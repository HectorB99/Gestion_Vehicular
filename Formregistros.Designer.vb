<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lbl_persona = New Label()
        txt_persona = New TextBox()
        lbl_descripcion = New Label()
        txt_descripcion = New TextBox()
        lbl_folio = New Label()
        txtfolio = New Label()
        btn_guardar = New Button()
        btn_back = New Button()
        SuspendLayout()
        ' 
        ' lbl_persona
        ' 
        lbl_persona.AutoSize = True
        lbl_persona.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_persona.Location = New Point(25, 85)
        lbl_persona.Name = "lbl_persona"
        lbl_persona.Size = New Size(316, 30)
        lbl_persona.TabIndex = 0
        lbl_persona.Text = "Persona que reporta el problema"
        ' 
        ' txt_persona
        ' 
        txt_persona.Location = New Point(356, 92)
        txt_persona.Name = "txt_persona"
        txt_persona.Size = New Size(400, 23)
        txt_persona.TabIndex = 1
        ' 
        ' lbl_descripcion
        ' 
        lbl_descripcion.AutoSize = True
        lbl_descripcion.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_descripcion.Location = New Point(25, 160)
        lbl_descripcion.Name = "lbl_descripcion"
        lbl_descripcion.Size = New Size(249, 30)
        lbl_descripcion.TabIndex = 2
        lbl_descripcion.Text = "Descripción del problema"
        ' 
        ' txt_descripcion
        ' 
        txt_descripcion.Location = New Point(356, 160)
        txt_descripcion.Multiline = True
        txt_descripcion.Name = "txt_descripcion"
        txt_descripcion.Size = New Size(400, 90)
        txt_descripcion.TabIndex = 3
        ' 
        ' lbl_folio
        ' 
        lbl_folio.AutoSize = True
        lbl_folio.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_folio.Location = New Point(25, 24)
        lbl_folio.Name = "lbl_folio"
        lbl_folio.Size = New Size(57, 30)
        lbl_folio.TabIndex = 4
        lbl_folio.Text = "Folio"
        ' 
        ' txtfolio
        ' 
        txtfolio.AutoSize = True
        txtfolio.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtfolio.Location = New Point(356, 24)
        txtfolio.Name = "txtfolio"
        txtfolio.Size = New Size(0, 30)
        txtfolio.TabIndex = 5
        ' 
        ' btn_guardar
        ' 
        btn_guardar.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_guardar.Location = New Point(79, 214)
        btn_guardar.Name = "btn_guardar"
        btn_guardar.Size = New Size(150, 36)
        btn_guardar.TabIndex = 6
        btn_guardar.Text = "Guardar"
        btn_guardar.UseVisualStyleBackColor = True
        ' 
        ' btn_back
        ' 
        btn_back.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_back.Location = New Point(294, 283)
        btn_back.Name = "btn_back"
        btn_back.Size = New Size(159, 40)
        btn_back.TabIndex = 7
        btn_back.Text = "Volver"
        btn_back.UseVisualStyleBackColor = True
        ' 
        ' registro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(793, 346)
        Controls.Add(btn_back)
        Controls.Add(btn_guardar)
        Controls.Add(txtfolio)
        Controls.Add(lbl_folio)
        Controls.Add(txt_descripcion)
        Controls.Add(lbl_descripcion)
        Controls.Add(txt_persona)
        Controls.Add(lbl_persona)
        Name = "registro"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registro"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_persona As Label
    Friend WithEvents txt_persona As TextBox
    Friend WithEvents lbl_descripcion As Label
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents lbl_folio As Label
    Friend WithEvents txtfolio As Label
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_back As Button

End Class
