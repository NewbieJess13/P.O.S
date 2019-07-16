Imports ClassSql
Imports System.Data.SqlClient

Public Class frmLogin
    Dim tbl As New DataTable
    Public Shared user1, pass1 As String
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        My.Settings.Reload()


    End Sub


    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        LoginUser(txtUsername.Text, txtPassword.Text)

    End Sub
    Sub LoginUser(user As String, pass As String)
        If user <> "" And pass <> "" Then
            tbl = MsSql.Table("SELECT * FROM Tbl_UserAccounts WHERE UserName = @userN AND Password = @passW", New String() {user, pass})
            If tbl.Rows.Count > 0 Then
                For Each dr As DataRow In tbl.Rows
                    Lblaccount.Text = dr(6)
                    user1 = dr(3)
                    pass1 = dr(4)
                    My.Settings.FullName = dr(1)
                    My.Settings.Username = user1
                Next
                If txtUsername.Text = user1 AndAlso txtPassword.Text = pass1 Then
                    If MessageBox.Show("Welcome " & Lblaccount.Text, "POS - Login", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                        FrmMainMenu.Show()
                        Hide()
                        ClearTexts()
                    End If
                Else
                    MessageBox.Show("Your Username or Password is either incorrect or unregistered.Try Again", "POS - Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("Your Username or Password is either incorrect or unregistered.Try Again", "POS - Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Please fill up all the required fields", "POS - Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsSql.connectionString = My.Settings.ConnectionString
    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoginUser(txtUsername.Text, txtPassword.Text)
        End If
    End Sub

    Sub ClearTexts()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub



End Class
