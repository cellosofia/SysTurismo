Imports System.Data.SqlClient

Public Class frmReserva

    Dim Transac As SqlTransaction
    Dim vPrecioHabitacion As Decimal
    Dim vReservaID As Integer
    Dim vImporteDetalle As Decimal

    Private Sub txtCliente_DoubleClick(sender As Object, e As EventArgs) Handles txtCliente.DoubleClick
        frmConsultaCliente.ShowDialog()
        txtCliente.Text = vCliente_Nombre
    End Sub

    Private Sub frmReserva_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            LimpiarFormulario()

            With cboAlojamiento
                .DisplayMember = "Nombre"
                .ValueMember = "AlojamientoID"
                .DataSource = generar_datatabla("SELECT Nombre, AlojamientoID FROM Alojamiento")
            End With

            With cboServicio
                .DisplayMember = "Descripcion"
                .ValueMember = "TipoServicioHabitacionID"
                .DataSource = generar_datatabla("SELECT Descripcion, TipoServicioHabitacionID FROM TipoServicioHabitacion")
            End With

            If cboSucursalAlojamiento.Items.Count > 0 Then
                cboSucursalAlojamiento.SelectedIndex = 0
            End If

            If cboHabitacion.Items.Count > 0 Then
                cboHabitacion.SelectedIndex = 0
            End If


            gbxDetalle.Enabled = False
            dtpFechaReserva.Value = Date.Today
            txtCliente.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboAlojamiento_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboAlojamiento.SelectedValueChanged
        If Not IsNothing(cboAlojamiento.SelectedValue) Then
            If IsNothing(Transac) Then
                With cboSucursalAlojamiento
                    .DisplayMember = "Nombre"
                    .ValueMember = "SucursalAlojamientoID"
                    .DataSource = generar_datatabla("SELECT * FROM SucursalAlojamiento WHERE AlojamientoID=" & cboAlojamiento.SelectedValue)
                End With
            Else
                With cboSucursalAlojamiento
                    .DisplayMember = "Nombre"
                    .ValueMember = "SucursalAlojamientoID"
                    .DataSource = generar_datatabla("SELECT * FROM SucursalAlojamiento WHERE AlojamientoID=" & cboAlojamiento.SelectedValue, Transac)
                End With
            End If
        End If
    End Sub

    Private Sub cboServicio_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboServicio.SelectedValueChanged
        If Not IsNothing(cboServicio.SelectedValue) Then
            If cboServicio.SelectedValue <> -1 Then
                If IsNothing(Transac) Then
                    nudPrecio.Value = TraerValor("SELECT Precio FROM TipoServicioHabitacion WHERE TipoServicioHabitacionID=" & cboServicio.SelectedValue)
                Else
                    nudPrecio.Value = TraerValor("SELECT Precio FROM TipoServicioHabitacion WHERE TipoServicioHabitacionID=" & cboServicio.SelectedValue, Transac)
                End If
            End If
        End If
    End Sub

    Private Sub cboSucursalAlojamiento_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboSucursalAlojamiento.SelectedValueChanged
        If Not IsNothing(cboSucursalAlojamiento.SelectedValue) Then
            If IsNothing(Transac) Then
                With cboHabitacion
                    .DisplayMember = "NroHabitacion"
                    .ValueMember = "HabitacionID"
                    ' Seleccionamos solamente las habitaciones que estan libres con EstadoHabitacionID=1
                    .DataSource = generar_datatabla("SELECT NroHabitacion, HabitacionID FROM Habitacion WHERE EstadoHabitacionID=1 AND SucursalAlojamientoID=" & cboSucursalAlojamiento.SelectedValue)
                End With
            Else
                With cboHabitacion
                    .DisplayMember = "NroHabitacion"
                    .ValueMember = "HabitacionID"
                    ' Seleccionamos solamente las habitaciones que estan libres con EstadoHabitacionID=1
                    .DataSource = generar_datatabla("SELECT NroHabitacion, HabitacionID FROM Habitacion WHERE EstadoHabitacionID=1 AND SucursalAlojamientoID=" & cboSucursalAlojamiento.SelectedValue, Transac)
                End With
            End If
            If cboHabitacion.Items.Count = 0 Then
                MessageBox.Show("Ya no existen habitaciones disponibles en esta sucursal [" & cboSucursalAlojamiento.Text & "], por favor seleccione otra", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cboSucursalAlojamiento.Focus()
            End If
        End If
    End Sub

    Private Sub cboHabitacion_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboHabitacion.SelectedValueChanged
        If Not IsNothing(cboHabitacion.SelectedValue) Then
            If cboHabitacion.SelectedValue <> -1 Then
                If IsNothing(Transac) Then
                    vPrecioHabitacion = TraerValor("SELECT Precio FROM Habitacion WHERE HabitacionID=" & cboHabitacion.SelectedValue)
                Else
                    vPrecioHabitacion = TraerValor("SELECT Precio FROM Habitacion WHERE HabitacionID=" & cboHabitacion.SelectedValue, Transac)
                End If
                lblPrecioHabitacion.Text = "Precio Habitacion:" & vbCrLf & "Gs. " & vPrecioHabitacion
            End If
        End If
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

            EjecutarSQL("INSERT INTO Reserva VALUES (@1,@2,@3,@4,@5,@6)", Transac, vCliente_ID, cboAlojamiento.SelectedValue, cboSucursalAlojamiento.SelectedValue, 0, dtpFechaReserva.Value, 0)

            gbxDetalle.Enabled = True

            cboServicio.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            ' Validar
            If cboServicio.Text = "" Then
                cboServicio.Focus()
                MessageBox.Show("Debe seleccionar un servicio", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If cboHabitacion.Text = "" Then
                cboHabitacion.Focus()
                MessageBox.Show("Debe seleccionar el numero de habitación", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If nudPrecio.Value <= 0 Then
                nudPrecio.Focus()
                MessageBox.Show("Debe ingresar un precio mayor a cero (0)", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            For Each r As DataGridViewRow In dgvDetalle.Rows
                If r.Cells.Item("Servicio").Value = cboServicio.Text And r.Cells.Item("Habitacion").Value = cboHabitacion.Text Then
                    cboServicio.Focus()
                    MessageBox.Show("Este servicio ya ha sido cargado para la habitacion", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            Next

            vReservaID = TraerValor("SELECT MAX(ReservaID) FROM Reserva", Transac)
            Dim yaReservoHabitacion As Boolean = TraerValor("SELECT COUNT(HabitacionID) FROM ReservaDetalle WHERE ReservaID=" & vReservaID & " AND HabitacionId=" & cboHabitacion.SelectedValue, Transac) > 0

            If yaReservoHabitacion Then
                vPrecioHabitacion = 0
            End If

            vImporteDetalle = vPrecioHabitacion + nudPrecio.Value

            EjecutarSQL("INSERT INTO ReservaDetalle VALUES(@1,@2,@3,@4,@5,@6)", Transac, vReservaID, cboHabitacion.SelectedValue, cboServicio.SelectedValue, nudPrecio.Value, vPrecioHabitacion, vImporteDetalle)
            EjecutarSQL("UPDATE Reserva SET PrecioReserva=PrecioReserva + @1 WHERE ReservaID=@2", Transac, vImporteDetalle, vReservaID)

            LimpiarIngresoFormulario()
            lblTotal.Text = Format(CDec(lblTotal.Text) + vImporteDetalle, "###,###,###")

            ActualizarDataGrid()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AnularTransaccion(Transac)
        End Try
    End Sub

    Private Sub ActualizarDataGrid()
        dgvDetalle.DataSource = generar_datatabla("SELECT h.NroHabitacion [Habitacion], tsh.Descripcion [Servicio], rd.PrecioHabitacion, rd.PrecioServicio, rd.PrecioDetalle [SubTotal] FROM ReservaDetalle rd JOIN Habitacion h ON rd.HabitacionID = h.HabitacionID JOIN TipoServicioHabitacion tsh ON rd.TipoServicioHabitacionID = tsh.TipoServicioHabitacionID WHERE ReservaID=" & vReservaID, Transac)
    End Sub

    Private Sub LimpiarIngresoFormulario()
        cboServicio.SelectedIndex = 0  ' dispara evento de actualización de precio
        cboHabitacion.SelectedIndex = 0
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvDetalle.Rows.Count > 0 Then

            Dim fila As DataGridViewRow = dgvDetalle.CurrentRow
            Dim vHabitacionID = TraerValor("SELECT HabitacionID FROM Habitacion WHERE NroHabitacion='" & fila.Cells("Habitacion").Value & "' AND SucursalAlojamientoID=" & cboSucursalAlojamiento.SelectedValue, Transac)
            Dim vTipoServicioHabitacionID = TraerValor("SELECT TipoServicioHabitacionID FROM TipoServicioHabitacion WHERE Descripcion='" & fila.Cells("Servicio").Value & "'", Transac)
            Dim SubTotal = fila.Cells("SubTotal").Value

            EjecutarSQL("DELETE from ReservaDetalle WHERE ReservaID=@1 AND HabitacionID=@2 AND TipoServicioHabitacionID=@3", Transac, vReservaID, vHabitacionID, vTipoServicioHabitacionID)
            EjecutarSQL("UPDATE Reserva SET PrecioReserva=PrecioReserva - @1 where ReservaID=@2", Transac, SubTotal, vReservaID)

            LimpiarIngresoFormulario()

            lblTotal.Text = Format(CDec(lblTotal.Text) - SubTotal, "###,###,###")

            If lblTotal.Text = "" Then
                lblTotal.Text = "0"
            End If

            ActualizarDataGrid()
        Else
            MessageBox.Show("No existe fila para eliminar", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim dtHabitaciones As New DataTable
        dtHabitaciones = generar_datatabla("SELECT HabitacionID FROM ReservaDetalle WHERE ReservaID=" & vReservaID, Transac)

        For Each fila As DataRow In dtHabitaciones.Rows
            EjecutarSQL("UPDATE Habitacion SET EstadoHabitacionID=3 WHERE HabitacionID=" & fila.Item("HabitacionID"), Transac)
        Next

        ConfirmarTransaccion(Transac)
        LimpiarFormulario()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If Not IsNothing(Transac) Then
            AnularTransaccion(Transac)
        End If

        LimpiarFormulario()
        Me.Close()
    End Sub

    Private Sub LimpiarFormulario()
        txtCliente.Text = ""
        dtpFechaReserva.Value = Date.Today
        cboHabitacion.SelectedValue = -1
        cboServicio.SelectedValue = -1
        cboSucursalAlojamiento.SelectedValue = -1
        nudPrecio.Value = 0
        cboAlojamiento.SelectedValue = -1 ' Esto hace que se dispare el vento SelectedChange del combo box cboAlojamiento y se cargue dinamicamente el combo box de SucursalAlojamiento, luego el combo box de las habitaciones disponibles y el precio de la habitacion y del servicio
        dgvDetalle.DataSource = Nothing
        gbxDetalle.Enabled = False
        lblTotal.Text = "0"
        vReservaID = 0
        vImporteDetalle = 0
        vPrecioHabitacion = 0
        Transac = Nothing
    End Sub
End Class