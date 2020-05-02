Imports System.ComponentModel
Public Class FrmModificacionesMedicos
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TxtClave.Text = "" Then
            Exit Sub
        End If
        If Exist(CInt(TxtClave.Text), NumMedicos, Medicos) = True Then
            Dim index As Integer = GetIndex(CInt(TxtClave.Text), NumMedicos, Medicos)
            GroupBoxDatos.Enabled = True
            GroupBoxClave.Enabled = False
            BtnGrabarModificacion.Enabled = True
            TxtNombre.Text = Medicos(index).Nombre
            TxtCedula.Text = Medicos(index).Cedula
            TxtEspecialidad.Text = Medicos(index).Especialidad
        Else
            MessageBox.Show("Clave no encontrada", "No existe este Médico",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtClave.Text = ""
            TxtClave.Focus()
        End If
    End Sub
    Private Sub BtnGrabarModificacion_Click(sender As Object, e As EventArgs) Handles BtnGrabarModificacion.Click
        If TxtNombre.Text = "" Or TxtCedula.Text = "" Or TxtEspecialidad.Text = "" Then
            MessageBox.Show("Ingresa todos los datos", "Formulario incompleto",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim index As Integer = GetIndex(CInt(TxtClave.Text), NumMedicos, Medicos)
        Medicos(index) = New Medico(CInt(TxtClave.Text),
                                    TxtNombre.Text.ToUpper,
                                    TxtCedula.Text.ToUpper,
                                    TxtEspecialidad.Text.ToUpper)
        MessageBox.Show("Los datos se modificaron exitosamente", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Dispose()
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

    Private Sub FrmModificacionesMedicos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class