Public Class FrmMenuPrincipal
    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblFecha.Text = DateTime.Now.ToShortDateString()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = TimeString
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Dim _frmCliente As New frmCliente()
        _frmCliente.MdiParent = Me
        _frmCliente.Show()
    End Sub

    Private Sub PrestamoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrestamoToolStripMenuItem.Click
        Dim _frmPrestamo As New frmPrestamo()
        _frmPrestamo.MdiParent = Me
        _frmPrestamo.Show()
    End Sub
End Class