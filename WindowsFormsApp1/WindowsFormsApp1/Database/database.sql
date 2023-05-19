create database CompanyIHJ;

use CompanyIHJ;

CREATE TABLE Administrador (
ID INT IDENTITY (1,1) PRIMARY KEY,
Nombre VARCHAR (50) not null,
Apellido VARCHAR (50) not null,
Rut INT not null,
Telefono INT,
Correo VARCHAR (50)
);


CREATE TABLE Videojuegos(
ID INT IDENTITY(1,1) PRIMARY KEY,
Nombre VARCHAR (50) not null,
Categoria VARCHAR (50) not null,
Precio INT not null,
Stock INT not null,
);


CREATE TABLE Clientes(
ID INT IDENTITY (1,1) PRIMARY KEY,
Nombre VARCHAR (50) not null,
Apellido VARCHAR (50) not null,
Rut INT not null,
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

SELECT * FROM Registros;