<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CDeleter
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.minimize = New System.Windows.Forms.Label()
        Me.Separator = New System.Windows.Forms.Label()
        Me.BackToHome = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'minimize
        '
        Me.minimize.AutoSize = True
        Me.minimize.BackColor = System.Drawing.Color.Transparent
        Me.minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimize.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold)
        Me.minimize.ForeColor = System.Drawing.Color.Gray
        Me.minimize.Location = New System.Drawing.Point(78, 9)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(59, 15)
        Me.minimize.TabIndex = 63
        Me.minimize.Text = "Minimize"
        '
        'Separator
        '
        Me.Separator.AutoSize = True
        Me.Separator.BackColor = System.Drawing.Color.Transparent
        Me.Separator.Cursor = System.Windows.Forms.Cursors.Default
        Me.Separator.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Separator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Separator.Location = New System.Drawing.Point(61, 9)
        Me.Separator.Name = "Separator"
        Me.Separator.Size = New System.Drawing.Size(10, 15)
        Me.Separator.TabIndex = 61
        Me.Separator.Text = "|"
        '
        'BackToHome
        '
        Me.BackToHome.AutoSize = True
        Me.BackToHome.BackColor = System.Drawing.Color.Transparent
        Me.BackToHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackToHome.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BackToHome.ForeColor = System.Drawing.Color.Gray
        Me.BackToHome.Location = New System.Drawing.Point(12, 9)
        Me.BackToHome.Name = "BackToHome"
        Me.BackToHome.Size = New System.Drawing.Size(36, 15)
        Me.BackToHome.TabIndex = 62
        Me.BackToHome.Text = "Back"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(213, 174)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(175, 13)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Reason / Additional Information : "
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox9.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TextBox9.Location = New System.Drawing.Point(216, 190)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.TextBox9.Size = New System.Drawing.Size(924, 198)
        Me.TextBox9.TabIndex = 91
        Me.TextBox9.Text = "..."
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TextBox1.Location = New System.Drawing.Point(216, 102)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(407, 20)
        Me.TextBox1.TabIndex = 83
        Me.TextBox1.Text = "..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(713, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Concourse Title :"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TextBox3.Location = New System.Drawing.Point(716, 102)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(407, 20)
        Me.TextBox3.TabIndex = 83
        Me.TextBox3.Text = "..."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(213, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 13)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "Concourse ID / Ref.:  "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Roboto", 15.0!)
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(1002, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(168, 24)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Delete Concourse"
        Me.Label10.UseMnemonic = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PictureBox9.Image = Global.ProjectoGConcurso.My.Resources.Resources.formbg
        Me.PictureBox9.Location = New System.Drawing.Point(204, 181)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(936, 217)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 71
        Me.PictureBox9.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox3.Image = Global.ProjectoGConcurso.My.Resources.Resources.formbg
        Me.PictureBox3.Location = New System.Drawing.Point(704, 84)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(436, 50)
        Me.PictureBox3.TabIndex = 65
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PictureBox1.Image = Global.ProjectoGConcurso.My.Resources.Resources.formbg
        Me.PictureBox1.Location = New System.Drawing.Point(204, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(436, 50)
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = Global.ProjectoGConcurso.My.Resources.Resources.apply1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(950, 719)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(195, 41)
        Me.Button2.TabIndex = 64
        Me.Button2.Text = "Remove Councourse"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(213, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 13)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Note : Check 'MyConcourses' section to get the Concourse ID."
        '
        'CDeleter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.minimize)
        Me.Controls.Add(Me.Separator)
        Me.Controls.Add(Me.BackToHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1200, 800)
        Me.MinimumSize = New System.Drawing.Size(1200, 800)
        Me.Name = "CDeleter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CDeleter"
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents minimize As Label
    Friend WithEvents Separator As Label
    Friend WithEvents BackToHome As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox9 As RichTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
End Class
