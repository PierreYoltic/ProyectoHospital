<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBajaMedicos
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
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.GroupBoxDatos = New System.Windows.Forms.GroupBox()
        Me.TxtEspecialidad = New System.Windows.Forms.TextBox()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
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
        'BtnEliminar
        '
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(77, 303)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(250, 52)
        Me.BtnEliminar.TabIndex = 29
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'GroupBoxDatos
        '
        Me.GroupBoxDatos.Controls.Add(Me.TxtEspecialidad)
        Me.GroupBoxDatos.Controls.Add(Me.TxtCedula)
        Me.GroupBoxDatos.Controls.Add(Me.TxtNombre)
        Me.GroupBoxDatos.Controls.Add(Me.Label4)
        Me.GroupBoxDatos.Controls.Add(Me.Label3)
        Me.GroupBoxDatos.Controls.Add(Me.Label2)
        Me.GroupBoxDatos.Enabled = False
        Me.GroupBoxDatos.Location = New System.Drawing.Point(68, 102)
        Me.GroupBoxDatos.Name = "GroupBoxDatos"
        Me.GroupBoxDatos.Size = New System.Drawing.Size(270, 186)
        Me.GroupBoxDatos.TabIndex = 31
        Me.GroupBoxDatos.TabStop = False
        Me.GroupBoxDatos.Text = "Datos del médico:"
        '
        'TxtEspecialidad
        '
        Me.TxtEspecialidad.Location = New System.Drawing.Point(9, 148)
        Me.TxtEspecialidad.Name = "TxtEspecialidad"
        Me.TxtEspecialidad.ReadOnly = True
        Me.TxtEspecialidad.Size = New System.Drawing.Size(250, 22)
        Me.TxtEspecialidad.TabIndex = 13
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(9, 98)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.ReadOnly = True
        Me.TxtCedula.Size = New System.Drawing.Size(250, 22)
        Me.TxtCedula.TabIndex = 12
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(9, 41)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(250, 22)
        Me.TxtNombre.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Especialidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cédula Profesional:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre:"
        '
        'GroupBoxClave
        '
        Me.GroupBoxClave.Controls.Add(Me.BtnBuscar)
        Me.GroupBoxClave.Controls.Add(Me.TxtClave)
        Me.GroupBoxClave.Controls.Add(Me.Label1)
        Me.GroupBoxClave.Location = New System.Drawing.Point(68, 12)
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
        'FrmBajaMedicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 377)
        Me.Controls.Add(Me.GroupBoxDatos)
        Me.Controls.Add(Me.GroupBoxClave)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Name = "FrmBajaMedicos"
        Me.Text = "Baja Medicos"
        Me.GroupBoxDatos.ResumeLayout(False)
        Me.GroupBoxDatos.PerformLayout()
        Me.GroupBoxClave.ResumeLayout(False)
        Me.GroupBoxClave.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnEliminar As Button
    Friend WithEvents GroupBoxDatos As GroupBox
    Friend WithEvents TxtEspecialidad As TextBox
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBoxClave As GroupBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents Label1 As Label
End Class
