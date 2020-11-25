Public Class FrmCadClientes
    Private Sub FrmCadClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Cadastro2DataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
        Me.ClientesTableAdapter.Fill(Me.Cadastro2DataSet.Clientes)
    End Sub
    Private Sub Btn_buscar_Click(sender As Object, e As EventArgs) Handles Btn_buscar.Click
        Dim CliList = From clientes In Cadastro2DataSet.Clientes 'Caminho para tabela
                      Where (clientes.Cod_clientes = Val(txt_CodigoBusca.Text)) 'buscando clientes.cod atribui ao objeto
                      Select clientes.Nome_clientes, clientes.End_clientes, clientes.Tel_clientes  'Tem como retorno o objeto atribuido acima 

        For Each cliente In CliList 'Enquanto encontra o cliente na lista CliList
            txt_Nome.Text = cliente.Nome_clientes 'Atribui ao objeto o nome do cliente
            txt_Endereco.Text = cliente.End_clientes 'Atribui ao objeto o endereço do cliente
            txt_telefone.Text = cliente.Tel_clientes 'Atribui ao objeto o telefone do cliente
        Next
    End Sub

    Private Sub Btn_Editar_Click(sender As Object, e As EventArgs) Handles Btn_Editar.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit() 'Sair no modo edição
        Me.Cadastro2DataSet.AcceptChanges() 'Mesmo que pegar do datSet e editat
        Me.ClientesTableAdapter.Update_Cli(txt_Nome.Text, txt_Endereco.Text,
                                          txt_telefone.Text, txt_CodigoBusca.Text) 'Atualizar os valores, seguindo a ordem do Dataset

        DataGridView1.DataSource = ClientesTableAdapter.GetData ' Atribui ao datagrid os dados dos bancos de dados, recebendo todos os dados
        MessageBox.Show("Insira o código para excluir", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub Btn_excluir_Click(sender As Object, e As EventArgs) Handles Btn_excluir.Click
        If txt_CodigoBusca.Text = "" Then
            MessageBox.Show("Insira o código para excluir", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            Me.ClientesBindingSource.RemoveCurrent() 'Remover linha do datagrid, mas não do banco de dados
            Me.Validate()
            Me.ClientesBindingSource.EndEdit() 'Sair no modo edição
            Me.Cadastro2DataSet.AcceptChanges() 'Mesmo que pegar do datSet e editat
            Me.ClientesTableAdapter.Delete_Cli(txt_CodigoBusca.Text) 'Atualizar os valores, seguindo a ordem do Dataset

            DataGridView1.DataSource = ClientesTableAdapter.GetData ' Atribui ao datagrid os dados dos bancos de dados, recebendo todos os dados
            MessageBox.Show("Registro excluido com sucesso!", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If
    End Sub
    Private Sub Btn_Novo_Click(sender As Object, e As EventArgs) Handles Btn_Novo.Click
        Me.ClientesBindingSource.AddNew() 'Adiniona uma linha ao datagrid
        Btn_Salvar.Enabled = True
        Btn_Novo.Enabled = False
    End Sub
    Private Sub Btn_Salvar_Click(sender As Object, e As EventArgs) Handles Btn_Salvar.Click
        If txt_Nome.Text = "" Or txt_Endereco.Text = "" Or txt_telefone.Text = "" Then
            MessageBox.Show("Preencha todos os campos", "Salvar", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            Me.Validate()
            Me.ClientesBindingSource.EndEdit() 'Sair no modo edição
            Me.Cadastro2DataSet.AcceptChanges() 'Mesmo que pegar do datSet e editat
            Me.ClientesTableAdapter.Insert_Cli(txt_Nome.Text, txt_Endereco.Text,
                                          txt_telefone.Text) 'Atualizar os valores, seguindo a ordem do Dataset
        End If
        DataGridView1.DataSource = ClientesTableAdapter.GetData ' Atribui ao datagrid os dados dos bancos de dados, recebendo todos os dados
        MessageBox.Show("Registro salvo com sucesso!", "Salvar", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Limpar()

        Btn_Novo.Enabled = True
        Btn_Salvar.Enabled = False
    End Sub
    Private Sub Limpar()
        txt_Nome.Text = ""
        txt_Endereco.Text = ""
        txt_telefone.Text = ""
        txt_CodigoBusca.Text = ""
    End Sub
    Private Sub Btn_Limpar_Click(sender As Object, e As EventArgs) Handles Btn_Limpar.Click
        Limpar()
        MessageBox.Show("Registro limpo com sucesso!", "Limpar", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub Btnabrirform_Click(sender As Object, e As EventArgs) Handles btnabrirform.Click
        Tela2.Show()

    End Sub
End Class