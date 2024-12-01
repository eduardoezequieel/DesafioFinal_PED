CREATE DATABASE saborLocal;
GO

USE saborLocal;
GO

CREATE TABLE tipo_usuario( 
    idTipoUsuario INT IDENTITY(1,1) PRIMARY KEY,
    nombreTipoUsuario NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE usuario(
    idUsuario INT IDENTITY(1,1) PRIMARY KEY,
    idTipoUsuario INT,
    usuario VARCHAR(50) NOT NULL,
    contrasena NVARCHAR(MAX) NOT NULL,
    CONSTRAINT fk_tipo_usuario FOREIGN KEY (idTipoUsuario) REFERENCES tipo_usuario(idTipoUsuario)
);
GO

CREATE TABLE mesa(
    idMesa INT IDENTITY(1,1) PRIMARY KEY,
    capacidad INT NOT NULL,
    notas NVARCHAR(200)
);
GO

CREATE TABLE estado_reserva(
    idEstadoReserva INT IDENTITY(1,1) PRIMARY KEY,
    nombreEstadoReserva NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE reservacion(
    idReservacion INT IDENTITY(1,1) PRIMARY KEY,
    idMesa INT,
    idEstadoReservacion INT,
    idUsuario INT,
    cliente NVARCHAR(50) NOT NULL,
    fechaHoraInicio DATETIME NOT NULL,
    fechaHoraFin DATETIME NOT NULL,
    CONSTRAINT fk_mesa FOREIGN KEY (idMesa) REFERENCES mesa(idMesa),
    CONSTRAINT fk_estado_reserva FOREIGN KEY (idEstadoReservacion) REFERENCES estado_reserva(idEstadoReserva),
    CONSTRAINT fk_usuario FOREIGN KEY (idUsuario) REFERENCES usuario(idUsuario)
);
GO

CREATE TABLE estado_orden(
    idEstadoOrden INT IDENTITY(1,1) PRIMARY KEY,
    estadoOrden NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE metodo_pago(
    idMetodoPago INT IDENTITY(1,1) PRIMARY KEY,
    metodoPago NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE menu(
    idMenu INT IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(50) NOT NULL,
);
GO

CREATE TABLE platillo(
    idPlatillo INT IDENTITY(1,1) PRIMARY KEY,
    idMenu INT,
    nombre NVARCHAR(50) NOT NULL,
    precio DECIMAL(10,2) NOT NULL,
    CONSTRAINT fk_menu FOREIGN KEY (idMenu) REFERENCES menu(idMenu)
);
GO

CREATE TABLE orden(
    idOrden INT IDENTITY(1,1) PRIMARY KEY,
    idMetodoPago INT,
    idEstadoOrden INT,
    idReservacion INT,
    total DECIMAL(10,2) NOT NULL,
    CONSTRAINT fk_metodo_pago FOREIGN KEY (idMetodoPago) REFERENCES metodo_pago(idMetodoPago),
    CONSTRAINT fk_estado_orden FOREIGN KEY (idEstadoOrden) REFERENCES estado_orden(idEstadoOrden),
    CONSTRAINT fk_reservacion FOREIGN KEY (idReservacion) REFERENCES reservacion(idReservacion)
);
GO

CREATE TABLE detalle_orden(
    idDetalleOrden INT IDENTITY(1,1) PRIMARY KEY,
    idOrden INT,
    idPlatillo INT,
    cantidad INT NOT NULL,
    subtotal DECIMAL(10,2) NOT NULL,
    CONSTRAINT fk_orden FOREIGN KEY (idOrden) REFERENCES orden(idOrden),
    CONSTRAINT fk_platillo FOREIGN KEY (idPlatillo) REFERENCES platillo(idPlatillo)
)

INSERT INTO tipo_usuario(nombreTipoUsuario) VALUES ('Administrador');
INSERT INTO usuario(idTipoUsuario, usuario, contrasena) VALUES (1, 'admin', 'HrE4PPDP3lAAShHArhTdCQ==');

INSERT INTO estado_reserva(nombreEstadoReserva) VALUES ('Pendiente'), ('Activa'), ('Cancelada'), ('Finalizada');

INSERT INTO mesa(capacidad, notas) VALUES
(6, 'Esta a la par de la ventana'),
(7, 'nsahjkdg jashdgav jashdgadsklcbn uicsd hjsdgcc jks'),
(4, 'Cerca de la entrada principal'),
(10, 'En la esquina del restaurante'),
(8, 'Junto a la ventana del fondo'),
(5, 'Bajo una lámpara brillante'),
(6, 'Al lado de la barra de bebidas'),
(12, 'Mesa VIP cerca del escenario'),
(3, 'Mesa pequeña para dos personas'),
(9, 'Ubicada en la terraza');

-- Reservación 1
INSERT INTO reservacion (idMesa, idEstadoReservacion, idUsuario, cliente, fechaHoraInicio, fechaHoraFin)
VALUES (2, 1, 3, 'Juan Pérez', GETDATE(), DATEADD(HOUR, 2, GETDATE()));

-- Reservación 2
INSERT INTO reservacion (idMesa, idEstadoReservacion, idUsuario, cliente, fechaHoraInicio, fechaHoraFin)
VALUES (6, 2, 3, 'María López', GETDATE(), DATEADD(HOUR, 3, GETDATE()));

-- Reservación 3
INSERT INTO reservacion (idMesa, idEstadoReservacion, idUsuario, cliente, fechaHoraInicio, fechaHoraFin)
VALUES (7, 3, 3, 'Carlos Méndez', GETDATE(), DATEADD(HOUR, 1, GETDATE()));

-- Reservación 4
INSERT INTO reservacion (idMesa, idEstadoReservacion, idUsuario, cliente, fechaHoraInicio, fechaHoraFin)
VALUES (11, 4, 3, 'Ana García', GETDATE(), DATEADD(HOUR, 4, GETDATE()));

-- Reservación 5
INSERT INTO reservacion (idMesa, idEstadoReservacion, idUsuario, cliente, fechaHoraInicio, fechaHoraFin)
VALUES (12, 1, 3, 'Luis Martínez', GETDATE(), DATEADD(HOUR, 2, GETDATE()));

-- Reservación 6
INSERT INTO reservacion (idMesa, idEstadoReservacion, idUsuario, cliente, fechaHoraInicio, fechaHoraFin)
VALUES (13, 2, 3, 'Sofía Herrera', GETDATE(), DATEADD(HOUR, 3, GETDATE()));

