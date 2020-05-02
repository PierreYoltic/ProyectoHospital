Imports System.ComponentModel

Public Class FrmConsultaGeneralAreas
    Private Sub FrmConsultaGeneralAreas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To NumAreas - 1
            DataGridViewAreas.Rows.Add(Areas(i).Clave, Areas(i).Nombre, Areas(i).Piso)
        Next
    End Sub

    Private Sub FrmConsultaGeneralAreas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class