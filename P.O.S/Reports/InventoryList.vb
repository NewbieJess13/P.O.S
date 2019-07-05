Public Class InventoryList
    Dim action As String = 1
    Private Sub InventoryList_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadInventory()
        CbStatus.SelectedIndex = -1
    End Sub

    Sub LoadInventory()
        DGInvList.Rows.Clear()
        Dim InvCrud As New InventoryCrud
        Dim DTInv As DataTable = InvCrud.GetInventoryList
        If DTInv.Rows.Count > 0 Then
            For Each dr As DataRow In DTInv.Rows
                DGInvList.Rows.Add(dr(0), False, dr(1), dr(2), dr(3), dr(4))
            Next
        End If
    End Sub

    Sub ClearControls()
        TxtItem.Clear()
        TxtQuan.Clear()
        TxtSupp.Clear()
        CbStatus.SelectedIndex = -1
    End Sub
    Sub EnableControls()
        TxtItem.Enabled = True
        TxtQuan.Enabled = True
        TxtSupp.Enabled = True
        CbStatus.Enabled = True
    End Sub
    Sub DisableControls()
        TxtItem.Enabled = False
        TxtQuan.Enabled = False
        TxtSupp.Enabled = False
        CbStatus.Enabled = False
    End Sub
    Function GetInvData()
        Dim InvenData As New InventoryData
        InvenData.ItemName = TxtItem.Text
        InvenData.Quantity = TxtQuan.Text
        InvenData.Supplier = TxtSupp.Text
        InvenData.Status = CbStatus.Text
        Return InvenData
    End Function
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        action = "1"
        ClearControls()
        EnableControls()
        TxtItem.Focus()
    End Sub

    Dim id As String
    Private Sub DGInvList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGInvList.CellClick
        Try
            If e.RowIndex >= 0 Or e.ColumnIndex >= 0 Then
                id = DGInvList.Rows(e.RowIndex).Cells(0).Value
                TxtItem.Text = DGInvList.Rows(e.RowIndex).Cells(1).Value
                TxtQuan.Text = DGInvList.Rows(e.RowIndex).Cells(2).Value
                TxtSupp.Text = DGInvList.Rows(e.RowIndex).Cells(3).Value
                CbStatus.Text = DGInvList.Rows(e.RowIndex).Cells(4).Value
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        action = "2"
        EnableControls()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim InvCrud As New InventoryCrud
        Dim selectedRows As List(Of DataGridViewRow) = (From row In DGInvList.Rows.Cast(Of DataGridViewRow)()
                                                        Where
                                        Convert.ToBoolean(row.Cells("Column6").Value) = True).ToList()
        If MessageBox.Show(String.Format("Are you sure you want to delete the selected {0} items", selectedRows.Count), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each row As DataGridViewRow In selectedRows
                InvCrud.DeleteInventory(row.Cells(0).Value)
            Next
            MessageBox.Show(String.Format("{0} items deleted.", selectedRows.Count), "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadInventory()
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If action = "1" Then
            Dim InvenCrud As New InventoryCrud
            If InvenCrud.InsertInventory(GetInvData) Then
                MessageBox.Show("New item added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadInventory()
                ClearControls()
                ' DisableControls()
            End If
        ElseIf action = "2" Then
            Dim InvCrud As New InventoryCrud
            If id IsNot Nothing Then
                If InvCrud.EditInventory(GetInvData) Then
                    MessageBox.Show("Item Edited", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    id = ""
                    LoadInventory()
                    ClearControls()
                    DisableControls()
                End If
            Else
                MessageBox.Show("Select the item to be updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCheck.CheckedChanged
        If ChkCheck.Checked = True Then
            For Each row As DataGridViewRow In DGInvList.Rows
                row.Cells(1).Value = True
            Next
        Else
            For Each row As DataGridViewRow In DGInvList.Rows
                row.Cells(1).Value = False
            Next
        End If
    End Sub

    Private Sub BtnExcelReport_Click(sender As Object, e As EventArgs) Handles BtnExcelReport.Click

    End Sub
End Class