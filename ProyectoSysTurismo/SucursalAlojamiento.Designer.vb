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
        Me.GpbEstado = New System.Windows.Forms.GroupBox()
        Me.RdbDeshabilitado = New System.Windows.Forms.RadioButton()
        Me.RdbHabilitado = New System.Windows.Forms.RadioButton()
        Me.CmbCIudad = New System.Windows.Forms.ComboBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtSucursalID = New System.Windows.Forms.TextBox()
        Me.TxtALojamientoID = New System.Windows.Forms.TextBox()
        Me.LblEstadoSistema = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblCiudad = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblSucursal = New System.Windows.Forms.Label()
        Me.LblAlojamineto = New System.Windows.Forms.Label()
        Me.DgvConsulta = New System.Windows.Forms.TabPage()
        Me.tbcPrincipal.SuspendLayout()
        Me.TbpSucursalAlojamiento.SuspendLayout()
        Me.GpbBotones.SuspendLayout()
        Me.GpbEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcPrincipal
        '
        Me.tbcPrincipal.Controls.Add(Me.TbpSucursalAlojamiento)
        Me.tbcPrincipal.Controls.Add(Me.DgvConsulta)
        Me.tbcPrincipal.Location = New System.Drawing.Point(1, 3)
        Me.tbcPrincipal.Name = "tbcPrincipal"
        Me.tbcPrincipal.SelectedIndex = 0
        Me.tbcPrincipal.Size = New System.Drawing.Size(650, 392)
        Me.tbcPrincipal.TabIndex = 0
        '
        'TbpSucursalAlojamiento
        '
        Me.TbpSucursalAlojamiento.Controls.Add(Me.GpbBotones)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.GpbEstado)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.CmbCIudad)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.TxtEmail)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.TxtTelefono)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.TxtDireccion)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.TxtNombre)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.TxtSucursalID)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.TxtALojamientoID)
        Me.TbpSucursalAlojamiento.Controls.Add(Me.LblEstadoSistema)
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
        'GpbEstado
        '
        Me.GpbEstado.Controls.Add(Me.RdbDeshabilitado)
        Me.GpbEstado.Controls.Add(Me.RdbHabilitado)
        Me.GpbEstado.Location = New System.Drawing.Point(325, 186)
        Me.GpbEstado.Name = "GpbEstado"
        Me.GpbEstado.Size = New System.Drawing.Size(209, 29)
        Me.GpbEstado.TabIndex = 24
        Me.GpbEstado.TabStop = False
        '
        'RdbDeshabilitado
        '
        Me.RdbDeshabilitado.AutoSize = True
        Me.RdbDeshabilitado.Location = New System.Drawing.Point(102, 8)
        Me.RdbDeshabilitado.Name = "RdbDeshabilitado"
        Me.RdbDeshabilitado.Size = New System.Drawing.Size(89, 17)
        Me.RdbDeshabilitado.TabIndex = 1
        Me.RdbDeshabilitado.TabStop = True
        Me.RdbDeshabilitado.Text = "Deshabilitado"
        Me.RdbDeshabilitado.UseVisualStyleBackColor = True
        '
        'RdbHabilitado
        '
        Me.RdbHabilitado.AutoSize = True
        Me.RdbHabilitado.Location = New System.Drawing.Point(6, 8)
        Me.RdbHabilitado.Name = "RdbHabilitado"
        Me.RdbHabilitado.Size = New System.Drawing.Size(72, 17)
        Me.RdbHabilitado.TabIndex = 0
        Me.RdbHabilitado.TabStop = True
        Me.RdbHabilitado.Text = "Habilitado"
        Me.RdbHabilitado.UseVisualStyleBackColor = True
        '
        'CmbCIudad
        '
        Me.CmbCIudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCIudad.FormattingEnabled = True
        Me.CmbCIudad.Location = New System.Drawing.Point(115, 186)
        Me.CmbCIudad.Name = "CmbCIudad"
        Me.CmbCIudad.Size = New System.Drawing.Size(121, 21)
        Me.CmbCIudad.TabIndex = 23
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(354, 136)
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
        'TxtSucursalID
        '
        Me.TxtSucursalID.Location = New System.Drawing.Point(115, 69)
        Me.TxtSucursalID.Name = "TxtSucursalID"
        Me.TxtSucursalID.ReadOnly = True
        Me.TxtSucursalID.Size = New System.Drawing.Size(100, 20)
        Me.TxtSucursalID.TabIndex = 17
        '
        'TxtALojamientoID
        '
        Me.TxtALojamientoID.Location = New System.Drawing.Point(115, 28)
        Me.TxtALojamientoID.Name = "TxtALojamientoID"
        Me.TxtALojamientoID.ReadOnly = True
        Me.TxtALojamientoID.Size = New System.Drawing.Size(100, 20)
        Me.TxtALojamientoID.TabIndex = 16
        '
        'LblEstadoSistema
        '
        Me.LblEstadoSistema.AutoSize = True
        Me.LblEstadoSistema.Location = New System.Drawing.Point(279, 194)
        Me.LblEstadoSistema.Name = "LblEstadoSistema"
        Me.LblEstadoSistema.Size = New System.Drawing.Size(40, 13)
        Me.LblEstadoSistema.TabIndex = 15
        Me.LblEstadoSistema.Text = "Estado"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(276, 136)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(32, 13)
        Me.LblEmail.TabIndex = 14
        Me.LblEmail.Text = "Email"
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Location = New System.Drawing.Point(276, 72)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.LblDireccion.TabIndex = 13
        Me.LblDireccion.Text = "Direccion"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(279, 31)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LblTelefono.TabIndex = 12
        Me.LblTelefono.Text = "Telefono"
        '
        'LblCiudad
        '
        Me.LblCiudad.AutoSize = True
        Me.LblCiudad.Location = New System.Drawing.Point(48, 194)
        Me.LblCiudad.Name = "LblCiudad"
        Me.LblCiudad.Size = New System.Drawing.Size(40, 13)
        Me.LblCiudad.TabIndex = 11
        Me.LblCiudad.Text = "Ciudad"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(48, 136)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 10
        Me.LblNombre.Text = "Nombre"
        '
        'LblSucursal
        '
        Me.LblSucursal.AutoSize = True
        Me.LblSucursal.Location = New System.Drawing.Point(40, 76)
        Me.LblSucursal.Name = "LblSucursal"
        Me.LblSucursal.Size = New System.Drawing.Size(48, 13)
        Me.LblSucursal.TabIndex = 9
        Me.LblSucursal.Text = "Sucursal"
        '
        'LblAlojamineto
        '
        Me.LblAlojamineto.AutoSize = True
        Me.LblAlojamineto.Location = New System.Drawing.Point(31, 31)
        Me.LblAlojamineto.Name = "LblAlojamineto"
        Me.LblAlojamineto.Size = New System.Drawing.Size(61, 13)
        Me.LblAlojamineto.TabIndex = 8
        Me.LblAlojamineto.Text = "Alojamiento"
        '
        'DgvConsulta
        '
        Me.DgvConsulta.Location = New System.Drawing.Point(4, 22)
        Me.DgvConsulta.Name = "DgvConsulta"
        Me.DgvConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.DgvConsulta.Size = New System.Drawing.Size(616, 320)
        Me.DgvConsulta.TabIndex = 1
        Me.DgvConsulta.Text = "Conulta"
        Me.DgvConsulta.UseVisualStyleBackColor = True
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
        Me.GpbEstado.ResumeLayout(False)
        Me.GpbEstado.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcPrincipal As TabControl
    Friend WithEvents TbpSucursalAlojamiento As TabPage
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtSucursalID As TextBox
    Friend WithEvents TxtALojamientoID As TextBox
    Friend WithEvents LblEstadoSistema As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblDireccion As Label
    Friend WithEvents LblTelefono As Label
    Friend WithEvents LblCiudad As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblSucursal As Label
    Friend WithEvents LblAlojamineto As Label
    Friend WithEvents DgvConsulta As TabPage
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents CmbCIudad As ComboBox
    Friend WithEvents GpbEstado As GroupBox
    Friend WithEvents RdbDeshabilitado As RadioButton
    Friend WithEvents RdbHabilitado As RadioButton
    Friend WithEvents GpbBotones As GroupBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnConfirmar As Button
End Class
