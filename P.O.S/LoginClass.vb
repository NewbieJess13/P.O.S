Imports System.Text
Imports System.Data.SqlClient
Friend Class LoginClassData
    Friend Property id() As String
    Friend Property Full_Name() As String
    Friend Property COOP_Id() As String
    Friend Property UserName() As String
    Friend Property Password() As String
    Friend Property Position() As String
    Friend Property Account_Type() As String
    Friend Property Status() As String
    Friend Property CurrentSessionId() As String
End Class

Friend Class LoginCrud
    Private CP As New ConnectionProperties
    Friend Function LoginUser(CoopID) As DataTable
        Dim LoginDT As New DataTable
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQl As New StringBuilder
                xSQl.AppendLine("SELECT ")
                xSQl.AppendLine("Full_Name, ")
                xSQl.AppendLine("COOP_Id, ")
                xSQl.AppendLine("UserName, ")
                xSQl.AppendLine("Position, ")
                xSQl.AppendLine("Account_Type, ")
                xSQl.AppendLine("Status, ")
                xSQl.AppendLine("CurrentSession ")
                xSQl.AppendLine("FROM Tbl_UserAccounts ")
                xSQl.AppendLine("WHERE COOP_Id = @coopID ")
                Dim cmd As New SqlCommand(xSQl.ToString, conn)
                cmd.Parameters.AddWithValue("@coopID", CoopID)
                Dim DA As New SqlDataAdapter(cmd)
                Dim DS As New DataSet
                DA.Fill(DS)
                If DS.Tables.Count > 0 Then
                    LoginDT = DS.Tables(0)
                End If
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return LoginDT
    End Function

    Friend Function UpdateStatus(coop_ID As String, status As String) As Boolean
        Dim isUpdated As Boolean = False
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQl As New StringBuilder
                xSQl.AppendLine("UPDATE Tbl_UserAccounts SET ")
                xSQl.AppendLine("Status = @status ")
                xSQl.AppendLine("WHERE COOP_id = @coopID ")
                Dim cmd As New SqlCommand(xSQl.ToString, conn)
                cmd.Parameters.AddWithValue("@coopID", coop_ID)
                cmd.Parameters.AddWithValue("@status", status)
                Dim isExecute As Integer = cmd.ExecuteNonQuery
                If isExecute <> 0 Then isUpdated = True
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return isUpdated
    End Function
End Class
