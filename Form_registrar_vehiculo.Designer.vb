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
        Label10 = New Label()
        txt_numserie = New TextBox()
        btn_limpiar = New Button()
        GroupBox1 = New GroupBox()
        rb_baja = New RadioButton()
        rb_activo = New RadioButton()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        dtp_llantas = New DateTimePicker()
        txt_km_aceite = New TextBox()
        txt_km_prox_aceite = New TextBox()
        dtp_ultimo_taller = New DateTimePicker()
        txt_km_ultimo_taller = New TextBox()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        txt_poliza_seguro = New TextBox()
        dtp_vigencia_poliza = New DateTimePicker()
        dtp_ultima_bateria = New DateTimePicker()
        dtp_vigencia_tarjeta = New DateTimePicker()
        Label20 = New Label()
        txt_num_economico = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txt_marca
        ' 
        txt_marca.Location = New Point(105, 65)
        txt_marca.Name = "txt_marca"
        txt_marca.Size = New Size(217, 23)
        txt_marca.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(22, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 31)
        Label1.TabIndex = 0
        Label1.Text = "Clave interna del vehiculo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 15)
        Label2.TabIndex = 1
        Label2.Text = "Marca"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(51, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 2
        Label3.Text = "Línea"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(38, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 15)
        Label4.TabIndex = 3
        Label4.Text = "Modelo"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(50, 236)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 15)
        Label5.TabIndex = 4
        Label5.Text = "Color"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(421, 14)
        Label6.Name = "Label6"
        Label6.Size = New Size(35, 15)
        Label6.TabIndex = 5
        Label6.Text = "Placa"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(374, 63)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 15)
        Label7.TabIndex = 6
        Label7.Text = "Tipo de Motor"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(412, 119)
        Label8.Name = "Label8"
        Label8.Size = New Size(44, 15)
        Label8.TabIndex = 7
        Label8.Text = "Llantas"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(339, 176)
        Label9.Name = "Label9"
        Label9.Size = New Size(117, 15)
        Label9.TabIndex = 8
        Label9.Text = "Tipo de Combustible"
        ' 
        ' txt_clave
        ' 
        txt_clave.Location = New Point(105, 11)
        txt_clave.Name = "txt_clave"
        txt_clave.Size = New Size(217, 23)
        txt_clave.TabIndex = 9
        ' 
        ' txt_linea
        ' 
        txt_linea.Location = New Point(105, 116)
        txt_linea.Name = "txt_linea"
        txt_linea.Size = New Size(217, 23)
        txt_linea.TabIndex = 11
        ' 
        ' txt_modelo
        ' 
        txt_modelo.Location = New Point(105, 173)
        txt_modelo.Name = "txt_modelo"
        txt_modelo.Size = New Size(217, 23)
        txt_modelo.TabIndex = 12
        ' 
        ' txt_color
        ' 
        txt_color.Location = New Point(105, 233)
        txt_color.Name = "txt_color"
        txt_color.Size = New Size(217, 23)
        txt_color.TabIndex = 13
        ' 
        ' txt_placa
        ' 
        txt_placa.Location = New Point(481, 11)
        txt_placa.Name = "txt_placa"
        txt_placa.Size = New Size(217, 23)
        txt_placa.TabIndex = 14
        ' 
        ' txt_tipomotor
        ' 
        txt_tipomotor.Location = New Point(481, 60)
        txt_tipomotor.Name = "txt_tipomotor"
        txt_tipomotor.Size = New Size(217, 23)
        txt_tipomotor.TabIndex = 15
        ' 
        ' txt_llantas
        ' 
        txt_llantas.Location = New Point(481, 116)
        txt_llantas.Name = "txt_llantas"
        txt_llantas.Size = New Size(217, 23)
        txt_llantas.TabIndex = 16
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(349, 356)
        Button1.Name = "Button1"
        Button1.Size = New Size(182, 48)
        Button1.TabIndex = 18
        Button1.Text = "Guardar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(725, 356)
        Button2.Name = "Button2"
        Button2.Size = New Size(182, 48)
        Button2.TabIndex = 19
        Button2.Text = "Volver"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' cb_tipocombustible
        ' 
        cb_tipocombustible.FormattingEnabled = True
        cb_tipocombustible.Location = New Point(481, 173)
        cb_tipocombustible.Name = "cb_tipocombustible"
        cb_tipocombustible.Size = New Size(217, 23)
        cb_tipocombustible.TabIndex = 20
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 410)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1226, 387)
        DataGridView1.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(375, 236)
        Label10.Name = "Label10"
        Label10.Size = New Size(81, 15)
        Label10.TabIndex = 22
        Label10.Text = "Num. de Serie"
        ' 
        ' txt_numserie
        ' 
        txt_numserie.Location = New Point(481, 228)
        txt_numserie.Name = "txt_numserie"
        txt_numserie.Size = New Size(217, 23)
        txt_numserie.TabIndex = 23
        ' 
        ' btn_limpiar
        ' 
        btn_limpiar.Font = New Font("Arial Narrow", 20.25F)
        btn_limpiar.Location = New Point(537, 356)
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
        GroupBox1.Location = New Point(99, 283)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(223, 54)
        GroupBox1.TabIndex = 25
        GroupBox1.TabStop = False
        GroupBox1.Text = "Estatus"
        ' 
        ' rb_baja
        ' 
        rb_baja.AutoSize = True
        rb_baja.Location = New Point(159, 22)
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
        ' Label11
        ' 
        Label11.Location = New Point(743, 7)
        Label11.Name = "Label11"
        Label11.Size = New Size(111, 33)
        Label11.TabIndex = 26
        Label11.Text = "Fecha del Ultimo Cambio de Llantas"
        ' 
        ' Label12
        ' 
        Label12.Location = New Point(743, 50)
        Label12.Name = "Label12"
        Label12.Size = New Size(111, 33)
        Label12.TabIndex = 27
        Label12.Text = "Kilometraje Ultimo Cambio de Aceite"
        ' 
        ' Label13
        ' 
        Label13.Location = New Point(743, 106)
        Label13.Name = "Label13"
        Label13.Size = New Size(111, 33)
        Label13.TabIndex = 28
        Label13.Text = "Kilometraje Prox. Cambio de Aceite"
        ' 
        ' Label14
        ' 
        Label14.Location = New Point(772, 164)
        Label14.Name = "Label14"
        Label14.Size = New Size(82, 32)
        Label14.TabIndex = 29
        Label14.Text = "Fecha Ultima Visita a Taller"
        ' 
        ' Label15
        ' 
        Label15.Location = New Point(748, 221)
        Label15.Name = "Label15"
        Label15.Size = New Size(106, 35)
        Label15.TabIndex = 30
        Label15.Text = "Kilometraje Ultima Visita a Taller"
        ' 
        ' dtp_llantas
        ' 
        dtp_llantas.Location = New Point(860, 11)
        dtp_llantas.Name = "dtp_llantas"
        dtp_llantas.Size = New Size(118, 23)
        dtp_llantas.TabIndex = 31
        ' 
        ' txt_km_aceite
        ' 
        txt_km_aceite.Location = New Point(860, 60)
        txt_km_aceite.Name = "txt_km_aceite"
        txt_km_aceite.Size = New Size(118, 23)
        txt_km_aceite.TabIndex = 32
        ' 
        ' txt_km_prox_aceite
        ' 
        txt_km_prox_aceite.Location = New Point(860, 116)
        txt_km_prox_aceite.Name = "txt_km_prox_aceite"
        txt_km_prox_aceite.Size = New Size(118, 23)
        txt_km_prox_aceite.TabIndex = 33
        ' 
        ' dtp_ultimo_taller
        ' 
        dtp_ultimo_taller.Location = New Point(860, 173)
        dtp_ultimo_taller.Name = "dtp_ultimo_taller"
        dtp_ultimo_taller.Size = New Size(118, 23)
        dtp_ultimo_taller.TabIndex = 34
        ' 
        ' txt_km_ultimo_taller
        ' 
        txt_km_ultimo_taller.Location = New Point(860, 228)
        txt_km_ultimo_taller.Name = "txt_km_ultimo_taller"
        txt_km_ultimo_taller.Size = New Size(118, 23)
        txt_km_ultimo_taller.TabIndex = 35
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(1011, 14)
        Label16.Name = "Label16"
        Label16.Size = New Size(94, 15)
        Label16.TabIndex = 36
        Label16.Text = "Poliza de Seguro"
        ' 
        ' Label17
        ' 
        Label17.Location = New Point(996, 50)
        Label17.Name = "Label17"
        Label17.Size = New Size(109, 38)
        Label17.TabIndex = 37
        Label17.Text = "Fecha de Vigencia de Poliza"
        ' 
        ' Label18
        ' 
        Label18.Location = New Point(996, 106)
        Label18.Name = "Label18"
        Label18.Size = New Size(109, 38)
        Label18.TabIndex = 38
        Label18.Text = "Fecha de Ultimo Cambio de Batería"
        ' 
        ' Label19
        ' 
        Label19.Location = New Point(996, 164)
        Label19.Name = "Label19"
        Label19.Size = New Size(109, 48)
        Label19.TabIndex = 39
        Label19.Text = "Fecha de Vigencia de Tarjeta de Circulación"
        ' 
        ' txt_poliza_seguro
        ' 
        txt_poliza_seguro.Location = New Point(1111, 11)
        txt_poliza_seguro.Name = "txt_poliza_seguro"
        txt_poliza_seguro.Size = New Size(127, 23)
        txt_poliza_seguro.TabIndex = 40
        ' 
        ' dtp_vigencia_poliza
        ' 
        dtp_vigencia_poliza.Location = New Point(1111, 57)
        dtp_vigencia_poliza.Name = "dtp_vigencia_poliza"
        dtp_vigencia_poliza.Size = New Size(127, 23)
        dtp_vigencia_poliza.TabIndex = 41
        ' 
        ' dtp_ultima_bateria
        ' 
        dtp_ultima_bateria.Location = New Point(1111, 111)
        dtp_ultima_bateria.Name = "dtp_ultima_bateria"
        dtp_ultima_bateria.Size = New Size(127, 23)
        dtp_ultima_bateria.TabIndex = 42
        ' 
        ' dtp_vigencia_tarjeta
        ' 
        dtp_vigencia_tarjeta.Location = New Point(1111, 170)
        dtp_vigencia_tarjeta.Name = "dtp_vigencia_tarjeta"
        dtp_vigencia_tarjeta.Size = New Size(127, 23)
        dtp_vigencia_tarjeta.TabIndex = 43
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(356, 293)
        Label20.Name = "Label20"
        Label20.Size = New Size(100, 15)
        Label20.TabIndex = 44
        Label20.Text = "Num. Económico"
        ' 
        ' txt_num_economico
        ' 
        txt_num_economico.Location = New Point(481, 285)
        txt_num_economico.Name = "txt_num_economico"
        txt_num_economico.Size = New Size(217, 23)
        txt_num_economico.TabIndex = 45
        ' 
        ' Form_registrar_vehiculo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1250, 809)
        Controls.Add(txt_num_economico)
        Controls.Add(Label20)
        Controls.Add(dtp_vigencia_tarjeta)
        Controls.Add(dtp_ultima_bateria)
        Controls.Add(dtp_vigencia_poliza)
        Controls.Add(txt_poliza_seguro)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(txt_km_ultimo_taller)
        Controls.Add(dtp_ultimo_taller)
        Controls.Add(txt_km_prox_aceite)
        Controls.Add(txt_km_aceite)
        Controls.Add(dtp_llantas)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
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
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_numserie As TextBox
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_baja As RadioButton
    Friend WithEvents rb_activo As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents dtp_llantas As DateTimePicker
    Friend WithEvents txt_km_aceite As TextBox
    Friend WithEvents txt_km_prox_aceite As TextBox
    Friend WithEvents dtp_ultimo_taller As DateTimePicker
    Friend WithEvents txt_km_ultimo_taller As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_poliza_seguro As TextBox
    Friend WithEvents dtp_vigencia_poliza As DateTimePicker
    Friend WithEvents dtp_ultima_bateria As DateTimePicker
    Friend WithEvents dtp_vigencia_tarjeta As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_num_economico As TextBox
End Class
