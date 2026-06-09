<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_tipo_refaccion
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
        DataGridView1 = New DataGridView()
        idtipopieza = New DataGridViewTextBoxColumn()
        descripcion = New DataGridViewTextBoxColumn()
        estatus = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        txt_descripcion = New TextBox()
        GroupBox1 = New GroupBox()
        rb_deshabilitado = New RadioButton()
        rb_habilitado = New RadioButton()
        btn_guardar = New Button()
        btn_volver = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {idtipopieza, descripcion, estatus})
        DataGridView1.Location = New Point(12, 40)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(301, 410)
        DataGridView1.TabIndex = 0
        ' 
        ' idtipopieza
        ' 
        idtipopieza.HeaderText = "idtipopieza"
        idtipopieza.Name = "idtipopieza"
        idtipopieza.Visible = False
        ' 
        ' descripcion
        ' 
        descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        descripcion.HeaderText = "Descripcion"
        descripcion.Name = "descripcion"
        ' 
        ' estatus
        ' 
        estatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        estatus.HeaderText = "Estatus"
        estatus.Name = "estatus"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(331, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 21)
        Label1.TabIndex = 1
        Label1.Text = "Descripción"
        ' 
        ' txt_descripcion
        ' 
        txt_descripcion.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_descripcion.Location = New Point(428, 103)
        txt_descripcion.Name = "txt_descripcion"
        txt_descripcion.Size = New Size(191, 29)
        txt_descripcion.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rb_deshabilitado)
        GroupBox1.Controls.Add(rb_habilitado)
        GroupBox1.Location = New Point(331, 162)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(288, 54)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Estatus"
        ' 
        ' rb_deshabilitado
        ' 
        rb_deshabilitado.AutoSize = True
        rb_deshabilitado.Location = New Point(185, 22)
        rb_deshabilitado.Name = "rb_deshabilitado"
        rb_deshabilitado.Size = New Size(97, 19)
        rb_deshabilitado.TabIndex = 1
        rb_deshabilitado.TabStop = True
        rb_deshabilitado.Text = "Deshabilitado"
        rb_deshabilitado.UseVisualStyleBackColor = True
        ' 
        ' rb_habilitado
        ' 
        rb_habilitado.AutoSize = True
        rb_habilitado.Location = New Point(6, 22)
        rb_habilitado.Name = "rb_habilitado"
        rb_habilitado.Size = New Size(80, 19)
        rb_habilitado.TabIndex = 0
        rb_habilitado.TabStop = True
        rb_habilitado.Text = "Habilitado"
        rb_habilitado.UseVisualStyleBackColor = True
        ' 
        ' btn_guardar
        ' 
        btn_guardar.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_guardar.Location = New Point(337, 279)
        btn_guardar.Name = "btn_guardar"
        btn_guardar.Size = New Size(130, 39)
        btn_guardar.TabIndex = 4
        btn_guardar.Text = "Guardar"
        btn_guardar.UseVisualStyleBackColor = True
        ' 
        ' btn_volver
        ' 
        btn_volver.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_volver.Location = New Point(490, 279)
        btn_volver.Name = "btn_volver"
        btn_volver.Size = New Size(130, 39)
        btn_volver.TabIndex = 5
        btn_volver.Text = "Volver"
        btn_volver.UseVisualStyleBackColor = True
        ' 
        ' Form_tipo_refaccion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(655, 493)
        Controls.Add(btn_volver)
        Controls.Add(btn_guardar)
        Controls.Add(GroupBox1)
        Controls.Add(txt_descripcion)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "Form_tipo_refaccion"
        Text = "Tipos de refacción"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_deshabilitado As RadioButton
    Friend WithEvents rb_habilitado As RadioButton
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_volver As Button
    Friend WithEvents idtipopieza As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents estatus As DataGridViewTextBoxColumn
End Class
