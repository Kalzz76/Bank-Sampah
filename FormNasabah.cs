using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BankSampah
{
    public partial class FormNasabah : Form
    {
        private int selectedId = 0;
        private string currentFotoFile = "default_nasabah.png";

        public FormNasabah()
        {
            InitializeComponent();
        }

        private void FormNasabah_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyModernGridStyle(dgvNasabah);
            UIHelper.StyleButtonTeal(btnSimpan);
            UIHelper.StyleButtonGold(btnUbah);
            UIHelper.StyleButtonDanger(btnHapus);
            UIHelper.StyleButtonOutline(btnBatal);
            UIHelper.StyleButtonDark(btnRiwayat);

            UIHelper.MakeRounded(panelFormCard, 10);
            UIHelper.MakeRounded(panelGridCard, 10);
            UIHelper.MakeRounded(btnPilihFoto, 6);
            UIHelper.MakeRounded(btnHapusFoto, 6);
            UIHelper.MakeRounded(btnRiwayat, 6);
            UIHelper.MakeRounded(txtNama, 6);
            UIHelper.MakeRounded(txtNoHp, 6);
            UIHelper.MakeRounded(txtAlamat, 6);
            UIHelper.MakeRounded(txtCari, 6);

            picNasabah.BorderStyle = BorderStyle.None;
            picNasabah.SizeMode = PictureBoxSizeMode.CenterImage;

            dgvNasabah.CellClick += dgvNasabah_CellClick;
            dgvNasabah.SelectionChanged += dgvNasabah_SelectionChanged;
            dgvNasabah.CellDoubleClick += dgvNasabah_CellDoubleClick;
            txtNama.TextChanged += txtNama_TextChanged;

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
            if (!dt.Columns.Contains("LevelBadge"))
            {
                dt.Columns.Add("LevelBadge", typeof(string));
            }

            foreach (DataRow r in dt.Rows)
            {
                string f = r.Table.Columns.Contains("foto") && r["foto"] != DBNull.Value ? r["foto"].ToString() : "";
                string n = r.Table.Columns.Contains("nama") && r["nama"] != DBNull.Value ? r["nama"].ToString() : "";
                r["FotoAvatar"] = UIHelper.GetCircularAvatar(f, n, 34);

                int idN = r["id_nasabah"] != DBNull.Value ? Convert.ToInt32(r["id_nasabah"]) : 0;
                decimal totalKg = DataStore.GetTotalSampahNasabah(idN);
                r["LevelBadge"] = DataStore.GetBadgeNasabah(totalKg);
            }
        }

        private void LoadData()
        {
            DataTable dt = DataStore.GetNasabah();
            PopulateAvatarColumn(dt);
            dgvNasabah.DataSource = dt;
            UIHelper.FormatGridColumns(dgvNasabah);

            if (dgvNasabah.Columns.Contains("LevelBadge"))
            {
                dgvNasabah.Columns["LevelBadge"].HeaderText = "Badge Level";
                dgvNasabah.Columns["LevelBadge"].Width = 145;
            }

            dgvNasabah.RowTemplate.Height = 44;
            foreach (DataGridViewRow row in dgvNasabah.Rows)
            {
                row.Height = 44;
            }
        }

        private void ResetForm()
        {
            selectedId = 0;
            txtNama.Clear();
            txtAlamat.Clear();
            txtNoHp.Clear();
            txtCari.Clear();
            currentFotoFile = "default_nasabah.png";
            UpdatePreviewAvatar();

            btnSimpan.Enabled = true;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
            btnRiwayat.Enabled = false;
        }

        private void UpdatePreviewAvatar()
        {
            try
            {
                if (picNasabah.Image != null) picNasabah.Image.Dispose();
                picNasabah.Image = UIHelper.GetCircularAvatar(currentFotoFile, txtNama.Text, 96);
            }
            catch { }
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            if (currentFotoFile == "default_nasabah.png" || string.IsNullOrWhiteSpace(currentFotoFile))
            {
                UpdatePreviewAvatar();
            }
        }

        private void btnPilihFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.png; *.jpg; *.jpeg)|*.png;*.jpg;*.jpeg";
                ofd.Title = "Pilih Foto Nasabah";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string dir = Path.Combine(Application.StartupPath, "Assets", "Images");
                        if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                        string ext = Path.GetExtension(ofd.FileName);
                        string newFileName = string.Format("nsb_{0}_{1}{2}", DateTime.Now.ToString("yyyyMMddHHmmss"), selectedId, ext);
                        string targetPath = Path.Combine(dir, newFileName);

                        File.Copy(ofd.FileName, targetPath, true);
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

        private void btnHapusFoto_Click(object sender, EventArgs e)
        {
            if (currentFotoFile == "default_nasabah.png" || string.IsNullOrWhiteSpace(currentFotoFile))
            {
                MessageBox.Show("Foto sudah menggunakan inisial bawaan.", "Info Foto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Hapus foto profil nasabah dan gunakan avatar inisial?", "Konfirmasi Hapus Foto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                currentFotoFile = "default_nasabah.png";
                UpdatePreviewAvatar();

                if (selectedId > 0)
                {
                    string kode = "NSB-" + selectedId.ToString("D3");
                    DataStore.UpdateNasabah(selectedId, kode, txtNama.Text.Trim(), txtAlamat.Text.Trim(), txtNoHp.Text.Trim(), currentFotoFile);
                    LoadData();
                    SoundHelper.PlaySaveSound();
                    MessageBox.Show("Foto nasabah berhasil dihapus dan diganti dengan inisial!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Nama Nasabah wajib diisi!", "Validasi Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kode = "NSB-" + (dgvNasabah.Rows.Count + 1).ToString("D3");
            DataStore.AddNasabah(kode, txtNama.Text.Trim(), txtAlamat.Text.Trim(), txtNoHp.Text.Trim(), 0, currentFotoFile);
            SoundHelper.PlaySaveSound();
            MessageBox.Show("Data Nasabah Berhasil Ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ResetForm();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) return;

            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Nama Nasabah wajib diisi!", "Validasi Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kode = "NSB-" + selectedId.ToString("D3");
            DataStore.UpdateNasabah(selectedId, kode, txtNama.Text.Trim(), txtAlamat.Text.Trim(), txtNoHp.Text.Trim(), currentFotoFile);
            SoundHelper.PlaySaveSound();
            MessageBox.Show("Data Nasabah Berhasil Diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ResetForm();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) return;

            if (MessageBox.Show("Apakah Anda yakin ingin menghapus data nasabah ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataStore.DeleteNasabah(selectedId);
                SoundHelper.PlaySaveSound();
                MessageBox.Show("Data Nasabah Berhasil Dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (row.Cells["id_nasabah"].Value != null && row.Cells["id_nasabah"].Value != DBNull.Value)
                {
                    selectedId = Convert.ToInt32(row.Cells["id_nasabah"].Value);
                }
                if (row.Cells["nama"].Value != null && row.Cells["nama"].Value != DBNull.Value)
                {
                    txtNama.Text = row.Cells["nama"].Value.ToString();
                }
                if (row.Cells["no_hp"].Value != null && row.Cells["no_hp"].Value != DBNull.Value)
                {
                    txtNoHp.Text = row.Cells["no_hp"].Value.ToString();
                }
                if (row.Cells["alamat"].Value != null && row.Cells["alamat"].Value != DBNull.Value)
                {
                    txtAlamat.Text = row.Cells["alamat"].Value.ToString();
                }

                if (dgvNasabah.Columns.Contains("foto") && row.Cells["foto"].Value != null && row.Cells["foto"].Value != DBNull.Value)
                {
                    currentFotoFile = row.Cells["foto"].Value.ToString();
                }
                else
                {
                    currentFotoFile = "default_nasabah.png";
                }
                UpdatePreviewAvatar();

                btnSimpan.Enabled = false;
                btnUbah.Enabled = true;
                btnHapus.Enabled = true;
                btnRiwayat.Enabled = true;
            }
            catch { }
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            if (selectedId <= 0)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Pilih salah satu nasabah di tabel terlebih dahulu untuk melihat riwayat transaksinya.", "Pilih Nasabah", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string kode = "NSB-" + selectedId.ToString("D3");
            decimal saldo = 0;
            if (dgvNasabah.CurrentRow != null && dgvNasabah.CurrentRow.Cells["saldo"].Value != null)
            {
                string rawSaldo = dgvNasabah.CurrentRow.Cells["saldo"].Value.ToString().Replace("Rp", "").Trim();
                decimal.TryParse(rawSaldo, out saldo);
            }

            FormRiwayatNasabah frm = new FormRiwayatNasabah(selectedId, kode, txtNama.Text, txtNoHp.Text, txtAlamat.Text, saldo, currentFotoFile);
            frm.ShowDialog(this);
        }

        private void dgvNasabah_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && selectedId > 0)
            {
                btnRiwayat_Click(sender, EventArgs.Empty);
            }
        }

        private void dgvNasabah_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNasabah.Rows.Count)
            {
                PopulateFormFromRow(dgvNasabah.Rows[e.RowIndex]);
            }
        }

        private void dgvNasabah_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNasabah.CurrentRow != null && dgvNasabah.CurrentRow.Index >= 0)
            {
                PopulateFormFromRow(dgvNasabah.CurrentRow);
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string keyword = UIHelper.EscapeRowFilter(txtCari.Text.Trim().ToLower());
            DataTable dt = DataStore.GetNasabah();
            if (!string.IsNullOrEmpty(keyword) && dt != null)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("kode_nasabah LIKE '%{0}%' OR nama LIKE '%{0}%' OR alamat LIKE '%{0}%' OR no_hp LIKE '%{0}%'", keyword);
                DataTable dtFiltered = dv.ToTable();
                PopulateAvatarColumn(dtFiltered);
                dgvNasabah.DataSource = dtFiltered;
                UIHelper.FormatGridColumns(dgvNasabah);
                dgvNasabah.RowTemplate.Height = 44;
                foreach (DataGridViewRow row in dgvNasabah.Rows)
                {
                    row.Height = 44;
                }
            }
            else
            {
                LoadData();
            }
        }
    }
}
