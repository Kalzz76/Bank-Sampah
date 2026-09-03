# LAPORAN PROYEK AKHIR PEMROGRAMAN MULTIMEDIA (PBTM)
## APLIKASI BANK SAMPAH DIGITAL BERBASIS MULTIMEDIA & SQL SERVER
**Mata Pelajaran:** Pemrograman Multimedia (PBTM)  
**Kelas:** XII Rekayasa Perangkat Lunak (RPL) - SMKN 13 Bandung  
**Guru Pengampu:** Maspuri Andewi, S.Kom  
**Tahun Ajaran:** 2025 / 2026  

---

## TAHAP 1 : MENENTUKAN IDE PROYEK

### 1. Masalah yang Ingin Diselesaikan
Pengelolaan Bank Sampah di tingkat lingkungan RT/RW dan sekolah selama ini masih dilakukan secara manual menggunakan pencatatan buku kas konvensional. Hal ini menimbulkan beberapa kendala mendasar:
* Kesulitan dalam menghitung total berat sampah dan akumulasi saldo tabungan nasabah secara cepat dan tepat.
* Risiko kehilangan data pencatatan transaksi fisik.
* Kurangnya daya tarik dan edukasi kepada warga/siswa dalam memilah sampah berdasarkan kelasnya (**Organik, Anorganik, dan B3**) serta belum adanya visualisasi foto produk sampah yang informatif.

### 2. Pengguna Aplikasi
* **Administrator (Admin):** Pengelola utama sistem yang memiliki akses penuh untuk kelola user/petugas, data nasabah, katalog jenis & foto sampah, transaksi setor/tarik, serta memantau grafik dashboard multimedia dan menu Pengaturan Sistem.
* **Petugas Bank Sampah:** Pengurus operasional lapangan yang bertugas menginput transaksi setor sampah dari warga, mencatat penarikan saldo, serta melayani data nasabah.

### 3. Data yang Dikelola
* **Data User / Petugas:** Username, Password (Hashed/Plain Auth), Nama Lengkap, Role (Admin/Petugas).
* **Data Nasabah:** Kode Nasabah, Nama Lengkap, Alamat, No. Telepon/HP, Tanggal Daftar, Saldo Tabungan.
* **Data Sampah:** ID Sampah, Nama Sampah, Kelas Sampah (**Organik**, **Anorganik**, **B3 (Berbahaya)**), Kategori Detail (Plastik, Kertas, Logam, Kaca, Minyak Jelantah, Kompos, B3 Elektronik), Harga per Kg, dan Foto Image (Preview & Upload).
* **Data Transaksi:** No. Transaksi, Tanggal, Kode Nasabah, ID Sampah, Jenis Transaksi (Setor/Tarik), Berat (Kg), Total Harga (Rp), Catatan.

---

## TAHAP 2 : MEMBUAT ANALISIS KEBUTUHAN

| Kebutuhan | Keterangan |
| :--- | :--- |
| **Input** | <ul><li>Input Akun Login (Username & Password)</li><li>Input Data Nasabah Baru / Edit Nasabah (Kode, Nama, Alamat, No. HP)</li><li>Input Master Sampah lengkap dengan Kelas Sampah (Organik/Anorganik/B3), Kategori, Harga, & Upload Foto (`.png`, `.jpg`)</li><li>Input Transaksi Setor Sampah (Nasabah, Jenis Sampah, Berat)</li><li>Input Transaksi Tarik Saldo (Nasabah, Jumlah Penarikan)</li><li>Input User Baru & Konfigurasi pada Menu Pengaturan</li></ul> |
| **Proses** | <ul><li>Otentikasi Login & Otorisasi Hak Akses (Admin vs Petugas)</li><li>Render Photo Preview Real-time saat memilih item sampah dari DataGridView</li><li>Kalkulasi Otomatis Total Setoran (`Berat * HargaPerKg`)</li><li>Pembaruan Saldo Nasabah secara Real-time (Tambah saat Setor, Kurang saat Tarik)</li><li>Validasi Saldo Cukup sebelum Transaksi Penarikan</li><li>Pencarian (Filtering) Data Nasabah dan Sampah secara Instant</li><li>Single-Window Embedded Navigation (Navigasi Seamless tanpa Pop-up Window)</li><li>Menu Modul Pengaturan Terpadu (Kelola User, Audio Test & Setting, Info Sistem & DB)</li><li>Play Audio Sound Notifications saat event Login & Transaksi</li><li>Sinkronisasi Data ke SQL Server dengan Fallback Storage</li></ul> |
| **Output** | <ul><li>Summary Metric Cards bergaya Modern (Total Nasabah, Jenis Sampah, Total Berat, Total Saldo)</li><li>Grafik Bar Chart Interaktif Distribusi Volume Sampah berdasarkan Kategori</li><li>Tabel DataGrid View Modern (Flat Horizontal Grid, Deep Emerald Headers, Row Heights 34px)</li><li>Foto Preview Cards (120x120px) dengan Automatic Graphic Badge Generator</li><li>Module Pengaturan Sistem Berbasis Multi-Tab</li><li>Feedback Audio Notification (Sound Engine)</li><li>Media Edukasi & Tutorial Penggunaan Aplikasi</li></ul> |

---

## TAHAP 3 : MEMBUAT DESAIN ANTARMUKA (UI/UX) & SINGLE-WINDOW NAVIGATION

Desain antarmuka dirancang menggunakan **Single-Window Embedded Navigation System** (`UIHelper.cs` & `FormMain.cs`). Seluruh halaman modul (Nasabah, Sampah, Transaksi, Pengaturan) tampil secara seamless dan terintegrasi di dalam satu jendela utama (`panelContent`) tanpa membuka window pop-up terpisah:

1. **Form Login (`FormLogin`) - Layout Split-Screen Hero Card (750x480)**:
   * **Sisi Kiri (Hero Panel - 330px)**: Deep Emerald Panel (`#064E3B`) dengan Icon 3D `🌿`, Judul Aplikasi, Subjudul, serta 3 poin checklist keunggulan sistem (`✓ Real-time`, `✓ Sound Player`, `✓ Otentikasi Hak Akses`) dan identitas SMKN 13 Bandung.
   * **Sisi Kanan (Form Input Panel - 420px)**: Tampilan White Card modern dengan ucapan "Selamat Datang! 👋", input field ikonik (`👤 Username`, `🔑 Password`), Tombol Aksi Utama `🔓 MASUK KE SISTEM` (Height: 48px), serta petunjuk akun default.

2. **Modul Katalog & Foto Sampah (`FormSampah`)**:
   * **Panel Kiri (Form Input & Photo Preview Card)**:
     * Card PictureBox Preview (120x120px) dengan Tombol `🖼️ UPLOAD FOTO...`.
     * Dropdown **Kelas / Jenis Sampah** (`🍃 Organik`, `♻️ Anorganik`, `⚠️ B3 (Berbahaya)`).
     * Dropdown **Kategori Detail** (`Plastik`, `Kertas`, `Logam`, `Kaca`, `Kompos`, `B3 Elektronik`, `Minyak Jelantah`, `Lain-lain`).
     * Field Input Nama Sampah dan Harga per Kg.
   * **Panel Kanan (Tabel Master Sampah & Search Bar)**:
     * DataGridView modern menampilkan `id_sampah`, `nama_sampah`, `jenis_sampah`, `kategori`, `harga_per_kg`, dan `foto`.
     * Mengkliknya akan memicu pratinjau foto secara instan!

---

## TAHAP 4 : MEMBUAT DATABASE SQL SERVER

Penyediaan database dilakukan menggunakan SQL Server Management Studio (SSMS) dengan langkah-langkah berikut:
1. Membuka SQL Server Management Studio (SSMS) dan melakukan koneksi ke instance `localhost` atau `localhost\SQLEXPRESS`.
2. Eksekusi Script SQL `database_banksampah.sql` untuk membuat database `db_banksampah` beserta 4 tabel utamanya (`tb_user`, `tb_nasabah`, `tb_sampah`, `tb_transaksi`).
3. Mengisikan Seed Data Awal:
   * **User default:** `admin` (pass: `admin123`, role: `Admin`) dan `petugas` (pass: `petugas123`, role: `Petugas`).
   * **Nasabah Awal:** Budi Santoso (NSB001), Siti Aminah (NSB002), Ahmad Dahlan (NSB003).
   * **Sampah & Kelas Awal:** Botol Plastik PET (Anorganik), Kardus Bekas (Anorganik), Besi Tua & Kaleng (Anorganik), Botol Kaca Bening (Anorganik), Kompos & Sisa Sayuran (Organik), Baterai & Akumulator Bekas (B3 (Berbahaya)).

---

## TAHAP 5 : PENGUJIAN & VALIDITAS APLIKASI

Pengujian aplikasi dilakukan menggunakan metode *Black Box Testing* & *User Acceptance Testing (UAT)* untuk memastikan seluruh fungsionalitas berjalan tanpa cacat (bug-free).

### Tabel Hasil Pengujian Fungsional

| Scenario Pengujian | Langkah Pengujian | Hasil yang Diharapkan | Status |
| :--- | :--- | :--- | :---: |
| **Login Valid** | Input Username `admin` & Password `admin123` -> Klik MASUK | Sound Login berbunyi, masuk ke Dashboard Utama | **BERHASIL** |
| **Kelas Sampah** | Pilih Klasifikasi Sampah (Organik / Anorganik / B3) | Data tersimpan dengan kelas sampah yang sesuai | **BERHASIL** |
| **Upload Foto** | Klik `🖼️ UPLOAD FOTO...` dan pilih file gambar | Gambar tampil pada PictureBox preview dan tersimpan | **BERHASIL** |
| **Click Row Preview**| Klik salah satu baris di tabel DataGridView Sampah | Foto preview langsung ter-render sesuai jenis sampah | **BERHASIL** |
| **Setor Sampah** | Setor 5 Kg Botol Plastik untuk Budi Santoso | Saldo Budi bertambah Rp 15.000, grafik terupdate | **BERHASIL** |
| **Tarik Saldo Valid** | Tarik Rp 10.000 dari saldo Budi Santoso | Saldo Budi berkurang Rp 10.000, transaksi tercatat | **BERHASIL** |

---

## KESIMPULAN

Aplikasi **Bank Sampah Digital Berbasis Multimedia** ini telah selesai dirancang, diimplementasikan, dan diuji secara menyeluruh sesuai dengan seluruh ketentuan dan instrumen penilaian proyek akhir mata pelajaran Pemrograman Multimedia (PBTM) kelas XII RPL SMKN 13 Bandung.
