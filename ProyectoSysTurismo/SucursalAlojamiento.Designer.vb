<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SucursalAlojamiento
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
        Me.tbcPrincipal = New System.Windows.Forms.TabControl()
        Me.TbpSucursalAlojamiento = New System.Windows.Forms.TabPage()
        Me.GpbBotones = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        Me.cboCiudad = New System.Windows.Forms.ComboBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.txtSucursal = New System.Windows.Forms.TextBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblCiudad = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblSucursal = New System.Windows.Forms.Label()
        Me.LblAlojamineto = New System.Windows.Forms.Label()
        Me.tbpConsulta = New System.Windows.Forms.TabPage()
        Me.dgvSucursal = New System.Windows.Forms.DataGridView()
        Me.cboAlojamiento = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboServicio = New System.Windows.Forms.ComboBox()
        Me.chkHabilitado = New System.Windows.Forms.CheckBox()
        Me.tbcPrincipal.SuspendLayout()
        Me.TbpSucursalAlojamiento.SuspendLayout()
        Me.GpbBotones.SuspendLayout()
        Me.tbpConsulta.SuspendLayout()
        CType(Me.dgvSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcPrincipal
        '
        Me.tbcPrincipal.Controls.Add(Me.TbpSucursalAlojamiento)
        Me.tbcPrincipal.Controls.Add(Me.tbpConsulta)
        Me.tbcPrincipal.Location = New System.Drawing.Point(1, 3)
        Me.tbcPrincipal.Name = "tbcPrincipal"
        Me.tbcPrincipal.SelectedIndex = 0
        Me.tbcPrincipal.Size = New System.Drawing.Size(650, 392)
        Me.tbcPrincipal.TabIndex = 0
        '
        'TbpSucursalAlojamiento
        '
        Me.TbpSucursalAlojamiento.Controls.Add(Me.chkHabilitado)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.cboServicio)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.Label1)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.cboAlojamiento)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.GpbBotones)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.cboCiudad)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.TxtEmail)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.TxtTelefono)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.TxtDireccion)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.TxtNombre)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.txtSucursal)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.LblEmail)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.LblDireccion)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.LblTelefono)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.LblCiudad)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.LblNombre)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.LblSucursal)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.LblAlojamineto)
        Me.TbpSucursalAlojamiento.Location = New System.Drawing.Point(4, 22)
        Me.TbpSucursalAlojamiento.Name = "TbpSucursalAlojamiento"
        Me.TbpSucursalAlojamiento.Padding = New System.Windows.Forms.Padding(3)
        Me.TbpSucursalAlojamiento.Size = New System.Drawing.Size(642, 366)
        Me.TbpSucursalAlojamiento.TabIndex = 0
        Me.TbpSucursalAlojamiento.Text = "ABM Sucursal Alojamiento"
        Me.TbpSucursalAlojamiento.UseVisualStyleBackColor = True
        '
        'GpbBotones
        '
        Me.GpbBotones.Controls.Add(Me.BtnEliminar)
        Me.GpbBotones.Controls.Add(Me.BtnCancelar)
        Me.GpbBotones.Controls.Add(Me.BtnConfirmar)
        Me.GpbBotones.Location = New System.Drawing.Point(60, 248)
        Me.GpbBotones.Name = "GpbBotones"
        Me.GpbBotones.Size = New System.Drawing.Size(439, 53)
        Me.GpbBotones.TabIndex = 25
        Me.GpbBotones.TabStop = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.BtnEliminar.Location = New System.Drawing.Point(329, 19)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(184, 19)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnConfirmar
        '
        Me.BtnConfirmar.Location = New System.Drawing.Point(55, 19)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.BtnConfirmar.TabIndex = 0
        Me.BtnConfirmar.Text = "Confirmar"
        Me.BtnConfirmar.UseVisualStyleBackColor = True
        '
        'cboCiudad
        '
        Me.cboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCiudad.FormattingEnabled = True
        Me.cboCiudad.Location = New System.Drawing.Point(115, 186)
        Me.cboCiudad.Name = "cboCiudad"
        Me.cboCiudad.Size = New System.Drawing.Size(121, 21)
        Me.cboCiudad.TabIndex = 23
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(354, 115)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(100, 20)
        Me.TxtEmail.TabIndex = 21
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(354, 28)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TxtTelefono.TabIndex = 20
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(354, 69)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(100, 20)
        Me.TxtDireccion.TabIndex = 19
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(115, 129)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombre.TabIndex = 18
        '
        'txtSucursal
        '
        Me.txtSucursal.Location = New System.Drawing.Point(115, 28)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.ReadOnly = True
        Me.txtSucursal.Size = New System.Drawing.Size(100, 20)
        Me.txtSucursal.TabIndex = 16
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(270, 118)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(32, 13)
        Me.LblEmail.TabIndex = 14
        Me.LblEmail.Text = "Email"
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Location = New System.Drawing.Point(270, 69)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.LblDireccion.TabIndex = 13
        Me.LblDireccion.Text = "Direccion"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(270, 31)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LblTelefono.TabIndex = 12
        Me.LblTelefono.Text = "Telefono"
        '
        'LblCiudad
        '
        Me.LblCiudad.AutoSize = True
        Me.LblCiudad.Location = New System.Drawing.Point(16, 186)
        Me.LblCiudad.Name = "LblCiudad"
        Me.LblCiudad.Size = New System.Drawing.Size(40, 13)
        Me.LblCiudad.TabIndex = 11
        Me.LblCiudad.Text = "Ciudad"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(16, 132)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(88, 13)
        Me.LblNombre.TabIndex = 10
        Me.LblNombre.Text = "Nombre Sucursal"
        '
        'LblSucursal
        '
        Me.LblSucursal.AutoSize = True
        Me.LblSucursal.Location = New System.Drawing.Point(16, 79)
        Me.LblSucursal.Name = "LblSucursal"
        Me.LblSucursal.Size = New System.Drawing.Size(61, 13)
        Me.LblSucursal.TabIndex = 9
        Me.LblSucursal.Text = "Alojamiento"
        '
        'LblAlojamineto
        '
        Me.LblAlojamineto.AutoSize = True
        Me.LblAlojamineto.Location = New System.Drawing.Point(15, 31)
        Me.LblAlojamineto.Name = "LblAlojamineto"
        Me.LblAlojamineto.Size = New System.Drawing.Size(62, 13)
        Me.LblAlojamineto.TabIndex = 8
        Me.LblAlojamineto.Text = "Sucursal ID"
        '
        'tbpConsulta
        '
        Me.tbpConsulta.Controls.Add(Me.dgvSucursal)
        Me.tbpConsulta.Location = New System.Drawing.Point(4, 22)
        Me.tbpConsulta.Name = "tbpConsulta"
        Me.tbpConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpConsulta.Size = New System.Drawing.Size(642, 366)
        Me.tbpConsulta.TabIndex = 1
        Me.tbpConsulta.Text = "Consulta"
        Me.tbpConsulta.UseVisualStyleBackColor = True
        '
        'dgvSucursal
        '
        Me.dgvSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSucursal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSucursal.Location = New System.Drawing.Point(3, 3)
        Me.dgvSucursal.Name = "dgvSucursal"
        Me.dgvSucursal.Size = New System.Drawing.Size(636, 360)
        Me.dgvSucursal.TabIndex = 0
        '
        'cboAlojamiento
        '
        Me.cboAlojamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlojamiento.FormattingEnabled = True
        Me.cboAlojamiento.Location = New System.Drawing.Point(115, 76)
        Me.cboAlojamiento.Name = "cboAlojamiento"
        Me.cboAlojamiento.Size = New System.Drawing.Size(121, 21)
        Me.cboAlojamiento.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(269, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Servicio"
        '
        'cboServicio
        '
        Me.cboServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboServicio.FormattingEnabled = True
        Me.cboServicio.Location = New System.Drawing.Point(354, 154)
        Me.cboServicio.Name = "cboServicio"
        Me.cboServicio.Size = New System.Drawing.Size(121, 21)
        Me.cboServicio.TabIndex = 28
        '
        'chkHabilitado
        '
        Me.chkHabilitado.AutoSize = True
        Me.chkHabilitado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkHabilitado.Location = New System.Drawing.Point(269, 190)
        Me.chkHabilitado.Name = "chkHabilitado"
        Me.chkHabilitado.Size = New System.Drawing.Size(73, 17)
        Me.chkHabilitado.TabIndex = 29
        Me.chkHabilitado.Text = "Habilitado"
        Me.chkHabilitado.UseVisualStyleBackColor = True
        '
        'SucursalAlojamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 392)
        Me.Controls.Add(Me.tbcPrincipal)
        Me.Name = "SucursalAlojamiento"
        Me.Text = "Sucursal Alojamiento - SysTurismo"
        Me.tbcPrincipal.ResumeLayout(False)
        Me.TbpSucursalAlojamiento.ResumeLayout(False)
        Me.TbpSucursalAlojamiento.PerformLayout()
        Me.GpbBotones.ResumeLayout(False)
        Me.tbpConsulta.ResumeLayout(False)
        CType(Me.dgvSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcPrincipal As TabControl
    Friend WithEvents TbpSucursalAlojamiento As TabPage
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents txtSucursal As TextBox
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblDireccion As Label
    Friend WithEvents LblTelefono As Label
    Friend WithEvents LblCiudad As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblSucursal As Label
    Friend WithEvents LblAlojamineto As Label
    Friend WithEvents tbpConsulta As TabPage
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents cboCiudad As ComboBox
    Friend WithEvents GpbBotones As GroupBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnConfirmar As Button
    Friend WithEvents dgvSucursal As DataGridView
    Friend WithEvents cboAlojamiento As ComboBox
    Friend WithEvents cboServicio As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkHabilitado As CheckBox
End Class
