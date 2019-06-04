<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotUsername
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotUsername))
        Me.LoginBg = New System.Windows.Forms.PictureBox()
        Me.back = New System.Windows.Forms.Label()
        Me.inputUsernamebg = New System.Windows.Forms.PictureBox()
        Me.rememberButton = New System.Windows.Forms.Button()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.LoginBg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inputUsernamebg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginBg
        '
        Me.LoginBg.Image = CType(resources.GetObject("LoginBg.Image"), System.Drawing.Image)
        Me.LoginBg.Location = New System.Drawing.Point(-13, 321)
        Me.LoginBg.Name = "LoginBg"
        Me.LoginBg.Size = New System.Drawing.Size(464, 480)
        Me.LoginBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LoginBg.TabIndex = 1
        Me.LoginBg.TabStop = False
        '
        'back
        '
        Me.back.AutoSize = True
        Me.back.BackColor = System.Drawing.Color.Transparent
        Me.back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back.Font = New System.Drawing.Font("Roboto", 8.25!)
        Me.back.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.back.Location = New System.Drawing.Point(12, 9)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(32, 13)
        Me.back.TabIndex = 11
        Me.back.Text = "Back"
        '
        'inputUsernamebg
        '
        Me.inputUsernamebg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.inputUsernamebg.Image = CType(resources.GetObject("inputUsernamebg.Image"), System.Drawing.Image)
        Me.inputUsernamebg.Location = New System.Drawing.Point(73, 374)
        Me.inputUsernamebg.Name = "inputUsernamebg"
        Me.inputUsernamebg.Size = New System.Drawing.Size(300, 52)
        Me.inputUsernamebg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.inputUsernamebg.TabIndex = 12
        Me.inputUsernamebg.TabStop = False
        '
        'rememberButton
        '
        Me.rememberButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.rememberButton.BackgroundImage = CType(resources.GetObject("rememberButton.BackgroundImage"), System.Drawing.Image)
        Me.rememberButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rememberButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rememberButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.rememberButton.FlatAppearance.BorderSize = 0
        Me.rememberButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.rememberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.rememberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.rememberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rememberButton.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rememberButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.rememberButton.Location = New System.Drawing.Point(73, 544)
        Me.rememberButton.Name = "rememberButton"
        Me.rememberButton.Size = New System.Drawing.Size(300, 50)
        Me.rememberButton.TabIndex = 13
        Me.rememberButton.Text = "remember username"
        Me.rememberButton.UseVisualStyleBackColor = False
        '
        'email
        '
        Me.email.AccessibleName = ""
        Me.email.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.email.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.email.ForeColor = System.Drawing.Color.DimGray
        Me.email.Location = New System.Drawing.Point(87, 391)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(272, 20)
        Me.email.TabIndex = 14
        Me.email.Tag = ""
        Me.email.Text = "'e-mail address'"
        Me.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(37, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "In order to get your account username, please fill the fields above."
        '
        'ForgotUsername
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(450, 800)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.rememberButton)
        Me.Controls.Add(Me.inputUsernamebg)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.LoginBg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ForgotUsername"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ForgotUsername"
        CType(Me.LoginBg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inputUsernamebg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginBg As PictureBox
    Friend WithEvents back As Label
    Friend WithEvents inputUsernamebg As PictureBox
    Friend WithEvents rememberButton As Button
    Friend WithEvents email As TextBox
    Friend WithEvents Label1 As Label
End Class
