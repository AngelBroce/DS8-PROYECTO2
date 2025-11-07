-- ========================================================================
-- Script unificado para crear y actualizar la base de datos proyectoSoft2
-- Este script incluye todas las tablas necesarias para el sistema de cheques
-- ========================================================================

-- ========================================================================
-- 0. Crear base de datos si no existe
-- ========================================================================
CREATE DATABASE IF NOT EXISTS proyectoSoft2;
USE proyectoSoft2;

-- ========================================================================
-- 1. Tabla: objeto (tipos de objetos)
-- ========================================================================
CREATE TABLE IF NOT EXISTS objeto (
  objeto VARCHAR(1) NOT NULL PRIMARY KEY,
  detalle VARCHAR(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

INSERT IGNORE INTO objeto (objeto, detalle) VALUES
('1', 'SERVICIOS NO PERSONALES'),
('2', 'MATERIALES DE SUMINISTROS'),
('3', 'MAQUINARIA Y EQUIPO');

-- ========================================================================
-- 2. Tabla: objeto_gasto (códigos de gasto detallados)
-- ========================================================================
CREATE TABLE IF NOT EXISTS objeto_gasto (
  codigo VARCHAR(10) NOT NULL PRIMARY KEY,
  detalle VARCHAR(150) NOT NULL,
  objeto VARCHAR(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

INSERT IGNORE INTO objeto_gasto (codigo, detalle, objeto) VALUES
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

-- ========================================================================
-- 3. Tabla: proveedores (datos maestros de proveedores)
-- ========================================================================
CREATE TABLE IF NOT EXISTS proveedores (
  codigo VARCHAR(5) NOT NULL PRIMARY KEY,
  nombre VARCHAR(100) NOT NULL,
  ruc VARCHAR(100) DEFAULT NULL,
  direccion VARCHAR(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT IGNORE INTO proveedores (codigo, nombre, ruc, direccion) VALUES
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

-- ========================================================================
-- 4. Tabla: usuarios (credenciales de usuario para login)
-- ========================================================================
CREATE TABLE IF NOT EXISTS usuarios (
  usuario_id INT AUTO_INCREMENT PRIMARY KEY,
  usuario VARCHAR(50) NOT NULL UNIQUE,
  contrasena VARCHAR(255) NOT NULL,
  nombre_completo VARCHAR(100),
  activo TINYINT DEFAULT 1,
  fecha_creacion DATETIME DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Insertar usuario por defecto (usuario: admin, contraseña: admin123)
INSERT IGNORE INTO usuarios (usuario, contrasena, nombre_completo, activo) VALUES
('admin', 'admin123', 'Contador Principal', 1);

-- ========================================================================
-- 5. Tabla: cheques (registro de cheques emitidos)
-- ========================================================================
DROP TABLE IF EXISTS cheques;
CREATE TABLE cheques (
    cheque_id INT AUTO_INCREMENT PRIMARY KEY,
    numero VARCHAR(50) NOT NULL,
    proveedor_codigo VARCHAR(10),
    fecha_emision DATETIME,
    monto DECIMAL(18,2) NOT NULL,
    estado TINYINT DEFAULT 0,
    objeto_codigo VARCHAR(10),
    fecha_girado DATETIME NULL,
    fecha_anulacion DATETIME NULL,
    detalles VARCHAR(300),
    KEY FK_cheques_proveedores (proveedor_codigo),
    KEY FK_cheques_objeto_gasto (objeto_codigo)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ========================================================================
-- 6. Tabla: depositos (registro de depósitos)
-- ========================================================================
CREATE TABLE IF NOT EXISTS depositos (
  DepositoID INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  Tipo ENUM('Transferencia', 'Deposito Directo') NOT NULL,
  FechaOperacion DATE NOT NULL,
  Monto DECIMAL(18,2) NOT NULL,
  Descripcion VARCHAR(200) DEFAULT NULL,
  FechaRegistro DATETIME DEFAULT CURRENT_TIMESTAMP,
  KEY idx_depositos_fecha (FechaOperacion)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ========================================================================
-- Fin del script de actualización
-- ========================================================================
