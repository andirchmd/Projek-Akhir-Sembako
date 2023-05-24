-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 24, 2023 at 03:14 PM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbtokosembako`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbakun`
--

CREATE TABLE `tbakun` (
  `id_user` int(11) NOT NULL,
  `username` varchar(12) NOT NULL,
  `password` varchar(24) NOT NULL,
  `nama` varchar(24) NOT NULL,
  `no_telp` varchar(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbakun`
--

INSERT INTO `tbakun` (`id_user`, `username`, `password`, `nama`, `no_telp`) VALUES
(1, 'Rasid', '123', 'Khairul Rasid', '081344447777'),
(2, 'Andi', '123', 'Andi Rachmad', '081212128787'),
(3, 'Novi', '123', 'Novitasari', '081283837474');

-- --------------------------------------------------------

--
-- Table structure for table `tbriwayat`
--

CREATE TABLE `tbriwayat` (
  `id_riwayat` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `id_barang` int(11) NOT NULL,
  `jumlah_beli` int(4) NOT NULL,
  `total_harga` int(12) NOT NULL,
  `tanggal_pembelian` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbriwayat`
--

INSERT INTO `tbriwayat` (`id_riwayat`, `id_user`, `id_barang`, `jumlah_beli`, `total_harga`, `tanggal_pembelian`) VALUES
(1, 2, 1, 2, 140000, '2023-05-24 12:18:00'),
(2, 2, 3, 4, 140000, '2023-05-24 18:28:29'),
(3, 1, 4, 2, 30000, '2023-05-24 19:27:50'),
(4, 1, 1, 3, 210000, '2023-05-24 19:24:10'),
(6, 2, 3, 5, 175000, '2023-05-24 18:49:20');

-- --------------------------------------------------------

--
-- Table structure for table `tbsembako`
--

CREATE TABLE `tbsembako` (
  `id_barang` int(11) NOT NULL,
  `nama_barang` varchar(24) NOT NULL,
  `satuan` varchar(12) NOT NULL,
  `harga_beli` int(8) NOT NULL,
  `harga_jual` int(8) NOT NULL,
  `stok` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbsembako`
--

INSERT INTO `tbsembako` (`id_barang`, `nama_barang`, `satuan`, `harga_beli`, `harga_jual`, `stok`) VALUES
(1, 'Beras Lele', 'Kg', 60000, 70000, 20),
(2, 'Indomie Goreng', 'Pcs', 3000, 3500, 10),
(3, 'Minyak Bimoli', 'Liter', 30000, 35000, 25),
(4, 'Sunlight', 'Liter', 12000, 15000, 20),
(5, 'Gula Pasir', 'Kg', 15000, 20000, 40);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbakun`
--
ALTER TABLE `tbakun`
  ADD PRIMARY KEY (`id_user`);

--
-- Indexes for table `tbriwayat`
--
ALTER TABLE `tbriwayat`
  ADD PRIMARY KEY (`id_riwayat`),
  ADD KEY `id_user` (`id_user`),
  ADD KEY `id_barang` (`id_barang`);

--
-- Indexes for table `tbsembako`
--
ALTER TABLE `tbsembako`
  ADD PRIMARY KEY (`id_barang`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbakun`
--
ALTER TABLE `tbakun`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbriwayat`
--
ALTER TABLE `tbriwayat`
  MODIFY `id_riwayat` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tbsembako`
--
ALTER TABLE `tbsembako`
  MODIFY `id_barang` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbriwayat`
--
ALTER TABLE `tbriwayat`
  ADD CONSTRAINT `barang_riwayat` FOREIGN KEY (`id_barang`) REFERENCES `tbsembako` (`id_barang`),
  ADD CONSTRAINT `user_riwayat` FOREIGN KEY (`id_user`) REFERENCES `tbakun` (`id_user`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
