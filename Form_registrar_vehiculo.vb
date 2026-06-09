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
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CV_ClearInputs()
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
                marca,
                linea,
                modelo,
                color,
                placa,
                tipo_motor,
                llantas, 
                tipo_combustible, 
                num_serie,
                estatus)
            VALUES (
                @clave, 
                @marcavechiculo, 
                @lineavehiculo,
                @modelovehiculo, 
                @colorvehiculo, 
                @placavehiculo, 
                @tipomotor, 
                @datosllantas,
                @combustible, 
                @num_serie,
                @estatus)", constr)

        Dim estatus As String
        'Dim selectedItem As ComboBoxItem = CType(cb_tipocombustible.SelectedItem, ComboBoxItem)
        If rb_activo.Checked = True Then
            estatus = "A"
        ElseIf rb_baja.Checked = True Then
            estatus = "B"
        End If


        'combustible = cb_tipocombustible.SelectedItem.ToString()

        sqlstr.Parameters.AddWithValue("@clave", txt_clave.Text)
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
                marca = @marcavechiculo, 
                linea = @lineavehiculo, 
                modelo = @modelovehiculo, 
                color = @colorvehiculo, 
                placa = @placavehiculo,
                tipo_motor = @tipomotor,
                llantas = @datosllantas,
                tipo_combustible = @combustible,
                num_serie = @num_serie,
                estatus = @estatus
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
        DataGridView1.Rows.Clear()
        rb_activo.Checked = False
        rb_baja.Checked = False
        cb_tipocombustible.SelectedIndex = -1
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CerrarAplicacion()
    End Sub

    Public Sub CV_LoadDGVData()
        DataGridView1.Rows.Clear()

        Dim contula_proveedores As String = "SELECT * FROM vehiculos"
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
                DataGridView1.Rows.Add(row("idvehiculo"), row("claveinterna").ToString(), row("marca").ToString(), row("linea").ToString(), row("modelo").ToString(), row("color").ToString(), row("placa").ToString(), row("tipo_motor").ToString(), row("llantas").ToString(), row("tipo_combustible").ToString(), row("num_serie").ToString(), estatus)
            Next
        End If
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
                txt_clave.Text = fila.Cells("clave_interna").Value
                txt_marca.Text = fila.Cells("marca").Value
                txt_linea.Text = fila.Cells("linea").Value
                txt_modelo.Text = fila.Cells("modelo").Value
                txt_color.Text = fila.Cells("color").Value
                txt_placa.Text = fila.Cells("placa").Value
                txt_tipomotor.Text = fila.Cells("tipo_motor").Value
                txt_llantas.Text = fila.Cells("llantas").Value
                txt_numserie.Text = fila.Cells("num_serie").Value

                If Not IsDBNull(fila.Cells("tipo_combustible").Value) Then
                    cb_tipocombustible.SelectedValue = fila.Cells("tipo_combustible").Value.ToString()
                End If

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
End Class