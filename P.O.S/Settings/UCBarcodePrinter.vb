Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class UCBarcodePrinter
    Dim crystal As New ReportDocument

    Private Sub UCBarcodePrinter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crystal.Load("C:\Users\JESTONI\source\repos\P.O.S\P.O.S\BarcodePrint.rpt")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using conn As New SqlConnection(My.Settings.ConnectionString)
                conn.Open()
                Dim sql As String = "SELECT * FROM Tbl_Products WHERE RealBarcode= '" & TxtBarcode.Text & "' "
                For i As Integer = 1 To TxtNumber.Text Step 1
                    sql = sql + " UNION ALL Select * FROM Tbl_Products WHERE RealBarcode='" & TxtBarcode.Text & "'"
                Next
                Dim DA As New SqlDataAdapter(sql, conn)
                Dim DS As New DataTable
                DA.Fill(DS)
                crystal.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = crystal
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Using conn As New SqlConnection(My.Settings.ConnectionString)
                conn.Open()
                Dim command As New SqlCommand("SELECT * FROM Tbl_Products", conn)
                Dim DS As New DataTable
                Dim DA As New SqlDataAdapter With {
                        .SelectCommand = command
                    }
                DA.Fill(DS)
                crystal.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = crystal
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class
