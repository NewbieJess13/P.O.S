Imports ClassSql
Imports System.Data.SqlClient

Public Class UCProductDetails
    Dim tbl As DataTable
    Dim action As String
    Private Sub UCProductDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsSql.connectionString = My.Settings.ConnectionString
        LoadData()
        PopulateComboCategory()

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        EnableTexts()
        ClearTexts()
        GetRealBarcode()
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

    Dim RealBarcode As String = "0"

    Sub GetRealBarcode()
        Try
            Using conn As New SqlConnection(My.Settings.ConnectionString)
                conn.Open()
                Dim command As New SqlCommand("SELECT TOP 1 RealBarcode FROM Tbl_Products ORDER BY RealBarcode DESC", conn)
                Dim DT As New DataTable
                Dim DA As New SqlDataAdapter With {
                    .SelectCommand = command
                }
                DA.Fill(DT)
                If DT.Rows.Count > 0 Then
                    Dim Barcode As Integer
                    For Each dr As DataRow In DT.Rows
                        Barcode = dr(0) + 1
                        RealBarcode = Format(Barcode, "00000000000")
                    Next
                Else
                    RealBarcode = "00000000001"
                End If
                TxtBarCode.Text = RealBarcode
                LblTextBar.Text = RealBarcode
                LblBarcode.Text = RealBarcode
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub LoadData()
        tbl = MsSql.Table("SELECT * FROM Tbl_Products ORDER BY Description ASC", Nothing)
        DGProductList.Rows.Clear()
        For Each dr As DataRow In tbl.Rows
            DGProductList.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(5), dr(6), dr(7), dr(4), dr(8))
        Next
    End Sub

    Sub AddItem()
        If MsSql.ExecuteQuery("INSERT INTO Tbl_Products (Description, RetailPrice, SellingPrice, ItemCount, Category, ItemCode, Barcode, Unit, RealBarcode) VALUES ('" & TxtDesc.Text & "','" & TxtRetailPrice.Text & "','" & TxtSellingPrice.Text & "','" & TxtQuanti.Text & "','" & CmbCategory.Text & "','" & TxtItemCode.Text & "','" & TxtBarCode.Text & "','" & TxtUnit.Text & "','" & TxtBarCode.Text & "')", Nothing) = True Then
            ClearTexts()
            DisableTexts()
            LoadData()
            MessageBox.Show("Item successfully added.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Sub EditItem()
        If MsSql.ExecuteQuery("UPDATE Tbl_Products SET Description = '" & TxtDesc.Text & "', RetailPrice ='" & TxtRetailPrice.Text & "', SellingPrice = '" & TxtSellingPrice.Text & "', ItemCount = '" & TxtQuanti.Text & "', Category= '" & CmbCategory.Text & "', ItemCode='" & TxtItemCode.Text & "', Barcode='" & TxtBarCode.Text & "', Unit='" & TxtUnit.Text & "', RealBarcode='" & TxtBarCode.Text & "' WHERE id='" & LblId.Text & "'", Nothing) = True Then
            ClearTexts()
            DisableTexts()
            LoadData()
            MessageBox.Show("Item Successfully Updated.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Sub DeleteITem()
        If MsSql.ExecuteQuery("DELETE FROM Tbl_Products WHERE id='" & LblId.Text & "'", Nothing) = True Then
            ClearTexts()
            DisableTexts()
            LoadData()
            MessageBox.Show("Item successfully deleted.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PopulateComboCategory()
        tbl = MsSql.Table("SELECT * FROM Tbl_Category")
        CmbCategory.DataSource = tbl
        CmbCategory.ValueMember = "id"
        CmbCategory.DisplayMember = "CategoryName"
        CmbCategory.SelectedIndex = -1
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If action = "add" Then
            AddItem()
        ElseIf action = "edit" Then
            EditItem()
        Else
            MessageBox.Show("Select action first!", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                LblBarcode.Text = TxtBarCode.Text
                LblTextBar.Text = TxtBarCode.Text
                TxtQuanti.Text = DGProductList.Rows(e.RowIndex).Cells(7).Value
                TxtUnit.Text = DGProductList.Rows(e.RowIndex).Cells(8).Value
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtRetailPrice_TextChanged(sender As Object, e As EventArgs) Handles TxtRetailPrice.TextChanged

    End Sub

End Class
