Public Class ProducaoItens
    Private _item As Integer
    Public Property Item() As Integer
        Get
            Return _item
        End Get
        Set(ByVal value As Integer)
            _item = value
        End Set
    End Property

    Private _codigoMateriaPrima As Integer
    Public Property NewProperty() As Integer
        Get
            Return _codigoMateriaPrima
        End Get
        Set(ByVal value As Integer)
            _codigoMateriaPrima = value
        End Set
    End Property

    Private _quantidadePesar As Double
    Public Property QuantidadePesar() As Double
        Get
            Return _quantidadePesar
        End Get
        Set(ByVal value As Double)
            _quantidadePesar = value
        End Set
    End Property
    Private _siloOrigem As Integer
    Public Property SiloOrigem() As Integer
        Get
            Return _siloOrigem
        End Get
        Set(ByVal value As Integer)
            _siloOrigem = value
        End Set
    End Property

    Private _lote As String
    Public Property Lote() As String
        Get
            Return _lote
        End Get
        Set(ByVal value As String)
            _lote = value
        End Set
    End Property

End Class
