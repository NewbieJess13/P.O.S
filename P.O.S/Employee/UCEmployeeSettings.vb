Imports System.Data.SqlClient

Public Class UCEmployeeSettings

    Sub SelectAllEmployee()
        Try
            Using conn As New SqlConnection(My.Settings.ConnectionString)
                conn.Open()
                Dim command As New SqlCommand("SELECT * FROM Tbl_EmployeeList ORDER BY id DESC", conn)
                Dim dt As New DataTable
                Dim DA As New SqlDataAdapter With {
                    .SelectCommand = command
                }
                DA.Fill(dt)
                DGEmpList.Rows.Clear()

                For Each dr As DataRow In dt.Rows
                    DGEmpList.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7), dr(9))
                Next

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UCEmployeeSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SelectAllEmployee()
    End Sub

    Private Sub DGEmpList_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGEmpList.CellFormatting
        For i = 0 To DGEmpList.Rows.Count - 1
            If DGEmpList.Rows(i).Cells(8).Value = 1 Then
                DGEmpList.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(46, 204, 113)
            ElseIf DGEmpList.Rows(i).Cells(8).Value = 0 Then
                DGEmpList.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(231, 76, 60)

            End If
        Next
    End Sub

    Private Sub DGEmpList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGEmpList.CellClick
        Try
            If e.RowIndex >= 0 Or e.ColumnIndex >= 0 Then
                LblId.Text = DGEmpList.Rows(e.RowIndex).Cells(0).Value
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnSetToActive_Click(sender As Object, e As EventArgs) Handles BtnSetToActive.Click
        If LblId.Text <> 0 Then
            SetToActiveStatus()
            MessageBox.Show("Employee is set to Active.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Select employee to change status.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Sub SetToActiveStatus()

        Try
            Using conn As New SqlConnection(My.Settings.ConnectionString)
                conn.Open()
                Dim command As New SqlCommand("UPDATE Tbl_EmployeeList SET EmployeeStatus=@Status WHERE id=@id", conn)
                command.Parameters.AddWithValue("@status", "1")
                command.Parameters.AddWithValue("@id", LblId.Text)
                command.ExecuteNonQuery()
                SelectAllEmployee()
                LblId.Text = 0
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub SetToInactiveStatus()
        Try
            Using conn As New SqlConnection(My.Settings.ConnectionString)
                conn.Open()
                Dim command As New SqlCommand("UPDATE Tbl_EmployeeList SET EmployeeStatus=@Status WHERE id=@id", conn)
                command.Parameters.AddWithValue("@status", "0")
                command.Parameters.AddWithValue("@id", LblId.Text)
                command.ExecuteNonQuery()
                SelectAllEmployee()
                LblId.Text = 0
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnSetInactive_Click(sender As Object, e As EventArgs) Handles BtnSetInactive.Click
        If LblId.Text <> 0 Then
            SetToInactiveStatus()
            MessageBox.Show("Employee is set to Inactive.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Select employee to change status.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
End Class
