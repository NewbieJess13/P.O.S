<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCashierSession
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCashierSession))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblNotification = New System.Windows.Forms.Label()
        Me.LblPrevPrevBarcode = New System.Windows.Forms.Label()
        Me.LblPrevBarcode = New System.Windows.Forms.Label()
        Me.LblDateTime = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LblTotalRes = New System.Windows.Forms.Label()
        Me.DGItemList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnManualInput = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn00 = New System.Windows.Forms.Button()
        Me.BtnTuldok = New System.Windows.Forms.Button()
        Me.BtnVoidTrans = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Btn0 = New System.Windows.Forms.Button()
        Me.BtnVoidItem = New System.Windows.Forms.Button()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.BtnEnter = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnAddToCredits = New System.Windows.Forms.Button()
        Me.BtnCashTendered = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnEndSession = New System.Windows.Forms.Button()
        Me.BtnPullOutCash = New System.Windows.Forms.Button()
        Me.BtnReplenishCash = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TxtBarcode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtQuanProd = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.DGItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblNotification)
        Me.Panel1.Controls.Add(Me.LblPrevPrevBarcode)
        Me.Panel1.Controls.Add(Me.LblPrevBarcode)
        Me.Panel1.Controls.Add(Me.LblDateTime)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1062, 100)
        Me.Panel1.TabIndex = 1
        '
        'LblNotification
        '
        Me.LblNotification.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblNotification.AutoSize = True
        Me.LblNotification.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNotification.ForeColor = System.Drawing.Color.Brown
        Me.LblNotification.Location = New System.Drawing.Point(955, 82)
        Me.LblNotification.Name = "LblNotification"
        Me.LblNotification.Size = New System.Drawing.Size(0, 15)
        Me.LblNotification.TabIndex = 27
        Me.LblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPrevPrevBarcode
        '
        Me.LblPrevPrevBarcode.AutoSize = True
        Me.LblPrevPrevBarcode.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrevPrevBarcode.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LblPrevPrevBarcode.Location = New System.Drawing.Point(366, 78)
        Me.LblPrevPrevBarcode.Name = "LblPrevPrevBarcode"
        Me.LblPrevPrevBarcode.Size = New System.Drawing.Size(101, 15)
        Me.LblPrevPrevBarcode.TabIndex = 26
        Me.LblPrevPrevBarcode.Text = "PrevPrevBarcode"
        Me.LblPrevPrevBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblPrevPrevBarcode.Visible = False
        '
        'LblPrevBarcode
        '
        Me.LblPrevBarcode.AutoSize = True
        Me.LblPrevBarcode.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrevBarcode.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LblPrevBarcode.Location = New System.Drawing.Point(272, 78)
        Me.LblPrevBarcode.Name = "LblPrevBarcode"
        Me.LblPrevBarcode.Size = New System.Drawing.Size(77, 15)
        Me.LblPrevBarcode.TabIndex = 25
        Me.LblPrevBarcode.Text = "PrevBarcode"
        Me.LblPrevBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblPrevBarcode.Visible = False
        '
        'LblDateTime
        '
        Me.LblDateTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDateTime.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDateTime.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LblDateTime.Location = New System.Drawing.Point(635, 39)
        Me.LblDateTime.Name = "LblDateTime"
        Me.LblDateTime.Size = New System.Drawing.Size(424, 23)
        Me.LblDateTime.TabIndex = 24
        Me.LblDateTime.Text = "{date and time}"
        Me.LblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(365, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 23)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "{name}"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(259, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "CASHIER |"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.P.O.S.My.Resources.Resources.horLine
        Me.PictureBox1.Location = New System.Drawing.Point(222, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(204, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 569)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1062, 39)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1062, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "© Copyright | GAMOSA TECHNOLOGY SOLUTIONS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1062, 469)
        Me.Panel3.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1062, 469)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel9)
        Me.Panel4.Controls.Add(Me.DGItemList)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(418, 463)
        Me.Panel4.TabIndex = 0
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.IndianRed
        Me.Panel9.Controls.Add(Me.Label13)
        Me.Panel9.Controls.Add(Me.LblTotalRes)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 418)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(418, 45)
        Me.Panel9.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(155, 45)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "TOTAL"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTotalRes
        '
        Me.LblTotalRes.Dock = System.Windows.Forms.DockStyle.Right
        Me.LblTotalRes.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalRes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblTotalRes.Location = New System.Drawing.Point(85, 0)
        Me.LblTotalRes.Name = "LblTotalRes"
        Me.LblTotalRes.Size = New System.Drawing.Size(333, 45)
        Me.LblTotalRes.TabIndex = 3
        Me.LblTotalRes.Text = "0.00"
        Me.LblTotalRes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DGItemList
        '
        Me.DGItemList.AllowUserToAddRows = False
        Me.DGItemList.AllowUserToDeleteRows = False
        Me.DGItemList.AllowUserToResizeColumns = False
        Me.DGItemList.AllowUserToResizeRows = False
        Me.DGItemList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGItemList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGItemList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGItemList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGItemList.ColumnHeadersHeight = 41
        Me.DGItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGItemList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGItemList.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGItemList.Location = New System.Drawing.Point(3, 0)
        Me.DGItemList.MultiSelect = False
        Me.DGItemList.Name = "DGItemList"
        Me.DGItemList.ReadOnly = True
        Me.DGItemList.RowHeadersVisible = False
        Me.DGItemList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGItemList.Size = New System.Drawing.Size(412, 415)
        Me.DGItemList.TabIndex = 23
        '
        'Column1
        '
        Me.Column1.HeaderText = "id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantity"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column4
        '
        Me.Column4.HeaderText = "Total Amount"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Item Code"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column6
        '
        Me.Column6.HeaderText = "Barcode"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column7
        '
        Me.Column7.HeaderText = "Selling Price"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(427, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(632, 463)
        Me.Panel5.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 43)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(632, 420)
        Me.Panel7.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnManualInput, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel8, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(632, 420)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'BtnManualInput
        '
        Me.BtnManualInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnManualInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnManualInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnManualInput.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManualInput.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnManualInput.Location = New System.Drawing.Point(445, 339)
        Me.BtnManualInput.Name = "BtnManualInput"
        Me.BtnManualInput.Size = New System.Drawing.Size(184, 78)
        Me.BtnManualInput.TabIndex = 23
        Me.BtnManualInput.Text = "MANUAL INPUT"
        Me.BtnManualInput.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.63736!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.45245!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.46342!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.44677!))
        Me.TableLayoutPanel3.Controls.Add(Me.Btn00, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnTuldok, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnVoidTrans, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Btn9, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Btn8, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Btn0, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnVoidItem, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Btn7, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Btn5, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Btn6, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnEnter, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Btn2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Btn1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Btn3, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Btn4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnClear, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(436, 330)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Btn00
        '
        Me.Btn00.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btn00.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn00.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn00.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn00.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Btn00.Location = New System.Drawing.Point(106, 249)
        Me.Btn00.Name = "Btn00"
        Me.Btn00.Size = New System.Drawing.Size(100, 78)
        Me.Btn00.TabIndex = 12
        Me.Btn00.Text = "00"
        Me.Btn00.UseVisualStyleBackColor = False
        '
        'BtnTuldok
        '
        Me.BtnTuldok.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.BtnTuldok.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnTuldok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTuldok.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTuldok.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BtnTuldok.Location = New System.Drawing.Point(212, 249)
        Me.BtnTuldok.Name = "BtnTuldok"
        Me.BtnTuldok.Size = New System.Drawing.Size(100, 78)
        Me.BtnTuldok.TabIndex = 13
        Me.BtnTuldok.Text = "."
        Me.BtnTuldok.UseVisualStyleBackColor = False
        '
        'BtnVoidTrans
        '
        Me.BtnVoidTrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BtnVoidTrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnVoidTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVoidTrans.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoidTrans.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BtnVoidTrans.Location = New System.Drawing.Point(318, 249)
        Me.BtnVoidTrans.Name = "BtnVoidTrans"
        Me.BtnVoidTrans.Size = New System.Drawing.Size(115, 78)
        Me.BtnVoidTrans.TabIndex = 17
        Me.BtnVoidTrans.Text = "VOID TRANSACTION"
        Me.BtnVoidTrans.UseVisualStyleBackColor = False
        '
        'Btn9
        '
        Me.Btn9.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btn9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn9.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn9.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Btn9.Location = New System.Drawing.Point(212, 167)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(100, 76)
        Me.Btn9.TabIndex = 10
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = False
        '
        'Btn8
        '
        Me.Btn8.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btn8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn8.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn8.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Btn8.Location = New System.Drawing.Point(106, 167)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(100, 76)
        Me.Btn8.TabIndex = 9
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = False
        '
        'Btn0
        '
        Me.Btn0.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btn0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn0.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn0.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Btn0.Location = New System.Drawing.Point(3, 249)
        Me.Btn0.Name = "Btn0"
        Me.Btn0.Size = New System.Drawing.Size(97, 78)
        Me.Btn0.TabIndex = 11
        Me.Btn0.Text = "0"
        Me.Btn0.UseVisualStyleBackColor = False
        '
        'BtnVoidItem
        '
        Me.BtnVoidItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BtnVoidItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnVoidItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVoidItem.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoidItem.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BtnVoidItem.Location = New System.Drawing.Point(318, 167)
        Me.BtnVoidItem.Name = "BtnVoidItem"
        Me.BtnVoidItem.Size = New System.Drawing.Size(115, 76)
        Me.BtnVoidItem.TabIndex = 16
        Me.BtnVoidItem.Text = "VOID ITEM"
        Me.BtnVoidItem.UseVisualStyleBackColor = False
        '
        'Btn7
        '
        Me.Btn7.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btn7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn7.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn7.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Btn7.Location = New System.Drawing.Point(3, 167)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(97, 76)
        Me.Btn7.TabIndex = 8
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = False
        '
        'Btn5
        '
        Me.Btn5.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btn5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn5.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn5.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Btn5.Location = New System.Drawing.Point(106, 85)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(100, 76)
        Me.Btn5.TabIndex = 6
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = False
        '
        'Btn6
        '
        Me.Btn6.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btn6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn6.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Btn6.Location = New System.Drawing.Point(212, 85)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(100, 76)
        Me.Btn6.TabIndex = 7
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = False
        '
        'BtnEnter
        '
        Me.BtnEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnEnter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnter.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnter.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BtnEnter.Location = New System.Drawing.Point(318, 85)
        Me.BtnEnter.Name = "BtnEnter"
        Me.BtnEnter.Size = New System.Drawing.Size(115, 76)
        Me.BtnEnter.TabIndex = 15
        Me.BtnEnter.Text = "ENTER"
        Me.BtnEnter.UseVisualStyleBackColor = False
        '
        'Btn2
        '
        Me.Btn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btn2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn2.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Btn2.Location = New System.Drawing.Point(106, 3)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(100, 76)
        Me.Btn2.TabIndex = 3
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = False
        '
        'Btn1
        '
        Me.Btn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Btn1.Location = New System.Drawing.Point(3, 3)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(97, 76)
        Me.Btn1.TabIndex = 2
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = False
        '
        'Btn3
        '
        Me.Btn3.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btn3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn3.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Btn3.Location = New System.Drawing.Point(212, 3)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(100, 76)
        Me.Btn3.TabIndex = 4
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = False
        '
        'Btn4
        '
        Me.Btn4.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Btn4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn4.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Btn4.Location = New System.Drawing.Point(3, 85)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(97, 76)
        Me.Btn4.TabIndex = 5
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BtnClear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BtnClear.Location = New System.Drawing.Point(318, 3)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(115, 76)
        Me.BtnClear.TabIndex = 14
        Me.BtnClear.Text = "C"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.TableLayoutPanel5)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(445, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(184, 330)
        Me.Panel8.TabIndex = 2
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.BtnAddToCredits, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.BtnCashTendered, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(184, 330)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'BtnAddToCredits
        '
        Me.BtnAddToCredits.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.BtnAddToCredits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnAddToCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddToCredits.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddToCredits.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnAddToCredits.Location = New System.Drawing.Point(3, 168)
        Me.BtnAddToCredits.Name = "BtnAddToCredits"
        Me.BtnAddToCredits.Size = New System.Drawing.Size(178, 159)
        Me.BtnAddToCredits.TabIndex = 19
        Me.BtnAddToCredits.Text = "ADD TO CREDITS"
        Me.BtnAddToCredits.UseVisualStyleBackColor = False
        '
        'BtnCashTendered
        '
        Me.BtnCashTendered.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.BtnCashTendered.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnCashTendered.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCashTendered.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCashTendered.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCashTendered.Location = New System.Drawing.Point(3, 3)
        Me.BtnCashTendered.Name = "BtnCashTendered"
        Me.BtnCashTendered.Size = New System.Drawing.Size(178, 159)
        Me.BtnCashTendered.TabIndex = 18
        Me.BtnCashTendered.Text = "CHECK OUT"
        Me.BtnCashTendered.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Controls.Add(Me.BtnEndSession, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.BtnPullOutCash, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.BtnReplenishCash, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 339)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(436, 78)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'BtnEndSession
        '
        Me.BtnEndSession.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.BtnEndSession.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnEndSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEndSession.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEndSession.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnEndSession.Location = New System.Drawing.Point(293, 3)
        Me.BtnEndSession.Name = "BtnEndSession"
        Me.BtnEndSession.Size = New System.Drawing.Size(140, 72)
        Me.BtnEndSession.TabIndex = 22
        Me.BtnEndSession.Text = "CLOSE SESSION"
        Me.BtnEndSession.UseVisualStyleBackColor = False
        '
        'BtnPullOutCash
        '
        Me.BtnPullOutCash.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.BtnPullOutCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnPullOutCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPullOutCash.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPullOutCash.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnPullOutCash.Location = New System.Drawing.Point(148, 3)
        Me.BtnPullOutCash.Name = "BtnPullOutCash"
        Me.BtnPullOutCash.Size = New System.Drawing.Size(139, 72)
        Me.BtnPullOutCash.TabIndex = 21
        Me.BtnPullOutCash.Text = "PULL OUT CASH"
        Me.BtnPullOutCash.UseVisualStyleBackColor = False
        '
        'BtnReplenishCash
        '
        Me.BtnReplenishCash.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.BtnReplenishCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnReplenishCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReplenishCash.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReplenishCash.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnReplenishCash.Location = New System.Drawing.Point(3, 3)
        Me.BtnReplenishCash.Name = "BtnReplenishCash"
        Me.BtnReplenishCash.Size = New System.Drawing.Size(139, 72)
        Me.BtnReplenishCash.TabIndex = 20
        Me.BtnReplenishCash.Text = "REPLENISH CASH"
        Me.BtnReplenishCash.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.TxtBarcode)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.TxtQuanProd)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(632, 43)
        Me.Panel6.TabIndex = 0
        '
        'TxtBarcode
        '
        Me.TxtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBarcode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtBarcode.Font = New System.Drawing.Font("Century Gothic", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBarcode.Location = New System.Drawing.Point(208, 0)
        Me.TxtBarcode.MaxLength = 13
        Me.TxtBarcode.Name = "TxtBarcode"
        Me.TxtBarcode.Size = New System.Drawing.Size(424, 41)
        Me.TxtBarcode.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(163, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 43)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "X"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtQuanProd
        '
        Me.TxtQuanProd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtQuanProd.Dock = System.Windows.Forms.DockStyle.Left
        Me.TxtQuanProd.Font = New System.Drawing.Font("Century Gothic", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuanProd.Location = New System.Drawing.Point(0, 0)
        Me.TxtQuanProd.Name = "TxtQuanProd"
        Me.TxtQuanProd.Size = New System.Drawing.Size(163, 41)
        Me.TxtQuanProd.TabIndex = 1
        Me.TxtQuanProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Timer1
        '
        '
        'FrmCashierSession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1062, 608)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(1078, 647)
        Me.Name = "FrmCashierSession"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS - Cashier Session"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.DGItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblDateTime As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents LblTotalRes As Label
    Friend WithEvents DGItemList As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TxtBarcode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtQuanProd As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Btn00 As Button
    Friend WithEvents BtnTuldok As Button
    Friend WithEvents BtnVoidTrans As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents Btn0 As Button
    Friend WithEvents BtnVoidItem As Button
    Friend WithEvents Btn7 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents BtnEnter As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents BtnAddToCredits As Button
    Friend WithEvents BtnCashTendered As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents BtnEndSession As Button
    Friend WithEvents BtnPullOutCash As Button
    Friend WithEvents BtnReplenishCash As Button
    Friend WithEvents BtnManualInput As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents LblPrevBarcode As Label
    Friend WithEvents LblPrevPrevBarcode As Label
    Friend WithEvents LblNotification As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
