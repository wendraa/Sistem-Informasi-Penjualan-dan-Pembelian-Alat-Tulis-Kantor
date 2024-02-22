-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 09, 2022 at 12:00 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tokoalattulis`
--

-- --------------------------------------------------------

--
-- Table structure for table `barang`
--

CREATE TABLE `barang` (
  `ID` varchar(10) NOT NULL,
  `Nama` varchar(30) NOT NULL,
  `cid` varchar(10) NOT NULL,
  `Harga` decimal(8,2) NOT NULL,
  `Jumlah` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `barang`
--

INSERT INTO `barang` (`ID`, `Nama`, `cid`, `Harga`, `Jumlah`) VALUES
('PRDK001', 'Joyko', 'CAT001', '5000.00', 2),
('PRDK002', 'SInar Bulan', 'CAT002', '3000.00', 17),
('PRDK003', 'Standard', 'CAT002', '3000.00', 7);

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `ID` varchar(10) NOT NULL,
  `Nama` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`ID`, `Nama`) VALUES
('CAT001', 'Penghapus'),
('CAT002', 'PULPEN'),
('CAT003', 'Pensil');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `ID` varchar(10) NOT NULL,
  `Nama` varchar(30) NOT NULL,
  `Nomor` varchar(14) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`ID`, `Nama`, `Nomor`) VALUES
('CST001', 'Alvito Dienova ', '081292311422'),
('CST002', 'Akmal Nurcahyono', '0887635421');

-- --------------------------------------------------------

--
-- Table structure for table `pegawai`
--

CREATE TABLE `pegawai` (
  `ID` varchar(10) NOT NULL,
  `Nama` varchar(30) NOT NULL,
  `Posisi` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pegawai`
--

INSERT INTO `pegawai` (`ID`, `Nama`, `Posisi`) VALUES
('PG001', 'Alvito Dienova', 'CEO'),
('PG002', 'Akmal', 'CEO'),
('PG003', 'Ruswendra', 'CEO');

-- --------------------------------------------------------

--
-- Table structure for table `pembelian`
--

CREATE TABLE `pembelian` (
  `ID` varchar(10) NOT NULL,
  `Nama` varchar(30) NOT NULL,
  `jumlah` varchar(5) NOT NULL,
  `harga` varchar(10) NOT NULL,
  `id_supp` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `penjualan`
--

CREATE TABLE `penjualan` (
  `idjual` int(10) NOT NULL,
  `noTrans` varchar(50) DEFAULT NULL,
  `ID` varchar(10) DEFAULT NULL,
  `Harga` varchar(10) DEFAULT NULL,
  `Jumlah` int(10) DEFAULT 0,
  `disc_percent` decimal(18,2) DEFAULT 0.00,
  `Discount` decimal(18,2) DEFAULT 0.00,
  `Total` decimal(18,2) DEFAULT NULL,
  `Tanggal` date DEFAULT NULL,
  `Status` varchar(25) DEFAULT '''Pending'''
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `penjualan`
--

INSERT INTO `penjualan` (`idjual`, `noTrans`, `ID`, `Harga`, `Jumlah`, `disc_percent`, `Discount`, `Total`, `Tanggal`, `Status`) VALUES
(25, '0000000000', 'PRDK001', '5000', 1, '0.00', '0.00', NULL, '2022-06-07', '\'Pending\'');

--
-- Triggers `penjualan`
--
DELIMITER $$
CREATE TRIGGER `computTotal` AFTER UPDATE ON `penjualan` FOR EACH ROW BEGIN
	UPDATE penjualan SET Discount =((Harga*Jumlah)*disc_percent);
	UPDATE penjualan SET Total = (Harga*Jumlah) - Discount;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `ID` varchar(10) NOT NULL,
  `Nama` varchar(30) NOT NULL,
  `Alamat` varchar(150) NOT NULL,
  `Nomor` varchar(14) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`ID`, `Nama`, `Alamat`, `Nomor`) VALUES
('SP001', 'PT. Sejahtera', 'Bogor', '081292911');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `pegawai`
--
ALTER TABLE `pegawai`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `pembelian`
--
ALTER TABLE `pembelian`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `penjualan`
--
ALTER TABLE `penjualan`
  ADD PRIMARY KEY (`idjual`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `penjualan`
--
ALTER TABLE `penjualan`
  MODIFY `idjual` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
