Imports Entity
Imports PagadiarioDesktop.ServiceUsuario

Public Class frmLogin
    Private _usuario As Usuario
    Private _usuarioBusinessClient As UsuarioBusinessClient

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtUsuario.Text = String.Empty And txtContraseña.Text = String.Empty Then
            MessageBox.Show("Usuario y contraseña vacios", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            _usuario = New Usuario()
            _usuarioBusinessClient = New UsuarioBusinessClient()

            _usuario.Usuariox = txtUsuario.Text.ToString()
            _usuario.Contraseña = txtContraseña.Text.ToString()

            Dim res = _usuarioBusinessClient.Loguear(_usuario)

            If res = True Then
                Dim _frmMenuPrincipal As New FrmMenuPrincipal()
                _frmMenuPrincipal.Show()
                _frmMenuPrincipal.lblUsuario.Text = txtUsuario.Text
            Else
                MessageBox.Show("Datos incorrectos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class