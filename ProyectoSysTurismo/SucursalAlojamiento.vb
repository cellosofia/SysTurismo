Imports System.Data.SqlClient
Imports ProyectoSysTurismo.acceso_datos
Public Class SucursalAlojamiento
    Dim vNuevo As Boolean = True
    Dim Habilitado As Boolean = True

    Private Sub SucursalAlojamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCiudad.DataSource = generar_datatabla("Select * From Ciudad ")
        cboCiudad.DisplayMember = "Descripcion"
        cboCiudad.ValueMember = "CiudadID"

        cboAlojamiento.DataSource = generar_datatabla("select * from Alojamiento")
        cboAlojamiento.DisplayMember = "Nombre"
        cboAlojamiento.ValueMember = "AlojamientoID"

        cboServicio.DataSource = generar_datatabla("select * from TipoServicioAlojamiento")
        cboServicio.DisplayMember = "Descripcion"
        cboServicio.ValueMember = "TipoServicioAlojamientoID"


        TxtNombre.Focus()

    End Sub
    Private Sub LimpiarForm()
        txtSucursal.Text = ""
        cboAlojamiento.SelectedIndex = -1
        TxtNombre.Text = ""
        cboCiudad.SelectedIndex = -1
        TxtDireccion.Text = ""
        TxtTelefono.Text = ""
        TxtEmail.Text = ""
        cboServicio.SelectedIndex = -1
        chkHabilitado.Checked = True



    End Sub
    Private Sub TbcPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcPrincipal.SelectedIndexChanged
        If tbcPrincipal.SelectedIndex = 1 Then

            dgvSucursal.DataSource = generar_datatabla("select * from vista_Sucursal_ALojamiento")
        End If
    End Sub
    Function DatosValidos() As Boolean

        If TxtNombre.Text.Trim = "" Then
            TxtNombre.Focus()
            MessageBox.Show("Debe insertar el nombre", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If cboAlojamiento.SelectedIndex = -1 Then
            cboAlojamiento.Focus()
            MessageBox.Show("Debe seleccionar el Alojamiento", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If cboCiudad.SelectedIndex = -1 Then
            cboCiudad.Focus()
            MessageBox.Show("Debe seleccionar su Ciudad", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If TxtTelefono.Text.Trim = "" Then
            TxtTelefono.Focus()
            MessageBox.Show("Debe ingresar el telefono", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If TxtDireccion.Text.Trim = "" Then
            TxtDireccion.Focus()
            MessageBox.Show("Debe ingresar la direccion", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If TxtEmail.Text.Trim = "" Then
            TxtNombre.Focus()
            MessageBox.Show("Debe insertar su Email", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If cboServicio.SelectedIndex = -1 Then
            cboServicio.Focus()
            MessageBox.Show("Debe seleccionar su Servicio", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If


        Return True
    End Function
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        Try


            If DatosValidos() Then
                Dim comando As New SqlCommand
                Dim Estado As Integer



                If vNuevo = True Then
                    EjecutarSQL("INSERT INTO SucursalAlojamiento VALUES(@1,@2,@3,@4,@5,@6,@7,@8)", cboAlojamiento.SelectedValue, TxtNombre.Text.Trim, cboCiudad.SelectedValue, TxtTelefono.Text.Trim, TxtDireccion.Text.Trim, TxtEmail.Text.Trim, cboServicio.SelectedValue, chkHabilitado.Checked)
                Else
                    EjecutarSQL("UPDATE SucursalAlojamiento SET AlojamientoID=@1,Nombre=@2,CiudadID=@3,Telefono=@4,Direccion=@5,Email=@6,ServicioID=@7,EstadoSistema=@8 where SucursalAlojamientoID=@9", cboAlojamiento.SelectedValue, TxtNombre.Text.Trim, cboCiudad.SelectedValue, TxtTelefono.Text.Trim, TxtDireccion.Text.Trim, TxtEmail.Text.Trim, cboServicio.SelectedValue, chkHabilitado.Checked, txtSucursal.Text.Trim)
                    vNuevo = True
                End If

                MessageBox.Show("Registro guardado con éxito")
                LimpiarForm()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvSucursal_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSucursal.CellDoubleClick

        Dim dtSucursalAlojamiento As New DataTable


        dtSucursalAlojamiento = generar_datatabla("select * from SucursalAlojamiento where SucursalAlojamientoID=" & dgvSucursal(0, e.RowIndex).Value)
        If dtSucursalAlojamiento.Rows.Count > 0 Then

            txtSucursal.Text = dtSucursalAlojamiento.Rows(0).Item("SucursalAlojamientoID")
            cboAlojamiento.SelectedValue = dtSucursalAlojamiento.Rows(0).Item("AlojamientoID")
            TxtNombre.Text = dtSucursalAlojamiento.Rows(0).Item("Nombre")
            cboCiudad.SelectedValue = dtSucursalAlojamiento.Rows(0).Item("CiudadID")
            TxtTelefono.Text = dtSucursalAlojamiento.Rows(0).Item("Telefono")
            TxtDireccion.Text = dtSucursalAlojamiento.Rows(0).Item("Direccion")
            cboServicio.SelectedValue = dtSucursalAlojamiento.Rows(0).Item("ServicioID")
            TxtEmail.Text = dtSucursalAlojamiento.Rows(0).Item("Email")

            If chkHabilitado.Checked = True Then
                Habilitado = 1
                chkHabilitado.Checked = dtSucursalAlojamiento.Rows(0).Item("EstadoSistema")
                ' Habilitado = dtEmpleado.Rows.Item("EstadoSistema")

            Else
                Habilitado = 0
                'Habilitado = dtEmpleado.Rows.Item("EstadoSistema")
                chkHabilitado.Checked = dtSucursalAlojamiento.Rows(0).Item("EstadoSistema")

            End If

            tbcPrincipal.SelectedIndex = 0

            vNuevo = False
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimpiarForm()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MessageBox.Show("Esta seguro de que desea eliminar el registro?", "SysTurismo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            If vNuevo = False Then
                EjecutarSQL("delete from SucursalAlojamiento where SucursalAlojamientoID=@1", txtSucursal.Text.Trim)
                MessageBox.Show("Registro eliminado con exito", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarForm()
            Else
                LimpiarForm()
            End If
        End If
    End Sub

    Private Sub LblAlojamineto_Click(sender As Object, e As EventArgs) Handles LblAlojamineto.Click

    End Sub
End Class