Public Class frmHabitacion
    Private Sub tbcPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcPrincipal.SelectedIndexChanged
        If tbcPrincipal.SelectedIndex = 1 Then
            dgvConsulta.DataSource = generar_datatabla("select * from Habitacion")
        End If
    End Sub

    Private Sub frmHabitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboEstadoHabitacion.DataSource = generar_datatabla("select * from EstadoHabitacion")
        cboEstadoHabitacion.ValueMember = "EstadoHabitacionID"
        cboEstadoHabitacion.DisplayMember = "Descripcion"

        cboTipoHabitacion.DataSource = generar_datatabla("select * from TipoHabitacion")
        cboTipoHabitacion.ValueMember = "TipoHabitacionID"
        cboTipoHabitacion.DisplayMember = "Descripcion"

        txtNroHabitacion.Focus()
    End Sub
End Class