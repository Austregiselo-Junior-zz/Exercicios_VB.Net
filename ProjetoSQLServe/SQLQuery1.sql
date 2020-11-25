use cadastro

create proc SP_ExcluirCliente
@CodCliente as int
as
Delete from clientes where cod_cli = @CodCliente 

select * from Clientes

exec SP_ExcluirCliente 1