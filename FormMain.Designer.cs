using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            ChartArea chartArea1 = new ChartArea();
            Series series1 = new Series();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.lblTitlebar = new System.Windows.Forms.Label();
            this.panelWindowDots = new System.Windows.Forms.Panel();
            this.dotClose = new System.Windows.Forms.Label();
            this.dotMax = new System.Windows.Forms.Label();
            this.dotMin = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnNavPengaturan = new System.Windows.Forms.Button();
            this.btnNavLaporan = new System.Windows.Forms.Button();
            this.btnNavPenjemputan = new System.Windows.Forms.Button();
            this.btnNavTransaksi = new System.Windows.Forms.Button();
            this.btnNavSampah = new System.Windows.Forms.Button();
            this.panelEcoImpact = new System.Windows.Forms.Panel();
            this.lblEcoTitle = new System.Windows.Forms.Label();
            this.lblEcoDesc = new System.Windows.Forms.Label();
            this.panelEcoCo2Box = new System.Windows.Forms.Panel();
            this.lblEcoCO2Title = new System.Windows.Forms.Label();
            this.lblEcoCO2Val = new System.Windows.Forms.Label();
            this.panelEcoTreeBox = new System.Windows.Forms.Panel();
            this.lblEcoPohonTitle = new System.Windows.Forms.Label();
            this.lblEcoPohonVal = new System.Windows.Forms.Label();
            this.lblEcoTag = new System.Windows.Forms.Label();
            this.lblEcoEduLink = new System.Windows.Forms.Label();
            this.btnNavNasabah = new System.Windows.Forms.Button();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogoSub = new System.Windows.Forms.Label();
            this.lblLogoTitle = new System.Windows.Forms.Label();
            this.lblLogoMark = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelDashboardView = new System.Windows.Forms.Panel();
            this.tableLayoutPanelGrid = new System.Windows.Forms.TableLayoutPanel();
            this.panelChartBox = new System.Windows.Forms.Panel();
            this.chartSetoran = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.panelRightMedia = new System.Windows.Forms.Panel();
            this.panelBanner = new System.Windows.Forms.Panel();
            this.lblBannerText = new System.Windows.Forms.Label();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.panelVideoBox = new System.Windows.Forms.Panel();
            this.btnPlayVideo = new System.Windows.Forms.Button();
            this.lblVideoTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanelKpi = new System.Windows.Forms.TableLayoutPanel();
            this.kpi4 = new System.Windows.Forms.Panel();
            this.lblKpi4Sub = new System.Windows.Forms.Label();
            this.lblKpi4Val = new System.Windows.Forms.Label();
            this.kpi3 = new System.Windows.Forms.Panel();
            this.lblKpi3Sub = new System.Windows.Forms.Label();
            this.lblKpi3Val = new System.Windows.Forms.Label();
            this.kpi2 = new System.Windows.Forms.Panel();
            this.lblKpi2Sub = new System.Windows.Forms.Label();
            this.lblKpi2Val = new System.Windows.Forms.Label();
            this.kpi1 = new System.Windows.Forms.Panel();
            this.lblKpi1Sub = new System.Windows.Forms.Label();
            this.lblKpi1Val = new System.Windows.Forms.Label();
            this.panelDashHeader = new System.Windows.Forms.Panel();
            this.lblDashDesc = new System.Windows.Forms.Label();
            this.lblDashTitle = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.panelTitlebar.SuspendLayout();
            this.panelWindowDots.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelDashboardView.SuspendLayout();
            this.tableLayoutPanelGrid.SuspendLayout();
            this.panelChartBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSetoran)).BeginInit();
            this.panelRightMedia.SuspendLayout();
            this.panelBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.panelVideoBox.SuspendLayout();
            this.tableLayoutPanelKpi.SuspendLayout();
            this.kpi4.SuspendLayout();
            this.kpi3.SuspendLayout();
            this.kpi2.SuspendLayout();
            this.kpi1.SuspendLayout();
            this.panelDashHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.panelTitlebar.Controls.Add(this.lblTitlebar);
            this.panelTitlebar.Controls.Add(this.panelWindowDots);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(0, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.panelTitlebar.Size = new System.Drawing.Size(1100, 36);
            this.panelTitlebar.TabIndex = 0;
            // 
            // lblTitlebar
            // 
            this.lblTitlebar.AutoSize = true;
            this.lblTitlebar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.lblTitlebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(216)))));
            this.lblTitlebar.Location = new System.Drawing.Point(12, 9);
            this.lblTitlebar.Name = "lblTitlebar";
            this.lblTitlebar.Size = new System.Drawing.Size(264, 17);
            this.lblTitlebar.TabIndex = 0;
            this.lblTitlebar.Text = "SIMBAS.exe — Sistem Informasi Bank Sampah";
            // 
            // panelWindowDots
            // 
            this.panelWindowDots.Controls.Add(this.dotMin);
            this.panelWindowDots.Controls.Add(this.dotMax);
            this.panelWindowDots.Controls.Add(this.dotClose);
            this.panelWindowDots.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelWindowDots.Location = new System.Drawing.Point(996, 0);
            this.panelWindowDots.Name = "panelWindowDots";
            this.panelWindowDots.Size = new System.Drawing.Size(90, 36);
            this.panelWindowDots.TabIndex = 1;
            // 
            // dotClose
            // 
            this.dotClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(70)))), ((int)(((byte)(50)))));
            this.dotClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dotClose.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.dotClose.ForeColor = System.Drawing.Color.White;
            this.dotClose.Location = new System.Drawing.Point(64, 10);
            this.dotClose.Name = "dotClose";
            this.dotClose.Size = new System.Drawing.Size(16, 16);
            this.dotClose.TabIndex = 2;
            this.dotClose.Text = "✕";
            this.dotClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dotClose.Click += new System.EventHandler(this.dotClose_Click);
            // 
            // dotMax
            // 
            this.dotMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(60)))));
            this.dotMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dotMax.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.dotMax.ForeColor = System.Drawing.Color.White;
            this.dotMax.Location = new System.Drawing.Point(38, 10);
            this.dotMax.Name = "dotMax";
            this.dotMax.Size = new System.Drawing.Size(16, 16);
            this.dotMax.TabIndex = 1;
            this.dotMax.Text = "+";
            this.dotMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dotMax.Click += new System.EventHandler(this.dotMax_Click);
            // 
            // dotMin
            // 
            this.dotMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(60)))));
            this.dotMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dotMin.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.dotMin.ForeColor = System.Drawing.Color.White;
            this.dotMin.Location = new System.Drawing.Point(12, 10);
            this.dotMin.Name = "dotMin";
            this.dotMin.Size = new System.Drawing.Size(16, 16);
            this.dotMin.TabIndex = 0;
            this.dotMin.Text = "-";
            this.dotMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dotMin.Click += new System.EventHandler(this.dotMin_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(46)))));
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnNavPengaturan);
            this.panelSidebar.Controls.Add(this.btnNavLaporan);
            this.panelSidebar.Controls.Add(this.btnNavPenjemputan);
            this.panelSidebar.Controls.Add(this.btnNavTransaksi);
            this.panelSidebar.Controls.Add(this.btnNavSampah);
            this.panelSidebar.Controls.Add(this.btnNavNasabah);
            this.panelSidebar.Controls.Add(this.btnNavDashboard);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 36);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Padding = new System.Windows.Forms.Padding(0, 16, 0, 16);
            this.panelSidebar.Size = new System.Drawing.Size(200, 664);
            this.panelSidebar.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblLogoSub);
            this.panelLogo.Controls.Add(this.lblLogoTitle);
            this.panelLogo.Controls.Add(this.lblLogoMark);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 16);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(16, 0, 16, 14);
            this.panelLogo.Size = new System.Drawing.Size(200, 60);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogoMark
            // 
            this.lblLogoMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.lblLogoMark.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLogoMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(26)))), ((int)(((byte)(2)))));
            this.lblLogoMark.Location = new System.Drawing.Point(14, 4);
            this.lblLogoMark.Name = "lblLogoMark";
            this.lblLogoMark.Size = new System.Drawing.Size(32, 32);
            this.lblLogoMark.TabIndex = 0;
            this.lblLogoMark.Text = "♻";
            this.lblLogoMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogoTitle
            // 
            this.lblLogoTitle.AutoSize = true;
            this.lblLogoTitle.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblLogoTitle.ForeColor = System.Drawing.Color.White;
            this.lblLogoTitle.Location = new System.Drawing.Point(52, 4);
            this.lblLogoTitle.Name = "lblLogoTitle";
            this.lblLogoTitle.Size = new System.Drawing.Size(69, 21);
            this.lblLogoTitle.TabIndex = 1;
            this.lblLogoTitle.Text = "SIMBAS";
            // 
            // lblLogoSub
            // 
            this.lblLogoSub.AutoSize = true;
            this.lblLogoSub.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblLogoSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(176)))), ((int)(((byte)(162)))));
            this.lblLogoSub.Location = new System.Drawing.Point(53, 25);
            this.lblLogoSub.Name = "lblLogoSub";
            this.lblLogoSub.Size = new System.Drawing.Size(107, 12);
            this.lblLogoSub.TabIndex = 2;
            this.lblLogoSub.Text = "BANK SAMPAH DIGITAL";
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNavDashboard.ForeColor = System.Drawing.Color.White;
            this.btnNavDashboard.Location = new System.Drawing.Point(0, 76);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavDashboard.Size = new System.Drawing.Size(200, 42);
            this.btnNavDashboard.TabIndex = 1;
            this.btnNavDashboard.Text = "  📊   Dashboard";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.UseVisualStyleBackColor = false;
            this.btnNavDashboard.Click += new System.EventHandler(this.btnNavDashboard_Click);
            // 
            // btnNavNasabah
            // 
            this.btnNavNasabah.BackColor = System.Drawing.Color.Transparent;
            this.btnNavNasabah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavNasabah.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavNasabah.FlatAppearance.BorderSize = 0;
            this.btnNavNasabah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavNasabah.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnNavNasabah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(201)))));
            this.btnNavNasabah.Location = new System.Drawing.Point(0, 118);
            this.btnNavNasabah.Name = "btnNavNasabah";
            this.btnNavNasabah.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavNasabah.Size = new System.Drawing.Size(200, 42);
            this.btnNavNasabah.TabIndex = 2;
            this.btnNavNasabah.Text = "  👥   Data Nasabah";
            this.btnNavNasabah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavNasabah.UseVisualStyleBackColor = false;
            this.btnNavNasabah.Click += new System.EventHandler(this.btnNavNasabah_Click);
            // 
            // btnNavSampah
            // 
            this.btnNavSampah.BackColor = System.Drawing.Color.Transparent;
            this.btnNavSampah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavSampah.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavSampah.FlatAppearance.BorderSize = 0;
            this.btnNavSampah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSampah.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnNavSampah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(201)))));
            this.btnNavSampah.Location = new System.Drawing.Point(0, 160);
            this.btnNavSampah.Name = "btnNavSampah";
            this.btnNavSampah.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavSampah.Size = new System.Drawing.Size(200, 42);
            this.btnNavSampah.TabIndex = 3;
            this.btnNavSampah.Text = "  ♻️   Jenis Sampah";
            this.btnNavSampah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavSampah.UseVisualStyleBackColor = false;
            this.btnNavSampah.Click += new System.EventHandler(this.btnNavSampah_Click);
            // 
            // btnNavTransaksi
            // 
            this.btnNavTransaksi.BackColor = System.Drawing.Color.Transparent;
            this.btnNavTransaksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavTransaksi.FlatAppearance.BorderSize = 0;
            this.btnNavTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTransaksi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnNavTransaksi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(201)))));
            this.btnNavTransaksi.Location = new System.Drawing.Point(0, 202);
            this.btnNavTransaksi.Name = "btnNavTransaksi";
            this.btnNavTransaksi.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavTransaksi.Size = new System.Drawing.Size(200, 42);
            this.btnNavTransaksi.TabIndex = 4;
            this.btnNavTransaksi.Text = "  💸   Transaksi Setor";
            this.btnNavTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavTransaksi.UseVisualStyleBackColor = false;
            this.btnNavTransaksi.Click += new System.EventHandler(this.btnNavTransaksi_Click);
            // 
            // btnNavPenjemputan
            // 
            this.btnNavPenjemputan.BackColor = System.Drawing.Color.Transparent;
            this.btnNavPenjemputan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavPenjemputan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavPenjemputan.FlatAppearance.BorderSize = 0;
            this.btnNavPenjemputan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPenjemputan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnNavPenjemputan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(201)))));
            this.btnNavPenjemputan.Location = new System.Drawing.Point(0, 244);
            this.btnNavPenjemputan.Name = "btnNavPenjemputan";
            this.btnNavPenjemputan.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavPenjemputan.Size = new System.Drawing.Size(200, 42);
            this.btnNavPenjemputan.TabIndex = 5;
            this.btnNavPenjemputan.Text = "  🚚   Penjemputan";
            this.btnNavPenjemputan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavPenjemputan.UseVisualStyleBackColor = false;
            this.btnNavPenjemputan.Click += new System.EventHandler(this.btnNavPenjemputan_Click);
            // 
            // btnNavLaporan
            // 
            this.btnNavLaporan.BackColor = System.Drawing.Color.Transparent;
            this.btnNavLaporan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavLaporan.FlatAppearance.BorderSize = 0;
            this.btnNavLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLaporan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnNavLaporan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(201)))));
            this.btnNavLaporan.Location = new System.Drawing.Point(0, 244);
            this.btnNavLaporan.Name = "btnNavLaporan";
            this.btnNavLaporan.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavLaporan.Size = new System.Drawing.Size(200, 42);
            this.btnNavLaporan.TabIndex = 5;
            this.btnNavLaporan.Text = "  📈   Laporan & Grafik";
            this.btnNavLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLaporan.UseVisualStyleBackColor = false;
            this.btnNavLaporan.Click += new System.EventHandler(this.btnNavLaporan_Click);
            // 
            // btnNavPengaturan
            // 
            this.btnNavPengaturan.BackColor = System.Drawing.Color.Transparent;
            this.btnNavPengaturan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavPengaturan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavPengaturan.FlatAppearance.BorderSize = 0;
            this.btnNavPengaturan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPengaturan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnNavPengaturan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(201)))));
            this.btnNavPengaturan.Location = new System.Drawing.Point(0, 286);
            this.btnNavPengaturan.Name = "btnNavPengaturan";
            this.btnNavPengaturan.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavPengaturan.Size = new System.Drawing.Size(200, 42);
            this.btnNavPengaturan.TabIndex = 6;
            this.btnNavPengaturan.Text = "  ⚙️   Pengaturan";
            this.btnNavPengaturan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavPengaturan.UseVisualStyleBackColor = false;
            this.btnNavPengaturan.Click += new System.EventHandler(this.btnNavPengaturan_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(136)))), ((int)(((byte)(120)))));
            this.btnLogout.Location = new System.Drawing.Point(0, 618);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(200, 42);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "  🚪   Keluar (Logout)";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.panelContent.Controls.Add(this.panelDashboardView);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 36);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelContent.Size = new System.Drawing.Size(900, 664);
            this.panelContent.TabIndex = 2;
            // 
            // panelDashboardView
            // 
            this.panelDashboardView.AutoScroll = true;
            this.panelDashboardView.Controls.Add(this.tableLayoutPanelGrid);
            this.panelDashboardView.Controls.Add(this.tableLayoutPanelKpi);
            this.panelDashboardView.Controls.Add(this.panelDashHeader);
            this.panelDashboardView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboardView.Location = new System.Drawing.Point(20, 20);
            this.panelDashboardView.Name = "panelDashboardView";
            this.panelDashboardView.Size = new System.Drawing.Size(860, 624);
            this.panelDashboardView.TabIndex = 0;
            // 
            // panelDashHeader
            // 
            this.panelDashHeader.Controls.Add(this.lblDashDesc);
            this.panelDashHeader.Controls.Add(this.lblDashTitle);
            this.panelDashHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDashHeader.Location = new System.Drawing.Point(0, 0);
            this.panelDashHeader.Name = "panelDashHeader";
            this.panelDashHeader.Size = new System.Drawing.Size(860, 50);
            this.panelDashHeader.TabIndex = 0;
            // 
            // lblDashTitle
            // 
            this.lblDashTitle.AutoSize = true;
            this.lblDashTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDashTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblDashTitle.Location = new System.Drawing.Point(0, 0);
            this.lblDashTitle.Name = "lblDashTitle";
            this.lblDashTitle.Size = new System.Drawing.Size(109, 25);
            this.lblDashTitle.TabIndex = 0;
            this.lblDashTitle.Text = "Dashboard";
            // 
            // lblDashDesc
            // 
            this.lblDashDesc.AutoSize = true;
            this.lblDashDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDashDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblDashDesc.Location = new System.Drawing.Point(1, 28);
            this.lblDashDesc.Name = "lblDashDesc";
            this.lblDashDesc.Size = new System.Drawing.Size(425, 17);
            this.lblDashDesc.TabIndex = 2;
            this.lblDashDesc.Text = "Nama aplikasi, ringkasan jumlah data, dan info multimedia tampil di sini.";
            // 
            // tableLayoutPanelKpi
            // 
            this.tableLayoutPanelKpi.ColumnCount = 4;
            this.tableLayoutPanelKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelKpi.Controls.Add(this.kpi4, 3, 0);
            this.tableLayoutPanelKpi.Controls.Add(this.kpi3, 2, 0);
            this.tableLayoutPanelKpi.Controls.Add(this.kpi2, 1, 0);
            this.tableLayoutPanelKpi.Controls.Add(this.kpi1, 0, 0);
            this.tableLayoutPanelKpi.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelKpi.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanelKpi.Name = "tableLayoutPanelKpi";
            this.tableLayoutPanelKpi.RowCount = 1;
            this.tableLayoutPanelKpi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelKpi.Size = new System.Drawing.Size(860, 86);
            this.tableLayoutPanelKpi.TabIndex = 1;
            // 
            // kpi1
            // 
            this.kpi1.BackColor = System.Drawing.Color.White;
            this.kpi1.Controls.Add(this.lblKpi1Sub);
            this.kpi1.Controls.Add(this.lblKpi1Val);
            this.kpi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpi1.Location = new System.Drawing.Point(3, 3);
            this.kpi1.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.kpi1.Name = "kpi1";
            this.kpi1.Padding = new System.Windows.Forms.Padding(12);
            this.kpi1.Size = new System.Drawing.Size(206, 80);
            this.kpi1.TabIndex = 0;
            this.kpi1.Paint += new System.Windows.Forms.PaintEventHandler(this.kpi1_Paint);
            // 
            // lblKpi1Val
            // 
            this.lblKpi1Val.AutoSize = true;
            this.lblKpi1Val.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKpi1Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblKpi1Val.Location = new System.Drawing.Point(8, 12);
            this.lblKpi1Val.Name = "lblKpi1Val";
            this.lblKpi1Val.Size = new System.Drawing.Size(51, 30);
            this.lblKpi1Val.TabIndex = 0;
            this.lblKpi1Val.Text = "128";
            // 
            // lblKpi1Sub
            // 
            this.lblKpi1Sub.AutoSize = true;
            this.lblKpi1Sub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpi1Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblKpi1Sub.Location = new System.Drawing.Point(10, 48);
            this.lblKpi1Sub.Name = "lblKpi1Sub";
            this.lblKpi1Sub.Size = new System.Drawing.Size(107, 15);
            this.lblKpi1Sub.TabIndex = 1;
            this.lblKpi1Sub.Text = "Nasabah Terdaftar";
            // 
            // kpi2
            // 
            this.kpi2.BackColor = System.Drawing.Color.White;
            this.kpi2.Controls.Add(this.lblKpi2Sub);
            this.kpi2.Controls.Add(this.lblKpi2Val);
            this.kpi2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpi2.Location = new System.Drawing.Point(218, 3);
            this.kpi2.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.kpi2.Name = "kpi2";
            this.kpi2.Padding = new System.Windows.Forms.Padding(12);
            this.kpi2.Size = new System.Drawing.Size(206, 80);
            this.kpi2.TabIndex = 1;
            this.kpi2.Paint += new System.Windows.Forms.PaintEventHandler(this.kpi2_Paint);
            // 
            // lblKpi2Val
            // 
            this.lblKpi2Val.AutoSize = true;
            this.lblKpi2Val.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKpi2Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblKpi2Val.Location = new System.Drawing.Point(8, 12);
            this.lblKpi2Val.Name = "lblKpi2Val";
            this.lblKpi2Val.Size = new System.Drawing.Size(101, 30);
            this.lblKpi2Val.TabIndex = 0;
            this.lblKpi2Val.Text = "1.240 kg";
            // 
            // lblKpi2Sub
            // 
            this.lblKpi2Sub.AutoSize = true;
            this.lblKpi2Sub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpi2Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblKpi2Sub.Location = new System.Drawing.Point(10, 48);
            this.lblKpi2Sub.Name = "lblKpi2Sub";
            this.lblKpi2Sub.Size = new System.Drawing.Size(110, 15);
            this.lblKpi2Sub.TabIndex = 1;
            this.lblKpi2Sub.Text = "Sampah Terkumpul";
            // 
            // kpi3
            // 
            this.kpi3.BackColor = System.Drawing.Color.White;
            this.kpi3.Controls.Add(this.lblKpi3Sub);
            this.kpi3.Controls.Add(this.lblKpi3Val);
            this.kpi3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpi3.Location = new System.Drawing.Point(433, 3);
            this.kpi3.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.kpi3.Name = "kpi3";
            this.kpi3.Padding = new System.Windows.Forms.Padding(12);
            this.kpi3.Size = new System.Drawing.Size(206, 80);
            this.kpi3.TabIndex = 2;
            this.kpi3.Paint += new System.Windows.Forms.PaintEventHandler(this.kpi3_Paint);
            // 
            // lblKpi3Val
            // 
            this.lblKpi3Val.AutoSize = true;
            this.lblKpi3Val.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblKpi3Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblKpi3Val.Location = new System.Drawing.Point(8, 14);
            this.lblKpi3Val.Name = "lblKpi3Val";
            this.lblKpi3Val.Size = new System.Drawing.Size(140, 28);
            this.lblKpi3Val.TabIndex = 0;
            this.lblKpi3Val.Text = "Rp 6.850.000";
            // 
            // lblKpi3Sub
            // 
            this.lblKpi3Sub.AutoSize = true;
            this.lblKpi3Sub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpi3Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblKpi3Sub.Location = new System.Drawing.Point(10, 48);
            this.lblKpi3Sub.Name = "lblKpi3Sub";
            this.lblKpi3Sub.Size = new System.Drawing.Size(117, 15);
            this.lblKpi3Sub.TabIndex = 1;
            this.lblKpi3Sub.Text = "Total Saldo Nasabah";
            // 
            // kpi4
            // 
            this.kpi4.BackColor = System.Drawing.Color.White;
            this.kpi4.Controls.Add(this.lblKpi4Sub);
            this.kpi4.Controls.Add(this.lblKpi4Val);
            this.kpi4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpi4.Location = new System.Drawing.Point(648, 3);
            this.kpi4.Name = "kpi4";
            this.kpi4.Padding = new System.Windows.Forms.Padding(12);
            this.kpi4.Size = new System.Drawing.Size(209, 80);
            this.kpi4.TabIndex = 3;
            this.kpi4.Paint += new System.Windows.Forms.PaintEventHandler(this.kpi4_Paint);
            // 
            // lblKpi4Val
            // 
            this.lblKpi4Val.AutoSize = true;
            this.lblKpi4Val.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKpi4Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblKpi4Val.Location = new System.Drawing.Point(8, 12);
            this.lblKpi4Val.Name = "lblKpi4Val";
            this.lblKpi4Val.Size = new System.Drawing.Size(39, 30);
            this.lblKpi4Val.TabIndex = 0;
            this.lblKpi4Val.Text = "34";
            // 
            // lblKpi4Sub
            // 
            this.lblKpi4Sub.AutoSize = true;
            this.lblKpi4Sub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKpi4Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblKpi4Sub.Location = new System.Drawing.Point(10, 48);
            this.lblKpi4Sub.Name = "lblKpi4Sub";
            this.lblKpi4Sub.Size = new System.Drawing.Size(107, 15);
            this.lblKpi4Sub.TabIndex = 1;
            this.lblKpi4Sub.Text = "Setoran Bulan Ini";
            // 
            // tableLayoutPanelGrid
            // 
            this.tableLayoutPanelGrid.ColumnCount = 2;
            this.tableLayoutPanelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanelGrid.Controls.Add(this.panelChartBox, 0, 0);
            this.tableLayoutPanelGrid.Controls.Add(this.panelRightMedia, 1, 0);
            this.tableLayoutPanelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGrid.Location = new System.Drawing.Point(0, 136);
            this.tableLayoutPanelGrid.Name = "tableLayoutPanelGrid";
            this.tableLayoutPanelGrid.RowCount = 1;
            this.tableLayoutPanelGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGrid.Size = new System.Drawing.Size(860, 488);
            this.tableLayoutPanelGrid.TabIndex = 2;
            // 
            // panelChartBox
            // 
            this.panelChartBox.BackColor = System.Drawing.Color.White;
            this.panelChartBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChartBox.Controls.Add(this.chartSetoran);
            this.panelChartBox.Controls.Add(this.lblChartTitle);
            this.panelChartBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChartBox.Location = new System.Drawing.Point(3, 14);
            this.panelChartBox.Margin = new System.Windows.Forms.Padding(3, 14, 8, 3);
            this.panelChartBox.Name = "panelChartBox";
            this.panelChartBox.Padding = new System.Windows.Forms.Padding(16);
            this.panelChartBox.Size = new System.Drawing.Size(573, 471);
            this.panelChartBox.TabIndex = 0;
            // 
            // lblChartTitle
            // 
            this.lblChartTitle.AutoSize = true;
            this.lblChartTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblChartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblChartTitle.Location = new System.Drawing.Point(14, 14);
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.Size = new System.Drawing.Size(183, 19);
            this.lblChartTitle.TabIndex = 0;
            this.lblChartTitle.Text = "Setoran Sampah per Bulan";
            // 
            // chartSetoran
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(194)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartSetoran.ChartAreas.Add(chartArea1);
            this.chartSetoran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartSetoran.Location = new System.Drawing.Point(16, 45);
            this.chartSetoran.Name = "chartSetoran";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(122)))), ((int)(((byte)(94)))));
            series1.CustomProperties = "PointWidth=0.6";
            series1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            series1.Name = "Setoran";
            this.chartSetoran.Series.Add(series1);
            this.chartSetoran.Size = new System.Drawing.Size(539, 408);
            this.chartSetoran.TabIndex = 2;
            // 
            // panelRightMedia
            // 
            this.panelRightMedia.Controls.Add(this.panelEcoImpact);
            this.panelRightMedia.Controls.Add(this.panelBanner);
            this.panelRightMedia.Controls.Add(this.panelVideoBox);
            this.panelRightMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightMedia.Location = new System.Drawing.Point(587, 14);
            this.panelRightMedia.Margin = new System.Windows.Forms.Padding(3, 14, 3, 3);
            this.panelRightMedia.Name = "panelRightMedia";
            this.panelRightMedia.Size = new System.Drawing.Size(270, 471);
            this.panelRightMedia.TabIndex = 1;
            // 
            // panelVideoBox
            // 
            this.panelVideoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.panelVideoBox.Controls.Add(this.btnPlayVideo);
            this.panelVideoBox.Controls.Add(this.lblVideoTitle);
            this.panelVideoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVideoBox.Location = new System.Drawing.Point(0, 0);
            this.panelVideoBox.Name = "panelVideoBox";
            this.panelVideoBox.Padding = new System.Windows.Forms.Padding(16);
            this.panelVideoBox.Size = new System.Drawing.Size(270, 110);
            this.panelVideoBox.TabIndex = 0;
            // 
            // lblVideoTitle
            // 
            this.lblVideoTitle.AutoSize = true;
            this.lblVideoTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblVideoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(216)))));
            this.lblVideoTitle.Location = new System.Drawing.Point(14, 14);
            this.lblVideoTitle.Name = "lblVideoTitle";
            this.lblVideoTitle.Size = new System.Drawing.Size(184, 19);
            this.lblVideoTitle.TabIndex = 0;
            this.lblVideoTitle.Text = "Video Edukasi Bank Sampah";
            // 
            // btnPlayVideo
            // 
            this.btnPlayVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.btnPlayVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayVideo.FlatAppearance.BorderSize = 0;
            this.btnPlayVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayVideo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnPlayVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(26)))), ((int)(((byte)(2)))));
            this.btnPlayVideo.Location = new System.Drawing.Point(18, 48);
            this.btnPlayVideo.Name = "btnPlayVideo";
            this.btnPlayVideo.Size = new System.Drawing.Size(120, 38);
            this.btnPlayVideo.TabIndex = 1;
            this.btnPlayVideo.Text = "▶  Putar Video";
            this.btnPlayVideo.UseVisualStyleBackColor = false;
            this.btnPlayVideo.Click += new System.EventHandler(this.btnPlayVideo_Click);
            // 
            // panelBanner
            // 
            this.panelBanner.BackColor = System.Drawing.Color.White;
            this.panelBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBanner.Controls.Add(this.picBanner);
            this.panelBanner.Controls.Add(this.lblBannerText);
            this.panelBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBanner.Location = new System.Drawing.Point(0, 124);
            this.panelBanner.Margin = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Padding = new System.Windows.Forms.Padding(12);
            this.panelBanner.Size = new System.Drawing.Size(270, 160);
            this.panelBanner.TabIndex = 1;
            // 
            // picBanner
            // 
            this.picBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.picBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBanner.Location = new System.Drawing.Point(12, 40);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(244, 106);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBanner.TabIndex = 2;
            this.picBanner.TabStop = false;
            // 
            // lblBannerText
            // 
            this.lblBannerText.AutoSize = true;
            this.lblBannerText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBannerText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblBannerText.Location = new System.Drawing.Point(12, 12);
            this.lblBannerText.Name = "lblBannerText";
            this.lblBannerText.Size = new System.Drawing.Size(142, 15);
            this.lblBannerText.TabIndex = 0;
            this.lblBannerText.Text = "Banner / Logo SIMBAS";
            // 
            // panelEcoImpact
            // 
            this.panelEcoImpact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.panelEcoImpact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEcoImpact.Controls.Add(this.lblEcoEduLink);
            this.panelEcoImpact.Controls.Add(this.lblEcoTag);
            this.panelEcoImpact.Controls.Add(this.panelEcoTreeBox);
            this.panelEcoImpact.Controls.Add(this.panelEcoCo2Box);
            this.panelEcoImpact.Controls.Add(this.lblEcoDesc);
            this.panelEcoImpact.Controls.Add(this.lblEcoTitle);
            this.panelEcoImpact.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEcoImpact.Location = new System.Drawing.Point(0, 298);
            this.panelEcoImpact.Margin = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.panelEcoImpact.Name = "panelEcoImpact";
            this.panelEcoImpact.Padding = new System.Windows.Forms.Padding(12);
            this.panelEcoImpact.Size = new System.Drawing.Size(270, 176);
            this.panelEcoImpact.TabIndex = 2;
            // 
            // lblEcoTitle
            // 
            this.lblEcoTitle.AutoSize = true;
            this.lblEcoTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEcoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblEcoTitle.Location = new System.Drawing.Point(10, 8);
            this.lblEcoTitle.Name = "lblEcoTitle";
            this.lblEcoTitle.Size = new System.Drawing.Size(232, 17);
            this.lblEcoTitle.TabIndex = 0;
            this.lblEcoTitle.Text = "🌿 Dampak Lingkungan (Eco-Impact)";
            // 
            // lblEcoDesc
            // 
            this.lblEcoDesc.AutoSize = true;
            this.lblEcoDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblEcoDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblEcoDesc.Location = new System.Drawing.Point(11, 28);
            this.lblEcoDesc.Name = "lblEcoDesc";
            this.lblEcoDesc.Size = new System.Drawing.Size(201, 13);
            this.lblEcoDesc.TabIndex = 1;
            this.lblEcoDesc.Text = "Estimasi kontribusi nyata terhadap bumi:";
            // 
            // panelEcoCo2Box
            // 
            this.panelEcoCo2Box.BackColor = System.Drawing.Color.White;
            this.panelEcoCo2Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEcoCo2Box.Controls.Add(this.lblEcoCO2Val);
            this.panelEcoCo2Box.Controls.Add(this.lblEcoCO2Title);
            this.panelEcoCo2Box.Location = new System.Drawing.Point(12, 46);
            this.panelEcoCo2Box.Name = "panelEcoCo2Box";
            this.panelEcoCo2Box.Size = new System.Drawing.Size(244, 32);
            this.panelEcoCo2Box.TabIndex = 2;
            // 
            // lblEcoCO2Title
            // 
            this.lblEcoCO2Title.AutoSize = true;
            this.lblEcoCO2Title.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblEcoCO2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(74)))), ((int)(((byte)(56)))));
            this.lblEcoCO2Title.Location = new System.Drawing.Point(6, 8);
            this.lblEcoCO2Title.Name = "lblEcoCO2Title";
            this.lblEcoCO2Title.Size = new System.Drawing.Size(107, 13);
            this.lblEcoCO2Title.TabIndex = 0;
            this.lblEcoCO2Title.Text = "🌍 Reduksi Emisi CO₂:";
            // 
            // lblEcoCO2Val
            // 
            this.lblEcoCO2Val.AutoSize = true;
            this.lblEcoCO2Val.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEcoCO2Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(122)))), ((int)(((byte)(94)))));
            this.lblEcoCO2Val.Location = new System.Drawing.Point(125, 8);
            this.lblEcoCO2Val.Name = "lblEcoCO2Val";
            this.lblEcoCO2Val.Size = new System.Drawing.Size(89, 15);
            this.lblEcoCO2Val.TabIndex = 1;
            this.lblEcoCO2Val.Text = "1.860 kg CO₂e";
            // 
            // panelEcoTreeBox
            // 
            this.panelEcoTreeBox.BackColor = System.Drawing.Color.White;
            this.panelEcoTreeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEcoTreeBox.Controls.Add(this.lblEcoPohonVal);
            this.panelEcoTreeBox.Controls.Add(this.lblEcoPohonTitle);
            this.panelEcoTreeBox.Location = new System.Drawing.Point(12, 84);
            this.panelEcoTreeBox.Name = "panelEcoTreeBox";
            this.panelEcoTreeBox.Size = new System.Drawing.Size(244, 32);
            this.panelEcoTreeBox.TabIndex = 3;
            // 
            // lblEcoPohonTitle
            // 
            this.lblEcoPohonTitle.AutoSize = true;
            this.lblEcoPohonTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblEcoPohonTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(74)))), ((int)(((byte)(56)))));
            this.lblEcoPohonTitle.Location = new System.Drawing.Point(6, 8);
            this.lblEcoPohonTitle.Name = "lblEcoPohonTitle";
            this.lblEcoPohonTitle.Size = new System.Drawing.Size(127, 13);
            this.lblEcoPohonTitle.TabIndex = 0;
            this.lblEcoPohonTitle.Text = "🌳 Pohon Terselamatkan:";
            // 
            // lblEcoPohonVal
            // 
            this.lblEcoPohonVal.AutoSize = true;
            this.lblEcoPohonVal.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEcoPohonVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblEcoPohonVal.Location = new System.Drawing.Point(145, 8);
            this.lblEcoPohonVal.Name = "lblEcoPohonVal";
            this.lblEcoPohonVal.Size = new System.Drawing.Size(56, 15);
            this.lblEcoPohonVal.TabIndex = 1;
            this.lblEcoPohonVal.Text = "31 Pohon";
            // 
            // lblEcoTag
            // 
            this.lblEcoTag.AutoSize = true;
            this.lblEcoTag.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblEcoTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblEcoTag.Location = new System.Drawing.Point(12, 128);
            this.lblEcoTag.Name = "lblEcoTag";
            this.lblEcoTag.Size = new System.Drawing.Size(224, 13);
            this.lblEcoTag.TabIndex = 4;
            this.lblEcoTag.Text = "♻️ 100% Dialihkan dari TPA (Zero Waste)";
            // 
            // lblEcoEduLink
            // 
            this.lblEcoEduLink.AutoSize = true;
            this.lblEcoEduLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEcoEduLink.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblEcoEduLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblEcoEduLink.Location = new System.Drawing.Point(12, 148);
            this.lblEcoEduLink.Name = "lblEcoEduLink";
            this.lblEcoEduLink.Size = new System.Drawing.Size(222, 13);
            this.lblEcoEduLink.TabIndex = 5;
            this.lblEcoEduLink.Text = "🧪 Edukasi Sains: Apa itu Simbol CO₂e? ➔";
            this.lblEcoEduLink.Click += new System.EventHandler(this.lblEcoEduLink_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelTitlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIMBAS";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTitlebar.ResumeLayout(false);
            this.panelTitlebar.PerformLayout();
            this.panelWindowDots.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelDashboardView.ResumeLayout(false);
            this.tableLayoutPanelGrid.ResumeLayout(false);
            this.panelChartBox.ResumeLayout(false);
            this.panelChartBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSetoran)).EndInit();
            this.panelRightMedia.ResumeLayout(false);
            this.panelBanner.ResumeLayout(false);
            this.panelBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.panelVideoBox.ResumeLayout(false);
            this.panelVideoBox.PerformLayout();
            this.tableLayoutPanelKpi.ResumeLayout(false);
            this.kpi4.ResumeLayout(false);
            this.kpi4.PerformLayout();
            this.kpi3.ResumeLayout(false);
            this.kpi3.PerformLayout();
            this.kpi2.ResumeLayout(false);
            this.kpi2.PerformLayout();
            this.kpi1.ResumeLayout(false);
            this.kpi1.PerformLayout();
            this.panelDashHeader.ResumeLayout(false);
            this.panelDashHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Label lblTitlebar;
        private System.Windows.Forms.Panel panelWindowDots;
        private System.Windows.Forms.Label dotClose;
        private System.Windows.Forms.Label dotMax;
        private System.Windows.Forms.Label dotMin;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogoMark;
        private System.Windows.Forms.Label lblLogoTitle;
        private System.Windows.Forms.Label lblLogoSub;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavNasabah;
        private System.Windows.Forms.Button btnNavSampah;
        private System.Windows.Forms.Button btnNavTransaksi;
        private System.Windows.Forms.Button btnNavLaporan;
        private System.Windows.Forms.Button btnNavPengaturan;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelDashboardView;
        private System.Windows.Forms.Panel panelDashHeader;
        private System.Windows.Forms.Label lblDashTitle;
        private System.Windows.Forms.Label lblDashDesc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelKpi;
        private System.Windows.Forms.Panel kpi1;
        private System.Windows.Forms.Label lblKpi1Val;
        private System.Windows.Forms.Label lblKpi1Sub;
        private System.Windows.Forms.Panel kpi2;
        private System.Windows.Forms.Label lblKpi2Val;
        private System.Windows.Forms.Label lblKpi2Sub;
        private System.Windows.Forms.Panel kpi3;
        private System.Windows.Forms.Label lblKpi3Val;
        private System.Windows.Forms.Label lblKpi3Sub;
        private System.Windows.Forms.Panel kpi4;
        private System.Windows.Forms.Label lblKpi4Val;
        private System.Windows.Forms.Label lblKpi4Sub;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGrid;
        private System.Windows.Forms.Panel panelChartBox;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSetoran;
        private System.Windows.Forms.Panel panelRightMedia;
        private System.Windows.Forms.Panel panelVideoBox;
        private System.Windows.Forms.Label lblVideoTitle;
        private System.Windows.Forms.Button btnPlayVideo;
        private System.Windows.Forms.Panel panelBanner;
        private System.Windows.Forms.Label lblBannerText;
        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.Button btnNavPenjemputan;
        private System.Windows.Forms.Panel panelEcoImpact;
        private System.Windows.Forms.Label lblEcoTitle;
        private System.Windows.Forms.Label lblEcoDesc;
        private System.Windows.Forms.Panel panelEcoCo2Box;
        private System.Windows.Forms.Label lblEcoCO2Title;
        private System.Windows.Forms.Label lblEcoCO2Val;
        private System.Windows.Forms.Panel panelEcoTreeBox;
        private System.Windows.Forms.Label lblEcoPohonTitle;
        private System.Windows.Forms.Label lblEcoPohonVal;
        private System.Windows.Forms.Label lblEcoTag;
        private System.Windows.Forms.Label lblEcoEduLink;
        private System.Windows.Forms.Timer timerClock;
    }
}
