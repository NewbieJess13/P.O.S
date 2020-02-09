Imports System.Data.SqlClient
Imports System.Text

Public Class ProductData
    Friend Property ItemCode As String
    Friend Property Description As String
    Friend Property RetailPrice As String
    Friend Property SellingPrice As String
    Friend Property ItemCount As String
    Friend Property Category As String
    Friend Property Unit As String
    Friend Property isAvailable As String
End Class

Public Class ProductCrud
    Private CP As New ConnectionProperties
    Friend Function InsertItemCode(itemCode As String, ItemName As String) As Boolean
        Dim isSaved As Boolean = True
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("INSERT INTO Tbl_sku ")
                xSQL.AppendLine("(SKU_Code, ")
                xSQL.AppendLine("ItemName) ")
                xSQL.AppendLine("VALUES( ")
                xSQL.AppendLine("@sku, ")
                xSQL.AppendLine("@item)")
                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@sku", itemCode)
                command.Parameters.AddWithValue("@item", ItemName)
                Dim isExecute As Integer = command.ExecuteNonQuery
                If isExecute <> 0 Then isSaved = True
                conn.Close()
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return isSaved
    End Function

    Friend Function PopulateItemCode(Optional itemcode As String = "") As DataTable
        Dim SKUDT As New DataTable
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("SELECT  ")
                xSQL.AppendLine("SKU_Code, ")
                xSQL.AppendLine("ItemName ")
                xSQL.AppendLine("FROM ")
                xSQL.AppendLine("Tbl_SKU ")
                If itemcode <> "" Then
                    xSQL.AppendLine("WHERE SKU_Code = @sku ")
                End If
                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@sku", itemcode)
                Dim DA As New SqlDataAdapter(command)
                Dim DS As New DataSet
                DA.Fill(DS)
                If DS.Tables.Count > 0 Then
                    SKUDT = DS.Tables(0)
                End If
                conn.Close()
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return SKUDT
    End Function
End Class
