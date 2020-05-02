Imports System.ComponentModel

Public Class FrmConsultaGeneralMedicos
    Private Sub FrmConsultaGeneralMedicos_Load(sender As Object, e As EventArgs) Handles Me.Load
        For i = 0 To NumMedicos - 1
            DataGridViewMedicos.Rows.Add(Medicos(i).Clave, Medicos(i).Nombre, Medicos(i).Especialidad)
        Next
    End Sub

    Private Sub FrmConsultaGeneralMedicos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class