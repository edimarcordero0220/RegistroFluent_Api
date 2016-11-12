use DetallesDb;

create table Estudiantes(
 EstudianteId int identity (1,1) primary key,
 Nombre varchar (40)
);


create table Grupos(
 GrupoId int identity (1,1)primary key,
 Nombre varchar(40)

);

create table GrupoEstudiantes(
 GrupoEstudianteId int identity (1,1) primary key,
 EstudianteId int,
 GrupoId int
);

select * from Estudiantes;