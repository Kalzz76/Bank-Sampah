using System;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            UIHelper.StyleButtonTeal(btnSimpan);
            UIHelper.StyleButtonGold(btnUbah);
            UIHelper.StyleButtonDanger(btnHapus);
            UIHelper.StyleButtonOutline(btnBatal);
            UIHelper.StyleButtonOutline(btnPilihFoto);

            UIHelper.MakeRounded(panelFormCard, 10);
            UIHelper.MakeRounded(panelGridCard, 10);
            UIHelper.MakeRounded(btnPilihFoto, 6);
            UIHelper.MakeRounded(txtNama, 6);
            UIHelper.MakeRounded(cmbKategori, 6);
            UIHelper.MakeRounded(txtHarga, 6);

            picSampah.BorderStyle = BorderStyle.None;
            picSampah.SizeMode = PictureBoxSizeMode.CenterImage;

            txtNama.TextChanged += txtNama_TextChanged;
            dgvSampah.CellClick += dgvSampah_CellClick;
            dgvSampah.SelectionChanged += dgvSampah_SelectionChanged;

            LoadData();
            ResetForm();
        }

        private void PopulateAvatarColumn(DataTable dt)
        {
            if (dt == null) return;
            if (!dt.Columns.Contains("FotoAvatar"))
            {
                dt.Columns.Add("FotoAvatar", typeof(Image));
            }

            foreach (DataRow r in dt.Rows)
            {
                string f = r.Table.Columns.Contains("foto") && r["foto"] != DBNull.Value ? r["foto"].ToString() : "";
                string n = r.Table.Columns.Contains("nama_sampah") && r["nama_sampah"] != DBNull.Value ? r["nama_sampah"].ToString() : "";
                r["FotoAvatar"] = UIHelper.GetCircularAvatar(f, n, 34);
            }
        }

        private void LoadData()
        {
            DataTable dt = DataStore.GetSampah();
            PopulateAvatarColumn(dt);
            dgvSampah.DataSource = dt;
            UIHelper.FormatGridColumns(dgvSampah);

            if (dgvSampah.Columns.Contains("FotoAvatar"))
            {
                dgvSampah.Columns["FotoAvatar"].HeaderText = "Foto";
                dgvSampah.Columns["FotoAvatar"].DisplayIndex = 0;
                dgvSampah.Columns["FotoAvatar"].Width = 55;
            }

            dgvSampah.RowTemplate.Height = 44;
            foreach (DataGridViewRow row in dgvSampah.Rows)
            {
                row.Height = 44;
            }
        }

        private void ResetForm()
        {
            selectedId = 0;
            txtNama.Clear();
            if (cmbKategori.Items.Count > 0) cmbKategori.SelectedIndex = 0;
            txtHarga.Clear();
            currentFotoFile = "default_sampah.png";
            UpdatePreviewAvatar();

            btnSimpan.Enabled = true;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void UpdatePreviewAvatar()
        {
            try
            {
                if (picSampah.Image != null) picSampah.Image.Dispose();
                picSampah.Image = UIHelper.GetCircularAvatar(currentFotoFile, txtNama.Text, 84);
            }
            catch { }
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            if (currentFotoFile == "default_sampah.png" || string.IsNullOrWhiteSpace(currentFotoFile))
            {
                UpdatePreviewAvatar();
            }
        }

        private void btnPilihFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.png; *.jpg; *.jpeg)|*.png;*.jpg;*.jpeg";
                ofd.Title = "Pilih Foto Jenis Sampah";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string dir = Path.Combine(Application.StartupPath, "Assets", "Images");
                        if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                        string ext = Path.GetExtension(ofd.FileName);
                        string newFileName = string.Format("smp_{0}_{1}{2}", DateTime.Now.ToString("yyyyMMddHHmmss"), selectedId, ext);
                        string targetPath = Path.Combine(dir, newFileName);

                        File.Copy(ofd.FileName, targetPath, true);

                        string projectDir = Path.Combine(Application.StartupPath, "..", "..", "Assets", "Images");
                        if (Directory.Exists(projectDir))
                        {
                            try { File.Copy(ofd.FileName, Path.Combine(projectDir, newFileName), true); } catch { }
                        }

                        currentFotoFile = newFileName;
                        UpdatePreviewAvatar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal memuat foto: " + ex.Message, "Error Foto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string DetermineKelasSampah(string kategori)
        {
            if (kategori == "Organik") return "Organik";
            if (kategori.Contains("B3")) return "B3 (Berbahaya)";
            return "Anorganik";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) || cmbKategori.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtHarga.Text))
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Nama Sampah, Kategori, dan Harga per Kg wajib diisi!", "Validasi Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal harga = 0;
            string hargaStr = txtHarga.Text.Replace(".", "").Replace(",", ".");
            if (!decimal.TryParse(hargaStr, NumberStyles.Any, CultureInfo.InvariantCulture, out harga))
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Harga per Kg harus berupa angka valid!", "Validasi Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kategori = cmbKategori.SelectedItem.ToString();
            string jenis = DetermineKelasSampah(kategori);

            DataStore.AddSampah(txtNama.Text.Trim(), jenis, kategori, harga, currentFotoFile);
            SoundHelper.PlaySaveSound();
            MessageBox.Show("Data Jenis Sampah Berhasil Ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ResetForm();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) return;

            if (string.IsNullOrWhiteSpace(txtNama.Text) || cmbKategori.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtHarga.Text))
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Semua kolom data sampah wajib diisi!", "Validasi Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal harga = 0;
            string hargaStr = txtHarga.Text.Replace(".", "").Replace(",", ".");
            if (!decimal.TryParse(hargaStr, NumberStyles.Any, CultureInfo.InvariantCulture, out harga))
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Harga per Kg harus berupa angka valid!", "Validasi Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kategori = cmbKategori.SelectedItem.ToString();
            string jenis = DetermineKelasSampah(kategori);

            DataStore.UpdateSampah(selectedId, txtNama.Text.Trim(), jenis, kategori, harga, currentFotoFile);
            SoundHelper.PlaySaveSound();
            MessageBox.Show("Data Jenis Sampah Berhasil Diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ResetForm();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) return;

            if (MessageBox.Show("Apakah Anda yakin ingin menghapus data jenis sampah ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void PopulateFormFromRow(DataGridViewRow row)
        {
            if (row == null || row.Index < 0) return;
            try
            {
                if (row.Cells["id_sampah"].Value != null && row.Cells["id_sampah"].Value != DBNull.Value)
                {
                    selectedId = Convert.ToInt32(row.Cells["id_sampah"].Value);
                }
                if (row.Cells["nama_sampah"].Value != null && row.Cells["nama_sampah"].Value != DBNull.Value)
                {
                    txtNama.Text = row.Cells["nama_sampah"].Value.ToString();
                }
                if (row.Cells["kategori"].Value != null && row.Cells["kategori"].Value != DBNull.Value)
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
                if (row.Cells["harga_per_kg"].Value != null && row.Cells["harga_per_kg"].Value != DBNull.Value)
                {
                    decimal h = Convert.ToDecimal(row.Cells["harga_per_kg"].Value);
                    txtHarga.Text = h.ToString("N0");
                }

                if (dgvSampah.Columns.Contains("foto") && row.Cells["foto"].Value != null && row.Cells["foto"].Value != DBNull.Value)
                {
                    currentFotoFile = row.Cells["foto"].Value.ToString();
                }
                else
                {
                    currentFotoFile = "default_sampah.png";
                }
                UpdatePreviewAvatar();

                btnSimpan.Enabled = false;
                btnUbah.Enabled = true;
                btnHapus.Enabled = true;
            }
            catch { }
        }

        private void dgvSampah_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PopulateFormFromRow(dgvSampah.Rows[e.RowIndex]);
            }
        }

        private void dgvSampah_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSampah.CurrentRow != null && dgvSampah.CurrentRow.Index >= 0)
            {
                PopulateFormFromRow(dgvSampah.CurrentRow);
            }
        }
    }
}
