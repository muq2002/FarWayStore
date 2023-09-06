<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.RibbonTOP = New System.Windows.Forms.Panel()
        Me.NamePageLabel = New System.Windows.Forms.Label()
        Me.CloseBTN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextUsername = New System.Windows.Forms.TextBox()
        Me.TextPassword = New System.Windows.Forms.TextBox()
        Me.PictureLogo = New System.Windows.Forms.PictureBox()
        Me.LoginBTN = New System.Windows.Forms.Button()
        Me.RibbonTOP.SuspendLayout()
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonTOP
        '
        Me.RibbonTOP.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.RibbonTOP.Controls.Add(Me.NamePageLabel)
        Me.RibbonTOP.Controls.Add(Me.CloseBTN)
        Me.RibbonTOP.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonTOP.Location = New System.Drawing.Point(0, 0)
        Me.RibbonTOP.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.RibbonTOP.Name = "RibbonTOP"
        Me.RibbonTOP.Size = New System.Drawing.Size(598, 49)
        Me.RibbonTOP.TabIndex = 4
        '
        'NamePageLabel
        '
        Me.NamePageLabel.AutoSize = True
        Me.NamePageLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.NamePageLabel.Font = New System.Drawing.Font("Cairo", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamePageLabel.ForeColor = System.Drawing.Color.White
        Me.NamePageLabel.Location = New System.Drawing.Point(267, 0)
        Me.NamePageLabel.Name = "NamePageLabel"
        Me.NamePageLabel.Size = New System.Drawing.Size(331, 45)
        Me.NamePageLabel.TabIndex = 2
        Me.NamePageLabel.Text = " تسجيل الدخول |FarWAY Store"
        '
        'CloseBTN
        '
        Me.CloseBTN.Dock = System.Windows.Forms.DockStyle.Left
        Me.CloseBTN.FlatAppearance.BorderSize = 0
        Me.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBTN.ForeColor = System.Drawing.Color.White
        Me.CloseBTN.Image = CType(resources.GetObject("CloseBTN.Image"), System.Drawing.Image)
        Me.CloseBTN.Location = New System.Drawing.Point(0, 0)
        Me.CloseBTN.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.CloseBTN.Name = "CloseBTN"
        Me.CloseBTN.Size = New System.Drawing.Size(50, 49)
        Me.CloseBTN.TabIndex = 0
        Me.CloseBTN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cairo Light", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(48, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "اسم المستخدم"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cairo Light", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(48, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 30)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "كلمة المرور"
        '
        'TextUsername
        '
        Me.TextUsername.Font = New System.Drawing.Font("Cairo Light", 12.0!)
        Me.TextUsername.Location = New System.Drawing.Point(162, 223)
        Me.TextUsername.Name = "TextUsername"
        Me.TextUsername.Size = New System.Drawing.Size(271, 37)
        Me.TextUsername.TabIndex = 7
        Me.TextUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextPassword
        '
        Me.TextPassword.Font = New System.Drawing.Font("Cairo Light", 12.0!)
        Me.TextPassword.Location = New System.Drawing.Point(162, 266)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(43)
        Me.TextPassword.Size = New System.Drawing.Size(271, 37)
        Me.TextPassword.TabIndex = 8
        Me.TextPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureLogo
        '
        Me.PictureLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureLogo.Image = CType(resources.GetObject("PictureLogo.Image"), System.Drawing.Image)
        Me.PictureLogo.Location = New System.Drawing.Point(0, 49)
        Me.PictureLogo.Name = "PictureLogo"
        Me.PictureLogo.Size = New System.Drawing.Size(598, 155)
        Me.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureLogo.TabIndex = 9
        Me.PictureLogo.TabStop = False
        '
        'LoginBTN
        '
        Me.LoginBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.LoginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBTN.Font = New System.Drawing.Font("Cairo", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBTN.ForeColor = System.Drawing.Color.White
        Me.LoginBTN.Location = New System.Drawing.Point(199, 328)
        Me.LoginBTN.Name = "LoginBTN"
        Me.LoginBTN.Size = New System.Drawing.Size(180, 51)
        Me.LoginBTN.TabIndex = 11
        Me.LoginBTN.Text = "تسجيل الدخول"
        Me.LoginBTN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LoginBTN.UseVisualStyleBackColor = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(598, 405)
        Me.Controls.Add(Me.LoginBTN)
        Me.Controls.Add(Me.PictureLogo)
        Me.Controls.Add(Me.TextPassword)
        Me.Controls.Add(Me.TextUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RibbonTOP)
        Me.Font = New System.Drawing.Font("Cairo", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "LoginForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        Me.RibbonTOP.ResumeLayout(False)
        Me.RibbonTOP.PerformLayout()
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonTOP As System.Windows.Forms.Panel
    Friend WithEvents NamePageLabel As System.Windows.Forms.Label
    Friend WithEvents CloseBTN As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextUsername As System.Windows.Forms.TextBox
    Friend WithEvents TextPassword As System.Windows.Forms.TextBox
    Friend WithEvents PictureLogo As System.Windows.Forms.PictureBox
    Friend WithEvents LoginBTN As System.Windows.Forms.Button
End Class
