Public Class frmPrincipal
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFechaHora.Text = lblFechaHora.Text + DateTime.Now

        ntiPrincipal.ShowBalloonTip(1000)
    End Sub

    Private Sub mnuClientes_Click(sender As Object, e As EventArgs) Handles mnuClientes.Click
        Dim f As New frmClientes
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuHabitacion_Click(sender As Object, e As EventArgs) Handles mnuHabitacion.Click
        Dim f As New frmHabitacion
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuEmpleados_Click(sender As Object, e As EventArgs) Handles mnuEmpleados.Click
        Dim f As New frmEmpleado
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        Me.Close()

    End Sub
End Class
