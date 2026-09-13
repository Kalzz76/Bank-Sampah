using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace BankSampah
{
    public partial class FormPortalWarga : Form
    {
        private int activeNasabahId = 1;
        private DataTable dtAllNasabah = null;

        public FormPortalWarga()
        {
            InitializeComponent();
        }

        public FormPortalWarga(int initialNasabahId) : this()
        {
            this.activeNasabahId = initialNasabahId;
        }

        private void FormPortalWarga_Load(object sender, EventArgs e)
        {
            // Styling Rounded Panels
            UIHelper.MakeRounded(panelMyRank, 10);
            UIHelper.MakeRounded(panelPodium, 10);
            UIHelper.MakeRounded(pnlPodium1, 10);
            UIHelper.MakeRounded(pnlPodium2, 10);
            UIHelper.MakeRounded(pnlPodium3, 10);
            UIHelper.MakeRounded(pnlTierGuide, 10);
            UIHelper.MakeRounded(pnlWalletCard, 14);
            UIHelper.MakeRounded(pnlBadgeLevel, 10);
            UIHelper.MakeRounded(pnlEcoImpact, 10);
            UIHelper.MakeRounded(panelBookingForm, 10);
            UIHelper.MakeRounded(panelPickupList, 10);
            UIHelper.MakeRounded(panelMutasiWrapper, 10);
            UIHelper.MakeRounded(panelKatalogWrapper, 10);
            UIHelper.MakeRounded(btnMintaJemputQuick, 8);
            UIHelper.MakeRounded(btnCetakKartuMember, 8);
            UIHelper.MakeRounded(picMemberQrCode, 8);
            UIHelper.MakeRounded(btnKirimBooking, 8);
            UIHelper.MakeRounded(btnKeluar, 6);
            UIHelper.MakeRounded(lblMyRankNumber, 8);

            // Modern Grid Styles
            UIHelper.ApplyModernGridStyle(dgvLeaderboard);
            UIHelper.ApplyModernGridStyle(dgvMyPickups);
            UIHelper.ApplyModernGridStyle(dgvMutasi);
            UIHelper.ApplyModernGridStyle(dgvKatalog);
            dgvLeaderboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyPickups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMutasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKatalog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Validasi Input Angka Desimal
            UIHelper.AttachNumericOnly(txtEstimasiBerat, true);

            // Setup Tier Guide Text
            lblTierGuideInfo.Text = 
                "[★ Level 4] Pahlawan Lingkungan (≥ 150 kg)\n" +
                "Kasta tertinggi! Kontributor utama sirkular ekonomi dan inspirator kebersihan warga.\n\n" +
                "[◆ Level 3] Nasabah Hijau (≥ 50 kg)\n" +
                "Warga yang konsisten dan aktif memilah sampah anorganik skala rumah tangga secara rutin.\n\n" +
                "[▲ Level 2] Nasabah Peduli (≥ 15 kg)\n" +
                "Warga yang telah berkomitmen mengurangi sampah ke TPA melalui tabungan berkala.\n\n" +
                "[● Level 1] Nasabah Pemula (< 15 kg)\n" +
                "Langkah awal langkah hijau! Mulai menabung sampah dan rasakan manfaat ekonominya.";

            if (cboWaktuJemput.Items.Count > 0)
            {
                cboWaktuJemput.SelectedIndex = 0;
            }

            // Populate Nasabah Dropdown
            PopulateNasabahDropdown();

            // Default Tab: Leaderboard & Gelar Hijau
            SwitchTab(pnlLeaderboard, btnTabLeaderboard);
        }

        private void PopulateNasabahDropdown()
        {
            try
            {
                dtAllNasabah = DataStore.GetNasabah();
                cboPilihNasabah.Items.Clear();

                int selectedIdx = 0;
                if (dtAllNasabah != null && dtAllNasabah.Rows.Count > 0)
                {
                    for (int i = 0; i < dtAllNasabah.Rows.Count; i++)
                    {
                        DataRow r = dtAllNasabah.Rows[i];
                        int id = Convert.ToInt32(r["id_nasabah"]);
                        string nama = r["nama"].ToString();
                        string kode = r["kode_nasabah"].ToString();

                        cboPilihNasabah.Items.Add(string.Format("{0} ({1})", nama, kode));

                        if (id == activeNasabahId)
                        {
                            selectedIdx = i;
                        }
                    }

                    cboPilihNasabah.SelectedIndex = selectedIdx;
                }
            }
            catch { }
        }

        private void cboPilihNasabah_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtAllNasabah != null && cboPilihNasabah.SelectedIndex >= 0 && cboPilihNasabah.SelectedIndex < dtAllNasabah.Rows.Count)
            {
                activeNasabahId = Convert.ToInt32(dtAllNasabah.Rows[cboPilihNasabah.SelectedIndex]["id_nasabah"]);
                LoadAllWargaData();
            }
        }

        private void LoadAllWargaData()
        {
            try
            {
                if (dtAllNasabah == null) dtAllNasabah = DataStore.GetNasabah();
                DataRow myRow = null;
                if (dtAllNasabah != null)
                {
                    DataRow[] rows = dtAllNasabah.Select("id_nasabah=" + activeNasabahId);
                    if (rows.Length > 0) myRow = rows[0];
                }

                if (myRow == null) return;

                string nama = myRow["nama"].ToString();
                string kode = myRow["kode_nasabah"].ToString();
                string foto = myRow["foto"] != DBNull.Value ? myRow["foto"].ToString() : "";
                decimal saldo = myRow["saldo"] != DBNull.Value ? Convert.ToDecimal(myRow["saldo"]) : 0m;
                string alamat = myRow["alamat"] != DBNull.Value ? myRow["alamat"].ToString() : "";
                string noHp = myRow["no_hp"] != DBNull.Value ? myRow["no_hp"].ToString() : "";

                decimal totalKg = DataStore.GetTotalSampahNasabah(activeNasabahId);
                string badge = DataStore.GetBadgeNasabah(totalKg);

                // 1. Header Profile Box
                picUserAvatar.Image = UIHelper.GetCircularAvatar(foto, nama, 36);
                lblUserSaldo.Text = string.Format("Rp {0:N0}", saldo);

                // 2. Tab Beranda Data
                lblSaldoCard.Text = string.Format("Rp {0:N0}", saldo);
                lblKodeNasabahCard.Text = "KODE: " + kode;
                lblCurrentBadgeTitle.Text = badge;
                lblLevelProgress.Text = string.Format("Terkumpul: {0:N2} kg", totalKg);

                // Generate QR Code for Member Card
                try
                {
                    if (picMemberQrCode.Image != null)
                    {
                        var oldImg = picMemberQrCode.Image;
                        picMemberQrCode.Image = null;
                        oldImg.Dispose();
                    }
                    picMemberQrCode.Image = QRCodeHelper.GenerateQrCodeBitmap(kode, 95);
                }
                catch { }

                // Progress Leveling
                string nextBadge = "";
                decimal targetKg = 0m;
                decimal remainingKg = 0m;
                int progressPct = 0;

                if (totalKg < 15m)
                {
                    nextBadge = "[Level 2] Nasabah Peduli";
                    targetKg = 15m;
                    remainingKg = targetKg - totalKg;
                    progressPct = (int)((totalKg / targetKg) * 100m);
                }
                else if (totalKg < 50m)
                {
                    nextBadge = "[Level 3] Nasabah Hijau";
                    targetKg = 50m;
                    remainingKg = targetKg - totalKg;
                    progressPct = (int)(((totalKg - 15m) / (50m - 15m)) * 100m);
                }
                else if (totalKg < 150m)
                {
                    nextBadge = "[Level 4] Pahlawan Lingkungan";
                    targetKg = 150m;
                    remainingKg = targetKg - totalKg;
                    progressPct = (int)(((totalKg - 50m) / (150m - 50m)) * 100m);
                }
                else
                {
                    nextBadge = "[Level 4] Gelar Tertinggi (Grand Master)";
                    targetKg = 150m;
                    remainingKg = 0m;
                    progressPct = 100;
                }

                progressPct = Math.Min(100, Math.Max(0, progressPct));
                pgbLevel.Value = progressPct;
                lblLevelNext.Text = string.Format("Menuju: {0}", nextBadge);
                if (remainingKg > 0)
                {
                    lblLevelHint.Text = string.Format("Kumpulkan {0:N2} kg sampah lagi untuk naik gelar kehormatan!", remainingKg);
                }
                else
                {
                    lblLevelHint.Text = "Luar biasa! Anda telah mencapai gelar kehormatan tertinggi di Bank Sampah!";
                }

                // Eco-Impact
                decimal co2e = Math.Round(totalKg * 1.82m, 1);
                decimal trees = Math.Round(totalKg / 40.0m, 2);
                decimal energy = Math.Round(totalKg * 3.4m, 1);
                decimal water = Math.Round(totalKg * 25.0m, 0);

                lblEcoCo2.Text = string.Format("◆ Pengurangan Emisi CO2e: {0:N1} kg CO2e", co2e);
                lblEcoTrees.Text = string.Format("◆ Pohon Hutan Diselamatkan: {0:N2} Pohon", trees);
                lblEcoEnergy.Text = string.Format("◆ Energi Manufaktur Dihemat: {0:N1} kWh", energy);
                lblEcoWater.Text = string.Format("◆ Air Bersih Terlindungi: {0:N0} Liter", water);

                // 3. Tab Leaderboard Data
                LoadLeaderboardData(nama, badge, totalKg);

                // 4. Tab Jemput Data
                txtAlamatJemput.Text = alamat;
                txtNoHpJemput.Text = noHp;
                LoadPickupsData();

                // 5. Tab Mutasi Data
                LoadMutasiData();
                LoadKatalogData();
            }
            catch { }
        }

        private void LoadLeaderboardData(string myNama, string myBadge, decimal myTotalKg)
        {
            try
            {
                DataTable dtTop = DataStore.GetTopNasabahTeraktif(20);

                // Display DataTable for Grid
                DataTable dtGrid = new DataTable();
                dtGrid.Columns.Add("Peringkat", typeof(string));
                dtGrid.Columns.Add("Avatar", typeof(Image));
                dtGrid.Columns.Add("Nama Nasabah", typeof(string));
                dtGrid.Columns.Add("Kode", typeof(string));
                dtGrid.Columns.Add("Gelar Kehormatan", typeof(string));
                dtGrid.Columns.Add("Total Sampah (kg)", typeof(string));
                dtGrid.Columns.Add("Total Tabungan", typeof(string));

                int myRank = 1;
                int myFreq = 0;

                if (dtTop != null && dtTop.Rows.Count > 0)
                {
                    // Render Podium 3 Besar
                    if (dtTop.Rows.Count >= 1)
                    {
                        DataRow r1 = dtTop.Rows[0];
                        lblP1Nama.Text = r1["nama"].ToString();
                        decimal b1 = Convert.ToDecimal(r1["total_berat"]);
                        lblP1Kg.Text = string.Format("{0:N2} kg", b1);
                        lblP1Badge.Text = DataStore.GetBadgeNasabah(b1);
                        picP1Avatar.Image = UIHelper.GetCircularAvatar(r1["foto"].ToString(), r1["nama"].ToString(), 56);
                    }
                    if (dtTop.Rows.Count >= 2)
                    {
                        DataRow r2 = dtTop.Rows[1];
                        lblP2Nama.Text = r2["nama"].ToString();
                        decimal b2 = Convert.ToDecimal(r2["total_berat"]);
                        lblP2Kg.Text = string.Format("{0:N2} kg", b2);
                        lblP2Badge.Text = DataStore.GetBadgeNasabah(b2);
                        picP2Avatar.Image = UIHelper.GetCircularAvatar(r2["foto"].ToString(), r2["nama"].ToString(), 52);
                    }
                    if (dtTop.Rows.Count >= 3)
                    {
                        DataRow r3 = dtTop.Rows[2];
                        lblP3Nama.Text = r3["nama"].ToString();
                        decimal b3 = Convert.ToDecimal(r3["total_berat"]);
                        lblP3Kg.Text = string.Format("{0:N2} kg", b3);
                        lblP3Badge.Text = DataStore.GetBadgeNasabah(b3);
                        picP3Avatar.Image = UIHelper.GetCircularAvatar(r3["foto"].ToString(), r3["nama"].ToString(), 48);
                    }

                    // Populate Grid
                    foreach (DataRow r in dtTop.Rows)
                    {
                        int id = Convert.ToInt32(r["id_nasabah"]);
                        int rank = Convert.ToInt32(r["rank"]);
                        string medal = rank == 1 ? "★ [1] Juara 1" : (rank == 2 ? "◆ [2] Juara 2" : (rank == 3 ? "▲ [3] Juara 3" : string.Format("#{0}", rank)));

                        string nName = r["nama"].ToString();
                        decimal berat = Convert.ToDecimal(r["total_berat"]);
                        decimal uang = Convert.ToDecimal(r["total_setoran"]);
                        string bLevel = DataStore.GetBadgeNasabah(berat);

                        if (id == activeNasabahId)
                        {
                            myRank = rank;
                            myFreq = Convert.ToInt32(r["frekuensi"]);
                        }

                        Image avatarImg = UIHelper.GetCircularAvatar(r["foto"].ToString(), nName, 32);

                        dtGrid.Rows.Add(
                            medal,
                            avatarImg,
                            nName + (id == activeNasabahId ? " (Anda)" : ""),
                            r["kode_nasabah"].ToString(),
                            bLevel,
                            string.Format("{0:N2} kg", berat),
                            string.Format("Rp {0:N0}", uang)
                        );
                    }
                }

                dgvLeaderboard.DataSource = dtGrid;

                if (dgvLeaderboard.Columns.Contains("Avatar"))
                {
                    DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dgvLeaderboard.Columns["Avatar"];
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    dgvLeaderboard.Columns["Avatar"].Width = 45;
                }

                // Posisi Peringkat Anda Card
                lblMyRankNumber.Text = string.Format("#{0}", myRank);
                lblMyRankNama.Text = myNama;
                lblMyRankStat.Text = string.Format("Total: {0:N2} kg • {1} Kali Setor", myTotalKg, myFreq);
                lblMyRankBadge.Text = string.Format("Gelar: {0}", myBadge);
            }
            catch { }
        }

        private void LoadPickupsData()
        {
            try
            {
                DataTable dt = DataStore.GetPenjemputan();
                DataTable dtGrid = new DataTable();
                dtGrid.Columns.Add("Kode Booking", typeof(string));
                dtGrid.Columns.Add("Tanggal", typeof(string));
                dtGrid.Columns.Add("Waktu", typeof(string));
                dtGrid.Columns.Add("Sampah", typeof(string));
                dtGrid.Columns.Add("Estimasi (kg)", typeof(string));
                dtGrid.Columns.Add("Armada", typeof(string));
                dtGrid.Columns.Add("Status", typeof(string));

                if (dt != null)
                {
                    DataRow[] rows = dt.Select("id_nasabah=" + activeNasabahId, "id_penjemputan DESC");
                    foreach (DataRow r in rows)
                    {
                        dtGrid.Rows.Add(
                            r["kode_booking"].ToString(),
                            Convert.ToDateTime(r["tanggal_jemput"]).ToString("dd/MM/yyyy"),
                            r["waktu_jemput"].ToString(),
                            r["estimasi_sampah"].ToString(),
                            string.Format("{0:N2} kg", Convert.ToDecimal(r["estimasi_berat"])),
                            r["armada_petugas"].ToString(),
                            r["status"].ToString()
                        );
                    }
                }

                dgvMyPickups.DataSource = dtGrid;
            }
            catch { }
        }

        private void LoadMutasiData()
        {
            try
            {
                DataTable dt = DataStore.GetRiwayatTransaksiNasabah(activeNasabahId);
                DataTable dtGrid = new DataTable();
                dtGrid.Columns.Add("Kode Trx", typeof(string));
                dtGrid.Columns.Add("Tanggal", typeof(string));
                dtGrid.Columns.Add("Jenis", typeof(string));
                dtGrid.Columns.Add("Sampah", typeof(string));
                dtGrid.Columns.Add("Berat (kg)", typeof(string));
                dtGrid.Columns.Add("Nominal (Rp)", typeof(string));

                if (dt != null)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        bool isSetor = r["jenis_transaksi"].ToString() == "Setor";
                        string sign = isSetor ? "+ " : "- ";
                        decimal nominal = Convert.ToDecimal(r["total_harga"]);
                        decimal berat = r["berat_kg"] != DBNull.Value ? Convert.ToDecimal(r["berat_kg"]) : 0m;

                        dtGrid.Rows.Add(
                            r["kode_transaksi"].ToString(),
                            r["tanggal"] != DBNull.Value ? Convert.ToDateTime(r["tanggal"]).ToString("dd/MM/yyyy HH:mm") : "-",
                            r["jenis_transaksi"].ToString(),
                            r["nama_sampah"] != DBNull.Value ? r["nama_sampah"].ToString() : "-",
                            berat > 0 ? string.Format("{0:N2} kg", berat) : "-",
                            sign + string.Format("Rp {0:N0}", nominal)
                        );
                    }
                }

                dgvMutasi.DataSource = dtGrid;
            }
            catch { }
        }

        private void LoadKatalogData()
        {
            try
            {
                DataTable dt = DataStore.GetSampah();
                DataTable dtGrid = new DataTable();
                dtGrid.Columns.Add("Nama Sampah", typeof(string));
                dtGrid.Columns.Add("Kategori", typeof(string));
                dtGrid.Columns.Add("Sifat", typeof(string));
                dtGrid.Columns.Add("Harga Beli / kg", typeof(string));

                if (dt != null)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        dtGrid.Rows.Add(
                            r["nama_sampah"].ToString(),
                            r["kategori"].ToString(),
                            r["jenis_sampah"].ToString(),
                            string.Format("Rp {0:N0} / kg", Convert.ToDecimal(r["harga_per_kg"]))
                        );
                    }
                }

                dgvKatalog.DataSource = dtGrid;
            }
            catch { }
        }

        // ==========================================
        // TAB SWITCHING NAVIGATION
        // ==========================================
        private void SwitchTab(Panel targetPanel, Button targetButton)
        {
            // Reset buttons
            Button[] buttons = { btnTabLeaderboard, btnTabBeranda, btnTabJemput, btnTabMutasi };
            foreach (Button b in buttons)
            {
                b.BackColor = Color.White;
                b.ForeColor = UIHelper.InkSoft;
            }

            // Set active button
            targetButton.BackColor = UIHelper.Pine;
            targetButton.ForeColor = Color.White;

            // Hide all panels
            pnlLeaderboard.Visible = false;
            pnlBeranda.Visible = false;
            pnlJemput.Visible = false;
            pnlMutasi.Visible = false;

            // Show target
            targetPanel.Visible = true;
            targetPanel.Dock = DockStyle.Fill;
            targetPanel.BringToFront();
        }

        private void btnTabLeaderboard_Click(object sender, EventArgs e)
        {
            SwitchTab(pnlLeaderboard, btnTabLeaderboard);
        }

        private void btnTabBeranda_Click(object sender, EventArgs e)
        {
            SwitchTab(pnlBeranda, btnTabBeranda);
        }

        private void btnTabJemput_Click(object sender, EventArgs e)
        {
            SwitchTab(pnlJemput, btnTabJemput);
        }

        private void btnTabMutasi_Click(object sender, EventArgs e)
        {
            SwitchTab(pnlMutasi, btnTabMutasi);
        }

        private void btnMintaJemputQuick_Click(object sender, EventArgs e)
        {
            SwitchTab(pnlJemput, btnTabJemput);
        }

        private void btnKirimBooking_Click(object sender, EventArgs e)
        {
            string jenis = txtJenisSampah.Text.Trim();
            if (string.IsNullOrEmpty(jenis))
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Silakan sebutkan jenis sampah yang ingin dijemput!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJenisSampah.Focus();
                return;
            }

            decimal berat;
            if (!decimal.TryParse(txtEstimasiBerat.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out berat) || berat <= 0)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Masukkan perkiraan berat sampah yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstimasiBerat.Focus();
                return;
            }

            string alamat = txtAlamatJemput.Text.Trim();
            if (string.IsNullOrEmpty(alamat))
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Alamat penjemputan harus diisi lengkap!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAlamatJemput.Focus();
                return;
            }

            string noHp = txtNoHpJemput.Text.Trim();
            if (string.IsNullOrEmpty(noHp))
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Nomor WhatsApp/HP harus diisi agar petugas armada dapat menghubungi Anda!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoHpJemput.Focus();
                return;
            }

            string waktu = cboWaktuJemput.SelectedItem != null ? cboWaktuJemput.SelectedItem.ToString() : "Pagi (08:00 - 11:00)";
            string catatan = txtCatatanJemput.Text.Trim();
            if (string.IsNullOrEmpty(catatan)) catatan = "Booking mandiri via SIMBAS Warga";

            string namaNasabah = "Nasabah";
            if (dtAllNasabah != null)
            {
                DataRow[] rows = dtAllNasabah.Select("id_nasabah=" + activeNasabahId);
                if (rows.Length > 0) namaNasabah = rows[0]["nama"].ToString();
            }

            string kodeBooking = "PKP-" + DateTime.Now.ToString("yyyyMMdd") + "-" + (new Random().Next(100, 999));
            string armada = "Budi Santoso (Motor Roda Tiga)";

            DataStore.AddPenjemputan(kodeBooking, activeNasabahId, namaNasabah, alamat, noHp, DateTime.Now.Date, waktu, armada, jenis, berat, catatan);

            SoundHelper.PlaySaveSound();
            MessageBox.Show(
                string.Format("Pesanan Penjemputan Berhasil Dikirim!\n\nKode Booking: {0}\nArmada: {1}\nWaktu: {2}\n\nPetugas armada akan segera menuju lokasi Anda untuk menimbang di tempat.", kodeBooking, armada, waktu),
                "Penjemputan Berhasil Diajukan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            txtJenisSampah.Clear();
            txtEstimasiBerat.Clear();
            txtCatatanJemput.Clear();

            LoadPickupsData();
        }

        private void btnCetakKartuMember_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtAllNasabah == null) dtAllNasabah = DataStore.GetNasabah();
                DataRow myRow = null;
                if (dtAllNasabah != null)
                {
                    DataRow[] rows = dtAllNasabah.Select("id_nasabah=" + activeNasabahId);
                    if (rows.Length > 0) myRow = rows[0];
                }

                if (myRow == null) return;

                string nama = myRow["nama"].ToString();
                string kode = myRow["kode_nasabah"].ToString();
                string foto = myRow["foto"] != DBNull.Value ? myRow["foto"].ToString() : "";
                decimal saldo = myRow["saldo"] != DBNull.Value ? Convert.ToDecimal(myRow["saldo"]) : 0m;
                decimal totalKg = DataStore.GetTotalSampahNasabah(activeNasabahId);
                string badge = DataStore.GetBadgeNasabah(totalKg);

                Bitmap ktaCard = QRCodeHelper.GenerateMemberCard(nama, kode, badge, totalKg, saldo, foto);

                // Show interactive Preview Dialog
                using (Form dlg = new Form())
                {
                    dlg.Text = "Kartu Tanda Anggota Digital (KTA) — " + nama;
                    dlg.Size = new Size(680, 520);
                    dlg.StartPosition = FormStartPosition.CenterParent;
                    dlg.FormBorderStyle = FormBorderStyle.FixedDialog;
                    dlg.MaximizeBox = false;
                    dlg.MinimizeBox = false;
                    dlg.BackColor = Color.FromArgb(238, 242, 236);

                    PictureBox picCard = new PictureBox();
                    picCard.Location = new Point(12, 12);
                    picCard.Size = new Size(640, 390);
                    picCard.Image = ktaCard;
                    picCard.SizeMode = PictureBoxSizeMode.CenterImage;
                    UIHelper.MakeRounded(picCard, 12);
                    dlg.Controls.Add(picCard);

                    Button btnSave = new Button();
                    btnSave.Text = "💾 Simpan PNG";
                    btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                    btnSave.BackColor = Color.FromArgb(59, 122, 94);
                    btnSave.ForeColor = Color.White;
                    btnSave.FlatStyle = FlatStyle.Flat;
                    btnSave.FlatAppearance.BorderSize = 0;
                    btnSave.Size = new Size(150, 38);
                    btnSave.Location = new Point(12, 420);
                    UIHelper.MakeRounded(btnSave, 8);
                    btnSave.Click += (s, ev) =>
                    {
                        using (SaveFileDialog sfd = new SaveFileDialog())
                        {
                            sfd.Filter = "PNG Image|*.png";
                            sfd.FileName = string.Format("KTA_{0}_{1}.png", kode, nama.Replace(' ', '_'));
                            if (sfd.ShowDialog(dlg) == DialogResult.OK)
                            {
                                ktaCard.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                                SoundHelper.PlaySaveSound();
                                MessageBox.Show("Kartu Tanda Anggota berhasil disimpan ke:\n" + sfd.FileName, "Berhasil Disimpan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    };
                    dlg.Controls.Add(btnSave);

                    Button btnPrint = new Button();
                    btnPrint.Text = "🖨 Cetak KTA";
                    btnPrint.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                    btnPrint.BackColor = Color.FromArgb(201, 151, 31);
                    btnPrint.ForeColor = Color.White;
                    btnPrint.FlatStyle = FlatStyle.Flat;
                    btnPrint.FlatAppearance.BorderSize = 0;
                    btnPrint.Size = new Size(140, 38);
                    btnPrint.Location = new Point(172, 420);
                    UIHelper.MakeRounded(btnPrint, 8);
                    btnPrint.Click += (s, ev) =>
                    {
                        PrintDocument pd = new PrintDocument();
                        pd.PrintPage += (prSender, prEv) =>
                        {
                            prEv.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            int x = (prEv.PageBounds.Width - ktaCard.Width) / 2;
                            int y = 120;
                            prEv.Graphics.DrawImage(ktaCard, Math.Max(20, x), y, ktaCard.Width, ktaCard.Height);
                        };

                        using (PrintPreviewDialog ppd = new PrintPreviewDialog())
                        {
                            ppd.Document = pd;
                            ppd.Width = 800;
                            ppd.Height = 600;
                            ppd.StartPosition = FormStartPosition.CenterParent;
                            ppd.ShowDialog(dlg);
                        }
                    };
                    dlg.Controls.Add(btnPrint);

                    Button btnClose = new Button();
                    btnClose.Text = "Tutup";
                    btnClose.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
                    btnClose.BackColor = Color.White;
                    btnClose.ForeColor = Color.FromArgb(75, 90, 82);
                    btnClose.FlatStyle = FlatStyle.Flat;
                    btnClose.FlatAppearance.BorderSize = 0;
                    btnClose.Size = new Size(110, 38);
                    btnClose.Location = new Point(542, 420);
                    UIHelper.MakeRounded(btnClose, 8);
                    btnClose.Click += (s, ev) => dlg.Close();
                    dlg.Controls.Add(btnClose);

                    dlg.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka kartu anggota: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
