Imports System.Data.SqlClient
Public Class Formproveedores
    Public edicion_activada As Int32 = 0
    Dim id_proveedor As Int32
    'Dim rowindex As Int32
    Dim constr As New SqlConnection(GlobalConnStrg)
    Private Sub Formproveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_telefono.MaxLength = 10

        Me.CenterToScreen()
        CV_LoadDGVData()

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
                'rowindex = e.RowIndex

                id_proveedor = fila.Cells("idproveedor").Value
                txt_nombre.Text = fila.Cells("nombre_proveedor").Value
                txt_telefono.Text = fila.Cells("telefono").Value
                txt_correo.Text = fila.Cells("email").Value
                txt_direccion.Text = fila.Cells("direccion").Value
                txt_ciudad.Text = fila.Cells("ciudad").Value
                txt_estado.Text = fila.Cells("estado").Value
                txt_pais.Text = fila.Cells("pais").Value
                txt_rfc.Text = fila.Cells("rfc").Value

                If fila.Cells("estatus").Value = "Activo" Then
                    rb_activo.Checked = True
                Else
                    rb_baja.Checked = True
                End If
            End If
        End If
    End Sub

    Public Sub CV_LoadDGVData()
        DataGridView1.Rows.Clear()

        Dim contula_proveedores As String = "SELECT * FROM proveedores"
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

                DataGridView1.Rows.Add(row("idproveedor"), row("nombre").ToString(), row("num_telefono").ToString(), row("email").ToString(), row("direccion").ToString(), row("ciudad").ToString(), row("estado").ToString(), row("pais").ToString(), row("RFC").ToString(), estatus)
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

    Public Sub CV_ClearInputs()
        txt_nombre.Clear()
        txt_nombre.Focus()
        txt_telefono.Clear()
        txt_correo.Clear()
        txt_direccion.Clear()
        txt_ciudad.Clear()
        txt_estado.Clear()
        txt_pais.Clear()
        txt_rfc.Clear()
        rb_activo.Checked = False
        rb_baja.Checked = False
    End Sub

    Public Sub CV_GuardarDatos()
        Dim sqlstr As New SqlCommand("
            INSERT INTO proveedores (
                nombre,
                num_telefono,
                email,
                direccion,
                ciudad,
                estado,
                pais,
                RFC,
                estatus
            ) VALUES (
                @nombre,
                @num_telefono,
                @email,
                @direccion,
                @ciudad,
                @estado,
                @pais,
                @rfc,
                @estatus
            )", constr)

        Dim estatus As String
        If rb_activo.Checked = True Then
            estatus = "A"
        ElseIf rb_baja.Checked = True Then
            estatus = "B"
        End If

        sqlstr.Parameters.AddWithValue("@nombre", txt_nombre.Text)
        sqlstr.Parameters.AddWithValue("@num_telefono", txt_telefono.Text)
        sqlstr.Parameters.AddWithValue("@email", txt_correo.Text)
        sqlstr.Parameters.AddWithValue("@direccion", txt_direccion.Text)
        sqlstr.Parameters.AddWithValue("@ciudad", txt_ciudad.Text)
        sqlstr.Parameters.AddWithValue("@estado", txt_estado.Text)
        sqlstr.Parameters.AddWithValue("@pais", txt_pais.Text)
        sqlstr.Parameters.AddWithValue("@rfc", txt_rfc.Text)
        sqlstr.Parameters.AddWithValue("@estatus", estatus)


        constr.Open()
        sqlstr.ExecuteScalar()
        MsgBox("Se han guardado los datos correctamente")
        constr.Close()

        CV_ClearInputs()
        CV_LoadDGVData()
    End Sub

    Public Sub CV_EditarDatos()
        Dim sqlstr As New SqlCommand("
            UPDATE proveedores
            SET 
                nombre = @nombre, 
                num_telefono = @num_telefono, 
                email = @email, 
                direccion = @direccion, 
                ciudad = @ciudad, 
                estado = @estado,
                pais = @pais,
                RFC = @rfc,
                estatus = @estatus
            WHERE idproveedor = @idproveedor",
        constr)

        Dim estatus As String

        If rb_activo.Checked = True Then
            estatus = "A"
        ElseIf rb_baja.Checked = True Then
            estatus = "B"
        End If

        sqlstr.Parameters.AddWithValue("@idproveedor", id_proveedor)
        sqlstr.Parameters.AddWithValue("@nombre", txt_nombre.Text)
        sqlstr.Parameters.AddWithValue("@num_telefono", txt_telefono.Text)
        sqlstr.Parameters.AddWithValue("@email", txt_correo.Text)
        sqlstr.Parameters.AddWithValue("@direccion", txt_direccion.Text)
        sqlstr.Parameters.AddWithValue("@ciudad", txt_ciudad.Text)
        sqlstr.Parameters.AddWithValue("@estado", txt_estado.Text)
        sqlstr.Parameters.AddWithValue("@pais", txt_pais.Text)
        sqlstr.Parameters.AddWithValue("@rfc", txt_rfc.Text)
        sqlstr.Parameters.AddWithValue("@estatus", estatus)

        constr.Open()
        sqlstr.ExecuteScalar()
        MsgBox("Se han actualizado los datos correctamente")
        constr.Close()

        CV_ClearInputs()
        CV_LoadDGVData()
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        CV_ClearInputs()
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Hide()
        CV_ClearInputs()
        Form1.Show()
    End Sub
End Class