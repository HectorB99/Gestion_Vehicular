Imports System.Data.SqlClient
Imports System.Runtime.Intrinsics.X86
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form_consulta_vehiculo
    'Dim constr As New SqlConnection("Data Source=192.168.100.119,1433;Initial Catalog=foliado;User ID=sa;Password=viaroot.viaroot;")
    'Dim constr As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=foliado;Integrated Security=True;")
    'Dim constr As New SqlConnection("Data Source=192.168.100.119,1433;Initial Catalog=foliado;User ID=sa;Password=viaroot.viaroot;Encrypt=True;TrustServerCertificate=True;")
    Dim constr As New SqlConnection(GlobalConnStrg)
    Dim edicion_activada As Int32
    Dim idcontrol As Int32
    Dim idvehiculo As String

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CerrarAplicacion()
    End Sub

    Private Sub Form_consulta_vehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 206
        Me.Width = 500
        dtm_fecha_captura.Format = DateTimePickerFormat.Custom
        dtm_fecha_captura.CustomFormat = " "

        edicion_activada = 0


        CV_Hide()
        Dim consulta As String = "SELECT idvehiculo,claveinterna FROM vehiculos"

        constr.Open()
        Dim sqlstr As New SqlCommand(consulta, constr)
        Dim reader As SqlDataReader = sqlstr.ExecuteReader()
        cb_vehiculos.Items.Clear()

        While reader.Read()
            Dim item As New ComboBoxItem(reader("claveinterna").ToString(), reader("idvehiculo").ToString())
            cb_vehiculos.Items.Add(item)
        End While
        constr.Close()
        Me.CenterToScreen()
    End Sub

    Public Class ComboBoxItem
        Public Property clave As String
        Public Property id As String
        Public Property Value As Object

        Public Sub New(nombre As String, id As String)
            Me.clave = nombre
            Me.id = id
        End Sub

        Public Overrides Function ToString() As String
            Return clave
        End Function
    End Class

    Public Sub CV_ConsultarVehiculo()
        Dim selectedItem As ComboBoxItem = CType(cb_vehiculos.SelectedItem, ComboBoxItem)

        Dim consulta As String = ""
        consulta = "SELECT TOP 1 * FROM control_vehicular WHERE idvehiculo = '" & selectedItem.id & "' AND fecha_captura = ( SELECT MAX(fecha_captura) FROM control_vehicular WHERE idvehiculo = '" & selectedItem.id & "' ) ORDER BY idcontrol DESC;"
        Dim adaptador As New SqlDataAdapter(consulta, constr)
        Dim dt As New DataTable
        adaptador.Fill(dt)

        If dt.Rows.Count > 0 Then
            CV_MostrarDatos(dt)
            'btn_guardar.PerformClick = CV_EditarDatos()
        Else
            MessageBox.Show("No se encontraron datos.")
        End If
        CV_ConsultarDatosVehiculo(selectedItem.id)
    End Sub

    Public Sub CV_CargarDatosEdicion(idcontrol)

        Dim consulta As String = ""
        consulta = "SELECT * FROM control_vehicular WHERE idcontrol = '" & idcontrol & "';"
        Dim adaptador As New SqlDataAdapter(consulta, constr)
        Dim dt As New DataTable
        adaptador.Fill(dt)

        If dt.Rows.Count > 0 Then
            CV_MostrarDatos(dt)
            CV_MostrarInputs()
            edicion_activada = 1

        Else
            MessageBox.Show("No se encontraron datos.")
        End If
    End Sub

    Public Sub CV_MostrarDatos(dt As DataTable)
        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            idcontrol = row("idcontrol")

            If Not IsDBNull(row("idvehiculo")) Then
                idvehiculo = row("idvehiculo")

                For Each item As ComboBoxItem In cb_vehiculos.Items
                    If item.id.ToString() = idvehiculo Then
                        cb_vehiculos.SelectedItem = item
                        Exit For
                    End If
                Next
            End If

            If Not IsDBNull(row("fecha_captura")) Then
                dtm_fecha_captura.CustomFormat = "dd/MM/yyyy"
                dtm_fecha_captura.Value = Convert.ToDateTime(row("fecha_captura"))
            Else
                dtm_fecha_captura.CustomFormat = " "
            End If

            If Not IsDBNull(row("kilometraje_servicio")) Then
                tb_km_ultimo_servicio.Text = row("kilometraje_servicio").ToString()
            End If

            If Not IsDBNull(row("kilometraje_prox_servicio")) Then
                tb_km_prox_servicio.Text = row("kilometraje_prox_servicio").ToString()
            End If

            If Not IsDBNull(row("kilometraje_ant")) Then
                txt_kilometrajea.Text = row("kilometraje_ant").ToString()
            End If

            If Not IsDBNull(row("kilometraje_nue")) Then
                txt_kilometrajen.Text = row("kilometraje_nue").ToString()
            End If

            If Not IsDBNull(row("comentarios")) Then
                txt_comentarios.Text = row("comentarios").ToString()
            End If

            If Not IsDBNull(row("gas_semanal")) Then
                txt_gas_semanal.Text = row("gas_semanal").ToString()
            End If

            If Not IsDBNull(row("nombre_chofer")) Then
                txt_nombre_chofer.Text = row("nombre_chofer").ToString()
            End If

            If Not IsDBNull(row("rendimiento")) Then
                txt_rendimiento.Text = row("rendimiento").ToString()
            End If

            If Not IsDBNull(row("litros_gasolina")) Then
                tb_gasolina_lts.Text = row("litros_gasolina").ToString()
            End If

            If Not IsDBNull(row("precio_gasolina")) Then
                tb_costo_gasolina.Text = row("precio_gasolina").ToString()
            End If

            If Not IsDBNull(row("total_gasolina")) Then
                tb_costo_total.Text = row("total_gasolina").ToString()
            End If

            If Not IsDBNull(row("folio_ticket")) Then
                tb_folio_gasolina.Text = row("folio_ticket").ToString()
            End If

            If Not IsDBNull(row("monto_permisos")) Then
                tb_monto_permiso.Text = row("monto_permisos").ToString()
            End If

            If Not IsDBNull(row("monto_casetas")) Then
                tb_monto_casetas.Text = row("monto_casetas").ToString()
            End If

            If Not IsDBNull(row("hora_entrada")) Then
                tp_horario_entrada.Value = DateTime.Today.Add(CType(row("hora_entrada"), TimeSpan))
            End If

            If Not IsDBNull(row("limpieza")) Then
                If row("limpieza") = "si" Then
                    cbx_limpieza.Checked = True
                Else
                    cbx_limpieza.Checked = False
                End If
            End If
        End If
    End Sub

    Public Sub CV_ConsultarDatosVehiculo(idvehiculo)
        Dim consulta As String = ""
        consulta = "SELECT * FROM vehiculos WHERE idvehiculo = '" & idvehiculo & "'"
        Dim adaptador As New SqlDataAdapter(consulta, constr)
        Dim dt As New DataTable
        adaptador.Fill(dt)

        Dim row As DataRow = dt.Rows(0)

        lbl_clave_interna.Text = row("claveinterna").ToString()
        lbl_marca.Text = row("marca").ToString()
        lbl_linea.Text = row("linea").ToString()
        lbl_modelo.Text = row("modelo").ToString()
        lbl_color.Text = row("color").ToString()
        lbl_placa.Text = row("placa").ToString()
        lbl_tipo_motor.Text = row("tipo_motor").ToString()
        lbl_llantas.Text = row("llantas").ToString()
        lbl_tipo_combustible.Text = row("tipo_combustible").ToString()
        lbl_num_serie.Text = row("num_serie").ToString()
    End Sub

    Public Sub CV_GuardarConsulta()
        Dim selectedItem As ComboBoxItem = CType(cb_vehiculos.SelectedItem, ComboBoxItem)
        'Dim fechaActual As Date = Now.Date
        Dim sqlstr As New SqlCommand("
            INSERT INTO control_vehicular (
                idvehiculo,
                kilometraje_servicio, 
                kilometraje_prox_servicio,
                kilometraje_ant,
                kilometraje_nue, 
                gas_semanal, 
                rendimiento, 
                fecha_captura, 
                comentarios,
                nombre_chofer,       
                hora_entrada,
                limpieza,
                folio_ticket,
                litros_gasolina,
                precio_gasolina,
                total_gasolina,
                monto_permisos,
                monto_casetas)
            VALUES (
                @idcarro,
                @servicio, 
                @prox_servicio,
                @kma, 
                @kmn, 
                @gasolina, 
                @rendi, 
                @fecha_hoy,
                @comentario,
                @nombre_chofer,      
                @hora_entrada,
                @limpieza,
                @folio_ticket,
                @litros_gasolina,
                @precio_gasolina,
                @total_gasolina,
                @monto_permisos,
                @monto_casetas)", constr)

        sqlstr.Parameters.AddWithValue("@idcarro", selectedItem.id)
        sqlstr.Parameters.AddWithValue("@servicio", tb_km_ultimo_servicio.Text)
        sqlstr.Parameters.AddWithValue("@prox_servicio", tb_km_prox_servicio.Text)
        sqlstr.Parameters.AddWithValue("@kma", txt_kilometrajea.Text)
        sqlstr.Parameters.AddWithValue("@kmn", txt_kilometrajen.Text)
        'sqlstr.Parameters.AddWithValue("@gasolina", txt_gas_semanal.Text)
        If txt_gas_semanal.Text <> "" Then
            sqlstr.Parameters.AddWithValue("@gasolina", SqlDbType.Float).Value = CDbl(txt_gas_semanal.Text)
        Else
            sqlstr.Parameters.AddWithValue("@gasolina", SqlDbType.Float).Value = 0
        End If

        sqlstr.Parameters.AddWithValue("@rendi", txt_rendimiento.Text)
        sqlstr.Parameters.Add("@fecha_hoy", SqlDbType.Date).Value = dtm_fecha_captura.Value
        sqlstr.Parameters.AddWithValue("@comentario", txt_comentarios.Text)
        sqlstr.Parameters.AddWithValue("@nombre_chofer", txt_nombre_chofer.Text)
        sqlstr.Parameters.Add("@hora_entrada", SqlDbType.Time).Value = tp_horario_entrada.Value.TimeOfDay

        Dim limpieza As String
        If cbx_limpieza.Checked Then
            limpieza = "si"
        Else
            limpieza = "no"
        End If

        sqlstr.Parameters.AddWithValue("@limpieza", limpieza)
        sqlstr.Parameters.AddWithValue("@folio_ticket", tb_folio_gasolina.Text)
        'sqlstr.Parameters.AddWithValue("@litros_gasolina", tb_gasolina_lts.Text)
        If tb_gasolina_lts.Text <> "" Then
            sqlstr.Parameters.AddWithValue("@litros_gasolina", SqlDbType.Float).Value = CDbl(tb_gasolina_lts.Text)
        Else
            sqlstr.Parameters.AddWithValue("@litros_gasolina", SqlDbType.Float).Value = 0
        End If
        'sqlstr.Parameters.AddWithValue("@precio_gasolina", tb_costo_gasolina.Text)
        If tb_costo_gasolina.Text <> "" Then
            sqlstr.Parameters.AddWithValue("@precio_gasolina", SqlDbType.Float).Value = CDbl(tb_costo_gasolina.Text)
        Else
            sqlstr.Parameters.AddWithValue("@precio_gasolina", SqlDbType.Float).Value = 0
        End If
        If tb_costo_total.Text <> "" Then
            sqlstr.Parameters.AddWithValue("@total_gasolina", tb_costo_total.Text)
        Else
            sqlstr.Parameters.AddWithValue("@total_gasolina", 0)
        End If
        sqlstr.Parameters.AddWithValue("@monto_permisos", tb_monto_permiso.Text)
        sqlstr.Parameters.AddWithValue("@monto_casetas", tb_monto_casetas.Text)


        constr.Open()
        sqlstr.ExecuteScalar()
        MsgBox("Se han guardado los datos correctamente")
        constr.Close()
    End Sub

    Public Sub CV_EditarRegistro()
        Dim selectedItem As ComboBoxItem = CType(cb_vehiculos.SelectedItem, ComboBoxItem)
        Dim sqlstr As New SqlCommand("
            UPDATE control_vehicular
            SET 
                idvehiculo = @idcarro,
                kilometraje_servicio = @servicio, 
                kilometraje_prox_servicio = @prox_servicio,
                kilometraje_ant = @kma,
                kilometraje_nue = @kmn, 
                gas_semanal = @gasolina,
                rendimiento = @rendi, 
                fecha_captura = @fecha_hoy,
                comentarios = @comentario,
                nombre_chofer = @nombre_chofer,     
                hora_entrada = @hora_entrada,
                limpieza = @limpieza,
                folio_ticket = @folio_ticket,
                litros_gasolina = @litros_gasolina,
                precio_gasolina = @precio_gasolina,
                total_gasolina = @total_gasolina,
                monto_permisos = @monto_permisos,
                monto_casetas = @monto_casetas
            WHERE idcontrol = @idcontrol",
        constr)

        sqlstr.Parameters.AddWithValue("@idcontrol", idcontrol)
        sqlstr.Parameters.AddWithValue("@idcarro", selectedItem.id)
        sqlstr.Parameters.AddWithValue("@servicio", tb_km_ultimo_servicio.Text)
        sqlstr.Parameters.AddWithValue("@prox_servicio", tb_km_prox_servicio.Text)
        sqlstr.Parameters.AddWithValue("@kma", txt_kilometrajea.Text)
        sqlstr.Parameters.AddWithValue("@kmn", txt_kilometrajen.Text)
        'sqlstr.Parameters.AddWithValue("@gasolina", txt_gas_semanal.Text)
        sqlstr.Parameters.AddWithValue("@gasolina", SqlDbType.Float).Value = CDbl(txt_gas_semanal.Text)
        sqlstr.Parameters.AddWithValue("@rendi", txt_rendimiento.Text)
        sqlstr.Parameters.Add("@fecha_hoy", SqlDbType.Date).Value = dtm_fecha_captura.Value
        sqlstr.Parameters.AddWithValue("@comentario", txt_comentarios.Text)
        sqlstr.Parameters.AddWithValue("@nombre_chofer", txt_nombre_chofer.Text)

        sqlstr.Parameters.Add("@hora_entrada", SqlDbType.Time).Value = tp_horario_entrada.Value.TimeOfDay

        Dim limpieza As String
        If cbx_limpieza.Checked Then
            limpieza = "si"
        Else
            limpieza = "no"
        End If

        sqlstr.Parameters.AddWithValue("@limpieza", limpieza)
        sqlstr.Parameters.AddWithValue("@folio_ticket", tb_folio_gasolina.Text)
        'sqlstr.Parameters.AddWithValue("@litros_gasolina", tb_gasolina_lts.Text)
        sqlstr.Parameters.AddWithValue("@litros_gasolina", SqlDbType.Float).Value = CDbl(tb_gasolina_lts.Text)
        'sqlstr.Parameters.AddWithValue("@precio_gasolina", tb_costo_gasolina.Text)
        sqlstr.Parameters.AddWithValue("@precio_gasolina", SqlDbType.Float).Value = CDbl(tb_costo_gasolina.Text)
        sqlstr.Parameters.AddWithValue("@total_gasolina", tb_costo_total.Text)
        sqlstr.Parameters.AddWithValue("@monto_permisos", tb_monto_permiso.Text)
        sqlstr.Parameters.AddWithValue("@monto_casetas", tb_monto_casetas.Text)


        constr.Open()
        sqlstr.ExecuteScalar()
        MsgBox("Registro actualizado correctamente")
        constr.Close()

        edicion_activada = 0
    End Sub

    Public Sub CV_Hide()
        btn_guardar.Hide()
        btn_reporte.Hide()
        btn_fotos.Hide()
        Label6.Hide()
        Label7.Hide()
        Label11.Hide()
        Label12.Hide()
        Label13.Hide()
        Label14.Hide()
        Label15.Hide()
        Label18.Hide()
        Label20.Hide()
        Label22.Hide()
        Label23.Hide()
        Label24.Hide()
        Label25.Hide()
        Label26.Hide()
        Label27.Hide()
        Label28.Hide()
        Label29.Hide()
        Label30.Hide()
        Label31.Hide()
        Label32.Hide()
        Label33.Hide()
        Label34.Hide()
        Label35.Hide()
        Label36.Hide()
        Label37.Hide()
        cbx_limpieza.Hide()
        txt_nombre_chofer.Hide()
        tp_horario_entrada.Hide()
        tb_gasolina_lts.Hide()
        tb_costo_gasolina.Hide()
        tb_costo_total.Hide()
        tb_folio_gasolina.Hide()
        tb_monto_permiso.Hide()
        tb_monto_casetas.Hide()
        tb_km_prox_servicio.Hide()
        tb_km_ultimo_servicio.Hide()
        txt_kilometrajea.Hide()
        txt_kilometrajen.Hide()
        txt_gas_semanal.Hide()
        txt_rendimiento.Hide()
        txt_comentarios.Hide()
        lbl_clave_interna.Hide()
        lbl_marca.Hide()
        lbl_linea.Hide()
        lbl_modelo.Hide()
        lbl_color.Hide()
        lbl_placa.Hide()
        lbl_tipo_motor.Hide()
        lbl_llantas.Hide()
        lbl_tipo_combustible.Hide()
        lbl_num_serie.Hide()
    End Sub
    Public Sub CV_ClearData()

        tp_horario_entrada.CustomFormat = " "
        cbx_limpieza.Checked = False
        txt_nombre_chofer.Clear()
        tb_gasolina_lts.Clear()
        tb_costo_gasolina.Clear()
        tb_costo_total.Clear()
        tb_folio_gasolina.Clear()
        tb_monto_permiso.Clear()
        tb_monto_casetas.Clear()
        tb_km_prox_servicio.Clear()
        tb_km_ultimo_servicio.Clear()
        txt_kilometrajea.Clear()
        txt_kilometrajen.Clear()
        txt_gas_semanal.Clear()
        txt_rendimiento.Clear()
        txt_comentarios.Clear()
        cb_vehiculos.SelectedIndex = -1
        lbl_clave_interna.Text = "_______________"
        lbl_marca.Text = "_______________"
        lbl_linea.Text = "_______________"
        lbl_modelo.Text = "_______________"
        lbl_color.Text = "_______________"
        lbl_placa.Text = "_______________"
        lbl_tipo_motor.Text = "_______________"
        lbl_llantas.Text = "_______________"
        lbl_tipo_combustible.Text = "_______________"
        lbl_num_serie.Text = "_______________"
    End Sub

    Private Sub txt_kilometrajea_TextChanged(sender As Object, e As EventArgs)
        CV_CalcularRendimiento()
    End Sub

    Private Sub txt_kilometrajen_TextChanged(sender As Object, e As EventArgs)
        CV_CalcularRendimiento()
    End Sub

    Private Sub txt_gas_semanal_TextChanged(sender As Object, e As EventArgs)
        CV_CalcularRendimiento()
    End Sub

    Public Sub CV_CalcularRendimiento()
        If txt_kilometrajen.Text <> "" And txt_kilometrajea.Text <> "" And txt_gas_semanal.Text <> "" Then
            Dim kma As Integer = Convert.ToInt32(txt_kilometrajea.Text)
            Dim kmn As Integer = Convert.ToInt32(txt_kilometrajen.Text)
            Dim gasolina As Integer = Convert.ToInt32(txt_gas_semanal.Text)
            Dim rendimiento As Double = (kmn - kma) / gasolina
            rendimiento = Math.Round(rendimiento, 2)

            txt_rendimiento.Text = rendimiento.ToString()
        End If
    End Sub


    Private Sub tb_gasolina_lts_TextChanged(sender As Object, e As EventArgs)
        CV_CalcularTotal()
    End Sub

    Private Sub tb_costo_gasolina_TextChanged(sender As Object, e As EventArgs)
        CV_CalcularTotal()
    End Sub

    Public Sub CV_CalcularTotal()
        If tb_gasolina_lts.Text <> "" And tb_costo_gasolina.Text <> "" Then
            Dim litros As Double = Convert.ToDouble(tb_gasolina_lts.Text)
            Dim precio As Double = Convert.ToDouble(tb_costo_gasolina.Text)
            Dim total As Double = litros * precio

            tb_costo_total.Text = total.ToString()
        End If
    End Sub

    Private Sub btn_consultar_Click_1(sender As Object, e As EventArgs) Handles btn_consultar.Click
        If cb_vehiculos.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un vehículo para la consulta")
            Exit Sub
        End If

        Height = 900
        Width = 1240

        CV_MostrarInputs()
        CV_ConsultarVehiculo()
    End Sub

    Public Sub CV_MostrarInputs()
        btn_guardar.Show()
        btn_reporte.Show()
        btn_fotos.Show()
        Label6.Show()
        Label7.Show()
        Label11.Show()
        Label12.Show()
        Label13.Show()
        Label14.Show()
        Label15.Show()
        Label18.Show()
        Label20.Show()
        Label22.Show()
        Label23.Show()
        Label24.Show()
        Label25.Show()
        Label26.Show()
        Label27.Show()
        Label28.Show()
        Label29.Show()
        Label30.Show()
        Label31.Show()
        Label32.Show()
        Label33.Show()
        Label34.Show()
        Label35.Show()
        Label36.Show()
        Label37.Show()
        cbx_limpieza.Show()
        txt_nombre_chofer.Show()
        tp_horario_entrada.Show()
        tb_gasolina_lts.Show()
        tb_costo_gasolina.Show()
        tb_costo_total.Show()
        tb_folio_gasolina.Show()
        tb_monto_permiso.Show()
        tb_monto_casetas.Show()
        tb_km_ultimo_servicio.Show()
        tb_km_prox_servicio.Show()
        txt_kilometrajea.Show()
        txt_kilometrajen.Show()
        txt_gas_semanal.Show()
        txt_rendimiento.Show()
        txt_comentarios.Show()
        lbl_clave_interna.Show()
        lbl_marca.Show()
        lbl_linea.Show()
        lbl_modelo.Show()
        lbl_color.Show()
        lbl_placa.Show()
        lbl_tipo_motor.Show()
        lbl_llantas.Show()
        lbl_tipo_combustible.Show()
        lbl_num_serie.Show()
    End Sub

    Private Sub btn_volver_Click_1(sender As Object, e As EventArgs) Handles btn_volver.Click
        edicion_activada = 0
        Hide()
        Form_control_vehicular.Show()
        Height = 206
        Width = 482


        CV_Hide()
        CV_ClearData()
    End Sub

    Private Sub btn_guardar_Click_1(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If edicion_activada = 0 Then
            CV_GuardarConsulta()
        ElseIf edicion_activada = 1 Then
            CV_EditarRegistro()
        End If

        CV_ClearData()
    End Sub

    Private Sub btn_reporte_Click_1(sender As Object, e As EventArgs) Handles btn_reporte.Click
        Hide()
        Form_reporte_controlvehicular.Show()
        edicion_activada = 0

        CV_Hide()
        CV_ClearData()
    End Sub

    Private Sub txt_kilometrajen_TextChanged_1(sender As Object, e As EventArgs) Handles txt_kilometrajen.Leave
        Dim km_anterior As Int32
        Dim km_nuevo As Int32
        Dim km_añadido As Int32

        Dim km_prox_servicio As Int32
        Dim km_ultimo_servicio As Int32
        Dim km_prox_servicio_nuevo As Int32 = -1

        If tb_km_prox_servicio.Text <> "" Then
            If txt_kilometrajea.Text <> "" Then
                km_anterior = Int32.Parse(txt_kilometrajea.Text)
            Else
                km_anterior = 0
            End If

            If txt_kilometrajen.Text <> "" Then
                km_nuevo = Int32.Parse(txt_kilometrajen.Text)
            Else
                km_nuevo = 0
            End If

            km_añadido = km_nuevo - km_anterior

            km_prox_servicio = Int32.Parse(tb_km_prox_servicio.Text)
            If km_anterior <> 0 Then
                km_prox_servicio_nuevo = km_prox_servicio - km_añadido
            End If

        Else
            If tb_km_ultimo_servicio.Text <> "" Then
                km_ultimo_servicio = Int32.Parse(tb_km_ultimo_servicio.Text)
                km_prox_servicio_nuevo = 10000 - (km_nuevo - km_ultimo_servicio)
            Else

            End If
        End If


        If km_prox_servicio_nuevo < 0 Then
            tb_km_prox_servicio.Text = "0"
        Else
            tb_km_prox_servicio.Text = km_prox_servicio_nuevo.ToString()
        End If


    End Sub

    Private Sub btn_fotos_Click(sender As Object, e As EventArgs) Handles btn_fotos.Click
        Dim fecha As String = dtm_fecha_captura.Value.ToString("dd_MM_yyyy")


        Form_mostrador_fotos.idcontrol = idcontrol
        Form_mostrador_fotos.idvehiculo = Int32.Parse(idvehiculo)
        Form_mostrador_fotos.fecha = fecha
        Form_mostrador_fotos.Show()
        Form_mostrador_fotos.CV_CargarFotos()
    End Sub
End Class