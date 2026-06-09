Imports System.Data.SqlClient
Public Class registro
    'Dim constr As New SqlConnection("Data Source=192.168.100.119,1433;Initial Catalog=foliado;User ID=sa;Password=viaroot.viaroot;")
    'Dim constr As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=foliado;Integrated Security=True;")
    'Dim constr As New SqlConnection("Data Source=192.168.100.119,1433;Initial Catalog=foliado;User ID=sa;Password=viaroot.viaroot;Encrypt=True;TrustServerCertificate=True;")
    Dim constr As New SqlConnection(GlobalConnStrg)
    Private Sub registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlstr As New SqlCommand("SELECT MAX(folio) FROM problemas", constr)

        constr.Open()
        Dim folio As Object = sqlstr.ExecuteScalar()

        If folio IsNot DBNull.Value Then
            Dim foliovalue As Integer = Convert.ToInt32(folio)
            foliovalue += 1
            Dim foliostr As String = ""

            If (foliovalue < 10) Then
                foliostr = "00000" & foliovalue.ToString()
                txtfolio.Text = foliostr
            ElseIf (foliovalue >= 10 And foliovalue < 100) Then
                foliostr = "0000" & foliovalue.ToString()
                txtfolio.Text = foliostr
            ElseIf (foliovalue >= 100 And foliovalue < 1000) Then
                foliostr = "000" & foliovalue.ToString()
                txtfolio.Text = foliostr
            ElseIf (foliovalue >= 1000 And foliovalue < 10000) Then
                foliostr = "00" & foliovalue.ToString()
                txtfolio.Text = foliostr
            ElseIf (foliovalue >= 10000 And foliovalue < 100000) Then
                foliostr = "0" & foliovalue.ToString()
                txtfolio.Text = foliostr
            ElseIf (foliovalue >= 100000) Then
                foliostr = "0" & foliovalue.ToString()
                txtfolio.Text = foliostr
            End If
        Else
            MessageBox.Show("No se encontraron registros")
        End If

        constr.Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CerrarAplicacion()
    End Sub

    Public Sub llenar_grid()
        'Dim sqlstr As New SqlCommand("SELECT persona,descripcion,folio FROM problemas", constr)
        'Dim consulta As String = "SELECT persona,descripcion,folio FROM problemas"
        'Dim adaptador As New SqlDataAdapter(consulta, constr)
        'Dim dt As New DataTable
        'adaptador.Fill(dt)
        'DataGridView1.DataSource = dt
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim folio As Integer = Convert.ToInt32(txtfolio.Text)
        Dim fechaActual As Date = DateTime.Now

        Dim sqlstr As New SqlCommand("INSERT INTO problemas (persona, descripcion, folio, fecha) VALUES (@persona, @descripcion, @folio, @fecha)", constr)

        sqlstr.Parameters.AddWithValue("@persona", txt_persona.Text)
        sqlstr.Parameters.AddWithValue("@descripcion", txt_descripcion.Text)
        sqlstr.Parameters.AddWithValue("@folio", folio)
        sqlstr.Parameters.Add("@fecha", SqlDbType.Date).Value = fechaActual

        constr.Open()
        sqlstr.ExecuteScalar()
        MsgBox("Se han guardado los datos correctamente")
        constr.Close()


        Call registro_Load(Me, New EventArgs())
        txt_persona.Clear()
        txt_descripcion.Clear()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        Formcontrolfallas.Show()
    End Sub
End Class
