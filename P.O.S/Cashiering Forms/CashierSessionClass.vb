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

Friend Class CashierTransData
    Friend Property TransactionNo As String
    Friend Property TransDate() As String = ""
    Friend Property TransTime As String
    Friend Property TableNum As String = ""
    Friend Property Cashier As String
    Friend Property PurchasedAmount As String
    Friend Property PaymentMethod As String = ""
    Friend Property CashTendered As String
    Friend Property Change As String = ""
    Friend Property TransactionType As String
    Friend Property DateFiltered As String = ""
    Friend Property TransRawNo As String
    Friend Property CashBalance As String = ""
    Friend Property SessionID As String


End Class

Friend Class CaptureTransData
    Friend Property EmployeeID As String
    Friend Property AvailableBalance As String
    Friend Property PurchasedList As String
    Friend Property PurchasedAmount As String
    Friend Property CashierName As String
    Friend Property ReceiptNo As String
    Friend Property TransactionDate As String
    Friend Property CanteenCode As String
    Friend Property RegAllowance As String
    Friend Property SpeAllowance As String
    Friend Property CostCenterCode As String
    Friend Property PrevRegAllowance As String
    Friend Property PrevSpeAllowance As String
    Friend Property errorCode As String
    Friend Property DateFormat As String
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
                conn.Close()
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
                xSQL.AppendLine("SellingPrice, ")
                xSQL.AppendLine("Description, ")
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
                conn.Close()
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
                conn.Close()
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
                conn.Close()
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
                conn.Close()
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
                xSQL.AppendLine("CashierSessionID = @SessionID  ")

                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@SessionID", My.Settings.SessionID)
                Dim DA As New SqlDataAdapter(command)
                Dim DS As New DataSet
                DA.Fill(DS)
                If DS.Tables.Count > 0 Then
                    SessionItemsDT = DS.Tables(0)
                End If
                conn.Close()
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return SessionItemsDT
    End Function

    Friend Function ConfirmBillOut(CSData As CashierTransData) As Boolean
        Dim isExe As Boolean = False
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQl As New StringBuilder
                xSQl.AppendLine("EXEC CreateTransactionNo @TransDate,@TransTime,@Cashier,@TotalAmount,@PaymentMethod,@CashTendered,@Change,@TransactionType,@CashBalance,@SessionID ")
                Dim command As New SqlCommand(xSQl.ToString, conn)
                command.Parameters.AddWithValue("@TransDate", Date.Now.ToString("yyyy.MM.dd"))
                command.Parameters.AddWithValue("@TransTime", Date.Now.ToString("hh:mm:ss"))
                command.Parameters.AddWithValue("@Cashier", My.Settings.FullName)
                command.Parameters.AddWithValue("@TotalAmount", CSData.PurchasedAmount)
                command.Parameters.AddWithValue("@PaymentMethod", CSData.PaymentMethod)
                command.Parameters.AddWithValue("@CashTendered", CSData.CashTendered)
                command.Parameters.AddWithValue("@Change", CSData.Change)
                command.Parameters.AddWithValue("@TransactionType", CSData.TransactionType)
                command.Parameters.AddWithValue("@CashBalance", CSData.CashBalance)
                command.Parameters.AddWithValue("@SessionID", My.Settings.SessionID)
                Dim isExecute As Integer = command.ExecuteNonQuery
                If isExecute <> 0 Then isExe = True
                conn.Close()
            End Using

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return isExe
    End Function

    Friend Function InsertIntoItems() As Boolean
        Dim isExe As Boolean = False
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQl As New StringBuilder
                xSQl.AppendLine("EXEC InsertIntoTransactItems @SessionID,@Cashier ")
                Dim command As New SqlCommand(xSQl.ToString, conn)
                command.Parameters.AddWithValue("@SessionID", My.Settings.SessionID)
                command.Parameters.AddWithValue("@Cashier", My.Settings.FullName)

                Dim isExecute As Integer = command.ExecuteNonQuery
                If isExecute <> 0 Then isExe = True
                conn.Close()
            End Using

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return isExe
    End Function

    Friend Function GetTransactionNo() As DataTable
        Dim TransNoDT As New DataTable
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("SELECT TOP 1 ")
                xSQL.AppendLine("TransactionNo ")
                xSQL.AppendLine("FROM ")
                xSQL.AppendLine("Tbl_TransactionHeader ")
                xSQL.AppendLine("WHERE ")
                xSQL.AppendLine("SessionID = @SessionID  ")
                xSQL.AppendLine("AND Cashier = @Cashier  ")
                xSQL.AppendLine("ORDER BY id DESC  ")
                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@SessionID", My.Settings.SessionID)
                command.Parameters.AddWithValue("@Cashier", My.Settings.FullName)
                Dim DA As New SqlDataAdapter(command)
                Dim DS As New DataSet
                DA.Fill(DS)
                If DS.Tables.Count > 0 Then
                    TransNoDT = DS.Tables(0)
                End If
                conn.Close()
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return TransNoDT
    End Function

    Friend Function SaveCaptureTrans(CTdata As CaptureTransData) As Boolean
        Dim isSent As Boolean = False
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("INSERT INTO ")
                xSQL.AppendLine("Tbl_CaptureTrans ")
                xSQL.AppendLine("( ")
                xSQL.AppendLine("EmployeeID, ")
                xSQL.AppendLine("AvailableBal, ")
                xSQL.AppendLine("PurchasedList, ")
                xSQL.AppendLine("PurchasedAmount, ")
                xSQL.AppendLine("CashierName, ")
                xSQL.AppendLine("ReceiptNo, ")
                xSQL.AppendLine("TransactionDate, ")
                xSQL.AppendLine("CanteenCode, ")
                xSQL.AppendLine("RegAllowanceBalance, ")
                xSQL.AppendLine("SpeAllowanceBalance, ")
                xSQL.AppendLine("CostCenterCode, ")
                xSQL.AppendLine("PrevRegBalance, ")
                xSQL.AppendLine("PrevSpeBalance, ")
                xSQL.AppendLine("errorCode, ")
                xSQL.AppendLine("DateFormat ")
                xSQL.AppendLine(") VALUES ( ")
                xSQL.AppendLine("@EmpID, ")
                xSQL.AppendLine("@AvailableBal, ")
                xSQL.AppendLine("@PurchasedList, ")
                xSQL.AppendLine("@PurchaseAmount, ")
                xSQL.AppendLine("@CashierName, ")
                xSQL.AppendLine("@ReceiptNo, ")
                xSQL.AppendLine("@Transdate, ")
                xSQL.AppendLine("@CanteenCode, ")
                xSQL.AppendLine("@RegAllowance, ")
                xSQL.AppendLine("@SpeAllowance, ")
                xSQL.AppendLine("@CostCenterCode, ")
                xSQL.AppendLine("@PrevRegAllowance, ")
                xSQL.AppendLine("@PrevSpeAllowance, ")
                xSQL.AppendLine("@errorCode, ")
                xSQL.AppendLine("@dateFormat, ")
                xSQL.AppendLine(") ")
                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@EmpID", CTdata.EmployeeID)
                command.Parameters.AddWithValue("@AvailableBal", CTdata.AvailableBalance)
                command.Parameters.AddWithValue("@PurchasedList", CTdata.PurchasedList)
                command.Parameters.AddWithValue("@PurchaseAmount", CTdata.PurchasedAmount)
                command.Parameters.AddWithValue("@CashierName", My.Settings.FullName)
                command.Parameters.AddWithValue("@ReceiptNo", CTdata.ReceiptNo)
                command.Parameters.AddWithValue("@Transdate", CTdata.TransactionDate)
                command.Parameters.AddWithValue("@CanteenCode", CTdata.CanteenCode)
                command.Parameters.AddWithValue("@RegAllowance", CTdata.RegAllowance)
                command.Parameters.AddWithValue("@SpeAllowance", CTdata.SpeAllowance)
                command.Parameters.AddWithValue("@CostCenterCode", CTdata.CostCenterCode)
                command.Parameters.AddWithValue("@PrevRegAllowance", CTdata.PrevRegAllowance)
                command.Parameters.AddWithValue("@PrevSpeAllowance", CTdata.PrevSpeAllowance)
                command.Parameters.AddWithValue("@errorCode", CTdata.errorCode)
                command.Parameters.AddWithValue("@dateFormat", Date.Now.ToString("yyyy.MM.dd"))
                Dim isExecute As Integer = command.ExecuteNonQuery
                If isExecute <> 0 Then isSent = True
                conn.Close()
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return isSent
    End Function


    Friend Function GetReport(transno As String) As DataTable
        Dim ReportDT As New DataTable
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("SELECT * ")
                xSQL.AppendLine("FROM ")
                xSQL.AppendLine("ViewReceiptReport ")
                xSQL.AppendLine("WHERE ")
                xSQL.AppendLine("CashierSessionID = @SessionID  ")
                xSQL.AppendLine(" AND TransactionNo = @TransNo ")
                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@SessionID", My.Settings.SessionID)
                command.Parameters.AddWithValue("@TransNo", transno)
                Dim DA As New SqlDataAdapter(command)
                Dim DS As New DataSet
                DA.Fill(DS)
                If DS.Tables.Count > 0 Then
                    ReportDT = DS.Tables(0)
                End If
                conn.Close()
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return ReportDT
    End Function

    Friend Function DeleteItems(Optional id As String = "") As Boolean
        Dim isremoved As Boolean = False
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQl As New StringBuilder
                xSQl.AppendLine("DELETE FROM Tbl_TempTransaction ")
                xSQl.AppendLine("WHERE CashierSessionID = @session ")
                If id <> "" Then
                    xSQl.AppendLine("AND id = @id ")
                End If
                Dim command As New SqlCommand(xSQl.ToString, conn)
                command.Parameters.AddWithValue("@session", My.Settings.SessionID)
                command.Parameters.AddWithValue("@id", id)
                Dim isExecute As Integer = command.ExecuteNonQuery
                If isExecute <> 0 Then isremoved = True
                conn.Close()
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return isremoved
    End Function

    Friend Function InsertSession(SesData As SessionData) As Boolean
        Dim isSent As Boolean = False
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("INSERT INTO ")
                xSQL.AppendLine("Tbl_CashierSession ")
                xSQL.AppendLine("( ")
                xSQL.AppendLine("TransactionNo, ")
                xSQL.AppendLine("SessionId, ")
                xSQL.AppendLine("xDatexTime, ")
                xSQL.AppendLine("CashAmount, ")
                xSQL.AppendLine("Notes, ")
                xSQL.AppendLine("xTransaction, ")
                xSQL.AppendLine("SessionUser ")
                xSQL.AppendLine(") VALUES ( ")
                xSQL.AppendLine("@TransactionNo, ")
                xSQL.AppendLine("@SessionId, ")
                xSQL.AppendLine("@xDatexTime, ")
                xSQL.AppendLine("@CashAmount, ")
                xSQL.AppendLine("@Notes, ")
                xSQL.AppendLine("@xTransaction, ")
                xSQL.AppendLine("@SessionUser ")
                xSQL.AppendLine(") ")
                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@TransactionNo", SesData.TransactionNo)
                command.Parameters.AddWithValue("@SessionId", SesData.SessionID)
                command.Parameters.AddWithValue("@xDatexTime", SesData.DateTime)
                command.Parameters.AddWithValue("@CashAmount", SesData.CashAmount)
                command.Parameters.AddWithValue("@Notes", SesData.Notes)
                command.Parameters.AddWithValue("@xTransaction", SesData.xTransaction)
                command.Parameters.AddWithValue("@SessionUser", SesData.SessionUser)
                Dim isExecute As Integer = command.ExecuteNonQuery
                If isExecute <> 0 Then isSent = True
                conn.Close()
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return isSent
    End Function

    Friend Function GetTransSession() As DataTable
        Dim ReportDT As New DataTable
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("SELECT TOP 1 TransactionNo FROM Tbl_CashierSession ORDER BY id DESC")
                Dim command As New SqlCommand(xSQL.ToString, conn)
                Dim DA As New SqlDataAdapter(command)
                Dim DS As New DataSet
                DA.Fill(DS)
                If DS.Tables.Count > 0 Then
                    ReportDT = DS.Tables(0)
                End If
                conn.Close()
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return ReportDT
    End Function

    Friend Function UpdateSessionAcct(session As String) As Boolean
        Dim isUpdated As Boolean = False
        Try
            Using conn As New SqlConnection(CP.ConnectionString)
                conn.Open()
                Dim xSQL As New StringBuilder
                xSQL.AppendLine("UPDATE Tbl_UserAccounts SET ")
                xSQL.AppendLine("CurrentSession = @session ")
                xSQL.AppendLine("WHERE COOP_id = @id  ")
                Dim command As New SqlCommand(xSQL.ToString, conn)
                command.Parameters.AddWithValue("@session", session)
                command.Parameters.AddWithValue("@id", My.Settings.UserID)
                Dim isExecute As Integer = command.ExecuteNonQuery
                If isExecute <> 0 Then isUpdated = True
                conn.Close()
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return isUpdated
    End Function
End Class


