Imports ClassSql
Imports System.Data.SqlClient
Public Class FrmManual
    Dim tbl As DataTable
    Dim ItemCount, ItemCode, Barcode, unit As String
    Dim SellingPrice, Total As Decimal

    Public Event LoadDataToGrid As EventHandler

    Private Sub txtDescrip_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescrip.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectFromProductList()
            TxtQuantity.Enabled = True
            TxtQuantity.Text = 1
        End If
    End Sub

    Private Sub TxtQuantity_TextChanged(sender As Object, e As EventArgs) Handles TxtQuantity.TextChanged
        If TxtQuantity.TextLength > 0 Then
            Total = SellingPrice * Val(TxtQuantity.Text)
            txtAmount.Text = Total
        Else
            txtAmount.Text = SellingPrice
        End If
    End Sub

    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles BtnDone.Click
        Close()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        ReadAllTheRecordInTempTransaction()
        RaiseEvent LoadDataToGrid(Me, e)
    End Sub

    Private Sub FrmManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsSql.connectionString = My.Settings.ConnectionString
        AutoCompleteText()
        ClearTexts()
    End Sub

    Sub ClearTexts()
        SellingPrice = 0
        Total = 0
        txtDescrip.Clear()
        txtAmount.Clear()
        TxtQuantity.Clear()
        ItemCount = ""
        ItemCode = ""
        Barcode = ""
        unit = ""
    End Sub

    Sub AutoCompleteText()
        tbl = MsSql.Table("SELECT * FROM Tbl_Products")
        txtDescrip.AutoCompleteCustomSource.Clear()
        For Each dr As DataRow In tbl.Rows
            txtDescrip.AutoCompleteCustomSource.Add(dr.Item(1).ToString)
        Next
    End Sub

    Sub SelectFromProductList()
        tbl = MsSql.Table("SELECT * FROM Tbl_Products WHERE Description = '" & txtDescrip.Text & "'")
        ItemCode = ""
        ItemCount = ""
        Barcode = ""
        unit = ""
        SellingPrice = 0
        For Each dr As DataRow In tbl.Rows
            SellingPrice = dr.Item(3)
            ItemCode = dr.Item(6)
            Barcode = dr.Item(7)
        Next

        txtAmount.Text = SellingPrice
    End Sub

    Sub InsertIntoTempTransaction()
        If MsSql.ExecuteQuery("INSERT INTO Tbl_TempTransaction (Description,Quantity,TotalAmount,ItemCode,Barcode,SellingPrice) VALUES ('" & txtDescrip.Text & "','" & TxtQuantity.Text & "','" & txtAmount.Text & "','" & ItemCode & "','" & Barcode & "','" & SellingPrice & "')", Nothing) = False Then
            MessageBox.Show("Not Inserted!")
        End If
    End Sub

    Sub ReadAllTheRecordInTempTransaction()
        Try
            Using conn As New SqlConnection(My.Settings.ConnectionString)
                conn.Open()
                Dim command As New SqlCommand("SELECT * FROM Tbl_TempTransaction WHERE Description = @Description", conn)
                command.Parameters.AddWithValue("@Description", txtDescrip.Text)
                Dim DA As New SqlDataAdapter
                Dim DT As New DataTable
                DA.SelectCommand = command
                DA.Fill(DT)
                If DT.Rows.Count > 0 Then
                    'Update the quantity and price record on the temp table
                    UpdateTheSelectedItem()
                Else
                    'Just insert the inputted record to the system
                    InsertIntoTempTransaction()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        ClearTexts()
    End Sub

    Sub UpdateTheSelectedItem()
        Try
            Using conn As New SqlConnection(My.Settings.ConnectionString)
                conn.Open()
                Dim command As New SqlCommand("UPDATE Tbl_TempTransaction SET Quantity += @quantity , TotalAmount += @TotalAmount WHERE Description= @Description ", conn)
                command.Parameters.AddWithValue("@quantity", TxtQuantity.Text)
                command.Parameters.AddWithValue("@TotalAmount", txtAmount.Text)
                command.Parameters.AddWithValue("@Description", txtDescrip.Text)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class