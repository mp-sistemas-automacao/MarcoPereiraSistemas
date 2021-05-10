Public Class Enums

    ''' <summary>
    ''' Estados da Producao
    ''' </summary>
    Public Enum StatusOrdem_Producao
        Aguardando = 0
        Produzindo = 1
        EmPausa = 3
        Finalizado = 4
        Cancelado = 5
    End Enum

    Public Enum StatusRegistro
        Desativado = 0
        Ativo = 1
    End Enum

End Class
