Imports System.Data.SqlClient
Public Class FrmResOptionFood

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        FrmTitle.Text = My.Settings.Title
        TxtQuan.Text = 1
        DomainUpDown1.SelectedItem = 1
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    ' Define the CS_DROPSHADOW constant
    Private Const CS_DROPSHADOW As Integer = 131072

    ' Override the CreateParams property
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get

    End Property


    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub FrmResOptionFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSelectedItem()

        For i As Integer = 1 To 100 Step 1
            DomainUpDown1.Items.Add(i)
        Next
    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click

    End Sub
    Dim sellingprice As Integer
    Sub LoadSelectedItem()
        Using conn As New SqlConnection(My.Settings.ConnectionString)
            conn.Open()
            Dim command As New SqlCommand("SELECT Description,SellingPrice,Category,ItemCode FROM Tbl_Products WHERE id='" & FrmCashierSession_Res.id & "'", conn)
            Dim dt As New DataTable
            Dim DA As New SqlDataAdapter With {
                .SelectCommand = command
            }
            DA.Fill(dt)
            If dt.Rows.Count > 0 Then
                For Each dr As DataRow In dt.Rows
                    TxtDesc.Text = dr(0)
                    TxtTotalAmount.Text = dr(1)
                    sellingprice = dr(1)
                Next
            End If
        End Using
    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs) Handles DomainUpDown1.SelectedItemChanged
        TxtTotalAmount.Text = sender.text * sellingprice
    End Sub
End Class