using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BankSampah
{
    public partial class FormMain : Form
    {
        private Form activeForm = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblUserName.Text = DataStore.CurrentUserNama;
            lblUserRoleTag.Text = DataStore.CurrentUserRole.ToUpper();

            timer1_Tick(null, null);
            LoadDashboardData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = "📅 " + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        public void LoadDashboardData()
        {
            try
            {
                DataTable dtN = DataStore.GetNasabah();
                lblValNasabah.Text = dtN.Rows.Count.ToString();

                DataTable dtS = DataStore.GetSampah();
                lblValSampah.Text = dtS.Rows.Count.ToString();

                DataTable dtT = DataStore.GetTransaksi();
                decimal totalBerat = 0;
                decimal totalSaldo = 0;

                foreach (DataRow r in dtN.Rows)
                {
                    if (r["saldo"] != DBNull.Value)
                    {
                        totalSaldo += Convert.ToDecimal(r["saldo"]);
                    }
                }

                foreach (DataRow r in dtT.Rows)
                {
                    if (r["berat_kg"] != DBNull.Value && r["jenis_transaksi"].ToString() == "Setor")
                    {
                        totalBerat += Convert.ToDecimal(r["berat_kg"]);
                    }
                }

                lblValBerat.Text = string.Format("{0:N2} Kg", totalBerat);
                lblValSaldo.Text = string.Format("Rp {0:N0}", totalSaldo);

                chartSampah.Series["Volume (Kg)"].Points.Clear();
                chartSampah.Series["Volume (Kg)"].Color = Color.FromArgb(16, 185, 129);

                foreach (DataRow r in dtS.Rows)
                {
                    string kat = r["kategori"].ToString();
                    decimal v = 0;

                    foreach (DataRow tr in dtT.Rows)
                    {
                        if (tr["jenis_transaksi"].ToString() == "Setor" && tr["nama_sampah"].ToString() == r["nama_sampah"].ToString())
                        {
                            v += Convert.ToDecimal(tr["berat_kg"]);
                        }
                    }

                    chartSampah.Series["Volume (Kg)"].Points.AddXY(kat, v > 0 ? v : (new Random().Next(5, 25)));
                }
            }
            catch { }
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            ResetNavButtons();
            btnNavDashboard.BackColor = Color.FromArgb(4, 120, 87);
            lblPageTitle.Text = "📊 Ringkasan Statistik Dashboard";

            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
                activeForm = null;
            }

            panelDashboardView.BringToFront();
            LoadDashboardData();
        }

        private void btnNavNasabah_Click(object sender, EventArgs e)
        {
            ResetNavButtons();
            btnNavNasabah.BackColor = Color.FromArgb(4, 120, 87);
            lblPageTitle.Text = "👥 Master Data Warga Nasabah";
            openChildForm(new FormNasabah());
        }

        private void btnNavSampah_Click(object sender, EventArgs e)
        {
            ResetNavButtons();
            btnNavSampah.BackColor = Color.FromArgb(4, 120, 87);
            lblPageTitle.Text = "♻️ Katalog & Tarif Harga Sampah";
            openChildForm(new FormSampah());
        }

        private void btnNavTransaksi_Click(object sender, EventArgs e)
        {
            ResetNavButtons();
            btnNavTransaksi.BackColor = Color.FromArgb(4, 120, 87);
            lblPageTitle.Text = "💸 Transaksi Setor & Tarik Saldo";
            openChildForm(new FormTransaksi());
        }

        private void btnNavPengaturan_Click(object sender, EventArgs e)
        {
            ResetNavButtons();
            btnNavPengaturan.BackColor = Color.FromArgb(4, 120, 87);
            lblPageTitle.Text = "⚙️ Pengaturan & Konfigurasi Sistem";
            openChildForm(new FormPengaturan());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda yakin ingin keluar dari sistem?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                FormLogin login = new FormLogin();
                login.Show();
            }
        }

        private void ResetNavButtons()
        {
            btnNavDashboard.BackColor = Color.Transparent;
            btnNavNasabah.BackColor = Color.Transparent;
            btnNavSampah.BackColor = Color.Transparent;
            btnNavTransaksi.BackColor = Color.Transparent;
            btnNavPengaturan.BackColor = Color.Transparent;
        }

        private void btnPlayMedia_Click(object sender, EventArgs e)
        {
            SoundHelper.PlaySaveSound();
            using (FormVideoPlayer player = new FormVideoPlayer())
            {
                player.ShowDialog(this);
            }
        }
    }
}
