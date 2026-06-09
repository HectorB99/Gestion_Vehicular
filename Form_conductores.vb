Imports System.Data.SqlClient

Public Class Form_conductores
    Dim constr As New SqlConnection(GlobalConnStrg)
    Public edicion_activada As Int32 = 0
    Dim id_conductor As Int32
    Private Sub Form_conductores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_vigencia_licencia.Format = DateTimePickerFormat.Short

        Me.CenterToScreen()
        CV_CargarDatos()
    End Sub

    Public Sub CV_CargarDatos()
        DataGridView1.Rows.Clear()

        Dim contula_proveedores As String = "SELECT * FROM conductores"
        Dim adaptador As New SqlDataAdapter(contula_proveedores, constr)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        Dim estatus As String

        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                If row("estatus") = "A" Then
                    estatus = "Activo"
                Else
                    estatus = "Inactivo"
                End If
                DataGridView1.Rows.Add(row("idconductor"), row("nombre_conductor").ToString(), row("apellidos_conductor").ToString(), row("CURP").ToString(), row("RFC").ToString(), row("area_trabajo").ToString(), row("fecha_vigencia_licencia").ToString(), row("estatus").ToString())
            Next
        End If
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If edicion_activada = 0 Then
            CV_GuardarDatos()
        Else
            CV_EditarDatos()
        End If
    End Sub

    Public Sub CV_GuardarDatos()
        Dim sqlstr As New SqlCommand("
            INSERT INTO conductores (
                nombre_conductor,
                apellidos_conductor, 
                CURP, 
                RFC, 
                fecha_vigencia_licencia, 
                area_trabajo, 
                estatus) 
            VALUES (
                @nombre_conductor, 
                @apellidos_conductor,
                @curp, 
                @rfc, 
                @fecha_vigencia_licencia, 
                @area_trabajo,
                @estatus)", constr)

        Dim estatus As String

        If rb_activo.Checked = True Then
            estatus = "A"
        ElseIf rb_baja.Checked = True Then
            estatus = "B"
        End If


        sqlstr.Parameters.AddWithValue("@nombre_conductor", txt_nombres.Text)
        sqlstr.Parameters.AddWithValue("@apellidos_conductor", txt_apellidos.Text)
        sqlstr.Parameters.AddWithValue("@curp", txt_curp.Text)
        sqlstr.Parameters.AddWithValue("@rfc", txt_rfc.Text)
        sqlstr.Parameters.Add("@fecha_vigencia_licencia", SqlDbType.Date).Value = dtp_vigencia_licencia.Value
        sqlstr.Parameters.AddWithValue("@area_trabajo", txt_area_trabajo.Text)
        sqlstr.Parameters.AddWithValue("@estatus", estatus)


        constr.Open()
        sqlstr.ExecuteScalar()
        MsgBox("Conductor registrado correctamente")
        constr.Close()

        CV_ClearInputs()
        CV_CargarDatos()
    End Sub

    Public Sub CV_EditarDatos()
        Dim sqlstr As New SqlCommand("
            UPDATE conductores
            SET 
                nombre_conductor = @nombre_conductor, 
                apellidos_conductor = @apellidos_conductor, 
                CURP = @curp, 
                RFC = @rfc, 
                fecha_vigencia_licencia = @fecha_vigencia_licencia, 
                area_trabajo = @area_trabajo,
                estatus = @estatus
            WHERE idconductor = @idconductor",
        constr)
        Dim estatus As String

        If rb_activo.Checked = True Then
            estatus = "A"
        ElseIf rb_baja.Checked = True Then
            estatus = "B"
        End If

        sqlstr.Parameters.AddWithValue("@idconductor", id_conductor)
        sqlstr.Parameters.AddWithValue("@nombre_conductor", txt_nombres.Text)
        sqlstr.Parameters.AddWithValue("@apellidos_conductor", txt_apellidos.Text)
        sqlstr.Parameters.AddWithValue("@curp", txt_curp.Text)
        sqlstr.Parameters.AddWithValue("@rfc", txt_rfc.Text)
        sqlstr.Parameters.Add("@fecha_vigencia_licencia", SqlDbType.Date).Value = dtp_vigencia_licencia.Value
        sqlstr.Parameters.AddWithValue("@area_trabajo", txt_area_trabajo.Text)
        sqlstr.Parameters.AddWithValue("@estatus", estatus)

        constr.Open()
        sqlstr.ExecuteScalar()
        MsgBox("Se han actualizado los datos correctamente")
        constr.Close()

        edicion_activada = 0

        CV_ClearInputs()
        CV_CargarDatos()
    End Sub

    Public Sub CV_ClearInputs()
        txt_nombres.Clear()
        txt_apellidos.Clear()
        txt_curp.Clear()
        txt_rfc.Clear()
        txt_area_trabajo.Clear()
        dtp_vigencia_licencia.CustomFormat = " "
        dtp_vigencia_licencia.Value = Date.Now
        rb_activo.Checked = False
        rb_baja.Checked = False
        edicion_activada = 0
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
                edicion_activada = 1

                id_conductor = fila.Cells("idconductor").Value
                txt_nombres.Text = fila.Cells("nombre").Value
                txt_apellidos.Text = fila.Cells("apellidos").Value
                txt_curp.Text = fila.Cells("curp").Value
                txt_curp.Text = fila.Cells("rfc").Value
                txt_area_trabajo.Text = fila.Cells("area_trabajo").Value

                dtp_vigencia_licencia.CustomFormat = "dd/MM/yyyy"
                dtp_vigencia_licencia.Value = Convert.ToDateTime(fila.Cells("fecha_vigencia_licencia").Value)


                If fila.Cells("estatus").Value = "Activo" Then
                    rb_activo.Checked = True
                Else
                    rb_baja.Checked = True
                End If

            End If
        End If
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        CV_ClearInputs()
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class