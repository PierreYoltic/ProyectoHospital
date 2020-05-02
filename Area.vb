Public Class Area
    Private _Clave, _ClaveMedico, _Piso As Integer
    Private _Nombre As String

    Public Sub New(clave As Integer, claveMedico As Integer, piso As Integer, nombre As String)
        _Clave = clave
        _ClaveMedico = claveMedico
        _Piso = piso
        _Nombre = nombre
    End Sub

    'Getters And Setters
    Public Property Clave() As Integer
        Get
            Return _Clave
        End Get
        Set(value As Integer)
            _Clave = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property ClaveMedico() As Integer
        Get
            Return _ClaveMedico
        End Get
        Set(value As Integer)
            _ClaveMedico = value
        End Set
    End Property

    Public Property Piso() As String
        Get
            Return _Piso
        End Get
        Set(value As String)
            _Piso = value
        End Set
    End Property
End Class
