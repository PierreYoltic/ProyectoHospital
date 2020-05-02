Imports System.ComponentModel
Public Class FrmPrincipal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub
    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaMedicos.Click
        FrmAltaMedicos.StartPosition = FormStartPosition.CenterScreen
        FrmAltaMedicos.ShowDialog()
    End Sub
    Private Sub ConsultaIndividualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaIndividualMedicos.Click
        FrmConsultaIndividualMedicos.StartPosition = FormStartPosition.CenterScreen
        FrmConsultaIndividualMedicos.ShowDialog()
    End Sub
    Private Sub ConsultaGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaGeneralMedicos.Click
        FrmConsultaGeneralMedicos.StartPosition = FormStartPosition.CenterScreen
        FrmConsultaGeneralMedicos.ShowDialog()
    End Sub
    Private Sub ModificacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificacionMedicos.Click
        FrmModificacionesMedicos.StartPosition = FormStartPosition.CenterScreen
        FrmModificacionesMedicos.ShowDialog()
    End Sub
    Private Sub BajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaMedicos.Click
        FrmBajaMedicos.StartPosition = FormStartPosition.CenterScreen
        FrmBajaMedicos.ShowDialog()
    End Sub
    Private Sub AltaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AltaAreas.Click
        FrmAltaAreas.StartPosition = FormStartPosition.CenterScreen
        FrmAltaAreas.ShowDialog()
    End Sub
    Private Sub ConsultaGeneralToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaGeneralAreas.Click
        FrmConsultaGeneralAreas.StartPosition = FormStartPosition.CenterScreen
        FrmConsultaGeneralAreas.ShowDialog()
    End Sub
    Private Sub ModificaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificacionAreas.Click
        FrmModificacionAreas.StartPosition = FormStartPosition.CenterScreen
        FrmModificacionAreas.ShowDialog()
    End Sub
    Private Sub AltaPacientes_Click(sender As Object, e As EventArgs) Handles AltaPacientes.Click
        FrmAltaPacientes.StartPosition = FormStartPosition.CenterScreen
        FrmAltaPacientes.ShowDialog()
    End Sub
    Private Sub ConsultaIndividualPacientes_Click(sender As Object, e As EventArgs) Handles ConsultaIndividualPacientes.Click
        FrmConsultaIndividualPacientes.StartPosition = FormStartPosition.CenterScreen
        FrmConsultaIndividualPacientes.ShowDialog()
    End Sub
    Private Sub ConsultaGeneralPacientes_Click(sender As Object, e As EventArgs) Handles ConsultaGeneralPacientes.Click
        FrmConsultaGeneralPacientes.StartPosition = FormStartPosition.CenterScreen
        FrmConsultaGeneralPacientes.ShowDialog()
    End Sub
    Private Sub ModificacionPacientes_Click(sender As Object, e As EventArgs) Handles ModificacionPacientes.Click
        FrmModificacionesPacientes.StartPosition = FormStartPosition.CenterScreen
        FrmModificacionesPacientes.ShowDialog()
    End Sub
    Private Sub MédicosPorEspecialidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MédicosPorEspecialidadToolStripMenuItem.Click
        FrmReporteMedicos.StartPosition = FormStartPosition.CenterScreen
        FrmReporteMedicos.ShowDialog()
    End Sub
    Private Sub ÁreasDelHospitalPorPisoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁreasDelHospitalPorPisoToolStripMenuItem.Click
        FrmReporteAreas.StartPosition = FormStartPosition.CenterScreen
        FrmReporteAreas.ShowDialog()
    End Sub
    Private Sub PacientesPorSexoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacientesPorSexoToolStripMenuItem.Click
        FrmReportePacientesSexo.StartPosition = FormStartPosition.CenterScreen
        FrmReportePacientesSexo.ShowDialog()
    End Sub
    Private Sub PacietesPorÁreaHospitalariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacietesPorÁreaHospitalariaToolStripMenuItem.Click
        FrmReportePacientesArea.StartPosition = FormStartPosition.CenterScreen
        FrmReportePacientesArea.ShowDialog()
    End Sub
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        MessageBox.Show("Autor: Pierre Yoltic Soltero Villa", "'Hospital Ventana de Hierro' Version: 1.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub
    Private Sub FrmPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class
