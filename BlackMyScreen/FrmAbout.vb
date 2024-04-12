Public Class FrmAbout
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ReturnToTopmost = True Then
            FrmMain.TopMost = True

        End If
        Me.Close()
        ReturnToTopmost = False

    End Sub

    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVersion.Text = Application.ProductVersion
        Me.Top = FrmMain.Top + (FrmMain.Height - Me.Height) / 2
        Me.Left = FrmMain.Left + (FrmMain.Width - Me.Width) / 2
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class