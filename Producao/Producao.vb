
Imports Producao.Enums

Public Class Producao

    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _codigoCliente As String
    Public Property CodigoClinte() As String
        Get
            Return _codigoCliente
        End Get
        Set(ByVal value As String)
            _codigoCliente = value
        End Set
    End Property

    Private _codigoFormula As String
    Public Property CodigoFormula() As String
        Get
            Return _codigoFormula
        End Get
        Set(ByVal value As String)
            _codigoFormula = value
        End Set
    End Property

    Private _dataProgramacao As String
    Public Property DataProgramacao() As String
        Get
            Return _dataProgramacao
        End Get
        Set(ByVal value As String)
            _dataProgramacao = value
        End Set
    End Property

    Private _dataProducao As DateTime
    Public Property DataProducao() As DateTime
        Get
            Return _dataProducao
        End Get
        Set(ByVal value As DateTime)
            _dataProducao = value
        End Set
    End Property

    Private _quantidadeBatchDesejados As Integer
    Public Property QuantidadeBatchsDesejados() As Integer
        Get
            Return _quantidadeBatchDesejados
        End Get
        Set(ByVal value As Integer)
            _quantidadeBatchDesejados = value
        End Set
    End Property

    Private _tamanhoBatch As String
    Public Property TamanhoBatch() As String
        Get
            Return _tamanhoBatch
        End Get
        Set(ByVal value As String)
            _tamanhoBatch = value
        End Set
    End Property

    Private _tempoMistura As Integer
    Public Property TempoMistura() As Integer
        Get
            Return _tempoMistura
        End Get
        Set(ByVal value As Integer)
            _tempoMistura = value
        End Set
    End Property

    Private _tempoMisturaUmida As Integer
    Public Property TempoMisturaUmida() As Integer
        Get
            Return _tempoMisturaUmida
        End Get
        Set(ByVal value As Integer)
            _tempoMisturaUmida = value
        End Set
    End Property

    Private _dataInicio As DateTime
    Public Property DataInicio() As DateTime
        Get
            Return _dataInicio
        End Get
        Set(ByVal value As DateTime)
            _dataInicio = value
        End Set
    End Property

    Private _dataFim As DateTime
    Public Property DataFim() As DateTime
        Get
            Return _dataFim
        End Get
        Set(ByVal value As DateTime)
            _dataFim = value
        End Set
    End Property

    Private _status As StatusOrdem_Producao
    Public Property Status() As StatusOrdem_Producao
        Get
            Return _status
        End Get
        Set(ByVal value As StatusOrdem_Producao)
            _status = value
        End Set
    End Property
    Private _destinoID As Integer
    Public Property DestinoID() As Integer
        Get
            Return _destinoID
        End Get
        Set(ByVal value As Integer)
            _destinoID = value
        End Set
    End Property

    Private _areaID As Integer
    Public Property AreaID() As Integer
        Get
            Return _areaID
        End Get
        Set(ByVal value As Integer)
            _areaID = value
        End Set
    End Property

    Private _linhaID As Integer
    Public Property LinhaID() As Integer
        Get
            Return _linhaID
        End Get
        Set(ByVal value As Integer)
            _linhaID = value
        End Set
    End Property

    Private _usuarioIniciou As Integer
    Public Property UsuarioIniciou() As Integer
        Get
            Return _usuarioIniciou
        End Get
        Set(ByVal value As Integer)
            _usuarioIniciou = value
        End Set
    End Property

    Private _usuarioFinalizou As Integer
    Public Property UsuarioFinalizou() As Integer
        Get
            Return _usuarioFinalizou
        End Get
        Set(ByVal value As Integer)
            _usuarioFinalizou = value
        End Set
    End Property

    Private _preSolicitacao As String
    Public Property PreSolicitacao() As String
        Get
            Return _preSolicitacao
        End Get
        Set(ByVal value As String)
            _preSolicitacao = value
        End Set
    End Property

    Private _loteDigitado As String
    Public Property LoteDigitado() As String
        Get
            Return _loteDigitado
        End Get
        Set(ByVal value As String)
            _loteDigitado = value
        End Set
    End Property

    Private _observacao As String
    Public Property Observacao() As String
        Get
            Return _observacao
        End Get
        Set(ByVal value As String)
            _observacao = value
        End Set
    End Property

End Class

