Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class UCBarcodePrinter
    Dim crystal As New ReportDocument

    Private Sub UCBarcodePrinter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crystal.Load("C:\Users\JESTONI\source\repos\P.O.S\P.O.S\BarcodePrint.rpt")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim conn As New SqlConnection(My.Settings.ConnectionString)
            conn.Open()
            Dim sql As String = "SELECT * FROM Tbl_Products WHERE RealBarcode='" & TxtBarcode.Text & "'"
            'For i As Integer = 1 To TxtNumber.Text Step 1
            '    sql = sql + " UNION ALL SELECT * FROM Tbl_Products WHERE RealBarcode='" & TxtBarcode.Text & "'"
            'Next
            Dim DA As New SqlDataAdapter("SELECT * FROM Tbl_Products WHERE RealBarcode='" & TxtBarcode.Text & "'", conn)
            Dim DS As New DataSet
            DA.Fill(DS, "RealBarcode")
            crystal.SetDataSource(DS)
            CrystalReportViewer1.ReportSource = crystal


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Using conn As New SqlConnection(My.Settings.ConnectionString)
                conn.Open()
                Dim command As New SqlCommand("SELECT * FROM Tbl_Products", conn)
                Dim DS As New DataSet
                Dim DA As New SqlDataAdapter With {
                    .SelectCommand = command
                }
                DA.Fill(DS, "RealBarcode")
                crystal.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = crystal

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
