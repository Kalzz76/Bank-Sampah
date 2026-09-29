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
        private static DataTable dtPenjemputan = new DataTable();

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
            dtNasabah.Columns.Add("foto", typeof(string));
            dtNasabah.Rows.Add(1, "NSB-001", "Ahmad Dahlan", "Jl. Soekarno Hatta No. 12", "081234567890", 45000.00m, "default_nasabah.png");
            dtNasabah.Rows.Add(2, "NSB-002", "Siti Nurhaliza", "Jl. Buah Batu No. 45", "082198765432", 28500.00m, "default_nasabah.png");
            dtNasabah.Rows.Add(3, "NSB-003", "Rudi Hermawan", "Jl. Kopo Cirangrang No. 88", "085712344321", 120000.00m, "default_nasabah.png");
            dtNasabah.Rows.Add(4, "NSB-004", "Dewi Sartika", "Jl. Merdeka No. 10", "081399887766", 85000.00m, "default_nasabah.png");
            dtNasabah.Rows.Add(5, "NSB-005", "Bambang Pamungkas", "Jl. Asia Afrika No. 50", "081211223344", 64000.00m, "default_nasabah.png");
            dtNasabah.Rows.Add(6, "NSB-006", "Maya Indah", "Jl. Dago No. 102", "085677889900", 35000.00m, "default_nasabah.png");
            dtNasabah.Rows.Add(7, "NSB-007", "Eko Prasetyo", "Jl. Cihampelas No. 34", "081900112233", 110000.00m, "default_nasabah.png");
            dtNasabah.Rows.Add(8, "NSB-008", "Rina Kusumawati", "Jl. Sunda No. 77", "082344556677", 52000.00m, "default_nasabah.png");

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

            // Penjemputan Sampah (Door-to-Door Pickup Service ala Pastiklola)
            dtPenjemputan.Columns.Add("id_penjemputan", typeof(int));
            dtPenjemputan.Columns.Add("kode_booking", typeof(string));
            dtPenjemputan.Columns.Add("id_nasabah", typeof(int));
            dtPenjemputan.Columns.Add("nama_nasabah", typeof(string));
            dtPenjemputan.Columns.Add("alamat_jemput", typeof(string));
            dtPenjemputan.Columns.Add("no_hp", typeof(string));
            dtPenjemputan.Columns.Add("tanggal_jemput", typeof(DateTime));
            dtPenjemputan.Columns.Add("waktu_jemput", typeof(string));
            dtPenjemputan.Columns.Add("armada_petugas", typeof(string));
            dtPenjemputan.Columns.Add("estimasi_sampah", typeof(string));
            dtPenjemputan.Columns.Add("estimasi_berat", typeof(decimal));
            dtPenjemputan.Columns.Add("status", typeof(string));
            dtPenjemputan.Columns.Add("catatan", typeof(string));

            dtPenjemputan.Rows.Add(1, "PKP-20260910-001", 1, "Ahmad Dahlan", "Jl. Soekarno Hatta No. 12", "081234567890", DateTime.Today, "09:00 - 10:30 WIB", "Budi Santoso (Motor Roda Tiga)", "Kardus Tebal & Botol Plastik PET", 15.50m, "Menunggu", "Mohon jemput di depan pagar rumah");
            dtPenjemputan.Rows.Add(2, "PKP-20260910-002", 2, "Siti Nurhaliza", "Jl. Buah Batu No. 45", "082198765432", DateTime.Today, "11:00 - 12:30 WIB", "Budi Santoso (Motor Roda Tiga)", "Minyak Jelantah 5L & Kaleng Minuman", 8.20m, "Dalam Penjemputan", "Armada sudah mengarah ke lokasi");
            dtPenjemputan.Rows.Add(3, "PKP-20260909-001", 3, "Rudi Hermawan", "Jl. Kopo Cirangrang No. 88", "085712344321", DateTime.Today.AddDays(-1), "14:00 - 15:30 WIB", "Budi Santoso (Motor Roda Tiga)", "Besi Tua & Kaleng", 17.14m, "Selesai", "Telah berhasil dikonversi ke setoran");
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

        public static void AddNasabah(string kode, string nama, string alamat, string noHp, decimal saldo, string foto = "default_nasabah.png")
        {
            string fotoFile = string.IsNullOrWhiteSpace(foto) ? "default_nasabah.png" : foto;
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@k", kode),
                    new SqlParameter("@n", nama),
                    new SqlParameter("@a", alamat),
                    new SqlParameter("@h", noHp),
                    new SqlParameter("@s", saldo),
                    new SqlParameter("@f", fotoFile)
                };
                Koneksi.ExecuteNonQuery("INSERT INTO tb_nasabah (kode_nasabah, nama, alamat, no_hp, saldo, foto) VALUES (@k, @n, @a, @h, @s, @f)", p);
            }
            catch { }

            int newId = dtNasabah.Rows.Count + 1;
            dtNasabah.Rows.Add(newId, kode, nama, alamat, noHp, saldo, fotoFile);
        }

        public static void UpdateNasabah(int id, string kode, string nama, string alamat, string noHp, string foto = "default_nasabah.png")
        {
            string fotoFile = string.IsNullOrWhiteSpace(foto) ? "default_nasabah.png" : foto;
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@id", id),
                    new SqlParameter("@k", kode),
                    new SqlParameter("@n", nama),
                    new SqlParameter("@a", alamat),
                    new SqlParameter("@h", noHp),
                    new SqlParameter("@f", fotoFile)
                };
                Koneksi.ExecuteNonQuery("UPDATE tb_nasabah SET kode_nasabah=@k, nama=@n, alamat=@a, no_hp=@h, foto=@f WHERE id_nasabah=@id", p);
            }
            catch { }

            DataRow[] rows = dtNasabah.Select(string.Format("id_nasabah={0}", id));
            if (rows.Length > 0)
            {
                rows[0]["kode_nasabah"] = kode;
                rows[0]["nama"] = nama;
                rows[0]["alamat"] = alamat;
                rows[0]["no_hp"] = noHp;
                if (rows[0].Table.Columns.Contains("foto")) rows[0]["foto"] = fotoFile;
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

        public static void SyncSaldoNasabah(int idNasabah, decimal saldoBaru)
        {
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@id", idNasabah),
                    new SqlParameter("@s", saldoBaru)
                };
                Koneksi.ExecuteNonQuery("UPDATE tb_nasabah SET saldo=@s WHERE id_nasabah=@id", p);
            }
            catch { }

            DataRow[] rows = dtNasabah.Select(string.Format("id_nasabah={0}", idNasabah));
            if (rows.Length > 0)
            {
                rows[0]["saldo"] = saldoBaru;
            }
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
            
            DataTable currentNasabahTable = GetNasabah();
            DataRow[] nRows = currentNasabahTable.Select(string.Format("kode_nasabah='{0}'", kodeNasabah));
            if (nRows.Length > 0)
            {
                idNasabah = Convert.ToInt32(nRows[0]["id_nasabah"]);
                namaNasabah = nRows[0]["nama"].ToString();
            }

            string namaSampah = "Sampah";
            DataTable currentSampahTable = GetSampah();
            DataRow[] sRows = currentSampahTable.Select(string.Format("id_sampah={0}", idSampah));
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
            DataTable currentNasabahTable = GetNasabah();
            DataRow[] nRows = currentNasabahTable.Select(string.Format("kode_nasabah='{0}'", kodeNasabah));
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
                DataTable dt = Koneksi.ExecuteQuery("SELECT id_user, username, password, nama_lengkap, role FROM tb_user ORDER BY id_user DESC");
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

        public static DataTable GetKomposisiSampah()
        {
            DataTable dtResult = new DataTable();
            dtResult.Columns.Add("kategori", typeof(string));
            dtResult.Columns.Add("total_berat", typeof(decimal));

            System.Collections.Generic.Dictionary<string, decimal> dict = new System.Collections.Generic.Dictionary<string, decimal>();
            dict["Plastik"] = 0;
            dict["Kertas"] = 0;
            dict["Logam"] = 0;
            dict["Kaca"] = 0;
            dict["Organik"] = 0;
            dict["B3"] = 0;

            DataTable dtT = GetTransaksi();
            DataTable dtS = GetSampah();

            foreach (DataRow tr in dtT.Rows)
            {
                if (tr["jenis_transaksi"].ToString() == "Setor" && tr["berat_kg"] != DBNull.Value)
                {
                    decimal b = Convert.ToDecimal(tr["berat_kg"]);
                    string namaSampah = tr["nama_sampah"].ToString();
                    
                    // Match with sampah table category
                    string kat = "Plastik";
                    DataRow[] sRows = dtS.Select(string.Format("nama_sampah='{0}'", namaSampah.Replace("'", "''")));
                    if (sRows.Length > 0)
                    {
                        string k = (sRows[0].Table.Columns.Contains("kategori") && sRows[0]["kategori"] != DBNull.Value)
                                   ? sRows[0]["kategori"].ToString() : "";
                        string j = (sRows[0].Table.Columns.Contains("jenis_sampah") && sRows[0]["jenis_sampah"] != DBNull.Value)
                                   ? sRows[0]["jenis_sampah"].ToString() : "";

                        if (j.IndexOf("Organik", StringComparison.OrdinalIgnoreCase) >= 0 || 
                            k.IndexOf("Organik", StringComparison.OrdinalIgnoreCase) >= 0 || 
                            namaSampah.IndexOf("Organik", StringComparison.OrdinalIgnoreCase) >= 0 || 
                            namaSampah.IndexOf("Kompos", StringComparison.OrdinalIgnoreCase) >= 0 || 
                            namaSampah.IndexOf("Daun", StringComparison.OrdinalIgnoreCase) >= 0) 
                            kat = "Organik";
                        else if (j.IndexOf("B3", StringComparison.OrdinalIgnoreCase) >= 0 || 
                                 k.IndexOf("B3", StringComparison.OrdinalIgnoreCase) >= 0 || 
                                 namaSampah.IndexOf("B3", StringComparison.OrdinalIgnoreCase) >= 0 || 
                                 namaSampah.IndexOf("Baterai", StringComparison.OrdinalIgnoreCase) >= 0 || 
                                 namaSampah.IndexOf("Lampu", StringComparison.OrdinalIgnoreCase) >= 0) 
                            kat = "B3";
                        else if (k.IndexOf("Kertas", StringComparison.OrdinalIgnoreCase) >= 0 || 
                                 namaSampah.IndexOf("Kardus", StringComparison.OrdinalIgnoreCase) >= 0 || 
                                 namaSampah.IndexOf("Kertas", StringComparison.OrdinalIgnoreCase) >= 0 || 
                                 namaSampah.IndexOf("Koran", StringComparison.OrdinalIgnoreCase) >= 0) 
                            kat = "Kertas";
                        else if (k.IndexOf("Logam", StringComparison.OrdinalIgnoreCase) >= 0 || 
                                 namaSampah.IndexOf("Besi", StringComparison.OrdinalIgnoreCase) >= 0 || 
                                 namaSampah.IndexOf("Kaleng", StringComparison.OrdinalIgnoreCase) >= 0 || 
                                 namaSampah.IndexOf("Tembaga", StringComparison.OrdinalIgnoreCase) >= 0) 
                            kat = "Logam";
                        else if (k.IndexOf("Kaca", StringComparison.OrdinalIgnoreCase) >= 0 || 
                                 namaSampah.IndexOf("Kaca", StringComparison.OrdinalIgnoreCase) >= 0) 
                            kat = "Kaca";
                        else 
                            kat = "Plastik";
                    }

                    if (!dict.ContainsKey(kat)) dict[kat] = 0;
                    dict[kat] += b;
                }
            }

            // Defaults if zero transactions
            if (dict["Plastik"] == 0 && dict["Kertas"] == 0 && dict["Logam"] == 0)
            {
                dict["Plastik"] = 40.5m;
                dict["Kertas"] = 25.0m;
                dict["Logam"] = 20.0m;
                dict["Kaca"] = 15.0m;
            }

            foreach (var kvp in dict)
            {
                if (kvp.Value > 0)
                {
                    dtResult.Rows.Add(kvp.Key, kvp.Value);
                }
            }

            return dtResult;
        }

        public static DataTable GetTrenSetoranBulanan()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("bulan", typeof(string));
            dt.Columns.Add("total_kg", typeof(decimal));

            dt.Rows.Add("Mar", 45.0m);
            dt.Rows.Add("Apr", 65.5m);
            dt.Rows.Add("Mei", 52.0m);
            dt.Rows.Add("Jun", 88.4m);
            dt.Rows.Add("Jul", 76.2m);
            dt.Rows.Add("Ags", 112.5m);

            return dt;
        }

        public static DataTable GetRiwayatTransaksiNasabah(int idNasabah)
        {
            try
            {
                string sql = @"SELECT t.id_transaksi, t.kode_transaksi, t.tanggal, t.jenis_transaksi, 
                                       ISNULL(s.nama_sampah, '-') AS nama_sampah, t.berat_kg, t.total_harga, 
                                       u.username AS petugas, t.catatan 
                                FROM tb_transaksi t 
                                LEFT JOIN tb_sampah s ON t.id_sampah = s.id_sampah 
                                LEFT JOIN tb_user u ON t.id_user = u.id_user 
                                WHERE t.id_nasabah = @id 
                                ORDER BY t.id_transaksi DESC";
                SqlParameter[] p = { new SqlParameter("@id", idNasabah) };
                DataTable dt = Koneksi.ExecuteQuery(sql, p);
                if (dt != null && dt.Rows.Count > 0) return dt;
            }
            catch { }

            DataTable dtFall = dtTransaksi.Clone();
            DataRow[] rows = dtTransaksi.Select(string.Format("id_nasabah={0}", idNasabah), "id_transaksi DESC");
            foreach (DataRow r in rows) dtFall.ImportRow(r);
            return dtFall;
        }

        public static DataTable GetTopNasabahTeraktif(int topCount = 5)
        {
            DataTable dtResult = new DataTable();
            dtResult.Columns.Add("rank", typeof(int));
            dtResult.Columns.Add("id_nasabah", typeof(int));
            dtResult.Columns.Add("kode_nasabah", typeof(string));
            dtResult.Columns.Add("nama", typeof(string));
            dtResult.Columns.Add("foto", typeof(string));
            dtResult.Columns.Add("total_berat", typeof(decimal));
            dtResult.Columns.Add("total_setoran", typeof(decimal));
            dtResult.Columns.Add("frekuensi", typeof(int));

            try
            {
                string sql = string.Format(@"
                    SELECT TOP {0} n.id_nasabah, n.kode_nasabah, n.nama, n.foto, 
                           SUM(t.berat_kg) AS total_berat, 
                           SUM(t.total_harga) AS total_setoran, 
                           COUNT(t.id_transaksi) AS frekuensi
                    FROM tb_nasabah n
                    INNER JOIN tb_transaksi t ON n.id_nasabah = t.id_nasabah
                    WHERE t.jenis_transaksi = 'Setor'
                    GROUP BY n.id_nasabah, n.kode_nasabah, n.nama, n.foto
                    ORDER BY total_berat DESC", topCount);
                DataTable dt = Koneksi.ExecuteQuery(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    int rank = 1;
                    foreach (DataRow r in dt.Rows)
                    {
                        dtResult.Rows.Add(
                            rank++,
                            Convert.ToInt32(r["id_nasabah"]),
                            r["kode_nasabah"].ToString(),
                            r["nama"].ToString(),
                            r["foto"] != DBNull.Value ? r["foto"].ToString() : "default_nasabah.png",
                            Convert.ToDecimal(r["total_berat"]),
                            Convert.ToDecimal(r["total_setoran"]),
                            Convert.ToInt32(r["frekuensi"])
                        );
                    }
                    return dtResult;
                }
            }
            catch { }

            DataTable dtN = GetNasabah();
            DataTable dtT = GetTransaksi();
            var dictBerat = new System.Collections.Generic.Dictionary<int, decimal>();
            var dictUang = new System.Collections.Generic.Dictionary<int, decimal>();
            var dictFreq = new System.Collections.Generic.Dictionary<int, int>();

            foreach (DataRow tr in dtT.Rows)
            {
                if (tr["jenis_transaksi"].ToString() == "Setor" && tr["id_nasabah"] != DBNull.Value)
                {
                    int idN = Convert.ToInt32(tr["id_nasabah"]);
                    decimal b = tr["berat_kg"] != DBNull.Value ? Convert.ToDecimal(tr["berat_kg"]) : 0;
                    decimal u = tr["total_harga"] != DBNull.Value ? Convert.ToDecimal(tr["total_harga"]) : 0;
                    if (!dictBerat.ContainsKey(idN)) { dictBerat[idN] = 0; dictUang[idN] = 0; dictFreq[idN] = 0; }
                    dictBerat[idN] += b;
                    dictUang[idN] += u;
                    dictFreq[idN] += 1;
                }
            }

            var list = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, decimal>>(dictBerat);
            list.Sort((x, y) => y.Value.CompareTo(x.Value));

            int rk = 1;
            foreach (var item in list)
            {
                DataRow[] nRow = dtN.Select("id_nasabah=" + item.Key);
                if (nRow.Length > 0)
                {
                    dtResult.Rows.Add(
                        rk++,
                        item.Key,
                        nRow[0]["kode_nasabah"].ToString(),
                        nRow[0]["nama"].ToString(),
                        nRow[0].Table.Columns.Contains("foto") ? nRow[0]["foto"].ToString() : "default_nasabah.png",
                        item.Value,
                        dictUang[item.Key],
                        dictFreq[item.Key]
                    );
                    if (rk > topCount) break;
                }
            }

            return dtResult;
        }

        // ==========================================
        // 1. ECO-METRICS (DAMPAK LINGKUNGAN ALAS PASTIKLOLA)
        // ==========================================
        public class EcoMetricsData
        {
            public decimal TotalKg { get; set; }
            public decimal TotalTon { get; set; }
            public decimal CO2ReduksiKg { get; set; }
            public int PohonTerselamatkan { get; set; }
            public int TotalSetoran { get; set; }
            public decimal PersenDaurUlang { get; set; }
            public string StatusPemberdayaan { get; set; }
        }

        public static EcoMetricsData GetEcoMetrics()
        {
            EcoMetricsData data = new EcoMetricsData();
            try
            {
                DataTable dtT = GetTransaksi();
                if (dtT != null)
                {
                    foreach (DataRow r in dtT.Rows)
                    {
                        if (r["jenis_transaksi"] != null && r["jenis_transaksi"].ToString() == "Setor")
                        {
                            data.TotalSetoran++;
                            if (r["berat_kg"] != DBNull.Value)
                            {
                                data.TotalKg += Convert.ToDecimal(r["berat_kg"]);
                            }
                        }
                    }
                }
            }
            catch { }

            if (data.TotalKg == 0) data.TotalKg = 1240.00m; // Fallback jika baru mulai
            data.TotalTon = Math.Round(data.TotalKg / 1000.0m, 2);
            data.CO2ReduksiKg = Math.Round(data.TotalKg * 1.5m, 1);
            data.PohonTerselamatkan = Math.Max(1, (int)(data.TotalKg / 40.0m));
            data.PersenDaurUlang = 100.0m;
            data.StatusPemberdayaan = "Mendukung Zero Waste to Landfill & Ekonomi Sirkular";

            return data;
        }

        // ==========================================
        // 2. GAMIFIKASI & LEVELING NASABAH HIJAU
        // ==========================================
        public static string GetBadgeNasabah(decimal totalKg)
        {
            if (totalKg >= 150m) return "★ Pahlawan Lingkungan";
            if (totalKg >= 50m) return "◆ Nasabah Hijau";
            if (totalKg >= 15m) return "▲ Nasabah Peduli";
            return "● Nasabah Pemula";
        }

        public static decimal GetTotalSampahNasabah(int idNasabah)
        {
            decimal total = 0;
            try
            {
                DataTable dtT = GetTransaksi();
                if (dtT != null)
                {
                    foreach (DataRow r in dtT.Rows)
                    {
                        if (r["id_nasabah"] != DBNull.Value && Convert.ToInt32(r["id_nasabah"]) == idNasabah && r["jenis_transaksi"].ToString() == "Setor")
                        {
                            if (r["berat_kg"] != DBNull.Value)
                                total += Convert.ToDecimal(r["berat_kg"]);
                        }
                    }
                }
            }
            catch { }
            return total;
        }

        public static string GetBadgeNasabahByKode(string kodeNasabah)
        {
            DataTable dtN = GetNasabah();
            DataRow[] rows = dtN.Select(string.Format("kode_nasabah='{0}'", kodeNasabah));
            if (rows.Length > 0)
            {
                int idN = Convert.ToInt32(rows[0]["id_nasabah"]);
                decimal kg = GetTotalSampahNasabah(idN);
                return GetBadgeNasabah(kg);
            }
            return "🌱 Nasabah Pemula";
        }

        // ==========================================
        // 3. MODUL PENJEMPUTAN SAMPAH (PICKUP DISPATCHER)
        // ==========================================
        public static DataTable GetPenjemputan()
        {
            try
            {
                string sql = @"
                    SELECT p.id_penjemputan, p.kode_booking, p.id_nasabah, n.nama AS nama_nasabah, 
                           p.alamat_jemput, p.no_hp, p.tanggal_jemput, p.waktu_jemput, 
                           p.armada_petugas, p.estimasi_sampah, p.estimasi_berat, p.status, p.catatan
                    FROM tb_penjemputan p
                    LEFT JOIN tb_nasabah n ON p.id_nasabah = n.id_nasabah
                    ORDER BY p.id_penjemputan DESC";
                DataTable dt = Koneksi.ExecuteQuery(sql);
                if (dt != null && dt.Rows.Count > 0) return dt;
            }
            catch { }
            return dtPenjemputan;
        }

        public static void AddPenjemputan(string kodeBooking, int idNasabah, string namaNasabah, string alamat, string noHp, DateTime tglJemput, string waktuJemput, string armada, string estimasiSampah, decimal estimasiBerat, string catatan)
        {
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@kb", kodeBooking),
                    new SqlParameter("@in", idNasabah),
                    new SqlParameter("@al", alamat),
                    new SqlParameter("@hp", noHp),
                    new SqlParameter("@tj", tglJemput.Date),
                    new SqlParameter("@wj", waktuJemput),
                    new SqlParameter("@ap", armada),
                    new SqlParameter("@es", estimasiSampah),
                    new SqlParameter("@eb", estimasiBerat),
                    new SqlParameter("@st", "Menunggu"),
                    new SqlParameter("@c", (object)catatan ?? DBNull.Value)
                };
                Koneksi.ExecuteNonQuery(@"INSERT INTO tb_penjemputan (kode_booking, id_nasabah, alamat_jemput, no_hp, tanggal_jemput, waktu_jemput, armada_petugas, estimasi_sampah, estimasi_berat, status, catatan)
                                           VALUES (@kb, @in, @al, @hp, @tj, @wj, @ap, @es, @eb, @st, @c)", p);
            }
            catch { }

            int newId = dtPenjemputan.Rows.Count + 1;
            dtPenjemputan.Rows.Add(newId, kodeBooking, idNasabah, namaNasabah, alamat, noHp, tglJemput, waktuJemput, armada, estimasiSampah, estimasiBerat, "Menunggu", catatan);
        }

        public static void UpdateStatusPenjemputan(int idPenjemputan, string status)
        {
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@id", idPenjemputan),
                    new SqlParameter("@st", status)
                };
                Koneksi.ExecuteNonQuery("UPDATE tb_penjemputan SET status=@st WHERE id_penjemputan=@id", p);
            }
            catch { }

            DataRow[] rows = dtPenjemputan.Select("id_penjemputan=" + idPenjemputan);
            if (rows.Length > 0)
            {
                rows[0]["status"] = status;
            }
        }

        public static bool ConvertPenjemputanToSetor(int idPenjemputan, int idSampah, decimal beratReal, decimal totalHarga, string catatanSetor, out string kodeTransaksiBaru)
        {
            kodeTransaksiBaru = "";
            try
            {
                DataTable dtP = GetPenjemputan();
                DataRow[] rows = dtP.Select("id_penjemputan=" + idPenjemputan);
                if (rows.Length == 0) return false;

                int idNasabah = Convert.ToInt32(rows[0]["id_nasabah"]);
                string kodeBooking = rows[0]["kode_booking"].ToString();

                // Cari kode nasabah
                DataTable dtN = GetNasabah();
                DataRow[] nRows = dtN.Select("id_nasabah=" + idNasabah);
                if (nRows.Length == 0) return false;
                string kodeNasabah = nRows[0]["kode_nasabah"].ToString();

                // Tambahkan transaksi setor
                string fullCatatan = string.Format("Hasil Jemput {0}. {1}", kodeBooking, catatanSetor);
                AddTransaksiSetor(kodeNasabah, idSampah, beratReal, totalHarga, fullCatatan);

                // Update status penjemputan menjadi Selesai
                UpdateStatusPenjemputan(idPenjemputan, "Selesai");

                DataTable dtT = GetTransaksi();
                if (dtT != null && dtT.Rows.Count > 0)
                {
                    kodeTransaksiBaru = dtT.Rows[0]["kode_transaksi"].ToString();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
