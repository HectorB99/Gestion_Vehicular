<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_sucursal
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
        cb_sucursal = New ComboBox()
        btn_aceptar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 25)
        Label1.TabIndex = 0
        Label1.Text = "Seleccione Sucursal"
        ' 
        ' cb_sucursal
        ' 
        cb_sucursal.Font = New Font("Segoe UI", 14.25F)
        cb_sucursal.FormattingEnabled = True
        cb_sucursal.Location = New Point(227, 29)
        cb_sucursal.Name = "cb_sucursal"
        cb_sucursal.Size = New Size(201, 33)
        cb_sucursal.TabIndex = 1
        ' 
        ' btn_aceptar
        ' 
        btn_aceptar.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_aceptar.Location = New Point(152, 78)
        btn_aceptar.Name = "btn_aceptar"
        btn_aceptar.Size = New Size(139, 37)
        btn_aceptar.TabIndex = 2
        btn_aceptar.Text = "Aceptar"
        btn_aceptar.UseVisualStyleBackColor = True
        ' 
        ' Form_sucursal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(481, 124)
        Controls.Add(btn_aceptar)
        Controls.Add(cb_sucursal)
        Controls.Add(Label1)
        Name = "Form_sucursal"
        Text = "Form_sucursal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cb_sucursal As ComboBox
    Friend WithEvents btn_aceptar As Button
End Class
