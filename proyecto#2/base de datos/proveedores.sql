-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-10-2025 a las 22:55:49
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `conciliacion`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedores`
--

CREATE TABLE `proveedores` (
  `codigo` varchar(5) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `ruc` varchar(100) DEFAULT NULL,
  `direccion` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `proveedores`
--

INSERT INTO `proveedores` (`codigo`, `nombre`, `ruc`, `direccion`) VALUES
('00001', 'ÓPTICA SOSA Y ARANGO, S.A.', '', ''),
('00003', 'CARILO, S.A.', '', ''),
('00006', 'AGENCIA SKY', '', ''),
('00007', 'SENTOSA CORPORACIÓN, S.A.', '', ''),
('00008', 'GILMIR BUSINESS, S.A.', '', ''),
('00009', 'OFIHOGAR, S.A.', '', ''),
('00010', 'GRUPO BARSASH, S.A.', '', ''),
('00011', 'CORPORACIÓN LAS ANTILLAS', '', ''),
('00012', 'INVERSIONES TEALIS, S.A.', '', ''),
('00013', 'SUPER-PLAS', '', ''),
('00014', 'SERVICIOS COMERCIALES Y TÉCNICOS', '', ''),
('00015', 'PANDATA SERVICE INC.', '', ''),
('00017', 'DIGITEC', '', ''),
('00018', 'IPHE', '', ''),
('00019', 'DISTRIBUIDORA MUSICAL, S.A.', '', ''),
('00020', 'IMPORTADORA MC', '', ''),
('00021', 'INVERSIONES RAMA', '', ''),
('00022', 'JELLINI', '', ''),
('00023', 'OLIMPUS COMMERCIAL CORPORATION', '', ''),
('00024', 'ASOCIADOS TENNOVA', '', ''),
('00026', 'BARYAN, S.A.', '', ''),
('00027', 'MASTER DIRECT PANAMÁ, S.A.', '', ''),
('00028', 'OMICRON PANAMÁ CORPORATION', '', ''),
('00029', 'Sistemas y Soluciones Mag', '', 'La Chorrera'),
('00030', 'MULTIFRIO PANAMÁ GROUP S.A.', '', ''),
('00031', 'INDUSTRIA PANAMEÑA DE PLASTICO S.A.', '', ''),
('00032', 'B.H. CORP, S.A.', '', ''),
('00033', 'COMERCIALIZADORA SELECTA, S.A.', '', ''),
('00034', 'ASOCIADOS TERRANOVA, S.A.', '', ''),
('00035', 'MODERNA COMERCIAL, S.A.', '', ''),
('00036', 'PROLAT', '', ''),
('00037', 'MUEBLERIA Y JOYERIA CENTROAMERICANA, S.A.', '', ''),
('00038', 'CRISTOBAL JOVILLA RIOS', '', ''),
('00039', 'ROMERO VENDING', '', ''),
('00040', 'ALEXANDER AROSEMENA', '', ''),
('00041', 'YANIS MORAN', '', ''),
('00042', 'MANEKI-NEKO', '', ''),
('00043', 'NEXCO                                   ', '', ''),
('00044', 'PRUEBA', '854-PF', 'Panamá Oeste'),
('00045', 'INVERSIONES EDSEDA COMPANY, S.A.', '', ''),
('00046', 'DISTINTIVOS Y ACCESORIOS, S.A.', '', ''),
('00047', 'ROLANDO BARRIA', '', ''),
('00048', 'SUPERMERCADO FEUILLET', '', ''),
('00049', 'VISIONARTE PROMOCIÓN Y PUBLICIDAD', '', ''),
('00050', 'FRIO EXPRESS PANAMA', '', ''),
('00051', 'GLOBAL BUSINESS SOLUTION - GLOBUS', '', ''),
('00052', 'SUPER STARS COMPUTERS ', '', ''),
('00053', 'INGENIEROS, DESARROLLADORES, ESTRATEGICOS, GLOBALES, S.A.', '', ''),
('00054', 'Selma Yussara Barakat', '', ''),
('00055', 'Ingeniería Electromecánica Especializada, S.A.', '', ''),
('00056', 'Deportes Jimmy, S.A.', '', '');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  ADD UNIQUE KEY `codigo` (`codigo`) USING BTREE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
