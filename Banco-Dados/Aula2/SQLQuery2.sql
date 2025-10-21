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








