Public Class FrmItemCode
    Dim ProdCrud As New ProductCrud
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If TxtItemCode.Text <> "" And TxtItemName.Text <> "" Then
            If ProdCrud.InsertItemCode(TxtItemCode.Text, TxtItemName.Text) Then
                MessageBox.Show("Success!", My.Settings.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                TxtItemCode.Clear()
                TxtItemName.Clear()
            End If
        Else
            MessageBox.Show("Empty Fields!", My.Settings.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class