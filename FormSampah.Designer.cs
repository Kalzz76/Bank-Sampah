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
            this.panelFormCard.Size = new System.Drawing.Size(860, 138);
            this.panelFormCard.TabIndex = 1;
            // 
            // tableLayoutPanelFields
            // 
            this.tableLayoutPanelFields.ColumnCount = 3;
            this.tableLayoutPanelFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanelFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelFields.Controls.Add(this.panelField3, 2, 0);
            this.tableLayoutPanelFields.Controls.Add(this.panelField2, 1, 0);
            this.tableLayoutPanelFields.Controls.Add(this.panelField1, 0, 0);
            this.tableLayoutPanelFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelFields.Location = new System.Drawing.Point(16, 16);
            this.tableLayoutPanelFields.Name = "tableLayoutPanelFields";
            this.tableLayoutPanelFields.RowCount = 1;
            this.tableLayoutPanelFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFields.Size = new System.Drawing.Size(826, 62);
            this.tableLayoutPanelFields.TabIndex = 0;
            // 
            // panelField1
            // 
            this.panelField1.Controls.Add(this.txtNama);
            this.panelField1.Controls.Add(this.lblNamaTitle);
            this.panelField1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelField1.Location = new System.Drawing.Point(0, 0);
            this.panelField1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panelField1.Name = "panelField1";
            this.panelField1.Size = new System.Drawing.Size(361, 62);
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
            this.txtNama.Size = new System.Drawing.Size(361, 24);
            this.txtNama.TabIndex = 2;
            // 
            // panelField2
            // 
            this.panelField2.Controls.Add(this.cmbKategori);
            this.panelField2.Controls.Add(this.lblKategoriTitle);
            this.panelField2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelField2.Location = new System.Drawing.Point(371, 0);
            this.panelField2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panelField2.Name = "panelField2";
            this.panelField2.Size = new System.Drawing.Size(196, 62);
            this.panelField2.TabIndex = 1;
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
            this.cmbKategori.Size = new System.Drawing.Size(196, 25);
            this.cmbKategori.TabIndex = 2;
            // 
            // panelField3
            // 
            this.panelField3.Controls.Add(this.txtHarga);
            this.panelField3.Controls.Add(this.lblHargaTitle);
            this.panelField3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelField3.Location = new System.Drawing.Point(577, 0);
            this.panelField3.Margin = new System.Windows.Forms.Padding(0);
            this.panelField3.Name = "panelField3";
            this.panelField3.Size = new System.Drawing.Size(249, 62);
            this.panelField3.TabIndex = 2;
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
            this.txtHarga.Size = new System.Drawing.Size(249, 24);
            this.txtHarga.TabIndex = 2;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnSimpan);
            this.panelButtons.Controls.Add(this.btnUbah);
            this.panelButtons.Controls.Add(this.btnHapus);
            this.panelButtons.Controls.Add(this.btnBatal);
            this.panelButtons.Controls.Add(this.lblTipsSOP);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(16, 88);
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
            this.panelGridCard.Location = new System.Drawing.Point(20, 222);
            this.panelGridCard.Margin = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.panelGridCard.Name = "panelGridCard";
            this.panelGridCard.Padding = new System.Windows.Forms.Padding(1);
            this.panelGridCard.Size = new System.Drawing.Size(860, 408);
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
            this.dgvSampah.Size = new System.Drawing.Size(856, 404);
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
        private System.Windows.Forms.Label lblNamaTitle;
        private System.Windows.Forms.TextBox txtNama;
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
