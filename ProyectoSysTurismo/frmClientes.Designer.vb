<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Me.tbcPrincipal = New System.Windows.Forms.TabControl()
        Me.tbpABM = New System.Windows.Forms.TabPage()
        Me.gbxSexo = New System.Windows.Forms.GroupBox()
        Me.rdbMasculino = New System.Windows.Forms.RadioButton()
        Me.rdbFemenino = New System.Windows.Forms.RadioButton()
        Me.cmbProfesion = New System.Windows.Forms.ComboBox()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.cmbEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.txtNroDocumento = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblProfesion = New System.Windows.Forms.Label()
        Me.gbxBotones = New System.Windows.Forms.GroupBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblEstadoCivil = New System.Windows.Forms.Label()
        Me.lblNroDocumento = New System.Windows.Forms.Label()
        Me.cmbTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.lblTipoDocumento = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.tbpConsulta = New System.Windows.Forms.TabPage()
        Me.dgvConsulta = New System.Windows.Forms.DataGridView()
        Me.cmbTipoCliente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbcPrincipal.SuspendLayout()
        Me.tbpABM.SuspendLayout()
        Me.gbxSexo.SuspendLayout()
        Me.gbxBotones.SuspendLayout()
        Me.tbpConsulta.SuspendLayout()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcPrincipal
        '
        Me.tbcPrincipal.Controls.Add(Me.tbpABM)
        Me.tbcPrincipal.Controls.Add(Me.tbpConsulta)
        Me.tbcPrincipal.Location = New System.Drawing.Point(13, 19)
        Me.tbcPrincipal.Margin = New System.Windows.Forms.Padding(4)
        Me.tbcPrincipal.Name = "tbcPrincipal"
        Me.tbcPrincipal.SelectedIndex = 0
        Me.tbcPrincipal.Size = New System.Drawing.Size(944, 475)
        Me.tbcPrincipal.TabIndex = 0
        '
        'tbpABM
        '
        Me.tbpABM.Controls.Add(Me.cmbTipoCliente)
        Me.tbpABM.Controls.Add(Me.Label1)
        Me.tbpABM.Controls.Add(Me.gbxSexo)
        Me.tbpABM.Controls.Add(Me.cmbProfesion)
        Me.tbpABM.Controls.Add(Me.dtpFechaNacimiento)
        Me.tbpABM.Controls.Add(Me.txtEmail)
        Me.tbpABM.Controls.Add(Me.txtDireccion)
        Me.tbpABM.Controls.Add(Me.txtTelefono)
        Me.tbpABM.Controls.Add(Me.cmbEstadoCivil)
        Me.tbpABM.Controls.Add(Me.txtNroDocumento)
        Me.tbpABM.Controls.Add(Me.txtApellido)
        Me.tbpABM.Controls.Add(Me.lblProfesion)
        Me.tbpABM.Controls.Add(Me.gbxBotones)
        Me.tbpABM.Controls.Add(Me.lblFechaNacimiento)
        Me.tbpABM.Controls.Add(Me.lblEmail)
        Me.tbpABM.Controls.Add(Me.lblDireccion)
        Me.tbpABM.Controls.Add(Me.lblTelefono)
        Me.tbpABM.Controls.Add(Me.lblEstadoCivil)
        Me.tbpABM.Controls.Add(Me.lblNroDocumento)
        Me.tbpABM.Controls.Add(Me.cmbTipoDocumento)
        Me.tbpABM.Controls.Add(Me.lblTipoDocumento)
        Me.tbpABM.Controls.Add(Me.lblApellido)
        Me.tbpABM.Controls.Add(Me.txtNombre)
        Me.tbpABM.Controls.Add(Me.lblNombre)
        Me.tbpABM.Controls.Add(Me.txtCodigo)
        Me.tbpABM.Controls.Add(Me.lblCodigo)
        Me.tbpABM.Location = New System.Drawing.Point(4, 25)
        Me.tbpABM.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpABM.Name = "tbpABM"
        Me.tbpABM.Padding = New System.Windows.Forms.Padding(4)
        Me.tbpABM.Size = New System.Drawing.Size(936, 446)
        Me.tbpABM.TabIndex = 0
        Me.tbpABM.Text = "ABM"
        Me.tbpABM.UseVisualStyleBackColor = True
        '
        'gbxSexo
        '
        Me.gbxSexo.Controls.Add(Me.rdbMasculino)
        Me.gbxSexo.Controls.Add(Me.rdbFemenino)
        Me.gbxSexo.Location = New System.Drawing.Point(456, 84)
        Me.gbxSexo.Name = "gbxSexo"
        Me.gbxSexo.Size = New System.Drawing.Size(449, 119)
        Me.gbxSexo.TabIndex = 24
        Me.gbxSexo.TabStop = False
        Me.gbxSexo.Text = "Sexo"
        '
        'rdbMasculino
        '
        Me.rdbMasculino.AutoSize = True
        Me.rdbMasculino.Location = New System.Drawing.Point(92, 51)
        Me.rdbMasculino.Name = "rdbMasculino"
        Me.rdbMasculino.Size = New System.Drawing.Size(92, 21)
        Me.rdbMasculino.TabIndex = 0
        Me.rdbMasculino.TabStop = True
        Me.rdbMasculino.Text = "Masculino"
        Me.rdbMasculino.UseVisualStyleBackColor = True
        '
        'rdbFemenino
        '
        Me.rdbFemenino.AutoSize = True
        Me.rdbFemenino.Location = New System.Drawing.Point(262, 51)
        Me.rdbFemenino.Name = "rdbFemenino"
        Me.rdbFemenino.Size = New System.Drawing.Size(91, 21)
        Me.rdbFemenino.TabIndex = 1
        Me.rdbFemenino.TabStop = True
        Me.rdbFemenino.Text = "Femenino"
        Me.rdbFemenino.UseVisualStyleBackColor = True
        '
        'cmbProfesion
        '
        Me.cmbProfesion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProfesion.FormattingEnabled = True
        Me.cmbProfesion.Location = New System.Drawing.Point(545, 16)
        Me.cmbProfesion.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbProfesion.Name = "cmbProfesion"
        Me.cmbProfesion.Size = New System.Drawing.Size(363, 24)
        Me.cmbProfesion.TabIndex = 21
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(141, 310)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(293, 22)
        Me.dtpFechaNacimiento.TabIndex = 19
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(141, 276)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(169, 22)
        Me.txtEmail.TabIndex = 17
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(141, 243)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(297, 22)
        Me.txtDireccion.TabIndex = 15
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(141, 211)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(169, 22)
        Me.txtTelefono.TabIndex = 13
        '
        'cmbEstadoCivil
        '
        Me.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstadoCivil.FormattingEnabled = True
        Me.cmbEstadoCivil.Items.AddRange(New Object() {"Soltero", "Casado", "Viudo", "Divorciado"})
        Me.cmbEstadoCivil.Location = New System.Drawing.Point(141, 178)
        Me.cmbEstadoCivil.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEstadoCivil.Name = "cmbEstadoCivil"
        Me.cmbEstadoCivil.Size = New System.Drawing.Size(169, 24)
        Me.cmbEstadoCivil.TabIndex = 11
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.Location = New System.Drawing.Point(141, 147)
        Me.txtNroDocumento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(169, 22)
        Me.txtNroDocumento.TabIndex = 9
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(141, 84)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(297, 22)
        Me.txtApellido.TabIndex = 5
        '
        'lblProfesion
        '
        Me.lblProfesion.AutoSize = True
        Me.lblProfesion.Location = New System.Drawing.Point(456, 20)
        Me.lblProfesion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProfesion.Name = "lblProfesion"
        Me.lblProfesion.Size = New System.Drawing.Size(68, 17)
        Me.lblProfesion.TabIndex = 20
        Me.lblProfesion.Text = "Profesión"
        '
        'gbxBotones
        '
        Me.gbxBotones.Controls.Add(Me.btnConfirmar)
        Me.gbxBotones.Controls.Add(Me.btnEliminar)
        Me.gbxBotones.Controls.Add(Me.btnCancelar)
        Me.gbxBotones.Location = New System.Drawing.Point(197, 339)
        Me.gbxBotones.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxBotones.Name = "gbxBotones"
        Me.gbxBotones.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxBotones.Size = New System.Drawing.Size(569, 80)
        Me.gbxBotones.TabIndex = 25
        Me.gbxBotones.TabStop = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(85, 26)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(100, 28)
        Me.btnConfirmar.TabIndex = 0
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(235, 26)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 28)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(392, 26)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 28)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(12, 313)
        Me.lblFechaNacimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(121, 17)
        Me.lblFechaNacimiento.TabIndex = 18
        Me.lblFechaNacimiento.Text = "Fecha Nacimiento"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(12, 279)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblEmail.TabIndex = 16
        Me.lblEmail.Text = "Email"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(12, 246)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(67, 17)
        Me.lblDireccion.TabIndex = 14
        Me.lblDireccion.Text = "Dirección"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(12, 214)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(64, 17)
        Me.lblTelefono.TabIndex = 12
        Me.lblTelefono.Text = "Teléfono"
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Location = New System.Drawing.Point(12, 182)
        Me.lblEstadoCivil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(81, 17)
        Me.lblEstadoCivil.TabIndex = 10
        Me.lblEstadoCivil.Text = "Estado Civil"
        '
        'lblNroDocumento
        '
        Me.lblNroDocumento.AutoSize = True
        Me.lblNroDocumento.Location = New System.Drawing.Point(12, 150)
        Me.lblNroDocumento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNroDocumento.Name = "lblNroDocumento"
        Me.lblNroDocumento.Size = New System.Drawing.Size(111, 17)
        Me.lblNroDocumento.TabIndex = 8
        Me.lblNroDocumento.Text = "Nro. Documento"
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDocumento.FormattingEnabled = True
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(141, 113)
        Me.cmbTipoDocumento.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(169, 24)
        Me.cmbTipoDocumento.TabIndex = 7
        '
        'lblTipoDocumento
        '
        Me.lblTipoDocumento.AutoSize = True
        Me.lblTipoDocumento.Location = New System.Drawing.Point(12, 117)
        Me.lblTipoDocumento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoDocumento.Name = "lblTipoDocumento"
        Me.lblTipoDocumento.Size = New System.Drawing.Size(112, 17)
        Me.lblTipoDocumento.TabIndex = 6
        Me.lblTipoDocumento.Text = "Tipo Documento"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(12, 84)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(58, 17)
        Me.lblApellido.TabIndex = 4
        Me.lblApellido.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(141, 49)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(297, 22)
        Me.txtNombre.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 52)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(141, 17)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(168, 22)
        Me.txtCodigo.TabIndex = 1
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(12, 20)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código"
        '
        'tbpConsulta
        '
        Me.tbpConsulta.Controls.Add(Me.dgvConsulta)
        Me.tbpConsulta.Location = New System.Drawing.Point(4, 25)
        Me.tbpConsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpConsulta.Name = "tbpConsulta"
        Me.tbpConsulta.Padding = New System.Windows.Forms.Padding(4)
        Me.tbpConsulta.Size = New System.Drawing.Size(936, 446)
        Me.tbpConsulta.TabIndex = 1
        Me.tbpConsulta.Text = "Consulta"
        Me.tbpConsulta.UseVisualStyleBackColor = True
        '
        'dgvConsulta
        '
        Me.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvConsulta.Location = New System.Drawing.Point(4, 4)
        Me.dgvConsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvConsulta.Name = "dgvConsulta"
        Me.dgvConsulta.Size = New System.Drawing.Size(928, 438)
        Me.dgvConsulta.TabIndex = 0
        '
        'cmbTipoCliente
        '
        Me.cmbTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoCliente.FormattingEnabled = True
        Me.cmbTipoCliente.Location = New System.Drawing.Point(545, 48)
        Me.cmbTipoCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipoCliente.Name = "cmbTipoCliente"
        Me.cmbTipoCliente.Size = New System.Drawing.Size(363, 24)
        Me.cmbTipoCliente.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(456, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Tipo Cliente"
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 508)
        Me.Controls.Add(Me.tbcPrincipal)
        Me.Name = "frmClientes"
        Me.Text = "Clientes - SysTurismo"
        Me.tbcPrincipal.ResumeLayout(False)
        Me.tbpABM.ResumeLayout(False)
        Me.tbpABM.PerformLayout()
        Me.gbxSexo.ResumeLayout(False)
        Me.gbxSexo.PerformLayout()
        Me.gbxBotones.ResumeLayout(False)
        Me.tbpConsulta.ResumeLayout(False)
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcPrincipal As TabControl
    Friend WithEvents tbpABM As TabPage
    Friend WithEvents gbxBotones As GroupBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblFechaNacimiento As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblEstadoCivil As Label
    Friend WithEvents lblNroDocumento As Label
    Friend WithEvents cmbTipoDocumento As ComboBox
    Friend WithEvents lblTipoDocumento As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents tbpConsulta As TabPage
    Friend WithEvents dgvConsulta As DataGridView
    Friend WithEvents lblProfesion As Label
    Friend WithEvents cmbProfesion As ComboBox
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents cmbEstadoCivil As ComboBox
    Friend WithEvents txtNroDocumento As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents gbxSexo As GroupBox
    Friend WithEvents rdbMasculino As RadioButton
    Friend WithEvents rdbFemenino As RadioButton
    Friend WithEvents cmbTipoCliente As ComboBox
    Friend WithEvents Label1 As Label
End Class
