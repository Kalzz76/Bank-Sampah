using System;
using System.Drawing;
using System.Windows.Forms;

namespace BankSampah
{
    partial class FormUser
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.panelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.panelGridCard = new System.Windows.Forms.Panel();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.panelSearchBox = new System.Windows.Forms.Panel();
            this.lblRecordBadge = new System.Windows.Forms.Label();
            this.lblGridHeaderTitle = new System.Windows.Forms.Label();
            this.panelMainContainer.SuspendLayout();
            this.panelFormCard.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelGridCard.SuspendLayout();
            this.panelSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.ColumnCount = 2;
            this.panelMainContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 340F));
            this.panelMainContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.panelMainContainer.Controls.Add(this.panelFormCard, 0, 0);
            this.panelMainContainer.Controls.Add(this.panelGridCard, 1, 0);
            this.panelMainContainer.Dock = DockStyle.Fill;
            this.panelMainContainer.Location = new Point(0, 0);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Padding = new Padding(20);
            this.panelMainContainer.RowCount = 1;
            this.panelMainContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.panelMainContainer.Size = new Size(960, 655);
            this.panelMainContainer.TabIndex = 0;
            // 
            // panelFormCard
            // 
            this.panelFormCard.BackColor = Color.White;
            this.panelFormCard.Controls.Add(this.lblFormHeader);
            this.panelFormCard.Controls.Add(this.lblUsername);
            this.panelFormCard.Controls.Add(this.txtUsername);
            this.panelFormCard.Controls.Add(this.lblPassword);
            this.panelFormCard.Controls.Add(this.txtPassword);
            this.panelFormCard.Controls.Add(this.lblNama);
            this.panelFormCard.Controls.Add(this.txtNama);
            this.panelFormCard.Controls.Add(this.lblRole);
            this.panelFormCard.Controls.Add(this.cmbRole);
            this.panelFormCard.Controls.Add(this.panelButtons);
            this.panelFormCard.Dock = DockStyle.Fill;
            this.panelFormCard.Location = new Point(20, 20);
            this.panelFormCard.Margin = new Padding(0, 0, 15, 0);
            this.panelFormCard.Name = "panelFormCard";
            this.panelFormCard.Padding = new Padding(20);
            this.panelFormCard.Size = new Size(325, 615);
            this.panelFormCard.TabIndex = 0;
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblFormHeader.ForeColor = Color.FromArgb(6, 78, 59);
            this.lblFormHeader.Location = new Point(15, 15);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new Size(195, 21);
            this.lblFormHeader.TabIndex = 0;
            this.lblFormHeader.Text = "📝 Registration User Baru";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblUsername.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblUsername.Location = new Point(15, 55);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new Size(76, 15);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "👤 Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new Font("Segoe UI", 10F);
            this.txtUsername.Location = new Point(15, 75);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new Size(290, 25);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblPassword.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblPassword.Location = new Point(15, 115);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(73, 15);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "🔑 Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new Font("Segoe UI", 10F);
            this.txtPassword.Location = new Point(15, 135);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new Size(290, 25);
            this.txtPassword.TabIndex = 4;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblNama.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblNama.Location = new Point(15, 175);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new Size(102, 15);
            this.lblNama.TabIndex = 5;
            this.lblNama.Text = "📝 Nama Lengkap";
            // 
            // txtNama
            // 
            this.txtNama.Font = new Font("Segoe UI", 10F);
            this.txtNama.Location = new Point(15, 195);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new Size(290, 25);
            this.txtNama.TabIndex = 6;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblRole.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblRole.Location = new Point(15, 235);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new Size(116, 15);
            this.lblRole.TabIndex = 7;
            this.lblRole.Text = "🛡️ Role / Hak Akses";
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new Font("Segoe UI", 10F);
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Petugas"});
            this.cmbRole.Location = new Point(15, 255);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new Size(290, 25);
            this.cmbRole.TabIndex = 8;
            // 
            // panelButtons
            // 
            this.panelButtons.ColumnCount = 2;
            this.panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.panelButtons.Controls.Add(this.btnSimpan, 0, 0);
            this.panelButtons.Controls.SetChildIndex(this.btnSimpan, 0);
            this.panelButtons.Controls.Add(this.btnHapus, 0, 1);
            this.panelButtons.Controls.Add(this.btnBatal, 1, 1);
            this.panelButtons.Location = new Point(15, 305);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.RowCount = 2;
            this.panelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.panelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.panelButtons.Size = new Size(290, 100);
            this.panelButtons.TabIndex = 9;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = Color.FromArgb(16, 185, 129);
            this.panelButtons.SetColumnSpan(this.btnSimpan, 2);
            this.btnSimpan.Cursor = Cursors.Hand;
            this.btnSimpan.Dock = DockStyle.Fill;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = FlatStyle.Flat;
            this.btnSimpan.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnSimpan.ForeColor = Color.White;
            this.btnSimpan.Location = new Point(3, 3);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new Size(284, 44);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "💾 TAMBAH USER BARU";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new EventHandler(this.btnSimpan_Click);
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
            this.btnHapus.Location = new Point(3, 53);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new Size(139, 44);
            this.btnHapus.TabIndex = 1;
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
            this.btnBatal.Location = new Point(148, 53);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new Size(139, 44);
            this.btnBatal.TabIndex = 2;
            this.btnBatal.Text = "🔄 BATAL";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new EventHandler(this.btnBatal_Click);
            // 
            // panelGridCard
            // 
            this.panelGridCard.BackColor = Color.White;
            this.panelGridCard.Controls.Add(this.dgvUser);
            this.panelGridCard.Controls.Add(this.panelSearchBox);
            this.panelGridCard.Dock = DockStyle.Fill;
            this.panelGridCard.Location = new Point(360, 20);
            this.panelGridCard.Margin = new Padding(0);
            this.panelGridCard.Name = "panelGridCard";
            this.panelGridCard.Padding = new Padding(15);
            this.panelGridCard.Size = new Size(580, 615);
            this.panelGridCard.TabIndex = 1;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.BackgroundColor = Color.White;
            this.dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Dock = DockStyle.Fill;
            this.dgvUser.Location = new Point(15, 60);
            this.dgvUser.MultiSelect = false;
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new Size(550, 540);
            this.dgvUser.TabIndex = 1;
            this.dgvUser.CellClick += new DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // panelSearchBox
            // 
            this.panelSearchBox.BackColor = Color.FromArgb(240, 244, 242);
            this.panelSearchBox.Controls.Add(this.lblRecordBadge);
            this.panelSearchBox.Controls.Add(this.lblGridHeaderTitle);
            this.panelSearchBox.Dock = DockStyle.Top;
            this.panelSearchBox.Location = new Point(15, 15);
            this.panelSearchBox.Name = "panelSearchBox";
            this.panelSearchBox.Padding = new Padding(10, 8, 10, 8);
            this.panelSearchBox.Size = new Size(550, 45);
            this.panelSearchBox.TabIndex = 0;
            // 
            // lblRecordBadge
            // 
            this.lblRecordBadge.Dock = DockStyle.Right;
            this.lblRecordBadge.AutoSize = true;
            this.lblRecordBadge.BackColor = Color.FromArgb(16, 185, 129);
            this.lblRecordBadge.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            this.lblRecordBadge.ForeColor = Color.White;
            this.lblRecordBadge.Location = new Point(390, 8);
            this.lblRecordBadge.Padding = new Padding(8, 4, 8, 4);
            this.lblRecordBadge.Name = "lblRecordBadge";
            this.lblRecordBadge.Size = new Size(150, 23);
            this.lblRecordBadge.TabIndex = 1;
            this.lblRecordBadge.Text = "📌 TOTAL: 0 USER";
            // 
            // lblGridHeaderTitle
            // 
            this.lblGridHeaderTitle.AutoSize = true;
            this.lblGridHeaderTitle.Dock = DockStyle.Left;
            this.lblGridHeaderTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblGridHeaderTitle.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblGridHeaderTitle.Location = new Point(10, 8);
            this.lblGridHeaderTitle.Name = "lblGridHeaderTitle";
            this.lblGridHeaderTitle.Size = new Size(205, 19);
            this.lblGridHeaderTitle.TabIndex = 0;
            this.lblGridHeaderTitle.Text = "📋 Daftar User Petugas Sistem";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(240, 244, 242);
            this.ClientSize = new Size(960, 655);
            this.Controls.Add(this.panelMainContainer);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "FormUser";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Kelola User & Hak Akses";
            this.Load += new EventHandler(this.FormUser_Load);
            this.panelMainContainer.ResumeLayout(false);
            this.panelFormCard.ResumeLayout(false);
            this.panelFormCard.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelGridCard.ResumeLayout(false);
            this.panelSearchBox.ResumeLayout(false);
            this.panelSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelMainContainer;
        private System.Windows.Forms.Panel panelFormCard;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TableLayoutPanel panelButtons;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Panel panelGridCard;
        private System.Windows.Forms.Panel panelSearchBox;
        private System.Windows.Forms.Label lblGridHeaderTitle;
        private System.Windows.Forms.Label lblRecordBadge;
        private System.Windows.Forms.DataGridView dgvUser;
    }
}
