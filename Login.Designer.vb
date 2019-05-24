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
        Me.ForgotDetails = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InvitetoCreateAccount = New System.Windows.Forms.Label()
        Me.CreateAccount = New System.Windows.Forms.Label()
        Me.loadingPic = New System.Windows.Forms.PictureBox()
        Me.UserIcon = New System.Windows.Forms.PictureBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.maximize = New System.Windows.Forms.Button()
        Me.minimize = New System.Windows.Forms.Button()
        Me.closer = New System.Windows.Forms.Button()
        Me.inputPasswordbg = New System.Windows.Forms.PictureBox()
        Me.inputUsernamebg = New System.Windows.Forms.PictureBox()
        Me.LoginBg = New System.Windows.Forms.PictureBox()
        CType(Me.loadingPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserIcon, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ForgotDetails
        '
        Me.ForgotDetails.AutoSize = True
        Me.ForgotDetails.BackColor = System.Drawing.Color.Transparent
        Me.ForgotDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForgotDetails.Font = New System.Drawing.Font("Roboto", 8.25!)
        Me.ForgotDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ForgotDetails.Location = New System.Drawing.Point(88, 448)
        Me.ForgotDetails.Name = "ForgotDetails"
        Me.ForgotDetails.Size = New System.Drawing.Size(121, 13)
        Me.ForgotDetails.TabIndex = 9
        Me.ForgotDetails.Text = "Forgor your username?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(232, 448)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Forgor your password?"
        '
        'InvitetoCreateAccount
        '
        Me.InvitetoCreateAccount.AutoSize = True
        Me.InvitetoCreateAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.InvitetoCreateAccount.Cursor = System.Windows.Forms.Cursors.Default
        Me.InvitetoCreateAccount.Font = New System.Drawing.Font("Roboto", 8.25!)
        Me.InvitetoCreateAccount.ForeColor = System.Drawing.Color.White
        Me.InvitetoCreateAccount.Location = New System.Drawing.Point(107, 605)
        Me.InvitetoCreateAccount.Name = "InvitetoCreateAccount"
        Me.InvitetoCreateAccount.Size = New System.Drawing.Size(125, 13)
        Me.InvitetoCreateAccount.TabIndex = 9
        Me.InvitetoCreateAccount.Text = "It's your first time here?"
        '
        'CreateAccount
        '
        Me.CreateAccount.AutoSize = True
        Me.CreateAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CreateAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CreateAccount.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateAccount.ForeColor = System.Drawing.Color.White
        Me.CreateAccount.Location = New System.Drawing.Point(240, 605)
        Me.CreateAccount.Name = "CreateAccount"
        Me.CreateAccount.Size = New System.Drawing.Size(99, 13)
        Me.CreateAccount.TabIndex = 9
        Me.CreateAccount.Text = "Create an Account"
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
        'maximize
        '
        Me.maximize.BackgroundImage = CType(resources.GetObject("maximize.BackgroundImage"), System.Drawing.Image)
        Me.maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.maximize.Cursor = System.Windows.Forms.Cursors.Default
        Me.maximize.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.maximize.FlatAppearance.BorderSize = 0
        Me.maximize.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.maximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.maximize.Location = New System.Drawing.Point(60, 12)
        Me.maximize.Name = "maximize"
        Me.maximize.Size = New System.Drawing.Size(20, 20)
        Me.maximize.TabIndex = 2
        Me.maximize.UseVisualStyleBackColor = True
        '
        'minimize
        '
        Me.minimize.BackgroundImage = CType(resources.GetObject("minimize.BackgroundImage"), System.Drawing.Image)
        Me.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.minimize.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.minimize.FlatAppearance.BorderSize = 0
        Me.minimize.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimize.Location = New System.Drawing.Point(36, 12)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(20, 20)
        Me.minimize.TabIndex = 3
        Me.minimize.UseVisualStyleBackColor = True
        '
        'closer
        '
        Me.closer.BackgroundImage = CType(resources.GetObject("closer.BackgroundImage"), System.Drawing.Image)
        Me.closer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closer.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.closer.FlatAppearance.BorderSize = 0
        Me.closer.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.closer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.closer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.closer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closer.Location = New System.Drawing.Point(12, 12)
        Me.closer.Name = "closer"
        Me.closer.Size = New System.Drawing.Size(20, 20)
        Me.closer.TabIndex = 4
        Me.closer.UseVisualStyleBackColor = True
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
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(450, 800)
        Me.Controls.Add(Me.UserIcon)
        Me.Controls.Add(Me.loadingPic)
        Me.Controls.Add(Me.CreateAccount)
        Me.Controls.Add(Me.InvitetoCreateAccount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ForgotDetails)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.maximize)
        Me.Controls.Add(Me.minimize)
        Me.Controls.Add(Me.closer)
        Me.Controls.Add(Me.inputPasswordbg)
        Me.Controls.Add(Me.inputUsernamebg)
        Me.Controls.Add(Me.LoginBg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainScreen"
        CType(Me.loadingPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inputPasswordbg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inputUsernamebg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginBg As PictureBox
    Friend WithEvents maximize As Button
    Friend WithEvents minimize As Button
    Friend WithEvents closer As Button
    Friend WithEvents UserIcon As PictureBox
    Friend WithEvents inputUsernamebg As PictureBox
    Friend WithEvents username As TextBox
    Friend WithEvents inputPasswordbg As PictureBox
    Friend WithEvents password As TextBox
    Friend WithEvents ForgotDetails As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents loginButton As Button
    Friend WithEvents InvitetoCreateAccount As Label
    Friend WithEvents CreateAccount As Label
    Friend WithEvents loadingPic As PictureBox
End Class
