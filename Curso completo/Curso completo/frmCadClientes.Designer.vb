<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCadClientes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Btn_Novo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_CodigoBusca = New System.Windows.Forms.TextBox()
        Me.txt_Nome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Endereco = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_telefone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btn_Salvar = New System.Windows.Forms.Button()
        Me.Btn_Editar = New System.Windows.Forms.Button()
        Me.Btn_Limpar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodclientesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeclientesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndclientesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelclientesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cadastro2DataSet = New Curso.Cadastro2DataSet()
        Me.Btn_buscar = New System.Windows.Forms.Button()
        Me.Btn_excluir = New System.Windows.Forms.Button()
        Me.Cadastro2DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Curso.Cadastro2DataSetTableAdapters.ClientesTableAdapter()
        Me.btnabrirform = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cadastro2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cadastro2DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Novo
        '
        Me.Btn_Novo.Location = New System.Drawing.Point(7, 168)
        Me.Btn_Novo.Name = "Btn_Novo"
        Me.Btn_Novo.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Novo.TabIndex = 0
        Me.Btn_Novo.Text = "Novo"
        Me.Btn_Novo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Código"
        '
        'txt_CodigoBusca
        '
        Me.txt_CodigoBusca.Location = New System.Drawing.Point(12, 25)
        Me.txt_CodigoBusca.Name = "txt_CodigoBusca"
        Me.txt_CodigoBusca.Size = New System.Drawing.Size(22, 20)
        Me.txt_CodigoBusca.TabIndex = 5
        '
        'txt_Nome
        '
        Me.txt_Nome.Location = New System.Drawing.Point(12, 116)
        Me.txt_Nome.Name = "txt_Nome"
        Me.txt_Nome.Size = New System.Drawing.Size(70, 20)
        Me.txt_Nome.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nome"
        '
        'txt_Endereco
        '
        Me.txt_Endereco.Location = New System.Drawing.Point(98, 116)
        Me.txt_Endereco.Name = "txt_Endereco"
        Me.txt_Endereco.Size = New System.Drawing.Size(219, 20)
        Me.txt_Endereco.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Endereço"
        '
        'txt_telefone
        '
        Me.txt_telefone.Location = New System.Drawing.Point(323, 116)
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(120, 20)
        Me.txt_telefone.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(323, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Telefone"
        '
        'Btn_Salvar
        '
        Me.Btn_Salvar.Enabled = False
        Me.Btn_Salvar.Location = New System.Drawing.Point(88, 168)
        Me.Btn_Salvar.Name = "Btn_Salvar"
        Me.Btn_Salvar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Salvar.TabIndex = 12
        Me.Btn_Salvar.Text = "Salvar"
        Me.Btn_Salvar.UseVisualStyleBackColor = True
        '
        'Btn_Editar
        '
        Me.Btn_Editar.Location = New System.Drawing.Point(169, 168)
        Me.Btn_Editar.Name = "Btn_Editar"
        Me.Btn_Editar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Editar.TabIndex = 13
        Me.Btn_Editar.Text = "Editar"
        Me.Btn_Editar.UseVisualStyleBackColor = True
        '
        'Btn_Limpar
        '
        Me.Btn_Limpar.Location = New System.Drawing.Point(331, 168)
        Me.Btn_Limpar.Name = "Btn_Limpar"
        Me.Btn_Limpar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Limpar.TabIndex = 14
        Me.Btn_Limpar.Text = "Limpar"
        Me.Btn_Limpar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodclientesDataGridViewTextBoxColumn, Me.NomeclientesDataGridViewTextBoxColumn, Me.EndclientesDataGridViewTextBoxColumn, Me.TelclientesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 215)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(431, 137)
        Me.DataGridView1.TabIndex = 15
        '
        'CodclientesDataGridViewTextBoxColumn
        '
        Me.CodclientesDataGridViewTextBoxColumn.DataPropertyName = "Cod_clientes"
        Me.CodclientesDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodclientesDataGridViewTextBoxColumn.Name = "CodclientesDataGridViewTextBoxColumn"
        Me.CodclientesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeclientesDataGridViewTextBoxColumn
        '
        Me.NomeclientesDataGridViewTextBoxColumn.DataPropertyName = "Nome_clientes"
        Me.NomeclientesDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.NomeclientesDataGridViewTextBoxColumn.Name = "NomeclientesDataGridViewTextBoxColumn"
        Me.NomeclientesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EndclientesDataGridViewTextBoxColumn
        '
        Me.EndclientesDataGridViewTextBoxColumn.DataPropertyName = "End_clientes"
        Me.EndclientesDataGridViewTextBoxColumn.HeaderText = "Endereço"
        Me.EndclientesDataGridViewTextBoxColumn.Name = "EndclientesDataGridViewTextBoxColumn"
        Me.EndclientesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelclientesDataGridViewTextBoxColumn
        '
        Me.TelclientesDataGridViewTextBoxColumn.DataPropertyName = "Tel_clientes"
        Me.TelclientesDataGridViewTextBoxColumn.HeaderText = "Telefone"
        Me.TelclientesDataGridViewTextBoxColumn.Name = "TelclientesDataGridViewTextBoxColumn"
        Me.TelclientesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.Cadastro2DataSet
        '
        'Cadastro2DataSet
        '
        Me.Cadastro2DataSet.DataSetName = "Cadastro2DataSet"
        Me.Cadastro2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Btn_buscar
        '
        Me.Btn_buscar.Location = New System.Drawing.Point(62, 23)
        Me.Btn_buscar.Name = "Btn_buscar"
        Me.Btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_buscar.TabIndex = 17
        Me.Btn_buscar.Text = "Buscar"
        Me.Btn_buscar.UseVisualStyleBackColor = True
        '
        'Btn_excluir
        '
        Me.Btn_excluir.Location = New System.Drawing.Point(250, 168)
        Me.Btn_excluir.Name = "Btn_excluir"
        Me.Btn_excluir.Size = New System.Drawing.Size(75, 23)
        Me.Btn_excluir.TabIndex = 19
        Me.Btn_excluir.Text = "Excluir"
        Me.Btn_excluir.UseVisualStyleBackColor = True
        '
        'Cadastro2DataSetBindingSource
        '
        Me.Cadastro2DataSetBindingSource.DataSource = Me.Cadastro2DataSet
        Me.Cadastro2DataSetBindingSource.Position = 0
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'btnabrirform
        '
        Me.btnabrirform.Location = New System.Drawing.Point(368, 22)
        Me.btnabrirform.Name = "btnabrirform"
        Me.btnabrirform.Size = New System.Drawing.Size(75, 23)
        Me.btnabrirform.TabIndex = 20
        Me.btnabrirform.Text = "Abrir form"
        Me.btnabrirform.UseVisualStyleBackColor = True
        '
        'FrmCadClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 363)
        Me.Controls.Add(Me.btnabrirform)
        Me.Controls.Add(Me.Btn_excluir)
        Me.Controls.Add(Me.Btn_buscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btn_Limpar)
        Me.Controls.Add(Me.Btn_Editar)
        Me.Controls.Add(Me.Btn_Salvar)
        Me.Controls.Add(Me.txt_telefone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Endereco)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Nome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_CodigoBusca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Novo)
        Me.Name = "FrmCadClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de clientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cadastro2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cadastro2DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Novo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_CodigoBusca As TextBox
    Friend WithEvents txt_Nome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Endereco As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_telefone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_Salvar As Button
    Friend WithEvents Btn_Editar As Button
    Friend WithEvents Btn_Limpar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Cadastro2DataSetBindingSource As BindingSource
    Friend WithEvents Cadastro2DataSet As Cadastro2DataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As Cadastro2DataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents CodclientesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeclientesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndclientesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelclientesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Btn_buscar As Button
    Friend WithEvents Btn_excluir As Button
    Friend WithEvents btnabrirform As Button
End Class
