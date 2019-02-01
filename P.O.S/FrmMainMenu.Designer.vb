<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMainMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblTimer = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnDelivery = New System.Windows.Forms.Button()
        Me.BtnUploadEmployee = New System.Windows.Forms.Button()
        Me.BtnProducts = New System.Windows.Forms.Button()
        Me.BtnOpenSession = New System.Windows.Forms.Button()
        Me.BtnSettings = New System.Windows.Forms.Button()
        Me.BtnReports = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.LblTimer)
        Me.Panel1.Controls.Add(Me.LblName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(980, 100)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Button1.BackgroundImage = Global.P.O.S.My.Resources.Resources.logout
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(899, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 58)
        Me.Button1.TabIndex = 25
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LblTimer
        '
        Me.LblTimer.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LblTimer.Font = New System.Drawing.Font("PMingLiU-ExtB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimer.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LblTimer.Location = New System.Drawing.Point(631, 23)
        Me.LblTimer.Name = "LblTimer"
        Me.LblTimer.Size = New System.Drawing.Size(241, 47)
        Me.LblTimer.TabIndex = 24
        Me.LblTimer.Text = "{date and time}"
        Me.LblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblName
        '
        Me.LblName.Font = New System.Drawing.Font("PMingLiU-ExtB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LblName.Location = New System.Drawing.Point(395, 23)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(334, 47)
        Me.LblName.TabIndex = 23
        Me.LblName.Text = "{name}"
        Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("PMingLiU-ExtB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(259, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 47)
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
        Me.Panel2.Location = New System.Drawing.Point(0, 519)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(980, 39)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(980, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "© Copyright | GAMOSA TECHNOLOGY SOLUTIONS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnDelivery, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnUploadEmployee, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnProducts, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnOpenSession, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnSettings, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnReports, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 100)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(980, 419)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'BtnDelivery
        '
        Me.BtnDelivery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelivery.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnDelivery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelivery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BtnDelivery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelivery.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelivery.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnDelivery.Image = CType(resources.GetObject("BtnDelivery.Image"), System.Drawing.Image)
        Me.BtnDelivery.Location = New System.Drawing.Point(329, 212)
        Me.BtnDelivery.Name = "BtnDelivery"
        Me.BtnDelivery.Size = New System.Drawing.Size(320, 204)
        Me.BtnDelivery.TabIndex = 11
        Me.BtnDelivery.Text = "Delivery"
        Me.BtnDelivery.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDelivery.UseVisualStyleBackColor = False
        '
        'BtnUploadEmployee
        '
        Me.BtnUploadEmployee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnUploadEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnUploadEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUploadEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BtnUploadEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnUploadEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUploadEmployee.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUploadEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnUploadEmployee.Image = CType(resources.GetObject("BtnUploadEmployee.Image"), System.Drawing.Image)
        Me.BtnUploadEmployee.Location = New System.Drawing.Point(655, 3)
        Me.BtnUploadEmployee.Name = "BtnUploadEmployee"
        Me.BtnUploadEmployee.Size = New System.Drawing.Size(322, 203)
        Me.BtnUploadEmployee.TabIndex = 9
        Me.BtnUploadEmployee.Text = "Upload Employee"
        Me.BtnUploadEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnUploadEmployee.UseVisualStyleBackColor = False
        '
        'BtnProducts
        '
        Me.BtnProducts.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BtnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProducts.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProducts.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnProducts.Image = CType(resources.GetObject("BtnProducts.Image"), System.Drawing.Image)
        Me.BtnProducts.Location = New System.Drawing.Point(329, 3)
        Me.BtnProducts.Name = "BtnProducts"
        Me.BtnProducts.Size = New System.Drawing.Size(320, 203)
        Me.BtnProducts.TabIndex = 8
        Me.BtnProducts.Text = "Products"
        Me.BtnProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnProducts.UseVisualStyleBackColor = False
        '
        'BtnOpenSession
        '
        Me.BtnOpenSession.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpenSession.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnOpenSession.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOpenSession.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BtnOpenSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnOpenSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOpenSession.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpenSession.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnOpenSession.Image = CType(resources.GetObject("BtnOpenSession.Image"), System.Drawing.Image)
        Me.BtnOpenSession.Location = New System.Drawing.Point(3, 3)
        Me.BtnOpenSession.Name = "BtnOpenSession"
        Me.BtnOpenSession.Size = New System.Drawing.Size(320, 203)
        Me.BtnOpenSession.TabIndex = 7
        Me.BtnOpenSession.Text = "Open Session"
        Me.BtnOpenSession.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnOpenSession.UseVisualStyleBackColor = False
        '
        'BtnSettings
        '
        Me.BtnSettings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BtnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSettings.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSettings.Image = CType(resources.GetObject("BtnSettings.Image"), System.Drawing.Image)
        Me.BtnSettings.Location = New System.Drawing.Point(655, 212)
        Me.BtnSettings.Name = "BtnSettings"
        Me.BtnSettings.Size = New System.Drawing.Size(322, 204)
        Me.BtnSettings.TabIndex = 12
        Me.BtnSettings.Text = "Settings"
        Me.BtnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSettings.UseVisualStyleBackColor = False
        '
        'BtnReports
        '
        Me.BtnReports.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BtnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReports.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReports.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnReports.Image = CType(resources.GetObject("BtnReports.Image"), System.Drawing.Image)
        Me.BtnReports.Location = New System.Drawing.Point(3, 212)
        Me.BtnReports.Name = "BtnReports"
        Me.BtnReports.Size = New System.Drawing.Size(320, 204)
        Me.BtnReports.TabIndex = 10
        Me.BtnReports.Text = "Reports"
        Me.BtnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnReports.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'FrmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(980, 558)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(996, 597)
        Me.Name = "FrmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS -  Main Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblTimer As Label
    Friend WithEvents LblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnDelivery As Button
    Friend WithEvents BtnUploadEmployee As Button
    Friend WithEvents BtnProducts As Button
    Friend WithEvents BtnOpenSession As Button
    Friend WithEvents BtnSettings As Button
    Friend WithEvents BtnReports As Button
    Friend WithEvents Timer1 As Timer
End Class
