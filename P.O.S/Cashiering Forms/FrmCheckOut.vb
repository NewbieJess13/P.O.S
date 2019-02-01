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
End Class