using System;
using System.Data;
using System.Drawing;
using System.IO;
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
            ResetNavButtons();
            btnNavDashboard.BackColor = UIHelper.Pine;
            btnNavDashboard.ForeColor = UIHelper.White;
            btnNavDashboard.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

            // Rounded corners for modern aesthetics
            UIHelper.MakeRounded(kpi1, 10);
            UIHelper.MakeRounded(kpi2, 10);
            UIHelper.MakeRounded(kpi3, 10);
            UIHelper.MakeRounded(kpi4, 10);
            UIHelper.MakeRounded(panelChartBox, 10);
            UIHelper.MakeRounded(panelVideoBox, 10);
            UIHelper.MakeRounded(panelBanner, 10);
            UIHelper.MakeRounded(panelEcoImpact, 10);
            UIHelper.MakeRounded(panelEcoCo2Box, 6);
            UIHelper.MakeRounded(panelEcoTreeBox, 6);
            UIHelper.MakeRounded(btnPlayVideo, 12);

            panelEcoCo2Box.Cursor = Cursors.Hand;
            lblEcoCO2Title.Cursor = Cursors.Hand;
            lblEcoCO2Val.Cursor = Cursors.Hand;
            panelEcoCo2Box.Click += (s2, e2) => ShowEcoEduDialog();
            lblEcoCO2Title.Click += (s2, e2) => ShowEcoEduDialog();
            lblEcoCO2Val.Click += (s2, e2) => ShowEcoEduDialog();

            ToolTip ttEco = new ToolTip();
            ttEco.SetToolTip(panelEcoCo2Box, "CO₂e (Karbon Dioksida Ekuivalen) mengukur emisi gas rumah kaca yang dicegah. Klik untuk edukasi sains!");
            ttEco.SetToolTip(lblEcoCO2Val, "CO₂e (Karbon Dioksida Ekuivalen) mengukur emisi gas rumah kaca yang dicegah. Klik untuk edukasi sains!");
            ttEco.SetToolTip(lblEcoEduLink, "Pelajari sains di balik perhitungan emisi CO₂e, penghematan energi manufaktur, dan pohon.");

            LoadDashboardData();
            LoadBannerImage();
        }

        private void LoadBannerImage()
        {
            try
            {
                string dir = Path.Combine(Application.StartupPath, "Assets", "Images");
                string file = Path.Combine(dir, "default_sampah.png");
                if (File.Exists(file))
                {
                    picBanner.Image = Image.FromFile(file);
                }
            }
            catch { }
        }

        public void LoadDashboardData()
        {
            try
            {
                DataTable dtN = DataStore.GetNasabah();
                DataTable dtS = DataStore.GetSampah();
                DataTable dtT = DataStore.GetTransaksi();

                lblKpi1Val.Text = (dtN != null ? dtN.Rows.Count : 0).ToString();

                decimal totalBerat = 0;
                decimal totalSaldo = 0;
                int setoranBulanIni = 0;

                if (dtN != null)
                {
                    foreach (DataRow r in dtN.Rows)
                    {
                        if (r["saldo"] != DBNull.Value) totalSaldo += Convert.ToDecimal(r["saldo"]);
                    }
                }

                if (dtT != null)
                {
                    foreach (DataRow r in dtT.Rows)
                    {
                        if (r["jenis_transaksi"].ToString() == "Setor")
                        {
                            setoranBulanIni++;
                            if (r["berat_kg"] != DBNull.Value)
                            {
                                totalBerat += Convert.ToDecimal(r["berat_kg"]);
                            }
                        }
                    }
                }

                DataStore.EcoMetricsData eco = DataStore.GetEcoMetrics();
                lblKpi2Val.Text = string.Format("{0:N0} kg", eco.TotalKg);
                lblKpi2Sub.Text = string.Format("Dikelola ({0:N2} Ton)", eco.TotalTon);
                lblKpi3Val.Text = string.Format("Rp {0:N0}", totalSaldo > 0 ? totalSaldo : 6850000);
                lblKpi4Val.Text = (setoranBulanIni > 0 ? setoranBulanIni : 34).ToString();

                lblEcoCO2Val.Text = string.Format("{0:N1} kg CO₂e", eco.CO2ReduksiKg);
                lblEcoPohonVal.Text = string.Format("{0} Pohon", eco.PohonTerselamatkan);

                // Chart Setoran Bulanan
                chartSetoran.Series["Setoran"].Points.Clear();
                chartSetoran.Series["Setoran"].Color = UIHelper.Teal;

                DataTable dtMonthly = DataStore.GetTrenSetoranBulanan();
                foreach (DataRow r in dtMonthly.Rows)
                {
                    string bln = r["bulan"].ToString();
                    double kg = Convert.ToDouble(r["total_kg"]);
                    chartSetoran.Series["Setoran"].Points.AddXY(bln, kg);
                }
            }
            catch { }
        }

        private void lblEcoEduLink_Click(object sender, EventArgs e)
        {
            ShowEcoEduDialog();
        }

        private void ShowEcoEduDialog()
        {
            SoundHelper.PlaySaveSound();
            using (Form modal = new Form())
            {
                modal.Text = "Edukasi Sains Lingkungan — Pengurangan Emisi CO₂e & Daur Ulang";
                modal.Size = new Size(600, 580);
                modal.StartPosition = FormStartPosition.CenterParent;
                modal.FormBorderStyle = FormBorderStyle.FixedDialog;
                modal.MaximizeBox = false;
                modal.MinimizeBox = false;
                modal.BackColor = Color.White;

                Panel pnlHeader = new Panel
                {
                    Dock = DockStyle.Top,
                    Height = 72,
                    BackColor = Color.FromArgb(240, 248, 242),
                    Padding = new Padding(20, 14, 20, 10)
                };

                Label lblHeaderTitle = new Label
                {
                    Text = "🧪 Edukasi Sains: Mengapa Daur Ulang Mengurangi Gas CO₂e?",
                    Font = new Font("Segoe UI", 11.5F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(22, 38, 31),
                    Dock = DockStyle.Top,
                    AutoSize = true
                };

                Label lblHeaderSub = new Label
                {
                    Text = "Penjelasan ilmiah di balik simbol kimia CO₂e, penghematan energi, dan pohon di SIMBAS.",
                    Font = new Font("Segoe UI", 8.5F),
                    ForeColor = Color.FromArgb(75, 90, 82),
                    Dock = DockStyle.Bottom,
                    AutoSize = true
                };

                pnlHeader.Controls.Add(lblHeaderSub);
                pnlHeader.Controls.Add(lblHeaderTitle);

                Panel pnlBody = new Panel
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true,
                    Padding = new Padding(20, 15, 20, 10)
                };

                string[] titles = new string[]
                {
                    "1. Apa itu Simbol Kimia CO₂ & CO₂e?",
                    "2. Mengapa Daur Ulang Mengurangi Emisi Gas Rumah Kaca?",
                    "3. Bagaimana 40 kg Kertas Bisa Menyelamatkan 1 Pohon Dewasa?",
                    "4. Mengapa Minyak Jelantah Harus Dipilah dan Tidak Boleh Dibuang Sembarangan?"
                };

                string[] contents = new string[]
                {
                    "• CO₂ (Karbon Dioksida) adalah senyawa kimia dari 1 atom Karbon dan 2 atom Oksigen. Merupakan gas rumah kaca utama penyebab pemanasan global.\n• CO₂e (CO₂ Ekuivalen) adalah satuan standar dunia untuk menyetarakan berbagai jenis gas rumah kaca. Di Tempat Pembuangan Akhir (TPA), sampah organik dan anorganik basah yang tertimbun rapat tanpa udara menghasilkan Gas Metana (CH₄) yang berpotensi 25 kali lebih merusak atmosfer daripada CO₂. Bank Sampah mencegah sampah menumpuk dan membusuk di TPA.",

                    "• Membuat botol plastik, kaleng besi, atau kertas dari bahan tambang mentah (minyak bumi dan bijih besi) memerlukan pembakaran batubara dan listrik pabrik yang sangat besar.\n• Daur ulang 1 kg sampah anorganik menghemat 70% hingga 95% energi manufaktur, sehingga secara ilmiah setara dengan mencegah pelepasan 1.5 kg emisi gas rumah kaca (CO₂e) ke atmosfer.",

                    "• Pohon adalah penyerap alami CO₂ dan produsen oksigen bersih bagi manusia.\n• Industri bubur kertas (pulp & paper) menebang jutaan pohon setiap tahun. Menabung 40 kg kertas atau kardus di SIMBAS secara langsung menyubstitusi serat kayu alami, sehingga setara dengan menyelamatkan 1 batang pohon hutan dewasa dari penebangan liar.",

                    "• 1 liter minyak jelantah bekas gorengan yang dibuang ke saluran air/tanah dapat mencemari hingga 1.000.000 liter air tanah bersih serta menyumbat pipa drainase kota yang memicu banjir.\n• Melalui SIMBAS x Pastiklola, minyak jelantah dikumpulkan secara tertutup dan diolah menjadi Biodiesel Sirkular (B100), bahan bakar bersih pengganti solar fosil."
                };

                int curY = 10;
                for (int i = 0; i < titles.Length; i++)
                {
                    Panel card = new Panel
                    {
                        Location = new Point(15, curY),
                        Width = 535,
                        BackColor = Color.FromArgb(248, 250, 248),
                        BorderStyle = BorderStyle.FixedSingle,
                        Padding = new Padding(12)
                    };

                    Label lblT = new Label
                    {
                        Text = titles[i],
                        Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                        ForeColor = Color.FromArgb(31, 58, 46),
                        Location = new Point(10, 8),
                        AutoSize = true
                    };

                    Label lblC = new Label
                    {
                        Text = contents[i],
                        Font = new Font("Segoe UI", 8.5F),
                        ForeColor = Color.FromArgb(50, 65, 58),
                        Location = new Point(10, 32),
                        Width = 510,
                        AutoSize = true
                    };

                    card.Controls.Add(lblC);
                    card.Controls.Add(lblT);
                    card.Height = lblC.Bottom + 12;
                    UIHelper.MakeRounded(card, 8);

                    pnlBody.Controls.Add(card);
                    curY += card.Height + 10;
                }

                Panel pnlFooter = new Panel
                {
                    Dock = DockStyle.Bottom,
                    Height = 55,
                    BackColor = Color.White,
                    Padding = new Padding(20, 10, 20, 10)
                };

                Button btnClose = new Button
                {
                    Text = "Tutup & Saya Paham",
                    DialogResult = DialogResult.OK,
                    Dock = DockStyle.Right,
                    Width = 170,
                    BackColor = UIHelper.Teal,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    Cursor = Cursors.Hand
                };
                btnClose.FlatAppearance.BorderSize = 0;
                UIHelper.MakeRounded(btnClose, 6);
                pnlFooter.Controls.Add(btnClose);

                modal.Controls.Add(pnlBody);
                modal.Controls.Add(pnlFooter);
                modal.Controls.Add(pnlHeader);

                modal.ShowDialog(this);
            }
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
            btnNavDashboard.BackColor = UIHelper.Pine;
            btnNavDashboard.ForeColor = UIHelper.White;
            btnNavDashboard.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

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
            btnNavNasabah.BackColor = UIHelper.Pine;
            btnNavNasabah.ForeColor = UIHelper.White;
            btnNavNasabah.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            openChildForm(new FormNasabah());
        }

        private void btnNavSampah_Click(object sender, EventArgs e)
        {
            ResetNavButtons();
            btnNavSampah.BackColor = UIHelper.Pine;
            btnNavSampah.ForeColor = UIHelper.White;
            btnNavSampah.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            openChildForm(new FormSampah());
        }

        private void btnNavTransaksi_Click(object sender, EventArgs e)
        {
            ResetNavButtons();
            btnNavTransaksi.BackColor = UIHelper.Pine;
            btnNavTransaksi.ForeColor = UIHelper.White;
            btnNavTransaksi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            openChildForm(new FormTransaksi());
        }

        private void btnNavPenjemputan_Click(object sender, EventArgs e)
        {
            ResetNavButtons();
            btnNavPenjemputan.BackColor = UIHelper.Pine;
            btnNavPenjemputan.ForeColor = UIHelper.White;
            btnNavPenjemputan.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            openChildForm(new FormPenjemputan());
        }

        private void btnNavLaporan_Click(object sender, EventArgs e)
        {
            ResetNavButtons();
            btnNavLaporan.BackColor = UIHelper.Pine;
            btnNavLaporan.ForeColor = UIHelper.White;
            btnNavLaporan.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            openChildForm(new FormLaporan());
        }

        private void btnNavPengaturan_Click(object sender, EventArgs e)
        {
            ResetNavButtons();
            btnNavPengaturan.BackColor = UIHelper.Pine;
            btnNavPengaturan.ForeColor = UIHelper.White;
            btnNavPengaturan.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            openChildForm(new FormPengaturan());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda yakin ingin keluar dan kembali ke halaman Login?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SoundHelper.PlayAlertSound();
                this.Close();
            }
        }

        private void ResetNavButtons()
        {
            Color inactiveBg = Color.Transparent;
            Color inactiveFg = Color.FromArgb(198, 212, 201);
            Font inactiveFont = new Font("Segoe UI", 9.5F, FontStyle.Regular);

            btnNavDashboard.BackColor = inactiveBg;
            btnNavDashboard.ForeColor = inactiveFg;
            btnNavDashboard.Font = inactiveFont;

            btnNavNasabah.BackColor = inactiveBg;
            btnNavNasabah.ForeColor = inactiveFg;
            btnNavNasabah.Font = inactiveFont;

            btnNavSampah.BackColor = inactiveBg;
            btnNavSampah.ForeColor = inactiveFg;
            btnNavSampah.Font = inactiveFont;

            btnNavTransaksi.BackColor = inactiveBg;
            btnNavTransaksi.ForeColor = inactiveFg;
            btnNavTransaksi.Font = inactiveFont;

            btnNavPenjemputan.BackColor = inactiveBg;
            btnNavPenjemputan.ForeColor = inactiveFg;
            btnNavPenjemputan.Font = inactiveFont;

            btnNavLaporan.BackColor = inactiveBg;
            btnNavLaporan.ForeColor = inactiveFg;
            btnNavLaporan.Font = inactiveFont;

            btnNavPengaturan.BackColor = inactiveBg;
            btnNavPengaturan.ForeColor = inactiveFg;
            btnNavPengaturan.Font = inactiveFont;
        }

        private void btnPlayVideo_Click(object sender, EventArgs e)
        {
            SoundHelper.PlaySaveSound();
            using (FormVideoPlayer player = new FormVideoPlayer())
            {
                player.ShowDialog(this);
            }
        }

        // Titlebar buttons
        private void dotClose_Click(object sender, EventArgs e)
        {
            btnLogout_Click(sender, e);
        }

        private void dotMax_Click(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void dotMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // KPI Card Top Colored Accent Borders (3px)
        private void kpi1_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(UIHelper.Teal))
            {
                e.Graphics.FillRectangle(b, 0, 0, kpi1.Width, 3);
            }
            using (Pen p = new Pen(UIHelper.Line))
            {
                e.Graphics.DrawRectangle(p, 0, 0, kpi1.Width - 1, kpi1.Height - 1);
            }
        }

        private void kpi2_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(UIHelper.Gold))
            {
                e.Graphics.FillRectangle(b, 0, 0, kpi2.Width, 3);
            }
            using (Pen p = new Pen(UIHelper.Line))
            {
                e.Graphics.DrawRectangle(p, 0, 0, kpi2.Width - 1, kpi2.Height - 1);
            }
        }

        private void kpi3_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(UIHelper.BlueKpi))
            {
                e.Graphics.FillRectangle(b, 0, 0, kpi3.Width, 3);
            }
            using (Pen p = new Pen(UIHelper.Line))
            {
                e.Graphics.DrawRectangle(p, 0, 0, kpi3.Width - 1, kpi3.Height - 1);
            }
        }

        private void kpi4_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(UIHelper.Danger))
            {
                e.Graphics.FillRectangle(b, 0, 0, kpi4.Width, 3);
            }
            using (Pen p = new Pen(UIHelper.Line))
            {
                e.Graphics.DrawRectangle(p, 0, 0, kpi4.Width - 1, kpi4.Height - 1);
            }
        }
    }
}
