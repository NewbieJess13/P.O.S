Public Class FrmMainMenu
    Dim Login As New LoginCrud
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


    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        FrmSettings.ShowDialog()
    End Sub

    Private Sub BtnProducts_Click(sender As Object, e As EventArgs) Handles BtnProducts.Click
        FrmProducts.ShowDialog()
    End Sub

    Private Sub FrmMainMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            BtnOpenSession.PerformClick()
        End If
        If e.KeyCode = Keys.F2 Then
            BtnProducts.PerformClick()
        End If
        If e.KeyCode = Keys.F3 Then
            BtnUploadEmployee.PerformClick()
        End If
        If e.KeyCode = Keys.F4 Then
            BtnReports.PerformClick()
        End If

        If e.KeyCode = Keys.F6 Then
            BtnSettings.PerformClick()
        End If
    End Sub

    Private Sub BtnReports_Click(sender As Object, e As EventArgs) Handles BtnReports.Click
        FrmReports.ShowDialog()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        If Login.UpdateStatus(My.Settings.UserID, "1") Then
            Application.Restart()
        End If
    End Sub
End Class