Imports System.ComponentModel

Public Class FrmAltaPacientes
    Private Sub FrmAltaPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTPFechaNacimiento.Format = DateTimePickerFormat.Custom
        DTPFechaNacimiento.CustomFormat = "dd-MM-yyyy"
        AddNames(Medicos, NumMedicos, ComboBoxMedico)
        AddNames(Areas, NumAreas, ComboBoxArea)
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TxtClave.Text = "" Then
            Exit Sub
        End If
        If Exist(CInt(TxtClave.Text), NumPacientes, Pacientes) = False Then
            GroupBoxClave.Enabled = False
            GroupBoxDatos.Enabled = True
            BtnGrabar.Enabled = True
            TxtNombre.Focus()

        Else
            MessageBox.Show("La clave ya existe, ingrese una nueva", "Error: Clave duplicada",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtClave.Clear()
            TxtClave.Focus()
        End If
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        If TxtNombre.Text = "" Or TxtPeso.Text = "" Or TxtEstatura.Text = "" Or ComboBoxArea.Text = "" Or ComboBoxMedico.Text = "" Then
            MessageBox.Show("Ingresa todos los datos", "Formulario incompleto",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim rButtonSexo As RadioButton = GroupBoxDatos.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)

        Pacientes(NumPacientes) = New Paciente(CInt(TxtClave.Text),
                                               GetKeyByName(ComboBoxMedico.Text, NumMedicos, Medicos),
                                               GetKeyByName(ComboBoxArea.Text, NumAreas, Areas),
                                               TxtNombre.Text.ToUpper,
                                               rButtonSexo.Text,
                                               DTPFechaNacimiento.Text,
                                               CSng(TxtPeso.Text),
                                               CSng(TxtEstatura.Text))
        NumPacientes += 1
        MessageBox.Show("El Paciente: '" & TxtNombre.Text & "' se ha registrado exitosamente", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        If NumPacientes = 50 Then
            FrmPrincipal.AltaPacientes.Enabled = False
        ElseIf NumMedicos > 0 And FrmPrincipal.ConsultaGeneralPacientes.Enabled = False Then
            FrmPrincipal.ConsultaGeneralPacientes.Enabled = True
            FrmPrincipal.ConsultaIndividualPacientes.Enabled = True
            FrmPrincipal.ModificacionPacientes.Enabled = True
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
        If CInt(TxtClave.Text) < 201 Or CInt(TxtClave.Text) > 999 Then
            MessageBox.Show("Ingresa una clave dentro del rango [201-999]", "Clave inválida",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtClave.Focus()
            TxtClave.SelectAll()
        End If
    End Sub

    Private Sub FrmAltaPacientes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class