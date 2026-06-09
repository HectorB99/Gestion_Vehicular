Imports WinFormsApp1.Form_consulta_vehiculo

Public Class Form_sucursal
    Private Sub Form_sucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable()

        dt.Columns.Add("id", GetType(Integer))
        dt.Columns.Add("descripcion", GetType(String))

        dt.Rows.Add(1, "Los Mochis")
        dt.Rows.Add(2, "Navojoa")

        cb_sucursal.DataSource = dt
        cb_sucursal.DisplayMember = "descripcion"
        cb_sucursal.ValueMember = "id"

        Me.CenterToScreen()
        Me.TopMost = True
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click

        If cb_sucursal.SelectedValue = 1 Then
            GlobalConnStrg = "Data Source=192.168.100.3,1433;Initial Catalog=foliado;User ID=sa;Password=Chelo.viaroot1712;Encrypt=True;TrustServerCertificate=True;"
        Else
            GlobalConnStrg = "Data Source=192.168.100.3,1433;Initial Catalog=CVNavojoa;User ID=sa;Password=Chelo.viaroot1712;Encrypt=True;TrustServerCertificate=True;"
        End If

        Me.Hide()
    End Sub
End Class