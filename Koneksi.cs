using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankSampah
{
    public class Koneksi
    {
        private static string connString = @"Server=localhost;Database=db_banksampah;Integrated Security=True;TrustServerCertificate=True;";
        private static string connStringExpress = @"Server=.\SQLEXPRESS;Database=db_banksampah;Integrated Security=True;TrustServerCertificate=True;";
        
        private static string _activeConnectionString = null;
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
                            _activeConnectionString = cs.ConnectionString;
                        }
                    }
                    catch { }

                    if (string.IsNullOrEmpty(_activeConnectionString))
                    {
                        _activeConnectionString = connString;
                    }
                }
                return _activeConnectionString; 
            } 
            set { _activeConnectionString = value; } 
        }

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(ActiveConnectionString);
                conn.Open();
                return conn;
            }
            catch
            {
                if (ActiveConnectionString != connString)
                {
                    try
                    {
                        conn = new SqlConnection(connString);
                        conn.Open();
                        ActiveConnectionString = connString;
                        return conn;
                    }
                    catch { }
                }

                try
                {
                    conn = new SqlConnection(connStringExpress);
                    conn.Open();
                    ActiveConnectionString = connStringExpress;
                    return conn;
                }
                catch
                {
                    return null;
                }
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
