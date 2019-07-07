Imports Microsoft.Office.Interop.Excel
Public Class InventoryList
    Dim action As String = 1
    Private Sub InventoryList_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadInventory()
        CbStatus.SelectedIndex = -1
    End Sub

    Sub LoadInventory()
        DGInvList.Rows.Clear()
        Dim InvCrud As New InventoryCrud
        Dim DTInv As System.Data.DataTable = InvCrud.GetInventoryList
        If DTInv.Rows.Count > 0 Then
            For Each dr As DataRow In DTInv.Rows
                DGInvList.Rows.Add(dr(0), False, dr(1), dr(2) & " pieces ", dr(2), dr(3), dr(4), dr(5))
            Next
        End If
    End Sub

    Sub ClearControls()
        TxtItem.Clear()
        TxtQuan.Clear()
        TxtUnit.Clear()
        TxtSupp.Clear()
        CbStatus.SelectedIndex = -1
    End Sub
    Sub EnableControls()
        TxtItem.Enabled = True
        TxtQuan.Enabled = True
        TxtUnit.Enabled = True
        TxtSupp.Enabled = True
        CbStatus.Enabled = True
    End Sub
    Sub DisableControls()
        TxtItem.Enabled = False
        TxtQuan.Enabled = False
        TxtUnit.Enabled = False
        TxtSupp.Enabled = False
        CbStatus.Enabled = False
    End Sub
    Function GetInvData()
        Dim InvenData As New InventoryData
        InvenData.ItemName = TxtItem.Text
        InvenData.Quantity = TxtQuan.Text
        InvenData.Unit = TxtUnit.Text
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
                TxtQuan.Text = DGInvList.Rows(e.RowIndex).Cells(4).Value
                TxtUnit.Text = DGInvList.Rows(e.RowIndex).Cells(5).Value
                TxtSupp.Text = DGInvList.Rows(e.RowIndex).Cells(6).Value
                CbStatus.Text = DGInvList.Rows(e.RowIndex).Cells(7).Value
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
        If MessageBox.Show(String.Format("Are you sure you want to delete the selected {0} items", selectedRows.Count), "",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each row As DataGridViewRow In selectedRows
                InvCrud.DeleteInventory(row.Cells(0).Value)
            Next
            MessageBox.Show(String.Format("{0} item(s) deleted.", selectedRows.Count), "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadInventory()
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim InvenCrud As New InventoryCrud
        If action = "1" Then
            If TxtItem.Text <> "" AndAlso TxtQuan.Text <> "" Then
                If InvenCrud.InsertInventory(GetInvData) Then
                    MessageBox.Show("New item added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadInventory()
                    ClearControls()
                    ' DisableControls()
                End If
            Else
                MessageBox.Show("Item name and quantity is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        ElseIf action = "2" Then
            If id IsNot Nothing Then
                If TxtItem.Text <> "" AndAlso TxtQuan.Text <> "" Then
                    If InvenCrud.EditInventory(GetInvData) Then
                        MessageBox.Show("Item Edited", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        id = ""
                        LoadInventory()
                        ClearControls()
                        DisableControls()
                    End If
                Else
                    MessageBox.Show("Item name and quantity is required!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
        Dim xlApp As Application
        Dim xlWorkBook As Workbook
        Dim xlWorkSheet As Worksheet
        Dim misValue As Object = Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        xlApp = New ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        For i = 0 To DGInvList.RowCount - 1
            For j = 0 To DGInvList.ColumnCount - 1
                For k As Integer = 1 To DGInvList.Columns.Count
                    xlWorkSheet.Cells(1, k) = DGInvList.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DGInvList(j, i).Value
                Next
            Next
        Next
        Dim Location As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim _Date As String = Date.Now.ToString("yyyy-MM-dd")
        xlWorkSheet.Range("A:Z").EntireColumn.AutoFit()
        xlWorkSheet.Range("A:B").EntireColumn.Hidden = True
        xlWorkSheet.Range("E:F").EntireColumn.Hidden = True
        xlWorkSheet.SaveAs(Location & "\Inventory-Report" & _Date & ".xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("You can find the file at the Desktop.")
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class