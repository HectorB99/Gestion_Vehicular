Imports System.Data.SqlClient
Imports WinFormsApp1.Form_consulta_vehiculo


Public Class Form_compra_piezas
    Dim edicion_activada As Int32
    Public idcompra As Int32 = 0
    Dim constr As New SqlConnection(GlobalConnStrg)
    'Dim constr As New SqlConnection("Data Source=192.168.100.119,1433;Initial Catalog=foliado;User ID=sa;Password=viaroot.viaroot;Encrypt=True;TrustServerCertificate=True;")

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Form_control_vehicular.Show()

        CV_ClearData()
    End Sub

    Private Sub Form_compra_piezas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()


        If idcompra <> 0 Then
            CV_CargarDatosEdicion(idcompra)
        End If
    End Sub

    Public Sub CV_LoadGeneralData()
        Dim consulta_vehiculos As String = "SELECT idvehiculo,claveinterna FROM vehiculos"
        edicion_activada = 0

        dtp_compra.Format = DateTimePickerFormat.Custom
        dtp_compra.CustomFormat = " "

        constr.Open()
        Dim sqlstr As New SqlCommand(consulta_vehiculos, constr)
        Dim reader As SqlDataReader = sqlstr.ExecuteReader()
        cb_vehiculos.Items.Clear()

        While reader.Read()
            Dim item As New ComboBoxItem(reader("claveinterna").ToString(), reader("idvehiculo").ToString())
            cb_vehiculos.Items.Add(item)
        End While
        constr.Close()


        Dim consulta_tipo_piezas As String = "SELECT idtipopieza, descripcion FROM tipo_piezas"

        constr.Open()
        Dim sqlstr2 As New SqlCommand(consulta_tipo_piezas, constr)
        Dim reader2 As SqlDataReader = sqlstr2.ExecuteReader()
        cb_tipo_pieza.Items.Clear()

        While reader2.Read()
            Dim item As New ComboBoxItem(reader2("descripcion").ToString(), reader2("idtipopieza").ToString())
            cb_tipo_pieza.Items.Add(item)
        End While
        constr.Close()

        Dim consulta_proveedores As String = "SELECT idproveedor, nombre FROM proveedores WHERE estatus = 'A'"

        constr.Open()
        Dim sqlstr3 As New SqlCommand(consulta_proveedores, constr)
        Dim reader3 As SqlDataReader = sqlstr3.ExecuteReader()
        cb_proveedores.Items.Clear()

        While reader3.Read()
            Dim item As New ComboBoxItem(reader3("nombre").ToString(), reader3("idproveedor").ToString())
            cb_proveedores.Items.Add(item)
        End While
        constr.Close()
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
        Dim selectedProveedor As ComboBoxItem = CType(cb_proveedores.SelectedItem, ComboBoxItem)
        Dim selectedTipoPieza As ComboBoxItem = CType(cb_tipo_pieza.SelectedItem, ComboBoxItem)
        Dim fechaActual As Date = Now.Date
        Dim idvehiculo As Int32 = 0
        If selectedItem IsNot Nothing Then
            idvehiculo = selectedItem.id
        End If



        Dim sqlstr As New SqlCommand("
            INSERT INTO compra_piezas (
                fecha_compra,
                fecha_captura,
                idvehiculo,
                costo_pieza,
                tipo_pieza,
                marca,
                modelo,
                idproveedor
            ) VALUES (
                @fecha_compra,
                @fecha_captura,
                @idvehiculo,
                @costo_pieza,
                @tipo_pieza,
                @marca,
                @modelo,
                @idproveedor
            )", constr)




        sqlstr.Parameters.Add("@fecha_compra", SqlDbType.Date).Value = dtp_compra.Value
        sqlstr.Parameters.Add("@fecha_captura", SqlDbType.Date).Value = fechaActual
        sqlstr.Parameters.AddWithValue("@idvehiculo", idvehiculo)
        sqlstr.Parameters.AddWithValue("@costo_pieza", SqlDbType.Float).Value = CDbl(txb_costo.Text)
        sqlstr.Parameters.AddWithValue("@tipo_pieza", selectedTipoPieza.id)
        sqlstr.Parameters.AddWithValue("@marca", txb_marca.Text)
        sqlstr.Parameters.AddWithValue("@modelo", txb_modelo.Text)
        sqlstr.Parameters.AddWithValue("@idproveedor", selectedProveedor.id)

        constr.Open()
        sqlstr.ExecuteScalar()
        MsgBox("Se han guardado los datos correctamente")
        constr.Close()
    End Sub

    Public Sub CV_EditarRegistro()
        Dim selectedItem As ComboBoxItem = CType(cb_vehiculos.SelectedItem, ComboBoxItem)
        Dim selectedProveedor As ComboBoxItem = CType(cb_proveedores.SelectedItem, ComboBoxItem)
        Dim selectedTipoPieza As ComboBoxItem = CType(cb_tipo_pieza.SelectedItem, ComboBoxItem)

        Dim sqlstr As New SqlCommand("
            UPDATE compra_piezas
            SET
                idvehiculo = @idvehiculo,
                fecha_compra = @fecha_compra, 
                costo_pieza = @costo_pieza, 
                tipo_pieza = @tipo_pieza, 
                marca = @marca, 
                modelo = @modelo,
                idproveedor = @idproveedor
            WHERE idcompra = @idcompra",
        constr)

        sqlstr.Parameters.AddWithValue("@idcompra", idcompra)
        sqlstr.Parameters.Add("@fecha_compra", SqlDbType.Date).Value = dtp_compra.Value
        sqlstr.Parameters.AddWithValue("@idvehiculo", selectedItem.id)
        sqlstr.Parameters.AddWithValue("@costo_pieza", SqlDbType.Float).Value = CDbl(txb_costo.Text)
        sqlstr.Parameters.AddWithValue("@tipo_pieza", selectedTipoPieza.id)
        sqlstr.Parameters.AddWithValue("@marca", txb_marca.Text)
        sqlstr.Parameters.AddWithValue("@modelo", txb_modelo.Text)
        sqlstr.Parameters.AddWithValue("@idproveedor", selectedProveedor.id)

        constr.Open()
        sqlstr.ExecuteScalar()
        MsgBox("Se han guardado los datos correctamente")
        constr.Close()
    End Sub

    Public Sub CV_ClearData()
        cb_vehiculos.SelectedIndex = -1
        'dtp_compra.CustomFormat = " "
        txb_marca.Clear()
        txb_modelo.Clear()
        cb_tipo_pieza.SelectedIndex = -1
        txb_costo.Clear()
        cb_proveedores.SelectedIndex = -1
    End Sub

    Private Sub dtp_compra_ValueChanged(sender As Object, e As EventArgs) Handles dtp_compra.ValueChanged
        dtp_compra.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        CV_ClearData()
    End Sub

    Public Sub CV_CargarDatosEdicion(idcompra)

        Dim consulta As String = ""
        consulta = "SELECT * FROM compra_piezas WHERE idcompra = '" & idcompra & "';"
        Dim adaptador As New SqlDataAdapter(consulta, constr)
        Dim dt As New DataTable
        adaptador.Fill(dt)


        If dt.Rows.Count > 0 Then
            CV_MostrarDatos(dt)
            'CV_MostrarInputs()
            edicion_activada = 1

        Else
            MessageBox.Show("No se encontraron datos.")
        End If
    End Sub

    Public Sub CV_MostrarDatos(dt As DataTable)
        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            idcompra = row("idcompra")
            Dim idvehiculo As String
            Dim idtipopieza As String
            Dim idproveedor As String

            If Not IsDBNull(row("fecha_compra")) Then
                dtp_compra.CustomFormat = "dd/MM/yyyy"
                dtp_compra.Value = Convert.ToDateTime(row("fecha_compra"))
            Else
                dtp_compra.CustomFormat = " "
            End If

            If Not IsDBNull(row("idvehiculo")) Then
                idvehiculo = row("idvehiculo")

                For Each item As ComboBoxItem In cb_vehiculos.Items
                    If item.id.ToString() = idvehiculo Then
                        cb_vehiculos.SelectedItem = item
                        Exit For
                    End If
                Next
            End If

            If Not IsDBNull(row("tipo_pieza")) Then
                idtipopieza = row("tipo_pieza")

                For Each item As ComboBoxItem In cb_tipo_pieza.Items
                    If item.id.ToString() = idtipopieza Then
                        cb_tipo_pieza.SelectedItem = item
                        Exit For
                    End If
                Next
            End If

            If Not IsDBNull(row("marca")) Then
                txb_marca.Text = row("marca")
            End If

            If Not IsDBNull(row("modelo")) Then
                txb_modelo.Text = row("modelo")
            End If

            If Not IsDBNull(row("idproveedor")) Then
                idproveedor = row("idproveedor")

                For Each item As ComboBoxItem In cb_proveedores.Items
                    If item.id.ToString() = idproveedor Then
                        cb_proveedores.SelectedItem = item
                        Exit For
                    End If
                Next
            End If

            If Not IsDBNull(row("costo_pieza")) Then
                txb_costo.Text = row("costo_pieza")
            End If
        End If
    End Sub
End Class