namespace BankSampah
{
    partial class FormRiwayatNasabah
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

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnTutupTop = new System.Windows.Forms.Button();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelCardProfile = new System.Windows.Forms.Panel();
            this.lblMetricSaldo = new System.Windows.Forms.Label();
            this.lblSaldoTitle = new System.Windows.Forms.Label();
            this.lblTotalBerat = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblNoHp = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblKodeBadge = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvRiwayat = new System.Windows.Forms.DataGridView();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblCountTrx = new System.Windows.Forms.Label();
            this.btnCetakBuku = new System.Windows.Forms.Button();
            this.btnTutup = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelCardProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.panelHeader.Controls.Add(this.btnTutupTop);
            this.panelHeader.Controls.Add(this.lblSubTitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(20, 14, 20, 14);
            this.panelHeader.Size = new System.Drawing.Size(780, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // btnTutupTop
            // 
            this.btnTutupTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTutupTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTutupTop.FlatAppearance.BorderSize = 0;
            this.btnTutupTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutupTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTutupTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(216)))));
            this.btnTutupTop.Location = new System.Drawing.Point(734, 16);
            this.btnTutupTop.Name = "btnTutupTop";
            this.btnTutupTop.Size = new System.Drawing.Size(32, 32);
            this.btnTutupTop.TabIndex = 2;
            this.btnTutupTop.Text = "✕";
            this.btnTutupTop.UseVisualStyleBackColor = true;
            this.btnTutupTop.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(198)))), ((int)(((byte)(190)))));
            this.lblSubTitle.Location = new System.Drawing.Point(20, 38);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(347, 15);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Histori transaksi setor sampah & penarikan saldo buku tabungan";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(18, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📜 Riwayat Transaksi Nasabah";
            // 
            // panelCardProfile
            // 
            this.panelCardProfile.BackColor = System.Drawing.Color.White;
            this.panelCardProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCardProfile.Controls.Add(this.lblMetricSaldo);
            this.panelCardProfile.Controls.Add(this.lblSaldoTitle);
            this.panelCardProfile.Controls.Add(this.lblTotalBerat);
            this.panelCardProfile.Controls.Add(this.lblAlamat);
            this.panelCardProfile.Controls.Add(this.lblNoHp);
            this.panelCardProfile.Controls.Add(this.lblNama);
            this.panelCardProfile.Controls.Add(this.lblKodeBadge);
            this.panelCardProfile.Controls.Add(this.picAvatar);
            this.panelCardProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCardProfile.Location = new System.Drawing.Point(0, 70);
            this.panelCardProfile.Name = "panelCardProfile";
            this.panelCardProfile.Padding = new System.Windows.Forms.Padding(16);
            this.panelCardProfile.Size = new System.Drawing.Size(780, 95);
            this.panelCardProfile.TabIndex = 1;
            // 
            // lblMetricSaldo
            // 
            this.lblMetricSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMetricSaldo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblMetricSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(122)))), ((int)(((byte)(94)))));
            this.lblMetricSaldo.Location = new System.Drawing.Point(520, 26);
            this.lblMetricSaldo.Name = "lblMetricSaldo";
            this.lblMetricSaldo.Size = new System.Drawing.Size(240, 30);
            this.lblMetricSaldo.TabIndex = 7;
            this.lblMetricSaldo.Text = "Rp 0";
            this.lblMetricSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSaldoTitle
            // 
            this.lblSaldoTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaldoTitle.AutoSize = true;
            this.lblSaldoTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSaldoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(108)))));
            this.lblSaldoTitle.Location = new System.Drawing.Point(680, 12);
            this.lblSaldoTitle.Name = "lblSaldoTitle";
            this.lblSaldoTitle.Size = new System.Drawing.Size(81, 13);
            this.lblSaldoTitle.TabIndex = 6;
            this.lblSaldoTitle.Text = "SALDO AKTIF";
            this.lblSaldoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalBerat
            // 
            this.lblTotalBerat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalBerat.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTotalBerat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblTotalBerat.Location = new System.Drawing.Point(520, 58);
            this.lblTotalBerat.Name = "lblTotalBerat";
            this.lblTotalBerat.Size = new System.Drawing.Size(240, 20);
            this.lblTotalBerat.TabIndex = 5;
            this.lblTotalBerat.Text = "Total Sampah Disetor: 0.00 kg";
            this.lblTotalBerat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAlamat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblAlamat.Location = new System.Drawing.Point(86, 60);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(51, 15);
            this.lblAlamat.TabIndex = 4;
            this.lblAlamat.Text = "Alamat: -";
            // 
            // lblNoHp
            // 
            this.lblNoHp.AutoSize = true;
            this.lblNoHp.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNoHp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblNoHp.Location = new System.Drawing.Point(86, 38);
            this.lblNoHp.Name = "lblNoHp";
            this.lblNoHp.Size = new System.Drawing.Size(53, 15);
            this.lblNoHp.TabIndex = 3;
            this.lblNoHp.Text = "No. HP: -";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(30)))));
            this.lblNama.Location = new System.Drawing.Point(85, 12);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(127, 21);
            this.lblNama.TabIndex = 2;
            this.lblNama.Text = "Nama Nasabah";
            // 
            // lblKodeBadge
            // 
            this.lblKodeBadge.AutoSize = true;
            this.lblKodeBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(215)))));
            this.lblKodeBadge.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblKodeBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(122)))), ((int)(((byte)(18)))));
            this.lblKodeBadge.Location = new System.Drawing.Point(220, 16);
            this.lblKodeBadge.Name = "lblKodeBadge";
            this.lblKodeBadge.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.lblKodeBadge.Size = new System.Drawing.Size(61, 15);
            this.lblKodeBadge.TabIndex = 1;
            this.lblKodeBadge.Text = "NSB-000";
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(16, 15);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(60, 60);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.Controls.Add(this.dgvRiwayat);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 165);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(16);
            this.panelGrid.Size = new System.Drawing.Size(780, 335);
            this.panelGrid.TabIndex = 2;
            // 
            // dgvRiwayat
            // 
            this.dgvRiwayat.AllowUserToAddRows = false;
            this.dgvRiwayat.AllowUserToDeleteRows = false;
            this.dgvRiwayat.BackgroundColor = System.Drawing.Color.White;
            this.dgvRiwayat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRiwayat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRiwayat.Location = new System.Drawing.Point(16, 16);
            this.dgvRiwayat.Name = "dgvRiwayat";
            this.dgvRiwayat.ReadOnly = true;
            this.dgvRiwayat.Size = new System.Drawing.Size(748, 303);
            this.dgvRiwayat.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.panelFooter.Controls.Add(this.lblCountTrx);
            this.panelFooter.Controls.Add(this.btnCetakBuku);
            this.panelFooter.Controls.Add(this.btnTutup);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 500);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.panelFooter.Size = new System.Drawing.Size(780, 55);
            this.panelFooter.TabIndex = 3;
            // 
            // lblCountTrx
            // 
            this.lblCountTrx.AutoSize = true;
            this.lblCountTrx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblCountTrx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblCountTrx.Location = new System.Drawing.Point(16, 20);
            this.lblCountTrx.Name = "lblCountTrx";
            this.lblCountTrx.Size = new System.Drawing.Size(124, 15);
            this.lblCountTrx.TabIndex = 2;
            this.lblCountTrx.Text = "Menampilkan 0 mutasi";
            // 
            // btnCetakBuku
            // 
            this.btnCetakBuku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCetakBuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(122)))), ((int)(((byte)(94)))));
            this.btnCetakBuku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCetakBuku.FlatAppearance.BorderSize = 0;
            this.btnCetakBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCetakBuku.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCetakBuku.ForeColor = System.Drawing.Color.White;
            this.btnCetakBuku.Location = new System.Drawing.Point(500, 10);
            this.btnCetakBuku.Name = "btnCetakBuku";
            this.btnCetakBuku.Size = new System.Drawing.Size(170, 35);
            this.btnCetakBuku.TabIndex = 1;
            this.btnCetakBuku.Text = "🖨️ Cetak Buku Tabungan";
            this.btnCetakBuku.UseVisualStyleBackColor = false;
            this.btnCetakBuku.Click += new System.EventHandler(this.btnCetakBuku_Click);
            // 
            // btnTutup
            // 
            this.btnTutup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTutup.BackColor = System.Drawing.Color.White;
            this.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTutup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(194)))));
            this.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTutup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.btnTutup.Location = new System.Drawing.Point(680, 10);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(84, 35);
            this.btnTutup.TabIndex = 0;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = false;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // FormRiwayatNasabah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(780, 555);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelCardProfile);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRiwayatNasabah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Riwayat Transaksi Nasabah";
            this.Load += new System.EventHandler(this.FormRiwayatNasabah_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelCardProfile.ResumeLayout(false);
            this.panelCardProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Button btnTutupTop;
        private System.Windows.Forms.Panel panelCardProfile;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblKodeBadge;
        private System.Windows.Forms.Label lblNoHp;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblMetricSaldo;
        private System.Windows.Forms.Label lblSaldoTitle;
        private System.Windows.Forms.Label lblTotalBerat;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvRiwayat;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnCetakBuku;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Label lblCountTrx;
    }
}
