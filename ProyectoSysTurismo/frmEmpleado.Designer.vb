﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpleado
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
        Me.tbcEmpleado = New System.Windows.Forms.TabControl()
        Me.tbpempleado = New System.Windows.Forms.TabPage()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.cboEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.cboSucursal = New System.Windows.Forms.ComboBox()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.cboCargo = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboDocumento = New System.Windows.Forms.ComboBox()
        Me.nudAntiguedad = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodEmpleado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbpConsultaEmp = New System.Windows.Forms.TabPage()
        Me.dgvConsultaEmp = New System.Windows.Forms.DataGridView()
        Me.tbcEmpleado.SuspendLayout()
        Me.tbpempleado.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudAntiguedad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpConsultaEmp.SuspendLayout()
        CType(Me.dgvConsultaEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcEmpleado
        '
        Me.tbcEmpleado.Controls.Add(Me.tbpempleado)
        Me.tbcEmpleado.Controls.Add(Me.tbpConsultaEmp)
        Me.tbcEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcEmpleado.Location = New System.Drawing.Point(0, 0)
        Me.tbcEmpleado.Name = "tbcEmpleado"
        Me.tbcEmpleado.SelectedIndex = 0
        Me.tbcEmpleado.Size = New System.Drawing.Size(846, 486)
        Me.tbcEmpleado.TabIndex = 0
        '
        'tbpempleado
        '
        Me.tbpempleado.Controls.Add(Me.chkEstado)
        Me.tbpempleado.Controls.Add(Me.cboEstadoCivil)
        Me.tbpempleado.Controls.Add(Me.dtpFechaNac)
        Me.tbpempleado.Controls.Add(Me.txtTelefono)
        Me.tbpempleado.Controls.Add(Me.txtDireccion)
        Me.tbpempleado.Controls.Add(Me.cboSucursal)
        Me.tbpempleado.Controls.Add(Me.txtDocumento)
        Me.tbpempleado.Controls.Add(Me.cboCargo)
        Me.tbpempleado.Controls.Add(Me.Label13)
        Me.tbpempleado.Controls.Add(Me.Label12)
        Me.tbpempleado.Controls.Add(Me.Label11)
        Me.tbpempleado.Controls.Add(Me.txtApellido)
        Me.tbpempleado.Controls.Add(Me.GroupBox1)
        Me.tbpempleado.Controls.Add(Me.Label10)
        Me.tbpempleado.Controls.Add(Me.Label9)
        Me.tbpempleado.Controls.Add(Me.Label8)
        Me.tbpempleado.Controls.Add(Me.Label7)
        Me.tbpempleado.Controls.Add(Me.Label6)
        Me.tbpempleado.Controls.Add(Me.Label5)
        Me.tbpempleado.Controls.Add(Me.cboDocumento)
        Me.tbpempleado.Controls.Add(Me.nudAntiguedad)
        Me.tbpempleado.Controls.Add(Me.Label4)
        Me.tbpempleado.Controls.Add(Me.Label3)
        Me.tbpempleado.Controls.Add(Me.txtNombre)
        Me.tbpempleado.Controls.Add(Me.Label2)
        Me.tbpempleado.Controls.Add(Me.txtCodEmpleado)
        Me.tbpempleado.Controls.Add(Me.Label1)
        Me.tbpempleado.Location = New System.Drawing.Point(4, 22)
        Me.tbpempleado.Name = "tbpempleado"
        Me.tbpempleado.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpempleado.Size = New System.Drawing.Size(838, 460)
        Me.tbpempleado.TabIndex = 0
        Me.tbpempleado.Text = "ABMEmpleado"
        Me.tbpempleado.UseVisualStyleBackColor = True
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Checked = True
        Me.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEstado.Location = New System.Drawing.Point(97, 366)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(73, 17)
        Me.chkEstado.TabIndex = 53
        Me.chkEstado.Text = "Habilitado"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'cboEstadoCivil
        '
        Me.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstadoCivil.FormattingEnabled = True
        Me.cboEstadoCivil.Items.AddRange(New Object() {"Soltero", "Casado", "Viudo", "Divorciado"})
        Me.cboEstadoCivil.Location = New System.Drawing.Point(98, 293)
        Me.cboEstadoCivil.Name = "cboEstadoCivil"
        Me.cboEstadoCivil.Size = New System.Drawing.Size(128, 21)
        Me.cboEstadoCivil.TabIndex = 52
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNac.Location = New System.Drawing.Point(97, 176)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(130, 20)
        Me.dtpFechaNac.TabIndex = 51
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(98, 233)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(127, 20)
        Me.txtTelefono.TabIndex = 50
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(98, 262)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(225, 20)
        Me.txtDireccion.TabIndex = 49
        '
        'cboSucursal
        '
        Me.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSucursal.FormattingEnabled = True
        Me.cboSucursal.Location = New System.Drawing.Point(97, 201)
        Me.cboSucursal.Name = "cboSucursal"
        Me.cboSucursal.Size = New System.Drawing.Size(225, 21)
        Me.cboSucursal.TabIndex = 48
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(98, 148)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(127, 20)
        Me.txtDocumento.TabIndex = 47
        '
        'cboCargo
        '
        Me.cboCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCargo.FormattingEnabled = True
        Me.cboCargo.Location = New System.Drawing.Point(99, 93)
        Me.cboCargo.Name = "cboCargo"
        Me.cboCargo.Size = New System.Drawing.Size(225, 21)
        Me.cboCargo.TabIndex = 46
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 367)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Estado"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 330)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Antiguedad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 296)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Estado Civil"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(99, 67)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(127, 20)
        Me.txtApellido.TabIndex = 42
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnConfirmar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 391)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 65)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(64, 21)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmar.TabIndex = 2
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
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 263)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Direccion"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Telefono"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Sucursal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Fecha nac"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Nro Documento"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Tipo Documento"
        '
        'cboDocumento
        '
        Me.cboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDocumento.FormattingEnabled = True
        Me.cboDocumento.Location = New System.Drawing.Point(99, 119)
        Me.cboDocumento.Name = "cboDocumento"
        Me.cboDocumento.Size = New System.Drawing.Size(225, 21)
        Me.cboDocumento.TabIndex = 29
        '
        'nudAntiguedad
        '
        Me.nudAntiguedad.Location = New System.Drawing.Point(98, 328)
        Me.nudAntiguedad.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudAntiguedad.Name = "nudAntiguedad"
        Me.nudAntiguedad.Size = New System.Drawing.Size(120, 20)
        Me.nudAntiguedad.TabIndex = 28
        Me.nudAntiguedad.ThousandsSeparator = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Cargo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(99, 42)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(127, 20)
        Me.txtNombre.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nombre"
        '
        'txtCodEmpleado
        '
        Me.txtCodEmpleado.Location = New System.Drawing.Point(100, 13)
        Me.txtCodEmpleado.Name = "txtCodEmpleado"
        Me.txtCodEmpleado.ReadOnly = True
        Me.txtCodEmpleado.Size = New System.Drawing.Size(127, 20)
        Me.txtCodEmpleado.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Cod. Empleado"
        '
        'tbpConsultaEmp
        '
        Me.tbpConsultaEmp.Controls.Add(Me.dgvConsultaEmp)
        Me.tbpConsultaEmp.Location = New System.Drawing.Point(4, 22)
        Me.tbpConsultaEmp.Name = "tbpConsultaEmp"
        Me.tbpConsultaEmp.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpConsultaEmp.Size = New System.Drawing.Size(838, 460)
        Me.tbpConsultaEmp.TabIndex = 1
        Me.tbpConsultaEmp.Text = "Consulta Empleado"
        Me.tbpConsultaEmp.UseVisualStyleBackColor = True
        '
        'dgvConsultaEmp
        '
        Me.dgvConsultaEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaEmp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvConsultaEmp.Location = New System.Drawing.Point(3, 3)
        Me.dgvConsultaEmp.Name = "dgvConsultaEmp"
        Me.dgvConsultaEmp.Size = New System.Drawing.Size(832, 454)
        Me.dgvConsultaEmp.TabIndex = 0
        '
        'frmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 486)
        Me.Controls.Add(Me.tbcEmpleado)
        Me.Name = "frmEmpleado"
        Me.Text = "frmEmpleado"
        Me.tbcEmpleado.ResumeLayout(False)
        Me.tbpempleado.ResumeLayout(False)
        Me.tbpempleado.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.nudAntiguedad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpConsultaEmp.ResumeLayout(False)
        CType(Me.dgvConsultaEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcEmpleado As TabControl
    Friend WithEvents tbpempleado As TabPage
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents cboSucursal As ComboBox
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents cboCargo As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboDocumento As ComboBox
    Friend WithEvents nudAntiguedad As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodEmpleado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbpConsultaEmp As TabPage
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents dgvConsultaEmp As DataGridView
    Friend WithEvents cboEstadoCivil As ComboBox
    Friend WithEvents chkEstado As CheckBox
End Class
