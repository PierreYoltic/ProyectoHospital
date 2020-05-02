Imports System.ComponentModel
Public Class FrmBajaMedicos
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TxtClave.Text = "" Then
            Exit Sub
        End If
        If Exist(CInt(TxtClave.Text), NumMedicos, Medicos) = True Then
            Dim index As Integer = GetIndex(CInt(TxtClave.Text), NumMedicos, Medicos)
            If IsThisDoctorFree(index) = False Then
                MessageBox.Show("No se puede dar de baja este Médico, en este momento es responsable de alguna área o paciente",
                                "Error: Regla de Negocio",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtClave.Focus()
                Exit Sub
            End If
            GroupBoxDatos.Enabled = True
            GroupBoxClave.Enabled = False
            BtnEliminar.Enabled = True
            TxtNombre.Text = Medicos(index).Nombre
            TxtCedula.Text = Medicos(index).Cedula
            TxtEspecialidad.Text = Medicos(index).Especialidad
        Else
            MessageBox.Show("Clave no encontrada", "No existe este Médico",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtClave.Text = ""
            TxtClave.Focus()
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim answer As Integer
        answer = MessageBox.Show("Deseas dar de baja al Médico?", "Confirmación de la baja",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If answer = vbYes Then
            RemoveMedico(CInt(TxtClave.Text), NumMedicos, Medicos)
            If NumMedicos = 0 Then
                FrmPrincipal.ConsultaGeneralMedicos.Enabled = False
                FrmPrincipal.ConsultaIndividualMedicos.Enabled = False
                FrmPrincipal.BajaMedicos.Enabled = False
                FrmPrincipal.ModificacionMedicos.Enabled = False
            End If
            If NumMedicos < 55 Then
                FrmPrincipal.AltaMedicos.Enabled = True
            End If
            Me.Dispose()
        Else
            Me.Dispose()
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

    Private Sub FrmBajaMedicos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class