Imports System.Data.SqlClient
Imports ProyectoSysTurismo.acceso_datos
Public Class frmEmpleado
    Dim Habilitado As Integer


    Dim vNuevo As Boolean = True

    Private Sub frmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCargo.DataSource = generar_datatabla("select * from CargoEmpleado")
        cboCargo.DisplayMember = "Nombre"
        cboCargo.ValueMember = "CargoEmpleadoID"

        cboDocumento.DataSource = generar_datatabla("select * from TipoDocumento")
        cboDocumento.DisplayMember = "Descripcion"
        cboDocumento.ValueMember = "TipoDocumentoID"

        cboSucursal.DataSource = generar_datatabla("select * from SucursalEmpresa")
        cboSucursal.DisplayMember = "Nombre"
        cboSucursal.ValueMember = "SucursalEmpresaID"



    End Sub
    Function DatosValidos() As Boolean
        If txtNombre.Text.Trim = "" Then
            txtNombre.Focus()
            MessageBox.Show("Debe insertar el nombre", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If txtApellido.Text.Trim = "" Then
            txtApellido.Focus()
            MessageBox.Show("Debe insertar el apellido", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If txtDocumento.Text.Trim = "" Then
            txtDocumento.Focus()
            MessageBox.Show("Debe insertar el nro Documento", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If cboCargo.SelectedIndex = -1 Then
            cboCargo.Focus()
            MessageBox.Show("Debe insertar el cargo", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If cboDocumento.SelectedIndex = -1 Then
            cboDocumento.Focus()
            MessageBox.Show("Debe insertar el documento", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If cboSucursal.SelectedIndex = -1 Then
            cboSucursal.Focus()
            MessageBox.Show("Debe insertar la sucursal", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If txtDireccion.Text.Trim = "" Then
            txtDireccion.Focus()
            MessageBox.Show("Debe insertar la direccion", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If txtTelefono.Text.Trim = "" Then
            txtTelefono.Focus()
            MessageBox.Show("Debe insertar el nro telefono", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If nudAntiguedad.Value = 0 Then
            nudAntiguedad.Focus()
            MessageBox.Show("Debe insertar la antiguedad", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If



        Return True

    End Function


    Private Sub LimpiarFormulario()
        txtCodEmpleado.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDocumento.Text = ""
        cboCargo.SelectedIndex = -1
        cboDocumento.SelectedIndex = -1
        cboSucursal.SelectedIndex = -1
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        nudAntiguedad.Value = 0
        chkEstado.Checked = True


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarFormulario()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Esta seguro de que desea eliminar el registro?", "SysTurismo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            If vNuevo = False Then

                EjecutarSQL("delete from Empleado where EmpleadoID=@1", txtCodEmpleado.Text.Trim)
                MessageBox.Show("Registro eliminado con exito", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarFormulario()
            Else
                LimpiarFormulario()
            End If
        End If
    End Sub

    Private Sub dgvConsultaEmp_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsultaEmp.CellDoubleClick
        'Instanciamos un objeto del tipo DataTable, que es una tabla en memoria, en la cual volcaremos los datos de la base datos a nuestra aplicación
        Dim dtEmpleado As New DataTable
        'En el commandText filtramos para que traiga los datos solo del articulo seleccionado, a través de la instrucción "where"
        'dgvConsulta(0, e.RowIndex) --> Cero hace referencia a la primera columna, y e.RowIndex hace referencia a la fila seleccionada
        dtEmpleado = generar_datatabla("select * from Empleado where EmpleadoID=" & dgvConsultaEmp(0, e.RowIndex).Value)
        If dtEmpleado.Rows.Count > 0 Then
            'Rows(0) hace referencia a la primera fila recuperada de la base de datos, que en este caso es la única, ya que por el where en la sentencia sql estamos recuperando un solo registro. Item("Columna") hace referencia a la columna que queremos recuperar de la tabla, tiene que coincidir con el nombre del campo en la tabla.
            txtCodEmpleado.Text = dtEmpleado.Rows(0).Item("EmpleadoID")
            txtNombre.Text = dtEmpleado.Rows(0).Item("Nombre")
            txtApellido.Text = dtEmpleado.Rows(0).Item("Apellido")
            cboCargo.SelectedValue = dtEmpleado.Rows(0).Item("CargoEmpleadoID")
            cboDocumento.SelectedValue = dtEmpleado.Rows(0).Item("TipoDocumentoID")
            txtDocumento.Text = dtEmpleado.Rows(0).Item("NroDocumento")
            dtpFechaNac.Value = dtEmpleado.Rows(0).Item("FechaNacimiento")
            cboSucursal.SelectedValue = dtEmpleado.Rows(0).Item("SucursalEmpresaID")
            txtTelefono.Text = dtEmpleado.Rows(0).Item("Telefono")
            txtDireccion.Text = dtEmpleado.Rows(0).Item("Direccion")
            Select Case dtEmpleado.Rows(0).Item("EstadoCivil")
                Case "s"
                    cboEstadoCivil.Text = "Soltero"
                Case "c"
                    cboEstadoCivil.Text = "Casado"
                Case "v"
                    cboEstadoCivil.Text = "Viudo"
                Case "d"
                    cboEstadoCivil.Text = "Divorciado"
            End Select

            nudAntiguedad.Value = dtEmpleado.Rows(0).Item("Antiguedad")

            If chkEstado.Checked = True Then
                Habilitado = 1
                ' Habilitado = dtEmpleado.Rows.Item("EstadoSistema")

            Else
                Habilitado = 0
                'Habilitado = dtEmpleado.Rows.Item("EstadoSistema")

            End If

            'Para pasar a la primera pestaña (ABM) del tabControl
            tbcEmpleado.SelectedIndex = 0

            'La bandera que nos permite determinar si un registro es nuevo o no, en este caso como recuperamos datos de la bd asignamos false ya que sabemos el registro no es nuevo.
            vNuevo = False
        End If
    End Sub

    Private Sub tbcEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcEmpleado.SelectedIndexChanged
        If tbcEmpleado.SelectedIndex = 1 Then
            dgvConsultaEmp.DataSource = generar_datatabla("select * from vista_empleado") 'falta vista
        End If

    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Try


            If DatosValidos() Then
                Dim comando As New SqlCommand

                Dim EstadoCivil As Char
                ' Dim sexo As Integer

                Select Case cboEstadoCivil.Text
                    Case "Soltero"
                        EstadoCivil = "s"
                    Case "Casado"
                        EstadoCivil = "c"
                    Case "Viudo"
                        EstadoCivil = "v"
                    Case "Divorciado"
                        EstadoCivil = "d"
                End Select
                If Habilitado = 1 Then

                End If

                If vNuevo = True Then
                    EjecutarSQL("INSERT INTO Empleado VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12)", txtNombre.Text.Trim, txtApellido.Text.Trim, cboCargo.SelectedValue, cboDocumento.SelectedValue, txtDocumento.Text.Trim, dtpFechaNac.Value, cboSucursal.SelectedValue, txtTelefono.Text.Trim, txtDireccion.Text.Trim, EstadoCivil, nudAntiguedad.Value, Habilitado)
                Else
                    EjecutarSQL("UPDATE Empleado SET Nombre=@1,Apellido=@2,CargoEmpleadoID=@3,TipoDocumentoID=@4,NroDocumento=@5,FechaNacimiento=@6,SucursalEmpresaID=@7,Telefono=@8,Direccion=@9,EstadoCivil=@10,Antiguedad=@11,EstadoSistema=@12 where EmpleadoID=@13", txtNombre.Text.Trim, txtApellido.Text.Trim, cboCargo.SelectedValue, cboDocumento.SelectedValue, txtDocumento.Text.Trim, dtpFechaNac.Value, cboSucursal.SelectedValue, txtTelefono.Text.Trim, txtDireccion.Text.Trim, EstadoCivil, nudAntiguedad.Value, Habilitado)
                    vNuevo = True
                End If

                MessageBox.Show("Registro guardado con éxito")
                LimpiarFormulario()


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class