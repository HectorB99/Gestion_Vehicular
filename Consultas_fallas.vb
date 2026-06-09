Imports System.Data.SqlClient
Imports System.Configuration
Public Class consultas
    'Dim constr As New SqlConnection("Data Source=192.168.100.119,1433;Initial Catalog=foliado;User ID=sa;Password=viaroot.viaroot;")
    'Dim constr As New SqlConnection("Data Source=192.168.100.119,1433;Initial Catalog=foliado;User ID=sa;Password=viaroot.viaroot;Encrypt=True;TrustServerCertificate=True;")
    Dim constr As New SqlConnection("Data Source=192.168.100.3,1433;Initial Catalog=foliado;User ID=sa;Password=Chelo.viaroot1712;Encrypt=True;TrustServerCertificate=True;")
    'Dim constr As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=foliado;Integrated Security=True;")
    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        DataGridView1.DataSource = Nothing
        Me.Hide()
        Formcontrolfallas.Show()
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CerrarAplicacion()
    End Sub

    Private Sub consultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_desde.Hide()
        lbl_hasta.Hide()
        dtp_fechainicial.Hide()
        dtp_fechafinal.Hide()

        dtp_fechainicial.Format = DateTimePickerFormat.Custom
        dtp_fechainicial.CustomFormat = "dd/MM/yyyy"
        dtp_fechafinal.Format = DateTimePickerFormat.Custom
        dtp_fechafinal.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub cb_fecha_CheckedChanged(sender As Object, e As EventArgs) Handles cb_fecha.CheckedChanged
        If cb_fecha.Checked Then
            lbl_desde.Show()
            lbl_hasta.Show()
            dtp_fechainicial.Show()
            dtp_fechafinal.Show()
        Else
            lbl_desde.Hide()
            lbl_hasta.Hide()
            dtp_fechainicial.Hide()
            dtp_fechafinal.Hide()
        End If
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim consulta As String = ""

        If txt_persona.Text = "" And txt_folio.Text = "" And cb_fecha.Checked = False Then
            consulta = "SELECT persona,descripcion,folio,fecha FROM problemas"
        End If
        If txt_persona.Text <> "" And txt_folio.Text = "" And cb_fecha.Checked = False Then
            consulta = "SELECT persona,descripcion,folio,fecha FROM problemas WHERE persona LIKE '%' + '" & txt_persona.Text & "' + '%';"
        End If

        If txt_folio.Text <> "" Then
            consulta = "SELECT persona,descripcion,folio,fecha FROM problemas WHERE folio = '" & txt_folio.Text & "';"
        End If


        If cb_fecha.Checked = False Then
            Dim adaptador As New SqlDataAdapter(consulta, constr)
            Dim dt As New DataTable
            adaptador.Fill(dt)
            DataGridView1.DataSource = dt
        Else

            constr.Open()
            Dim sqlstr As SqlCommand = Nothing

            If txt_persona.Text <> "" And txt_folio.Text = "" Then
                sqlstr = New SqlCommand("SELECT persona,descripcion,folio,fecha FROM problemas WHERE persona LIKE '%' + @persona + '%' AND fecha BETWEEN @fecha1 AND @fecha2", constr)
                sqlstr.Parameters.AddWithValue("@persona", txt_persona.Text)
                sqlstr.Parameters.Add("@fecha1", SqlDbType.Date).Value = dtp_fechainicial.Value
                sqlstr.Parameters.Add("@fecha2", SqlDbType.Date).Value = dtp_fechafinal.Value
            ElseIf txt_persona.Text = "" And txt_folio.Text = "" Then
                sqlstr = New SqlCommand("SELECT persona,descripcion,folio,fecha FROM problemas WHERE fecha BETWEEN @fecha1 AND @fecha2", constr)
                sqlstr.Parameters.Add("@fecha1", SqlDbType.Date).Value = dtp_fechainicial.Value
                sqlstr.Parameters.Add("@fecha2", SqlDbType.Date).Value = dtp_fechafinal.Value
            ElseIf txt_folio.Text <> "" Then
                Dim folio As Integer = Convert.ToInt32(txt_folio.Text)
                sqlstr = New SqlCommand("SELECT persona,descripcion,folio,fecha FROM problemas WHERE folio = @folio", constr)
                sqlstr.Parameters.AddWithValue("@folio", folio)
            End If


            If sqlstr IsNot Nothing Then
                Dim dt As New DataTable()
                Using da As New SqlDataAdapter(sqlstr)
                    da.Fill(dt)
                End Using
                DataGridView1.DataSource = dt
            End If

        End If

        constr.Close()
        txt_persona.Clear()
        txt_folio.Clear()
        dtp_fechafinal.Value = DateTime.Now
        dtp_fechainicial.Value = DateTime.Now
    End Sub
End Class