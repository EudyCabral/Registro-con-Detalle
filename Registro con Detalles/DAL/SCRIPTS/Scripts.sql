CREATE DATABASE DetallesDb
go
use DetallesDb
go
CREATE TABLE Detalles
(
	PersonaId int primary key identity(1,1),
	Fecha DateTime,
	Nombres varchar(30),
	Cedula varchar(13),
	Telefono varchar(13),
	Direccion varchar(max)


);