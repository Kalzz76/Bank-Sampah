using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace BankSampah
{
    public class SampahComboItem
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public decimal Harga { get; set; }

        public SampahComboItem(int id, string nama, decimal harga)
        {
            Id = id;
            Nama = nama;
            Harga = harga;
        }

        public override string ToString()
        {
            return string.Format("{0} — Rp {1:N0} / kg", Nama, Harga);
        }
    }

    public partial class FormPortalPetugas : Form
    {
        private DataTable dtNasabahList = null;
        private DataTable dtSampahList = null;
        private DataTable dtArmadaList = null;
        private DataRow activeNasabahRow = null;
        private bool isSyncingDropdown = false;

        private decimal currentHargaPerKg = 0m;
        private decimal currentSubtotal = 0m;

        // Print Struk State
        private string printKodeTrx = "";
        private string printTgl = "";
        private string printNasabah = "";
        private string printSampah = "";
        private string printBerat = "";
        private string printHargaKg = "";
        private string printTotal = "";
        private string printJenis = "Setor";
        private string printPetugas = "Petugas SIMBAS";
        private decimal printSaldoAkhir = 0m;

        // Armada State
        private int activePenjemputanId = 0;
        private string activeWargaNama = "";
        private string activeWargaHp = "";
        private string activeWargaAlamat = "";
        private decimal activeArmadaHargaKg = 0m;

        public FormPortalPetugas()
        {
            InitializeComponent();
        }

        private void FormPortalPetugas_Load(object sender, EventArgs e)
        {
            // Set User Info Petugas
            string userNama = !string.IsNullOrEmpty(DataStore.CurrentUserNama) ? DataStore.CurrentUserNama : "Ahmad Fauzi";
            string userRole = !string.IsNullOrEmpty(DataStore.CurrentUserRole) ? DataStore.CurrentUserRole : "Petugas Loket & Lapangan";
            lblPetugasName.Text = userNama;
            lblPetugasRole.Text = string.Format("Role: {0} (Shift Aktif)", userRole);
            picPetugasAvatar.Image = UIHelper.GetCircularAvatar(null, userNama, 44);

            // Styling Rounded Panels
            UIHelper.MakeRounded(panelHeader, 0);
            UIHelper.MakeRounded(panelScanQrBox, 10);
            UIHelper.MakeRounded(panelNasabahInfoBox, 10);
            UIHelper.MakeRounded(panelKasirBox, 10);
            UIHelper.MakeRounded(pnlSetorSection, 8);
            UIHelper.MakeRounded(pnlTarikSection, 8);
            UIHelper.MakeRounded(panelRiwayatLoket, 10);

            UIHelper.MakeRounded(pnlStatTotal, 10);
            UIHelper.MakeRounded(pnlStatMenunggu, 10);
            UIHelper.MakeRounded(pnlStatJalan, 10);
            UIHelper.MakeRounded(pnlStatSelesai, 10);
            UIHelper.MakeRounded(panelTabelArmada, 10);
            UIHelper.MakeRounded(panelAksiArmada, 10);

            // Styling Rounded Buttons
            UIHelper.MakeRounded(btnTabLoket, 8);
            UIHelper.MakeRounded(btnTabArmada, 8);
            UIHelper.MakeRounded(btnCariNasabah, 6);
            UIHelper.MakeRounded(btnScanKamera, 6);
            UIHelper.MakeRounded(btnModeSetor, 6);
            UIHelper.MakeRounded(btnModeTarik, 6);
            UIHelper.MakeRounded(btnSimpanSetor, 8);
            UIHelper.MakeRounded(btnProsesTarik, 8);
            UIHelper.MakeRounded(btnCetakStrukTerakhir, 6);
            UIHelper.MakeRounded(btnChatWa, 6);
            UIHelper.MakeRounded(btnMulaiJalan, 6);
            UIHelper.MakeRounded(btnSelesaiDanCairkan, 8);
            UIHelper.MakeRounded(btnTutup, 6);

            // Modern Grid Styles
            UIHelper.ApplyModernGridStyle(dgvTransaksiHariIni);
            UIHelper.ApplyModernGridStyle(dgvPenjemputan);
            dgvTransaksiHariIni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPenjemputan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTransaksiHariIni.SelectionChanged += new EventHandler(this.dgvTransaksiHariIni_SelectionChanged);

            // Numeric Validation
            UIHelper.AttachNumericOnly(txtBeratSetor, true);
            UIHelper.AttachNumericOnly(txtNominalTarik, false);
            UIHelper.AttachNumericOnly(txtBeratRealJemput, true);

            // Setup Filter Status Armada
            cboFilterArmadaStatus.Items.Clear();
            cboFilterArmadaStatus.Items.AddRange(new object[] { "Semua Status", "Menunggu", "Dalam Perjalanan", "Selesai" });
            cboFilterArmadaStatus.SelectedIndex = 0;

            // Load Comboboxes and Initial Data
            LoadSampahDropdowns();
            LoadNasabahDropdown();
            LoadTransaksiHariIni();

            // Default: Loket Tab Active & Setor Mode
            SwitchTab(pnlLoket, btnTabLoket);
            SetCashierMode(true);

            // Select first nasabah if available
            if (cboPilihNasabahManual.Items.Count > 0)
            {
                cboPilihNasabahManual.SelectedIndex = 0;
            }
        }

        #region Navigation & Mode Switch

        public void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnTabLoket_Click(object sender, EventArgs e)
        {
            SwitchTab(pnlLoket, btnTabLoket);
        }

        public void btnTabArmada_Click(object sender, EventArgs e)
        {
            SwitchTab(pnlArmada, btnTabArmada);
        }

        private void SwitchTab(Panel activePanel, Button activeTabBtn)
        {
            pnlLoket.Visible = (activePanel == pnlLoket);
            pnlArmada.Visible = (activePanel == pnlArmada);

            Color darkPine = Color.FromArgb(22, 38, 31);
            Color softBg = Color.FromArgb(235, 243, 238);

            if (activeTabBtn == btnTabLoket)
            {
                btnTabLoket.BackColor = darkPine;
                btnTabLoket.ForeColor = Color.White;
                btnTabArmada.BackColor = softBg;
                btnTabArmada.ForeColor = darkPine;
            }
            else
            {
                btnTabArmada.BackColor = darkPine;
                btnTabArmada.ForeColor = Color.White;
                btnTabLoket.BackColor = softBg;
                btnTabLoket.ForeColor = darkPine;

                LoadArmadaData();
            }
        }

        public void btnModeSetor_Click(object sender, EventArgs e)
        {
            SetCashierMode(true);
        }

        public void btnModeTarik_Click(object sender, EventArgs e)
        {
            SetCashierMode(false);
        }

        private void SetCashierMode(bool isSetor)
        {
            pnlSetorSection.Visible = isSetor;
            pnlTarikSection.Visible = !isSetor;

            if (isSetor)
            {
                btnModeSetor.BackColor = Color.FromArgb(59, 122, 94);
                btnModeSetor.ForeColor = Color.White;
                btnModeTarik.BackColor = Color.FromArgb(240, 243, 240);
                btnModeTarik.ForeColor = Color.FromArgb(40, 50, 45);
            }
            else
            {
                btnModeTarik.BackColor = Color.FromArgb(201, 151, 31);
                btnModeTarik.ForeColor = Color.FromArgb(36, 26, 2);
                btnModeSetor.BackColor = Color.FromArgb(240, 243, 240);
                btnModeSetor.ForeColor = Color.FromArgb(40, 50, 45);

                UpdateTarikSaldoInfo();
            }
        }

        #endregion

        #region Loket Front-Desk Logic

        private void LoadSampahDropdowns()
        {
            try
            {
                cboKomoditasSampah.Items.Clear();
                cboSampahArmada.Items.Clear();

                dtSampahList = DataStore.GetSampah();
                if (dtSampahList != null && dtSampahList.Rows.Count > 0)
                {
                    foreach (DataRow r in dtSampahList.Rows)
                    {
                        int id = Convert.ToInt32(r["id_sampah"]);
                        string nama = r["nama_sampah"].ToString();
                        decimal harga = 0m;
                        if (r.Table.Columns.Contains("harga_per_kg") && r["harga_per_kg"] != DBNull.Value)
                        {
                            harga = Convert.ToDecimal(r["harga_per_kg"]);
                        }
                        else if (r.Table.Columns.Contains("harga_beli") && r["harga_beli"] != DBNull.Value)
                        {
                            harga = Convert.ToDecimal(r["harga_beli"]);
                        }

                        cboKomoditasSampah.Items.Add(new SampahComboItem(id, nama, harga));
                        cboSampahArmada.Items.Add(new SampahComboItem(id, nama, harga));
                    }
                }

                if (cboKomoditasSampah.Items.Count > 0)
                {
                    cboKomoditasSampah.SelectedIndex = 0;
                }

                if (cboSampahArmada.Items.Count > 0)
                {
                    cboSampahArmada.SelectedIndex = 0;
                }
            }
            catch { }
        }

        private void LoadNasabahDropdown()
        {
            try
            {
                dtNasabahList = DataStore.GetNasabah();
                cboPilihNasabahManual.Items.Clear();

                if (dtNasabahList != null && dtNasabahList.Rows.Count > 0)
                {
                    foreach (DataRow r in dtNasabahList.Rows)
                    {
                        string nama = r["nama"].ToString();
                        string kode = r["kode_nasabah"].ToString();
                        cboPilihNasabahManual.Items.Add(string.Format("{0} ({1})", nama, kode));
                    }
                }
            }
            catch { }
        }

        public void cboPilihNasabahManual_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isSyncingDropdown) return;
            if (dtNasabahList != null && cboPilihNasabahManual.SelectedIndex >= 0 && cboPilihNasabahManual.SelectedIndex < dtNasabahList.Rows.Count)
            {
                DataRow r = dtNasabahList.Rows[cboPilihNasabahManual.SelectedIndex];
                DisplayNasabahProfile(r);
            }
        }

        public void txtScanQr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnCariNasabah_Click(sender, e);
            }
        }

        public void btnScanKamera_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menuScan = new ContextMenuStrip();
            menuScan.Font = new Font("Segoe UI", 9.5F);

            ToolStripMenuItem itemKamera = new ToolStripMenuItem("▶ Buka Kamera Webcam (Live Scanner)", null, (s, ev) =>
            {
                BukaScannerKamera();
            });
            itemKamera.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

            ToolStripMenuItem itemFile = new ToolStripMenuItem("Pindai dari File Foto KTA...", null, (s, ev) =>
            {
                BukaScannerFile();
            });

            ToolStripSeparator sep = new ToolStripSeparator();

            ToolStripMenuItem itemPanduan = new ToolStripMenuItem("Panduan Alat Scanner Barcode USB", null, (s, ev) =>
            {
                TampilkanPanduanScanner();
            });

            menuScan.Items.Add(itemKamera);
            menuScan.Items.Add(itemFile);
            menuScan.Items.Add(sep);
            menuScan.Items.Add(itemPanduan);

            menuScan.Show(btnScanKamera, 0, btnScanKamera.Height);
        }

        private void BukaScannerKamera()
        {
            try
            {
                string scriptPath = Path.Combine(Application.StartupPath, "Assets", "Scripts", "camera_scanner.py");
                if (!File.Exists(scriptPath))
                {
                    scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Assets\Scripts\camera_scanner.py");
                }

                if (!File.Exists(scriptPath))
                {
                    MessageBox.Show("Modul scanner kamera tidak ditemukan:\n" + scriptPath, "Scanner Kamera", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cursor.Current = Cursors.WaitCursor;

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = string.Format("\"{0}\"", Path.GetFullPath(scriptPath)),
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                bool scanSuccess = false;
                string detectedCode = null;
                string errorMessage = null;

                using (Process proc = Process.Start(psi))
                {
                    Cursor.Current = Cursors.Default;
                    string output = proc.StandardOutput.ReadToEnd();
                    proc.WaitForExit();

                    if (!string.IsNullOrEmpty(output))
                    {
                        foreach (string line in output.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
                        {
                            string trimmed = line.Trim();
                            if (trimmed.StartsWith("RESULT:"))
                            {
                                detectedCode = trimmed.Substring(7).Trim();
                                scanSuccess = true;
                                break;
                            }
                            else if (trimmed.StartsWith("ERROR_NO_CAMERA"))
                            {
                                errorMessage = "Kamera webcam tidak terdeteksi atau sedang aktif di aplikasi lain.\nPastikan webcam laptop menyala dan tidak digunakan aplikasi lain.";
                            }
                            else if (trimmed.StartsWith("ERROR:"))
                            {
                                errorMessage = trimmed.Substring(6).Trim();
                            }
                        }
                    }
                }

                if (scanSuccess && !string.IsNullOrEmpty(detectedCode))
                {
                    txtScanQr.Text = detectedCode;
                    DataRow foundRow = CariNasabahByKeyword(detectedCode);
                    if (foundRow != null)
                    {
                        DisplayNasabahProfile(foundRow);
                        SoundHelper.PlaySaveSound();
                        txtScanQr.Clear();

                        string nama = foundRow["nama"].ToString();
                        string kode = foundRow["kode_nasabah"].ToString();
                        decimal saldo = foundRow["saldo"] != DBNull.Value ? Convert.ToDecimal(foundRow["saldo"]) : 0m;

                        MessageBox.Show(
                            string.Format("Scan Kamera Berhasil!\n\n" +
                                          "Nama Nasabah   : {0}\n" +
                                          "Kode / ID      : {1}\n" +
                                          "Saldo Tabungan : Rp {2:N0}\n\n" +
                                          "Data nasabah telah dimuat dan siap untuk transaksi.",
                                          nama, kode, saldo),
                            "Pindai Kamera Sukses",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        SoundHelper.PlayAlertSound();
                        MessageBox.Show(
                            string.Format("Scan Kamera Berhasil Terbaca ({0}), namun nasabah tersebut tidak terdaftar di database SIMBAS.", detectedCode),
                            "Nasabah Tidak Ditemukan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }
                else if (!string.IsNullOrEmpty(errorMessage))
                {
                    SoundHelper.PlayAlertSound();
                    MessageBox.Show("Scan Kamera Gagal!\n\n" + errorMessage, "Kamera Tidak Terdeteksi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Gagal mengaktifkan scanner kamera:\n" + ex.Message + "\n\nCatatan: Pastikan Python dan modul OpenCV terpasang di komputer.", "Informasi Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BukaScannerFile()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Pilih Foto KTA / Gambar QR Code Nasabah";
                ofd.Filter = "File Gambar (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp|Semua File (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string scriptPath = Path.Combine(Application.StartupPath, "Assets", "Scripts", "camera_scanner.py");
                        if (!File.Exists(scriptPath))
                        {
                            scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Assets\Scripts\camera_scanner.py");
                        }

                        ProcessStartInfo psi = new ProcessStartInfo
                        {
                            FileName = "python",
                            Arguments = string.Format("\"{0}\" --file \"{1}\"", Path.GetFullPath(scriptPath), ofd.FileName),
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            CreateNoWindow = true
                        };

                        bool scanSuccess = false;
                        string detectedCode = null;
                        string errorMessage = null;

                        using (Process proc = Process.Start(psi))
                        {
                            string output = proc.StandardOutput.ReadToEnd();
                            proc.WaitForExit();

                            foreach (string line in output.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
                            {
                                string trimmed = line.Trim();
                                if (trimmed.StartsWith("RESULT:"))
                                {
                                    detectedCode = trimmed.Substring(7).Trim();
                                    scanSuccess = true;
                                    break;
                                }
                                else if (trimmed.StartsWith("ERROR:"))
                                {
                                    errorMessage = trimmed.Substring(6).Trim();
                                }
                            }
                        }

                        if (scanSuccess && !string.IsNullOrEmpty(detectedCode))
                        {
                            txtScanQr.Text = detectedCode;
                            DataRow foundRow = CariNasabahByKeyword(detectedCode);
                            if (foundRow != null)
                            {
                                DisplayNasabahProfile(foundRow);
                                SoundHelper.PlaySaveSound();
                                txtScanQr.Clear();

                                string nama = foundRow["nama"].ToString();
                                string kode = foundRow["kode_nasabah"].ToString();
                                decimal saldo = foundRow["saldo"] != DBNull.Value ? Convert.ToDecimal(foundRow["saldo"]) : 0m;

                                MessageBox.Show(
                                    string.Format("Scan KTA Berhasil!\n\n" +
                                                  "Nama Nasabah   : {0}\n" +
                                                  "Kode / ID      : {1}\n" +
                                                  "Saldo Tabungan : Rp {2:N0}\n\n" +
                                                  "Data nasabah telah dimuat dan siap untuk transaksi.",
                                                  nama, kode, saldo),
                                    "Pindai KTA Sukses",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );
                            }
                            else
                            {
                                SoundHelper.PlayAlertSound();
                                MessageBox.Show(
                                    string.Format("QR Code berhasil terbaca ({0}), namun nasabah tersebut tidak terdaftar di database SIMBAS.", detectedCode),
                                    "Nasabah Tidak Ditemukan",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );
                            }
                        }
                        else
                        {
                            SoundHelper.PlayAlertSound();
                            string msg = !string.IsNullOrEmpty(errorMessage)
                                ? errorMessage
                                : "Tidak ditemukan QR Code yang valid pada gambar tersebut.\nPastikan gambar kartu KTA tampak jelas dan tidak terpotong.";
                            MessageBox.Show("Scan KTA Gagal!\n\n" + msg, "Pindai Gambar KTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        SoundHelper.PlayAlertSound();
                        MessageBox.Show("Gagal memproses gambar KTA:\n" + ex.Message, "Error Pemindaian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void TampilkanPanduanScanner()
        {
            MessageBox.Show(
                "PANDUAN PEMINDAIAN KTA PETUGAS:\n\n" +
                "1. ALAT SCANNER FISIK (USB Gun / Barcode Scanner):\n" +
                "   • Hubungkan scanner barcode USB ke komputer/laptop.\n" +
                "   • Arahkan sinar scanner ke QR Code KTA nasabah (atau layar HP warga).\n" +
                "   • Scanner otomatis mengetik kode nasabah dan menekan Enter seketika!\n\n" +
                "2. KAMERA WEBCAM (Laptop / PC):\n" +
                "   • Klik tombol 'Scan Kamera' lalu pilih '▶ Buka Kamera Webcam'.\n" +
                "   • Arahkan QR Code KTA ke depan kamera laptop hingga kotak hijau terdeteksi.\n\n" +
                "3. SCAN DARI FILE FOTO:\n" +
                "   • Jika warga mengirim foto kartu KTA, simpan lalu klik 'Pindai dari File Foto KTA'.\n\n" +
                "4. KETIK MANUAL ATAU PILIH DAFTAR:\n" +
                "   • Ketik kode (misal NSB-003) di kotak input lalu klik 'Cari' atau pilih langsung nama warga dari dropdown di sebelah kanan.",
                "Panduan Scanner KTA SIMBAS",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public void btnCariNasabah_Click(object sender, EventArgs e)
        {
            string keyword = txtScanQr.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                SoundHelper.PlayAlertSound();
                DialogResult dr = MessageBox.Show(
                    "Kotak pencarian nasabah masih kosong.\n\n" +
                    "Apakah Anda ingin membuka Scanner Kamera Webcam sekarang?\n\n" +
                    "Tips Petugas:\n" +
                    "• Tembakkan alat Scanner Barcode USB ke QR KTA untuk scan otomatis.\n" +
                    "• Atau klik tombol 'Scan Kamera' untuk opsi kamera & scan dari foto.",
                    "Pindai / Cari Nasabah",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dr == DialogResult.Yes)
                {
                    BukaScannerKamera();
                }
                else
                {
                    txtScanQr.Focus();
                }
                return;
            }

            DataRow foundRow = CariNasabahByKeyword(keyword);
            if (foundRow != null)
            {
                DisplayNasabahProfile(foundRow);
                SoundHelper.PlaySaveSound();
                txtScanQr.Clear();
            }
            else
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show(string.Format("Nasabah dengan kata kunci '{0}' tidak ditemukan.\nPeriksa kembali kode QR atau gunakan daftar manual.", keyword), "Nasabah Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtScanQr.SelectAll();
                txtScanQr.Focus();
            }
        }

        private DataRow CariNasabahByKeyword(string keyword)
        {
            if (string.IsNullOrEmpty(keyword)) return null;

            if (dtNasabahList == null) dtNasabahList = DataStore.GetNasabah();

            foreach (DataRow r in dtNasabahList.Rows)
            {
                string kode = r["kode_nasabah"].ToString().Trim();
                string nama = r["nama"].ToString().Trim();
                string nik = r.Table.Columns.Contains("nik") ? r["nik"].ToString().Trim() : "";

                if (string.Equals(kode, keyword, StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(nama, keyword, StringComparison.OrdinalIgnoreCase) ||
                    kode.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    nama.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    nik.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    return r;
                }
            }
            return null;
        }

        private void DisplayNasabahProfile(DataRow r)
        {
            activeNasabahRow = r;
            if (r == null) return;

            int idNasabah = Convert.ToInt32(r["id_nasabah"]);
            string nama = r["nama"].ToString();
            string kode = r["kode_nasabah"].ToString();
            decimal saldo = r["saldo"] != DBNull.Value ? Convert.ToDecimal(r["saldo"]) : 0m;
            string foto = r.Table.Columns.Contains("foto") && r["foto"] != DBNull.Value ? r["foto"].ToString() : "";

            decimal totalKg = DataStore.GetTotalSampahNasabah(idNasabah);
            string badge = DataStore.GetBadgeNasabah(totalKg);

            lblNamaNasabah.Text = nama;
            lblKodeNasabah.Text = string.Format("ID: {0} (Aktif)", kode);
            lblGelarNasabah.Text = badge;
            lblSaldoNasabah.Text = string.Format("Rp {0:N0}", saldo);
            lblTotalKgNasabah.Text = string.Format("Setoran: {0:N2} kg", totalKg);

            picNasabahAvatar.Image = UIHelper.GetCircularAvatar(foto, nama, 64);

            // Sinkronisasi dropdown cboPilihNasabahManual agar ikut terpilih sesuai nasabah yang di-scan / dicari
            if (dtNasabahList != null && dtNasabahList.Rows.Count > 0)
            {
                for (int i = 0; i < dtNasabahList.Rows.Count; i++)
                {
                    if (string.Equals(dtNasabahList.Rows[i]["kode_nasabah"].ToString().Trim(), kode.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        if (cboPilihNasabahManual.SelectedIndex != i)
                        {
                            isSyncingDropdown = true;
                            cboPilihNasabahManual.SelectedIndex = i;
                            isSyncingDropdown = false;
                        }
                        break;
                    }
                }
            }

            UpdateTarikSaldoInfo();
        }

        private void UpdateTarikSaldoInfo()
        {
            if (activeNasabahRow != null)
            {
                decimal saldo = activeNasabahRow["saldo"] != DBNull.Value ? Convert.ToDecimal(activeNasabahRow["saldo"]) : 0m;
                lblInfoSaldoTarik.Text = string.Format("Maksimal Penarikan Tunai: Rp {0:N0}", saldo);
            }
            else
            {
                lblInfoSaldoTarik.Text = "Pilih / Scan Nasabah terlebih dahulu.";
            }
        }

        public void cboKomoditasSampah_SelectedIndexChanged(object sender, EventArgs e)
        {
            SampahComboItem item = cboKomoditasSampah.SelectedItem as SampahComboItem;
            if (item != null)
            {
                currentHargaPerKg = item.Harga;
                lblHargaPerKg.Text = string.Format("Tarif: Rp {0:N0} / kg", currentHargaPerKg);
                RecalculateSetor();
            }
        }

        public void txtBeratSetor_TextChanged(object sender, EventArgs e)
        {
            RecalculateSetor();
        }

        public void txtBeratSetor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSimpanSetor_Click(sender, e);
            }
        }

        private void RecalculateSetor()
        {
            decimal berat = 0m;
            decimal.TryParse(txtBeratSetor.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out berat);
            currentSubtotal = berat * currentHargaPerKg;
            lblSubtotalSetor.Text = string.Format("Total Masuk Saldo: Rp {0:N0}", currentSubtotal);
        }

        public void btnSimpanSetor_Click(object sender, EventArgs e)
        {
            if (activeNasabahRow == null)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Silakan scan QR code atau pilih nasabah terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtScanQr.Focus();
                return;
            }

            SampahComboItem item = cboKomoditasSampah.SelectedItem as SampahComboItem;
            if (item == null)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Pilih komoditas jenis sampah yang disetor!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal berat = 0m;
            if (!decimal.TryParse(txtBeratSetor.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out berat) || berat <= 0m)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Masukkan berat sampah yang valid (> 0 kg)!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBeratSetor.Focus();
                return;
            }

            string kodeNasabah = activeNasabahRow["kode_nasabah"].ToString();
            int idSampah = item.Id;
            string namaSampah = item.Nama;
            string catatan = string.Format("Setor langsung di Loket SIMBAS ({0} kg @ Rp {1:N0})", berat.ToString("N2"), currentHargaPerKg);

            DataStore.AddTransaksiSetor(kodeNasabah, idSampah, berat, currentSubtotal, catatan);

            // Record data for printing
            printKodeTrx = "TRX-" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
            printTgl = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            printNasabah = string.Format("{0} ({1})", activeNasabahRow["nama"], kodeNasabah);
            printSampah = namaSampah;
            printBerat = string.Format("{0:N2} kg", berat);
            printHargaKg = string.Format("Rp {0:N0}", currentHargaPerKg);
            printTotal = string.Format("Rp {0:N0}", currentSubtotal);
            printJenis = "Setor";
            printPetugas = lblPetugasName.Text;

            // Refresh Nasabah Data & Balance
            dtNasabahList = DataStore.GetNasabah();
            DataRow[] updated = dtNasabahList.Select(string.Format("kode_nasabah='{0}'", kodeNasabah));
            if (updated.Length > 0)
            {
                DisplayNasabahProfile(updated[0]);
                printSaldoAkhir = Convert.ToDecimal(updated[0]["saldo"]);
            }

            SoundHelper.PlaySaveSound();
            var res = MessageBox.Show(
                string.Format("Setoran Sampah Berhasil Disimpan!\n\nNasabah: {0}\nKomoditas: {1} ({2:N2} kg)\nTotal Ditabungkan: Rp {3:N0}\n\nApakah Anda ingin langsung mencetak struk bukti setoran?", activeNasabahRow["nama"], namaSampah, berat, currentSubtotal),
                "Transaksi Berhasil",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

            txtBeratSetor.Text = "1";
            LoadTransaksiHariIni();

            if (res == DialogResult.Yes)
            {
                CetakStruk(printKodeTrx, printTgl, printNasabah, printSampah, printBerat, printHargaKg, printTotal, printJenis, printPetugas, printSaldoAkhir);
            }
        }

        public void btnProsesTarik_Click(object sender, EventArgs e)
        {
            if (activeNasabahRow == null)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Silakan scan QR code atau pilih nasabah terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtScanQr.Focus();
                return;
            }

            decimal saldoSaatIni = activeNasabahRow["saldo"] != DBNull.Value ? Convert.ToDecimal(activeNasabahRow["saldo"]) : 0m;

            decimal nominalTarik = 0m;
            if (!decimal.TryParse(txtNominalTarik.Text.Replace(".", "").Replace(",", ""), out nominalTarik) || nominalTarik <= 0m)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Masukkan nominal penarikan tunai yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNominalTarik.Focus();
                return;
            }

            if (nominalTarik > saldoSaatIni)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show(string.Format("Saldo nasabah tidak mencukupi!\nSaldo saat ini: Rp {0:N0}\nNominal ditarik: Rp {1:N0}", saldoSaatIni, nominalTarik), "Penarikan Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNominalTarik.Focus();
                return;
            }

            string kodeNasabah = activeNasabahRow["kode_nasabah"].ToString();
            string catatan = string.Format("Penarikan tunai di Loket SIMBAS sebesar Rp {0:N0}", nominalTarik);

            DataStore.AddTransaksiTarik(kodeNasabah, nominalTarik, catatan);

            // Print info
            printKodeTrx = "TRX-" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
            printTgl = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            printNasabah = string.Format("{0} ({1})", activeNasabahRow["nama"], kodeNasabah);
            printSampah = "- (Tarik Tunai)";
            printBerat = "-";
            printHargaKg = "-";
            printTotal = string.Format("Rp {0:N0}", nominalTarik);
            printJenis = "Tarik Tunai";
            printPetugas = lblPetugasName.Text;

            // Refresh Nasabah
            dtNasabahList = DataStore.GetNasabah();
            DataRow[] updated = dtNasabahList.Select(string.Format("kode_nasabah='{0}'", kodeNasabah));
            if (updated.Length > 0)
            {
                DisplayNasabahProfile(updated[0]);
                printSaldoAkhir = Convert.ToDecimal(updated[0]["saldo"]);
            }

            SoundHelper.PlaySaveSound();
            var res = MessageBox.Show(
                string.Format("Penarikan Tunai Berhasil Diproses!\n\nNasabah: {0}\nNominal Ditarik: Rp {1:N0}\nSisa Saldo: Rp {2:N0}\n\nCetak bukti penarikan tunai?", activeNasabahRow["nama"], nominalTarik, printSaldoAkhir),
                "Penarikan Sukses",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

            txtNominalTarik.Clear();
            LoadTransaksiHariIni();

            if (res == DialogResult.Yes)
            {
                CetakStruk(printKodeTrx, printTgl, printNasabah, printSampah, printBerat, printHargaKg, printTotal, printJenis, printPetugas, printSaldoAkhir);
            }
        }

        private void LoadTransaksiHariIni()
        {
            try
            {
                DataTable dtTrx = DataStore.GetTransaksi();
                if (dtTrx != null)
                {
                    dgvTransaksiHariIni.DataSource = dtTrx;
                    UIHelper.FormatGridColumns(dgvTransaksiHariIni);

                    decimal sumSetor = 0m;
                    int countHariIni = dtTrx.Rows.Count;
                    foreach (DataRow r in dtTrx.Rows)
                    {
                        if (r["total_harga"] != DBNull.Value)
                        {
                            sumSetor += Convert.ToDecimal(r["total_harga"]);
                        }
                    }
                    lblTotalTransaksiHariIni.Text = string.Format("Total: {0} Transaksi (Perputaran: Rp {1:N0})", countHariIni, sumSetor);
                }
            }
            catch { }
        }

        private void dgvTransaksiHariIni_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTransaksiHariIni.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvTransaksiHariIni.SelectedRows[0];
                printKodeTrx = GetCellValue(row, "kode_transaksi");
                printTgl = GetCellValue(row, "tanggal");
                printNasabah = GetCellValue(row, "nama_nasabah", "nama");
                printSampah = GetCellValue(row, "nama_sampah");
                printBerat = GetCellValue(row, "berat_kg") + " kg";
                printTotal = "Rp " + GetCellValue(row, "total_harga");
                printJenis = GetCellValue(row, "jenis_transaksi");
                printPetugas = GetCellValue(row, "petugas", "username");
                if (string.IsNullOrEmpty(printPetugas)) printPetugas = lblPetugasName.Text;
            }
        }

        private string GetCellValue(DataGridViewRow row, params string[] colNames)
        {
            foreach (string col in colNames)
            {
                if (row.DataGridView.Columns.Contains(col))
                {
                    object val = row.Cells[col].Value;
                    if (val != null && val != DBNull.Value) return val.ToString();
                }
            }
            return "-";
        }

        public void btnCetakStrukTerakhir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(printKodeTrx))
            {
                if (dgvTransaksiHariIni.Rows.Count > 0)
                {
                    dgvTransaksiHariIni.Rows[0].Selected = true;
                    dgvTransaksiHariIni_SelectionChanged(null, null);
                }
                else
                {
                    SoundHelper.PlayAlertSound();
                    MessageBox.Show("Belum ada data transaksi yang dapat dicetak!", "Cetak Struk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            CetakStruk(printKodeTrx, printTgl, printNasabah, printSampah, printBerat, printHargaKg, printTotal, printJenis, printPetugas, printSaldoAkhir);
        }

        private void CetakStruk(string kodeTrx, string tgl, string nasabah, string sampah, string berat, string hargaKg, string total, string jenis, string petugas, decimal saldoAkhir)
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.DefaultPageSettings.PaperSize = new PaperSize("Thermal80mm", 315, 620);
                pd.PrintPage += (s, ev) =>
                {
                    Graphics g = ev.Graphics;
                    Font fTitle = new Font("Segoe UI", 12F, FontStyle.Bold);
                    Font fSub = new Font("Segoe UI", 8F, FontStyle.Regular);
                    Font fBold = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                    Font fNormal = new Font("Segoe UI", 8.5F, FontStyle.Regular);
                    Font fTotal = new Font("Segoe UI", 13F, FontStyle.Bold);
                    Brush bPine = new SolidBrush(Color.FromArgb(22, 38, 31));
                    Brush bTeal = new SolidBrush(Color.FromArgb(59, 122, 94));
                    Pen penDash = new Pen(Color.FromArgb(180, 190, 180), 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };

                    int x = 15;
                    int y = 18;
                    int w = 270;
                    StringFormat sfCenter = new StringFormat { Alignment = StringAlignment.Center };
                    StringFormat sfRight = new StringFormat { Alignment = StringAlignment.Far };

                    // Header
                    g.DrawString("SIMBAS DIGITAL", fTitle, bTeal, new RectangleF(x, y, w, 22), sfCenter);
                    y += 22;
                    g.DrawString("BANK SAMPAH BERKAH MANDIRI", fBold, bPine, new RectangleF(x, y, w, 16), sfCenter);
                    y += 16;
                    g.DrawString("Loket Layanan Mandiri & Armada Lapangan", fSub, Brushes.Gray, new RectangleF(x, y, w, 14), sfCenter);
                    y += 18;
                    g.DrawLine(penDash, x, y, x + w, y);
                    y += 10;

                    // Info Metadata
                    g.DrawString("No. Trx   : " + kodeTrx, fBold, bPine, x, y);
                    y += 16;
                    g.DrawString("Waktu     : " + tgl, fNormal, bPine, x, y);
                    y += 16;
                    g.DrawString("Petugas   : " + petugas, fNormal, bPine, x, y);
                    y += 16;
                    g.DrawString("Nasabah   : " + nasabah, fBold, bTeal, x, y);
                    y += 16;
                    g.DrawString("Operasi   : " + jenis.ToUpper(), fBold, (jenis.IndexOf("Tarik", StringComparison.OrdinalIgnoreCase) >= 0) ? Brushes.Firebrick : bTeal, x, y);
                    y += 18;
                    g.DrawLine(penDash, x, y, x + w, y);
                    y += 10;

                    // Rincian Item
                    g.DrawString("Rincian Transaksi:", fBold, bPine, x, y);
                    y += 16;
                    g.DrawString(sampah, fNormal, bPine, x, y);
                    g.DrawString(berat, fNormal, bPine, new RectangleF(x, y, w, 16), sfRight);
                    y += 16;
                    if (hargaKg != "-")
                    {
                        g.DrawString("@ " + hargaKg, fSub, Brushes.Gray, x, y);
                        y += 14;
                    }

                    g.DrawLine(penDash, x, y, x + w, y);
                    y += 8;

                    // Total
                    g.DrawString("TOTAL TRANSAKSI", fBold, bPine, x, y + 4);
                    g.DrawString(total, fTotal, bTeal, new RectangleF(x, y, w, 22), sfRight);
                    y += 26;

                    if (saldoAkhir > 0)
                    {
                        g.DrawString("Sisa Saldo Nasabah : Rp " + saldoAkhir.ToString("N0"), fBold, bPine, x, y);
                        y += 18;
                    }

                    g.DrawLine(penDash, x, y, x + w, y);
                    y += 12;

                    // Footer
                    g.DrawString("Terima Kasih Atas Kontribusi Anda!", fBold, bPine, new RectangleF(x, y, w, 16), sfCenter);
                    y += 16;
                    g.DrawString("Sampah Anda Menyelamatkan Bumi & Bernilai Rupiah", fSub, Brushes.Gray, new RectangleF(x, y, w, 14), sfCenter);
                    y += 14;
                    g.DrawString("simbas-banksampah.go.id", fSub, bTeal, new RectangleF(x, y, w, 14), sfCenter);
                };

                PrintPreviewDialog ppd = new PrintPreviewDialog();
                ppd.Document = pd;
                ppd.Width = 460;
                ppd.Height = 650;
                ppd.StartPosition = FormStartPosition.CenterParent;
                ppd.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka struk: " + ex.Message, "Error Cetak", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Armada Field Logic

        private void LoadArmadaData()
        {
            try
            {
                dtArmadaList = DataStore.GetPenjemputan();

                // Update Status KPIs
                int tot = 0, tunggu = 0, jalan = 0, selesai = 0;
                if (dtArmadaList != null)
                {
                    tot = dtArmadaList.Rows.Count;
                    foreach (DataRow r in dtArmadaList.Rows)
                    {
                        string st = r["status"].ToString().Trim();
                        if (string.Equals(st, "Menunggu", StringComparison.OrdinalIgnoreCase)) tunggu++;
                        else if (string.Equals(st, "Dalam Perjalanan", StringComparison.OrdinalIgnoreCase)) jalan++;
                        else if (string.Equals(st, "Selesai", StringComparison.OrdinalIgnoreCase)) selesai++;
                    }
                }

                lblStatTotalVal.Text = tot.ToString();
                lblStatMenungguVal.Text = tunggu.ToString();
                lblStatJalanVal.Text = jalan.ToString();
                lblStatSelesaiVal.Text = selesai.ToString();

                FilterArmadaTable();
            }
            catch { }
        }

        public void cboFilterArmadaStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterArmadaTable();
        }

        private void FilterArmadaTable()
        {
            if (dtArmadaList == null) return;

            string selected = cboFilterArmadaStatus.SelectedItem != null ? cboFilterArmadaStatus.SelectedItem.ToString() : "Semua Status";
            if (selected == "Semua Status")
            {
                dgvPenjemputan.DataSource = dtArmadaList;
            }
            else
            {
                DataView dv = dtArmadaList.DefaultView;
                dv.RowFilter = string.Format("status = '{0}'", selected);
                dgvPenjemputan.DataSource = dv;
            }

            UIHelper.FormatGridColumns(dgvPenjemputan);
        }

        public void dgvPenjemputan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPenjemputan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvPenjemputan.SelectedRows[0];
                activePenjemputanId = Convert.ToInt32(row.Cells["id_penjemputan"].Value);
                activeWargaNama = row.Cells["nama_nasabah"].Value.ToString();
                activeWargaAlamat = row.Cells["alamat_jemput"].Value.ToString();
                activeWargaHp = row.Cells["no_hp"].Value.ToString();
                string booking = row.Cells["kode_booking"].Value.ToString();
                string status = row.Cells["status"].Value.ToString();
                object estB = row.Cells["estimasi_berat"].Value;

                lblDetailWargaJemput.Text = string.Format("Warga: {0} ({1})\nBooking: {2} | Status: {3}", activeWargaNama, activeWargaHp, booking, status);
                lblDetailAlamatJemput.Text = string.Format("Alamat: {0}", activeWargaAlamat);

                if (estB != null && estB != DBNull.Value)
                {
                    txtBeratRealJemput.Text = Convert.ToDecimal(estB).ToString("N2", CultureInfo.InvariantCulture);
                }

                // Otomatis sinkronkan jenis sampah final sesuai pesanan antrean warga
                if (row.Cells["estimasi_sampah"] != null && row.Cells["estimasi_sampah"].Value != null && row.Cells["estimasi_sampah"].Value != DBNull.Value)
                {
                    string estSampah = row.Cells["estimasi_sampah"].Value.ToString().Trim();
                    SelectMatchingSampahArmada(estSampah);
                    lblSampahArmada.Text = "Jenis Sampah Final (Sesuai Antrean) *";
                }
                else
                {
                    lblSampahArmada.Text = "Jenis Sampah Final *";
                }

                btnMulaiJalan.Enabled = (status == "Menunggu");
                btnSelesaiDanCairkan.Enabled = (status != "Selesai");
            }
        }

        private void SelectMatchingSampahArmada(string estSampah)
        {
            if (string.IsNullOrWhiteSpace(estSampah) || cboSampahArmada.Items.Count == 0) return;

            string targetNama = estSampah.Trim();
            int rpIdx = targetNama.IndexOf(" (Rp", StringComparison.OrdinalIgnoreCase);
            if (rpIdx > 0)
            {
                targetNama = targetNama.Substring(0, rpIdx).Trim();
            }

            // 1. Exact match nama bersih atau teks lengkap
            for (int i = 0; i < cboSampahArmada.Items.Count; i++)
            {
                SampahComboItem item = cboSampahArmada.Items[i] as SampahComboItem;
                if (item != null)
                {
                    if (string.Equals(item.Nama.Trim(), targetNama, StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(item.Nama.Trim(), estSampah.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        cboSampahArmada.SelectedIndex = i;
                        return;
                    }
                }
            }

            // 2. Contains match (targetNama mengandung nama item atau sebaliknya)
            for (int i = 0; i < cboSampahArmada.Items.Count; i++)
            {
                SampahComboItem item = cboSampahArmada.Items[i] as SampahComboItem;
                if (item != null)
                {
                    string itemNama = item.Nama.Trim();
                    if (targetNama.IndexOf(itemNama, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        itemNama.IndexOf(targetNama, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        cboSampahArmada.SelectedIndex = i;
                        return;
                    }
                }
            }

            // 3. Keyword matching per kata (misal: "Besi", "Plastik", "Kardus", "Minyak", "Kaca", "Logam")
            string[] keywords = targetNama.Split(new char[] { ' ', '/', '&', '-', ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < cboSampahArmada.Items.Count; i++)
            {
                SampahComboItem item = cboSampahArmada.Items[i] as SampahComboItem;
                if (item != null)
                {
                    foreach (string kw in keywords)
                    {
                        if (kw.Length >= 3 && item.Nama.IndexOf(kw, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            cboSampahArmada.SelectedIndex = i;
                            return;
                        }
                    }
                }
            }
        }

        public void btnChatWa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(activeWargaHp) || activeWargaHp == "-")
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Pilih pesanan penjemputan dengan nomor WhatsApp yang valid terlebih dahulu!", "WhatsApp Warga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cleanPhone = activeWargaHp.Trim().Replace("-", "").Replace(" ", "").Replace("+", "");
            if (cleanPhone.StartsWith("0"))
            {
                cleanPhone = "62" + cleanPhone.Substring(1);
            }

            string textMessage = Uri.EscapeDataString(string.Format("Halo Bapak/Ibu {0}, kami dari Tim Armada SIMBAS Bank Sampah sedang menuju ke lokasi Anda ({1}) untuk melakukan penjemputan & penimbangan sampah. Mohon siapkan sampahnya ya. Terima kasih!", activeWargaNama, activeWargaAlamat));
            string url = string.Format("https://wa.me/{0}?text={1}", cleanPhone, textMessage);

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka browser/WhatsApp: " + ex.Message, "WhatsApp Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnMulaiJalan_Click(object sender, EventArgs e)
        {
            if (activePenjemputanId <= 0)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Pilih pesanan penjemputan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataStore.UpdateStatusPenjemputan(activePenjemputanId, "Dalam Perjalanan");
            SoundHelper.PlaySaveSound();
            MessageBox.Show(string.Format("Status Penjemputan diubah menjadi 'Dalam Perjalanan'.\nArmada sedang menuju lokasi {0}.", activeWargaNama), "Status Diperbarui", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadArmadaData();
        }

        public void cboSampahArmada_SelectedIndexChanged(object sender, EventArgs e)
        {
            SampahComboItem item = cboSampahArmada.SelectedItem as SampahComboItem;
            if (item != null)
            {
                activeArmadaHargaKg = item.Harga;
                RecalculateArmadaPencairan();
            }
        }

        public void txtBeratRealJemput_TextChanged(object sender, EventArgs e)
        {
            RecalculateArmadaPencairan();
        }

        private void RecalculateArmadaPencairan()
        {
            decimal beratReal = 0m;
            decimal.TryParse(txtBeratRealJemput.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out beratReal);
            decimal totalCair = beratReal * activeArmadaHargaKg;
            lblPencairanSaldoArmada.Text = string.Format("Total Masuk Saldo: Rp {0:N0}", totalCair);
        }

        public void btnSelesaiDanCairkan_Click(object sender, EventArgs e)
        {
            if (activePenjemputanId <= 0)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Pilih pesanan penjemputan yang ingin diselesaikan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal beratReal = 0m;
            if (!decimal.TryParse(txtBeratRealJemput.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out beratReal) || beratReal <= 0m)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Masukkan hasil timbang riil di tempat (> 0 kg)!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBeratRealJemput.Focus();
                return;
            }

            SampahComboItem item = cboSampahArmada.SelectedItem as SampahComboItem;
            if (item == null)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Pilih jenis komoditas sampah yang ditimbang!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idSampah = item.Id;
            string namaSampah = item.Nama;
            decimal totalCair = beratReal * activeArmadaHargaKg;

            var confirm = MessageBox.Show(
                string.Format("Konfirmasi Timbang di Lokasi:\n\nWarga: {0}\nKomoditas: {1}\nBerat Riil: {2:N2} kg\nNilai Pencairan: Rp {3:N0}\n\nApakah Anda yakin ingin menyelesaikan pesanan dan langsung mencairkan saldo ke akun warga?", activeWargaNama, namaSampah, beratReal, totalCair),
                "Konfirmasi Timbang & Pencairan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            string kodeTrxBaru = "";
            string catatan = string.Format("Penimbangan langsung di tempat oleh Armada ({0} kg @ Rp {1:N0})", beratReal.ToString("N2"), activeArmadaHargaKg);

            bool success = DataStore.ConvertPenjemputanToSetor(activePenjemputanId, idSampah, beratReal, totalCair, catatan, out kodeTrxBaru);

            if (success)
            {
                SoundHelper.PlaySaveSound();
                MessageBox.Show(
                    string.Format("Penjemputan Selesai & Saldo Berhasil Dicairkan!\n\nNo. Transaksi Setor: {0}\nWarga: {1}\nSaldo Masuk: Rp {2:N0}", kodeTrxBaru, activeWargaNama, totalCair),
                    "Penjemputan Tuntas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadArmadaData();
                LoadTransaksiHariIni();
            }
            else
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Terjadi kendala saat memproses konversi penjemputan ke transaksi setor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
