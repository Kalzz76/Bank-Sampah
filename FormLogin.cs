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
                FormMain mainForm = new FormMain();
                mainForm.ShowDialog();
                this.Close();
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
            Application.Exit();
        }
    }
}
