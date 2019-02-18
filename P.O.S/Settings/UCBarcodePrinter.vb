Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class UCBarcodePrinter
    Dim crystal As New ReportDocument

    Private Sub UCBarcodePrinter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crystal.Load("C:\Users\JESTONI\source\repos\P.O.S\P.O.S\Settings\BarcodePrint.rpt")
        TxtNumber.Items.AddRange(Enumerable.Range(1, 50).Cast(Of Object)().ToArray())
        TxtNumber.SelectedItem = 1

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnShow1.Click
        If CmbBarcodeType.Text <> "" Then
            Try
                Using conn As New SqlConnection(My.Settings.ConnectionString)
                    conn.Open()
                    Dim sql As String
                    If CmbBarcodeType.Text = "Products" Then
                        sql = "SELECT * FROM Tbl_Products WHERE RealBarcode= '" & TxtBarcode.Text & "'"
                    ElseIf CmbBarcodeType.Text = "Employees" Then
                        sql = "SELECT * FROM Tbl_EmployeeList WHERE RealBarcode= '" & TxtBarcode.Text & "'"
                    End If
                    For i As Integer = 1 To TxtNumber.Text Step 1
                        If CmbBarcodeType.Text = "Products" Then
                            sql = sql + " UNION ALL Select * FROM Tbl_Products WHERE RealBarcode='" & TxtBarcode.Text & "'"
                        ElseIf CmbBarcodeType.Text = "Employees" Then
                            sql = sql + " UNION ALL Select * FROM Tbl_EmployeeList WHERE RealBarcode='" & TxtBarcode.Text & "'"
                        End If

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
        Else
            MessageBox.Show("Please select the barcodes to be display.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnShowAll2.Click
        If CmbBarcodeType.Text <> "" Then
            Try
                Using conn As New SqlConnection(My.Settings.ConnectionString)
                    conn.Open()
                    Dim sql As String
                    If CmbBarcodeType.Text = "Products" Then
                        sql = "SELECT * FROM Tbl_Products"
                    ElseIf CmbBarcodeType.Text = "Employees" Then
                        sql = "SELECT * FROM Tbl_EmployeeList"
                    End If
                    Dim command As New SqlCommand(sql, conn)
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
        Else
            MessageBox.Show("Please select the barcodes to be display.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CmbBarcodeType.Focus()
        End If

    End Sub


End Class
