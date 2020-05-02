Imports System.ComponentModel

Public Class FrmReportePacientesSexo
    Private Sub FrmReportePacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxDatos.ScrollBars = ScrollBars.Both
        TextBoxDatos.WordWrap = True
        Dim Cont As Integer
        TextBoxDatos.Text += "HOMBRES: " & vbCrLf
        Cont = 1
        For i = 0 To NumPacientes - 1
            If Pacientes(i).Sexo = "Hombre" Then
                TextBoxDatos.Text += Cont & ".  " & Pacientes(i).Nombre.ToUpper & vbCrLf
                Cont += 1
            End If
        Next
        TextBoxDatos.Text += vbCrLf & vbCrLf
        TextBoxDatos.Text += "MUJERES: " & vbCrLf
        Cont = 1
        For i = 0 To NumPacientes - 1
            If Pacientes(i).Sexo = "Mujer" Then
                TextBoxDatos.Text += Cont & ".  " & Pacientes(i).Nombre.ToUpper & vbCrLf
                Cont += 1
            End If
        Next
        TextBoxDatos.Text += vbCrLf & vbCrLf
    End Sub

    Private Sub FrmReportePacientesSexo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class