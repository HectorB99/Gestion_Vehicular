Imports Microsoft.Data.SqlClient
Imports System.Net.Security
Imports System.Security.Cryptography
Imports System.Configuration
Imports System.Text
Imports System.IO
Imports Windows.Win32.System
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form_login
    'Dim constr As New SqlConnection("Data Source=DESKTOP-463V5VN\SQLEXPRESS;Initial Catalog=foliado;Integrated Security=True")
    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        login()
    End Sub

    Private Sub login()
        'Dim connectionString As String = "Data Source=DESKTOP-463V5VN\SQLEXPRESS;Initial Catalog=foliado;Trusted_Connection=True;Column Encryption Setting=Enabled;TrustServerCertificate=True;"
        'Dim connectionString As String = "Data Source=192.168.100.119,1433;Initial Catalog=foliado;Integrated Security=SSPI;Column Encryption Setting=Enabled;TrustServerCertificate=True;"
        'Dim connectionString As String = ConfigurationManager.ConnectionStrings("conection").ConnectionString
        Dim connectionString As String = GlobalConnStrg

        Dim contra As String = txt_contraseña.Text
        Dim nombre As String = txt_usuario.Text
        Dim query As String = "EXECUTE login_usuarios '" + nombre + "'"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)

            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                reader.Read()

                Dim dbContra As String = reader("contraseña").ToString()
                Dim dbNombre As String = reader("nombre").ToString()

                If dbContra = contra And dbNombre = nombre Then
                    Me.Hide()
                    Form1.Show()
                    Form1.CV_NotificacionServiciosVehiculos()

                    txt_contraseña.Clear()
                    txt_usuario.Clear()
                Else
                    MessageBox.Show("Nombre o contraseña incorrectos")
                End If

            Else
                MessageBox.Show("No se encontraron datos")
            End If

            reader.Close()
            connection.Close()
        End Using
    End Sub
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub Form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_contraseña.PasswordChar = "*"c
        Form_sucursal.Show()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cb_contraseña.CheckedChanged
        If cb_contraseña.Checked Then
            txt_contraseña.PasswordChar = ControlChars.NullChar
        Else
            txt_contraseña.PasswordChar = "*"c
        End If
    End Sub

    Private Sub txt_contraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_contraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub
End Class