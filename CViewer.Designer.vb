<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CViewer
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cstart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cend = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.minimize.TabIndex = 99
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
        Me.Separator.TabIndex = 97
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
        Me.BackToHome.TabIndex = 98
        Me.BackToHome.Text = "Back"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Roboto", 15.0!)
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(975, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(195, 24)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "View My Concourses"
        Me.Label10.UseMnemonic = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cid, Me.cname, Me.cdescription, Me.cstart, Me.Cend})
        Me.DataGridView1.Location = New System.Drawing.Point(149, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(994, 671)
        Me.DataGridView1.TabIndex = 109
        '
        'cid
        '
        Me.cid.HeaderText = "Concourse ID"
        Me.cid.Name = "cid"
        Me.cid.ReadOnly = True
        '
        'cname
        '
        Me.cname.HeaderText = "Concourse Name"
        Me.cname.Name = "cname"
        Me.cname.ReadOnly = True
        Me.cname.Width = 250
        '
        'cdescription
        '
        Me.cdescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cdescription.HeaderText = "Concourse Description"
        Me.cdescription.Name = "cdescription"
        Me.cdescription.ReadOnly = True
        '
        'cstart
        '
        Me.cstart.HeaderText = "Concourse Start"
        Me.cstart.Name = "cstart"
        Me.cstart.ReadOnly = True
        '
        'Cend
        '
        Me.Cend.HeaderText = "Concourse End"
        Me.Cend.Name = "Cend"
        Me.Cend.ReadOnly = True
        '
        'CViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.minimize)
        Me.Controls.Add(Me.Separator)
        Me.Controls.Add(Me.BackToHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1200, 800)
        Me.MinimumSize = New System.Drawing.Size(1200, 800)
        Me.Name = "CViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CViewer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents minimize As Label
    Friend WithEvents Separator As Label
    Friend WithEvents BackToHome As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cid As DataGridViewTextBoxColumn
    Friend WithEvents cname As DataGridViewTextBoxColumn
    Friend WithEvents cdescription As DataGridViewTextBoxColumn
    Friend WithEvents cstart As DataGridViewTextBoxColumn
    Friend WithEvents Cend As DataGridViewTextBoxColumn
End Class
