<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        MenuStrip1 = New MenuStrip()
        ControlDeReportesDeFallasToolStripMenuItem = New ToolStripMenuItem()
        ConsultarToolStripMenuItem = New ToolStripMenuItem()
        ConsultarToolStripMenuItem1 = New ToolStripMenuItem()
        ControlVehicularToolStripMenuItem = New ToolStripMenuItem()
        RegistrarToolStripMenuItem = New ToolStripMenuItem()
        ConsultarVehiculoToolStripMenuItem = New ToolStripMenuItem()
        ReportesToolStripMenuItem = New ToolStripMenuItem()
        CompraDeRefaccionesToolStripMenuItem = New ToolStripMenuItem()
        RegistroDeServiciosToolStripMenuItem = New ToolStripMenuItem()
        UtileriasToolStripMenuItem = New ToolStripMenuItem()
        ProveedoresToolStripMenuItem = New ToolStripMenuItem()
        TiposDeRefacciónToolStripMenuItem = New ToolStripMenuItem()
        ConductoresToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ControlDeReportesDeFallasToolStripMenuItem, ControlVehicularToolStripMenuItem, UtileriasToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1241, 24)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ControlDeReportesDeFallasToolStripMenuItem
        ' 
        ControlDeReportesDeFallasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ConsultarToolStripMenuItem, ConsultarToolStripMenuItem1})
        ControlDeReportesDeFallasToolStripMenuItem.Name = "ControlDeReportesDeFallasToolStripMenuItem"
        ControlDeReportesDeFallasToolStripMenuItem.Size = New Size(172, 20)
        ControlDeReportesDeFallasToolStripMenuItem.Text = "Control de Reportes de Fallas"
        ' 
        ' ConsultarToolStripMenuItem
        ' 
        ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        ConsultarToolStripMenuItem.Size = New Size(125, 22)
        ConsultarToolStripMenuItem.Text = "Registrar"
        ' 
        ' ConsultarToolStripMenuItem1
        ' 
        ConsultarToolStripMenuItem1.Name = "ConsultarToolStripMenuItem1"
        ConsultarToolStripMenuItem1.Size = New Size(125, 22)
        ConsultarToolStripMenuItem1.Text = "Consultar"
        ' 
        ' ControlVehicularToolStripMenuItem
        ' 
        ControlVehicularToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RegistrarToolStripMenuItem, ConsultarVehiculoToolStripMenuItem, ReportesToolStripMenuItem, CompraDeRefaccionesToolStripMenuItem, RegistroDeServiciosToolStripMenuItem})
        ControlVehicularToolStripMenuItem.Name = "ControlVehicularToolStripMenuItem"
        ControlVehicularToolStripMenuItem.Size = New Size(110, 20)
        ControlVehicularToolStripMenuItem.Text = "Control Vehicular"
        ' 
        ' RegistrarToolStripMenuItem
        ' 
        RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        RegistrarToolStripMenuItem.Size = New Size(196, 22)
        RegistrarToolStripMenuItem.Text = "Registrar"
        ' 
        ' ConsultarVehiculoToolStripMenuItem
        ' 
        ConsultarVehiculoToolStripMenuItem.Name = "ConsultarVehiculoToolStripMenuItem"
        ConsultarVehiculoToolStripMenuItem.Size = New Size(196, 22)
        ConsultarVehiculoToolStripMenuItem.Text = "Consultar Vehiculo"
        ' 
        ' ReportesToolStripMenuItem
        ' 
        ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        ReportesToolStripMenuItem.Size = New Size(196, 22)
        ReportesToolStripMenuItem.Text = "Reportes"
        ' 
        ' CompraDeRefaccionesToolStripMenuItem
        ' 
        CompraDeRefaccionesToolStripMenuItem.Name = "CompraDeRefaccionesToolStripMenuItem"
        CompraDeRefaccionesToolStripMenuItem.Size = New Size(196, 22)
        CompraDeRefaccionesToolStripMenuItem.Text = "Compra de refacciones"
        ' 
        ' RegistroDeServiciosToolStripMenuItem
        ' 
        RegistroDeServiciosToolStripMenuItem.Name = "RegistroDeServiciosToolStripMenuItem"
        RegistroDeServiciosToolStripMenuItem.Size = New Size(196, 22)
        RegistroDeServiciosToolStripMenuItem.Text = "Registro de Servicios"
        ' 
        ' UtileriasToolStripMenuItem
        ' 
        UtileriasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProveedoresToolStripMenuItem, TiposDeRefacciónToolStripMenuItem, ConductoresToolStripMenuItem})
        UtileriasToolStripMenuItem.Name = "UtileriasToolStripMenuItem"
        UtileriasToolStripMenuItem.Size = New Size(61, 20)
        UtileriasToolStripMenuItem.Text = "Utilerias"
        ' 
        ' ProveedoresToolStripMenuItem
        ' 
        ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        ProveedoresToolStripMenuItem.Size = New Size(180, 22)
        ProveedoresToolStripMenuItem.Text = "Proveedores"
        ' 
        ' TiposDeRefacciónToolStripMenuItem
        ' 
        TiposDeRefacciónToolStripMenuItem.Name = "TiposDeRefacciónToolStripMenuItem"
        TiposDeRefacciónToolStripMenuItem.Size = New Size(180, 22)
        TiposDeRefacciónToolStripMenuItem.Text = "Tipos de Refacción"
        ' 
        ' ConductoresToolStripMenuItem
        ' 
        ConductoresToolStripMenuItem.Name = "ConductoresToolStripMenuItem"
        ConductoresToolStripMenuItem.Size = New Size(180, 22)
        ConductoresToolStripMenuItem.Text = "Conductores"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1241, 595)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ControlDeReportesDeFallasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ControlVehicularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarVehiculoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtileriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompraDeRefaccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroDeServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDeRefacciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConductoresToolStripMenuItem As ToolStripMenuItem
End Class
