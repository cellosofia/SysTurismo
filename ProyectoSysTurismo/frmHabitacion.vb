Imports System.Data.SqlClient
Imports ProyectoSysTurismo.acceso_datos
Public Class frmHabitacion
    Dim vNuevo As Boolean = True
    Dim Habilitado As Boolean = True

    Private Sub tbcPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcPrincipal.SelectedIndexChanged
        If tbcPrincipal.SelectedIndex = 1 Then
            dgvConsulta.DataSource = generar_datatabla("select * from vista_habitacion")
        End If
    End Sub
    Function DatosValidos() As Boolean
        If txtNroHabitacion.Text.Trim = "" Then
            txtNroHabitacion.Focus()
            MessageBox.Show("Debe insertar el N° de Habitacion", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If cboSucursal.SelectedIndex = -1 Then
            cboSucursal.Focus()
            MessageBox.Show("Debe insertar la sucursal", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If cboTipoHabitacion.SelectedIndex = -1 Then
            cboTipoHabitacion.Focus()
            MessageBox.Show("Debe insertar el tipo de habitacion", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If cboEstadoHabitacion.SelectedIndex = -1 Then
            cboEstadoHabitacion.Focus()
            MessageBox.Show("Debe insertar estado de la habitacion", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If nudPrecio.Value = 0 Then
            nudPrecio.Focus()
            MessageBox.Show("Debe insertar un precio valido", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If


        Return True

    End Function

    Private Sub LimpiarFormulario()
        txtCodigo.Text = ""

        txtNroHabitacion.Text = ""
        cboSucursal.SelectedIndex = -1
        cboTipoHabitacion.SelectedIndex = -1
        cboEstadoHabitacion.SelectedIndex = -1
        nudPrecio.Value = 0
        chkHabilitado.Checked = True


    End Sub

    Private Sub frmHabitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboEstadoHabitacion.DataSource = generar_datatabla("select * from EstadoHabitacion")
        cboEstadoHabitacion.ValueMember = "EstadoHabitacionID"
        cboEstadoHabitacion.DisplayMember = "Descripcion"

        cboTipoHabitacion.DataSource = generar_datatabla("select * from TipoHabitacion")
        cboTipoHabitacion.ValueMember = "TipoHabitacionID"
        cboTipoHabitacion.DisplayMember = "Descripcion"

        cboSucursal.DataSource = generar_datatabla("select * from SucursalAlojamiento")
        cboSucursal.ValueMember = "SucursalAlojamientoID"
        cboSucursal.DisplayMember = "Nombre"

        txtNroHabitacion.Focus()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Try


            If DatosValidos() Then
                Dim comando As New SqlCommand

                'Dim EstadoCivil As Char
                ' Dim sexo As Integer

                If Habilitado = 1 Then

                End If

                If vNuevo = True Then
                    EjecutarSQL("INSERT INTO Habitacion VALUES(@1,@2,@3,@4,@5,@6)", txtNroHabitacion.Text.Trim, cboSucursal.SelectedValue, nudPrecio.Value, cboTipoHabitacion.SelectedValue, cboEstadoHabitacion.SelectedValue, chkHabilitado.Checked)
                Else
                    EjecutarSQL("UPDATE Habitacion SET NroHabitacion=@1,SucursalAlojamientoID=@2,Precio=@3,TipoHabitacionID=@4,EstadoHabitacionID=@5,EstadoSistema=@6 where HabitacionID=@7", txtNroHabitacion.Text.Trim, cboSucursal.SelectedValue, nudPrecio.Value, cboTipoHabitacion.SelectedValue, cboEstadoHabitacion.SelectedValue, chkHabilitado.Checked, txtCodigo.Text.Trim)
                    vNuevo = True
                End If

                MessageBox.Show("Registro guardado con éxito")
                LimpiarFormulario()


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub chkHabilitado_CheckedChanged(sender As Object, e As EventArgs) Handles chkHabilitado.CheckedChanged

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarFormulario()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Esta seguro de que desea eliminar el registro?", "SysTurismo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            If vNuevo = False Then

                EjecutarSQL("delete from Habitacion where HabitacionID=@1", txtCodigo.Text.Trim)
                MessageBox.Show("Registro eliminado con exito", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarFormulario()
            Else
                LimpiarFormulario()
            End If
        End If
    End Sub

    Private Sub dgvConsulta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsulta.CellDoubleClick
        Dim dtHabitacion As New DataTable
        'En el commandText filtramos para que traiga los datos solo del articulo seleccionado, a través de la instrucción "where"
        'dgvConsulta(0, e.RowIndex) --> Cero hace referencia a la primera columna, y e.RowIndex hace referencia a la fila seleccionada
        dtHabitacion = generar_datatabla("select * from Habitacion where HabitacionID=" & dgvConsulta(0, e.RowIndex).Value)
        If dtHabitacion.Rows.Count > 0 Then
            'Rows(0) hace referencia a la primera fila recuperada de la base de datos, que en este caso es la única, ya que por el where en la sentencia sql estamos recuperando un solo registro. Item("Columna") hace referencia a la columna que queremos recuperar de la tabla, tiene que coincidir con el nombre del campo en la tabla.
            txtCodigo.Text = dtHabitacion.Rows(0).Item("HabitacionID")
            txtNroHabitacion.Text = dtHabitacion.Rows(0).Item("NroHabitacion")
            cboSucursal.SelectedValue = dtHabitacion.Rows(0).Item("SucursalAlojamientoID")
            cboTipoHabitacion.SelectedValue = dtHabitacion.Rows(0).Item("TipoHabitacionID")
            cboEstadoHabitacion.SelectedValue = dtHabitacion.Rows(0).Item("EstadoHabitacionID")
            nudPrecio.Value = dtHabitacion.Rows(0).Item("Precio")

            If chkHabilitado.Checked = True Then
                Habilitado = 1
                chkHabilitado.Checked = dtHabitacion.Rows(0).Item("EstadoSistema")
                ' Habilitado = dtHabitacion.Rows.Item("EstadoSistema")

            Else
                Habilitado = 0
                'Habilitado = dtHabitacion.Rows.Item("EstadoSistema")
                chkHabilitado.Checked = dtHabitacion.Rows(0).Item("EstadoSistema")

            End If

            'Para pasar a la primera pestaña (ABM) del tabControl
            tbcPrincipal.SelectedIndex = 0

            'La bandera que nos permite determinar si un registro es nuevo o no, en este caso como recuperamos datos de la bd asignamos false ya que sabemos el registro no es nuevo.
            vNuevo = False
        End If

    End Sub

End Class