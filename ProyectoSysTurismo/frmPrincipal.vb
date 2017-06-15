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
        If (MessageBox.Show("Desea Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = vbYes Then
            ' MsgBox("Se va a cerrar el formulario y el programa")
            'Me.Close()
            End
            Me.Close()
        End If



    End Sub

    Private Sub stsPrincipal_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles stsPrincipal.ItemClicked

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmEmpleado.Show()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frmClientes.Show()

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Dim f As New SucursalAlojamiento
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub SucursalAlojamientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SucursalAlojamientoToolStripMenuItem.Click
        Dim f As New SucursalAlojamiento
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dim f As New frmHabitacion
        f.MdiParent = Me
        f.Show()
    End Sub
End Class
