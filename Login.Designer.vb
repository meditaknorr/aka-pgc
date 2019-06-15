<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.ForgotUsernameLink = New System.Windows.Forms.Label()
        Me.ForgotPasswordlink = New System.Windows.Forms.Label()
        Me.UserIcon = New System.Windows.Forms.PictureBox()
        Me.loadingPic = New System.Windows.Forms.PictureBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.inputPasswordbg = New System.Windows.Forms.PictureBox()
        Me.inputUsernamebg = New System.Windows.Forms.PictureBox()
        Me.LoginBg = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.minimize = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CloseApp = New System.Windows.Forms.Label()
        CType(Me.UserIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.loadingPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inputPasswordbg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inputUsernamebg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'username
        '
        Me.username.AccessibleName = ""
        Me.username.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.username.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.username.ForeColor = System.Drawing.Color.DimGray
        Me.username.Location = New System.Drawing.Point(88, 312)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(272, 20)
        Me.username.TabIndex = 8
        Me.username.Tag = "username"
        Me.username.Text = "'username'"
        Me.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'password
        '
        Me.password.AllowDrop = True
        Me.password.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.password.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.password.ForeColor = System.Drawing.Color.DimGray
        Me.password.Location = New System.Drawing.Point(87, 400)
        Me.password.MaxLength = 52
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(272, 20)
        Me.password.TabIndex = 8
        Me.password.Tag = "password"
        Me.password.Text = "'password'"
        Me.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.password.WordWrap = False
        '
        'ForgotUsernameLink
        '
        Me.ForgotUsernameLink.AutoSize = True
        Me.ForgotUsernameLink.BackColor = System.Drawing.Color.Transparent
        Me.ForgotUsernameLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForgotUsernameLink.Font = New System.Drawing.Font("Roboto", 8.25!)
        Me.ForgotUsernameLink.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ForgotUsernameLink.Location = New System.Drawing.Point(88, 448)
        Me.ForgotUsernameLink.Name = "ForgotUsernameLink"
        Me.ForgotUsernameLink.Size = New System.Drawing.Size(121, 13)
        Me.ForgotUsernameLink.TabIndex = 9
        Me.ForgotUsernameLink.Text = "Forgor your username?"
        '
        'ForgotPasswordlink
        '
        Me.ForgotPasswordlink.AutoSize = True
        Me.ForgotPasswordlink.BackColor = System.Drawing.Color.Transparent
        Me.ForgotPasswordlink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForgotPasswordlink.Font = New System.Drawing.Font("Roboto", 8.25!)
        Me.ForgotPasswordlink.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ForgotPasswordlink.Location = New System.Drawing.Point(232, 448)
        Me.ForgotPasswordlink.Name = "ForgotPasswordlink"
        Me.ForgotPasswordlink.Size = New System.Drawing.Size(119, 13)
        Me.ForgotPasswordlink.TabIndex = 9
        Me.ForgotPasswordlink.Text = "Forgor your password?"
        '
        'UserIcon
        '
        Me.UserIcon.Image = CType(resources.GetObject("UserIcon.Image"), System.Drawing.Image)
        Me.UserIcon.Location = New System.Drawing.Point(177, 104)
        Me.UserIcon.Name = "UserIcon"
        Me.UserIcon.Size = New System.Drawing.Size(96, 96)
        Me.UserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.UserIcon.TabIndex = 5
        Me.UserIcon.TabStop = False
        '
        'loadingPic
        '
        Me.loadingPic.Image = Global.ProjectoGConcurso.My.Resources.Resources.loadin
        Me.loadingPic.Location = New System.Drawing.Point(171, 161)
        Me.loadingPic.Name = "loadingPic"
        Me.loadingPic.Size = New System.Drawing.Size(108, 86)
        Me.loadingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.loadingPic.TabIndex = 10
        Me.loadingPic.TabStop = False
        '
        'loginButton
        '
        Me.loginButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.loginButton.BackgroundImage = CType(resources.GetObject("loginButton.BackgroundImage"), System.Drawing.Image)
        Me.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.loginButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.loginButton.FlatAppearance.BorderSize = 0
        Me.loginButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginButton.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.loginButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.loginButton.Location = New System.Drawing.Point(75, 541)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(300, 50)
        Me.loginButton.TabIndex = 2
        Me.loginButton.Text = "login"
        Me.loginButton.UseVisualStyleBackColor = False
        '
        'inputPasswordbg
        '
        Me.inputPasswordbg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.inputPasswordbg.Image = CType(resources.GetObject("inputPasswordbg.Image"), System.Drawing.Image)
        Me.inputPasswordbg.Location = New System.Drawing.Point(75, 384)
        Me.inputPasswordbg.Name = "inputPasswordbg"
        Me.inputPasswordbg.Size = New System.Drawing.Size(300, 52)
        Me.inputPasswordbg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.inputPasswordbg.TabIndex = 7
        Me.inputPasswordbg.TabStop = False
        '
        'inputUsernamebg
        '
        Me.inputUsernamebg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.inputUsernamebg.Image = CType(resources.GetObject("inputUsernamebg.Image"), System.Drawing.Image)
        Me.inputUsernamebg.Location = New System.Drawing.Point(75, 296)
        Me.inputUsernamebg.Name = "inputUsernamebg"
        Me.inputUsernamebg.Size = New System.Drawing.Size(300, 52)
        Me.inputUsernamebg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.inputUsernamebg.TabIndex = 7
        Me.inputUsernamebg.TabStop = False
        '
        'LoginBg
        '
        Me.LoginBg.Image = CType(resources.GetObject("LoginBg.Image"), System.Drawing.Image)
        Me.LoginBg.Location = New System.Drawing.Point(-8, 320)
        Me.LoginBg.Name = "LoginBg"
        Me.LoginBg.Size = New System.Drawing.Size(464, 480)
        Me.LoginBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LoginBg.TabIndex = 0
        Me.LoginBg.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 778)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Before start using, login on our system make sure you have an internet connection" &
    "."
        '
        'minimize
        '
        Me.minimize.AutoSize = True
        Me.minimize.BackColor = System.Drawing.Color.Transparent
        Me.minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimize.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold)
        Me.minimize.ForeColor = System.Drawing.Color.Gray
        Me.minimize.Location = New System.Drawing.Point(80, 9)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(59, 15)
        Me.minimize.TabIndex = 11
        Me.minimize.Text = "Minimize"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(62, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "|"
        '
        'CloseApp
        '
        Me.CloseApp.AutoSize = True
        Me.CloseApp.BackColor = System.Drawing.Color.Transparent
        Me.CloseApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseApp.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CloseApp.ForeColor = System.Drawing.Color.Gray
        Me.CloseApp.Location = New System.Drawing.Point(12, 9)
        Me.CloseApp.Name = "CloseApp"
        Me.CloseApp.Size = New System.Drawing.Size(40, 15)
        Me.CloseApp.TabIndex = 13
        Me.CloseApp.Text = "Close"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(450, 800)
        Me.Controls.Add(Me.minimize)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CloseApp)
        Me.Controls.Add(Me.UserIcon)
        Me.Controls.Add(Me.loadingPic)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ForgotPasswordlink)
        Me.Controls.Add(Me.ForgotUsernameLink)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.inputPasswordbg)
        Me.Controls.Add(Me.inputUsernamebg)
        Me.Controls.Add(Me.LoginBg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainScreen"
        CType(Me.UserIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.loadingPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inputPasswordbg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inputUsernamebg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginBg As PictureBox
    Friend WithEvents UserIcon As PictureBox
    Friend WithEvents inputUsernamebg As PictureBox
    Friend WithEvents username As TextBox
    Friend WithEvents inputPasswordbg As PictureBox
    Friend WithEvents password As TextBox
    Friend WithEvents ForgotUsernameLink As Label
    Friend WithEvents ForgotPasswordlink As Label
    Friend WithEvents loginButton As Button
    Friend WithEvents loadingPic As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents minimize As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CloseApp As Label
End Class
