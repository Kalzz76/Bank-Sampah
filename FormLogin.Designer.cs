using System;
using System.Drawing;
using System.Windows.Forms;

namespace BankSampah
{
    partial class FormLogin
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
            this.panelHero = new System.Windows.Forms.Panel();
            this.panelBins = new System.Windows.Forms.Panel();
            this.bin1 = new System.Windows.Forms.Panel();
            this.bin2 = new System.Windows.Forms.Panel();
            this.bin3 = new System.Windows.Forms.Panel();
            this.lblHeroSubtitle = new System.Windows.Forms.Label();
            this.lblHeroTitle = new System.Windows.Forms.Label();
            this.lblSchoolBranding = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelAudioBox = new System.Windows.Forms.Panel();
            this.btnPlayLoginAudio = new System.Windows.Forms.Button();
            this.lblAudioInfo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFormSubtitle = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblMarkLogo = new System.Windows.Forms.Label();
            this.lblDividerWarga = new System.Windows.Forms.Label();
            this.btnPortalWargaLogin = new System.Windows.Forms.Button();
            this.btnPortalPetugasLogin = new System.Windows.Forms.Button();
            this.panelHero.SuspendLayout();
            this.panelBins.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelAudioBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHero
            // 
            this.panelHero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.panelHero.Controls.Add(this.panelBins);
            this.panelHero.Controls.Add(this.lblHeroSubtitle);
            this.panelHero.Controls.Add(this.lblHeroTitle);
            this.panelHero.Controls.Add(this.lblSchoolBranding);
            this.panelHero.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHero.Location = new System.Drawing.Point(0, 0);
            this.panelHero.Name = "panelHero";
            this.panelHero.Padding = new System.Windows.Forms.Padding(28);
            this.panelHero.Size = new System.Drawing.Size(340, 500);
            this.panelHero.TabIndex = 0;
            // 
            // panelBins
            // 
            this.panelBins.Controls.Add(this.bin3);
            this.panelBins.Controls.Add(this.bin2);
            this.panelBins.Controls.Add(this.bin1);
            this.panelBins.Location = new System.Drawing.Point(120, 40);
            this.panelBins.Name = "panelBins";
            this.panelBins.Size = new System.Drawing.Size(180, 90);
            this.panelBins.TabIndex = 3;
            // 
            // bin1
            // 
            this.bin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(139)))), ((int)(((byte)(103)))));
            this.bin1.Location = new System.Drawing.Point(10, 10);
            this.bin1.Name = "bin1";
            this.bin1.Size = new System.Drawing.Size(46, 75);
            this.bin1.TabIndex = 0;
            // 
            // bin2
            // 
            this.bin2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.bin2.Location = new System.Drawing.Point(68, 10);
            this.bin2.Name = "bin2";
            this.bin2.Size = new System.Drawing.Size(46, 75);
            this.bin2.TabIndex = 1;
            // 
            // bin3
            // 
            this.bin3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(143)))), ((int)(((byte)(176)))));
            this.bin3.Location = new System.Drawing.Point(126, 10);
            this.bin3.Name = "bin3";
            this.bin3.Size = new System.Drawing.Size(46, 75);
            this.bin3.TabIndex = 2;
            // 
            // lblHeroTitle
            // 
            this.lblHeroTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeroTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeroTitle.Location = new System.Drawing.Point(26, 230);
            this.lblHeroTitle.Name = "lblHeroTitle";
            this.lblHeroTitle.Size = new System.Drawing.Size(290, 75);
            this.lblHeroTitle.TabIndex = 0;
            this.lblHeroTitle.Text = "Kelola sampah,\r\nkelola tabungan.";
            // 
            // lblHeroSubtitle
            // 
            this.lblHeroSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeroSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(198)))), ((int)(((byte)(190)))));
            this.lblHeroSubtitle.Location = new System.Drawing.Point(28, 315);
            this.lblHeroSubtitle.Name = "lblHeroSubtitle";
            this.lblHeroSubtitle.Size = new System.Drawing.Size(280, 80);
            this.lblHeroSubtitle.TabIndex = 1;
            this.lblHeroSubtitle.Text = "Setiap kilogram sampah yang disetor nasabah tercatat otomatis dan dikonversi menjadi saldo tabungan.";
            // 
            // lblSchoolBranding
            // 
            this.lblSchoolBranding.AutoSize = true;
            this.lblSchoolBranding.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSchoolBranding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(176)))), ((int)(((byte)(162)))));
            this.lblSchoolBranding.Location = new System.Drawing.Point(28, 455);
            this.lblSchoolBranding.Name = "lblSchoolBranding";
            this.lblSchoolBranding.Size = new System.Drawing.Size(242, 15);
            this.lblSchoolBranding.TabIndex = 2;
            this.lblSchoolBranding.Text = "SMKN 13 Bandung • RPL Proyek Akhir 2026";
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Controls.Add(this.panelAudioBox);
            this.panelForm.Controls.Add(this.btnPortalPetugasLogin);
            this.panelForm.Controls.Add(this.btnPortalWargaLogin);
            this.panelForm.Controls.Add(this.lblDividerWarga);
            this.panelForm.Controls.Add(this.btnExit);
            this.panelForm.Controls.Add(this.btnLogin);
            this.panelForm.Controls.Add(this.txtPassword);
            this.panelForm.Controls.Add(this.lblPassword);
            this.panelForm.Controls.Add(this.txtUsername);
            this.panelForm.Controls.Add(this.lblUsername);
            this.panelForm.Controls.Add(this.lblFormSubtitle);
            this.panelForm.Controls.Add(this.lblFormTitle);
            this.panelForm.Controls.Add(this.lblMarkLogo);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(340, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(44);
            this.panelForm.Size = new System.Drawing.Size(430, 500);
            this.panelForm.TabIndex = 1;
            // 
            // lblMarkLogo
            // 
            this.lblMarkLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.lblMarkLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblMarkLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(26)))), ((int)(((byte)(2)))));
            this.lblMarkLogo.Location = new System.Drawing.Point(44, 40);
            this.lblMarkLogo.Name = "lblMarkLogo";
            this.lblMarkLogo.Size = new System.Drawing.Size(42, 42);
            this.lblMarkLogo.TabIndex = 0;
            this.lblMarkLogo.Text = "♻";
            this.lblMarkLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblFormTitle.Location = new System.Drawing.Point(40, 96);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(199, 31);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "Masuk ke SIMBAS";
            // 
            // lblFormSubtitle
            // 
            this.lblFormSubtitle.AutoSize = true;
            this.lblFormSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFormSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblFormSubtitle.Location = new System.Drawing.Point(42, 130);
            this.lblFormSubtitle.Name = "lblFormSubtitle";
            this.lblFormSubtitle.Size = new System.Drawing.Size(185, 17);
            this.lblFormSubtitle.TabIndex = 2;
            this.lblFormSubtitle.Text = "Khusus pengurus Bank Sampah";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblUsername.Location = new System.Drawing.Point(44, 168);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(64, 15);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(30)))));
            this.txtUsername.Location = new System.Drawing.Point(44, 188);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(340, 26);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Text = "admin";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblPassword.Location = new System.Drawing.Point(44, 230);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 15);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(30)))));
            this.txtPassword.Location = new System.Drawing.Point(44, 250);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(340, 26);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "admin123";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(26)))), ((int)(((byte)(2)))));
            this.btnLogin.Location = new System.Drawing.Point(44, 292);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(220, 36);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(194)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.btnExit.Location = new System.Drawing.Point(274, 292);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 36);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Keluar";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDividerWarga
            // 
            this.lblDividerWarga.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblDividerWarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(176)))), ((int)(((byte)(162)))));
            this.lblDividerWarga.Location = new System.Drawing.Point(44, 338);
            this.lblDividerWarga.Name = "lblDividerWarga";
            this.lblDividerWarga.Size = new System.Drawing.Size(340, 16);
            this.lblDividerWarga.TabIndex = 9;
            this.lblDividerWarga.Text = "── AKSES CEPAT PORTAL KHUSUS ──";
            this.lblDividerWarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPortalWargaLogin
            // 
            this.btnPortalWargaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.btnPortalWargaLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPortalWargaLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(122)))), ((int)(((byte)(94)))));
            this.btnPortalWargaLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPortalWargaLogin.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnPortalWargaLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.btnPortalWargaLogin.Location = new System.Drawing.Point(44, 358);
            this.btnPortalWargaLogin.Name = "btnPortalWargaLogin";
            this.btnPortalWargaLogin.Size = new System.Drawing.Size(165, 36);
            this.btnPortalWargaLogin.TabIndex = 10;
            this.btnPortalWargaLogin.Text = "★ Portal Warga";
            this.btnPortalWargaLogin.UseVisualStyleBackColor = false;
            this.btnPortalWargaLogin.Click += new System.EventHandler(this.btnPortalWargaLogin_Click);
            // 
            // btnPortalPetugasLogin
            // 
            this.btnPortalPetugasLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(230)))));
            this.btnPortalPetugasLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPortalPetugasLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.btnPortalPetugasLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPortalPetugasLogin.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnPortalPetugasLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(26)))), ((int)(((byte)(2)))));
            this.btnPortalPetugasLogin.Location = new System.Drawing.Point(219, 358);
            this.btnPortalPetugasLogin.Name = "btnPortalPetugasLogin";
            this.btnPortalPetugasLogin.Size = new System.Drawing.Size(165, 36);
            this.btnPortalPetugasLogin.TabIndex = 12;
            this.btnPortalPetugasLogin.Text = "★ Portal Petugas";
            this.btnPortalPetugasLogin.UseVisualStyleBackColor = false;
            this.btnPortalPetugasLogin.Click += new System.EventHandler(this.btnPortalPetugasLogin_Click);
            // 
            // panelAudioBox
            // 
            this.panelAudioBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.panelAudioBox.Controls.Add(this.lblAudioInfo);
            this.panelAudioBox.Controls.Add(this.btnPlayLoginAudio);
            this.panelAudioBox.Location = new System.Drawing.Point(44, 410);
            this.panelAudioBox.Name = "panelAudioBox";
            this.panelAudioBox.Padding = new System.Windows.Forms.Padding(8);
            this.panelAudioBox.Size = new System.Drawing.Size(340, 48);
            this.panelAudioBox.TabIndex = 11;
            // 
            // btnPlayLoginAudio
            // 
            this.btnPlayLoginAudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.btnPlayLoginAudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayLoginAudio.FlatAppearance.BorderSize = 0;
            this.btnPlayLoginAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayLoginAudio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPlayLoginAudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(26)))), ((int)(((byte)(2)))));
            this.btnPlayLoginAudio.Location = new System.Drawing.Point(10, 8);
            this.btnPlayLoginAudio.Name = "btnPlayLoginAudio";
            this.btnPlayLoginAudio.Size = new System.Drawing.Size(32, 32);
            this.btnPlayLoginAudio.TabIndex = 0;
            this.btnPlayLoginAudio.Text = "▶";
            this.btnPlayLoginAudio.UseVisualStyleBackColor = false;
            this.btnPlayLoginAudio.Click += new System.EventHandler(this.btnPlayLoginAudio_Click);
            // 
            // lblAudioInfo
            // 
            this.lblAudioInfo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAudioInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(216)))));
            this.lblAudioInfo.Location = new System.Drawing.Point(50, 7);
            this.lblAudioInfo.Name = "lblAudioInfo";
            this.lblAudioInfo.Size = new System.Drawing.Size(280, 34);
            this.lblAudioInfo.TabIndex = 1;
            this.lblAudioInfo.Text = "Suara notifikasi login berhasil\r\nAudio • SoundPlayer";
            this.lblAudioInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(770, 500);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelHero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIMBAS — Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelHero.ResumeLayout(false);
            this.panelHero.PerformLayout();
            this.panelBins.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelAudioBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHero;
        private System.Windows.Forms.Panel panelBins;
        private System.Windows.Forms.Panel bin1;
        private System.Windows.Forms.Panel bin2;
        private System.Windows.Forms.Panel bin3;
        private System.Windows.Forms.Label lblHeroSubtitle;
        private System.Windows.Forms.Label lblHeroTitle;
        private System.Windows.Forms.Label lblSchoolBranding;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblMarkLogo;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFormSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelAudioBox;
        private System.Windows.Forms.Button btnPlayLoginAudio;
        private System.Windows.Forms.Label lblAudioInfo;
        private System.Windows.Forms.Label lblDividerWarga;
        private System.Windows.Forms.Button btnPortalWargaLogin;
        private System.Windows.Forms.Button btnPortalPetugasLogin;
    }
}
