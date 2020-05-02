Public Class Medico
    Private _Clave As Integer
    Private _Nombre, _Cedula, _Especialidad As String

    Public Sub New(clave As Integer, nombre As String, cedula As String, especialidad As String)
        _Clave = clave
        _Nombre = nombre
        _Cedula = cedula
        _Especialidad = especialidad
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

    Public Property Cedula() As String
        Get
            Return _Cedula
        End Get
        Set(value As String)
            _Cedula = value
        End Set
    End Property

    Public Property Especialidad() As String
        Get
            Return _Especialidad
        End Get
        Set(value As String)
            _Especialidad = value
        End Set
    End Property
End Class
