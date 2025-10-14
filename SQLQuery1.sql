--Cria um banco de dados com o nome de exemplo
create database  exemplo 

--Exclui um banco de dados
drop database exemplo

--Troca o banco de dados em que as tabelas são salvas
use exemplo

--Cria uma tabela
create table Pessoa
(
	cd_cpf varchar(11),
	nm_pessoa varchar(50),
	qt_idade int
)

--Exclui uma tabela
drop table Pessoa

--Remove uma coluna da tabela pessoa
alter table Pessoa
drop column qt_idade

--Adiciona uma coluna 
alter table Pessoa 
add dt_nascimento date

create database dbEmpresa

use dbEmpresa

create table Departamento
(
	cd_departamento int not null,
	ds_local varchar(50)
)

create table Funcionario
(
	cd_funcionario int not null,
	nm_funcionario varchar(80),
	dt_admissao date,
	cd_departamento int not null
)

--Cria uma chave primaria
alter table Departamento
add primary key (cd_departamento)

alter table Funcionario
add primary key (cd_funcionario)

alter table Funcionario
add foreign key (cd_departamento)
references Departamento