Public Class FrmEmployee
    Private Sub BtnUploadMem_Click(sender As Object, e As EventArgs) Handles BtnUploadMem.Click

    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click

    End Sub

    Private Sub BtnViewMem_Click(sender As Object, e As EventArgs) Handles BtnViewMem.Click
        PnlContent.Controls.Clear()
        Dim a As New UCEditEmployee
        a.Parent = PnlContent
        a.Dock = DockStyle.Fill
    End Sub
End Class