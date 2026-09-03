-- ==========================================================
-- SCRIPT DATABASE BANK SAMPAH DIGITAL (PBTM XII RPL @2026)
-- Guru Pengampu: Maspuri Andewi, S.Kom
-- SMKN 13 Bandung
-- ==========================================================

-- 1. Buat Database
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'db_banksampah')
BEGIN
    CREATE DATABASE db_banksampah;
END
GO

USE db_banksampah;
GO

-- 2. Hapus Tabel Lama Jika Ada (Reverse Order Dependencies)
IF OBJECT_ID('tb_transaksi', 'U') IS NOT NULL DROP TABLE tb_transaksi;
IF OBJECT_ID('tb_sampah', 'U') IS NOT NULL DROP TABLE tb_sampah;
IF OBJECT_ID('tb_nasabah', 'U') IS NOT NULL DROP TABLE tb_nasabah;
IF OBJECT_ID('tb_user', 'U') IS NOT NULL DROP TABLE tb_user;
GO

-- 3. Tabel User (Admin / Petugas)
CREATE TABLE tb_user (
    id_user INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(100) NOT NULL,
    nama_lengkap VARCHAR(100) NOT NULL,
    role VARCHAR(20) NOT NULL DEFAULT 'Petugas', -- 'Admin', 'Petugas'
    created_at DATETIME DEFAULT GETDATE()
);
GO

-- 4. Tabel Nasabah / Warga
CREATE TABLE tb_nasabah (
    id_nasabah INT IDENTITY(1,1) PRIMARY KEY,
    kode_nasabah VARCHAR(20) NOT NULL UNIQUE,
    nama VARCHAR(100) NOT NULL,
    alamat VARCHAR(255) NULL,
    no_hp VARCHAR(20) NULL,
    saldo DECIMAL(18, 2) DEFAULT 0,
    foto VARCHAR(255) DEFAULT 'default_nasabah.png',
    created_at DATETIME DEFAULT GETDATE()
);
GO

-- 5. Tabel Kategori & Jenis Sampah (Organik, Anorganik, B3)
CREATE TABLE tb_sampah (
    id_sampah INT IDENTITY(1,1) PRIMARY KEY,
    nama_sampah VARCHAR(100) NOT NULL,
    jenis_sampah VARCHAR(50) NOT NULL DEFAULT 'Anorganik', -- 'Organik', 'Anorganik', 'B3 (Berbahaya)'
    kategori VARCHAR(50) NOT NULL, -- 'Plastik', 'Kertas', 'Logam', 'Kaca', 'Minyak Jelantah', 'Kompos', 'B3 Elektronik', 'Lain-lain'
    harga_per_kg DECIMAL(18, 2) NOT NULL,
    foto VARCHAR(255) DEFAULT 'default_sampah.png'
);
GO

-- 6. Tabel Transaksi (Setor Sampah & Penarikan Saldo)
CREATE TABLE tb_transaksi (
    id_transaksi INT IDENTITY(1,1) PRIMARY KEY,
    kode_transaksi VARCHAR(30) NOT NULL UNIQUE,
    id_nasabah INT NOT NULL,
    jenis_transaksi VARCHAR(20) NOT NULL, -- 'Setor', 'Tarik'
    id_sampah INT NULL, -- NULL jika jenis_transaksi = 'Tarik'
    berat_kg DECIMAL(10, 2) DEFAULT 0,
    total_harga DECIMAL(18, 2) NOT NULL,
    tanggal DATETIME DEFAULT GETDATE(),
    id_user INT NOT NULL,
    catatan VARCHAR(255) NULL,
    CONSTRAINT FK_Transaksi_Nasabah FOREIGN KEY (id_nasabah) REFERENCES tb_nasabah(id_nasabah) ON DELETE CASCADE,
    CONSTRAINT FK_Transaksi_Sampah FOREIGN KEY (id_sampah) REFERENCES tb_sampah(id_sampah) ON DELETE SET NULL,
    CONSTRAINT FK_Transaksi_User FOREIGN KEY (id_user) REFERENCES tb_user(id_user)
);
GO

-- 7. Seed Data Awal (Initial Data)
INSERT INTO tb_user (username, password, nama_lengkap, role) VALUES
('admin', 'admin123', 'Administrator Utama', 'Admin'),
('petugas', 'petugas123', 'Budi Santoso', 'Petugas');

INSERT INTO tb_nasabah (kode_nasabah, nama, alamat, no_hp, saldo) VALUES
('NSB-001', 'Ahmad Dahlan', 'Jl. Soekarno Hatta No. 12', '081234567890', 45000.00),
('NSB-002', 'Siti Nurhaliza', 'Jl. Buah Batu No. 45', '082198765432', 28500.00),
('NSB-003', 'Rudi Hermawan', 'Jl. Kopo Cirangrang No. 88', '085712344321', 120000.00);

INSERT INTO tb_sampah (nama_sampah, jenis_sampah, kategori, harga_per_kg, foto) VALUES
('Botol Plastik PET Bersih', 'Anorganik', 'Plastik', 4500.00, 'botol_plastik.png'),
('Kardus Bekas Tebal', 'Anorganik', 'Kertas', 2500.00, 'kardus.png'),
('Besi Tua & Kaleng', 'Anorganik', 'Logam', 7000.00, 'besi_kaleng.png'),
('Botol Kaca Bening', 'Anorganik', 'Kaca', 1500.00, 'botol_kaca.png'),
('Kompos & Sisa Sayuran', 'Organik', 'Kompos', 1000.00, 'organik_kompos.png'),
('Baterai & Akumulator Bekas', 'B3 (Berbahaya)', 'B3 Elektronik', 12000.00, 'baterai_b3.png'),
('Kertas HVS Bekas', 'Anorganik', 'Kertas', 3000.00, 'kertas_hvs.png'),
('Plastik Gelas Minuman', 'Anorganik', 'Plastik', 3500.00, 'plastik_gelas.png');

INSERT INTO tb_transaksi (kode_transaksi, id_nasabah, jenis_transaksi, id_sampah, berat_kg, total_harga, id_user, catatan) VALUES
('TRX-20260826-001', 1, 'Setor', 1, 10.00, 45000.00, 1, 'Setoran botol PET 10 Kg'),
('TRX-20260826-002', 2, 'Setor', 2, 11.40, 28500.00, 2, 'Setoran kardus bekas 11.4 Kg'),
('TRX-20260826-003', 3, 'Setor', 3, 17.14, 120000.00, 1, 'Setoran besi tua 17.14 Kg');
GO

PRINT 'Database db_banksampah berhasil dibuat dan diisi data sampel (termasuk kelas Organik, Anorganik, B3 dan foto)!';
