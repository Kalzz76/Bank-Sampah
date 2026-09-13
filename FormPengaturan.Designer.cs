using System;
using System.Drawing;
using System.Windows.Forms;

namespace BankSampah
{
    partial class FormPengaturan
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
            this.panelContentArea = new System.Windows.Forms.Panel();
            this.panelUserTab = new System.Windows.Forms.Panel();
            this.panelUserGridCard = new System.Windows.Forms.Panel();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.panelUserGridHeader = new System.Windows.Forms.Panel();
            this.lblUserRecordBadge = new System.Windows.Forms.Label();
            this.lblUserGridTitle = new System.Windows.Forms.Label();
            this.panelUserFormCard = new System.Windows.Forms.Panel();
            this.panelUserButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSimpanUser = new System.Windows.Forms.Button();
            this.btnHapusUser = new System.Windows.Forms.Button();
            this.btnBatalUser = new System.Windows.Forms.Button();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUserFormHeader = new System.Windows.Forms.Label();
            this.panelAudioTab = new System.Windows.Forms.Panel();
            this.tableLayoutPanelAudio = new System.Windows.Forms.TableLayoutPanel();
            this.cardAudio3 = new System.Windows.Forms.Panel();
            this.btnTestAlertSound = new System.Windows.Forms.Button();
            this.lblAudio3Desc = new System.Windows.Forms.Label();
            this.lblAudio3Title = new System.Windows.Forms.Label();
            this.cardAudio2 = new System.Windows.Forms.Panel();
            this.btnTestSaveSound = new System.Windows.Forms.Button();
            this.lblAudio2Desc = new System.Windows.Forms.Label();
            this.lblAudio2Title = new System.Windows.Forms.Label();
            this.cardAudio1 = new System.Windows.Forms.Panel();
            this.btnTestLoginSound = new System.Windows.Forms.Button();
            this.lblAudio1Desc = new System.Windows.Forms.Label();
            this.lblAudio1Title = new System.Windows.Forms.Label();
            this.panelSystemTab = new System.Windows.Forms.Panel();
            this.cardSystemMain = new System.Windows.Forms.Panel();
            this.btnTestDbConn = new System.Windows.Forms.Button();
            this.btnBackupDatabase = new System.Windows.Forms.Button();
            this.panelSysCards = new System.Windows.Forms.TableLayoutPanel();
            this.cardSys4 = new System.Windows.Forms.Panel();
            this.lblSys4Val = new System.Windows.Forms.Label();
            this.lblSys4Title = new System.Windows.Forms.Label();
            this.cardSys3 = new System.Windows.Forms.Panel();
            this.lblSys3Val = new System.Windows.Forms.Label();
            this.lblSys3Title = new System.Windows.Forms.Label();
            this.cardSys2 = new System.Windows.Forms.Panel();
            this.lblSys2Val = new System.Windows.Forms.Label();
            this.lblSys2Title = new System.Windows.Forms.Label();
            this.cardSys1 = new System.Windows.Forms.Panel();
            this.lblSys1Val = new System.Windows.Forms.Label();
            this.lblSys1Title = new System.Windows.Forms.Label();
            this.lblSystemSub = new System.Windows.Forms.Label();
            this.lblSystemHeader = new System.Windows.Forms.Label();
            this.panelNavSegment = new System.Windows.Forms.Panel();
            this.btnTabSystem = new System.Windows.Forms.Button();
            this.btnTabAudio = new System.Windows.Forms.Button();
            this.btnTabUser = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelContentArea.SuspendLayout();
            this.panelUserTab.SuspendLayout();
            this.panelUserGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.panelUserGridHeader.SuspendLayout();
            this.panelUserFormCard.SuspendLayout();
            this.panelUserButtons.SuspendLayout();
            this.panelAudioTab.SuspendLayout();
            this.tableLayoutPanelAudio.SuspendLayout();
            this.cardAudio3.SuspendLayout();
            this.cardAudio2.SuspendLayout();
            this.cardAudio1.SuspendLayout();
            this.panelSystemTab.SuspendLayout();
            this.cardSystemMain.SuspendLayout();
            this.panelSysCards.SuspendLayout();
            this.cardSys4.SuspendLayout();
            this.cardSys3.SuspendLayout();
            this.cardSys2.SuspendLayout();
            this.cardSys1.SuspendLayout();
            this.panelNavSegment.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.panelContentArea);
            this.panelMain.Controls.Add(this.panelNavSegment);
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
            this.lblTitle.Size = new System.Drawing.Size(180, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pengaturan Sistem";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblDesc.Location = new System.Drawing.Point(1, 28);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(465, 17);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Kelola akun petugas, uji multimedia notifikasi audio, dan cek koneksi database.";
            // 
            // panelNavSegment
            // 
            this.panelNavSegment.Controls.Add(this.btnTabSystem);
            this.panelNavSegment.Controls.Add(this.btnTabAudio);
            this.panelNavSegment.Controls.Add(this.btnTabUser);
            this.panelNavSegment.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavSegment.Location = new System.Drawing.Point(20, 70);
            this.panelNavSegment.Name = "panelNavSegment";
            this.panelNavSegment.Padding = new System.Windows.Forms.Padding(0, 4, 0, 10);
            this.panelNavSegment.Size = new System.Drawing.Size(860, 46);
            this.panelNavSegment.TabIndex = 1;
            // 
            // btnTabUser
            // 
            this.btnTabUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnTabUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabUser.FlatAppearance.BorderSize = 0;
            this.btnTabUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabUser.ForeColor = System.Drawing.Color.White;
            this.btnTabUser.Location = new System.Drawing.Point(0, 2);
            this.btnTabUser.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnTabUser.Name = "btnTabUser";
            this.btnTabUser.Size = new System.Drawing.Size(180, 32);
            this.btnTabUser.TabIndex = 0;
            this.btnTabUser.Text = "👤 Kelola Petugas";
            this.btnTabUser.UseVisualStyleBackColor = false;
            this.btnTabUser.Click += new System.EventHandler(this.btnTabUser_Click);
            // 
            // btnTabAudio
            // 
            this.btnTabAudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.btnTabAudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabAudio.FlatAppearance.BorderSize = 0;
            this.btnTabAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabAudio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabAudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.btnTabAudio.Location = new System.Drawing.Point(188, 2);
            this.btnTabAudio.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnTabAudio.Name = "btnTabAudio";
            this.btnTabAudio.Size = new System.Drawing.Size(160, 32);
            this.btnTabAudio.TabIndex = 1;
            this.btnTabAudio.Text = "🔊 Uji Audio";
            this.btnTabAudio.UseVisualStyleBackColor = false;
            this.btnTabAudio.Click += new System.EventHandler(this.btnTabAudio_Click);
            // 
            // btnTabSystem
            // 
            this.btnTabSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.btnTabSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabSystem.FlatAppearance.BorderSize = 0;
            this.btnTabSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabSystem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.btnTabSystem.Location = new System.Drawing.Point(356, 2);
            this.btnTabSystem.Margin = new System.Windows.Forms.Padding(0);
            this.btnTabSystem.Name = "btnTabSystem";
            this.btnTabSystem.Size = new System.Drawing.Size(180, 32);
            this.btnTabSystem.TabIndex = 2;
            this.btnTabSystem.Text = "🖥️ Info Sistem";
            this.btnTabSystem.UseVisualStyleBackColor = false;
            this.btnTabSystem.Click += new System.EventHandler(this.btnTabSystem_Click);
            // 
            // panelContentArea
            // 
            this.panelContentArea.Controls.Add(this.panelUserTab);
            this.panelContentArea.Controls.Add(this.panelAudioTab);
            this.panelContentArea.Controls.Add(this.panelSystemTab);
            this.panelContentArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentArea.Location = new System.Drawing.Point(20, 116);
            this.panelContentArea.Name = "panelContentArea";
            this.panelContentArea.Size = new System.Drawing.Size(860, 514);
            this.panelContentArea.TabIndex = 2;
            // 
            // panelUserTab
            // 
            this.panelUserTab.Controls.Add(this.panelUserGridCard);
            this.panelUserTab.Controls.Add(this.panelUserFormCard);
            this.panelUserTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserTab.Location = new System.Drawing.Point(0, 0);
            this.panelUserTab.Name = "panelUserTab";
            this.panelUserTab.Size = new System.Drawing.Size(860, 514);
            this.panelUserTab.TabIndex = 0;
            // 
            // panelUserFormCard
            // 
            this.panelUserFormCard.BackColor = System.Drawing.Color.White;
            this.panelUserFormCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUserFormCard.Controls.Add(this.panelUserButtons);
            this.panelUserFormCard.Controls.Add(this.cmbRole);
            this.panelUserFormCard.Controls.Add(this.lblRole);
            this.panelUserFormCard.Controls.Add(this.txtNama);
            this.panelUserFormCard.Controls.Add(this.lblNama);
            this.panelUserFormCard.Controls.Add(this.txtPassword);
            this.panelUserFormCard.Controls.Add(this.lblPassword);
            this.panelUserFormCard.Controls.Add(this.txtUsername);
            this.panelUserFormCard.Controls.Add(this.lblUsername);
            this.panelUserFormCard.Controls.Add(this.lblUserFormHeader);
            this.panelUserFormCard.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUserFormCard.Location = new System.Drawing.Point(0, 0);
            this.panelUserFormCard.Name = "panelUserFormCard";
            this.panelUserFormCard.Padding = new System.Windows.Forms.Padding(16);
            this.panelUserFormCard.Size = new System.Drawing.Size(320, 514);
            this.panelUserFormCard.TabIndex = 0;
            // 
            // lblUserFormHeader
            // 
            this.lblUserFormHeader.AutoSize = true;
            this.lblUserFormHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUserFormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblUserFormHeader.Location = new System.Drawing.Point(14, 14);
            this.lblUserFormHeader.Name = "lblUserFormHeader";
            this.lblUserFormHeader.Size = new System.Drawing.Size(155, 20);
            this.lblUserFormHeader.TabIndex = 0;
            this.lblUserFormHeader.Text = "Form Kelola Pengguna";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblUsername.Location = new System.Drawing.Point(14, 46);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(63, 15);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtUsername.Location = new System.Drawing.Point(16, 64);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(286, 24);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblPassword.Location = new System.Drawing.Point(14, 98);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 15);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPassword.Location = new System.Drawing.Point(16, 116);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(286, 24);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblNama.Location = new System.Drawing.Point(14, 150);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(89, 15);
            this.lblNama.TabIndex = 5;
            this.lblNama.Text = "Nama Lengkap";
            // 
            // txtNama
            // 
            this.txtNama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNama.Location = new System.Drawing.Point(16, 168);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(286, 24);
            this.txtNama.TabIndex = 6;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblRole.Location = new System.Drawing.Point(14, 202);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(63, 15);
            this.lblRole.TabIndex = 7;
            this.lblRole.Text = "Hak Akses";
            // 
            // cmbRole
            // 
            this.cmbRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Petugas"});
            this.cmbRole.Location = new System.Drawing.Point(16, 220);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(286, 25);
            this.cmbRole.TabIndex = 8;
            // 
            // panelUserButtons
            // 
            this.panelUserButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUserButtons.Controls.Add(this.btnSimpanUser);
            this.panelUserButtons.Controls.Add(this.btnHapusUser);
            this.panelUserButtons.Controls.Add(this.btnBatalUser);
            this.panelUserButtons.Location = new System.Drawing.Point(16, 260);
            this.panelUserButtons.Name = "panelUserButtons";
            this.panelUserButtons.Size = new System.Drawing.Size(286, 75);
            this.panelUserButtons.TabIndex = 9;
            // 
            // btnSimpanUser
            // 
            this.btnSimpanUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(122)))), ((int)(((byte)(94)))));
            this.btnSimpanUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpanUser.FlatAppearance.BorderSize = 0;
            this.btnSimpanUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpanUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSimpanUser.ForeColor = System.Drawing.Color.White;
            this.btnSimpanUser.Location = new System.Drawing.Point(0, 0);
            this.btnSimpanUser.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.btnSimpanUser.Name = "btnSimpanUser";
            this.btnSimpanUser.Size = new System.Drawing.Size(86, 32);
            this.btnSimpanUser.TabIndex = 0;
            this.btnSimpanUser.Text = "Simpan";
            this.btnSimpanUser.UseVisualStyleBackColor = false;
            this.btnSimpanUser.Click += new System.EventHandler(this.btnSimpanUser_Click);
            // 
            // btnHapusUser
            // 
            this.btnHapusUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(217)))));
            this.btnHapusUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapusUser.FlatAppearance.BorderSize = 0;
            this.btnHapusUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapusUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHapusUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(70)))), ((int)(((byte)(50)))));
            this.btnHapusUser.Location = new System.Drawing.Point(92, 0);
            this.btnHapusUser.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.btnHapusUser.Name = "btnHapusUser";
            this.btnHapusUser.Size = new System.Drawing.Size(86, 32);
            this.btnHapusUser.TabIndex = 1;
            this.btnHapusUser.Text = "Hapus";
            this.btnHapusUser.UseVisualStyleBackColor = false;
            this.btnHapusUser.Click += new System.EventHandler(this.btnHapusUser_Click);
            // 
            // btnBatalUser
            // 
            this.btnBatalUser.BackColor = System.Drawing.Color.Transparent;
            this.btnBatalUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatalUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(194)))));
            this.btnBatalUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatalUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBatalUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.btnBatalUser.Location = new System.Drawing.Point(184, 0);
            this.btnBatalUser.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnBatalUser.Name = "btnBatalUser";
            this.btnBatalUser.Size = new System.Drawing.Size(96, 32);
            this.btnBatalUser.TabIndex = 2;
            this.btnBatalUser.Text = "Bersihkan";
            this.btnBatalUser.UseVisualStyleBackColor = false;
            this.btnBatalUser.Click += new System.EventHandler(this.btnBatalUser_Click);
            // 
            // panelUserGridCard
            // 
            this.panelUserGridCard.BackColor = System.Drawing.Color.White;
            this.panelUserGridCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUserGridCard.Controls.Add(this.dgvUser);
            this.panelUserGridCard.Controls.Add(this.panelUserGridHeader);
            this.panelUserGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserGridCard.Location = new System.Drawing.Point(334, 0);
            this.panelUserGridCard.Margin = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.panelUserGridCard.Name = "panelUserGridCard";
            this.panelUserGridCard.Padding = new System.Windows.Forms.Padding(1);
            this.panelUserGridCard.Size = new System.Drawing.Size(526, 514);
            this.panelUserGridCard.TabIndex = 1;
            // 
            // panelUserGridHeader
            // 
            this.panelUserGridHeader.Controls.Add(this.lblUserRecordBadge);
            this.panelUserGridHeader.Controls.Add(this.lblUserGridTitle);
            this.panelUserGridHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserGridHeader.Location = new System.Drawing.Point(1, 1);
            this.panelUserGridHeader.Name = "panelUserGridHeader";
            this.panelUserGridHeader.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.panelUserGridHeader.Size = new System.Drawing.Size(522, 38);
            this.panelUserGridHeader.TabIndex = 0;
            // 
            // lblUserGridTitle
            // 
            this.lblUserGridTitle.AutoSize = true;
            this.lblUserGridTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUserGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblUserGridTitle.Location = new System.Drawing.Point(8, 10);
            this.lblUserGridTitle.Name = "lblUserGridTitle";
            this.lblUserGridTitle.Size = new System.Drawing.Size(164, 17);
            this.lblUserGridTitle.TabIndex = 0;
            this.lblUserGridTitle.Text = "Daftar Pengguna Sistem";
            // 
            // lblUserRecordBadge
            // 
            this.lblUserRecordBadge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserRecordBadge.AutoSize = true;
            this.lblUserRecordBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.lblUserRecordBadge.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblUserRecordBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(122)))), ((int)(((byte)(94)))));
            this.lblUserRecordBadge.Location = new System.Drawing.Point(400, 10);
            this.lblUserRecordBadge.Name = "lblUserRecordBadge";
            this.lblUserRecordBadge.Size = new System.Drawing.Size(95, 13);
            this.lblUserRecordBadge.TabIndex = 1;
            this.lblUserRecordBadge.Text = "TOTAL: 0 USER";
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.Location = new System.Drawing.Point(1, 39);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.Size = new System.Drawing.Size(522, 472);
            this.dgvUser.TabIndex = 1;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // panelAudioTab
            // 
            this.panelAudioTab.Controls.Add(this.tableLayoutPanelAudio);
            this.panelAudioTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAudioTab.Location = new System.Drawing.Point(0, 0);
            this.panelAudioTab.Name = "panelAudioTab";
            this.panelAudioTab.Size = new System.Drawing.Size(860, 514);
            this.panelAudioTab.TabIndex = 1;
            this.panelAudioTab.Visible = false;
            // 
            // tableLayoutPanelAudio
            // 
            this.tableLayoutPanelAudio.ColumnCount = 3;
            this.tableLayoutPanelAudio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelAudio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelAudio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanelAudio.Controls.Add(this.cardAudio3, 2, 0);
            this.tableLayoutPanelAudio.Controls.Add(this.cardAudio2, 1, 0);
            this.tableLayoutPanelAudio.Controls.Add(this.cardAudio1, 0, 0);
            this.tableLayoutPanelAudio.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelAudio.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAudio.Name = "tableLayoutPanelAudio";
            this.tableLayoutPanelAudio.RowCount = 1;
            this.tableLayoutPanelAudio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAudio.Size = new System.Drawing.Size(860, 160);
            this.tableLayoutPanelAudio.TabIndex = 0;
            // 
            // cardAudio1
            // 
            this.cardAudio1.BackColor = System.Drawing.Color.White;
            this.cardAudio1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardAudio1.Controls.Add(this.btnTestLoginSound);
            this.cardAudio1.Controls.Add(this.lblAudio1Desc);
            this.cardAudio1.Controls.Add(this.lblAudio1Title);
            this.cardAudio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardAudio1.Location = new System.Drawing.Point(0, 0);
            this.cardAudio1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.cardAudio1.Name = "cardAudio1";
            this.cardAudio1.Padding = new System.Windows.Forms.Padding(16);
            this.cardAudio1.Size = new System.Drawing.Size(276, 160);
            this.cardAudio1.TabIndex = 0;
            // 
            // lblAudio1Title
            // 
            this.lblAudio1Title.AutoSize = true;
            this.lblAudio1Title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAudio1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblAudio1Title.Location = new System.Drawing.Point(14, 14);
            this.lblAudio1Title.Name = "lblAudio1Title";
            this.lblAudio1Title.Size = new System.Drawing.Size(127, 19);
            this.lblAudio1Title.TabIndex = 0;
            this.lblAudio1Title.Text = "Suara Login Sukses";
            // 
            // lblAudio1Desc
            // 
            this.lblAudio1Desc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAudio1Desc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAudio1Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblAudio1Desc.Location = new System.Drawing.Point(14, 38);
            this.lblAudio1Desc.Name = "lblAudio1Desc";
            this.lblAudio1Desc.Size = new System.Drawing.Size(246, 45);
            this.lblAudio1Desc.TabIndex = 1;
            this.lblAudio1Desc.Text = "Efek suara sambutan saat otentikasi login berhasil.";
            // 
            // btnTestLoginSound
            // 
            this.btnTestLoginSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.btnTestLoginSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestLoginSound.FlatAppearance.BorderSize = 0;
            this.btnTestLoginSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestLoginSound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTestLoginSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(26)))), ((int)(((byte)(2)))));
            this.btnTestLoginSound.Location = new System.Drawing.Point(17, 95);
            this.btnTestLoginSound.Name = "btnTestLoginSound";
            this.btnTestLoginSound.Size = new System.Drawing.Size(120, 32);
            this.btnTestLoginSound.TabIndex = 2;
            this.btnTestLoginSound.Text = "▶ Putar Suara";
            this.btnTestLoginSound.UseVisualStyleBackColor = false;
            this.btnTestLoginSound.Click += new System.EventHandler(this.btnTestLoginSound_Click);
            // 
            // cardAudio2
            // 
            this.cardAudio2.BackColor = System.Drawing.Color.White;
            this.cardAudio2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardAudio2.Controls.Add(this.btnTestSaveSound);
            this.cardAudio2.Controls.Add(this.lblAudio2Desc);
            this.cardAudio2.Controls.Add(this.lblAudio2Title);
            this.cardAudio2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardAudio2.Location = new System.Drawing.Point(286, 0);
            this.cardAudio2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.cardAudio2.Name = "cardAudio2";
            this.cardAudio2.Padding = new System.Windows.Forms.Padding(16);
            this.cardAudio2.Size = new System.Drawing.Size(276, 160);
            this.cardAudio2.TabIndex = 1;
            // 
            // lblAudio2Title
            // 
            this.lblAudio2Title.AutoSize = true;
            this.lblAudio2Title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAudio2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblAudio2Title.Location = new System.Drawing.Point(14, 14);
            this.lblAudio2Title.Name = "lblAudio2Title";
            this.lblAudio2Title.Size = new System.Drawing.Size(147, 19);
            this.lblAudio2Title.TabIndex = 0;
            this.lblAudio2Title.Text = "Suara Simpan Transaksi";
            // 
            // lblAudio2Desc
            // 
            this.lblAudio2Desc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAudio2Desc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAudio2Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblAudio2Desc.Location = new System.Drawing.Point(14, 38);
            this.lblAudio2Desc.Name = "lblAudio2Desc";
            this.lblAudio2Desc.Size = new System.Drawing.Size(246, 45);
            this.lblAudio2Desc.TabIndex = 1;
            this.lblAudio2Desc.Text = "Efek suara konfirmasi bahwa transaksi setor berhasil dicatat.";
            // 
            // btnTestSaveSound
            // 
            this.btnTestSaveSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.btnTestSaveSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestSaveSound.FlatAppearance.BorderSize = 0;
            this.btnTestSaveSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestSaveSound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTestSaveSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(26)))), ((int)(((byte)(2)))));
            this.btnTestSaveSound.Location = new System.Drawing.Point(17, 95);
            this.btnTestSaveSound.Name = "btnTestSaveSound";
            this.btnTestSaveSound.Size = new System.Drawing.Size(120, 32);
            this.btnTestSaveSound.TabIndex = 2;
            this.btnTestSaveSound.Text = "▶ Putar Suara";
            this.btnTestSaveSound.UseVisualStyleBackColor = false;
            this.btnTestSaveSound.Click += new System.EventHandler(this.btnTestSaveSound_Click);
            // 
            // cardAudio3
            // 
            this.cardAudio3.BackColor = System.Drawing.Color.White;
            this.cardAudio3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardAudio3.Controls.Add(this.btnTestAlertSound);
            this.cardAudio3.Controls.Add(this.lblAudio3Desc);
            this.cardAudio3.Controls.Add(this.lblAudio3Title);
            this.cardAudio3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardAudio3.Location = new System.Drawing.Point(572, 0);
            this.cardAudio3.Margin = new System.Windows.Forms.Padding(0);
            this.cardAudio3.Name = "cardAudio3";
            this.cardAudio3.Padding = new System.Windows.Forms.Padding(16);
            this.cardAudio3.Size = new System.Drawing.Size(288, 160);
            this.cardAudio3.TabIndex = 2;
            // 
            // lblAudio3Title
            // 
            this.lblAudio3Title.AutoSize = true;
            this.lblAudio3Title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAudio3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblAudio3Title.Location = new System.Drawing.Point(14, 14);
            this.lblAudio3Title.Name = "lblAudio3Title";
            this.lblAudio3Title.Size = new System.Drawing.Size(130, 19);
            this.lblAudio3Title.TabIndex = 0;
            this.lblAudio3Title.Text = "Suara Peringatan / Alert";
            // 
            // lblAudio3Desc
            // 
            this.lblAudio3Desc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAudio3Desc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAudio3Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblAudio3Desc.Location = new System.Drawing.Point(14, 38);
            this.lblAudio3Desc.Name = "lblAudio3Desc";
            this.lblAudio3Desc.Size = new System.Drawing.Size(258, 45);
            this.lblAudio3Desc.TabIndex = 1;
            this.lblAudio3Desc.Text = "Efek suara ketika terdapat inputan belum lengkap atau error validasi.";
            // 
            // btnTestAlertSound
            // 
            this.btnTestAlertSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.btnTestAlertSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestAlertSound.FlatAppearance.BorderSize = 0;
            this.btnTestAlertSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestAlertSound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTestAlertSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(26)))), ((int)(((byte)(2)))));
            this.btnTestAlertSound.Location = new System.Drawing.Point(17, 95);
            this.btnTestAlertSound.Name = "btnTestAlertSound";
            this.btnTestAlertSound.Size = new System.Drawing.Size(120, 32);
            this.btnTestAlertSound.TabIndex = 2;
            this.btnTestAlertSound.Text = "▶ Putar Suara";
            this.btnTestAlertSound.UseVisualStyleBackColor = false;
            this.btnTestAlertSound.Click += new System.EventHandler(this.btnTestAlertSound_Click);
            // 
            // panelSystemTab
            // 
            this.panelSystemTab.Controls.Add(this.cardSystemMain);
            this.panelSystemTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSystemTab.Location = new System.Drawing.Point(0, 0);
            this.panelSystemTab.Name = "panelSystemTab";
            this.panelSystemTab.Size = new System.Drawing.Size(860, 514);
            this.panelSystemTab.TabIndex = 2;
            this.panelSystemTab.Visible = false;
            // 
            // cardSystemMain
            // 
            this.cardSystemMain.BackColor = System.Drawing.Color.White;
            this.cardSystemMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardSystemMain.Controls.Add(this.btnBackupDatabase);
            this.cardSystemMain.Controls.Add(this.btnTestDbConn);
            this.cardSystemMain.Controls.Add(this.panelSysCards);
            this.cardSystemMain.Controls.Add(this.lblSystemSub);
            this.cardSystemMain.Controls.Add(this.lblSystemHeader);
            this.cardSystemMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardSystemMain.Location = new System.Drawing.Point(0, 0);
            this.cardSystemMain.Name = "cardSystemMain";
            this.cardSystemMain.Padding = new System.Windows.Forms.Padding(20);
            this.cardSystemMain.Size = new System.Drawing.Size(860, 260);
            this.cardSystemMain.TabIndex = 0;
            // 
            // lblSystemHeader
            // 
            this.lblSystemHeader.AutoSize = true;
            this.lblSystemHeader.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblSystemHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblSystemHeader.Location = new System.Drawing.Point(16, 16);
            this.lblSystemHeader.Name = "lblSystemHeader";
            this.lblSystemHeader.Size = new System.Drawing.Size(260, 21);
            this.lblSystemHeader.TabIndex = 0;
            this.lblSystemHeader.Text = "Status Sistem && Database Server";
            // 
            // lblSystemSub
            // 
            this.lblSystemSub.AutoSize = true;
            this.lblSystemSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSystemSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblSystemSub.Location = new System.Drawing.Point(17, 40);
            this.lblSystemSub.Name = "lblSystemSub";
            this.lblSystemSub.Size = new System.Drawing.Size(355, 15);
            this.lblSystemSub.TabIndex = 1;
            this.lblSystemSub.Text = "Ringkasan arsitektur infrastruktur koneksi database SIMBAS realtime.";
            // 
            // panelSysCards
            // 
            this.panelSysCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSysCards.ColumnCount = 4;
            this.panelSysCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelSysCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelSysCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelSysCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelSysCards.Controls.Add(this.cardSys4, 3, 0);
            this.panelSysCards.Controls.Add(this.cardSys3, 2, 0);
            this.panelSysCards.Controls.Add(this.cardSys2, 1, 0);
            this.panelSysCards.Controls.Add(this.cardSys1, 0, 0);
            this.panelSysCards.Location = new System.Drawing.Point(16, 70);
            this.panelSysCards.Name = "panelSysCards";
            this.panelSysCards.RowCount = 1;
            this.panelSysCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelSysCards.Size = new System.Drawing.Size(826, 95);
            this.panelSysCards.TabIndex = 2;
            // 
            // cardSys1
            // 
            this.cardSys1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.cardSys1.Controls.Add(this.lblSys1Val);
            this.cardSys1.Controls.Add(this.lblSys1Title);
            this.cardSys1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSys1.Location = new System.Drawing.Point(0, 0);
            this.cardSys1.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.cardSys1.Name = "cardSys1";
            this.cardSys1.Padding = new System.Windows.Forms.Padding(12);
            this.cardSys1.Size = new System.Drawing.Size(198, 95);
            this.cardSys1.TabIndex = 0;
            // 
            // lblSys1Title
            // 
            this.lblSys1Title.AutoSize = true;
            this.lblSys1Title.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSys1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(122)))), ((int)(((byte)(94)))));
            this.lblSys1Title.Location = new System.Drawing.Point(10, 10);
            this.lblSys1Title.Name = "lblSys1Title";
            this.lblSys1Title.Size = new System.Drawing.Size(100, 13);
            this.lblSys1Title.TabIndex = 0;
            this.lblSys1Title.Text = "STATUS DATABASE";
            // 
            // lblSys1Val
            // 
            this.lblSys1Val.AutoSize = true;
            this.lblSys1Val.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblSys1Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblSys1Val.Location = new System.Drawing.Point(10, 36);
            this.lblSys1Val.Name = "lblSys1Val";
            this.lblSys1Val.Size = new System.Drawing.Size(108, 19);
            this.lblSys1Val.TabIndex = 1;
            this.lblSys1Val.Text = "🟢 CONNECTED";
            // 
            // cardSys2
            // 
            this.cardSys2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.cardSys2.Controls.Add(this.lblSys2Val);
            this.cardSys2.Controls.Add(this.lblSys2Title);
            this.cardSys2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSys2.Location = new System.Drawing.Point(206, 0);
            this.cardSys2.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.cardSys2.Name = "cardSys2";
            this.cardSys2.Padding = new System.Windows.Forms.Padding(12);
            this.cardSys2.Size = new System.Drawing.Size(198, 95);
            this.cardSys2.TabIndex = 1;
            // 
            // lblSys2Title
            // 
            this.lblSys2Title.AutoSize = true;
            this.lblSys2Title.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSys2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblSys2Title.Location = new System.Drawing.Point(10, 10);
            this.lblSys2Title.Name = "lblSys2Title";
            this.lblSys2Title.Size = new System.Drawing.Size(116, 13);
            this.lblSys2Title.TabIndex = 0;
            this.lblSys2Title.Text = "SQL SERVER ENGINE";
            // 
            // lblSys2Val
            // 
            this.lblSys2Val.AutoSize = true;
            this.lblSys2Val.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSys2Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblSys2Val.Location = new System.Drawing.Point(10, 38);
            this.lblSys2Val.Name = "lblSys2Val";
            this.lblSys2Val.Size = new System.Drawing.Size(155, 17);
            this.lblSys2Val.TabIndex = 1;
            this.lblSys2Val.Text = "localhost / SQLEXPRESS";
            // 
            // cardSys3
            // 
            this.cardSys3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.cardSys3.Controls.Add(this.lblSys3Val);
            this.cardSys3.Controls.Add(this.lblSys3Title);
            this.cardSys3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSys3.Location = new System.Drawing.Point(412, 0);
            this.cardSys3.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.cardSys3.Name = "cardSys3";
            this.cardSys3.Padding = new System.Windows.Forms.Padding(12);
            this.cardSys3.Size = new System.Drawing.Size(198, 95);
            this.cardSys3.TabIndex = 2;
            // 
            // lblSys3Title
            // 
            this.lblSys3Title.AutoSize = true;
            this.lblSys3Title.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSys3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblSys3Title.Location = new System.Drawing.Point(10, 10);
            this.lblSys3Title.Name = "lblSys3Title";
            this.lblSys3Title.Size = new System.Drawing.Size(95, 13);
            this.lblSys3Title.TabIndex = 0;
            this.lblSys3Title.Text = "DATABASE NAME";
            // 
            // lblSys3Val
            // 
            this.lblSys3Val.AutoSize = true;
            this.lblSys3Val.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSys3Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblSys3Val.Location = new System.Drawing.Point(10, 38);
            this.lblSys3Val.Name = "lblSys3Val";
            this.lblSys3Val.Size = new System.Drawing.Size(98, 17);
            this.lblSys3Val.TabIndex = 1;
            this.lblSys3Val.Text = "db_banksampah";
            // 
            // cardSys4
            // 
            this.cardSys4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(220)))));
            this.cardSys4.Controls.Add(this.lblSys4Val);
            this.cardSys4.Controls.Add(this.lblSys4Title);
            this.cardSys4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSys4.Location = new System.Drawing.Point(618, 0);
            this.cardSys4.Margin = new System.Windows.Forms.Padding(0);
            this.cardSys4.Name = "cardSys4";
            this.cardSys4.Padding = new System.Windows.Forms.Padding(12);
            this.cardSys4.Size = new System.Drawing.Size(208, 95);
            this.cardSys4.TabIndex = 3;
            // 
            // lblSys4Title
            // 
            this.lblSys4Title.AutoSize = true;
            this.lblSys4Title.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSys4Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(122)))), ((int)(((byte)(18)))));
            this.lblSys4Title.Location = new System.Drawing.Point(10, 10);
            this.lblSys4Title.Name = "lblSys4Title";
            this.lblSys4Title.Size = new System.Drawing.Size(107, 13);
            this.lblSys4Title.TabIndex = 0;
            this.lblSys4Title.Text = "PLATFORM RUNTIME";
            // 
            // lblSys4Val
            // 
            this.lblSys4Val.AutoSize = true;
            this.lblSys4Val.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSys4Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(26)))), ((int)(((byte)(2)))));
            this.lblSys4Val.Location = new System.Drawing.Point(10, 38);
            this.lblSys4Val.Name = "lblSys4Val";
            this.lblSys4Val.Size = new System.Drawing.Size(135, 17);
            this.lblSys4Val.TabIndex = 1;
            this.lblSys4Val.Text = ".NET Framework 4.8";
            // 
            // btnTestDbConn
            // 
            this.btnTestDbConn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(122)))), ((int)(((byte)(94)))));
            this.btnTestDbConn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestDbConn.FlatAppearance.BorderSize = 0;
            this.btnTestDbConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestDbConn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTestDbConn.ForeColor = System.Drawing.Color.White;
            this.btnTestDbConn.Location = new System.Drawing.Point(16, 185);
            this.btnTestDbConn.Name = "btnTestDbConn";
            this.btnTestDbConn.Size = new System.Drawing.Size(220, 36);
            this.btnTestDbConn.TabIndex = 3;
            this.btnTestDbConn.Text = "⚡ Uji Koneksi Database Realtime";
            this.btnTestDbConn.UseVisualStyleBackColor = false;
            this.btnTestDbConn.Click += new System.EventHandler(this.btnTestDbConn_Click);
            // 
            // btnBackupDatabase
            // 
            this.btnBackupDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnBackupDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackupDatabase.FlatAppearance.BorderSize = 0;
            this.btnBackupDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupDatabase.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBackupDatabase.ForeColor = System.Drawing.Color.White;
            this.btnBackupDatabase.Location = new System.Drawing.Point(246, 185);
            this.btnBackupDatabase.Name = "btnBackupDatabase";
            this.btnBackupDatabase.Size = new System.Drawing.Size(210, 36);
            this.btnBackupDatabase.TabIndex = 4;
            this.btnBackupDatabase.Text = "💾 Backup Database (.bak)";
            this.btnBackupDatabase.UseVisualStyleBackColor = false;
            this.btnBackupDatabase.Click += new System.EventHandler(this.btnBackupDatabase_Click);
            // 
            // FormPengaturan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPengaturan";
            this.Text = "Pengaturan Sistem";
            this.Load += new System.EventHandler(this.FormPengaturan_Load);
            this.panelMain.ResumeLayout(false);
            this.panelContentArea.ResumeLayout(false);
            this.panelUserTab.ResumeLayout(false);
            this.panelUserGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.panelUserGridHeader.ResumeLayout(false);
            this.panelUserGridHeader.PerformLayout();
            this.panelUserFormCard.ResumeLayout(false);
            this.panelUserFormCard.PerformLayout();
            this.panelUserButtons.ResumeLayout(false);
            this.panelAudioTab.ResumeLayout(false);
            this.tableLayoutPanelAudio.ResumeLayout(false);
            this.cardAudio3.ResumeLayout(false);
            this.cardAudio3.PerformLayout();
            this.cardAudio2.ResumeLayout(false);
            this.cardAudio2.PerformLayout();
            this.cardAudio1.ResumeLayout(false);
            this.cardAudio1.PerformLayout();
            this.panelSystemTab.ResumeLayout(false);
            this.cardSystemMain.ResumeLayout(false);
            this.cardSystemMain.PerformLayout();
            this.panelSysCards.ResumeLayout(false);
            this.cardSys4.ResumeLayout(false);
            this.cardSys4.PerformLayout();
            this.cardSys3.ResumeLayout(false);
            this.cardSys3.PerformLayout();
            this.cardSys2.ResumeLayout(false);
            this.cardSys2.PerformLayout();
            this.cardSys1.ResumeLayout(false);
            this.cardSys1.PerformLayout();
            this.panelNavSegment.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Panel panelNavSegment;
        private System.Windows.Forms.Button btnTabUser;
        private System.Windows.Forms.Button btnTabAudio;
        private System.Windows.Forms.Button btnTabSystem;
        private System.Windows.Forms.Panel panelContentArea;
        private System.Windows.Forms.Panel panelUserTab;
        private System.Windows.Forms.Panel panelUserFormCard;
        private System.Windows.Forms.Label lblUserFormHeader;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.FlowLayoutPanel panelUserButtons;
        private System.Windows.Forms.Button btnSimpanUser;
        private System.Windows.Forms.Button btnHapusUser;
        private System.Windows.Forms.Button btnBatalUser;
        private System.Windows.Forms.Panel panelUserGridCard;
        private System.Windows.Forms.Panel panelUserGridHeader;
        private System.Windows.Forms.Label lblUserGridTitle;
        private System.Windows.Forms.Label lblUserRecordBadge;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Panel panelAudioTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAudio;
        private System.Windows.Forms.Panel cardAudio1;
        private System.Windows.Forms.Label lblAudio1Title;
        private System.Windows.Forms.Label lblAudio1Desc;
        private System.Windows.Forms.Button btnTestLoginSound;
        private System.Windows.Forms.Panel cardAudio2;
        private System.Windows.Forms.Label lblAudio2Title;
        private System.Windows.Forms.Label lblAudio2Desc;
        private System.Windows.Forms.Button btnTestSaveSound;
        private System.Windows.Forms.Panel cardAudio3;
        private System.Windows.Forms.Label lblAudio3Title;
        private System.Windows.Forms.Label lblAudio3Desc;
        private System.Windows.Forms.Button btnTestAlertSound;
        private System.Windows.Forms.Panel panelSystemTab;
        private System.Windows.Forms.Panel cardSystemMain;
        private System.Windows.Forms.Label lblSystemHeader;
        private System.Windows.Forms.Label lblSystemSub;
        private System.Windows.Forms.TableLayoutPanel panelSysCards;
        private System.Windows.Forms.Panel cardSys1;
        private System.Windows.Forms.Label lblSys1Title;
        private System.Windows.Forms.Label lblSys1Val;
        private System.Windows.Forms.Panel cardSys2;
        private System.Windows.Forms.Label lblSys2Title;
        private System.Windows.Forms.Label lblSys2Val;
        private System.Windows.Forms.Panel cardSys3;
        private System.Windows.Forms.Label lblSys3Title;
        private System.Windows.Forms.Label lblSys3Val;
        private System.Windows.Forms.Panel cardSys4;
        private System.Windows.Forms.Label lblSys4Title;
        private System.Windows.Forms.Label lblSys4Val;
        private System.Windows.Forms.Button btnTestDbConn;
        private System.Windows.Forms.Button btnBackupDatabase;
    }
}
