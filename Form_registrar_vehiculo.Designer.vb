<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_registrar_vehiculo
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
        txt_marca = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        txt_clave = New TextBox()
        txt_linea = New TextBox()
        txt_modelo = New TextBox()
        txt_color = New TextBox()
        txt_placa = New TextBox()
        txt_tipomotor = New TextBox()
        txt_llantas = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        cb_tipocombustible = New ComboBox()
        DataGridView1 = New DataGridView()
        idvehiculo = New DataGridViewTextBoxColumn()
        clave_interna = New DataGridViewTextBoxColumn()
        marca = New DataGridViewTextBoxColumn()
        linea = New DataGridViewTextBoxColumn()
        modelo = New DataGridViewTextBoxColumn()
        color = New DataGridViewTextBoxColumn()
        placa = New DataGridViewTextBoxColumn()
        tipo_motor = New DataGridViewTextBoxColumn()
        llantas = New DataGridViewTextBoxColumn()
        tipo_combustible = New DataGridViewTextBoxColumn()
        num_serie = New DataGridViewTextBoxColumn()
        estatus = New DataGridViewTextBoxColumn()
        Label10 = New Label()
        txt_numserie = New TextBox()
        btn_limpiar = New Button()
        GroupBox1 = New GroupBox()
        rb_baja = New RadioButton()
        rb_activo = New RadioButton()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txt_marca
        ' 
        txt_marca.Location = New Point(302, 66)
        txt_marca.Name = "txt_marca"
        txt_marca.Size = New Size(217, 23)
        txt_marca.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(140, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 15)
        Label1.TabIndex = 0
        Label1.Text = "Clave interna del vehiculo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(243, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 15)
        Label2.TabIndex = 1
        Label2.Text = "Marca"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(248, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 2
        Label3.Text = "Línea"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(235, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 15)
        Label4.TabIndex = 3
        Label4.Text = "Modelo"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(247, 237)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 15)
        Label5.TabIndex = 4
        Label5.Text = "Color"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(644, 15)
        Label6.Name = "Label6"
        Label6.Size = New Size(35, 15)
        Label6.TabIndex = 5
        Label6.Text = "Placa"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(597, 64)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 15)
        Label7.TabIndex = 6
        Label7.Text = "Tipo de Motor"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(635, 120)
        Label8.Name = "Label8"
        Label8.Size = New Size(44, 15)
        Label8.TabIndex = 7
        Label8.Text = "Llantas"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(562, 177)
        Label9.Name = "Label9"
        Label9.Size = New Size(117, 15)
        Label9.TabIndex = 8
        Label9.Text = "Tipo de Combustible"
        ' 
        ' txt_clave
        ' 
        txt_clave.Location = New Point(302, 12)
        txt_clave.Name = "txt_clave"
        txt_clave.Size = New Size(217, 23)
        txt_clave.TabIndex = 9
        ' 
        ' txt_linea
        ' 
        txt_linea.Location = New Point(302, 117)
        txt_linea.Name = "txt_linea"
        txt_linea.Size = New Size(217, 23)
        txt_linea.TabIndex = 11
        ' 
        ' txt_modelo
        ' 
        txt_modelo.Location = New Point(302, 174)
        txt_modelo.Name = "txt_modelo"
        txt_modelo.Size = New Size(217, 23)
        txt_modelo.TabIndex = 12
        ' 
        ' txt_color
        ' 
        txt_color.Location = New Point(302, 234)
        txt_color.Name = "txt_color"
        txt_color.Size = New Size(217, 23)
        txt_color.TabIndex = 13
        ' 
        ' txt_placa
        ' 
        txt_placa.Location = New Point(704, 12)
        txt_placa.Name = "txt_placa"
        txt_placa.Size = New Size(217, 23)
        txt_placa.TabIndex = 14
        ' 
        ' txt_tipomotor
        ' 
        txt_tipomotor.Location = New Point(704, 61)
        txt_tipomotor.Name = "txt_tipomotor"
        txt_tipomotor.Size = New Size(217, 23)
        txt_tipomotor.TabIndex = 15
        ' 
        ' txt_llantas
        ' 
        txt_llantas.Location = New Point(704, 117)
        txt_llantas.Name = "txt_llantas"
        txt_llantas.Size = New Size(217, 23)
        txt_llantas.TabIndex = 16
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(319, 343)
        Button1.Name = "Button1"
        Button1.Size = New Size(182, 48)
        Button1.TabIndex = 18
        Button1.Text = "Guardar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(704, 343)
        Button2.Name = "Button2"
        Button2.Size = New Size(182, 48)
        Button2.TabIndex = 19
        Button2.Text = "Volver"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' cb_tipocombustible
        ' 
        cb_tipocombustible.FormattingEnabled = True
        cb_tipocombustible.Location = New Point(704, 174)
        cb_tipocombustible.Name = "cb_tipocombustible"
        cb_tipocombustible.Size = New Size(217, 23)
        cb_tipocombustible.TabIndex = 20
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {idvehiculo, clave_interna, marca, linea, modelo, color, placa, tipo_motor, llantas, tipo_combustible, num_serie, estatus})
        DataGridView1.Location = New Point(12, 410)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1179, 387)
        DataGridView1.TabIndex = 21
        ' 
        ' idvehiculo
        ' 
        idvehiculo.HeaderText = "idvehiculo"
        idvehiculo.Name = "idvehiculo"
        idvehiculo.Visible = False
        ' 
        ' clave_interna
        ' 
        clave_interna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        clave_interna.HeaderText = "Clave Interna"
        clave_interna.Name = "clave_interna"
        ' 
        ' marca
        ' 
        marca.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        marca.HeaderText = "Marca"
        marca.Name = "marca"
        ' 
        ' linea
        ' 
        linea.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        linea.HeaderText = "Linea"
        linea.Name = "linea"
        ' 
        ' modelo
        ' 
        modelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        modelo.HeaderText = "Modelo"
        modelo.Name = "modelo"
        ' 
        ' color
        ' 
        color.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        color.HeaderText = "Color"
        color.Name = "color"
        ' 
        ' placa
        ' 
        placa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        placa.HeaderText = "Placa"
        placa.Name = "placa"
        ' 
        ' tipo_motor
        ' 
        tipo_motor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tipo_motor.HeaderText = "Tipo de Motor"
        tipo_motor.Name = "tipo_motor"
        ' 
        ' llantas
        ' 
        llantas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        llantas.HeaderText = "Llantas"
        llantas.Name = "llantas"
        ' 
        ' tipo_combustible
        ' 
        tipo_combustible.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tipo_combustible.HeaderText = "Tipo de Combustible"
        tipo_combustible.Name = "tipo_combustible"
        ' 
        ' num_serie
        ' 
        num_serie.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        num_serie.HeaderText = "Num. de Serie"
        num_serie.Name = "num_serie"
        ' 
        ' estatus
        ' 
        estatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        estatus.HeaderText = "Estatus"
        estatus.Name = "estatus"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(598, 237)
        Label10.Name = "Label10"
        Label10.Size = New Size(81, 15)
        Label10.TabIndex = 22
        Label10.Text = "Num. de Serie"
        ' 
        ' txt_numserie
        ' 
        txt_numserie.Location = New Point(704, 234)
        txt_numserie.Name = "txt_numserie"
        txt_numserie.Size = New Size(217, 23)
        txt_numserie.TabIndex = 23
        ' 
        ' btn_limpiar
        ' 
        btn_limpiar.Font = New Font("Arial Narrow", 20.25F)
        btn_limpiar.Location = New Point(516, 343)
        btn_limpiar.Name = "btn_limpiar"
        btn_limpiar.Size = New Size(182, 48)
        btn_limpiar.TabIndex = 24
        btn_limpiar.Text = "Limpiar"
        btn_limpiar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rb_baja)
        GroupBox1.Controls.Add(rb_activo)
        GroupBox1.Location = New Point(476, 274)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(256, 54)
        GroupBox1.TabIndex = 25
        GroupBox1.TabStop = False
        GroupBox1.Text = "Estatus"
        ' 
        ' rb_baja
        ' 
        rb_baja.AutoSize = True
        rb_baja.Location = New Point(185, 22)
        rb_baja.Name = "rb_baja"
        rb_baja.Size = New Size(47, 19)
        rb_baja.TabIndex = 1
        rb_baja.TabStop = True
        rb_baja.Text = "Baja"
        rb_baja.UseVisualStyleBackColor = True
        ' 
        ' rb_activo
        ' 
        rb_activo.AutoSize = True
        rb_activo.Location = New Point(6, 22)
        rb_activo.Name = "rb_activo"
        rb_activo.Size = New Size(59, 19)
        rb_activo.TabIndex = 0
        rb_activo.TabStop = True
        rb_activo.Text = "Activo"
        rb_activo.UseVisualStyleBackColor = True
        ' 
        ' Form_registrar_vehiculo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1203, 809)
        Controls.Add(GroupBox1)
        Controls.Add(btn_limpiar)
        Controls.Add(txt_numserie)
        Controls.Add(Label10)
        Controls.Add(DataGridView1)
        Controls.Add(cb_tipocombustible)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txt_llantas)
        Controls.Add(txt_tipomotor)
        Controls.Add(txt_placa)
        Controls.Add(txt_color)
        Controls.Add(txt_modelo)
        Controls.Add(txt_linea)
        Controls.Add(txt_marca)
        Controls.Add(txt_clave)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form_registrar_vehiculo"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form_registrar_vehiculo"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_clave As TextBox
    Friend WithEvents txt_marca As TextBox
    Friend WithEvents txt_linea As TextBox
    Friend WithEvents txt_modelo As TextBox
    Friend WithEvents txt_color As TextBox
    Friend WithEvents txt_placa As TextBox
    Friend WithEvents txt_tipomotor As TextBox
    Friend WithEvents txt_llantas As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cb_tipocombustible As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents idvehiculo As DataGridViewTextBoxColumn
    Friend WithEvents clave_interna As DataGridViewTextBoxColumn
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents linea As DataGridViewTextBoxColumn
    Friend WithEvents modelo As DataGridViewTextBoxColumn
    Friend WithEvents color As DataGridViewTextBoxColumn
    Friend WithEvents placa As DataGridViewTextBoxColumn
    Friend WithEvents tipo_motor As DataGridViewTextBoxColumn
    Friend WithEvents llantas As DataGridViewTextBoxColumn
    Friend WithEvents tipo_combustible As DataGridViewTextBoxColumn
    Friend WithEvents num_serie As DataGridViewTextBoxColumn
    Friend WithEvents estatus As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_numserie As TextBox
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_baja As RadioButton
    Friend WithEvents rb_activo As RadioButton
End Class
