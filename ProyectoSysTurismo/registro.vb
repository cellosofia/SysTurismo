Public Class registro
    Public conexion As SqlClient.SqlConnection
    Dim accion As String, id As String, sql As String
    Dim res As Integer, nom, email, pass As String
    Dim com As SqlClient.SqlCommand, dr As SqlClient.SqlDataReader

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Call Me.verificar()

    End Sub

    Dim da As SqlClient.SqlDataAdapter, c As SqlClient.SqlCommandBuilder
    Dim ds As DataSet
    Public Sub conectar()
        conexion = New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=(localdb)\mssqllocaldb;Initial Catalog=SysTurismo;Integrated Security=True;Connect Timeout=30"
        conexion.Open()

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        frmLogin.Show()

    End Sub
    Private Sub verificar()
        If txtId.Text = "" Then
            m1.Visible = True
        Else
            m1.Visible = False

        End If
        If txtNombre.Text = "" Then
            m2.Visible = True
        Else
            m2.Visible = False

        End If
        If txtEmail.Text = "" Then
            m3.Visible = True
        Else
            m3.Visible = False

        End If
        If txtContraseña.Text = "" Then
            m4.Visible = True
        Else
            m4.Visible = False
        End If

        If txtConfirmar.Text = "" Then
            lblConfirmar.Visible = True
        Else
            lblConfirmar.Visible = False
        End If

        If txtId.Text <> "" And txtNombre.Text <> "" And txtEmail.Text <> "" And txtContraseña.Text <> "" And txtConfirmar.Text <> "" And txtContraseña.Text = txtConfirmar.Text Then
            Me.register()
            Me.Hide()
            frmLogin.Show()
        Else
            If txtContraseña.Text <> txtConfirmar.Text Then
                MessageBox.Show("Las contraseñas no coinciden", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub register()

        id = txtId.Text
        nom = txtNombre.Text
        email = txtEmail.Text
        pass = txtContraseña.Text
        sql = "exec ver_users  '" + id + "'"
        conectar()
        com = New SqlClient.SqlCommand(sql, conexion)
        dr = com.ExecuteReader
        If dr.Read Then
            MessageBox.Show("El id ya esta registrado", "users", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dr.Close()
            conexion.Close()
        Else
            sql = "exec alta_users" + "'" + id + "','" + nom + "','" + email + "','" + pass + "'"
            conectar()
            com = New SqlClient.SqlCommand(sql, conexion)
            res = com.ExecuteNonQuery
            conexion.Close()

            MsgBox("Felicidades ya puede ingresar", MsgBoxStyle.Information, "Datos Guardados ")

        End If
    End Sub
End Class