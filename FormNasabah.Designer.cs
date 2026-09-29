using System;
using System.Drawing;
using System.Windows.Forms;

namespace BankSampah
{
    partial class FormNasabah
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
            this.dgvNasabah = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.lblCariTitle = new System.Windows.Forms.Label();
            this.panelFormCard = new System.Windows.Forms.Panel();
            this.tableLayoutPanelFields = new System.Windows.Forms.TableLayoutPanel();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnRiwayat = new System.Windows.Forms.Button();
            this.panelPhotoCol = new System.Windows.Forms.Panel();
            this.btnHapusFoto = new System.Windows.Forms.Button();
            this.btnPilihFoto = new System.Windows.Forms.Button();
            this.picNasabah = new System.Windows.Forms.PictureBox();
            this.lblFotoTitle = new System.Windows.Forms.Label();
            this.panelInputsCol = new System.Windows.Forms.Panel();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lblAlamatTitle = new System.Windows.Forms.Label();
            this.txtNoHp = new System.Windows.Forms.TextBox();
            this.lblNoHpTitle = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblNamaTitle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNasabah)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.panelFormCard.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.tableLayoutPanelFields.SuspendLayout();
            this.panelPhotoCol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNasabah)).BeginInit();
            this.panelInputsCol.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.panelGridCard);
            this.panelMain.Controls.Add(this.panelSearch);
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
            this.lblTitle.Size = new System.Drawing.Size(134, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Data Nasabah";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblDesc.Location = new System.Drawing.Point(1, 28);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(325, 17);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Kelola data warga yang menjadi nasabah bank sampah.";
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
            this.panelFormCard.Size = new System.Drawing.Size(860, 246);
            this.panelFormCard.TabIndex = 1;
            // 
            // tableLayoutPanelFields
            // 
            this.tableLayoutPanelFields.ColumnCount = 2;
            this.tableLayoutPanelFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFields.Controls.Add(this.panelPhotoCol, 0, 0);
            this.tableLayoutPanelFields.Controls.Add(this.panelInputsCol, 1, 0);
            this.tableLayoutPanelFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelFields.Location = new System.Drawing.Point(16, 16);
            this.tableLayoutPanelFields.Name = "tableLayoutPanelFields";
            this.tableLayoutPanelFields.RowCount = 1;
            this.tableLayoutPanelFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFields.Size = new System.Drawing.Size(826, 170);
            this.tableLayoutPanelFields.TabIndex = 0;
            // 
            // panelPhotoCol
            // 
            this.panelPhotoCol.Controls.Add(this.btnHapusFoto);
            this.panelPhotoCol.Controls.Add(this.btnPilihFoto);
            this.panelPhotoCol.Controls.Add(this.picNasabah);
            this.panelPhotoCol.Controls.Add(this.lblFotoTitle);
            this.panelPhotoCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPhotoCol.Location = new System.Drawing.Point(0, 0);
            this.panelPhotoCol.Margin = new System.Windows.Forms.Padding(0);
            this.panelPhotoCol.Name = "panelPhotoCol";
            this.panelPhotoCol.Size = new System.Drawing.Size(120, 170);
            this.panelPhotoCol.TabIndex = 0;
            // 
            // lblFotoTitle
            // 
            this.lblFotoTitle.AutoSize = true;
            this.lblFotoTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFotoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblFotoTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFotoTitle.Name = "lblFotoTitle";
            this.lblFotoTitle.Size = new System.Drawing.Size(80, 15);
            this.lblFotoTitle.TabIndex = 0;
            this.lblFotoTitle.Text = "Foto Nasabah";
            // 
            // picNasabah
            // 
            this.picNasabah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.picNasabah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNasabah.Location = new System.Drawing.Point(8, 18);
            this.picNasabah.Name = "picNasabah";
            this.picNasabah.Size = new System.Drawing.Size(86, 86);
            this.picNasabah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNasabah.TabIndex = 2;
            this.picNasabah.TabStop = false;
            // 
            // btnPilihFoto
            // 
            this.btnPilihFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.btnPilihFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPilihFoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(194)))));
            this.btnPilihFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPilihFoto.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnPilihFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.btnPilihFoto.Location = new System.Drawing.Point(3, 110);
            this.btnPilihFoto.Name = "btnPilihFoto";
            this.btnPilihFoto.Size = new System.Drawing.Size(96, 24);
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
            this.btnHapusFoto.Location = new System.Drawing.Point(3, 138);
            this.btnHapusFoto.Name = "btnHapusFoto";
            this.btnHapusFoto.Size = new System.Drawing.Size(96, 24);
            this.btnHapusFoto.TabIndex = 4;
            this.btnHapusFoto.Text = "Hapus Foto";
            this.btnHapusFoto.UseVisualStyleBackColor = false;
            this.btnHapusFoto.Click += new System.EventHandler(this.btnHapusFoto_Click);
            // 
            // panelInputsCol
            // 
            this.panelInputsCol.Controls.Add(this.txtAlamat);
            this.panelInputsCol.Controls.Add(this.lblAlamatTitle);
            this.panelInputsCol.Controls.Add(this.txtNoHp);
            this.panelInputsCol.Controls.Add(this.lblNoHpTitle);
            this.panelInputsCol.Controls.Add(this.txtNama);
            this.panelInputsCol.Controls.Add(this.lblNamaTitle);
            this.panelInputsCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInputsCol.Location = new System.Drawing.Point(130, 0);
            this.panelInputsCol.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelInputsCol.Name = "panelInputsCol";
            this.panelInputsCol.Size = new System.Drawing.Size(696, 170);
            this.panelInputsCol.TabIndex = 1;
            // 
            // lblNamaTitle
            // 
            this.lblNamaTitle.AutoSize = true;
            this.lblNamaTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNamaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblNamaTitle.Location = new System.Drawing.Point(0, 0);
            this.lblNamaTitle.Name = "lblNamaTitle";
            this.lblNamaTitle.Size = new System.Drawing.Size(89, 15);
            this.lblNamaTitle.TabIndex = 0;
            this.lblNamaTitle.Text = "Nama Lengkap";
            // 
            // txtNama
            // 
            this.txtNama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(30)))));
            this.txtNama.Location = new System.Drawing.Point(0, 18);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(696, 24);
            this.txtNama.TabIndex = 2;
            // 
            // lblNoHpTitle
            // 
            this.lblNoHpTitle.AutoSize = true;
            this.lblNoHpTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNoHpTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblNoHpTitle.Location = new System.Drawing.Point(0, 48);
            this.lblNoHpTitle.Name = "lblNoHpTitle";
            this.lblNoHpTitle.Size = new System.Drawing.Size(45, 15);
            this.lblNoHpTitle.TabIndex = 3;
            this.lblNoHpTitle.Text = "No. HP";
            // 
            // txtNoHp
            // 
            this.txtNoHp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoHp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.txtNoHp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoHp.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNoHp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(30)))));
            this.txtNoHp.Location = new System.Drawing.Point(0, 66);
            this.txtNoHp.Name = "txtNoHp";
            this.txtNoHp.Size = new System.Drawing.Size(696, 24);
            this.txtNoHp.TabIndex = 5;
            // 
            // lblAlamatTitle
            // 
            this.lblAlamatTitle.AutoSize = true;
            this.lblAlamatTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAlamatTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblAlamatTitle.Location = new System.Drawing.Point(0, 96);
            this.lblAlamatTitle.Name = "lblAlamatTitle";
            this.lblAlamatTitle.Size = new System.Drawing.Size(46, 15);
            this.lblAlamatTitle.TabIndex = 6;
            this.lblAlamatTitle.Text = "Alamat";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlamat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlamat.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtAlamat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(30)))));
            this.txtAlamat.Location = new System.Drawing.Point(0, 114);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(696, 46);
            this.txtAlamat.TabIndex = 8;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnSimpan);
            this.panelButtons.Controls.Add(this.btnUbah);
            this.panelButtons.Controls.Add(this.btnHapus);
            this.panelButtons.Controls.Add(this.btnBatal);
            this.panelButtons.Controls.Add(this.btnRiwayat);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(16, 192);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(826, 36);
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
            // btnRiwayat
            // 
            this.btnRiwayat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnRiwayat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRiwayat.FlatAppearance.BorderSize = 0;
            this.btnRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiwayat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRiwayat.ForeColor = System.Drawing.Color.White;
            this.btnRiwayat.Location = new System.Drawing.Point(422, 0);
            this.btnRiwayat.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Size = new System.Drawing.Size(155, 32);
            this.btnRiwayat.TabIndex = 4;
            this.btnRiwayat.Text = "📜 Riwayat Transaksi";
            this.btnRiwayat.UseVisualStyleBackColor = false;
            this.btnRiwayat.Click += new System.EventHandler(this.btnRiwayat_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.txtCari);
            this.panelSearch.Controls.Add(this.lblCariTitle);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(20, 316);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Padding = new System.Windows.Forms.Padding(0, 10, 0, 8);
            this.panelSearch.Size = new System.Drawing.Size(860, 64);
            this.panelSearch.TabIndex = 2;
            // 
            // lblCariTitle
            // 
            this.lblCariTitle.AutoSize = true;
            this.lblCariTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCariTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblCariTitle.Location = new System.Drawing.Point(1, 8);
            this.lblCariTitle.Name = "lblCariTitle";
            this.lblCariTitle.Size = new System.Drawing.Size(155, 15);
            this.lblCariTitle.TabIndex = 0;
            this.lblCariTitle.Text = "Cari Nasabah (Nama / HP)";
            // 
            // txtCari
            // 
            this.txtCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(30)))));
            this.txtCari.Location = new System.Drawing.Point(0, 28);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(320, 24);
            this.txtCari.TabIndex = 2;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // panelGridCard
            // 
            this.panelGridCard.BackColor = System.Drawing.Color.White;
            this.panelGridCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGridCard.Controls.Add(this.dgvNasabah);
            this.panelGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridCard.Location = new System.Drawing.Point(20, 380);
            this.panelGridCard.Name = "panelGridCard";
            this.panelGridCard.Padding = new System.Windows.Forms.Padding(1);
            this.panelGridCard.Size = new System.Drawing.Size(860, 250);
            this.panelGridCard.TabIndex = 3;
            // 
            // dgvNasabah
            // 
            this.dgvNasabah.AllowUserToAddRows = false;
            this.dgvNasabah.AllowUserToDeleteRows = false;
            this.dgvNasabah.BackgroundColor = System.Drawing.Color.White;
            this.dgvNasabah.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNasabah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNasabah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNasabah.Location = new System.Drawing.Point(1, 1);
            this.dgvNasabah.Name = "dgvNasabah";
            this.dgvNasabah.ReadOnly = true;
            this.dgvNasabah.Size = new System.Drawing.Size(856, 246);
            this.dgvNasabah.TabIndex = 0;
            this.dgvNasabah.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNasabah_CellClick);
            // 
            // FormNasabah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNasabah";
            this.Text = "Data Nasabah";
            this.Load += new System.EventHandler(this.FormNasabah_Load);
            this.panelMain.ResumeLayout(false);
            this.panelGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNasabah)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelFormCard.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.tableLayoutPanelFields.ResumeLayout(false);
            this.panelPhotoCol.ResumeLayout(false);
            this.panelPhotoCol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNasabah)).EndInit();
            this.panelInputsCol.ResumeLayout(false);
            this.panelInputsCol.PerformLayout();
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
        private System.Windows.Forms.PictureBox picNasabah;
        private System.Windows.Forms.Button btnPilihFoto;
        private System.Windows.Forms.Button btnHapusFoto;
        private System.Windows.Forms.Panel panelInputsCol;
        private System.Windows.Forms.Label lblNamaTitle;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblNoHpTitle;
        private System.Windows.Forms.TextBox txtNoHp;
        private System.Windows.Forms.Label lblAlamatTitle;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnRiwayat;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lblCariTitle;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Panel panelGridCard;
        private System.Windows.Forms.DataGridView dgvNasabah;
    }
}
