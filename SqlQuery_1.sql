use master
create database Calculadora

 go

 CREATE TABLE Resultados (
    Resultado integer not null,
    Mensaje varchar(250) default 'No hay mensaje' not null,
    EsValido binary default 1 not null,
);
go
