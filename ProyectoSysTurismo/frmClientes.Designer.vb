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
        Me.cmbTipoCliente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.tbcPrincipal.Location = New System.Drawing.Point(10, 15)
        Me.tbcPrincipal.Name = "tbcPrincipal"
        Me.tbcPrincipal.SelectedIndex = 0
        Me.tbcPrincipal.Size = New System.Drawing.Size(708, 386)
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
        Me.tbpABM.Location = New System.Drawing.Point(4, 22)
        Me.tbpABM.Name = "tbpABM"
        Me.tbpABM.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpABM.Size = New System.Drawing.Size(700, 360)
        Me.tbpABM.TabIndex = 0
        Me.tbpABM.Text = "ABM"
        Me.tbpABM.UseVisualStyleBackColor = True
        '
        'cmbTipoCliente
        '
        Me.cmbTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoCliente.FormattingEnabled = True
        Me.cmbTipoCliente.Location = New System.Drawing.Point(409, 39)
        Me.cmbTipoCliente.Name = "cmbTipoCliente"
        Me.cmbTipoCliente.Size = New System.Drawing.Size(273, 21)
        Me.cmbTipoCliente.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(342, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Tipo Cliente"
        '
        'gbxSexo
        '
        Me.gbxSexo.Controls.Add(Me.rdbMasculino)
        Me.gbxSexo.Controls.Add(Me.rdbFemenino)
        Me.gbxSexo.Location = New System.Drawing.Point(342, 68)
        Me.gbxSexo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxSexo.Name = "gbxSexo"
        Me.gbxSexo.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxSexo.Size = New System.Drawing.Size(337, 97)
        Me.gbxSexo.TabIndex = 24
        Me.gbxSexo.TabStop = False
        Me.gbxSexo.Text = "Sexo"
        '
        'rdbMasculino
        '
        Me.rdbMasculino.AutoSize = True
        Me.rdbMasculino.Location = New System.Drawing.Point(69, 41)
        Me.rdbMasculino.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdbMasculino.Name = "rdbMasculino"
        Me.rdbMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rdbMasculino.TabIndex = 0
        Me.rdbMasculino.TabStop = True
        Me.rdbMasculino.Text = "Masculino"
        Me.rdbMasculino.UseVisualStyleBackColor = True
        '
        'rdbFemenino
        '
        Me.rdbFemenino.AutoSize = True
        Me.rdbFemenino.Location = New System.Drawing.Point(196, 41)
        Me.rdbFemenino.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdbFemenino.Name = "rdbFemenino"
        Me.rdbFemenino.Size = New System.Drawing.Size(71, 17)
        Me.rdbFemenino.TabIndex = 1
        Me.rdbFemenino.TabStop = True
        Me.rdbFemenino.Text = "Femenino"
        Me.rdbFemenino.UseVisualStyleBackColor = True
        '
        'cmbProfesion
        '
        Me.cmbProfesion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProfesion.FormattingEnabled = True
        Me.cmbProfesion.Location = New System.Drawing.Point(409, 13)
        Me.cmbProfesion.Name = "cmbProfesion"
        Me.cmbProfesion.Size = New System.Drawing.Size(273, 21)
        Me.cmbProfesion.TabIndex = 21
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(106, 252)
        Me.dtpFechaNacimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(128, 20)
        Me.dtpFechaNacimiento.TabIndex = 19
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(106, 224)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(128, 20)
        Me.txtEmail.TabIndex = 17
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(106, 197)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(224, 20)
        Me.txtDireccion.TabIndex = 15
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(106, 171)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(128, 20)
        Me.txtTelefono.TabIndex = 13
        '
        'cmbEstadoCivil
        '
        Me.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstadoCivil.FormattingEnabled = True
        Me.cmbEstadoCivil.Items.AddRange(New Object() {"Soltero", "Casado", "Viudo", "Divorciado"})
        Me.cmbEstadoCivil.Location = New System.Drawing.Point(106, 145)
        Me.cmbEstadoCivil.Name = "cmbEstadoCivil"
        Me.cmbEstadoCivil.Size = New System.Drawing.Size(128, 21)
        Me.cmbEstadoCivil.TabIndex = 11
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.Location = New System.Drawing.Point(106, 119)
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(128, 20)
        Me.txtNroDocumento.TabIndex = 9
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(106, 68)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(224, 20)
        Me.txtApellido.TabIndex = 5
        '
        'lblProfesion
        '
        Me.lblProfesion.AutoSize = True
        Me.lblProfesion.Location = New System.Drawing.Point(342, 16)
        Me.lblProfesion.Name = "lblProfesion"
        Me.lblProfesion.Size = New System.Drawing.Size(51, 13)
        Me.lblProfesion.TabIndex = 20
        Me.lblProfesion.Text = "Profesión"
        '
        'gbxBotones
        '
        Me.gbxBotones.Controls.Add(Me.btnConfirmar)
        Me.gbxBotones.Controls.Add(Me.btnEliminar)
        Me.gbxBotones.Controls.Add(Me.btnCancelar)
        Me.gbxBotones.Location = New System.Drawing.Point(148, 275)
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
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(9, 254)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(93, 13)
        Me.lblFechaNacimiento.TabIndex = 18
        Me.lblFechaNacimiento.Text = "Fecha Nacimiento"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(9, 227)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 16
        Me.lblEmail.Text = "Email"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(9, 200)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 14
        Me.lblDireccion.Text = "Dirección"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(9, 174)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 12
        Me.lblTelefono.Text = "Teléfono"
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Location = New System.Drawing.Point(9, 148)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(62, 13)
        Me.lblEstadoCivil.TabIndex = 10
        Me.lblEstadoCivil.Text = "Estado Civil"
        '
        'lblNroDocumento
        '
        Me.lblNroDocumento.AutoSize = True
        Me.lblNroDocumento.Location = New System.Drawing.Point(9, 122)
        Me.lblNroDocumento.Name = "lblNroDocumento"
        Me.lblNroDocumento.Size = New System.Drawing.Size(85, 13)
        Me.lblNroDocumento.TabIndex = 8
        Me.lblNroDocumento.Text = "Nro. Documento"
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDocumento.FormattingEnabled = True
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(106, 92)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(128, 21)
        Me.cmbTipoDocumento.TabIndex = 7
        '
        'lblTipoDocumento
        '
        Me.lblTipoDocumento.AutoSize = True
        Me.lblTipoDocumento.Location = New System.Drawing.Point(9, 95)
        Me.lblTipoDocumento.Name = "lblTipoDocumento"
        Me.lblTipoDocumento.Size = New System.Drawing.Size(86, 13)
        Me.lblTipoDocumento.TabIndex = 6
        Me.lblTipoDocumento.Text = "Tipo Documento"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(9, 68)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 4
        Me.lblApellido.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(106, 40)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(224, 20)
        Me.txtNombre.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(9, 42)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(106, 14)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(127, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(9, 16)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código"
        '
        'tbpConsulta
        '
        Me.tbpConsulta.Controls.Add(Me.dgvConsulta)
        Me.tbpConsulta.Location = New System.Drawing.Point(4, 22)
        Me.tbpConsulta.Name = "tbpConsulta"
        Me.tbpConsulta.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpConsulta.Size = New System.Drawing.Size(700, 360)
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
        Me.dgvConsulta.Size = New System.Drawing.Size(694, 354)
        Me.dgvConsulta.TabIndex = 0
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 413)
        Me.Controls.Add(Me.tbcPrincipal)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
