CREATE DATABASE Product
GO

USE Product
GO

create table tbProduct
(
	intProdId int primary key identity(1,1),
	strName varchar(100) not null,
	strDescription varchar(200) not null,
	decValue decimal(19,2) not null
)
GO

create table tbCategory
(
	intCategoryId int primary key identity(1,1),
	strName varchar(200) not null
)
GO
-- não será usada foreign key para intCategoryKey pois essa tabela será sempre zerada ao inserir um novo registro
create table tbProductCategory
(
	intProdCategoryId int primary key identity(1,1),
	intProdId int,
	intCategoryId int,
	CONSTRAINT fk_usuarioCliente foreign key (intProdId) references tbProduct (intProdId)
)

GO

CREATE TYPE CategoryNameType as TABLE
(
	strname varchar(200)
)

GO






CREATE TYPE CategoriesId as TABLE
(
	intCategoryId int
)

GO

create procedure spInsertCategory
@pCategoryNames CategoryNameType READONLY
as
begin
	set nocount on;

	truncate table tbCategory

	insert into tbCategory
		(strName)
	select 
		strname 
	from 
		@pCategoryNames


end

go


create procedure spInsertNewProduct
@pStrName varchar(100) ,
@pStrDescription varchar(200),
@pDecValue decimal(19,2),
@pCategoryId CategoriesId READONLY

as
begin

	insert into tbProduct
	(
		strName,
		strDescription,
		decValue 
	)
	values
	(
		@pStrName,
		@pStrDescription,
		@pDecValue
	)

	declare @pProductId int = scope_identity()

	
	insert into tbProductCategory
	(
		intProdId,
		intCategoryId
	)
	select
		@pProductId,
		intCategoryId
	from
		@pCategoryId
	
end

go


create procedure spReadProducts
as begin

select prod.intProdId as Code, prod.strName as Name ,strDescription as Description, prod.decValue as Value,  cat.strName as Category
into #temp
from tbProduct prod
join tbProductCategory pc on pc.intProdId = prod.intProdId
join tbCategory cat on cat.intCategoryId = pc.intCategoryId

SELECT  Code,
        Name,
		Description,
		Value,
    COALESCE(
        (SELECT CAST(Category AS VARCHAR(100)) + ';' AS [text()]
         FROM #temp AS O
         WHERE O.Code  = C.Code
         and   O.Name = C.Name
         ORDER BY Category
         FOR XML PATH(''), TYPE).value('.[1]', 'VARCHAR(MAX)'), '') AS Category
FROM #temp AS C
GROUP BY Code,
        Name,
		Description,
		Value;

end
