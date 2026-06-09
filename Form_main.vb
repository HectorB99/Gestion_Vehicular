Imports System.Data.SqlClient

Public Class Form1
    Dim constr As New SqlConnection(GlobalConnStrg)
    'Dim constr As New SqlConnection("Data Source=192.168.100.119,1433;Initial Catalog=foliado;User ID=sa;Password=viaroot.viaroot;Encrypt=True;TrustServerCertificate=True;")

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CerrarAplicacion()
    End Sub
    Private Sub ControlDeReportesDeFallas_MouseHover(sender As Object, e As EventArgs) Handles ControlDeReportesDeFallasToolStripMenuItem.MouseHover
        ControlDeReportesDeFallasToolStripMenuItem.ShowDropDown()
    End Sub
    Private Sub ControlDeReportesDeFallasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlDeReportesDeFallasToolStripMenuItem.Click
        Me.Hide()
        Formcontrolfallas.Show()
    End Sub
    Private Sub ControlVehicular_MouseHover(sender As Object, e As EventArgs) Handles ControlVehicularToolStripMenuItem.MouseHover
        ControlVehicularToolStripMenuItem.ShowDropDown()
    End Sub
    Private Sub ControlVehicularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlVehicularToolStripMenuItem.Click
        Me.Hide()
        Form_control_vehicular.Show()
    End Sub

    Private Sub Utilerias_MouseHover(sender As Object, e As EventArgs) Handles UtileriasToolStripMenuItem.MouseHover
        UtileriasToolStripMenuItem.ShowDropDown()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Me.Hide()
        registro.Show()
    End Sub

    Private Sub ConsultarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem1.Click
        Hide()
        consultas.Show()
    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
        Hide()
        Form_registrar_vehiculo.Show()
        Form_registrar_vehiculo.CV_LoadDGVData()
    End Sub

    Private Sub ConsultarVehiculoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarVehiculoToolStripMenuItem.Click
        Hide()
        Form_consulta_vehiculo.Show()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        Hide()
        Form_reporte_controlvehicular.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Me.Hide()
        Formproveedores.Show()
    End Sub

    Private Sub CompraDeRefaccionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraDeRefaccionesToolStripMenuItem.Click
        Me.Hide()
        Form_compra_piezas.Show()
        Form_compra_piezas.CV_LoadGeneralData()
    End Sub

    Private Sub RegistroDeServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeServiciosToolStripMenuItem.Click
        Me.Hide()
        Form_registro_servicios.Show()
    End Sub

    Public Sub CV_NotificacionServiciosVehiculos()
        Dim consulta As String = "SELECT vehiculos.claveinterna,* FROM control_vehicular 
        INNER JOIN vehiculos ON control_vehicular.idvehiculo = vehiculos.idvehiculo
        WHERE idcontrol = 
        (SELECT Max(c.idcontrol) 
        FROM control_vehicular AS c
        WHERE c.idvehiculo = control_vehicular.idvehiculo
        GROUP BY c.idvehiculo)
        AND control_vehicular.kilometraje_prox_servicio IS NOT NULL"

        Dim adaptador As New SqlDataAdapter(consulta, constr)
        Dim dt As New DataTable
        adaptador.Fill(dt)


        If dt.Rows.Count > 0 Then
            Form_mensaje_prox_servicio.Show()
            Form_mensaje_prox_servicio.CV_Validacion_Kilometraje_Servicio(dt)
        Else
            MessageBox.Show("Sin servicios pendientes")
        End If


    End Sub

    Private Sub TiposDeRefacciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeRefacciónToolStripMenuItem.Click
        Me.Hide()
        Form_tipo_refaccion.Show()
    End Sub
End Class

Module GlobalModule
    Public Sub CerrarAplicacion()
        Application.Exit()
    End Sub
End Module