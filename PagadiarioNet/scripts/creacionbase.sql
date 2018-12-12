
create database pagadiario;
use pagadiario; 

create table Cliente
(
	cedula varchar(20) unique,
	apellidos varchar(100), 
	nombres varchar(100), 
	telefono varchar(10), 
	celular varchar(10), 
	direccion varchar(max), 
	notas varchar(max),
	id int identity(1, 1) primary key 
)

create table Cobrador
( 
	cobrador varchar(200),  
	celular varchar(10), 
	zona varchar(max),	
	id int identity(1, 1) primary key
)

create table Prestamo
(
	numero varchar(30), 
	fecha date,
	cantidad float, 
	interes float, 
	formaPago varchar(20), 
	fechaLimite date,	 
	idCliente int foreign key references Cliente(id),
	id int identity(1, 1) primary key, 
	totalPagar as cantidad + (cantidad * (interes/100)),	  
)

create table Pago
(
	numero varchar(30),
	cantidad float, 
	fecha date, 
	proximoPago date,
	idPrestamo int, 
	idCobrador int foreign key references Cobrador(id), 
	id int identity(1, 1) primary key 
)

alter table Pago add foreign key(idPrestamo) references Prestamo(id)
 

