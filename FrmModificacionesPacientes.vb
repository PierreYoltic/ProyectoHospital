Imports System.ComponentModel

Public Class FrmModificacionesPacientes
    Private Sub FrmModificacionesPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTPFechaNacimiento.Format = DateTimePickerFormat.Custom
        DTPFechaNacimiento.CustomFormat = "dd-MM-yyyy"
        AddNames(Medicos, NumMedicos, ComboBoxMedico)
        AddNames(Areas, NumAreas, ComboBoxArea)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TxtClave.Text = "" Then
            Exit Sub
        End If
        If Exist(CInt(TxtClave.Text), NumPacientes, Pacientes) Then
            Dim index As Integer = GetIndex(CInt(TxtClave.Text), NumPacientes, Pacientes)
            GroupBoxDatos.Enabled = True
            GroupBoxClave.Enabled = False
            BtnGrabarModificacion.Enabled = True
            TxtNombre.Text = Pacientes(index).Nombre
            If Pacientes(index).Sexo = RadioButtonHombre.Text Then
                RadioButtonHombre.Checked = True
            Else
                RadioButtonMujer.Checked = True
            End If
            TxtPeso.Text = Pacientes(index).Peso
            TxtEstatura.Text = Pacientes(index).Estatura
            DTPFechaNacimiento.Text = Pacientes(index).FechaNacimiento
            ComboBoxArea.Text = Areas(GetIndex(Pacientes(index).ClaveArea, NumAreas, Areas)).Nombre
            ComboBoxMedico.Text = Medicos(GetIndex(Pacientes(index).ClaveMedico, NumMedicos, Medicos)).Nombre
        Else
            MessageBox.Show("Clave no encontrada", "No existe este Paciente",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtClave.Clear()
            TxtClave.Focus()
        End If
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabarModificacion.Click
        If TxtNombre.Text = "" Or TxtPeso.Text = "" Or TxtEstatura.Text = "" Or ComboBoxArea.Text = "" Or ComboBoxMedico.Text = "" Then
            MessageBox.Show("Ingresa todos los datos", "Formulario incompleto",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim Index As Integer = GetIndex(CInt(TxtClave.Text), NumPacientes, Pacientes)

        Dim rButtonSexo As RadioButton = GroupBoxDatos.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)

        Pacientes(Index) = New Paciente(CInt(TxtClave.Text),
                                        GetKeyByName(ComboBoxMedico.Text, NumMedicos, Medicos),
                                        GetKeyByName(ComboBoxArea.Text, NumAreas, Areas),
                                        TxtNombre.Text.ToUpper,
                                        rButtonSexo.Text,
                                        DTPFechaNacimiento.Text,
                                        CSng(TxtPeso.Text),
                                        CSng(TxtEstatura.Text))

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
        If CInt(TxtClave.Text) < 201 Or CInt(TxtClave.Text) > 999 Then
            MessageBox.Show("Ingresa una clave dentro del rango [201-999]", "Clave inválida",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtClave.Focus()
            TxtClave.SelectAll()
        End If
    End Sub

    Private Sub FrmModificacionesPacientes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class