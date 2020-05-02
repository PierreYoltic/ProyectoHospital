Imports System.ComponentModel
Public Class FrmConsultaIndividualMedicos
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TxtClave.Text = "" Then
            Exit Sub
        End If
        If Exist(CInt(TxtClave.Text), NumMedicos, Medicos) Then
            Dim index As Integer = GetIndex(CInt(TxtClave.Text), NumMedicos, Medicos)
            TxtNombre.Text = Medicos(index).Nombre
            TxtCedula.Text = Medicos(index).Cedula
            TxtEspecialidad.Text = Medicos(index).Especialidad
        Else
            MessageBox.Show("Clave no encontrada", "No existe este Médico",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtClave.Clear()
            TxtClave.Focus()
        End If
    End Sub
    Private Sub TxtClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtClave.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TxtClave_Validating(sender As Object, e As CancelEventArgs) Handles TxtClave.Validating
        If TxtClave.Text = "" Then
            Exit Sub
        End If
        If CInt(TxtClave.Text) < 1 Or CInt(TxtClave.Text) > 100 Then
            MessageBox.Show("Ingresa una clave dentro del rango [1-100]", "Clave inválida",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtClave.Focus()
            TxtClave.SelectAll()
        End If
    End Sub

    Private Sub FrmConsultaIndividualMedicos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class