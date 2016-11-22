create table Clientes(
ClienteId int primary key identity(1,1),
Nombres varchar (30),
FechaNacimiento DateTime,
LimiteCredito float
);

create table TiposTelefonos(
TipoId int primary key identity (1,1),
Descripcion varchar(10)
);

create table ClientesTelefonos(
Id int primary key identity (1,1),
ClienteId int,
TipoId int
);
