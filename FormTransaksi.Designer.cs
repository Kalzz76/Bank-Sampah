using System;
using System.Drawing;
using System.Windows.Forms;

namespace BankSampah
{
    partial class FormTransaksi
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelGridCard = new System.Windows.Forms.Panel();
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            this.panelRiwayatHeader = new System.Windows.Forms.Panel();
            this.lblRiwayatTitle = new System.Windows.Forms.Label();
            this.panelFormCard = new System.Windows.Forms.Panel();
            this.panelAudioBox = new System.Windows.Forms.Panel();
            this.lblAudioInfo = new System.Windows.Forms.Label();
            this.btnPlaySaveAudio = new System.Windows.Forms.Button();
            this.panelCalcBox = new System.Windows.Forms.Panel();
            this.btnSimpanTrx = new System.Windows.Forms.Button();
            this.btnCetakStruk = new System.Windows.Forms.Button();
            this.lblNilaiSetoranVal = new System.Windows.Forms.Label();
            this.lblNilaiSetoranTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanelFields = new System.Windows.Forms.TableLayoutPanel();
            this.panelField4 = new System.Windows.Forms.Panel();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.lblTanggalTitle = new System.Windows.Forms.Label();
            this.panelField3 = new System.Windows.Forms.Panel();
            this.txtBerat = new System.Windows.Forms.TextBox();
            this.lblBeratTitle = new System.Windows.Forms.Label();
            this.panelField2 = new System.Windows.Forms.Panel();
            this.cmbSampah = new System.Windows.Forms.ComboBox();
            this.lblSampahTitle = new System.Windows.Forms.Label();
            this.panelField1 = new System.Windows.Forms.Panel();
            this.cmbNasabah = new System.Windows.Forms.ComboBox();
            this.lblNasabahTitle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
            this.panelRiwayatHeader.SuspendLayout();
            this.panelFormCard.SuspendLayout();
            this.panelAudioBox.SuspendLayout();
            this.panelCalcBox.SuspendLayout();
            this.tableLayoutPanelFields.SuspendLayout();
            this.panelField4.SuspendLayout();
            this.panelField3.SuspendLayout();
            this.panelField2.SuspendLayout();
            this.panelField1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.panelGridCard);
            this.panelMain.Controls.Add(this.panelFormCard);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(900, 680);
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
            this.lblTitle.Size = new System.Drawing.Size(217, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Transaksi Setor Sampah";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblDesc.Location = new System.Drawing.Point(1, 28);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(434, 17);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Mencatat setoran sampah nasabah dan menghitung nilai tabungan otomatis.";
            // 
            // panelFormCard
            // 
            this.panelFormCard.BackColor = System.Drawing.Color.White;
            this.panelFormCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormCard.Controls.Add(this.panelAudioBox);
            this.panelFormCard.Controls.Add(this.panelCalcBox);
            this.panelFormCard.Controls.Add(this.tableLayoutPanelFields);
            this.panelFormCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormCard.Location = new System.Drawing.Point(20, 70);
            this.panelFormCard.Name = "panelFormCard";
            this.panelFormCard.Padding = new System.Windows.Forms.Padding(16);
            this.panelFormCard.Size = new System.Drawing.Size(860, 260);
            this.panelFormCard.TabIndex = 1;
            // 
            // tableLayoutPanelFields
            // 
            this.tableLayoutPanelFields.ColumnCount = 2;
            this.tableLayoutPanelFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFields.Controls.Add(this.panelField4, 1, 1);
            this.tableLayoutPanelFields.Controls.Add(this.panelField3, 0, 1);
            this.tableLayoutPanelFields.Controls.Add(this.panelField2, 1, 0);
            this.tableLayoutPanelFields.Controls.Add(this.panelField1, 0, 0);
            this.tableLayoutPanelFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelFields.Location = new System.Drawing.Point(16, 16);
            this.tableLayoutPanelFields.Name = "tableLayoutPanelFields";
            this.tableLayoutPanelFields.RowCount = 2;
            this.tableLayoutPanelFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFields.Size = new System.Drawing.Size(826, 116);
            this.tableLayoutPanelFields.TabIndex = 0;
            // 
            // panelField1
            // 
            this.panelField1.Controls.Add(this.cmbNasabah);
            this.panelField1.Controls.Add(this.lblNasabahTitle);
            this.panelField1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelField1.Location = new System.Drawing.Point(0, 0);
            this.panelField1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 6);
            this.panelField1.Name = "panelField1";
            this.panelField1.Size = new System.Drawing.Size(403, 52);
            this.panelField1.TabIndex = 0;
            // 
            // lblNasabahTitle
            // 
            this.lblNasabahTitle.AutoSize = true;
            this.lblNasabahTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNasabahTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblNasabahTitle.Location = new System.Drawing.Point(0, 0);
            this.lblNasabahTitle.Name = "lblNasabahTitle";
            this.lblNasabahTitle.Size = new System.Drawing.Size(81, 15);
            this.lblNasabahTitle.TabIndex = 0;
            this.lblNasabahTitle.Text = "Pilih Nasabah";
            // 
            // cmbNasabah
            // 
            this.cmbNasabah.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNasabah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.cmbNasabah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNasabah.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbNasabah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(30)))));
            this.cmbNasabah.FormattingEnabled = true;
            this.cmbNasabah.Location = new System.Drawing.Point(0, 18);
            this.cmbNasabah.Name = "cmbNasabah";
            this.cmbNasabah.Size = new System.Drawing.Size(403, 25);
            this.cmbNasabah.TabIndex = 2;
            this.cmbNasabah.SelectedIndexChanged += new System.EventHandler(this.cmbNasabah_SelectedIndexChanged);
            // 
            // panelField2
            // 
            this.panelField2.Controls.Add(this.cmbSampah);
            this.panelField2.Controls.Add(this.lblSampahTitle);
            this.panelField2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelField2.Location = new System.Drawing.Point(423, 0);
            this.panelField2.Margin = new System.Windows.Forms.Padding(10, 0, 0, 6);
            this.panelField2.Name = "panelField2";
            this.panelField2.Size = new System.Drawing.Size(403, 52);
            this.panelField2.TabIndex = 1;
            // 
            // lblSampahTitle
            // 
            this.lblSampahTitle.AutoSize = true;
            this.lblSampahTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSampahTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblSampahTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSampahTitle.Name = "lblSampahTitle";
            this.lblSampahTitle.Size = new System.Drawing.Size(104, 15);
            this.lblSampahTitle.TabIndex = 0;
            this.lblSampahTitle.Text = "Pilih Jenis Sampah";
            // 
            // cmbSampah
            // 
            this.cmbSampah.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSampah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.cmbSampah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSampah.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbSampah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(30)))));
            this.cmbSampah.FormattingEnabled = true;
            this.cmbSampah.Location = new System.Drawing.Point(0, 18);
            this.cmbSampah.Name = "cmbSampah";
            this.cmbSampah.Size = new System.Drawing.Size(403, 25);
            this.cmbSampah.TabIndex = 2;
            this.cmbSampah.SelectedIndexChanged += new System.EventHandler(this.cmbSampah_SelectedIndexChanged);
            // 
            // panelField3
            // 
            this.panelField3.Controls.Add(this.txtBerat);
            this.panelField3.Controls.Add(this.lblBeratTitle);
            this.panelField3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelField3.Location = new System.Drawing.Point(0, 58);
            this.panelField3.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panelField3.Name = "panelField3";
            this.panelField3.Size = new System.Drawing.Size(403, 58);
            this.panelField3.TabIndex = 2;
            // 
            // lblBeratTitle
            // 
            this.lblBeratTitle.AutoSize = true;
            this.lblBeratTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBeratTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblBeratTitle.Location = new System.Drawing.Point(0, 4);
            this.lblBeratTitle.Name = "lblBeratTitle";
            this.lblBeratTitle.Size = new System.Drawing.Size(61, 15);
            this.lblBeratTitle.TabIndex = 0;
            this.lblBeratTitle.Text = "Berat (kg)";
            // 
            // txtBerat
            // 
            this.txtBerat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBerat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.txtBerat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBerat.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBerat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(30)))));
            this.txtBerat.Location = new System.Drawing.Point(0, 24);
            this.txtBerat.Name = "txtBerat";
            this.txtBerat.Size = new System.Drawing.Size(403, 24);
            this.txtBerat.TabIndex = 2;
            this.txtBerat.Text = "1";
            this.txtBerat.TextChanged += new System.EventHandler(this.txtBerat_TextChanged);
            // 
            // panelField4
            // 
            this.panelField4.Controls.Add(this.dtpTanggal);
            this.panelField4.Controls.Add(this.lblTanggalTitle);
            this.panelField4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelField4.Location = new System.Drawing.Point(423, 58);
            this.panelField4.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelField4.Name = "panelField4";
            this.panelField4.Size = new System.Drawing.Size(403, 58);
            this.panelField4.TabIndex = 3;
            // 
            // lblTanggalTitle
            // 
            this.lblTanggalTitle.AutoSize = true;
            this.lblTanggalTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTanggalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblTanggalTitle.Location = new System.Drawing.Point(0, 4);
            this.lblTanggalTitle.Name = "lblTanggalTitle";
            this.lblTanggalTitle.Size = new System.Drawing.Size(83, 15);
            this.lblTanggalTitle.TabIndex = 0;
            this.lblTanggalTitle.Text = "Tanggal Setor";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTanggal.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(30)))));
            this.dtpTanggal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpTanggal.Location = new System.Drawing.Point(0, 24);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(403, 24);
            this.dtpTanggal.TabIndex = 2;
            // 
            // panelCalcBox
            // 
            this.panelCalcBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.panelCalcBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCalcBox.Controls.Add(this.btnSimpanTrx);
            this.panelCalcBox.Controls.Add(this.btnCetakStruk);
            this.panelCalcBox.Controls.Add(this.lblNilaiSetoranVal);
            this.panelCalcBox.Controls.Add(this.lblNilaiSetoranTitle);
            this.panelCalcBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCalcBox.Location = new System.Drawing.Point(16, 132);
            this.panelCalcBox.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.panelCalcBox.Name = "panelCalcBox";
            this.panelCalcBox.Padding = new System.Windows.Forms.Padding(14);
            this.panelCalcBox.Size = new System.Drawing.Size(826, 56);
            this.panelCalcBox.TabIndex = 1;
            // 
            // lblNilaiSetoranTitle
            // 
            this.lblNilaiSetoranTitle.AutoSize = true;
            this.lblNilaiSetoranTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNilaiSetoranTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblNilaiSetoranTitle.Location = new System.Drawing.Point(14, 8);
            this.lblNilaiSetoranTitle.Name = "lblNilaiSetoranTitle";
            this.lblNilaiSetoranTitle.Size = new System.Drawing.Size(73, 15);
            this.lblNilaiSetoranTitle.TabIndex = 0;
            this.lblNilaiSetoranTitle.Text = "Nilai Setoran";
            // 
            // lblNilaiSetoranVal
            // 
            this.lblNilaiSetoranVal.AutoSize = true;
            this.lblNilaiSetoranVal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblNilaiSetoranVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(122)))), ((int)(((byte)(94)))));
            this.lblNilaiSetoranVal.Location = new System.Drawing.Point(13, 23);
            this.lblNilaiSetoranVal.Name = "lblNilaiSetoranVal";
            this.lblNilaiSetoranVal.Size = new System.Drawing.Size(107, 28);
            this.lblNilaiSetoranVal.TabIndex = 1;
            this.lblNilaiSetoranVal.Text = "Rp 15.750";
            // 
            // btnCetakStruk
            // 
            this.btnCetakStruk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCetakStruk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnCetakStruk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCetakStruk.FlatAppearance.BorderSize = 0;
            this.btnCetakStruk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCetakStruk.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCetakStruk.ForeColor = System.Drawing.Color.White;
            this.btnCetakStruk.Location = new System.Drawing.Point(510, 10);
            this.btnCetakStruk.Name = "btnCetakStruk";
            this.btnCetakStruk.Size = new System.Drawing.Size(150, 34);
            this.btnCetakStruk.TabIndex = 3;
            this.btnCetakStruk.Text = "🧾 Cetak Struk Bukti";
            this.btnCetakStruk.UseVisualStyleBackColor = false;
            this.btnCetakStruk.Click += new System.EventHandler(this.btnCetakStruk_Click);
            // 
            // btnSimpanTrx
            // 
            this.btnSimpanTrx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpanTrx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.btnSimpanTrx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpanTrx.FlatAppearance.BorderSize = 0;
            this.btnSimpanTrx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpanTrx.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSimpanTrx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(26)))), ((int)(((byte)(2)))));
            this.btnSimpanTrx.Location = new System.Drawing.Point(670, 10);
            this.btnSimpanTrx.Name = "btnSimpanTrx";
            this.btnSimpanTrx.Size = new System.Drawing.Size(142, 34);
            this.btnSimpanTrx.TabIndex = 2;
            this.btnSimpanTrx.Text = "Simpan Transaksi";
            this.btnSimpanTrx.UseVisualStyleBackColor = false;
            this.btnSimpanTrx.Click += new System.EventHandler(this.btnSimpanTrx_Click);
            // 
            // panelAudioBox
            // 
            this.panelAudioBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.panelAudioBox.Controls.Add(this.lblAudioInfo);
            this.panelAudioBox.Controls.Add(this.btnPlaySaveAudio);
            this.panelAudioBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAudioBox.Location = new System.Drawing.Point(16, 194);
            this.panelAudioBox.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.panelAudioBox.Name = "panelAudioBox";
            this.panelAudioBox.Padding = new System.Windows.Forms.Padding(10);
            this.panelAudioBox.Size = new System.Drawing.Size(826, 48);
            this.panelAudioBox.TabIndex = 2;
            // 
            // btnPlaySaveAudio
            // 
            this.btnPlaySaveAudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.btnPlaySaveAudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaySaveAudio.FlatAppearance.BorderSize = 0;
            this.btnPlaySaveAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaySaveAudio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPlaySaveAudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(26)))), ((int)(((byte)(2)))));
            this.btnPlaySaveAudio.Location = new System.Drawing.Point(12, 10);
            this.btnPlaySaveAudio.Name = "btnPlaySaveAudio";
            this.btnPlaySaveAudio.Size = new System.Drawing.Size(28, 28);
            this.btnPlaySaveAudio.TabIndex = 0;
            this.btnPlaySaveAudio.Text = "▶";
            this.btnPlaySaveAudio.UseVisualStyleBackColor = false;
            this.btnPlaySaveAudio.Click += new System.EventHandler(this.btnPlaySaveAudio_Click);
            // 
            // lblAudioInfo
            // 
            this.lblAudioInfo.AutoSize = true;
            this.lblAudioInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAudioInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(216)))));
            this.lblAudioInfo.Location = new System.Drawing.Point(48, 16);
            this.lblAudioInfo.Name = "lblAudioInfo";
            this.lblAudioInfo.Size = new System.Drawing.Size(282, 15);
            this.lblAudioInfo.TabIndex = 1;
            this.lblAudioInfo.Text = "Suara \"Berhasil Disimpan\" saat transaksi tersimpan";
            // 
            // panelGridCard
            // 
            this.panelGridCard.BackColor = System.Drawing.Color.White;
            this.panelGridCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGridCard.Controls.Add(this.dgvTransaksi);
            this.panelGridCard.Controls.Add(this.panelRiwayatHeader);
            this.panelGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridCard.Location = new System.Drawing.Point(20, 330);
            this.panelGridCard.Margin = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.panelGridCard.Name = "panelGridCard";
            this.panelGridCard.Padding = new System.Windows.Forms.Padding(1);
            this.panelGridCard.Size = new System.Drawing.Size(860, 330);
            this.panelGridCard.TabIndex = 2;
            // 
            // panelRiwayatHeader
            // 
            this.panelRiwayatHeader.Controls.Add(this.lblRiwayatTitle);
            this.panelRiwayatHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRiwayatHeader.Location = new System.Drawing.Point(1, 1);
            this.panelRiwayatHeader.Name = "panelRiwayatHeader";
            this.panelRiwayatHeader.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.panelRiwayatHeader.Size = new System.Drawing.Size(856, 36);
            this.panelRiwayatHeader.TabIndex = 0;
            // 
            // lblRiwayatTitle
            // 
            this.lblRiwayatTitle.AutoSize = true;
            this.lblRiwayatTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblRiwayatTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblRiwayatTitle.Location = new System.Drawing.Point(10, 8);
            this.lblRiwayatTitle.Name = "lblRiwayatTitle";
            this.lblRiwayatTitle.Size = new System.Drawing.Size(155, 17);
            this.lblRiwayatTitle.TabIndex = 0;
            this.lblRiwayatTitle.Text = "Riwayat Transaksi Setor";
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.AllowUserToAddRows = false;
            this.dgvTransaksi.AllowUserToDeleteRows = false;
            this.dgvTransaksi.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransaksi.Location = new System.Drawing.Point(1, 37);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.ReadOnly = true;
            this.dgvTransaksi.Size = new System.Drawing.Size(856, 290);
            this.dgvTransaksi.TabIndex = 1;
            this.dgvTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaksi_CellClick);
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(900, 680);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTransaksi";
            this.Text = "Transaksi Setor";
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            this.panelMain.ResumeLayout(false);
            this.panelGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            this.panelRiwayatHeader.ResumeLayout(false);
            this.panelRiwayatHeader.PerformLayout();
            this.panelFormCard.ResumeLayout(false);
            this.panelAudioBox.ResumeLayout(false);
            this.panelAudioBox.PerformLayout();
            this.panelCalcBox.ResumeLayout(false);
            this.panelCalcBox.PerformLayout();
            this.tableLayoutPanelFields.ResumeLayout(false);
            this.panelField4.ResumeLayout(false);
            this.panelField4.PerformLayout();
            this.panelField3.ResumeLayout(false);
            this.panelField3.PerformLayout();
            this.panelField2.ResumeLayout(false);
            this.panelField2.PerformLayout();
            this.panelField1.ResumeLayout(false);
            this.panelField1.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Panel panelFormCard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFields;
        private System.Windows.Forms.Panel panelField1;
        private System.Windows.Forms.Label lblNasabahTitle;
        private System.Windows.Forms.ComboBox cmbNasabah;
        private System.Windows.Forms.Panel panelField2;
        private System.Windows.Forms.Label lblSampahTitle;
        private System.Windows.Forms.ComboBox cmbSampah;
        private System.Windows.Forms.Panel panelField3;
        private System.Windows.Forms.Label lblBeratTitle;
        private System.Windows.Forms.TextBox txtBerat;
        private System.Windows.Forms.Panel panelField4;
        private System.Windows.Forms.Label lblTanggalTitle;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Panel panelCalcBox;
        private System.Windows.Forms.Label lblNilaiSetoranTitle;
        private System.Windows.Forms.Label lblNilaiSetoranVal;
        private System.Windows.Forms.Button btnSimpanTrx;
        private System.Windows.Forms.Button btnCetakStruk;
        private System.Windows.Forms.Panel panelAudioBox;
        private System.Windows.Forms.Button btnPlaySaveAudio;
        private System.Windows.Forms.Label lblAudioInfo;
        private System.Windows.Forms.Panel panelGridCard;
        private System.Windows.Forms.Panel panelRiwayatHeader;
        private System.Windows.Forms.Label lblRiwayatTitle;
        private System.Windows.Forms.DataGridView dgvTransaksi;
    }
}
