Imports System.Data.SqlClient
Imports System.Text
Friend Class CashierSessionData
    Friend Property FoodID() As String = ""
    Friend Property Description() As String = ""
    Friend Property RetailPrice() As String = ""
    Friend Property SellingPrice() As String = ""
    Friend Property ItemCount() As String = ""
    Friend Property Quantity() As String = ""
    Friend Property TotalAmount() As String = ""
    Friend Property Category() As String = ""
    Friend Property ItemCode() As String = ""
    Friend Property Barcode() As String = ""
    Friend Property Unit() As String = ""
    Friend Property RealBarcode() As String = ""
    Friend Property ImagePath() As String = ""
    Friend Property SessionID() As String = ""
End Class
Public Class CashierSessionCrud
    Private CP As New ConnectionProperties

    Friend Function PopulateFoodMenu(Filter As String) As DataTable
        Dim FoodMenuDT As New DataTable
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("SELECT ")
                xSQL.AppendLine("id, ")
                xSQL.AppendLine("Description, ")
                xSQL.AppendLine("SellingPrice, ")
                xSQL.AppendLine("ItemCode ")
                xSQL.AppendLine("FROM Tbl_Products ")
                xSQL.AppendLine("WHERE Category=@Filter ")
                xSQL.AppendLine("AND isAvailable = 1 ")
                xSQL.AppendLine("ORDER BY Description ASC")
                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@Filter", Filter)
                Dim DA As New SqlDataAdapter(command)
                Dim DS As New DataSet
                DA.Fill(DS)
                If DS.Tables.Count > 0 Then
                    FoodMenuDT = DS.Tables(0)
                End If

            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return FoodMenuDT
    End Function

    Friend Function SelectedFood(id As String) As DataTable
        Dim DTSelected As New DataTable
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("SELECT ")
                xSQL.AppendLine("id, ")
                xSQL.AppendLine("Description, ")
                xSQL.AppendLine("SellingPrice, ")
                xSQL.AppendLine("Category, ")
                xSQL.AppendLine("ItemCode ")
                xSQL.AppendLine("FROM Tbl_Products ")
                xSQL.AppendLine("WHERE id = @id ")

                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@id", id)
                Dim DA As New SqlDataAdapter(command)
                Dim DS As New DataSet
                DA.Fill(DS)
                If DS.Tables.Count > 0 Then
                    DTSelected = DS.Tables(0)
                End If
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return DTSelected
    End Function

    Friend Function SendToTempTrans(TempTrans As CashierSessionData) As Boolean
        Dim isSent As Boolean = False
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("INSERT INTO ")
                xSQL.AppendLine("Tbl_TempTransaction ")
                xSQL.AppendLine("( ")
                xSQL.AppendLine("Description, ")
                xSQL.AppendLine("Quantity, ")
                xSQL.AppendLine("TotalAmount, ")
                xSQL.AppendLine("ItemCode, ")
                xSQL.AppendLine("SellingPrice, ")
                xSQL.AppendLine("CashierSessionID ")
                xSQL.AppendLine(") VALUES ( ")
                xSQL.AppendLine("@Desc, ")
                xSQL.AppendLine("@Quan, ")
                xSQL.AppendLine("@TotalAmount, ")
                xSQL.AppendLine("@ItemCode, ")
                xSQL.AppendLine("@SellingPrice, ")
                xSQL.AppendLine("@CashierSessionID ")
                xSQL.AppendLine(") ")

                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@Desc", TempTrans.Description)
                command.Parameters.AddWithValue("@Quan", TempTrans.Quantity)
                command.Parameters.AddWithValue("@TotalAmount", TempTrans.TotalAmount)
                command.Parameters.AddWithValue("@ItemCode", TempTrans.ItemCode)
                command.Parameters.AddWithValue("@SellingPrice", TempTrans.SellingPrice)
                command.Parameters.AddWithValue("@CashierSessionID", My.Settings.SessionID)

                Dim isExecute As Integer = command.ExecuteNonQuery
                If isExecute <> 0 Then isSent = True
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return isSent
    End Function

    Friend Function CheckForExistingTempItem(ItemCode As String) As DataTable
        Dim TempItemDT As New DataTable
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("SELECT ")
                xSQL.AppendLine("ItemCode ")
                xSQL.AppendLine("FROM ")
                xSQL.AppendLine("Tbl_TempTransaction ")
                xSQL.AppendLine("WHERE ")
                xSQL.AppendLine("ItemCode = @ItemCode ")
                xSQL.AppendLine("AND ")
                xSQL.AppendLine("CashierSessionID = @SessionID ")

                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@ItemCode", ItemCode)
                command.Parameters.AddWithValue("@SessionID", My.Settings.SessionID)
                Dim DA As New SqlDataAdapter(command)
                Dim DS As New DataSet
                DA.Fill(DS)
                If DS.Tables.Count > 0 Then
                    TempItemDT = DS.Tables(0)
                End If
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return TempItemDT
    End Function

    Friend Function UpdateExistingItem(ItemCode As String, Quantity As Integer, Amount As Integer) As Boolean
        Dim isUpdated As Boolean = False
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("UPDATE Tbl_TempTransaction SET")
                xSQL.AppendLine("Quantity += @quan, ")
                xSQL.AppendLine("TotalAmount += @Amount")
                xSQL.AppendLine("WHERE ItemCode = @ItemCode AND ")
                xSQL.AppendLine("CashierSessionID = @SessionID ")

                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@quan", Quantity)
                command.Parameters.AddWithValue("@Amount", Amount)
                command.Parameters.AddWithValue("@ItemCode", ItemCode)
                command.Parameters.AddWithValue("@SessionID", My.Settings.SessionID)

                Dim isExecute As Integer = command.ExecuteNonQuery
                If isExecute <> 0 Then isUpdated = True

            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return isUpdated
    End Function

    Friend Function LoadSessionItems() As DataTable
        Dim SessionItemsDT As New DataTable
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("SELECT ")
                xSQL.AppendLine("id, ")
                xSQL.AppendLine("Description, ")
                xSQL.AppendLine("Quantity, ")
                xSQL.AppendLine("TotalAmount, ")
                xSQL.AppendLine("ItemCode, ")
                xSQL.AppendLine("SellingPrice ")
                xSQL.AppendLine("FROM ")
                xSQL.AppendLine("Tbl_TempTransaction ")
                xSQL.AppendLine("WHERE ")
                xSQL.AppendLine("CashierSessionID = @SessionID ")

                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@SessionID", My.Settings.SessionID)
                Dim DA As New SqlDataAdapter(command)
                Dim DS As New DataSet
                DA.Fill(DS)
                If DS.Tables.Count > 0 Then
                    SessionItemsDT = DS.Tables(0)
                End If
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return SessionItemsDT
    End Function
End Class


