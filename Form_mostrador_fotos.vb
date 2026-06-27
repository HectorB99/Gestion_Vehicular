Imports System.Data.SqlClient
Imports System.IO
Imports DocumentFormat.OpenXml.Drawing
Imports DocumentFormat.OpenXml.Drawing.Diagrams

Public Class Form_mostrador_fotos
    Public idcontrol As Int32
    Public idvehiculo As Int32
    Public fecha As String
    Dim images() As Bitmap
    Dim pos As Int32 = 0
    Dim constr As New SqlConnection(GlobalConnStrg)
    Private Sub btn_subir_foto_Click(sender As Object, e As EventArgs) Handles btn_subir_foto.Click
        Using openFileDialog As New OpenFileDialog()

            openFileDialog.InitialDirectory = "\\mochisconc\Control Vehicular\Fotos de Bitacora Vehicular"
            'openFileDialog.InitialDirectory = "C:\Control Vehicular\Fotos de Bitacora Vehicular"
            openFileDialog.Title = "Seleccione una foto"
            openFileDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|All Files (*.*)|*.*"
            openFileDialog.FilterIndex = 2
            openFileDialog.Multiselect = True
            openFileDialog.RestoreDirectory = True


            If openFileDialog.ShowDialog() = DialogResult.OK Then

                For Each filePath As String In openFileDialog.FileNames
                    CV_GuardarFoto(filePath)
                Next

                CV_CargarFotos()

            End If
        End Using
    End Sub

    Public Sub CV_GuardarFoto(filePath As String)
        Dim claveinterna As String
        'Dim fecha As String = Date.Now.ToString("dd_MM_yyyy")
        Dim ruta = "\\mochisconc\Control Vehicular\Fotos de Bitacora Vehicular\" & fecha
        'Dim ruta = "C:\Control Vehicular\Fotos de Bitacora Vehicular\" & fecha

        Dim separacion() As String = filePath.Split("\")
        Dim ultimo As Int32 = separacion.Length()
        Dim nombre_archivo = separacion(ultimo - 1)


        Dim consulta As New SqlCommand("
            SELECT claveinterna FROM vehiculos WHERE idvehiculo = @idvehiculo", constr)

        consulta.Parameters.AddWithValue("@idvehiculo", idvehiculo)

        constr.Open()
        claveinterna = consulta.ExecuteScalar()
        constr.Close()


        If Directory.Exists(ruta) Then
            ruta = ruta & "\" & claveinterna

            If Directory.Exists(ruta) Then
                ruta = ruta & "\" & nombre_archivo

                If File.Exists(ruta) Then

                Else
                    My.Computer.FileSystem.CopyFile(
                    filePath,
                    ruta)
                End If

            Else
                System.IO.Directory.CreateDirectory(ruta)
                ruta = ruta & "\" & nombre_archivo

                My.Computer.FileSystem.CopyFile(
                    filePath,
                    ruta)
            End If

        Else
            System.IO.Directory.CreateDirectory(ruta)
            ruta = ruta & "\" & claveinterna
            System.IO.Directory.CreateDirectory(ruta)

            ruta = ruta & "\" & nombre_archivo

            My.Computer.FileSystem.CopyFile(
                filePath,
                ruta)
        End If


        Dim sqlstr As New SqlCommand("
            INSERT INTO fotos_bitacora (
                idcontrol, 
                idvehiculo, 
                ruta_foto)
            VALUES (
                @idcontrol,
                @idvehiculo,     
                @ruta_foto)", constr)

        sqlstr.Parameters.AddWithValue("@idcontrol", idcontrol)
        sqlstr.Parameters.AddWithValue("@idvehiculo", idvehiculo)
        sqlstr.Parameters.AddWithValue("@ruta_foto", ruta)

        constr.Open()
        sqlstr.ExecuteScalar()
        constr.Close()


    End Sub

    Public Sub CV_CargarFotos()

        Dim consulta As String = ""
        consulta = "SELECT * FROM fotos_bitacora WHERE idcontrol = '" & idcontrol & "' AND idvehiculo = '" & idvehiculo & "';"
        Dim adaptador As New SqlDataAdapter(consulta, constr)
        Dim dt As New DataTable
        adaptador.Fill(dt)

        If dt.Rows.Count > 0 Then

            ReDim images(dt.Rows.Count - 1)

            Dim index As Integer = 0

            For Each row As DataRow In dt.Rows

                Dim ruta As String = row("ruta_foto").ToString()

                If IO.File.Exists(ruta) Then
                    images(index) = New Bitmap(ruta)
                    index += 1
                End If

            Next


            If images.Length > 0 Then
                PictureBox1.Image = images(0)
                pos = 0
            End If


        Else
            MessageBox.Show("Error al mostrar las fotos. No se encontro ninguna foto registrada")
        End If
    End Sub

    Private Sub btn_siguiente_Click(sender As Object, e As EventArgs) Handles btn_siguiente.Click
        pos += 1

        If pos <= images.Length - 1 Then
            PictureBox1.Image = images(pos)
        Else
            pos = images.Length
        End If

    End Sub

    Private Sub btn_anterior_Click(sender As Object, e As EventArgs) Handles btn_anterior.Click
        pos -= 1

        If pos >= 0 Then
            PictureBox1.Image = images(pos)
        Else
            pos = 0
        End If

    End Sub

    Private Sub Form_mostrador_fotos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Form_mostrador_fotos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        pos = 0
    End Sub
End Class