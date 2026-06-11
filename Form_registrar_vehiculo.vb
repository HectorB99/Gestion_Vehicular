Imports System.Data.SqlClient
Imports System.Runtime.Intrinsics.X86
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports WinFormsApp1.Form_consulta_vehiculo

Public Class Form_registrar_vehiculo
    'Dim constr As New SqlConnection("Data Source=192.168.100.119,1433;Initial Catalog=foliado;User ID=sa;Password=viaroot.viaroot;")
    'Dim constr As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=foliado;Integrated Security=True;")
    'Dim constr As New SqlConnection("Data Source=192.168.100.119,1433;Initial Catalog=foliado;User ID=sa;Password=viaroot.viaroot;Encrypt=True;TrustServerCertificate=True;")
    Dim constr As New SqlConnection(GlobalConnStrg)
    Public edicion_activada As Int32 = 0
    Dim id_vehiculo As Int32

    Private Sub Form_registrar_vehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Dim dt As New DataTable()

        dt.Columns.Add("id", GetType(Integer))
        dt.Columns.Add("descripcion", GetType(String))

        dt.Rows.Add(1, "gasolina")
        dt.Rows.Add(2, "diesel")

        cb_tipocombustible.DataSource = dt
        cb_tipocombustible.DisplayMember = "descripcion"
        cb_tipocombustible.ValueMember = "descripcion"

        cb_tipocombustible.SelectedIndex = -1

        dtp_llantas.Format = DateTimePickerFormat.Custom
        dtp_llantas.CustomFormat = " "
        dtp_ultimo_taller.Format = DateTimePickerFormat.Custom
        dtp_ultimo_taller.CustomFormat = " "
        dtp_vigencia_poliza.Format = DateTimePickerFormat.Custom
        dtp_vigencia_poliza.CustomFormat = " "
        dtp_ultima_bateria.Format = DateTimePickerFormat.Custom
        dtp_ultima_bateria.CustomFormat = " "
        dtp_vigencia_tarjeta.Format = DateTimePickerFormat.Custom
        dtp_vigencia_tarjeta.CustomFormat = " "
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CV_ClearInputs()
        DataGridView1.DataSource = Nothing
        Me.Hide()
        Form_control_vehicular.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If edicion_activada = 0 Then
            CV_GuardarDatos()
        Else
            CV_EditarDatos()
        End If
    End Sub

    Public Sub CV_GuardarDatos()
        Dim sqlstr As New SqlCommand("
            INSERT INTO vehiculos (
                claveinterna,
                num_economico,
                marca,
                linea,
                modelo,
                color,
                placa,
                tipo_motor,
                llantas, 
                tipo_combustible, 
                num_serie,
                estatus,
                fecha_ultimo_cambio_llanta,
                kilometraje_ultimo_cambio_aceite,
                kilometraje_prox_cambio_aceite,
                fecha_ultima_visita_taller,
                kilometraje_ultima_visita_taller,
                poliza_seguro,
                fecha_vigencia_poliza,
                fecha_ultimo_cambio_bateria,
                fecha_vigencia_tarjeta_circulacion)
            VALUES (
                @clave,
                @num_economico,
                @marcavechiculo, 
                @lineavehiculo,
                @modelovehiculo, 
                @colorvehiculo, 
                @placavehiculo, 
                @tipomotor, 
                @datosllantas,
                @combustible, 
                @num_serie,
                @estatus,
                @fecha_ultimo_cambio_llanta,
                @kilometraje_ultimo_cambio_aceite,
                @kilometraje_prox_cambio_aceite,
                @fecha_ultima_visita_taller,
                @kilometraje_ultima_visita_taller,
                @poliza_seguro,
                @fecha_vigencia_poliza,
                @fecha_ultimo_cambio_bateria,
                @fecha_vigencia_tarjeta_circulacion)", constr)

        Dim estatus As String
        'Dim selectedItem As ComboBoxItem = CType(cb_tipocombustible.SelectedItem, ComboBoxItem)
        If rb_activo.Checked = True Then
            estatus = "A"
        ElseIf rb_baja.Checked = True Then
            estatus = "B"
        End If


        'combustible = cb_tipocombustible.SelectedItem.ToString()

        sqlstr.Parameters.AddWithValue("@clave", txt_clave.Text)
        sqlstr.Parameters.AddWithValue("@num_economico", txt_num_economico.Text)
        sqlstr.Parameters.AddWithValue("@marcavechiculo", txt_marca.Text)
        sqlstr.Parameters.AddWithValue("@lineavehiculo", txt_linea.Text)
        sqlstr.Parameters.AddWithValue("@modelovehiculo", Convert.ToInt32(txt_modelo.Text))
        sqlstr.Parameters.AddWithValue("@colorvehiculo", txt_color.Text)
        sqlstr.Parameters.AddWithValue("@placavehiculo", txt_placa.Text)
        sqlstr.Parameters.AddWithValue("@tipomotor", txt_tipomotor.Text)
        sqlstr.Parameters.AddWithValue("@datosllantas", txt_llantas.Text)
        sqlstr.Parameters.AddWithValue("@num_serie", txt_numserie.Text)
        sqlstr.Parameters.AddWithValue("@combustible", cb_tipocombustible.SelectedValue.ToString())
        sqlstr.Parameters.AddWithValue("@estatus", estatus)
        sqlstr.Parameters.Add("@fecha_ultimo_cambio_llanta", SqlDbType.Date).Value = dtp_llantas.Value
        If String.IsNullOrWhiteSpace(txt_km_aceite.Text) Then
            sqlstr.Parameters.AddWithValue("@kilometraje_ultimo_cambio_aceite", DBNull.Value)
        Else
            sqlstr.Parameters.AddWithValue("@kilometraje_ultimo_cambio_aceite", Convert.ToInt32(txt_km_aceite.Text))
        End If

        'sqlstr.Parameters.AddWithValue("@kilometraje_ultimo_cambio_aceite", Convert.ToInt32(txt_km_aceite.Text))

        If String.IsNullOrWhiteSpace(txt_km_prox_aceite.Text) Then
            sqlstr.Parameters.AddWithValue("@kilometraje_prox_cambio_aceite", DBNull.Value)
        Else
            sqlstr.Parameters.AddWithValue("@kilometraje_prox_cambio_aceite", Convert.ToInt32(txt_km_prox_aceite.Text))
        End If
        'sqlstr.Parameters.AddWithValue("@kilometraje_prox_cambio_aceite", Convert.ToInt32(txt_km_prox_aceite.Text))
        sqlstr.Parameters.Add("@fecha_ultima_visita_taller", SqlDbType.Date).Value = dtp_ultimo_taller.Value

        If String.IsNullOrWhiteSpace(txt_km_ultimo_taller.Text) Then
            sqlstr.Parameters.AddWithValue("@kilometraje_ultima_visita_taller", DBNull.Value)
        Else
            sqlstr.Parameters.AddWithValue("@kilometraje_ultima_visita_taller", Convert.ToInt32(txt_km_ultimo_taller.Text))
        End If

        'sqlstr.Parameters.AddWithValue("@kilometraje_ultima_visita_taller", Convert.ToInt32(txt_km_ultimo_taller.Text))
        sqlstr.Parameters.AddWithValue("@poliza_seguro", txt_poliza_seguro.Text)
        sqlstr.Parameters.Add("@fecha_vigencia_poliza", SqlDbType.Date).Value = dtp_vigencia_poliza.Value
        sqlstr.Parameters.Add("@dtp_ultima_bateria", SqlDbType.Date).Value = dtp_ultima_bateria.Value
        sqlstr.Parameters.Add("@fecha_vigencia_tarjeta_circulacion", SqlDbType.Date).Value = dtp_vigencia_tarjeta.Value

        constr.Open()
        sqlstr.ExecuteScalar()
        MsgBox("Vehiculo registrado")
        constr.Close()

        CV_ClearInputs()
        CV_LoadDGVData()
    End Sub

    Public Sub CV_EditarDatos()
        Dim sqlstr As New SqlCommand("
            UPDATE vehiculos
            SET 
                claveinterna = @claveinterna,
                num_economico = @num_economico,
                marca = @marcavechiculo, 
                linea = @lineavehiculo, 
                modelo = @modelovehiculo, 
                color = @colorvehiculo, 
                placa = @placavehiculo,
                tipo_motor = @tipomotor,
                llantas = @datosllantas,
                tipo_combustible = @combustible,
                num_serie = @num_serie,
                estatus = @estatus,
                fecha_ultimo_cambio_llanta = @fecha_ultimo_cambio_llanta,
                kilometraje_ultimo_cambio_aceite = @kilometraje_ultimo_cambio_aceite,
                kilometraje_prox_cambio_aceite = @kilometraje_prox_cambio_aceite,
                fecha_ultima_visita_taller = @fecha_ultima_visita_taller,
                kilometraje_ultima_visita_taller = @kilometraje_ultima_visita_taller,
                poliza_seguro = @poliza_seguro,
                fecha_vigencia_poliza = @fecha_vigencia_poliza,
                fecha_ultimo_cambio_bateria = @fecha_ultimo_cambio_bateria,
                fecha_vigencia_tarjeta_circulacion = @fecha_vigencia_tarjeta_circulacion
            WHERE idvehiculo = @idvehiculo",
        constr)

        Dim modelo As Integer = Convert.ToInt32(txt_modelo.Text)
        Dim combustible As String
        combustible = cb_tipocombustible.SelectedValue
        Dim estatus As String

        If rb_activo.Checked = True Then
            estatus = "A"
        ElseIf rb_baja.Checked = True Then
            estatus = "B"
        End If

        sqlstr.Parameters.AddWithValue("@idvehiculo", id_vehiculo)
        sqlstr.Parameters.AddWithValue("@claveinterna", txt_clave.Text)
        sqlstr.Parameters.AddWithValue("@num_economico", txt_num_economico.Text)
        sqlstr.Parameters.AddWithValue("@marcavechiculo", txt_marca.Text)
        sqlstr.Parameters.AddWithValue("@lineavehiculo", txt_linea.Text)
        sqlstr.Parameters.AddWithValue("@modelovehiculo", modelo)
        sqlstr.Parameters.AddWithValue("@colorvehiculo", txt_color.Text)
        sqlstr.Parameters.AddWithValue("@placavehiculo", txt_placa.Text)
        sqlstr.Parameters.AddWithValue("@tipomotor", txt_tipomotor.Text)
        sqlstr.Parameters.AddWithValue("@datosllantas", txt_llantas.Text)
        sqlstr.Parameters.AddWithValue("@num_serie", txt_numserie.Text)
        sqlstr.Parameters.AddWithValue("@combustible", combustible)
        sqlstr.Parameters.AddWithValue("@estatus", estatus)

        If dtp_llantas.CustomFormat = " " Then
            sqlstr.Parameters.AddWithValue("@fecha_ultimo_cambio_llanta", DBNull.Value)
        Else
            sqlstr.Parameters.Add("@fecha_ultimo_cambio_llanta", SqlDbType.Date).Value = dtp_llantas.Value
        End If

        If String.IsNullOrWhiteSpace(txt_km_aceite.Text) Then
            sqlstr.Parameters.AddWithValue("@kilometraje_ultimo_cambio_aceite", DBNull.Value)
        Else
            sqlstr.Parameters.AddWithValue("@kilometraje_ultimo_cambio_aceite", Convert.ToInt32(txt_km_aceite.Text))
        End If

        'sqlstr.Parameters.AddWithValue("@kilometraje_ultimo_cambio_aceite", Convert.ToInt32(txt_km_aceite.Text))

        If String.IsNullOrWhiteSpace(txt_km_prox_aceite.Text) Then
            sqlstr.Parameters.AddWithValue("@kilometraje_prox_cambio_aceite", DBNull.Value)
        Else
            sqlstr.Parameters.AddWithValue("@kilometraje_prox_cambio_aceite", Convert.ToInt32(txt_km_prox_aceite.Text))
        End If
        'sqlstr.Parameters.AddWithValue("@kilometraje_prox_cambio_aceite", Convert.ToInt32(txt_km_prox_aceite.Text))
        'sqlstr.Parameters.Add("@fecha_ultima_visita_taller", SqlDbType.Date).Value = dtp_ultimo_taller.Value

        If dtp_ultimo_taller.CustomFormat = " " Then
            sqlstr.Parameters.AddWithValue("@fecha_ultima_visita_taller", DBNull.Value)
        Else
            sqlstr.Parameters.Add("@fecha_ultima_visita_taller", SqlDbType.Date).Value = dtp_ultimo_taller.Value
        End If

        If String.IsNullOrWhiteSpace(txt_km_ultimo_taller.Text) Then
            sqlstr.Parameters.AddWithValue("@kilometraje_ultima_visita_taller", DBNull.Value)
        Else
            sqlstr.Parameters.AddWithValue("@kilometraje_ultima_visita_taller", Convert.ToInt32(txt_km_ultimo_taller.Text))
        End If

        'sqlstr.Parameters.AddWithValue("@kilometraje_ultima_visita_taller", Convert.ToInt32(txt_km_ultimo_taller.Text))
        sqlstr.Parameters.AddWithValue("@poliza_seguro", txt_poliza_seguro.Text)

        If String.IsNullOrWhiteSpace(dtp_vigencia_poliza.Text) Then
            sqlstr.Parameters.AddWithValue("@fecha_vigencia_poliza", DBNull.Value)
        Else
            sqlstr.Parameters.Add("@fecha_vigencia_poliza", SqlDbType.Date).Value = dtp_vigencia_poliza.Value
        End If

        'sqlstr.Parameters.Add("@fecha_vigencia_poliza", SqlDbType.Date).Value = dtp_vigencia_poliza.Value

        If String.IsNullOrWhiteSpace(dtp_vigencia_poliza.Text) Then
            sqlstr.Parameters.AddWithValue("@fecha_ultimo_cambio_bateria", DBNull.Value)
        Else
            sqlstr.Parameters.Add("@fecha_ultimo_cambio_bateria", SqlDbType.Date).Value = dtp_ultima_bateria.Value
        End If

        'sqlstr.Parameters.Add("@fecha_ultimo_cambio_bateria", SqlDbType.Date).Value = dtp_ultima_bateria.Value

        If String.IsNullOrWhiteSpace(dtp_vigencia_tarjeta.Text) Then
            sqlstr.Parameters.AddWithValue("@fecha_vigencia_tarjeta_circulacion", DBNull.Value)
        Else
            sqlstr.Parameters.Add("@fecha_vigencia_tarjeta_circulacion", SqlDbType.Date).Value = dtp_vigencia_tarjeta.Value
        End If

        'sqlstr.Parameters.Add("@fecha_vigencia_tarjeta_circulacion", SqlDbType.Date).Value = dtp_vigencia_tarjeta.Value

        constr.Open()
        sqlstr.ExecuteScalar()
        MsgBox("Se han actualizado los datos correctamente")
        constr.Close()

        edicion_activada = 0

        CV_ClearInputs()
        CV_LoadDGVData()
    End Sub

    Public Sub CV_ClearInputs()
        txt_clave.Clear()
        txt_marca.Clear()
        txt_linea.Clear()
        txt_modelo.Clear()
        txt_color.Clear()
        txt_placa.Clear()
        txt_tipomotor.Clear()
        txt_llantas.Clear()
        txt_numserie.Clear()
        txt_km_aceite.Clear()
        txt_km_prox_aceite.Clear()
        txt_km_ultimo_taller.Clear()
        txt_poliza_seguro.Clear()
        txt_num_economico.Clear()
        dtp_llantas.CustomFormat = " "
        dtp_ultimo_taller.CustomFormat = " "
        dtp_vigencia_poliza.CustomFormat = " "
        dtp_ultima_bateria.CustomFormat = " "
        dtp_vigencia_tarjeta.CustomFormat = " "
        'DataGridView1.Rows.Clear()
        'DataGridView1.DataSource = Nothing
        rb_activo.Checked = False
        rb_baja.Checked = False
        cb_tipocombustible.SelectedIndex = -1
        edicion_activada = 0
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CerrarAplicacion()
    End Sub

    Public Sub CV_LoadDGVData()
        DataGridView1.DataSource = Nothing

        constr.Open()
        Dim sqlstr As SqlCommand = Nothing
        Dim consulta As String
        consulta = "SELECT * FROM vehiculos"
        sqlstr = New SqlCommand(consulta, constr)

        If sqlstr IsNot Nothing Then
            Dim dt As New DataTable()
            Using da As New SqlDataAdapter(sqlstr)
                da.Fill(dt)
            End Using
            DataGridView1.DataSource = dt
        End If

        DataGridView1.Columns("idvehiculo").Visible = False
        DataGridView1.Columns("claveinterna").HeaderText = "Clave Interna"
        DataGridView1.Columns("marca").HeaderText = "Marca"
        DataGridView1.Columns("linea").HeaderText = "Línea"
        DataGridView1.Columns("modelo").HeaderText = "Modelo"
        DataGridView1.Columns("color").HeaderText = "Color"
        DataGridView1.Columns("placa").HeaderText = "Placa"
        DataGridView1.Columns("tipo_motor").HeaderText = "Tipo de Motor"
        DataGridView1.Columns("llantas").HeaderText = "Llantas"
        DataGridView1.Columns("tipo_combustible").HeaderText = "Tipo de Combustible"
        DataGridView1.Columns("num_serie").HeaderText = "Num. de Serie"
        DataGridView1.Columns("fecha_ultimo_cambio_llanta").HeaderText = "Fecha de Ultimo cambio de llanta"
        DataGridView1.Columns("kilometraje_ultimo_cambio_aceite").HeaderText = "Kilometraje de Ultimo Cambio de Aceite"
        DataGridView1.Columns("kilometraje_prox_cambio_aceite").HeaderText = "Kilometraje Para el Prox. Cambio de Aceite"
        DataGridView1.Columns("fecha_ultima_visita_taller").HeaderText = "Fecha de Ultima Visita al Taller"
        DataGridView1.Columns("kilometraje_ultima_visita_taller").HeaderText = "Kilometraje de Ultima Visita al Taller"
        DataGridView1.Columns("poliza_seguro").HeaderText = "Poliza de Seguro"
        DataGridView1.Columns("fecha_vigencia_poliza").HeaderText = "Fecha de Vigencia de Poliza"
        DataGridView1.Columns("fecha_ultimo_cambio_bateria").HeaderText = "Fecha de Ultimo Cambio de Batería"
        DataGridView1.Columns("fecha_vigencia_tarjeta_circulacion").HeaderText = "Fecha de Vigencia de Tarjeta de Circulación"
        DataGridView1.Columns("estatus").HeaderText = "Estatus"
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        constr.Close()
        'Dim contula_proveedores As String = "SELECT * FROM vehiculos"
        'Dim adaptador As New SqlDataAdapter(contula_proveedores, constr)
        'Dim dt As New DataTable
        'adaptador.Fill(dt)
        'Dim estatus As String

        'If dt.Rows.Count > 0 Then
        '    For Each row As DataRow In dt.Rows
        '        If row("estatus") = "A" Then
        '            estatus = "Activo"
        '        Else
        '            estatus = "Inactivo"
        '        End If
        '        DataGridView1.Rows.Add(row("idvehiculo"), row("claveinterna").ToString(), row("marca").ToString(), row("linea").ToString(), row("modelo").ToString(), row("color").ToString(), row("placa").ToString(), row("tipo_motor").ToString(), row("llantas").ToString(), row("tipo_combustible").ToString(), row("num_serie").ToString(), estatus)
        '    Next
        'End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim tipocombustible As String

            Dim respuesta As DialogResult

            respuesta = MessageBox.Show(
                "¿Desea editar esta fila?",
                "Confirmar edición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

            If respuesta = DialogResult.Yes Then
                edicion_activada = 1

                id_vehiculo = fila.Cells("idvehiculo").Value
                txt_clave.Text = fila.Cells(1).Value
                If Not IsDBNull(fila.Cells(2).Value) Then
                    txt_num_economico.Text = fila.Cells(2).Value
                Else
                    txt_num_economico.Text = ""
                End If
                txt_marca.Text = fila.Cells("marca").Value
                txt_linea.Text = fila.Cells("linea").Value
                txt_modelo.Text = fila.Cells("modelo").Value
                txt_color.Text = fila.Cells("color").Value
                txt_placa.Text = fila.Cells("placa").Value
                txt_tipomotor.Text = fila.Cells("tipo_motor").Value
                txt_llantas.Text = fila.Cells("llantas").Value

                If Not IsDBNull(fila.Cells(11).Value) Then
                    txt_numserie.Text = fila.Cells(11).Value
                Else
                    txt_numserie.Text = ""
                End If


                If Not IsDBNull(fila.Cells(10).Value) Then
                    cb_tipocombustible.SelectedValue = fila.Cells(10).Value.ToString()
                End If

                If fila.Cells(12).Value = "A" Then
                    rb_activo.Checked = True
                Else
                    rb_baja.Checked = True
                End If

                If Not IsDBNull(fila.Cells(13).Value) Then
                    dtp_llantas.CustomFormat = "dd/MM/yyyy"
                    dtp_llantas.Value = Convert.ToDateTime(fila.Cells(13).Value)
                Else
                    dtp_llantas.CustomFormat = " "
                End If

                If Not IsDBNull(fila.Cells(14).Value) Then
                    txt_km_aceite.Text = fila.Cells(14).Value
                Else
                    txt_km_aceite.Text = ""
                End If

                If Not IsDBNull(fila.Cells(15).Value) Then
                    txt_km_prox_aceite.Text = fila.Cells(15).Value
                Else
                    txt_km_prox_aceite.Text = ""
                End If


                If Not IsDBNull(fila.Cells(16).Value) Then
                    dtp_ultimo_taller.CustomFormat = "dd/MM/yyyy"
                    dtp_ultimo_taller.Value = Convert.ToDateTime(fila.Cells(16).Value)
                Else
                    dtp_ultimo_taller.CustomFormat = " "
                End If

                If Not IsDBNull(fila.Cells(17).Value) Then
                    txt_km_ultimo_taller.Text = fila.Cells(17).Value
                Else
                    txt_km_ultimo_taller.Text = ""
                End If

                If Not IsDBNull(fila.Cells(18).Value) Then
                    txt_poliza_seguro.Text = fila.Cells(18).Value
                Else
                    txt_poliza_seguro.Text = ""
                End If



                If Not IsDBNull(fila.Cells(19).Value) Then
                    dtp_vigencia_poliza.CustomFormat = "dd/MM/yyyy"
                    dtp_vigencia_poliza.Value = Convert.ToDateTime(fila.Cells(19).Value)
                Else
                    dtp_vigencia_poliza.CustomFormat = " "
                End If


                If Not IsDBNull(fila.Cells(20).Value) Then
                    dtp_ultima_bateria.CustomFormat = "dd/MM/yyyy"
                    dtp_ultima_bateria.Value = Convert.ToDateTime(fila.Cells(20).Value)
                Else
                    dtp_ultima_bateria.CustomFormat = " "
                End If

                If Not IsDBNull(fila.Cells(21).Value) Then
                    dtp_vigencia_tarjeta.CustomFormat = "dd/MM/yyyy"
                    dtp_vigencia_tarjeta.Value = Convert.ToDateTime(fila.Cells(21).Value)
                Else
                    dtp_vigencia_tarjeta.CustomFormat = " "
                End If
            End If
        End If
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        CV_ClearInputs()
    End Sub

    Private Sub dtp_llantas_ValueChanged(sender As Object, e As EventArgs) Handles dtp_llantas.ValueChanged
        dtp_llantas.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtp_ultimo_taller_ValueChanged(sender As Object, e As EventArgs) Handles dtp_ultimo_taller.ValueChanged
        dtp_ultimo_taller.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtp_vigencia_poliza_ValueChanged(sender As Object, e As EventArgs) Handles dtp_vigencia_poliza.ValueChanged
        dtp_vigencia_poliza.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtp_ultima_bateria_ValueChanged(sender As Object, e As EventArgs) Handles dtp_ultima_bateria.ValueChanged
        dtp_ultima_bateria.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtp_vigencia_tarjeta_ValueChanged(sender As Object, e As EventArgs) Handles dtp_vigencia_tarjeta.ValueChanged
        dtp_vigencia_tarjeta.CustomFormat = "dd/MM/yyyy"
    End Sub
End Class