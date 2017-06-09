Imports System.Data.SqlClient
Imports ProyectoSysTurismo.acceso_datos

Public Class frmClientes

    Dim vNuevo As Boolean = True

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTipoDocumento.DataSource = generar_datatabla("select * from TipoDocumento")
        cmbTipoDocumento.ValueMember = "TipoDocumentoID"
        cmbTipoDocumento.DisplayMember = "Descripcion"

        cmbProfesion.DataSource = generar_datatabla("select * from Profesion")
        cmbProfesion.ValueMember = "ProfesionID"
        cmbProfesion.DisplayMember = "Descripcion"

        cmbTipoCliente.DataSource = generar_datatabla("select * from TipoCliente")
        cmbTipoCliente.ValueMember = "TipoClienteID"
        cmbTipoCliente.DisplayMember = "Descripcion"

        LimpiarFormulario()

        txtNombre.Focus()
    End Sub

    Private Sub tbcPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcPrincipal.SelectedIndexChanged
        If tbcPrincipal.SelectedIndex = 1 Then
            dgvConsulta.DataSource = generar_datatabla("select * from vista_cliente")
        End If
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

        If cmbTipoDocumento.SelectedIndex = -1 Then
            cmbTipoDocumento.Focus()
            MessageBox.Show("Debe seleccionar el tipo de documento", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If txtNroDocumento.Text.Trim = "" Then
            txtNroDocumento.Focus()
            MessageBox.Show("Debe insertar el numero de documento", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If cmbEstadoCivil.SelectedIndex = -1 Then
            cmbEstadoCivil.Focus()
            MessageBox.Show("Debe seleccionar el estado civil", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If txtTelefono.Text.Trim = "" Then
            txtTelefono.Focus()
            MessageBox.Show("Debe ingresar el telefono", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If txtDireccion.Text.Trim = "" Then
            txtDireccion.Focus()
            MessageBox.Show("Debe ingresar la direccion", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If txtEmail.Text.Trim = "" Then
            txtEmail.Focus()
            MessageBox.Show("Debe ingresar el email", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If cmbProfesion.SelectedIndex = -1 Then
            cmbProfesion.Focus()
            MessageBox.Show("Debe seleccionar la profesion", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If cmbTipoCliente.SelectedIndex = -1 Then
            cmbTipoCliente.Focus()
            MessageBox.Show("Debe seleccionar el tipo de cliente", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If rdbFemenino.Checked = False And rdbMasculino.Checked = False Then
            rdbMasculino.Checked = True
            rdbMasculino.Focus()
            MessageBox.Show("Debe seleccionar el sexo", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Sub LimpiarFormulario()
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        cmbTipoDocumento.SelectedIndex = -1
        txtNroDocumento.Text = ""
        cmbEstadoCivil.SelectedIndex = -1
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        txtEmail.Text = ""
        dtpFechaNacimiento.Value = Date.Today
        cmbProfesion.SelectedIndex = -1
        cmbTipoCliente.SelectedIndex = -1
        rdbMasculino.Checked = True
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If DatosValidos() Then
            Dim comando As New SqlCommand

            Dim EstadoCivil As Char
            Dim sexo As Integer

            Select Case cmbEstadoCivil.Text
                Case "Soltero"
                    EstadoCivil = "s"
                Case "Casado"
                    EstadoCivil = "c"
                Case "Viudo"
                    EstadoCivil = "v"
                Case "Divorciado"
                    EstadoCivil = "d"
            End Select

            If rdbMasculino.Checked Then
                sexo = 1
            Else
                sexo = 0
            End If

            If vNuevo = True Then
                EjecutarSQL("INSERT INTO Cliente VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13)", txtNombre.Text.Trim, txtApellido.Text.Trim, cmbTipoDocumento.SelectedValue, txtNroDocumento.Text.Trim, EstadoCivil, txtTelefono.Text.Trim, txtDireccion.Text.Trim, txtEmail.Text.Trim, dtpFechaNacimiento.Value, cmbProfesion.SelectedValue, sexo, cmbTipoCliente.SelectedValue, 1)
            Else
                EjecutarSQL("UPDATE Cliente SET Nombre=@1,Apellido=@2,TipoDocumentoID=@3,NroDocumento=@4,EstadoCivil=@5,Telefono=@6,Direccion=@7,Email=@8,FechaNacimiento=@9,ProfesionID=@10,Sexo=@11,TipoClienteID=@12", txtNombre.Text.Trim, txtApellido.Text.Trim, cmbTipoDocumento.SelectedValue, txtNroDocumento.Text.Trim, EstadoCivil, txtTelefono.Text.Trim, txtDireccion.Text.Trim, txtEmail.Text.Trim, dtpFechaNacimiento.Value, cmbProfesion.SelectedValue, sexo, cmbTipoCliente.SelectedValue)
                vNuevo = True
            End If

            MessageBox.Show("Registro guardado con éxito")
            LimpiarFormulario()

        End If
    End Sub

    Private Sub dgvConsulta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsulta.CellDoubleClick
        Dim dtCliente As New DataTable
        dtCliente = generar_datatabla("select * from Cliente where ClienteID=" & dgvConsulta(0, e.RowIndex).Value)
        If dtCliente.Rows.Count > 0 Then
            txtCodigo.Text = dtCliente.Rows(0).Item("ClienteID")
            txtNombre.Text = dtCliente.Rows(0).Item("Nombre")
            txtApellido.Text = dtCliente.Rows(0).Item("Apellido")
            cmbTipoDocumento.SelectedValue = dtCliente.Rows(0).Item("TipoDocumentoID")
            txtNroDocumento.Text = dtCliente.Rows(0).Item("NroDocumento")

            Select Case dtCliente.Rows(0).Item("EstadoCivil")
                Case "s"
                    cmbEstadoCivil.Text = "Soltero"
                Case "c"
                    cmbEstadoCivil.Text = "Casado"
                Case "v"
                    cmbEstadoCivil.Text = "Viudo"
                Case "d"
                    cmbEstadoCivil.Text = "Divorciado"
            End Select

            txtTelefono.Text = dtCliente.Rows(0).Item("Telefono")
            txtDireccion.Text = dtCliente.Rows(0).Item("Direccion")
            txtEmail.Text = dtCliente.Rows(0).Item("Email")
            dtpFechaNacimiento.Value = dtCliente.Rows(0).Item("FechaNacimiento")
            cmbProfesion.SelectedValue = dtCliente.Rows(0).Item("ProfesionID")
            cmbTipoCliente.SelectedValue = dtCliente.Rows(0).Item("TipoClienteID")

            If dtCliente.Rows(0).Item("Sexo") = True Then
                rdbMasculino.Checked = True
            Else
                rdbFemenino.Checked = True
            End If

            tbcPrincipal.SelectedIndex = 0

            vNuevo = False
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarFormulario()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Esta seguro de que desea eliminar el registro?", "SysTurismo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            If vNuevo = False Then
                EjecutarSQL("UPDATE Cliente SET EstadoSistema=0 WHERE ClienteID=@1", txtCodigo.Text.Trim)
                MessageBox.Show("Registro eliminado con exito", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarFormulario()
            Else
                LimpiarFormulario()
            End If
        End If
    End Sub
End Class