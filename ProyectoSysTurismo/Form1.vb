Public Class frmLogin
    Public conexion As SqlClient.SqlConnection
    Dim accion As String, id As String, sql As String
    Dim res As Integer, pass As String
    Dim com As SqlClient.SqlCommand, dr As SqlClient.SqlDataReader
    Dim da As SqlClient.SqlDataAdapter, cb As SqlClient.SqlCommandBuilder
    Dim ds As DataSet

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Call Me.verificar()


    End Sub

    Public Sub conectar()
        conexion = New SqlClient.SqlConnection
        conexion.ConnectionString = ("Integrated Security = SSPI;Initial Catalog=SysTurismo;Data Source=(local)")
        conexion.Open()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Me.Hide()
        registro.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub verificar()
        id = txtLogin.Text
        pass = txtPass.Text
        If id = "" Then
            lblid.Visible = True
        End If
        If pass = "" Then
            lblpass.Visible = True
        End If

        If id <> "" And pass <> "" Then

            sql = "exec ver_users '" + id + "'"
            conectar()
            com = New SqlClient.SqlCommand(sql, conexion)
            dr = com.ExecuteReader

            If dr.Read Then

                If id = dr(0) And pass = dr(3) Then
                    'proyecto.lbluser.Text = dr(1)
                    frmPrincipal.Show()
                    Me.Hide()



                Else
                    MsgBox("Constraseña incorrecta", MsgBoxStyle.Exclamation, "Acceso")

                End If
            Else
                MsgBox("Por favor registrese", MsgBoxStyle.Exclamation, "Acesoo denegado")


            End If
        Else
            MsgBox("Por favor ingrese datos", MsgBoxStyle.Exclamation, "Ingrese")
        End If


    End Sub
End Class
