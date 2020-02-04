Imports ClassSql
Imports System.Data.SqlClient

Public Class frmLogin


    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        My.Settings.Reload()
    End Sub
    Dim Account_Type As String
    Dim Position As String
    Dim status As String
    Dim CashierSession As String
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        LoginUser()
    End Sub
    Sub LoginUser()

        Dim Login As New LoginCrud
        Dim DT As DataTable = Login.LoginUser(TxtCoopID.Text)
        If DT.Rows.Count > 0 Then
            For Each dr As DataRow In DT.Rows
                My.Settings.FullName = dr(0)
                My.Settings.Username = dr(2)
                Account_Type = dr(4)
                Position = dr(3)
                status = dr(5)
                CashierSession = dr(6)
            Next
            If status <> "1" Then
                If Login.UpdateStatus(TxtCoopID.Text) Then
                    FrmMainMenu.Show()
                End If
            Else
                My.Settings.SessionID = CashierSession
                FrmCashierSession.Show()
            End If
            Hide()
        Else
            MessageBox.Show("Unknown ID!", My.Settings.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        ClearTexts()
    End Sub
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoginUser()
        End If
    End Sub

    Sub ClearTexts()
        TxtCoopID.Clear()
    End Sub
End Class
