Imports System.Data.SqlClient
Imports WinFormsApp1.Form_consulta_vehiculo

Public Class Form_registro_servicios
    Public edicion_activada As Int32 = 0
    Public idservicio As Int32
    Public total_servicio As Double = 0
    Dim constr As New SqlConnection(GlobalConnStrg)
    'Dim constr As New SqlConnection("Data Source=192.168.100.119,1433;Initial Catalog=foliado;User ID=sa;Password=viaroot.viaroot;Encrypt=True;TrustServerCertificate=True;")
    Private Sub Form_registro_servicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim consulta_vehiculos As String = "SELECT idvehiculo,claveinterna FROM vehiculos"
        'Dim edicion_activada As Int32

        dtp_entrada.Format = DateTimePickerFormat.Custom
        dtp_entrada.CustomFormat = " "
        dtp_salida.Format = DateTimePickerFormat.Custom
        dtp_salida.CustomFormat = " "
        dtp_programada.Format = DateTimePickerFormat.Custom
        dtp_programada.CustomFormat = " "

        tb_telefono_taller.MaxLength = 10
        tb_tel_mecanico.MaxLength = 10

        constr.Open()
        Dim sqlstr As New SqlCommand(consulta_vehiculos, constr)
        Dim reader As SqlDataReader = sqlstr.ExecuteReader()
        cb_vehiculos.Items.Clear()

        While reader.Read()
            Dim item As New ComboBoxItem(reader("claveinterna").ToString(), reader("idvehiculo").ToString())
            cb_vehiculos.Items.Add(item)
        End While
        constr.Close()

        'If idservicio <> 0 Then
        'CV_CargarDatosEdicion(idservicio)
        'End If

    End Sub

    Private Sub dtp_entrada_ValueChanged(sender As Object, e As EventArgs) Handles dtp_entrada.ValueChanged
        dtp_entrada.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtp_salida_ValueChanged(sender As Object, e As EventArgs) Handles dtp_salida.ValueChanged
        dtp_salida.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtp_programaad_ValueChanged(sender As Object, e As EventArgs) Handles dtp_programada.ValueChanged
        dtp_programada.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If edicion_activada = 0 Then
            CV_GuardarConsulta()
        ElseIf edicion_activada = 1 Then
            CV_EditarRegistro()
        End If

        CV_ClearData()
    End Sub

    Public Sub CV_GuardarConsulta()
        Dim selectedItem As ComboBoxItem = CType(cb_vehiculos.SelectedItem, ComboBoxItem)
        Dim fechaActual As Date = Now.Date

        Dim sqlstr As New SqlCommand("
            INSERT INTO servicios (
                idvehiculo,
                fecha_captura,
                fecha_programada,
                fecha_entrada,
                fecha_salida,
                tipo_servicio,
                costo_servicio,
                taller,
                direccion_taller,
                tel_taller,
                mecanico_nombre,
                tel_mecanico
            ) VALUES (
                @idvehiculo,
                @fecha_captura,
                @fecha_programada,
                @fecha_entrada,
                @fecha_salida,
                @tipo_servicio,
                @costo_servicio,
                @taller,
                @direccion_taller,
                @tel_taller,
                @mecanico_nombre,
                @tel_mecanico
            )
            SELECT SCOPE_IDENTITY();", constr)

        sqlstr.Parameters.AddWithValue("@idvehiculo", selectedItem.id)
        sqlstr.Parameters.Add("@fecha_captura", SqlDbType.Date).Value = fechaActual
        sqlstr.Parameters.Add("@fecha_programada", SqlDbType.Date).Value = dtp_programada.Value
        sqlstr.Parameters.Add("@fecha_entrada", SqlDbType.Date).Value = dtp_entrada.Value
        sqlstr.Parameters.Add("@fecha_salida", SqlDbType.Date).Value = dtp_salida.Value
        sqlstr.Parameters.AddWithValue("@tipo_servicio", tb_tipo_servicio.Text)
        sqlstr.Parameters.AddWithValue("@costo_servicio", SqlDbType.Float).Value = CDbl(tb_costo.Text)
        sqlstr.Parameters.AddWithValue("@taller", tb_taller.Text)
        sqlstr.Parameters.AddWithValue("@direccion_taller", tb_direccion_taller.Text)
        sqlstr.Parameters.AddWithValue("@tel_taller", tb_telefono_taller.Text)
        sqlstr.Parameters.AddWithValue("@mecanico_nombre", tb_nombre_mecanico.Text)
        sqlstr.Parameters.AddWithValue("@tel_mecanico", tb_tel_mecanico.Text)

        constr.Open()
        idservicio = Convert.ToInt32(sqlstr.ExecuteScalar())
        MsgBox("Se han guardado los datos correctamente")
        constr.Close()

        If idservicio <> 0 Then
            CV_GuardarDetallesServicio(idservicio)
        End If

    End Sub

    Public Sub CV_GuardarDetallesServicio(idservicio)
        Dim dt As New DataTable()

        dt.Columns.Add("cantidad", GetType(Integer))
        dt.Columns.Add("unidad", GetType(String))
        dt.Columns.Add("pieza", GetType(String))
        dt.Columns.Add("costo", GetType(Decimal))
        dt.Columns.Add("costo_total", GetType(Decimal))
        dt.Columns.Add("operacion", GetType(String))

        dt.Columns.Add("idservicio", GetType(Integer))

        For Each dgRow As DataGridViewRow In DataGridView1.Rows
            If Not dgRow.IsNewRow Then
                dt.Rows.Add(
                    dgRow.Cells("cantidad").Value,
                    dgRow.Cells("unidad").Value,
                    dgRow.Cells("pieza").Value,
                    dgRow.Cells("costo").Value,
                    dgRow.Cells("costo_total").Value,
                    dgRow.Cells("operacion").Value,
                    idservicio
                )
            End If
        Next

        constr.Open()
        Using bulkCopy As New SqlBulkCopy(constr)
            bulkCopy.DestinationTableName = "detalles_servicio"

            bulkCopy.ColumnMappings.Add("idservicio", "idservicio")
            bulkCopy.ColumnMappings.Add("cantidad", "cant_piezas")
            bulkCopy.ColumnMappings.Add("unidad", "unidad_pieza")
            bulkCopy.ColumnMappings.Add("pieza", "pieza")
            bulkCopy.ColumnMappings.Add("costo", "costo_unitario")
            bulkCopy.ColumnMappings.Add("costo_total", "costo_total")
            bulkCopy.ColumnMappings.Add("operacion", "descripcion")
            bulkCopy.WriteToServer(dt)
        End Using
        constr.Close()


        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
    End Sub

    Public Sub CV_EditarRegistro()
        MessageBox.Show("Actualizando registro de servicio")
        Dim selectedItem As ComboBoxItem = CType(cb_vehiculos.SelectedItem, ComboBoxItem)
        Dim sqlstr As New SqlCommand("
            UPDATE servicios
            SET
                idvehiculo = @idvehiculo,
                fecha_programada = @fecha_programada,
                fecha_entrada = @fecha_entrada,
                fecha_salida = @fecha_salida,
                tipo_servicio = @tipo_servicio,
                costo_servicio = @costo_servicio,
                taller = @taller,
                direccion_taller = @direccion_taller,
                tel_taller = @tel_taller,
                mecanico_nombre = @mecanico_nombre,
                tel_mecanico = @tel_mecanico
            WHERE idservicio = @idservicio",
        constr)

        sqlstr.Parameters.AddWithValue("@idservicio", idservicio)
        sqlstr.Parameters.AddWithValue("@idvehiculo", selectedItem.id)
        sqlstr.Parameters.Add("@fecha_programada", SqlDbType.Date).Value = dtp_programada.Value
        sqlstr.Parameters.Add("@fecha_entrada", SqlDbType.Date).Value = dtp_entrada.Value
        sqlstr.Parameters.Add("@fecha_salida", SqlDbType.Date).Value = dtp_salida.Value
        sqlstr.Parameters.AddWithValue("@tipo_servicio", tb_tipo_servicio.Text)
        sqlstr.Parameters.AddWithValue("@costo_servicio", SqlDbType.Float).Value = CDbl(tb_costo.Text)
        sqlstr.Parameters.AddWithValue("@taller", tb_taller.Text)
        sqlstr.Parameters.AddWithValue("@direccion_taller", tb_direccion_taller.Text)
        sqlstr.Parameters.AddWithValue("@tel_taller", tb_telefono_taller.Text)
        sqlstr.Parameters.AddWithValue("@mecanico_nombre", tb_nombre_mecanico.Text)
        sqlstr.Parameters.AddWithValue("@tel_mecanico", tb_tel_mecanico.Text)

        constr.Open()
        sqlstr.ExecuteScalar()
        MsgBox("Se han actualizado los datos correctamente")
        constr.Close()


        CV_EditarDetallesServicio()
        edicion_activada = 0
    End Sub

    Public Sub CV_EditarDetallesServicio()

        constr.Open()
        For Each dgRow As DataGridViewRow In DataGridView1.Rows

            If Not dgRow.IsNewRow Then

                Dim sqlstr As New SqlCommand("
                    UPDATE detalles_servicio
                    SET
                        cant_piezas = @cantidad,
                        unidad_pieza = @unidad,
                        pieza = @pieza,
                        costo_unitario = @costo,
                        costo_total = @costo_total,
                        descripcion = @operacion,
                        idservicio = @idservicio
                    WHERE iddetalle = @iddetalle
                ", constr)

                sqlstr.Parameters.AddWithValue("@cantidad", dgRow.Cells("cantidad").Value)
                sqlstr.Parameters.AddWithValue("@unidad", dgRow.Cells("unidad").Value)
                sqlstr.Parameters.AddWithValue("@pieza", dgRow.Cells("pieza").Value)
                sqlstr.Parameters.AddWithValue("@costo", dgRow.Cells("costo").Value)
                sqlstr.Parameters.AddWithValue("@costo_total", dgRow.Cells("costo_total").Value)
                sqlstr.Parameters.AddWithValue("@operacion", dgRow.Cells("operacion").Value)
                sqlstr.Parameters.AddWithValue("@iddetalle", dgRow.Cells("iddetalle").Value)
                sqlstr.Parameters.AddWithValue("@idservicio", idservicio)

                sqlstr.ExecuteNonQuery()

            End If

        Next

        constr.Close()

        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()

    End Sub

    Public Sub CV_ClearData()
        cb_vehiculos.SelectedIndex = -1
        dtp_programada.CustomFormat = " "
        dtp_entrada.CustomFormat = " "
        dtp_salida.CustomFormat = " "
        tb_tipo_servicio.Clear()
        tb_costo.Clear()
        tb_taller.Clear()
        tb_direccion_taller.Clear()
        tb_telefono_taller.Clear()
        tb_nombre_mecanico.Clear()
        tb_tel_mecanico.Clear()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        CV_ClearData()
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        edicion_activada = 0
        Hide()
        CV_ClearData()
        Form_control_vehicular.Show()
    End Sub

    Private Sub btn_reporte_Click(sender As Object, e As EventArgs) Handles btn_reporte.Click
        edicion_activada = 0
        Hide()
        CV_ClearData()
        Form_reporte_controlvehicular.Show()
    End Sub

    Public Sub CV_CargarDatosEdicion()

        Dim consulta As String = ""
        consulta = "SELECT * FROM servicios WHERE idservicio = '" & idservicio & "';"
        Dim adaptador As New SqlDataAdapter(consulta, constr)
        Dim dt As New DataTable
        adaptador.Fill(dt)

        If dt.Rows.Count > 0 Then
            edicion_activada = 1
            CV_MostrarDatos(dt)
        Else
            MessageBox.Show("No se encontraron datos.")
        End If
    End Sub

    Public Sub CV_MostrarDatos(dt)
        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            idservicio = row("idservicio")
            Dim idvehiculo As String
            Dim estatus As String
            total_servicio = row("costo_servicio")

            If Not IsDBNull(row("idvehiculo")) Then
                idvehiculo = row("idvehiculo")

                For Each item As ComboBoxItem In cb_vehiculos.Items
                    If item.id.ToString() = idvehiculo Then
                        cb_vehiculos.SelectedItem = item
                        Exit For
                    End If
                Next
            End If

            If Not IsDBNull(row("fecha_entrada")) Then
                dtp_entrada.CustomFormat = "dd/MM/yyyy"
                dtp_entrada.Value = Convert.ToDateTime(row("fecha_entrada"))
            Else
                dtp_entrada.CustomFormat = " "
            End If

            If Not IsDBNull(row("fecha_salida")) Then
                dtp_salida.CustomFormat = "dd/MM/yyyy"
                dtp_salida.Value = Convert.ToDateTime(row("fecha_salida"))
            Else
                dtp_salida.CustomFormat = " "
            End If

            If Not IsDBNull(row("fecha_programada")) Then
                dtp_programada.CustomFormat = "dd/MM/yyyy"
                dtp_programada.Value = Convert.ToDateTime(row("fecha_programada"))
            Else
                dtp_programada.CustomFormat = " "
            End If

            If Not IsDBNull(row("tipo_servicio")) Then
                tb_tipo_servicio.Text = row("tipo_servicio")
            End If

            If Not IsDBNull(row("costo_servicio")) Then
                tb_costo.Text = row("costo_servicio")
            End If

            If Not IsDBNull(row("taller")) Then
                tb_taller.Text = row("taller")
            End If

            If Not IsDBNull(row("direccion_taller")) Then
                tb_direccion_taller.Text = row("direccion_taller")
            End If

            If Not IsDBNull(row("tel_taller")) Then
                tb_telefono_taller.Text = row("tel_taller")
            End If

            If Not IsDBNull(row("mecanico_nombre")) Then
                tb_nombre_mecanico.Text = row("mecanico_nombre")
            End If

            If Not IsDBNull(row("tel_mecanico")) Then
                tb_tel_mecanico.Text = row("tel_mecanico")
            End If

            If Not IsDBNull(row("estatus")) Then
                estatus = row("estatus")

                If estatus = "C" Then
                    rb_concluido.Checked = True
                ElseIf estatus = "P" Then
                    rb_programado.Checked = True
                ElseIf estatus = "EC" Then
                    rb_curso.Checked = True
                End If
            End If


        End If

        CV_ConsultaDetallesServicio(idservicio)
    End Sub

    Public Sub CV_ConsultaDetallesServicio(idservicio)
        Dim consulta As String = ""
        consulta = "SELECT * FROM detalles_servicio WHERE idservicio = '" & idservicio & "';"
        Dim adaptador As New SqlDataAdapter(consulta, constr)
        Dim dt As New DataTable
        adaptador.Fill(dt)

        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                DataGridView1.Rows.Add(row("cant_piezas").ToString(), row("unidad_pieza").ToString(), row("pieza").ToString(), row("costo_unitario"), row("costo_total"), row("descripcion").ToString(), row("iddetalle"))
            Next
        End If
    End Sub

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click
        Form_detalles_servicio.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            Dim respuesta As DialogResult

            respuesta = MessageBox.Show(
                "¿Desea editar esta fila?",
                "Confirmar edición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

            If respuesta = DialogResult.Yes Then

                Form_detalles_servicio.action = 1
                Form_detalles_servicio.rowIndex = e.RowIndex
                Form_detalles_servicio.Show()
                Form_detalles_servicio.CV_CargarDatos(fila)
            End If
        End If
    End Sub
End Class