using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace BankSampah
{
    public partial class FormSampah : Form
    {
        private int selectedId = 0;

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

            UIHelper.MakeRounded(panelFormCard, 10);
            UIHelper.MakeRounded(panelGridCard, 10);
            UIHelper.MakeRounded(txtNama, 6);
            UIHelper.MakeRounded(cmbKategori, 6);
            UIHelper.MakeRounded(txtHarga, 6);

            LoadData();
            ResetForm();
        }

        private void LoadData()
        {
            DataTable dt = DataStore.GetSampah();
            dgvSampah.DataSource = dt;
            UIHelper.FormatGridColumns(dgvSampah);
        }

        private void ResetForm()
        {
            selectedId = 0;
            txtNama.Clear();
            if (cmbKategori.Items.Count > 0) cmbKategori.SelectedIndex = 0;
            txtHarga.Clear();

            btnSimpan.Enabled = true;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
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

            DataStore.AddSampah(txtNama.Text.Trim(), jenis, kategori, harga, "default_sampah.png");
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

            DataStore.UpdateSampah(selectedId, txtNama.Text.Trim(), jenis, kategori, harga, "default_sampah.png");
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

        private void dgvSampah_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSampah.Rows[e.RowIndex];
                if (row.Cells["id_sampah"].Value != null)
                {
                    selectedId = Convert.ToInt32(row.Cells["id_sampah"].Value);
                }
                if (row.Cells["nama_sampah"].Value != null)
                {
                    txtNama.Text = row.Cells["nama_sampah"].Value.ToString();
                }
                if (row.Cells["kategori"].Value != null)
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
                if (row.Cells["harga_per_kg"].Value != null)
                {
                    decimal h = Convert.ToDecimal(row.Cells["harga_per_kg"].Value);
                    txtHarga.Text = h.ToString("N0");
                }

                btnSimpan.Enabled = false;
                btnUbah.Enabled = true;
                btnHapus.Enabled = true;
            }
        }
    }
}
