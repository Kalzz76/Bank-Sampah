using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankSampah
{
    public static class DataStore
    {
        private static string _currentUsername = "admin";
        private static string _currentUserRole = "Admin";
        private static string _currentUserNama = "Administrator Utama";
        private static int _currentUserId = 1;

        public static string CurrentUsername
        {
            get { return _currentUsername; }
            set { _currentUsername = value; }
        }

        public static string CurrentUserRole
        {
            get { return _currentUserRole; }
            set { _currentUserRole = value; }
        }

        public static string CurrentUserNama
        {
            get { return _currentUserNama; }
            set { _currentUserNama = value; }
        }

        public static int CurrentUserId
        {
            get { return _currentUserId; }
            set { _currentUserId = value; }
        }

        private static DataTable dtUsers = new DataTable();
        private static DataTable dtNasabah = new DataTable();
        private static DataTable dtSampah = new DataTable();
        private static DataTable dtTransaksi = new DataTable();

        static DataStore()
        {
            InitializeInMemoryTables();
        }

        private static void InitializeInMemoryTables()
        {
            // Users
            dtUsers.Columns.Add("id_user", typeof(int));
            dtUsers.Columns.Add("username", typeof(string));
            dtUsers.Columns.Add("password", typeof(string));
            dtUsers.Columns.Add("nama_lengkap", typeof(string));
            dtUsers.Columns.Add("role", typeof(string));
            dtUsers.Rows.Add(1, "admin", "admin123", "Administrator Utama", "Admin");
            dtUsers.Rows.Add(2, "petugas", "petugas123", "Budi Santoso", "Petugas");

            // Nasabah
            dtNasabah.Columns.Add("id_nasabah", typeof(int));
            dtNasabah.Columns.Add("kode_nasabah", typeof(string));
            dtNasabah.Columns.Add("nama", typeof(string));
            dtNasabah.Columns.Add("alamat", typeof(string));
            dtNasabah.Columns.Add("no_hp", typeof(string));
            dtNasabah.Columns.Add("saldo", typeof(decimal));
            dtNasabah.Rows.Add(1, "NSB-001", "Ahmad Dahlan", "Jl. Soekarno Hatta No. 12", "081234567890", 45000.00m);
            dtNasabah.Rows.Add(2, "NSB-002", "Siti Nurhaliza", "Jl. Buah Batu No. 45", "082198765432", 28500.00m);
            dtNasabah.Rows.Add(3, "NSB-003", "Rudi Hermawan", "Jl. Kopo Cirangrang No. 88", "085712344321", 120000.00m);
            dtNasabah.Rows.Add(4, "NSB-004", "Dewi Sartika", "Jl. Merdeka No. 10", "081399887766", 85000.00m);
            dtNasabah.Rows.Add(5, "NSB-005", "Bambang Pamungkas", "Jl. Asia Afrika No. 50", "081211223344", 64000.00m);
            dtNasabah.Rows.Add(6, "NSB-006", "Maya Indah", "Jl. Dago No. 102", "085677889900", 35000.00m);
            dtNasabah.Rows.Add(7, "NSB-007", "Eko Prasetyo", "Jl. Cihampelas No. 34", "081900112233", 110000.00m);
            dtNasabah.Rows.Add(8, "NSB-008", "Rina Kusumawati", "Jl. Sunda No. 77", "082344556677", 52000.00m);

            // Sampah
            dtSampah.Columns.Add("id_sampah", typeof(int));
            dtSampah.Columns.Add("nama_sampah", typeof(string));
            dtSampah.Columns.Add("jenis_sampah", typeof(string));
            dtSampah.Columns.Add("kategori", typeof(string));
            dtSampah.Columns.Add("harga_per_kg", typeof(decimal));
            dtSampah.Columns.Add("foto", typeof(string));

            dtSampah.Rows.Add(1, "Botol Plastik PET Bersih", "Anorganik", "Plastik", 4500.00m, "botol_plastik.png");
            dtSampah.Rows.Add(2, "Kardus Bekas Tebal", "Anorganik", "Kertas", 2500.00m, "kardus.png");
            dtSampah.Rows.Add(3, "Besi Tua & Kaleng", "Anorganik", "Logam", 7000.00m, "besi_kaleng.png");
            dtSampah.Rows.Add(4, "Botol Kaca Bening", "Anorganik", "Kaca", 1500.00m, "botol_kaca.png");
            dtSampah.Rows.Add(5, "Kompos & Sisa Sayuran", "Organik", "Kompos & Sisa Dapur", 1000.00m, "organik_kompos.png");
            dtSampah.Rows.Add(6, "Baterai & Akumulator Bekas", "B3 (Berbahaya)", "Baterai & Akumulator", 12000.00m, "baterai_b3.png");
            dtSampah.Rows.Add(7, "Kertas HVS Bekas", "Anorganik", "Kertas", 3000.00m, "kertas_hvs.png");
            dtSampah.Rows.Add(8, "Plastik Gelas Minuman", "Anorganik", "Plastik", 3500.00m, "plastik_gelas.png");
            dtSampah.Rows.Add(9, "Minyak Jelantah Rumah Tangga", "Anorganik", "Minyak Jelantah", 6500.00m, "default_sampah.png");
            dtSampah.Rows.Add(10, "Kaleng Alumunium Minuman", "Anorganik", "Logam", 10000.00m, "default_sampah.png");
            dtSampah.Rows.Add(11, "Tembaga & Kabel Bekas", "Anorganik", "Logam", 45000.00m, "default_sampah.png");
            dtSampah.Rows.Add(12, "Lampu Neon TL Bekas", "B3 (Berbahaya)", "Lampu TL & Kaca B3", 5000.00m, "default_sampah.png");
            dtSampah.Rows.Add(13, "Daun & Sampah Kebun", "Organik", "Daun & Sampah Kebun", 800.00m, "default_sampah.png");
            dtSampah.Rows.Add(14, "Koran Bekas & Majalah", "Anorganik", "Kertas", 2800.00m, "default_sampah.png");

            // Transaksi
            dtTransaksi.Columns.Add("id_transaksi", typeof(int));
            dtTransaksi.Columns.Add("kode_transaksi", typeof(string));
            dtTransaksi.Columns.Add("id_nasabah", typeof(int));
            dtTransaksi.Columns.Add("nama_nasabah", typeof(string));
            dtTransaksi.Columns.Add("jenis_transaksi", typeof(string));
            dtTransaksi.Columns.Add("id_sampah", typeof(int));
            dtTransaksi.Columns.Add("nama_sampah", typeof(string));
            dtTransaksi.Columns.Add("berat_kg", typeof(decimal));
            dtTransaksi.Columns.Add("total_harga", typeof(decimal));
            dtTransaksi.Columns.Add("tanggal", typeof(DateTime));
            dtTransaksi.Columns.Add("petugas", typeof(string));
            dtTransaksi.Columns.Add("catatan", typeof(string));

            dtTransaksi.Rows.Add(1, "TRX-20260901-001", 1, "Ahmad Dahlan", "Setor", 1, "Botol Plastik PET Bersih", 10.00m, 45000.00m, DateTime.Now.AddDays(-2), "admin", "Setoran botol PET 10 Kg");
            dtTransaksi.Rows.Add(2, "TRX-20260901-002", 2, "Siti Nurhaliza", "Setor", 2, "Kardus Bekas Tebal", 11.40m, 28500.00m, DateTime.Now.AddDays(-1), "petugas", "Setoran kardus bekas 11.4 Kg");
            dtTransaksi.Rows.Add(3, "TRX-20260902-003", 3, "Rudi Hermawan", "Setor", 3, "Besi Tua & Kaleng", 17.14m, 120000.00m, DateTime.Now.AddDays(-1), "admin", "Setoran besi tua 17.14 Kg");
            dtTransaksi.Rows.Add(4, "TRX-20260902-004", 4, "Dewi Sartika", "Setor", 9, "Minyak Jelantah Rumah Tangga", 13.08m, 85000.00m, DateTime.Now.AddDays(-1), "petugas", "Setoran minyak jelantah 13.08 Kg");
            dtTransaksi.Rows.Add(5, "TRX-20260902-005", 5, "Bambang Pamungkas", "Setor", 10, "Kaleng Alumunium Minuman", 6.40m, 64000.00m, DateTime.Now, "admin", "Setoran kaleng alumunium 6.4 Kg");
            dtTransaksi.Rows.Add(6, "TRX-20260903-006", 7, "Eko Prasetyo", "Setor", 11, "Tembaga & Kabel Bekas", 2.44m, 110000.00m, DateTime.Now, "petugas", "Setoran kabel tembaga 2.44 Kg");
            dtTransaksi.Rows.Add(7, "TRX-20260903-007", 6, "Maya Indah", "Tarik", 0, "-", 0.00m, 25000.00m, DateTime.Now, "admin", "Penarikan saldo tunai di teller");
            dtTransaksi.Rows.Add(8, "TRX-20260903-008", 8, "Rina Kusumawati", "Setor", 14, "Koran Bekas & Majalah", 18.57m, 52000.00m, DateTime.Now, "petugas", "Setoran koran bekas 18.57 Kg");
        }

        public static bool Login(string username, string password)
        {
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@u", username),
                    new SqlParameter("@p", password)
                };
                DataTable dt = Koneksi.ExecuteQuery("SELECT * FROM tb_user WHERE username=@u AND password=@p", p);
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    CurrentUserId = Convert.ToInt32(r["id_user"]);
                    CurrentUsername = r["username"].ToString();
                    CurrentUserNama = r["nama_lengkap"].ToString();
                    CurrentUserRole = r["role"].ToString();
                    return true;
                }
            }
            catch { }

            string uClean = username.Replace("'", "''");
            string pClean = password.Replace("'", "''");
            DataRow[] found = dtUsers.Select(string.Format("username='{0}' AND password='{1}'", uClean, pClean));
            if (found.Length > 0)
            {
                DataRow r = found[0];
                CurrentUserId = Convert.ToInt32(r["id_user"]);
                CurrentUsername = r["username"].ToString();
                CurrentUserNama = r["nama_lengkap"].ToString();
                CurrentUserRole = r["role"].ToString();
                return true;
            }

            return false;
        }

        public static DataTable GetNasabah()
        {
            try
            {
                DataTable dt = Koneksi.ExecuteQuery("SELECT * FROM tb_nasabah ORDER BY id_nasabah DESC");
                if (dt != null && dt.Rows.Count > 0) return dt;
            }
            catch { }
            return dtNasabah;
        }

        public static void AddNasabah(string kode, string nama, string alamat, string noHp, decimal saldo)
        {
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@k", kode),
                    new SqlParameter("@n", nama),
                    new SqlParameter("@a", alamat),
                    new SqlParameter("@h", noHp),
                    new SqlParameter("@s", saldo)
                };
                Koneksi.ExecuteNonQuery("INSERT INTO tb_nasabah (kode_nasabah, nama, alamat, no_hp, saldo) VALUES (@k, @n, @a, @h, @s)", p);
            }
            catch { }

            int newId = dtNasabah.Rows.Count + 1;
            dtNasabah.Rows.Add(newId, kode, nama, alamat, noHp, saldo);
        }

        public static void UpdateNasabah(int id, string kode, string nama, string alamat, string noHp)
        {
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@id", id),
                    new SqlParameter("@k", kode),
                    new SqlParameter("@n", nama),
                    new SqlParameter("@a", alamat),
                    new SqlParameter("@h", noHp)
                };
                Koneksi.ExecuteNonQuery("UPDATE tb_nasabah SET kode_nasabah=@k, nama=@n, alamat=@a, no_hp=@h WHERE id_nasabah=@id", p);
            }
            catch { }

            DataRow[] rows = dtNasabah.Select(string.Format("id_nasabah={0}", id));
            if (rows.Length > 0)
            {
                rows[0]["kode_nasabah"] = kode;
                rows[0]["nama"] = nama;
                rows[0]["alamat"] = alamat;
                rows[0]["no_hp"] = noHp;
            }
        }

        public static void DeleteNasabah(int id)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@id", id) };
                Koneksi.ExecuteNonQuery("DELETE FROM tb_nasabah WHERE id_nasabah=@id", p);
            }
            catch { }

            DataRow[] rows = dtNasabah.Select(string.Format("id_nasabah={0}", id));
            if (rows.Length > 0) dtNasabah.Rows.Remove(rows[0]);
        }

        public static DataTable GetSampah()
        {
            try
            {
                DataTable dt = Koneksi.ExecuteQuery("SELECT * FROM tb_sampah ORDER BY id_sampah DESC");
                if (dt != null && dt.Rows.Count > 0) return dt;
            }
            catch { }
            return dtSampah;
        }

        public static void AddSampah(string nama, string jenis, string kategori, decimal harga, string foto)
        {
            string fotoFile = string.IsNullOrWhiteSpace(foto) ? "default_sampah.png" : foto;
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@n", nama),
                    new SqlParameter("@j", jenis),
                    new SqlParameter("@k", kategori),
                    new SqlParameter("@h", harga),
                    new SqlParameter("@f", fotoFile)
                };
                Koneksi.ExecuteNonQuery("INSERT INTO tb_sampah (nama_sampah, jenis_sampah, kategori, harga_per_kg, foto) VALUES (@n, @j, @k, @h, @f)", p);
            }
            catch { }

            int newId = dtSampah.Rows.Count + 1;
            dtSampah.Rows.Add(newId, nama, jenis, kategori, harga, fotoFile);
        }

        public static void UpdateSampah(int id, string nama, string jenis, string kategori, decimal harga, string foto)
        {
            string fotoFile = string.IsNullOrWhiteSpace(foto) ? "default_sampah.png" : foto;
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@id", id),
                    new SqlParameter("@n", nama),
                    new SqlParameter("@j", jenis),
                    new SqlParameter("@k", kategori),
                    new SqlParameter("@h", harga),
                    new SqlParameter("@f", fotoFile)
                };
                Koneksi.ExecuteNonQuery("UPDATE tb_sampah SET nama_sampah=@n, jenis_sampah=@j, kategori=@k, harga_per_kg=@h, foto=@f WHERE id_sampah=@id", p);
            }
            catch { }

            DataRow[] rows = dtSampah.Select(string.Format("id_sampah={0}", id));
            if (rows.Length > 0)
            {
                rows[0]["nama_sampah"] = nama;
                rows[0]["jenis_sampah"] = jenis;
                rows[0]["kategori"] = kategori;
                rows[0]["harga_per_kg"] = harga;
                rows[0]["foto"] = fotoFile;
            }
        }

        public static void DeleteSampah(int id)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@id", id) };
                Koneksi.ExecuteNonQuery("DELETE FROM tb_sampah WHERE id_sampah=@id", p);
            }
            catch { }

            DataRow[] rows = dtSampah.Select(string.Format("id_sampah={0}", id));
            if (rows.Length > 0) dtSampah.Rows.Remove(rows[0]);
        }

        public static DataTable GetTransaksi()
        {
            try
            {
                string sql = @"SELECT t.id_transaksi, t.kode_transaksi, t.id_nasabah, n.nama AS nama_nasabah, 
                                       t.jenis_transaksi, t.id_sampah, s.nama_sampah, t.berat_kg, t.total_harga, 
                                       t.tanggal, u.username AS petugas, t.catatan 
                                FROM tb_transaksi t 
                                LEFT JOIN tb_nasabah n ON t.id_nasabah = n.id_nasabah 
                                LEFT JOIN tb_sampah s ON t.id_sampah = s.id_sampah 
                                LEFT JOIN tb_user u ON t.id_user = u.id_user 
                                ORDER BY t.id_transaksi DESC";
                DataTable dt = Koneksi.ExecuteQuery(sql);
                if (dt != null && dt.Rows.Count > 0) return dt;
            }
            catch { }
            return dtTransaksi;
        }

        public static void AddTransaksi(string kode, int idNasabah, string namaNasabah, string jenis, int? idSampah, string namaSampah, decimal berat, decimal total, string catatan)
        {
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@k", kode),
                    new SqlParameter("@in", idNasabah),
                    new SqlParameter("@j", jenis),
                    new SqlParameter("@is", (object)idSampah ?? DBNull.Value),
                    new SqlParameter("@b", berat),
                    new SqlParameter("@t", total),
                    new SqlParameter("@iu", CurrentUserId),
                    new SqlParameter("@c", catatan)
                };
                Koneksi.ExecuteNonQuery(@"INSERT INTO tb_transaksi (kode_transaksi, id_nasabah, jenis_transaksi, id_sampah, berat_kg, total_harga, id_user, catatan) 
                                           VALUES (@k, @in, @j, @is, @b, @t, @iu, @c)", p);

                decimal change = (jenis == "Setor") ? total : -total;
                SqlParameter[] p2 = { new SqlParameter("@id", idNasabah), new SqlParameter("@val", change) };
                Koneksi.ExecuteNonQuery("UPDATE tb_nasabah SET saldo = saldo + @val WHERE id_nasabah=@id", p2);
            }
            catch { }

            int newId = dtTransaksi.Rows.Count + 1;
            dtTransaksi.Rows.Add(newId, kode, idNasabah, namaNasabah, jenis, idSampah ?? 0, namaSampah, berat, total, DateTime.Now, CurrentUsername, catatan);

            DataRow[] rows = dtNasabah.Select(string.Format("id_nasabah={0}", idNasabah));
            if (rows.Length > 0)
            {
                decimal cur = Convert.ToDecimal(rows[0]["saldo"]);
                rows[0]["saldo"] = (jenis == "Setor") ? cur + total : cur - total;
            }
        }

        public static void AddTransaksiSetor(string kodeNasabah, int idSampah, decimal berat, decimal totalHarga, string catatan)
        {
            int idNasabah = 1;
            string namaNasabah = "Nasabah";
            DataRow[] nRows = dtNasabah.Select(string.Format("kode_nasabah='{0}'", kodeNasabah));
            if (nRows.Length > 0)
            {
                idNasabah = Convert.ToInt32(nRows[0]["id_nasabah"]);
                namaNasabah = nRows[0]["nama"].ToString();
            }

            string namaSampah = "Sampah";
            DataRow[] sRows = dtSampah.Select(string.Format("id_sampah={0}", idSampah));
            if (sRows.Length > 0)
            {
                namaSampah = sRows[0]["nama_sampah"].ToString();
            }

            string kodeTrx = "TRX-" + DateTime.Now.ToString("yyyyMMdd") + "-" + (dtTransaksi.Rows.Count + 1).ToString("D3");
            AddTransaksi(kodeTrx, idNasabah, namaNasabah, "Setor", idSampah, namaSampah, berat, totalHarga, catatan);
        }

        public static void AddTransaksiTarik(string kodeNasabah, decimal nominal, string catatan)
        {
            int idNasabah = 1;
            string namaNasabah = "Nasabah";
            DataRow[] nRows = dtNasabah.Select(string.Format("kode_nasabah='{0}'", kodeNasabah));
            if (nRows.Length > 0)
            {
                idNasabah = Convert.ToInt32(nRows[0]["id_nasabah"]);
                namaNasabah = nRows[0]["nama"].ToString();
            }

            string kodeTrx = "TRX-" + DateTime.Now.ToString("yyyyMMdd") + "-" + (dtTransaksi.Rows.Count + 1).ToString("D3");
            AddTransaksi(kodeTrx, idNasabah, namaNasabah, "Tarik", null, "-", 0, nominal, catatan);
        }

        public static DataTable GetUsers()
        {
            try
            {
                DataTable dt = Koneksi.ExecuteQuery("SELECT id_user, username, nama_lengkap, role FROM tb_user ORDER BY id_user DESC");
                if (dt != null && dt.Rows.Count > 0) return dt;
            }
            catch { }
            return dtUsers;
        }

        public static DataTable GetUser()
        {
            return GetUsers();
        }

        public static void AddUser(string username, string password, string nama, string role)
        {
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@u", username),
                    new SqlParameter("@p", password),
                    new SqlParameter("@n", nama),
                    new SqlParameter("@r", role)
                };
                Koneksi.ExecuteNonQuery("INSERT INTO tb_user (username, password, nama_lengkap, role) VALUES (@u, @p, @n, @r)", p);
            }
            catch { }

            int newId = dtUsers.Rows.Count + 1;
            dtUsers.Rows.Add(newId, username, password, nama, role);
        }

        public static void DeleteUser(int id)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@id", id) };
                Koneksi.ExecuteNonQuery("DELETE FROM tb_user WHERE id_user=@id", p);
            }
            catch { }

            DataRow[] rows = dtUsers.Select(string.Format("id_user={0}", id));
            if (rows.Length > 0) dtUsers.Rows.Remove(rows[0]);
        }
    }
}
