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
    Public Property Titulo As String
        Get
            Return Titulo
        End Get
        Set(value As String)
            titulo = value
        End Set
    End Property

    Public Property Plataforma As String
        Get
            Return Plataforma
        End Get
        Set(value As String)
            plataforma = value
        End Set
    End Property

    Public Property Estudio As String
        Get
            Return Estudio
        End Get
        Set(value As String)
            estudio = value
        End Set
    End Property

    Public Property Anio As Integer
        Get
            Return Anio
        End Get
        Set(value As Integer)
            anio = value
        End Set
    End Property

    Public Property TiempoSpeedrun As Double
        Get
            Return TiempoSpeedrun
        End Get
        Set(value As Double)
            tiempoSpeedrun = value
        End Set
    End Property

    Public Property Recordista As String
        Get
            Return Recordista
        End Get
        Set(value As String)
            recordista = value
        End Set
    End Property

End Class
