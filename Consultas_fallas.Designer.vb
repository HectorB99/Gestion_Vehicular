<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultas
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
        cb_fecha = New CheckBox()
        DataGridView1 = New DataGridView()
        lbl_persona = New Label()
        txt_persona = New TextBox()
        lbl_folio = New Label()
        txt_folio = New TextBox()
        dtp_fechainicial = New DateTimePicker()
        lbl_desde = New Label()
        btn_buscar = New Button()
        btn_volver = New Button()
        lbl_hasta = New Label()
        dtp_fechafinal = New DateTimePicker()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cb_fecha
        ' 
        cb_fecha.AutoSize = True
        cb_fecha.Location = New Point(168, 112)
        cb_fecha.Name = "cb_fecha"
        cb_fecha.Size = New Size(57, 19)
        cb_fecha.TabIndex = 2
        cb_fecha.Text = "Fecha"
        cb_fecha.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 244)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(556, 374)
        DataGridView1.TabIndex = 1
        ' 
        ' lbl_persona
        ' 
        lbl_persona.AutoSize = True
        lbl_persona.Location = New Point(12, 37)
        lbl_persona.Name = "lbl_persona"
        lbl_persona.Size = New Size(49, 15)
        lbl_persona.TabIndex = 2
        lbl_persona.Text = "Persona"
        ' 
        ' txt_persona
        ' 
        txt_persona.Location = New Point(87, 34)
        txt_persona.Name = "txt_persona"
        txt_persona.Size = New Size(237, 23)
        txt_persona.TabIndex = 3
        ' 
        ' lbl_folio
        ' 
        lbl_folio.AutoSize = True
        lbl_folio.Location = New Point(12, 89)
        lbl_folio.Name = "lbl_folio"
        lbl_folio.Size = New Size(33, 15)
        lbl_folio.TabIndex = 4
        lbl_folio.Text = "Folio"
        ' 
        ' txt_folio
        ' 
        txt_folio.Location = New Point(87, 81)
        txt_folio.Name = "txt_folio"
        txt_folio.Size = New Size(237, 23)
        txt_folio.TabIndex = 5
        ' 
        ' dtp_fechainicial
        ' 
        dtp_fechainicial.Location = New Point(87, 137)
        dtp_fechainicial.Name = "dtp_fechainicial"
        dtp_fechainicial.Size = New Size(97, 23)
        dtp_fechainicial.TabIndex = 6
        ' 
        ' lbl_desde
        ' 
        lbl_desde.AutoSize = True
        lbl_desde.Location = New Point(23, 143)
        lbl_desde.Name = "lbl_desde"
        lbl_desde.Size = New Size(39, 15)
        lbl_desde.TabIndex = 7
        lbl_desde.Text = "Desde"
        ' 
        ' btn_buscar
        ' 
        btn_buscar.Font = New Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_buscar.Location = New Point(382, 37)
        btn_buscar.Name = "btn_buscar"
        btn_buscar.Size = New Size(164, 42)
        btn_buscar.TabIndex = 8
        btn_buscar.Text = "Buscar"
        btn_buscar.UseVisualStyleBackColor = True
        ' 
        ' btn_volver
        ' 
        btn_volver.Font = New Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_volver.Location = New Point(382, 95)
        btn_volver.Name = "btn_volver"
        btn_volver.Size = New Size(164, 42)
        btn_volver.TabIndex = 9
        btn_volver.Text = "Volver"
        btn_volver.UseVisualStyleBackColor = True
        ' 
        ' lbl_hasta
        ' 
        lbl_hasta.AutoSize = True
        lbl_hasta.Location = New Point(23, 169)
        lbl_hasta.Name = "lbl_hasta"
        lbl_hasta.Size = New Size(37, 15)
        lbl_hasta.TabIndex = 10
        lbl_hasta.Text = "Hasta"
        ' 
        ' dtp_fechafinal
        ' 
        dtp_fechafinal.Location = New Point(87, 169)
        dtp_fechafinal.Name = "dtp_fechafinal"
        dtp_fechafinal.Size = New Size(97, 23)
        dtp_fechafinal.TabIndex = 11
        ' 
        ' consultas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(609, 630)
        Controls.Add(cb_fecha)
        Controls.Add(dtp_fechafinal)
        Controls.Add(lbl_hasta)
        Controls.Add(btn_volver)
        Controls.Add(btn_buscar)
        Controls.Add(lbl_desde)
        Controls.Add(dtp_fechainicial)
        Controls.Add(txt_folio)
        Controls.Add(lbl_folio)
        Controls.Add(txt_persona)
        Controls.Add(lbl_persona)
        Controls.Add(DataGridView1)
        Name = "consultas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "consultas"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents cb_fecha As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbl_persona As Label
    Friend WithEvents txt_persona As TextBox
    Friend WithEvents lbl_folio As Label
    Friend WithEvents txt_folio As TextBox
    Friend WithEvents dtp_fechainicial As DateTimePicker
    Friend WithEvents lbl_desde As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_volver As Button
    Friend WithEvents lbl_hasta As Label
    Friend WithEvents dtp_fechafinal As DateTimePicker
End Class
