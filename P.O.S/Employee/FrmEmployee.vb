Public Class FrmEmployee
    Private Sub BtnUploadMem_Click(sender As Object, e As EventArgs) Handles BtnUploadMem.Click
        PnlContent.Controls.Clear()
        Dim a As New UCUploadEmp With {
            .Parent = PnlContent,
            .Dock = DockStyle.Fill
        }
    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click
        PnlContent.Controls.Clear()
        Dim a As New UCExportMem With {
            .Parent = PnlContent,
            .Dock = DockStyle.Fill
        }
    End Sub

    Private Sub BtnViewMem_Click(sender As Object, e As EventArgs) Handles BtnViewMem.Click
        PnlContent.Controls.Clear()
        Dim a As New UCEditEmployee With {
            .Parent = PnlContent,
            .Dock = DockStyle.Fill
        }
    End Sub
End Class