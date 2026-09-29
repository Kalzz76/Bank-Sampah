using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankSampah
{
    public class Koneksi
    {
        private static string connStringExpress = @"Server=.\SQLEXPRESS;Database=db_banksampah;Integrated Security=True;TrustServerCertificate=True;Connect Timeout=2;";
        private static string connStringLocalhost = @"Server=localhost;Database=db_banksampah;Integrated Security=True;TrustServerCertificate=True;Connect Timeout=2;";
        
        private static string _activeConnectionString = null;
        private static bool _isOfflineMode = false;
        private static DateTime _lastFailedCheck = DateTime.MinValue;
        private static readonly TimeSpan RecheckInterval = TimeSpan.FromSeconds(15);
        private static readonly object _syncLock = new object();

        public static bool IsOfflineMode
        {
            get { return _isOfflineMode; }
        }

        public static void ResetConnectionState()
        {
            lock (_syncLock)
            {
                _isOfflineMode = false;
                _lastFailedCheck = DateTime.MinValue;
            }
        }

        public static string ActiveConnectionString 
        { 
            get 
            { 
                if (string.IsNullOrEmpty(_activeConnectionString))
                {
                    try
                    {
                        var cs = ConfigurationManager.ConnectionStrings["DbBankSampah"];
                        if (cs != null && !string.IsNullOrWhiteSpace(cs.ConnectionString))
                        {
                            _activeConnectionString = EnsureConnectTimeout(cs.ConnectionString, 2);
                        }
                    }
                    catch { }

                    if (string.IsNullOrEmpty(_activeConnectionString))
                    {
                        _activeConnectionString = connStringExpress;
                    }
                }
                return _activeConnectionString; 
            } 
            set { _activeConnectionString = value; } 
        }

        private static string EnsureConnectTimeout(string cs, int timeoutSeconds = 2)
        {
            if (string.IsNullOrEmpty(cs)) return cs;
            if (!cs.ToLower().Contains("connect timeout") && !cs.ToLower().Contains("connection timeout"))
            {
                cs = cs.TrimEnd(';') + string.Format(";Connect Timeout={0};", timeoutSeconds);
            }
            return cs;
        }

        public static SqlConnection GetConnection()
        {
            lock (_syncLock)
            {
                // Jika sedang dalam mode offline dan belum melewati interval pengecekan ulang, langsung fallback ke in-memory tanpa lag
                if (_isOfflineMode && (DateTime.Now - _lastFailedCheck) < RecheckInterval)
                {
                    return null;
                }

                // Coba kandidat koneksi dengan timeout singkat (2 detik)
                string[] candidates = {
                    EnsureConnectTimeout(ActiveConnectionString, 2),
                    EnsureConnectTimeout(connStringExpress, 2),
                    EnsureConnectTimeout(connStringLocalhost, 2)
                };

                foreach (string candidate in candidates)
                {
                    if (string.IsNullOrWhiteSpace(candidate)) continue;
                    try
                    {
                        SqlConnection conn = new SqlConnection(candidate);
                        conn.Open();
                        _isOfflineMode = false;
                        _activeConnectionString = candidate;
                        return conn;
                    }
                    catch
                    {
                        // Coba kandidat berikutnya
                    }
                }

                // Jika semua kandidat gagal terhubung, aktifkan offline mode agar query-query berikutnya tidak freeze
                _isOfflineMode = true;
                _lastFailedCheck = DateTime.Now;
                return null;
            }
        }

        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                if (conn != null)
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            return dt;
        }

        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                if (conn != null)
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            return 0;
        }

        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                if (conn != null)
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        return cmd.ExecuteScalar();
                    }
                }
            }
            return null;
        }

        public static bool TestConnection()
        {
            using (SqlConnection conn = GetConnection())
            {
                return (conn != null && conn.State == ConnectionState.Open);
            }
        }

        public static bool BackupDatabase(string targetFilePath, out string message)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    if (conn == null)
                    {
                        message = "Koneksi database SQL Server tidak tersedia.";
                        return false;
                    }

                    string dir = System.IO.Path.GetDirectoryName(targetFilePath);
                    if (!string.IsNullOrEmpty(dir) && !System.IO.Directory.Exists(dir))
                    {
                        System.IO.Directory.CreateDirectory(dir);
                    }

                    string dbName = string.IsNullOrEmpty(conn.Database) ? "db_banksampah" : conn.Database;
                    string sql = string.Format("BACKUP DATABASE [{0}] TO DISK = @path WITH FORMAT, INIT, NAME = 'Full Backup of db_banksampah';", dbName);
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.CommandTimeout = 120;
                        cmd.Parameters.AddWithValue("@path", targetFilePath);
                        cmd.ExecuteNonQuery();
                    }

                    message = "Backup database berhasil disimpan di:\n" + targetFilePath;
                    return true;
                }
            }
            catch (Exception ex)
            {
                message = "Gagal melakukan backup database: " + ex.Message;
                return false;
            }
        }
    }
}
