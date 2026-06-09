<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_control_vehicular
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
        Button1 = New Button()
        Label1 = New Label()
        btn_consultar = New Button()
        btn_registrar = New Button()
        Button2 = New Button()
        btn_compra_refacciones = New Button()
        btn_servicios = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(36, 476)
        Button1.Name = "Button1"
        Button1.Size = New Size(275, 58)
        Button1.TabIndex = 7
        Button1.Text = "Volver"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(60, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(227, 29)
        Label1.TabIndex = 6
        Label1.Text = "CONTROL VEHICULAR"
        ' 
        ' btn_consultar
        ' 
        btn_consultar.Font = New Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_consultar.Location = New Point(36, 237)
        btn_consultar.Name = "btn_consultar"
        btn_consultar.Size = New Size(275, 58)
        btn_consultar.TabIndex = 5
        btn_consultar.Text = "Consultar Vehiculo"
        btn_consultar.UseVisualStyleBackColor = True
        ' 
        ' btn_registrar
        ' 
        btn_registrar.Font = New Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_registrar.Location = New Point(36, 80)
        btn_registrar.Name = "btn_registrar"
        btn_registrar.Size = New Size(275, 58)
        btn_registrar.TabIndex = 4
        btn_registrar.Text = "Registrar Vehiculo"
        btn_registrar.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(36, 395)
        Button2.Name = "Button2"
        Button2.Size = New Size(275, 58)
        Button2.TabIndex = 8
        Button2.Text = "Reportes"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btn_compra_refacciones
        ' 
        btn_compra_refacciones.Font = New Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_compra_refacciones.Location = New Point(36, 159)
        btn_compra_refacciones.Name = "btn_compra_refacciones"
        btn_compra_refacciones.Size = New Size(275, 58)
        btn_compra_refacciones.TabIndex = 9
        btn_compra_refacciones.Text = "Compra de Refacciones"
        btn_compra_refacciones.UseVisualStyleBackColor = True
        ' 
        ' btn_servicios
        ' 
        btn_servicios.Font = New Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_servicios.Location = New Point(36, 317)
        btn_servicios.Name = "btn_servicios"
        btn_servicios.Size = New Size(275, 58)
        btn_servicios.TabIndex = 10
        btn_servicios.Text = "Registro de Servicios"
        btn_servicios.UseVisualStyleBackColor = True
        ' 
        ' Form_control_vehicular
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(350, 587)
        Controls.Add(btn_servicios)
        Controls.Add(btn_compra_refacciones)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(btn_consultar)
        Controls.Add(btn_registrar)
        Name = "Form_control_vehicular"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form_control_vehicular"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_consultar As Button
    Friend WithEvents btn_registrar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_compra_refacciones As Button
    Friend WithEvents btn_servicios As Button
End Class
