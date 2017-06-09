Public Class frmPrincipal
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFechaHora.Text = lblFechaHora.Text + DateTime.Now

        ntiPrincipal.ShowBalloonTip(100)
    End Sub

    Private Sub mnuClientes_Click(sender As Object, e As EventArgs) Handles mnuClientes.Click
        Dim f As New frmClientes
        f.MdiParent = Me
        f.Show()
    End Sub
End Class
