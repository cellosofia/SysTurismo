Public Class frmEmpleado
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
    Private Sub LimpiarForm()
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
        rdbCasado.Checked = False
        rdbDivorciado.Checked = False
        rdbSoltero.Checked = False
        rdbViudo.Checked = False
        rdbDeshabilidado.Checked = False
        rdbHabilitado.Checked = False

    End Sub
End Class