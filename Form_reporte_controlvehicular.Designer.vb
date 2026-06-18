<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_reporte_controlvehicular
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
        cb_vehiculos = New ComboBox()
        Label2 = New Label()
        btn_reporte = New Button()
        btn_volver = New Button()
        dtp_fechafinal = New DateTimePicker()
        lbl_hasta = New Label()
        lbl_desde = New Label()
        dtp_fechainicial = New DateTimePicker()
        btn_export_xlsx = New Button()
        Label1 = New Label()
        cb_tipo_reporte = New ComboBox()
        btn_imprimir = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 111)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1145, 627)
        DataGridView1.TabIndex = 0
        ' 
        ' cb_vehiculos
        ' 
        cb_vehiculos.FormattingEnabled = True
        cb_vehiculos.Location = New Point(207, 22)
        cb_vehiculos.Name = "cb_vehiculos"
        cb_vehiculos.Size = New Size(300, 23)
        cb_vehiculos.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(189, 25)
        Label2.TabIndex = 3
        Label2.Text = "Seleccione el vehiculo"
        ' 
        ' btn_reporte
        ' 
        btn_reporte.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_reporte.Font = New Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_reporte.Location = New Point(831, 17)
        btn_reporte.Name = "btn_reporte"
        btn_reporte.Size = New Size(161, 41)
        btn_reporte.TabIndex = 4
        btn_reporte.Text = "Generar Reporte"
        btn_reporte.UseVisualStyleBackColor = True
        ' 
        ' btn_volver
        ' 
        btn_volver.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_volver.FlatStyle = FlatStyle.System
        btn_volver.Font = New Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_volver.Location = New Point(831, 64)
        btn_volver.Name = "btn_volver"
        btn_volver.Size = New Size(161, 41)
        btn_volver.TabIndex = 5
        btn_volver.Text = "Volver"
        btn_volver.UseVisualStyleBackColor = True
        ' 
        ' dtp_fechafinal
        ' 
        dtp_fechafinal.Location = New Point(601, 61)
        dtp_fechafinal.Name = "dtp_fechafinal"
        dtp_fechafinal.Size = New Size(118, 23)
        dtp_fechafinal.TabIndex = 16
        dtp_fechafinal.Value = New Date(2026, 6, 3, 16, 39, 40, 0)
        ' 
        ' lbl_hasta
        ' 
        lbl_hasta.AutoSize = True
        lbl_hasta.Location = New Point(539, 64)
        lbl_hasta.Name = "lbl_hasta"
        lbl_hasta.Size = New Size(37, 15)
        lbl_hasta.TabIndex = 15
        lbl_hasta.Text = "Hasta"
        ' 
        ' lbl_desde
        ' 
        lbl_desde.AutoSize = True
        lbl_desde.Location = New Point(537, 25)
        lbl_desde.Name = "lbl_desde"
        lbl_desde.Size = New Size(39, 15)
        lbl_desde.TabIndex = 14
        lbl_desde.Text = "Desde"
        ' 
        ' dtp_fechainicial
        ' 
        dtp_fechainicial.Location = New Point(601, 19)
        dtp_fechainicial.Name = "dtp_fechainicial"
        dtp_fechainicial.Size = New Size(118, 23)
        dtp_fechainicial.TabIndex = 13
        ' 
        ' btn_export_xlsx
        ' 
        btn_export_xlsx.Font = New Font("Arial Narrow", 15.75F)
        btn_export_xlsx.Location = New Point(996, 17)
        btn_export_xlsx.Name = "btn_export_xlsx"
        btn_export_xlsx.Size = New Size(161, 41)
        btn_export_xlsx.TabIndex = 17
        btn_export_xlsx.Text = "Exportar a Excel"
        btn_export_xlsx.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 15.75F)
        Label1.Location = New Point(61, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 25)
        Label1.TabIndex = 18
        Label1.Text = "Tipo de Reporte"
        ' 
        ' cb_tipo_reporte
        ' 
        cb_tipo_reporte.FormattingEnabled = True
        cb_tipo_reporte.Location = New Point(207, 64)
        cb_tipo_reporte.Name = "cb_tipo_reporte"
        cb_tipo_reporte.Size = New Size(300, 23)
        cb_tipo_reporte.TabIndex = 19
        ' 
        ' btn_imprimir
        ' 
        btn_imprimir.Font = New Font("Arial Narrow", 15.75F)
        btn_imprimir.Location = New Point(998, 64)
        btn_imprimir.Name = "btn_imprimir"
        btn_imprimir.Size = New Size(158, 41)
        btn_imprimir.TabIndex = 20
        btn_imprimir.Text = "Imprimir"
        btn_imprimir.UseVisualStyleBackColor = True
        ' 
        ' Form_reporte_controlvehicular
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1168, 750)
        Controls.Add(btn_imprimir)
        Controls.Add(cb_tipo_reporte)
        Controls.Add(Label1)
        Controls.Add(btn_export_xlsx)
        Controls.Add(dtp_fechafinal)
        Controls.Add(lbl_hasta)
        Controls.Add(lbl_desde)
        Controls.Add(dtp_fechainicial)
        Controls.Add(btn_volver)
        Controls.Add(btn_reporte)
        Controls.Add(Label2)
        Controls.Add(cb_vehiculos)
        Controls.Add(DataGridView1)
        Name = "Form_reporte_controlvehicular"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reporte de Control Vehicular"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cb_vehiculos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_reporte As Button
    Friend WithEvents btn_volver As Button
    Friend WithEvents dtp_fechafinal As DateTimePicker
    Friend WithEvents lbl_hasta As Label
    Friend WithEvents lbl_desde As Label
    Friend WithEvents dtp_fechainicial As DateTimePicker
    Friend WithEvents btn_export_xlsx As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_tipo_reporte As ComboBox
    Friend WithEvents btn_imprimir As Button
End Class
