Imports System.Data.SqlClient
Imports System.IO
Imports ClosedXML.Excel
Imports DocumentFormat.OpenXml.Spreadsheet
Imports WinFormsApp1.Form_consulta_vehiculo

Public Class Form_reporte_controlvehicular
    Dim imprimir As Int32 = 0
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
        dt.Rows.Add(2, "Refacciones Compradas")
        dt.Rows.Add(3, "Servicios")
        dt.Rows.Add(4, "Gasolina Semanal")
        dt.Rows.Add(5, "Gasolina Diaria")
        dt.Rows.Add(6, "Kilometraje diario")
        dt.Rows.Add(7, "Kilometraje semanal")

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

        Select Case cb_tipo_reporte.SelectedValue
            Case 1
                Reporte_Bitacora()
            Case 2
                Reporte_Refacciones()
            Case 3
                Reporte_Servicios()
            Case 4
                Reporte_Gasolina_Semanal()
            Case 5
                Reporte_Gasolina_Diaria()
            Case 6
                Reporte_Kilometraje_Diario()
            Case 7
                Reporte_Kilometraje_Semanal()
            Case Else

        End Select




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

    Public Sub Reporte_Gasolina_Diaria()
        Dim selectedItem As ComboBoxItem = CType(cb_vehiculos.SelectedItem, ComboBoxItem)

        constr.Open()
        Dim sqlstr As SqlCommand = Nothing
        Dim consulta As String

        consulta = "SELECT
                control_vehicular.fecha_captura,
                vehiculos.claveinterna,
                vehiculos.num_economico,
                control_vehicular.nombre_chofer,
                vehiculos.tipo_combustible,
                control_vehicular.folio_ticket,
                control_vehicular.litros_gasolina,
                control_vehicular.precio_gasolina,
                control_vehicular.total_gasolina
            FROM control_vehicular
            INNER JOIN vehiculos
            On control_vehicular.idvehiculo = vehiculos.idvehiculo"

        If selectedItem.id = 0 Then
            consulta = consulta + " WHERE control_vehicular.fecha_captura BETWEEN @fecha1 AND @fecha2 AND control_vehicular.folio_ticket > ''"
        Else
            consulta = consulta + " WHERE control_vehicular.idvehiculo = '" & selectedItem.id & "' AND control_vehicular.fecha_captura BETWEEN @fecha1 AND @fecha2 AND control_vehicular.folio_ticket > ''"
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

        If selectedItem.id = 0 Then
            DataGridView1.Columns("claveinterna").HeaderText = "Clave Interna"
            DataGridView1.Columns("num_economico").HeaderText = "Núm. Económico"
            DataGridView1.Columns("claveinterna").Visible = True
            DataGridView1.Columns("num_economico").Visible = True
        Else
            DataGridView1.Columns("claveinterna").Visible = False
            DataGridView1.Columns("num_economico").Visible = False
        End If

        DataGridView1.Columns("fecha_captura").HeaderText = "Fecha del Registro"
        DataGridView1.Columns("nombre_chofer").HeaderText = "Chofer"
        DataGridView1.Columns("tipo_combustible").HeaderText = "Tipo de Combustible"
        DataGridView1.Columns("folio_ticket").HeaderText = "Folio del Ticket"
        DataGridView1.Columns("litros_gasolina").HeaderText = "Litros de Combustible"
        DataGridView1.Columns("precio_gasolina").HeaderText = "Precio por litro"
        DataGridView1.Columns("total_gasolina").HeaderText = "Costo Total"
        DataGridView1.Columns("litros_gasolina").DefaultCellStyle.Format = "0.00 'Lts'"
        DataGridView1.Columns("precio_gasolina").DefaultCellStyle.Format = "$#,##0.00"
        DataGridView1.Columns("total_gasolina").DefaultCellStyle.Format = "$#,##0.00"
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



        constr.Close()

    End Sub

    Public Sub Reporte_Kilometraje_Diario()

    End Sub

    Public Sub Reporte_Kilometraje_Semanal()

    End Sub

    Private Sub btn_export_xlsx_Click(sender As Object, e As EventArgs) Handles btn_export_xlsx.Click
        ExportarExcel()
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

        Select Case cb_tipo_reporte.SelectedValue
            Case 1
                nombreArchivo = "REPORTE_BITACORA_" &
                claveunidad & "_" &
                DateTime.Now.ToString("dd_MM_yy") &
                ".xlsx"
                CV_ExpExcelReporteBitacora(claveunidad, rutaCarpeta, nombreArchivo)
            Case 2
                nombreArchivo = "REPORTE_COMPRA_REFACCIONES_" &
                claveunidad & "_" &
                DateTime.Now.ToString("dd_MM_yy") &
                ".xlsx"
            Case 3
                nombreArchivo = "REPORTE_SERVICIOS_" &
                claveunidad & "_" &
                DateTime.Now.ToString("dd_MM_yy") &
                ".xlsx"
            Case 4
                nombreArchivo = "REPORTE_GASOLINA_SEMANAL_" &
                claveunidad & "_" &
                DateTime.Now.ToString("dd_MM_yy") &
                ".xlsx"
                CV_ExpExcelReporteGasolinaSemanal(claveunidad, rutaCarpeta, nombreArchivo)
            Case 5
                nombreArchivo = "REPORTE_GASOLINA_DIARIA_" &
                claveunidad & "_" &
                DateTime.Now.ToString("dd_MM_yy") &
                ".xlsx"
                CV_ExpExcelReporteGasolinaDiaria(claveunidad, rutaCarpeta, nombreArchivo)
            Case 6
                nombreArchivo = "REPORTE_KILOMETRAJE_DIARIO_" &
                claveunidad & "_" &
                DateTime.Now.ToString("dd_MM_yy") &
                ".xlsx"
            Case 7
                nombreArchivo = "REPORTE_KILOMETRAJE_SEMANAL_" &
                claveunidad & "_" &
                DateTime.Now.ToString("dd_MM_yy") &
                ".xlsx"

        End Select

    End Sub

    Public Sub CV_ExpExcelReporteBitacora(ByVal claveunidad As String, ByVal rutaCarpeta As String, ByVal nombreArchivo As String)

        If Not Directory.Exists(rutaCarpeta) Then
            Directory.CreateDirectory(rutaCarpeta)
        End If

        Dim rutaCompleta As String = Path.Combine(rutaCarpeta, nombreArchivo)

        Dim wb As New XLWorkbook()
        Dim ws = wb.Worksheets.Add("Datos")

        Dim rango = ws.Range("B2:P2")
        With rango
            .Merge()
            .Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
        End With
        ws.Cell(2, 2).Value = "Reporte de Bitacora " & claveunidad & " " & dtp_fechainicial.Value & "-" & dtp_fechafinal.Value


        For i As Integer = 1 To DataGridView1.Columns.Count - 1

            ws.Cell(5, i + 1).Value = DataGridView1.Columns(i).HeaderText
            ws.Cell(5, i + 1).Style.Font.Bold = True
            ws.Cell(5, i + 1).Style.Alignment.Vertical = XLAlignmentVerticalValues.Top
            ws.Cell(5, i + 1).Style.Fill.BackgroundColor = XLColor.FromHtml("#A6A6A6")
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

        ws.Style.Font.FontSize = 28
        ws.Cell(2, 2).Style.Font.FontSize = 48

        ws.Row(5).Height = 14
        ws.Row(2).Height = 54
        ws.Column(2).Width = 29
        ws.Column(3).Width = 23.71
        ws.Column(4).Width = 33.43
        ws.Column(5).Width = 20.71
        ws.Column(6).Width = 19.29
        ws.Column(7).Width = 16.71
        ws.Column(8).Width = 20.71
        ws.Column(9).Width = 22.43
        ws.Column(10).Width = 20.43
        ws.Column(11).Width = 18.29

        ws.PageSetup.PagesWide = 1
        ws.PageSetup.PagesTall = False

        ws.PageSetup.PageOrientation = XLPageOrientation.Landscape

        ws.RangeUsed().Style.Border.OutsideBorder = XLBorderStyleValues.Thin
        ws.RangeUsed().Style.Border.InsideBorder = XLBorderStyleValues.Thin

        ws.RangeUsed().Style.Alignment.WrapText = True
        'ws.Columns().AdjustToContents()

        With ws.PageSetup.Margins
            .Top = 0.4
            .Bottom = 0.4
            .Left = 0.4
            .Right = 0.4
        End With

        wb.SaveAs(rutaCompleta)

        If imprimir = 1 Then
            CV_ImprimirExcel(rutaCompleta)
            imprimir = 0
            Exit Sub
        End If

        MessageBox.Show("Archivo guardado en: " & rutaCompleta)
    End Sub

    Public Sub CV_ExpExcelReporteGasolinaSemanal(ByVal claveunidad As String, ByVal rutaCarpeta As String, ByVal nombreArchivo As String)

    End Sub

    Public Sub CV_ExpExcelReporteGasolinaDiaria(ByVal claveunidad As String, ByVal rutaCarpeta As String, ByVal nombreArchivo As String)
        If Not Directory.Exists(rutaCarpeta) Then
            Directory.CreateDirectory(rutaCarpeta)
        End If

        Dim rutaCompleta As String = Path.Combine(rutaCarpeta, nombreArchivo)

        Dim wb As New XLWorkbook()
        Dim ws = wb.Worksheets.Add("Datos")
        Dim rango As IXLRange

        Dim claveinterna As String
        Dim num_economico As String
        Dim marca As String
        Dim linea As String
        Dim modelo As String
        Dim placa As String
        Dim tipo_motor As String

        If claveunidad = "GENERAL" Then
            rango = ws.Range("B2:J2")
        Else
            rango = ws.Range("B2:H2")

            Dim consulta As String = ""
            consulta = "SELECT * FROM vehiculos WHERE claveinterna = '" & claveunidad & "'"
            Dim adaptador As New SqlDataAdapter(consulta, constr)
            Dim dt As New DataTable
            adaptador.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)

                claveinterna = row("claveinterna")
                num_economico = row("num_economico")
                marca = row("marca")
                linea = row("linea")
                modelo = row("modelo")
                placa = row("placa")
                tipo_motor = row("tipo_motor")
            End If

        End If

        With rango
            .Merge()
            .Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
        End With
        ws.Cell(2, 2).Value = "Reporte de Consumo Diario de Gasolina " & claveunidad & " " & dtp_fechainicial.Value & "-" & dtp_fechafinal.Value

        Dim aux As Int32 = 2

        For i As Integer = 0 To DataGridView1.Columns.Count - 1
            If claveunidad <> "GENERAL" Then
                If i = 1 Or i = 2 Then
                    aux -= 1
                    Continue For
                End If
            End If

            ws.Cell(5, i + aux).Value = DataGridView1.Columns(i).HeaderText
            ws.Cell(5, i + aux).Style.Font.Bold = True
            ws.Cell(5, i + aux).Style.Alignment.Vertical = XLAlignmentVerticalValues.Top
            ws.Cell(5, i + aux).Style.Fill.BackgroundColor = XLColor.FromHtml("#A6A6A6")


        Next

        aux = 2

        Dim filaExcel As Integer = 6

        If claveunidad = "GENERAL" Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    For col As Integer = 0 To DataGridView1.Columns.Count - 1
                        Dim valor = row.Cells(col).Value
                        Dim celda As IXLCell = ws.Cell(filaExcel, col + 2)

                        If valor IsNot Nothing AndAlso Not IsDBNull(valor) Then
                            If TypeOf valor Is Date Or TypeOf valor Is DateTime Then
                                celda.SetValue(CDate(valor))
                                celda.Style.DateFormat.Format = "dd/MM/yyyy"
                            ElseIf col = 6 Then
                                celda.SetValue(CDbl(valor))
                                celda.Style.NumberFormat.Format = "0.00 ""Lts"""
                            ElseIf col = 7 Or col = 8 Then
                                celda.SetValue(CDbl(valor))
                                celda.Style.NumberFormat.Format = "$#,##0.00"
                            Else
                                celda.SetValue(CStr(valor))
                            End If
                        Else
                            celda.SetValue("")
                        End If
                    Next

                    filaExcel += 1
                End If
            Next
        Else
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    For col As Integer = 0 To DataGridView1.Columns.Count - 1
                        If col = 1 Or col = 2 Then
                            aux -= 1
                            Continue For
                        End If

                        Dim valor = row.Cells(col).Value
                        Dim celda As IXLCell = ws.Cell(filaExcel, col + aux)

                        If valor IsNot Nothing AndAlso Not IsDBNull(valor) Then
                            If TypeOf valor Is Date Or TypeOf valor Is DateTime Then
                                celda.SetValue(CDate(valor))
                                celda.Style.DateFormat.Format = "dd/MM/yyyy"

                            ElseIf col = 6 Then
                                celda.SetValue(CDbl(valor))
                                celda.Style.NumberFormat.Format = "0.00 ""Lts"""
                            ElseIf col = 7 Or col = 8 Then
                                celda.SetValue(CDbl(valor))
                                celda.Style.NumberFormat.Format = "$#,##0.00"
                            Else
                                celda.SetValue(CStr(valor))
                            End If
                        Else
                            celda.SetValue("")
                        End If
                    Next

                    aux = 2
                    filaExcel += 1
                End If
            Next

            ws.Cell(3, 2).Value = "Clave"
            ws.Cell(3, 2).Style.Font.Bold = True
            ws.Cell(3, 3).Value = claveinterna
            ws.Cell(4, 2).Value = "Num. Económico"
            ws.Cell(4, 2).Style.Font.Bold = True
            ws.Cell(4, 3).Value = num_economico
            ws.Cell(3, 4).Value = "Marca"
            ws.Cell(3, 4).Style.Font.Bold = True
            ws.Cell(3, 5).Value = marca
            ws.Cell(4, 4).Value = "Linea"
            ws.Cell(4, 4).Style.Font.Bold = True
            ws.Cell(4, 5).Value = linea
            ws.Cell(3, 6).Value = "Modelo"
            ws.Cell(3, 6).Style.Font.Bold = True
            ws.Cell(3, 7).Value = modelo
            ws.Cell(4, 6).Value = "Placas"
            ws.Cell(4, 6).Style.Font.Bold = True
            ws.Cell(4, 7).Value = placa

        End If

        ws.Style.Font.FontSize = 28
        ws.Cell(2, 2).Style.Font.FontSize = 36

        ws.Row(5).Height = 81.75
        ws.Row(2).Height = 51.75

        If claveunidad = "GENERAL" Then
            ws.Column(2).Width = 30.57
            ws.Column(3).Width = 28.43
            ws.Column(4).Width = 30.43
            ws.Column(5).Width = 43.71
            ws.Column(6).Width = 52
            ws.Column(7).Width = 28.14
            ws.Column(8).Width = 31
            ws.Column(9).Width = 19.86
            ws.Column(10).Width = 28.29
        Else
            ws.Column(2).Width = 30.57
            ws.Column(3).Width = 58.29
            ws.Column(4).Width = 30.43
            ws.Column(5).Width = 43.71
            ws.Column(6).Width = 52
            ws.Column(7).Width = 28.14
            ws.Column(8).Width = 31
        End If

        ws.PageSetup.PagesWide = 1
        ws.PageSetup.PagesTall = False

        ws.PageSetup.PageOrientation = XLPageOrientation.Landscape

        ws.RangeUsed().Style.Border.OutsideBorder = XLBorderStyleValues.Thin
        ws.RangeUsed().Style.Border.InsideBorder = XLBorderStyleValues.Thin

        ws.RangeUsed().Style.Alignment.WrapText = True

        With ws.PageSetup.Margins
            .Top = 0.4
            .Bottom = 0.4
            .Left = 0.4
            .Right = 0.4
        End With

        wb.SaveAs(rutaCompleta)

        If imprimir = 1 Then
            CV_ImprimirExcel(rutaCompleta)
            imprimir = 0
            Exit Sub
        End If

        MessageBox.Show("Archivo guardado en: " & rutaCompleta)

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

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        imprimir = 1
        ExportarExcel()
    End Sub

    Public Sub CV_ImprimirExcel(ruta)
        Dim rutaArchivo As String = ruta

        Dim infoProceso As New ProcessStartInfo()
        With infoProceso
            .FileName = rutaArchivo
            .Verb = "print"
            .CreateNoWindow = True
            .WindowStyle = ProcessWindowStyle.Hidden
            .UseShellExecute = True

        End With

        Try
            Process.Start(infoProceso)
        Catch ex As Exception
            MsgBox("Error al intentar imprimir: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class