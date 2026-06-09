<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_conductores
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
        GroupBox1 = New GroupBox()
        rb_baja = New RadioButton()
        rb_activo = New RadioButton()
        txt_area_trabajo = New TextBox()
        txt_rfc = New TextBox()
        txt_curp = New TextBox()
        txt_apellidos = New TextBox()
        txt_nombres = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        dtp_vigencia_licencia = New DateTimePicker()
        DataGridView1 = New DataGridView()
        idconductor = New DataGridViewTextBoxColumn()
        nombre = New DataGridViewTextBoxColumn()
        apellidos = New DataGridViewTextBoxColumn()
        curp = New DataGridViewTextBoxColumn()
        rfc = New DataGridViewTextBoxColumn()
        area_trabajo = New DataGridViewTextBoxColumn()
        fecha_vigencia_licencia = New DataGridViewTextBoxColumn()
        estatus = New DataGridViewTextBoxColumn()
        btn_limpiar = New Button()
        btn_volver = New Button()
        btn_guardar = New Button()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rb_baja)
        GroupBox1.Controls.Add(rb_activo)
        GroupBox1.Location = New Point(329, 317)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(256, 54)
        GroupBox1.TabIndex = 46
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
        ' txt_area_trabajo
        ' 
        txt_area_trabajo.Location = New Point(192, 271)
        txt_area_trabajo.Name = "txt_area_trabajo"
        txt_area_trabajo.Size = New Size(217, 23)
        txt_area_trabajo.TabIndex = 39
        ' 
        ' txt_rfc
        ' 
        txt_rfc.Location = New Point(192, 211)
        txt_rfc.Name = "txt_rfc"
        txt_rfc.Size = New Size(217, 23)
        txt_rfc.TabIndex = 38
        ' 
        ' txt_curp
        ' 
        txt_curp.Location = New Point(192, 154)
        txt_curp.Name = "txt_curp"
        txt_curp.Size = New Size(217, 23)
        txt_curp.TabIndex = 37
        ' 
        ' txt_apellidos
        ' 
        txt_apellidos.Location = New Point(192, 103)
        txt_apellidos.Name = "txt_apellidos"
        txt_apellidos.Size = New Size(217, 23)
        txt_apellidos.TabIndex = 36
        ' 
        ' txt_nombres
        ' 
        txt_nombres.Location = New Point(192, 49)
        txt_nombres.Name = "txt_nombres"
        txt_nombres.Size = New Size(217, 23)
        txt_nombres.TabIndex = 35
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(455, 52)
        Label6.Name = "Label6"
        Label6.Size = New Size(160, 15)
        Label6.TabIndex = 31
        Label6.Text = "Fecha de vigencia de licencia"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(86, 274)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 15)
        Label5.TabIndex = 30
        Label5.Text = "Area de trabajo"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(145, 214)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 15)
        Label4.TabIndex = 29
        Label4.Text = "RFC"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(136, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 15)
        Label3.TabIndex = 28
        Label3.Text = "CURP"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(117, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 27
        Label2.Text = "Apellidos"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(122, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 26
        Label1.Text = "Nombre"
        ' 
        ' dtp_vigencia_licencia
        ' 
        dtp_vigencia_licencia.Location = New Point(621, 49)
        dtp_vigencia_licencia.Name = "dtp_vigencia_licencia"
        dtp_vigencia_licencia.Size = New Size(164, 23)
        dtp_vigencia_licencia.TabIndex = 47
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {idconductor, nombre, apellidos, curp, rfc, area_trabajo, fecha_vigencia_licencia, estatus})
        DataGridView1.Location = New Point(12, 449)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(843, 354)
        DataGridView1.TabIndex = 48
        ' 
        ' idconductor
        ' 
        idconductor.HeaderText = "Column1"
        idconductor.Name = "idconductor"
        idconductor.Resizable = DataGridViewTriState.False
        idconductor.Visible = False
        ' 
        ' nombre
        ' 
        nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        nombre.HeaderText = "Nombre"
        nombre.Name = "nombre"
        ' 
        ' apellidos
        ' 
        apellidos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        apellidos.HeaderText = "Apellidos"
        apellidos.Name = "apellidos"
        ' 
        ' curp
        ' 
        curp.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        curp.HeaderText = "CURP"
        curp.Name = "curp"
        ' 
        ' rfc
        ' 
        rfc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        rfc.HeaderText = "RFC"
        rfc.Name = "rfc"
        ' 
        ' area_trabajo
        ' 
        area_trabajo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        area_trabajo.HeaderText = "Area de Trabajo"
        area_trabajo.Name = "area_trabajo"
        ' 
        ' fecha_vigencia_licencia
        ' 
        fecha_vigencia_licencia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        fecha_vigencia_licencia.HeaderText = "Fecha de Vigencia de Licencia"
        fecha_vigencia_licencia.Name = "fecha_vigencia_licencia"
        ' 
        ' estatus
        ' 
        estatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        estatus.HeaderText = "Estatus"
        estatus.Name = "estatus"
        ' 
        ' btn_limpiar
        ' 
        btn_limpiar.Font = New Font("Arial Narrow", 20.25F)
        btn_limpiar.Location = New Point(362, 395)
        btn_limpiar.Name = "btn_limpiar"
        btn_limpiar.Size = New Size(182, 48)
        btn_limpiar.TabIndex = 51
        btn_limpiar.Text = "Limpiar"
        btn_limpiar.UseVisualStyleBackColor = True
        ' 
        ' btn_volver
        ' 
        btn_volver.Font = New Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_volver.Location = New Point(550, 395)
        btn_volver.Name = "btn_volver"
        btn_volver.Size = New Size(182, 48)
        btn_volver.TabIndex = 50
        btn_volver.Text = "Volver"
        btn_volver.UseVisualStyleBackColor = True
        ' 
        ' btn_guardar
        ' 
        btn_guardar.Font = New Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_guardar.Location = New Point(174, 395)
        btn_guardar.Name = "btn_guardar"
        btn_guardar.Size = New Size(182, 48)
        btn_guardar.TabIndex = 49
        btn_guardar.Text = "Guardar"
        btn_guardar.UseVisualStyleBackColor = True
        ' 
        ' Form_conductores
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(867, 815)
        Controls.Add(btn_limpiar)
        Controls.Add(btn_volver)
        Controls.Add(btn_guardar)
        Controls.Add(DataGridView1)
        Controls.Add(dtp_vigencia_licencia)
        Controls.Add(GroupBox1)
        Controls.Add(txt_area_trabajo)
        Controls.Add(txt_rfc)
        Controls.Add(txt_curp)
        Controls.Add(txt_apellidos)
        Controls.Add(txt_nombres)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form_conductores"
        Text = "Conductores Registrados"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_baja As RadioButton
    Friend WithEvents rb_activo As RadioButton
    Friend WithEvents txt_area_trabajo As TextBox
    Friend WithEvents txt_rfc As TextBox
    Friend WithEvents txt_curp As TextBox
    Friend WithEvents txt_apellidos As TextBox
    Friend WithEvents txt_nombres As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_vigencia_licencia As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_volver As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents idconductor As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents apellidos As DataGridViewTextBoxColumn
    Friend WithEvents curp As DataGridViewTextBoxColumn
    Friend WithEvents rfc As DataGridViewTextBoxColumn
    Friend WithEvents area_trabajo As DataGridViewTextBoxColumn
    Friend WithEvents fecha_vigencia_licencia As DataGridViewTextBoxColumn
    Friend WithEvents estatus As DataGridViewTextBoxColumn
End Class
