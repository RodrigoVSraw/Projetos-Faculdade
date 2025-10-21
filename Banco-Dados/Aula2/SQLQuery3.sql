CREATE DATABASE EX1

USE EX1

CREATE TABLE VENDEDOR
(
	cd_vendedor INT PRIMARY KEY,
	nm_vendedor VARCHAR(40),
	ds_endereco VARCHAR,
	pc_comissao INT CHECK (pc_comissao < 60)
)

CREATE TABLE CLIENTE
(
	cd_cliente INT PRIMARY KEY,
	nm_cliente VARCHAR(40),
	ds_endereco VARCHAR,
	ds_email VARCHAR UNIQUE NOT NULL,
	vl_faturamento MONEY,
	vl_limite MONEY,
	cd_vendedor INT FOREIGN KEY REFERENCES VENDEDOR
)

CREATE TABLE PEDIDO
(
	cd_pedido INT PRIMARY KEY,
	dt_pedido DATE DEFAULT GETDATE(),
	cd_cliente INT FOREIGN KEY REFERENCES CLIENTE,
	cd_vendedor INT FOREIGN KEY REFERENCES VENDEDOR,
	cd_peca INT FOREIGN KEY REFERENCES PEÇA
)

CREATE TABLE PEÇA
(
	cd_peca INT PRIMARY KEY,
	ds_peca VARCHAR,
	vl_peca MONEY,
	qt_estoque INT DEFAULT 0 CHECK (qt_estoque >= 0),
	cd_armazem INT FOREIGN KEY REFERENCES ARMAZEM
)

CREATE TABLE ARMAZEM
(
	cd_armazem INT PRIMARY KEY,
	ds_endereco VARCHAR
)

-- ##ISERÇÃO DE DADOS##

-- DECLARANDO COLUNAS
INSERT INTO VENDEDOR
	(cd_vendedor, nm_vendedor, ds_endereco, pc_comissao)
VALUES
	(1, 'Fulano Silva', 'A', 45)

-- SEM DECLARAR COLUNAS
INSERT INTO VENDEDOR
VALUES 
	(2, 'Fausto Silva', 'B', 20)


SELECT pc_comissao, cd_vendedor
FROM VENDEDOR

SELECT *
FROM VENDEDOR