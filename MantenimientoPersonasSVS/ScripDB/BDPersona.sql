create database dbpersona
go 
use dbpersona
go
create table tpersonaJuridica( 
	ruc varchar(11)not null,
	razonSocial varchar(56)not null,  
	direccion varchar(56)not null, 
	telefono varchar(12)not null, 
	correoElectronico varchar(20)not null, 
	paginaURL varchar(56) not null, primary key(ruc) ) 


go
create table tpersonaNatural( 
	dni varchar(8) not null, 
	nombrePersona varchar(56)not null, 
	apellidoPersona varchar(56)not null, 
	fechaNacimiento datetime not null, 
	sexo char(1),
	direccion varchar(56)not null, 
	telefono varchar(12)not null, 
	correoElectronico varchar(67)not null, primary key (dni) )

go



