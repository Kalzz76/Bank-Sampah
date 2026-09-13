using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;

namespace BankSampah
{
    public partial class FormPenjemputan : Form
    {
        private DataTable dtNasabahCache = null;

        public FormPenjemputan()
        {
            InitializeComponent();
        }

        private void FormPenjemputan_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyModernGridStyle(dgvPenjemputan);
            UIHelper.StyleButtonTeal(btnSimpan);
            UIHelper.StyleButtonOutline(btnReset);
            UIHelper.StyleButtonTeal(btnKonversiSetor);
            UIHelper.StyleButtonGold(btnSetDalamProses);
            UIHelper.StyleButtonOutline(btnCetakSuratTugas);
            UIHelper.StyleButtonDanger(btnBatalPenjemputan);

            UIHelper.MakeRounded(panelFormCard, 10);
            UIHelper.MakeRounded(panelGridCard, 10);
            UIHelper.MakeRounded(cmbNasabah, 6);
            UIHelper.MakeRounded(txtAlamat, 6);
            UIHelper.MakeRounded(txtNoHp, 6);
            UIHelper.MakeRounded(dtpTanggal, 6);
            UIHelper.MakeRounded(cmbWaktu, 6);
            UIHelper.MakeRounded(txtArmada, 6);
            UIHelper.MakeRounded(txtEstimasiSampah, 6);
            UIHelper.MakeRounded(txtEstimasiBerat, 6);
            UIHelper.MakeRounded(txtCatatan, 6);
            UIHelper.MakeRounded(cmbFilterStatus, 6);

            UIHelper.AttachNumericOnly(txtEstimasiBerat, true);

            if (cmbWaktu.Items.Count > 0) cmbWaktu.SelectedIndex = 0;
            if (cmbFilterStatus.Items.Count > 0) cmbFilterStatus.SelectedIndex = 0;

            dtpTanggal.Value = DateTime.Today;

            LoadNasabahCombo();
            LoadData();
        }

        private void LoadNasabahCombo()
        {
            try
            {
                dtNasabahCache = DataStore.GetNasabah();
                cmbNasabah.Items.Clear();
                if (dtNasabahCache != null)
                {
                    foreach (DataRow r in dtNasabahCache.Rows)
                    {
                        string item = string.Format("{0} - {1}", r["kode_nasabah"], r["nama"]);
                        cmbNasabah.Items.Add(item);
                    }
                    if (cmbNasabah.Items.Count > 0) cmbNasabah.SelectedIndex = 0;
                }
            }
            catch { }
        }

        private void cmbNasabah_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNasabah.SelectedIndex >= 0 && dtNasabahCache != null)
            {
                string selected = cmbNasabah.SelectedItem.ToString();
                string kode = selected.Split('-')[0].Trim();
                DataRow[] rows = dtNasabahCache.Select(string.Format("kode_nasabah='{0}'", kode));
                if (rows.Length > 0)
                {
                    txtAlamat.Text = rows[0]["alamat"] != DBNull.Value ? rows[0]["alamat"].ToString() : "";
                    txtNoHp.Text = rows[0]["no_hp"] != DBNull.Value ? rows[0]["no_hp"].ToString() : "";
                }
            }
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = DataStore.GetPenjemputan();
                string filter = cmbFilterStatus.SelectedItem != null ? cmbFilterStatus.SelectedItem.ToString() : "Semua Status";

                DataTable dtDisplay = dt.Clone();
                if (filter == "Semua Status")
                {
                    dtDisplay = dt.Copy();
                }
                else
                {
                    DataRow[] filtered = dt.Select(string.Format("status='{0}'", filter));
                    foreach (DataRow r in filtered)
                    {
                        dtDisplay.ImportRow(r);
                    }
                }

                dgvPenjemputan.DataSource = dtDisplay;
                UIHelper.FormatGridColumns(dgvPenjemputan);

                if (dgvPenjemputan.Columns.Contains("id_penjemputan"))
                    dgvPenjemputan.Columns["id_penjemputan"].Visible = false;
                if (dgvPenjemputan.Columns.Contains("id_nasabah"))
                    dgvPenjemputan.Columns["id_nasabah"].Visible = false;

                if (dgvPenjemputan.Columns.Contains("kode_booking"))
                {
                    dgvPenjemputan.Columns["kode_booking"].HeaderText = "Kode Booking";
                    dgvPenjemputan.Columns["kode_booking"].Width = 120;
                }
                if (dgvPenjemputan.Columns.Contains("tanggal_jemput"))
                {
                    dgvPenjemputan.Columns["tanggal_jemput"].HeaderText = "Tgl Jemput";
                    dgvPenjemputan.Columns["tanggal_jemput"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvPenjemputan.Columns["tanggal_jemput"].Width = 90;
                }
                if (dgvPenjemputan.Columns.Contains("waktu_jemput"))
                {
                    dgvPenjemputan.Columns["waktu_jemput"].HeaderText = "Jam Jemput";
                    dgvPenjemputan.Columns["waktu_jemput"].Width = 110;
                }
                if (dgvPenjemputan.Columns.Contains("nama_nasabah"))
                {
                    dgvPenjemputan.Columns["nama_nasabah"].HeaderText = "Nama Nasabah";
                    dgvPenjemputan.Columns["nama_nasabah"].Width = 130;
                }
                if (dgvPenjemputan.Columns.Contains("alamat_jemput"))
                {
                    dgvPenjemputan.Columns["alamat_jemput"].HeaderText = "Alamat Penjemputan";
                    dgvPenjemputan.Columns["alamat_jemput"].Width = 180;
                }
                if (dgvPenjemputan.Columns.Contains("no_hp"))
                {
                    dgvPenjemputan.Columns["no_hp"].HeaderText = "No. WhatsApp";
                    dgvPenjemputan.Columns["no_hp"].Width = 100;
                }
                if (dgvPenjemputan.Columns.Contains("armada_petugas"))
                {
                    dgvPenjemputan.Columns["armada_petugas"].HeaderText = "Petugas / Armada";
                    dgvPenjemputan.Columns["armada_petugas"].Width = 160;
                }
                if (dgvPenjemputan.Columns.Contains("estimasi_sampah"))
                {
                    dgvPenjemputan.Columns["estimasi_sampah"].HeaderText = "Estimasi Sampah";
                    dgvPenjemputan.Columns["estimasi_sampah"].Width = 150;
                }
                if (dgvPenjemputan.Columns.Contains("estimasi_berat"))
                {
                    dgvPenjemputan.Columns["estimasi_berat"].HeaderText = "Est. (Kg)";
                    dgvPenjemputan.Columns["estimasi_berat"].DefaultCellStyle.Format = "N2";
                    dgvPenjemputan.Columns["estimasi_berat"].Width = 80;
                }
                if (dgvPenjemputan.Columns.Contains("status"))
                {
                    dgvPenjemputan.Columns["status"].HeaderText = "Status";
                    dgvPenjemputan.Columns["status"].Width = 120;
                }
                if (dgvPenjemputan.Columns.Contains("catatan"))
                {
                    dgvPenjemputan.Columns["catatan"].HeaderText = "Catatan";
                    dgvPenjemputan.Columns["catatan"].Width = 150;
                }
            }
            catch { }
        }

        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cmbNasabah.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtAlamat.Text) || string.IsNullOrWhiteSpace(txtNoHp.Text))
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Pilih Nasabah, isi Alamat Penjemputan dan No. HP/WA!", "Validasi Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal estBerat = 0;
            if (!string.IsNullOrWhiteSpace(txtEstimasiBerat.Text))
            {
                string bStr = txtEstimasiBerat.Text.Trim().Replace(",", ".");
                if (!decimal.TryParse(bStr, NumberStyles.Any, CultureInfo.InvariantCulture, out estBerat) || estBerat < 0)
                {
                    SoundHelper.PlayAlertSound();
                    MessageBox.Show("Estimasi berat sampah harus berupa angka yang valid (contoh: 15.5 atau 10)!", "Validasi Angka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEstimasiBerat.Focus();
                    txtEstimasiBerat.SelectAll();
                    return;
                }
            }

            string selected = cmbNasabah.SelectedItem.ToString();
            string kode = selected.Split('-')[0].Trim();
            int idNasabah = 1;
            string namaNasabah = "Nasabah";
            if (dtNasabahCache != null)
            {
                DataRow[] rows = dtNasabahCache.Select(string.Format("kode_nasabah='{0}'", kode));
                if (rows.Length > 0)
                {
                    idNasabah = Convert.ToInt32(rows[0]["id_nasabah"]);
                    namaNasabah = rows[0]["nama"].ToString();
                }
            }

            string kodeBooking = "PKP-" + DateTime.Now.ToString("yyyyMMdd") + "-" + (dgvPenjemputan.Rows.Count + 1).ToString("D3");
            string waktu = cmbWaktu.SelectedItem != null ? cmbWaktu.SelectedItem.ToString() : "09:00 - 10:30 WIB";
            string armada = string.IsNullOrWhiteSpace(txtArmada.Text) ? "Budi Santoso (Motor Roda Tiga)" : txtArmada.Text.Trim();
            string sampah = string.IsNullOrWhiteSpace(txtEstimasiSampah.Text) ? "Sampah Campur Terpilah" : txtEstimasiSampah.Text.Trim();
            string catatan = txtCatatan.Text.Trim();

            DataStore.AddPenjemputan(kodeBooking, idNasabah, namaNasabah, txtAlamat.Text.Trim(), txtNoHp.Text.Trim(), dtpTanggal.Value, waktu, armada, sampah, estBerat, catatan);

            SoundHelper.PlaySaveSound();
            MessageBox.Show(string.Format("Jadwal Penjemputan Berhasil Dibuat!\nKode Booking: {0}\nNasabah: {1}", kodeBooking, namaNasabah), "Penjemputan Terjadwal", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
            btnReset_Click(null, null);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (cmbNasabah.Items.Count > 0) cmbNasabah.SelectedIndex = 0;
            txtEstimasiSampah.Clear();
            txtEstimasiBerat.Clear();
            txtCatatan.Clear();
            dtpTanggal.Value = DateTime.Today;
            if (cmbWaktu.Items.Count > 0) cmbWaktu.SelectedIndex = 0;
        }

        private void btnSetDalamProses_Click(object sender, EventArgs e)
        {
            if (dgvPenjemputan.SelectedRows.Count == 0)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Pilih baris tiket penjemputan pada tabel terlebih dahulu!", "Pilih Tiket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvPenjemputan.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["id_penjemputan"].Value);
            string status = row.Cells["status"].Value.ToString();

            if (status == "Selesai")
            {
                MessageBox.Show("Penjemputan ini sudah Selesai!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataStore.UpdateStatusPenjemputan(id, "Dalam Penjemputan");
            SoundHelper.PlaySaveSound();
            MessageBox.Show("Status berhasil diubah menjadi 'Dalam Penjemputan'. Armada diberangkatkan!", "Armada Berangkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void btnBatalPenjemputan_Click(object sender, EventArgs e)
        {
            if (dgvPenjemputan.SelectedRows.Count == 0)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Pilih baris tiket penjemputan yang ingin dibatalkan!", "Pilih Tiket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvPenjemputan.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["id_penjemputan"].Value);
            string kode = row.Cells["kode_booking"].Value.ToString();

            if (MessageBox.Show("Yakin ingin membatalkan tiket penjemputan " + kode + "?", "Konfirmasi Batal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataStore.UpdateStatusPenjemputan(id, "Batal");
                SoundHelper.PlayAlertSound();
                LoadData();
            }
        }

        private void btnKonversiSetor_Click(object sender, EventArgs e)
        {
            if (dgvPenjemputan.SelectedRows.Count == 0)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Pilih tiket penjemputan yang sudah tiba di posko bank sampah!", "Pilih Tiket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvPenjemputan.SelectedRows[0];
            int idPenjemputan = Convert.ToInt32(row.Cells["id_penjemputan"].Value);
            string status = row.Cells["status"].Value.ToString();
            string kodeBooking = row.Cells["kode_booking"].Value.ToString();
            string namaNasabah = row.Cells["nama_nasabah"].Value.ToString();
            decimal estBerat = (row.Cells["estimasi_berat"].Value != null && row.Cells["estimasi_berat"].Value != DBNull.Value) ? Convert.ToDecimal(row.Cells["estimasi_berat"].Value) : 10m;

            if (status == "Selesai")
            {
                MessageBox.Show("Tiket penjemputan ini sudah selesai diproses dan telah menjadi transaksi setor!", "Sudah Selesai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Dialog konfirmasi berat riil & jenis sampah
            DataTable dtSampah = DataStore.GetSampah();
            if (dtSampah == null || dtSampah.Rows.Count == 0)
            {
                MessageBox.Show("Data master sampah belum tersedia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (Form modal = new Form())
            {
                modal.Text = "Konfirmasi Setoran Armada — " + kodeBooking;
                modal.Size = new Size(460, 330);
                modal.StartPosition = FormStartPosition.CenterParent;
                modal.FormBorderStyle = FormBorderStyle.FixedDialog;
                modal.MaximizeBox = false;
                modal.MinimizeBox = false;
                modal.BackColor = Color.White;

                Label lblHeader = new Label
                {
                    Text = "Konfirmasi Penimbangan Sampah Tiba",
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(22, 38, 31),
                    Location = new Point(20, 15),
                    AutoSize = true
                };

                Label lblSub = new Label
                {
                    Text = string.Format("Nasabah: {0} ({1})\nMasukkan jenis sampah dan berat riil hasil timbangan:", namaNasabah, kodeBooking),
                    Font = new Font("Segoe UI", 8.5F),
                    ForeColor = Color.FromArgb(75, 90, 82),
                    Location = new Point(20, 42),
                    Size = new Size(400, 34)
                };

                Label lblSampah = new Label { Text = "Jenis Sampah Terpilah:", Location = new Point(20, 86), AutoSize = true, Font = new Font("Segoe UI", 8.5F, FontStyle.Bold) };
                ComboBox cmbS = new ComboBox { Location = new Point(20, 106), Size = new Size(400, 24), DropDownStyle = ComboBoxStyle.DropDownList, Font = new Font("Segoe UI", 9F) };
                foreach (DataRow sr in dtSampah.Rows)
                {
                    decimal h = Convert.ToDecimal(sr["harga_per_kg"]);
                    cmbS.Items.Add(string.Format("{0} - {1} (Rp {2:N0}/kg)", sr["id_sampah"], sr["nama_sampah"], h));
                }
                if (cmbS.Items.Count > 0) cmbS.SelectedIndex = 0;

                Label lblBerat = new Label { Text = "Berat Timbangan Riil (Kg):", Location = new Point(20, 140), AutoSize = true, Font = new Font("Segoe UI", 8.5F, FontStyle.Bold) };
                TextBox txtB = new TextBox { Location = new Point(20, 160), Size = new Size(400, 24), Font = new Font("Segoe UI", 9F), Text = estBerat > 0 ? estBerat.ToString("N2") : "10.00" };
                UIHelper.AttachNumericOnly(txtB, true);

                Label lblEstimasiUang = new Label { Text = "Total Nilai Tabungan: Rp 0", Location = new Point(20, 195), AutoSize = true, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold), ForeColor = UIHelper.Teal };

                Action updateKalkulasi = () =>
                {
                    try
                    {
                        if (cmbS.SelectedIndex >= 0)
                        {
                            string sText = cmbS.SelectedItem.ToString();
                            int idS = Convert.ToInt32(sText.Split('-')[0].Trim());
                            DataRow[] sRows = dtSampah.Select("id_sampah=" + idS);
                            if (sRows.Length > 0)
                            {
                                decimal harga = Convert.ToDecimal(sRows[0]["harga_per_kg"]);
                                decimal berat = 0;
                                string bClean = txtB.Text.Replace(",", ".");
                                decimal.TryParse(bClean, NumberStyles.Any, CultureInfo.InvariantCulture, out berat);
                                decimal total = harga * berat;
                                lblEstimasiUang.Text = string.Format("Total Nilai Tabungan: Rp {0:N0}", total);
                            }
                        }
                    }
                    catch { }
                };

                cmbS.SelectedIndexChanged += (s2, e2) => updateKalkulasi();
                txtB.TextChanged += (s2, e2) => updateKalkulasi();
                updateKalkulasi();

                Button btnOk = new Button
                {
                    Text = "Proses Masuk Saldo",
                    Location = new Point(190, 235),
                    Size = new Size(140, 34),
                    BackColor = UIHelper.Teal,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    Cursor = Cursors.Hand
                };
                btnOk.FlatAppearance.BorderSize = 0;
                UIHelper.MakeRounded(btnOk, 6);

                btnOk.Click += (s2, e2) =>
                {
                    string bClean = txtB.Text.Trim().Replace(",", ".");
                    decimal beratVal = 0;
                    if (string.IsNullOrWhiteSpace(bClean) || !decimal.TryParse(bClean, NumberStyles.Any, CultureInfo.InvariantCulture, out beratVal) || beratVal <= 0)
                    {
                        SoundHelper.PlayAlertSound();
                        MessageBox.Show("Berat timbangan riil harus berupa angka positif yang valid (contoh: 12.5 atau 8)!\nHuruf dan teks lainnya tidak diperbolehkan.", "Validasi Angka Timbangan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtB.Focus();
                        txtB.SelectAll();
                        return;
                    }
                    modal.DialogResult = DialogResult.OK;
                    modal.Close();
                };

                Button btnCancel = new Button
                {
                    Text = "Batal",
                    DialogResult = DialogResult.Cancel,
                    Location = new Point(340, 235),
                    Size = new Size(80, 34),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 9F),
                    Cursor = Cursors.Hand
                };
                UIHelper.StyleButtonOutline(btnCancel);
                UIHelper.MakeRounded(btnCancel, 6);

                modal.Controls.Add(lblHeader);
                modal.Controls.Add(lblSub);
                modal.Controls.Add(lblSampah);
                modal.Controls.Add(cmbS);
                modal.Controls.Add(lblBerat);
                modal.Controls.Add(txtB);
                modal.Controls.Add(lblEstimasiUang);
                modal.Controls.Add(btnOk);
                modal.Controls.Add(btnCancel);
                modal.AcceptButton = btnOk;
                modal.CancelButton = btnCancel;

                if (modal.ShowDialog(this) == DialogResult.OK)
                {
                    string sText = cmbS.SelectedItem.ToString();
                    int idS = Convert.ToInt32(sText.Split('-')[0].Trim());
                    decimal berat = 0;
                    string bClean = txtB.Text.Replace(",", ".");
                    decimal.TryParse(bClean, NumberStyles.Any, CultureInfo.InvariantCulture, out berat);
                    if (berat <= 0) berat = 1m;

                    DataRow[] sRows = dtSampah.Select("id_sampah=" + idS);
                    decimal harga = Convert.ToDecimal(sRows[0]["harga_per_kg"]);
                    decimal total = harga * berat;

                    string newTrxCode;
                    bool success = DataStore.ConvertPenjemputanToSetor(idPenjemputan, idS, berat, total, "Penjemputan armada selesai & tertimbang", out newTrxCode);

                    if (success)
                    {
                        SoundHelper.PlaySaveSound();
                        MessageBox.Show(string.Format("Sukses! Transaksi Setor baru berhasil dibuat.\nKode Transaksi: {0}\nNilai Tambahan Saldo: Rp {1:N0}\nStatus Penjemputan kini 'Selesai'.", newTrxCode, total), "Penjemputan Sukses Dikonversi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        SoundHelper.PlayAlertSound();
                        MessageBox.Show("Gagal mengonversi penjemputan ke transaksi setor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvPenjemputan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnKonversiSetor_Click(null, null);
            }
        }

        private void btnCetakSuratTugas_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.DocumentName = "Surat_Tugas_Armada_SIMBAS";
                pd.PrintPage += (s, ev) =>
                {
                    Graphics g = ev.Graphics;
                    Font fTitle = new Font("Segoe UI", 14F, FontStyle.Bold);
                    Font fSub = new Font("Segoe UI", 9F, FontStyle.Regular);
                    Font fHead = new Font("Segoe UI", 9F, FontStyle.Bold);
                    Font fBody = new Font("Segoe UI", 8.5F, FontStyle.Regular);
                    Font fBadge = new Font("Segoe UI", 8F, FontStyle.Bold);

                    Brush bDark = new SolidBrush(Color.FromArgb(22, 38, 31));
                    Brush bGreen = new SolidBrush(UIHelper.Teal);
                    Pen penLine = new Pen(Color.FromArgb(199, 210, 194), 1);

                    int y = 40;
                    int left = 40;
                    int right = ev.PageBounds.Width - 40;

                    // Header
                    g.DrawString("SIMBAS — SURAT TUGAS & RUTE PENJEMPUTAN SAMPAH", fTitle, bGreen, left, y);
                    y += 26;
                    g.DrawString(string.Format("Tanggal Operasional: {0} | Petugas/Armada: Budi Santoso (Motor Roda Tiga)", DateTime.Today.ToString("dd MMMM yyyy")), fSub, bDark, left, y);
                    y += 20;
                    g.DrawString("Bank Sampah Digital (Waste Management Service) — Beroperasi Terstandarisasi ala Pastiklola", fSub, Brushes.Gray, left, y);
                    y += 24;

                    g.DrawLine(penLine, left, y, right, y);
                    y += 12;

                    // Table Headers
                    int[] colWidths = { 40, 110, 80, 130, 180, 95, 110 };
                    string[] headers = { "No", "Kode Booking", "Jam", "Nasabah", "Alamat Jemput", "Est. Berat", "Ttd Nasabah" };

                    int curX = left;
                    for (int i = 0; i < headers.Length; i++)
                    {
                        g.DrawString(headers[i], fHead, bDark, curX, y);
                        curX += colWidths[i];
                    }
                    y += 20;
                    g.DrawLine(penLine, left, y, right, y);
                    y += 10;

                    // Rows
                    DataTable dt = DataStore.GetPenjemputan();
                    int no = 1;
                    if (dt != null)
                    {
                        foreach (DataRow r in dt.Rows)
                        {
                            if (y > ev.PageBounds.Height - 120) break;

                            curX = left;
                            g.DrawString(no.ToString(), fBody, bDark, curX, y);
                            curX += colWidths[0];

                            g.DrawString(r["kode_booking"].ToString(), fHead, bGreen, curX, y);
                            curX += colWidths[1];

                            g.DrawString(r["waktu_jemput"].ToString(), fBody, bDark, curX, y);
                            curX += colWidths[2];

                            g.DrawString(r["nama_nasabah"].ToString(), fBody, bDark, curX, y);
                            curX += colWidths[3];

                            string alm = r["alamat_jemput"].ToString();
                            if (alm.Length > 24) alm = alm.Substring(0, 22) + "..";
                            g.DrawString(alm, fBody, bDark, curX, y);
                            curX += colWidths[4];

                            decimal eb = r["estimasi_berat"] != DBNull.Value ? Convert.ToDecimal(r["estimasi_berat"]) : 0;
                            g.DrawString(string.Format("{0:N1} kg", eb), fBody, bDark, curX, y);
                            curX += colWidths[5];

                            g.DrawString("[ ____________ ]", fBody, Brushes.Gray, curX, y);

                            y += 24;
                            no++;
                        }
                    }

                    y += 20;
                    g.DrawLine(penLine, left, y, right, y);
                    y += 20;

                    // Footer Signatures
                    int sigLeft = left + 40;
                    int sigRight = right - 220;
                    g.DrawString("Driver / Petugas Armada,", fSub, bDark, sigLeft, y);
                    g.DrawString("Koordinator Operasional,", fSub, bDark, sigRight, y);
                    y += 60;
                    g.DrawString("( Budi Santoso )", fHead, bDark, sigLeft, y);
                    g.DrawString("( Administrator SIMBAS )", fHead, bDark, sigRight, y);
                };

                PrintPreviewDialog ppd = new PrintPreviewDialog();
                ppd.Document = pd;
                ppd.Width = 850;
                ppd.Height = 650;
                ppd.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memproses pratinjau cetak: " + ex.Message, "Error Cetak", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
