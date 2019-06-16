<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.minimize = New System.Windows.Forms.Label()
        Me.Separator = New System.Windows.Forms.Label()
        Me.BackToHome = New System.Windows.Forms.Label()
        Me.calendario1 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.calendario1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.minimize.TabIndex = 102
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
        Me.Separator.TabIndex = 100
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
        Me.BackToHome.TabIndex = 101
        Me.BackToHome.Text = "Back"
        '
        'calendario1
        '
        Me.calendario1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.calendario1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.calendario1.Image = Global.ProjectoGConcurso.My.Resources.Resources.Schedule_48px
        Me.calendario1.Location = New System.Drawing.Point(1100, 90)
        Me.calendario1.Name = "calendario1"
        Me.calendario1.Size = New System.Drawing.Size(29, 30)
        Me.calendario1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.calendario1.TabIndex = 109
        Me.calendario1.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TextBox2.Location = New System.Drawing.Point(717, 100)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(407, 20)
        Me.TextBox2.TabIndex = 107
        Me.TextBox2.Text = "..."
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TextBox1.Location = New System.Drawing.Point(219, 100)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(407, 20)
        Me.TextBox1.TabIndex = 108
        Me.TextBox1.Text = "..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(714, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "End :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(216, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Start  : "
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PictureBox2.Image = Global.ProjectoGConcurso.My.Resources.Resources.formbg
        Me.PictureBox2.Location = New System.Drawing.Point(707, 82)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(436, 50)
        Me.PictureBox2.TabIndex = 103
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PictureBox1.Image = Global.ProjectoGConcurso.My.Resources.Resources.formbg
        Me.PictureBox1.Location = New System.Drawing.Point(207, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(436, 50)
        Me.PictureBox1.TabIndex = 104
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Roboto", 15.0!)
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(965, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 24)
        Me.Label10.TabIndex = 110
        Me.Label10.Text = "Report"
        Me.Label10.UseMnemonic = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.ProjectoGConcurso.My.Resources.Resources.Schedule_48px
        Me.PictureBox3.Location = New System.Drawing.Point(597, 90)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(29, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 109
        Me.PictureBox3.TabStop = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(388, 109)
        Me.MonthCalendar1.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.MinDate = New Date(2019, 6, 15, 0, 0, 0, 0)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 111
        Me.MonthCalendar1.Visible = False
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(888, 109)
        Me.MonthCalendar2.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.MonthCalendar2.MaxSelectionCount = 1
        Me.MonthCalendar2.MinDate = New Date(2019, 6, 15, 0, 0, 0, 0)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 111
        Me.MonthCalendar2.Visible = False
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
        Me.Button2.Location = New System.Drawing.Point(948, 719)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(195, 41)
        Me.Button2.TabIndex = 112
        Me.Button2.Text = "Get Report"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MonthCalendar2)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.calendario1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.minimize)
        Me.Controls.Add(Me.Separator)
        Me.Controls.Add(Me.BackToHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1200, 800)
        Me.MinimumSize = New System.Drawing.Size(1200, 800)
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        CType(Me.calendario1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents minimize As Label
    Friend WithEvents Separator As Label
    Friend WithEvents BackToHome As Label
    Friend WithEvents calendario1 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents Button2 As Button
End Class
