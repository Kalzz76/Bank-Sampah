using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Web.Script.Serialization;

namespace BankSampah
{
    /// <summary>
    /// Lightweight zero-dependency embedded Web Server for Portal Warga Mobile-First.
    /// Runs on native .NET HttpListener and connects directly to SQL Server (db_banksampah).
    /// </summary>
    public static class WargaWebServer
    {
        private static HttpListener _listener;
        private static Thread _serverThread;
        private static bool _isRunning = false;
        private static JavaScriptSerializer _serializer = new JavaScriptSerializer();

        private static int _port = 5050;
        public static int Port { get { return _port; } private set { _port = value; } }
        public static string BaseUrl { get { return "http://localhost:" + Port + "/"; } }
        public static bool IsRunning { get { return _isRunning; } }

        public static event Action<string> OnLog;

        private static void Log(string message)
        {
            try
            {
                if (OnLog != null) OnLog(message);
                Console.WriteLine("[WargaWebServer] " + message);
            }
            catch { }
        }

        public static void Start(int preferredPort = 5050)
        {
            if (_isRunning) return;

            int port = preferredPort;
            bool started = false;

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    _listener = new HttpListener();
                    _listener.Prefixes.Add(string.Format("http://localhost:{0}/", port));
                    _listener.Prefixes.Add(string.Format("http://127.0.0.1:{0}/", port));
                    _listener.Start();
                    Port = port;
                    started = true;
                    break;
                }
                catch (Exception ex)
                {
                    Log(string.Format("Port {0} tidak dapat digunakan ({1}), mencoba port lain...", port, ex.Message));
                    try { _listener.Close(); } catch { }
                    port++;
                }
            }

            if (!started)
            {
                Log("Gagal memulai Web Server setelah beberapa percobaan port.");
                return;
            }

            _isRunning = true;
            Log(string.Format("Server Portal Warga aktif di {0}", BaseUrl));

            _serverThread = new Thread(ListenLoop);
            _serverThread.IsBackground = true;
            _serverThread.Start();
        }

        public static void Stop()
        {
            if (!_isRunning) return;
            _isRunning = false;

            try
            {
                if (_listener != null && _listener.IsListening)
                {
                    _listener.Stop();
                    _listener.Close();
                }
            }
            catch { }

            Log("Server Portal Warga dihentikan.");
        }

        private static void ListenLoop()
        {
            while (_isRunning)
            {
                try
                {
                    var context = _listener.GetContext();
                    ThreadPool.QueueUserWorkItem(state => ProcessRequest((HttpListenerContext)state), context);
                }
                catch (HttpListenerException)
                {
                    // Server dihentikan secara normal
                    break;
                }
                catch (Exception ex)
                {
                    Log("ListenLoop Error: " + ex.Message);
                }
            }
        }

        private static void ProcessRequest(HttpListenerContext context)
        {
            HttpListenerRequest req = context.Request;
            HttpListenerResponse res = context.Response;

            // Header CORS untuk kemudahan integrasi
            res.Headers.Add("Access-Control-Allow-Origin", "*");
            res.Headers.Add("Access-Control-Allow-Methods", "GET, POST, OPTIONS");
            res.Headers.Add("Access-Control-Allow-Headers", "Content-Type");

            if (req.HttpMethod == "OPTIONS")
            {
                res.StatusCode = 200;
                res.Close();
                return;
            }

            try
            {
                string rawPath = req.Url.AbsolutePath.TrimEnd('/');
                if (string.IsNullOrEmpty(rawPath)) rawPath = "/";

                // Routing API
                if (rawPath.StartsWith("/api/"))
                {
                    HandleApi(rawPath, req, res);
                    return;
                }

                // Routing Static Assets (HTML/CSS/JS/Images)
                ServeStaticFile(rawPath, res);
            }
            catch (Exception ex)
            {
                Log("ProcessRequest Error: " + ex.Message);
                SendJsonResponse(res, new { success = false, error = ex.Message }, 500);
            }
        }

        #region API Handlers
        private static void HandleApi(string path, HttpListenerRequest req, HttpListenerResponse res)
        {
            switch (path)
            {
                case "/api/nasabah":
                    GetNasabahList(req, res);
                    break;

                case "/api/profile":
                    GetProfile(req, res);
                    break;

                case "/api/leaderboard":
                    GetLeaderboard(req, res);
                    break;

                case "/api/transaksi":
                    GetTransaksiNasabah(req, res);
                    break;

                case "/api/sampah":
                    GetKatalogSampah(req, res);
                    break;

                case "/api/penjemputan":
                    if (req.HttpMethod == "POST")
                    {
                        CreatePenjemputan(req, res);
                    }
                    else
                    {
                        GetPenjemputanNasabah(req, res);
                    }
                    break;

                default:
                    SendJsonResponse(res, new { success = false, message = "Endpoint API tidak ditemukan" }, 404);
                    break;
            }
        }

        private static void GetNasabahList(HttpListenerRequest req, HttpListenerResponse res)
        {
            DataTable dt = DataStore.GetNasabah();
            var list = new List<Dictionary<string, object>>();

            if (dt != null)
            {
                foreach (DataRow r in dt.Rows)
                {
                    int id = Convert.ToInt32(r["id_nasabah"]);
                    decimal totalKg = DataStore.GetTotalSampahNasabah(id);
                    string badge = DataStore.GetBadgeNasabah(totalKg);

                    var item = new Dictionary<string, object>();
                    item["id_nasabah"] = id;
                    item["kode_nasabah"] = r["kode_nasabah"].ToString();
                    item["nama"] = r["nama"].ToString();
                    item["alamat"] = r["alamat"] != DBNull.Value ? r["alamat"].ToString() : "";
                    item["no_hp"] = r["no_hp"] != DBNull.Value ? r["no_hp"].ToString() : "";
                    item["saldo"] = r["saldo"] != DBNull.Value ? Convert.ToDecimal(r["saldo"]) : 0m;
                    item["foto"] = r["foto"] != DBNull.Value ? r["foto"].ToString() : "default_nasabah.png";
                    item["total_kg"] = totalKg;
                    item["badge"] = badge;
                    list.Add(item);
                }
            }

            SendJsonResponse(res, new { success = true, data = list });
        }

        private static void GetProfile(HttpListenerRequest req, HttpListenerResponse res)
        {
            string idStr = req.QueryString["id"];
            DataTable dt = DataStore.GetNasabah();
            if (dt == null || dt.Rows.Count == 0)
            {
                SendJsonResponse(res, new { success = false, message = "Data nasabah kosong" }, 404);
                return;
            }

            DataRow targetRow = null;
            if (!string.IsNullOrEmpty(idStr))
            {
                int id;
                if (int.TryParse(idStr, out id))
                {
                    DataRow[] rows = dt.Select("id_nasabah=" + id);
                    if (rows.Length > 0) targetRow = rows[0];
                }
            }

            if (targetRow == null)
            {
                targetRow = dt.Rows[0]; // Default ke nasabah pertama
            }

            int nasabahId = Convert.ToInt32(targetRow["id_nasabah"]);
            decimal saldo = targetRow["saldo"] != DBNull.Value ? Convert.ToDecimal(targetRow["saldo"]) : 0m;
            decimal totalKg = DataStore.GetTotalSampahNasabah(nasabahId);
            string badge = DataStore.GetBadgeNasabah(totalKg);

            // Hitung Badge Berikutnya & Progress
            string nextBadge = "";
            decimal targetKg = 0m;
            decimal remainingKg = 0m;
            decimal progressPct = 0m;

            if (totalKg < 15m)
            {
                nextBadge = "🌿 Nasabah Peduli";
                targetKg = 15m;
                remainingKg = targetKg - totalKg;
                progressPct = Math.Round((totalKg / targetKg) * 100m, 1);
            }
            else if (totalKg < 50m)
            {
                nextBadge = "🌳 Nasabah Hijau";
                targetKg = 50m;
                remainingKg = targetKg - totalKg;
                progressPct = Math.Round(((totalKg - 15m) / (50m - 15m)) * 100m, 1);
            }
            else if (totalKg < 150m)
            {
                nextBadge = "👑 Pahlawan Lingkungan";
                targetKg = 150m;
                remainingKg = targetKg - totalKg;
                progressPct = Math.Round(((totalKg - 50m) / (150m - 50m)) * 100m, 1);
            }
            else
            {
                nextBadge = "👑 Gelar Tertinggi (Grand Master)";
                targetKg = 150m;
                remainingKg = 0m;
                progressPct = 100m;
            }

            // Hitung Eco-Impact Pribadi
            decimal co2e = Math.Round(totalKg * 1.82m, 1);
            decimal trees = Math.Round(totalKg / 40.0m, 2);
            decimal energyKwh = Math.Round(totalKg * 3.4m, 1);
            decimal waterLiter = Math.Round(totalKg * 25.0m, 0);

            // Cek Ranking Nasabah
            int myRank = 1;
            DataTable dtLeaderboard = DataStore.GetTopNasabahTeraktif(100);
            if (dtLeaderboard != null)
            {
                foreach (DataRow lr in dtLeaderboard.Rows)
                {
                    if (Convert.ToInt32(lr["id_nasabah"]) == nasabahId)
                    {
                        myRank = Convert.ToInt32(lr["rank"]);
                        break;
                    }
                }
            }

            var profileData = new Dictionary<string, object>
            {
                { "id_nasabah", nasabahId },
                { "kode_nasabah", targetRow["kode_nasabah"].ToString() },
                { "nama", targetRow["nama"].ToString() },
                { "alamat", targetRow["alamat"] != DBNull.Value ? targetRow["alamat"].ToString() : "" },
                { "no_hp", targetRow["no_hp"] != DBNull.Value ? targetRow["no_hp"].ToString() : "" },
                { "saldo", saldo },
                { "foto", targetRow["foto"] != DBNull.Value ? targetRow["foto"].ToString() : "default_nasabah.png" },
                { "total_kg", totalKg },
                { "badge", badge },
                { "next_badge", nextBadge },
                { "target_kg", targetKg },
                { "remaining_kg", remainingKg },
                { "progress_pct", progressPct },
                { "my_rank", myRank },
                { "eco_impact", new Dictionary<string, object> {
                    { "co2e_kg", co2e },
                    { "trees_saved", trees },
                    { "energy_kwh", energyKwh },
                    { "water_liter", waterLiter }
                }}
            };

            SendJsonResponse(res, new { success = true, data = profileData });
        }

        private static void GetLeaderboard(HttpListenerRequest req, HttpListenerResponse res)
        {
            DataTable dt = DataStore.GetTopNasabahTeraktif(20);
            var list = new List<Dictionary<string, object>>();

            if (dt != null)
            {
                foreach (DataRow r in dt.Rows)
                {
                    int rank = Convert.ToInt32(r["rank"]);
                    string medal = "";
                    if (rank == 1) medal = "🥇 Juara 1";
                    else if (rank == 2) medal = "🥈 Juara 2";
                    else if (rank == 3) medal = "🥉 Juara 3";
                    else medal = string.Format("#{0}", rank);

                    decimal totalBerat = Convert.ToDecimal(r["total_berat"]);
                    string badge = DataStore.GetBadgeNasabah(totalBerat);

                    var item = new Dictionary<string, object>();
                    item["rank"] = rank;
                    item["medal"] = medal;
                    item["id_nasabah"] = Convert.ToInt32(r["id_nasabah"]);
                    item["kode_nasabah"] = r["kode_nasabah"].ToString();
                    item["nama"] = r["nama"].ToString();
                    item["foto"] = r["foto"] != DBNull.Value ? r["foto"].ToString() : "default_nasabah.png";
                    item["total_berat"] = totalBerat;
                    item["total_setoran"] = Convert.ToDecimal(r["total_setoran"]);
                    item["frekuensi"] = Convert.ToInt32(r["frekuensi"]);
                    item["badge"] = badge;
                    list.Add(item);
                }
            }

            SendJsonResponse(res, new { success = true, data = list });
        }

        private static void GetTransaksiNasabah(HttpListenerRequest req, HttpListenerResponse res)
        {
            string idStr = req.QueryString["id"];
            int id = 0;
            int.TryParse(idStr, out id);

            DataTable dt = DataStore.GetRiwayatTransaksiNasabah(id);
            var list = new List<Dictionary<string, object>>();

            if (dt != null)
            {
                foreach (DataRow r in dt.Rows)
                {
                    var item = new Dictionary<string, object>();
                    item["id_transaksi"] = r["id_transaksi"];
                    item["kode_transaksi"] = r["kode_transaksi"].ToString();
                    item["tanggal"] = r["tanggal"] != DBNull.Value ? Convert.ToDateTime(r["tanggal"]).ToString("dd/MM/yyyy HH:mm") : "-";
                    item["jenis_transaksi"] = r["jenis_transaksi"].ToString();
                    item["nama_sampah"] = r["nama_sampah"] != DBNull.Value ? r["nama_sampah"].ToString() : "-";
                    item["berat_kg"] = r["berat_kg"] != DBNull.Value ? Convert.ToDecimal(r["berat_kg"]) : 0m;
                    item["total_harga"] = Convert.ToDecimal(r["total_harga"]);
                    item["catatan"] = r["catatan"] != DBNull.Value ? r["catatan"].ToString() : "";
                    list.Add(item);
                }
            }

            SendJsonResponse(res, new { success = true, data = list });
        }

        private static void GetKatalogSampah(HttpListenerRequest req, HttpListenerResponse res)
        {
            DataTable dt = DataStore.GetSampah();
            var list = new List<Dictionary<string, object>>();

            if (dt != null)
            {
                foreach (DataRow r in dt.Rows)
                {
                    var item = new Dictionary<string, object>();
                    item["id_sampah"] = Convert.ToInt32(r["id_sampah"]);
                    item["nama_sampah"] = r["nama_sampah"].ToString();
                    item["kategori"] = r["kategori"].ToString();
                    item["jenis_sampah"] = r["jenis_sampah"].ToString();
                    item["harga_per_kg"] = Convert.ToDecimal(r["harga_per_kg"]);
                    item["foto"] = r["foto"] != DBNull.Value ? r["foto"].ToString() : "default_sampah.png";
                    list.Add(item);
                }
            }

            SendJsonResponse(res, new { success = true, data = list });
        }

        private static void GetPenjemputanNasabah(HttpListenerRequest req, HttpListenerResponse res)
        {
            string idStr = req.QueryString["id"];
            int id = 0;
            int.TryParse(idStr, out id);

            DataTable dt = DataStore.GetPenjemputan();
            var list = new List<Dictionary<string, object>>();

            if (dt != null)
            {
                DataRow[] rows = (id > 0) ? dt.Select("id_nasabah=" + id, "id_penjemputan DESC") : dt.Select("", "id_penjemputan DESC");
                foreach (DataRow r in rows)
                {
                    var item = new Dictionary<string, object>();
                    item["id_penjemputan"] = Convert.ToInt32(r["id_penjemputan"]);
                    item["kode_booking"] = r["kode_booking"].ToString();
                    item["id_nasabah"] = Convert.ToInt32(r["id_nasabah"]);
                    item["nama_nasabah"] = r["nama_nasabah"].ToString();
                    item["alamat_jemput"] = r["alamat_jemput"].ToString();
                    item["no_hp"] = r["no_hp"].ToString();
                    item["tanggal_jemput"] = Convert.ToDateTime(r["tanggal_jemput"]).ToString("yyyy-MM-dd");
                    item["waktu_jemput"] = r["waktu_jemput"].ToString();
                    item["armada_petugas"] = r["armada_petugas"].ToString();
                    item["estimasi_sampah"] = r["estimasi_sampah"].ToString();
                    item["estimasi_berat"] = r["estimasi_berat"] != DBNull.Value ? Convert.ToDecimal(r["estimasi_berat"]) : 0m;
                    item["status"] = r["status"].ToString();
                    item["catatan"] = r["catatan"] != DBNull.Value ? r["catatan"].ToString() : "";
                    list.Add(item);
                }
            }

            SendJsonResponse(res, new { success = true, data = list });
        }

        private static void CreatePenjemputan(HttpListenerRequest req, HttpListenerResponse res)
        {
            try
            {
                string jsonBody = "";
                using (var reader = new StreamReader(req.InputStream, req.ContentEncoding))
                {
                    jsonBody = reader.ReadToEnd();
                }

                var dict = _serializer.Deserialize<Dictionary<string, object>>(jsonBody);
                if (dict == null)
                {
                    SendJsonResponse(res, new { success = false, message = "Payload JSON tidak valid" }, 400);
                    return;
                }

                int idNasabah = Convert.ToInt32(dict["id_nasabah"]);
                string alamat = dict.ContainsKey("alamat") ? dict["alamat"].ToString() : "";
                string noHp = dict.ContainsKey("no_hp") ? dict["no_hp"].ToString() : "";
                string waktuJemput = dict.ContainsKey("waktu_jemput") ? dict["waktu_jemput"].ToString() : "Pagi (08:00 - 11:00)";
                string estimasiSampah = dict.ContainsKey("estimasi_sampah") ? dict["estimasi_sampah"].ToString() : "Sampah Campur";
                decimal estimasiBerat = 0m;
                if (dict.ContainsKey("estimasi_berat"))
                {
                    decimal.TryParse(dict["estimasi_berat"].ToString().Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out estimasiBerat);
                }
                string catatan = dict.ContainsKey("catatan") ? dict["catatan"].ToString() : "Booking mandiri via Portal Warga";

                // Cari Nama Nasabah
                string namaNasabah = "Nasabah";
                DataTable dtN = DataStore.GetNasabah();
                if (dtN != null)
                {
                    DataRow[] rows = dtN.Select("id_nasabah=" + idNasabah);
                    if (rows.Length > 0) namaNasabah = rows[0]["nama"].ToString();
                }

                // Generate Kode Booking
                string kodeBooking = "PKP-" + DateTime.Now.ToString("yyyyMMdd") + "-" + (new Random().Next(100, 999));
                string armada = "Budi Santoso (Motor Roda Tiga)";

                DataStore.AddPenjemputan(kodeBooking, idNasabah, namaNasabah, alamat, noHp, DateTime.Now.Date, waktuJemput, armada, estimasiSampah, estimasiBerat, catatan);

                SendJsonResponse(res, new
                {
                    success = true,
                    message = "Booking penjemputan berhasil dibuat! Petugas armada akan segera menjemput ke lokasi Anda.",
                    kode_booking = kodeBooking
                });
            }
            catch (Exception ex)
            {
                SendJsonResponse(res, new { success = false, message = "Gagal membuat booking: " + ex.Message }, 500);
            }
        }
        #endregion

        #region Static File Serving
        private static void ServeStaticFile(string path, HttpListenerResponse res)
        {
            if (path == "/" || path == "/warga" || path == "/index.html")
            {
                path = "/index.html";
            }

            // Cari lokasi direktori web
            string webDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "Web");
            if (!Directory.Exists(webDir))
            {
                // Fallback jika running dari bin\Debug saat development
                string devDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Assets", "Web");
                if (Directory.Exists(devDir)) webDir = Path.GetFullPath(devDir);
            }

            string filePath = Path.Combine(webDir, path.TrimStart('/'));

            // Cek jika request gambar dari Assets/Images
            if (path.StartsWith("/assets/images/"))
            {
                string imgFile = Path.GetFileName(path);
                string imgDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "Images");
                if (!Directory.Exists(imgDir))
                {
                    imgDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Assets", "Images");
                }
                filePath = Path.Combine(imgDir, imgFile);
            }

            if (!File.Exists(filePath))
            {
                SendJsonResponse(res, new { success = false, message = "Berkas tidak ditemukan: " + path }, 404);
                return;
            }

            string ext = Path.GetExtension(filePath).ToLowerInvariant();
            string mimeType = "application/octet-stream";

            switch (ext)
            {
                case ".html": mimeType = "text/html; charset=utf-8"; break;
                case ".css": mimeType = "text/css; charset=utf-8"; break;
                case ".js": mimeType = "application/javascript; charset=utf-8"; break;
                case ".json": mimeType = "application/json; charset=utf-8"; break;
                case ".png": mimeType = "image/png"; break;
                case ".jpg":
                case ".jpeg": mimeType = "image/jpeg"; break;
                case ".svg": mimeType = "image/svg+xml"; break;
                case ".ico": mimeType = "image/x-icon"; break;
            }

            byte[] bytes = File.ReadAllBytes(filePath);
            res.ContentType = mimeType;
            res.ContentLength64 = bytes.Length;
            res.StatusCode = 200;
            res.OutputStream.Write(bytes, 0, bytes.Length);
            res.OutputStream.Flush();
            res.Close();
        }

        private static void SendJsonResponse(HttpListenerResponse res, object obj, int statusCode = 200)
        {
            try
            {
                string json = _serializer.Serialize(obj);
                byte[] bytes = Encoding.UTF8.GetBytes(json);
                res.ContentType = "application/json; charset=utf-8";
                res.StatusCode = statusCode;
                res.ContentLength64 = bytes.Length;
                res.OutputStream.Write(bytes, 0, bytes.Length);
                res.OutputStream.Flush();
                res.Close();
            }
            catch { }
        }
        #endregion
    }
}
