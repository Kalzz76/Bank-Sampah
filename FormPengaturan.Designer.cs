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
            this.panelNavSegment = new System.Windows.Forms.Panel();
            this.btnTabSystem = new System.Windows.Forms.Button();
            this.btnTabAudio = new System.Windows.Forms.Button();
            this.btnTabUser = new System.Windows.Forms.Button();
            this.panelContentArea = new System.Windows.Forms.Panel();
            
            // USER TAB COMPONENTS
            this.panelUserTab = new System.Windows.Forms.TableLayoutPanel();
            this.panelUserFormCard = new System.Windows.Forms.Panel();
            this.lblUserFormHeader = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.panelUserButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSimpanUser = new System.Windows.Forms.Button();
            this.btnHapusUser = new System.Windows.Forms.Button();
            this.btnBatalUser = new System.Windows.Forms.Button();
            this.panelUserGridCard = new System.Windows.Forms.Panel();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.panelUserSearchBox = new System.Windows.Forms.Panel();
            this.lblUserRecordBadge = new System.Windows.Forms.Label();
            this.lblUserGridTitle = new System.Windows.Forms.Label();

            // AUDIO TAB COMPONENTS
            this.panelAudioTab = new System.Windows.Forms.TableLayoutPanel();
            this.cardAudio1 = new System.Windows.Forms.Panel();
            this.lblAudio1Title = new System.Windows.Forms.Label();
            this.lblAudio1Desc = new System.Windows.Forms.Label();
            this.btnTestLoginSound = new System.Windows.Forms.Button();
            this.cardAudio2 = new System.Windows.Forms.Panel();
            this.lblAudio2Title = new System.Windows.Forms.Label();
            this.lblAudio2Desc = new System.Windows.Forms.Label();
            this.btnTestSaveSound = new System.Windows.Forms.Button();
            this.cardAudio3 = new System.Windows.Forms.Panel();
            this.lblAudio3Title = new System.Windows.Forms.Label();
            this.lblAudio3Desc = new System.Windows.Forms.Label();
            this.btnTestAlertSound = new System.Windows.Forms.Button();

            // SYSTEM TAB COMPONENTS
            this.panelSystemTab = new System.Windows.Forms.Panel();
            this.cardSystemMain = new System.Windows.Forms.Panel();
            this.lblSystemHeader = new System.Windows.Forms.Label();
            this.lblSystemSub = new System.Windows.Forms.Label();
            this.panelSysCards = new System.Windows.Forms.TableLayoutPanel();
            this.cardSys1 = new System.Windows.Forms.Panel();
            this.lblSys1Val = new System.Windows.Forms.Label();
            this.lblSys1Title = new System.Windows.Forms.Label();
            this.cardSys2 = new System.Windows.Forms.Panel();
            this.lblSys2Val = new System.Windows.Forms.Label();
            this.lblSys2Title = new System.Windows.Forms.Label();
            this.cardSys3 = new System.Windows.Forms.Panel();
            this.lblSys3Val = new System.Windows.Forms.Label();
            this.lblSys3Title = new System.Windows.Forms.Label();
            this.cardSys4 = new System.Windows.Forms.Panel();
            this.lblSys4Val = new System.Windows.Forms.Label();
            this.lblSys4Title = new System.Windows.Forms.Label();
            this.btnTestDbConn = new System.Windows.Forms.Button();
            this.lblSchoolBrand = new System.Windows.Forms.Label();

            this.panelNavSegment.SuspendLayout();
            this.panelContentArea.SuspendLayout();
            this.panelUserTab.SuspendLayout();
            this.panelUserFormCard.SuspendLayout();
            this.panelUserButtons.SuspendLayout();
            this.panelUserGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.panelUserSearchBox.SuspendLayout();
            this.panelAudioTab.SuspendLayout();
            this.cardAudio1.SuspendLayout();
            this.cardAudio2.SuspendLayout();
            this.cardAudio3.SuspendLayout();
            this.panelSystemTab.SuspendLayout();
            this.cardSystemMain.SuspendLayout();
            this.panelSysCards.SuspendLayout();
            this.cardSys1.SuspendLayout();
            this.cardSys2.SuspendLayout();
            this.cardSys3.SuspendLayout();
            this.cardSys4.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelNavSegment
            // 
            this.panelNavSegment.BackColor = Color.White;
            this.panelNavSegment.Controls.Add(this.btnTabSystem);
            this.panelNavSegment.Controls.Add(this.btnTabAudio);
            this.panelNavSegment.Controls.Add(this.btnTabUser);
            this.panelNavSegment.Dock = DockStyle.Top;
            this.panelNavSegment.Location = new Point(0, 0);
            this.panelNavSegment.Name = "panelNavSegment";
            this.panelNavSegment.Padding = new Padding(20, 10, 20, 10);
            this.panelNavSegment.Size = new Size(960, 58);
            this.panelNavSegment.TabIndex = 0;
            // 
            // btnTabUser
            // 
            this.btnTabUser.BackColor = Color.FromArgb(6, 78, 59);
            this.btnTabUser.Cursor = Cursors.Hand;
            this.btnTabUser.Dock = DockStyle.Left;
            this.btnTabUser.FlatAppearance.BorderSize = 0;
            this.btnTabUser.FlatStyle = FlatStyle.Flat;
            this.btnTabUser.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnTabUser.ForeColor = Color.White;
            this.btnTabUser.Location = new Point(20, 10);
            this.btnTabUser.Margin = new Padding(0, 0, 10, 0);
            this.btnTabUser.Name = "btnTabUser";
            this.btnTabUser.Size = new Size(230, 38);
            this.btnTabUser.TabIndex = 0;
            this.btnTabUser.Text = "👤 Kelola User & Hak Akses";
            this.btnTabUser.UseVisualStyleBackColor = false;
            this.btnTabUser.Click += new EventHandler(this.btnTabUser_Click);
            // 
            // btnTabAudio
            // 
            this.btnTabAudio.BackColor = Color.FromArgb(240, 244, 242);
            this.btnTabAudio.Cursor = Cursors.Hand;
            this.btnTabAudio.Dock = DockStyle.Left;
            this.btnTabAudio.FlatAppearance.BorderSize = 0;
            this.btnTabAudio.FlatStyle = FlatStyle.Flat;
            this.btnTabAudio.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnTabAudio.ForeColor = Color.FromArgb(71, 85, 105);
            this.btnTabAudio.Location = new Point(260, 10);
            this.btnTabAudio.Margin = new Padding(10, 0, 10, 0);
            this.btnTabAudio.Name = "btnTabAudio";
            this.btnTabAudio.Size = new Size(210, 38);
            this.btnTabAudio.TabIndex = 1;
            this.btnTabAudio.Text = "🔊 Efek Suara (Audio)";
            this.btnTabAudio.UseVisualStyleBackColor = false;
            this.btnTabAudio.Click += new EventHandler(this.btnTabAudio_Click);
            // 
            // btnTabSystem
            // 
            this.btnTabSystem.BackColor = Color.FromArgb(240, 244, 242);
            this.btnTabSystem.Cursor = Cursors.Hand;
            this.btnTabSystem.Dock = DockStyle.Left;
            this.btnTabSystem.FlatAppearance.BorderSize = 0;
            this.btnTabSystem.FlatStyle = FlatStyle.Flat;
            this.btnTabSystem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnTabSystem.ForeColor = Color.FromArgb(71, 85, 105);
            this.btnTabSystem.Location = new Point(480, 10);
            this.btnTabSystem.Margin = new Padding(10, 0, 0, 0);
            this.btnTabSystem.Name = "btnTabSystem";
            this.btnTabSystem.Size = new Size(230, 38);
            this.btnTabSystem.TabIndex = 2;
            this.btnTabSystem.Text = "🖥️ Info Sistem & Database";
            this.btnTabSystem.UseVisualStyleBackColor = false;
            this.btnTabSystem.Click += new EventHandler(this.btnTabSystem_Click);
            // 
            // panelContentArea
            // 
            this.panelContentArea.BackColor = Color.FromArgb(240, 244, 242);
            this.panelContentArea.Controls.Add(this.panelUserTab);
            this.panelContentArea.Controls.Add(this.panelAudioTab);
            this.panelContentArea.Controls.Add(this.panelSystemTab);
            this.panelContentArea.Dock = DockStyle.Fill;
            this.panelContentArea.Location = new Point(0, 58);
            this.panelContentArea.Name = "panelContentArea";
            this.panelContentArea.Padding = new Padding(20);
            this.panelContentArea.Size = new Size(960, 597);
            this.panelContentArea.TabIndex = 1;
            // 
            // panelUserTab
            // 
            this.panelUserTab.ColumnCount = 2;
            this.panelUserTab.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 340F));
            this.panelUserTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.panelUserTab.Controls.Add(this.panelUserFormCard, 0, 0);
            this.panelUserTab.Controls.Add(this.panelUserGridCard, 1, 0);
            this.panelUserTab.Dock = DockStyle.Fill;
            this.panelUserTab.Location = new Point(20, 20);
            this.panelUserTab.Name = "panelUserTab";
            this.panelUserTab.RowCount = 1;
            this.panelUserTab.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.panelUserTab.Size = new Size(920, 557);
            this.panelUserTab.TabIndex = 0;
            // 
            // panelUserFormCard
            // 
            this.panelUserFormCard.BackColor = Color.White;
            this.panelUserFormCard.Controls.Add(this.lblUserFormHeader);
            this.panelUserFormCard.Controls.Add(this.lblUsername);
            this.panelUserFormCard.Controls.Add(this.txtUsername);
            this.panelUserFormCard.Controls.Add(this.lblPassword);
            this.panelUserFormCard.Controls.Add(this.txtPassword);
            this.panelUserFormCard.Controls.Add(this.lblNama);
            this.panelUserFormCard.Controls.Add(this.txtNama);
            this.panelUserFormCard.Controls.Add(this.lblRole);
            this.panelUserFormCard.Controls.Add(this.cmbRole);
            this.panelUserFormCard.Controls.Add(this.panelUserButtons);
            this.panelUserFormCard.Dock = DockStyle.Fill;
            this.panelUserFormCard.Location = new Point(0, 0);
            this.panelUserFormCard.Margin = new Padding(0, 0, 15, 0);
            this.panelUserFormCard.Name = "panelUserFormCard";
            this.panelUserFormCard.Padding = new Padding(20);
            this.panelUserFormCard.Size = new Size(325, 557);
            this.panelUserFormCard.TabIndex = 0;
            // 
            // lblUserFormHeader
            // 
            this.lblUserFormHeader.AutoSize = true;
            this.lblUserFormHeader.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            this.lblUserFormHeader.ForeColor = Color.FromArgb(6, 78, 59);
            this.lblUserFormHeader.Location = new Point(15, 15);
            this.lblUserFormHeader.Name = "lblUserFormHeader";
            this.lblUserFormHeader.Size = new Size(191, 21);
            this.lblUserFormHeader.TabIndex = 0;
            this.lblUserFormHeader.Text = "📝 Form User & Hak Akses";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblUsername.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblUsername.Location = new Point(15, 52);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new Size(76, 15);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "👤 Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new Font("Segoe UI", 10F);
            this.txtUsername.Location = new Point(15, 72);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new Size(290, 25);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblPassword.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblPassword.Location = new Point(15, 110);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(73, 15);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "🔑 Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new Font("Segoe UI", 10F);
            this.txtPassword.Location = new Point(15, 130);
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
            this.lblNama.Location = new Point(15, 168);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new Size(102, 15);
            this.lblNama.TabIndex = 5;
            this.lblNama.Text = "📝 Nama Lengkap";
            // 
            // txtNama
            // 
            this.txtNama.Font = new Font("Segoe UI", 10F);
            this.txtNama.Location = new Point(15, 188);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new Size(290, 25);
            this.txtNama.TabIndex = 6;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblRole.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblRole.Location = new Point(15, 226);
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
            this.cmbRole.Location = new Point(15, 246);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new Size(290, 25);
            this.cmbRole.TabIndex = 8;
            // 
            // panelUserButtons
            // 
            this.panelUserButtons.ColumnCount = 2;
            this.panelUserButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.panelUserButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.panelUserButtons.Controls.Add(this.btnSimpanUser, 0, 0);
            this.panelUserButtons.Controls.SetChildIndex(this.btnSimpanUser, 0);
            this.panelUserButtons.Controls.Add(this.btnHapusUser, 0, 1);
            this.panelUserButtons.Controls.Add(this.btnBatalUser, 1, 1);
            this.panelUserButtons.Location = new Point(15, 295);
            this.panelUserButtons.Name = "panelUserButtons";
            this.panelUserButtons.RowCount = 2;
            this.panelUserButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.panelUserButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.panelUserButtons.Size = new Size(290, 95);
            this.panelUserButtons.TabIndex = 9;
            // 
            // btnSimpanUser
            // 
            this.btnSimpanUser.BackColor = Color.FromArgb(16, 185, 129);
            this.panelUserButtons.SetColumnSpan(this.btnSimpanUser, 2);
            this.btnSimpanUser.Cursor = Cursors.Hand;
            this.btnSimpanUser.Dock = DockStyle.Fill;
            this.btnSimpanUser.FlatAppearance.BorderSize = 0;
            this.btnSimpanUser.FlatStyle = FlatStyle.Flat;
            this.btnSimpanUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnSimpanUser.ForeColor = Color.White;
            this.btnSimpanUser.Location = new Point(3, 3);
            this.btnSimpanUser.Name = "btnSimpanUser";
            this.btnSimpanUser.Size = new Size(284, 41);
            this.btnSimpanUser.TabIndex = 0;
            this.btnSimpanUser.Text = "💾 TAMBAH USER BARU";
            this.btnSimpanUser.UseVisualStyleBackColor = false;
            this.btnSimpanUser.Click += new EventHandler(this.btnSimpanUser_Click);
            // 
            // btnHapusUser
            // 
            this.btnHapusUser.BackColor = Color.FromArgb(225, 29, 72);
            this.btnHapusUser.Cursor = Cursors.Hand;
            this.btnHapusUser.Dock = DockStyle.Fill;
            this.btnHapusUser.FlatAppearance.BorderSize = 0;
            this.btnHapusUser.FlatStyle = FlatStyle.Flat;
            this.btnHapusUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnHapusUser.ForeColor = Color.White;
            this.btnHapusUser.Location = new Point(3, 50);
            this.btnHapusUser.Name = "btnHapusUser";
            this.btnHapusUser.Size = new Size(139, 42);
            this.btnHapusUser.TabIndex = 1;
            this.btnHapusUser.Text = "🗑️ HAPUS";
            this.btnHapusUser.UseVisualStyleBackColor = false;
            this.btnHapusUser.Click += new EventHandler(this.btnHapusUser_Click);
            // 
            // btnBatalUser
            // 
            this.btnBatalUser.BackColor = Color.FromArgb(100, 116, 139);
            this.btnBatalUser.Cursor = Cursors.Hand;
            this.btnBatalUser.Dock = DockStyle.Fill;
            this.btnBatalUser.FlatAppearance.BorderSize = 0;
            this.btnBatalUser.FlatStyle = FlatStyle.Flat;
            this.btnBatalUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnBatalUser.ForeColor = Color.White;
            this.btnBatalUser.Location = new Point(148, 50);
            this.btnBatalUser.Name = "btnBatalUser";
            this.btnBatalUser.Size = new Size(139, 42);
            this.btnBatalUser.TabIndex = 2;
            this.btnBatalUser.Text = "🔄 BATAL";
            this.btnBatalUser.UseVisualStyleBackColor = false;
            this.btnBatalUser.Click += new EventHandler(this.btnBatalUser_Click);
            // 
            // panelUserGridCard
            // 
            this.panelUserGridCard.BackColor = Color.White;
            this.panelUserGridCard.Controls.Add(this.dgvUser);
            this.panelUserGridCard.Controls.Add(this.panelUserSearchBox);
            this.panelUserGridCard.Dock = DockStyle.Fill;
            this.panelUserGridCard.Location = new Point(340, 0);
            this.panelUserGridCard.Margin = new Padding(0);
            this.panelUserGridCard.Name = "panelUserGridCard";
            this.panelUserGridCard.Padding = new Padding(15);
            this.panelUserGridCard.Size = new Size(580, 557);
            this.panelUserGridCard.TabIndex = 1;
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
            this.dgvUser.Size = new Size(550, 482);
            this.dgvUser.TabIndex = 1;
            this.dgvUser.CellClick += new DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // panelUserSearchBox
            // 
            this.panelUserSearchBox.BackColor = Color.FromArgb(240, 244, 242);
            this.panelUserSearchBox.Controls.Add(this.lblUserRecordBadge);
            this.panelUserSearchBox.Controls.Add(this.lblUserGridTitle);
            this.panelUserSearchBox.Dock = DockStyle.Top;
            this.panelUserSearchBox.Location = new Point(15, 15);
            this.panelUserSearchBox.Name = "panelUserSearchBox";
            this.panelUserSearchBox.Padding = new Padding(10, 8, 10, 8);
            this.panelUserSearchBox.Size = new Size(550, 45);
            this.panelUserSearchBox.TabIndex = 0;
            // 
            // lblUserRecordBadge
            // 
            this.lblUserRecordBadge.Dock = DockStyle.Right;
            this.lblUserRecordBadge.AutoSize = true;
            this.lblUserRecordBadge.BackColor = Color.FromArgb(16, 185, 129);
            this.lblUserRecordBadge.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            this.lblUserRecordBadge.ForeColor = Color.White;
            this.lblUserRecordBadge.Location = new Point(390, 8);
            this.lblUserRecordBadge.Padding = new Padding(8, 4, 8, 4);
            this.lblUserRecordBadge.Name = "lblUserRecordBadge";
            this.lblUserRecordBadge.Size = new Size(150, 23);
            this.lblUserRecordBadge.TabIndex = 1;
            this.lblUserRecordBadge.Text = "📌 TOTAL: 0 USER";
            // 
            // lblUserGridTitle
            // 
            this.lblUserGridTitle.AutoSize = true;
            this.lblUserGridTitle.Dock = DockStyle.Left;
            this.lblUserGridTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblUserGridTitle.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblUserGridTitle.Location = new Point(10, 8);
            this.lblUserGridTitle.Name = "lblUserGridTitle";
            this.lblUserGridTitle.Size = new Size(205, 19);
            this.lblUserGridTitle.TabIndex = 0;
            this.lblUserGridTitle.Text = "📋 Daftar User Petugas Sistem";
            // 
            // panelAudioTab
            // 
            this.panelAudioTab.ColumnCount = 3;
            this.panelAudioTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            this.panelAudioTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            this.panelAudioTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            this.panelAudioTab.Controls.Add(this.cardAudio1, 0, 0);
            this.panelAudioTab.Controls.Add(this.cardAudio2, 1, 0);
            this.panelAudioTab.Controls.Add(this.cardAudio3, 2, 0);
            this.panelAudioTab.Dock = DockStyle.Fill;
            this.panelAudioTab.Location = new Point(20, 20);
            this.panelAudioTab.Name = "panelAudioTab";
            this.panelAudioTab.RowCount = 1;
            this.panelAudioTab.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.panelAudioTab.Size = new Size(920, 557);
            this.panelAudioTab.TabIndex = 1;
            this.panelAudioTab.Visible = false;
            // 
            // cardAudio1
            // 
            this.cardAudio1.BackColor = Color.White;
            this.cardAudio1.Controls.Add(this.btnTestLoginSound);
            this.cardAudio1.Controls.Add(this.lblAudio1Desc);
            this.cardAudio1.Controls.Add(this.lblAudio1Title);
            this.cardAudio1.Dock = DockStyle.Top;
            this.cardAudio1.Location = new Point(0, 0);
            this.cardAudio1.Margin = new Padding(0, 0, 15, 0);
            this.cardAudio1.Name = "cardAudio1";
            this.cardAudio1.Padding = new Padding(20);
            this.cardAudio1.Size = new Size(291, 260);
            this.cardAudio1.TabIndex = 0;
            // 
            // lblAudio1Title
            // 
            this.lblAudio1Title.AutoSize = true;
            this.lblAudio1Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblAudio1Title.ForeColor = Color.FromArgb(6, 78, 59);
            this.lblAudio1Title.Location = new Point(20, 20);
            this.lblAudio1Title.Name = "lblAudio1Title";
            this.lblAudio1Title.Size = new Size(184, 20);
            this.lblAudio1Title.TabIndex = 0;
            this.lblAudio1Title.Text = "🎵 Suara Login Success";
            // 
            // lblAudio1Desc
            // 
            this.lblAudio1Desc.Font = new Font("Segoe UI", 9F);
            this.lblAudio1Desc.ForeColor = Color.FromArgb(71, 85, 105);
            this.lblAudio1Desc.Location = new Point(20, 55);
            this.lblAudio1Desc.Name = "lblAudio1Desc";
            this.lblAudio1Desc.Size = new Size(250, 110);
            this.lblAudio1Desc.TabIndex = 1;
            this.lblAudio1Desc.Text = "Efek suara sambutan multimedia saat user berhasil melakukan otentikasi login ke dalam sistem.\r\n\r\nFile: Assets/Audio/login_success.wav";
            // 
            // btnTestLoginSound
            // 
            this.btnTestLoginSound.BackColor = Color.FromArgb(16, 185, 129);
            this.btnTestLoginSound.Cursor = Cursors.Hand;
            this.btnTestLoginSound.Dock = DockStyle.Bottom;
            this.btnTestLoginSound.FlatAppearance.BorderSize = 0;
            this.btnTestLoginSound.FlatStyle = FlatStyle.Flat;
            this.btnTestLoginSound.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnTestLoginSound.ForeColor = Color.White;
            this.btnTestLoginSound.Location = new Point(20, 195);
            this.btnTestLoginSound.Name = "btnTestLoginSound";
            this.btnTestLoginSound.Size = new Size(251, 45);
            this.btnTestLoginSound.TabIndex = 2;
            this.btnTestLoginSound.Text = "▶️ UJI SUARA LOGIN";
            this.btnTestLoginSound.UseVisualStyleBackColor = false;
            this.btnTestLoginSound.Click += new EventHandler(this.btnTestLogin_Click);
            // 
            // cardAudio2
            // 
            this.cardAudio2.BackColor = Color.White;
            this.cardAudio2.Controls.Add(this.btnTestSaveSound);
            this.cardAudio2.Controls.Add(this.lblAudio2Desc);
            this.cardAudio2.Controls.Add(this.lblAudio2Title);
            this.cardAudio2.Dock = DockStyle.Top;
            this.cardAudio2.Location = new Point(306, 0);
            this.cardAudio2.Margin = new Padding(0, 0, 15, 0);
            this.cardAudio2.Name = "cardAudio2";
            this.cardAudio2.Padding = new Padding(20);
            this.cardAudio2.Size = new Size(291, 260);
            this.cardAudio2.TabIndex = 1;
            // 
            // lblAudio2Title
            // 
            this.lblAudio2Title.AutoSize = true;
            this.lblAudio2Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblAudio2Title.ForeColor = Color.FromArgb(37, 99, 235);
            this.lblAudio2Title.Location = new Point(20, 20);
            this.lblAudio2Title.Name = "lblAudio2Title";
            this.lblAudio2Title.Size = new Size(190, 20);
            this.lblAudio2Title.TabIndex = 0;
            this.lblAudio2Title.Text = "💾 Suara Simpan Transaksi";
            // 
            // lblAudio2Desc
            // 
            this.lblAudio2Desc.Font = new Font("Segoe UI", 9F);
            this.lblAudio2Desc.ForeColor = Color.FromArgb(71, 85, 105);
            this.lblAudio2Desc.Location = new Point(20, 55);
            this.lblAudio2Desc.Name = "lblAudio2Desc";
            this.lblAudio2Desc.Size = new Size(250, 110);
            this.lblAudio2Desc.TabIndex = 1;
            this.lblAudio2Desc.Text = "Efek suara konfirmasi transaksi saat petugas berhasil memproses setor sampah / tarik saldo.\r\n\r\nFile: Assets/Audio/save_success.wav";
            // 
            // btnTestSaveSound
            // 
            this.btnTestSaveSound.BackColor = Color.FromArgb(37, 99, 235);
            this.btnTestSaveSound.Cursor = Cursors.Hand;
            this.btnTestSaveSound.Dock = DockStyle.Bottom;
            this.btnTestSaveSound.FlatAppearance.BorderSize = 0;
            this.btnTestSaveSound.FlatStyle = FlatStyle.Flat;
            this.btnTestSaveSound.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnTestSaveSound.ForeColor = Color.White;
            this.btnTestSaveSound.Location = new Point(20, 195);
            this.btnTestSaveSound.Name = "btnTestSaveSound";
            this.btnTestSaveSound.Size = new Size(251, 45);
            this.btnTestSaveSound.TabIndex = 2;
            this.btnTestSaveSound.Text = "▶️ UJI SUARA SIMPAN";
            this.btnTestSaveSound.UseVisualStyleBackColor = false;
            this.btnTestSaveSound.Click += new EventHandler(this.btnTestSave_Click);
            // 
            // cardAudio3
            // 
            this.cardAudio3.BackColor = Color.White;
            this.cardAudio3.Controls.Add(this.btnTestAlertSound);
            this.cardAudio3.Controls.Add(this.lblAudio3Desc);
            this.cardAudio3.Controls.Add(this.lblAudio3Title);
            this.cardAudio3.Dock = DockStyle.Top;
            this.cardAudio3.Location = new Point(612, 0);
            this.cardAudio3.Margin = new Padding(0);
            this.cardAudio3.Name = "cardAudio3";
            this.cardAudio3.Padding = new Padding(20);
            this.cardAudio3.Size = new Size(308, 260);
            this.cardAudio3.TabIndex = 2;
            // 
            // lblAudio3Title
            // 
            this.lblAudio3Title.AutoSize = true;
            this.lblAudio3Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblAudio3Title.ForeColor = Color.FromArgb(225, 29, 72);
            this.lblAudio3Title.Location = new Point(20, 20);
            this.lblAudio3Title.Name = "lblAudio3Title";
            this.lblAudio3Title.Size = new Size(187, 20);
            this.lblAudio3Title.TabIndex = 0;
            this.lblAudio3Title.Text = "🔔 Suara Alert & Peringatan";
            // 
            // lblAudio3Desc
            // 
            this.lblAudio3Desc.Font = new Font("Segoe UI", 9F);
            this.lblAudio3Desc.ForeColor = Color.FromArgb(71, 85, 105);
            this.lblAudio3Desc.Location = new Point(20, 55);
            this.lblAudio3Desc.Name = "lblAudio3Desc";
            this.lblAudio3Desc.Size = new Size(260, 110);
            this.lblAudio3Desc.TabIndex = 1;
            this.lblAudio3Desc.Text = "Efek suara peringatan jika terjadi kesalahan input / saldo tidak mencukupi saat penarikan.\r\n\r\nFile: Assets/Audio/alert.wav";
            // 
            // btnTestAlertSound
            // 
            this.btnTestAlertSound.BackColor = Color.FromArgb(225, 29, 72);
            this.btnTestAlertSound.Cursor = Cursors.Hand;
            this.btnTestAlertSound.Dock = DockStyle.Bottom;
            this.btnTestAlertSound.FlatAppearance.BorderSize = 0;
            this.btnTestAlertSound.FlatStyle = FlatStyle.Flat;
            this.btnTestAlertSound.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnTestAlertSound.ForeColor = Color.White;
            this.btnTestAlertSound.Location = new Point(20, 195);
            this.btnTestAlertSound.Name = "btnTestAlertSound";
            this.btnTestAlertSound.Size = new Size(268, 45);
            this.btnTestAlertSound.TabIndex = 2;
            this.btnTestAlertSound.Text = "▶️ UJI SUARA ALERT";
            this.btnTestAlertSound.UseVisualStyleBackColor = false;
            this.btnTestAlertSound.Click += new EventHandler(this.btnTestAlert_Click);
            // 
            // panelSystemTab
            // 
            this.panelSystemTab.Controls.Add(this.cardSystemMain);
            this.panelSystemTab.Dock = DockStyle.Fill;
            this.panelSystemTab.Location = new Point(20, 20);
            this.panelSystemTab.Name = "panelSystemTab";
            this.panelSystemTab.Size = new Size(920, 557);
            this.panelSystemTab.TabIndex = 2;
            this.panelSystemTab.Visible = false;
            // 
            // cardSystemMain
            // 
            this.cardSystemMain.BackColor = Color.White;
            this.cardSystemMain.Controls.Add(this.lblSchoolBrand);
            this.cardSystemMain.Controls.Add(this.btnTestDbConn);
            this.cardSystemMain.Controls.Add(this.panelSysCards);
            this.cardSystemMain.Controls.Add(this.lblSystemSub);
            this.cardSystemMain.Controls.Add(this.lblSystemHeader);
            this.cardSystemMain.Dock = DockStyle.Top;
            this.cardSystemMain.Location = new Point(0, 0);
            this.cardSystemMain.Name = "cardSystemMain";
            this.cardSystemMain.Padding = new Padding(25);
            this.cardSystemMain.Size = new Size(920, 390);
            this.cardSystemMain.TabIndex = 0;
            // 
            // lblSystemHeader
            // 
            this.lblSystemHeader.AutoSize = true;
            this.lblSystemHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblSystemHeader.ForeColor = Color.FromArgb(6, 78, 59);
            this.lblSystemHeader.Location = new Point(25, 20);
            this.lblSystemHeader.Name = "lblSystemHeader";
            this.lblSystemHeader.Size = new Size(330, 21);
            this.lblSystemHeader.TabIndex = 0;
            this.lblSystemHeader.Text = "🖥️ Status Sistem & Database SQL Server";
            // 
            // lblSystemSub
            // 
            this.lblSystemSub.AutoSize = true;
            this.lblSystemSub.Font = new Font("Segoe UI", 9F);
            this.lblSystemSub.ForeColor = Color.FromArgb(100, 116, 139);
            this.lblSystemSub.Location = new Point(25, 46);
            this.lblSystemSub.Name = "lblSystemSub";
            this.lblSystemSub.Size = new Size(393, 15);
            this.lblSystemSub.TabIndex = 1;
            this.lblSystemSub.Text = "Ringkasan arsitektur infrastruktur database dan platform runtime aplikasi.";
            // 
            // panelSysCards
            // 
            this.panelSysCards.ColumnCount = 4;
            this.panelSysCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.panelSysCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.panelSysCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.panelSysCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.panelSysCards.Controls.Add(this.cardSys4, 3, 0);
            this.panelSysCards.Controls.Add(this.cardSys3, 2, 0);
            this.panelSysCards.Controls.Add(this.cardSys2, 1, 0);
            this.panelSysCards.Controls.Add(this.cardSys1, 0, 0);
            this.panelSysCards.Location = new Point(25, 80);
            this.panelSysCards.Name = "panelSysCards";
            this.panelSysCards.RowCount = 1;
            this.panelSysCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.panelSysCards.Size = new Size(870, 110);
            this.panelSysCards.TabIndex = 2;
            // 
            // cardSys1
            // 
            this.cardSys1.BackColor = Color.FromArgb(236, 253, 245);
            this.cardSys1.Controls.Add(this.lblSys1Val);
            this.cardSys1.Controls.Add(this.lblSys1Title);
            this.cardSys1.Dock = DockStyle.Fill;
            this.cardSys1.Location = new Point(3, 3);
            this.cardSys1.Margin = new Padding(3, 3, 8, 3);
            this.cardSys1.Name = "cardSys1";
            this.cardSys1.Size = new Size(206, 104);
            this.cardSys1.TabIndex = 0;
            // 
            // lblSys1Title
            // 
            this.lblSys1Title.AutoSize = true;
            this.lblSys1Title.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            this.lblSys1Title.ForeColor = Color.FromArgb(6, 78, 59);
            this.lblSys1Title.Location = new Point(15, 18);
            this.lblSys1Title.Name = "lblSys1Title";
            this.lblSys1Title.Size = new Size(111, 15);
            this.lblSys1Title.TabIndex = 0;
            this.lblSys1Title.Text = "STATUS DATABASE";
            // 
            // lblSys1Val
            // 
            this.lblSys1Val.AutoSize = true;
            this.lblSys1Val.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblSys1Val.ForeColor = Color.FromArgb(16, 185, 129);
            this.lblSys1Val.Location = new Point(15, 45);
            this.lblSys1Val.Name = "lblSys1Val";
            this.lblSys1Val.Size = new Size(116, 20);
            this.lblSys1Val.TabIndex = 1;
            this.lblSys1Val.Text = "🟢 CONNECTED";
            // 
            // cardSys2
            // 
            this.cardSys2.BackColor = Color.FromArgb(239, 246, 255);
            this.cardSys2.Controls.Add(this.lblSys2Val);
            this.cardSys2.Controls.Add(this.lblSys2Title);
            this.cardSys2.Dock = DockStyle.Fill;
            this.cardSys2.Location = new Point(220, 3);
            this.cardSys2.Margin = new Padding(3, 3, 8, 3);
            this.cardSys2.Name = "cardSys2";
            this.cardSys2.Size = new Size(206, 104);
            this.cardSys2.TabIndex = 1;
            // 
            // lblSys2Title
            // 
            this.lblSys2Title.AutoSize = true;
            this.lblSys2Title.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            this.lblSys2Title.ForeColor = Color.FromArgb(30, 64, 175);
            this.lblSys2Title.Location = new Point(15, 18);
            this.lblSys2Title.Name = "lblSys2Title";
            this.lblSys2Title.Size = new Size(112, 15);
            this.lblSys2Title.TabIndex = 0;
            this.lblSys2Title.Text = "SQL SERVER ENGINE";
            // 
            // lblSys2Val
            // 
            this.lblSys2Val.AutoSize = true;
            this.lblSys2Val.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblSys2Val.ForeColor = Color.FromArgb(37, 99, 235);
            this.lblSys2Val.Location = new Point(15, 45);
            this.lblSys2Val.Name = "lblSys2Val";
            this.lblSys2Val.Size = new Size(160, 19);
            this.lblSys2Val.TabIndex = 1;
            this.lblSys2Val.Text = "localhost / SQLEXPRESS";
            // 
            // cardSys3
            // 
            this.cardSys3.BackColor = Color.FromArgb(250, 245, 255);
            this.cardSys3.Controls.Add(this.lblSys3Val);
            this.cardSys3.Controls.Add(this.lblSys3Title);
            this.cardSys3.Dock = DockStyle.Fill;
            this.cardSys3.Location = new Point(437, 3);
            this.cardSys3.Margin = new Padding(3, 3, 8, 3);
            this.cardSys3.Name = "cardSys3";
            this.cardSys3.Size = new Size(206, 104);
            this.cardSys3.TabIndex = 2;
            // 
            // lblSys3Title
            // 
            this.lblSys3Title.AutoSize = true;
            this.lblSys3Title.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            this.lblSys3Title.ForeColor = Color.FromArgb(107, 33, 168);
            this.lblSys3Title.Location = new Point(15, 18);
            this.lblSys3Title.Name = "lblSys3Title";
            this.lblSys3Title.Size = new Size(100, 15);
            this.lblSys3Title.TabIndex = 0;
            this.lblSys3Title.Text = "DATABASE NAME";
            // 
            // lblSys3Val
            // 
            this.lblSys3Val.AutoSize = true;
            this.lblSys3Val.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblSys3Val.ForeColor = Color.FromArgb(124, 58, 237);
            this.lblSys3Val.Location = new Point(15, 45);
            this.lblSys3Val.Name = "lblSys3Val";
            this.lblSys3Val.Size = new Size(128, 20);
            this.lblSys3Val.TabIndex = 1;
            this.lblSys3Val.Text = "db_banksampah";
            // 
            // cardSys4
            // 
            this.cardSys4.BackColor = Color.FromArgb(254, 243, 199);
            this.cardSys4.Controls.Add(this.lblSys4Val);
            this.cardSys4.Controls.Add(this.lblSys4Title);
            this.cardSys4.Dock = DockStyle.Fill;
            this.cardSys4.Location = new Point(654, 3);
            this.cardSys4.Margin = new Padding(3);
            this.cardSys4.Name = "cardSys4";
            this.cardSys4.Size = new Size(213, 104);
            this.cardSys4.TabIndex = 3;
            // 
            // lblSys4Title
            // 
            this.lblSys4Title.AutoSize = true;
            this.lblSys4Title.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            this.lblSys4Title.ForeColor = Color.FromArgb(146, 64, 14);
            this.lblSys4Title.Location = new Point(15, 18);
            this.lblSys4Title.Name = "lblSys4Title";
            this.lblSys4Title.Size = new Size(130, 15);
            this.lblSys4Title.TabIndex = 0;
            this.lblSys4Title.Text = "PLATFORM RUNTIME";
            // 
            // lblSys4Val
            // 
            this.lblSys4Val.AutoSize = true;
            this.lblSys4Val.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            this.lblSys4Val.ForeColor = Color.FromArgb(217, 119, 6);
            this.lblSys4Val.Location = new Point(15, 45);
            this.lblSys4Val.Name = "lblSys4Val";
            this.lblSys4Val.Size = new Size(147, 19);
            this.lblSys4Val.TabIndex = 1;
            this.lblSys4Val.Text = ".NET Framework 4.8";
            // 
            // btnTestDbConn
            // 
            this.btnTestDbConn.BackColor = Color.FromArgb(16, 185, 129);
            this.btnTestDbConn.Cursor = Cursors.Hand;
            this.btnTestDbConn.FlatAppearance.BorderSize = 0;
            this.btnTestDbConn.FlatStyle = FlatStyle.Flat;
            this.btnTestDbConn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnTestDbConn.ForeColor = Color.White;
            this.btnTestDbConn.Location = new Point(25, 215);
            this.btnTestDbConn.Name = "btnTestDbConn";
            this.btnTestDbConn.Size = new Size(280, 48);
            this.btnTestDbConn.TabIndex = 3;
            this.btnTestDbConn.Text = "⚡ UJI KONEKSI DATABASE REALTIME";
            this.btnTestDbConn.UseVisualStyleBackColor = false;
            this.btnTestDbConn.Click += new EventHandler(this.btnTestDbConn_Click);
            // 
            // lblSchoolBrand
            // 
            this.lblSchoolBrand.AutoSize = true;
            this.lblSchoolBrand.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            this.lblSchoolBrand.ForeColor = Color.FromArgb(100, 116, 139);
            this.lblSchoolBrand.Location = new Point(25, 285);
            this.lblSchoolBrand.Name = "lblSchoolBrand";
            this.lblSchoolBrand.Size = new Size(540, 17);
            this.lblSchoolBrand.TabIndex = 4;
            this.lblSchoolBrand.Text = "🌿 Bank Sampah Digital SMKN 13 Bandung — Modern Eco-Emerald Edition @Proyek Akhir PBTM";
            // 
            // FormPengaturan
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(240, 244, 242);
            this.ClientSize = new Size(960, 655);
            this.Controls.Add(this.panelContentArea);
            this.Controls.Add(this.panelNavSegment);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "FormPengaturan";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Pengaturan Sistem";
            this.Load += new EventHandler(this.FormPengaturan_Load);
            this.panelNavSegment.ResumeLayout(false);
            this.panelContentArea.ResumeLayout(false);
            this.panelUserTab.ResumeLayout(false);
            this.panelUserFormCard.ResumeLayout(false);
            this.panelUserFormCard.PerformLayout();
            this.panelUserButtons.ResumeLayout(false);
            this.panelUserGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.panelUserSearchBox.ResumeLayout(false);
            this.panelUserSearchBox.PerformLayout();
            this.panelAudioTab.ResumeLayout(false);
            this.cardAudio1.ResumeLayout(false);
            this.cardAudio1.PerformLayout();
            this.cardAudio2.ResumeLayout(false);
            this.cardAudio2.PerformLayout();
            this.cardAudio3.ResumeLayout(false);
            this.cardAudio3.PerformLayout();
            this.panelSystemTab.ResumeLayout(false);
            this.cardSystemMain.ResumeLayout(false);
            this.cardSystemMain.PerformLayout();
            this.panelSysCards.ResumeLayout(false);
            this.cardSys1.ResumeLayout(false);
            this.cardSys1.PerformLayout();
            this.cardSys2.ResumeLayout(false);
            this.cardSys2.PerformLayout();
            this.cardSys3.ResumeLayout(false);
            this.cardSys3.PerformLayout();
            this.cardSys4.ResumeLayout(false);
            this.cardSys4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavSegment;
        private System.Windows.Forms.Button btnTabUser;
        private System.Windows.Forms.Button btnTabAudio;
        private System.Windows.Forms.Button btnTabSystem;
        private System.Windows.Forms.Panel panelContentArea;
        
        // USER
        private System.Windows.Forms.TableLayoutPanel panelUserTab;
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
        private System.Windows.Forms.TableLayoutPanel panelUserButtons;
        private System.Windows.Forms.Button btnSimpanUser;
        private System.Windows.Forms.Button btnHapusUser;
        private System.Windows.Forms.Button btnBatalUser;
        private System.Windows.Forms.Panel panelUserGridCard;
        private System.Windows.Forms.Panel panelUserSearchBox;
        private System.Windows.Forms.Label lblUserGridTitle;
        private System.Windows.Forms.Label lblUserRecordBadge;
        private System.Windows.Forms.DataGridView dgvUser;

        // AUDIO
        private System.Windows.Forms.TableLayoutPanel panelAudioTab;
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

        // SYSTEM
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
        private System.Windows.Forms.Label lblSchoolBrand;
    }
}
