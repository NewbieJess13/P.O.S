<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCashierReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CrystalReportReceipt = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ReceiptReport2 = New P.O.S.ReceiptReport()
        Me.receiptReport1 = New P.O.S.ReceiptReport()
        Me.SuspendLayout()
        '
        'CrystalReportReceipt
        '
        Me.CrystalReportReceipt.ActiveViewIndex = -1
        Me.CrystalReportReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportReceipt.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportReceipt.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportReceipt.Name = "CrystalReportReceipt"
        Me.CrystalReportReceipt.Size = New System.Drawing.Size(948, 553)
        Me.CrystalReportReceipt.TabIndex = 0
        Me.CrystalReportReceipt.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FrmCashierReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 553)
        Me.Controls.Add(Me.CrystalReportReceipt)
        Me.Name = "FrmCashierReport"
        Me.Text = "FrmCashierReport"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents receiptReport1 As ReceiptReport
    Friend WithEvents CrystalReportReceipt As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ReceiptReport2 As ReceiptReport
End Class
