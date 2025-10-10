-- phpMyAdmin SQL Dump
-- version 5.2.2
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost:3306
-- Tiempo de generación: 08-10-2025 a las 20:55:31
-- Versión del servidor: 10.6.23-MariaDB
-- Versión de PHP: 8.4.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `ssmagnet_conciliacion`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ch_objeto`
--

CREATE TABLE `objeto` (
  `objeto` varchar(1) NOT NULL,
  `detalle` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_unicode_ci;

--
-- Volcado de datos para la tabla `ch_objeto`
--

INSERT INTO `objeto` (`objeto`, `detalle`) VALUES
('1', 'SERVICIOS NO PERSONALES'),
('2', 'MATERIALES DE SUMINISTROS'),
('3', 'MAQUINARIA Y EQUIPO');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `ch_objeto`
--
ALTER TABLE `objeto`
  ADD UNIQUE KEY `objeto` (`objeto`) USING BTREE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
