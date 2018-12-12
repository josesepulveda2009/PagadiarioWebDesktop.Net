
Public Class frmSplash
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        ProgressBar2.Value += 1

        lblLoading.Text = "Cargando... " & ProgressBar1.Value & " %"

        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False

            Dim _frmLogin As New frmLogin()
            _frmLogin.Show()
        End If
    End Sub
End Class
