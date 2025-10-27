

create database proyectoSoft2;
use proyectoSoft2; 
        -- Tabla usuarios (login)
        CREATE TABLE usuarios (
            usuario_id INT AUTO_INCREMENT PRIMARY KEY,
            username VARCHAR(100) NOT NULL UNIQUE,
            password_hash VARCHAR(256) NOT NULL,
            nombre VARCHAR(200)
        ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
        -- Tabla conciliacion
        CREATE TABLE conciliacion (
            conciliacion_id INT AUTO_INCREMENT PRIMARY KEY,
            fecha DATETIME NOT NULL,
            descripcion VARCHAR(500),
            saldo_banco DECIMAL(18,2),
            saldo_libros DECIMAL(18,2),
            -- Montos específicos para conciliación
            depositos DECIMAL(18,2) NULL,
            cheques_girados DECIMAL(18,2) NULL,
            cheques_anulados DECIMAL(18,2) NULL,
            depositos_en_transito DECIMAL(18,2) NULL,
            cheques_en_circulacion DECIMAL(18,2) NULL,
            resultado VARCHAR(100),
            creado_en DATETIME NOT NULL
        ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

        -- Tabla cheques
        CREATE TABLE cheques (
            cheque_id INT AUTO_INCREMENT PRIMARY KEY,
            numero VARCHAR(50) NOT NULL,
            proveedor_id INT,
            fecha_emision DATETIME,
            monto DECIMAL(18,2) NOT NULL,
            banco VARCHAR(100),
            estado TINYINT NOT NULL DEFAULT 0,
            objeto_id INT,
            fecha_girado DATETIME,
            fecha_anulacion DATETIME,
            detalles VARCHAR(300),
            CONSTRAINT CK_cheques_estado CHECK (estado IN (0,1))
        ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

        -- Tabla depositos
        CREATE TABLE depositos (
            deposito_id INT AUTO_INCREMENT PRIMARY KEY,
            referencia VARCHAR(100),
            fecha DATETIME NOT NULL,
            monto DECIMAL(18,2) NOT NULL,
            banco VARCHAR(100),
            metodo_pago VARCHAR(50),
            cheque_id INT,
            creado_en DATETIME NOT NULL,
            CONSTRAINT FK_depositos_cheques FOREIGN KEY (cheque_id) REFERENCES cheques (cheque_id) ON DELETE SET NULL ON UPDATE CASCADE
        ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


