using System;
using System.Windows.Forms;

namespace BankSampah
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            UIHelper.MakeRounded(this, 16);
            UIHelper.MakeRounded(panelHero, 16);
            UIHelper.MakeRounded(panelForm, 16);
            UIHelper.MakeRounded(btnLogin, 8);
            UIHelper.MakeRounded(btnExit, 8);
            UIHelper.MakeRounded(txtUsername, 6);
            UIHelper.MakeRounded(txtPassword, 6);
            UIHelper.MakeRounded(panelAudioBox, 8);
            UIHelper.MakeRounded(btnPlayLoginAudio, 12);
            UIHelper.MakeRounded(bin1, 8);
            UIHelper.MakeRounded(bin2, 8);
            UIHelper.MakeRounded(bin3, 8);
            UIHelper.MakeRounded(btnPortalWargaLogin, 8);
            UIHelper.MakeRounded(btnPortalPetugasLogin, 8);
        }

        private void btnPortalWargaLogin_Click(object sender, EventArgs e)
        {
            SoundHelper.PlaySaveSound();
            using (FormPortalWarga wargaForm = new FormPortalWarga())
            {
                wargaForm.ShowDialog(this);
            }
        }

        private void btnPortalPetugasLogin_Click(object sender, EventArgs e)
        {
            SoundHelper.PlaySaveSound();
            using (FormPortalPetugas petugasForm = new FormPortalPetugas())
            {
                petugasForm.ShowDialog(this);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Silakan isi Username dan Password terlebih dahulu!", "Peringatan Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DataStore.Login(username, password))
            {
                SoundHelper.PlayLoginSound();
                MessageBox.Show(string.Format("Selamat Datang, {0}!\nRole: {1}", DataStore.CurrentUserNama, DataStore.CurrentUserRole), "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.Hide();
                txtPassword.Clear();
                using (FormMain mainForm = new FormMain())
                {
                    mainForm.ShowDialog();
                }

                // Saat keluar dari Admin, kembali ke halaman login
                this.Show();
                txtPassword.Clear();
                txtPassword.Focus();
            }
            else
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Username atau Password tidak valid! Silakan coba lagi.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(
                    "Apakah Anda yakin ingin keluar dari aplikasi SIMBAS?",
                    "Konfirmasi Keluar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnPlayLoginAudio_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayLoginSound();
        }
    }
}
