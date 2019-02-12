<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCheckOut
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.TxtCashTendered = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn = New System.Windows.Forms.Button()
        Me.Btn0 = New System.Windows.Forms.Button()
        Me.Btndot = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtChange = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.61378!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.82255!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.03131!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.32359!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(559, 479)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TxtTotalAmount, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(553, 64)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TxtTotalAmount
        '
        Me.TxtTotalAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtTotalAmount.Enabled = False
        Me.TxtTotalAmount.Font = New System.Drawing.Font("Century Gothic", 30.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalAmount.Location = New System.Drawing.Point(141, 3)
        Me.TxtTotalAmount.Name = "TxtTotalAmount"
        Me.TxtTotalAmount.Size = New System.Drawing.Size(409, 58)
        Me.TxtTotalAmount.TabIndex = 5
        Me.TxtTotalAmount.Text = "1000"
        Me.TxtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 64)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Amount:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnClear, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TxtCashTendered, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 73)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(553, 65)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 65)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cash Tendered:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BtnClear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(456, 3)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(94, 59)
        Me.BtnClear.TabIndex = 3
        Me.BtnClear.Text = "C"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'TxtCashTendered
        '
        Me.TxtCashTendered.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCashTendered.Font = New System.Drawing.Font("Century Gothic", 30.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCashTendered.Location = New System.Drawing.Point(141, 3)
        Me.TxtCashTendered.Name = "TxtCashTendered"
        Me.TxtCashTendered.Size = New System.Drawing.Size(309, 58)
        Me.TxtCashTendered.TabIndex = 4
        Me.TxtCashTendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Controls.Add(Me.Btn, 2, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Btn0, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Btndot, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Btn9, 2, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Btn8, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Btn7, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Btn6, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Btn5, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Btn4, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Btn3, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Btn2, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Btn1, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 216)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(553, 260)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'Btn
        '
        Me.Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn.Location = New System.Drawing.Point(371, 198)
        Me.Btn.Name = "Btn"
        Me.Btn.Size = New System.Drawing.Size(179, 59)
        Me.Btn.TabIndex = 11
        Me.Btn.Text = "Bill Out"
        Me.Btn.UseVisualStyleBackColor = False
        '
        'Btn0
        '
        Me.Btn0.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btn0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn0.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn0.Location = New System.Drawing.Point(187, 198)
        Me.Btn0.Name = "Btn0"
        Me.Btn0.Size = New System.Drawing.Size(178, 59)
        Me.Btn0.TabIndex = 10
        Me.Btn0.Text = "0"
        Me.Btn0.UseVisualStyleBackColor = False
        '
        'Btndot
        '
        Me.Btndot.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btndot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btndot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btndot.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndot.Location = New System.Drawing.Point(3, 198)
        Me.Btndot.Name = "Btndot"
        Me.Btndot.Size = New System.Drawing.Size(178, 59)
        Me.Btndot.TabIndex = 9
        Me.Btndot.Text = "."
        Me.Btndot.UseVisualStyleBackColor = False
        '
        'Btn9
        '
        Me.Btn9.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btn9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn9.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn9.Location = New System.Drawing.Point(371, 133)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(179, 59)
        Me.Btn9.TabIndex = 8
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = False
        '
        'Btn8
        '
        Me.Btn8.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btn8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn8.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn8.Location = New System.Drawing.Point(187, 133)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(178, 59)
        Me.Btn8.TabIndex = 7
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = False
        '
        'Btn7
        '
        Me.Btn7.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btn7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn7.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn7.Location = New System.Drawing.Point(3, 133)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(178, 59)
        Me.Btn7.TabIndex = 6
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = False
        '
        'Btn6
        '
        Me.Btn6.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btn6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn6.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn6.Location = New System.Drawing.Point(371, 68)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(179, 59)
        Me.Btn6.TabIndex = 5
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = False
        '
        'Btn5
        '
        Me.Btn5.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btn5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn5.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn5.Location = New System.Drawing.Point(187, 68)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(178, 59)
        Me.Btn5.TabIndex = 4
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = False
        '
        'Btn4
        '
        Me.Btn4.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btn4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn4.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.Location = New System.Drawing.Point(3, 68)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(178, 59)
        Me.Btn4.TabIndex = 3
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = False
        '
        'Btn3
        '
        Me.Btn3.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btn3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn3.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.Location = New System.Drawing.Point(371, 3)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(179, 59)
        Me.Btn3.TabIndex = 2
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = False
        '
        'Btn2
        '
        Me.Btn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btn2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn2.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.Location = New System.Drawing.Point(187, 3)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(178, 59)
        Me.Btn2.TabIndex = 1
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = False
        '
        'Btn1
        '
        Me.Btn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btn1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn1.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.Location = New System.Drawing.Point(3, 3)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(178, 59)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TxtChange, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 144)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(553, 66)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'TxtChange
        '
        Me.TxtChange.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtChange.Enabled = False
        Me.TxtChange.Font = New System.Drawing.Font("Century Gothic", 30.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtChange.Location = New System.Drawing.Point(141, 3)
        Me.TxtChange.Name = "TxtChange"
        Me.TxtChange.Size = New System.Drawing.Size(409, 58)
        Me.TxtChange.TabIndex = 6
        Me.TxtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 66)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Change:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmCheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(559, 479)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximumSize = New System.Drawing.Size(575, 518)
        Me.MinimumSize = New System.Drawing.Size(575, 518)
        Me.Name = "FrmCheckOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS - Check Out"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnClear As Button
    Friend WithEvents TxtCashTendered As TextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Btn As Button
    Friend WithEvents Btn0 As Button
    Friend WithEvents Btndot As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents Btn7 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents TxtTotalAmount As TextBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TxtChange As TextBox
    Friend WithEvents Label1 As Label
End Class
