
Public Class FrmCashierSession

    Dim _Quantity As Integer
    Dim rnd As New Random
    Dim CSCrud As New CashierSessionCrud
    Dim id As String
    Sub New()
        InitializeComponent()

        AddHandler FrmCheckOut.LoadDataToGridToCheckOut, AddressOf LoadDataToGrid
        AddHandler FrmViaAllowance.LoadDataToGridToCheckOut, AddressOf LoadDataToGrid

        LblCashier.Text = My.Settings.FullName
        Timer1.Start()
    End Sub

    Private Sub FrmCashierSession_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataToGrid()
    End Sub
#Region "MenuControls"
    Private Sub BtnCash_Click(sender As Object, e As EventArgs) Handles BtnCash.Click
        FrmCheckOut.ShowDialog()
    End Sub

    Private Sub btnMeals_Click(sender As Object, e As EventArgs) Handles btnMeals.Click
        PopulateMenu("MEALS", FlowLayoutPanel1)
    End Sub

    Private Sub btnBeverages_Click(sender As Object, e As EventArgs) Handles btnBeverages.Click
        PopulateMenu("BEVERAGES", FlowLayoutPanel1)
    End Sub

    Private Sub btnSnacks_Click(sender As Object, e As EventArgs) Handles btnSnacks.Click
        PopulateMenu("SNACKS", FlowLayoutPanel1)
    End Sub

    Private Sub btnOthers_Click(sender As Object, e As EventArgs) Handles btnOthers.Click
        PopulateMenu("OTHERS", FlowLayoutPanel1)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblDateTime.Text = Date.Now
    End Sub
#End Region

    Sub LoadDataToGrid()
        DGItemList.Rows.Clear()
        If CSCrud.LoadSessionItems().Rows.Count > 0 Then
            For Each dr As DataRow In CSCrud.LoadSessionItems().Rows
                DGItemList.Rows.Add(dr(0), dr(1), dr(5), dr(2), Convert.ToDecimal(dr(3)).ToString("N2"), dr(4))
            Next
        End If
        DGItemList.ClearSelection()
        GetTotal()

    End Sub

    Private Sub PopulateMenu(CAT As String, FLPanel As FlowLayoutPanel)
        Dim PopulateFM As New CashierSessionCrud
        Dim DT As DataTable = PopulateFM.PopulateFoodMenu(CAT)
        FLPanel.Controls.Clear()
        If DT.Rows.Count > 0 Then
            For Each dr As DataRow In DT.Rows
                Dim location As Point = New Point(0, 0)
                Dim btnProd As Button = New Button With {
                    .Location = location,
                    .Dock = DockStyle.Bottom,
                    .Size = New Size(130, 50),
                    .Font = New Font("Malgun Gothic", 10, FontStyle.Bold),
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .BackColor = Color.FromArgb(255, rnd.Next(100, 255), rnd.Next(100, 255), rnd.Next(100, 255)),
                    .FlatStyle = FlatStyle.Standard,
                    .Text = dr(1) & "- ₱" & dr(2),
                    .Tag = dr(0)
                }
                ToolTip1.SetToolTip(btnProd, dr(1) & "- ₱" & dr(2))
                FLPanel.Controls.Add(btnProd)
                AddHandler btnProd.Click, AddressOf btnProd_Click
            Next
        End If

    End Sub

    Private Sub btnProd_Click(ByVal sender As Object, ByVal e As EventArgs)
        _Quantity = 1
        If CSCrud.SelectedFood(sender.tag).Rows.Count > 0 Then
            Dim ItemData As New CashierSessionData() With
                    {
                        .Description = CSCrud.SelectedFood(sender.tag).Rows(0)(2),
                        .SellingPrice = CSCrud.SelectedFood(sender.tag).Rows(0)(1),
                        .Quantity = _Quantity,
                        .TotalAmount = _Quantity * .SellingPrice,
                        .Category = CSCrud.SelectedFood(sender.tag).Rows(0)(3),
                        .ItemCode = CSCrud.SelectedFood(sender.tag)(0)(4)
                    }

            If CSCrud.CheckForExistingTempItem(ItemData.ItemCode).Rows.Count > 0 Then
                CSCrud.UpdateExistingItem(ItemData.ItemCode, _Quantity, ItemData.TotalAmount)
            Else
                CSCrud.SendToTempTrans(ItemData)
            End If
        End If
        LoadDataToGrid()

    End Sub

    Private Sub GetTotal()
        Dim sum As Decimal = 0
        For I As Integer = 0 To DGItemList.Rows.Count() - 1 Step +1
            If DGItemList.Rows.Count < 1 Then
                LblTotalRes.Text = "0.00"
            Else
                sum = sum + DGItemList.Rows(I).Cells(4).Value
                sum = Math.Round(sum, 2)
            End If
        Next
        LblTotalRes.Text = "₱" + sum.ToString("N2")
    End Sub
    Friend purchasedList As String
    Private Sub BtnAllowance_Click(sender As Object, e As EventArgs) Handles BtnAllowance.Click
        Dim qty As String
        Dim desc As String
        Dim i As Integer = 0
        Do While i < DGItemList.Rows.Count()
            qty = DGItemList.Rows(i).Cells(3).Value
            desc = DGItemList.Rows(i).Cells(1).Value
            purchasedList = purchasedList & qty & "-" & desc & ","
            i += 1
        Loop
        If purchasedList <> "" Then
            FrmViaAllowance.ShowDialog()
        End If
    End Sub

    Private Sub DGItemList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGItemList.CellClick
        Try
            If e.RowIndex >= 0 Or e.ColumnIndex >= 0 Then
                id = DGItemList.Rows(e.RowIndex).Cells(0).Value
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnVoidItem_Click(sender As Object, e As EventArgs) Handles BtnVoidItem.Click
        If id <> "" Then
            If CSCrud.DeleteItems(id) Then
                LoadDataToGrid()
            End If
        End If
    End Sub

    Private Sub BtnVoidTrans_Click(sender As Object, e As EventArgs) Handles BtnVoidTrans.Click
        If CSCrud.DeleteItems() Then
            LoadDataToGrid()
        End If
    End Sub

    Private Sub BtnEndSession_Click(sender As Object, e As EventArgs) Handles BtnEndSession.Click
        FrmCloseSession.ShowDialog()
    End Sub
End Class