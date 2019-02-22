Public Class FrmCashierSession_Res

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        FlowLayoutPanel1.AutoScroll = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For n As Integer = 1 To 1000 Step 1
            Dim Pnl As Panel = New Panel
            Dim Lbl As Label = New Label
            Dim location As Point = New Point(0, 0)
            Pnl.Location = location
            Pnl.Size = New Size(132, 143)
            Pnl.BorderStyle = BorderStyle.FixedSingle
            FlowLayoutPanel1.Controls.Add(Pnl)
            ResumeLayout()
            Lbl.Location = location
            Lbl.Dock = DockStyle.Bottom
            Lbl.Text = "Hayup ka"
            Lbl.BackColor = Color.Red
            Lbl.TextAlign = ContentAlignment.MiddleCenter
            Lbl.AutoSize = False
            Pnl.Controls.Add(Lbl)
        Next
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub
End Class