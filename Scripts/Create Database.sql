CREATE DATABASE Product
GO

USE Product
GO

create table tbProduct
(
	intProdCode int primary key identity(1,1),
	strName varchar(100) not null,
	strDescription varchar(200) not null,
	decValue decimal(19,2) not null
)

create table tbCategory
(
	intCategoryCode int primary key identity(1,1),
	strName varchar(200) not null
)
-- não será usada foreign key para intCategoryKey pois essa tabela será sempre zerada ao inserir um novo registro
create table tbProductCategory
(
	intProdCategoryCode int primary key identity(1,1),
	intProdCode int,
	intCategoryCode int,
	CONSTRAINT fk_usuarioCliente foreign key (intProdCode) references tbProduct (intProdCode)
)
