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
        contrasena VARBINARY(MAX) NOT NULL,
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