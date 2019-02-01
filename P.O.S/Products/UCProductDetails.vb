Imports ClassSql
Public Class UCProductDetails
    Dim tbl As DataTable
    Dim action As String
    Private Sub UCProductDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsSql.connectionString = My.Settings.ConnectionString
        LoadData()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        EnableTexts()
        ClearTexts()
        action = "add"
    End Sub

    Sub ClearTexts()
        TxtDesc.Clear()
        TxtRetailPrice.Clear()
        TxtSellingPrice.Clear()
        CmbCategory.Text = ""
        TxtItemCode.Clear()
        TxtBarCode.Clear()
        TxtQuanti.Clear()
        TxtUnit.Clear()

        TxtDesc.Focus()

    End Sub

    Sub EnableTexts()
        TxtDesc.Enabled = True
        TxtRetailPrice.Enabled = True
        TxtSellingPrice.Enabled = True
        CmbCategory.Enabled = True
        TxtItemCode.Enabled = True
        TxtBarCode.Enabled = True
        TxtQuanti.Enabled = True
        TxtUnit.Enabled = True
    End Sub

    Sub DisableTexts()
        TxtDesc.Enabled = False
        TxtRetailPrice.Enabled = False
        TxtSellingPrice.Enabled = False
        CmbCategory.Enabled = False
        TxtItemCode.Enabled = False
        TxtBarCode.Enabled = False
        TxtQuanti.Enabled = False
        TxtUnit.Enabled = False
    End Sub

    Sub LoadData()
        tbl = MsSql.Table("SELECT * FROM Tbl_Products ORDER BY Description ASC", Nothing)
        DGProductList.Rows.Clear()
        For Each dr As DataRow In tbl.Rows
            DGProductList.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(5), dr(6), dr(7), dr(4), dr(8))
        Next
    End Sub

    Sub AddItem()
        MsSql.ExecuteQuery("INSERT INTO Tbl_Products (Description, RetailPrice, SellingPrice, ItemCount, Category, ItemCode, Barcode, Unit, RealBarcode) VALUES ('" & TxtDesc.Text & "','" & TxtRetailPrice.Text & "','" & TxtSellingPrice.Text & "','" & TxtQuanti.Text & "','" & CmbCategory.Text & "','" & TxtItemCode.Text & "','" & TxtBarCode.Text & "','" & TxtUnit.Text & "','" & RchTxtRealBarcode.Text & "')", Nothing)
        ClearTexts()
        DisableTexts()
        LoadData()
        MessageBox.Show("Item successfully added.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub EditItem()
        MsSql.ExecuteQuery("UPDATE Tbl_Products SET Description = '" & TxtDesc.Text & "', RetailPrice ='" & TxtRetailPrice.Text & "', SellingPrice = '" & TxtSellingPrice.Text & "', ItemCount = '" & TxtQuanti.Text & "', Category= '" & CmbCategory.Text & "', ItemCode='" & TxtItemCode.Text & "', Barcode='" & TxtBarCode.Text & "', Unit='" & TxtUnit.Text & "', RealBarcode='" & RchTxtRealBarcode.Text & "' WHERE id='" & LblId.Text & "'", Nothing)
        ClearTexts()
        DisableTexts()
        LoadData()
        MessageBox.Show("Item Successfully Updated.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Sub DeleteITem()
        MsSql.ExecuteQuery("DELETE FROM Tbl_Products WHERE id='" & LblId.Text & "'", Nothing)
        ClearTexts()
        DisableTexts()
        LoadData()
        MessageBox.Show("Item successfully deleted.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If action = "add" Then
            AddItem()
        ElseIf action = "edit" Then
            EditItem()
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        action = "edit"
        EnableTexts()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this item?", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            DeleteITem()
        End If
    End Sub

    Private Sub DGProductList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProductList.CellClick
        Try
            If e.RowIndex >= 0 Or e.ColumnIndex >= 0 Then
                LblId.Text = DGProductList.Rows(e.RowIndex).Cells(0).Value
                TxtDesc.Text = DGProductList.Rows(e.RowIndex).Cells(1).Value
                TxtRetailPrice.Text = DGProductList.Rows(e.RowIndex).Cells(2).Value
                TxtSellingPrice.Text = DGProductList.Rows(e.RowIndex).Cells(3).Value
                CmbCategory.Text = DGProductList.Rows(e.RowIndex).Cells(4).Value
                TxtItemCode.Text = DGProductList.Rows(e.RowIndex).Cells(5).Value
                TxtBarCode.Text = DGProductList.Rows(e.RowIndex).Cells(6).Value
                TxtQuanti.Text = DGProductList.Rows(e.RowIndex).Cells(7).Value
                TxtUnit.Text = DGProductList.Rows(e.RowIndex).Cells(8).Value
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtBarCode_TextChanged(sender As Object, e As EventArgs) Handles TxtBarCode.TextChanged

        Dim Barcode, Check12Digits As String

        If Not (String.IsNullOrEmpty(TxtBarCode.Text)) Then

            Check12Digits = TxtBarCode.Text.PadRight(12, CChar("0"))
            Barcode = EAN13(Check12Digits)
            LblBarcode.Text = Barcode

            If Not (String.IsNullOrEmpty(Barcode13Digits)) And
                    Not Barcode13Digits = "" Then

                RchTxtRealBarcode.Text = Barcode13Digits.Trim.ToString

                Dim intStart As Int16 = Convert.ToInt16(RchTxtRealBarcode.TextLength - 1)
                ChangeColor(RchTxtRealBarcode, intStart)
            End If
        End If
    End Sub

    Private Sub TxtRetailPrice_TextChanged(sender As Object, e As EventArgs) Handles TxtRetailPrice.TextChanged
        Dim VAT As Decimal = 0.12
        Dim VATResult As Decimal = 0
        Dim Total As Decimal
        VATResult = Val(TxtRetailPrice.Text) * VAT
        Total = Val(TxtRetailPrice.Text) + VATResult
        TxtSellingPrice.Text = Total
    End Sub
End Class
