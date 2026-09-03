using System;
using System.Data;
using System.Windows.Forms;

namespace BankSampah
{
    public partial class FormNasabah : Form
    {
        private int selectedId = 0;

        public FormNasabah()
        {
            InitializeComponent();
        }

        private void FormNasabah_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyModernGridStyle(dgvNasabah);
            LoadData();
            ResetForm();
        }

        private void LoadData()
        {
            DataTable dt = DataStore.GetNasabah();
            dgvNasabah.DataSource = dt;
            UIHelper.FormatGridColumns(dgvNasabah);

            decimal totalSaldo = 0;
            if (dt != null)
            {
                foreach (DataRow r in dt.Rows)
                {
                    if (r["saldo"] != DBNull.Value) totalSaldo += Convert.ToDecimal(r["saldo"]);
                }
            }
            lblRecordBadge.Text = string.Format("👥 TOTAL: {0} NASABAH | 💰 SALDO TABUNGAN WARGA: Rp {1:N0}", dt != null ? dt.Rows.Count : 0, totalSaldo);
        }

        private void ResetForm()
        {
            selectedId = 0;
            txtKode.Text = "NSB-" + (dgvNasabah.Rows.Count + 1).ToString("D3");
            txtNama.Clear();
            txtAlamat.Clear();
            txtNoHp.Clear();
            txtCari.Clear();
            btnSimpan.Enabled = true;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKode.Text) || string.IsNullOrEmpty(txtNama.Text))
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Kode dan Nama Nasabah wajib diisi!", "Validasi Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataStore.AddNasabah(txtKode.Text.Trim(), txtNama.Text.Trim(), txtAlamat.Text.Trim(), txtNoHp.Text.Trim(), 0);
            SoundHelper.PlaySaveSound();
            MessageBox.Show("Data Nasabah Berhasil Disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ResetForm();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) return;

            DataStore.UpdateNasabah(selectedId, txtKode.Text.Trim(), txtNama.Text.Trim(), txtAlamat.Text.Trim(), txtNoHp.Text.Trim());
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

        private void dgvNasabah_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNasabah.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["id_nasabah"].Value);
                txtKode.Text = row.Cells["kode_nasabah"].Value.ToString();
                txtNama.Text = row.Cells["nama"].Value.ToString();
                txtAlamat.Text = row.Cells["alamat"].Value.ToString();
                txtNoHp.Text = row.Cells["no_hp"].Value.ToString();

                btnSimpan.Enabled = false;
                btnUbah.Enabled = true;
                btnHapus.Enabled = true;
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtCari.Text.Trim().ToLower();
            DataTable dt = DataStore.GetNasabah();
            if (!string.IsNullOrEmpty(keyword) && dt != null)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("kode_nasabah LIKE '%{0}%' OR nama LIKE '%{0}%' OR alamat LIKE '%{0}%'", keyword);
                DataTable dtFiltered = dv.ToTable();
                dgvNasabah.DataSource = dtFiltered;
                UIHelper.FormatGridColumns(dgvNasabah);

                decimal totalSaldoFiltered = 0;
                foreach (DataRow r in dtFiltered.Rows)
                {
                    if (r["saldo"] != DBNull.Value) totalSaldoFiltered += Convert.ToDecimal(r["saldo"]);
                }
                lblRecordBadge.Text = string.Format("🔍 DITEMUKAN: {0} NASABAH | SALDO: Rp {1:N0}", dtFiltered.Rows.Count, totalSaldoFiltered);
            }
            else
            {
                LoadData();
            }
        }
    }
}
