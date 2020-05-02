Module Funciones
    Function Exist(ByVal Key As Integer, ByVal NumItems As Integer, ByRef arr As Object())
        If NumItems <> 0 Then
            For i = 0 To NumItems - 1
                If arr(i).Clave = Key Then
                    Return True
                    Exit For
                End If
            Next
        End If
        Return False
    End Function

    Function GetIndex(ByVal Key As Integer, ByVal NumItems As Integer, ByRef arr As Object())
        For i = 0 To NumItems - 1
            If arr(i).Clave = Key Then
                Return i
                Exit For
            End If
        Next
        Return -1
    End Function

    Sub RemoveMedico(ByVal Key As Integer, ByVal NumItems As Integer, ByRef arr As Medico())
        For i = GetIndex(Key, NumItems, arr) To NumItems - 1
            arr(i) = arr(i + 1)
        Next
        NumMedicos -= 1
    End Sub

    Sub AddNames(ByRef arr As Object(), ByVal NumItems As Integer, ByRef Cbo As ComboBox)
        For i = 0 To NumItems - 1
            Cbo.Items.Add(arr(i).Nombre)
        Next
    End Sub

    Function GetKeyByName(ByVal Name As String, ByVal NumItems As Integer, ByRef arr As Object()) As Integer
        For i = 0 To NumItems - 1
            If arr(i).Nombre = Name Then
                Return arr(i).Clave
                Exit For
            End If
        Next
        Return -1
    End Function

    Function ThisAreaHavePatient(ByVal AreaIndex)
        For i = 0 To NumPacientes - 1
            If Areas(AreaIndex).Clave = Pacientes(i).ClaveArea Then
                Return True
            End If
        Next
        Return False
    End Function

    Function IsThisDoctorFree(ByVal Index As Integer)
        For i = 0 To NumAreas - 1
            If Medicos(Index).Clave = Areas(i).ClaveMedico Then
                Return False
            End If
        Next
        For i = 0 To NumPacientes - 1
            If Medicos(Index).Clave = Pacientes(i).ClaveMedico Then
                Return False
            End If
        Next
        Return True
    End Function
End Module
