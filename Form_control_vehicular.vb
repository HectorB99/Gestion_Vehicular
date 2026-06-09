Public Class Form_control_vehicular
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide
        Form1.Show
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        Hide()
        Form_registrar_vehiculo.Show()
        Form_registrar_vehiculo.CV_LoadDGVData()
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        Hide()
        Form_consulta_vehiculo.Show()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CerrarAplicacion()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Form_reporte_controlvehicular.Show()
    End Sub

    Private Sub btn_compra_refacciones_Click(sender As Object, e As EventArgs) Handles btn_compra_refacciones.Click
        Hide()
        Form_compra_piezas.Show()
        Form_compra_piezas.CV_LoadGeneralData()
    End Sub

    Private Sub btn_servicios_Click(sender As Object, e As EventArgs) Handles btn_servicios.Click
        Hide()
        Form_registro_servicios.Show()
    End Sub

End Class