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
            this.lblSchoolBranding = new System.Windows.Forms.Label();
            this.lblFeature3 = new System.Windows.Forms.Label();
            this.lblFeature2 = new System.Windows.Forms.Label();
            this.lblFeature1 = new System.Windows.Forms.Label();
            this.lblHeroSubtitle = new System.Windows.Forms.Label();
            this.lblHeroTitle = new System.Windows.Forms.Label();
            this.lblHeroLogo = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFormSubtitle = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.panelHero.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHero
            // 
            this.panelHero.BackColor = Color.FromArgb(6, 78, 59);
            this.panelHero.Controls.Add(this.lblSchoolBranding);
            this.panelHero.Controls.Add(this.lblFeature3);
            this.panelHero.Controls.Add(this.lblFeature2);
            this.panelHero.Controls.Add(this.lblFeature1);
            this.panelHero.Controls.Add(this.lblHeroSubtitle);
            this.panelHero.Controls.Add(this.lblHeroTitle);
            this.panelHero.Controls.Add(this.lblHeroLogo);
            this.panelHero.Dock = DockStyle.Left;
            this.panelHero.Location = new Point(0, 0);
            this.panelHero.Name = "panelHero";
            this.panelHero.Size = new Size(330, 480);
            this.panelHero.TabIndex = 0;
            // 
            // lblSchoolBranding
            // 
            this.lblSchoolBranding.AutoSize = true;
            this.lblSchoolBranding.Font = new Font("Segoe UI", 8.5F);
            this.lblSchoolBranding.ForeColor = Color.FromArgb(167, 243, 208);
            this.lblSchoolBranding.Location = new Point(30, 435);
            this.lblSchoolBranding.Name = "lblSchoolBranding";
            this.lblSchoolBranding.Size = new Size(244, 15);
            this.lblSchoolBranding.TabIndex = 6;
            this.lblSchoolBranding.Text = "SMKN 13 Bandung • RPL Proyek Akhir 2026";
            // 
            // lblFeature3
            // 
            this.lblFeature3.AutoSize = true;
            this.lblFeature3.Font = new Font("Segoe UI", 9.5F);
            this.lblFeature3.ForeColor = Color.FromArgb(209, 250, 229);
            this.lblFeature3.Location = new Point(30, 320);
            this.lblFeature3.Name = "lblFeature3";
            this.lblFeature3.Size = new Size(213, 17);
            this.lblFeature3.TabIndex = 5;
            this.lblFeature3.Text = "✓ Otentikasi Hak Akses Role User";
            // 
            // lblFeature2
            // 
            this.lblFeature2.AutoSize = true;
            this.lblFeature2.Font = new Font("Segoe UI", 9.5F);
            this.lblFeature2.ForeColor = Color.FromArgb(209, 250, 229);
            this.lblFeature2.Location = new Point(30, 285);
            this.lblFeature2.Name = "lblFeature2";
            this.lblFeature2.Size = new Size(230, 17);
            this.lblFeature2.TabIndex = 4;
            this.lblFeature2.Text = "✓ Visualisasi Grafik & Sound Notification";
            // 
            // lblFeature1
            // 
            this.lblFeature1.AutoSize = true;
            this.lblFeature1.Font = new Font("Segoe UI", 9.5F);
            this.lblFeature1.ForeColor = Color.FromArgb(209, 250, 229);
            this.lblFeature1.Location = new Point(30, 250);
            this.lblFeature1.Name = "lblFeature1";
            this.lblFeature1.Size = new Size(224, 17);
            this.lblFeature1.TabIndex = 3;
            this.lblFeature1.Text = "✓ Pencatatan Setor & Tarik Real-time";
            // 
            // lblHeroSubtitle
            // 
            this.lblHeroSubtitle.Font = new Font("Segoe UI", 9.5F);
            this.lblHeroSubtitle.ForeColor = Color.FromArgb(167, 243, 208);
            this.lblHeroSubtitle.Location = new Point(30, 175);
            this.lblHeroSubtitle.Name = "lblHeroSubtitle";
            this.lblHeroSubtitle.Size = new Size(270, 45);
            this.lblHeroSubtitle.TabIndex = 2;
            this.lblHeroSubtitle.Text = "Sistem Pengelolaan Sampah & Tabungan Warga Berbasis Multimedia";
            // 
            // lblHeroTitle
            // 
            this.lblHeroTitle.AutoSize = true;
            this.lblHeroTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblHeroTitle.ForeColor = Color.White;
            this.lblHeroTitle.Location = new Point(28, 140);
            this.lblHeroTitle.Name = "lblHeroTitle";
            this.lblHeroTitle.Size = new Size(250, 30);
            this.lblHeroTitle.TabIndex = 1;
            this.lblHeroTitle.Text = "BANK SAMPAH DIGITAL";
            // 
            // lblHeroLogo
            // 
            this.lblHeroLogo.AutoSize = true;
            this.lblHeroLogo.Font = new Font("Segoe UI", 48F);
            this.lblHeroLogo.Location = new Point(20, 35);
            this.lblHeroLogo.Name = "lblHeroLogo";
            this.lblHeroLogo.Size = new Size(111, 86);
            this.lblHeroLogo.TabIndex = 0;
            this.lblHeroLogo.Text = "🌿";
            // 
            // panelForm
            // 
            this.panelForm.BackColor = Color.White;
            this.panelForm.Controls.Add(this.btnExit);
            this.panelForm.Controls.Add(this.lblInfo);
            this.panelForm.Controls.Add(this.btnLogin);
            this.panelForm.Controls.Add(this.txtPassword);
            this.panelForm.Controls.Add(this.lblPassword);
            this.panelForm.Controls.Add(this.txtUsername);
            this.panelForm.Controls.Add(this.lblUsername);
            this.panelForm.Controls.Add(this.lblFormSubtitle);
            this.panelForm.Controls.Add(this.lblFormTitle);
            this.panelForm.Dock = DockStyle.Fill;
            this.panelForm.Location = new Point(330, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new Padding(40);
            this.panelForm.Size = new Size(420, 480);
            this.panelForm.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = Color.Transparent;
            this.btnExit.Cursor = Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = FlatStyle.Flat;
            this.btnExit.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnExit.ForeColor = Color.FromArgb(225, 29, 72);
            this.btnExit.Location = new Point(40, 422);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(340, 32);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "🚪 KELUAR DARI APLIKASI";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new EventHandler(this.btnExit_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            this.lblInfo.ForeColor = Color.FromArgb(100, 116, 139);
            this.lblInfo.Location = new Point(40, 385);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new Size(310, 15);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Akun Default: admin / admin123  atau  petugas / petugas123";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = Color.FromArgb(16, 185, 129);
            this.btnLogin.Cursor = Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            this.btnLogin.ForeColor = Color.White;
            this.btnLogin.Location = new Point(40, 322);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new Size(340, 48);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "🔓 MASUK KE SISTEM";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new Font("Segoe UI", 11F);
            this.txtPassword.Location = new Point(40, 255);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new Size(340, 27);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "admin123";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblPassword.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblPassword.Location = new Point(37, 232);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(81, 17);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "🔑 Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new Font("Segoe UI", 11F);
            this.txtUsername.Location = new Point(40, 180);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new Size(340, 27);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "admin";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblUsername.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblUsername.Location = new Point(37, 157);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new Size(84, 17);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "👤 Username";
            // 
            // lblFormSubtitle
            // 
            this.lblFormSubtitle.AutoSize = true;
            this.lblFormSubtitle.Font = new Font("Segoe UI", 9.5F);
            this.lblFormSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            this.lblFormSubtitle.Location = new Point(37, 95);
            this.lblFormSubtitle.Name = "lblFormSubtitle";
            this.lblFormSubtitle.Size = new Size(234, 17);
            this.lblFormSubtitle.TabIndex = 1;
            this.lblFormSubtitle.Text = "Silakan masukkan akun kredensial Anda";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblFormTitle.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblFormTitle.Location = new Point(35, 55);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new Size(213, 32);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Selamat Datang! 👋";
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(750, 480);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelHero);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Login - Bank Sampah Digital SMKN 13 Bandung";
            this.panelHero.ResumeLayout(false);
            this.panelHero.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHero;
        private System.Windows.Forms.Label lblHeroLogo;
        private System.Windows.Forms.Label lblHeroTitle;
        private System.Windows.Forms.Label lblHeroSubtitle;
        private System.Windows.Forms.Label lblFeature1;
        private System.Windows.Forms.Label lblFeature2;
        private System.Windows.Forms.Label lblFeature3;
        private System.Windows.Forms.Label lblSchoolBranding;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFormSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnExit;
    }
}
