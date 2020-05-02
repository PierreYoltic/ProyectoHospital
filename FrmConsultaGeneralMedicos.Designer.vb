<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaGeneralMedicos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewMedicos = New System.Windows.Forms.DataGridView()
        Me.Clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Especialidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(480, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CONSULTA GENERAL: MEDICOS"
        '
        'DataGridViewMedicos
        '
        Me.DataGridViewMedicos.AllowUserToAddRows = False
        Me.DataGridViewMedicos.AllowUserToDeleteRows = False
        Me.DataGridViewMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMedicos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Clave, Me.Nombre, Me.Especialidad})
        Me.DataGridViewMedicos.Location = New System.Drawing.Point(24, 91)
        Me.DataGridViewMedicos.Name = "DataGridViewMedicos"
        Me.DataGridViewMedicos.ReadOnly = True
        Me.DataGridViewMedicos.RowHeadersWidth = 51
        Me.DataGridViewMedicos.RowTemplate.Height = 24
        Me.DataGridViewMedicos.Size = New System.Drawing.Size(558, 347)
        Me.DataGridViewMedicos.TabIndex = 1
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
        'Especialidad
        '
        Me.Especialidad.HeaderText = "Especialidad"
        Me.Especialidad.MinimumWidth = 6
        Me.Especialidad.Name = "Especialidad"
        Me.Especialidad.ReadOnly = True
        '
        'FrmConsultaGeneralMedicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 450)
        Me.Controls.Add(Me.DataGridViewMedicos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmConsultaGeneralMedicos"
        Me.Text = "Consulta General Medicos"
        CType(Me.DataGridViewMedicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewMedicos As DataGridView
    Friend WithEvents Clave As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Especialidad As DataGridViewTextBoxColumn
End Class
