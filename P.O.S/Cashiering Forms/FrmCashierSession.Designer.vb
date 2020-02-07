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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblNotification = New System.Windows.Forms.Label()
        Me.LblDateTime = New System.Windows.Forms.Label()
        Me.LblCashier = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGItemList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblTotalRes = New System.Windows.Forms.Label()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnVoidTrans = New System.Windows.Forms.Button()
        Me.BtnVoidItem = New System.Windows.Forms.Button()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnReplenishCash = New System.Windows.Forms.Button()
        Me.BtnEndSession = New System.Windows.Forms.Button()
        Me.BtnPullOutCash = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSnacks = New System.Windows.Forms.Button()
        Me.btnOthers = New System.Windows.Forms.Button()
        Me.btnMeals = New System.Windows.Forms.Button()
        Me.btnBeverages = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.BtnAllowance = New System.Windows.Forms.Button()
        Me.BtnCash = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.DGItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1062, 608)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 576)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1056, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "© Copyright | GAMOSA TECHNOLOGY SOLUTIONS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblNotification)
        Me.Panel1.Controls.Add(Me.LblDateTime)
        Me.Panel1.Controls.Add(Me.LblCashier)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1056, 54)
        Me.Panel1.TabIndex = 1
        '
        'LblNotification
        '
        Me.LblNotification.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblNotification.AutoSize = True
        Me.LblNotification.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNotification.ForeColor = System.Drawing.Color.Brown
        Me.LblNotification.Location = New System.Drawing.Point(949, 36)
        Me.LblNotification.Name = "LblNotification"
        Me.LblNotification.Size = New System.Drawing.Size(0, 15)
        Me.LblNotification.TabIndex = 27
        Me.LblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDateTime
        '
        Me.LblDateTime.Dock = System.Windows.Forms.DockStyle.Right
        Me.LblDateTime.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDateTime.ForeColor = System.Drawing.Color.OrangeRed
        Me.LblDateTime.Location = New System.Drawing.Point(602, 0)
        Me.LblDateTime.Name = "LblDateTime"
        Me.LblDateTime.Size = New System.Drawing.Size(454, 54)
        Me.LblDateTime.TabIndex = 24
        Me.LblDateTime.Text = "{date and time}"
        Me.LblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCashier
        '
        Me.LblCashier.AutoSize = True
        Me.LblCashier.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCashier.ForeColor = System.Drawing.Color.OrangeRed
        Me.LblCashier.Location = New System.Drawing.Point(161, 18)
        Me.LblCashier.Name = "LblCashier"
        Me.LblCashier.Size = New System.Drawing.Size(65, 21)
        Me.LblCashier.TabIndex = 23
        Me.LblCashier.Text = "{name}"
        Me.LblCashier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(79, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 21)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "CASHIER |"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.P.O.S.My.Resources.Resources.logoSGSreport
        Me.PictureBox2.Location = New System.Drawing.Point(12, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(57, 51)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.2944!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.7056!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 63)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1056, 510)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.63736!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel10, 0, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.41046!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.58954!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(311, 498)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.DGItemList, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.LblTotalRes, 0, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.45981!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.54019!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(303, 332)
        Me.TableLayoutPanel6.TabIndex = 7
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Malgun Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGItemList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGItemList.ColumnHeadersHeight = 20
        Me.DGItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGItemList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column7, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Malgun Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGItemList.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGItemList.Location = New System.Drawing.Point(4, 4)
        Me.DGItemList.MultiSelect = False
        Me.DGItemList.Name = "DGItemList"
        Me.DGItemList.ReadOnly = True
        Me.DGItemList.RowHeadersVisible = False
        Me.DGItemList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGItemList.Size = New System.Drawing.Size(295, 281)
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
        'Column7
        '
        Me.Column7.HeaderText = "Selling Price"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
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
        'LblTotalRes
        '
        Me.LblTotalRes.BackColor = System.Drawing.Color.Salmon
        Me.LblTotalRes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTotalRes.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalRes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblTotalRes.Location = New System.Drawing.Point(4, 289)
        Me.LblTotalRes.Name = "LblTotalRes"
        Me.LblTotalRes.Size = New System.Drawing.Size(295, 42)
        Me.LblTotalRes.TabIndex = 3
        Me.LblTotalRes.Text = "0.00"
        Me.LblTotalRes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel10.ColumnCount = 1
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.TableLayoutPanel9, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.TableLayoutPanel8, 0, 0)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(4, 343)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 2
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.74556!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.25444!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(303, 151)
        Me.TableLayoutPanel10.TabIndex = 24
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.BtnVoidTrans, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.BtnVoidItem, 0, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(5, 74)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(293, 72)
        Me.TableLayoutPanel9.TabIndex = 24
        '
        'BtnVoidTrans
        '
        Me.BtnVoidTrans.BackColor = System.Drawing.Color.Gray
        Me.BtnVoidTrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnVoidTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVoidTrans.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoidTrans.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnVoidTrans.Location = New System.Drawing.Point(150, 5)
        Me.BtnVoidTrans.Name = "BtnVoidTrans"
        Me.BtnVoidTrans.Size = New System.Drawing.Size(138, 62)
        Me.BtnVoidTrans.TabIndex = 19
        Me.BtnVoidTrans.Text = "Void transaction"
        Me.BtnVoidTrans.UseVisualStyleBackColor = False
        '
        'BtnVoidItem
        '
        Me.BtnVoidItem.BackColor = System.Drawing.Color.Gray
        Me.BtnVoidItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnVoidItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVoidItem.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoidItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnVoidItem.Location = New System.Drawing.Point(5, 5)
        Me.BtnVoidItem.Name = "BtnVoidItem"
        Me.BtnVoidItem.Size = New System.Drawing.Size(137, 62)
        Me.BtnVoidItem.TabIndex = 18
        Me.BtnVoidItem.Text = "Void Item"
        Me.BtnVoidItem.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel8.ColumnCount = 3
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel8.Controls.Add(Me.BtnReplenishCash, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.BtnEndSession, 2, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.BtnPullOutCash, 1, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(293, 61)
        Me.TableLayoutPanel8.TabIndex = 23
        '
        'BtnReplenishCash
        '
        Me.BtnReplenishCash.BackColor = System.Drawing.Color.Gray
        Me.BtnReplenishCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnReplenishCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReplenishCash.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReplenishCash.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnReplenishCash.Location = New System.Drawing.Point(5, 5)
        Me.BtnReplenishCash.Name = "BtnReplenishCash"
        Me.BtnReplenishCash.Size = New System.Drawing.Size(89, 51)
        Me.BtnReplenishCash.TabIndex = 20
        Me.BtnReplenishCash.Text = "Replenish cash"
        Me.BtnReplenishCash.UseVisualStyleBackColor = False
        '
        'BtnEndSession
        '
        Me.BtnEndSession.BackColor = System.Drawing.Color.Gray
        Me.BtnEndSession.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnEndSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEndSession.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEndSession.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnEndSession.Location = New System.Drawing.Point(199, 5)
        Me.BtnEndSession.Name = "BtnEndSession"
        Me.BtnEndSession.Size = New System.Drawing.Size(89, 51)
        Me.BtnEndSession.TabIndex = 22
        Me.BtnEndSession.Text = "Close session"
        Me.BtnEndSession.UseVisualStyleBackColor = False
        '
        'BtnPullOutCash
        '
        Me.BtnPullOutCash.BackColor = System.Drawing.Color.Gray
        Me.BtnPullOutCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnPullOutCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPullOutCash.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPullOutCash.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnPullOutCash.Location = New System.Drawing.Point(102, 5)
        Me.BtnPullOutCash.Name = "BtnPullOutCash"
        Me.BtnPullOutCash.Size = New System.Drawing.Size(89, 51)
        Me.BtnPullOutCash.TabIndex = 21
        Me.BtnPullOutCash.Text = "Pull out cash"
        Me.BtnPullOutCash.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(326, 6)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(724, 498)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel7.ColumnCount = 4
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.btnSnacks, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnOthers, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnMeals, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnBeverages, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(714, 43)
        Me.TableLayoutPanel7.TabIndex = 1
        '
        'btnSnacks
        '
        Me.btnSnacks.BackColor = System.Drawing.Color.Gray
        Me.btnSnacks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSnacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSnacks.Font = New System.Drawing.Font("Malgun Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSnacks.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSnacks.Location = New System.Drawing.Point(360, 4)
        Me.btnSnacks.Name = "btnSnacks"
        Me.btnSnacks.Size = New System.Drawing.Size(171, 35)
        Me.btnSnacks.TabIndex = 23
        Me.btnSnacks.Text = "SNACKS"
        Me.btnSnacks.UseVisualStyleBackColor = False
        '
        'btnOthers
        '
        Me.btnOthers.BackColor = System.Drawing.Color.Gray
        Me.btnOthers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOthers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOthers.Font = New System.Drawing.Font("Malgun Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOthers.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOthers.Location = New System.Drawing.Point(538, 4)
        Me.btnOthers.Name = "btnOthers"
        Me.btnOthers.Size = New System.Drawing.Size(172, 35)
        Me.btnOthers.TabIndex = 22
        Me.btnOthers.Text = "OTHERS"
        Me.btnOthers.UseVisualStyleBackColor = False
        '
        'btnMeals
        '
        Me.btnMeals.BackColor = System.Drawing.Color.Gray
        Me.btnMeals.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMeals.Font = New System.Drawing.Font("Malgun Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMeals.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMeals.Location = New System.Drawing.Point(4, 4)
        Me.btnMeals.Name = "btnMeals"
        Me.btnMeals.Size = New System.Drawing.Size(171, 35)
        Me.btnMeals.TabIndex = 21
        Me.btnMeals.Text = "MEALS"
        Me.btnMeals.UseVisualStyleBackColor = False
        '
        'btnBeverages
        '
        Me.btnBeverages.BackColor = System.Drawing.Color.Gray
        Me.btnBeverages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBeverages.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBeverages.Font = New System.Drawing.Font("Malgun Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeverages.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBeverages.Location = New System.Drawing.Point(182, 4)
        Me.btnBeverages.Name = "btnBeverages"
        Me.btnBeverages.Size = New System.Drawing.Size(171, 35)
        Me.btnBeverages.TabIndex = 20
        Me.btnBeverages.Text = "BEVERAGES"
        Me.btnBeverages.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel5.ColumnCount = 4
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Button8, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Button7, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.BtnAllowance, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.BtnCash, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(5, 450)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(714, 43)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Silver
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button8.Location = New System.Drawing.Point(360, 4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(171, 35)
        Me.Button8.TabIndex = 25
        Me.Button8.Text = "Load Card"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Silver
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button7.Location = New System.Drawing.Point(538, 4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(172, 35)
        Me.Button7.TabIndex = 24
        Me.Button7.Text = "Via Cashcard"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'BtnAllowance
        '
        Me.BtnAllowance.BackColor = System.Drawing.Color.Silver
        Me.BtnAllowance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnAllowance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAllowance.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAllowance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnAllowance.Location = New System.Drawing.Point(4, 4)
        Me.BtnAllowance.Name = "BtnAllowance"
        Me.BtnAllowance.Size = New System.Drawing.Size(171, 35)
        Me.BtnAllowance.TabIndex = 23
        Me.BtnAllowance.Text = "Via Allowance"
        Me.BtnAllowance.UseVisualStyleBackColor = False
        '
        'BtnCash
        '
        Me.BtnCash.BackColor = System.Drawing.Color.Silver
        Me.BtnCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCash.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCash.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCash.Location = New System.Drawing.Point(182, 4)
        Me.BtnCash.Name = "BtnCash"
        Me.BtnCash.Size = New System.Drawing.Size(171, 35)
        Me.BtnCash.TabIndex = 22
        Me.BtnCash.Text = "Via Cash"
        Me.BtnCash.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(5, 56)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(714, 386)
        Me.FlowLayoutPanel1.TabIndex = 2
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
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(1078, 647)
        Me.Name = "FrmCashierSession"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS - Cashier Session"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        CType(Me.DGItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LblCashier As Label
    Friend WithEvents LblDateTime As Label
    Friend WithEvents LblNotification As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents DGItemList As DataGridView
    Friend WithEvents LblTotalRes As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents BtnEndSession As Button
    Friend WithEvents BtnPullOutCash As Button
    Friend WithEvents BtnReplenishCash As Button
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents BtnVoidTrans As Button
    Friend WithEvents BtnVoidItem As Button
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents btnSnacks As Button
    Friend WithEvents btnOthers As Button
    Friend WithEvents btnMeals As Button
    Friend WithEvents btnBeverages As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents BtnAllowance As Button
    Friend WithEvents BtnCash As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
