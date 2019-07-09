Public Class FrmManualNew

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        PopulateMenu("MEALS", FlowLayoutPanel1)
        PopulateMenu("DRINKS", FlowLayoutPanel2)
        PopulateMenu("SNACKS", FlowLayoutPanel3)
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub PopulateMenu(Filter As String, FlowPanel As FlowLayoutPanel)
        Dim PopulateFM As New CashierSessionCrud
        Dim DT As DataTable = PopulateFM.PopulateFoodMenu(Filter)
        Dim Path As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))
        FlowPanel.Controls.Clear()
        If DT.Rows.Count > 0 Then
            For Each Dr As DataRow In DT.Rows
                Dim location As Point = New Point(0, 0)
                Dim pnl As Panel = New Panel With {
                    .Location = location,
                    .Size = New Size(130, 100),
                    .BorderStyle = BorderStyle.FixedSingle
                }
                FlowPanel.Controls.Add(pnl)
                Dim productImage As PictureBox = New PictureBox With {
                    .Location = location,
                    .Dock = DockStyle.Top,
                    .SizeMode = PictureBoxSizeMode.StretchImage,
                    .Size = New Drawing.Size(0, 70),
                    .Image = Image.FromFile(Path + Dr(6)),
                    .Tag = Dr(0)
                }
                Dim ProdDesc As Label = New Label With {
                    .Location = location,
                    .Dock = DockStyle.Bottom,
                    .AutoSize = False,
                    .Size = New Drawing.Size(60, 30),
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .BorderStyle = BorderStyle.FixedSingle,
                    .Text = Dr(1)
                }
                ToolTip1.SetToolTip(productImage, Dr(1))
                AddHandler productImage.Click, AddressOf ProductImageAll_Click
                AddHandler productImage.MouseHover, AddressOf ProductImageAll_Hover
                AddHandler productImage.MouseLeave, AddressOf ProductImageAll_Leave
                pnl.Controls.Add(productImage)
                pnl.Controls.Add(ProdDesc)
            Next
        End If
    End Sub

    Private Sub ProductImageAll_Hover(ByVal sender As Object, ByVal e As EventArgs)
        sender.BorderStyle = BorderStyle.Fixed3D
    End Sub
    Private Sub ProductImageAll_Leave(ByVal sender As Object, ByVal e As EventArgs)
        sender.BorderStyle = BorderStyle.FixedSingle
    End Sub
    Dim id As String
    Private Sub ProductImageAll_Click(ByVal sender As Object, ByVal e As EventArgs)
        id = sender.tag
        Dim SelectedMenu As New CashierSessionCrud
        Dim DT As DataTable = SelectedMenu.SelectedFood(id)
        If DT.Rows.Count > 0 Then
            LblDesc.Text = DT.Rows(0)(1)
        End If
    End Sub
    Private Sub BtnPrev_Click(sender As Object, e As EventArgs) Handles BtnPrev.Click
        If LblNumber.Text = 0 Then
            LblNumber.Text = 0
        Else
            LblNumber.Text -= 1
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        LblNumber.Text += 1
    End Sub
End Class