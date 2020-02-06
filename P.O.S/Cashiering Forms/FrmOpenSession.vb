Imports ClassSql
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class FrmOpenSession

    Dim dateTime As String
    Dim CSCrud As New CashierSessionCrud
    Dim SesData As New SessionData
    Sub New()
        InitializeComponent()
        TxtBusinessDate.Text = Format(Date.Now, "dd-mm-yy hh:mm:ss")
    End Sub

    Private Sub FrmOpenSession_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtCashierName.Text = My.Settings.FullName
    End Sub

    Private Sub BtnReplenish_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        If TxtBegCash.Text <> "" And TxtNotes.Text <> "" Then
            InsertCashierSession()
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



    Dim TransNo As String = "0"
    Private Sub GetTransactionID()
        Try
            Dim DT As DataTable = CSCrud.GetTransSession
            If DT.Rows.Count > 0 Then
                Dim TransNumber As Integer
                For Each dr As DataRow In DT.Rows
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
        SesData.TransactionNo = TransNo
        SesData.SessionID = String.Concat(Date.Now.ToString("yyMMddhhmmss"), My.Settings.FullName)
        SesData.DateTime = TxtBusinessDate.Text
        SesData.CashAmount = TxtBegCash.Text
        SesData.Notes = TxtNotes.Text
        SesData.xTransaction = "Open Session"
        SesData.SessionUser = My.Settings.FullName
        If CSCrud.InsertSession(SesData) Then
            ClearTexts()
            FrmCashierSession.Show()
            Me.Close()
            My.Settings.SessionID = SesData.SessionID
            UpdateAcctSes()
        End If
    End Sub

    Sub UpdateAcctSes()
        If CSCrud.UpdateSessionAcct() Then

        End If
    End Sub

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


    Sub ClearTexts()
        TxtBegCash.Clear()
        TxtNotes.Clear()
    End Sub
End Class