Imports System.Text.RegularExpressions
Public Class FrmCloseSession

    Dim CSCrud As New CashierSessionCrud
    Dim SesData As New SessionData
    Dim TransNo As String = "0"

    Sub New()
        InitializeComponent()
        TxtBusinessDate.Text = Format(Date.Now, "dd-mm-yy hh:mm:ss")
        TxtCashierName.Text = My.Settings.FullName
    End Sub
    Private Sub TxtCashAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCashAmount.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCashAmount_TextChanged(sender As Object, e As EventArgs) Handles TxtCashAmount.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d.]")
        TxtCashAmount.Text = digitsOnly.Replace(TxtCashAmount.Text, "")
    End Sub

    Private Sub GetTransactionID()
        Try
            Dim DT As DataTable = CSCrud.GetTransSession
            If DT.Rows.Count > 0 Then
                Dim TransNumber As Integer
                For Each dr As DataRow In DT.Rows
                    TransNumber = dr(0) + 1
                    TransNo = Format(TransNumber, "00000000")
                Next
            Else
                TransNo = "00000001"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub InsertCashierSession()
        GetTransactionID()
        SesData.TransactionNo = TransNo
        SesData.SessionID = My.Settings.SessionID
        SesData.DateTime = TxtBusinessDate.Text
        SesData.CashAmount = TxtCashAmount.Text
        SesData.Notes = TxtNotes.Text
        SesData.xTransaction = "Close Session"
        SesData.SessionUser = My.Settings.FullName
        If CSCrud.InsertSession(SesData) Then
            ClearTexts()
            FrmMainMenu.Show()
            FrmCashierSession.Close()
            CSCrud.UpdateSessionAcct("--")
        End If
    End Sub

    Private Sub FrmCloseSession_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Enter Then
            Btnclose.PerformClick()
        End If
    End Sub

    Sub ClearTexts()
        TxtCashAmount.Clear()
        TxtNotes.Clear()
    End Sub

    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        If TxtCashAmount.Text <> "" And TxtNotes.Text <> "" Then
            InsertCashierSession()
            ClearTexts()
        Else
            MessageBox.Show("Please fill up all the required fields.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ClearTexts()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()
        ClearTexts()
    End Sub
End Class