CREATE DATABASE VENDALIVRO

use VENDALIVRO

create table Usuario 
(
	ds_email varchar not null,
	nm_usuario varchar,
	ds_senha varchar,
	cd_assinatura int not null
)

alter table Usuario
add primary key (ds_email)

alter table Usuario
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

create table Transacao 
(
	cd_transacao int not null,
	dt_transacao date,
	vl_pago int,
	sg_tipo varchar,
	cd_usuario varchar not null,
	cd_livro int not null
)

alter table Transacao
add primary key (cd_transacao)

alter table Transacao
add foreign key (cd_livro)
references Livro

alter table Transacao
add foreign key (cd_usuario)
references Usuario

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

alter table Avaliacao
add primary key (cd_avaliacao)

alter table Avaliacao
add foreign key (cd_livro)
references Livro

alter table Avaliacao
add foreign key (cd_usuario)
references Usuario



