Public Class FrmCashCard
    Dim _action As String
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        EnableTexts()
    End Sub
    Sub EnableTexts()
        TxtCardID.Enabled = True
        TxtEmpID.Enabled = True
        TxtEmpName.Enabled = True
        RBactive.Enabled = True
        RBInActive.Enabled = True
    End Sub

    Sub DisableTexts()
        TxtCardID.Enabled = False
        TxtEmpID.Enabled = False
        TxtEmpName.Enabled = False
        RBactive.Enabled = False
        RBInActive.Enabled = False

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        DisableTexts()
    End Sub
End Class