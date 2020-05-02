Imports System.ComponentModel
Public Class FrmConsultaIndividualPacientes
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TxtClave.Text = "" Then
            Exit Sub
        End If
        If Exist(CInt(TxtClave.Text), NumPacientes, Pacientes) Then
            Dim index As Integer = GetIndex(CInt(TxtClave.Text), NumPacientes, Pacientes)
            GroupBoxDatos.Enabled = True
            TxtNombre.Text = Pacientes(index).Nombre
            TxtSexo.Text = Pacientes(index).Sexo
            TxtPeso.Text = Pacientes(index).Peso
            TxtEstatura.Text = Pacientes(index).Estatura
            TxtFechaNacimiento.Text = Pacientes(index).FechaNacimiento
            TxtArea.Text = Areas(GetIndex(Pacientes(index).ClaveArea, NumAreas, Areas)).Nombre
            TxtMedico.Text = Medicos(GetIndex(Pacientes(index).ClaveMedico, NumMedicos, Medicos)).Nombre
        Else
            MessageBox.Show("Clave no encontrada", "No existe este Paciente",
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
        If CInt(TxtClave.Text) < 201 Or CInt(TxtClave.Text) > 999 Then
            MessageBox.Show("Ingresa una clave dentro del rango [201-999]", "Clave inválida",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtClave.Focus()
            TxtClave.SelectAll()
        End If
    End Sub
    Private Sub FrmConsultaIndividualPacientes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class