create database PitechNovo;

use PitechNovo;


create table cliente (
codigo int not null auto_increment primary key,
nome varchar(50) not null,
cpf bigint (13) not null,
telefone varchar(45) not null, 
endereco varchar(70) not null, 
rg varchar(10) not null,
datanasc date not null,
PetCliente_codigo int not null,
doacaoSuprimentos_idsupri int not null
)Engine = InnoDB;


alter table Cliente add constraint PetCliente
foreign key (PetCliente_codigo) references PetCliente(codigo);

alter table Cliente add constraint doacaoSuprimentos
foreign key (doacaoSuprimentos_idsupri)references doacaoSuprimentos(idsupri);


create table ADM(
codigo int not null auto_increment primary key,
nome varchar(45) not null,
cuidado varchar(45) not null,
funcionario varchar(45) not null,
estoque_idestoque int not null,
creche_idcreche int not null,
doacaoSuprimentos_idsupri int not null,
PetAdotante_iddoacao int not null,
PetAdotante_cliente_codigo int not null
)Engine = InnoDB;



alter table ADM add constraint estoque 
foreign key (estoque_idestoque) references estoque(idestoque);

alter table ADM add constraint Creche 
foreign key (Creche_idcreche) references Creche(idcreche);

alter table ADM add constraint doacaoSuprimentos
foreign key (doacaoSuprimentos_idsupri) references doacaoSuprimentos(idsupri);

alter table ADM add constraint doacaodePets
foreign key (PetAdotante_iddoacao) references PetAdotante(iddoacao);


create table Creche (
idcreche int not null auto_increment primary key,
datta date not null,
cliente_codigo int not null
)Engine = InnoDB;


alter table Creche add constraint Cliente
foreign key (cliente_codigo) references cliente(codigo);


create table PetCliente(
codigo int not null auto_increment primary key,
Nome varchar(90) not null,
Raca varchar(45) not null,
Porte varchar(60) not null,
SituacaoDescricao varchar(150) not null,
Genero varchar(45) not null,
AnosdeVida date not null
)Engine = InnoDB;


-- TABELA N/ N CLIENTE E DOAÇÃO 
create table ClientehasDoacao(
cliente_codigo int not null,
PetAdotante_iddoacao int not null,
PetAdotante_cliente_codigo int not null
)Engine = InnoDB;


create table  doacaoSuprimentos(
idsupri int not null auto_increment primary key,
tipodeproduto varchar(80) not null,
qntddoar decimal(10,2) not null
)Engine = InnoDB;

create table PetAdotante (
iddoacao int not null auto_increment primary key,
idade date not null,
tipoanimal varchar(50)not null,
sexo varchar(45) not null,
tamanho varchar(45) not null,
cliente_codigo int not null
)Engine = InnoDB;

alter table PetAdotante add constraint Cliente
foreign key (cliente_codigo) references cliente(codigo);

create table estoque(
idestoque int not null auto_increment primary key,
descricaoprodutos varchar(45) not null,
qntproduto  decimal(10,2) not null,
datavalidade datetime not null
)Engine = InnoDB;



insert into cliente(codigo,nome,cpf,telefone,endereco,rg,datanasc,PetCliente_codigo,doacaoSuprimentos_idsupri)
values('','paulo ricardo','1234567812345','119884251','senac','415271',' 2003-02-06' , '1', '1');


insert into ADM(codigo,nome,cuidado,funcionario,estoque_idestoque,creche_idcreche,doacaoSuprimentos_idsupri ,PetAdotante_iddoacao,PetAdotante_cliente_codigo)
values ('','iza','medico','barao','1','1','1','1','1');


insert into Creche(idcreche,datta,cliente_codigo)
values('','2003-01-03','1');

insert into PetCliente(codigo,Nome,Raca,Porte,SituacaoDescricao,Genero,AnosdeVida)
values('','danone','golden','medio','caramelo','macho','4');

insert into doacaoSuprimentos(idsupri,tipodeproduto ,qntddoar)
values('','ração','12');

insert into PetAdotante(iddoacao,idade,tipoanimal,sexo,tamanho,cliente_codigo) 
values('','5','cachorro','femea','medio','1');

insert into estoque(idestoque,descricaoprodutos,qntproduto,datavalidade)
values('','ração','12','2003-02-06');

