Public Class Paciente
    Private _Clave, _ClaveMedico, _ClaveArea As Integer
    Private _Nombre, _Sexo, _FechaNacimiento As String
    Private _Peso, _Estatura As Single

    Public Sub New(clave As Integer, claveMedico As Integer, claveArea As Integer, nombre As String,
                   sexo As String, fechaNacimiento As String, peso As Single, estatura As Single)
        _Clave = clave
        _ClaveMedico = claveMedico
        _ClaveArea = claveArea
        _Nombre = nombre
        _Sexo = sexo
        _FechaNacimiento = fechaNacimiento
        _Peso = peso
        _Estatura = estatura
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
    Public Property ClaveMedico() As Integer
        Get
            Return _ClaveMedico
        End Get
        Set(value As Integer)
            _ClaveMedico = value
        End Set
    End Property

    Public Property ClaveArea() As Integer
        Get
            Return _ClaveArea
        End Get
        Set(value As Integer)
            _ClaveArea = value
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
    Public Property Sexo() As String
        Get
            Return _Sexo
        End Get
        Set(ByVal value As String)
            _Sexo = value
        End Set
    End Property
    Public Property FechaNacimiento() As String
        Get
            Return _FechaNacimiento
        End Get
        Set(ByVal value As String)
            _FechaNacimiento = value
        End Set
    End Property
    Public Property Peso() As Single
        Get
            Return _Peso
        End Get
        Set(value As Single)
            _Peso = value
        End Set
    End Property
    Public Property Estatura() As Single
        Get
            Return _Estatura
        End Get
        Set(value As Single)
            _Estatura = value
        End Set
    End Property

End Class
