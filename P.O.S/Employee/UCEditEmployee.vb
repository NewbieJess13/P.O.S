Imports ClassSql

Public Class UCEditEmployee
    Dim tbl As DataTable
    Dim action As String
    Private Sub UCEditEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsSql.connectionString = My.Settings.ConnectionString
        LoadEmployees()
    End Sub

    Sub LoadEmployees()
        tbl = MsSql.Table("SELECT * FROM Tbl_EmployeeList ORDER BY TotalCredits DESC")
        DGEmpList.Rows.Clear()

        For Each dr As DataRow In tbl.Rows
            DGEmpList.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7))
        Next
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        EnableTextBoxes()
        ClearTextBoxes()
        action = "add"
    End Sub

    Sub AddEmployees()
        MsSql.ExecuteQuery("INSERT INTO Tbl_EmployeeList (COOP_id, FullName, Position, Status, barcode, Site, TotalCredits,RealBarcode) VALUES ('" & TxtCoopId.Text & "', '" & TxtFullName.Text & "', '" & TxtPos.Text & "', '" & TxtStatus.Text & "', '" & TxtBarcode.Text & "', '" & TxtSite.Text & "', '" & TxtTotalCredits.Text & "','" & RchTxtRealBarcode.Text & "')", Nothing)
        MessageBox.Show("New Employee has been added!", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadEmployees()
        ClearTextBoxes()
    End Sub
    Sub EditEmployees()
        MsSql.ExecuteQuery("UPDATE Tbl_EmployeeList SET COOP_id = '" & TxtCoopId.Text & "', FullName = '" & TxtFullName.Text & "', Position = '" & TxtPos.Text & "', Status = '" & TxtStatus.Text & "', barcode='" & TxtBarcode.Text & "', Site = '" & TxtSite.Text & "', TotalCredits = '" & TxtTotalCredits.Text & "',RealBarcode='" & RchTxtRealBarcode.Text & "' WHERE id = '" & LblId.Text & "'", Nothing)
        MessageBox.Show("Successfully edited employee!", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadEmployees()
        ClearTextBoxes()
    End Sub

    Sub DeleteEmployees()
        If MessageBox.Show("Are you sure you want to delete this Employee?", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MsSql.ExecuteQuery("DELETE FROM Tbl_EmployeeList WHERE id = '" & LblID.Text & "'", Nothing)
            MessageBox.Show("Successfully deleted employee!", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadEmployees()
            ClearTextBoxes()
        End If

    End Sub
    Sub EnableTextBoxes()
        TxtCoopId.Enabled = True
        TxtFullName.Enabled = True
        TxtPos.Enabled = True
        TxtStatus.Enabled = True
        TxtBarcode.Enabled = True
        TxtSite.Enabled = True
        TxtTotalCredits.Enabled = True

        TxtFullName.Focus()
    End Sub
    Sub DisableTextBox()
        TxtCoopId.Enabled = False
        TxtFullName.Enabled = False
        TxtPos.Enabled = False
        TxtStatus.Enabled = False
        TxtBarcode.Enabled = False
        TxtSite.Enabled = False
        TxtTotalCredits.Enabled = False
    End Sub
    Sub ClearTextBoxes()
        TxtCoopId.Clear()
        TxtFullName.Clear()
        TxtPos.Clear()
        TxtStatus.Clear()
        TxtBarcode.Clear()
        TxtSite.Clear()
        TxtTotalCredits.Clear()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If action = "add" Then
            If TxtFullName.Text = "" And TxtCoopId.Text = "" And TxtPos.Text = "" And TxtStatus.Text = "" And TxtBarcode.Text = "" And TxtSite.Text = "" And TxtTotalCredits.Text = "" Then
                MessageBox.Show("Fill out all the empty fields!", "POS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                AddEmployees()
                DisableTextBox()
            End If

        ElseIf action = "edit" Then
            EditEmployees()
            DisableTextBox()
        End If

    End Sub

    Private Sub DGEmpList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGEmpList.CellClick
        Try
            If e.RowIndex >= 0 Or e.ColumnIndex >= 0 Then
                LblID.Text = DGEmpList.Rows(e.RowIndex).Cells(0).Value
                TxtCoopId.Text = DGEmpList.Rows(e.RowIndex).Cells(1).Value
                TxtFullName.Text = DGEmpList.Rows(e.RowIndex).Cells(2).Value
                TxtPos.Text = DGEmpList.Rows(e.RowIndex).Cells(3).Value
                TxtStatus.Text = DGEmpList.Rows(e.RowIndex).Cells(4).Value
                TxtBarcode.Text = DGEmpList.Rows(e.RowIndex).Cells(5).Value
                TxtSite.Text = DGEmpList.Rows(e.RowIndex).Cells(6).Value
                TxtTotalCredits.Text = DGEmpList.Rows(e.RowIndex).Cells(7).Value
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        EnableTextBoxes()
        action = "edit"
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        DeleteEmployees()
    End Sub

    Private Sub TxtBarcode_TextChanged(sender As Object, e As EventArgs) Handles TxtBarcode.TextChanged
        Dim Barcode, Check12Digits As String
        If Not (String.IsNullOrEmpty(TxtBarcode.Text)) Then
            Check12Digits = TxtBarcode.Text.PadRight(12, CChar("0"))
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
End Class
