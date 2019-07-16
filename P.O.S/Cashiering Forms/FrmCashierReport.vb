Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class FrmCashierReport
    Dim crystal As New ReportDocument

    Private Sub FrmCashierReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crystal.Load("C:\Users\JESTONI\source\repos\P.O.S\P.O.S\Cashiering Forms\ReceiptReport.rpt")
        GetTransactionNo()

    End Sub
    Dim TransactionNo As String
    Sub GetTransactionNo()
        Try
            Using conn As New SqlConnection(My.Settings.ConnectionString)
                conn.Open()
                Dim command As New SqlCommand("SELECT TOP 1 TransactionNo FROM ViewReceiptReport ORDER BY TransactionNo DESC", conn)
                Dim DT As New DataTable
                Dim DA As New SqlDataAdapter With {
                    .SelectCommand = command
                }
                DA.Fill(DT)
                If DT.Rows.Count > 0 Then
                    For Each dr As DataRow In DT.Rows
                        TransactionNo = dr(0)
                    Next
                End If
            End Using
            DisplayToReceipt()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub DisplayToReceipt()
        Try
            Using conn As New SqlConnection(My.Settings.ConnectionString)
                conn.Open()
                Dim command As New SqlCommand("SELECT * FROM ViewReceiptReport WHERE TransactionNo = @TransactionNo", conn)
                command.Parameters.AddWithValue("@TransactionNo", TransactionNo)
                Dim DT As New DataTable
                Dim DA As New SqlDataAdapter With {
                    .SelectCommand = command
                }
                DA.Fill(DT)
                crystal.SetDataSource(DT)
                CrystalReportReceipt.ReportSource = crystal
            End Using
        Catch ex As Exception

        End Try
    End Sub


End Class