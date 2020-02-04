Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Text
Public Class FrmCheckOut

    Public Event LoadDataToGridToCheckOut As EventHandler
    Dim Converted, VAT As Decimal
    Dim CSCrud As New CashierSessionCrud
    Dim CSdata As New CashierTransData

    Private Sub FrmCheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtTotalAmount.Text = ToBeMinusToTotalAmount()
        TxtChange.ReadOnly = True
        TxtCashTendered.Text = ""
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
            ReadyTheReceipt()
        End If
    End Sub


    Sub ReadyTheReceipt()
        If CSCrud.InsertIntoItems() Then
            RaiseEvent LoadDataToGridToCheckOut(Me, Nothing)
            ClearTexts()
            Me.Close()
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