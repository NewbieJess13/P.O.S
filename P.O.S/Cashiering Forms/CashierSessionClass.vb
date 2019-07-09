Imports System.Data.SqlClient
Imports System.Text
Friend Class CashierSessionData
    Friend Property FoodID() As String = ""
    Friend Property Description() As String = ""
    Friend Property RetailPrice() As String = ""
    Friend Property SellingPrice() As String = ""
    Friend Property ItemCount() As String = ""
    Friend Property Category() As String = ""
    Friend Property ItemCode() As String = ""
    Friend Property Barcode() As String = ""
    Friend Property Unit() As String = ""
    Friend Property RealBarcode() As String = ""
    Friend Property ImagePath() As String = ""
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
                xSQL.AppendLine("Category, ")
                xSQL.AppendLine("ItemCode, ")
                xSQL.AppendLine("RealBarcode, ")
                xSQL.AppendLine("ImagePath ")
                xSQL.AppendLine("FROM Tbl_Products   ")
                If Filter = "MEALS" Then
                    xSQL.AppendLine("WHERE Category=@Filter ")
                ElseIf Filter = "DRINKS" Then
                    xSQL.AppendLine("WHERE Category=@Filter ")
                ElseIf Filter = "SNACKS" Then
                    xSQL.AppendLine("WHERE Category=@Filter ")
                End If


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
                xSQL.AppendLine("ItemCode, ")
                xSQL.AppendLine("RealBarcode, ")
                xSQL.AppendLine("ImagePath ")
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
End Class


