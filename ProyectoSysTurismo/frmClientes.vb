Imports System.Data.SqlClient
Imports ProyectoSysTurismo.acceso_datos

Public Class frmClientes

    Dim vNuevo As Boolean = True

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTipoDocumento.DataSource = generar_datatabla("select * from TipoDocumento")
        cboTipoDocumento.ValueMember = "TipoDocumentoID"
        cboTipoDocumento.DisplayMember = "Descripcion"

        cboProfesion.DataSource = generar_datatabla("select * from Profesion")
        cboProfesion.ValueMember = "ProfesionID"
        cboProfesion.DisplayMember = "Descripcion"

        cboTipoCliente.DataSource = generar_datatabla("select * from TipoCliente")
        cboTipoCliente.ValueMember = "TipoClienteID"
        cboTipoCliente.DisplayMember = "Descripcion"

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

        If cboTipoDocumento.SelectedIndex = -1 Then
            cboTipoDocumento.Focus()
            MessageBox.Show("Debe seleccionar el tipo de documento", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If txtNroDocumento.Text.Trim = "" Then
            txtNroDocumento.Focus()
            MessageBox.Show("Debe insertar el numero de documento", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If cboEstadoCivil.SelectedIndex = -1 Then
            cboEstadoCivil.Focus()
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

        If cboProfesion.SelectedIndex = -1 Then
            cboProfesion.Focus()
            MessageBox.Show("Debe seleccionar la profesion", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If cboTipoCliente.SelectedIndex = -1 Then
            cboTipoCliente.Focus()
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
        cboTipoDocumento.SelectedIndex = 0
        txtNroDocumento.Text = ""
        cboEstadoCivil.SelectedIndex = 0
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        txtEmail.Text = ""
        dtpFechaNacimiento.Value = Date.Today
        cboProfesion.SelectedIndex = 0
        cboTipoCliente.SelectedIndex = 0
        rdbMasculino.Checked = True
        chkHabilitado.Checked = True
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If DatosValidos() Then
            Dim comando As New SqlCommand

            Dim EstadoCivil As Char
            Dim sexo As Boolean
            Dim habilitado As Boolean

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

            If rdbMasculino.Checked Then
                sexo = True
            Else
                sexo = False
            End If

            If chkHabilitado.Checked Then
                habilitado = True
            Else
                habilitado = False
            End If

            If vNuevo = True Then
                EjecutarSQL("INSERT INTO Cliente VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13)", txtNombre.Text.Trim, txtApellido.Text.Trim, cboTipoDocumento.SelectedValue, txtNroDocumento.Text.Trim, EstadoCivil, txtTelefono.Text.Trim, txtDireccion.Text.Trim, txtEmail.Text.Trim, dtpFechaNacimiento.Value, cboProfesion.SelectedValue, sexo, cboTipoCliente.SelectedValue, habilitado)
            Else
                EjecutarSQL("UPDATE Cliente SET Nombre=@1,Apellido=@2,TipoDocumentoID=@3,NroDocumento=@4,EstadoCivil=@5,Telefono=@6,Direccion=@7,Email=@8,FechaNacimiento=@9,ProfesionID=@10,Sexo=@11,TipoClienteID=@12,EstadoSistema=@13 WHERE ClienteID=@14", txtNombre.Text.Trim, txtApellido.Text.Trim, cboTipoDocumento.SelectedValue, txtNroDocumento.Text.Trim, EstadoCivil, txtTelefono.Text.Trim, txtDireccion.Text.Trim, txtEmail.Text.Trim, dtpFechaNacimiento.Value, cboProfesion.SelectedValue, sexo, cboTipoCliente.SelectedValue, habilitado, txtCodigo.Text)
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
            cboTipoDocumento.SelectedValue = dtCliente.Rows(0).Item("TipoDocumentoID")
            txtNroDocumento.Text = dtCliente.Rows(0).Item("NroDocumento")

            Select Case dtCliente.Rows(0).Item("EstadoCivil")
                Case "s"
                    cboEstadoCivil.Text = "Soltero"
                Case "c"
                    cboEstadoCivil.Text = "Casado"
                Case "v"
                    cboEstadoCivil.Text = "Viudo"
                Case "d"
                    cboEstadoCivil.Text = "Divorciado"
            End Select

            txtTelefono.Text = dtCliente.Rows(0).Item("Telefono")
            txtDireccion.Text = dtCliente.Rows(0).Item("Direccion")
            txtEmail.Text = dtCliente.Rows(0).Item("Email")
            dtpFechaNacimiento.Value = dtCliente.Rows(0).Item("FechaNacimiento")
            cboProfesion.SelectedValue = dtCliente.Rows(0).Item("ProfesionID")
            cboTipoCliente.SelectedValue = dtCliente.Rows(0).Item("TipoClienteID")

            If dtCliente.Rows(0).Item("Sexo") = True Then
                rdbMasculino.Checked = True
            Else
                rdbFemenino.Checked = True
            End If

            If dtCliente.Rows(0).Item("EstadoSistema") = True Then
                chkHabilitado.Checked = True
            Else
                chkHabilitado.Checked = False
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
                'EjecutarSQL("UPDATE Cliente SET EstadoSistema=0 WHERE ClienteID=@1", txtCodigo.Text.Trim)
                EjecutarSQL("delete from Cliente where ClienteID=@1", txtCodigo.Text.Trim)
                MessageBox.Show("Registro eliminado con exito", "SysTurismo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarFormulario()
            Else
                LimpiarFormulario()
            End If
        End If
    End Sub

    Private Sub tbpABM_Click(sender As Object, e As EventArgs) Handles tbpABM.Click

    End Sub
End Class