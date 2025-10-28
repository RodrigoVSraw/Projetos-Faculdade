create database TP02
go

use TP02
go

create table Cliente (
	cd_cnpj char(14) primary key,
	nm_razao_social varchar(150)
)

create table Seguradora (
	cd_cnpj char(14) primary key,
	nm_razao_social varchar(150)
)

create table Plano (
	cd_plano int primary key identity(1,1), --Identity cria número automatico
	nm_plano varchar(150) not null
)

create table Contrato (
	cd_contrato int primary key identity(1,1),
	dt_assinatura date not null,
	cd_cnpj_cliente char(14) foreign key references Cliente,
	cd_cnpj_seguradora char(14) foreign key references Seguradora
)

create table Apolice (
	cd_apolice int primary key identity(1,1),
	dt_validade date check (dt_validade > getdate()),
	cd_plano int foreign key references Plano,
	cd_contrato int foreign key references Contrato
)

create table Segurado (
	cd_segurado int primary key identity(1,1),
	nm_segurado varchar(100) not null,
	dt_nascimento date not null,
	cd_apolice int foreign key references Apolice,
	ic_titular bit default 0
)

go


-- Inserir clientes
INSERT INTO Cliente (cd_cnpj, nm_razao_social) 
VALUES 
	('12345678901234', 'Cliente A'),
	('23456789012345', 'Cliente B'),
	('34567890123456', 'Cliente C'),
	('45678901234567', 'Cliente D'),
	('56789012345678', 'Cliente E'),
	('67890123456789', 'Cliente F'),
	('78901234567890', 'Cliente G'),
	('89012345678901', 'Cliente H'),
	('90123456789012', 'Cliente I'),
	('01234567890123', 'Cliente J'),
	('98765432109876', 'Cliente K'),
	('87654321098765', 'Cliente L'),
	('76543210987654', 'Cliente M'),
	('65432109876543', 'Cliente N'),
	('54321098765432', 'Cliente O'),
	('43210987654321', 'Cliente P'),
	('32109876543210', 'Cliente Q'),
	('21098765432109', 'Cliente R'),
	('10987654321098', 'Cliente S'),
	('09876543210987', 'Cliente T');
go

-- Inserir seguradoras
INSERT INTO Seguradora (cd_cnpj, nm_razao_social) 
VALUES 
	('12345678901230', 'Seguradora Alpha'),
	('98765432109870', 'Seguradora Beta');
go

-- Inserir planos
INSERT INTO Plano (nm_plano) 
VALUES 
	('Plano Básico'),
	('Plano Standard'),
	('Plano Premium'),
	('Plano Familiar'),
	('Plano Individual');
go

-- Inserir contratos
INSERT INTO Contrato (dt_assinatura, cd_cnpj_cliente, cd_cnpj_seguradora)
VALUES 
    ('2024-01-10', '12345678901234', '12345678901230'),
    ('2024-02-10', '23456789012345', '12345678901230'),
    ('2024-03-10', '34567890123456', '12345678901230'),
    ('2024-04-10', '45678901234567', '12345678901230'),
    ('2024-05-10', '56789012345678', '12345678901230'),
    ('2024-06-10', '67890123456789', '12345678901230'),
    ('2024-07-10', '78901234567890', '12345678901230'),
    ('2024-08-10', '89012345678901', '12345678901230'),
    ('2024-09-10', '90123456789012', '12345678901230'),
    ('2024-10-10', '01234567890123', '12345678901230');
go

--Inserir apólices 
INSERT INTO Apolice (dt_validade, cd_plano, cd_contrato)
VALUES 
    ('2026-02-01', 1, 1),
    ('2026-02-01', 2, 1),
    ('2026-03-01', 3, 2),
    ('2026-03-01', 4, 2),
    ('2026-03-01', 5, 2),
	('2026-04-01', 3, 3),
    ('2026-03-03', 4, 4),
    ('2026-03-03', 5, 4);
go

-- Inserir Segurados
INSERT INTO Segurado (nm_segurado, dt_nascimento, cd_apolice, ic_titular)
VALUES 
    ('Segurado 1','2000-01-01', 1, 1),
    ('Segurado 2','2000-02-01', 1, 0),
    ('Segurado 3','2000-03-01', 1, 0),
    ('Segurado 4','2000-04-01', 1, 0),
    ('Segurado 5','2000-05-01', 1, 0),
    ('Segurado 6','2000-06-01', 2, 1),
    ('Segurado 7','2000-07-01', 2, 0),
    ('Segurado 8','2000-08-01', 2, 0),
    ('Segurado 9','2000-09-01', 2, 0),
    ('Segurado10','2000-01-01', 2, 0),
    ('Segurado11','2000-01-01', 3, 1),
    ('Segurado12','2000-01-01', 3, 0),
    ('Segurado13','2000-01-01', 3, 0),
    ('Segurado14','2000-01-01', 3, 0),
    ('Segurado15','2000-01-01', 3, 0),
    ('Segurado16','2000-01-01', 4, 1),
    ('Segurado17','2000-01-01', 4, 0),
    ('Segurado18','2000-01-01', 4, 0),
    ('Segurado19','2000-01-01', 4, 0),
    ('Segurado20','2000-01-01', 4, 0);
go


-- EXS PARA PRATICAR

-- 1
Select cd_segurado, nm_segurado, dt_nascimento
FROM Segurado

-- 2
SELECT nm_plano
FROM Plano

-- 3
SELECT *
FROM Contrato

-- 4
SELECT *
FROM Cliente
WHERE cd_cnpj = '12345678901234'

-- 5
SELECT *
FROM Contrato
WHERE cd_cnpj_cliente = '12345678901234'

-- 6
SELECT nm_razao_social
FROM Seguradora
WHERE cd_cnpj = '12345678901230'

-- 7
SELECT *
FROM Apolice
WHERE cd_contrato = 1

-- 8
SELECT *
FROM SEGURADO
WHERE (cd_apolice = 1 OR cd_apolice = 2) AND ic_titular = 1


-- Resumindo

SELECT * FROM Segurado WHERE cd_apolice in(
	SELECT cd_apolice FROM Apolice WHERE cd_contrato in( 
		SELECT cd_contrato FROM Contrato WHERE cd_cnpj_cliente = '12345678901234'
		)
	) AND ic_titular = 1


-- Usando o ORDER BY
SELECT * FROM Segurado
WHERE cd_segurado = 1
ORDER BY dt_nascimento DESC


-- Usando sem o WHERE
SELECT * FROM Segurado
ORDER BY dt_nascimento, cd_apolice DESC
