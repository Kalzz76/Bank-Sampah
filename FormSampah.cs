using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace BankSampah
{
    public partial class FormSampah : Form
    {
        private int selectedId = 0;
        private string currentFotoFile = "default_sampah.png";

        public FormSampah()
        {
            InitializeComponent();
        }

        private void FormSampah_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyModernGridStyle(dgvSampah);
            EnsureSampleImagesExist();
            LoadData();
            ResetForm();
        }

        private void EnsureSampleImagesExist()
        {
            try
            {
                string dir = Path.Combine(Application.StartupPath, "Assets", "Images");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                CreateSampleImageIfMissing(dir, "botol_plastik.png", "♻️ PLASTIK PET", "Anorganik", Color.FromArgb(6, 182, 212), Color.FromArgb(14, 116, 144));
                CreateSampleImageIfMissing(dir, "kardus.png", "📦 KARDUS BEKAS", "Anorganik", Color.FromArgb(245, 158, 11), Color.FromArgb(180, 83, 9));
                CreateSampleImageIfMissing(dir, "besi_kaleng.png", "🥫 BESI & KALENG", "Anorganik", Color.FromArgb(100, 116, 139), Color.FromArgb(51, 65, 85));
                CreateSampleImageIfMissing(dir, "botol_kaca.png", "🍾 BOTOL KACA", "Anorganik", Color.FromArgb(16, 185, 129), Color.FromArgb(4, 120, 87));
                CreateSampleImageIfMissing(dir, "organik_kompos.png", "🍃 ORGANIK KOMPOS", "Organik", Color.FromArgb(34, 197, 94), Color.FromArgb(21, 128, 61));
                CreateSampleImageIfMissing(dir, "baterai_b3.png", "⚠️ BATERAI & B3", "B3 (Berbahaya)", Color.FromArgb(239, 68, 68), Color.FromArgb(185, 28, 28));
                CreateSampleImageIfMissing(dir, "kertas_hvs.png", "📄 KERTAS HVS", "Anorganik", Color.FromArgb(234, 179, 8), Color.FromArgb(161, 98, 7));
                CreateSampleImageIfMissing(dir, "plastik_gelas.png", "🥤 PLASTIK GELAS", "Anorganik", Color.FromArgb(20, 184, 166), Color.FromArgb(15, 118, 110));
                CreateSampleImageIfMissing(dir, "default_sampah.png", "🌱 BANK SAMPAH", "Eco-Emerald", Color.FromArgb(16, 185, 129), Color.FromArgb(6, 78, 59));
            }
            catch { }
        }

        private void CreateSampleImageIfMissing(string folder, string fileName, string textTitle, string textSub, Color color1, Color color2)
        {
            string fullPath = Path.Combine(folder, fileName);
            if (File.Exists(fullPath)) return;

            using (Bitmap bmp = new Bitmap(240, 240))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    using (LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, 240, 240), color1, color2, LinearGradientMode.ForwardDiagonal))
                    {
                        g.FillRectangle(brush, 0, 0, 240, 240);
                    }

                    using (Pen pen = new Pen(Color.FromArgb(180, Color.White), 4))
                    {
                        g.DrawRectangle(pen, 10, 10, 220, 220);
                    }

                    using (SolidBrush badgeBrush = new SolidBrush(Color.FromArgb(200, Color.Black)))
                    {
                        g.FillRectangle(badgeBrush, 20, 30, 200, 30);
                    }

                    using (Font subFont = new Font("Segoe UI", 9.5F, FontStyle.Bold))
                    using (SolidBrush textBrush = new SolidBrush(Color.White))
                    {
                        StringFormat sfCenter = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                        g.DrawString(textSub.ToUpper(), subFont, textBrush, new RectangleF(20, 30, 200, 30), sfCenter);
                        
                        using (Font titleFont = new Font("Segoe UI", 12F, FontStyle.Bold))
                        {
                            g.DrawString(textTitle, titleFont, textBrush, new RectangleF(15, 90, 210, 110), sfCenter);
                        }
                    }
                }
                bmp.Save(fullPath, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void LoadData()
        {
            DataTable dt = DataStore.GetSampah();
            dgvSampah.DataSource = dt;
            UIHelper.FormatGridColumns(dgvSampah);
            lblRecordBadge.Text = string.Format("♻️ KATALOG: {0} JENIS SAMPAH | 💡 KLIK BARIS UNTUK PRATINJAU FOTO", dt != null ? dt.Rows.Count : 0);
        }

        private void ResetForm()
        {
            selectedId = 0;
            txtNama.Clear();
            cmbJenis.SelectedIndex = 0; // Default Anorganik (Memicu cmbJenis_SelectedIndexChanged)
            txtHarga.Clear();
            txtCari.Clear();
            currentFotoFile = "default_sampah.png";
            if (cmbJenis.SelectedItem != null)
            {
                LoadImagePreview(currentFotoFile, cmbJenis.SelectedItem.ToString(), "Default");
            }

            btnSimpan.Enabled = true;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void LoadImagePreview(string fileName, string jenis, string nama)
        {
            try
            {
                if (picFoto.Image != null)
                {
                    picFoto.Image.Dispose();
                    picFoto.Image = null;
                }

                string dir = Path.Combine(Application.StartupPath, "Assets", "Images");
                string fullPath = Path.Combine(dir, fileName);

                if (File.Exists(fullPath))
                {
                    using (FileStream stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                    {
                        picFoto.Image = Image.FromStream(stream);
                    }
                }
                else if (File.Exists(fileName))
                {
                    using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                    {
                        picFoto.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    picFoto.Image = GenerateDynamicBadgeBitmap(jenis, nama);
                }
            }
            catch
            {
                picFoto.Image = GenerateDynamicBadgeBitmap(jenis, nama);
            }
        }

        private Bitmap GenerateDynamicBadgeBitmap(string jenis, string nama)
        {
            Bitmap bmp = new Bitmap(240, 240);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Color bg1 = Color.FromArgb(16, 185, 129);
                Color bg2 = Color.FromArgb(6, 78, 59);

                if (jenis != null && jenis.Contains("Organik") && !jenis.Contains("Anorganik"))
                {
                    bg1 = Color.FromArgb(34, 197, 94);
                    bg2 = Color.FromArgb(21, 128, 61);
                }
                else if (jenis != null && jenis.Contains("B3"))
                {
                    bg1 = Color.FromArgb(239, 68, 68);
                    bg2 = Color.FromArgb(185, 28, 28);
                }

                using (LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, 240, 240), bg1, bg2, LinearGradientMode.ForwardDiagonal))
                {
                    g.FillRectangle(brush, 0, 0, 240, 240);
                }

                using (Font f1 = new Font("Segoe UI", 10F, FontStyle.Bold))
                using (Font f2 = new Font("Segoe UI", 12F, FontStyle.Bold))
                using (SolidBrush textBrush = new SolidBrush(Color.White))
                {
                    StringFormat sfCenter = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    g.DrawString(jenis != null ? jenis.ToUpper() : "SAMPAH", f1, textBrush, new RectangleF(10, 40, 220, 30), sfCenter);
                    g.DrawString(nama != null ? nama : "Katalog Sampah", f2, textBrush, new RectangleF(10, 90, 220, 100), sfCenter);
                }
            }
            return bmp;
        }

        private void btnBrowseFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.bmp)|*.png;*.jpg;*.jpeg;*.bmp";
                ofd.Title = "Pilih Foto Sampah";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string dir = Path.Combine(Application.StartupPath, "Assets", "Images");
                        if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                        string ext = Path.GetExtension(ofd.FileName);
                        string newFileName = string.Format("sampah_{0}_{1}{2}", DateTime.Now.ToString("yyyyMMddHHmmss"), selectedId, ext);
                        string targetPath = Path.Combine(dir, newFileName);

                        File.Copy(ofd.FileName, targetPath, true);
                        currentFotoFile = newFileName;

                        LoadImagePreview(currentFotoFile, cmbJenis.SelectedItem != null ? cmbJenis.SelectedItem.ToString() : "Anorganik", txtNama.Text);
                        SoundHelper.PlaySaveSound();
                        MessageBox.Show("Foto Sampah Berhasil Diunggah!", "Sukses Upload", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        SoundHelper.PlayAlertSound();
                        MessageBox.Show("Gagal mengunggah foto: " + ex.Message, "Error Upload", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cmbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbJenis.SelectedItem == null) return;

            string jenis = cmbJenis.SelectedItem.ToString();
            string previousKategori = cmbKategori.SelectedItem != null ? cmbKategori.SelectedItem.ToString() : "";

            cmbKategori.Items.Clear();

            if (jenis == "Organik")
            {
                cmbKategori.Items.Add("Kompos & Sisa Dapur");
                cmbKategori.Items.Add("Kompos");
                cmbKategori.Items.Add("Daun & Sampah Kebun");
                cmbKategori.Items.Add("Kayu & Ranting");
                cmbKategori.Items.Add("Lain-lain (Organik)");
            }
            else if (jenis.Contains("B3"))
            {
                cmbKategori.Items.Add("Baterai & Akumulator");
                cmbKategori.Items.Add("B3 Elektronik / E-Waste");
                cmbKategori.Items.Add("B3 Elektronik");
                cmbKategori.Items.Add("Lampu TL & Kaca B3");
                cmbKategori.Items.Add("Oli & Kemasan Bahan Kimia");
                cmbKategori.Items.Add("Lain-lain (B3)");
            }
            else // Anorganik
            {
                cmbKategori.Items.Add("Plastik");
                cmbKategori.Items.Add("Kertas");
                cmbKategori.Items.Add("Logam");
                cmbKategori.Items.Add("Kaca");
                cmbKategori.Items.Add("Minyak Jelantah");
                cmbKategori.Items.Add("Lain-lain (Anorganik)");
            }

            if (!string.IsNullOrEmpty(previousKategori) && cmbKategori.Items.Contains(previousKategori))
            {
                cmbKategori.SelectedItem = previousKategori;
            }
            else if (cmbKategori.Items.Count > 0)
            {
                cmbKategori.SelectedIndex = 0;
            }

            if (currentFotoFile == "default_sampah.png" || string.IsNullOrEmpty(currentFotoFile))
            {
                LoadImagePreview(currentFotoFile, jenis, txtNama.Text);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) || cmbJenis.SelectedIndex == -1 || cmbKategori.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtHarga.Text))
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Semua kolom data sampah (Nama, Kelas, Kategori, Harga) wajib diisi!", "Validasi Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal harga = 0;
            if (!decimal.TryParse(txtHarga.Text, out harga))
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Harga per Kg harus berupa angka!", "Validasi Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string jenis = cmbJenis.SelectedItem.ToString();
            string kategori = cmbKategori.SelectedItem.ToString();

            DataStore.AddSampah(txtNama.Text.Trim(), jenis, kategori, harga, currentFotoFile);
            SoundHelper.PlaySaveSound();
            MessageBox.Show("Data Jenis Sampah & Foto Berhasil Disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ResetForm();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) return;

            if (string.IsNullOrWhiteSpace(txtNama.Text) || cmbJenis.SelectedIndex == -1 || cmbKategori.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtHarga.Text))
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Semua kolom data sampah wajib diisi!", "Validasi Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal harga = 0;
            if (!decimal.TryParse(txtHarga.Text, out harga))
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Harga per Kg harus berupa angka!", "Validasi Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string jenis = cmbJenis.SelectedItem.ToString();
            string kategori = cmbKategori.SelectedItem.ToString();

            DataStore.UpdateSampah(selectedId, txtNama.Text.Trim(), jenis, kategori, harga, currentFotoFile);
            SoundHelper.PlaySaveSound();
            MessageBox.Show("Data Jenis Sampah & Foto Berhasil Diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ResetForm();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) return;

            if (MessageBox.Show("Apakah Anda yakin ingin menghapus data sampah ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataStore.DeleteSampah(selectedId);
                SoundHelper.PlaySaveSound();
                MessageBox.Show("Data Jenis Sampah Berhasil Dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ResetForm();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void dgvSampah_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSampah.Rows[e.RowIndex];

                if (dgvSampah.Columns.Contains("id_sampah") && row.Cells["id_sampah"].Value != null)
                {
                    selectedId = Convert.ToInt32(row.Cells["id_sampah"].Value);
                }

                if (dgvSampah.Columns.Contains("nama_sampah") && row.Cells["nama_sampah"].Value != null)
                {
                    txtNama.Text = row.Cells["nama_sampah"].Value.ToString();
                }

                string jenis = "Anorganik";
                if (dgvSampah.Columns.Contains("jenis_sampah") && row.Cells["jenis_sampah"].Value != null && row.Cells["jenis_sampah"].Value != DBNull.Value)
                {
                    jenis = row.Cells["jenis_sampah"].Value.ToString();
                }

                if (cmbJenis.Items.Contains(jenis))
                {
                    cmbJenis.SelectedItem = jenis;
                }
                else
                {
                    cmbJenis.SelectedIndex = 0;
                }

                if (dgvSampah.Columns.Contains("kategori") && row.Cells["kategori"].Value != null && row.Cells["kategori"].Value != DBNull.Value)
                {
                    string kat = row.Cells["kategori"].Value.ToString();
                    if (cmbKategori.Items.Contains(kat))
                    {
                        cmbKategori.SelectedItem = kat;
                    }
                    else
                    {
                        cmbKategori.Items.Add(kat);
                        cmbKategori.SelectedItem = kat;
                    }
                }

                if (dgvSampah.Columns.Contains("harga_per_kg") && row.Cells["harga_per_kg"].Value != null)
                {
                    txtHarga.Text = Convert.ToDecimal(row.Cells["harga_per_kg"].Value).ToString("0.##");
                }

                if (dgvSampah.Columns.Contains("foto") && row.Cells["foto"].Value != null && row.Cells["foto"].Value != DBNull.Value)
                {
                    currentFotoFile = row.Cells["foto"].Value.ToString();
                }
                else
                {
                    currentFotoFile = "default_sampah.png";
                }

                LoadImagePreview(currentFotoFile, cmbJenis.SelectedItem != null ? cmbJenis.SelectedItem.ToString() : jenis, txtNama.Text);

                btnSimpan.Enabled = false;
                btnUbah.Enabled = true;
                btnHapus.Enabled = true;
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtCari.Text.Trim().ToLower();
            DataTable dt = DataStore.GetSampah();
            if (!string.IsNullOrEmpty(keyword) && dt != null)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("nama_sampah LIKE '%{0}%' OR jenis_sampah LIKE '%{0}%' OR kategori LIKE '%{0}%'", keyword);
                DataTable dtFiltered = dv.ToTable();
                dgvSampah.DataSource = dtFiltered;
                UIHelper.FormatGridColumns(dgvSampah);
                lblRecordBadge.Text = string.Format("🔍 DITEMUKAN: {0} SAMPAH", dtFiltered.Rows.Count);
            }
            else
            {
                LoadData();
            }
        }
    }
}
