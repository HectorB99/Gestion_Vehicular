Imports DocumentFormat.OpenXml.Vml

Public Class Form_detalles_servicio
    Public rowIndex As Int32 = 0
    Public action As Int32 = 0
    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        If action = 0 Then
            CV_InsertarLinea()
        Else
            CV_EditarLina()
        End If

    End Sub

    Public Sub CV_InsertarLinea()
        Dim cantidad As Int32 = Int32.Parse(txt_cantidad.Text)
        Dim costo As Double = Double.Parse(txt_costo_pieza.Text)
        Dim costo_total As Double

        costo_total = Math.Round((cantidad * costo), 2)

        Form_registro_servicios.DataGridView1.Rows.Add(txt_cantidad.Text, txt_unidad.Text, txt_descripcion.Text, costo, costo_total, txt_operacion.Text)

        action = 0

        Form_registro_servicios.total_servicio += costo_total
        Form_registro_servicios.tb_costo.Text = Math.Round((Form_registro_servicios.total_servicio), 2)
        CV_Clear()
        Me.Hide()
    End Sub

    Public Sub CV_EditarLina()
        Dim cantidad As Int32 = Int32.Parse(txt_cantidad.Text)
        Dim costo As Double = Double.Parse(txt_costo_pieza.Text)
        Dim costo_total As Double

        costo_total = cantidad * costo

        Form_registro_servicios.DataGridView1.Rows(rowIndex).Cells(0).Value = txt_cantidad.Text
        Form_registro_servicios.DataGridView1.Rows(rowIndex).Cells(1).Value = txt_unidad.Text
        Form_registro_servicios.DataGridView1.Rows(rowIndex).Cells(2).Value = txt_descripcion.Text
        Form_registro_servicios.DataGridView1.Rows(rowIndex).Cells(3).Value = txt_costo_pieza.Text
        Form_registro_servicios.DataGridView1.Rows(rowIndex).Cells(4).Value = costo_total
        Form_registro_servicios.DataGridView1.Rows(rowIndex).Cells(5).Value = txt_operacion.Text

        Form_registro_servicios.total_servicio = 0
        For Each row As DataGridViewRow In Form_registro_servicios.DataGridView1.Rows
            If Not row.IsNewRow AndAlso row.Cells("costo_total").Value IsNot Nothing Then
                Dim cellValue As Decimal
                If Decimal.TryParse(row.Cells("costo_total").Value, cellValue) Then
                    Form_registro_servicios.total_servicio += cellValue
                End If
            End If
        Next

        action = 0

        Form_registro_servicios.tb_costo.Text = Math.Round((Form_registro_servicios.total_servicio), 2)
        Me.Hide()
    End Sub

    Public Sub CV_Clear()
        txt_cantidad.Clear()
        txt_costo_pieza.Clear()
        txt_descripcion.Clear()
        txt_unidad.Clear()
        txt_operacion.Clear()
    End Sub

    Public Sub CV_CargarDatos(fila As DataGridViewRow)
        Me.CenterToScreen()

        txt_cantidad.Text = fila.Cells("cantidad").Value
        txt_unidad.Text = fila.Cells("unidad").Value
        txt_descripcion.Text = fila.Cells("pieza").Value
        txt_costo_pieza.Text = fila.Cells("costo").Value
        txt_operacion.Text = fila.Cells("operacion").Value

    End Sub

    Private Sub Form_detalles_servicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class