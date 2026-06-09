<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formcontrolfallas
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
        btn_registrar = New Button()
        btn_consultar = New Button()
        Label1 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' btn_registrar
        ' 
        btn_registrar.Font = New Font("Calibri", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_registrar.Location = New Point(65, 82)
        btn_registrar.Name = "btn_registrar"
        btn_registrar.Size = New Size(275, 58)
        btn_registrar.TabIndex = 0
        btn_registrar.Text = "Registrar"
        btn_registrar.UseVisualStyleBackColor = True
        ' 
        ' btn_consultar
        ' 
        btn_consultar.Font = New Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_consultar.Location = New Point(65, 164)
        btn_consultar.Name = "btn_consultar"
        btn_consultar.Size = New Size(275, 58)
        btn_consultar.TabIndex = 1
        btn_consultar.Text = "Consultar"
        btn_consultar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(52, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(281, 23)
        Label1.TabIndex = 2
        Label1.Text = "CONTROL DE REPORTE DE FALLAS"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(65, 246)
        Button1.Name = "Button1"
        Button1.Size = New Size(275, 58)
        Button1.TabIndex = 3
        Button1.Text = "Volver"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Formcontrolfallas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(398, 325)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(btn_consultar)
        Controls.Add(btn_registrar)
        Name = "Formcontrolfallas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Control de Fallas"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_registrar As Button
    Friend WithEvents btn_consultar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
