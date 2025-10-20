CREATE DATABASE TP1

use TP1

create table Usuário 
(
	ds_email varchar not null,
	nm_usuario varchar,
	ds_senha varchar,
	cd_assinatura int not null
)

alter table Usuário
add primary key (ds_email)

alter table Usuário
add foreign key (cd_assinatura)
references Assinatura

create table Assinatura
(
	cd_assinatura int not null,
	nm_assinatura varchar,
	sg_nivel int not null,
	vl_assinatura int
)

alter table Assinatura
add primary key (cd_assinatura)

create table Transação 
(
	cd_transacao int not null,
	dt_transacao date,
	vl_pago int,
	sg_tipo varchar,
	cd_usuario varchar not null,
	cd_livro int not null
)

alter table Transação
add primary key (cd_transacao)

alter table Transação
add foreign key (cd_livro)
references Livro

alter table Transação
add foreign key (cd_usuario)
references Usuário

create table Livro
(
	cd_livro int not null,
	nm_titulo varchar,
	nm_autor varchar,
	sg_genero varchar,
	ds_sinopse varchar,
	sg_disponibilidade varchar,	
)

alter table Livro 
add primary key (cd_livro)

create table Avaliação
(
	cd_avaliacao int not null,
	ds_comentario varchar,
	cd_livro int not null,
	cd_usuario varchar not null
)

alter table Avaliação
add primary key (cd_avaliacao)

alter table Avaliação
add foreign key (cd_livro)
references Livro

alter table Avaliação
add foreign key (cd_usuario)
references Usuário


