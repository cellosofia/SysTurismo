<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaCliente
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
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblDocumento = New System.Windows.Forms.Label()
        Me.dgvResultados = New System.Windows.Forms.DataGridView()
        Me.lblNombreApellido = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(120, 24)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(143, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Location = New System.Drawing.Point(22, 27)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(85, 13)
        Me.lblDocumento.TabIndex = 0
        Me.lblDocumento.Text = "Nro. Documento"
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.AllowUserToDeleteRows = False
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Location = New System.Drawing.Point(13, 63)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.ReadOnly = True
        Me.dgvResultados.Size = New System.Drawing.Size(681, 213)
        Me.dgvResultados.TabIndex = 5
        '
        'lblNombreApellido
        '
        Me.lblNombreApellido.AutoSize = True
        Me.lblNombreApellido.Location = New System.Drawing.Point(269, 27)
        Me.lblNombreApellido.Name = "lblNombreApellido"
        Me.lblNombreApellido.Size = New System.Drawing.Size(92, 13)
        Me.lblNombreApellido.TabIndex = 2
        Me.lblNombreApellido.Text = "Nombre / Apellido"
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(367, 24)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(189, 20)
        Me.txtFiltro.TabIndex = 3
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(575, 22)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frmConsultaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 288)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblNombreApellido)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.dgvResultados)
        Me.Controls.Add(Me.lblDocumento)
        Me.Controls.Add(Me.txtCodigo)
        Me.Name = "frmConsultaCliente"
        Me.Text = "frmConsultaCliente"
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblDocumento As Label
    Friend WithEvents dgvResultados As DataGridView
    Friend WithEvents lblNombreApellido As Label
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents btnBuscar As Button
End Class
