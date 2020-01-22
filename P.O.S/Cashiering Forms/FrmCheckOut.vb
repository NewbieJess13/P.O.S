Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Text
Public Class FrmCheckOut

    Public Event LoadDataToGridToCheckOut As EventHandler

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        TxtCashTendered.Text = 0
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtCashTendered.Text = TxtCashTendered.Text.Remove(TxtCashTendered.TextLength - 1)
    End Sub

    Private Sub TxtCashTendered_TextChanged(sender As Object, e As EventArgs) Handles TxtCashTendered.TextChanged
        If TxtCashTendered.TextLength = 0 Then
            BtnClear.Enabled = False
            TxtChange.Text = 0
            TxtCashTendered.Text = 0
        Else
            BtnClear.Enabled = True
            TxtChange.Text = Math.Round(Val(TxtCashTendered.Text) - Val(TxtTotalAmount.Text), 2)
        End If
    End Sub
    Dim Converted, VAT As Decimal
    Function ToBeMinusToTotalAmount()
        Dim Total As Decimal
        Dim value As String = FrmCashierSession.LblTotalRes.Text
        Converted = Regex.Replace(value, "[^A-Za-z\-/0-9\./]", "")
        '   VAT = Math.Round(Converted * 0.12, 2)
        Total = Converted
        Total = Math.Round(Total, 2)
        Return Total
    End Function

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        TxtCashTendered.Text += sender.text
    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles Btn.Click
        If TxtCashTendered.Text <> 0 Then
            ConfirmBillOut()
        Else
            MessageBox.Show("Please enter the Cash tendered first.", My.Settings.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub ConfirmBillOut()
        Dim xDate As String = Format(Date.Now, "dd-MM-yy").ToString
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
                'command.Parameters.AddWithValue("@VAT", LblVat.Text)
                command.Parameters.AddWithValue("@CashTendered", TxtCashTendered.Text)
                command.Parameters.AddWithValue("@Change", TxtChange.Text)
                command.ExecuteNonQuery()
            End Using
            ReadyTheReceipt()

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
                    Dim TransNum As String
                    For Each dr As DataRow In DT.Rows
                        ' TransNum = dr(0) + 1
                        TransNum = Date.Now.ToString("yyyyMMdd-hhmmss")
                        TransactionNo = TransNum + My.Settings.Username
                    Next
                    'Else
                    '    TransactionNo = "000000000001"
                End If

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub ReadyTheReceipt()
        Try
            Using conn As New SqlConnection(My.Settings.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("EXEC InsertIntoTransactItems")
                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.ExecuteNonQuery()
            End Using

            If MessageBox.Show("Print Receipt?", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                RaiseEvent LoadDataToGridToCheckOut(Me, Nothing)
                ClearTexts()
                Me.Hide()
                FrmCashierReport.Show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmCheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtTotalAmount.Text = ToBeMinusToTotalAmount()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Sub ClearTexts()
        TxtTotalAmount.Clear()
        TxtCashTendered.Clear()
        TxtChange.Clear()
    End Sub
End Class