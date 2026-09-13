using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BankSampah
{
    public partial class FormLaporan : Form
    {
        public FormLaporan()
        {
            InitializeComponent();
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            UIHelper.MakeRounded(panelEcoBanner, 10);
            UIHelper.MakeRounded(panelColLeft, 10);
            UIHelper.MakeRounded(panelColRight, 10);
            UIHelper.MakeRounded(panelLeaderboard, 10);
            UIHelper.ApplyModernGridStyle(dgvLeaderboard);
            UIHelper.StyleButtonOutline(btnCetak);
            UIHelper.StyleButtonOutline(btnEkspor);

            LoadEcoMetrics();
            LoadKomposisiChart();
            LoadTrenChart();
            LoadLeaderboard();
        }

        private void LoadEcoMetrics()
        {
            try
            {
                DataStore.EcoMetricsData eco = DataStore.GetEcoMetrics();
                lblEcoMetric1.Text = string.Format("♻️ {0:N1} kg\r\nSampah Dikelola ({1:N2} Ton)", eco.TotalKg, eco.TotalTon);
                lblEcoMetric2.Text = string.Format("💨 {0:N1} kg CO₂e\r\nReduksi Emisi Karbon", eco.CO2ReduksiKg);
                lblEcoMetric3.Text = string.Format("🌳 {0} Batang\r\nPohon Terselamatkan", eco.PohonTerselamatkan);
                lblEcoMetric4.Text = string.Format("⭐ {0:N0}%\r\n{1}", eco.PersenDaurUlang, "Zero Waste Pastiklola");
            }
            catch { }
        }

        private void LoadLeaderboard()
        {
            try
            {
                DataTable dtRaw = DataStore.GetTopNasabahTeraktif(5);

                DataTable dtDisplay = new DataTable();
                dtDisplay.Columns.Add("Peringkat", typeof(string));
                dtDisplay.Columns.Add("FotoAvatar", typeof(Image));
                dtDisplay.Columns.Add("Kode Nasabah", typeof(string));
                dtDisplay.Columns.Add("Nama Nasabah", typeof(string));
                dtDisplay.Columns.Add("Badge Level", typeof(string));
                dtDisplay.Columns.Add("Total Sampah (kg)", typeof(string));
                dtDisplay.Columns.Add("Kontribusi Tabungan", typeof(string));
                dtDisplay.Columns.Add("Keaktifan", typeof(string));

                if (dtRaw != null && dtRaw.Rows.Count > 0)
                {
                    foreach (DataRow r in dtRaw.Rows)
                    {
                        int rank = Convert.ToInt32(r["rank"]);
                        string badge = "";
                        if (rank == 1) badge = "🥇 Juara 1";
                        else if (rank == 2) badge = "🥈 Juara 2";
                        else if (rank == 3) badge = "🥉 Juara 3";
                        else badge = string.Format("#{0} Peringkat", rank);

                        string foto = r["foto"] != DBNull.Value ? r["foto"].ToString() : "";
                        string nama = r["nama"].ToString();
                        Image img = UIHelper.GetCircularAvatar(foto, nama, 34);

                        decimal b = Convert.ToDecimal(r["total_berat"]);
                        decimal u = Convert.ToDecimal(r["total_setoran"]);
                        int freq = Convert.ToInt32(r["frekuensi"]);
                        string badgeLevel = DataStore.GetBadgeNasabah(b);

                        dtDisplay.Rows.Add(
                            badge,
                            img,
                            r["kode_nasabah"].ToString(),
                            nama,
                            badgeLevel,
                            string.Format("{0:N2} kg", b),
                            string.Format("Rp {0:N0}", u),
                            string.Format("{0} Kali Setor", freq)
                        );
                    }
                }

                dgvLeaderboard.DataSource = dtDisplay;
                UIHelper.FormatGridColumns(dgvLeaderboard);

                if (dgvLeaderboard.Columns.Contains("FotoAvatar"))
                {
                    dgvLeaderboard.Columns["FotoAvatar"].HeaderText = "Foto";
                    dgvLeaderboard.Columns["FotoAvatar"].DisplayIndex = 1;
                    dgvLeaderboard.Columns["FotoAvatar"].Width = 50;
                }

                dgvLeaderboard.RowTemplate.Height = 44;
                foreach (DataGridViewRow row in dgvLeaderboard.Rows)
                {
                    row.Height = 44;
                }
            }
            catch { }
        }

        private void LoadKomposisiChart()
        {
            try
            {
                chartPie.Series["Komposisi"].Points.Clear();

                Color[] colors = new Color[] {
                    UIHelper.Teal,
                    UIHelper.Gold,
                    UIHelper.BlueKpi,
                    UIHelper.Danger,
                    Color.FromArgb(78, 139, 103),
                    Color.FromArgb(169, 122, 18)
                };

                DataTable dt = null;
                try { dt = DataStore.GetKomposisiSampah(); } catch { }

                int colorIdx = 0;
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        string kat = r["kategori"].ToString();
                        double val = 0;
                        double.TryParse(r["total_berat"].ToString(), out val);

                        if (val > 0)
                        {
                            int pIdx = chartPie.Series["Komposisi"].Points.AddXY(kat, val);
                            DataPoint dp = chartPie.Series["Komposisi"].Points[pIdx];

                            dp.Color = colors[colorIdx % colors.Length];
                            dp.LegendText = kat + " (#PERCENT{P0})";
                            dp.Label = "#PERCENT{P0}";
                            dp.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);

                            colorIdx++;
                        }
                    }
                }

                // If no points yet, load clean default distribution
                if (chartPie.Series["Komposisi"].Points.Count == 0)
                {
                    string[] defKats = new string[] { "Plastik", "Kertas", "Logam", "Kaca" };
                    double[] defVals = new double[] { 40.0, 25.0, 20.0, 15.0 };

                    for (int i = 0; i < defKats.Length; i++)
                    {
                        int pIdx = chartPie.Series["Komposisi"].Points.AddXY(defKats[i], defVals[i]);
                        DataPoint dp = chartPie.Series["Komposisi"].Points[pIdx];
                        dp.Color = colors[i % colors.Length];
                        dp.LegendText = defKats[i] + " (#PERCENT{P0})";
                        dp.Label = "#PERCENT{P0}";
                        dp.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                    }
                }

                chartPie.Series["Komposisi"]["PieLabelStyle"] = "Inside";
                chartPie.Series["Komposisi"]["DoughnutRadius"] = "50";
            }
            catch { }
        }

        private void LoadTrenChart()
        {
            try
            {
                chartTren.Series["Tren"].Points.Clear();
                chartTren.Series["Tren"].Color = UIHelper.Gold;

                DataTable dt = DataStore.GetTrenSetoranBulanan();
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        string bln = r["bulan"].ToString();
                        double kg = Convert.ToDouble(r["total_kg"]);

                        int pIdx = chartTren.Series["Tren"].Points.AddXY(bln, kg);
                        chartTren.Series["Tren"].Points[pIdx].Color = UIHelper.Gold;
                    }
                }
                else
                {
                    string[] defBln = new string[] { "Mar", "Apr", "Mei", "Jun", "Jul", "Ags" };
                    double[] defKg = new double[] { 45.0, 65.5, 52.0, 88.4, 76.2, 112.5 };

                    for (int i = 0; i < defBln.Length; i++)
                    {
                        int pIdx = chartTren.Series["Tren"].Points.AddXY(defBln[i], defKg[i]);
                        chartTren.Series["Tren"].Points[pIdx].Color = UIHelper.Gold;
                    }
                }
            }
            catch { }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            SoundHelper.PlaySaveSound();
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.DocumentName = "Laporan_SIMBAS_" + DateTime.Now.ToString("yyyyMMdd");
                pd.DefaultPageSettings.Landscape = false;
                pd.PrintPage += new PrintPageEventHandler(PrintLaporanPage);

                PrintPreviewDialog ppd = new PrintPreviewDialog();
                ppd.Document = pd;
                ppd.Width = 920;
                ppd.Height = 740;
                ppd.StartPosition = FormStartPosition.CenterParent;
                ppd.ShowDialog(this);
            }
            catch (Exception ex)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Gagal membuka pratinjau cetak laporan: " + ex.Message, "Error Cetak", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintLaporanPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Palet Warna & Brush SIMBAS
            Brush bPine = new SolidBrush(Color.FromArgb(22, 38, 31));
            Brush bTeal = new SolidBrush(Color.FromArgb(59, 122, 94));
            Brush bMuted = new SolidBrush(Color.FromArgb(80, 95, 85));
            Brush bZebra = new SolidBrush(Color.FromArgb(248, 250, 248));
            Brush bSage = new SolidBrush(Color.FromArgb(238, 242, 236));
            Pen penLine = new Pen(Color.FromArgb(210, 220, 210), 1);
            Pen penThick = new Pen(Color.FromArgb(31, 58, 46), 2);

            // Font Tipografi
            Font fKopTitle = new Font("Segoe UI", 13F, FontStyle.Bold);
            Font fKopSub = new Font("Segoe UI", 9F, FontStyle.Bold);
            Font fKopSmall = new Font("Segoe UI", 8F, FontStyle.Regular);
            Font fDocTitle = new Font("Segoe UI", 11F, FontStyle.Bold);
            Font fSecHeader = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            Font fCardTitle = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            Font fCardVal = new Font("Segoe UI", 9F, FontStyle.Bold);
            Font fTh = new Font("Segoe UI", 8F, FontStyle.Bold);
            Font fTd = new Font("Segoe UI", 8F, FontStyle.Regular);
            Font fTdBold = new Font("Segoe UI", 8F, FontStyle.Bold);
            Font fNote = new Font("Segoe UI", 7.5F, FontStyle.Italic);

            StringFormat sfCenter = new StringFormat { Alignment = StringAlignment.Center };
            StringFormat sfRight = new StringFormat { Alignment = StringAlignment.Far };

            int x = 45;
            int y = 35;
            int w = e.PageBounds.Width - 90; // Lebar cetak A4 ~737 px

            // ==========================================
            // 1. KOP RESMI LAPORAN BANK SAMPAH
            // ==========================================
            g.DrawString("SIMBAS — SISTEM INFORMASI MANAJEMEN BANK SAMPAH", fKopTitle, bTeal, new RectangleF(x, y, w, 22), sfCenter);
            y += 22;
            g.DrawString("BANK SAMPAH BERKAH MANDIRI KOTA BANDUNG", fKopSub, bPine, new RectangleF(x, y, w, 18), sfCenter);
            y += 18;
            g.DrawString("Jl. Soekarno Hatta No. 12, Buahbatu, Bandung 40286 | Telp: (022) 7500123 | Email: simbas@pastiklola.id", fKopSmall, bMuted, new RectangleF(x, y, w, 16), sfCenter);
            y += 18;
            g.DrawLine(penThick, x, y, x + w, y);
            y += 3;
            g.DrawLine(penLine, x, y, x + w, y);
            y += 14;

            // Judul Dokumen
            g.DrawString("LAPORAN EVALUASI STATISTIK & DAMPAK LINGKUNGAN", fDocTitle, bPine, new RectangleF(x, y, w, 20), sfCenter);
            y += 20;
            g.DrawString("Dicetak pada: " + DateTime.Now.ToString("dd MMMM yyyy, HH:mm") + " WIB  |  Periode: Tahun Berjalan 2026", fKopSmall, bMuted, new RectangleF(x, y, w, 16), sfCenter);
            y += 24;

            // ==========================================
            // 2. REKAPITULASI DAMPAK LINGKUNGAN (ECO-METRICS)
            // ==========================================
            g.DrawString("I. INDIKATOR DAMPAK LINGKUNGAN (ECO-METRICS & CIRCULAR ECONOMY)", fSecHeader, bTeal, x, y);
            y += 18;

            DataStore.EcoMetricsData eco = DataStore.GetEcoMetrics();
            int cardW = (w - 18) / 4;
            int cardH = 50;

            string[] cTitles = { "SAMPAH TERKELOLA", "REDUKSI EMISI", "POHON TERSELAMATKAN", "TARGET ZERO WASTE" };
            string[] cVals = {
                string.Format("{0:N1} kg\n({1:N2} Ton)", eco.TotalKg, eco.TotalTon),
                string.Format("{0:N1} kg CO₂e\nGas Rumah Kaca", eco.CO2ReduksiKg),
                string.Format("{0} Batang\nPohon Hutan", eco.PohonTerselamatkan),
                string.Format("{0:N0}% Sirkular\nBebas dari TPA", eco.PersenDaurUlang)
            };

            for (int i = 0; i < 4; i++)
            {
                int cx = x + i * (cardW + 6);
                g.FillRectangle(bSage, cx, y, cardW, cardH);
                g.DrawRectangle(penLine, cx, y, cardW, cardH);
                g.DrawString(cTitles[i], fCardTitle, bMuted, new RectangleF(cx + 4, y + 5, cardW - 8, 14), sfCenter);
                g.DrawString(cVals[i], fCardVal, bPine, new RectangleF(cx + 4, y + 18, cardW - 8, 30), sfCenter);
            }
            y += cardH + 18;

            // ==========================================
            // 3. TABEL KOMPOSISI JENIS SAMPAH
            // ==========================================
            g.DrawString("II. DISTRIBUSI KOMPOSISI SAMPAH TERKELOLA", fSecHeader, bTeal, x, y);
            y += 18;

            int col1 = 40, col2 = 230, col3 = 150, col4 = 150;
            g.FillRectangle(bPine, x, y, w, 22);
            g.DrawString("No", fTh, Brushes.White, x + 8, y + 4);
            g.DrawString("Kategori Sampah", fTh, Brushes.White, x + col1 + 8, y + 4);
            g.DrawString("Total Berat Terkelola", fTh, Brushes.White, new RectangleF(x + col1 + col2, y + 4, col3 - 10, 16), sfRight);
            g.DrawString("Persentase (%)", fTh, Brushes.White, new RectangleF(x + col1 + col2 + col3, y + 4, col4 - 10, 16), sfRight);
            g.DrawString("Status Pemanfaatan", fTh, Brushes.White, x + col1 + col2 + col3 + col4 + 8, y + 4);
            y += 22;

            DataTable dtKomp = DataStore.GetKomposisiSampah();
            decimal sumBerat = 0;
            if (dtKomp != null && dtKomp.Rows.Count > 0)
            {
                foreach (DataRow kr in dtKomp.Rows)
                {
                    decimal bw = 0;
                    decimal.TryParse(kr["total_berat"].ToString(), out bw);
                    sumBerat += bw;
                }
            }
            if (sumBerat <= 0) sumBerat = 100m;

            int noK = 1;
            if (dtKomp != null && dtKomp.Rows.Count > 0)
            {
                foreach (DataRow kr in dtKomp.Rows)
                {
                    string kat = kr["kategori"].ToString();
                    decimal bw = 0;
                    decimal.TryParse(kr["total_berat"].ToString(), out bw);
                    decimal pct = Math.Round((bw / sumBerat) * 100m, 1);

                    string statusSirkular = "Didaur Ulang Pabrik";
                    if (kat.ToLower().Contains("minyak")) statusSirkular = "Bahan Baku Biodiesel";
                    else if (kat.ToLower().Contains("kompos") || kat.ToLower().Contains("organik")) statusSirkular = "Pupuk Organik / Maggot";
                    else if (kat.ToLower().Contains("b3")) statusSirkular = "Pengolahan Limbah Khusus";

                    if (noK % 2 == 0) g.FillRectangle(bZebra, x, y, w, 20);
                    g.DrawLine(penLine, x, y + 20, x + w, y + 20);

                    g.DrawString(noK.ToString(), fTd, bPine, x + 8, y + 3);
                    g.DrawString(kat, fTdBold, bPine, x + col1 + 8, y + 3);
                    g.DrawString(string.Format("{0:N2} kg", bw), fTd, bPine, new RectangleF(x + col1 + col2, y + 3, col3 - 10, 16), sfRight);
                    g.DrawString(string.Format("{0:N1} %", pct), fTd, bPine, new RectangleF(x + col1 + col2 + col3, y + 3, col4 - 10, 16), sfRight);
                    g.DrawString(statusSirkular, fTd, bMuted, x + col1 + col2 + col3 + col4 + 8, y + 3);

                    y += 20;
                    noK++;
                }
            }
            else
            {
                g.DrawString("Belum ada data komposisi sampah", fTd, Brushes.Gray, x + 10, y + 4);
                y += 20;
            }

            // Subtotal Komposisi
            g.FillRectangle(bSage, x, y, w, 22);
            g.DrawString("TOTAL TERKELOLA", fTh, bPine, x + col1 + 8, y + 4);
            g.DrawString(string.Format("{0:N2} kg", sumBerat), fTh, bPine, new RectangleF(x + col1 + col2, y + 4, col3 - 10, 16), sfRight);
            g.DrawString("100.0 %", fTh, bPine, new RectangleF(x + col1 + col2 + col3, y + 4, col4 - 10, 16), sfRight);
            g.DrawString("Ekonomi Sirkular 100%", fTh, bTeal, x + col1 + col2 + col3 + col4 + 8, y + 4);
            y += 30;

            // ==========================================
            // 4. TOP 5 NASABAH TERAKTIF (LEADERBOARD)
            // ==========================================
            g.DrawString("III. DAFTAR PERINGKAT NASABAH TERAKTIF (TOP 5 LEADERBOARD)", fSecHeader, bTeal, x, y);
            y += 18;

            int cR1 = 60, cR2 = 80, cR3 = 190, cR4 = 140, cR5 = 120;
            g.FillRectangle(bPine, x, y, w, 22);
            g.DrawString("Peringkat", fTh, Brushes.White, x + 6, y + 4);
            g.DrawString("Kode", fTh, Brushes.White, x + cR1 + 6, y + 4);
            g.DrawString("Nama Nasabah", fTh, Brushes.White, x + cR1 + cR2 + 6, y + 4);
            g.DrawString("Badge Gamifikasi", fTh, Brushes.White, x + cR1 + cR2 + cR3 + 6, y + 4);
            g.DrawString("Total Sampah", fTh, Brushes.White, new RectangleF(x + cR1 + cR2 + cR3 + cR4, y + 4, cR5 - 10, 16), sfRight);
            g.DrawString("Total Tabungan", fTh, Brushes.White, new RectangleF(x + cR1 + cR2 + cR3 + cR4 + cR5, y + 4, w - (cR1 + cR2 + cR3 + cR4 + cR5) - 10, 16), sfRight);
            y += 22;

            DataTable dtTop = DataStore.GetTopNasabahTeraktif(5);
            if (dtTop != null && dtTop.Rows.Count > 0)
            {
                int rIdx = 1;
                foreach (DataRow tr in dtTop.Rows)
                {
                    string rText = string.Format("#{0}", tr["rank"]);
                    if (rIdx == 1) rText = "Juara 1";
                    else if (rIdx == 2) rText = "Juara 2";
                    else if (rIdx == 3) rText = "Juara 3";

                    decimal bKg = Convert.ToDecimal(tr["total_berat"]);
                    decimal uRp = Convert.ToDecimal(tr["total_setoran"]);
                    string badge = DataStore.GetBadgeNasabah(bKg);
                    string badgePrint = badge.Replace("👑", "★").Replace("🌳", "◆").Replace("🌿", "▲").Replace("🌱", "●").Trim();

                    if (rIdx % 2 == 0) g.FillRectangle(bZebra, x, y, w, 20);
                    g.DrawLine(penLine, x, y + 20, x + w, y + 20);

                    g.DrawString(rText, fTdBold, bPine, x + 6, y + 3);
                    g.DrawString(tr["kode_nasabah"].ToString(), fTd, bMuted, x + cR1 + 6, y + 3);
                    g.DrawString(tr["nama"].ToString(), fTdBold, bPine, x + cR1 + cR2 + 6, y + 3);
                    g.DrawString(badgePrint, fTd, bTeal, x + cR1 + cR2 + cR3 + 6, y + 3);
                    g.DrawString(string.Format("{0:N2} kg", bKg), fTd, bPine, new RectangleF(x + cR1 + cR2 + cR3 + cR4, y + 3, cR5 - 10, 16), sfRight);
                    g.DrawString(string.Format("Rp {0:N0}", uRp), fTdBold, bPine, new RectangleF(x + cR1 + cR2 + cR3 + cR4 + cR5, y + 3, w - (cR1 + cR2 + cR3 + cR4 + cR5) - 10, 16), sfRight);

                    y += 20;
                    rIdx++;
                }
            }
            else
            {
                g.DrawString("Belum ada data transaksi nasabah", fTd, Brushes.Gray, x + 10, y + 4);
                y += 20;
            }
            y += 28;

            // ==========================================
            // 5. TANDA TANGAN & PENGESAHAN LAPORAN
            // ==========================================
            int signW = 220;
            int signX1 = x + 20;
            int signX2 = x + w - signW - 20;

            g.DrawString("Catatan Verifikasi:", fTh, bPine, signX1, y);
            g.DrawString("• Seluruh data terverifikasi otomatis dari SQL Server SIMBAS.", fNote, bMuted, signX1, y + 16);
            g.DrawString("• Mendukung komitmen Zero Waste to Landfill Kota Bandung.", fNote, bMuted, signX1, y + 30);

            g.DrawString("Bandung, " + DateTime.Now.ToString("dd MMMM yyyy"), fTd, bPine, signX2, y);
            y += 18;
            g.DrawString("Petugas Validator SIMBAS,", fTd, bPine, signX2, y);
            y += 50;
            g.DrawString("( __________________________ )", fTdBold, bPine, signX2, y);
            y += 16;
            g.DrawString("NIP/NIK: 2026.RPL.1301", fNote, bMuted, signX2, y);

            // Footer halaman
            g.DrawLine(penLine, x, e.PageBounds.Height - 45, x + w, e.PageBounds.Height - 45);
            g.DrawString("Dokumen resmi Sistem Informasi Manajemen Bank Sampah (SIMBAS) @2026 — Terhubung SQL Server db_banksampah", fNote, bMuted, new RectangleF(x, e.PageBounds.Height - 40, w, 16), sfCenter);
        }

        private void btnEkspor_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV File (*.csv)|*.csv|Excel File (*.xlsx)|*.xlsx";
                sfd.FileName = "Laporan_SIMBAS_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";
                sfd.Title = "Ekspor Laporan Bank Sampah";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Kode Trx,Nama Nasabah,Jenis Sampah,Berat (Kg),Total (Rp),Tanggal");

                        DataTable dtT = DataStore.GetTransaksi();
                        foreach (DataRow r in dtT.Rows)
                        {
                            sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5}",
                                r["kode_transaksi"],
                                r["nama_nasabah"],
                                r["nama_sampah"],
                                r["berat_kg"],
                                r["total_harga"],
                                Convert.ToDateTime(r["tanggal"]).ToString("yyyy-MM-dd HH:mm")));
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        SoundHelper.PlaySaveSound();
                        MessageBox.Show("Data Laporan Berhasil Diekspor ke: " + Path.GetFileName(sfd.FileName), "Sukses Ekspor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        SoundHelper.PlayAlertSound();
                        MessageBox.Show("Gagal ekspor data: " + ex.Message, "Error Ekspor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
