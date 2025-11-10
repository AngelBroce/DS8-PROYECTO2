-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-11-2025 a las 23:34:54
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
-- Base de datos: `proyectosoft2`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cheques`
--

CREATE TABLE `cheques` (
  `cheque_id` int(11) NOT NULL,
  `numero` varchar(50) NOT NULL,
  `proveedor_codigo` varchar(10) DEFAULT NULL,
  `fecha_emision` datetime DEFAULT NULL,
  `monto` decimal(18,2) NOT NULL,
  `estado` tinyint(4) DEFAULT 0,
  `objeto_codigo` varchar(10) DEFAULT NULL,
  `fecha_girado` datetime DEFAULT NULL,
  `fecha_anulacion` datetime DEFAULT NULL,
  `detalles` varchar(300) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `conciliacion_bancaria`
--

CREATE TABLE `conciliacion_bancaria` (
  `conciliacion_id` int(11) NOT NULL,
  `mes` tinyint(4) NOT NULL CHECK (`mes` between 1 and 12),
  `anio` year(4) NOT NULL,
  `saldo_conciliado` decimal(18,2) NOT NULL DEFAULT 0.00
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `depositos`
--

CREATE TABLE `depositos` (
  `DepositoID` int(10) UNSIGNED NOT NULL,
  `Tipo` enum('Transferencia','Deposito Directo') NOT NULL,
  `FechaOperacion` date NOT NULL,
  `Monto` decimal(18,2) NOT NULL,
  `FechaRegistro` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `objeto`
--

CREATE TABLE `objeto` (
  `objeto` varchar(1) NOT NULL,
  `detalle` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Volcado de datos para la tabla `objeto`
--

INSERT INTO `objeto` (`objeto`, `detalle`) VALUES
('1', 'SERVICIOS NO PERSONALES'),
('2', 'MATERIALES DE SUMINISTROS'),
('3', 'MAQUINARIA Y EQUIPO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `objeto_gasto`
--

CREATE TABLE `objeto_gasto` (
  `codigo` varchar(10) NOT NULL,
  `detalle` varchar(150) NOT NULL,
  `objeto` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Volcado de datos para la tabla `objeto_gasto`
--

INSERT INTO `objeto_gasto` (`codigo`, `detalle`, `objeto`) VALUES
('120', 'Impresión, Encuadernación y otros', '1'),
('130', 'Información y Publicidad', '1'),
('141', 'Viáticos dentro del país', '1'),
('151', 'Transporte dentro del país', '1'),
('169', 'Otros Servicios', '1'),
('180', 'Mantenimiento y Reparación', '1'),
('181', 'Mantenimiento y Reparación de Edificios', '1'),
('182', 'Mantenimiento de Maquinarias y Otros Equipos', '1'),
('183', 'Mantenimiento de Mobiliario y Equipo de Oficina', '1'),
('185', 'Mantenimiento de Equipos de Computación', '1'),
('189', 'Otros Mantenimientos y Reparaciones', '1'),
('200', 'Alimentos y Bebidas', '2'),
('210', 'Textiles y Vestuarios', '2'),
('220', 'Combustibles y Lubricantes', '2'),
('230', 'Productos de Papel y Cartón', '2'),
('240', 'Productos Químicos y Conexos', '2'),
('250', 'Otros Materiales de Construcción', '2'),
('260', 'Productos Varios', '2'),
('262', 'Herramientas', '2'),
('265', 'Materiales, Accesorios y Suministros de Computación', '2'),
('270', 'Útiles y Materiales Diversos', '2'),
('280', 'Repuestos', '2'),
('320', 'Equipo Educacional y Recreativo', '3'),
('340', 'Equipo de Oficina', '3'),
('350', 'Mobiliario de Oficina', '3'),
('370', 'Maquinarias y Equipos Varios', '3'),
('380', 'Equipo de Computación', '3');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedores`
--

CREATE TABLE `proveedores` (
  `codigo` varchar(5) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `ruc` varchar(100) DEFAULT NULL,
  `direccion` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

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
('00043', 'NEXCO', '', ''),
('00044', 'PRUEBA', '854-PF', 'Panamá Oeste'),
('00045', 'INVERSIONES EDSEDA COMPANY, S.A.', '', ''),
('00046', 'DISTINTIVOS Y ACCESORIOS, S.A.', '', ''),
('00047', 'ROLANDO BARRIA', '', ''),
('00048', 'SUPERMERCADO FEUILLET', '', ''),
('00049', 'VISIONARTE PROMOCIÓN Y PUBLICIDAD', '', ''),
('00050', 'FRIO EXPRESS PANAMA', '', ''),
('00051', 'GLOBAL BUSINESS SOLUTION - GLOBUS', '', ''),
('00052', 'SUPER STARS COMPUTERS', '', ''),
('00053', 'INGENIEROS, DESARROLLADORES, ESTRATEGICOS, GLOBALES, S.A.', '', ''),
('00054', 'Selma Yussara Barakat', '', ''),
('00055', 'Ingeniería Electromecánica Especializada, S.A.', '', ''),
('00056', 'Deportes Jimmy, S.A.', '', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `usuario_id` int(11) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `contrasena` varchar(255) NOT NULL,
  `nombre_completo` varchar(100) DEFAULT NULL,
  `activo` tinyint(4) DEFAULT 1,
  `fecha_creacion` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`usuario_id`, `usuario`, `contrasena`, `nombre_completo`, `activo`, `fecha_creacion`) VALUES
(1, 'admin', 'admin123', 'Contador Principal', 1, '2025-11-10 14:01:09');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cheques`
--
ALTER TABLE `cheques`
  ADD PRIMARY KEY (`cheque_id`),
  ADD KEY `FK_cheques_proveedores` (`proveedor_codigo`),
  ADD KEY `FK_cheques_objeto_gasto` (`objeto_codigo`);

--
-- Indices de la tabla `conciliacion_bancaria`
--
ALTER TABLE `conciliacion_bancaria`
  ADD PRIMARY KEY (`conciliacion_id`),
  ADD UNIQUE KEY `uk_mes_anio` (`mes`,`anio`),
  ADD KEY `idx_anio` (`anio`),
  ADD KEY `idx_mes` (`mes`);

--
-- Indices de la tabla `depositos`
--
ALTER TABLE `depositos`
  ADD PRIMARY KEY (`DepositoID`),
  ADD KEY `idx_depositos_fecha` (`FechaOperacion`);

--
-- Indices de la tabla `objeto`
--
ALTER TABLE `objeto`
  ADD PRIMARY KEY (`objeto`);

--
-- Indices de la tabla `objeto_gasto`
--
ALTER TABLE `objeto_gasto`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`usuario_id`),
  ADD UNIQUE KEY `usuario` (`usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cheques`
--
ALTER TABLE `cheques`
  MODIFY `cheque_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `conciliacion_bancaria`
--
ALTER TABLE `conciliacion_bancaria`
  MODIFY `conciliacion_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `depositos`
--
ALTER TABLE `depositos`
  MODIFY `DepositoID` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `usuario_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
