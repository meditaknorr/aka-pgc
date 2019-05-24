Public Class Home
    Dim dba As New dbamanager()

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TilesPanel.BackColor = Color.FromArgb(1, 250, 250, 250)
        constatus.Text = "Okay!"
    End Sub

    Private Sub toLogin_Click(sender As Object, e As EventArgs) Handles toLogin.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles closer.Click
        Application.ExitThread()
    End Sub

    Private Sub maximize_Click(sender As Object, e As EventArgs) Handles maximize.Click
        'Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub inputSearchbg_Click(sender As Object, e As EventArgs) Handles inputSearchbg.Click
        homeSearch.Focus()
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        TilesPanel.Focus()
    End Sub

    Private Sub TilesPanel_Click(sender As Object, e As EventArgs) Handles TilesPanel.Click
        TilesPanel.Focus()
    End Sub

    Private Sub Tile_Click(sender As Object, e As EventArgs) Handles Tile.Click
        CDescription.Show()
    End Sub

End Class
