using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;

namespace BankSampah
{
    public partial class FormTransaksi : Form
    {
        private DataTable dtNasabah;
        private DataTable dtSampah;
        private decimal hargaPerKgCurrent = 0;
        private decimal totalCurrent = 0;

        private string printKodeTrx = "";
        private string printTgl = "";
        private string printNasabah = "";
        private string printSampah = "";
        private string printBerat = "";
        private string printHargaKg = "";
        private string printTotal = "";
        private string printPetugas = "Petugas SIMBAS";

        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyModernGridStyle(dgvTransaksi);
            UIHelper.StyleButtonGold(btnSimpanTrx);
            UIHelper.StyleButtonDark(btnCetakStruk);

            UIHelper.MakeRounded(panelFormCard, 10);
            UIHelper.MakeRounded(panelGridCard, 10);
            UIHelper.MakeRounded(panelCalcBox, 8);
            UIHelper.MakeRounded(panelAudioBox, 8);
            UIHelper.MakeRounded(btnPlaySaveAudio, 14);
            UIHelper.MakeRounded(btnSimpanTrx, 6);
            UIHelper.MakeRounded(btnCetakStruk, 6);
            UIHelper.MakeRounded(cmbNasabah, 6);
            UIHelper.MakeRounded(cmbSampah, 6);
            UIHelper.MakeRounded(txtBerat, 6);
            UIHelper.AttachNumericOnly(txtBerat, true);

            LoadCombos();
            LoadData();
            UpdateCalculations();

            dgvTransaksi.SelectionChanged += (s, ev) =>
            {
                if (dgvTransaksi.SelectedRows.Count > 0)
                {
                    PopulateFormFromSelectedRow(dgvTransaksi.SelectedRows[0]);
                }
            };
        }

        private void LoadCombos()
        {
            dtNasabah = DataStore.GetNasabah();
            cmbNasabah.DisplayMember = "nama";
            cmbNasabah.ValueMember = "kode_nasabah";
            cmbNasabah.DataSource = dtNasabah;

            dtSampah = DataStore.GetSampah();
            cmbSampah.DisplayMember = "nama_sampah";
            cmbSampah.ValueMember = "id_sampah";
            cmbSampah.DataSource = dtSampah;

            if (cmbSampah.Items.Count > 0)
            {
                cmbSampah.SelectedIndex = 0;
                cmbSampah_SelectedIndexChanged(null, null);
            }
        }

        private void LoadData()
        {
            DataTable dt = DataStore.GetTransaksi();
            dgvTransaksi.DataSource = dt;
            UIHelper.FormatGridColumns(dgvTransaksi);
        }

        private void cmbNasabah_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update UI if needed
        }

        private void dgvTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTransaksi.Rows.Count)
            {
                PopulateFormFromSelectedRow(dgvTransaksi.Rows[e.RowIndex]);
            }
        }

        private string GetRowString(DataGridViewRow r, params string[] keys)
        {
            if (r == null || r.DataGridView == null) return null;
            try
            {
                // 1. Check exact column name
                foreach (string k in keys)
                {
                    if (r.DataGridView.Columns.Contains(k))
                    {
                        object v = r.Cells[k].Value;
                        if (v != null && v != DBNull.Value) return v.ToString().Trim();
                    }
                }
                // 2. Check contains in column name or header text
                foreach (DataGridViewColumn col in r.DataGridView.Columns)
                {
                    foreach (string k in keys)
                    {
                        if (col.Name.ToLower().Contains(k.ToLower()) || col.HeaderText.ToLower().Contains(k.ToLower()))
                        {
                            object v = r.Cells[col.Index].Value;
                            if (v != null && v != DBNull.Value) return v.ToString().Trim();
                        }
                    }
                }
            }
            catch { }
            return null;
        }

        private bool isPopulatingRow = false;

        private decimal ParseDecimalSafe(object obj)
        {
            if (obj == null || obj == DBNull.Value) return 0m;
            if (obj is decimal) return (decimal)obj;
            if (obj is double) return (decimal)((double)obj);
            if (obj is float) return (decimal)((float)obj);
            if (obj is int) return (decimal)((int)obj);
            if (obj is long) return (decimal)((long)obj);

            string s = obj.ToString().Replace("Rp", "").Replace("kg", "").Replace("KG", "").Trim().Replace(" ", "");
            if (string.IsNullOrWhiteSpace(s)) return 0m;

            if (s.Contains(".") && s.Contains(","))
            {
                int lastDot = s.LastIndexOf('.');
                int lastComma = s.LastIndexOf(',');
                if (lastComma > lastDot)
                {
                    s = s.Replace(".", "").Replace(",", ".");
                }
                else
                {
                    s = s.Replace(",", "");
                }
            }
            else if (s.Contains(","))
            {
                int commaIdx = s.LastIndexOf(',');
                int digitsAfter = s.Length - 1 - commaIdx;
                if (digitsAfter == 3 && s.Length > 4)
                {
                    s = s.Replace(",", "");
                }
                else
                {
                    s = s.Replace(",", ".");
                }
            }
            else if (s.Contains("."))
            {
                int dotIdx = s.LastIndexOf('.');
                int digitsAfter = s.Length - 1 - dotIdx;
                if (digitsAfter == 3 && s.Length >= 5)
                {
                    s = s.Replace(".", "");
                }
            }

            decimal result;
            NumberStyles style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign;
            if (decimal.TryParse(s, style, CultureInfo.InvariantCulture, out result))
            {
                return result;
            }
            if (decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out result))
            {
                return result;
            }
            if (decimal.TryParse(s, NumberStyles.Any, CultureInfo.CurrentCulture, out result))
            {
                return result;
            }
            return 0m;
        }

        private void PopulateFormFromSelectedRow(DataGridViewRow row)
        {
            if (row == null) return;
            try
            {
                isPopulatingRow = true;

                // 1. Match Nasabah
                string targetNama = GetRowString(row, "nama_nasabah", "nama", "nasabah");
                if (!string.IsNullOrEmpty(targetNama))
                {
                    for (int i = 0; i < cmbNasabah.Items.Count; i++)
                    {
                        string itemText = cmbNasabah.GetItemText(cmbNasabah.Items[i]).Trim();
                        if (itemText.Equals(targetNama, StringComparison.OrdinalIgnoreCase) ||
                            itemText.ToLower().Contains(targetNama.ToLower()) ||
                            targetNama.ToLower().Contains(itemText.ToLower()))
                        {
                            cmbNasabah.SelectedIndex = i;
                            break;
                        }
                    }
                }

                // 2. Match Sampah
                string targetSampah = GetRowString(row, "nama_sampah", "jenis_sampah", "sampah");
                if (!string.IsNullOrEmpty(targetSampah))
                {
                    for (int i = 0; i < cmbSampah.Items.Count; i++)
                    {
                        string itemText = cmbSampah.GetItemText(cmbSampah.Items[i]).Trim();
                        if (itemText.Equals(targetSampah, StringComparison.OrdinalIgnoreCase) ||
                            itemText.ToLower().Contains(targetSampah.ToLower()) ||
                            targetSampah.ToLower().Contains(itemText.ToLower()))
                        {
                            cmbSampah.SelectedIndex = i;
                            break;
                        }
                    }
                }

                // 3. Set Berat
                string beratStr = GetRowString(row, "berat_kg", "berat");
                if (!string.IsNullOrEmpty(beratStr))
                {
                    decimal bVal = ParseDecimalSafe(beratStr.Replace("kg", "").Trim());
                    txtBerat.Text = bVal.ToString("0.##", CultureInfo.InvariantCulture);
                }

                // 4. Set Tanggal
                string tglStr = GetRowString(row, "tanggal", "waktu", "tgl");
                if (!string.IsNullOrEmpty(tglStr))
                {
                    DateTime tgl;
                    if (DateTime.TryParse(tglStr, out tgl))
                    {
                        dtpTanggal.Value = tgl;
                    }
                }

                // 5. Set Nilai Setoran
                string totalStr = GetRowString(row, "total_harga", "nilai", "total");
                decimal tot = ParseDecimalSafe(totalStr);
                if (tot > 0)
                {
                    totalCurrent = tot;
                    lblNilaiSetoranVal.Text = string.Format("Rp {0:N0}", tot);
                }
                else
                {
                    isPopulatingRow = false;
                    UpdateCalculations();
                    isPopulatingRow = true;
                }

                printKodeTrx = GetRowString(row, "kode_transaksi", "kode");
                printTgl = GetRowString(row, "tanggal", "waktu");
                printNasabah = GetRowString(row, "nama_nasabah", "nasabah", "nama");
                printSampah = GetRowString(row, "nama_sampah", "sampah");
                printBerat = beratStr + " kg";
                printHargaKg = string.Format("Rp {0:N0}", hargaPerKgCurrent);
                printTotal = string.Format("Rp {0:N0}", tot > 0 ? tot : totalCurrent);
                printPetugas = GetRowString(row, "petugas", "user");
                if (string.IsNullOrEmpty(printPetugas)) printPetugas = "Petugas SIMBAS";
            }
            catch { }
            finally
            {
                isPopulatingRow = false;
            }
        }

        private void cmbSampah_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSampah.SelectedItem != null && dtSampah != null)
            {
                DataRowView drv = cmbSampah.SelectedItem as DataRowView;
                if (drv != null && drv["harga_per_kg"] != DBNull.Value)
                {
                    hargaPerKgCurrent = Convert.ToDecimal(drv["harga_per_kg"]);
                    if (!isPopulatingRow)
                    {
                        UpdateCalculations();
                    }
                }
            }
        }

        private void txtBerat_TextChanged(object sender, EventArgs e)
        {
            if (!isPopulatingRow)
            {
                UpdateCalculations();
            }
        }

        private void UpdateCalculations()
        {
            if (isPopulatingRow) return;
            decimal inputVal = ParseDecimalSafe(txtBerat.Text);
            totalCurrent = inputVal * hargaPerKgCurrent;
            lblNilaiSetoranVal.Text = string.Format("Rp {0:N0}", totalCurrent);
        }

        private void btnSimpanTrx_Click(object sender, EventArgs e)
        {
            if (cmbNasabah.SelectedItem == null)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Pilih Nasabah terlebih dahulu!", "Validasi Transaksi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbSampah.SelectedItem == null)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Pilih Jenis Sampah terlebih dahulu!", "Validasi Transaksi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal inputVal = ParseDecimalSafe(txtBerat.Text);
            if (inputVal <= 0)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Nilai berat harus berupa angka lebih besar dari 0!", "Validasi Transaksi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kodeNasabah = cmbNasabah.SelectedValue.ToString();
            int idSampah = Convert.ToInt32(cmbSampah.SelectedValue);

            string catatan = string.Format("Setor {0:N2} kg pada {1}", inputVal, dtpTanggal.Value.ToString("dd/MM/yyyy"));
            DataStore.AddTransaksiSetor(kodeNasabah, idSampah, inputVal, totalCurrent, catatan);

            printKodeTrx = "TRX-" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
            printTgl = dtpTanggal.Value.ToString("dd/MM/yyyy HH:mm");
            printNasabah = cmbNasabah.Text;
            printSampah = cmbSampah.Text;
            printBerat = string.Format("{0:N2} kg", inputVal);
            printHargaKg = string.Format("Rp {0:N0}", hargaPerKgCurrent);
            printTotal = string.Format("Rp {0:N0}", totalCurrent);
            printPetugas = "Petugas SIMBAS";

            SoundHelper.PlaySaveSound();
            var res = MessageBox.Show(string.Format("Transaksi Setor Sampah Berhasil Disimpan!\nNilai Setoran: Rp {0:N0}\n\nApakah Anda ingin langsung mencetak struk bukti setoran?", totalCurrent), "Transaksi Berhasil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                btnCetakStruk_Click(null, null);
            }

            LoadCombos();
            LoadData();
            txtBerat.Text = "1";
            UpdateCalculations();
        }

        private void btnCetakStruk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(printKodeTrx) || string.IsNullOrEmpty(printNasabah))
            {
                if (dgvTransaksi.Rows.Count > 0)
                {
                    PopulateFormFromSelectedRow(dgvTransaksi.Rows[0]);
                }
                else
                {
                    SoundHelper.PlayAlertSound();
                    MessageBox.Show("Silakan pilih transaksi dari tabel atau simpan transaksi baru terlebih dahulu untuk mencetak struk.", "Pilih Transaksi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            try
            {
                PrintDocument pd = new PrintDocument();
                pd.DefaultPageSettings.PaperSize = new PaperSize("Thermal80mm", 315, 600);
                pd.PrintPage += new PrintPageEventHandler(PrintStrukPage);

                PrintPreviewDialog ppd = new PrintPreviewDialog();
                ppd.Document = pd;
                ppd.Width = 480;
                ppd.Height = 650;
                ppd.StartPosition = FormStartPosition.CenterParent;
                ppd.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka pratinjau cetak: " + ex.Message, "Error Cetak", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintStrukPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fTitle = new Font("Segoe UI", 12F, FontStyle.Bold);
            Font fSub = new Font("Segoe UI", 8F, FontStyle.Regular);
            Font fBold = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            Font fNormal = new Font("Segoe UI", 8.5F, FontStyle.Regular);
            Font fTotal = new Font("Segoe UI", 13F, FontStyle.Bold);
            Brush bPine = new SolidBrush(Color.FromArgb(22, 38, 31));
            Brush bTeal = new SolidBrush(Color.FromArgb(59, 122, 94));
            Pen penDash = new Pen(Color.FromArgb(180, 190, 180), 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };

            int x = 15;
            int y = 20;
            int w = 270;

            StringFormat sfCenter = new StringFormat { Alignment = StringAlignment.Center };

            // Header Struk
            g.DrawString("SIMBAS DIGITAL", fTitle, bTeal, new RectangleF(x, y, w, 22), sfCenter);
            y += 22;
            g.DrawString("BANK SAMPAH BERKAH MANDIRI", fBold, bPine, new RectangleF(x, y, w, 16), sfCenter);
            y += 16;
            g.DrawString("Jl. Lingkungan Bersih No. 10 - Telp (021) 555-1234", fSub, Brushes.Gray, new RectangleF(x, y, w, 14), sfCenter);
            y += 18;
            g.DrawLine(penDash, x, y, x + w, y);
            y += 10;

            // Info Transaksi
            g.DrawString("No. Trx  : " + printKodeTrx, fBold, bPine, x, y);
            y += 16;
            g.DrawString("Waktu    : " + printTgl, fNormal, bPine, x, y);
            y += 16;
            g.DrawString("Petugas  : " + printPetugas, fNormal, bPine, x, y);
            y += 16;
            g.DrawString("Nasabah  : " + printNasabah, fBold, bTeal, x, y);
            y += 18;
            g.DrawLine(penDash, x, y, x + w, y);
            y += 10;

            // Item detail
            g.DrawString("Rincian Sampah:", fBold, bPine, x, y);
            y += 16;
            g.DrawString(printSampah, fBold, bPine, x + 5, y);
            y += 16;
            g.DrawString(string.Format("{0} x {1}", printBerat, printHargaKg), fNormal, Brushes.DimGray, x + 5, y);
            y += 20;
            g.DrawLine(penDash, x, y, x + w, y);
            y += 12;

            // Total Nilai
            g.DrawString("TOTAL TABUNGAN :", fBold, bPine, x, y);
            y += 16;
            g.DrawString(printTotal, fTotal, bTeal, x, y);
            y += 24;
            g.DrawLine(penDash, x, y, x + w, y);
            y += 14;

            // Footer Struk
            g.DrawString("TABUNGAN ANDA TELAH DITAMBAHKAN!", fBold, bPine, new RectangleF(x, y, w, 16), sfCenter);
            y += 16;
            g.DrawString("Simpan struk ini sebagai bukti transaksi sah.", fSub, Brushes.Gray, new RectangleF(x, y, w, 14), sfCenter);
            y += 14;
            g.DrawString("Sampah Terpilah, Lingkungan Berkah 🌱", fSub, bTeal, new RectangleF(x, y, w, 14), sfCenter);
        }

        private void btnPlaySaveAudio_Click(object sender, EventArgs e)
        {
            SoundHelper.PlaySaveSound();
        }
    }
}
