<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_login
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
        btn_ingresar = New Button()
        Label1 = New Label()
        txt_usuario = New TextBox()
        txt_contraseña = New TextBox()
        Label2 = New Label()
        btn_salir = New Button()
        Label3 = New Label()
        cb_contraseña = New CheckBox()
        SuspendLayout()
        ' 
        ' btn_ingresar
        ' 
        btn_ingresar.BackColor = SystemColors.Control
        btn_ingresar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_ingresar.Location = New Point(208, 418)
        btn_ingresar.Name = "btn_ingresar"
        btn_ingresar.Size = New Size(106, 33)
        btn_ingresar.TabIndex = 0
        btn_ingresar.Text = " Ingresar"
        btn_ingresar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(182, 158)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 21)
        Label1.TabIndex = 1
        Label1.Text = "Usuario"
        Label1.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' txt_usuario
        ' 
        txt_usuario.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_usuario.Location = New Point(182, 193)
        txt_usuario.Multiline = True
        txt_usuario.Name = "txt_usuario"
        txt_usuario.Size = New Size(298, 32)
        txt_usuario.TabIndex = 2
        ' 
        ' txt_contraseña
        ' 
        txt_contraseña.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_contraseña.Location = New Point(182, 278)
        txt_contraseña.Multiline = True
        txt_contraseña.Name = "txt_contraseña"
        txt_contraseña.Size = New Size(298, 32)
        txt_contraseña.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(182, 243)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 21)
        Label2.TabIndex = 3
        Label2.Text = "Contraseña"
        Label2.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' btn_salir
        ' 
        btn_salir.BackColor = SystemColors.Control
        btn_salir.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_salir.Location = New Point(345, 418)
        btn_salir.Name = "btn_salir"
        btn_salir.Size = New Size(106, 33)
        btn_salir.TabIndex = 5
        btn_salir.Text = "Salir"
        btn_salir.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.MenuHighlight
        Label3.Location = New Point(293, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 29)
        Label3.TabIndex = 6
        Label3.Text = "Login"
        ' 
        ' cb_contraseña
        ' 
        cb_contraseña.AutoSize = True
        cb_contraseña.Location = New Point(182, 328)
        cb_contraseña.Name = "cb_contraseña"
        cb_contraseña.Size = New Size(128, 19)
        cb_contraseña.TabIndex = 7
        cb_contraseña.Text = "mostrar contraseña"
        cb_contraseña.UseVisualStyleBackColor = True
        ' 
        ' Form_login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(661, 591)
        Controls.Add(txt_usuario)
        Controls.Add(cb_contraseña)
        Controls.Add(btn_ingresar)
        Controls.Add(txt_contraseña)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_salir)
        Name = "Form_login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_ingresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_contraseña As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_salir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_contraseña As CheckBox
End Class
