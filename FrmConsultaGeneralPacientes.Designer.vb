<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaGeneralPacientes
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
        Me.DataGridViewPacientes = New System.Windows.Forms.DataGridView()
        Me.Clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AreaHospital = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewPacientes
        '
        Me.DataGridViewPacientes.AllowUserToAddRows = False
        Me.DataGridViewPacientes.AllowUserToDeleteRows = False
        Me.DataGridViewPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Clave, Me.Nombre, Me.AreaHospital})
        Me.DataGridViewPacientes.Location = New System.Drawing.Point(24, 91)
        Me.DataGridViewPacientes.Name = "DataGridViewPacientes"
        Me.DataGridViewPacientes.ReadOnly = True
        Me.DataGridViewPacientes.RowHeadersWidth = 51
        Me.DataGridViewPacientes.RowTemplate.Height = 24
        Me.DataGridViewPacientes.Size = New System.Drawing.Size(558, 327)
        Me.DataGridViewPacientes.TabIndex = 3
        '
        'Clave
        '
        Me.Clave.HeaderText = "Clave"
        Me.Clave.MinimumWidth = 6
        Me.Clave.Name = "Clave"
        Me.Clave.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'AreaHospital
        '
        Me.AreaHospital.HeaderText = "Área del hospital"
        Me.AreaHospital.MinimumWidth = 6
        Me.AreaHospital.Name = "AreaHospital"
        Me.AreaHospital.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(511, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CONSULTA GENERAL: PACIENTES"
        '
        'FrmConsultaGeneralPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 450)
        Me.Controls.Add(Me.DataGridViewPacientes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmConsultaGeneralPacientes"
        Me.Text = "Consulta General Pacientes"
        CType(Me.DataGridViewPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewPacientes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Clave As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents AreaHospital As DataGridViewTextBoxColumn
End Class
