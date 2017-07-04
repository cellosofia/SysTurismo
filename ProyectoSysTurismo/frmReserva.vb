Imports System.Data.SqlClient

Public Class frmReserva

    Dim Transac As SqlTransaction

    Private Sub txtCliente_DoubleClick(sender As Object, e As EventArgs) Handles txtCliente.DoubleClick
        frmConsultaCliente.ShowDialog()
        txtCliente.Text = vCliente_Nombre
    End Sub

    Private Sub frmReserva_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            With cboAlojamiento
                .DataSource = generar_datatabla("SELECT * FROM Alojamiento")
                .DisplayMember = "Nombre"
                .ValueMember = "AlojamientoID"
            End With

            With cboServicio
                .DataSource = generar_datatabla("SELECT * FROM TipoServicioHabitacion")
                .DisplayMember = "Descripcion"
                .ValueMember = "TipoServicioHabitacionID"
            End With

            gbxDetalle.Enabled = False
            dtpFechaReserva.Value = Date.Today
            txtCliente.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.F9 Then
            frmConsultaCliente.ShowDialog()
            txtCliente.Text = vCliente_Nombre
        End If
    End Sub

    Private Sub btnHabilitarDetalle_Click(sender As Object, e As EventArgs) Handles btnHabilitarDetalle.Click
        Try
            If txtCliente.Text.Trim = "" Or vCliente_ID = 0 Then
                MessageBox.Show("Debe ingresar el cliente. Doble Click en el campo de texto para seleccionar. Tecla F9 sobre el campo de texto también.", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If cboAlojamiento.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar el alojamiento", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If cboSucursalAlojamiento.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar el alojamiento", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Transac = IniciarTransaccion()

            gbxDetalle.Enabled = True

            cboServicio.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboAlojamiento_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboAlojamiento.SelectedValueChanged
        With cboSucursalAlojamiento
            .DataSource = generar_datatabla("SELECT * FROM SucursalAlojamiento WHERE AlojamientoID=" & cboAlojamiento.SelectedValue)
            .DisplayMember = "Nombre"
            .ValueMember = "SucursalAlojamientoID"
        End With
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub
End Class