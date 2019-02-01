Public Class FrmMainMenu
    Private Sub BtnOpenSession_Click(sender As Object, e As EventArgs) Handles BtnOpenSession.Click
        FrmOpenSession.ShowDialog()

    End Sub

    Private Sub FrmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        LblName.Text = My.Settings.FullName
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblTimer.Text = Now
        LblTimer.Text = Format(Now, "dd-MMM-yyyy hh:mm:ss tt")
    End Sub

    Private Sub BtnUploadEmployee_Click(sender As Object, e As EventArgs) Handles BtnUploadEmployee.Click
        FrmEmployee.ShowDialog()

    End Sub

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        FrmSettings.ShowDialog()
    End Sub

    Private Sub BtnProducts_Click(sender As Object, e As EventArgs) Handles BtnProducts.Click
        FrmProducts.ShowDialog()
    End Sub
End Class