using System;
using System.Drawing;
using System.Windows.Forms;

namespace BankSampah
{
    public static class UIHelper
    {
        // Color Palette (Default Emerald)
        public static Color PrimaryDark = Color.FromArgb(6, 78, 59);      // Deep Emerald
        public static Color PrimaryGreen = Color.FromArgb(16, 185, 129);   // Vivid Green Accent
        public static Color HoverGreen = Color.FromArgb(5, 150, 105);     // Darker Green Hover
        public static Color BgLight = Color.FromArgb(240, 244, 242);      // Soft Cool Gray-Green
        public static Color CardBg = Color.White;
        public static Color TextDark = Color.FromArgb(15, 23, 42);        // Slate 900
        public static Color TextMuted = Color.FromArgb(100, 116, 139);    // Slate 500
        public static Color BorderColor = Color.FromArgb(226, 232, 240);   // Slate 200

        public static void ApplyModernGridStyle(DataGridView dgv)
        {
            if (dgv == null) return;

            dgv.EnableHeadersVisualStyles = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(226, 232, 240);

            // Column Header Style (Center Aligned)
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = PrimaryDark;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 6, 8, 6);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = 38;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Rows Style (Center Aligned for standard cells)
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.RowsDefaultCellStyle.ForeColor = TextDark;
            dgv.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dgv.RowsDefaultCellStyle.SelectionBackColor = PrimaryGreen;
            dgv.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgv.RowsDefaultCellStyle.Padding = new Padding(6, 4, 6, 4);
            dgv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(244, 248, 246);
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = TextDark;
            dgv.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.RowHeadersVisible = false;
            dgv.RowTemplate.Height = 32;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
        }

        public static void FormatButton(Button btn, Color bg, Color fg)
        {
            if (btn == null) return;
            btn.BackColor = bg;
            btn.ForeColor = fg;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        }

        public static void FormatGridColumns(DataGridView dgv)
        {
            if (dgv == null || dgv.Columns.Count == 0) return;

            // Sembunyikan kolom ID internal database & foto file yang tidak perlu ditampilkan di tabel
            string[] hideCols = { "id_transaksi", "id_nasabah", "id_sampah", "id_user", "created_at", "foto", "foto_nasabah", "Nama File Foto" };
            foreach (string col in hideCols)
            {
                if (dgv.Columns.Contains(col))
                {
                    dgv.Columns[col].Visible = false;
                }
            }

            // Ubah Header Text ke Bahasa Indonesia yang Rapi & Jelas
            if (dgv.Columns.Contains("kode_transaksi")) dgv.Columns["kode_transaksi"].HeaderText = "Kode Trx";
            if (dgv.Columns.Contains("kode_nasabah")) dgv.Columns["kode_nasabah"].HeaderText = "Kode Nasabah";
            if (dgv.Columns.Contains("nama_nasabah")) dgv.Columns["nama_nasabah"].HeaderText = "Nama Nasabah";
            if (dgv.Columns.Contains("nama")) dgv.Columns["nama"].HeaderText = "Nama Nasabah";
            if (dgv.Columns.Contains("nama_sampah")) dgv.Columns["nama_sampah"].HeaderText = "Nama Sampah";
            if (dgv.Columns.Contains("jenis_sampah")) dgv.Columns["jenis_sampah"].HeaderText = "Kelas Sampah";
            if (dgv.Columns.Contains("jenis_transaksi")) dgv.Columns["jenis_transaksi"].HeaderText = "Jenis Trx";
            if (dgv.Columns.Contains("kategori")) dgv.Columns["kategori"].HeaderText = "Kategori Detail";
            
            if (dgv.Columns.Contains("harga_per_kg"))
            {
                dgv.Columns["harga_per_kg"].HeaderText = "Harga / Kg (Rp)";
                dgv.Columns["harga_per_kg"].DefaultCellStyle.Format = "N0";
                dgv.Columns["harga_per_kg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgv.Columns.Contains("berat_kg"))
            {
                dgv.Columns["berat_kg"].HeaderText = "Berat (Kg)";
                dgv.Columns["berat_kg"].DefaultCellStyle.Format = "N2";
                dgv.Columns["berat_kg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgv.Columns.Contains("total_harga"))
            {
                dgv.Columns["total_harga"].HeaderText = "Total (Rp)";
                dgv.Columns["total_harga"].DefaultCellStyle.Format = "N0";
                dgv.Columns["total_harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgv.Columns.Contains("saldo"))
            {
                dgv.Columns["saldo"].HeaderText = "Saldo Tabungan (Rp)";
                dgv.Columns["saldo"].DefaultCellStyle.Format = "N0";
                dgv.Columns["saldo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgv.Columns.Contains("tgl_transaksi")) dgv.Columns["tgl_transaksi"].HeaderText = "Tanggal Trx";
            if (dgv.Columns.Contains("tanggal")) dgv.Columns["tanggal"].HeaderText = "Tanggal Trx";
            if (dgv.Columns.Contains("tgl_daftar")) dgv.Columns["tgl_daftar"].HeaderText = "Tgl Daftar";
            if (dgv.Columns.Contains("no_hp")) dgv.Columns["no_hp"].HeaderText = "No. Telepon / HP";
            if (dgv.Columns.Contains("alamat")) dgv.Columns["alamat"].HeaderText = "Alamat Lengkap";
            if (dgv.Columns.Contains("petugas")) dgv.Columns["petugas"].HeaderText = "Petugas";
            if (dgv.Columns.Contains("catatan")) dgv.Columns["catatan"].HeaderText = "Catatan Trx";

            // Atur alignment seluruh kolom ke Center
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Gunakan Fill agar tabel membentang 100% penuh mengisi lebar panel
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
