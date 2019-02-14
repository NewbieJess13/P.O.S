Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
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
        Dim Converted, VAT, Total As Decimal
        Dim value As String = FrmCashierSession.LblTotalRes.Text
        Converted = Regex.Replace(value, "[^A-Za-z\-/0-9\./]", "")
        VAT = Converted * 0.12
        Total = VAT + Converted
        Total = Math.Round(Total, 2)
        Return Total
    End Function

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        TxtCashTendered.Text += sender.text
    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles Btn.Click
        ConfirmBillOut()
    End Sub

    Sub ConfirmBillOut()
        Dim xDate As String = Format(Date.Now, "dd-mm-yy").ToString
        Dim xTime As String = Format(Date.Now, "hh:mm:ss tt").ToString
        Try
            GetTransactionNo()
            Using conn As New SqlConnection(My.Settings.ConnectionString)
                conn.Open()
                Dim command As New SqlCommand("INSERT INTO Tbl_TransactionHeader (TransactionNo,TransDate,TransTime,Cashier,TotalAmount,PaymentMethod,CashTendered,Change,TransactionType) VALUES (@TransactionNo,@Date,@Time,@Cashier,@TotalAmount,'Cash',@CashTendered,@Change,'Sales')", conn)
                command.Parameters.AddWithValue("@TransactionNo", TransactionNo)
                command.Parameters.AddWithValue("@Date", xDate)
                command.Parameters.AddWithValue("@Time", xTime)
                command.Parameters.AddWithValue("@Cashier", My.Settings.FullName)
                command.Parameters.AddWithValue("@TotalAmount", TxtTotalAmount.Text)
                command.Parameters.AddWithValue("@CashTendered", TxtCashTendered.Text)
                command.Parameters.AddWithValue("@Change", TxtChange.Text)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Dim TransactionNo As String = "0"

    Sub GetTransactionNo()
        Try
            Using conn As New SqlConnection(My.Settings.ConnectionString)
                conn.Open()
                Dim command As New SqlCommand("SELECT TOP 1 TransactionNo FROM Tbl_TransactionHeader ORDER BY TransactionNo DESC", conn)
                Dim DT As New DataTable
                Dim DA As New SqlDataAdapter With {
                    .SelectCommand = command
                }
                DA.Fill(DT)
                If DT.Rows.Count > 0 Then
                    Dim TransNum As Integer
                    For Each dr As DataRow In DT.Rows
                        TransNum = dr(0) + 1
                        TransactionNo = Format(TransNum, "000000000000")
                    Next
                Else
                    TransactionNo = "000000000001"
                End If

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class