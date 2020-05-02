<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaIndividualMedicos
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
        Me.GroupBoxClave = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtEspecialidad = New System.Windows.Forms.TextBox()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBoxClave.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxClave
        '
        Me.GroupBoxClave.Controls.Add(Me.BtnBuscar)
        Me.GroupBoxClave.Controls.Add(Me.TxtClave)
        Me.GroupBoxClave.Controls.Add(Me.Label1)
        Me.GroupBoxClave.Location = New System.Drawing.Point(80, 9)
        Me.GroupBoxClave.Name = "GroupBoxClave"
        Me.GroupBoxClave.Size = New System.Drawing.Size(270, 84)
        Me.GroupBoxClave.TabIndex = 24
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Clave:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtEspecialidad)
        Me.GroupBox1.Controls.Add(Me.TxtCedula)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(80, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 191)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Médico:"
        '
        'TxtEspecialidad
        '
        Me.TxtEspecialidad.Location = New System.Drawing.Point(9, 156)
        Me.TxtEspecialidad.Name = "TxtEspecialidad"
        Me.TxtEspecialidad.ReadOnly = True
        Me.TxtEspecialidad.Size = New System.Drawing.Size(250, 22)
        Me.TxtEspecialidad.TabIndex = 22
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(9, 106)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.ReadOnly = True
        Me.TxtCedula.Size = New System.Drawing.Size(250, 22)
        Me.TxtCedula.TabIndex = 21
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(9, 49)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(250, 22)
        Me.TxtNombre.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Especialidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Cédula Profesional:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nombre:"
        '
        'FrmConsultaIndividualMedicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 316)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxClave)
        Me.Name = "FrmConsultaIndividualMedicos"
        Me.Text = "Consulta Individual Medicos"
        Me.GroupBoxClave.ResumeLayout(False)
        Me.GroupBoxClave.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxClave As GroupBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtEspecialidad As TextBox
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
