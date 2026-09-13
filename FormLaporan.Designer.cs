using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BankSampah
{
    partial class FormLaporan
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
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            ChartArea chartArea2 = new ChartArea();
            Series series2 = new Series();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanelCharts = new System.Windows.Forms.TableLayoutPanel();
            this.panelColRight = new System.Windows.Forms.Panel();
            this.chartTren = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelButtonsExport = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCetak = new System.Windows.Forms.Button();
            this.btnEkspor = new System.Windows.Forms.Button();
            this.lblTrenTitle = new System.Windows.Forms.Label();
            this.panelColLeft = new System.Windows.Forms.Panel();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblPieTitle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelLeaderboard = new System.Windows.Forms.Panel();
            this.lblLeaderboardTitle = new System.Windows.Forms.Label();
            this.panelEcoBanner = new System.Windows.Forms.Panel();
            this.lblEcoHeader = new System.Windows.Forms.Label();
            this.tableLayoutEco = new System.Windows.Forms.TableLayoutPanel();
            this.lblEcoMetric1 = new System.Windows.Forms.Label();
            this.lblEcoMetric2 = new System.Windows.Forms.Label();
            this.lblEcoMetric3 = new System.Windows.Forms.Label();
            this.lblEcoMetric4 = new System.Windows.Forms.Label();
            this.lblLeaderboardSub = new System.Windows.Forms.Label();
            this.dgvLeaderboard = new System.Windows.Forms.DataGridView();
            this.panelMain.SuspendLayout();
            this.panelEcoBanner.SuspendLayout();
            this.tableLayoutEco.SuspendLayout();
            this.tableLayoutPanelCharts.SuspendLayout();
            this.panelColRight.SuspendLayout();
            this.panelButtonsExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTren)).BeginInit();
            this.panelColLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelLeaderboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.panelLeaderboard);
            this.panelMain.Controls.Add(this.tableLayoutPanelCharts);
            this.panelMain.Controls.Add(this.panelEcoBanner);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(900, 650);
            this.panelMain.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblDesc);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(20, 20);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(860, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Laporan & Grafik";
            this.lblTitle.UseMnemonic = false;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblDesc.Location = new System.Drawing.Point(1, 28);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(469, 17);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Ringkasan visual komposisi sampah dan tren setoran untuk evaluasi bank sampah.";
            // 
            // tableLayoutPanelCharts
            // 
            this.tableLayoutPanelCharts.ColumnCount = 2;
            this.tableLayoutPanelCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCharts.Controls.Add(this.panelColRight, 1, 0);
            this.tableLayoutPanelCharts.Controls.Add(this.panelColLeft, 0, 0);
            this.tableLayoutPanelCharts.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelCharts.Location = new System.Drawing.Point(20, 70);
            this.tableLayoutPanelCharts.Name = "tableLayoutPanelCharts";
            this.tableLayoutPanelCharts.RowCount = 1;
            this.tableLayoutPanelCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCharts.Size = new System.Drawing.Size(860, 360);
            this.tableLayoutPanelCharts.TabIndex = 1;
            // 
            // panelEcoBanner
            // 
            this.panelEcoBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.panelEcoBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEcoBanner.Controls.Add(this.tableLayoutEco);
            this.panelEcoBanner.Controls.Add(this.lblEcoHeader);
            this.panelEcoBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEcoBanner.Location = new System.Drawing.Point(20, 70);
            this.panelEcoBanner.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelEcoBanner.Name = "panelEcoBanner";
            this.panelEcoBanner.Padding = new System.Windows.Forms.Padding(10, 6, 10, 8);
            this.panelEcoBanner.Size = new System.Drawing.Size(860, 84);
            this.panelEcoBanner.TabIndex = 3;
            // 
            // lblEcoHeader
            // 
            this.lblEcoHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEcoHeader.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEcoHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblEcoHeader.Location = new System.Drawing.Point(10, 6);
            this.lblEcoHeader.Name = "lblEcoHeader";
            this.lblEcoHeader.Size = new System.Drawing.Size(838, 18);
            this.lblEcoHeader.TabIndex = 0;
            this.lblEcoHeader.Text = "🌱 INDIKATOR DAMPAK LINGKUNGAN & EKONOMI SIRKULAR (ECO-METRICS)";
            // 
            // tableLayoutEco
            // 
            this.tableLayoutEco.ColumnCount = 4;
            this.tableLayoutEco.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutEco.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutEco.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutEco.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutEco.Controls.Add(this.lblEcoMetric1, 0, 0);
            this.tableLayoutEco.Controls.Add(this.lblEcoMetric2, 1, 0);
            this.tableLayoutEco.Controls.Add(this.lblEcoMetric3, 2, 0);
            this.tableLayoutEco.Controls.Add(this.lblEcoMetric4, 3, 0);
            this.tableLayoutEco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutEco.Location = new System.Drawing.Point(10, 24);
            this.tableLayoutEco.Name = "tableLayoutEco";
            this.tableLayoutEco.RowCount = 1;
            this.tableLayoutEco.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutEco.Size = new System.Drawing.Size(838, 52);
            this.tableLayoutEco.TabIndex = 1;
            // 
            // lblEcoMetric1
            // 
            this.lblEcoMetric1.BackColor = System.Drawing.Color.White;
            this.lblEcoMetric1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEcoMetric1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEcoMetric1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEcoMetric1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblEcoMetric1.Location = new System.Drawing.Point(3, 2);
            this.lblEcoMetric1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblEcoMetric1.Name = "lblEcoMetric1";
            this.lblEcoMetric1.Size = new System.Drawing.Size(203, 48);
            this.lblEcoMetric1.TabIndex = 0;
            this.lblEcoMetric1.Text = "♻️ 0 kg\r\nSampah Terkelola";
            this.lblEcoMetric1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEcoMetric2
            // 
            this.lblEcoMetric2.BackColor = System.Drawing.Color.White;
            this.lblEcoMetric2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEcoMetric2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEcoMetric2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEcoMetric2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblEcoMetric2.Location = new System.Drawing.Point(212, 2);
            this.lblEcoMetric2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblEcoMetric2.Name = "lblEcoMetric2";
            this.lblEcoMetric2.Size = new System.Drawing.Size(203, 48);
            this.lblEcoMetric2.TabIndex = 1;
            this.lblEcoMetric2.Text = "💨 0 kg CO₂e\r\nReduksi Emisi";
            this.lblEcoMetric2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEcoMetric3
            // 
            this.lblEcoMetric3.BackColor = System.Drawing.Color.White;
            this.lblEcoMetric3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEcoMetric3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEcoMetric3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEcoMetric3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblEcoMetric3.Location = new System.Drawing.Point(421, 2);
            this.lblEcoMetric3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblEcoMetric3.Name = "lblEcoMetric3";
            this.lblEcoMetric3.Size = new System.Drawing.Size(203, 48);
            this.lblEcoMetric3.TabIndex = 2;
            this.lblEcoMetric3.Text = "🌳 0 Batang\r\nPohon Selamat";
            this.lblEcoMetric3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEcoMetric4
            // 
            this.lblEcoMetric4.BackColor = System.Drawing.Color.White;
            this.lblEcoMetric4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEcoMetric4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEcoMetric4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEcoMetric4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblEcoMetric4.Location = new System.Drawing.Point(630, 2);
            this.lblEcoMetric4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblEcoMetric4.Name = "lblEcoMetric4";
            this.lblEcoMetric4.Size = new System.Drawing.Size(205, 48);
            this.lblEcoMetric4.TabIndex = 3;
            this.lblEcoMetric4.Text = "⭐ 100% Sirkular\r\nZero Waste Target";
            this.lblEcoMetric4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLeaderboard
            // 
            this.panelLeaderboard.BackColor = System.Drawing.Color.White;
            this.panelLeaderboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeaderboard.Controls.Add(this.dgvLeaderboard);
            this.panelLeaderboard.Controls.Add(this.lblLeaderboardSub);
            this.panelLeaderboard.Controls.Add(this.lblLeaderboardTitle);
            this.panelLeaderboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeaderboard.Location = new System.Drawing.Point(20, 440);
            this.panelLeaderboard.Margin = new System.Windows.Forms.Padding(0, 10, 0, 20);
            this.panelLeaderboard.Name = "panelLeaderboard";
            this.panelLeaderboard.Padding = new System.Windows.Forms.Padding(16);
            this.panelLeaderboard.Size = new System.Drawing.Size(860, 240);
            this.panelLeaderboard.TabIndex = 2;
            // 
            // lblLeaderboardTitle
            // 
            this.lblLeaderboardTitle.AutoSize = true;
            this.lblLeaderboardTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLeaderboardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblLeaderboardTitle.Location = new System.Drawing.Point(16, 14);
            this.lblLeaderboardTitle.Name = "lblLeaderboardTitle";
            this.lblLeaderboardTitle.Size = new System.Drawing.Size(262, 20);
            this.lblLeaderboardTitle.TabIndex = 0;
            this.lblLeaderboardTitle.Text = "🏆 Top 5 Nasabah Teraktif (Bulan Ini)";
            // 
            // lblLeaderboardSub
            // 
            this.lblLeaderboardSub.AutoSize = true;
            this.lblLeaderboardSub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLeaderboardSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblLeaderboardSub.Location = new System.Drawing.Point(17, 36);
            this.lblLeaderboardSub.Name = "lblLeaderboardSub";
            this.lblLeaderboardSub.Size = new System.Drawing.Size(434, 15);
            this.lblLeaderboardSub.TabIndex = 1;
            this.lblLeaderboardSub.Text = "Peringkat partisipasi nasabah berdasarkan akumulasi kilogram sampah yang disetorkan";
            // 
            // dgvLeaderboard
            // 
            this.dgvLeaderboard.AllowUserToAddRows = false;
            this.dgvLeaderboard.AllowUserToDeleteRows = false;
            this.dgvLeaderboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLeaderboard.BackgroundColor = System.Drawing.Color.White;
            this.dgvLeaderboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaderboard.Location = new System.Drawing.Point(16, 58);
            this.dgvLeaderboard.Name = "dgvLeaderboard";
            this.dgvLeaderboard.ReadOnly = true;
            this.dgvLeaderboard.Size = new System.Drawing.Size(826, 164);
            this.dgvLeaderboard.TabIndex = 2;
            // 
            // panelColLeft
            // 
            this.panelColLeft.BackColor = System.Drawing.Color.White;
            this.panelColLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColLeft.Controls.Add(this.chartPie);
            this.panelColLeft.Controls.Add(this.lblPieTitle);
            this.panelColLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelColLeft.Location = new System.Drawing.Point(3, 3);
            this.panelColLeft.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panelColLeft.Name = "panelColLeft";
            this.panelColLeft.Padding = new System.Windows.Forms.Padding(16);
            this.panelColLeft.Size = new System.Drawing.Size(417, 554);
            this.panelColLeft.TabIndex = 0;
            // 
            // lblPieTitle
            // 
            this.lblPieTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPieTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPieTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblPieTitle.Location = new System.Drawing.Point(16, 16);
            this.lblPieTitle.Name = "lblPieTitle";
            this.lblPieTitle.Size = new System.Drawing.Size(383, 30);
            this.lblPieTitle.TabIndex = 0;
            this.lblPieTitle.Text = "Komposisi Jenis Sampah";
            // 
            // chartPie
            // 
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartAreaPie";
            this.chartPie.ChartAreas.Add(chartArea1);
            this.chartPie.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Segoe UI", 9F);
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            legend1.Name = "Legend1";
            this.chartPie.Legends.Add(legend1);
            this.chartPie.Location = new System.Drawing.Point(16, 46);
            this.chartPie.Name = "chartPie";
            series1.ChartArea = "ChartAreaPie";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            series1.Legend = "Legend1";
            series1.Name = "Komposisi";
            this.chartPie.Series.Add(series1);
            this.chartPie.Size = new System.Drawing.Size(383, 490);
            this.chartPie.TabIndex = 1;
            // 
            // panelColRight
            // 
            this.panelColRight.BackColor = System.Drawing.Color.White;
            this.panelColRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColRight.Controls.Add(this.chartTren);
            this.panelColRight.Controls.Add(this.panelButtonsExport);
            this.panelColRight.Controls.Add(this.lblTrenTitle);
            this.panelColRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelColRight.Location = new System.Drawing.Point(440, 3);
            this.panelColRight.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.panelColRight.Name = "panelColRight";
            this.panelColRight.Padding = new System.Windows.Forms.Padding(16);
            this.panelColRight.Size = new System.Drawing.Size(417, 554);
            this.panelColRight.TabIndex = 1;
            // 
            // lblTrenTitle
            // 
            this.lblTrenTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrenTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTrenTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblTrenTitle.Location = new System.Drawing.Point(16, 16);
            this.lblTrenTitle.Name = "lblTrenTitle";
            this.lblTrenTitle.Size = new System.Drawing.Size(383, 30);
            this.lblTrenTitle.TabIndex = 0;
            this.lblTrenTitle.Text = "Tren Setoran 6 Bulan";
            // 
            // panelButtonsExport
            // 
            this.panelButtonsExport.Controls.Add(this.btnCetak);
            this.panelButtonsExport.Controls.Add(this.btnEkspor);
            this.panelButtonsExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtonsExport.Location = new System.Drawing.Point(16, 496);
            this.panelButtonsExport.Name = "panelButtonsExport";
            this.panelButtonsExport.Size = new System.Drawing.Size(383, 40);
            this.panelButtonsExport.TabIndex = 2;
            // 
            // btnCetak
            // 
            this.btnCetak.BackColor = System.Drawing.Color.Transparent;
            this.btnCetak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCetak.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(194)))));
            this.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCetak.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCetak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.btnCetak.Location = new System.Drawing.Point(0, 0);
            this.btnCetak.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(120, 34);
            this.btnCetak.TabIndex = 0;
            this.btnCetak.Text = "Cetak Laporan";
            this.btnCetak.UseVisualStyleBackColor = false;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // btnEkspor
            // 
            this.btnEkspor.BackColor = System.Drawing.Color.Transparent;
            this.btnEkspor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkspor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(194)))));
            this.btnEkspor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkspor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEkspor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.btnEkspor.Location = new System.Drawing.Point(128, 0);
            this.btnEkspor.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnEkspor.Name = "btnEkspor";
            this.btnEkspor.Size = new System.Drawing.Size(120, 34);
            this.btnEkspor.TabIndex = 1;
            this.btnEkspor.Text = "Ekspor Excel";
            this.btnEkspor.UseVisualStyleBackColor = false;
            this.btnEkspor.Click += new System.EventHandler(this.btnEkspor_Click);
            // 
            // chartTren
            // 
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(194)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            chartArea2.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartAreaTren";
            this.chartTren.ChartAreas.Add(chartArea2);
            this.chartTren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTren.Location = new System.Drawing.Point(16, 46);
            this.chartTren.Name = "chartTren";
            series2.ChartArea = "ChartAreaTren";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            series2.CustomProperties = "PointWidth=0.6";
            series2.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            series2.Name = "Tren";
            this.chartTren.Series.Add(series2);
            this.chartTren.Size = new System.Drawing.Size(383, 450);
            this.chartTren.TabIndex = 1;
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLaporan";
            this.Text = "Laporan & Grafik";
            this.Load += new System.EventHandler(this.FormLaporan_Load);
            this.panelMain.ResumeLayout(false);
            this.tableLayoutPanelCharts.ResumeLayout(false);
            this.panelColRight.ResumeLayout(false);
            this.panelButtonsExport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTren)).EndInit();
            this.panelColLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelEcoBanner.ResumeLayout(false);
            this.tableLayoutEco.ResumeLayout(false);
            this.panelLeaderboard.ResumeLayout(false);
            this.panelLeaderboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Panel panelEcoBanner;
        private System.Windows.Forms.Label lblEcoHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutEco;
        private System.Windows.Forms.Label lblEcoMetric1;
        private System.Windows.Forms.Label lblEcoMetric2;
        private System.Windows.Forms.Label lblEcoMetric3;
        private System.Windows.Forms.Label lblEcoMetric4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCharts;
        private System.Windows.Forms.Panel panelColLeft;
        private System.Windows.Forms.Label lblPieTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private System.Windows.Forms.Panel panelColRight;
        private System.Windows.Forms.Label lblTrenTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTren;
        private System.Windows.Forms.FlowLayoutPanel panelButtonsExport;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Button btnEkspor;
        private System.Windows.Forms.Panel panelLeaderboard;
        private System.Windows.Forms.Label lblLeaderboardTitle;
        private System.Windows.Forms.Label lblLeaderboardSub;
        private System.Windows.Forms.DataGridView dgvLeaderboard;
    }
}
