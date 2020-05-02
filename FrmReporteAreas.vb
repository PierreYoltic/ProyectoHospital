Imports System.ComponentModel

Public Class FrmReporteAreas
    Private Sub FrmReporteAreas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxDatos.ScrollBars = ScrollBars.Both
        TextBoxDatos.WordWrap = True
        Dim UsedIndex As New List(Of Integer)
        Dim cont As Integer
        For i = 0 To NumAreas - 1
            If UsedIndex.Contains(i) = False Then
                TextBoxDatos.Text += "PISO " & Areas(i).Piso & ":" & vbCrLf
            Else
                Continue For
            End If
            cont = 1
            For j = i To NumAreas - 1
                If Areas(j).Piso = Areas(i).Piso And Not UsedIndex.Contains(j) Then
                    TextBoxDatos.Text += cont & ".  " & Areas(j).Nombre.ToUpper & vbCrLf
                    cont += 1
                    UsedIndex.Add(j)
                End If
            Next
            TextBoxDatos.Text += vbCrLf
        Next
    End Sub

    Private Sub FrmReporteAreas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class