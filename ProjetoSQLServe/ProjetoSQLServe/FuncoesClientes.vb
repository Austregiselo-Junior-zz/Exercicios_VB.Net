Imports System.Data.SqlClient

Public Class FuncoesClientes
    Dim cn As New SqlConnection(My.Settings.Conecção)
    Dim cmd As New SqlCommand()

    Public Function Excluir_Cliente(ByVal data As Clientes) As Boolean
        Try
            cn.Open()
            cmd = New SqlCommand("SP_ExcluirCliente", cn)
            cmd.CommandType = CommandType.StoredProcedure 'execução do procediento SP_ExcluirCliente
            cmd.Parameters.AddWithValue("@CodCliente", data.CODCLI)

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception ' se cair aqui a função não retorna
            MsgBox("ex.mensagem")
            Return False

        Finally
            cn.Close() 'serve para organizar as conexões no banco, quando há limite de 10 usuários, um 
            'outro usuário so entra quando um sair
        End Try
    End Function
End Class
