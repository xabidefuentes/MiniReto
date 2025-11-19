Public Class Videojuego

    ' Atributos
    Public titulo As String
    Public plataforma As String
    Public estudio As String
    Public anio As Integer
    Public tiempoSpeedrun As Double
    Public recordista As String

    ' Constructor con parámetros
    Public Sub New(pTitulo As String, pPlataforma As String, pEstudio As String,
                   pAnio As Integer, pTiempoSpeedrun As Double, pRecordista As String)

        Me.titulo = pTitulo
        Me.plataforma = pPlataforma
        Me.estudio = pEstudio
        Me.anio = pAnio
        Me.tiempoSpeedrun = pTiempoSpeedrun
        Me.recordista = pRecordista
    End Sub

    ' Propiedades
    Public Property Titulos As String
        Get
            Return titulo
        End Get
        Set(value As String)
            titulo = value
        End Set
    End Property

    Public Property Plataformas As String
        Get
            Return plataforma
        End Get
        Set(value As String)
            plataforma = value
        End Set
    End Property

    Public Property Estudios As String
        Get
            Return estudio
        End Get
        Set(value As String)
            estudio = value
        End Set
    End Property

    Public Property Anios As Integer
        Get
            Return anio
        End Get
        Set(value As Integer)
            anio = value
        End Set
    End Property

    Public Property TiempoSpeedruns As Double
        Get
            Return tiempoSpeedrun
        End Get
        Set(value As Double)
            tiempoSpeedrun = value
        End Set
    End Property

    Public Property Recordistas As String
        Get
            Return recordista
        End Get
        Set(value As String)
            recordista = value
        End Set
    End Property

End Class
