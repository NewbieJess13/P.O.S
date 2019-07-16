Imports ClassSql
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class FrmOpenSession

    Dim dateTime As String

    Sub New()
        InitializeComponent()
        TxtBusinessDate.Text = Format(Date.Now, "dd-mm-yy hh:mm:ss")
    End Sub

    Private Sub FrmOpenSession_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsSql.connectionString = My.Settings.ConnectionString
        TxtCashierName.Text = frmLogin.user1
    End Sub

    Private Sub BtnReplenish_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        If TxtBegCash.Text <> "" And TxtNotes.Text <> "" Then
            If MessageBox.Show("Are you sure you want to start your session?", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                InsertCashierSession()
                ClearTexts()
                MessageBox.Show("Session Opened.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FrmCashierSession.Show()
            End If
        Else
            MessageBox.Show("Please fill up all the required fields.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ClearTexts()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()
    End Sub

    Sub ClearTexts()
        TxtBegCash.Clear()
        TxtNotes.Clear()
    End Sub

    Dim TransNo As String = "0"

    Private Sub GetTransactionID()
        Try
            Dim dt As DataTable
            dt = MsSql.Table("SELECT TOP 1 TransactionNo FROM Tbl_CashierSession ORDER BY TransactionNo DESC")
            If dt.Rows.Count > 0 Then
                Dim TransNumber As Integer
                For Each dr As DataRow In dt.Rows
                    TransNumber = dr(0) + 1
                    TransNo = Format(TransNumber, "000000000000")
                Next
            Else
                TransNo = "000000000001"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub InsertCashierSession()
        GetTransactionID()
        Dim SessionID As String = Splitted() & TxtCashierName.Text
        My.Settings.SessionID = SessionID
        Try
            Using conn As New SqlConnection(My.Settings.ConnectionString)
                conn.Open()
                Dim command As New SqlCommand("INSERT INTO Tbl_CashierSession (TransactionNo,SessionId,xDatexTime,CashAmount,EndCash,Notes,xTransaction) VALUES (@TransactionNo,@SessionId,@DateTime,@BeginCash,@EndCash,@Notes,@XTransaction)", conn)
                command.Parameters.AddWithValue("@TransactionNo", TransNo)
                command.Parameters.AddWithValue("@SessionId", SessionID)
                command.Parameters.AddWithValue("@DateTime", Splitted)
                command.Parameters.AddWithValue("@BeginCash", TxtBegCash.Text)
                command.Parameters.AddWithValue("@EndCash", "")
                command.Parameters.AddWithValue("@Notes", TxtNotes.Text)
                command.Parameters.AddWithValue("@XTransaction", "Beginning Balance")
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Function Splitted()
        dateTime = TxtBusinessDate.Text
        Dim Converted As String = Regex.Replace(dateTime, "[- :]", "")
        Return Converted
    End Function

    Private Sub TxtBegCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBegCash.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtBegCash_TextChanged(sender As Object, e As EventArgs) Handles TxtBegCash.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d.]")
        TxtBegCash.Text = digitsOnly.Replace(TxtBegCash.Text, "")
    End Sub

    Private Sub FrmOpenSession_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Enter Then
            BtnOpen.PerformClick()
        End If
    End Sub
End Class