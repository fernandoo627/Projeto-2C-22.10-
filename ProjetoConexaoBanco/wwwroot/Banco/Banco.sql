create database dbBancoApp8;
use dbBancoApp8;

/*TABELA DE USUARIO*/
create table usuario(
idUsu int primary key auto_increment,
nomeUsu varchar(50) not null,
cargo varchar(30) not null,
dataNasc datetime
);

insert into usuario(nomeUsu,cargo,dataNasc)
		values("Nilson", "Admin", "1978-05-01"),
            ("Clayton","Gerente","2000-05-15");