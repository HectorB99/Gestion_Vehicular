<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_compra_piezas
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
        cb_vehiculos = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        cb_tipo_pieza = New ComboBox()
        cb_proveedores = New ComboBox()
        txb_marca = New TextBox()
        txb_modelo = New TextBox()
        txb_costo = New TextBox()
        btn_guardar = New Button()
        Button2 = New Button()
        btn_borrar = New Button()
        dtp_compra = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(74, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 21)
        Label1.TabIndex = 0
        Label1.Text = "Vehiculo"
        ' 
        ' cb_vehiculos
        ' 
        cb_vehiculos.FormattingEnabled = True
        cb_vehiculos.Location = New Point(163, 28)
        cb_vehiculos.Name = "cb_vehiculos"
        cb_vehiculos.Size = New Size(175, 23)
        cb_vehiculos.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(42, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 21)
        Label2.TabIndex = 2
        Label2.Text = "Tipo de Pieza"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(90, 124)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 21)
        Label3.TabIndex = 3
        Label3.Text = "Marca"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(80, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 21)
        Label4.TabIndex = 4
        Label4.Text = "Modelo"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(61, 236)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 21)
        Label5.TabIndex = 5
        Label5.Text = "Proveedor"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(93, 290)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 21)
        Label6.TabIndex = 6
        Label6.Text = "Costo"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(12, 342)
        Label7.Name = "Label7"
        Label7.Size = New Size(131, 21)
        Label7.TabIndex = 7
        Label7.Text = "Fecha de Compra"
        ' 
        ' cb_tipo_pieza
        ' 
        cb_tipo_pieza.FormattingEnabled = True
        cb_tipo_pieza.Location = New Point(163, 74)
        cb_tipo_pieza.Name = "cb_tipo_pieza"
        cb_tipo_pieza.Size = New Size(175, 23)
        cb_tipo_pieza.TabIndex = 8
        ' 
        ' cb_proveedores
        ' 
        cb_proveedores.FormattingEnabled = True
        cb_proveedores.Location = New Point(163, 234)
        cb_proveedores.Name = "cb_proveedores"
        cb_proveedores.Size = New Size(175, 23)
        cb_proveedores.TabIndex = 9
        ' 
        ' txb_marca
        ' 
        txb_marca.Location = New Point(163, 126)
        txb_marca.Name = "txb_marca"
        txb_marca.Size = New Size(175, 23)
        txb_marca.TabIndex = 10
        ' 
        ' txb_modelo
        ' 
        txb_modelo.Location = New Point(163, 178)
        txb_modelo.Name = "txb_modelo"
        txb_modelo.Size = New Size(175, 23)
        txb_modelo.TabIndex = 11
        ' 
        ' txb_costo
        ' 
        txb_costo.Location = New Point(163, 288)
        txb_costo.Name = "txb_costo"
        txb_costo.Size = New Size(175, 23)
        txb_costo.TabIndex = 13
        ' 
        ' btn_guardar
        ' 
        btn_guardar.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_guardar.Location = New Point(12, 390)
        btn_guardar.Name = "btn_guardar"
        btn_guardar.Size = New Size(118, 35)
        btn_guardar.TabIndex = 14
        btn_guardar.Text = "Guardar"
        btn_guardar.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(163, 390)
        Button2.Name = "Button2"
        Button2.Size = New Size(120, 35)
        Button2.TabIndex = 15
        Button2.Text = "Volver"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btn_borrar
        ' 
        btn_borrar.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_borrar.Location = New Point(312, 390)
        btn_borrar.Name = "btn_borrar"
        btn_borrar.Size = New Size(120, 35)
        btn_borrar.TabIndex = 16
        btn_borrar.Text = "Borrar"
        btn_borrar.UseVisualStyleBackColor = True
        ' 
        ' dtp_compra
        ' 
        dtp_compra.Location = New Point(163, 340)
        dtp_compra.Name = "dtp_compra"
        dtp_compra.Size = New Size(175, 23)
        dtp_compra.TabIndex = 17
        ' 
        ' Form_compra_piezas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(444, 441)
        Controls.Add(dtp_compra)
        Controls.Add(btn_borrar)
        Controls.Add(Button2)
        Controls.Add(btn_guardar)
        Controls.Add(txb_costo)
        Controls.Add(txb_modelo)
        Controls.Add(txb_marca)
        Controls.Add(cb_proveedores)
        Controls.Add(cb_tipo_pieza)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(cb_vehiculos)
        Controls.Add(Label1)
        Name = "Form_compra_piezas"
        Text = "Form_compra_piezas"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cb_vehiculos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cb_tipo_pieza As ComboBox
    Friend WithEvents cb_proveedores As ComboBox
    Friend WithEvents txb_marca As TextBox
    Friend WithEvents txb_modelo As TextBox
    Friend WithEvents txb_costo As TextBox
    Friend WithEvents btn_guardar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_borrar As Button
    Friend WithEvents dtp_compra As DateTimePicker
End Class
