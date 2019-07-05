Imports System.Data.SqlClient
Imports System.Text
Friend Class InventoryData
    Friend Property ItemID() As String = ""
    Friend Property ItemName() As String = ""
    Friend Property Quantity() As String = ""

    Friend Property Supplier() As String = ""
    Friend Property Status() As String = ""
End Class
Public Class InventoryCrud
    Private CP As New ConnectionProperties
    Friend Function GetInventoryList(Optional InvenID As String = "") As DataTable
        Dim DTInventory As New DataTable
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("SELECT ")
                xSQL.AppendLine("id, ")
                xSQL.AppendLine("ItemName, ")
                xSQL.AppendLine("Quantity, ")
                xSQL.AppendLine("Supplier, ")
                xSQL.AppendLine("Status ")
                xSQL.AppendLine("FROM ")
                xSQL.AppendLine("Tbl_Inventory")

                Dim command As New SqlCommand(xSQL.ToString, conn)
                Dim DA As New SqlDataAdapter(command)
                Dim DS As New DataSet
                DA.Fill(DS)
                If DS.Tables.Count <> 0 Then
                    DTInventory = DS.Tables(0)
                End If
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return DTInventory
    End Function

    Friend Function InsertInventory(ByVal InvData As InventoryData) As Boolean
        Dim isInvAdded As Boolean = False
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("INSERT INTO Tbl_Inventory ")
                xSQL.AppendLine("( ")
                xSQL.AppendLine("ItemName, ")
                xSQL.AppendLine("Quantity, ")
                xSQL.AppendLine("Supplier, ")
                xSQL.AppendLine("Status ")
                xSQL.AppendLine(") ")
                xSQL.AppendLine("VALUES")
                xSQL.AppendLine("( ")
                xSQL.AppendLine("@Item, ")
                xSQL.AppendLine("@Quan, ")
                xSQL.AppendLine("@Supplier, ")
                xSQL.AppendLine("@Status ")
                xSQL.AppendLine(") ")

                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@Item", InvData.ItemName)
                command.Parameters.AddWithValue("@Quan", InvData.Quantity)
                command.Parameters.AddWithValue("@Supplier", InvData.Supplier)
                command.Parameters.AddWithValue("@Status", InvData.Status)
                Dim isExecute As Integer = command.ExecuteNonQuery
                If isExecute <> 0 Then isInvAdded = True
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return isInvAdded
    End Function

    Friend Function EditInventory(ByVal InvData As InventoryData) As Boolean
        Dim isInvEdited As Boolean = False
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("UPDATE Tbl_Inventory SET ")
                xSQL.AppendLine("ItemName = @Item, ")
                xSQL.AppendLine("Quantity = @Quan, ")
                xSQL.AppendLine("Supplier = @Supp, ")
                xSQL.AppendLine("Status = @Status ")
                xSQL.AppendLine("WHERE id = @id")
                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@id", InvData.ItemID)
                command.Parameters.AddWithValue("@Item", InvData.ItemName)
                command.Parameters.AddWithValue("@Quan", InvData.Quantity)
                command.Parameters.AddWithValue("@Supp", InvData.Supplier)
                command.Parameters.AddWithValue("@Status", InvData.Status)
                Dim isExecute As Integer = command.ExecuteNonQuery
                If isExecute <> 0 Then isInvEdited = True
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return isInvEdited
    End Function

    Friend Function DeleteInventory(ByVal ItemId As String) As Boolean
        Dim IsInvDeleted As Boolean = False
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("DELETE FROM ")
                xSQL.AppendLine("Tbl_Inventory ")
                xSQL.AppendLine("WHERE ")
                xSQL.AppendLine("id = @id")
                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@id", ItemId)
                Dim isExecute As Integer = command.ExecuteNonQuery
                If isExecute <> 0 Then IsInvDeleted = True
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return IsInvDeleted
    End Function
End Class
