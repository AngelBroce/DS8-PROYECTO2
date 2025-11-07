-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 07, 2025 at 10:11 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `proyectosoft2`
--

-- --------------------------------------------------------

--
-- Table structure for table `conciliacion_bancaria`
--

CREATE TABLE `conciliacion_bancaria` (
  `conciliacion_id` int(11) NOT NULL,
  `mes` tinyint(4) NOT NULL CHECK (`mes` between 1 and 12),
  `anio` year(4) NOT NULL,
  `saldo` decimal(18,2) NOT NULL DEFAULT 0.00,
  `saldo_conciliado` decimal(18,2) NOT NULL DEFAULT 0.00
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `conciliacion_bancaria`
--
ALTER TABLE `conciliacion_bancaria`
  ADD PRIMARY KEY (`conciliacion_id`),
  ADD UNIQUE KEY `uk_mes_anio` (`mes`,`anio`),
  ADD KEY `idx_anio` (`anio`),
  ADD KEY `idx_mes` (`mes`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `conciliacion_bancaria`
--
ALTER TABLE `conciliacion_bancaria`
  MODIFY `conciliacion_id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
