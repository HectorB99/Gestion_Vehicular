Imports System.Data.SqlClient
Public Class Form_tipo_refaccion
    Public edicion_activada As Int32 = 0
    Dim constr As New SqlConnection(GlobalConnStrg)
    Dim id_tipo_pieza As Int32
    Private Sub Form_tipo_refaccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        CV_LoadDGVData()
    End Sub

    Public Sub CV_LoadDGVData()
        DataGridView1.Rows.Clear()

        Dim contula_proveedores As String = "SELECT * FROM tipo_piezas"
        Dim adaptador As New SqlDataAdapter(contula_proveedores, constr)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        Dim estatus As String

        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                If row("estatus") = "A" Then
                    estatus = "Habilitado"
                Else
                    estatus = "Deshabilitado"
                End If

                DataGridView1.Rows.Add(row("idtipopieza"), row("descripcion"), estatus)
            Next
        End If
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Hide()
        Form1.Show()
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

                id_tipo_pieza = fila.Cells("idtipopieza").Value
                txt_descripcion.Text = fila.Cells("descripcion").Value
                If fila.Cells("estatus").Value = "Habilitado" Then
                    rb_habilitado.Checked = True
                Else
                    rb_deshabilitado.Checked = True
                End If
            End If
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
        Dim estatus As String

        Dim sqlstr As New SqlCommand("
            INSERT INTO tipo_piezas (
                descripcion,
                estatus,
            ) VALUES (
                @descripcion,
                @estatus
            )", constr)

        sqlstr.Parameters.AddWithValue("@nombre", txt_descripcion.Text)

        If rb_habilitado.Checked = True Then
            estatus = "A"
        ElseIf rb_deshabilitado.Checked = True Then
            estatus = "D"
        End If

        sqlstr.Parameters.AddWithValue("@estatus", estatus)


        constr.Open()
        sqlstr.ExecuteScalar()
        MsgBox("Se han guardado los datos correctamente")
        constr.Close()

        CV_ClearInputs()
        CV_LoadDGVData()
    End Sub

    Public Sub CV_EditarDatos()
        Dim estatus As String

        Dim sqlstr As New SqlCommand("
            UPDATE tipo_piezas
            SET 
                descripcion = @descripcion, 
                estatus = @estatus
            WHERE idtipopieza = @idtipopieza",
        constr)

        sqlstr.Parameters.AddWithValue("@idtipopieza", id_tipo_pieza)
        sqlstr.Parameters.AddWithValue("@descripcion", txt_descripcion.Text)
        If rb_habilitado.Checked = True Then
            estatus = "A"
        ElseIf rb_deshabilitado.Checked = True Then
            estatus = "D"
        End If

        sqlstr.Parameters.AddWithValue("@estatus", estatus)

        constr.Open()
        sqlstr.ExecuteScalar()
        MsgBox("Se han actualizado los datos correctamente")
        constr.Close()

        CV_ClearInputs()
        CV_LoadDGVData()
        edicion_activada = 0
    End Sub

    Public Sub CV_ClearInputs()
        txt_descripcion.Clear()
        rb_habilitado.Checked = False
        rb_deshabilitado.Checked = False

    End Sub
End Class