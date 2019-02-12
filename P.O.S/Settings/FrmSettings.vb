Public Class FrmSettings
    Private Sub BtnEditProfile_Click(sender As Object, e As EventArgs) Handles BtnEditProfile.Click
        PnlContent.Controls.Clear()
        Dim a As New UCEditStaff
        a.Parent = PnlContent
        a.Dock = DockStyle.Fill
    End Sub

    Private Sub BtnCredit_Click(sender As Object, e As EventArgs) Handles BtnCredit.Click
        PnlContent.Controls.Clear()
        Dim a As New UCCreditSet
        a.Parent = PnlContent
        a.Dock = DockStyle.Fill
    End Sub

    Private Sub BtnBarcodePrinter_Click(sender As Object, e As EventArgs) Handles BtnBarcodePrinter.Click
        PnlContent.Controls.Clear()
        Dim a As New UCBarcodePrinter
        a.Parent = PnlContent
        a.Dock = DockStyle.Fill
    End Sub

    Private Sub BtnAppSettings_Click(sender As Object, e As EventArgs) Handles BtnAppSettings.Click
        PnlContent.Controls.Clear()
    End Sub
End Class