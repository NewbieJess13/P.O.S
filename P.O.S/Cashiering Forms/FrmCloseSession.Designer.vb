﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCloseSession
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtNotes = New System.Windows.Forms.TextBox()
        Me.TxtCashAmount = New System.Windows.Forms.TextBox()
        Me.TxtCashierName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBusinessDate = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Btnclose = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TxtNotes, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtCashAmount, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtCashierName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtBusinessDate, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 36)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(713, 250)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'TxtNotes
        '
        Me.TxtNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtNotes.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNotes.Location = New System.Drawing.Point(218, 190)
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.Size = New System.Drawing.Size(491, 57)
        Me.TxtNotes.TabIndex = 10
        '
        'TxtCashAmount
        '
        Me.TxtCashAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCashAmount.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCashAmount.Location = New System.Drawing.Point(218, 128)
        Me.TxtCashAmount.Name = "TxtCashAmount"
        Me.TxtCashAmount.Size = New System.Drawing.Size(491, 57)
        Me.TxtCashAmount.TabIndex = 9
        '
        'TxtCashierName
        '
        Me.TxtCashierName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCashierName.Enabled = False
        Me.TxtCashierName.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCashierName.Location = New System.Drawing.Point(218, 66)
        Me.TxtCashierName.Name = "TxtCashierName"
        Me.TxtCashierName.Size = New System.Drawing.Size(491, 57)
        Me.TxtCashierName.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(207, 62)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "NOTES"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 61)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ENDING CASH"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 61)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CASHIER NAME"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 61)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "BUSINESS DATE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtBusinessDate
        '
        Me.TxtBusinessDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtBusinessDate.Enabled = False
        Me.TxtBusinessDate.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusinessDate.Location = New System.Drawing.Point(218, 4)
        Me.TxtBusinessDate.Name = "TxtBusinessDate"
        Me.TxtBusinessDate.Size = New System.Drawing.Size(491, 57)
        Me.TxtBusinessDate.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 286)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(713, 78)
        Me.Panel1.TabIndex = 7
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnClear, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Btnclose, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnExit, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(713, 78)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'BtnClear
        '
        Me.BtnClear.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnClear.Location = New System.Drawing.Point(237, 0)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(237, 78)
        Me.BtnClear.TabIndex = 30
        Me.BtnClear.Text = "CLEAR"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnclose.Location = New System.Drawing.Point(0, 0)
        Me.Btnclose.Margin = New System.Windows.Forms.Padding(0)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(237, 78)
        Me.Btnclose.TabIndex = 29
        Me.Btnclose.Text = "CLOSE"
        Me.Btnclose.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnExit.Location = New System.Drawing.Point(474, 0)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(239, 78)
        Me.BtnExit.TabIndex = 31
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(713, 36)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CLOSE SESSION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmCloseSession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(713, 364)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(729, 403)
        Me.MinimumSize = New System.Drawing.Size(593, 403)
        Me.Name = "FrmCloseSession"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCloseSession"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TxtNotes As TextBox
    Friend WithEvents TxtCashAmount As TextBox
    Friend WithEvents TxtCashierName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBusinessDate As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnClear As Button
    Friend WithEvents Btnclose As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents Label1 As Label
End Class
