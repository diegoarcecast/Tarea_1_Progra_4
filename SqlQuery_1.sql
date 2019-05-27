--use master
use Calculadora
--create database Calculadora

-- go

 Create TABLE Resultados (
    Resultado integer not null,
    Mensaje varchar(250) default 'No hay mensaje' not null,
    EsValido bit  default 1 not null,
);
go

CREATE PROCEDURE SP_INSERTAR_OPERACIONES @Resultado integer, @Mensaje varchar(250) , @EsValido binary
AS
INSERT INTO Resultados(Resultado,	Mensaje, EsValido)
VALUES (@Resultado, @Mensaje, @EsValido);
GO 
CREATE PROCEDURE SP_LISTAR_OPERACIONES @Resultado integer, @Mensaje varchar(250) , @EsValido binary
AS
SELECT * FROM Resultados
GO
