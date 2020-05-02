Imports System.ComponentModel

Public Class FrmModificacionAreas
    Private Sub FrmModificacionAreas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddNames(Medicos, NumMedicos, ComboBoxMedico)
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TxtClave.Text = "" Then
            Exit Sub
        End If
        If Exist(CInt(TxtClave.Text), NumAreas, Areas) = True Then
            Dim index As Integer = GetIndex(CInt(TxtClave.Text), NumAreas, Areas)
            GroupBoxDatos.Enabled = True
            GroupBoxClave.Enabled = False
            BtnGrabarModificacion.Enabled = True
            TxtNombre.Text = Areas(index).Nombre
            ComboBoxMedico.Text = Medicos(GetIndex(CInt(Areas(index).ClaveMedico), NumMedicos, Medicos)).Nombre
            ComboBoxPiso.Text = Areas(index).Piso
        Else
            MessageBox.Show("Clave no encontrada", "No existe este Médico",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtClave.Focus()
        End If
    End Sub

    Private Sub BtnGrabarModificacion_Click(sender As Object, e As EventArgs) Handles BtnGrabarModificacion.Click
        If TxtNombre.Text = "" Or ComboBoxMedico.Text = "" Or ComboBoxPiso.Text = "" Then
            MessageBox.Show("Ingresa todos los datos", "Formulario incompleto",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim index As Integer = GetIndex(CInt(TxtClave.Text), NumAreas, Areas)
        Areas(index) = New Area(CInt(TxtClave.Text),
                                GetKeyByName(ComboBoxMedico.Text, NumMedicos, Medicos),
                                CInt(ComboBoxPiso.Text), TxtNombre.Text)

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
        If CInt(TxtClave.Text) < 101 Or CInt(TxtClave.Text) > 200 Then
            MessageBox.Show("Ingresa una clave dentro del rango [101-200]", "Clave inválida",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtClave.Focus()
            TxtClave.SelectAll()
        End If
    End Sub

    Private Sub FrmModificacionAreas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class