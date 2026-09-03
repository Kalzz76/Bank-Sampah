using System;
using System.Data;
using System.Windows.Forms;

namespace BankSampah
{
    public partial class FormUser : Form
    {
        private int selectedId = 0;

        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyModernGridStyle(dgvUser);
            LoadData();
            ResetForm();
        }

        private void LoadData()
        {
            DataTable dt = DataStore.GetUser();
            dgvUser.DataSource = dt;
            lblRecordBadge.Text = string.Format("📌 TOTAL USER: {0} AKUN", dt.Rows.Count);
        }

        private void ResetForm()
        {
            selectedId = 0;
            txtUsername.Clear();
            txtPassword.Clear();
            txtNama.Clear();
            cmbRole.SelectedIndex = 0;
            btnSimpan.Enabled = true;
            btnHapus.Enabled = false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtNama.Text))
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Semua kolom user wajib diisi!", "Validasi Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataStore.AddUser(txtUsername.Text.Trim(), txtPassword.Text.Trim(), txtNama.Text.Trim(), cmbRole.SelectedItem.ToString());
            SoundHelper.PlaySaveSound();
            MessageBox.Show("User Baru Berhasil Ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ResetForm();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) return;

            if (MessageBox.Show("Apakah Anda yakin ingin menghapus user ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataStore.DeleteUser(selectedId);
                SoundHelper.PlaySaveSound();
                MessageBox.Show("User Berhasil Dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ResetForm();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUser.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["id_user"].Value);
                txtUsername.Text = row.Cells["username"].Value.ToString();
                txtPassword.Text = row.Cells["password"].Value.ToString();
                txtNama.Text = row.Cells["nama_lengkap"].Value.ToString();
                cmbRole.SelectedItem = row.Cells["role"].Value.ToString();

                btnSimpan.Enabled = false;
                btnHapus.Enabled = true;
            }
        }
    }
}
