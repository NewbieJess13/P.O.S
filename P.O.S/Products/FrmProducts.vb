Public Class FrmProducts
    Private Sub FrmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        LblName.Text = My.Settings.FullName
        Panel3.Controls.Clear()
        Dim a As New UCProductDetails
        a.Parent = Panel3
        a.Dock = DockStyle.Fill
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblDateTime.Text = Now
        LblDateTime.Text = Format(Now, "dd-MMM-yyyy hh:mm:ss tt")
    End Sub
End Class