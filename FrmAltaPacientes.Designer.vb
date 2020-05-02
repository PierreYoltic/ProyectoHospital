<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaPacientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.GroupBoxClave = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxDatos = New System.Windows.Forms.GroupBox()
        Me.DTPFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtEstatura = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtPeso = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadioButtonMujer = New System.Windows.Forms.RadioButton()
        Me.RadioButtonHombre = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxMedico = New System.Windows.Forms.ComboBox()
        Me.ComboBoxArea = New System.Windows.Forms.ComboBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBoxClave.SuspendLayout()
        Me.GroupBoxDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Enabled = False
        Me.BtnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrabar.Location = New System.Drawing.Point(88, 481)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(250, 52)
        Me.BtnGrabar.TabIndex = 62
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'GroupBoxClave
        '
        Me.GroupBoxClave.Controls.Add(Me.BtnBuscar)
        Me.GroupBoxClave.Controls.Add(Me.TxtClave)
        Me.GroupBoxClave.Controls.Add(Me.Label1)
        Me.GroupBoxClave.Location = New System.Drawing.Point(79, 12)
        Me.GroupBoxClave.Name = "GroupBoxClave"
        Me.GroupBoxClave.Size = New System.Drawing.Size(270, 84)
        Me.GroupBoxClave.TabIndex = 41
        Me.GroupBoxClave.TabStop = False
        Me.GroupBoxClave.Text = "Ingresa una clave:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(97, 26)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(162, 42)
        Me.BtnBuscar.TabIndex = 53
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtClave
        '
        Me.TxtClave.Location = New System.Drawing.Point(9, 46)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.Size = New System.Drawing.Size(59, 22)
        Me.TxtClave.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Clave:"
        '
        'GroupBoxDatos
        '
        Me.GroupBoxDatos.Controls.Add(Me.DTPFechaNacimiento)
        Me.GroupBoxDatos.Controls.Add(Me.Label8)
        Me.GroupBoxDatos.Controls.Add(Me.TxtEstatura)
        Me.GroupBoxDatos.Controls.Add(Me.Label7)
        Me.GroupBoxDatos.Controls.Add(Me.TxtPeso)
        Me.GroupBoxDatos.Controls.Add(Me.Label6)
        Me.GroupBoxDatos.Controls.Add(Me.RadioButtonMujer)
        Me.GroupBoxDatos.Controls.Add(Me.RadioButtonHombre)
        Me.GroupBoxDatos.Controls.Add(Me.Label5)
        Me.GroupBoxDatos.Controls.Add(Me.ComboBoxMedico)
        Me.GroupBoxDatos.Controls.Add(Me.ComboBoxArea)
        Me.GroupBoxDatos.Controls.Add(Me.TxtNombre)
        Me.GroupBoxDatos.Controls.Add(Me.Label4)
        Me.GroupBoxDatos.Controls.Add(Me.Label3)
        Me.GroupBoxDatos.Controls.Add(Me.Label2)
        Me.GroupBoxDatos.Enabled = False
        Me.GroupBoxDatos.Location = New System.Drawing.Point(79, 102)
        Me.GroupBoxDatos.Name = "GroupBoxDatos"
        Me.GroupBoxDatos.Size = New System.Drawing.Size(270, 359)
        Me.GroupBoxDatos.TabIndex = 42
        Me.GroupBoxDatos.TabStop = False
        Me.GroupBoxDatos.Text = "Ingresa los datos:"
        '
        'DTPFechaNacimiento
        '
        Me.DTPFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaNacimiento.Location = New System.Drawing.Point(9, 209)
        Me.DTPFechaNacimiento.Name = "DTPFechaNacimiento"
        Me.DTPFechaNacimiento.Size = New System.Drawing.Size(250, 22)
        Me.DTPFechaNacimiento.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 17)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Fecha de Nacimiento:"
        '
        'TxtEstatura
        '
        Me.TxtEstatura.Location = New System.Drawing.Point(137, 153)
        Me.TxtEstatura.Name = "TxtEstatura"
        Me.TxtEstatura.Size = New System.Drawing.Size(122, 22)
        Me.TxtEstatura.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(134, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Estatura:"
        '
        'TxtPeso
        '
        Me.TxtPeso.Location = New System.Drawing.Point(9, 153)
        Me.TxtPeso.Name = "TxtPeso"
        Me.TxtPeso.Size = New System.Drawing.Size(122, 22)
        Me.TxtPeso.TabIndex = 57
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Peso:"
        '
        'RadioButtonMujer
        '
        Me.RadioButtonMujer.AutoSize = True
        Me.RadioButtonMujer.Location = New System.Drawing.Point(97, 95)
        Me.RadioButtonMujer.Name = "RadioButtonMujer"
        Me.RadioButtonMujer.Size = New System.Drawing.Size(64, 21)
        Me.RadioButtonMujer.TabIndex = 56
        Me.RadioButtonMujer.TabStop = True
        Me.RadioButtonMujer.Text = "Mujer"
        Me.RadioButtonMujer.UseVisualStyleBackColor = True
        '
        'RadioButtonHombre
        '
        Me.RadioButtonHombre.AutoSize = True
        Me.RadioButtonHombre.Checked = True
        Me.RadioButtonHombre.Location = New System.Drawing.Point(9, 95)
        Me.RadioButtonHombre.Name = "RadioButtonHombre"
        Me.RadioButtonHombre.Size = New System.Drawing.Size(79, 21)
        Me.RadioButtonHombre.TabIndex = 55
        Me.RadioButtonHombre.TabStop = True
        Me.RadioButtonHombre.Text = "Hombre"
        Me.RadioButtonHombre.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Sexo:"
        '
        'ComboBoxMedico
        '
        Me.ComboBoxMedico.FormattingEnabled = True
        Me.ComboBoxMedico.Location = New System.Drawing.Point(9, 321)
        Me.ComboBoxMedico.Name = "ComboBoxMedico"
        Me.ComboBoxMedico.Size = New System.Drawing.Size(250, 24)
        Me.ComboBoxMedico.TabIndex = 61
        '
        'ComboBoxArea
        '
        Me.ComboBoxArea.FormattingEnabled = True
        Me.ComboBoxArea.Location = New System.Drawing.Point(9, 264)
        Me.ComboBoxArea.Name = "ComboBoxArea"
        Me.ComboBoxArea.Size = New System.Drawing.Size(250, 24)
        Me.ComboBoxArea.TabIndex = 60
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(9, 38)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(250, 22)
        Me.TxtNombre.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 17)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Médico responsable:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 17)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Área del hospital"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Nombre:"
        '
        'FrmAltaPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 545)
        Me.Controls.Add(Me.GroupBoxDatos)
        Me.Controls.Add(Me.GroupBoxClave)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Name = "FrmAltaPacientes"
        Me.Text = "Alta Pacientes"
        Me.GroupBoxClave.ResumeLayout(False)
        Me.GroupBoxClave.PerformLayout()
        Me.GroupBoxDatos.ResumeLayout(False)
        Me.GroupBoxDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnGrabar As Button
    Friend WithEvents GroupBoxClave As GroupBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBoxDatos As GroupBox
    Friend WithEvents DTPFechaNacimiento As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtEstatura As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtPeso As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RadioButtonMujer As RadioButton
    Friend WithEvents RadioButtonHombre As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxMedico As ComboBox
    Friend WithEvents ComboBoxArea As ComboBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
