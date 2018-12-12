Imports Entity
Imports PagadiarioDesktop.ServiceCliente

Public Class frmCliente
    Dim _clienteBussines As New ClienteBusinessClient
    Dim _cliente As New Cliente

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCliente.DataSource = _clienteBussines.GetClientes()
    End Sub

    Private Sub dgvCliente_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCliente.SelectionChanged
        If dgvCliente.Rows.Count > 0 Then
            txtCedula.Text = dgvCliente.CurrentRow.Cells("cedula").Value
            txtApellidos.Text = dgvCliente.CurrentRow.Cells("apellidos").Value
            txtNombres.Text = dgvCliente.CurrentRow.Cells("nombres").Value
            txtTelefono.Text = dgvCliente.CurrentRow.Cells("telefono").Value
            txtCelular.Text = dgvCliente.CurrentRow.Cells("celular").Value
            txtDireccion.Text = dgvCliente.CurrentRow.Cells("direccion").Value
            txtNotas.Text = dgvCliente.CurrentRow.Cells("notas").Value
            chkActivo.Checked = dgvCliente.CurrentRow.Cells("activo").Value
            txtImg.Text = dgvCliente.CurrentRow.Cells("img").Value
        End If
    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Dim open As New OpenFileDialog()
        open.ShowDialog()

        txtImg.Text = open.FileName
        picFoto.ImageLocation = txtImg.Text
    End Sub

    Private Sub txtImg_TextChanged(sender As Object, e As EventArgs) Handles txtImg.TextChanged
        picFoto.ImageLocation = txtImg.Text
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If
        Next

        txtCedula.Focus()
        btnGuardar.Enabled = True
        btnNuevo.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        _cliente.Cedula = txtCedula.Text
        _cliente.Apellidos = txtApellidos.Text
        _cliente.Nombres = txtNombres.Text
        _cliente.Telefono = txtTelefono.Text
        _cliente.Celular = txtCelular.Text
        _cliente.Direccion = txtDireccion.Text
        _cliente.Notas = txtNotas.Text
        _cliente.Img = txtImg.Text
        _cliente.Activo = chkActivo.Checked
        _cliente.Usuario = "admin"

        _clienteBussines = New ClienteBusinessClient()
        _clienteBussines.InsertCliente(_cliente)

        MsgBox("Elementos agregados ")
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        _cliente.Cedula = txtCedula.Text
        _cliente.Apellidos = txtApellidos.Text
        _cliente.Nombres = txtNombres.Text
        _cliente.Telefono = txtTelefono.Text
        _cliente.Celular = txtCelular.Text
        _cliente.Direccion = txtDireccion.Text
        _cliente.Notas = txtNotas.Text
        _cliente.Img = txtImg.Text
        _cliente.Activo = chkActivo.Checked
        _cliente.Usuario = "admin"
        _cliente.Id = dgvCliente.CurrentRow.Cells("id").Value

        _clienteBussines = New ClienteBusinessClient()
        _clienteBussines.UpdateCliente(_cliente)

        MsgBox("Elementos actualizados ")
    End Sub
End Class