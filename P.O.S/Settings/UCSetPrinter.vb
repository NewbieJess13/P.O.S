Public Class UCSetPrinter
    Private Sub UCSetPrinter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblprinterName.Text = My.Settings.PrinterName
        For Each strPrinterName As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            CmbListPrinters.Items.Add(strPrinterName)

            CmbListPrinters.DropDownStyle = ComboBoxStyle.DropDownList
            CmbListPrinters.SelectedIndex = 0
        Next
    End Sub

    Private Sub BtnSet_Click(sender As Object, e As EventArgs) Handles BtnSet.Click
        My.Settings.PrinterName = CmbListPrinters.Text
        My.Settings.Save()
        lblprinterName.Text = My.Settings.PrinterName
    End Sub
End Class
