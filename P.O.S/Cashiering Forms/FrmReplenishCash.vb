Imports System.Data.SqlClient
Imports ClassSql
Imports System.Text.RegularExpressions
Public Class FrmReplenishCash
    Sub New()
        InitializeComponent()
        TxtBusinessDate.Text = Format(Date.Now, "dd-mm-yy hh:mm:ss")
        'TxtCashierName.Text = frmLogin.user1
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ClearTexts()
    End Sub

    Sub ClearTexts()
        TxtCashAmount.Clear()
        TxtNotes.Clear()
    End Sub

    Dim TransactionNo As String = "0"

    Sub GetTransactionID()
        Try
            MsSql.connectionString = My.Settings.ConnectionString
            Dim dt As DataTable
            dt = MsSql.Table("SELECT TOP 1 TransactionNo FROM Tbl_CashierSession ORDER BY TransactionNo DESC")
            If dt.Rows.Count > 0 Then
                Dim TransNum As Integer
                For Each dr As DataRow In dt.Rows
                    TransNum = dr(0) + 1
                    TransactionNo = Format(TransNum, "000000000000")
                Next
            Else
                TransactionNo = "000000000001"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub InsertReplenish()
        GetTransactionID()
        Try
            Using conn As New SqlConnection(My.Settings.ConnectionString)
                conn.Open()
                Dim command As New SqlCommand("INSERT INTO Tbl_CashierSession (TransactionNo,SessionId,xDatexTime,CashAmount,Notes,xTransaction) VALUES (@TransactionNo,@SessionId,@xDateTime,@CashAmount,@Notes,@Transaction)", conn)
                command.Parameters.AddWithValue("@TransactionNo", TransactionNo)
                command.Parameters.AddWithValue("@SessionId", Splitted() & TxtCashierName.Text)
                command.Parameters.AddWithValue("@xDateTime", Splitted)
                command.Parameters.AddWithValue("@CashAmount", TxtCashAmount.Text)
                command.Parameters.AddWithValue("@Notes", TxtNotes.Text)
                command.Parameters.AddWithValue("@Transaction", "Replenish  Cash")
                command.ExecuteNonQuery()
                MessageBox.Show("Successfully replenished cash.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Dim dateTime As String

    Function Splitted()
        DateTime = TxtBusinessDate.Text
        Dim Converted As String = Regex.Replace(DateTime, "[- :]", "")
        Return Converted
    End Function

    Private Sub TxtCashAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCashAmount.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCashAmount_TextChanged(sender As Object, e As EventArgs) Handles TxtCashAmount.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d.]")
        TxtCashAmount.Text = digitsOnly.Replace(TxtCashAmount.Text, "")
    End Sub

    Private Sub BtnReplenish_Click(sender As Object, e As EventArgs) Handles BtnReplenish.Click
        If TxtCashAmount.Text <> "" And TxtNotes.Text <> "" Then
            InsertReplenish()
            ClearTexts()
            Close()
        Else
            MessageBox.Show("Please fill up all the fields.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class