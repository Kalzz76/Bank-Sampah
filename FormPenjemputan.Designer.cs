using System;
using System.Drawing;
using System.Windows.Forms;

namespace BankSampah
{
    partial class FormPenjemputan
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
            this.dgvPenjemputan = new System.Windows.Forms.DataGridView();
            this.panelGridActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnKonversiSetor = new System.Windows.Forms.Button();
            this.btnSetDalamProses = new System.Windows.Forms.Button();
            this.btnCetakSuratTugas = new System.Windows.Forms.Button();
            this.btnBatalPenjemputan = new System.Windows.Forms.Button();
            this.panelFilterBox = new System.Windows.Forms.Panel();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.panelFormCard = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tableLayoutPanelFields = new System.Windows.Forms.TableLayoutPanel();
            this.panelFieldCatatan = new System.Windows.Forms.Panel();
            this.txtCatatan = new System.Windows.Forms.TextBox();
            this.lblCatatan = new System.Windows.Forms.Label();
            this.panelFieldBerat = new System.Windows.Forms.Panel();
            this.txtEstimasiBerat = new System.Windows.Forms.TextBox();
            this.lblEstimasiBerat = new System.Windows.Forms.Label();
            this.panelFieldSampah = new System.Windows.Forms.Panel();
            this.txtEstimasiSampah = new System.Windows.Forms.TextBox();
            this.lblEstimasiSampah = new System.Windows.Forms.Label();
            this.panelFieldArmada = new System.Windows.Forms.Panel();
            this.txtArmada = new System.Windows.Forms.TextBox();
            this.lblArmada = new System.Windows.Forms.Label();
            this.panelFieldWaktu = new System.Windows.Forms.Panel();
            this.cmbWaktu = new System.Windows.Forms.ComboBox();
            this.lblWaktu = new System.Windows.Forms.Label();
            this.panelFieldTanggal = new System.Windows.Forms.Panel();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.panelFieldHp = new System.Windows.Forms.Panel();
            this.txtNoHp = new System.Windows.Forms.TextBox();
            this.lblNoHp = new System.Windows.Forms.Label();
            this.panelFieldAlamat = new System.Windows.Forms.Panel();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.panelFieldNasabah = new System.Windows.Forms.Panel();
            this.cmbNasabah = new System.Windows.Forms.ComboBox();
            this.lblNasabah = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjemputan)).BeginInit();
            this.panelGridActions.SuspendLayout();
            this.panelFilterBox.SuspendLayout();
            this.panelFormCard.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.tableLayoutPanelFields.SuspendLayout();
            this.panelFieldCatatan.SuspendLayout();
            this.panelFieldBerat.SuspendLayout();
            this.panelFieldSampah.SuspendLayout();
            this.panelFieldArmada.SuspendLayout();
            this.panelFieldWaktu.SuspendLayout();
            this.panelFieldTanggal.SuspendLayout();
            this.panelFieldHp.SuspendLayout();
            this.panelFieldAlamat.SuspendLayout();
            this.panelFieldNasabah.SuspendLayout();
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
            this.panelMain.Size = new System.Drawing.Size(900, 720);
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
            this.lblTitle.Size = new System.Drawing.Size(342, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🚚 Manajemen Penjemputan Sampah";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblDesc.Location = new System.Drawing.Point(1, 28);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(650, 17);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Penjadwalan jemput door-to-door, rute armada motor roda tiga, dan konversi instan ke transaksi setor nasabah.";
            // 
            // panelFormCard
            // 
            this.panelFormCard.BackColor = System.Drawing.Color.White;
            this.panelFormCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormCard.Controls.Add(this.panelButtons);
            this.panelFormCard.Controls.Add(this.tableLayoutPanelFields);
            this.panelFormCard.Controls.Add(this.lblFormTitle);
            this.panelFormCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormCard.Location = new System.Drawing.Point(20, 70);
            this.panelFormCard.Margin = new System.Windows.Forms.Padding(0, 10, 0, 15);
            this.panelFormCard.Name = "panelFormCard";
            this.panelFormCard.Padding = new System.Windows.Forms.Padding(16);
            this.panelFormCard.Size = new System.Drawing.Size(860, 245);
            this.panelFormCard.TabIndex = 1;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblFormTitle.Location = new System.Drawing.Point(14, 12);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(262, 20);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "📝 Jadwalkan Penjemputan Baru";
            // 
            // tableLayoutPanelFields
            // 
            this.tableLayoutPanelFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelFields.ColumnCount = 3;
            this.tableLayoutPanelFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanelFields.Controls.Add(this.panelFieldCatatan, 2, 2);
            this.tableLayoutPanelFields.Controls.Add(this.panelFieldBerat, 1, 2);
            this.tableLayoutPanelFields.Controls.Add(this.panelFieldSampah, 0, 2);
            this.tableLayoutPanelFields.Controls.Add(this.panelFieldArmada, 2, 1);
            this.tableLayoutPanelFields.Controls.Add(this.panelFieldWaktu, 1, 1);
            this.tableLayoutPanelFields.Controls.Add(this.panelFieldTanggal, 0, 1);
            this.tableLayoutPanelFields.Controls.Add(this.panelFieldHp, 2, 0);
            this.tableLayoutPanelFields.Controls.Add(this.panelFieldAlamat, 1, 0);
            this.tableLayoutPanelFields.Controls.Add(this.panelFieldNasabah, 0, 0);
            this.tableLayoutPanelFields.Location = new System.Drawing.Point(14, 38);
            this.tableLayoutPanelFields.Name = "tableLayoutPanelFields";
            this.tableLayoutPanelFields.RowCount = 3;
            this.tableLayoutPanelFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanelFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanelFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanelFields.Size = new System.Drawing.Size(830, 156);
            this.tableLayoutPanelFields.TabIndex = 1;
            // 
            // panelFieldNasabah
            // 
            this.panelFieldNasabah.Controls.Add(this.cmbNasabah);
            this.panelFieldNasabah.Controls.Add(this.lblNasabah);
            this.panelFieldNasabah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFieldNasabah.Location = new System.Drawing.Point(3, 3);
            this.panelFieldNasabah.Name = "panelFieldNasabah";
            this.panelFieldNasabah.Size = new System.Drawing.Size(270, 46);
            this.panelFieldNasabah.TabIndex = 0;
            // 
            // lblNasabah
            // 
            this.lblNasabah.AutoSize = true;
            this.lblNasabah.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblNasabah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblNasabah.Location = new System.Drawing.Point(0, 0);
            this.lblNasabah.Name = "lblNasabah";
            this.lblNasabah.Size = new System.Drawing.Size(89, 13);
            this.lblNasabah.TabIndex = 0;
            this.lblNasabah.Text = "PILIH NASABAH";
            // 
            // cmbNasabah
            // 
            this.cmbNasabah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbNasabah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNasabah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbNasabah.FormattingEnabled = true;
            this.cmbNasabah.Location = new System.Drawing.Point(0, 18);
            this.cmbNasabah.Name = "cmbNasabah";
            this.cmbNasabah.Size = new System.Drawing.Size(270, 23);
            this.cmbNasabah.TabIndex = 1;
            this.cmbNasabah.SelectedIndexChanged += new System.EventHandler(this.cmbNasabah_SelectedIndexChanged);
            // 
            // panelFieldAlamat
            // 
            this.panelFieldAlamat.Controls.Add(this.txtAlamat);
            this.panelFieldAlamat.Controls.Add(this.lblAlamat);
            this.panelFieldAlamat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFieldAlamat.Location = new System.Drawing.Point(279, 3);
            this.panelFieldAlamat.Name = "panelFieldAlamat";
            this.panelFieldAlamat.Size = new System.Drawing.Size(270, 46);
            this.panelFieldAlamat.TabIndex = 1;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblAlamat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblAlamat.Location = new System.Drawing.Point(0, 0);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(90, 13);
            this.lblAlamat.TabIndex = 0;
            this.lblAlamat.Text = "ALAMAT JEMPUT";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtAlamat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAlamat.Location = new System.Drawing.Point(0, 18);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(270, 23);
            this.txtAlamat.TabIndex = 1;
            // 
            // panelFieldHp
            // 
            this.panelFieldHp.Controls.Add(this.txtNoHp);
            this.panelFieldHp.Controls.Add(this.lblNoHp);
            this.panelFieldHp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFieldHp.Location = new System.Drawing.Point(555, 3);
            this.panelFieldHp.Name = "panelFieldHp";
            this.panelFieldHp.Size = new System.Drawing.Size(272, 46);
            this.panelFieldHp.TabIndex = 2;
            // 
            // lblNoHp
            // 
            this.lblNoHp.AutoSize = true;
            this.lblNoHp.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblNoHp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblNoHp.Location = new System.Drawing.Point(0, 0);
            this.lblNoHp.Name = "lblNoHp";
            this.lblNoHp.Size = new System.Drawing.Size(107, 13);
            this.lblNoHp.TabIndex = 0;
            this.lblNoHp.Text = "NO. HP / WHATSAPP";
            // 
            // txtNoHp
            // 
            this.txtNoHp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNoHp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNoHp.Location = new System.Drawing.Point(0, 18);
            this.txtNoHp.Name = "txtNoHp";
            this.txtNoHp.Size = new System.Drawing.Size(272, 23);
            this.txtNoHp.TabIndex = 1;
            // 
            // panelFieldTanggal
            // 
            this.panelFieldTanggal.Controls.Add(this.dtpTanggal);
            this.panelFieldTanggal.Controls.Add(this.lblTanggal);
            this.panelFieldTanggal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFieldTanggal.Location = new System.Drawing.Point(3, 55);
            this.panelFieldTanggal.Name = "panelFieldTanggal";
            this.panelFieldTanggal.Size = new System.Drawing.Size(270, 46);
            this.panelFieldTanggal.TabIndex = 3;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblTanggal.Location = new System.Drawing.Point(0, 0);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(95, 13);
            this.lblTanggal.TabIndex = 0;
            this.lblTanggal.Text = "TANGGAL JEMPUT";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggal.Location = new System.Drawing.Point(0, 18);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(270, 23);
            this.dtpTanggal.TabIndex = 1;
            // 
            // panelFieldWaktu
            // 
            this.panelFieldWaktu.Controls.Add(this.cmbWaktu);
            this.panelFieldWaktu.Controls.Add(this.lblWaktu);
            this.panelFieldWaktu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFieldWaktu.Location = new System.Drawing.Point(279, 55);
            this.panelFieldWaktu.Name = "panelFieldWaktu";
            this.panelFieldWaktu.Size = new System.Drawing.Size(270, 46);
            this.panelFieldWaktu.TabIndex = 4;
            // 
            // lblWaktu
            // 
            this.lblWaktu.AutoSize = true;
            this.lblWaktu.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblWaktu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblWaktu.Location = new System.Drawing.Point(0, 0);
            this.lblWaktu.Name = "lblWaktu";
            this.lblWaktu.Size = new System.Drawing.Size(86, 13);
            this.lblWaktu.TabIndex = 0;
            this.lblWaktu.Text = "WAKTU JEMPUT";
            // 
            // cmbWaktu
            // 
            this.cmbWaktu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbWaktu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWaktu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbWaktu.FormattingEnabled = true;
            this.cmbWaktu.Items.AddRange(new object[] {
            "08:30 - 10:00 WIB",
            "10:00 - 11:30 WIB",
            "13:00 - 14:30 WIB",
            "14:30 - 16:00 WIB"});
            this.cmbWaktu.Location = new System.Drawing.Point(0, 18);
            this.cmbWaktu.Name = "cmbWaktu";
            this.cmbWaktu.Size = new System.Drawing.Size(270, 23);
            this.cmbWaktu.TabIndex = 1;
            // 
            // panelFieldArmada
            // 
            this.panelFieldArmada.Controls.Add(this.txtArmada);
            this.panelFieldArmada.Controls.Add(this.lblArmada);
            this.panelFieldArmada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFieldArmada.Location = new System.Drawing.Point(555, 55);
            this.panelFieldArmada.Name = "panelFieldArmada";
            this.panelFieldArmada.Size = new System.Drawing.Size(272, 46);
            this.panelFieldArmada.TabIndex = 5;
            // 
            // lblArmada
            // 
            this.lblArmada.AutoSize = true;
            this.lblArmada.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblArmada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblArmada.Location = new System.Drawing.Point(0, 0);
            this.lblArmada.Name = "lblArmada";
            this.lblArmada.Size = new System.Drawing.Size(109, 13);
            this.lblArmada.TabIndex = 0;
            this.lblArmada.Text = "PETUGAS / ARMADA";
            // 
            // txtArmada
            // 
            this.txtArmada.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtArmada.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtArmada.Location = new System.Drawing.Point(0, 18);
            this.txtArmada.Name = "txtArmada";
            this.txtArmada.Size = new System.Drawing.Size(272, 23);
            this.txtArmada.TabIndex = 1;
            this.txtArmada.Text = "Budi Santoso (Motor Roda Tiga)";
            // 
            // panelFieldSampah
            // 
            this.panelFieldSampah.Controls.Add(this.txtEstimasiSampah);
            this.panelFieldSampah.Controls.Add(this.lblEstimasiSampah);
            this.panelFieldSampah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFieldSampah.Location = new System.Drawing.Point(3, 107);
            this.panelFieldSampah.Name = "panelFieldSampah";
            this.panelFieldSampah.Size = new System.Drawing.Size(270, 46);
            this.panelFieldSampah.TabIndex = 6;
            // 
            // lblEstimasiSampah
            // 
            this.lblEstimasiSampah.AutoSize = true;
            this.lblEstimasiSampah.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblEstimasiSampah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblEstimasiSampah.Location = new System.Drawing.Point(0, 0);
            this.lblEstimasiSampah.Name = "lblEstimasiSampah";
            this.lblEstimasiSampah.Size = new System.Drawing.Size(107, 13);
            this.lblEstimasiSampah.TabIndex = 0;
            this.lblEstimasiSampah.Text = "ESTIMASI SAMPAH";
            // 
            // txtEstimasiSampah
            // 
            this.txtEstimasiSampah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtEstimasiSampah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEstimasiSampah.Location = new System.Drawing.Point(0, 18);
            this.txtEstimasiSampah.Name = "txtEstimasiSampah";
            this.txtEstimasiSampah.Size = new System.Drawing.Size(270, 23);
            this.txtEstimasiSampah.TabIndex = 1;
            // 
            // panelFieldBerat
            // 
            this.panelFieldBerat.Controls.Add(this.txtEstimasiBerat);
            this.panelFieldBerat.Controls.Add(this.lblEstimasiBerat);
            this.panelFieldBerat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFieldBerat.Location = new System.Drawing.Point(279, 107);
            this.panelFieldBerat.Name = "panelFieldBerat";
            this.panelFieldBerat.Size = new System.Drawing.Size(270, 46);
            this.panelFieldBerat.TabIndex = 7;
            // 
            // lblEstimasiBerat
            // 
            this.lblEstimasiBerat.AutoSize = true;
            this.lblEstimasiBerat.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblEstimasiBerat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblEstimasiBerat.Location = new System.Drawing.Point(0, 0);
            this.lblEstimasiBerat.Name = "lblEstimasiBerat";
            this.lblEstimasiBerat.Size = new System.Drawing.Size(117, 13);
            this.lblEstimasiBerat.TabIndex = 0;
            this.lblEstimasiBerat.Text = "ESTIMASI BERAT (KG)";
            // 
            // txtEstimasiBerat
            // 
            this.txtEstimasiBerat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtEstimasiBerat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEstimasiBerat.Location = new System.Drawing.Point(0, 18);
            this.txtEstimasiBerat.Name = "txtEstimasiBerat";
            this.txtEstimasiBerat.Size = new System.Drawing.Size(270, 23);
            this.txtEstimasiBerat.TabIndex = 1;
            // 
            // panelFieldCatatan
            // 
            this.panelFieldCatatan.Controls.Add(this.txtCatatan);
            this.panelFieldCatatan.Controls.Add(this.lblCatatan);
            this.panelFieldCatatan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFieldCatatan.Location = new System.Drawing.Point(555, 107);
            this.panelFieldCatatan.Name = "panelFieldCatatan";
            this.panelFieldCatatan.Size = new System.Drawing.Size(272, 46);
            this.panelFieldCatatan.TabIndex = 8;
            // 
            // lblCatatan
            // 
            this.lblCatatan.AutoSize = true;
            this.lblCatatan.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCatatan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblCatatan.Location = new System.Drawing.Point(0, 0);
            this.lblCatatan.Name = "lblCatatan";
            this.lblCatatan.Size = new System.Drawing.Size(127, 13);
            this.lblCatatan.TabIndex = 0;
            this.lblCatatan.Text = "CATATAN / PATOKAN";
            // 
            // txtCatatan
            // 
            this.txtCatatan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtCatatan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCatatan.Location = new System.Drawing.Point(0, 18);
            this.txtCatatan.Name = "txtCatatan";
            this.txtCatatan.Size = new System.Drawing.Size(272, 23);
            this.txtCatatan.TabIndex = 1;
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelButtons.Controls.Add(this.btnSimpan);
            this.panelButtons.Controls.Add(this.btnReset);
            this.panelButtons.Location = new System.Drawing.Point(14, 200);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(400, 36);
            this.panelButtons.TabIndex = 2;
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
            this.btnSimpan.Size = new System.Drawing.Size(190, 34);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "💾 Jadwalkan Penjemputan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(194)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.btnReset.Location = new System.Drawing.Point(198, 0);
            this.btnReset.Margin = new System.Windows.Forms.Padding(0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 34);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Batal";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panelGridCard
            // 
            this.panelGridCard.BackColor = System.Drawing.Color.White;
            this.panelGridCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGridCard.Controls.Add(this.dgvPenjemputan);
            this.panelGridCard.Controls.Add(this.panelGridActions);
            this.panelGridCard.Controls.Add(this.panelFilterBox);
            this.panelGridCard.Controls.Add(this.lblGridTitle);
            this.panelGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridCard.Location = new System.Drawing.Point(20, 330);
            this.panelGridCard.Name = "panelGridCard";
            this.panelGridCard.Padding = new System.Windows.Forms.Padding(16);
            this.panelGridCard.Size = new System.Drawing.Size(860, 370);
            this.panelGridCard.TabIndex = 2;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(31)))));
            this.lblGridTitle.Location = new System.Drawing.Point(14, 14);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(287, 20);
            this.lblGridTitle.TabIndex = 0;
            this.lblGridTitle.Text = "📋 Daftar & Monitoring Rute Penjemputan";
            // 
            // panelFilterBox
            // 
            this.panelFilterBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFilterBox.Controls.Add(this.cmbFilterStatus);
            this.panelFilterBox.Controls.Add(this.lblFilterStatus);
            this.panelFilterBox.Location = new System.Drawing.Point(620, 10);
            this.panelFilterBox.Name = "panelFilterBox";
            this.panelFilterBox.Size = new System.Drawing.Size(224, 30);
            this.panelFilterBox.TabIndex = 1;
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFilterStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.lblFilterStatus.Location = new System.Drawing.Point(0, 7);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(76, 15);
            this.lblFilterStatus.TabIndex = 0;
            this.lblFilterStatus.Text = "Filter Status:";
            // 
            // cmbFilterStatus
            // 
            this.cmbFilterStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFilterStatus.FormattingEnabled = true;
            this.cmbFilterStatus.Items.AddRange(new object[] {
            "Semua Status",
            "Menunggu",
            "Dalam Penjemputan",
            "Selesai",
            "Batal"});
            this.cmbFilterStatus.Location = new System.Drawing.Point(82, 0);
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.Size = new System.Drawing.Size(142, 23);
            this.cmbFilterStatus.TabIndex = 1;
            this.cmbFilterStatus.SelectedIndexChanged += new System.EventHandler(this.cmbFilterStatus_SelectedIndexChanged);
            // 
            // panelGridActions
            // 
            this.panelGridActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGridActions.Controls.Add(this.btnKonversiSetor);
            this.panelGridActions.Controls.Add(this.btnSetDalamProses);
            this.panelGridActions.Controls.Add(this.btnCetakSuratTugas);
            this.panelGridActions.Controls.Add(this.btnBatalPenjemputan);
            this.panelGridActions.Location = new System.Drawing.Point(14, 46);
            this.panelGridActions.Name = "panelGridActions";
            this.panelGridActions.Size = new System.Drawing.Size(830, 36);
            this.panelGridActions.TabIndex = 2;
            // 
            // btnKonversiSetor
            // 
            this.btnKonversiSetor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(122)))), ((int)(((byte)(94)))));
            this.btnKonversiSetor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKonversiSetor.FlatAppearance.BorderSize = 0;
            this.btnKonversiSetor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKonversiSetor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKonversiSetor.ForeColor = System.Drawing.Color.White;
            this.btnKonversiSetor.Location = new System.Drawing.Point(0, 0);
            this.btnKonversiSetor.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnKonversiSetor.Name = "btnKonversiSetor";
            this.btnKonversiSetor.Size = new System.Drawing.Size(220, 32);
            this.btnKonversiSetor.TabIndex = 0;
            this.btnKonversiSetor.Text = "✅ Selesai & Buat Transaksi Setor";
            this.btnKonversiSetor.UseVisualStyleBackColor = false;
            this.btnKonversiSetor.Click += new System.EventHandler(this.btnKonversiSetor_Click);
            // 
            // btnSetDalamProses
            // 
            this.btnSetDalamProses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.btnSetDalamProses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetDalamProses.FlatAppearance.BorderSize = 0;
            this.btnSetDalamProses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetDalamProses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSetDalamProses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(26)))), ((int)(((byte)(2)))));
            this.btnSetDalamProses.Location = new System.Drawing.Point(228, 0);
            this.btnSetDalamProses.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnSetDalamProses.Name = "btnSetDalamProses";
            this.btnSetDalamProses.Size = new System.Drawing.Size(175, 32);
            this.btnSetDalamProses.TabIndex = 1;
            this.btnSetDalamProses.Text = "🚚 Berangkatkan Armada";
            this.btnSetDalamProses.UseVisualStyleBackColor = false;
            this.btnSetDalamProses.Click += new System.EventHandler(this.btnSetDalamProses_Click);
            // 
            // btnCetakSuratTugas
            // 
            this.btnCetakSuratTugas.BackColor = System.Drawing.Color.Transparent;
            this.btnCetakSuratTugas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCetakSuratTugas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(194)))));
            this.btnCetakSuratTugas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCetakSuratTugas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCetakSuratTugas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(82)))));
            this.btnCetakSuratTugas.Location = new System.Drawing.Point(411, 0);
            this.btnCetakSuratTugas.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnCetakSuratTugas.Name = "btnCetakSuratTugas";
            this.btnCetakSuratTugas.Size = new System.Drawing.Size(185, 32);
            this.btnCetakSuratTugas.TabIndex = 2;
            this.btnCetakSuratTugas.Text = "🖨️ Cetak Surat Jalan Armada";
            this.btnCetakSuratTugas.UseVisualStyleBackColor = false;
            this.btnCetakSuratTugas.Click += new System.EventHandler(this.btnCetakSuratTugas_Click);
            // 
            // btnBatalPenjemputan
            // 
            this.btnBatalPenjemputan.BackColor = System.Drawing.Color.Transparent;
            this.btnBatalPenjemputan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatalPenjemputan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(136)))), ((int)(((byte)(120)))));
            this.btnBatalPenjemputan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatalPenjemputan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBatalPenjemputan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(70)))), ((int)(((byte)(50)))));
            this.btnBatalPenjemputan.Location = new System.Drawing.Point(604, 0);
            this.btnBatalPenjemputan.Margin = new System.Windows.Forms.Padding(0);
            this.btnBatalPenjemputan.Name = "btnBatalPenjemputan";
            this.btnBatalPenjemputan.Size = new System.Drawing.Size(130, 32);
            this.btnBatalPenjemputan.TabIndex = 3;
            this.btnBatalPenjemputan.Text = "✕ Batalkan Tiket";
            this.btnBatalPenjemputan.UseVisualStyleBackColor = false;
            this.btnBatalPenjemputan.Click += new System.EventHandler(this.btnBatalPenjemputan_Click);
            // 
            // dgvPenjemputan
            // 
            this.dgvPenjemputan.AllowUserToAddRows = false;
            this.dgvPenjemputan.AllowUserToDeleteRows = false;
            this.dgvPenjemputan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPenjemputan.BackgroundColor = System.Drawing.Color.White;
            this.dgvPenjemputan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPenjemputan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenjemputan.Location = new System.Drawing.Point(14, 90);
            this.dgvPenjemputan.MultiSelect = false;
            this.dgvPenjemputan.Name = "dgvPenjemputan";
            this.dgvPenjemputan.ReadOnly = true;
            this.dgvPenjemputan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPenjemputan.Size = new System.Drawing.Size(830, 260);
            this.dgvPenjemputan.TabIndex = 3;
            this.dgvPenjemputan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPenjemputan_CellDoubleClick);
            // 
            // FormPenjemputan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(900, 720);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPenjemputan";
            this.Text = "FormPenjemputan";
            this.Load += new System.EventHandler(this.FormPenjemputan_Load);
            this.panelMain.ResumeLayout(false);
            this.panelGridCard.ResumeLayout(false);
            this.panelGridCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjemputan)).EndInit();
            this.panelGridActions.ResumeLayout(false);
            this.panelFilterBox.ResumeLayout(false);
            this.panelFilterBox.PerformLayout();
            this.panelFormCard.ResumeLayout(false);
            this.panelFormCard.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.tableLayoutPanelFields.ResumeLayout(false);
            this.panelFieldCatatan.ResumeLayout(false);
            this.panelFieldCatatan.PerformLayout();
            this.panelFieldBerat.ResumeLayout(false);
            this.panelFieldBerat.PerformLayout();
            this.panelFieldSampah.ResumeLayout(false);
            this.panelFieldSampah.PerformLayout();
            this.panelFieldArmada.ResumeLayout(false);
            this.panelFieldArmada.PerformLayout();
            this.panelFieldWaktu.ResumeLayout(false);
            this.panelFieldWaktu.PerformLayout();
            this.panelFieldTanggal.ResumeLayout(false);
            this.panelFieldTanggal.PerformLayout();
            this.panelFieldHp.ResumeLayout(false);
            this.panelFieldHp.PerformLayout();
            this.panelFieldAlamat.ResumeLayout(false);
            this.panelFieldAlamat.PerformLayout();
            this.panelFieldNasabah.ResumeLayout(false);
            this.panelFieldNasabah.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFormCard;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFields;
        private System.Windows.Forms.Panel panelFieldNasabah;
        private System.Windows.Forms.Label lblNasabah;
        private System.Windows.Forms.ComboBox cmbNasabah;
        private System.Windows.Forms.Panel panelFieldAlamat;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Panel panelFieldHp;
        private System.Windows.Forms.Label lblNoHp;
        private System.Windows.Forms.TextBox txtNoHp;
        private System.Windows.Forms.Panel panelFieldTanggal;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Panel panelFieldWaktu;
        private System.Windows.Forms.Label lblWaktu;
        private System.Windows.Forms.ComboBox cmbWaktu;
        private System.Windows.Forms.Panel panelFieldArmada;
        private System.Windows.Forms.Label lblArmada;
        private System.Windows.Forms.TextBox txtArmada;
        private System.Windows.Forms.Panel panelFieldSampah;
        private System.Windows.Forms.Label lblEstimasiSampah;
        private System.Windows.Forms.TextBox txtEstimasiSampah;
        private System.Windows.Forms.Panel panelFieldBerat;
        private System.Windows.Forms.Label lblEstimasiBerat;
        private System.Windows.Forms.TextBox txtEstimasiBerat;
        private System.Windows.Forms.Panel panelFieldCatatan;
        private System.Windows.Forms.Label lblCatatan;
        private System.Windows.Forms.TextBox txtCatatan;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panelGridCard;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.Panel panelFilterBox;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.FlowLayoutPanel panelGridActions;
        private System.Windows.Forms.Button btnKonversiSetor;
        private System.Windows.Forms.Button btnSetDalamProses;
        private System.Windows.Forms.Button btnCetakSuratTugas;
        private System.Windows.Forms.Button btnBatalPenjemputan;
        private System.Windows.Forms.DataGridView dgvPenjemputan;
    }
}
