Imports ClassSql

Public Class FrmCashierSession
    Dim tbl As DataTable
    Dim Description, ItemCount, ItemCode, unit As String
    Dim BarcodeStorage As String
    Dim SellingPrice, Total As Decimal
    Public Shared PurchaseID As String
    Dim tfocus As String

    Sub New()
        InitializeComponent()
        AddHandler FrmVoidItem.LoadDataToGrid, AddressOf LoadDataToGrid
        AddHandler FrmManualNew.LoadDataToGrid, AddressOf LoadDataToGrid
        AddHandler FrmCheckOut.LoadDataToGridToCheckOut, AddressOf LoadDataToGrid
        Timer1.Start()
    End Sub

#Region "MenuControls"
    Private Sub BtnAddToCredits_Click(sender As Object, e As EventArgs) Handles BtnAddToCredits.Click
        FrmAddToCredits.ShowDialog()
    End Sub

    Private Sub BtnReplenishCash_Click(sender As Object, e As EventArgs) Handles BtnReplenishCash.Click
        FrmReplenishCash.ShowDialog()
    End Sub

    Private Sub BtnPullOutCash_Click(sender As Object, e As EventArgs) Handles BtnPullOutCash.Click
        FrmPullOutCash.ShowDialog()
    End Sub

    Private Sub BtnEndSession_Click(sender As Object, e As EventArgs) Handles BtnEndSession.Click
        FrmCloseSession.ShowDialog()
    End Sub

    Private Sub BtnManualInput_Click(sender As Object, e As EventArgs) Handles BtnManualInput.Click
        FrmManualNew.ShowDialog()
    End Sub

    Private Sub BtnVoidItem_Click(sender As Object, e As EventArgs) Handles BtnVoidItem.Click
        FrmVoidItem.ShowDialog()
    End Sub

    Private Sub BtnVoidTrans_Click(sender As Object, e As EventArgs) Handles BtnVoidTrans.Click
        FrmVoidTrans.ShowDialog()
    End Sub

    Private Sub BtnCashTendered_Click(sender As Object, e As EventArgs) Handles BtnCashTendered.Click
        FrmCheckOut.ShowDialog()
    End Sub
#End Region


    Private Sub FrmCashierSession_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtBarcode.Focus()
        Panel6.BorderStyle = BorderStyle.FixedSingle
        MsSql.connectionString = My.Settings.ConnectionString
        Label3.Text = My.Settings.FullName
        LoadDataToGrid()
        TxtQuanProd.Text = 0
    End Sub

    Sub LoadDataToGrid()
        tbl = MsSql.Table("SELECT * FROM Tbl_TempTransaction WHERE CashierSessionID = '" & My.Settings.SessionID & "'")
        DGItemList.Rows.Clear()

        For Each dr As DataRow In tbl.Rows
            DGItemList.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
        Next
        GetTotal()

    End Sub
    Private Sub GetTotal()
        Dim sum As Decimal = 0
        For I As Integer = 0 To DGItemList.Rows.Count() - 1 Step +1
            If DGItemList.Rows.Count < 1 Then
                LblTotalRes.Text = "0.00"
            Else
                sum = sum + DGItemList.Rows(I).Cells(3).Value
                sum = Math.Round(sum, 2)
            End If
        Next
        LblTotalRes.Text = "₱" + sum.ToString
    End Sub
    Private Sub TxtBarcode_TextChanged(sender As Object, e As EventArgs) Handles TxtBarcode.TextChanged
        CheckBarcode()
    End Sub
    Private Sub CheckBarcode()
        If TxtBarcode.TextLength = TxtBarcode.MaxLength Then
            LblPrevBarcode.Text = TxtBarcode.Text
            If TxtBarcode.Text = LblPrevPrevBarcode.Text Then
                SelectFromProdListUsingBarcode()
                TxtQuanProd.Text += 1
                ComputeTotalPrice()
                UpdateTempQuantity()
                ClearTextbarcode()
            Else
                TxtQuanProd.Text = 1
                ComputeTotalPrice()
                CheckForDuplicateBarcode()
                ClearTextbarcode()
            End If

            LoadDataToGrid()
        End If
    End Sub

    Sub UpdateTempQuantity()
        MsSql.ExecuteQuery("UPDATE Tbl_TempTransaction SET Quantity += 1,TotalAmount='" & Total & "' WHERE Barcode ='" & TxtBarcode.Text & "'", Nothing)
        LoadDataToGrid()
    End Sub
    Function SelectFromProdListUsingBarcode() As Boolean
        tbl = MsSql.Table("SELECT * FROM Tbl_Products WHERE RealBarcode = '" & TxtBarcode.Text & "'")
        Description = ""
        ItemCount = ""
        ItemCode = ""
        unit = ""
        If tbl.Rows.Count > 0 Then
            For Each dr As DataRow In tbl.Rows
                Description = dr(1)
                ItemCount = dr(4)
                ItemCode = dr(6)
                unit = dr(8)
                SellingPrice = dr(3)
            Next
            Return True
        Else
            MessageBox.Show("No records for that barcode!", "POS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click, Btn2.Click, Btn3.Click, Btn4.Click, Btn5.Click, Btn6.Click, Btn7.Click, Btn8.Click, Btn9.Click, Btn0.Click, Btn00.Click
        If tfocus = "barcode" Then
            TxtBarcode.Text += sender.text
        ElseIf tfocus = "quan" Then
            TxtQuanProd.Text += sender.text
        End If

    End Sub

    Private Sub DGItemList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGItemList.CellClick
        Try
            If e.RowIndex >= 0 Or e.ColumnIndex >= 0 Then
                PurchaseID = DGItemList.Rows(e.RowIndex).Cells(0).Value
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub ComputeTotalPrice()
        tbl = MsSql.Table("SELECT TotalAmount,SellingPrice FROM Tbl_TempTransaction WHERE Barcode='" & TxtBarcode.Text & "'")
        For Each dr As DataRow In tbl.Rows
            Total = dr(0)
            SellingPrice = dr(1)
        Next
        Total += SellingPrice
    End Sub
    Sub ClearTextbarcode()
        TxtBarcode.Clear()
        TxtBarcode.Focus()
        Total = 0
        SellingPrice = 0
        LblPrevPrevBarcode.Text = LblPrevBarcode.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblDateTime.Text = Date.Now
    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        CheckBarcode()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtBarcode.Text = TxtBarcode.Text.Remove(TxtBarcode.TextLength - 1)
    End Sub

    Sub InsertIntoTempBarcode()

        If MsSql.ExecuteQuery("INSERT INTO Tbl_TempTransaction (Description,Quantity,TotalAmount,ItemCode,Barcode,SellingPrice) VALUES ('" & Description & "','" & TxtQuanProd.Text & "','" & Total & "','" & ItemCode & "','" & TxtBarcode.Text & "','" & SellingPrice & "')", Nothing) = False Then
            MessageBox.Show("Not Inserted!")
        End If
    End Sub

    Sub CheckForDuplicateBarcode()
        tbl = MsSql.Table("SELECT * FROM Tbl_TempTransaction WHERE Barcode='" & TxtBarcode.Text & "'")
        If tbl.Rows.Count > 0 Then
            UpdateTempQuantity()
        Else
            If SelectFromProdListUsingBarcode() = True Then
                InsertIntoTempBarcode()
            End If
        End If
    End Sub

    Private Sub TxtQuanProd_GotFocus(sender As Object, e As EventArgs) Handles TxtQuanProd.GotFocus
        tfocus = "quan"
    End Sub

    Private Sub TxtBarcode_GotFocus(sender As Object, e As EventArgs) Handles TxtBarcode.GotFocus
        tfocus = "barcode"
    End Sub


End Class