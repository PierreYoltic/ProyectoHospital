Imports System.ComponentModel
Public Class FrmAltaMedicos
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TxtClave.Text = "" Then
            Exit Sub
        End If
        If Exist(CInt(TxtClave.Text), NumMedicos, Medicos) = False Then
            GroupBoxClave.Enabled = False
            GroupBoxDatos.Enabled = True
            BtnGrabar.Enabled = True
            TxtNombre.Focus()
        Else
            MessageBox.Show("La clave ya existe, ingrese una nueva", "Error: Clave duplicada",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtClave.Focus()
        End If
    End Sub
    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        If TxtNombre.Text = "" Or TxtCedula.Text = "" Or TxtEspecialidad.Text = "" Then
            MessageBox.Show("Ingresa todos los datos", "Formulario incompleto",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Medicos(NumMedicos) = New Medico(CInt(TxtClave.Text),
                                         TxtNombre.Text.ToUpper,
                                         TxtCedula.Text.ToUpper,
                                         TxtEspecialidad.Text.ToUpper)
        NumMedicos += 1
        MessageBox.Show("El Medico: '" & TxtNombre.Text & "' se ha registrado exitosamente", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        If NumMedicos = 50 Then
            FrmPrincipal.AltaMedicos.Enabled = False
        ElseIf NumMedicos > 0 And FrmPrincipal.BajaMedicos.Enabled = False Then
            FrmPrincipal.ConsultaGeneralMedicos.Enabled = True
            FrmPrincipal.ModificacionMedicos.Enabled = True
            FrmPrincipal.ConsultaIndividualMedicos.Enabled = True
            FrmPrincipal.BajaMedicos.Enabled = True
        End If
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

    Private Sub FrmAltaMedicos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class