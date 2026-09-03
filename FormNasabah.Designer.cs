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
            this.panelMainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.panelFormCard = new System.Windows.Forms.Panel();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.lblKode = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lblNoHp = new System.Windows.Forms.Label();
            this.txtNoHp = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.panelGridCard = new System.Windows.Forms.Panel();
            this.dgvNasabah = new System.Windows.Forms.DataGridView();
            this.panelSearchBox = new System.Windows.Forms.Panel();
            this.lblRecordBadge = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.lblCariIcon = new System.Windows.Forms.Label();
            this.panelMainContainer.SuspendLayout();
            this.panelFormCard.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelGridCard.SuspendLayout();
            this.panelSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNasabah)).BeginInit();
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
            this.panelMainContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            this.panelMainContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.panelMainContainer.Size = new Size(960, 655);
            this.panelMainContainer.TabIndex = 0;
            // 
            // panelFormCard
            // 
            this.panelFormCard.BackColor = Color.White;
            this.panelFormCard.Controls.Add(this.lblFormHeader);
            this.panelFormCard.Controls.Add(this.lblKode);
            this.panelFormCard.Controls.Add(this.txtKode);
            this.panelFormCard.Controls.Add(this.lblNama);
            this.panelFormCard.Controls.Add(this.txtNama);
            this.panelFormCard.Controls.Add(this.lblNoHp);
            this.panelFormCard.Controls.Add(this.txtNoHp);
            this.panelFormCard.Controls.Add(this.lblAlamat);
            this.panelFormCard.Controls.Add(this.txtAlamat);
            this.panelFormCard.Controls.Add(this.panelButtons);
            this.panelFormCard.Dock = DockStyle.Fill;
            this.panelFormCard.Location = new Point(20, 20);
            this.panelFormCard.Margin = new Padding(0, 0, 0, 15);
            this.panelFormCard.Name = "panelFormCard";
            this.panelFormCard.Padding = new Padding(20);
            this.panelFormCard.Size = new Size(920, 185);
            this.panelFormCard.TabIndex = 0;
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblFormHeader.ForeColor = Color.FromArgb(6, 78, 59);
            this.lblFormHeader.Location = new Point(20, 10);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new Size(198, 20);
            this.lblFormHeader.TabIndex = 0;
            this.lblFormHeader.Text = "📝 Form Input Data Nasabah";
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblKode.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblKode.Location = new Point(20, 38);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new Size(97, 15);
            this.lblKode.TabIndex = 1;
            this.lblKode.Text = "📌 Kode Nasabah";
            // 
            // txtKode
            // 
            this.txtKode.Font = new Font("Segoe UI", 10F);
            this.txtKode.Location = new Point(20, 56);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new Size(180, 25);
            this.txtKode.TabIndex = 2;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblNama.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblNama.Location = new Point(220, 38);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new Size(102, 15);
            this.lblNama.TabIndex = 3;
            this.lblNama.Text = "👤 Nama Lengkap";
            // 
            // txtNama
            // 
            this.txtNama.Font = new Font("Segoe UI", 10F);
            this.txtNama.Location = new Point(220, 56);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new Size(280, 25);
            this.txtNama.TabIndex = 4;
            // 
            // lblNoHp
            // 
            this.lblNoHp.AutoSize = true;
            this.lblNoHp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblNoHp.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblNoHp.Location = new Point(520, 38);
            this.lblNoHp.Name = "lblNoHp";
            this.lblNoHp.Size = new Size(111, 15);
            this.lblNoHp.TabIndex = 7;
            this.lblNoHp.Text = "📞 No. Telepon/HP";
            // 
            // txtNoHp
            // 
            this.txtNoHp.Font = new Font("Segoe UI", 10F);
            this.txtNoHp.Location = new Point(520, 56);
            this.txtNoHp.Name = "txtNoHp";
            this.txtNoHp.Size = new Size(220, 25);
            this.txtNoHp.TabIndex = 8;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblAlamat.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblAlamat.Location = new Point(20, 88);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new Size(62, 15);
            this.lblAlamat.TabIndex = 5;
            this.lblAlamat.Text = "🏠 Alamat";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Font = new Font("Segoe UI", 10F);
            this.txtAlamat.Location = new Point(20, 106);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new Size(480, 65);
            this.txtAlamat.TabIndex = 6;
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
            this.panelButtons.Location = new Point(520, 95);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.RowCount = 2;
            this.panelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.panelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.panelButtons.Size = new Size(360, 76);
            this.panelButtons.TabIndex = 9;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = Color.FromArgb(16, 185, 129);
            this.btnSimpan.Cursor = Cursors.Hand;
            this.btnSimpan.Dock = DockStyle.Fill;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = FlatStyle.Flat;
            this.btnSimpan.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnSimpan.ForeColor = Color.White;
            this.btnSimpan.Location = new Point(2, 2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new Size(176, 34);
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
            this.btnUbah.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnUbah.ForeColor = Color.White;
            this.btnUbah.Location = new Point(182, 2);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new Size(176, 34);
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
            this.btnHapus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnHapus.ForeColor = Color.White;
            this.btnHapus.Location = new Point(2, 40);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new Size(176, 34);
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
            this.btnBatal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnBatal.ForeColor = Color.White;
            this.btnBatal.Location = new Point(182, 40);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new Size(176, 34);
            this.btnBatal.TabIndex = 3;
            this.btnBatal.Text = "🔄 BATAL";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new EventHandler(this.btnBatal_Click);
            // 
            // panelGridCard
            // 
            this.panelGridCard.BackColor = Color.White;
            this.panelGridCard.Controls.Add(this.dgvNasabah);
            this.panelGridCard.Controls.Add(this.panelSearchBox);
            this.panelGridCard.Dock = DockStyle.Fill;
            this.panelGridCard.Location = new Point(20, 220);
            this.panelGridCard.Margin = new Padding(0);
            this.panelGridCard.Name = "panelGridCard";
            this.panelGridCard.Padding = new Padding(15);
            this.panelGridCard.Size = new Size(920, 415);
            this.panelGridCard.TabIndex = 1;
            // 
            // dgvNasabah
            // 
            this.dgvNasabah.AllowUserToAddRows = false;
            this.dgvNasabah.AllowUserToDeleteRows = false;
            this.dgvNasabah.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNasabah.BackgroundColor = Color.White;
            this.dgvNasabah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNasabah.Dock = DockStyle.Fill;
            this.dgvNasabah.Location = new Point(15, 60);
            this.dgvNasabah.MultiSelect = false;
            this.dgvNasabah.Name = "dgvNasabah";
            this.dgvNasabah.ReadOnly = true;
            this.dgvNasabah.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvNasabah.Size = new Size(890, 340);
            this.dgvNasabah.TabIndex = 1;
            this.dgvNasabah.CellClick += new DataGridViewCellEventHandler(this.dgvNasabah_CellClick);
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
            this.lblRecordBadge.Location = new Point(730, 8);
            this.lblRecordBadge.Padding = new Padding(8, 4, 8, 4);
            this.lblRecordBadge.Name = "lblRecordBadge";
            this.lblRecordBadge.Size = new Size(150, 23);
            this.lblRecordBadge.TabIndex = 2;
            this.lblRecordBadge.Text = "📌 TOTAL: 0 NASABAH";
            // 
            // txtCari
            // 
            this.txtCari.BackColor = Color.FromArgb(240, 244, 242);
            this.txtCari.BorderStyle = BorderStyle.None;
            this.txtCari.Dock = DockStyle.Fill;
            this.txtCari.Font = new Font("Segoe UI", 10.5F);
            this.txtCari.Location = new Point(125, 8);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new Size(605, 19);
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
            this.lblCariIcon.Text = "🔍 Cari Nasabah: ";
            // 
            // FormNasabah
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(240, 244, 242);
            this.ClientSize = new Size(960, 655);
            this.Controls.Add(this.panelMainContainer);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "FormNasabah";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Master Data Nasabah";
            this.Load += new EventHandler(this.FormNasabah_Load);
            this.panelMainContainer.ResumeLayout(false);
            this.panelFormCard.ResumeLayout(false);
            this.panelFormCard.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelGridCard.ResumeLayout(false);
            this.panelSearchBox.ResumeLayout(false);
            this.panelSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNasabah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelMainContainer;
        private System.Windows.Forms.Panel panelFormCard;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label lblNoHp;
        private System.Windows.Forms.TextBox txtNoHp;
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
        private System.Windows.Forms.DataGridView dgvNasabah;
    }
}
