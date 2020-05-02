<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificacionAreas
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
        Me.BtnGrabarModificacion = New System.Windows.Forms.Button()
        Me.GroupBoxDatos = New System.Windows.Forms.GroupBox()
        Me.ComboBoxPiso = New System.Windows.Forms.ComboBox()
        Me.ComboBoxMedico = New System.Windows.Forms.ComboBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBoxClave = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxDatos.SuspendLayout()
        Me.GroupBoxClave.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnGrabarModificacion
        '
        Me.BtnGrabarModificacion.Enabled = False
        Me.BtnGrabarModificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrabarModificacion.Location = New System.Drawing.Point(89, 311)
        Me.BtnGrabarModificacion.Name = "BtnGrabarModificacion"
        Me.BtnGrabarModificacion.Size = New System.Drawing.Size(250, 52)
        Me.BtnGrabarModificacion.TabIndex = 29
        Me.BtnGrabarModificacion.Text = "Grabar modificación"
        Me.BtnGrabarModificacion.UseVisualStyleBackColor = True
        '
        'GroupBoxDatos
        '
        Me.GroupBoxDatos.Controls.Add(Me.ComboBoxPiso)
        Me.GroupBoxDatos.Controls.Add(Me.ComboBoxMedico)
        Me.GroupBoxDatos.Controls.Add(Me.TxtNombre)
        Me.GroupBoxDatos.Controls.Add(Me.Label4)
        Me.GroupBoxDatos.Controls.Add(Me.Label3)
        Me.GroupBoxDatos.Controls.Add(Me.Label2)
        Me.GroupBoxDatos.Enabled = False
        Me.GroupBoxDatos.Location = New System.Drawing.Point(80, 102)
        Me.GroupBoxDatos.Name = "GroupBoxDatos"
        Me.GroupBoxDatos.Size = New System.Drawing.Size(269, 193)
        Me.GroupBoxDatos.TabIndex = 31
        Me.GroupBoxDatos.TabStop = False
        Me.GroupBoxDatos.Text = "Ingresa los datos:"
        '
        'ComboBoxPiso
        '
        Me.ComboBoxPiso.FormattingEnabled = True
        Me.ComboBoxPiso.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.ComboBoxPiso.Location = New System.Drawing.Point(11, 146)
        Me.ComboBoxPiso.Name = "ComboBoxPiso"
        Me.ComboBoxPiso.Size = New System.Drawing.Size(250, 24)
        Me.ComboBoxPiso.TabIndex = 27
        '
        'ComboBoxMedico
        '
        Me.ComboBoxMedico.FormattingEnabled = True
        Me.ComboBoxMedico.Location = New System.Drawing.Point(11, 96)
        Me.ComboBoxMedico.Name = "ComboBoxMedico"
        Me.ComboBoxMedico.Size = New System.Drawing.Size(250, 24)
        Me.ComboBoxMedico.TabIndex = 26
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(11, 39)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(250, 22)
        Me.TxtNombre.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Piso:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Médico responsable:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Nombre:"
        '
        'GroupBoxClave
        '
        Me.GroupBoxClave.Controls.Add(Me.BtnBuscar)
        Me.GroupBoxClave.Controls.Add(Me.TxtClave)
        Me.GroupBoxClave.Controls.Add(Me.Label1)
        Me.GroupBoxClave.Location = New System.Drawing.Point(80, 12)
        Me.GroupBoxClave.Name = "GroupBoxClave"
        Me.GroupBoxClave.Size = New System.Drawing.Size(270, 84)
        Me.GroupBoxClave.TabIndex = 30
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
        'FrmModificacionAreas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 381)
        Me.Controls.Add(Me.GroupBoxDatos)
        Me.Controls.Add(Me.GroupBoxClave)
        Me.Controls.Add(Me.BtnGrabarModificacion)
        Me.Name = "FrmModificacionAreas"
        Me.Text = "Modificacion Areas"
        Me.GroupBoxDatos.ResumeLayout(False)
        Me.GroupBoxDatos.PerformLayout()
        Me.GroupBoxClave.ResumeLayout(False)
        Me.GroupBoxClave.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnGrabarModificacion As Button
    Friend WithEvents GroupBoxDatos As GroupBox
    Friend WithEvents ComboBoxPiso As ComboBox
    Friend WithEvents ComboBoxMedico As ComboBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBoxClave As GroupBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents Label1 As Label
End Class
