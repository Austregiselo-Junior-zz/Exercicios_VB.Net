Public Class Clientes
    Private _CODCLI As Integer
    Private _NOMECLI As Integer
    Private _ENDCLI As Integer
    Private _TELCLI As Integer

    Public Property CODCLI As Integer
        Get 'recebe
            Return _CODCLI
        End Get
        Set(value As Integer) 'passar informação ao banco
            _CODCLI = value
        End Set
    End Property

    Public Property NOMECLI As Integer
        Get 'recebe
            Return _NOMECLI
        End Get
        Set(value As Integer) 'passar informação ao banco
            _NOMECLI = value
        End Set
    End Property

    Public Property ENDCLI As Integer
        Get 'recebe
            Return _ENDCLI
        End Get
        Set(value As Integer) 'passar informação ao banco
            _ENDCLI = value
        End Set
    End Property

    Public Property TELCLI As Integer
        Get 'recebe
            Return _TELCLI
        End Get
        Set(value As Integer) 'passar informação ao banco
            _TELCLI = value
        End Set
    End Property
End Class
