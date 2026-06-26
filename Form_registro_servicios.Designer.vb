<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_registro_servicios
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
        lbl_vehiculo = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        cb_vehiculos = New ComboBox()
        dtp_entrada = New DateTimePicker()
        dtp_salida = New DateTimePicker()
        dtp_programada = New DateTimePicker()
        tb_tipo_servicio = New TextBox()
        txt_subtotal = New TextBox()
        tb_taller = New TextBox()
        tb_direccion_taller = New TextBox()
        tb_telefono_taller = New TextBox()
        tb_nombre_mecanico = New TextBox()
        tb_tel_mecanico = New TextBox()
        btn_guardar = New Button()
        btn_reporte = New Button()
        btn_borrar = New Button()
        btn_volver = New Button()
        DataGridView1 = New DataGridView()
        cantidad = New DataGridViewTextBoxColumn()
        unidad = New DataGridViewTextBoxColumn()
        pieza = New DataGridViewTextBoxColumn()
        costo = New DataGridViewTextBoxColumn()
        costo_total = New DataGridViewTextBoxColumn()
        operacion = New DataGridViewTextBoxColumn()
        iddetalle = New DataGridViewTextBoxColumn()
        Label11 = New Label()
        btn_añadir = New Button()
        GroupBox1 = New GroupBox()
        rb_concluido = New RadioButton()
        rb_curso = New RadioButton()
        rb_programado = New RadioButton()
        Label12 = New Label()
        txt_iva_añadido = New TextBox()
        Label13 = New Label()
        txt_costo_total = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lbl_vehiculo
        ' 
        lbl_vehiculo.AutoSize = True
        lbl_vehiculo.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_vehiculo.ImageAlign = ContentAlignment.TopRight
        lbl_vehiculo.Location = New Point(120, 86)
        lbl_vehiculo.Name = "lbl_vehiculo"
        lbl_vehiculo.Size = New Size(88, 25)
        lbl_vehiculo.TabIndex = 0
        lbl_vehiculo.Text = "Vehiculo"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(45, 144)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 25)
        Label1.TabIndex = 1
        Label1.Text = "Fecha de entrada"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(64, 199)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 25)
        Label2.TabIndex = 2
        Label2.Text = "Fecha de salida"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(30, 259)
        Label3.Name = "Label3"
        Label3.Size = New Size(178, 25)
        Label3.TabIndex = 3
        Label3.Text = "Fecha programada"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label4.Location = New Point(53, 319)
        Label4.Name = "Label4"
        Label4.Size = New Size(155, 25)
        Label4.TabIndex = 4
        Label4.Text = "Tipo de Servicio"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label5.Location = New Point(708, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 25)
        Label5.TabIndex = 5
        Label5.Text = "Taller"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label6.Location = New Point(587, 146)
        Label6.Name = "Label6"
        Label6.Size = New Size(180, 25)
        Label6.TabIndex = 6
        Label6.Text = "Dirección del Taller"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label7.Location = New Point(515, 204)
        Label7.Name = "Label7"
        Label7.Size = New Size(252, 25)
        Label7.TabIndex = 7
        Label7.Text = "Num. de Teléfono del taller"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label8.Location = New Point(559, 259)
        Label8.Name = "Label8"
        Label8.Size = New Size(208, 25)
        Label8.TabIndex = 8
        Label8.Text = "Nombre del Mecánico"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label9.Location = New Point(475, 314)
        Label9.Name = "Label9"
        Label9.Size = New Size(292, 25)
        Label9.TabIndex = 9
        Label9.Text = "Num. de Télefono del Mecánico"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label10.Location = New Point(12, 423)
        Label10.Name = "Label10"
        Label10.Size = New Size(196, 25)
        Label10.TabIndex = 10
        Label10.Text = "Subtotal del Servicio"
        ' 
        ' cb_vehiculos
        ' 
        cb_vehiculos.FormattingEnabled = True
        cb_vehiculos.Location = New Point(225, 90)
        cb_vehiculos.Name = "cb_vehiculos"
        cb_vehiculos.Size = New Size(149, 23)
        cb_vehiculos.TabIndex = 11
        ' 
        ' dtp_entrada
        ' 
        dtp_entrada.Location = New Point(225, 148)
        dtp_entrada.Name = "dtp_entrada"
        dtp_entrada.Size = New Size(149, 23)
        dtp_entrada.TabIndex = 12
        ' 
        ' dtp_salida
        ' 
        dtp_salida.Location = New Point(225, 206)
        dtp_salida.Name = "dtp_salida"
        dtp_salida.Size = New Size(149, 23)
        dtp_salida.TabIndex = 13
        ' 
        ' dtp_programada
        ' 
        dtp_programada.Location = New Point(225, 263)
        dtp_programada.Name = "dtp_programada"
        dtp_programada.Size = New Size(149, 23)
        dtp_programada.TabIndex = 14
        ' 
        ' tb_tipo_servicio
        ' 
        tb_tipo_servicio.Location = New Point(225, 321)
        tb_tipo_servicio.Name = "tb_tipo_servicio"
        tb_tipo_servicio.Size = New Size(149, 23)
        tb_tipo_servicio.TabIndex = 15
        ' 
        ' txt_subtotal
        ' 
        txt_subtotal.Enabled = False
        txt_subtotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_subtotal.Location = New Point(225, 421)
        txt_subtotal.Name = "txt_subtotal"
        txt_subtotal.ReadOnly = True
        txt_subtotal.Size = New Size(149, 29)
        txt_subtotal.TabIndex = 16
        ' 
        ' tb_taller
        ' 
        tb_taller.Location = New Point(773, 90)
        tb_taller.Name = "tb_taller"
        tb_taller.Size = New Size(149, 23)
        tb_taller.TabIndex = 17
        ' 
        ' tb_direccion_taller
        ' 
        tb_direccion_taller.Location = New Point(773, 146)
        tb_direccion_taller.Name = "tb_direccion_taller"
        tb_direccion_taller.Size = New Size(149, 23)
        tb_direccion_taller.TabIndex = 18
        ' 
        ' tb_telefono_taller
        ' 
        tb_telefono_taller.Location = New Point(773, 204)
        tb_telefono_taller.Name = "tb_telefono_taller"
        tb_telefono_taller.Size = New Size(149, 23)
        tb_telefono_taller.TabIndex = 19
        ' 
        ' tb_nombre_mecanico
        ' 
        tb_nombre_mecanico.Location = New Point(773, 261)
        tb_nombre_mecanico.Name = "tb_nombre_mecanico"
        tb_nombre_mecanico.Size = New Size(149, 23)
        tb_nombre_mecanico.TabIndex = 20
        ' 
        ' tb_tel_mecanico
        ' 
        tb_tel_mecanico.Location = New Point(773, 316)
        tb_tel_mecanico.Name = "tb_tel_mecanico"
        tb_tel_mecanico.Size = New Size(149, 23)
        tb_tel_mecanico.TabIndex = 21
        ' 
        ' btn_guardar
        ' 
        btn_guardar.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_guardar.Location = New Point(25, 21)
        btn_guardar.Name = "btn_guardar"
        btn_guardar.Size = New Size(163, 42)
        btn_guardar.TabIndex = 22
        btn_guardar.Text = "Guardar"
        btn_guardar.UseVisualStyleBackColor = True
        ' 
        ' btn_reporte
        ' 
        btn_reporte.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btn_reporte.Location = New Point(254, 21)
        btn_reporte.Name = "btn_reporte"
        btn_reporte.Size = New Size(163, 42)
        btn_reporte.TabIndex = 23
        btn_reporte.Text = "Reportes"
        btn_reporte.UseVisualStyleBackColor = True
        ' 
        ' btn_borrar
        ' 
        btn_borrar.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btn_borrar.Location = New Point(489, 21)
        btn_borrar.Name = "btn_borrar"
        btn_borrar.Size = New Size(163, 42)
        btn_borrar.TabIndex = 24
        btn_borrar.Text = "Borrar"
        btn_borrar.UseVisualStyleBackColor = True
        ' 
        ' btn_volver
        ' 
        btn_volver.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btn_volver.Location = New Point(725, 21)
        btn_volver.Name = "btn_volver"
        btn_volver.Size = New Size(163, 42)
        btn_volver.TabIndex = 25
        btn_volver.Text = "Volver"
        btn_volver.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {cantidad, unidad, pieza, costo, costo_total, operacion, iddetalle})
        DataGridView1.Location = New Point(25, 510)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(916, 291)
        DataGridView1.TabIndex = 26
        ' 
        ' cantidad
        ' 
        cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        cantidad.HeaderText = "Cantidad"
        cantidad.Name = "cantidad"
        ' 
        ' unidad
        ' 
        unidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        unidad.HeaderText = "Unidad"
        unidad.Name = "unidad"
        ' 
        ' pieza
        ' 
        pieza.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        pieza.HeaderText = "Pieza"
        pieza.Name = "pieza"
        ' 
        ' costo
        ' 
        costo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        costo.HeaderText = "Costo de la Pieza"
        costo.Name = "costo"
        ' 
        ' costo_total
        ' 
        costo_total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        costo_total.HeaderText = "Costo Total"
        costo_total.Name = "costo_total"
        ' 
        ' operacion
        ' 
        operacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        operacion.HeaderText = "Operación"
        operacion.Name = "operacion"
        ' 
        ' iddetalle
        ' 
        iddetalle.HeaderText = "Column1"
        iddetalle.Name = "iddetalle"
        iddetalle.Visible = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label11.Location = New Point(25, 470)
        Label11.Name = "Label11"
        Label11.Size = New Size(100, 25)
        Label11.TabIndex = 27
        Label11.Text = "DETALLES"
        ' 
        ' btn_añadir
        ' 
        btn_añadir.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btn_añadir.Location = New Point(725, 454)
        btn_añadir.Name = "btn_añadir"
        btn_añadir.Size = New Size(197, 41)
        btn_añadir.TabIndex = 28
        btn_añadir.Text = "Añadir Detalles"
        btn_añadir.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rb_concluido)
        GroupBox1.Controls.Add(rb_curso)
        GroupBox1.Controls.Add(rb_programado)
        GroupBox1.Location = New Point(619, 359)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(303, 54)
        GroupBox1.TabIndex = 29
        GroupBox1.TabStop = False
        GroupBox1.Text = "Estatus"
        ' 
        ' rb_concluido
        ' 
        rb_concluido.AutoSize = True
        rb_concluido.Location = New Point(221, 22)
        rb_concluido.Name = "rb_concluido"
        rb_concluido.Size = New Size(80, 19)
        rb_concluido.TabIndex = 30
        rb_concluido.TabStop = True
        rb_concluido.Text = "Concluido"
        rb_concluido.UseVisualStyleBackColor = True
        ' 
        ' rb_curso
        ' 
        rb_curso.AutoSize = True
        rb_curso.Location = New Point(127, 22)
        rb_curso.Name = "rb_curso"
        rb_curso.Size = New Size(70, 19)
        rb_curso.TabIndex = 1
        rb_curso.TabStop = True
        rb_curso.Text = "En curso"
        rb_curso.UseVisualStyleBackColor = True
        ' 
        ' rb_programado
        ' 
        rb_programado.AutoSize = True
        rb_programado.Location = New Point(8, 22)
        rb_programado.Name = "rb_programado"
        rb_programado.Size = New Size(91, 19)
        rb_programado.TabIndex = 0
        rb_programado.TabStop = True
        rb_programado.Text = "Programado"
        rb_programado.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label12.Location = New Point(87, 373)
        Label12.Name = "Label12"
        Label12.Size = New Size(121, 25)
        Label12.TabIndex = 30
        Label12.Text = "IVA añadido"
        ' 
        ' txt_iva_añadido
        ' 
        txt_iva_añadido.Location = New Point(225, 373)
        txt_iva_añadido.Name = "txt_iva_añadido"
        txt_iva_añadido.Size = New Size(149, 23)
        txt_iva_añadido.TabIndex = 31
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(164, 464)
        Label13.Name = "Label13"
        Label13.Size = New Size(210, 32)
        Label13.TabIndex = 32
        Label13.Text = "Total del Servicio"
        ' 
        ' txt_costo_total
        ' 
        txt_costo_total.Enabled = False
        txt_costo_total.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_costo_total.Location = New Point(380, 466)
        txt_costo_total.Name = "txt_costo_total"
        txt_costo_total.ReadOnly = True
        txt_costo_total.Size = New Size(149, 29)
        txt_costo_total.TabIndex = 33
        ' 
        ' Form_registro_servicios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(953, 813)
        Controls.Add(txt_costo_total)
        Controls.Add(Label13)
        Controls.Add(txt_iva_añadido)
        Controls.Add(Label12)
        Controls.Add(GroupBox1)
        Controls.Add(btn_añadir)
        Controls.Add(Label11)
        Controls.Add(DataGridView1)
        Controls.Add(btn_volver)
        Controls.Add(btn_borrar)
        Controls.Add(btn_reporte)
        Controls.Add(btn_guardar)
        Controls.Add(tb_tel_mecanico)
        Controls.Add(tb_nombre_mecanico)
        Controls.Add(tb_telefono_taller)
        Controls.Add(tb_direccion_taller)
        Controls.Add(tb_taller)
        Controls.Add(txt_subtotal)
        Controls.Add(tb_tipo_servicio)
        Controls.Add(dtp_programada)
        Controls.Add(dtp_salida)
        Controls.Add(dtp_entrada)
        Controls.Add(cb_vehiculos)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lbl_vehiculo)
        Name = "Form_registro_servicios"
        Text = "Form_registro_servicios"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_vehiculo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cb_vehiculos As ComboBox
    Friend WithEvents dtp_entrada As DateTimePicker
    Friend WithEvents dtp_salida As DateTimePicker
    Friend WithEvents dtp_programada As DateTimePicker
    Friend WithEvents tb_tipo_servicio As TextBox
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents tb_taller As TextBox
    Friend WithEvents tb_direccion_taller As TextBox
    Friend WithEvents tb_telefono_taller As TextBox
    Friend WithEvents tb_nombre_mecanico As TextBox
    Friend WithEvents tb_tel_mecanico As TextBox
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_reporte As Button
    Friend WithEvents btn_borrar As Button
    Friend WithEvents btn_volver As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_añadir As Button
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents unidad As DataGridViewTextBoxColumn
    Friend WithEvents pieza As DataGridViewTextBoxColumn
    Friend WithEvents costo As DataGridViewTextBoxColumn
    Friend WithEvents costo_total As DataGridViewTextBoxColumn
    Friend WithEvents operacion As DataGridViewTextBoxColumn
    Friend WithEvents iddetalle As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_concluido As RadioButton
    Friend WithEvents rb_curso As RadioButton
    Friend WithEvents rb_programado As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_iva_añadido As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_costo_total As TextBox
End Class
