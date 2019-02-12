Imports System.Text.RegularExpressions
Public Class FrmCheckOut
    Sub New()
        InitializeComponent()
        TxtTotalAmount.Text = ToBeMinusToTotalAmount()

    End Sub
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtCashTendered.Text = TxtCashTendered.Text.Remove(TxtCashTendered.TextLength - 1)

    End Sub

    Private Sub TxtCashTendered_TextChanged(sender As Object, e As EventArgs) Handles TxtCashTendered.TextChanged
        If TxtCashTendered.TextLength = 0 Then
            BtnClear.Enabled = False
            TxtChange.Text = 0
        Else
            BtnClear.Enabled = True
            TxtChange.Text = Val(TxtCashTendered.Text) - Val(TxtTotalAmount.Text)
        End If
    End Sub

    Function ToBeMinusToTotalAmount()
        Dim Converted As Decimal
        Dim value As String = FrmCashierSession.LblTotalRes.Text
        Converted = Regex.Replace(value, "[^A-Za-z\-/0-9\./]", "")
        Return Converted

    End Function

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click, Btn2.Click, Btn3.Click, Btn4.Click, Btn5.Click, Btn6.Click, Btn7.Click, Btn8.Click, Btn9.Click, Btndot.Click, Btn0.Click
        TxtCashTendered.Text += sender.text
    End Sub
End Class