Public Class frmConsultaCliente
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            RealizarBusqueda()
        End If
    End Sub

    Private Sub RealizarBusqueda()
        dgvResultados.DataSource = generar_datatabla("SELECT * FROM vista_cliente WHERE [Numero Documento] LIKE '%" & txtCodigo.Text.Trim & "%' AND (Nombre LIKE '%" & txtFiltro.Text.Trim & "%' OR Apellido LIKE '%" & txtFiltro.Text.Trim & "%') AND [Estado Sistema] = 'Habilitado'")
    End Sub

    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            RealizarBusqueda()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        RealizarBusqueda()
    End Sub

    Private Sub dgvResultados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResultados.CellContentClick
        vCliente_Nombre = dgvResultados.Rows(e.RowIndex).Cells.Item("Apellido").Value & ", " & dgvResultados.Rows(e.RowIndex).Cells.Item("Nombre").Value
        vCliente_ID = dgvResultados.Rows(e.RowIndex).Cells.Item("Codigo").Value
        Me.Close()
    End Sub
End Class