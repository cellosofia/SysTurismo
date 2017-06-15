Imports System.Data.SqlClient
Imports ProyectoSysTurismo.acceso_datos
Public Class SucursalAlojamiento
    Dim vNuevo As Boolean = True
    Private Sub SucursalAlojamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbCIudad.DataSource = generar_datatabla("Select * From Ciudad ")
        CmbCIudad.DisplayMember = "Nombre"
        CmbCIudad.ValueMember = "CiudadID"

        LimpiarForm()

        TxtNombre.Focus()

    End Sub
    Private Sub LimpiarForm()
        TxtALojamientoID.Text = ""
        TxtSucursalID.Text = ""
        TxtNombre.Text = ""
        TxtDireccion.Text = ""
        TxtTelefono.Text = ""
        CmbCIudad.SelectedIndex = -1
        RdbDeshabilitado.Checked = False
        RdbHabilitado.Checked = False


    End Sub
    Private Sub TbcPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcPrincipal.SelectedIndexChanged
        If tbcPrincipal.SelectedIndex = 1 Then
         
            dgvSucursal.DataSource = generar_datatabla("select * from vista_Sucursal_ALojamiento")
        End If
    End Sub
    Function DatosValidos() As Boolean

        If TxtEmail.Text.Trim = "" Then
            TxtNombre.Focus()
            MessageBox.Show("Debe insertar su Email", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If


        If TxtNombre.Text.Trim = "" Then
            TxtNombre.Focus()
            MessageBox.Show("Debe insertar el nombre", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If CmbCIudad.SelectedIndex = -1 Then
            CmbCIudad.Focus()
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

        If RdbDeshabilitado.Checked = False And RdbHabilitado.Checked = False Then
            RdbHabilitado.Checked = True
            RdbDeshabilitado.Focus()
            MessageBox.Show("Debe seleccionar el Estado de la Sucursal", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        If DatosValidos() Then
            Dim comando As New SqlCommand
            Dim Estado As Integer

            If RdbHabilitado.Checked Then
                Estado = 1
            Else
                Estado = 0
            End If

            If vNuevo = True Then
                EjecutarSQL("INSERT INTO SucursalAlojamiento VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9)", TxtALojamientoID.Text.Trim, TxtSucursalID.Text.Trim, TxtNombre.Text.Trim, TxtTelefono.Text.Trim, CmbCIudad.SelectedValue, TxtSucursalID.Text.Trim, TxtTelefono.Text.Trim, TxtDireccion.Text.Trim, TxtEmail.Text.Trim, Estado)
            Else
                EjecutarSQL("UPDATE SucursalAlojamiento SET Alojamineto=@1,Sucursal=@2,Nombre=@3,Ciudad=@4,Telefono=@5,=@6,Direccion=@7,Email=@8", TxtALojamientoID.Text.Trim, TxtSucursalID.Text.Trim, TxtNombre.Text.Trim, TxtTelefono.Text.Trim, CmbCIudad.SelectedValue, TxtSucursalID.Text.Trim, TxtTelefono.Text.Trim, TxtDireccion.Text.Trim, TxtEmail.Text.Trim, Estado)
                vNuevo = True
            End If

            MessageBox.Show("Registro guardado con éxito")
            LimpiarForm()

        End If
    End Sub

    Private Sub dgvSucursal_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSucursal.CellDoubleClick
        Dim dtSucursalAlojamiento As New DataTable
        dtSucursalAlojamiento = generar_datatabla("select * from SucursalAlojamiento where AlojamientoID=" & dgvSucursal(0, e.RowIndex).Value)
        If dtSucursalAlojamiento.Rows.Count > 0 Then
            TxtALojamientoID.Text = dtSucursalAlojamiento.Rows(0).Item("AlojamientoID")
            TxtSucursalID.Text = dtSucursalAlojamiento.Rows(0).Item("SucursalID")
            TxtNombre.Text = dtSucursalAlojamiento.Rows(0).Item("Nombre")
            CmbCIudad.SelectedValue = dtSucursalAlojamiento.Rows(0).Item("CiudadID")
            TxtTelefono.Text = dtSucursalAlojamiento.Rows(0).Item("NroDocumento")

            TxtTelefono.Text = dtSucursalAlojamiento.Rows(0).Item("Telefono")
            TxtDireccion.Text = dtSucursalAlojamiento.Rows(0).Item("Direccion")
            TxtEmail.Text = dtSucursalAlojamiento.Rows(0).Item("Email")

            If dtSucursalAlojamiento.Rows(0).Item("Estado") = True Then
                RdbHabilitado.Checked = True
            Else
                RdbDeshabilitado.Checked = True
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
                EjecutarSQL("UPDATE SucursalAlojamiento SET EstadoSistema=0 WHERE AlojamientoID=@1", TxtALojamientoID.Text.Trim)
                MessageBox.Show("Registro eliminado con exito", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarForm()
            Else
                LimpiarForm()
            End If
        End If
    End Sub
End Class