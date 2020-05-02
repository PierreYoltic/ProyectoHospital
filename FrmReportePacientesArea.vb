Imports System.ComponentModel

Public Class FrmReportePacientesArea
    Private Sub FrmReportePacientesArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxDatos.ScrollBars = ScrollBars.Both
        TextBoxDatos.WordWrap = True
        Dim Cont As Integer
        For i = 0 To NumAreas - 1
            If ThisAreaHavePatient(i) Then
                TextBoxDatos.Text += Areas(i).Nombre.ToUpper & ":" & vbCrLf
            Else
                Continue For
            End If
            Cont = 1
            For j = 0 To NumPacientes - 1
                If Areas(i).Nombre = Areas(GetIndex(Pacientes(j).ClaveArea, NumAreas, Areas)).Nombre Then
                    TextBoxDatos.Text += Cont & ".  " & Pacientes(j).Nombre.ToUpper & vbCrLf
                    Cont += 1
                End If
            Next
            TextBoxDatos.Text += vbCrLf
        Next
    End Sub

    Private Sub FrmReportePacientesArea_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class