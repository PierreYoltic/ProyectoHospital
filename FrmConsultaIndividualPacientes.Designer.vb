<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaIndividualPacientes
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSexo = New System.Windows.Forms.TextBox()
        Me.TxtFechaNacimiento = New System.Windows.Forms.TextBox()
        Me.TxtArea = New System.Windows.Forms.TextBox()
        Me.TxtMedico = New System.Windows.Forms.TextBox()
        Me.GroupBoxDatos = New System.Windows.Forms.GroupBox()
        Me.TxtEstatura = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtPeso = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBoxClave = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBoxDatos.SuspendLayout()
        Me.GroupBoxClave.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 17)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Fecha de Nacimiento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Sexo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 17)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Médico responsable:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 17)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Área del hospital"
        '
        'TxtSexo
        '
        Me.TxtSexo.Location = New System.Drawing.Point(9, 90)
        Me.TxtSexo.Name = "TxtSexo"
        Me.TxtSexo.ReadOnly = True
        Me.TxtSexo.Size = New System.Drawing.Size(250, 22)
        Me.TxtSexo.TabIndex = 60
        '
        'TxtFechaNacimiento
        '
        Me.TxtFechaNacimiento.Location = New System.Drawing.Point(9, 195)
        Me.TxtFechaNacimiento.Name = "TxtFechaNacimiento"
        Me.TxtFechaNacimiento.ReadOnly = True
        Me.TxtFechaNacimiento.Size = New System.Drawing.Size(250, 22)
        Me.TxtFechaNacimiento.TabIndex = 61
        '
        'TxtArea
        '
        Me.TxtArea.Location = New System.Drawing.Point(9, 250)
        Me.TxtArea.Name = "TxtArea"
        Me.TxtArea.ReadOnly = True
        Me.TxtArea.Size = New System.Drawing.Size(250, 22)
        Me.TxtArea.TabIndex = 62
        '
        'TxtMedico
        '
        Me.TxtMedico.Location = New System.Drawing.Point(9, 307)
        Me.TxtMedico.Name = "TxtMedico"
        Me.TxtMedico.ReadOnly = True
        Me.TxtMedico.Size = New System.Drawing.Size(250, 22)
        Me.TxtMedico.TabIndex = 63
        '
        'GroupBoxDatos
        '
        Me.GroupBoxDatos.Controls.Add(Me.TxtEstatura)
        Me.GroupBoxDatos.Controls.Add(Me.Label7)
        Me.GroupBoxDatos.Controls.Add(Me.TxtMedico)
        Me.GroupBoxDatos.Controls.Add(Me.TxtArea)
        Me.GroupBoxDatos.Controls.Add(Me.TxtPeso)
        Me.GroupBoxDatos.Controls.Add(Me.TxtFechaNacimiento)
        Me.GroupBoxDatos.Controls.Add(Me.TxtSexo)
        Me.GroupBoxDatos.Controls.Add(Me.Label8)
        Me.GroupBoxDatos.Controls.Add(Me.Label6)
        Me.GroupBoxDatos.Controls.Add(Me.Label4)
        Me.GroupBoxDatos.Controls.Add(Me.Label5)
        Me.GroupBoxDatos.Controls.Add(Me.Label3)
        Me.GroupBoxDatos.Controls.Add(Me.TxtNombre)
        Me.GroupBoxDatos.Controls.Add(Me.Label11)
        Me.GroupBoxDatos.Enabled = False
        Me.GroupBoxDatos.Location = New System.Drawing.Point(77, 102)
        Me.GroupBoxDatos.Name = "GroupBoxDatos"
        Me.GroupBoxDatos.Size = New System.Drawing.Size(270, 342)
        Me.GroupBoxDatos.TabIndex = 65
        Me.GroupBoxDatos.TabStop = False
        Me.GroupBoxDatos.Text = "Ingresa los datos:"
        '
        'TxtEstatura
        '
        Me.TxtEstatura.Location = New System.Drawing.Point(137, 144)
        Me.TxtEstatura.Name = "TxtEstatura"
        Me.TxtEstatura.ReadOnly = True
        Me.TxtEstatura.Size = New System.Drawing.Size(122, 22)
        Me.TxtEstatura.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(134, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Estatura:"
        '
        'TxtPeso
        '
        Me.TxtPeso.Location = New System.Drawing.Point(9, 144)
        Me.TxtPeso.Name = "TxtPeso"
        Me.TxtPeso.ReadOnly = True
        Me.TxtPeso.Size = New System.Drawing.Size(122, 22)
        Me.TxtPeso.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Peso:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(9, 38)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(250, 22)
        Me.TxtNombre.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 17)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Nombre:"
        '
        'GroupBoxClave
        '
        Me.GroupBoxClave.Controls.Add(Me.BtnBuscar)
        Me.GroupBoxClave.Controls.Add(Me.TxtClave)
        Me.GroupBoxClave.Controls.Add(Me.Label12)
        Me.GroupBoxClave.Location = New System.Drawing.Point(77, 12)
        Me.GroupBoxClave.Name = "GroupBoxClave"
        Me.GroupBoxClave.Size = New System.Drawing.Size(270, 84)
        Me.GroupBoxClave.TabIndex = 64
        Me.GroupBoxClave.TabStop = False
        Me.GroupBoxClave.Text = "Ingresa una clave:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(97, 26)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(162, 42)
        Me.BtnBuscar.TabIndex = 18
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtClave
        '
        Me.TxtClave.Location = New System.Drawing.Point(9, 46)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.Size = New System.Drawing.Size(59, 22)
        Me.TxtClave.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 17)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Clave:"
        '
        'FrmConsultaIndividualPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 462)
        Me.Controls.Add(Me.GroupBoxDatos)
        Me.Controls.Add(Me.GroupBoxClave)
        Me.Name = "FrmConsultaIndividualPacientes"
        Me.Text = "Consulta Individual Pacientes"
        Me.GroupBoxDatos.ResumeLayout(False)
        Me.GroupBoxDatos.PerformLayout()
        Me.GroupBoxClave.ResumeLayout(False)
        Me.GroupBoxClave.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtSexo As TextBox
    Friend WithEvents TxtFechaNacimiento As TextBox
    Friend WithEvents TxtArea As TextBox
    Friend WithEvents TxtMedico As TextBox
    Friend WithEvents GroupBoxDatos As GroupBox
    Friend WithEvents TxtEstatura As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtPeso As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBoxClave As GroupBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents Label12 As Label
End Class
