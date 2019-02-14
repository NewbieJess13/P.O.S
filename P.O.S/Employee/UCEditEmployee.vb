Imports ClassSql
Imports System.Data.SqlClient

Public Class UCEditEmployee

    Dim tbl As DataTable
    Dim action As String

    Private Sub UCEditEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsSql.connectionString = My.Settings.ConnectionString
        LoadEmployees()
    End Sub

    Sub LoadEmployees()
        tbl = MsSql.Table("SELECT * FROM Tbl_EmployeeList WHERE EmployeeStatus='1' ORDER BY TotalCredits DESC")
        DGEmpList.Rows.Clear()

        For Each dr As DataRow In tbl.Rows
            DGEmpList.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7))
        Next
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        EnableTextBoxes()
        ClearTextBoxes()
        GetRealBarcode()
        action = "add"
    End Sub

    Sub AddEmployees()
        MsSql.ExecuteQuery("INSERT INTO Tbl_EmployeeList (COOP_id, FullName, Position, Status, barcode, Site, TotalCredits,RealBarcode,EmployeeStatus) VALUES ('" & TxtCoopId.Text & "', '" & TxtFullName.Text & "', '" & TxtPos.Text & "', '" & TxtStatus.Text & "', '" & TxtBarcode.Text & "', '" & TxtSite.Text & "', '" & TxtTotalCredits.Text & "','" & TxtBarcode.Text & "','1')", Nothing)
        MessageBox.Show("New Employee has been added!", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadEmployees()
        ClearTextBoxes()
    End Sub
    Sub EditEmployees()
        MsSql.ExecuteQuery("UPDATE Tbl_EmployeeList SET COOP_id = '" & TxtCoopId.Text & "', FullName = '" & TxtFullName.Text & "', Position = '" & TxtPos.Text & "', Status = '" & TxtStatus.Text & "', barcode='" & TxtBarcode.Text & "', Site = '" & TxtSite.Text & "', TotalCredits = '" & TxtTotalCredits.Text & "',RealBarcode='" & TxtBarcode.Text & "' WHERE id = '" & LblId.Text & "'", Nothing)
        MessageBox.Show("Successfully edited employee!", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadEmployees()
        ClearTextBoxes()
    End Sub

    Sub DeleteEmployees()
        If MessageBox.Show("Are you sure you want to delete this Employee?", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MsSql.ExecuteQuery("DELETE FROM Tbl_EmployeeList WHERE id = '" & LblId.Text & "'", Nothing)
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
                LblId.Text = DGEmpList.Rows(e.RowIndex).Cells(0).Value
                TxtCoopId.Text = DGEmpList.Rows(e.RowIndex).Cells(1).Value
                TxtFullName.Text = DGEmpList.Rows(e.RowIndex).Cells(2).Value
                TxtPos.Text = DGEmpList.Rows(e.RowIndex).Cells(3).Value
                TxtStatus.Text = DGEmpList.Rows(e.RowIndex).Cells(4).Value
                TxtBarcode.Text = DGEmpList.Rows(e.RowIndex).Cells(5).Value
                LblBarcode.Text = TxtBarcode.Text
                LblTextBar.Text = TxtBarcode.Text
                TxtSite.Text = DGEmpList.Rows(e.RowIndex).Cells(6).Value
                TxtTotalCredits.Text = DGEmpList.Rows(e.RowIndex).Cells(7).Value
            End If
        Catch ex As Exception

        End Try
    End Sub


    Dim RealBarcode As String = "0"

    Sub GetRealBarcode()
        Try
            Using conn As New SqlConnection(My.Settings.ConnectionString)
                conn.Open()
                Dim command As New SqlCommand("SELECT TOP 1 RealBarcode FROM Tbl_EmployeeList ORDER BY RealBarcode DESC", conn)
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
                TxtBarcode.Text = RealBarcode
                LblTextBar.Text = RealBarcode
                LblBarcode.Text = RealBarcode
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        EnableTextBoxes()
        action = "edit"
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        DeleteEmployees()
    End Sub

End Class
