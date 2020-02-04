Imports MealAllowance.Ibiden
Public Class FrmViaAllowance
    Dim server As String = "192.168.53.72"
    Dim regAllowance As Decimal
    Dim speAllowance As Decimal
    Dim regAllowancestr As String
    Dim speAllowancestr As String
    Dim sectionName As String
    Dim TotalBal As String
    Dim TransactionDate As String
    Dim CanteenCode As String
    Dim PrevRegAllowance As String
    Dim PrevSpeAllowance As String
    Dim CostCenterCode As String
    Dim errorCode As Integer
    Dim InquiryID As String
    Dim ibiden As MealAllowance.Ibiden



    Private Sub txtBarcode_TextChanged(sender As Object, e As EventArgs) Handles txtBarcode.TextChanged
        If txtBarcode.TextLength = 11 Then
            InquiryID = txtBarcode.Text.Substring(0, txtBarcode.TextLength - 2)
            errorCode = ibiden.BalanceInquiry(server, InquiryID, regAllowance, speAllowance, sectionName)
            LblBalance.Text = "₱ " & Math.Round(regAllowance + speAllowance, 2)
        End If
        If errorCode = "-1" Then
            MessageBox.Show("Server not Found!", My.Settings.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf errorCode = "-2" Then
            MessageBox.Show("Employee not Found!", My.Settings.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf errorCode = "-3" Then
            MessageBox.Show("File not Found!", My.Settings.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf errorCode = "-4" Then
            MessageBox.Show("Negative Balance!", My.Settings.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf errorCode = "-5" Then
            MessageBox.Show("Negative Balance!", My.Settings.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf errorCode = "-6" Then
            MessageBox.Show("Null value passed as  parameter!", My.Settings.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf errorCode = "-7" Then
            MessageBox.Show("Illegal Process!", My.Settings.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class