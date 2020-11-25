Imports System.Data.SqlClient

Public Class Form1
    ' Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'quando o formulário iniciar
    '    AtualizarGrid()
    '  End Sub

    ' Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    'Dim cli As New Clientes
    'Dim func As New FuncoesClientes

    'If Me.ValidateChildren = True And TextBox1.Text <> Then 'testa de o valor posto no textbox1 existe
    'Try
    '           cli.CODCLI = TextBox1.Text
    'If func.Excluir_Cliente(cli) Then
    '               MsgBox("Excluido com sucesso", "Clientes")
    '              TextBox1.Text = ""
    '             AtualizarGrid()
    'End If

    'Catch ex As Exception
    '           MsgBox("ex.mensagem")
    'End Try
    'Else
    '       MsgBox("Insira o código para excluir", "Clientes")
    'End If

    'End Sub

    Public Function AtualizarGrid()
        Dim con As New SqlConnection(My.Settings.Conecção) 'Conexão de formulario com a configuração feita
        Dim sql As String = "SELECT Cod_cli, Nome_cli, Ende_cli, Tel_cli FROM clientes" 'consulta ao banco essas colunas
        Dim cmd As New SqlCommand(sql, con) 'Cria comando que puxa os dados da tabela segundo a conexão con


        'Serve para verificar se há erro, caso haja abaixo do Catch aparecerá a mensagem posta pelo programador
        Try
            'acossiar o grid com o banco de dados, através do dataset
            Dim da As New SqlDataAdapter(cmd) 'recebe a consulta do cmd e atualiza
            Dim ds As New DataSet
            da.Fill(ds, "clientes") 'preenche o datset a partir da tabela clientes

            Me.DataGridView1.DataSource = ds.Tables("clientes")

        Catch ex As Exception
            MsgBox("Ex. erro")
        End Try
    End Function
End Class

