Imports ClassSql

Public Class FrmVoidItem
    Dim dt As DataTable

    Public Event LoadDataToGrid As EventHandler

    Private Sub FrmVoidItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsSql.connectionString = My.Settings.ConnectionString
    End Sub

    Sub CheckBarcode()
        dt = MsSql.Table("SELECT * FROM Tbl_UserAccounts WHERE Account_Type='ADMINISTRATOR' AND RealBarcode='" & TxtAuthBarcode.Text & "'")
        If dt.Rows.Count > 0 Then
            DeleteItem()
            FrmCashierSession.LblNotification.Text = "Item Deleted!"
        Else
            MessageBox.Show("Not an authorized barcode!", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        TxtAuthBarcode.Clear()
    End Sub

    Sub DeleteItem()
        MsSql.ExecuteQuery("DELETE FROM Tbl_TempTransaction WHERE id='" & FrmCashierSession.PurchaseID & "'", Nothing)
        RaiseEvent LoadDataToGrid(Me, Nothing)
    End Sub

    Private Sub TxtAuthBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAuthBarcode.KeyDown
        If TxtAuthBarcode.TextLength = TxtAuthBarcode.MaxLength Then
            CheckBarcode()
        End If
    End Sub
End Class