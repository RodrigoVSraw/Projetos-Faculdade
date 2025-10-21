create database Aula2

use Aula2


-- TIPOS DE CONSTRAINT

-- ##PRIMARY KEY##

-- CRIA플O
create table Tabela1 (
	cd_tabela1 INT PRIMARY KEY,
	nm_tabela1 VARCHAR(50)
)

-- ALTERA플O
alter table Tabela1 
ADD PRIMARY KEY cd_tabela1


-- ##FOREIGN KEY##

-- CRIA플O
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

-- ALTERA플O
ALTER TABLE Tabela2 
ADD FOREIGN KEY (cd_tabela1)
REFERENCES Tabela1


-- ##UNIQUE##

-- CRIA플O
CREATE TABLE Tabela2
(
	cd_tabela2 INT PRIMARY KEY,
	ds_email VARCHAR(100) UNIQUE
)

-- ALTERA플O
ALTER TABLE Tabela4 ADD CONSTRAINT UQ_Email UNIQUE (ds_email)


-- ##CHECK##

-- CRIA플O
CREATE TABLE Tabela2
(
	cd_tabela2 INT PRIMARY KEY,
	nm_tabela2 VARCHAR,
	qt_idade INT CHECK (qt_idade >= 18)
)


-- ##NOT NULL##

-- CRIA플O
CREATE TABLE Tabela2
(
	cd_tabela2 INT PRIMARY KEY,
	nm_tabela2 VARCHAR NOT NULL,
)

-- ALTERA플O


-- ##DEFAULT##

-- CRIA플O
CREATE TABLE Tabela2
(
	cd_tabela2 INT PRIMARY KEY,
	vl_produto DECIMAL(10, 2) DEFAULT 0
)

-- ALTERA픈O
ALTER TABLE Tabela2
ADD CONSTRAINT vl_produto DEFAULT 0








