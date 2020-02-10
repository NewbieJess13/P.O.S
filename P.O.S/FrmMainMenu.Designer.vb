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
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.LblTimer = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnCashCard = New System.Windows.Forms.Button()
        Me.BtnProducts = New System.Windows.Forms.Button()
        Me.BtnOpenSession = New System.Windows.Forms.Button()
        Me.BtnReports = New System.Windows.Forms.Button()
        Me.BtnSettings = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnLogout)
        Me.Panel1.Controls.Add(Me.LblTimer)
        Me.Panel1.Controls.Add(Me.LblName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(980, 63)
        Me.Panel1.TabIndex = 0
        '
        'BtnLogout
        '
        Me.BtnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BtnLogout.BackgroundImage = Global.P.O.S.My.Resources.Resources.logout
        Me.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Location = New System.Drawing.Point(927, 20)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(41, 34)
        Me.BtnLogout.TabIndex = 25
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'LblTimer
        '
        Me.LblTimer.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LblTimer.Font = New System.Drawing.Font("PMingLiU-ExtB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblTimer.Location = New System.Drawing.Point(680, 13)
        Me.LblTimer.Name = "LblTimer"
        Me.LblTimer.Size = New System.Drawing.Size(241, 47)
        Me.LblTimer.TabIndex = 24
        Me.LblTimer.Text = "{date and time}"
        Me.LblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblName
        '
        Me.LblName.Font = New System.Drawing.Font("PMingLiU-ExtB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblName.Location = New System.Drawing.Point(176, 13)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(334, 47)
        Me.LblName.TabIndex = 23
        Me.LblName.Text = "{name}"
        Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("PMingLiU-ExtB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(72, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 47)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "CASHIER |"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.P.O.S.My.Resources.Resources.logoSGSreport
        Me.PictureBox2.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 57)
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
        Me.TableLayoutPanel1.Controls.Add(Me.BtnCashCard, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnProducts, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnOpenSession, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnReports, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnSettings, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 63)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(980, 456)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'BtnCashCard
        '
        Me.BtnCashCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCashCard.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnCashCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCashCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.BtnCashCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnCashCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCashCard.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCashCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCashCard.Image = CType(resources.GetObject("BtnCashCard.Image"), System.Drawing.Image)
        Me.BtnCashCard.Location = New System.Drawing.Point(655, 3)
        Me.BtnCashCard.Name = "BtnCashCard"
        Me.BtnCashCard.Size = New System.Drawing.Size(322, 222)
        Me.BtnCashCard.TabIndex = 9
        Me.BtnCashCard.Text = "CASH CARD(F3)"
        Me.BtnCashCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCashCard.UseVisualStyleBackColor = False
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
        Me.BtnProducts.Size = New System.Drawing.Size(320, 222)
        Me.BtnProducts.TabIndex = 8
        Me.BtnProducts.Text = "Products (F2)"
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
        Me.BtnOpenSession.Size = New System.Drawing.Size(320, 222)
        Me.BtnOpenSession.TabIndex = 7
        Me.BtnOpenSession.Text = "Open Session (F1)"
        Me.BtnOpenSession.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnOpenSession.UseVisualStyleBackColor = False
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
        Me.BtnReports.Location = New System.Drawing.Point(3, 231)
        Me.BtnReports.Name = "BtnReports"
        Me.BtnReports.Size = New System.Drawing.Size(320, 222)
        Me.BtnReports.TabIndex = 10
        Me.BtnReports.Text = "Reports (F4)"
        Me.BtnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnReports.UseVisualStyleBackColor = False
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
        Me.BtnSettings.Location = New System.Drawing.Point(329, 231)
        Me.BtnSettings.Name = "BtnSettings"
        Me.BtnSettings.Size = New System.Drawing.Size(320, 222)
        Me.BtnSettings.TabIndex = 12
        Me.BtnSettings.Text = "Settings (F6)"
        Me.BtnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSettings.UseVisualStyleBackColor = False
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
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(996, 597)
        Me.Name = "FrmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS -  Main Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblTimer As Label
    Friend WithEvents LblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnLogout As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnCashCard As Button
    Friend WithEvents BtnProducts As Button
    Friend WithEvents BtnOpenSession As Button
    Friend WithEvents BtnSettings As Button
    Friend WithEvents BtnReports As Button
    Friend WithEvents Timer1 As Timer
End Class
