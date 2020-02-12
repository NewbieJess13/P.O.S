Public Class FrmCashCard
    Dim _action As String
    Dim id As String
    Dim CCCrud As New CashCardCrud
    Dim CCData As New CashCardData
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        EnableTexts()
        cleartexts()
        _action = "add"
    End Sub
    Sub EnableTexts()
        TxtCardID.Enabled = True
        TxtEmpID.Enabled = True
        TxtEmpName.Enabled = True
        RBactive.Enabled = True
        RBInActive.Enabled = True
    End Sub

    Sub DisableTexts()
        TxtCardID.Enabled = False
        TxtEmpID.Enabled = False
        TxtEmpName.Enabled = False
        RBactive.Enabled = False
        RBInActive.Enabled = False

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        EnableTexts()
        _action = "edit"

    End Sub

    Sub PopulateCardList()
        Dim DT As DataTable = CCCrud.GetCardList
        DGCardList.Rows.Clear()
        If DT.Rows.Count > 0 Then
            For Each dr As DataRow In DT.Rows
                DGCardList.Rows.Add(dr("id"), dr("BarcodeID"), dr("EmployeeName"), dr("Balance"), dr("EmployeeID"), dr("Status"))
            Next
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        CCData.CardID = TxtCardID.Text
        CCData.EmpName = TxtEmpName.Text
        CCData.Balance = "0"
        CCData.EmpId = TxtEmpID.Text
        CCData.Creator = My.Settings.FullName
        CCData.DateStamp = Date.Now.ToString("yyyy.MM.dd hh:mm:ss")
        If RBactive.Checked = True Then
            CCData.Status = "1"
        ElseIf RBInactive.Checked = True Then
            CCData.Status = "0"
        End If
        If _action = "add" Then
            If CCCrud.InsertCard(CCData) Then
                MessageBox.Show("New card added!", My.Settings.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                cleartexts()
            End If
        ElseIf _action = "edit" Then
            If CCCrud.UpdateCard(CCData, id) Then
                MessageBox.Show("Update successfull!", My.Settings.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                cleartexts()
            End If
        End If
        PopulateCardList()
        DGCardList.ClearSelection()
    End Sub
    Sub cleartexts()
        TxtCardID.Clear()
        TxtEmpID.Clear()
        TxtEmpName.Clear()
        RBactive.Checked = False
        RBInActive.Checked = False
    End Sub

    Private Sub FrmCashCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCardList()
        LblBal.Text = ""
    End Sub

    Private Sub DGCardList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCardList.CellClick
        Try
            If e.RowIndex >= 0 Or e.ColumnIndex >= 0 Then
                id = DGCardList.Rows(e.RowIndex).Cells(0).Value
                TxtCardID.Text = DGCardList.Rows(e.RowIndex).Cells(1).Value
                TxtEmpName.Text = DGCardList.Rows(e.RowIndex).Cells(2).Value
                TxtEmpID.Text = DGCardList.Rows(e.RowIndex).Cells(4).Value
                If DGCardList.Rows(e.RowIndex).Cells(5).Value = "1" Then
                    RBactive.Checked = True
                Else
                    RBInActive.Checked = True
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this card?", My.Settings.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If CCCrud.DeleteCard(id) Then
                MessageBox.Show("Deleted successfully!", My.Settings.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DGCardList.ClearSelection()
                PopulateCardList()
                cleartexts()
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        DisableTexts()
        DGCardList.ClearSelection()
        cleartexts()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Dim DT As DataTable = CCCrud.SearchCardList(TxtSearch.Text)
        DGCardList.Rows.Clear()
        If DT.Rows.Count > 0 Then
            For Each dr As DataRow In DT.Rows
                DGCardList.Rows.Add(dr("id"), dr("BarcodeID"), dr("EmployeeName"), dr("Balance"), dr("EmployeeID"), dr("Status"))
            Next
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCardScan.KeyDown
        If TxtCardScan.TextLength = 11 Then
            If e.KeyCode = Keys.Enter Then
                ' Execute code here
            End If
        End If
    End Sub

    Private Sub TxtCardScan_TextChanged(sender As Object, e As EventArgs) Handles TxtCardScan.TextChanged
        Dim DT As DataTable = CCCrud.GetCardInfo(TxtCardScan.Text)
        If DT.Rows.Count > 0 Then
            LblBal.Text = DT.Rows(0)("Balance").ToString
        Else
            LblBal.Text = "0.00"
        End If
    End Sub
End Class