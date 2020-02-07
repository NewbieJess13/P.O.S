<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCSetPrinter
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.CmbListPrinters = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSet = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblprinterName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CmbListPrinters
        '
        Me.CmbListPrinters.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbListPrinters.FormattingEnabled = True
        Me.CmbListPrinters.Location = New System.Drawing.Point(3, 55)
        Me.CmbListPrinters.Name = "CmbListPrinters"
        Me.CmbListPrinters.Size = New System.Drawing.Size(452, 29)
        Me.CmbListPrinters.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "List of Installed Printers"
        '
        'BtnSet
        '
        Me.BtnSet.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSet.Location = New System.Drawing.Point(4, 91)
        Me.BtnSet.Name = "BtnSet"
        Me.BtnSet.Size = New System.Drawing.Size(205, 42)
        Me.BtnSet.TabIndex = 2
        Me.BtnSet.Text = "Set"
        Me.BtnSet.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Default printer:"
        '
        'lblprinterName
        '
        Me.lblprinterName.AutoSize = True
        Me.lblprinterName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprinterName.Location = New System.Drawing.Point(129, 160)
        Me.lblprinterName.Name = "lblprinterName"
        Me.lblprinterName.Size = New System.Drawing.Size(119, 19)
        Me.lblprinterName.TabIndex = 4
        Me.lblprinterName.Text = "{printer name}"
        '
        'UCSetPrinter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblprinterName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbListPrinters)
        Me.Name = "UCSetPrinter"
        Me.Size = New System.Drawing.Size(814, 438)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbListPrinters As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSet As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblprinterName As Label
End Class
