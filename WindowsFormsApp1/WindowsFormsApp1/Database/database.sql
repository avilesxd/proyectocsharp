CREATE DATABASE CompanyIHJ;

USE CompanyIHJ;

CREATE TABLE Administrador (
ID INT IDENTITY (1,1) PRIMARY KEY,
Nombre VARCHAR (50) NOT NULL,
Apellido VARCHAR (50) NOT NULL,
Rut INT NOT NULL,
Telefono INT,
Correo VARCHAR (50)
);


CREATE TABLE Videojuegos(
ID INT IDENTITY(1,1) PRIMARY KEY,
Nombre VARCHAR (50) NOT NULL,
Categoria VARCHAR (50) not null,
Precio INT NOT NULL,
Stock INT NOT NULL,
);


CREATE TABLE Clientes(
ID INT IDENTITY (1,1) PRIMARY KEY,
Nombre VARCHAR (50) NOT NULL,
Apellido VARCHAR (50) NOT NULL,
Rut INT NOT NULL,
Telefono INT,
Correo VARCHAR (50),
Direccion VARCHAR (50),
);

CREATE TABLE Registros (
ID INT IDENTITY (1,1) PRIMARY KEY,
DetalleCompra VARCHAR (50) not null,
ID_Cliente INT FOREIGN KEY REFERENCES Clientes(ID),
ID_Videojuego INT FOREIGN KEY REFERENCES Videojuegos(ID),
);

CREATE TABLE Usuarios (
id INT IDENTITY (1,1) PRIMARY KEY,
usuario VARCHAR NOT NULL,
password VARCHAR
);
