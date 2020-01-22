Imports ClassSql

Public Class FrmVoidItem
    Dim dt As DataTable

    Public Event LoadDataToGrid As EventHandler

    Private Sub FrmVoidItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsSql.connectionString = My.Settings.ConnectionString
    End Sub

    Private Sub TxtAuthBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAuthBarcode.KeyDown

    End Sub

End Class