Imports System.Data.SqlClient
Public Class FrmCashierSession_Res

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        FlowLayoutPanel1.AutoScroll = True
        PopulateMenu()
        FrmTitle.Text = My.Settings.Title
    End Sub



    Sub PopulateMenu()
        Using conn As New SqlConnection(My.Settings.ConnectionString)
            conn.Open()
            Dim command As New SqlCommand("SELECT * FROM Tbl_Products", conn)
            Dim DA As New SqlDataAdapter
            Dim DT As New DataTable
            DA.SelectCommand = command
            DA.Fill(DT)
            Dim Path As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 9))
            FlowLayoutPanel1.Controls.Clear()
            If DT.Rows.Count > 0 Then
                For Each dr As DataRow In DT.Rows
                    'Create parentpanel for the images
                    Dim location As Point = New Point(0, 0)
                    Dim pnl As Panel = New Panel With {
                        .Location = location,
                        .Size = New Size(120, 120),
                        .BorderStyle = BorderStyle.FixedSingle
                    }
                    FlowLayoutPanel1.Controls.Add(pnl)
                    'Create Imagelist of the product
                    Dim productImage As PictureBox = New PictureBox With {
                        .Location = location,
                        .Dock = DockStyle.Fill,
                        .SizeMode = PictureBoxSizeMode.StretchImage,
                        .Image = Image.FromFile(Path + dr(10)),
                        .Tag = dr(0)
                    }
                    ToolTip1.SetToolTip(productImage, dr(1))
                    AddHandler productImage.Click, AddressOf ProductImageAll_Click
                    AddHandler productImage.MouseHover, AddressOf ProductImageAll_Hover
                    AddHandler productImage.MouseLeave, AddressOf ProductImageAll_Leave
                    pnl.Controls.Add(productImage)

                Next
            End If
            conn.Close()
        End Using
    End Sub

    Private Sub ProductImageAll_Hover(ByVal sender As Object, ByVal e As EventArgs)
        sender.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub ProductImageAll_Leave(ByVal sender As Object, ByVal e As EventArgs)
        sender.BorderStyle = BorderStyle.FixedSingle
    End Sub
    Public Shared id As String
    Private Sub ProductImageAll_Click(ByVal sender As Object, ByVal e As EventArgs)

        id = sender.tag
        FrmResOptionFood.ShowDialog()
        'Using conn As New SqlConnection(My.Settings.ConnectionString)
        '    conn.Open()
        '    Dim command As New SqlCommand("SELECT Description,SellingPrice,Category,ItemCode,RealBarcode FROM Tbl_Products WHERE id=@ItemID", conn)
        '    command.Parameters.AddWithValue("@ItemID", sender.tag)
        '    Dim DA As New SqlDataAdapter
        '    Dim DT As New DataTable
        '    DA.SelectCommand = command
        '    DA.Fill(DT)
        '    If DT.Rows.Count > 0 Then

        '    End If
        'End Using
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

End Class