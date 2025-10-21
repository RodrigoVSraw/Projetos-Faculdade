create database Aula2

use Aula2


-- TIPOS DE CONSTRAINT

-- ##PRIMARY KEY##

-- CRIAÇÃO
create table Tabela1 (
	cd_tabela1 INT PRIMARY KEY,
	nm_tabela1 VARCHAR(50)
)

-- ALTERAÇÃO
alter table Tabela1 
ADD PRIMARY KEY cd_tabela1


-- ##FOREIGN KEY##

-- CRIAÇÃO
CREATE TABLE Tabela2
(
	cd_tabela2 INT PRIMARY KEY,
	cd_tabela1 INT NOT NULL
	FOREIGN KEY (cd_tabela1) REFERENCES Tabela1
)

CREATE TABLE Tabela2
(
	cd_tabela2 INT PRIMARY KEY,
	cd_tabela1 INT FOREIGN KEY REFERENCES Tabela1
)

-- ALTERAÇÃO
ALTER TABLE Tabela2 
ADD FOREIGN KEY (cd_tabela1)
REFERENCES Tabela1


-- ##UNIQUE##

-- CRIAÇÃO
CREATE TABLE Tabela2
(
	cd_tabela2 INT PRIMARY KEY,
	ds_email VARCHAR(100) UNIQUE
)

-- ALTERAÇÃO
ALTER TABLE Tabela4 ADD CONSTRAINT UQ_Email UNIQUE (ds_email)


-- ##CHECK##

-- CRIAÇÃO
CREATE TABLE Tabela2
(
	cd_tabela2 INT PRIMARY KEY,
	nm_tabela2 VARCHAR,
	qt_idade INT CHECK (qt_idade >= 18)
)

-- ALTERAÇÃO
ALTER TABLE Tabela2


-- ##NOT NULL##

-- CRIAÇÃO
CREATE TABLE Tabela2
(
	cd_tabela2 INT PRIMARY KEY,
	nm_tabela2 VARCHAR NOT NULL,
)

-- ALTERAÇÃO


-- ##DEFAULT##

-- CRIAÇÃO
CREATE TABLE Tabela2
(
	cd_tabela2 INT PRIMARY KEY,
	vl_produto DECIMAL(10, 2) DEFAULT 0
)

-- ALTERAÇÂO
ALTER TABLE Tabela2
ADD CONSTRAINT vl_produto DEFAULT 0

-- #######################################

-- INSERT

-- ##DECLARANDO COLUNAS##
-- PODE TROCAR AS ORDENS DAS COLUNAS, E NÃO PRECISA DE VALOR EM TODAS
INSERT INTO TB1
	(C1, C2, C3, C4)
VALUES (3, 'x', 50, 0)

INSERT INTO TB1
	(C4, C2, C3)
VALUES (3, 'x', 50)

	
-- ##SEM DECLARAR AS COLUNAS##
-- PRECISA COLOCAR VALOR EM TODAS AS COLUNAS, E EM ORDEM
INSERT INTO TB1
VALUES (3, 'x', 50, 0)

-- ##CONSULTA DE DADOS##

-- SELECT BÁSICO

-- ESTRUTURA 1 - Seleciona as colunas que são necessárias
SELECT C1, C2, C3, C4
FROM TB1

-- ESTRUTURA 2 - Seleciona todas as colunas
SELECT *
FROM TB1













