<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Help
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CDBrowser = New System.Windows.Forms.WebBrowser()
        Me.reportBt = New System.Windows.Forms.Label()
        Me.closer = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CDBrowser)
        Me.Panel1.Location = New System.Drawing.Point(25, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(948, 576)
        Me.Panel1.TabIndex = 4
        '
        'CDBrowser
        '
        Me.CDBrowser.AllowWebBrowserDrop = False
        Me.CDBrowser.IsWebBrowserContextMenuEnabled = False
        Me.CDBrowser.Location = New System.Drawing.Point(3, 3)
        Me.CDBrowser.Name = "CDBrowser"
        Me.CDBrowser.Size = New System.Drawing.Size(942, 570)
        Me.CDBrowser.TabIndex = 0
        Me.CDBrowser.Url = New System.Uri("", System.UriKind.Relative)
        '
        'reportBt
        '
        Me.reportBt.AutoSize = True
        Me.reportBt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reportBt.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportBt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.reportBt.Location = New System.Drawing.Point(67, 9)
        Me.reportBt.Name = "reportBt"
        Me.reportBt.Size = New System.Drawing.Size(98, 13)
        Me.reportBt.TabIndex = 5
        Me.reportBt.Text = "Report a problem?"
        '
        'closer
        '
        Me.closer.BackgroundImage = Global.ProjectoGConcurso.My.Resources.Resources.Delete_48px
        Me.closer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closer.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.closer.FlatAppearance.BorderSize = 0
        Me.closer.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.closer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.closer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.closer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closer.Location = New System.Drawing.Point(968, 12)
        Me.closer.Name = "closer"
        Me.closer.Size = New System.Drawing.Size(20, 20)
        Me.closer.TabIndex = 2
        Me.closer.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(12, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 15)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Help"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(51, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(10, 15)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "|"
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1000, 630)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.reportBt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.closer)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Help"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CDescription"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents closer As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents reportBt As Label
    Friend WithEvents CDBrowser As WebBrowser
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
End Class
