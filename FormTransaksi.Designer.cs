using System;
using System.Drawing;
using System.Windows.Forms;

namespace BankSampah
{
    partial class FormTransaksi
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
            this.lblJenis = new System.Windows.Forms.Label();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.lblNasabah = new System.Windows.Forms.Label();
            this.cmbNasabah = new System.Windows.Forms.ComboBox();
            this.lblSaldoInfo = new System.Windows.Forms.Label();
            this.lblSampah = new System.Windows.Forms.Label();
            this.cmbSampah = new System.Windows.Forms.ComboBox();
            this.lblHargaInfo = new System.Windows.Forms.Label();
            this.lblBerat = new System.Windows.Forms.Label();
            this.txtBerat = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblCatatan = new System.Windows.Forms.Label();
            this.txtCatatan = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.panelGridCard = new System.Windows.Forms.Panel();
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            this.panelSearchBox = new System.Windows.Forms.Panel();
            this.lblRecordBadge = new System.Windows.Forms.Label();
            this.lblCariIcon = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.panelMainContainer.SuspendLayout();
            this.panelFormCard.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelGridCard.SuspendLayout();
            this.panelSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
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
            this.panelFormCard.Controls.Add(this.lblJenis);
            this.panelFormCard.Controls.Add(this.cmbJenis);
            this.panelFormCard.Controls.Add(this.lblNasabah);
            this.panelFormCard.Controls.Add(this.cmbNasabah);
            this.panelFormCard.Controls.Add(this.lblSaldoInfo);
            this.panelFormCard.Controls.Add(this.lblSampah);
            this.panelFormCard.Controls.Add(this.cmbSampah);
            this.panelFormCard.Controls.Add(this.lblHargaInfo);
            this.panelFormCard.Controls.Add(this.lblBerat);
            this.panelFormCard.Controls.Add(this.txtBerat);
            this.panelFormCard.Controls.Add(this.lblTotal);
            this.panelFormCard.Controls.Add(this.txtTotal);
            this.panelFormCard.Controls.Add(this.lblCatatan);
            this.panelFormCard.Controls.Add(this.txtCatatan);
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
            this.lblFormHeader.Location = new Point(20, 10);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new Size(181, 20);
            this.lblFormHeader.TabIndex = 0;
            this.lblFormHeader.Text = "📝 Input Transaksi Baru";
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblJenis.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblJenis.Location = new Point(20, 38);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new Size(107, 15);
            this.lblJenis.TabIndex = 1;
            this.lblJenis.Text = "🔄 Jenis Transaksi";
            // 
            // cmbJenis
            // 
            this.cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbJenis.Font = new Font("Segoe UI", 10F);
            this.cmbJenis.FormattingEnabled = true;
            this.cmbJenis.Items.AddRange(new object[] {
            "Setor Sampah (+ Saldo)",
            "Tarik Saldo (- Saldo)"});
            this.cmbJenis.Location = new Point(20, 56);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new Size(240, 25);
            this.cmbJenis.TabIndex = 2;
            this.cmbJenis.SelectedIndexChanged += new EventHandler(this.cmbJenis_SelectedIndexChanged);
            // 
            // lblNasabah
            // 
            this.lblNasabah.AutoSize = true;
            this.lblNasabah.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblNasabah.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblNasabah.Location = new Point(20, 90);
            this.lblNasabah.Name = "lblNasabah";
            this.lblNasabah.Size = new Size(99, 15);
            this.lblNasabah.TabIndex = 3;
            this.lblNasabah.Text = "👤 Pilih Nasabah";
            // 
            // cmbNasabah
            // 
            this.cmbNasabah.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbNasabah.Font = new Font("Segoe UI", 10F);
            this.cmbNasabah.FormattingEnabled = true;
            this.cmbNasabah.Location = new Point(20, 108);
            this.cmbNasabah.Name = "cmbNasabah";
            this.cmbNasabah.Size = new Size(240, 25);
            this.cmbNasabah.TabIndex = 4;
            this.cmbNasabah.SelectedIndexChanged += new EventHandler(this.cmbNasabah_SelectedIndexChanged);
            // 
            // lblSaldoInfo
            // 
            this.lblSaldoInfo.AutoSize = true;
            this.lblSaldoInfo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            this.lblSaldoInfo.ForeColor = Color.FromArgb(4, 120, 87);
            this.lblSaldoInfo.Location = new Point(20, 140);
            this.lblSaldoInfo.Name = "lblSaldoInfo";
            this.lblSaldoInfo.Size = new Size(122, 15);
            this.lblSaldoInfo.TabIndex = 5;
            this.lblSaldoInfo.Text = "Saldo Saat Ini: Rp 0";
            // 
            // lblSampah
            // 
            this.lblSampah.AutoSize = true;
            this.lblSampah.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblSampah.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblSampah.Location = new Point(280, 38);
            this.lblSampah.Name = "lblSampah";
            this.lblSampah.Size = new Size(137, 15);
            this.lblSampah.TabIndex = 6;
            this.lblSampah.Text = "♻️ Pilih Jenis Sampah";
            // 
            // cmbSampah
            // 
            this.cmbSampah.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSampah.Font = new Font("Segoe UI", 10F);
            this.cmbSampah.FormattingEnabled = true;
            this.cmbSampah.Location = new Point(280, 56);
            this.cmbSampah.Name = "cmbSampah";
            this.cmbSampah.Size = new Size(270, 25);
            this.cmbSampah.TabIndex = 7;
            this.cmbSampah.SelectedIndexChanged += new EventHandler(this.cmbSampah_SelectedIndexChanged);
            // 
            // lblHargaInfo
            // 
            this.lblHargaInfo.AutoSize = true;
            this.lblHargaInfo.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            this.lblHargaInfo.ForeColor = Color.FromArgb(100, 116, 139);
            this.lblHargaInfo.Location = new Point(280, 84);
            this.lblHargaInfo.Name = "lblHargaInfo";
            this.lblHargaInfo.Size = new Size(129, 15);
            this.lblHargaInfo.TabIndex = 8;
            this.lblHargaInfo.Text = "Harga per Kg: Rp 0 / Kg";
            // 
            // lblBerat
            // 
            this.lblBerat.AutoSize = true;
            this.lblBerat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblBerat.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblBerat.Location = new Point(280, 104);
            this.lblBerat.Name = "lblBerat";
            this.lblBerat.Size = new Size(76, 15);
            this.lblBerat.TabIndex = 9;
            this.lblBerat.Text = "⚖️ Berat (Kg)";
            // 
            // txtBerat
            // 
            this.txtBerat.Font = new Font("Segoe UI", 10F);
            this.txtBerat.Location = new Point(280, 122);
            this.txtBerat.Name = "txtBerat";
            this.txtBerat.Size = new Size(110, 25);
            this.txtBerat.TabIndex = 10;
            this.txtBerat.Text = "0";
            this.txtBerat.TextChanged += new EventHandler(this.txtBerat_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblTotal.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblTotal.Location = new Point(405, 104);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new Size(116, 15);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "💰 Total Harga (Rp)";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.txtTotal.ForeColor = Color.FromArgb(16, 185, 129);
            this.txtTotal.Location = new Point(405, 122);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new Size(145, 25);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.Text = "0";
            // 
            // lblCatatan
            // 
            this.lblCatatan.AutoSize = true;
            this.lblCatatan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblCatatan.ForeColor = Color.FromArgb(15, 23, 42);
            this.lblCatatan.Location = new Point(575, 38);
            this.lblCatatan.Name = "lblCatatan";
            this.lblCatatan.Size = new Size(119, 15);
            this.lblCatatan.TabIndex = 13;
            this.lblCatatan.Text = "📝 Catatan Transaksi";
            // 
            // txtCatatan
            // 
            this.txtCatatan.Font = new Font("Segoe UI", 10F);
            this.txtCatatan.Location = new Point(575, 56);
            this.txtCatatan.Multiline = true;
            this.txtCatatan.Name = "txtCatatan";
            this.txtCatatan.Size = new Size(325, 55);
            this.txtCatatan.TabIndex = 14;
            // 
            // panelButtons
            // 
            this.panelButtons.ColumnCount = 2;
            this.panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.panelButtons.Controls.Add(this.btnSimpan, 0, 0);
            this.panelButtons.Controls.Add(this.btnBatal, 1, 0);
            this.panelButtons.Location = new Point(575, 118);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.RowCount = 1;
            this.panelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.panelButtons.Size = new Size(325, 42);
            this.panelButtons.TabIndex = 15;
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
            this.btnSimpan.Size = new Size(158, 38);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "💾 PROSES TRX";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new EventHandler(this.btnSimpan_Click);
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
            this.btnBatal.Location = new Point(164, 2);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new Size(159, 38);
            this.btnBatal.TabIndex = 1;
            this.btnBatal.Text = "🔄 BATAL";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new EventHandler(this.btnBatal_Click);
            // 
            // panelGridCard
            // 
            this.panelGridCard.BackColor = Color.White;
            this.panelGridCard.Controls.Add(this.dgvTransaksi);
            this.panelGridCard.Controls.Add(this.panelSearchBox);
            this.panelGridCard.Dock = DockStyle.Fill;
            this.panelGridCard.Location = new Point(20, 230);
            this.panelGridCard.Margin = new Padding(0);
            this.panelGridCard.Name = "panelGridCard";
            this.panelGridCard.Padding = new Padding(15);
            this.panelGridCard.Size = new Size(920, 405);
            this.panelGridCard.TabIndex = 1;
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.AllowUserToAddRows = false;
            this.dgvTransaksi.AllowUserToDeleteRows = false;
            this.dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransaksi.BackgroundColor = Color.White;
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.Dock = DockStyle.Fill;
            this.dgvTransaksi.Location = new Point(15, 60);
            this.dgvTransaksi.MultiSelect = false;
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.ReadOnly = true;
            this.dgvTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransaksi.Size = new Size(890, 330);
            this.dgvTransaksi.TabIndex = 1;
            this.dgvTransaksi.CellClick += new DataGridViewCellEventHandler(this.dgvTransaksi_CellClick);
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
            this.lblRecordBadge.Text = "📌 TRANSAKSI: 0 RECORD";
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
            this.lblCariIcon.Text = "🔍 Cari Riwayat: ";
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(240, 244, 242);
            this.ClientSize = new Size(960, 655);
            this.Controls.Add(this.panelMainContainer);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "FormTransaksi";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Transaksi Setor & Tarik";
            this.Load += new EventHandler(this.FormTransaksi_Load);
            this.panelMainContainer.ResumeLayout(false);
            this.panelFormCard.ResumeLayout(false);
            this.panelFormCard.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelGridCard.ResumeLayout(false);
            this.panelSearchBox.ResumeLayout(false);
            this.panelSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelMainContainer;
        private System.Windows.Forms.Panel panelFormCard;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.Label lblNasabah;
        private System.Windows.Forms.ComboBox cmbNasabah;
        private System.Windows.Forms.Label lblSaldoInfo;
        private System.Windows.Forms.Label lblSampah;
        private System.Windows.Forms.ComboBox cmbSampah;
        private System.Windows.Forms.Label lblHargaInfo;
        private System.Windows.Forms.Label lblBerat;
        private System.Windows.Forms.TextBox txtBerat;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblCatatan;
        private System.Windows.Forms.TextBox txtCatatan;
        private System.Windows.Forms.TableLayoutPanel panelButtons;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Panel panelGridCard;
        private System.Windows.Forms.Panel panelSearchBox;
        private System.Windows.Forms.Label lblCariIcon;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label lblRecordBadge;
        private System.Windows.Forms.DataGridView dgvTransaksi;
    }
}
