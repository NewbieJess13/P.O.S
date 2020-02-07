Public Class FrmSettings
    Private Sub BtnEditProfile_Click(sender As Object, e As EventArgs) Handles BtnEditProfile.Click
        PnlContent.Controls.Clear()
        Dim a As New UCEditStaff
        a.Parent = PnlContent
        a.Dock = DockStyle.Fill
    End Sub

    Private Sub BtnSetPrinter_Click(sender As Object, e As EventArgs) Handles BtnSetPrinter.Click
        PnlContent.Controls.Clear()
        Dim a As New UCSetPrinter
        a.Parent = PnlContent
        a.Dock = DockStyle.Fill
    End Sub
End Class