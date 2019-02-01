<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCCreditSet
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMskCredit = New System.Windows.Forms.MaskedTextBox()
        Me.BtnEditProfile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Credit Limit"
        '
        'TxtMskCredit
        '
        Me.TxtMskCredit.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMskCredit.Location = New System.Drawing.Point(21, 74)
        Me.TxtMskCredit.Mask = "000000.00"
        Me.TxtMskCredit.Name = "TxtMskCredit"
        Me.TxtMskCredit.Size = New System.Drawing.Size(592, 53)
        Me.TxtMskCredit.TabIndex = 1
        '
        'BtnEditProfile
        '
        Me.BtnEditProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BtnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditProfile.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditProfile.Location = New System.Drawing.Point(21, 155)
        Me.BtnEditProfile.Name = "BtnEditProfile"
        Me.BtnEditProfile.Size = New System.Drawing.Size(191, 63)
        Me.BtnEditProfile.TabIndex = 2
        Me.BtnEditProfile.Text = "SET"
        Me.BtnEditProfile.UseVisualStyleBackColor = False
        '
        'UCCreditSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnEditProfile)
        Me.Controls.Add(Me.TxtMskCredit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UCCreditSet"
        Me.Size = New System.Drawing.Size(878, 482)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtMskCredit As MaskedTextBox
    Friend WithEvents BtnEditProfile As Button
End Class
