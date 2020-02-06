Imports CrystalDecisions.CrystalReports.Engine
Imports System.Text.RegularExpressions
Public Class FrmViaAllowance
    Public Event LoadDataToGridToCheckOut As EventHandler
    Dim server As String = "192.168.53.72"
    Dim regAllowance As Decimal
    Dim speAllowance As Decimal
    Dim regAllowancestr As String
    Dim speAllowancestr As String
    Dim sectionName As String
    Dim TotalBal As String
    Dim purchasedList As String
    Dim TransactionDate As String
    Dim CanteenCode As String = "5"
    Dim newRegAllowance As String
    Dim newSpeAllowance As String
    Dim CostCenterCode As String
    Dim errorCode As Integer
    Dim InquiryID As String
    Dim receiptNum As String
    Dim employeeClass As String
    Dim remBalance As String
    Dim Converted As Decimal
    Dim purchasedAmount As String
    Dim tendered As String
    Dim change As String
    Dim bal As String
    Dim realID As String
    Dim ibiden As MealAllowance.Ibiden
    Dim CSCrud As New CashierSessionCrud
    Dim CSData As New CashierTransData
    Dim CTData As New CaptureTransData
    Dim crystal As New ReportDocument
    Function ToBeMinusToTotalAmount()
        Dim Total As Decimal
        Dim value As String = FrmCashierSession.LblTotalRes.Text
        Converted = Regex.Replace(value, "[^A-Za-z\-/0-9\./]", "")
        Total = Converted
        Total = Math.Round(Total, 2)
        Return Total
    End Function

    Private Sub FrmViaAllowance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crystal.Load(Application.StartupPath & "\ReceiptMealAllowance.rpt")
        txtTotalAmount.ReadOnly = True
        txtBalance.ReadOnly = True
        txtChange.ReadOnly = True
        txtTotalAmount.Text = ToBeMinusToTotalAmount()
        purchasedList = FrmCashierSession.purchasedList

    End Sub

    Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtBarcode.TextLength = 11 Then
                InquiryID = txtBarcode.Text.Substring(0, txtBarcode.TextLength - 2)
                ' errorCode = ibiden.BalanceInquiry(server, InquiryID, regAllowancestr, speAllowancestr, sectionName)
                TotalBal = regAllowancestr + speAllowancestr
                LblBalance.Text = "₱ " & TotalBal

                MessageBox.Show(realID)
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
                Else
                    'Success
                    CompareBal()
                End If
            End If

        End If
    End Sub

    Sub CompareBal()
        If Val(TotalBal) > Val(txtTotalAmount.Text) Then
            purchasedAmount = txtTotalAmount.Text
            tendered = 0
            change = 0
            bal = 0
        ElseIf Val(txtTotalAmount.Text) > TotalBal Then
            txtBalance.Text = Val(txtTotalAmount.Text) - TotalBal
            purchasedAmount = TotalBal
            bal = txtBalance.Text
        End If
    End Sub

    Private Sub BtnBillOut_Click(sender As Object, e As EventArgs) Handles BtnBillOut.Click
        ConfirmBillOut()
    End Sub

    Sub ConfirmBillOut()
        CSData.PurchasedAmount = txtTotalAmount.Text
        CSData.PaymentMethod = "MealAllowance"
        CSData.CashTendered = tendered
        CSData.Change = change
        CSData.TransactionType = "Sales"
        CSData.CashBalance = bal
        If CSCrud.ConfirmBillOut(CSData) Then
            SaveItemTrans()
        End If
    End Sub

    Sub SaveItemTrans()
        If CSCrud.InsertIntoItems() Then
            CaptureTransaction()
        End If
    End Sub

    Sub GetTransactionNo()
        Dim DT As DataTable = CSCrud.GetTransactionNo
        If DT.Rows.Count > 0 Then
            receiptNum = DT.Rows(0)(0)
            CaptureTransaction()
        End If
    End Sub

    Sub CaptureTransaction()
        TransactionDate = Date.Now.ToString("yyyyMMddhhmm")
        errorCode = ibiden.CaptureTransaction(server, InquiryID, TotalBal, purchasedList, purchasedAmount, My.Settings.FullName, receiptNum, TransactionDate, CanteenCode, regAllowance, speAllowance, CostCenterCode, employeeClass)
        remBalance = regAllowance + speAllowance
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
        Else
            'Success
            'Inquire Again
            errorCode = ibiden.BalanceInquiry(server, InquiryID, newRegAllowance, newSpeAllowance, sectionName)
            'trim id
            realID = InquiryID.TrimStart("0"c)
            'If realID.Length < 3 Then
            '    realID.ToString().PadLeft(2, "0")
            'End If
            CTData.EmployeeID = realID
                CTData.AvailableBalance = remBalance
                CTData.PurchasedList = purchasedList
                CTData.PurchasedAmount = purchasedAmount
                CTData.ReceiptNo = receiptNum
                CTData.TransactionDate = TransactionDate
                CTData.CanteenCode = CanteenCode
                CTData.RegAllowance = newRegAllowance
                CTData.SpeAllowance = newSpeAllowance
                CTData.CostCenterCode = CostCenterCode
                CTData.PrevRegAllowance = regAllowancestr
                CTData.PrevSpeAllowance = speAllowancestr
                CTData.errorCode = errorCode
                If CSCrud.SaveCaptureTrans(CTData) Then
                    PrintReport()
                End If
            End If
    End Sub

    Sub PrintReport()
        Dim DT As DataTable = CSCrud.GetReport(receiptNum)
        If DT.Rows.Count > 0 Then
            crystal.SetDataSource(DT)
            CRVAllowance.ReportSource = crystal
            RaiseEvent LoadDataToGridToCheckOut(Me, Nothing)
            Me.Close()
        End If
    End Sub

    Private Sub FrmViaAllowance_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmCashierSession.purchasedList = ""
        regAllowance = 0
        speAllowance = 0
        regAllowancestr = ""
        speAllowancestr = ""
        sectionName = ""
        TotalBal = ""
        purchasedList = ""
        TransactionDate = ""
        CanteenCode = ""
        newRegAllowance = ""
        newSpeAllowance = ""
        CostCenterCode = ""
        errorCode = 0
        InquiryID = ""
        receiptNum = ""
        employeeClass = ""
        remBalance = ""
        Converted = 0
        purchasedAmount = ""
        tendered = ""
        change = ""
        bal = ""
        realID = ""
        txtBarcode.Clear()
        txtTotalAmount.Clear()
        txtBalance.Clear()
        txtTendered.Clear()
        txtChange.Clear()
    End Sub

    Private Sub txtTendered_TextChanged(sender As Object, e As EventArgs) Handles txtTendered.TextChanged
        txtChange.Text = Val(txtTendered.Text) - Val(txtBalance.Text)
        tendered = txtTendered.Text
        change = txtChange.Text
    End Sub


End Class