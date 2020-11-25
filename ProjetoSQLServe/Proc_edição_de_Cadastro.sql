Use Cadastro


-- Procedimento para excluir cliente
Create proc SP_ExcluirUsuário
@Cod_U as int
as
Delete from Cadastro_U WHERE Código=@Cod_U
go
Select*from Cadastro_U
 execute  SP_ExcluirUsuário 
 go
 

 -- Procedimento para Inserir cliente
 Create proc SP_InserirUsuário
@Cod_U as int,
@Nome_U as nchar(50),
@End_U as nchar(50),
@Tel_U as nchar(50),
@Email_U as nchar (50),
@CPF_U as int
as
insert into Cadastro_U values (@Cod_U,@Nome_U,@End_U,@Tel_U,@Email_U,@CPF_U)
go
Select*from Cadastro_U

