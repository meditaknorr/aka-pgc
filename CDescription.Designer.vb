<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CDescription
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.closer = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CDBrowser)
        Me.Panel1.Location = New System.Drawing.Point(14, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(687, 596)
        Me.Panel1.TabIndex = 4
        '
        'CDBrowser
        '
        Me.CDBrowser.AllowWebBrowserDrop = False
        Me.CDBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CDBrowser.IsWebBrowserContextMenuEnabled = False
        Me.CDBrowser.Location = New System.Drawing.Point(0, 0)
        Me.CDBrowser.MaximumSize = New System.Drawing.Size(687, 596)
        Me.CDBrowser.MinimumSize = New System.Drawing.Size(687, 596)
        Me.CDBrowser.Name = "CDBrowser"
        Me.CDBrowser.Size = New System.Drawing.Size(687, 596)
        Me.CDBrowser.TabIndex = 0
        Me.CDBrowser.Url = New System.Uri("", System.UriKind.Relative)
        '
        'reportBt
        '
        Me.reportBt.AutoSize = True
        Me.reportBt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reportBt.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportBt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.reportBt.Location = New System.Drawing.Point(810, 547)
        Me.reportBt.Name = "reportBt"
        Me.reportBt.Size = New System.Drawing.Size(98, 13)
        Me.reportBt.TabIndex = 5
        Me.reportBt.Text = "Report a problem?"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.ProjectoGConcurso.My.Resources.Resources.apply1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Roboto", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(744, 565)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(221, 47)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "express interest"
        Me.Button1.UseVisualStyleBackColor = True
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
        'CDescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1000, 630)
        Me.Controls.Add(Me.reportBt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.closer)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CDescription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CDescription"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents closer As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents reportBt As Label
    Friend WithEvents CDBrowser As WebBrowser
End Class
