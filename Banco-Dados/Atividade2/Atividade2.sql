CREATE DATABASE TP2
go

USE TP2
go

-- TABELAS
CREATE TABLE CLIENTE
(
	cd_cnpj int PRIMARY KEY,
	nm_razao_social varchar(50)
)

CREATE TABLE SEGURADORA
(
	cd_cnpj int PRIMARY KEY,
	nm_razao_social varchar(50)
)

CREATE TABLE PLANO
(
	cd_plano int PRIMARY KEY,
	nm_plano varchar(20),
	sg_plano varchar(40),
	ds_beneficios varchar(100)
)

CREATE TABLE CONTRATO
(
	cd_contrato int PRIMARY KEY,
	dt_assinatura date DEFAULT GETDATE(),
	cd_cnpj_cliente int FOREIGN KEY REFERENCES CLIENTE,
	cd_cnpj_seguradora int FOREIGN KEY REFERENCES SEGURADORA

)

CREATE TABLE APOLICE
(
	cd_apolice int PRIMARY KEY,
	dt_validade date,
	cd_plano int FOREIGN KEY REFERENCES PLANO,
	cd_contrato int FOREIGN KEY REFERENCES CONTRATO
)

CREATE TABLE SEGURADO
(
	cd_segurado int PRIMARY KEY,
	nm_segurado varchar(50),
	dt_nascimento date,
	cd_apolice int FOREIGN KEY REFERENCES APOLICE,
	ic_titular varchar(50)
)

go

-- INSERTS
INSERT INTO CLIENTE
VALUES
	(1, 'Autocarros'),
	(2, 'Augusto Bebidas')

INSERT INTO SEGURADORA
VALUES
	(1, 'Seguradora Live'),
	(2, 'Seguros Auto')

INSERT INTO PLANO
VALUES
	(1, 'Básico', '', ''),
	(2, 'Premium', '', '')

INSERT INTO CONTRATO (cd_contrato, cd_cnpj_cliente, cd_cnpj_seguradora)
VALUES
	(1, 2, 1),
	(2, 1, 2)

INSERT INTO APOLICE
VALUES
	(1, '2026-07-19', 2, 1),
	(2, '2027-11-30', 2, 2)

INSERT INTO SEGURADO
VALUES
	(1, 'Augusto Benjo', '1977-05-19', 1, 'Augusto Benjo'),
	(2, 'Marcos Manco', '2000-01-24', 2, 'George Vinte')
go

-- SELECT

SELECT *
FROM CLIENTE

SELECT *
FROM SEGURADORA 

SELECT *
FROM PLANO

SELECT *
FROM CONTRATO

SELECT *
FROM APOLICE

SELECT *
FROM SEGURADO
go

