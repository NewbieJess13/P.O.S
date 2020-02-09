
Public Class UCProductDetails
    Dim tbl As DataTable
    Dim _action As String
    Dim ProdCrud As New ProductCrud
    Private Sub UCProductDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   MsSql.connectionString = My.Settings.ConnectionString

        PopulateComboCategory()
        PopTxtCode()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        EnableTexts()
        ClearTexts()
        _action = "add"
    End Sub

    Sub ClearTexts()
        TxtDesc.Clear()
        TxtRetailPrice.Clear()
        TxtSellingPrice.Clear()
        CmbCategory.Text = ""
        TxtItemCode.Clear()
        cmbunit.Text = ""
        TxtQuanti.Clear()
        TxtDesc.Focus()

    End Sub

    Sub EnableTexts()
        TxtDesc.Enabled = True
        TxtRetailPrice.Enabled = True
        TxtSellingPrice.Enabled = True
        CmbCategory.Enabled = True
        TxtItemCode.Enabled = True
        TxtQuanti.Enabled = True
        cmbunit.Enabled = True
    End Sub

    Sub DisableTexts()
        TxtDesc.Enabled = False
        TxtRetailPrice.Enabled = False
        TxtSellingPrice.Enabled = False
        CmbCategory.Enabled = False
        TxtItemCode.Enabled = False
        TxtQuanti.Enabled = False
        cmbunit.Enabled = False
    End Sub



    Private Sub PopulateComboCategory()
        '       tbl = MsSql.Table("SELECT * FROM Tbl_Category")
        CmbCategory.DataSource = tbl
        CmbCategory.ValueMember = "id"
        CmbCategory.DisplayMember = "CategoryName"
        CmbCategory.SelectedIndex = -1
    End Sub

    Sub PopTxtCode()
        Dim DT As DataTable = ProdCrud.PopulateItemCode
        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To DT.Rows.Count - 1
            col.Add(DT.Rows(i)("SKU_Code").ToString)

        Next
        TxtItemCode.AutoCompleteSource = AutoCompleteSource.CustomSource
        TxtItemCode.AutoCompleteCustomSource = col
        TxtItemCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend

    End Sub

    Sub loadItem()
        Dim DT As DataTable = ProdCrud.PopulateItemCode(TxtItemCode.Text)
        If DT.Rows.Count > 0 Then
            TxtDesc.Text = DT.Rows(0)(1)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If _action = "add" Then

        ElseIf _Action = "edit" Then

        Else
            MessageBox.Show("Select action first!", My.Settings.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

    End Sub

    Private Sub DGProductList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProductList.CellClick
        Try
            If e.RowIndex >= 0 Or e.ColumnIndex >= 0 Then

                TxtDesc.Text = DGProductList.Rows(e.RowIndex).Cells(1).Value
                TxtRetailPrice.Text = DGProductList.Rows(e.RowIndex).Cells(2).Value
                TxtSellingPrice.Text = DGProductList.Rows(e.RowIndex).Cells(3).Value
                CmbCategory.Text = DGProductList.Rows(e.RowIndex).Cells(4).Value
                TxtItemCode.Text = DGProductList.Rows(e.RowIndex).Cells(5).Value
                TxtQuanti.Text = DGProductList.Rows(e.RowIndex).Cells(7).Value
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        DisableTexts()
    End Sub

    Private Sub TxtItemCode_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtItemCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadItem()
        End If
    End Sub
End Class