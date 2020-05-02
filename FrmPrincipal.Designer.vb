<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatálogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MédicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaMedicos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaIndividualMedicos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaGeneralMedicos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificacionMedicos = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaMedicos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÁreasDelHospitalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaAreas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaGeneralAreas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificacionAreas = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaPacientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaIndividualPacientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaGeneralPacientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificacionPacientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MédicosPorEspecialidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÁreasDelHospitalPorPisoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacientesPorSexoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacietesPorÁreaHospitalariaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.CatálogosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'CatálogosToolStripMenuItem
        '
        Me.CatálogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MédicosToolStripMenuItem, Me.ÁreasDelHospitalToolStripMenuItem, Me.PacientesToolStripMenuItem})
        Me.CatálogosToolStripMenuItem.Name = "CatálogosToolStripMenuItem"
        Me.CatálogosToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.CatálogosToolStripMenuItem.Text = "Catálogos"
        '
        'MédicosToolStripMenuItem
        '
        Me.MédicosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaMedicos, Me.ConsultaIndividualMedicos, Me.ConsultaGeneralMedicos, Me.ModificacionMedicos, Me.BajaMedicos})
        Me.MédicosToolStripMenuItem.Name = "MédicosToolStripMenuItem"
        Me.MédicosToolStripMenuItem.Size = New System.Drawing.Size(211, 26)
        Me.MédicosToolStripMenuItem.Text = "Médicos"
        '
        'AltaMedicos
        '
        Me.AltaMedicos.Name = "AltaMedicos"
        Me.AltaMedicos.Size = New System.Drawing.Size(218, 26)
        Me.AltaMedicos.Text = "Alta"
        '
        'ConsultaIndividualMedicos
        '
        Me.ConsultaIndividualMedicos.Enabled = False
        Me.ConsultaIndividualMedicos.Name = "ConsultaIndividualMedicos"
        Me.ConsultaIndividualMedicos.Size = New System.Drawing.Size(218, 26)
        Me.ConsultaIndividualMedicos.Text = "Consulta individual"
        '
        'ConsultaGeneralMedicos
        '
        Me.ConsultaGeneralMedicos.Enabled = False
        Me.ConsultaGeneralMedicos.Name = "ConsultaGeneralMedicos"
        Me.ConsultaGeneralMedicos.Size = New System.Drawing.Size(218, 26)
        Me.ConsultaGeneralMedicos.Text = "Consulta General"
        '
        'ModificacionMedicos
        '
        Me.ModificacionMedicos.Enabled = False
        Me.ModificacionMedicos.Name = "ModificacionMedicos"
        Me.ModificacionMedicos.Size = New System.Drawing.Size(218, 26)
        Me.ModificacionMedicos.Text = "Modificación"
        '
        'BajaMedicos
        '
        Me.BajaMedicos.Enabled = False
        Me.BajaMedicos.Name = "BajaMedicos"
        Me.BajaMedicos.Size = New System.Drawing.Size(218, 26)
        Me.BajaMedicos.Text = "Baja"
        '
        'ÁreasDelHospitalToolStripMenuItem
        '
        Me.ÁreasDelHospitalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaAreas, Me.ConsultaGeneralAreas, Me.ModificacionAreas})
        Me.ÁreasDelHospitalToolStripMenuItem.Name = "ÁreasDelHospitalToolStripMenuItem"
        Me.ÁreasDelHospitalToolStripMenuItem.Size = New System.Drawing.Size(211, 26)
        Me.ÁreasDelHospitalToolStripMenuItem.Text = "Áreas del hospital"
        '
        'AltaAreas
        '
        Me.AltaAreas.Name = "AltaAreas"
        Me.AltaAreas.Size = New System.Drawing.Size(203, 26)
        Me.AltaAreas.Text = "Alta"
        '
        'ConsultaGeneralAreas
        '
        Me.ConsultaGeneralAreas.Enabled = False
        Me.ConsultaGeneralAreas.Name = "ConsultaGeneralAreas"
        Me.ConsultaGeneralAreas.Size = New System.Drawing.Size(203, 26)
        Me.ConsultaGeneralAreas.Text = "Consulta general"
        '
        'ModificacionAreas
        '
        Me.ModificacionAreas.Enabled = False
        Me.ModificacionAreas.Name = "ModificacionAreas"
        Me.ModificacionAreas.Size = New System.Drawing.Size(203, 26)
        Me.ModificacionAreas.Text = "Modificación"
        '
        'PacientesToolStripMenuItem
        '
        Me.PacientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaPacientes, Me.ConsultaIndividualPacientes, Me.ConsultaGeneralPacientes, Me.ModificacionPacientes})
        Me.PacientesToolStripMenuItem.Name = "PacientesToolStripMenuItem"
        Me.PacientesToolStripMenuItem.Size = New System.Drawing.Size(211, 26)
        Me.PacientesToolStripMenuItem.Text = "Pacientes"
        '
        'AltaPacientes
        '
        Me.AltaPacientes.Name = "AltaPacientes"
        Me.AltaPacientes.Size = New System.Drawing.Size(218, 26)
        Me.AltaPacientes.Text = "Alta"
        '
        'ConsultaIndividualPacientes
        '
        Me.ConsultaIndividualPacientes.Enabled = False
        Me.ConsultaIndividualPacientes.Name = "ConsultaIndividualPacientes"
        Me.ConsultaIndividualPacientes.Size = New System.Drawing.Size(218, 26)
        Me.ConsultaIndividualPacientes.Text = "Consulta Individual"
        '
        'ConsultaGeneralPacientes
        '
        Me.ConsultaGeneralPacientes.Enabled = False
        Me.ConsultaGeneralPacientes.Name = "ConsultaGeneralPacientes"
        Me.ConsultaGeneralPacientes.Size = New System.Drawing.Size(218, 26)
        Me.ConsultaGeneralPacientes.Text = "Consulta General"
        '
        'ModificacionPacientes
        '
        Me.ModificacionPacientes.Enabled = False
        Me.ModificacionPacientes.Name = "ModificacionPacientes"
        Me.ModificacionPacientes.Size = New System.Drawing.Size(218, 26)
        Me.ModificacionPacientes.Text = "Modificación"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MédicosPorEspecialidadToolStripMenuItem, Me.ÁreasDelHospitalPorPisoToolStripMenuItem, Me.PacientesPorSexoToolStripMenuItem, Me.PacietesPorÁreaHospitalariaToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'MédicosPorEspecialidadToolStripMenuItem
        '
        Me.MédicosPorEspecialidadToolStripMenuItem.Name = "MédicosPorEspecialidadToolStripMenuItem"
        Me.MédicosPorEspecialidadToolStripMenuItem.Size = New System.Drawing.Size(287, 26)
        Me.MédicosPorEspecialidadToolStripMenuItem.Text = "Médicos por especialidad"
        '
        'ÁreasDelHospitalPorPisoToolStripMenuItem
        '
        Me.ÁreasDelHospitalPorPisoToolStripMenuItem.Name = "ÁreasDelHospitalPorPisoToolStripMenuItem"
        Me.ÁreasDelHospitalPorPisoToolStripMenuItem.Size = New System.Drawing.Size(287, 26)
        Me.ÁreasDelHospitalPorPisoToolStripMenuItem.Text = "Áreas del hospital por piso"
        '
        'PacientesPorSexoToolStripMenuItem
        '
        Me.PacientesPorSexoToolStripMenuItem.Name = "PacientesPorSexoToolStripMenuItem"
        Me.PacientesPorSexoToolStripMenuItem.Size = New System.Drawing.Size(287, 26)
        Me.PacientesPorSexoToolStripMenuItem.Text = "Pacientes por sexo"
        '
        'PacietesPorÁreaHospitalariaToolStripMenuItem
        '
        Me.PacietesPorÁreaHospitalariaToolStripMenuItem.Name = "PacietesPorÁreaHospitalariaToolStripMenuItem"
        Me.PacietesPorÁreaHospitalariaToolStripMenuItem.Size = New System.Drawing.Size(287, 26)
        Me.PacietesPorÁreaHospitalariaToolStripMenuItem.Text = "Pacietes por área hospitalaria"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoHospital.My.Resources.Resources.logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatálogosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MédicosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaMedicos As ToolStripMenuItem
    Friend WithEvents ConsultaIndividualMedicos As ToolStripMenuItem
    Friend WithEvents ConsultaGeneralMedicos As ToolStripMenuItem
    Friend WithEvents ModificacionMedicos As ToolStripMenuItem
    Friend WithEvents BajaMedicos As ToolStripMenuItem
    Friend WithEvents ÁreasDelHospitalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaAreas As ToolStripMenuItem
    Friend WithEvents ConsultaGeneralAreas As ToolStripMenuItem
    Friend WithEvents ModificacionAreas As ToolStripMenuItem
    Friend WithEvents PacientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaPacientes As ToolStripMenuItem
    Friend WithEvents ConsultaIndividualPacientes As ToolStripMenuItem
    Friend WithEvents ConsultaGeneralPacientes As ToolStripMenuItem
    Friend WithEvents ModificacionPacientes As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MédicosPorEspecialidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÁreasDelHospitalPorPisoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PacientesPorSexoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PacietesPorÁreaHospitalariaToolStripMenuItem As ToolStripMenuItem
End Class
