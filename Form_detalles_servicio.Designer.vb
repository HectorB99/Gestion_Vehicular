<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_detalles_servicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txt_cantidad = New TextBox()
        txt_unidad = New TextBox()
        txt_descripcion = New TextBox()
        txt_costo_pieza = New TextBox()
        txt_operacion = New TextBox()
        btn_insertar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(57, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 15)
        Label1.TabIndex = 0
        Label1.Text = "Cantidad"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(67, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 15)
        Label2.TabIndex = 1
        Label2.Text = "Unidad"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(43, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 15)
        Label3.TabIndex = 2
        Label3.Text = "Descripcion"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(28, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 15)
        Label4.TabIndex = 3
        Label4.Text = "Costo de pieza"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(50, 225)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 15)
        Label5.TabIndex = 4
        Label5.Text = "Operación"
        ' 
        ' txt_cantidad
        ' 
        txt_cantidad.Location = New Point(134, 33)
        txt_cantidad.Name = "txt_cantidad"
        txt_cantidad.Size = New Size(283, 23)
        txt_cantidad.TabIndex = 7
        ' 
        ' txt_unidad
        ' 
        txt_unidad.Location = New Point(134, 80)
        txt_unidad.Name = "txt_unidad"
        txt_unidad.Size = New Size(283, 23)
        txt_unidad.TabIndex = 8
        ' 
        ' txt_descripcion
        ' 
        txt_descripcion.Location = New Point(134, 126)
        txt_descripcion.Name = "txt_descripcion"
        txt_descripcion.Size = New Size(283, 23)
        txt_descripcion.TabIndex = 9
        ' 
        ' txt_costo_pieza
        ' 
        txt_costo_pieza.Location = New Point(134, 176)
        txt_costo_pieza.Name = "txt_costo_pieza"
        txt_costo_pieza.Size = New Size(283, 23)
        txt_costo_pieza.TabIndex = 10
        ' 
        ' txt_operacion
        ' 
        txt_operacion.Location = New Point(134, 222)
        txt_operacion.Multiline = True
        txt_operacion.Name = "txt_operacion"
        txt_operacion.Size = New Size(283, 86)
        txt_operacion.TabIndex = 11
        ' 
        ' btn_insertar
        ' 
        btn_insertar.Location = New Point(157, 330)
        btn_insertar.Name = "btn_insertar"
        btn_insertar.Size = New Size(125, 27)
        btn_insertar.TabIndex = 14
        btn_insertar.Text = "Insertar"
        btn_insertar.UseVisualStyleBackColor = True
        ' 
        ' Form_detalles_servicio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(447, 380)
        Controls.Add(btn_insertar)
        Controls.Add(txt_operacion)
        Controls.Add(txt_costo_pieza)
        Controls.Add(txt_descripcion)
        Controls.Add(txt_unidad)
        Controls.Add(txt_cantidad)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form_detalles_servicio"
        Text = "Datos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents txt_unidad As TextBox
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents txt_costo_pieza As TextBox
    Friend WithEvents txt_operacion As TextBox
    Friend WithEvents btn_insertar As Button
End Class
