<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmResOptionFood
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmResOptionFood))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FrmTitle = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtQuan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTotalAmount = New System.Windows.Forms.TextBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FrmTitle)
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 54)
        Me.Panel1.TabIndex = 5
        '
        'FrmTitle
        '
        Me.FrmTitle.AutoSize = True
        Me.FrmTitle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FrmTitle.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrmTitle.ForeColor = System.Drawing.Color.White
        Me.FrmTitle.Location = New System.Drawing.Point(0, 22)
        Me.FrmTitle.Name = "FrmTitle"
        Me.FrmTitle.Size = New System.Drawing.Size(89, 32)
        Me.FrmTitle.TabIndex = 6
        Me.FrmTitle.Text = "{TITLE}"
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(343, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(64, 47)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'TxtDesc
        '
        Me.TxtDesc.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesc.Location = New System.Drawing.Point(12, 117)
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(386, 37)
        Me.TxtDesc.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Quantity"
        '
        'TxtQuan
        '
        Me.TxtQuan.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuan.Location = New System.Drawing.Point(12, 184)
        Me.TxtQuan.Name = "TxtQuan"
        Me.TxtQuan.Size = New System.Drawing.Size(386, 37)
        Me.TxtQuan.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Total amount"
        '
        'TxtTotalAmount
        '
        Me.TxtTotalAmount.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalAmount.Location = New System.Drawing.Point(12, 251)
        Me.TxtTotalAmount.Name = "TxtTotalAmount"
        Me.TxtTotalAmount.Size = New System.Drawing.Size(386, 37)
        Me.TxtTotalAmount.TabIndex = 10
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Image = Global.P.O.S.My.Resources.Resources.delete_shopping_basket
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(217, 294)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(160, 79)
        Me.BtnDelete.TabIndex = 12
        Me.BtnDelete.Text = "CLOSE"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnConfirm
        '
        Me.BtnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirm.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirm.Image = Global.P.O.S.My.Resources.Resources.shopping_cart
        Me.BtnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConfirm.Location = New System.Drawing.Point(39, 294)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(160, 79)
        Me.BtnConfirm.TabIndex = 13
        Me.BtnConfirm.Text = "CONFIRM"
        Me.BtnConfirm.UseVisualStyleBackColor = False
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.Location = New System.Drawing.Point(180, 74)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.DomainUpDown1.TabIndex = 14
        '
        'FrmResOptionFood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(410, 385)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnConfirm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTotalAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtQuan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDesc)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmResOptionFood"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmResOptionFood"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FrmTitle As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtQuan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTotalAmount As TextBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnConfirm As Button
    Friend WithEvents DomainUpDown1 As DomainUpDown
End Class
