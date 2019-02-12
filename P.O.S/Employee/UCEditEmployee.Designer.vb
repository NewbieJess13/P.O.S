<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCEditEmployee
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGEmpList = New System.Windows.Forms.DataGridView()
        Me.TxtTotalCredits = New System.Windows.Forms.TextBox()
        Me.TxtStatus = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtSite = New System.Windows.Forms.TextBox()
        Me.TxtPos = New System.Windows.Forms.TextBox()
        Me.TxtBarcode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCoopId = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RchTxtRealBarcode = New System.Windows.Forms.RichTextBox()
        Me.LblId = New System.Windows.Forms.Label()
        Me.LblBarcode = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtFullName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.DGEmpList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.CausesValidation = False
        Me.Panel2.Controls.Add(Me.DGEmpList)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 307)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(924, 224)
        Me.Panel2.TabIndex = 4
        '
        'DGEmpList
        '
        Me.DGEmpList.AllowUserToAddRows = False
        Me.DGEmpList.AllowUserToDeleteRows = False
        Me.DGEmpList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGEmpList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGEmpList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGEmpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGEmpList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGEmpList.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGEmpList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGEmpList.Location = New System.Drawing.Point(0, 0)
        Me.DGEmpList.MultiSelect = False
        Me.DGEmpList.Name = "DGEmpList"
        Me.DGEmpList.ReadOnly = True
        Me.DGEmpList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGEmpList.Size = New System.Drawing.Size(924, 224)
        Me.DGEmpList.TabIndex = 0
        '
        'TxtTotalCredits
        '
        Me.TxtTotalCredits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtTotalCredits.Enabled = False
        Me.TxtTotalCredits.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalCredits.Location = New System.Drawing.Point(696, 69)
        Me.TxtTotalCredits.Name = "TxtTotalCredits"
        Me.TxtTotalCredits.Size = New System.Drawing.Size(225, 33)
        Me.TxtTotalCredits.TabIndex = 12
        '
        'TxtStatus
        '
        Me.TxtStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtStatus.Enabled = False
        Me.TxtStatus.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStatus.Location = New System.Drawing.Point(234, 69)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.Size = New System.Drawing.Size(225, 33)
        Me.TxtStatus.TabIndex = 11
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TxtTotalCredits, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtStatus, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtSite, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtPos, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtBarcode, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtCoopId, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 56)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(924, 100)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TxtSite
        '
        Me.TxtSite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtSite.Enabled = False
        Me.TxtSite.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSite.Location = New System.Drawing.Point(696, 36)
        Me.TxtSite.Name = "TxtSite"
        Me.TxtSite.Size = New System.Drawing.Size(225, 33)
        Me.TxtSite.TabIndex = 10
        '
        'TxtPos
        '
        Me.TxtPos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtPos.Enabled = False
        Me.TxtPos.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPos.Location = New System.Drawing.Point(234, 36)
        Me.TxtPos.Name = "TxtPos"
        Me.TxtPos.Size = New System.Drawing.Size(225, 33)
        Me.TxtPos.TabIndex = 9
        '
        'TxtBarcode
        '
        Me.TxtBarcode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtBarcode.Enabled = False
        Me.TxtBarcode.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBarcode.Location = New System.Drawing.Point(696, 3)
        Me.TxtBarcode.MaxLength = 12
        Me.TxtBarcode.Name = "TxtBarcode"
        Me.TxtBarcode.Size = New System.Drawing.Size(225, 33)
        Me.TxtBarcode.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(225, 34)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "STATUS"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "COOP ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 33)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "POSITION"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(465, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 33)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "SITE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(465, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(225, 33)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "BARCODE"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(465, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(225, 34)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TOTAL CREDITS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtCoopId
        '
        Me.TxtCoopId.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCoopId.Enabled = False
        Me.TxtCoopId.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCoopId.Location = New System.Drawing.Point(234, 3)
        Me.TxtCoopId.Name = "TxtCoopId"
        Me.TxtCoopId.Size = New System.Drawing.Size(225, 33)
        Me.TxtCoopId.TabIndex = 7
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.BtnEdit, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.BtnAdd, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.BtnDelete, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.BtnSave, 3, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 162)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(924, 139)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RchTxtRealBarcode)
        Me.GroupBox1.Controls.Add(Me.LblId)
        Me.GroupBox1.Controls.Add(Me.LblBarcode)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 133)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Barcode"
        '
        'RchTxtRealBarcode
        '
        Me.RchTxtRealBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RchTxtRealBarcode.Location = New System.Drawing.Point(19, 103)
        Me.RchTxtRealBarcode.MaxLength = 13
        Me.RchTxtRealBarcode.Multiline = False
        Me.RchTxtRealBarcode.Name = "RchTxtRealBarcode"
        Me.RchTxtRealBarcode.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RchTxtRealBarcode.Size = New System.Drawing.Size(267, 24)
        Me.RchTxtRealBarcode.TabIndex = 12
        Me.RchTxtRealBarcode.Text = ""
        Me.RchTxtRealBarcode.Visible = False
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(6, 33)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(44, 16)
        Me.LblId.TabIndex = 10
        Me.LblId.Text = "Label9"
        '
        'LblBarcode
        '
        Me.LblBarcode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblBarcode.Font = New System.Drawing.Font("Code EAN13", 44.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.LblBarcode.Location = New System.Drawing.Point(54, 10)
        Me.LblBarcode.Name = "LblBarcode"
        Me.LblBarcode.Size = New System.Drawing.Size(198, 113)
        Me.LblBarcode.TabIndex = 11
        Me.LblBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtFullName, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.34082!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.8839!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(930, 534)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TxtFullName
        '
        Me.TxtFullName.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TxtFullName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtFullName.Enabled = False
        Me.TxtFullName.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFullName.Location = New System.Drawing.Point(3, 3)
        Me.TxtFullName.Name = "TxtFullName"
        Me.TxtFullName.Size = New System.Drawing.Size(924, 53)
        Me.TxtFullName.TabIndex = 5
        Me.TxtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(932, 536)
        Me.Panel1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "COOP ID"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Full Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Position"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Status"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Barcode"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Site"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Total Credits"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "status"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BtnEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEdit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = Global.P.O.S.My.Resources.Resources.resume_2_
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(471, 3)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(150, 133)
        Me.BtnEdit.TabIndex = 1
        Me.BtnEdit.Text = "EDIT"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAdd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Image = Global.P.O.S.My.Resources.Resources.add_contact
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(315, 3)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(150, 133)
        Me.BtnAdd.TabIndex = 3
        Me.BtnAdd.Text = "ADD"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Image = Global.P.O.S.My.Resources.Resources.remove_user
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(783, 3)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(138, 133)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "DELETE"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = Global.P.O.S.My.Resources.Resources.save
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(627, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(150, 133)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'UCEditEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UCEditEmployee"
        Me.Size = New System.Drawing.Size(932, 536)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGEmpList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGEmpList As DataGridView
    Friend WithEvents TxtTotalCredits As TextBox
    Friend WithEvents TxtStatus As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TxtSite As TextBox
    Friend WithEvents TxtPos As TextBox
    Friend WithEvents TxtBarcode As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtCoopId As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents BtnDelete As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtFullName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RchTxtRealBarcode As RichTextBox
    Friend WithEvents LblId As Label
    Friend WithEvents LblBarcode As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
