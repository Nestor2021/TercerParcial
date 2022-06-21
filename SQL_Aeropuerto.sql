Create database Aeropuerto

use Aeropuerto
 


Create table avion (
IdAvion int primary key identity (1,1) not null,
NombreAvion varchar(50) not null,
marca varchar(50) not null,
capacidad int not null,
descripcion varchar(50) not null,
);

insert into avion values ('Sol','Avianca',25,'nada')

select * from avion