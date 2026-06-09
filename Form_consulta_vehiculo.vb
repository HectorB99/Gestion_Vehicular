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
        dtp_llantas.Format = DateTimePickerFormat.Custom
        dtp_llantas.CustomFormat = " "
        dtp_prox_llantas.Format = DateTimePickerFormat.Custom
        dtp_prox_llantas.CustomFormat = " "
        dtp_aceite.Format = DateTimePickerFormat.Custom
        dtp_aceite.CustomFormat = " "
        dtp_prox_aceite.Format = DateTimePickerFormat.Custom
        dtp_prox_aceite.CustomFormat = " "
        dtp_vigencia_poliza.Format = DateTimePickerFormat.Custom
        dtp_vigencia_poliza.CustomFormat = " "
        dtp_vigencia_licencia.Format = DateTimePickerFormat.Custom
        dtp_vigencia_licencia.CustomFormat = " "
        dtp_ultima_bateria.Format = DateTimePickerFormat.Custom
        dtp_ultima_bateria.CustomFormat = " "
        dtp_ultimo_taller.Format = DateTimePickerFormat.Custom
        dtp_ultimo_taller.CustomFormat = " "
        dtp_vigencia_tarjeta.Format = DateTimePickerFormat.Custom
        dtp_vigencia_tarjeta.CustomFormat = " "

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


            'If (row("fecha_captura") = Now.Date) Then
            'edicion_activada = 1
            'End If

            If Not IsDBNull(row("fecha_captura")) Then
                dtm_fecha_captura.CustomFormat = "dd/MM/yyyy"
                dtm_fecha_captura.Value = Convert.ToDateTime(row("fecha_captura"))
            Else
                dtm_fecha_captura.CustomFormat = " "
            End If

            If Not IsDBNull(row("fecha_cambio_llanta")) Then
                dtp_llantas.CustomFormat = "dd/MM/yyyy"
                dtp_llantas.Value = Convert.ToDateTime(row("fecha_cambio_llanta"))

            Else
                dtp_llantas.CustomFormat = " "
            End If

            If Not IsDBNull(row("fecha_prox_cambio_llanta")) Then
                dtp_prox_llantas.CustomFormat = "dd/MM/yyyy"
                dtp_prox_llantas.Value = Convert.ToDateTime(row("fecha_prox_cambio_llanta"))
            Else
                dtp_prox_llantas.CustomFormat = " "
            End If

            If Not IsDBNull(row("fecha_cambio_aceite")) Then
                dtp_aceite.CustomFormat = "dd/MM/yyyy"
                dtp_aceite.Value = Convert.ToDateTime(row("fecha_cambio_aceite"))
            Else
                dtp_aceite.CustomFormat = " "
            End If

            If Not IsDBNull(row("fecha_prox_cambio_aceite")) Then
                dtp_prox_aceite.CustomFormat = "dd/MM/yyyy"
                dtp_prox_aceite.Value = Convert.ToDateTime(row("fecha_prox_cambio_aceite"))
            Else
                dtp_prox_aceite.CustomFormat = " "
            End If

            If Not IsDBNull(row("kilometraje_servicio")) Then
                tb_km_ultimo_servicio.Text = row("kilometraje_servicio").ToString()
            End If

            If Not IsDBNull(row("kilometraje_prox_servicio")) Then
                tb_km_prox_servicio.Text = row("kilometraje_prox_servicio").ToString()
            End If

            If Not IsDBNull(row("fecha_vigencia_poliza")) Then
                dtp_vigencia_poliza.CustomFormat = "dd/MM/yyyy"
                dtp_vigencia_poliza.Value = Convert.ToDateTime(row("fecha_vigencia_poliza"))
            Else
                dtp_vigencia_poliza.CustomFormat = " "
            End If

            If Not IsDBNull(row("fecha_vigencia_lic_conductor")) Then
                dtp_vigencia_licencia.CustomFormat = "dd/MM/yyyy"
                dtp_vigencia_licencia.Value = Convert.ToDateTime(row("fecha_vigencia_lic_conductor"))
            Else
                dtp_vigencia_licencia.CustomFormat = " "
            End If

            If Not IsDBNull(row("poliza_seguro")) Then
                txt_poliza.Text = row("poliza_seguro").ToString()
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

            If Not IsDBNull(row("fecha_ultimo_taller")) Then
                dtp_ultimo_taller.CustomFormat = "dd/MM/yyyy"
                dtp_ultimo_taller.Value = Convert.ToDateTime(row("fecha_ultimo_taller"))
            Else
                dtp_ultimo_taller.CustomFormat = " "
            End If

            If Not IsDBNull(row("gas_semanal")) Then
                txt_gas_semanal.Text = row("gas_semanal").ToString()
            End If

            If Not IsDBNull(row("fecha_cambio_bateria")) Then
                dtp_ultima_bateria.CustomFormat = "dd/MM/yyyy"
                dtp_ultima_bateria.Value = Convert.ToDateTime(row("fecha_cambio_bateria"))
            Else
                dtp_ultima_bateria.CustomFormat = " "
            End If

            If Not IsDBNull(row("nombre_chofer")) Then
                txt_nombre_chofer.Text = row("nombre_chofer").ToString()
            End If

            If Not IsDBNull(row("fecha_vigencia_tarjeta_circulacion")) Then
                dtp_vigencia_tarjeta.CustomFormat = "dd/MM/yyyy"
                dtp_vigencia_tarjeta.Value = Convert.ToDateTime(row("fecha_vigencia_tarjeta_circulacion"))
            Else
                dtp_vigencia_tarjeta.CustomFormat = " "
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

            'If Not IsDBNull(row("hora_entrada")) Then
            '    tp_horario_entrada.Value = DateTime.Today.Add(TimeSpan.Parse(row("hora_entrada")))
            'End If

            'If Not IsDBNull(row("hora_salida")) Then
            '    tp_horario_salida.Value = DateTime.Today.Add(TimeSpan.Parse(row("hora_salida")))
            'End If

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
                fecha_cambio_aceite, 
                fecha_prox_cambio_aceite, 
                kilometraje_servicio, 
                kilometraje_prox_servicio,  
                fecha_cambio_llanta, 
                fecha_prox_cambio_llanta,   
                poliza_seguro, 
                fecha_vigencia_poliza, 
                fecha_vigencia_lic_conductor, 
                kilometraje_ant, 
                kilometraje_nue, 
                gas_semanal, 
                rendimiento, 
                fecha_captura, 
                fecha_cambio_bateria, 
                fecha_ultimo_taller, 
                comentarios,
                nombre_chofer,
                fecha_vigencia_tarjeta_circulacion,       
                hora_entrada,
                hora_salida,
                limpieza,
                folio_ticket,
                litros_gasolina,
                precio_gasolina,
                total_gasolina,
                monto_permisos,
                monto_casetas)
            VALUES (
                @idcarro, 
                @cambio_aceite,     
                @prox_aceite, 
                @servicio, 
                @prox_servicio, 
                @llanta, 
                @prox_llanta, 
                @poliza,    
                @vigencia_poliza, 
                @fecha_lic, 
                @kma, 
                @kmn, 
                @gasolina, 
                @rendi, 
                @fecha_hoy, 
                @fecha_bateria, 
                @fecha_taller, 
                @comentario,
                @nombre_chofer,
                @fecha_vigencia_tarjeta_circulacion,       
                @hora_entrada,
                @hora_salida,
                @limpieza,
                @folio_ticket,
                @litros_gasolina,
                @precio_gasolina,
                @total_gasolina,
                @monto_permisos,
                @monto_casetas)", constr)

        sqlstr.Parameters.AddWithValue("@idcarro", selectedItem.id)
        sqlstr.Parameters.Add("@cambio_aceite", SqlDbType.Date).Value = dtp_aceite.Value
        sqlstr.Parameters.Add("@prox_aceite", SqlDbType.Date).Value = dtp_prox_aceite.Value
        sqlstr.Parameters.AddWithValue("@servicio", tb_km_ultimo_servicio.Text)
        sqlstr.Parameters.AddWithValue("@prox_servicio", tb_km_prox_servicio.Text)
        sqlstr.Parameters.Add("@llanta", SqlDbType.Date).Value = dtp_llantas.Value
        sqlstr.Parameters.Add("@prox_llanta", SqlDbType.Date).Value = dtp_prox_llantas.Value
        sqlstr.Parameters.AddWithValue("@poliza", txt_poliza.Text)
        sqlstr.Parameters.Add("@vigencia_poliza", SqlDbType.Date).Value = dtp_vigencia_poliza.Value
        sqlstr.Parameters.Add("@fecha_lic", SqlDbType.Date).Value = dtp_vigencia_licencia.Value
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
        sqlstr.Parameters.Add("@fecha_bateria", SqlDbType.Date).Value = dtp_ultima_bateria.Value
        If dtp_ultimo_taller.Value.Date <> DateTime.Today Then
            sqlstr.Parameters.Add("@fecha_taller", SqlDbType.Date).Value = dtp_ultimo_taller.Value
        Else
            sqlstr.Parameters.Add("@fecha_taller", SqlDbType.Date).Value = DBNull.Value
        End If
        sqlstr.Parameters.AddWithValue("@comentario", txt_comentarios.Text)
        sqlstr.Parameters.AddWithValue("@nombre_chofer", txt_nombre_chofer.Text)
        sqlstr.Parameters.Add("@fecha_vigencia_tarjeta_circulacion", SqlDbType.Date).Value = dtp_vigencia_tarjeta.Value
        sqlstr.Parameters.Add("@hora_entrada", SqlDbType.Time).Value = tp_horario_entrada.Value.TimeOfDay
        sqlstr.Parameters.Add("@hora_salida", SqlDbType.Time).Value = tp_horario_salida.Value.TimeOfDay

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
                fecha_cambio_aceite = @cambio_aceite, 
                fecha_prox_cambio_aceite = @prox_aceite, 
                kilometraje_servicio = @servicio, 
                kilometraje_prox_servicio = @prox_servicio, 
                fecha_cambio_llanta = @llanta, 
                fecha_prox_cambio_llanta = @prox_llanta,   
                poliza_seguro = @poliza, 
                fecha_vigencia_poliza = @vigencia_poliza, 
                fecha_vigencia_lic_conductor = @fecha_lic, 
                kilometraje_ant = @kma,
                kilometraje_nue = @kmn, 
                gas_semanal = @gasolina,
                rendimiento = @rendi, 
                fecha_captura = @fecha_hoy, 
                fecha_cambio_bateria = @fecha_bateria, 
                fecha_ultimo_taller = @fecha_taller, 
                comentarios = @comentario,
                nombre_chofer = @nombre_chofer,
                fecha_vigencia_tarjeta_circulacion = @fecha_vigencia_tarjeta_circulacion,       
                hora_entrada = @hora_entrada,
                hora_salida = @hora_salida,
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
        sqlstr.Parameters.Add("@cambio_aceite", SqlDbType.Date).Value = dtp_aceite.Value
        sqlstr.Parameters.Add("@prox_aceite", SqlDbType.Date).Value = dtp_prox_aceite.Value
        sqlstr.Parameters.AddWithValue("@servicio", tb_km_ultimo_servicio.Text)
        sqlstr.Parameters.AddWithValue("@prox_servicio", tb_km_prox_servicio.Text)
        sqlstr.Parameters.Add("@llanta", SqlDbType.Date).Value = dtp_llantas.Value
        sqlstr.Parameters.Add("@prox_llanta", SqlDbType.Date).Value = dtp_prox_llantas.Value
        sqlstr.Parameters.AddWithValue("@poliza", txt_poliza.Text)
        sqlstr.Parameters.Add("@vigencia_poliza", SqlDbType.Date).Value = dtp_vigencia_poliza.Value
        sqlstr.Parameters.Add("@fecha_lic", SqlDbType.Date).Value = dtp_vigencia_licencia.Value
        sqlstr.Parameters.AddWithValue("@kma", txt_kilometrajea.Text)
        sqlstr.Parameters.AddWithValue("@kmn", txt_kilometrajen.Text)
        'sqlstr.Parameters.AddWithValue("@gasolina", txt_gas_semanal.Text)
        sqlstr.Parameters.AddWithValue("@gasolina", SqlDbType.Float).Value = CDbl(txt_gas_semanal.Text)
        sqlstr.Parameters.AddWithValue("@rendi", txt_rendimiento.Text)
        sqlstr.Parameters.Add("@fecha_hoy", SqlDbType.Date).Value = dtm_fecha_captura.Value
        sqlstr.Parameters.Add("@fecha_bateria", SqlDbType.Date).Value = dtp_ultima_bateria.Value
        If dtp_ultimo_taller.Value.Date <> DateTime.Today Then
            sqlstr.Parameters.Add("@fecha_taller", SqlDbType.Date).Value = dtp_ultimo_taller.Value
        Else
            sqlstr.Parameters.Add("@fecha_taller", SqlDbType.Date).Value = DBNull.Value
        End If
        sqlstr.Parameters.AddWithValue("@comentario", txt_comentarios.Text)
        sqlstr.Parameters.AddWithValue("@nombre_chofer", txt_nombre_chofer.Text)
        sqlstr.Parameters.Add("@fecha_vigencia_tarjeta_circulacion", SqlDbType.Date).Value = dtp_vigencia_tarjeta.Value
        sqlstr.Parameters.Add("@hora_entrada", SqlDbType.Time).Value = tp_horario_entrada.Value.TimeOfDay
        sqlstr.Parameters.Add("@hora_salida", SqlDbType.Time).Value = tp_horario_salida.Value.TimeOfDay

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
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        Label11.Hide()
        Label12.Hide()
        Label13.Hide()
        Label14.Hide()
        Label15.Hide()
        Label16.Hide()
        Label17.Hide()
        Label18.Hide()
        Label19.Hide()
        Label20.Hide()
        Label21.Hide()
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
        dtp_vigencia_tarjeta.Hide()
        tp_horario_entrada.Hide()
        tp_horario_salida.Hide()
        tb_gasolina_lts.Hide()
        tb_costo_gasolina.Hide()
        tb_costo_total.Hide()
        tb_folio_gasolina.Hide()
        tb_monto_permiso.Hide()
        tb_monto_casetas.Hide()
        dtp_llantas.Hide()
        dtp_prox_llantas.Hide()
        dtp_aceite.Hide()
        dtp_prox_aceite.Hide()
        tb_km_prox_servicio.Hide()
        tb_km_ultimo_servicio.Hide()
        txt_poliza.Hide()
        dtp_vigencia_poliza.Hide()
        dtp_vigencia_licencia.Hide()
        txt_kilometrajea.Hide()
        txt_kilometrajen.Hide()
        txt_gas_semanal.Hide()
        txt_rendimiento.Hide()
        dtp_ultima_bateria.Hide()
        dtp_ultimo_taller.Hide()
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
        dtp_llantas.CustomFormat = " "
        dtp_prox_llantas.CustomFormat = " "
        dtp_aceite.CustomFormat = " "
        dtp_prox_aceite.CustomFormat = " "
        dtp_vigencia_poliza.CustomFormat = " "
        dtp_vigencia_licencia.CustomFormat = " "
        dtp_ultima_bateria.CustomFormat = " "
        dtp_ultimo_taller.CustomFormat = " "
        dtp_vigencia_tarjeta.CustomFormat = " "
        tp_horario_entrada.CustomFormat = " "
        tp_horario_salida.CustomFormat = " "
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
        txt_poliza.Clear()
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
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
        Label6.Show()
        Label7.Show()
        Label8.Show()
        Label9.Show()
        Label10.Show()
        Label11.Show()
        Label12.Show()
        Label13.Show()
        Label14.Show()
        Label15.Show()
        Label16.Show()
        Label17.Show()
        Label18.Show()
        Label19.Show()
        Label20.Show()
        Label21.Show()
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
        dtp_vigencia_tarjeta.Show()
        tp_horario_entrada.Show()
        tp_horario_salida.Show()
        tb_gasolina_lts.Show()
        tb_costo_gasolina.Show()
        tb_costo_total.Show()
        tb_folio_gasolina.Show()
        tb_monto_permiso.Show()
        tb_monto_casetas.Show()
        dtp_llantas.Show()
        dtp_prox_llantas.Show()
        dtp_aceite.Show()
        dtp_prox_aceite.Show()
        tb_km_ultimo_servicio.Show()
        tb_km_prox_servicio.Show()
        txt_poliza.Show()
        dtp_vigencia_poliza.Show()
        dtp_vigencia_licencia.Show()
        txt_kilometrajea.Show()
        txt_kilometrajen.Show()
        txt_gas_semanal.Show()
        txt_rendimiento.Show()
        dtp_ultima_bateria.Show()
        dtp_ultimo_taller.Show()
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
    End Sub

    Private Sub dtp_llantas_ValueChanged(sender As Object, e As EventArgs) Handles dtp_llantas.ValueChanged
        dtp_llantas.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtp_prox_llantas_ValueChanged(sender As Object, e As EventArgs) Handles dtp_prox_llantas.ValueChanged
        dtp_prox_llantas.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtp_aceite_ValueChanged(sender As Object, e As EventArgs) Handles dtp_aceite.ValueChanged
        dtp_aceite.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtp_prox_aceite_ValueChanged(sender As Object, e As EventArgs) Handles dtp_prox_aceite.ValueChanged
        dtp_prox_aceite.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtp_vigencia_poliza_ValueChanged(sender As Object, e As EventArgs) Handles dtp_vigencia_poliza.ValueChanged
        dtp_vigencia_poliza.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtp_vigencia_licencia_ValueChanged(sender As Object, e As EventArgs) Handles dtp_vigencia_licencia.ValueChanged
        dtp_vigencia_licencia.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtp_ultima_bateria_ValueChanged(sender As Object, e As EventArgs) Handles dtp_ultima_bateria.ValueChanged
        dtp_ultima_bateria.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtp_ultimo_taller_ValueChanged(sender As Object, e As EventArgs) Handles dtp_ultimo_taller.ValueChanged
        dtp_ultimo_taller.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtp_vigencia_tarjeta_ValueChanged(sender As Object, e As EventArgs) Handles dtp_vigencia_tarjeta.ValueChanged
        dtp_vigencia_tarjeta.CustomFormat = "dd/MM/yyyy"
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