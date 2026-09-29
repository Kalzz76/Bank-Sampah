using System;
using System.Drawing;
using System.Windows.Forms;

namespace BankSampah
{
    partial class FormSampah
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
            this.dgvSampah = new System.Windows.Forms.DataGridView();
            this.panelFormCard = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.lblTipsSOP = new System.Windows.Forms.Label();
            this.tableLayoutPanelFields = new System.Windows.Forms.TableLayoutPanel();
            this.panelPhotoCol = new System.Windows.Forms.Panel();
            this.btnHapusFoto = new System.Windows.Forms.Button();
            this.btnPilihFoto = new System.Windows.Forms.Button();
            this.picSampah = new System.Windows.Forms.PictureBox();
            this.lblFotoTitle = new System.Windows.Forms.Label();
            this.panelInputsCol = new System.Windows.Forms.Panel();
            this.tableLayoutPanelRow2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelField3 = new System.Windows.Forms.Panel();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.lblHargaTitle = new System.Windows.Forms.Label();
            this.panelField2 = new System.Windows.Forms.Panel();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblKategoriTitle = new System.Windows.Forms.Label();
            this.panelField1 = new System.Windows.Forms.Panel();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblNamaTitle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSampah)).BeginInit();
            this.panelFormCard.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.tableLayoutPanelFields.SuspendLayout();
            this.panelPhotoCol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSampah)).BeginInit();
            this.panelInputsCol.SuspendLayout();
            this.tableLayoutPanelRow2.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(193, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Jenis Sampah & Harga";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblDesc.Location = new System.Drawing.Point(1, 28);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(351, 17);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Menentukan kategori sampah dan harga beli per kilogram.";
            // 
            // panelFormCard
            // 
            this.panelFormCard.BackColor = System.Drawing.Color.White;
            this.panelFormCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormCard.Controls.Add(this.panelButtons);
            this.panelFormCard.Controls.Add(this.tableLayoutPanelFields);
            this.panelFormCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormCard.Location = new System.Drawing.Point(20, 70);
            this.panelFormCard.Name = "panelFormCard";
            this.panelFormCard.Padding = new System.Windows.Forms.Padding(16);
            this.panelFormCard.Size = new System.Drawing.Size(860, 220);
            this.panelFormCard.TabIndex = 1;
            // 
            // tableLayoutPanelFields
            // 
            this.tableLayoutPanelFields.ColumnCount = 2;
            this.tableLayoutPanelFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanelFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFields.Controls.Add(this.panelPhotoCol, 0, 0);
            this.tableLayoutPanelFields.Controls.Add(this.panelInputsCol, 1, 0);
            this.tableLayoutPanelFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelFields.Location = new System.Drawing.Point(16, 16);
            this.tableLayoutPanelFields.Name = "tableLayoutPanelFields";
            this.tableLayoutPanelFields.RowCount = 1;
            this.tableLayoutPanelFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFields.Size = new System.Drawing.Size(826, 146);
            this.tableLayoutPanelFields.TabIndex = 0;
            // 
            // panelPhotoCol
            // 
            this.panelPhotoCol.Controls.Add(this.btnHapusFoto);
            this.panelPhotoCol.Controls.Add(this.btnPilihFoto);
            this.panelPhotoCol.Controls.Add(this.picSampah);
            this.panelPhotoCol.Controls.Add(this.lblFotoTitle);
            this.panelPhotoCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPhotoCol.Location = new System.Drawing.Point(0, 0);
            this.panelPhotoCol.Margin = new System.Windows.Forms.Padding(0);
            this.panelPhotoCol.Name = "panelPhotoCol";
            this.panelPhotoCol.Size = new System.Drawing.Size(110, 146);
            this.panelPhotoCol.TabIndex = 0;
            // 
            // lblFotoTitle
            // 
            this.lblFotoTitle.AutoSize = true;
            this.lblFotoTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFotoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblFotoTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFotoTitle.Name = "lblFotoTitle";
            this.lblFotoTitle.Size = new System.Drawing.Size(76, 15);
            this.lblFotoTitle.TabIndex = 0;
            this.lblFotoTitle.Text = "Foto Sampah";
            // 
            // picSampah
            // 
            this.picSampah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.picSampah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSampah.Location = new System.Drawing.Point(6, 18);
            this.picSampah.Name = "picSampah";
            this.picSampah.Size = new System.Drawing.Size(76, 76);
            this.picSampah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSampah.TabIndex = 2;
            this.picSampah.TabStop = false;
            // 
            // btnPilihFoto
            // 
            this.btnPilihFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.btnPilihFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPilihFoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(194)))));
            this.btnPilihFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPilihFoto.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnPilihFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.btnPilihFoto.Location = new System.Drawing.Point(0, 98);
            this.btnPilihFoto.Name = "btnPilihFoto";
            this.btnPilihFoto.Size = new System.Drawing.Size(88, 23);
            this.btnPilihFoto.TabIndex = 3;
            this.btnPilihFoto.Text = "Pilih / Ganti";
            this.btnPilihFoto.UseVisualStyleBackColor = false;
            this.btnPilihFoto.Click += new System.EventHandler(this.btnPilihFoto_Click);
            // 
            // btnHapusFoto
            // 
            this.btnHapusFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnHapusFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapusFoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnHapusFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapusFoto.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnHapusFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnHapusFoto.Location = new System.Drawing.Point(0, 123);
            this.btnHapusFoto.Name = "btnHapusFoto";
            this.btnHapusFoto.Size = new System.Drawing.Size(88, 23);
            this.btnHapusFoto.TabIndex = 4;
            this.btnHapusFoto.Text = "Hapus Foto";
            this.btnHapusFoto.UseVisualStyleBackColor = false;
            this.btnHapusFoto.Click += new System.EventHandler(this.btnHapusFoto_Click);
            // 
            // panelInputsCol
            // 
            this.panelInputsCol.Controls.Add(this.tableLayoutPanelRow2);
            this.panelInputsCol.Controls.Add(this.panelField1);
            this.panelInputsCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInputsCol.Location = new System.Drawing.Point(120, 0);
            this.panelInputsCol.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelInputsCol.Name = "panelInputsCol";
            this.panelInputsCol.Size = new System.Drawing.Size(706, 146);
            this.panelInputsCol.TabIndex = 1;
            // 
            // panelField1
            // 
            this.panelField1.Controls.Add(this.txtNama);
            this.panelField1.Controls.Add(this.lblNamaTitle);
            this.panelField1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelField1.Location = new System.Drawing.Point(0, 0);
            this.panelField1.Margin = new System.Windows.Forms.Padding(0);
            this.panelField1.Name = "panelField1";
            this.panelField1.Size = new System.Drawing.Size(706, 56);
            this.panelField1.TabIndex = 0;
            // 
            // lblNamaTitle
            // 
            this.lblNamaTitle.AutoSize = true;
            this.lblNamaTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNamaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblNamaTitle.Location = new System.Drawing.Point(0, 0);
            this.lblNamaTitle.Name = "lblNamaTitle";
            this.lblNamaTitle.Size = new System.Drawing.Size(117, 15);
            this.lblNamaTitle.TabIndex = 0;
            this.lblNamaTitle.Text = "Nama Jenis Sampah";
            // 
            // txtNama
            // 
            this.txtNama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(30)))));
            this.txtNama.Location = new System.Drawing.Point(0, 20);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(706, 24);
            this.txtNama.TabIndex = 1;
            // 
            // tableLayoutPanelRow2
            // 
            this.tableLayoutPanelRow2.ColumnCount = 2;
            this.tableLayoutPanelRow2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRow2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRow2.Controls.Add(this.panelField2, 0, 0);
            this.tableLayoutPanelRow2.Controls.Add(this.panelField3, 1, 0);
            this.tableLayoutPanelRow2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelRow2.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanelRow2.Name = "tableLayoutPanelRow2";
            this.tableLayoutPanelRow2.RowCount = 1;
            this.tableLayoutPanelRow2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRow2.Size = new System.Drawing.Size(706, 56);
            this.tableLayoutPanelRow2.TabIndex = 1;
            // 
            // panelField2
            // 
            this.panelField2.Controls.Add(this.cmbKategori);
            this.panelField2.Controls.Add(this.lblKategoriTitle);
            this.panelField2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelField2.Location = new System.Drawing.Point(0, 0);
            this.panelField2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panelField2.Name = "panelField2";
            this.panelField2.Size = new System.Drawing.Size(343, 56);
            this.panelField2.TabIndex = 0;
            // 
            // lblKategoriTitle
            // 
            this.lblKategoriTitle.AutoSize = true;
            this.lblKategoriTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKategoriTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblKategoriTitle.Location = new System.Drawing.Point(0, 0);
            this.lblKategoriTitle.Name = "lblKategoriTitle";
            this.lblKategoriTitle.Size = new System.Drawing.Size(55, 15);
            this.lblKategoriTitle.TabIndex = 0;
            this.lblKategoriTitle.Text = "Kategori";
            // 
            // cmbKategori
            // 
            this.cmbKategori.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(30)))));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Plastik",
            "Kertas",
            "Logam",
            "Kaca",
            "Minyak Jelantah",
            "Organik",
            "B3 (Berbahaya)"});
            this.cmbKategori.Location = new System.Drawing.Point(0, 20);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(343, 25);
            this.cmbKategori.TabIndex = 1;
            // 
            // panelField3
            // 
            this.panelField3.Controls.Add(this.txtHarga);
            this.panelField3.Controls.Add(this.lblHargaTitle);
            this.panelField3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelField3.Location = new System.Drawing.Point(353, 0);
            this.panelField3.Margin = new System.Windows.Forms.Padding(0);
            this.panelField3.Name = "panelField3";
            this.panelField3.Size = new System.Drawing.Size(353, 56);
            this.panelField3.TabIndex = 1;
            // 
            // lblHargaTitle
            // 
            this.lblHargaTitle.AutoSize = true;
            this.lblHargaTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHargaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblHargaTitle.Location = new System.Drawing.Point(0, 0);
            this.lblHargaTitle.Name = "lblHargaTitle";
            this.lblHargaTitle.Size = new System.Drawing.Size(107, 15);
            this.lblHargaTitle.TabIndex = 0;
            this.lblHargaTitle.Text = "Harga per Kg (Rp)";
            // 
            // txtHarga
            // 
            this.txtHarga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHarga.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtHarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(30)))));
            this.txtHarga.Location = new System.Drawing.Point(0, 20);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(353, 24);
            this.txtHarga.TabIndex = 1;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnSimpan);
            this.panelButtons.Controls.Add(this.btnUbah);
            this.panelButtons.Controls.Add(this.btnHapus);
            this.panelButtons.Controls.Add(this.btnBatal);
            this.panelButtons.Controls.Add(this.lblTipsSOP);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(16, 170);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(826, 32);
            this.panelButtons.TabIndex = 1;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(122)))), ((int)(((byte)(94)))));
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(0, 0);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(90, 32);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "Tambah";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbah.FlatAppearance.BorderSize = 0;
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUbah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(26)))), ((int)(((byte)(2)))));
            this.btnUbah.Location = new System.Drawing.Point(98, 0);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(90, 32);
            this.btnUbah.TabIndex = 1;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(217)))));
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHapus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(70)))), ((int)(((byte)(50)))));
            this.btnHapus.Location = new System.Drawing.Point(196, 0);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(90, 32);
            this.btnHapus.TabIndex = 2;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.Transparent;
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(194)))));
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBatal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.btnBatal.Location = new System.Drawing.Point(294, 0);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(120, 32);
            this.btnBatal.TabIndex = 3;
            this.btnBatal.Text = "Bersihkan Form";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // lblTipsSOP
            // 
            this.lblTipsSOP.AutoSize = true;
            this.lblTipsSOP.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblTipsSOP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(122)))), ((int)(((byte)(94)))));
            this.lblTipsSOP.Location = new System.Drawing.Point(426, 8);
            this.lblTipsSOP.Margin = new System.Windows.Forms.Padding(4, 8, 0, 0);
            this.lblTipsSOP.Name = "lblTipsSOP";
            this.lblTipsSOP.Size = new System.Drawing.Size(390, 13);
            this.lblTipsSOP.TabIndex = 4;
            this.lblTipsSOP.Text = "💡 Standar Pemilahan: Pisahkan botol PET, lipat kardus, & saring minyak jelantah.";
            // 
            // panelGridCard
            // 
            this.panelGridCard.BackColor = System.Drawing.Color.White;
            this.panelGridCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGridCard.Controls.Add(this.dgvSampah);
            this.panelGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridCard.Location = new System.Drawing.Point(20, 290);
            this.panelGridCard.Margin = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.panelGridCard.Name = "panelGridCard";
            this.panelGridCard.Padding = new System.Windows.Forms.Padding(1);
            this.panelGridCard.Size = new System.Drawing.Size(860, 340);
            this.panelGridCard.TabIndex = 2;
            // 
            // dgvSampah
            // 
            this.dgvSampah.AllowUserToAddRows = false;
            this.dgvSampah.AllowUserToDeleteRows = false;
            this.dgvSampah.BackgroundColor = System.Drawing.Color.White;
            this.dgvSampah.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSampah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSampah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSampah.Location = new System.Drawing.Point(1, 1);
            this.dgvSampah.Name = "dgvSampah";
            this.dgvSampah.ReadOnly = true;
            this.dgvSampah.Size = new System.Drawing.Size(856, 336);
            this.dgvSampah.TabIndex = 0;
            this.dgvSampah.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSampah_CellClick);
            // 
            // FormSampah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSampah";
            this.Text = "Jenis Sampah";
            this.Load += new System.EventHandler(this.FormSampah_Load);
            this.panelMain.ResumeLayout(false);
            this.panelGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSampah)).EndInit();
            this.panelFormCard.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.tableLayoutPanelFields.ResumeLayout(false);
            this.panelPhotoCol.ResumeLayout(false);
            this.panelPhotoCol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSampah)).EndInit();
            this.panelInputsCol.ResumeLayout(false);
            this.tableLayoutPanelRow2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelPhotoCol;
        private System.Windows.Forms.Label lblFotoTitle;
        private System.Windows.Forms.PictureBox picSampah;
        private System.Windows.Forms.Button btnPilihFoto;
        private System.Windows.Forms.Button btnHapusFoto;
        private System.Windows.Forms.Panel panelInputsCol;
        private System.Windows.Forms.Panel panelField1;
        private System.Windows.Forms.Label lblNamaTitle;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRow2;
        private System.Windows.Forms.Panel panelField2;
        private System.Windows.Forms.Label lblKategoriTitle;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Panel panelField3;
        private System.Windows.Forms.Label lblHargaTitle;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label lblTipsSOP;
        private System.Windows.Forms.Panel panelGridCard;
        private System.Windows.Forms.DataGridView dgvSampah;
    }
}
