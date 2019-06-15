Public Class Home
    Dim dba As New dbamanager()

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TilesPanel.BackColor = Color.FromArgb(1, 250, 250, 250)
        userprofilename.Text = dba.get4rmUserProfile("firstname", dba.getUserId(Session.GetSession_ID())) & " " & dba.get4rmUserProfile("lastname", dba.getUserId(Session.GetSession_ID()))
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles LogoutSession.Click
        Session.LogoutApp(Me)
    End Sub

    Private Sub CloseApp_Click(sender As Object, e As EventArgs) Handles CloseApp.Click
        Session.CloseApp(Me)
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

    Private Sub Minimize_MouseEnter(sender As Object, e As EventArgs) Handles CloseApp.MouseHover, LogoutSession.MouseHover, userprofilename.MouseHover
        Style.Link_MouseHover(sender)
    End Sub

    Private Sub Minimize_MouseLeave(sender As Object, e As EventArgs) Handles CloseApp.MouseLeave, LogoutSession.MouseLeave, userprofilename.MouseLeave
        Style.Link(sender)
    End Sub
End Class
