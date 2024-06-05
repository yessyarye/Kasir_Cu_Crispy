-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 24, 2023 at 09:04 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dummy_kasir`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblbarang`
--

CREATE TABLE `tblbarang` (
  `Kode_Barang` varchar(50) NOT NULL,
  `Nama_Barang` varchar(50) DEFAULT NULL,
  `Jenis` varchar(50) DEFAULT NULL,
  `Harga` int(11) DEFAULT NULL,
  `Stock` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblbarang`
--

INSERT INTO `tblbarang` (`Kode_Barang`, `Nama_Barang`, `Jenis`, `Harga`, `Stock`) VALUES
('M001', 'Ayam Crispy', 'Makanan', 7000, 50),
('M002', 'Cumi Crispy', 'Makanan', 7000, 50),
('M003', 'Udang Crispy', 'Makanan', 7000, 50),
('M004', 'Paket Ayam Crispy', 'Paket', 10000, 50),
('M005', 'Paket Cumi Crispy', 'Paket', 10000, 50),
('M006', 'Paket Udang Crispy', 'Paket', 10000, 50),
('M007', 'Es Teh', 'Minuman', 2000, 50);

-- --------------------------------------------------------

--
-- Table structure for table `tbljenis_barang`
--

CREATE TABLE `tbljenis_barang` (
  `No` int(11) DEFAULT NULL,
  `Jenis` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbljenis_barang`
--

INSERT INTO `tbljenis_barang` (`No`, `Jenis`) VALUES
(1, 'Makanan'),
(2, 'Paket'),
(3, 'Minuman');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pelanggan`
--

CREATE TABLE `tbl_pelanggan` (
  `kode_pelanggan` varchar(20) NOT NULL,
  `nama_pelanggan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_pelanggan`
--

INSERT INTO `tbl_pelanggan` (`kode_pelanggan`, `nama_pelanggan`) VALUES
('P01', 'Cowok');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_penjualan`
--

CREATE TABLE `tbl_penjualan` (
  `faktur_penjualan` varchar(50) NOT NULL,
  `tgl_penjualan` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `kode_pelanggan` varchar(20) NOT NULL,
  `total` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_penjualan`
--

INSERT INTO `tbl_penjualan` (`faktur_penjualan`, `tgl_penjualan`, `kode_pelanggan`, `total`) VALUES
('INV/001/10/2023', '2023-10-27 04:51:57', 'P01', 10000);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_penjualan_rinci`
--

CREATE TABLE `tbl_penjualan_rinci` (
  `faktur_penjualan` varchar(50) NOT NULL,
  `kode_barang` varchar(50) NOT NULL,
  `harga_jual` int(20) NOT NULL,
  `jumlah` int(20) NOT NULL,
  `sub_total` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_penjualan_rinci`
--

INSERT INTO `tbl_penjualan_rinci` (`faktur_penjualan`, `kode_barang`, `harga_jual`, `jumlah`, `sub_total`) VALUES
('INV/001/10/2023', 'M004', 10000, 1, 10000);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `username` varchar(20) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `password`) VALUES
('Yessy', 'yessy123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblbarang`
--
ALTER TABLE `tblbarang`
  ADD UNIQUE KEY `Kode_Barang` (`Kode_Barang`),
  ADD KEY `tblbarang_ibfk_1` (`Jenis`);

--
-- Indexes for table `tbljenis_barang`
--
ALTER TABLE `tbljenis_barang`
  ADD UNIQUE KEY `Jenis` (`Jenis`);

--
-- Indexes for table `tbl_pelanggan`
--
ALTER TABLE `tbl_pelanggan`
  ADD PRIMARY KEY (`kode_pelanggan`);

--
-- Indexes for table `tbl_penjualan`
--
ALTER TABLE `tbl_penjualan`
  ADD PRIMARY KEY (`faktur_penjualan`),
  ADD KEY `kode_pelanggan` (`kode_pelanggan`);

--
-- Indexes for table `tbl_penjualan_rinci`
--
ALTER TABLE `tbl_penjualan_rinci`
  ADD KEY `tbl_penjualan_rinci_ibfk_2` (`kode_barang`),
  ADD KEY `tbl_penjualan_rinci_ibfk_3` (`faktur_penjualan`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tblbarang`
--
ALTER TABLE `tblbarang`
  ADD CONSTRAINT `tblbarang_ibfk_1` FOREIGN KEY (`Jenis`) REFERENCES `tbljenis_barang` (`Jenis`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_penjualan`
--
ALTER TABLE `tbl_penjualan`
  ADD CONSTRAINT `tbl_penjualan_ibfk_1` FOREIGN KEY (`kode_pelanggan`) REFERENCES `tbl_pelanggan` (`kode_pelanggan`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_penjualan_rinci`
--
ALTER TABLE `tbl_penjualan_rinci`
  ADD CONSTRAINT `tbl_penjualan_rinci_ibfk_2` FOREIGN KEY (`kode_barang`) REFERENCES `tblbarang` (`Kode_Barang`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_penjualan_rinci_ibfk_3` FOREIGN KEY (`faktur_penjualan`) REFERENCES `tbl_penjualan` (`faktur_penjualan`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
