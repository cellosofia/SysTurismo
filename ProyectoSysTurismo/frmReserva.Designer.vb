﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReserva
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnHabilitarDetalle = New System.Windows.Forms.Button()
        Me.gbxDetalle = New System.Windows.Forms.GroupBox()
        Me.cboServicio = New System.Windows.Forms.ComboBox()
        Me.lblServicio = New System.Windows.Forms.Label()
        Me.nudPrecio = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblHabitacion = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.cboSucursalAlojamiento = New System.Windows.Forms.ComboBox()
        Me.lblSucursalAlojamiento = New System.Windows.Forms.Label()
        Me.lblAlojamiento = New System.Windows.Forms.Label()
        Me.cboAlojamiento = New System.Windows.Forms.ComboBox()
        Me.dtpFechaReserva = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaReserva = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.cboHabitacion = New System.Windows.Forms.ComboBox()
        Me.Habitacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Servicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioHabitacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblPrecioHabitacion = New System.Windows.Forms.Label()
        Me.gbxDetalle.SuspendLayout()
        CType(Me.nudPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(487, 391)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 18)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Total Reserva"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(611, 391)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(16, 18)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "0"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(490, 433)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 12
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(576, 433)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnHabilitarDetalle
        '
        Me.btnHabilitarDetalle.Location = New System.Drawing.Point(606, 53)
        Me.btnHabilitarDetalle.Name = "btnHabilitarDetalle"
        Me.btnHabilitarDetalle.Size = New System.Drawing.Size(112, 23)
        Me.btnHabilitarDetalle.TabIndex = 8
        Me.btnHabilitarDetalle.Text = "Habilitar Detalle"
        Me.btnHabilitarDetalle.UseVisualStyleBackColor = True
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Controls.Add(Me.lblPrecioHabitacion)
        Me.gbxDetalle.Controls.Add(Me.cboHabitacion)
        Me.gbxDetalle.Controls.Add(Me.cboServicio)
        Me.gbxDetalle.Controls.Add(Me.lblServicio)
        Me.gbxDetalle.Controls.Add(Me.nudPrecio)
        Me.gbxDetalle.Controls.Add(Me.Label6)
        Me.gbxDetalle.Controls.Add(Me.lblHabitacion)
        Me.gbxDetalle.Controls.Add(Me.btnEliminar)
        Me.gbxDetalle.Controls.Add(Me.btnAgregar)
        Me.gbxDetalle.Controls.Add(Me.dgvDetalle)
        Me.gbxDetalle.Location = New System.Drawing.Point(15, 80)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(753, 297)
        Me.gbxDetalle.TabIndex = 9
        Me.gbxDetalle.TabStop = False
        Me.gbxDetalle.Text = "Detalle Reserva"
        '
        'cboServicio
        '
        Me.cboServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboServicio.FormattingEnabled = True
        Me.cboServicio.Location = New System.Drawing.Point(78, 229)
        Me.cboServicio.Name = "cboServicio"
        Me.cboServicio.Size = New System.Drawing.Size(340, 21)
        Me.cboServicio.TabIndex = 2
        '
        'lblServicio
        '
        Me.lblServicio.AutoSize = True
        Me.lblServicio.Location = New System.Drawing.Point(16, 232)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(45, 13)
        Me.lblServicio.TabIndex = 1
        Me.lblServicio.Text = "Servicio"
        '
        'nudPrecio
        '
        Me.nudPrecio.Location = New System.Drawing.Point(259, 256)
        Me.nudPrecio.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.nudPrecio.Name = "nudPrecio"
        Me.nudPrecio.Size = New System.Drawing.Size(159, 20)
        Me.nudPrecio.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(216, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Precio"
        '
        'lblHabitacion
        '
        Me.lblHabitacion.AutoSize = True
        Me.lblHabitacion.Location = New System.Drawing.Point(17, 258)
        Me.lblHabitacion.Name = "lblHabitacion"
        Me.lblHabitacion.Size = New System.Drawing.Size(58, 13)
        Me.lblHabitacion.TabIndex = 3
        Me.lblHabitacion.Text = "Habitacion"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(672, 225)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(591, 225)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Habitacion, Me.Servicio, Me.PrecioHabitacion, Me.PrecioServicio, Me.SubTotal})
        Me.dgvDetalle.Location = New System.Drawing.Point(17, 29)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.Size = New System.Drawing.Size(735, 180)
        Me.dgvDetalle.TabIndex = 0
        '
        'cboSucursalAlojamiento
        '
        Me.cboSucursalAlojamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSucursalAlojamiento.FormattingEnabled = True
        Me.cboSucursalAlojamiento.Location = New System.Drawing.Point(327, 36)
        Me.cboSucursalAlojamiento.Name = "cboSucursalAlojamiento"
        Me.cboSucursalAlojamiento.Size = New System.Drawing.Size(260, 21)
        Me.cboSucursalAlojamiento.TabIndex = 7
        '
        'lblSucursalAlojamiento
        '
        Me.lblSucursalAlojamiento.AutoSize = True
        Me.lblSucursalAlojamiento.Location = New System.Drawing.Point(279, 39)
        Me.lblSucursalAlojamiento.Name = "lblSucursalAlojamiento"
        Me.lblSucursalAlojamiento.Size = New System.Drawing.Size(48, 13)
        Me.lblSucursalAlojamiento.TabIndex = 6
        Me.lblSucursalAlojamiento.Text = "Sucursal"
        '
        'lblAlojamiento
        '
        Me.lblAlojamiento.AutoSize = True
        Me.lblAlojamiento.Location = New System.Drawing.Point(265, 9)
        Me.lblAlojamiento.Name = "lblAlojamiento"
        Me.lblAlojamiento.Size = New System.Drawing.Size(61, 13)
        Me.lblAlojamiento.TabIndex = 2
        Me.lblAlojamiento.Text = "Alojamiento"
        '
        'cboAlojamiento
        '
        Me.cboAlojamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlojamiento.FormattingEnabled = True
        Me.cboAlojamiento.Location = New System.Drawing.Point(327, 6)
        Me.cboAlojamiento.Name = "cboAlojamiento"
        Me.cboAlojamiento.Size = New System.Drawing.Size(260, 21)
        Me.cboAlojamiento.TabIndex = 3
        '
        'dtpFechaReserva
        '
        Me.dtpFechaReserva.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaReserva.Location = New System.Drawing.Point(93, 35)
        Me.dtpFechaReserva.Name = "dtpFechaReserva"
        Me.dtpFechaReserva.Size = New System.Drawing.Size(166, 20)
        Me.dtpFechaReserva.TabIndex = 5
        '
        'lblFechaReserva
        '
        Me.lblFechaReserva.AutoSize = True
        Me.lblFechaReserva.Location = New System.Drawing.Point(12, 38)
        Me.lblFechaReserva.Name = "lblFechaReserva"
        Me.lblFechaReserva.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaReserva.TabIndex = 4
        Me.lblFechaReserva.Text = "Fecha Reserva"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(12, 9)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(39, 13)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Cliente"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(93, 6)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(166, 20)
        Me.txtCliente.TabIndex = 1
        '
        'cboHabitacion
        '
        Me.cboHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHabitacion.FormattingEnabled = True
        Me.cboHabitacion.Location = New System.Drawing.Point(78, 256)
        Me.cboHabitacion.Name = "cboHabitacion"
        Me.cboHabitacion.Size = New System.Drawing.Size(132, 21)
        Me.cboHabitacion.TabIndex = 9
        '
        'Habitacion
        '
        Me.Habitacion.DataPropertyName = "Habitacion"
        Me.Habitacion.HeaderText = "Habitacion"
        Me.Habitacion.Name = "Habitacion"
        Me.Habitacion.ReadOnly = True
        '
        'Servicio
        '
        Me.Servicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Servicio.DataPropertyName = "Servicio"
        Me.Servicio.HeaderText = "Servicio"
        Me.Servicio.Name = "Servicio"
        Me.Servicio.ReadOnly = True
        '
        'PrecioHabitacion
        '
        Me.PrecioHabitacion.DataPropertyName = "PrecioHabitacion"
        Me.PrecioHabitacion.HeaderText = "PrecioHabitacion"
        Me.PrecioHabitacion.Name = "PrecioHabitacion"
        Me.PrecioHabitacion.ReadOnly = True
        '
        'PrecioServicio
        '
        Me.PrecioServicio.DataPropertyName = "PrecioServicio"
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.PrecioServicio.DefaultCellStyle = DataGridViewCellStyle2
        Me.PrecioServicio.HeaderText = "PrecioServicio"
        Me.PrecioServicio.Name = "PrecioServicio"
        Me.PrecioServicio.ReadOnly = True
        Me.PrecioServicio.Width = 150
        '
        'SubTotal
        '
        Me.SubTotal.DataPropertyName = "SubTotal"
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        '
        'lblPrecioHabitacion
        '
        Me.lblPrecioHabitacion.AutoSize = True
        Me.lblPrecioHabitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioHabitacion.Location = New System.Drawing.Point(424, 229)
        Me.lblPrecioHabitacion.Name = "lblPrecioHabitacion"
        Me.lblPrecioHabitacion.Size = New System.Drawing.Size(0, 13)
        Me.lblPrecioHabitacion.TabIndex = 14
        '
        'frmReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 468)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnHabilitarDetalle)
        Me.Controls.Add(Me.gbxDetalle)
        Me.Controls.Add(Me.lblAlojamiento)
        Me.Controls.Add(Me.cboAlojamiento)
        Me.Controls.Add(Me.cboSucursalAlojamiento)
        Me.Controls.Add(Me.lblSucursalAlojamiento)
        Me.Controls.Add(Me.dtpFechaReserva)
        Me.Controls.Add(Me.lblFechaReserva)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.lblCliente)
        Me.Name = "frmReserva"
        Me.Text = "frmReserva"
        Me.gbxDetalle.ResumeLayout(False)
        Me.gbxDetalle.PerformLayout()
        CType(Me.nudPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnHabilitarDetalle As Button
    Friend WithEvents gbxDetalle As GroupBox
    Friend WithEvents cboServicio As ComboBox
    Friend WithEvents lblServicio As Label
    Friend WithEvents nudPrecio As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents lblHabitacion As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cboSucursalAlojamiento As ComboBox
    Friend WithEvents lblSucursalAlojamiento As Label
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents lblAlojamiento As Label
    Friend WithEvents cboAlojamiento As ComboBox
    Friend WithEvents dtpFechaReserva As DateTimePicker
    Friend WithEvents lblFechaReserva As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents cboHabitacion As ComboBox
    Friend WithEvents Habitacion As DataGridViewTextBoxColumn
    Friend WithEvents Servicio As DataGridViewTextBoxColumn
    Friend WithEvents PrecioHabitacion As DataGridViewTextBoxColumn
    Friend WithEvents PrecioServicio As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents lblPrecioHabitacion As Label
End Class
