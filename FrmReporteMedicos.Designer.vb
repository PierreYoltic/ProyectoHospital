<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteMedicos
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
        Me.TextBoxDatos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxDatos
        '
        Me.TextBoxDatos.Location = New System.Drawing.Point(12, 54)
        Me.TextBoxDatos.Multiline = True
        Me.TextBoxDatos.Name = "TextBoxDatos"
        Me.TextBoxDatos.ReadOnly = True
        Me.TextBoxDatos.Size = New System.Drawing.Size(776, 384)
        Me.TextBoxDatos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(423, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Reporte: Médicos por especialidad"
        '
        'FrmReporteMedicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxDatos)
        Me.Name = "FrmReporteMedicos"
        Me.Text = "Reporte Medicos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxDatos As TextBox
    Friend WithEvents Label1 As Label
End Class
