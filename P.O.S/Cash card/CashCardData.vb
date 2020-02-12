Imports System.Data.SqlClient
Imports System.Text
Public Class CashCardData
    Friend Property id As String
    Friend Property CardID As String
    Friend Property EmpName As String
    Friend Property Balance As String
    Friend Property EmpId As String
    Friend Property Status As String
    Friend Property DateStamp As String
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
                xSQL.AppendLine("DateStamp, ")
                xSQL.AppendLine("Createdby, ")
                xSQL.AppendLine("EmployeeID) ")
                xSQL.AppendLine("VALUES ( ")
                xSQL.AppendLine("@BarcodeID, ")
                xSQL.AppendLine("@EmployeeName, ")
                xSQL.AppendLine("@Balance, ")
                xSQL.AppendLine("@Status, ")
                xSQL.AppendLine("@DateStamp, ")
                xSQL.AppendLine("@Createdby, ")
                xSQL.AppendLine("@EmployeeID) ")
                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@BarcodeID", CCdata.CardID)
                command.Parameters.AddWithValue("@EmployeeName", CCdata.EmpName)
                command.Parameters.AddWithValue("@Balance", CCdata.Balance)
                command.Parameters.AddWithValue("@Status", CCdata.Status)
                command.Parameters.AddWithValue("@DateStamp", CCdata.DateStamp)
                command.Parameters.AddWithValue("@Createdby", CCdata.Creator)
                command.Parameters.AddWithValue("@EmployeeID", CCdata.EmpId)
                Dim isExecute As Integer = command.ExecuteNonQuery
                If isExecute <> 0 Then isInsert = True
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return isInsert
    End Function

    Friend Function UpdateCard(CCdata As CashCardData, id As String) As Boolean
        Dim isUpdated As Boolean = False
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("UPDATE Tbl_CashCard SET  ")
                xSQL.AppendLine("BarcodeID = @BarcodeID, ")
                xSQL.AppendLine("EmployeeName = @EmployeeName, ")
                xSQL.AppendLine("Status = @Status, ")
                xSQL.AppendLine("EmployeeID = @EmployeeID ")
                xSQL.AppendLine("WHERE id = @id ")
                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@BarcodeID", CCdata.CardID)
                command.Parameters.AddWithValue("@EmployeeName", CCdata.EmpName)
                command.Parameters.AddWithValue("@Status", CCdata.Status)
                command.Parameters.AddWithValue("@EmployeeID", CCdata.EmpId)
                command.Parameters.AddWithValue("@id", id)
                Dim isExecute As Integer = command.ExecuteNonQuery
                If isExecute <> 0 Then isUpdated = True
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return isUpdated
    End Function

    Friend Function GetCardList() As DataTable
        Dim DTCard As New DataTable
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("SELECT ")
                xSQL.AppendLine("* ")
                xSQL.AppendLine("FROM ")
                xSQL.AppendLine("Tbl_CashCard")
                Dim command As New SqlCommand(xSQL.ToString, conn)
                Dim DA As New SqlDataAdapter(command)
                Dim DS As New DataSet
                DA.Fill(DS)
                If DS.Tables.Count <> 0 Then
                    DTCard = DS.Tables(0)
                End If
                conn.Close()
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return DTCard
    End Function

    Friend Function DeleteCard(id As String) As Boolean
        Dim isUpdated As Boolean = False
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("DELETE FROM Tbl_CashCard WHERE id = @id  ")
                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@id", id)
                Dim isExecute As Integer = command.ExecuteNonQuery
                If isExecute <> 0 Then isUpdated = True
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return isUpdated
    End Function


    Friend Function SearchCardList(empID As String) As DataTable
        Dim DTCard As New DataTable
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("SELECT ")
                xSQL.AppendLine("* ")
                xSQL.AppendLine("FROM ")
                xSQL.AppendLine("Tbl_CashCard ")
                xSQL.AppendLine("WHERE EmployeeID LIKE '%" & empID & "%' ")
                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@empID", empID)
                Dim DA As New SqlDataAdapter(command)
                Dim DS As New DataSet
                DA.Fill(DS)
                If DS.Tables.Count <> 0 Then
                    DTCard = DS.Tables(0)
                End If
                conn.Close()
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return DTCard
    End Function

    Friend Function GetCardInfo(CardID As String) As DataTable
        Dim DTCard As New DataTable
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("SELECT ")
                xSQL.AppendLine("* ")
                xSQL.AppendLine("FROM ")
                xSQL.AppendLine("Tbl_CashCard")
                xSQL.AppendLine("WHERE BarcodeID = @card")
                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@card", CardID)
                Dim DA As New SqlDataAdapter(command)
                Dim DS As New DataSet
                DA.Fill(DS)
                If DS.Tables.Count <> 0 Then
                    DTCard = DS.Tables(0)
                End If
                conn.Close()
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return DTCard
    End Function
End Class
