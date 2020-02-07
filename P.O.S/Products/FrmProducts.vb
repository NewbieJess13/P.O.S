Public Class FrmProducts
    Private Sub FrmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.Controls.Clear()
        Dim a As New UCProductDetails
        a.Parent = Panel3
        a.Dock = DockStyle.Fill
    End Sub


End Class