Imports System.ComponentModel

Public Class FrmAltaAreas
    Private Sub FrmAltaAreas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddNames(Medicos, NumMedicos, ComboBoxMedico)
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TxtClave.Text = "" Then
            Exit Sub
        End If
        If Exist(CInt(TxtClave.Text), NumAreas, Areas) = False Then
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
        If TxtNombre.Text = "" Or ComboBoxMedico.Text = "" Or ComboBoxPiso.Text = "" Then
            MessageBox.Show("Ingresa todos los datos", "Formulario incompleto",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Areas(NumAreas) = New Area(CInt(TxtClave.Text),
                                   GetKeyByName(ComboBoxMedico.Text, NumMedicos, Medicos),
                                   CInt(ComboBoxPiso.Text),
                                   TxtNombre.Text.ToUpper)
        NumAreas += 1
        MessageBox.Show("El Area: '" & TxtNombre.Text & "' se ha registrado exitosamente", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        If NumAreas = 50 Then
            FrmPrincipal.AltaAreas.Enabled = False
        ElseIf NumAreas > 0 And FrmPrincipal.ConsultaGeneralAreas.Enabled = False Then
            FrmPrincipal.ConsultaGeneralAreas.Enabled = True
            FrmPrincipal.ModificacionAreas.Enabled = True
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
        If CInt(TxtClave.Text) < 101 Or CInt(TxtClave.Text) > 200 Then
            MessageBox.Show("Ingresa una clave dentro del rango [101-200]", "Clave inválida",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtClave.Focus()
            TxtClave.SelectAll()
        End If
    End Sub

    Private Sub FrmAltaAreas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class