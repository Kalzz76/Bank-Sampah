using System;
using System.Drawing;
using System.Windows.Forms;

namespace BankSampah
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelUserProfile = new System.Windows.Forms.Panel();
            this.lblUserRoleTag = new System.Windows.Forms.Label();
            this.lblUserAvatar = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnNavPengaturan = new System.Windows.Forms.Button();
            this.btnNavTransaksi = new System.Windows.Forms.Button();
            this.btnNavSampah = new System.Windows.Forms.Button();
            this.btnNavNasabah = new System.Windows.Forms.Button();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.panelBrand = new System.Windows.Forms.Panel();
            this.lblBrandSub = new System.Windows.Forms.Label();
            this.lblBrandTitle = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.flowTopRight = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblStatusBadge = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelDashboardView = new System.Windows.Forms.Panel();
            this.panelMainSplit = new System.Windows.Forms.TableLayoutPanel();
            this.chartSampah = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelRightColumn = new System.Windows.Forms.Panel();
            this.panelMedia = new System.Windows.Forms.Panel();
            this.btnPlayMedia = new System.Windows.Forms.Button();
            this.lblMediaDesc = new System.Windows.Forms.Label();
            this.lblMediaTitle = new System.Windows.Forms.Label();
            this.panelShortcuts = new System.Windows.Forms.Panel();
            this.btnQuickTarik = new System.Windows.Forms.Button();
            this.btnQuickSetor = new System.Windows.Forms.Button();
            this.lblShortcutTitle = new System.Windows.Forms.Label();
            this.panelCards = new System.Windows.Forms.TableLayoutPanel();
            this.card4 = new System.Windows.Forms.Panel();
            this.lblValSaldo = new System.Windows.Forms.Label();
            this.lblTitleSaldo = new System.Windows.Forms.Label();
            this.card3 = new System.Windows.Forms.Panel();
            this.lblValBerat = new System.Windows.Forms.Label();
            this.lblTitleBerat = new System.Windows.Forms.Label();
            this.card2 = new System.Windows.Forms.Panel();
            this.lblValSampah = new System.Windows.Forms.Label();
            this.lblTitleSampah = new System.Windows.Forms.Label();
            this.card1 = new System.Windows.Forms.Panel();
            this.lblValNasabah = new System.Windows.Forms.Label();
            this.lblTitleNasabah = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelUserProfile.SuspendLayout();
            this.panelBrand.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.flowTopRight.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelDashboardView.SuspendLayout();
            this.panelMainSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSampah)).BeginInit();
            this.panelRightColumn.SuspendLayout();
            this.panelMedia.SuspendLayout();
            this.panelShortcuts.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.card4.SuspendLayout();
            this.card3.SuspendLayout();
            this.card2.SuspendLayout();
            this.card1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = Color.FromArgb(6, 78, 59);
            this.panelSidebar.Controls.Add(this.panelUserProfile);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnNavPengaturan);
            this.panelSidebar.Controls.Add(this.btnNavTransaksi);
            this.panelSidebar.Controls.Add(this.btnNavSampah);
            this.panelSidebar.Controls.Add(this.btnNavNasabah);
            this.panelSidebar.Controls.Add(this.btnNavDashboard);
            this.panelSidebar.Controls.Add(this.panelBrand);
            this.panelSidebar.Dock = DockStyle.Left;
            this.panelSidebar.Location = new Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new Size(240, 720);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelUserProfile
            // 
            this.panelUserProfile.BackColor = Color.FromArgb(4, 55, 42);
            this.panelUserProfile.Controls.Add(this.lblUserRoleTag);
            this.panelUserProfile.Controls.Add(this.lblUserAvatar);
            this.panelUserProfile.Controls.Add(this.lblUserName);
            this.panelUserProfile.Dock = DockStyle.Bottom;
            this.panelUserProfile.Location = new Point(0, 600);
            this.panelUserProfile.Name = "panelUserProfile";
            this.panelUserProfile.Size = new Size(240, 68);
            this.panelUserProfile.TabIndex = 7;
            // 
            // lblUserRoleTag
            // 
            this.lblUserRoleTag.AutoSize = true;
            this.lblUserRoleTag.BackColor = Color.FromArgb(16, 185, 129);
            this.lblUserRoleTag.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            this.lblUserRoleTag.ForeColor = Color.White;
            this.lblUserRoleTag.Location = new Point(60, 38);
            this.lblUserRoleTag.Padding = new Padding(6, 2, 6, 2);
            this.lblUserRoleTag.Name = "lblUserRoleTag";
            this.lblUserRoleTag.Size = new Size(54, 17);
            this.lblUserRoleTag.TabIndex = 2;
            this.lblUserRoleTag.Text = "ADMIN";
            // 
            // lblUserAvatar
            // 
            this.lblUserAvatar.AutoSize = true;
            this.lblUserAvatar.Font = new Font("Segoe UI", 20F);
            this.lblUserAvatar.ForeColor = Color.White;
            this.lblUserAvatar.Location = new Point(12, 14);
            this.lblUserAvatar.Name = "lblUserAvatar";
            this.lblUserAvatar.Size = new Size(47, 37);
            this.lblUserAvatar.TabIndex = 0;
            this.lblUserAvatar.Text = "👤";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblUserName.ForeColor = Color.White;
            this.lblUserName.Location = new Point(60, 16);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new Size(92, 17);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Administrator";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = Color.FromArgb(2, 44, 34);
            this.btnLogout.Dock = DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnLogout.ForeColor = Color.FromArgb(254, 202, 202);
            this.btnLogout.Location = new Point(0, 668);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new Padding(20, 0, 0, 0);
            this.btnLogout.Size = new Size(240, 52);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "  🚪 LOGOUT / KELUAR";
            this.btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);
            // 
            // btnNavPengaturan
            // 
            this.btnNavPengaturan.Dock = DockStyle.Top;
            this.btnNavPengaturan.FlatAppearance.BorderSize = 0;
            this.btnNavPengaturan.FlatStyle = FlatStyle.Flat;
            this.btnNavPengaturan.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            this.btnNavPengaturan.ForeColor = Color.White;
            this.btnNavPengaturan.Location = new Point(0, 290);
            this.btnNavPengaturan.Name = "btnNavPengaturan";
            this.btnNavPengaturan.Padding = new Padding(20, 0, 0, 0);
            this.btnNavPengaturan.Size = new Size(240, 52);
            this.btnNavPengaturan.TabIndex = 5;
            this.btnNavPengaturan.Text = "  ⚙️ PENGATURAN";
            this.btnNavPengaturan.TextAlign = ContentAlignment.MiddleLeft;
            this.btnNavPengaturan.UseVisualStyleBackColor = true;
            this.btnNavPengaturan.Click += new EventHandler(this.btnNavPengaturan_Click);
            // 
            // btnNavTransaksi
            // 
            this.btnNavTransaksi.Dock = DockStyle.Top;
            this.btnNavTransaksi.FlatAppearance.BorderSize = 0;
            this.btnNavTransaksi.FlatStyle = FlatStyle.Flat;
            this.btnNavTransaksi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            this.btnNavTransaksi.ForeColor = Color.White;
            this.btnNavTransaksi.Location = new Point(0, 238);
            this.btnNavTransaksi.Name = "btnNavTransaksi";
            this.btnNavTransaksi.Padding = new Padding(20, 0, 0, 0);
            this.btnNavTransaksi.Size = new Size(240, 52);
            this.btnNavTransaksi.TabIndex = 4;
            this.btnNavTransaksi.Text = "  💸 TRANSAKSI";
            this.btnNavTransaksi.TextAlign = ContentAlignment.MiddleLeft;
            this.btnNavTransaksi.UseVisualStyleBackColor = true;
            this.btnNavTransaksi.Click += new EventHandler(this.btnNavTransaksi_Click);
            // 
            // btnNavSampah
            // 
            this.btnNavSampah.Dock = DockStyle.Top;
            this.btnNavSampah.FlatAppearance.BorderSize = 0;
            this.btnNavSampah.FlatStyle = FlatStyle.Flat;
            this.btnNavSampah.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            this.btnNavSampah.ForeColor = Color.White;
            this.btnNavSampah.Location = new Point(0, 186);
            this.btnNavSampah.Name = "btnNavSampah";
            this.btnNavSampah.Padding = new Padding(20, 0, 0, 0);
            this.btnNavSampah.Size = new Size(240, 52);
            this.btnNavSampah.TabIndex = 3;
            this.btnNavSampah.Text = "  ♻️ DATA SAMPAH";
            this.btnNavSampah.TextAlign = ContentAlignment.MiddleLeft;
            this.btnNavSampah.UseVisualStyleBackColor = true;
            this.btnNavSampah.Click += new EventHandler(this.btnNavSampah_Click);
            // 
            // btnNavNasabah
            // 
            this.btnNavNasabah.Dock = DockStyle.Top;
            this.btnNavNasabah.FlatAppearance.BorderSize = 0;
            this.btnNavNasabah.FlatStyle = FlatStyle.Flat;
            this.btnNavNasabah.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            this.btnNavNasabah.ForeColor = Color.White;
            this.btnNavNasabah.Location = new Point(0, 134);
            this.btnNavNasabah.Name = "btnNavNasabah";
            this.btnNavNasabah.Padding = new Padding(20, 0, 0, 0);
            this.btnNavNasabah.Size = new Size(240, 52);
            this.btnNavNasabah.TabIndex = 2;
            this.btnNavNasabah.Text = "  👥 DATA NASABAH";
            this.btnNavNasabah.TextAlign = ContentAlignment.MiddleLeft;
            this.btnNavNasabah.UseVisualStyleBackColor = true;
            this.btnNavNasabah.Click += new EventHandler(this.btnNavNasabah_Click);
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.BackColor = Color.FromArgb(4, 120, 87);
            this.btnNavDashboard.Dock = DockStyle.Top;
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = FlatStyle.Flat;
            this.btnNavDashboard.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            this.btnNavDashboard.ForeColor = Color.White;
            this.btnNavDashboard.Location = new Point(0, 82);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Padding = new Padding(20, 0, 0, 0);
            this.btnNavDashboard.Size = new Size(240, 52);
            this.btnNavDashboard.TabIndex = 1;
            this.btnNavDashboard.Text = "  📊 DASHBOARD";
            this.btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft;
            this.btnNavDashboard.UseVisualStyleBackColor = false;
            this.btnNavDashboard.Click += new EventHandler(this.btnNavDashboard_Click);
            // 
            // panelBrand
            // 
            this.panelBrand.BackColor = Color.FromArgb(2, 44, 34);
            this.panelBrand.Controls.Add(this.lblBrandSub);
            this.panelBrand.Controls.Add(this.lblBrandTitle);
            this.panelBrand.Dock = DockStyle.Top;
            this.panelBrand.Location = new Point(0, 0);
            this.panelBrand.Name = "panelBrand";
            this.panelBrand.Size = new Size(240, 82);
            this.panelBrand.TabIndex = 0;
            // 
            // lblBrandSub
            // 
            this.lblBrandSub.AutoSize = true;
            this.lblBrandSub.Font = new Font("Segoe UI", 8.5F);
            this.lblBrandSub.ForeColor = Color.FromArgb(167, 243, 208);
            this.lblBrandSub.Location = new Point(16, 46);
            this.lblBrandSub.Name = "lblBrandSub";
            this.lblBrandSub.Size = new Size(188, 15);
            this.lblBrandSub.TabIndex = 1;
            this.lblBrandSub.Text = "SMKN 13 Bandung @Proyek Akhir";
            // 
            // lblBrandTitle
            // 
            this.lblBrandTitle.AutoSize = true;
            this.lblBrandTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblBrandTitle.ForeColor = Color.White;
            this.lblBrandTitle.Location = new Point(16, 20);
            this.lblBrandTitle.Name = "lblBrandTitle";
            this.lblBrandTitle.Size = new Size(196, 21);
            this.lblBrandTitle.TabIndex = 0;
            this.lblBrandTitle.Text = "🌿 BANK SAMPAH DIGITAL";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = Color.White;
            this.panelTop.Controls.Add(this.flowTopRight);
            this.panelTop.Controls.Add(this.lblPageTitle);
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Location = new Point(240, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new Size(960, 65);
            this.panelTop.TabIndex = 1;
            // 
            // flowTopRight
            // 
            this.flowTopRight.AutoSize = true;
            this.flowTopRight.Controls.Add(this.lblDateTime);
            this.flowTopRight.Controls.Add(this.lblStatusBadge);
            this.flowTopRight.Dock = DockStyle.Right;
            this.flowTopRight.FlowDirection = FlowDirection.RightToLeft;
            this.flowTopRight.Location = new Point(480, 0);
            this.flowTopRight.Name = "flowTopRight";
            this.flowTopRight.Padding = new Padding(15, 18, 15, 10);
            this.flowTopRight.Size = new Size(480, 65);
            this.flowTopRight.TabIndex = 3;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = Color.FromArgb(240, 244, 242);
            this.lblDateTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblDateTime.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblDateTime.Location = new Point(205, 18);
            this.lblDateTime.Margin = new Padding(5, 0, 0, 0);
            this.lblDateTime.Padding = new Padding(8, 4, 8, 4);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new Size(245, 23);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "📅 Rabu, 26 Agustus 2026 23:15";
            // 
            // lblStatusBadge
            // 
            this.lblStatusBadge.AutoSize = true;
            this.lblStatusBadge.BackColor = Color.FromArgb(236, 253, 245);
            this.lblStatusBadge.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            this.lblStatusBadge.ForeColor = Color.FromArgb(4, 120, 87);
            this.lblStatusBadge.Location = new Point(25, 18);
            this.lblStatusBadge.Margin = new Padding(0, 0, 5, 0);
            this.lblStatusBadge.Padding = new Padding(8, 4, 8, 4);
            this.lblStatusBadge.Name = "lblStatusBadge";
            this.lblStatusBadge.Size = new Size(160, 23);
            this.lblStatusBadge.TabIndex = 2;
            this.lblStatusBadge.Text = "🟢 DB SQL SERVER CONNECTED";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            this.lblPageTitle.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblPageTitle.Location = new Point(22, 20);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new Size(274, 25);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "📊 Ringkasan Statistik Dashboard";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new EventHandler(this.timer1_Tick);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = Color.FromArgb(240, 244, 242);
            this.panelContent.Controls.Add(this.panelDashboardView);
            this.panelContent.Dock = DockStyle.Fill;
            this.panelContent.Location = new Point(240, 65);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new Size(960, 655);
            this.panelContent.TabIndex = 2;
            // 
            // panelDashboardView
            // 
            this.panelDashboardView.Controls.Add(this.panelMainSplit);
            this.panelDashboardView.Controls.Add(this.panelCards);
            this.panelDashboardView.Dock = DockStyle.Fill;
            this.panelDashboardView.Location = new Point(0, 0);
            this.panelDashboardView.Name = "panelDashboardView";
            this.panelDashboardView.Padding = new Padding(20);
            this.panelDashboardView.Size = new Size(960, 655);
            this.panelDashboardView.TabIndex = 0;
            // 
            // panelMainSplit
            // 
            this.panelMainSplit.ColumnCount = 2;
            this.panelMainSplit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            this.panelMainSplit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            this.panelMainSplit.Controls.Add(this.chartSampah, 0, 0);
            this.panelMainSplit.Controls.Add(this.panelRightColumn, 1, 0);
            this.panelMainSplit.Dock = DockStyle.Fill;
            this.panelMainSplit.Location = new Point(20, 140);
            this.panelMainSplit.Name = "panelMainSplit";
            this.panelMainSplit.RowCount = 1;
            this.panelMainSplit.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.panelMainSplit.Size = new Size(920, 495);
            this.panelMainSplit.TabIndex = 1;
            // 
            // chartSampah
            // 
            this.chartSampah.BackColor = Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartSampah.ChartAreas.Add(chartArea1);
            this.chartSampah.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartSampah.Legends.Add(legend1);
            this.chartSampah.Location = new Point(0, 0);
            this.chartSampah.Margin = new Padding(0, 0, 10, 0);
            this.chartSampah.Name = "chartSampah";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Volume (Kg)";
            this.chartSampah.Series.Add(series1);
            this.chartSampah.Size = new Size(496, 495);
            this.chartSampah.TabIndex = 0;
            this.chartSampah.Text = "Grafik Pengumpulan Sampah";
            // 
            // panelRightColumn
            // 
            this.panelRightColumn.Controls.Add(this.panelMedia);
            this.panelRightColumn.Controls.Add(this.panelShortcuts);
            this.panelRightColumn.Dock = DockStyle.Fill;
            this.panelRightColumn.Location = new Point(506, 0);
            this.panelRightColumn.Margin = new Padding(0);
            this.panelRightColumn.Name = "panelRightColumn";
            this.panelRightColumn.Size = new Size(414, 495);
            this.panelRightColumn.TabIndex = 1;
            // 
            // panelMedia
            // 
            this.panelMedia.BackColor = Color.White;
            this.panelMedia.Controls.Add(this.btnPlayMedia);
            this.panelMedia.Controls.Add(this.lblMediaDesc);
            this.panelMedia.Controls.Add(this.lblMediaTitle);
            this.panelMedia.Dock = DockStyle.Fill;
            this.panelMedia.Location = new Point(0, 120);
            this.panelMedia.Name = "panelMedia";
            this.panelMedia.Padding = new Padding(20);
            this.panelMedia.Size = new Size(414, 375);
            this.panelMedia.TabIndex = 1;
            // 
            // btnPlayMedia
            // 
            this.btnPlayMedia.BackColor = Color.FromArgb(16, 185, 129);
            this.btnPlayMedia.Cursor = Cursors.Hand;
            this.btnPlayMedia.FlatAppearance.BorderSize = 0;
            this.btnPlayMedia.FlatStyle = FlatStyle.Flat;
            this.btnPlayMedia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnPlayMedia.ForeColor = Color.White;
            this.btnPlayMedia.Location = new Point(20, 310);
            this.btnPlayMedia.Name = "btnPlayMedia";
            this.btnPlayMedia.Size = new Size(374, 45);
            this.btnPlayMedia.TabIndex = 2;
            this.btnPlayMedia.Text = "▶️ PUTAR DEMO AUDIO & MEDIA";
            this.btnPlayMedia.UseVisualStyleBackColor = false;
            this.btnPlayMedia.Click += new EventHandler(this.btnPlayMedia_Click);
            // 
            // lblMediaDesc
            // 
            this.lblMediaDesc.Font = new Font("Segoe UI", 9.5F);
            this.lblMediaDesc.ForeColor = Color.FromArgb(71, 85, 105);
            this.lblMediaDesc.Location = new Point(20, 55);
            this.lblMediaDesc.Name = "lblMediaDesc";
            this.lblMediaDesc.Size = new Size(374, 240);
            this.lblMediaDesc.TabIndex = 1;
            this.lblMediaDesc.Text = "Selamat datang di Sistem Bank Sampah Digital SMKN 13 Bandung!\r\n\r\nAplikasi ini membantumu memilah sampah dan mengonversikannya menjadi saldo tabungan secara otomatis.\r\n\r\nChecklist Fitur Multimedia:\r\n✓ 🖼️ Visual Graphics & Single-Window Embedded Navigation\r\n✓ 🔊 Sound Player (Login & Transaksi WAV)\r\n✓ 📊 Dynamic Bar Chart Data Visualization\r\n✓ 🎥 Tutorial Panel Edukasi Pengelolaan Sampah";
            // 
            // lblMediaTitle
            // 
            this.lblMediaTitle.AutoSize = true;
            this.lblMediaTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblMediaTitle.ForeColor = Color.FromArgb(6, 78, 59);
            this.lblMediaTitle.Location = new Point(20, 20);
            this.lblMediaTitle.Name = "lblMediaTitle";
            this.lblMediaTitle.Size = new Size(295, 20);
            this.lblMediaTitle.TabIndex = 0;
            this.lblMediaTitle.Text = "🎥 MEDIA EDUKASI & TUTORIAL BANK";
            // 
            // panelShortcuts
            // 
            this.panelShortcuts.BackColor = Color.White;
            this.panelShortcuts.Controls.Add(this.btnQuickTarik);
            this.panelShortcuts.Controls.Add(this.btnQuickSetor);
            this.panelShortcuts.Controls.Add(this.lblShortcutTitle);
            this.panelShortcuts.Dock = DockStyle.Top;
            this.panelShortcuts.Location = new Point(0, 0);
            this.panelShortcuts.Name = "panelShortcuts";
            this.panelShortcuts.Padding = new Padding(15);
            this.panelShortcuts.Size = new Size(414, 110);
            this.panelShortcuts.TabIndex = 0;
            // 
            // btnQuickTarik
            // 
            this.btnQuickTarik.BackColor = Color.FromArgb(239, 68, 68);
            this.btnQuickTarik.Cursor = Cursors.Hand;
            this.btnQuickTarik.FlatAppearance.BorderSize = 0;
            this.btnQuickTarik.FlatStyle = FlatStyle.Flat;
            this.btnQuickTarik.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnQuickTarik.ForeColor = Color.White;
            this.btnQuickTarik.Location = new Point(200, 48);
            this.btnQuickTarik.Name = "btnQuickTarik";
            this.btnQuickTarik.Size = new Size(194, 42);
            this.btnQuickTarik.TabIndex = 2;
            this.btnQuickTarik.Text = "💸 TARIK SALDO";
            this.btnQuickTarik.UseVisualStyleBackColor = false;
            this.btnQuickTarik.Click += new EventHandler(this.btnNavTransaksi_Click);
            // 
            // btnQuickSetor
            // 
            this.btnQuickSetor.BackColor = Color.FromArgb(16, 185, 129);
            this.btnQuickSetor.Cursor = Cursors.Hand;
            this.btnQuickSetor.FlatAppearance.BorderSize = 0;
            this.btnQuickSetor.FlatStyle = FlatStyle.Flat;
            this.btnQuickSetor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnQuickSetor.ForeColor = Color.White;
            this.btnQuickSetor.Location = new Point(18, 48);
            this.btnQuickSetor.Name = "btnQuickSetor";
            this.btnQuickSetor.Size = new Size(174, 42);
            this.btnQuickSetor.TabIndex = 1;
            this.btnQuickSetor.Text = "➕ SETOR SAMPAH";
            this.btnQuickSetor.UseVisualStyleBackColor = false;
            this.btnQuickSetor.Click += new EventHandler(this.btnNavTransaksi_Click);
            // 
            // lblShortcutTitle
            // 
            this.lblShortcutTitle.AutoSize = true;
            this.lblShortcutTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblShortcutTitle.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblShortcutTitle.Location = new Point(15, 15);
            this.lblShortcutTitle.Name = "lblShortcutTitle";
            this.lblShortcutTitle.Size = new Size(173, 19);
            this.lblShortcutTitle.TabIndex = 0;
            this.lblShortcutTitle.Text = "⚡ AKSES CEPAT (SHORTCUT)";
            // 
            // panelCards
            // 
            this.panelCards.ColumnCount = 4;
            this.panelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.panelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.panelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.panelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.panelCards.Controls.Add(this.card4, 3, 0);
            this.panelCards.Controls.Add(this.card3, 2, 0);
            this.panelCards.Controls.Add(this.card2, 1, 0);
            this.panelCards.Controls.Add(this.card1, 0, 0);
            this.panelCards.Dock = DockStyle.Top;
            this.panelCards.Location = new Point(20, 20);
            this.panelCards.Name = "panelCards";
            this.panelCards.RowCount = 1;
            this.panelCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.panelCards.Size = new Size(920, 120);
            this.panelCards.TabIndex = 0;
            // 
            // card4
            // 
            this.card4.BackColor = Color.FromArgb(217, 119, 6);
            this.card4.Controls.Add(this.lblValSaldo);
            this.card4.Controls.Add(this.lblTitleSaldo);
            this.card4.Dock = DockStyle.Fill;
            this.card4.Location = new Point(693, 5);
            this.card4.Margin = new Padding(3, 5, 3, 5);
            this.card4.Name = "card4";
            this.card4.Size = new Size(224, 110);
            this.card4.TabIndex = 3;
            // 
            // lblValSaldo
            // 
            this.lblValSaldo.AutoSize = true;
            this.lblValSaldo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblValSaldo.ForeColor = Color.White;
            this.lblValSaldo.Location = new Point(15, 52);
            this.lblValSaldo.Name = "lblValSaldo";
            this.lblValSaldo.Size = new Size(130, 30);
            this.lblValSaldo.TabIndex = 1;
            this.lblValSaldo.Text = "Rp 193.500";
            // 
            // lblTitleSaldo
            // 
            this.lblTitleSaldo.AutoSize = true;
            this.lblTitleSaldo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblTitleSaldo.ForeColor = Color.White;
            this.lblTitleSaldo.Location = new Point(15, 20);
            this.lblTitleSaldo.Name = "lblTitleSaldo";
            this.lblTitleSaldo.Size = new Size(130, 15);
            this.lblTitleSaldo.TabIndex = 0;
            this.lblTitleSaldo.Text = "💰 TOTAL SALDO (RP)";
            // 
            // card3
            // 
            this.card3.BackColor = Color.FromArgb(124, 58, 237);
            this.card3.Controls.Add(this.lblValBerat);
            this.card3.Controls.Add(this.lblTitleBerat);
            this.card3.Dock = DockStyle.Fill;
            this.card3.Location = new Point(463, 5);
            this.card3.Margin = new Padding(3, 5, 3, 5);
            this.card3.Name = "card3";
            this.card3.Size = new Size(224, 110);
            this.card3.TabIndex = 2;
            // 
            // lblValBerat
            // 
            this.lblValBerat.AutoSize = true;
            this.lblValBerat.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblValBerat.ForeColor = Color.White;
            this.lblValBerat.Location = new Point(15, 50);
            this.lblValBerat.Name = "lblValBerat";
            this.lblValBerat.Size = new Size(117, 32);
            this.lblValBerat.TabIndex = 1;
            this.lblValBerat.Text = "38.54 Kg";
            // 
            // lblTitleBerat
            // 
            this.lblTitleBerat.AutoSize = true;
            this.lblTitleBerat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblTitleBerat.ForeColor = Color.White;
            this.lblTitleBerat.Location = new Point(15, 20);
            this.lblTitleBerat.Name = "lblTitleBerat";
            this.lblTitleBerat.Size = new Size(135, 15);
            this.lblTitleBerat.TabIndex = 0;
            this.lblTitleBerat.Text = "⚖️ TOTAL SAMPAH (KG)";
            // 
            // card2
            // 
            this.card2.BackColor = Color.FromArgb(37, 99, 235);
            this.card2.Controls.Add(this.lblValSampah);
            this.card2.Controls.Add(this.lblTitleSampah);
            this.card2.Dock = DockStyle.Fill;
            this.card2.Location = new Point(233, 5);
            this.card2.Margin = new Padding(3, 5, 3, 5);
            this.card2.Name = "card2";
            this.card2.Size = new Size(224, 110);
            this.card2.TabIndex = 1;
            // 
            // lblValSampah
            // 
            this.lblValSampah.AutoSize = true;
            this.lblValSampah.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblValSampah.ForeColor = Color.White;
            this.lblValSampah.Location = new Point(15, 48);
            this.lblValSampah.Name = "lblValSampah";
            this.lblValSampah.Size = new Size(32, 37);
            this.lblValSampah.TabIndex = 1;
            this.lblValSampah.Text = "6";
            // 
            // lblTitleSampah
            // 
            this.lblTitleSampah.AutoSize = true;
            this.lblTitleSampah.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblTitleSampah.ForeColor = Color.White;
            this.lblTitleSampah.Location = new Point(15, 20);
            this.lblTitleSampah.Name = "lblTitleSampah";
            this.lblTitleSampah.Size = new Size(106, 15);
            this.lblTitleSampah.TabIndex = 0;
            this.lblTitleSampah.Text = "♻️ JENIS SAMPAH";
            // 
            // card1
            // 
            this.card1.BackColor = Color.FromArgb(5, 150, 105);
            this.card1.Controls.Add(this.lblValNasabah);
            this.card1.Controls.Add(this.lblTitleNasabah);
            this.card1.Dock = DockStyle.Fill;
            this.card1.Location = new Point(3, 5);
            this.card1.Margin = new Padding(3, 5, 3, 5);
            this.card1.Name = "card1";
            this.card1.Size = new Size(224, 110);
            this.card1.TabIndex = 0;
            // 
            // lblValNasabah
            // 
            this.lblValNasabah.AutoSize = true;
            this.lblValNasabah.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblValNasabah.ForeColor = Color.White;
            this.lblValNasabah.Location = new Point(15, 48);
            this.lblValNasabah.Name = "lblValNasabah";
            this.lblValNasabah.Size = new Size(32, 37);
            this.lblValNasabah.TabIndex = 1;
            this.lblValNasabah.Text = "3";
            // 
            // lblTitleNasabah
            // 
            this.lblTitleNasabah.AutoSize = true;
            this.lblTitleNasabah.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblTitleNasabah.ForeColor = Color.White;
            this.lblTitleNasabah.Location = new Point(15, 20);
            this.lblTitleNasabah.Name = "lblTitleNasabah";
            this.lblTitleNasabah.Size = new Size(117, 15);
            this.lblTitleNasabah.TabIndex = 0;
            this.lblTitleNasabah.Text = "👥 TOTAL NASABAH";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(240, 244, 242);
            this.ClientSize = new Size(1200, 720);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSidebar);
            this.MinimumSize = new Size(1080, 680);
            this.Name = "FormMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Dashboard - Aplikasi Bank Sampah Digital SMKN 13 Bandung";
            this.Load += new EventHandler(this.FormMain_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelUserProfile.ResumeLayout(false);
            this.panelUserProfile.PerformLayout();
            this.panelBrand.ResumeLayout(false);
            this.panelBrand.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.flowTopRight.ResumeLayout(false);
            this.flowTopRight.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelDashboardView.ResumeLayout(false);
            this.panelMainSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSampah)).EndInit();
            this.panelRightColumn.ResumeLayout(false);
            this.panelMedia.ResumeLayout(false);
            this.panelMedia.PerformLayout();
            this.panelShortcuts.ResumeLayout(false);
            this.panelShortcuts.PerformLayout();
            this.panelCards.ResumeLayout(false);
            this.card4.ResumeLayout(false);
            this.card4.PerformLayout();
            this.card3.ResumeLayout(false);
            this.card3.PerformLayout();
            this.card2.ResumeLayout(false);
            this.card2.PerformLayout();
            this.card1.ResumeLayout(false);
            this.card1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelBrand;
        private System.Windows.Forms.Label lblBrandTitle;
        private System.Windows.Forms.Label lblBrandSub;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavNasabah;
        private System.Windows.Forms.Button btnNavSampah;
        private System.Windows.Forms.Button btnNavTransaksi;
        private System.Windows.Forms.Button btnNavPengaturan;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelUserProfile;
        private System.Windows.Forms.Label lblUserAvatar;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRoleTag;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.FlowLayoutPanel flowTopRight;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblStatusBadge;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelDashboardView;
        private System.Windows.Forms.TableLayoutPanel panelCards;
        private System.Windows.Forms.Panel card1;
        private System.Windows.Forms.Label lblTitleNasabah;
        private System.Windows.Forms.Label lblValNasabah;
        private System.Windows.Forms.Panel card2;
        private System.Windows.Forms.Label lblValSampah;
        private System.Windows.Forms.Label lblTitleSampah;
        private System.Windows.Forms.Panel card3;
        private System.Windows.Forms.Label lblValBerat;
        private System.Windows.Forms.Label lblTitleBerat;
        private System.Windows.Forms.Panel card4;
        private System.Windows.Forms.Label lblValSaldo;
        private System.Windows.Forms.Label lblTitleSaldo;
        private System.Windows.Forms.TableLayoutPanel panelMainSplit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSampah;
        private System.Windows.Forms.Panel panelRightColumn;
        private System.Windows.Forms.Panel panelShortcuts;
        private System.Windows.Forms.Label lblShortcutTitle;
        private System.Windows.Forms.Button btnQuickSetor;
        private System.Windows.Forms.Button btnQuickTarik;
        private System.Windows.Forms.Panel panelMedia;
        private System.Windows.Forms.Label lblMediaTitle;
        private System.Windows.Forms.Label lblMediaDesc;
        private System.Windows.Forms.Button btnPlayMedia;
    }
}
