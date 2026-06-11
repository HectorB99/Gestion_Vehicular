<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_mostrador_fotos
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
        PictureBox1 = New PictureBox()
        btn_subir_foto = New Button()
        btn_siguiente = New Button()
        btn_anterior = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(146, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(670, 674)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btn_subir_foto
        ' 
        btn_subir_foto.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_subir_foto.Location = New Point(378, 692)
        btn_subir_foto.Name = "btn_subir_foto"
        btn_subir_foto.Size = New Size(221, 48)
        btn_subir_foto.TabIndex = 1
        btn_subir_foto.Text = "Subir Nueva Foto"
        btn_subir_foto.UseVisualStyleBackColor = True
        ' 
        ' btn_siguiente
        ' 
        btn_siguiente.BackColor = Color.WhiteSmoke
        btn_siguiente.FlatAppearance.BorderSize = 0
        btn_siguiente.FlatAppearance.MouseDownBackColor = Color.Gray
        btn_siguiente.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
        btn_siguiente.FlatStyle = FlatStyle.Flat
        btn_siguiente.Font = New Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_siguiente.Location = New Point(822, 273)
        btn_siguiente.Name = "btn_siguiente"
        btn_siguiente.Size = New Size(133, 139)
        btn_siguiente.TabIndex = 2
        btn_siguiente.Text = ">"
        btn_siguiente.UseVisualStyleBackColor = False
        ' 
        ' btn_anterior
        ' 
        btn_anterior.BackColor = Color.WhiteSmoke
        btn_anterior.FlatAppearance.BorderSize = 0
        btn_anterior.FlatAppearance.MouseDownBackColor = Color.Gray
        btn_anterior.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
        btn_anterior.FlatStyle = FlatStyle.Flat
        btn_anterior.Font = New Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_anterior.Location = New Point(7, 273)
        btn_anterior.Name = "btn_anterior"
        btn_anterior.Size = New Size(133, 139)
        btn_anterior.TabIndex = 3
        btn_anterior.Text = "<"
        btn_anterior.UseVisualStyleBackColor = False
        ' 
        ' Form_mostrador_fotos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(964, 796)
        Controls.Add(btn_anterior)
        Controls.Add(btn_siguiente)
        Controls.Add(btn_subir_foto)
        Controls.Add(PictureBox1)
        Name = "Form_mostrador_fotos"
        Text = "Form_mostrador_fotos"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_subir_foto As Button
    Friend WithEvents btn_siguiente As Button
    Friend WithEvents btn_anterior As Button
End Class
