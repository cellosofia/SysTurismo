<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHabitacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tbcPrincipal = New System.Windows.Forms.TabControl()
        Me.tbpABM = New System.Windows.Forms.TabPage()
        Me.cboEstadoHabitacion = New System.Windows.Forms.ComboBox()
        Me.cboTipoHabitacion = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.nudPrecio = New System.Windows.Forms.NumericUpDown()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtSucursal = New System.Windows.Forms.TextBox()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.txtNroHabitacion = New System.Windows.Forms.TextBox()
        Me.lblNroHabitacion = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.chkHabilitado = New System.Windows.Forms.CheckBox()
        Me.gbxBotones = New System.Windows.Forms.GroupBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.tbpConsulta = New System.Windows.Forms.TabPage()
        Me.dgvConsulta = New System.Windows.Forms.DataGridView()
        Me.tbcPrincipal.SuspendLayout()
        Me.tbpABM.SuspendLayout()
        CType(Me.nudPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxBotones.SuspendLayout()
        Me.tbpConsulta.SuspendLayout()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcPrincipal
        '
        Me.tbcPrincipal.Controls.Add(Me.tbpABM)
        Me.tbcPrincipal.Controls.Add(Me.tbpConsulta)
        Me.tbcPrincipal.Location = New System.Drawing.Point(10, 13)
        Me.tbcPrincipal.Name = "tbcPrincipal"
        Me.tbcPrincipal.SelectedIndex = 0
        Me.tbcPrincipal.Size = New System.Drawing.Size(708, 325)
        Me.tbcPrincipal.TabIndex = 1
        '
        'tbpABM
        '
        Me.tbpABM.Controls.Add(Me.cboEstadoHabitacion)
        Me.tbpABM.Controls.Add(Me.cboTipoHabitacion)
        Me.tbpABM.Controls.Add(Me.lblEstado)
        Me.tbpABM.Controls.Add(Me.lblTipo)
        Me.tbpABM.Controls.Add(Me.nudPrecio)
        Me.tbpABM.Controls.Add(Me.lblPrecio)
        Me.tbpABM.Controls.Add(Me.txtSucursal)
        Me.tbpABM.Controls.Add(Me.lblSucursal)
        Me.tbpABM.Controls.Add(Me.txtNroHabitacion)
        Me.tbpABM.Controls.Add(Me.lblNroHabitacion)
        Me.tbpABM.Controls.Add(Me.txtCodigo)
        Me.tbpABM.Controls.Add(Me.lblCodigo)
        Me.tbpABM.Controls.Add(Me.chkHabilitado)
        Me.tbpABM.Controls.Add(Me.gbxBotones)
        Me.tbpABM.Location = New System.Drawing.Point(4, 22)
        Me.tbpABM.Name = "tbpABM"
        Me.tbpABM.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpABM.Size = New System.Drawing.Size(700, 299)
        Me.tbpABM.TabIndex = 0
        Me.tbpABM.Text = "ABM"
        Me.tbpABM.UseVisualStyleBackColor = True
        '
        'cboEstadoHabitacion
        '
        Me.cboEstadoHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstadoHabitacion.FormattingEnabled = True
        Me.cboEstadoHabitacion.Location = New System.Drawing.Point(132, 160)
        Me.cboEstadoHabitacion.Name = "cboEstadoHabitacion"
        Me.cboEstadoHabitacion.Size = New System.Drawing.Size(121, 21)
        Me.cboEstadoHabitacion.TabIndex = 47
        '
        'cboTipoHabitacion
        '
        Me.cboTipoHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoHabitacion.FormattingEnabled = True
        Me.cboTipoHabitacion.Location = New System.Drawing.Point(132, 134)
        Me.cboTipoHabitacion.Name = "cboTipoHabitacion"
        Me.cboTipoHabitacion.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoHabitacion.TabIndex = 46
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(28, 160)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblEstado.TabIndex = 45
        Me.lblEstado.Text = "Estado"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(28, 134)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(28, 13)
        Me.lblTipo.TabIndex = 44
        Me.lblTipo.Text = "Tipo"
        '
        'nudPrecio
        '
        Me.nudPrecio.Location = New System.Drawing.Point(132, 105)
        Me.nudPrecio.Name = "nudPrecio"
        Me.nudPrecio.Size = New System.Drawing.Size(120, 20)
        Me.nudPrecio.TabIndex = 43
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(28, 105)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecio.TabIndex = 42
        Me.lblPrecio.Text = "Precio"
        '
        'txtSucursal
        '
        Me.txtSucursal.Location = New System.Drawing.Point(132, 74)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.ReadOnly = True
        Me.txtSucursal.Size = New System.Drawing.Size(185, 20)
        Me.txtSucursal.TabIndex = 41
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(28, 77)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(48, 13)
        Me.lblSucursal.TabIndex = 40
        Me.lblSucursal.Text = "Sucursal"
        '
        'txtNroHabitacion
        '
        Me.txtNroHabitacion.Location = New System.Drawing.Point(132, 45)
        Me.txtNroHabitacion.Name = "txtNroHabitacion"
        Me.txtNroHabitacion.Size = New System.Drawing.Size(100, 20)
        Me.txtNroHabitacion.TabIndex = 39
        '
        'lblNroHabitacion
        '
        Me.lblNroHabitacion.AutoSize = True
        Me.lblNroHabitacion.Location = New System.Drawing.Point(28, 48)
        Me.lblNroHabitacion.Name = "lblNroHabitacion"
        Me.lblNroHabitacion.Size = New System.Drawing.Size(98, 13)
        Me.lblNroHabitacion.TabIndex = 38
        Me.lblNroHabitacion.Text = "Numero Habitacion"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(132, 19)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 37
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(28, 22)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 36
        Me.lblCodigo.Text = "Codigo"
        '
        'chkHabilitado
        '
        Me.chkHabilitado.AutoSize = True
        Me.chkHabilitado.Checked = True
        Me.chkHabilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHabilitado.Location = New System.Drawing.Point(324, 18)
        Me.chkHabilitado.Name = "chkHabilitado"
        Me.chkHabilitado.Size = New System.Drawing.Size(73, 17)
        Me.chkHabilitado.TabIndex = 26
        Me.chkHabilitado.Text = "Habilitado"
        Me.chkHabilitado.UseVisualStyleBackColor = True
        '
        'gbxBotones
        '
        Me.gbxBotones.Controls.Add(Me.btnConfirmar)
        Me.gbxBotones.Controls.Add(Me.btnEliminar)
        Me.gbxBotones.Controls.Add(Me.btnCancelar)
        Me.gbxBotones.Location = New System.Drawing.Point(148, 211)
        Me.gbxBotones.Name = "gbxBotones"
        Me.gbxBotones.Size = New System.Drawing.Size(427, 65)
        Me.gbxBotones.TabIndex = 25
        Me.gbxBotones.TabStop = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(64, 21)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmar.TabIndex = 0
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(176, 21)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(294, 21)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'tbpConsulta
        '
        Me.tbpConsulta.Controls.Add(Me.dgvConsulta)
        Me.tbpConsulta.Location = New System.Drawing.Point(4, 22)
        Me.tbpConsulta.Name = "tbpConsulta"
        Me.tbpConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpConsulta.Size = New System.Drawing.Size(700, 299)
        Me.tbpConsulta.TabIndex = 1
        Me.tbpConsulta.Text = "Consulta"
        Me.tbpConsulta.UseVisualStyleBackColor = True
        '
        'dgvConsulta
        '
        Me.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvConsulta.Location = New System.Drawing.Point(3, 3)
        Me.dgvConsulta.Name = "dgvConsulta"
        Me.dgvConsulta.Size = New System.Drawing.Size(694, 293)
        Me.dgvConsulta.TabIndex = 0
        '
        'frmHabitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 348)
        Me.Controls.Add(Me.tbcPrincipal)
        Me.Name = "frmHabitacion"
        Me.Text = "Habitacion - SysTurismo"
        Me.tbcPrincipal.ResumeLayout(False)
        Me.tbpABM.ResumeLayout(False)
        Me.tbpABM.PerformLayout()
        CType(Me.nudPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxBotones.ResumeLayout(False)
        Me.tbpConsulta.ResumeLayout(False)
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvConsulta As DataGridView
    Friend WithEvents tbpConsulta As TabPage
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents gbxBotones As GroupBox
    Friend WithEvents chkHabilitado As CheckBox
    Friend WithEvents tbpABM As TabPage
    Friend WithEvents tbcPrincipal As TabControl
    Friend WithEvents cboEstadoHabitacion As ComboBox
    Friend WithEvents cboTipoHabitacion As ComboBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents nudPrecio As NumericUpDown
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtSucursal As TextBox
    Friend WithEvents lblSucursal As Label
    Friend WithEvents txtNroHabitacion As TextBox
    Friend WithEvents lblNroHabitacion As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtCodigo As TextBox
End Class
