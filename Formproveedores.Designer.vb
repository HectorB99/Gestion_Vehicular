<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formproveedores
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
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txt_nombre = New TextBox()
        txt_telefono = New TextBox()
        txt_correo = New TextBox()
        txt_direccion = New TextBox()
        txt_ciudad = New TextBox()
        txt_estado = New TextBox()
        txt_pais = New TextBox()
        txt_rfc = New TextBox()
        btn_guardar = New Button()
        btn_limpiar = New Button()
        btn_volver = New Button()
        DataGridView1 = New DataGridView()
        idproveedor = New DataGridViewTextBoxColumn()
        nombre_proveedor = New DataGridViewTextBoxColumn()
        telefono = New DataGridViewTextBoxColumn()
        email = New DataGridViewTextBoxColumn()
        direccion = New DataGridViewTextBoxColumn()
        ciudad = New DataGridViewTextBoxColumn()
        estado = New DataGridViewTextBoxColumn()
        pais = New DataGridViewTextBoxColumn()
        rfc = New DataGridViewTextBoxColumn()
        estatus = New DataGridViewTextBoxColumn()
        GroupBox1 = New GroupBox()
        rb_baja = New RadioButton()
        rb_activo = New RadioButton()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(214, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 21)
        Label1.TabIndex = 0
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(162, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 21)
        Label2.TabIndex = 1
        Label2.Text = "Num. telefónico"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(144, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 21)
        Label3.TabIndex = 2
        Label3.Text = "Correo electronico"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(207, 187)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 21)
        Label4.TabIndex = 3
        Label4.Text = "Dirección"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(590, 28)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 21)
        Label5.TabIndex = 4
        Label5.Text = "Ciudad"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(593, 78)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 21)
        Label6.TabIndex = 5
        Label6.Text = "Estado"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(612, 133)
        Label7.Name = "Label7"
        Label7.Size = New Size(37, 21)
        Label7.TabIndex = 6
        Label7.Text = "País"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.Location = New Point(611, 187)
        Label8.Name = "Label8"
        Label8.Size = New Size(38, 21)
        Label8.TabIndex = 7
        Label8.Text = "RFC"
        ' 
        ' txt_nombre
        ' 
        txt_nombre.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_nombre.Location = New Point(303, 26)
        txt_nombre.Name = "txt_nombre"
        txt_nombre.Size = New Size(200, 27)
        txt_nombre.TabIndex = 8
        ' 
        ' txt_telefono
        ' 
        txt_telefono.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_telefono.Location = New Point(303, 76)
        txt_telefono.Name = "txt_telefono"
        txt_telefono.Size = New Size(200, 27)
        txt_telefono.TabIndex = 9
        ' 
        ' txt_correo
        ' 
        txt_correo.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_correo.Location = New Point(303, 131)
        txt_correo.Name = "txt_correo"
        txt_correo.Size = New Size(200, 27)
        txt_correo.TabIndex = 10
        ' 
        ' txt_direccion
        ' 
        txt_direccion.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_direccion.Location = New Point(303, 185)
        txt_direccion.Name = "txt_direccion"
        txt_direccion.Size = New Size(200, 27)
        txt_direccion.TabIndex = 11
        ' 
        ' txt_ciudad
        ' 
        txt_ciudad.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_ciudad.Location = New Point(670, 26)
        txt_ciudad.Name = "txt_ciudad"
        txt_ciudad.Size = New Size(200, 27)
        txt_ciudad.TabIndex = 12
        ' 
        ' txt_estado
        ' 
        txt_estado.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_estado.Location = New Point(670, 76)
        txt_estado.Name = "txt_estado"
        txt_estado.Size = New Size(200, 27)
        txt_estado.TabIndex = 13
        ' 
        ' txt_pais
        ' 
        txt_pais.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_pais.Location = New Point(670, 131)
        txt_pais.Name = "txt_pais"
        txt_pais.Size = New Size(200, 27)
        txt_pais.TabIndex = 14
        ' 
        ' txt_rfc
        ' 
        txt_rfc.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_rfc.Location = New Point(670, 185)
        txt_rfc.Name = "txt_rfc"
        txt_rfc.Size = New Size(200, 27)
        txt_rfc.TabIndex = 15
        ' 
        ' btn_guardar
        ' 
        btn_guardar.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_guardar.Location = New Point(339, 303)
        btn_guardar.Name = "btn_guardar"
        btn_guardar.Size = New Size(120, 36)
        btn_guardar.TabIndex = 16
        btn_guardar.Text = "Guardar"
        btn_guardar.UseVisualStyleBackColor = True
        ' 
        ' btn_limpiar
        ' 
        btn_limpiar.Font = New Font("Segoe UI", 14.25F)
        btn_limpiar.Location = New Point(524, 303)
        btn_limpiar.Name = "btn_limpiar"
        btn_limpiar.Size = New Size(120, 36)
        btn_limpiar.TabIndex = 17
        btn_limpiar.Text = "Limpiar"
        btn_limpiar.UseVisualStyleBackColor = True
        ' 
        ' btn_volver
        ' 
        btn_volver.Font = New Font("Segoe UI", 14.25F)
        btn_volver.Location = New Point(711, 303)
        btn_volver.Name = "btn_volver"
        btn_volver.Size = New Size(120, 36)
        btn_volver.TabIndex = 18
        btn_volver.Text = "Volver"
        btn_volver.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {idproveedor, nombre_proveedor, telefono, email, direccion, ciudad, estado, pais, rfc, estatus})
        DataGridView1.Location = New Point(12, 365)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1130, 335)
        DataGridView1.TabIndex = 19
        ' 
        ' idproveedor
        ' 
        idproveedor.HeaderText = "Column1"
        idproveedor.Name = "idproveedor"
        idproveedor.Visible = False
        ' 
        ' nombre_proveedor
        ' 
        nombre_proveedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        nombre_proveedor.HeaderText = "Nombre"
        nombre_proveedor.Name = "nombre_proveedor"
        ' 
        ' telefono
        ' 
        telefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        telefono.HeaderText = "Teléfono"
        telefono.Name = "telefono"
        ' 
        ' email
        ' 
        email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        email.HeaderText = "Correo Electronico"
        email.Name = "email"
        ' 
        ' direccion
        ' 
        direccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        direccion.HeaderText = "Dirección"
        direccion.Name = "direccion"
        ' 
        ' ciudad
        ' 
        ciudad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ciudad.HeaderText = "Ciudad"
        ciudad.Name = "ciudad"
        ' 
        ' estado
        ' 
        estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        estado.HeaderText = "Estado"
        estado.Name = "estado"
        ' 
        ' pais
        ' 
        pais.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        pais.HeaderText = "País"
        pais.Name = "pais"
        ' 
        ' rfc
        ' 
        rfc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        rfc.HeaderText = "RFC"
        rfc.Name = "rfc"
        ' 
        ' estatus
        ' 
        estatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        estatus.HeaderText = "Estatus"
        estatus.Name = "estatus"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rb_baja)
        GroupBox1.Controls.Add(rb_activo)
        GroupBox1.Location = New Point(445, 230)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(256, 54)
        GroupBox1.TabIndex = 26
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
        ' Formproveedores
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1154, 717)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Controls.Add(btn_volver)
        Controls.Add(btn_limpiar)
        Controls.Add(btn_guardar)
        Controls.Add(txt_rfc)
        Controls.Add(txt_pais)
        Controls.Add(txt_estado)
        Controls.Add(txt_ciudad)
        Controls.Add(txt_direccion)
        Controls.Add(txt_correo)
        Controls.Add(txt_telefono)
        Controls.Add(txt_nombre)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Formproveedores"
        Text = "Proveedores"
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
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents txt_ciudad As TextBox
    Friend WithEvents txt_estado As TextBox
    Friend WithEvents txt_pais As TextBox
    Friend WithEvents txt_rfc As TextBox
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_volver As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents idproveedor As DataGridViewTextBoxColumn
    Friend WithEvents nombre_proveedor As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents ciudad As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents pais As DataGridViewTextBoxColumn
    Friend WithEvents rfc As DataGridViewTextBoxColumn
    Friend WithEvents estatus As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_baja As RadioButton
    Friend WithEvents rb_activo As RadioButton
End Class
