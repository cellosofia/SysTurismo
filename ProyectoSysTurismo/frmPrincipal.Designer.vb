<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.mnuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.mnuArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuABMs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAlojamientos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHabitacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucursalAlojamientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucursalEmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTablasMenores = New System.Windows.Forms.ToolStripMenuItem()
        Me.CiudadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaísToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsPrincipal = New System.Windows.Forms.StatusStrip()
        Me.lblFechaHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ntiPrincipal = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsPrincipal = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ArchivoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TablasMenoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsPrincipal = New System.Windows.Forms.ToolStrip()
        Me.mnuPrincipal.SuspendLayout()
        Me.stsPrincipal.SuspendLayout()
        Me.cmsPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuArchivo, Me.mnuABMs, Me.mnuTablasMenores})
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.mnuPrincipal.Size = New System.Drawing.Size(660, 24)
        Me.mnuPrincipal.TabIndex = 1
        Me.mnuPrincipal.Text = "MenuStrip1"
        '
        'mnuArchivo
        '
        Me.mnuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSalir})
        Me.mnuArchivo.Name = "mnuArchivo"
        Me.mnuArchivo.Size = New System.Drawing.Size(60, 20)
        Me.mnuArchivo.Text = "&Archivo"
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.Size = New System.Drawing.Size(152, 22)
        Me.mnuSalir.Text = "&Salir"
        '
        'mnuABMs
        '
        Me.mnuABMs.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClientes, Me.mnuAlojamientos, Me.mnuEmpleados, Me.mnuHabitacion, Me.SucursalAlojamientoToolStripMenuItem, Me.SucursalEmpresaToolStripMenuItem})
        Me.mnuABMs.Name = "mnuABMs"
        Me.mnuABMs.Size = New System.Drawing.Size(50, 20)
        Me.mnuABMs.Text = "A&BMs"
        '
        'mnuClientes
        '
        Me.mnuClientes.Name = "mnuClientes"
        Me.mnuClientes.Size = New System.Drawing.Size(186, 22)
        Me.mnuClientes.Text = "&Clientes"
        '
        'mnuAlojamientos
        '
        Me.mnuAlojamientos.Name = "mnuAlojamientos"
        Me.mnuAlojamientos.Size = New System.Drawing.Size(186, 22)
        Me.mnuAlojamientos.Text = "&Alojamientos"
        '
        'mnuEmpleados
        '
        Me.mnuEmpleados.Name = "mnuEmpleados"
        Me.mnuEmpleados.Size = New System.Drawing.Size(186, 22)
        Me.mnuEmpleados.Text = "&Empleados"
        '
        'mnuHabitacion
        '
        Me.mnuHabitacion.Name = "mnuHabitacion"
        Me.mnuHabitacion.Size = New System.Drawing.Size(186, 22)
        Me.mnuHabitacion.Text = "Habitación"
        '
        'SucursalAlojamientoToolStripMenuItem
        '
        Me.SucursalAlojamientoToolStripMenuItem.Name = "SucursalAlojamientoToolStripMenuItem"
        Me.SucursalAlojamientoToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SucursalAlojamientoToolStripMenuItem.Text = "Sucursal Alojamiento"
        '
        'SucursalEmpresaToolStripMenuItem
        '
        Me.SucursalEmpresaToolStripMenuItem.Name = "SucursalEmpresaToolStripMenuItem"
        Me.SucursalEmpresaToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SucursalEmpresaToolStripMenuItem.Text = "Sucursal Empresa"
        '
        'mnuTablasMenores
        '
        Me.mnuTablasMenores.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CiudadToolStripMenuItem, Me.DepartamentoToolStripMenuItem, Me.PaísToolStripMenuItem})
        Me.mnuTablasMenores.Name = "mnuTablasMenores"
        Me.mnuTablasMenores.Size = New System.Drawing.Size(101, 20)
        Me.mnuTablasMenores.Text = "&Tablas Menores"
        '
        'CiudadToolStripMenuItem
        '
        Me.CiudadToolStripMenuItem.Name = "CiudadToolStripMenuItem"
        Me.CiudadToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CiudadToolStripMenuItem.Text = "Ciudad"
        '
        'DepartamentoToolStripMenuItem
        '
        Me.DepartamentoToolStripMenuItem.Name = "DepartamentoToolStripMenuItem"
        Me.DepartamentoToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DepartamentoToolStripMenuItem.Text = "Departamento"
        '
        'PaísToolStripMenuItem
        '
        Me.PaísToolStripMenuItem.Name = "PaísToolStripMenuItem"
        Me.PaísToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PaísToolStripMenuItem.Text = "País"
        '
        'stsPrincipal
        '
        Me.stsPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.stsPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblFechaHora})
        Me.stsPrincipal.Location = New System.Drawing.Point(0, 347)
        Me.stsPrincipal.Name = "stsPrincipal"
        Me.stsPrincipal.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.stsPrincipal.Size = New System.Drawing.Size(660, 22)
        Me.stsPrincipal.TabIndex = 2
        Me.stsPrincipal.Text = "StatusStrip1"
        '
        'lblFechaHora
        '
        Me.lblFechaHora.Name = "lblFechaHora"
        Me.lblFechaHora.Size = New System.Drawing.Size(70, 17)
        Me.lblFechaHora.Text = "Fecha: Hora"
        '
        'ntiPrincipal
        '
        Me.ntiPrincipal.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ntiPrincipal.BalloonTipText = "Bienvenido al Sistema de Turismo"
        Me.ntiPrincipal.BalloonTipTitle = "SysTurismo"
        Me.ntiPrincipal.Text = "Bienvenido al Sistema de Turismo SysTurismo"
        Me.ntiPrincipal.Visible = True
        '
        'cmsPrincipal
        '
        Me.cmsPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem1, Me.ABMsToolStripMenuItem1, Me.TablasMenoresToolStripMenuItem1})
        Me.cmsPrincipal.Name = "ContextMenuStrip1"
        Me.cmsPrincipal.Size = New System.Drawing.Size(157, 70)
        '
        'ArchivoToolStripMenuItem1
        '
        Me.ArchivoToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem1.Name = "ArchivoToolStripMenuItem1"
        Me.ArchivoToolStripMenuItem1.Size = New System.Drawing.Size(156, 22)
        Me.ArchivoToolStripMenuItem1.Text = "&Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'ABMsToolStripMenuItem1
        '
        Me.ABMsToolStripMenuItem1.Name = "ABMsToolStripMenuItem1"
        Me.ABMsToolStripMenuItem1.Size = New System.Drawing.Size(156, 22)
        Me.ABMsToolStripMenuItem1.Text = "A&BMs"
        '
        'TablasMenoresToolStripMenuItem1
        '
        Me.TablasMenoresToolStripMenuItem1.Name = "TablasMenoresToolStripMenuItem1"
        Me.TablasMenoresToolStripMenuItem1.Size = New System.Drawing.Size(156, 22)
        Me.TablasMenoresToolStripMenuItem1.Text = "&Tablas Menores"
        '
        'tlsPrincipal
        '
        Me.tlsPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlsPrincipal.Location = New System.Drawing.Point(0, 24)
        Me.tlsPrincipal.Name = "tlsPrincipal"
        Me.tlsPrincipal.Size = New System.Drawing.Size(660, 25)
        Me.tlsPrincipal.TabIndex = 4
        Me.tlsPrincipal.Text = "ToolStrip1"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 369)
        Me.Controls.Add(Me.tlsPrincipal)
        Me.Controls.Add(Me.stsPrincipal)
        Me.Controls.Add(Me.mnuPrincipal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuPrincipal
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmPrincipal"
        Me.Text = "Sistema de Turismo - Principal - SysTurismo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuPrincipal.ResumeLayout(False)
        Me.mnuPrincipal.PerformLayout()
        Me.stsPrincipal.ResumeLayout(False)
        Me.stsPrincipal.PerformLayout()
        Me.cmsPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuPrincipal As MenuStrip
    Friend WithEvents mnuArchivo As ToolStripMenuItem
    Friend WithEvents mnuABMs As ToolStripMenuItem
    Friend WithEvents mnuTablasMenores As ToolStripMenuItem
    Friend WithEvents mnuSalir As ToolStripMenuItem
    Friend WithEvents stsPrincipal As StatusStrip
    Friend WithEvents ntiPrincipal As NotifyIcon
    Friend WithEvents cmsPrincipal As ContextMenuStrip
    Friend WithEvents ArchivoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TablasMenoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents tlsPrincipal As ToolStrip
    Friend WithEvents mnuClientes As ToolStripMenuItem
    Friend WithEvents mnuAlojamientos As ToolStripMenuItem
    Friend WithEvents lblFechaHora As ToolStripStatusLabel
    Friend WithEvents mnuEmpleados As ToolStripMenuItem
    Friend WithEvents mnuHabitacion As ToolStripMenuItem
    Friend WithEvents SucursalAlojamientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SucursalEmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CiudadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaísToolStripMenuItem As ToolStripMenuItem
End Class
