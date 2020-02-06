Imports ClassSql

Public Class UCEditStaff
    Dim tbl As DataTable
    Dim action As String

    Sub ClearTexts()
        TxtFullName.Clear()
        txtCoopId.Clear()
        TxtUsername.Clear()
        TxtPassword.Clear()
        TxtPos.Clear()
        CmbUserType.Text = ""
        TxtBarcode.Clear()

    End Sub
    Sub EnableTexts()
        TxtFullName.Enabled = True
        txtCoopId.Enabled = True
        TxtUsername.Enabled = True
        TxtPassword.Enabled = True
        TxtPos.Enabled = True
        CmbUserType.Enabled = True
        TxtBarcode.Enabled = True

        TxtFullName.Focus()
    End Sub
    Sub DisableTexts()
        TxtFullName.Enabled = False
        txtCoopId.Enabled = False
        TxtUsername.Enabled = False
        TxtPassword.Enabled = False
        TxtPos.Enabled = False
        CmbUserType.Enabled = False
        TxtBarcode.Enabled = False
    End Sub

    Sub AddUserAccounts()
        '      MsSql.ExecuteQuery("INSERT INTO Tbl_UserAccounts (Full_Name, COOP_id, UserName, Password,  Position, Account_Type, Barcode,RealBarcode) VALUES ('" & TxtFullName.Text & "', '" & txtCoopId.Text & "', '" & TxtUsername.Text & "', '" & TxtPassword.Text & "', '" & TxtPos.Text & "', '" & CmbUserType.Text & "','" & TxtBarcode.Text & "', '" & RchTxtRealBarcode.Text & "')", Nothing)
        LoadUsers()
        ClearTexts()
        DisableTexts()
        MessageBox.Show("New staff has been added!", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Sub EditUserAccounts()
        '    MsSql.ExecuteQuery("UPDATE Tbl_UserAccounts SET Full_Name ='" & TxtFullName.Text & "', COOP_id='" & txtCoopId.Text & "', UserName ='" & TxtUsername.Text & "', Password ='" & TxtPassword.Text & "', Position='" & TxtPos.Text & "',Account_Type='" & CmbUserType.Text & "',Barcode='" & TxtBarcode.Text & "',RealBarcode='" & RchTxtRealBarcode.Text & "' WHERE id='" & LblId.Text & "' ", Nothing)
        LoadUsers()
        ClearTexts()
        DisableTexts()
        MessageBox.Show("Information successfully updated!", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Sub DeleteUserAccounts()
        If MessageBox.Show("Are you sure you want to delete this user?", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            '         MsSql.ExecuteQuery("DELETE FROM Tbl_UserAccounts WHERE id='" & LblID.Text & "'", Nothing)
            LoadUsers()
            ClearTexts()
            DisableTexts()
        End If
    End Sub

    Sub LoadUsers()
        '     tbl = MsSql.Table("SELECT * FROM Tbl_UserAccounts ORDER BY Full_Name ASC")
        DGUserAccounts.Rows.Clear()
        For Each dr As DataRow In tbl.Rows
            DGUserAccounts.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7))
        Next

    End Sub

    Private Sub UCEditStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '     MsSql.connectionString = My.Settings.ConnectionString
        LoadUsers()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        action = "Add"
        ClearTexts()
        EnableTexts()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        action = "Edit"
        EnableTexts()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If action = "Add" Then
            AddUserAccounts()

        ElseIf action = "Edit" Then
            EditUserAccounts()
        End If
    End Sub

    Private Sub DGUserAccounts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUserAccounts.CellClick
        Try
            If e.RowIndex >= 0 Or e.ColumnIndex >= 0 Then
                LblID.Text = DGUserAccounts.Rows(e.RowIndex).Cells(0).Value
                TxtFullName.Text = DGUserAccounts.Rows(e.RowIndex).Cells(1).Value
                txtCoopId.Text = DGUserAccounts.Rows(e.RowIndex).Cells(2).Value
                TxtUsername.Text = DGUserAccounts.Rows(e.RowIndex).Cells(3).Value
                TxtPassword.Text = DGUserAccounts.Rows(e.RowIndex).Cells(4).Value
                TxtPos.Text = DGUserAccounts.Rows(e.RowIndex).Cells(5).Value
                CmbUserType.Text = DGUserAccounts.Rows(e.RowIndex).Cells(6).Value
                TxtBarcode.Text = DGUserAccounts.Rows(e.RowIndex).Cells(7).Value
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        DeleteUserAccounts()
        LoadUsers()
        ClearTexts()
    End Sub

    'Private Sub TxtBarcode_TextChanged(sender As Object, e As EventArgs) Handles TxtBarcode.TextChanged
    '    Dim Barcode, Check12Digits As String
    '    If Not (String.IsNullOrEmpty(TxtBarcode.Text)) Then
    '        Check12Digits = TxtBarcode.Text.PadRight(12, "0")
    '        Barcode = EAN13(Check12Digits)
    '        LblBarcode.Text = Barcode
    '        If Not (String.IsNullOrEmpty(Barcode13Digits)) And
    '                Not Barcode13Digits = "" Then
    '            RchTxtRealBarcode.Text = Barcode13Digits.Trim.ToString
    '            Dim intStart As Short = Convert.ToInt16(RchTxtRealBarcode.TextLength - 1)
    '            ChangeColor(RchTxtRealBarcode, intStart)
    '        End If
    '    End If
    'End Sub
End Class
