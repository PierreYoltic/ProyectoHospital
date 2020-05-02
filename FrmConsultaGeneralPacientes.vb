Imports System.ComponentModel

Public Class FrmConsultaGeneralPacientes
    Private Sub FrmConsultaGeneralPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To NumPacientes - 1
            DataGridViewPacientes.Rows.Add(Pacientes(i).Clave,
                                           Pacientes(i).Nombre,
                                           Areas(GetIndex(Pacientes(i).ClaveArea, NumAreas, Areas)).Nombre)
        Next
    End Sub

    Private Sub FrmConsultaGeneralPacientes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class