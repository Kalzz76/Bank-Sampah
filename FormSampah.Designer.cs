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
            this.panelMainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.panelFormCard = new System.Windows.Forms.Panel();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.panelPhotoContainer = new System.Windows.Forms.Panel();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnBrowseFoto = new System.Windows.Forms.Button();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblJenis = new System.Windows.Forms.Label();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblHarga = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.panelGridCard = new System.Windows.Forms.Panel();
            this.dgvSampah = new System.Windows.Forms.DataGridView();
            this.panelSearchBox = new System.Windows.Forms.Panel();
            this.lblRecordBadge = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.lblCariIcon = new System.Windows.Forms.Label();
            this.panelMainContainer.SuspendLayout();
            this.panelFormCard.SuspendLayout();
            this.panelPhotoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelGridCard.SuspendLayout();
            this.panelSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSampah)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.ColumnCount = 1;
            this.panelMainContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.panelMainContainer.Controls.Add(this.panelFormCard, 0, 0);
            this.panelMainContainer.Controls.Add(this.panelGridCard, 0, 1);
            this.panelMainContainer.Dock = DockStyle.Fill;
            this.panelMainContainer.Location = new Point(0, 0);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Padding = new Padding(20);
            this.panelMainContainer.RowCount = 2;
            this.panelMainContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 210F));
            this.panelMainContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.panelMainContainer.Size = new Size(960, 655);
            this.panelMainContainer.TabIndex = 0;
            // 
            // panelFormCard
            // 
            this.panelFormCard.BackColor = Color.White;
            this.panelFormCard.Controls.Add(this.lblFormHeader);
            this.panelFormCard.Controls.Add(this.panelPhotoContainer);
            this.panelFormCard.Controls.Add(this.lblNama);
            this.panelFormCard.Controls.Add(this.txtNama);
            this.panelFormCard.Controls.Add(this.lblHarga);
            this.panelFormCard.Controls.Add(this.txtHarga);
            this.panelFormCard.Controls.Add(this.lblJenis);
            this.panelFormCard.Controls.Add(this.cmbJenis);
            this.panelFormCard.Controls.Add(this.lblKategori);
            this.panelFormCard.Controls.Add(this.cmbKategori);
            this.panelFormCard.Controls.Add(this.panelButtons);
            this.panelFormCard.Dock = DockStyle.Fill;
            this.panelFormCard.Location = new Point(20, 20);
            this.panelFormCard.Margin = new Padding(0, 0, 0, 15);
            this.panelFormCard.Name = "panelFormCard";
            this.panelFormCard.Padding = new Padding(15);
            this.panelFormCard.Size = new Size(920, 195);
            this.panelFormCard.TabIndex = 0;
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblFormHeader.ForeColor = Color.FromArgb(6, 78, 59);
            this.lblFormHeader.Location = new Point(15, 8);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new Size(198, 20);
            this.lblFormHeader.TabIndex = 0;
            this.lblFormHeader.Text = "📝 Form Data & Foto Sampah";
            // 
            // panelPhotoContainer
            // 
            this.panelPhotoContainer.BackColor = Color.FromArgb(240, 244, 242);
            this.panelPhotoContainer.Controls.Add(this.picFoto);
            this.panelPhotoContainer.Controls.Add(this.btnBrowseFoto);
            this.panelPhotoContainer.Location = new Point(15, 32);
            this.panelPhotoContainer.Name = "panelPhotoContainer";
            this.panelPhotoContainer.Padding = new Padding(6);
            this.panelPhotoContainer.Size = new Size(245, 145);
            this.panelPhotoContainer.TabIndex = 1;
            // 
            // picFoto
            // 
            this.picFoto.BackColor = Color.White;
            this.picFoto.BorderStyle = BorderStyle.FixedSingle;
            this.picFoto.Location = new Point(8, 8);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new Size(125, 128);
            this.picFoto.SizeMode = PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 0;
            this.picFoto.TabStop = false;
            // 
            // btnBrowseFoto
            // 
            this.btnBrowseFoto.BackColor = Color.FromArgb(4, 120, 87);
            this.btnBrowseFoto.Cursor = Cursors.Hand;
            this.btnBrowseFoto.FlatAppearance.BorderSize = 0;
            this.btnBrowseFoto.FlatStyle = FlatStyle.Flat;
            this.btnBrowseFoto.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            this.btnBrowseFoto.ForeColor = Color.White;
            this.btnBrowseFoto.Location = new Point(140, 48);
            this.btnBrowseFoto.Name = "btnBrowseFoto";
            this.btnBrowseFoto.Size = new Size(95, 42);
            this.btnBrowseFoto.TabIndex = 1;
            this.btnBrowseFoto.Text = "🖼️ FOTO";
            this.btnBrowseFoto.UseVisualStyleBackColor = false;
            this.btnBrowseFoto.Click += new EventHandler(this.btnBrowseFoto_Click);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new Font("Segoe UI", 8.75F, FontStyle.Bold);
            this.lblNama.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblNama.Location = new Point(275, 32);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new Size(97, 15);
            this.lblNama.TabIndex = 2;
            this.lblNama.Text = "♻️ Nama Sampah";
            // 
            // txtNama
            // 
            this.txtNama.Font = new Font("Segoe UI", 10F);
            this.txtNama.Location = new Point(275, 50);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new Size(230, 25);
            this.txtNama.TabIndex = 3;
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new Font("Segoe UI", 8.75F, FontStyle.Bold);
            this.lblHarga.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblHarga.Location = new Point(520, 32);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new Size(119, 15);
            this.lblHarga.TabIndex = 8;
            this.lblHarga.Text = "💰 Harga per Kg (Rp)";
            // 
            // txtHarga
            // 
            this.txtHarga.Font = new Font("Segoe UI", 10F);
            this.txtHarga.Location = new Point(520, 50);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new Size(200, 25);
            this.txtHarga.TabIndex = 9;
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Font = new Font("Segoe UI", 8.75F, FontStyle.Bold);
            this.lblJenis.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblJenis.Location = new Point(275, 88);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new Size(130, 15);
            this.lblJenis.TabIndex = 4;
            this.lblJenis.Text = "🏷️ Kelas / Jenis Sampah";
            // 
            // cmbJenis
            // 
            this.cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbJenis.Font = new Font("Segoe UI", 10F);
            this.cmbJenis.FormattingEnabled = true;
            this.cmbJenis.Items.AddRange(new object[] {
            "Organik",
            "Anorganik",
            "B3 (Bahan Berbahaya)"});
            this.cmbJenis.Location = new Point(275, 106);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new Size(230, 25);
            this.cmbJenis.TabIndex = 5;
            this.cmbJenis.SelectedIndexChanged += new EventHandler(this.cmbJenis_SelectedIndexChanged);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new Font("Segoe UI", 8.75F, FontStyle.Bold);
            this.lblKategori.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblKategori.Location = new Point(520, 88);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new Size(136, 15);
            this.lblKategori.TabIndex = 6;
            this.lblKategori.Text = "📂 Kategori Detail Sampah";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbKategori.Font = new Font("Segoe UI", 10F);
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new Point(520, 106);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new Size(200, 25);
            this.cmbKategori.TabIndex = 7;
            // 
            // panelButtons
            // 
            this.panelButtons.ColumnCount = 2;
            this.panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.panelButtons.Controls.Add(this.btnSimpan, 0, 0);
            this.panelButtons.Controls.Add(this.btnUbah, 1, 0);
            this.panelButtons.Controls.Add(this.btnHapus, 0, 1);
            this.panelButtons.Controls.Add(this.btnBatal, 1, 1);
            this.panelButtons.Location = new Point(735, 48);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.RowCount = 2;
            this.panelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.panelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.panelButtons.Size = new Size(170, 86);
            this.panelButtons.TabIndex = 10;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = Color.FromArgb(16, 185, 129);
            this.btnSimpan.Cursor = Cursors.Hand;
            this.btnSimpan.Dock = DockStyle.Fill;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = FlatStyle.Flat;
            this.btnSimpan.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            this.btnSimpan.ForeColor = Color.White;
            this.btnSimpan.Location = new Point(2, 2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new Size(81, 39);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "💾 SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new EventHandler(this.btnSimpan_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = Color.FromArgb(37, 99, 235);
            this.btnUbah.Cursor = Cursors.Hand;
            this.btnUbah.Dock = DockStyle.Fill;
            this.btnUbah.FlatAppearance.BorderSize = 0;
            this.btnUbah.FlatStyle = FlatStyle.Flat;
            this.btnUbah.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            this.btnUbah.ForeColor = Color.White;
            this.btnUbah.Location = new Point(87, 2);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new Size(81, 39);
            this.btnUbah.TabIndex = 1;
            this.btnUbah.Text = "✏️ UBAH";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new EventHandler(this.btnUbah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = Color.FromArgb(225, 29, 72);
            this.btnHapus.Cursor = Cursors.Hand;
            this.btnHapus.Dock = DockStyle.Fill;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = FlatStyle.Flat;
            this.btnHapus.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            this.btnHapus.ForeColor = Color.White;
            this.btnHapus.Location = new Point(2, 45);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new Size(81, 39);
            this.btnHapus.TabIndex = 2;
            this.btnHapus.Text = "🗑️ HAPUS";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new EventHandler(this.btnHapus_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = Color.FromArgb(100, 116, 139);
            this.btnBatal.Cursor = Cursors.Hand;
            this.btnBatal.Dock = DockStyle.Fill;
            this.btnBatal.FlatAppearance.BorderSize = 0;
            this.btnBatal.FlatStyle = FlatStyle.Flat;
            this.btnBatal.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            this.btnBatal.ForeColor = Color.White;
            this.btnBatal.Location = new Point(87, 45);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new Size(81, 39);
            this.btnBatal.TabIndex = 3;
            this.btnBatal.Text = "🔄 BATAL";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new EventHandler(this.btnBatal_Click);
            // 
            // panelGridCard
            // 
            this.panelGridCard.BackColor = Color.White;
            this.panelGridCard.Controls.Add(this.dgvSampah);
            this.panelGridCard.Controls.Add(this.panelSearchBox);
            this.panelGridCard.Dock = DockStyle.Fill;
            this.panelGridCard.Location = new Point(20, 230);
            this.panelGridCard.Margin = new Padding(0);
            this.panelGridCard.Name = "panelGridCard";
            this.panelGridCard.Padding = new Padding(15);
            this.panelGridCard.Size = new Size(920, 405);
            this.panelGridCard.TabIndex = 1;
            // 
            // dgvSampah
            // 
            this.dgvSampah.AllowUserToAddRows = false;
            this.dgvSampah.AllowUserToDeleteRows = false;
            this.dgvSampah.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSampah.BackgroundColor = Color.White;
            this.dgvSampah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSampah.Dock = DockStyle.Fill;
            this.dgvSampah.Location = new Point(15, 60);
            this.dgvSampah.MultiSelect = false;
            this.dgvSampah.Name = "dgvSampah";
            this.dgvSampah.ReadOnly = true;
            this.dgvSampah.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvSampah.Size = new Size(890, 330);
            this.dgvSampah.TabIndex = 1;
            this.dgvSampah.CellClick += new DataGridViewCellEventHandler(this.dgvSampah_CellClick);
            // 
            // panelSearchBox
            // 
            this.panelSearchBox.BackColor = Color.FromArgb(240, 244, 242);
            this.panelSearchBox.Controls.Add(this.lblRecordBadge);
            this.panelSearchBox.Controls.Add(this.txtCari);
            this.panelSearchBox.Controls.Add(this.lblCariIcon);
            this.panelSearchBox.Dock = DockStyle.Top;
            this.panelSearchBox.Location = new Point(15, 15);
            this.panelSearchBox.Name = "panelSearchBox";
            this.panelSearchBox.Padding = new Padding(10, 8, 10, 8);
            this.panelSearchBox.Size = new Size(890, 45);
            this.panelSearchBox.TabIndex = 0;
            // 
            // lblRecordBadge
            // 
            this.lblRecordBadge.Dock = DockStyle.Right;
            this.lblRecordBadge.AutoSize = true;
            this.lblRecordBadge.BackColor = Color.FromArgb(16, 185, 129);
            this.lblRecordBadge.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            this.lblRecordBadge.ForeColor = Color.White;
            this.lblRecordBadge.Location = new Point(715, 8);
            this.lblRecordBadge.Padding = new Padding(8, 4, 8, 4);
            this.lblRecordBadge.Name = "lblRecordBadge";
            this.lblRecordBadge.Size = new Size(165, 23);
            this.lblRecordBadge.TabIndex = 2;
            this.lblRecordBadge.Text = "KATALOG: 0 JENIS SAMPAH";
            // 
            // txtCari
            // 
            this.txtCari.BackColor = Color.FromArgb(240, 244, 242);
            this.txtCari.BorderStyle = BorderStyle.None;
            this.txtCari.Dock = DockStyle.Fill;
            this.txtCari.Font = new Font("Segoe UI", 10.5F);
            this.txtCari.Location = new Point(125, 8);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new Size(590, 19);
            this.txtCari.TabIndex = 1;
            this.txtCari.TextChanged += new EventHandler(this.txtCari_TextChanged);
            // 
            // lblCariIcon
            // 
            this.lblCariIcon.AutoSize = true;
            this.lblCariIcon.Dock = DockStyle.Left;
            this.lblCariIcon.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblCariIcon.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblCariIcon.Location = new Point(10, 8);
            this.lblCariIcon.Name = "lblCariIcon";
            this.lblCariIcon.Size = new Size(115, 17);
            this.lblCariIcon.TabIndex = 0;
            this.lblCariIcon.Text = "🔍 Cari Sampah: ";
            // 
            // FormSampah
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(240, 244, 242);
            this.ClientSize = new Size(960, 655);
            this.Controls.Add(this.panelMainContainer);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "FormSampah";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Katalog Data & Foto Sampah";
            this.Load += new EventHandler(this.FormSampah_Load);
            this.panelMainContainer.ResumeLayout(false);
            this.panelFormCard.ResumeLayout(false);
            this.panelFormCard.PerformLayout();
            this.panelPhotoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelGridCard.ResumeLayout(false);
            this.panelSearchBox.ResumeLayout(false);
            this.panelSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSampah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelMainContainer;
        private System.Windows.Forms.Panel panelFormCard;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Panel panelPhotoContainer;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btnBrowseFoto;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TableLayoutPanel panelButtons;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Panel panelGridCard;
        private System.Windows.Forms.Panel panelSearchBox;
        private System.Windows.Forms.Label lblCariIcon;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label lblRecordBadge;
        private System.Windows.Forms.DataGridView dgvSampah;
    }
}
