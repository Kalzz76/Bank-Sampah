using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace BankSampah
{
    public static class UIHelper
    {
        // ==========================================
        // SIMBAS PINE & GOLD DESIGN SYSTEM TOKENS
        // ==========================================
        public static Color Pine = Color.FromArgb(22, 38, 31);         // #16261F
        public static Color Pine2 = Color.FromArgb(31, 58, 46);        // #1F3A2E (Sidebar & Grid Headers)
        public static Color Sage = Color.FromArgb(238, 242, 236);      // #EEF2EC (Main Background)
        public static Color Sage2 = Color.FromArgb(220, 229, 216);     // #DCE5D8 (Borders / Accents)
        public static Color Gold = Color.FromArgb(201, 151, 31);       // #C9971F (Primary Accent & Buttons)
        public static Color GoldDark = Color.FromArgb(169, 122, 18);   // #A97A12
        public static Color Teal = Color.FromArgb(59, 122, 94);        // #3B7A5E (Tambah / Primary Action)
        public static Color Ink = Color.FromArgb(22, 36, 30);          // #16241E (Headings & Dark Text)
        public static Color InkSoft = Color.FromArgb(75, 90, 82);      // #4B5A52 (Muted Text & Labels)
        public static Color White = Color.White;
        public static Color Danger = Color.FromArgb(176, 70, 50);      // #B04632 (Hapus text)
        public static Color DangerBg = Color.FromArgb(243, 223, 217);  // #F3DFD9 (Hapus background)
        public static Color Line = Color.FromArgb(199, 210, 194);      // #C7D2C2 (Card & Input Borders)
        public static Color ZebraRow = Color.FromArgb(246, 248, 244);  // #F6F8F4
        public static Color BlueKpi = Color.FromArgb(91, 143, 176);    // #5B8FB0

        // Compatibility aliases with previous code
        public static Color PrimaryDark = Pine;
        public static Color PrimaryGreen = Teal;
        public static Color HoverGreen = Gold;
        public static Color BgLight = Sage;
        public static Color CardBg = White;
        public static Color TextDark = Ink;
        public static Color TextMuted = InkSoft;
        public static Color BorderColor = Line;

        public static void ApplyModernGridStyle(DataGridView dgv)
        {
            if (dgv == null) return;

            dgv.EnableHeadersVisualStyles = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = White;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Sage2;

            // Column Header Style: Pine-2 background, bold white text
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Pine2;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 7, 10, 7);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersHeight = 36;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Rows Style
            dgv.RowsDefaultCellStyle.BackColor = White;
            dgv.RowsDefaultCellStyle.ForeColor = Ink;
            dgv.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dgv.RowsDefaultCellStyle.SelectionBackColor = Sage2;
            dgv.RowsDefaultCellStyle.SelectionForeColor = Ink;
            dgv.RowsDefaultCellStyle.Padding = new Padding(8, 5, 8, 5);
            dgv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Zebra Rows
            dgv.AlternatingRowsDefaultCellStyle.BackColor = ZebraRow;
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Ink;
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Sage2;
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Ink;
            dgv.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.RowHeadersVisible = false;
            dgv.RowTemplate.Height = 34;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
        }


        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public static void MakeRounded(Control control, int radius = 8)
        {
            if (control == null) return;
            try
            {
                if (control.Width > 0 && control.Height > 0)
                {
                    control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, radius, radius));
                }
                control.Resize += (s, e) =>
                {
                    if (control.Width > 0 && control.Height > 0)
                    {
                        control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, radius, radius));
                    }
                };
            }
            catch { }
        }

        public static void AttachNumericOnly(TextBox txt, bool allowDecimal = true)
        {
            if (txt == null) return;
            txt.KeyPress += (s, e) =>
            {
                // Izinkan karakter kontrol (Backspace, Delete, Arrow, dll)
                if (char.IsControl(e.KeyChar)) return;
                // Izinkan angka 0-9
                if (char.IsDigit(e.KeyChar)) return;
                // Izinkan titik atau koma desimal hanya satu kali
                if (allowDecimal && (e.KeyChar == '.' || e.KeyChar == ','))
                {
                    if (!txt.Text.Contains(".") && !txt.Text.Contains(","))
                    {
                        return;
                    }
                }
                // Blokir semua huruf dan simbol lainnya
                e.Handled = true;
            };
        }

        public static void StyleButtonTeal(Button btn)
        {
            if (btn == null) return;
            btn.BackColor = Teal;
            btn.ForeColor = White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            MakeRounded(btn, 8);
        }

        public static void StyleButtonGold(Button btn)
        {
            if (btn == null) return;
            btn.BackColor = Gold;
            btn.ForeColor = Color.FromArgb(36, 26, 2);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            MakeRounded(btn, 8);
        }

        public static void StyleButtonDanger(Button btn)
        {
            if (btn == null) return;
            btn.BackColor = DangerBg;
            btn.ForeColor = Danger;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            MakeRounded(btn, 8);
        }

        public static void StyleButtonOutline(Button btn)
        {
            if (btn == null) return;
            btn.BackColor = Color.Transparent;
            btn.ForeColor = InkSoft;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Line;
            btn.FlatAppearance.BorderSize = 1;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            MakeRounded(btn, 8);
        }

        public static void StyleButtonDark(Button btn)
        {
            if (btn == null) return;
            btn.BackColor = Pine;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            MakeRounded(btn, 8);
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
            MakeRounded(btn, 8);
        }

        public static string EscapeRowFilter(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";
            return input.Replace("'", "''").Replace("[", "[[]").Replace("]", "[]]").Replace("%", "[%]");
        }

        public static void FormatGridColumns(DataGridView dgv)
        {
            if (dgv == null || dgv.Columns.Count == 0) return;

            string[] hideCols = { "id_transaksi", "id_nasabah", "id_sampah", "id_user", "created_at", "foto", "foto_nasabah", "Nama File Foto" };
            foreach (string col in hideCols)
            {
                if (dgv.Columns.Contains(col))
                {
                    dgv.Columns[col].Visible = false;
                }
            }

            if (dgv.Columns.Contains("kode_transaksi")) { dgv.Columns["kode_transaksi"].HeaderText = "Kode Trx"; dgv.Columns["kode_transaksi"].FillWeight = 14; }
            if (dgv.Columns.Contains("kode_nasabah")) { dgv.Columns["kode_nasabah"].HeaderText = "Kode"; dgv.Columns["kode_nasabah"].FillWeight = 12; }
            if (dgv.Columns.Contains("nama_nasabah")) { dgv.Columns["nama_nasabah"].HeaderText = "Nama Nasabah"; dgv.Columns["nama_nasabah"].FillWeight = 20; }
            if (dgv.Columns.Contains("nama")) { dgv.Columns["nama"].HeaderText = "Nama Lengkap"; dgv.Columns["nama"].FillWeight = 20; }
            if (dgv.Columns.Contains("nama_sampah")) { dgv.Columns["nama_sampah"].HeaderText = "Jenis Sampah"; dgv.Columns["nama_sampah"].FillWeight = 20; }
            if (dgv.Columns.Contains("jenis_sampah")) { dgv.Columns["jenis_sampah"].HeaderText = "Kategori"; dgv.Columns["jenis_sampah"].FillWeight = 14; }
            if (dgv.Columns.Contains("jenis_transaksi")) { dgv.Columns["jenis_transaksi"].HeaderText = "Tipe"; dgv.Columns["jenis_transaksi"].FillWeight = 8; }
            if (dgv.Columns.Contains("kategori")) { dgv.Columns["kategori"].HeaderText = "Detail Kategori"; dgv.Columns["kategori"].FillWeight = 14; }

            if (dgv.Columns.Contains("harga_per_kg"))
            {
                dgv.Columns["harga_per_kg"].HeaderText = "Harga / Kg";
                dgv.Columns["harga_per_kg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns["harga_per_kg"].FillWeight = 14;
            }
            if (dgv.Columns.Contains("berat_kg"))
            {
                dgv.Columns["berat_kg"].HeaderText = "Berat (kg)";
                dgv.Columns["berat_kg"].DefaultCellStyle.Format = "N2";
                dgv.Columns["berat_kg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns["berat_kg"].FillWeight = 10;
            }
            if (dgv.Columns.Contains("total_harga"))
            {
                dgv.Columns["total_harga"].HeaderText = "Nilai Setoran";
                dgv.Columns["total_harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns["total_harga"].FillWeight = 15;
            }
            if (dgv.Columns.Contains("saldo"))
            {
                dgv.Columns["saldo"].HeaderText = "Saldo";
                dgv.Columns["saldo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns["saldo"].FillWeight = 15;
            }

            if (dgv.Columns.Contains("tanggal")) { dgv.Columns["tanggal"].HeaderText = "Tanggal"; dgv.Columns["tanggal"].FillWeight = 14; }
            if (dgv.Columns.Contains("no_hp")) { dgv.Columns["no_hp"].HeaderText = "No. HP"; dgv.Columns["no_hp"].FillWeight = 14; }
            if (dgv.Columns.Contains("alamat")) { dgv.Columns["alamat"].HeaderText = "Alamat"; dgv.Columns["alamat"].FillWeight = 20; }
            if (dgv.Columns.Contains("petugas")) { dgv.Columns["petugas"].HeaderText = "Petugas"; dgv.Columns["petugas"].FillWeight = 10; }
            if (dgv.Columns.Contains("catatan")) { dgv.Columns["catatan"].HeaderText = "Catatan"; dgv.Columns["catatan"].FillWeight = 15; }

            if (dgv.Columns.Contains("FotoAvatar"))
            {
                dgv.Columns["FotoAvatar"].HeaderText = "Foto";
                dgv.Columns["FotoAvatar"].DisplayIndex = 0;
                dgv.Columns["FotoAvatar"].FillWeight = 8;
                dgv.Columns["FotoAvatar"].Width = 60;
                DataGridViewImageColumn imgCol = dgv.Columns["FotoAvatar"] as DataGridViewImageColumn;
                if (imgCol != null)
                {
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }

            // Attach event handler for guaranteed "Rp" formatting
            dgv.CellFormatting -= Dgv_CellFormattingMoney;
            dgv.CellFormatting += Dgv_CellFormattingMoney;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public static Image GetCircularAvatar(string photoFileName, string name, int size = 34)
        {
            Bitmap bmp = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                string path = "";
                if (!string.IsNullOrWhiteSpace(photoFileName) && photoFileName != "default_nasabah.png" && photoFileName != "default_sampah.png")
                {
                    path = System.IO.Path.Combine(Application.StartupPath, "Assets", "Images", photoFileName);
                    if (!System.IO.File.Exists(path))
                    {
                        string altPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "Images", photoFileName);
                        if (System.IO.File.Exists(altPath)) path = altPath;
                    }
                }

                if (!string.IsNullOrEmpty(path) && System.IO.File.Exists(path))
                {
                    try
                    {
                        using (Image src = Image.FromFile(path))
                        using (System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath())
                        {
                            gp.AddEllipse(1, 1, size - 2, size - 2);
                            g.SetClip(gp);
                            g.DrawImage(src, new Rectangle(0, 0, size, size));
                            g.ResetClip();

                            using (Pen pen = new Pen(Teal, 1.5f))
                            {
                                g.DrawEllipse(pen, 1, 1, size - 3, size - 3);
                            }
                            return bmp;
                        }
                    }
                    catch { }
                }

                // Fallback: Circular avatar with soft sage/pastel theme matching user design
                Color[] avatarBgs = new Color[] {
                    Color.FromArgb(220, 229, 216), // Sage-2
                    Color.FromArgb(210, 230, 222), // Light Teal
                    Color.FromArgb(245, 238, 215), // Soft Gold
                    Color.FromArgb(224, 236, 245), // Soft Blue
                    Color.FromArgb(238, 228, 224)  // Soft Rose
                };
                int hash = string.IsNullOrEmpty(name) ? 0 : Math.Abs(name.GetHashCode());
                Color bg = avatarBgs[hash % avatarBgs.Length];

                using (SolidBrush bgBrush = new SolidBrush(bg))
                {
                    g.FillEllipse(bgBrush, 1, 1, size - 2, size - 2);
                }
                using (Pen pen = new Pen(Color.FromArgb(190, 205, 185), 1.2f))
                {
                    g.DrawEllipse(pen, 1, 1, size - 3, size - 3);
                }

                string initial = "";
                if (!string.IsNullOrWhiteSpace(name))
                {
                    string[] parts = name.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 2) initial = (parts[0][0].ToString() + parts[1][0].ToString()).ToUpper();
                    else if (parts.Length == 1 && parts[0].Length > 0) initial = (parts[0].Length >= 2 ? parts[0].Substring(0, 2) : parts[0]).ToUpper();
                }
                if (string.IsNullOrEmpty(initial)) initial = "?";

                using (Font f = new Font("Segoe UI", size * 0.35f, FontStyle.Bold))
                using (SolidBrush textBrush = new SolidBrush(Color.FromArgb(22, 38, 31)))
                {
                    StringFormat sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    g.DrawString(initial, f, textBrush, new RectangleF(0, 0, size, size), sf);
                }
            }
            return bmp;
        }

        private static void Dgv_CellFormattingMoney(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null || e.Value == DBNull.Value) return;

            DataGridView dgv = sender as DataGridView;
            if (dgv == null || e.ColumnIndex < 0 || e.ColumnIndex >= dgv.Columns.Count) return;

            string colName = dgv.Columns[e.ColumnIndex].Name.ToLower();
            if (colName == "harga_per_kg" || colName == "total_harga" || colName == "saldo" || colName.Contains("harga") || colName.Contains("saldo"))
            {
                decimal val;
                string raw = e.Value.ToString().Replace("Rp", "").Trim();
                if (decimal.TryParse(raw, NumberStyles.Any, CultureInfo.InvariantCulture, out val) ||
                    decimal.TryParse(raw, NumberStyles.Any, CultureInfo.CurrentCulture, out val))
                {
                    e.Value = string.Format("Rp {0:N0}", val);
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
