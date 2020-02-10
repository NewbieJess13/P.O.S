Imports System.Text.RegularExpressions
Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmCheckOut

    Public Event LoadDataToGridToCheckOut As EventHandler
    Dim Converted As Decimal
    Dim CSCrud As New CashierSessionCrud
    Dim CSdata As New CashierTransData
    Dim ReceiptNo As String
    Dim crystal As New ReportDocument
    Private Sub FrmCheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtTotalAmount.Text = ToBeMinusToTotalAmount()
        TxtChange.ReadOnly = True
        TxtCashTendered.Text = ""
        crystal.Load(Application.StartupPath & "\ReceiptReport.rpt")
    End Sub

    Private Sub TxtCashTendered_TextChanged(sender As Object, e As EventArgs) Handles TxtCashTendered.TextChanged
        If TxtCashTendered.TextLength = 0 Then
            BtnClear.Enabled = False
            TxtChange.Text = 0
        Else
            BtnClear.Enabled = True
            TxtChange.Text = Math.Round(Val(TxtCashTendered.Text) - Val(TxtTotalAmount.Text), 2)
        End If
    End Sub

    Function ToBeMinusToTotalAmount()
        Dim Total As Decimal
        Dim value As String = FrmCashierSession.LblTotalRes.Text
        Converted = Regex.Replace(value, "[^A-Za-z\-/0-9\./]", "")
        Total = Converted
        Total = Math.Round(Total, 2)
        Return Total
    End Function

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click, Btn0.Click, Btn2.Click, Btn3.Click, Btn4.Click, Btn5.Click, Btn6.Click, Btn7.Click, Btn8.Click, Btn9.Click, Btndot.Click
        TxtCashTendered.Text += sender.text
    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles BtnBillOut.Click
        If TxtCashTendered.TextLength <> 0 Then
            If TxtChange.Text < 0 Then
                MessageBox.Show("Not enough cash tendered.", My.Settings.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ConfirmBillOut()
            End If
        Else
            MessageBox.Show("Invalid Process.", My.Settings.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub ConfirmBillOut()
        CSdata.PurchasedAmount = TxtTotalAmount.Text
        CSdata.PaymentMethod = "Cash"
        CSdata.CashTendered = TxtCashTendered.Text
        CSdata.Change = TxtChange.Text
        CSdata.TransactionType = "Sales"
        CSdata.CashBalance = 0
        If CSCrud.ConfirmBillOut(CSdata) Then
            If CSCrud.InsertIntoItems() Then
                Dim DT As DataTable = CSCrud.GetTransactionNo()
                If DT.Rows.Count > 0 Then
                    ReceiptNo = DT.Rows(0)(0)
                    Dim DTprint As DataTable = CSCrud.GetReport(ReceiptNo)
                    CRVcash.Show()
                    If DTprint.Rows.Count > 0 Then
                        crystal.SetDataSource(DTprint)
                        CRVcash.ReportSource = crystal
                        RaiseEvent LoadDataToGridToCheckOut(Me, Nothing)
                        crystal.PrintOptions.PrinterName = My.Settings.PrinterName
                        crystal.PrintToPrinter(1, False, 1, 1)
                        CRVcash.Hide()
                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtCashTendered.Text = TxtCashTendered.Text.Remove(TxtCashTendered.TextLength - 1)
    End Sub

    Private Sub FrmCheckOut_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ClearTexts()
    End Sub

    Sub ClearTexts()
        TxtTotalAmount.Clear()
        TxtCashTendered.Clear()
        TxtBalance.Clear()
        TxtChange.Clear()
    End Sub
End Class