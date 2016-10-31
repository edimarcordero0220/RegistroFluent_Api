use RegistroFluentApiDb;

create table Estudiantes(
 IdEstudiante int identity (1,1) primary key,
 EstudianteNombre varchar (30),
 Grupo varchar(20),
 Estudiante int 

);

create table Grupos(
IdGrupo int identity (1,1) primary key,
NombreGrupo varchar(20)
);

create table GruposEstudiantes(
Id int identity (1,1) primary key,
IdGrupo int,
IdEstudiante int,
EstudianteNombre varchar (30),
NombreGrupo varchar (30)
);