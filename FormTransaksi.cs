using System;
using System.Data;
using System.Windows.Forms;

namespace BankSampah
{
    public partial class FormTransaksi : Form
    {
        private DataTable dtNasabah;
        private DataTable dtSampah;
        private decimal hargaPerKgCurrent = 0;
        private decimal saldoNasabahCurrent = 0;

        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyModernGridStyle(dgvTransaksi);
            LoadCombos();
            LoadData();
            cmbJenis.SelectedIndex = 0;
            ResetForm();
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
        }

        private void LoadData()
        {
            DataTable dt = DataStore.GetTransaksi();
            dgvTransaksi.DataSource = dt;
            UIHelper.FormatGridColumns(dgvTransaksi);

            decimal totalPerputaran = 0;
            if (dt != null)
            {
                foreach (DataRow r in dt.Rows)
                {
                    if (r["total_harga"] != DBNull.Value) totalPerputaran += Convert.ToDecimal(r["total_harga"]);
                }
            }
            lblRecordBadge.Text = string.Format("📊 TOTAL: {0} TRX | 💰 PERPUTARAN: Rp {1:N0}", dt != null ? dt.Rows.Count : 0, totalPerputaran);
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = DataStore.GetTransaksi();
            if (dt == null) return;

            string keyword = txtCari.Text.Trim().Replace("'", "''");
            if (!string.IsNullOrEmpty(keyword))
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("kode_transaksi LIKE '%{0}%' OR nama_nasabah LIKE '%{0}%' OR nama_sampah LIKE '%{0}%' OR jenis_transaksi LIKE '%{0}%'", keyword);
                DataTable dtFiltered = dv.ToTable();
                dgvTransaksi.DataSource = dtFiltered;
                UIHelper.FormatGridColumns(dgvTransaksi);

                decimal totalFiltered = 0;
                foreach (DataRow r in dtFiltered.Rows)
                {
                    if (r["total_harga"] != DBNull.Value) totalFiltered += Convert.ToDecimal(r["total_harga"]);
                }
                lblRecordBadge.Text = string.Format("🔍 DITEMUKAN: {0} TRX | Rp {1:N0}", dtFiltered.Rows.Count, totalFiltered);
            }
            else
            {
                LoadData();
            }
        }

        private void ResetForm()
        {
            txtBerat.Text = "0";
            txtTotal.Text = "0";
            txtCatatan.Clear();
            if (cmbNasabah.Items.Count > 0) cmbNasabah.SelectedIndex = 0;
            if (cmbSampah.Items.Count > 0) cmbSampah.SelectedIndex = 0;
            UpdateCalculations();
        }

        private void cmbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isSetor = cmbJenis.SelectedIndex == 0;
            lblSampah.Visible = isSetor;
            cmbSampah.Visible = isSetor;
            lblHargaInfo.Visible = isSetor;
            lblBerat.Text = isSetor ? "⚖️ Berat (Kg)" : "💸 Jumlah Penarikan (Rp)";
            UpdateCalculations();
        }

        private void cmbNasabah_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNasabah.SelectedItem != null && dtNasabah != null)
            {
                DataRowView drv = cmbNasabah.SelectedItem as DataRowView;
                if (drv != null && drv["saldo"] != DBNull.Value)
                {
                    saldoNasabahCurrent = Convert.ToDecimal(drv["saldo"]);
                    lblSaldoInfo.Text = string.Format("Saldo Saat Ini: Rp {0:N0}", saldoNasabahCurrent);
                }
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
                    lblHargaInfo.Text = string.Format("Harga per Kg: Rp {0:N0} / Kg", hargaPerKgCurrent);
                    UpdateCalculations();
                }
            }
        }

        private void txtBerat_TextChanged(object sender, EventArgs e)
        {
            UpdateCalculations();
        }

        private void UpdateCalculations()
        {
            bool isSetor = cmbJenis.SelectedIndex == 0;
            decimal inputVal = 0;
            decimal.TryParse(txtBerat.Text, out inputVal);

            if (isSetor)
            {
                decimal total = inputVal * hargaPerKgCurrent;
                txtTotal.Text = total.ToString("0.##");
            }
            else
            {
                txtTotal.Text = inputVal.ToString("0.##");
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cmbNasabah.SelectedItem == null)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Pilih Nasabah terlebih dahulu!", "Validasi Transaksi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isSetor = cmbJenis.SelectedIndex == 0;
            string kodeNasabah = cmbNasabah.SelectedValue.ToString();
            decimal inputVal = 0;

            if (!decimal.TryParse(txtBerat.Text, out inputVal) || inputVal <= 0)
            {
                SoundHelper.PlayAlertSound();
                MessageBox.Show("Nilai berat/jumlah nominal transaksi harus lebih besar dari 0!", "Validasi Transaksi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isSetor)
            {
                if (cmbSampah.SelectedItem == null)
                {
                    SoundHelper.PlayAlertSound();
                    MessageBox.Show("Pilih Kategori Sampah terlebih dahulu!", "Validasi Transaksi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idSampah = Convert.ToInt32(cmbSampah.SelectedValue);
                decimal totalHarga = inputVal * hargaPerKgCurrent;

                DataStore.AddTransaksiSetor(kodeNasabah, idSampah, inputVal, totalHarga, txtCatatan.Text.Trim());
                SoundHelper.PlaySaveSound();
                MessageBox.Show(string.Format("Transaksi Setor Sampah Berhasil!\nTotal Saldo Bertambah: Rp {0:N0}", totalHarga), "Sukses Transaksi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (inputVal > saldoNasabahCurrent)
                {
                    SoundHelper.PlayAlertSound();
                    MessageBox.Show(string.Format("Saldo Nasabah Tidak Cukup!\nSaldo Saat Ini: Rp {0:N0}\nJumlah Penarikan: Rp {1:N0}", saldoNasabahCurrent, inputVal), "Transaksi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataStore.AddTransaksiTarik(kodeNasabah, inputVal, txtCatatan.Text.Trim());
                SoundHelper.PlaySaveSound();
                MessageBox.Show(string.Format("Penarikan Saldo Berhasil!\nJumlah Penarikan: Rp {0:N0}", inputVal), "Sukses Transaksi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadCombos();
            LoadData();
            ResetForm();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void dgvTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTransaksi.Rows[e.RowIndex];

                // 1. Jenis Transaksi (Setor / Tarik)
                if (dgvTransaksi.Columns.Contains("jenis_transaksi") && row.Cells["jenis_transaksi"].Value != null && row.Cells["jenis_transaksi"].Value != DBNull.Value)
                {
                    string jenis = row.Cells["jenis_transaksi"].Value.ToString();
                    if (jenis.Equals("Setor", StringComparison.OrdinalIgnoreCase))
                    {
                        cmbJenis.SelectedIndex = 0;
                    }
                    else if (jenis.Equals("Tarik", StringComparison.OrdinalIgnoreCase))
                    {
                        cmbJenis.SelectedIndex = 1;
                    }
                }

                // 2. Pilih Nasabah
                string namaNasabah = "";
                if (dgvTransaksi.Columns.Contains("nama_nasabah") && row.Cells["nama_nasabah"].Value != null && row.Cells["nama_nasabah"].Value != DBNull.Value)
                {
                    namaNasabah = row.Cells["nama_nasabah"].Value.ToString();
                }
                else if (dgvTransaksi.Columns.Contains("nama") && row.Cells["nama"].Value != null && row.Cells["nama"].Value != DBNull.Value)
                {
                    namaNasabah = row.Cells["nama"].Value.ToString();
                }

                if (!string.IsNullOrEmpty(namaNasabah) && cmbNasabah.Items.Count > 0)
                {
                    for (int i = 0; i < cmbNasabah.Items.Count; i++)
                    {
                        DataRowView drv = cmbNasabah.Items[i] as DataRowView;
                        if (drv != null && drv["nama"] != null && drv["nama"].ToString().Equals(namaNasabah, StringComparison.OrdinalIgnoreCase))
                        {
                            cmbNasabah.SelectedIndex = i;
                            break;
                        }
                    }
                }

                // 3. Pilih Jenis Sampah
                string namaSampah = "";
                if (dgvTransaksi.Columns.Contains("nama_sampah") && row.Cells["nama_sampah"].Value != null && row.Cells["nama_sampah"].Value != DBNull.Value)
                {
                    namaSampah = row.Cells["nama_sampah"].Value.ToString();
                }

                if (!string.IsNullOrEmpty(namaSampah) && cmbSampah.Items.Count > 0)
                {
                    for (int i = 0; i < cmbSampah.Items.Count; i++)
                    {
                        DataRowView drv = cmbSampah.Items[i] as DataRowView;
                        if (drv != null && drv["nama_sampah"] != null && drv["nama_sampah"].ToString().Equals(namaSampah, StringComparison.OrdinalIgnoreCase))
                        {
                            cmbSampah.SelectedIndex = i;
                            break;
                        }
                    }
                }

                // 4. Berat (Kg) atau Jumlah Penarikan (Rp)
                if (dgvTransaksi.Columns.Contains("berat_kg") && row.Cells["berat_kg"].Value != null && row.Cells["berat_kg"].Value != DBNull.Value)
                {
                    decimal b = Convert.ToDecimal(row.Cells["berat_kg"].Value);
                    if (b > 0)
                    {
                        txtBerat.Text = b.ToString("0.##");
                    }
                    else if (dgvTransaksi.Columns.Contains("total_harga") && row.Cells["total_harga"].Value != null && row.Cells["total_harga"].Value != DBNull.Value)
                    {
                        decimal t = Convert.ToDecimal(row.Cells["total_harga"].Value);
                        txtBerat.Text = t.ToString("0.##");
                    }
                }

                // 5. Catatan Transaksi
                if (dgvTransaksi.Columns.Contains("catatan") && row.Cells["catatan"].Value != null && row.Cells["catatan"].Value != DBNull.Value)
                {
                    txtCatatan.Text = row.Cells["catatan"].Value.ToString();
                }
                else
                {
                    txtCatatan.Clear();
                }

                UpdateCalculations();
            }
        }
    }
}
