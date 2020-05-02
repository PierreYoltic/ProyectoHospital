Imports System.ComponentModel

Public Class FrmReporteMedicos
    Private Sub FrmReporteMedicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxDatos.ScrollBars = ScrollBars.Both
        TextBoxDatos.WordWrap = True
        Dim UsedIndex As New List(Of Integer)
        Dim cont As Integer
        For i = 0 To NumMedicos - 1
            If Not UsedIndex.Contains(i) Then
                TextBoxDatos.Text += Medicos(i).Especialidad.ToUpper & ":" & vbCrLf
            Else
                Continue For
            End If
            cont = 1
            For j = i To NumMedicos - 1
                If Medicos(j).Especialidad = Medicos(i).Especialidad And Not UsedIndex.Contains(j) Then
                    TextBoxDatos.Text += cont & ".  " & Medicos(j).Nombre.ToUpper & vbCrLf
                    cont += 1
                    UsedIndex.Add(j)
                End If
            Next
            TextBoxDatos.Text += vbCrLf
        Next
    End Sub

    Private Sub FrmReporteMedicos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class