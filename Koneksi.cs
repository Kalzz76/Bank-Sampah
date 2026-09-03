using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankSampah
{
    public class Koneksi
    {
        private static string connString = @"Server=localhost;Database=db_banksampah;Integrated Security=True;TrustServerCertificate=True;";
        private static string connStringExpress = @"Server=.\SQLEXPRESS;Database=db_banksampah;Integrated Security=True;TrustServerCertificate=True;";
        
        private static string _activeConnectionString = connString;
        public static string ActiveConnectionString 
        { 
            get { return _activeConnectionString; } 
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
    }
}
