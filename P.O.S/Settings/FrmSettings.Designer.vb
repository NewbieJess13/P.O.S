<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettings))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PnlContent = New System.Windows.Forms.Panel()
        Me.BtnBarcodePrinter = New System.Windows.Forms.Button()
        Me.BtnCredit = New System.Windows.Forms.Button()
        Me.BtnAppSettings = New System.Windows.Forms.Button()
        Me.BtnEditProfile = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PnlContent)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(191, 89)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(844, 490)
        Me.Panel3.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnBarcodePrinter)
        Me.Panel2.Controls.Add(Me.BtnCredit)
        Me.Panel2.Controls.Add(Me.BtnAppSettings)
        Me.Panel2.Controls.Add(Me.BtnEditProfile)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(191, 490)
        Me.Panel2.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1035, 89)
        Me.Panel1.TabIndex = 3
        '
        'PnlContent
        '
        Me.PnlContent.BackgroundImage = CType(resources.GetObject("PnlContent.BackgroundImage"), System.Drawing.Image)
        Me.PnlContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PnlContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlContent.Location = New System.Drawing.Point(0, 0)
        Me.PnlContent.Name = "PnlContent"
        Me.PnlContent.Size = New System.Drawing.Size(844, 490)
        Me.PnlContent.TabIndex = 22
        '
        'BtnBarcodePrinter
        '
        Me.BtnBarcodePrinter.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnBarcodePrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBarcodePrinter.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBarcodePrinter.Image = Global.P.O.S.My.Resources.Resources.printer_
        Me.BtnBarcodePrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBarcodePrinter.Location = New System.Drawing.Point(0, 273)
        Me.BtnBarcodePrinter.Name = "BtnBarcodePrinter"
        Me.BtnBarcodePrinter.Size = New System.Drawing.Size(191, 63)
        Me.BtnBarcodePrinter.TabIndex = 3
        Me.BtnBarcodePrinter.Text = "Barcode Printer"
        Me.BtnBarcodePrinter.UseVisualStyleBackColor = False
        '
        'BtnCredit
        '
        Me.BtnCredit.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCredit.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCredit.Image = Global.P.O.S.My.Resources.Resources.upload_symbol
        Me.BtnCredit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCredit.Location = New System.Drawing.Point(0, 204)
        Me.BtnCredit.Name = "BtnCredit"
        Me.BtnCredit.Size = New System.Drawing.Size(191, 63)
        Me.BtnCredit.TabIndex = 2
        Me.BtnCredit.Text = "Credit Settings"
        Me.BtnCredit.UseVisualStyleBackColor = False
        '
        'BtnAppSettings
        '
        Me.BtnAppSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnAppSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAppSettings.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAppSettings.Image = Global.P.O.S.My.Resources.Resources.home_delivery_of_goods
        Me.BtnAppSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAppSettings.Location = New System.Drawing.Point(0, 135)
        Me.BtnAppSettings.Name = "BtnAppSettings"
        Me.BtnAppSettings.Size = New System.Drawing.Size(191, 63)
        Me.BtnAppSettings.TabIndex = 1
        Me.BtnAppSettings.Text = "Application Settings"
        Me.BtnAppSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAppSettings.UseVisualStyleBackColor = False
        '
        'BtnEditProfile
        '
        Me.BtnEditProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditProfile.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditProfile.Image = Global.P.O.S.My.Resources.Resources.upload_symbol
        Me.BtnEditProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditProfile.Location = New System.Drawing.Point(0, 66)
        Me.BtnEditProfile.Name = "BtnEditProfile"
        Me.BtnEditProfile.Size = New System.Drawing.Size(191, 63)
        Me.BtnEditProfile.TabIndex = 0
        Me.BtnEditProfile.Text = "Edit Profile"
        Me.BtnEditProfile.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 579)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(1051, 618)
        Me.Name = "FrmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSettings"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlContent As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnAppSettings As Button
    Friend WithEvents BtnEditProfile As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnCredit As Button
    Friend WithEvents BtnBarcodePrinter As Button
End Class
