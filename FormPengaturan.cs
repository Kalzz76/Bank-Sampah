using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BankSampah
{
    public partial class FormPengaturan : Form
    {
        private int selectedIdUser = -1;

        public FormPengaturan()
        {
            InitializeComponent();
        }

        private void FormPengaturan_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyModernGridStyle(dgvUser);
            LoadUserData();
            cmbRole.SelectedIndex = 1; // Default Petugas

            if (DataStore.CurrentUserRole != "Admin")
            {
                btnTabUser.Visible = false;
                SwitchTab("Audio");
            }
            else
            {
                SwitchTab("User");
            }
        }

        private void SwitchTab(string tabName)
        {
            ResetTabPills();
            panelUserTab.Visible = false;
            panelAudioTab.Visible = false;
            panelSystemTab.Visible = false;

            if (tabName == "User")
            {
                btnTabUser.BackColor = Color.FromArgb(6, 78, 59);
                btnTabUser.ForeColor = Color.White;
                panelUserTab.Visible = true;
                panelUserTab.BringToFront();
                LoadUserData();
            }
            else if (tabName == "Audio")
            {
                btnTabAudio.BackColor = Color.FromArgb(6, 78, 59);
                btnTabAudio.ForeColor = Color.White;
                panelAudioTab.Visible = true;
                panelAudioTab.BringToFront();
            }
            else if (tabName == "System")
            {
                btnTabSystem.BackColor = Color.FromArgb(6, 78, 59);
                btnTabSystem.ForeColor = Color.White;
                panelSystemTab.Visible = true;
                panelSystemTab.BringToFront();
            }
        }

        private void ResetTabPills()
        {
            btnTabUser.BackColor = Color.FromArgb(240, 244, 242);
            btnTabUser.ForeColor = Color.FromArgb(71, 85, 105);

            btnTabAudio.BackColor = Color.FromArgb(240, 244, 242);
            btnTabAudio.ForeColor = Color.FromArgb(71, 85, 105);

            btnTabSystem.BackColor = Color.FromArgb(240, 244, 242);
            btnTabSystem.ForeColor = Color.FromArgb(71, 85, 105);
        }

        private void btnTabUser_Click(object sender, EventArgs e)
        {
            SwitchTab("User");
        }

        private void btnTabAudio_Click(object sender, EventArgs e)
        {
            SwitchTab("Audio");
        }

        private void btnTabSystem_Click(object sender, EventArgs e)
        {
            SwitchTab("System");
        }

        // ================= USER MANAGEMENT LOGIC =================
        private void LoadUserData()
        {
            DataTable dt = DataStore.GetUser();
            dgvUser.DataSource = dt;
            lblUserRecordBadge.Text = string.Format("📌 TOTAL: {0} USER", dt.Rows.Count);
        }

        private void ResetUserForm()
        {
            selectedIdUser = -1;
            txtUsername.Clear();
            txtPassword.Clear();
            txtNama.Clear();
            cmbRole.SelectedIndex = 1;
            txtUsername.Enabled = true;
            btnSimpanUser.Text = "💾 TAMBAH USER BARU";
        }

        private void btnSimpanUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtNama.Text))
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Semua kolom (Username, Password, Nama) wajib diisi!", "Validasi Pengaturan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataStore.AddUser(txtUsername.Text.Trim(), txtPassword.Text.Trim(), txtNama.Text.Trim(), cmbRole.SelectedItem.ToString());
            SoundHelper.PlaySaveSound();
            MessageBox.Show("Akun User Baru Berhasil Ditambahkan!", "Sukses Pengaturan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUserData();
            ResetUserForm();
        }

        private void btnHapusUser_Click(object sender, EventArgs e)
        {
            if (selectedIdUser == -1)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Pilih user yang ingin dihapus dari tabel terlebih dahulu!", "Validasi Hapus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Apakah Anda yakin ingin menghapus user ini?", "Konfirmasi Hapus User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataStore.DeleteUser(selectedIdUser);
                SoundHelper.PlaySaveSound();
                MessageBox.Show("User berhasil dihapus!", "Sukses Hapus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserData();
                ResetUserForm();
            }
        }

        private void btnBatalUser_Click(object sender, EventArgs e)
        {
            ResetUserForm();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUser.Rows[e.RowIndex];
                if (row.Cells["id_user"].Value != null)
                {
                    selectedIdUser = Convert.ToInt32(row.Cells["id_user"].Value);
                    txtUsername.Text = row.Cells["username"].Value.ToString();
                    txtNama.Text = row.Cells["nama_lengkap"].Value.ToString();
                    cmbRole.SelectedItem = row.Cells["role"].Value.ToString();
                    txtUsername.Enabled = false;
                }
            }
        }

        // ================= AUDIO TEST LOGIC =================
        private void btnTestLogin_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayLoginSound();
        }

        private void btnTestSave_Click(object sender, EventArgs e)
        {
            SoundHelper.PlaySaveSound();
        }

        private void btnTestAlert_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayAlertSound();
        }

        // ================= SYSTEM INFO LOGIC =================
        private void btnTestDbConn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    if (conn != null)
                    {
                        SoundHelper.PlaySaveSound();
                        MessageBox.Show("⚡ Koneksi ke SQL Server (db_banksampah) BERHASIL DAN AKTIF!", "Tes Koneksi Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SoundHelper.PlaySaveSound();
                        MessageBox.Show("ℹ️ Menggunakan Fallback Storage (InMemory Active Store) karena SQL Server lokal belum diaktifkan.", "Tes Koneksi Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Error saat tes koneksi: " + ex.Message, "Error Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
