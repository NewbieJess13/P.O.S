Public Class UCCreditSet
    Private Sub BtnEditProfile_Click(sender As Object, e As EventArgs) Handles BtnEditProfile.Click
        If MessageBox.Show("Credit limit has been set.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
            My.Settings.Item("CreditLimit") = TxtMskCredit.Text
            My.Settings.Save()
        End If

    End Sub
End Class
