Public Class Form_mensaje_prox_servicio
    Private Sub Form_mensaje_prox_servicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Public Sub CV_Validacion_Kilometraje_Servicio(dt)
        Dim nombre_label_vehiculo As String = "lbl_vehiculo"
        Dim nombre_label_kilometraje As String = "lbl_kilometraje"
        Dim indiceLabel As Int32 = 1
        Dim cont As Int32 = 0


        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i)(9) < 5000 Then
                nombre_label_vehiculo = nombre_label_vehiculo & indiceLabel
                nombre_label_kilometraje = nombre_label_kilometraje & indiceLabel
                Me.Controls(nombre_label_vehiculo).Text = dt.Rows(i)(0).ToString()
                Me.Controls(nombre_label_kilometraje).Text = dt.Rows(i)(5).ToString()
                Me.Controls(nombre_label_vehiculo).Visible = True
                Me.Controls(nombre_label_kilometraje).Visible = True

                If dt.Rows(i)(5) = 0 Then
                    Me.Controls(nombre_label_vehiculo).ForeColor = Color.DarkRed
                    Me.Controls(nombre_label_kilometraje).ForeColor = Color.DarkRed
                ElseIf dt.Rows(i)(5) > 0 And dt.Rows(i)(5) < 1000 Then
                    Me.Controls(nombre_label_vehiculo).ForeColor = Color.Red
                    Me.Controls(nombre_label_kilometraje).ForeColor = Color.Red
                ElseIf dt.Rows(i)(5) > 1000 And dt.Rows(i)(5) < 2000 Then
                    Me.Controls(nombre_label_vehiculo).ForeColor = Color.Goldenrod
                    Me.Controls(nombre_label_kilometraje).ForeColor = Color.Goldenrod
                ElseIf dt.Rows(i)(5) > 2000 And dt.Rows(i)(5) < 5000 Then
                    Me.Controls(nombre_label_vehiculo).ForeColor = Color.Green
                    Me.Controls(nombre_label_kilometraje).ForeColor = Color.Green
                End If

                nombre_label_vehiculo = "lbl_vehiculo"
                nombre_label_kilometraje = "lbl_kilometraje"
                indiceLabel += 1
                cont += 1
            End If

            'MessageBox.Show("Vehiculo: " + dt.Rows(i)(1).ToString() + ", Fecha: " + dt.Rows(i)(6).ToString())
        Next

        If cont = 0 Then
            Me.Hide()
        End If
    End Sub
End Class