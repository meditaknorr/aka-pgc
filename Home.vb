Public Class Home
    Dim dba As New dbamanager()

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TilesPanel.BackColor = Color.FromArgb(1, 250, 250, 250)
        Dim txt As String = dba.get4rmUserProfile("firstname", dba.getUserId(Session.GetSession_ID())) '+ " " + dba.get4rmUserProfile("lastname", dba.getUserId(Session.GetSession_ID()))
        sessionid.Text = txt
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

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Session.Logout(Me)
    End Sub
End Class
