Imports ClassSql
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FrmAddToCredits

    Dim tbl As DataTable
    Dim Valerina As String

    Sub GetEmployeeInfo()
        tbl = MsSql.Table("SELECT COOP_id,FullName,TotalCredits FROM Tbl_EmployeeList WHERE RealBarcode='" & TxtBarcode.Text & "'")
        If tbl.Rows.Count > 0 Then
            For Each dr As DataRow In tbl.Rows
                TxtIDno.Text = dr(0)
                TxtName.Text = dr(1)
                TxtCredits.Text = dr(2)
            Next
            CheckIfCreditLimitreached()
        Else
            LblNotifyCredit.Text = "Barcode not registered!"
            LblNotifyCredit.ForeColor = Color.Red
            BtnOk.Enabled = False
        End If

    End Sub

    Private Sub FrmAddToCredits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsSql.connectionString = My.Settings.ConnectionString
        LblPurchaseAmount.Text = FrmCashierSession.LblTotalRes.Text
        TxtBarcode.Focus()
    End Sub

    Private Sub TxtBarcode_TextChanged(sender As Object, e As EventArgs) Handles TxtBarcode.TextChanged
        If TxtBarcode.TextLength = TxtBarcode.MaxLength Then
            BtnOk.Enabled = True
            GetEmployeeInfo()

        End If
    End Sub

    Private Sub AddToEmployeeCredit()
        Try
            Using conn As New SqlConnection(My.Settings.ConnectionString)
                conn.Open()
                Dim command As New SqlCommand("UPDATE Tbl_EmployeeList SET TotalCredits += @PurchaseItems WHERE RealBarcode= @Barcode", conn)
                command.Parameters.AddWithValue("@PurchaseItems", ToBeAddedToCredits)
                command.Parameters.AddWithValue("@Barcode", TxtBarcode.Text)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MessageBox.Show("Successfully added to credits.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ClearAllTheTemporaryItems()
        If MsSql.ExecuteQuery("DELETE  FROM Tbl_TempTransactions", Nothing) = False Then
            MessageBox.Show("Error in deleting temp transaction!", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CheckIfCreditLimitreached()
        Dim TotalCredits As Decimal = 0
        TotalCredits = Val(TxtCredits.Text) + Val(LblPurchaseAmount.Text)
        If TotalCredits > My.Settings.CreditLimit Then
            LblNotifyCredit.ForeColor = Color.Red
            LblNotifyCredit.Text = "● Credit denied!"
            BtnOk.Enabled = False
        ElseIf TotalCredits < My.Settings.CreditLimit Then
            LblNotifyCredit.ForeColor = Color.Green
            LblNotifyCredit.Text = "● Credit allowed!"
            BtnOk.Enabled = True
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        AddToEmployeeCredit()
    End Sub

    Function ToBeAddedToCredits()
        Dim Converted As String
        Dim value As String = LblPurchaseAmount.Text
        Converted = Regex.Replace(value, "[^A-Za-z\-/0-9]", "")
        Return Converted
    End Function
End Class