<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registro
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.m1 = New System.Windows.Forms.Label()
        Me.m2 = New System.Windows.Forms.Label()
        Me.m3 = New System.Windows.Forms.Label()
        Me.m4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtConfirmar = New System.Windows.Forms.TextBox()
        Me.lblConfirmar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ID"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(122, 92)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 7
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(122, 49)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Email"
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(121, 177)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(100, 20)
        Me.txtContraseña.TabIndex = 11
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(121, 134)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 10
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(146, 299)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 15
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(48, 299)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'm1
        '
        Me.m1.AutoSize = True
        Me.m1.ForeColor = System.Drawing.Color.Red
        Me.m1.Location = New System.Drawing.Point(122, 73)
        Me.m1.Name = "m1"
        Me.m1.Size = New System.Drawing.Size(57, 13)
        Me.m1.TabIndex = 16
        Me.m1.Text = "Obligatorio"
        Me.m1.Visible = False
        '
        'm2
        '
        Me.m2.AutoSize = True
        Me.m2.ForeColor = System.Drawing.Color.Red
        Me.m2.Location = New System.Drawing.Point(122, 115)
        Me.m2.Name = "m2"
        Me.m2.Size = New System.Drawing.Size(57, 13)
        Me.m2.TabIndex = 17
        Me.m2.Text = "Obligatorio"
        Me.m2.Visible = False
        '
        'm3
        '
        Me.m3.AutoSize = True
        Me.m3.ForeColor = System.Drawing.Color.Red
        Me.m3.Location = New System.Drawing.Point(122, 157)
        Me.m3.Name = "m3"
        Me.m3.Size = New System.Drawing.Size(57, 13)
        Me.m3.TabIndex = 18
        Me.m3.Text = "Obligatorio"
        Me.m3.Visible = False
        '
        'm4
        '
        Me.m4.AutoSize = True
        Me.m4.ForeColor = System.Drawing.Color.Red
        Me.m4.Location = New System.Drawing.Point(122, 200)
        Me.m4.Name = "m4"
        Me.m4.Size = New System.Drawing.Size(57, 13)
        Me.m4.TabIndex = 19
        Me.m4.Text = "Obligatorio"
        Me.m4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Confirmar"
        '
        'txtConfirmar
        '
        Me.txtConfirmar.Location = New System.Drawing.Point(121, 216)
        Me.txtConfirmar.Name = "txtConfirmar"
        Me.txtConfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmar.Size = New System.Drawing.Size(100, 20)
        Me.txtConfirmar.TabIndex = 20
        '
        'lblConfirmar
        '
        Me.lblConfirmar.AutoSize = True
        Me.lblConfirmar.ForeColor = System.Drawing.Color.Red
        Me.lblConfirmar.Location = New System.Drawing.Point(122, 239)
        Me.lblConfirmar.Name = "lblConfirmar"
        Me.lblConfirmar.Size = New System.Drawing.Size(57, 13)
        Me.lblConfirmar.TabIndex = 22
        Me.lblConfirmar.Text = "Obligatorio"
        Me.lblConfirmar.Visible = False
        '
        'registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 358)
        Me.Controls.Add(Me.lblConfirmar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtConfirmar)
        Me.Controls.Add(Me.m4)
        Me.Controls.Add(Me.m3)
        Me.Controls.Add(Me.m2)
        Me.Controls.Add(Me.m1)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtId)
        Me.Name = "registro"
        Me.Text = "registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents m1 As Label
    Friend WithEvents m2 As Label
    Friend WithEvents m3 As Label
    Friend WithEvents m4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtConfirmar As TextBox
    Friend WithEvents lblConfirmar As Label
End Class
