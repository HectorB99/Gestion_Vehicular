Imports System.Data.SqlClient
Imports System.IO
Imports ClosedXML.Excel
Imports DocumentFormat.OpenXml.Spreadsheet
Imports WinFormsApp1.Form_consulta_vehiculo

Public Class Form_reporte_controlvehicular
    'Dim constr As New SqlConnection("Data Source=192.168.100.119,1433;Initial Catalog=foliado;User ID=sa;Password=viaroot.viaroot;")
    'Dim constr As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=foliado;Integrated Security=True;")
    'Dim constr As New SqlConnection("Data Source=192.168.100.119,1433;Initial Catalog=foliado;User ID=sa;Password=viaroot.viaroot;Encrypt=True;TrustServerCertificate=True;")
    Dim constr As New SqlConnection(GlobalConnStrg)
    Private Sub Form_reporte_controlvehicular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim hoy As Date = Date.Today
        Dim primerDiaSemana As Date = hoy.AddDays(-(hoy.DayOfWeek - DayOfWeek.Monday))

        dtp_fechainicial.Value = primerDiaSemana
        dtp_fechafinal.Value = hoy

        dtp_fechainicial.Format = DateTimePickerFormat.Short
        dtp_fechafinal.Format = DateTimePickerFormat.Short

        Dim consulta As String = "SELECT idvehiculo,claveinterna FROM vehiculos"

        constr.Open()
        Dim sqlstr As New SqlCommand(consulta, constr)
        Dim reader As SqlDataReader = sqlstr.ExecuteReader()
        cb_vehiculos.Items.Clear()
        cb_vehiculos.Items.Add(New ComboBoxItem("Todos los vehiculos", "0"))

        While reader.Read()
            Dim item As New ComboBoxItem(reader("claveinterna").ToString(), reader("idvehiculo").ToString())
            cb_vehiculos.Items.Add(item)
        End While
        constr.Close()

        Dim dt As New DataTable()

        'Columnas
        dt.Columns.Add("id", GetType(Integer))
        dt.Columns.Add("descripcion", GetType(String))

        'Agregar registros
        dt.Rows.Add(1, "Bitacora")
        dt.Rows.Add(2, "Refacciones")
        dt.Rows.Add(3, "Servicios")
        dt.Rows.Add(4, "Gasolina Semanal")

        'Asignar datos al ComboBox
        cb_tipo_reporte.DataSource = dt

        'Texto visible
        cb_tipo_reporte.DisplayMember = "descripcion"

        'Valor interno
        cb_tipo_reporte.ValueMember = "id"

        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CerrarAplicacion()
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        cb_vehiculos.SelectedIndex = -1
        DataGridView1.DataSource = Nothing
        Hide()
        Form_control_vehicular.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_reporte.Click
        If cb_vehiculos.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un vehículo")
            Exit Sub
        End If


        If cb_tipo_reporte.SelectedValue = 1 Then
            Reporte_Bitacora()
        ElseIf cb_tipo_reporte.SelectedValue = 2 Then
            Reporte_Refacciones()
        ElseIf cb_tipo_reporte.SelectedValue = 3 Then
            Reporte_Servicios()
        ElseIf cb_tipo_reporte.SelectedValue = 4 Then
            Reporte_Gasolina_Semanal()
        End If



        'dtp_fechafinal.Value = DateTime.Now
        'dtp_fechainicial.Value = DateTime.Now
    End Sub

    Public Sub Reporte_Bitacora()
        Dim selectedItem As ComboBoxItem = CType(cb_vehiculos.SelectedItem, ComboBoxItem)

        constr.Open()
        Dim sqlstr As SqlCommand = Nothing
        Dim consulta As String

        consulta = "SELECT
                        idcontrol, 
                        fecha_captura,
                        kilometraje_servicio,
                        kilometraje_prox_servicio,
                        kilometraje_ant, 
                        kilometraje_nue,
                        comentarios,
                        nombre_chofer,
                        CONVERT(VARCHAR(5), hora_entrada, 108) AS hora_entrada,
                        limpieza,
                        folio_ticket,
                        litros_gasolina,
                        precio_gasolina, 
                        total_gasolina, 
                        monto_permisos, 
                        monto_casetas  
                    FROM control_vehicular"

        If selectedItem.id = 0 Then
            consulta = consulta + " WHERE fecha_captura BETWEEN @fecha1 AND @fecha2"
        Else
            consulta = consulta + " WHERE idvehiculo = '" & selectedItem.id & "' AND fecha_captura BETWEEN @fecha1 AND @fecha2"
        End If

        consulta = consulta + " ORDER BY fecha_captura ASC"
        sqlstr = New SqlCommand(consulta, constr)

        sqlstr.Parameters.Add("@fecha1", SqlDbType.Date).Value = dtp_fechainicial.Value
        sqlstr.Parameters.Add("@fecha2", SqlDbType.Date).Value = dtp_fechafinal.Value

        If sqlstr IsNot Nothing Then
            Dim dt As New DataTable()
            Using da As New SqlDataAdapter(sqlstr)
                da.Fill(dt)
            End Using
            DataGridView1.DataSource = dt
        End If

        DataGridView1.Columns("idcontrol").Visible = False
        DataGridView1.Columns("fecha_captura").HeaderText = "Fecha de Captura"
        DataGridView1.Columns("kilometraje_servicio").HeaderText = "Kilometraje en el Ultimo Servicio"
        DataGridView1.Columns("kilometraje_prox_servicio").HeaderText = "Kilometraje faltante para el Siguiente Servicio"
        DataGridView1.Columns("kilometraje_ant").HeaderText = "Kilometraje de Ultimo Registro"
        DataGridView1.Columns("kilometraje_nue").HeaderText = "Kilometraje Actual"
        DataGridView1.Columns("comentarios").HeaderText = "Comentarios"
        DataGridView1.Columns("comentarios").Width = 200
        DataGridView1.Columns("nombre_chofer").HeaderText = "Chofer"
        DataGridView1.Columns("hora_entrada").HeaderText = "Hora de Inspección"
        DataGridView1.Columns("limpieza").HeaderText = "Limpieza y Orden de la Cabina"
        DataGridView1.Columns("folio_ticket").HeaderText = "Folio del Ticket de Gasolina"
        DataGridView1.Columns("litros_gasolina").HeaderText = "Litros de gasolina"
        DataGridView1.Columns("precio_gasolina").HeaderText = "Precio/ltr de gasolina"
        DataGridView1.Columns("total_gasolina").HeaderText = "Costo total de gasolina"
        DataGridView1.Columns("monto_permisos").HeaderText = "Monto de Permiso de Descarga"
        DataGridView1.Columns("monto_casetas").HeaderText = "Monto para Casetas"
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.Columns("comentarios").DefaultCellStyle.WrapMode = DataGridViewTriState.True

        constr.Close()
    End Sub

    Public Sub Reporte_Refacciones()
        Dim selectedItem As ComboBoxItem = CType(cb_vehiculos.SelectedItem, ComboBoxItem)
        constr.Open()
        Dim sqlstr As SqlCommand = Nothing
        Dim consulta As String

        consulta = "SELECT
            compra_piezas.idcompra,
            compra_piezas.fecha_captura,
            compra_piezas.fecha_compra,
            compra_piezas.costo_pieza,
            tipo_piezas.descripcion,
            compra_piezas.marca,
            compra_piezas.modelo,
            proveedores.nombre
        FROM compra_piezas
        INNER JOIN proveedores ON compra_piezas.idproveedor = proveedores.idproveedor
        INNER JOIN tipo_piezas ON compra_piezas.tipo_pieza = tipo_piezas.idtipopieza"

        If selectedItem.id = 0 Then
            consulta = consulta + " WHERE fecha_captura BETWEEN @fecha1 AND @fecha2"
        Else
            consulta = consulta + " WHERE idvehiculo = '" & selectedItem.id & "' AND fecha_captura BETWEEN @fecha1 AND @fecha2"
        End If

        sqlstr = New SqlCommand(consulta, constr)

        sqlstr.Parameters.Add("@fecha1", SqlDbType.Date).Value = dtp_fechainicial.Value
        sqlstr.Parameters.Add("@fecha2", SqlDbType.Date).Value = dtp_fechafinal.Value

        If sqlstr IsNot Nothing Then
            Dim dt As New DataTable()
            Using da As New SqlDataAdapter(sqlstr)
                da.Fill(dt)
            End Using
            DataGridView1.DataSource = dt
        End If

        DataGridView1.Columns("idcompra").Visible = False
        DataGridView1.Columns("fecha_captura").HeaderText = "Fecha de Captura"
        DataGridView1.Columns("fecha_compra").HeaderText = "Fecha de Compra"
        DataGridView1.Columns("costo_pieza").HeaderText = "Costo de la pieza"
        DataGridView1.Columns("descripcion").HeaderText = "Tipo de Pieza"
        DataGridView1.Columns("marca").HeaderText = "Marca"
        DataGridView1.Columns("modelo").HeaderText = "Modelo"
        DataGridView1.Columns("nombre").HeaderText = "Proveedor"
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        constr.Close()

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Public Sub Reporte_Servicios()
        Dim selectedItem As ComboBoxItem = CType(cb_vehiculos.SelectedItem, ComboBoxItem)
        constr.Open()
        Dim sqlstr As SqlCommand = Nothing
        Dim consulta As String

        consulta = "SELECT 
                servicios.idservicio,
                servicios.fecha_captura,
                vehiculos.claveinterna,
                servicios.fecha_programada, 
                servicios.fecha_entrada,
                servicios.fecha_salida, 
                servicios.tipo_servicio, 
                servicios.costo_servicio,
                servicios.taller, 
                servicios.direccion_taller, 
                servicios.tel_taller, 
                servicios.mecanico_nombre, 
                servicios.tel_mecanico,
                servicios.estatus
            FROM servicios
            INNER JOIN vehiculos
            On servicios.idvehiculo = vehiculos.idvehiculo"


        If selectedItem.id = 0 Then
            consulta = consulta + " WHERE servicios.fecha_captura BETWEEN @fecha1 AND @fecha2"
        Else
            consulta = consulta + " WHERE servicios.idvehiculo = '" & selectedItem.id & "' AND servicios.fecha_captura BETWEEN @fecha1 AND @fecha2"
        End If


        sqlstr = New SqlCommand(consulta, constr)


        sqlstr.Parameters.Add("@fecha1", SqlDbType.Date).Value = dtp_fechainicial.Value
        sqlstr.Parameters.Add("@fecha2", SqlDbType.Date).Value = dtp_fechafinal.Value

        If sqlstr IsNot Nothing Then
            Dim dt As New DataTable()
            Using da As New SqlDataAdapter(sqlstr)
                da.Fill(dt)
            End Using
            DataGridView1.DataSource = dt

            For Each row As DataRow In dt.Rows
                Select Case row("estatus").ToString()
                    Case "C"
                        row("estatus") = "Concluido"

                    Case "P"
                        row("estatus") = "Programado"

                    Case "EC"
                        row("estatus") = "En Curso"
                End Select
            Next

            DataGridView1.DataSource = dt
        End If

        DataGridView1.Columns("fecha_captura").HeaderText = "Fecha de Captura"
        DataGridView1.Columns("claveinterna").HeaderText = "Vehiculo"
        DataGridView1.Columns("fecha_programada").HeaderText = "Fecha de Compra"
        DataGridView1.Columns("fecha_entrada").HeaderText = "Fecha de Entrada"
        DataGridView1.Columns("fecha_salida").HeaderText = "Fecha de Salida"
        DataGridView1.Columns("tipo_servicio").HeaderText = "Tipo de Servicio"
        DataGridView1.Columns("costo_servicio").HeaderText = "Costo del Servicio"
        DataGridView1.Columns("taller").HeaderText = "Taller"
        DataGridView1.Columns("direccion_taller").HeaderText = "Dirección"
        DataGridView1.Columns("tel_taller").HeaderText = "Télefono del Taller"
        DataGridView1.Columns("mecanico_nombre").HeaderText = "Mecánico"
        DataGridView1.Columns("tel_mecanico").HeaderText = "Télefono del Mecánico"
        DataGridView1.Columns("estatus").HeaderText = "Estatus"
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        constr.Close()

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub Reporte_Gasolina_Semanal()
        Dim selectedItem As ComboBoxItem = CType(cb_vehiculos.SelectedItem, ComboBoxItem)
        constr.Open()
        Dim sqlstr As SqlCommand = Nothing
        Dim consulta As String

        consulta = "
        SET DATEFIRST 1;
        SELECT
            DATEADD(DAY, 1 - DATEPART(WEEKDAY, cv.fecha_captura), CAST(cv.fecha_captura AS DATE)) AS fecha_inicio_semana,
            DATEADD(DAY, 6 - DATEPART(WEEKDAY, cv.fecha_captura), CAST(cv.fecha_captura AS DATE)) AS fecha_fin_semana,
	        v.claveinterna,
            SUM(cv.litros_gasolina) AS total_litros,
            SUM(cv.total_gasolina) AS total_precio
        FROM control_vehicular cv
        INNER JOIN vehiculos v ON cv.idvehiculo = v.idvehiculo"

        If selectedItem.id = 0 Then
            consulta = consulta + " WHERE cv.fecha_captura BETWEEN @fecha1 AND @fecha2"
        Else
            consulta = consulta + " WHERE cv.idvehiculo = '" & selectedItem.id & "' AND cv.fecha_captura BETWEEN @fecha1 AND @fecha2"
        End If

        consulta = consulta + "
        GROUP BY
            DATEADD(DAY, 1 - DATEPART(WEEKDAY, cv.fecha_captura), CAST(cv.fecha_captura AS DATE)),
            DATEADD(DAY, 6 - DATEPART(WEEKDAY, cv.fecha_captura), CAST(cv.fecha_captura AS DATE)),
	        cv.idvehiculo,
            v.claveinterna
        ORDER BY
            fecha_inicio_semana,
            cv.idvehiculo;"

        sqlstr = New SqlCommand(consulta, constr)

        sqlstr.Parameters.Add("@fecha1", SqlDbType.Date).Value = dtp_fechainicial.Value
        sqlstr.Parameters.Add("@fecha2", SqlDbType.Date).Value = dtp_fechafinal.Value

        If sqlstr IsNot Nothing Then
            Dim dt As New DataTable()
            Using da As New SqlDataAdapter(sqlstr)
                da.Fill(dt)
            End Using
            DataGridView1.DataSource = dt
        End If

        DataGridView1.Columns("fecha_inicio_semana").HeaderText = "Fecha de Inicio de Semana"
        DataGridView1.Columns("fecha_fin_semana").HeaderText = "Fecha de Fin de Semana"
        DataGridView1.Columns("claveinterna").HeaderText = "Clave Interna"
        DataGridView1.Columns("total_litros").HeaderText = "Total de Litros"
        DataGridView1.Columns("total_precio").HeaderText = "Costo Total"

        constr.Close()

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub ExportarExcel()
        Dim selectedItem As ComboBoxItem = CType(cb_vehiculos.SelectedItem, ComboBoxItem)
        Dim claveunidad As String
        Dim rutaCarpeta As String = "C:\Reporte Vehicular\"
        Dim nombreArchivo As String
        claveunidad = selectedItem.clave

        If claveunidad = "Todos los vehiculos" Then
            claveunidad = "GENERAL"
        End If

        If cb_tipo_reporte.SelectedValue = 1 Then
            nombreArchivo = "REPORTE_BITACORA_" &
            claveunidad & "_" &
            DateTime.Now.ToString("dd_MM_yy") &
            ".xlsx"
        ElseIf cb_tipo_reporte.SelectedValue = 2 Then
            nombreArchivo = "REPORTE_COMPRA_REFACCIONES_" &
            claveunidad & "_" &
            DateTime.Now.ToString("dd_MM_yy") &
            ".xlsx"
        ElseIf cb_tipo_reporte.SelectedValue = 3 Then
            nombreArchivo = "REPORTE_SERVICIOS_" &
            claveunidad & "_" &
            DateTime.Now.ToString("dd_MM_yy") &
            ".xlsx"
        ElseIf cb_tipo_reporte.SelectedValue = 4 Then
            nombreArchivo = "REPORTE_GASOLINA_SEMANAL_" &
            claveunidad & "_" &
            DateTime.Now.ToString("dd_MM_yy") &
            ".xlsx"
        End If

        If Not Directory.Exists(rutaCarpeta) Then
            Directory.CreateDirectory(rutaCarpeta)
        End If

        Dim rutaCompleta As String = Path.Combine(rutaCarpeta, nombreArchivo)

        Dim wb As New XLWorkbook()
        Dim ws = wb.Worksheets.Add("Datos")

        Dim rango = ws.Range("G2:I2")
        With rango
            .Merge()
            .Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
        End With
        ws.Cell(2, 7).Value = "Reporte de Bitacora " & claveunidad & " " & dtp_fechainicial.Value & "-" & dtp_fechafinal.Value

        For i As Integer = 1 To DataGridView1.Columns.Count - 1

            ws.Cell(5, i + 1).Value = DataGridView1.Columns(i).HeaderText
            ws.Cell(5, i + 1).Style.Font.Bold = True
            'ws.Cell(5, i + 1).Style.Fill.BackgroundColor = 
        Next

        Dim filaExcel As Integer = 6

        For Each row As DataGridViewRow In DataGridView1.Rows

            If Not row.IsNewRow Then
                For col As Integer = 1 To DataGridView1.Columns.Count - 1
                    Dim valor = row.Cells(col).Value

                    If valor IsNot Nothing Then
                        If TypeOf valor Is Date Or TypeOf valor Is DateTime Then
                            ws.Cell(filaExcel, col + 1).Value = CDate(valor)
                            ws.Cell(filaExcel, col + 1).Style.DateFormat.Format = "dd/MM/yyyy"
                        Else
                            ws.Cell(filaExcel, col + 1).Value = valor.ToString()
                        End If
                    Else
                        ws.Cell(filaExcel, col + 1).Value = ""
                    End If
                Next

                filaExcel += 1
            End If

        Next

        ws.Style.Font.FontSize = 18

        ws.Row(5).Height = 73.5
        ws.Column(2).Width = 16.71
        ws.Column(3).Width = 19.57
        ws.Column(4).Width = 28.29
        ws.Column(5).Width = 19.57
        ws.Column(6).Width = 19.0
        ws.Column(7).Width = 64.0
        ws.Column(8).Width = 25.29
        ws.Column(9).Width = 18.14
        ws.Column(10).Width = 15.29
        ws.Column(11).Width = 19.29
        ws.Column(12).Width = 12.57
        ws.Column(13).Width = 17.14
        ws.Column(14).Width = 15.43
        ws.Column(15).Width = 20.43
        ws.Column(16).Width = 18.29

        ws.PageSetup.PagesWide = 1
        ws.PageSetup.PagesTall = False

        ws.PageSetup.PageOrientation = XLPageOrientation.Landscape

        ws.RangeUsed().Style.Border.OutsideBorder = XLBorderStyleValues.Thin
        ws.RangeUsed().Style.Border.InsideBorder = XLBorderStyleValues.Thin

        ws.RangeUsed().Style.Alignment.WrapText = True
        'ws.Columns().AdjustToContents()

        wb.SaveAs(rutaCompleta)

        MessageBox.Show("Archivo guardado en: " & rutaCompleta)

    End Sub

    Private Sub btn_export_xlsx_Click(sender As Object, e As EventArgs) Handles btn_export_xlsx.Click
        ExportarExcel()
    End Sub

    Private Sub dtp_fechainicial_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fechainicial.ValueChanged
        dtp_fechainicial.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtp_fechafinal_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fechafinal.ValueChanged
        dtp_fechafinal.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If cb_tipo_reporte.SelectedValue = 1 Then
            DGV_Click_Bitacora(e)
        ElseIf cb_tipo_reporte.SelectedValue = 2 Then
            DGV_Click_Refacciones(e)
        ElseIf cb_tipo_reporte.SelectedValue = 3 Then
            DGV_Click_Servicios(e)
        ElseIf cb_tipo_reporte.SelectedValue = 4 Then

        End If
    End Sub

    Public Sub DGV_Click_Bitacora(e)
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim idcontrol As Int32 = fila.Cells("idcontrol").Value

            Dim respuesta As DialogResult

            respuesta = MessageBox.Show(
                "¿Desea editar el registro seleccionado?",
                "Confirmar edición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

            If respuesta = DialogResult.Yes Then
                Me.Hide()
                Form_consulta_vehiculo.Show()
                Form_consulta_vehiculo.CV_CargarDatosEdicion(idcontrol)
            End If
        End If
    End Sub

    Public Sub DGV_Click_Refacciones(e)
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim idcompra As Int32 = fila.Cells("idcompra").Value

            Dim respuesta As DialogResult

            respuesta = MessageBox.Show(
                "¿Desea editar el registro seleccionado?",
                "Confirmar edición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

            If respuesta = DialogResult.Yes Then
                Me.Hide()
                Form_compra_piezas.CV_LoadGeneralData()
                Form_compra_piezas.idcompra = idcompra
                Form_compra_piezas.Show()
            End If
        End If
    End Sub

    Public Sub DGV_Click_Servicios(e)
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim idservicio As Int32 = fila.Cells("idservicio").Value

            Dim respuesta As DialogResult

            respuesta = MessageBox.Show(
                "¿Desea editar el registro seleccionado?",
                "Confirmar edición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

            If respuesta = DialogResult.Yes Then
                Me.Hide()
                Form_registro_servicios.idservicio = idservicio
                Form_registro_servicios.Show()
                Form_registro_servicios.CV_CargarDatosEdicion()
            End If
        End If
    End Sub
End Class