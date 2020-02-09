Imports System.Data.SqlClient
Imports System.Text
Public Class CashCardData
    Friend Property id As String
    Friend Property CardID As String
    Friend Property EmpName As String
    Friend Property EmpId As String
    Friend Property Status As String
    Friend Property Creator As String
End Class

Friend Class CashCardCrud
    Dim CP As New ConnectionProperties
    Friend Function InsertCard(CCdata As CashCardData) As Boolean
        Dim isInsert As Boolean = False
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("INSERT INTO Tbl_CashCard ( ")
                xSQL.AppendLine("BarcodeID, ")
                xSQL.AppendLine("EmployeeName, ")
                xSQL.AppendLine("Balance, ")
                xSQL.AppendLine("Status, ")
                xSQL.AppendLine("DateStanp, ")
                xSQL.AppendLine("Createdby, ")
                xSQL.AppendLine("EmployeeID) ")
                xSQL.AppendLine("VALUES ( ")
                xSQL.AppendLine("@BarcodeID, ")
                xSQL.AppendLine("@EmployeeName, ")
                xSQL.AppendLine("@Balance, ")
                xSQL.AppendLine("@Status, ")
                xSQL.AppendLine("@DateStanp, ")
                xSQL.AppendLine("@Createdby, ")
                xSQL.AppendLine("@EmployeeID) ")



            End Using
        Catch ex As Exception

        End Try
    End Function

End Class
