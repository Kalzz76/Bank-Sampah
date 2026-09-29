using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace BankSampah
{
    public partial class FormRiwayatNasabah : Form
    {
        private int _idNasabah;
        private string _kode;
        private string _nama;
        private string _noHp;
        private string _alamat;
        private decimal _saldo;
        private string _foto;
        private DataTable _dtRiwayat;

        public FormRiwayatNasabah(int idNasabah, string kode, string nama, string noHp, string alamat, decimal saldo, string foto)
        {
            InitializeComponent();
            _idNasabah = idNasabah;
            _kode = kode;
            _nama = nama;
            _noHp = noHp;
            _alamat = alamat;
            _saldo = saldo;
            _foto = foto;
        }

        private void FormRiwayatNasabah_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyModernGridStyle(dgvRiwayat);
            UIHelper.MakeRounded(this, 12);
            UIHelper.MakeRounded(btnCetakBuku, 6);
            UIHelper.MakeRounded(btnTutup, 6);
            UIHelper.MakeRounded(lblKodeBadge, 4);

            lblNama.Text = _nama;
            lblKodeBadge.Text = _kode;
            lblNoHp.Text = "No. HP: " + (string.IsNullOrWhiteSpace(_noHp) ? "-" : _noHp);
            lblAlamat.Text = "Alamat: " + (string.IsNullOrWhiteSpace(_alamat) ? "-" : _alamat);
            lblMetricSaldo.Text = string.Format("Rp {0:N0}", _saldo);

            picAvatar.Image = UIHelper.GetCircularAvatar(_foto, _nama, 60);

            LoadRiwayat();
        }

        private void LoadRiwayat()
        {
            _dtRiwayat = DataStore.GetRiwayatTransaksiNasabah(_idNasabah);
            dgvRiwayat.DataSource = _dtRiwayat;
            UIHelper.FormatGridColumns(dgvRiwayat);

            decimal totalKg = 0;
            decimal totalSetor = 0;
            decimal totalTarik = 0;

            if (_dtRiwayat != null && _dtRiwayat.Rows.Count > 0)
            {
                foreach (DataRow r in _dtRiwayat.Rows)
                {
                    if (r["berat_kg"] != DBNull.Value)
                    {
                        decimal b;
                        if (decimal.TryParse(r["berat_kg"].ToString(), out b)) totalKg += b;
                    }

                    string jenis = r.Table.Columns.Contains("jenis_transaksi") && r["jenis_transaksi"] != DBNull.Value ? r["jenis_transaksi"].ToString() : "";
                    decimal val = 0;
                    if (r.Table.Columns.Contains("total_harga") && r["total_harga"] != DBNull.Value && decimal.TryParse(r["total_harga"].ToString(), out val))
                    {
                        if (jenis.Equals("Setor", StringComparison.OrdinalIgnoreCase)) totalSetor += val;
                        else if (jenis.Equals("Tarik", StringComparison.OrdinalIgnoreCase)) totalTarik += val;
                    }
                }
                lblCountTrx.Text = string.Format("Menampilkan {0} mutasi transaksi", _dtRiwayat.Rows.Count);

                decimal saldoMutasi = totalSetor - totalTarik;
                if (_saldo != saldoMutasi)
                {
                    _saldo = saldoMutasi;
                    DataStore.SyncSaldoNasabah(_idNasabah, _saldo);
                }
            }
            else
            {
                lblCountTrx.Text = "Belum ada transaksi tercatat untuk nasabah ini";
            }

            lblMetricSaldo.Text = string.Format("Rp {0:N0}", _saldo);
            string badge = DataStore.GetBadgeNasabah(totalKg);
            lblTotalBerat.Text = string.Format("Total Sampah Disetor: {0:N2} kg   •   Level: {1}", totalKg, badge);
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCetakBuku_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintBukuTabunganPage);

            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.Width = 800;
            ppd.Height = 600;
            ppd.StartPosition = FormStartPosition.CenterParent;
            ppd.ShowDialog(this);
        }

        private void PrintBukuTabunganPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fTitle = new Font("Segoe UI", 14F, FontStyle.Bold);
            Font fSubtitle = new Font("Segoe UI", 9F, FontStyle.Regular);
            Font fHeader = new Font("Segoe UI", 9F, FontStyle.Bold);
            Font fRow = new Font("Segoe UI", 8.5F, FontStyle.Regular);
            Brush bPine = new SolidBrush(Color.FromArgb(22, 38, 31));
            Brush bTeal = new SolidBrush(Color.FromArgb(59, 122, 94));
            Pen penLine = new Pen(Color.FromArgb(199, 210, 194), 1);

            int startX = 50;
            int startY = 40;
            int width = e.PageBounds.Width - 100;

            // Kop Surat
            g.DrawString("SIMBAS - BANK SAMPAH DIGITAL", fTitle, bTeal, startX, startY);
            startY += 26;
            g.DrawString("BUKU CATATAN REKAPITULASI TABUNGAN NASABAH", fHeader, bPine, startX, startY);
            startY += 18;
            g.DrawString("Dicetak pada: " + DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss"), fSubtitle, Brushes.Gray, startX, startY);
            startY += 24;
            g.DrawLine(penLine, startX, startY, startX + width, startY);
            startY += 12;

            // Info Nasabah
            g.DrawString("Kode Nasabah  : " + _kode, fHeader, bPine, startX, startY);
            g.DrawString("Saldo Tabungan : " + string.Format("Rp {0:N0}", _saldo), fTitle, bTeal, startX + 350, startY);
            startY += 20;
            g.DrawString("Nama Nasabah  : " + _nama, fRow, bPine, startX, startY);
            startY += 18;
            g.DrawString("No. Telepon   : " + _noHp, fRow, bPine, startX, startY);
            startY += 18;
            g.DrawString("Alamat Warga  : " + _alamat, fRow, bPine, startX, startY);
            startY += 25;
            g.DrawLine(penLine, startX, startY, startX + width, startY);
            startY += 10;

            // Table Header
            g.FillRectangle(new SolidBrush(Color.FromArgb(238, 242, 236)), startX, startY, width, 24);
            g.DrawString("Tanggal", fHeader, bPine, startX + 5, startY + 4);
            g.DrawString("Kode Trx", fHeader, bPine, startX + 90, startY + 4);
            g.DrawString("Tipe", fHeader, bPine, startX + 220, startY + 4);
            g.DrawString("Jenis Sampah", fHeader, bPine, startX + 280, startY + 4);
            g.DrawString("Berat (kg)", fHeader, bPine, startX + 460, startY + 4);
            g.DrawString("Total (Rp)", fHeader, bPine, startX + 550, startY + 4);
            startY += 26;

            if (_dtRiwayat != null && _dtRiwayat.Rows.Count > 0)
            {
                foreach (DataRow r in _dtRiwayat.Rows)
                {
                    string tgl = Convert.ToDateTime(r["tanggal"]).ToString("dd/MM/yy");
                    string kodeTrx = r["kode_transaksi"].ToString();
                    string tipe = r["jenis_transaksi"].ToString();
                    string sampah = r["nama_sampah"].ToString();
                    string berat = r["berat_kg"] != DBNull.Value ? string.Format("{0:N2}", r["berat_kg"]) : "-";
                    string total = r["total_harga"] != DBNull.Value ? string.Format("Rp {0:N0}", r["total_harga"]) : "-";

                    g.DrawString(tgl, fRow, bPine, startX + 5, startY + 4);
                    g.DrawString(kodeTrx, fRow, bPine, startX + 90, startY + 4);
                    g.DrawString(tipe, fRow, bPine, startX + 220, startY + 4);
                    g.DrawString(sampah, fRow, bPine, startX + 280, startY + 4);
                    g.DrawString(berat, fRow, bPine, startX + 460, startY + 4);
                    g.DrawString(total, fRow, bPine, startX + 550, startY + 4);

                    startY += 22;
                    g.DrawLine(penLine, startX, startY, startX + width, startY);

                    if (startY > e.PageBounds.Height - 100) break;
                }
            }
            else
            {
                g.DrawString("Belum ada mutasi transaksi", fRow, Brushes.Gray, startX + 10, startY + 6);
                startY += 30;
            }

            // Footer signature
            startY += 40;
            g.DrawString("Mengetahui,", fRow, bPine, startX + width - 180, startY);
            startY += 18;
            g.DrawString("Petugas Bank Sampah", fRow, bPine, startX + width - 180, startY);
            startY += 55;
            g.DrawString("( ____________________ )", fRow, bPine, startX + width - 180, startY);
        }
    }
}
