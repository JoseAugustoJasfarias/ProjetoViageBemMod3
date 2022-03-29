--Modelo físico SQL Server ViageBem

CREATE DATABASE ViageBem

USE ViageBem


CREATE TABLE CLIENTE (
Id_Cliente int PRIMARY KEY,
Id_Destino_Cliente int,
NomeCliente VARCHAR(200 ),
TelefoneCliente VARCHAR(80 ),
EmailCliente VARCHAR(200 )
)

CREATE TABLE DESTINO (
Id_Destino_Cliente int PRIMARY KEY,
NomeDestino VARCHAR(200),
Pais VARCHAR( 100),
DataViagem date
)

CREATE TABLE Contato (
Id_Contato int PRIMARY KEY,
Nome VARCHAR(200 ),
Email VARCHAR(200 ),
Telefone VARCHAR(80 ),
Destino VARCHAR(200 ),
Mensagem VARCHAR(5000 )
)

ALTER TABLE CLIENTE ADD FOREIGN KEY(Id_Destino_Cliente) REFERENCES DESTINO (Id_Destino_Cliente)
