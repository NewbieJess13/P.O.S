Public Class FrmCashierSession
    Private Sub FrmCashierSession_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel6.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub BtnCashTendered_Click(sender As Object, e As EventArgs) Handles BtnCashTendered.Click
        FrmCashTendered.ShowDialog()
    End Sub

    Private Sub BtnAddToCredits_Click(sender As Object, e As EventArgs) Handles BtnAddToCredits.Click
        FrmAddToCredits.ShowDialog()
    End Sub

    Private Sub BtnReplenishCash_Click(sender As Object, e As EventArgs) Handles BtnReplenishCash.Click
        FrmReplenishCash.ShowDialog()
    End Sub

    Private Sub BtnPullOutCash_Click(sender As Object, e As EventArgs) Handles BtnPullOutCash.Click
        FrmPullOutCash.ShowDialog()
    End Sub

    Private Sub BtnEndSession_Click(sender As Object, e As EventArgs) Handles BtnEndSession.Click
        FrmCloseSession.ShowDialog()
    End Sub
End Class