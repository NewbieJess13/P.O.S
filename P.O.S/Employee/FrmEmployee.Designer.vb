<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmployee))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PnlContent = New System.Windows.Forms.Panel()
        Me.BtnViewMem = New System.Windows.Forms.Button()
        Me.BtnExport = New System.Windows.Forms.Button()
        Me.BtnUploadMem = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1001, 89)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnViewMem)
        Me.Panel2.Controls.Add(Me.BtnExport)
        Me.Panel2.Controls.Add(Me.BtnUploadMem)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(191, 442)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PnlContent)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(191, 89)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(810, 442)
        Me.Panel3.TabIndex = 2
        '
        'PnlContent
        '
        Me.PnlContent.BackgroundImage = CType(resources.GetObject("PnlContent.BackgroundImage"), System.Drawing.Image)
        Me.PnlContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PnlContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlContent.Location = New System.Drawing.Point(0, 0)
        Me.PnlContent.Name = "PnlContent"
        Me.PnlContent.Size = New System.Drawing.Size(810, 442)
        Me.PnlContent.TabIndex = 22
        '
        'BtnViewMem
        '
        Me.BtnViewMem.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnViewMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnViewMem.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewMem.Image = Global.P.O.S.My.Resources.Resources.group
        Me.BtnViewMem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnViewMem.Location = New System.Drawing.Point(0, 204)
        Me.BtnViewMem.Name = "BtnViewMem"
        Me.BtnViewMem.Size = New System.Drawing.Size(191, 63)
        Me.BtnViewMem.TabIndex = 2
        Me.BtnViewMem.Text = "View Members"
        Me.BtnViewMem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnViewMem.UseVisualStyleBackColor = False
        '
        'BtnExport
        '
        Me.BtnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExport.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExport.Image = Global.P.O.S.My.Resources.Resources.home_delivery_of_goods
        Me.BtnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExport.Location = New System.Drawing.Point(0, 135)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(191, 63)
        Me.BtnExport.TabIndex = 1
        Me.BtnExport.Text = "Export Members"
        Me.BtnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExport.UseVisualStyleBackColor = False
        '
        'BtnUploadMem
        '
        Me.BtnUploadMem.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnUploadMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUploadMem.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUploadMem.Image = Global.P.O.S.My.Resources.Resources.upload_symbol
        Me.BtnUploadMem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUploadMem.Location = New System.Drawing.Point(0, 66)
        Me.BtnUploadMem.Name = "BtnUploadMem"
        Me.BtnUploadMem.Size = New System.Drawing.Size(191, 63)
        Me.BtnUploadMem.TabIndex = 0
        Me.BtnUploadMem.Text = "Upload Member"
        Me.BtnUploadMem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUploadMem.UseVisualStyleBackColor = False
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
        'FrmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1001, 531)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(1017, 570)
        Me.Name = "FrmEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS - Employee "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnUploadMem As Button
    Friend WithEvents BtnViewMem As Button
    Friend WithEvents BtnExport As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PnlContent As Panel
End Class
