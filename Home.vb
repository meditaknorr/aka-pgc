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

    Private Sub Tile_Click(sender As Object, e As EventArgs)
        Help.Show()
    End Sub

    Private Sub Minimize_MouseEnter(sender As Object, e As EventArgs) Handles CloseApp.MouseHover, LogoutSession.MouseHover, userprofilename.MouseHover, minimize.MouseHover
        Style.Link_MouseHover(sender)
    End Sub

    Private Sub Minimize_MouseLeave(sender As Object, e As EventArgs) Handles CloseApp.MouseLeave, LogoutSession.MouseLeave, userprofilename.MouseLeave, minimize.MouseLeave
        Style.Link(sender)
    End Sub

    Private Sub Tile_MouseHover(sender As Object, e As EventArgs) Handles Tile.MouseHover, Tile9.MouseHover, Tile8.MouseHover, Tile7.MouseHover, Tile6.MouseHover, Tile4.MouseHover, Tile3.MouseHover, Tile2.MouseHover, Panel1.MouseHover, PictureBox9.MouseHover, PictureBox8.MouseHover, PictureBox7.MouseHover, PictureBox6.MouseHover, PictureBox5.MouseHover, PictureBox4.MouseHover, PictureBox3.MouseHover, PictureBox2.MouseHover, Label9.MouseHover, Label8.MouseHover, Label7.MouseHover, Label6.MouseHover, Label5.MouseHover, Label4.MouseHover, Label3.MouseHover, Label2.MouseHover
        Style.Tile_MouseHover(sender)
    End Sub

    Private Sub Tile_MouseLeave(sender As Object, e As EventArgs) Handles Tile.MouseLeave, Tile9.MouseLeave, Tile8.MouseLeave, Tile7.MouseLeave, Tile6.MouseLeave, Tile4.MouseLeave, Tile3.MouseLeave, Tile2.MouseLeave, Panel1.MouseLeave, PictureBox9.MouseLeave, PictureBox8.MouseLeave, PictureBox7.MouseLeave, PictureBox6.MouseLeave, PictureBox5.MouseLeave, PictureBox4.MouseLeave, PictureBox3.MouseLeave, PictureBox2.MouseLeave, Label9.MouseLeave, Label8.MouseLeave, Label7.MouseLeave, Label6.MouseLeave, Label5.MouseLeave, Label4.MouseLeave, Label3.MouseLeave, Label2.MouseLeave
        Style.Tile(sender)
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Tile_Click_1(sender As Object, e As EventArgs) Handles Tile.Click, text11.Click, PictureBox1.Click
        Me.Hide()
        CCreator.Show()
    End Sub

    Private Sub Tile2_Click(sender As Object, e As EventArgs) Handles Tile2.Click, PictureBox2.Click, Label2.Click
        Me.Hide()
        CEditor.Show()
    End Sub

    Private Sub Tile3_Click(sender As Object, e As EventArgs) Handles Tile3.Click, PictureBox3.Click, Label3.Click
        Me.Hide()
        CDeleter.Show()
    End Sub

    Private Sub Tile4_Click(sender As Object, e As EventArgs) Handles Tile4.Click, PictureBox4.Click, Label4.Click
        Me.Hide()
        CClose.Show()
    End Sub

    Private Sub Tile6_Click(sender As Object, e As EventArgs) Handles Tile6.Click, PictureBox5.Click, Label5.Click
        Me.Hide()
        CViewer.Show()
    End Sub

    Private Sub Tile7_Click(sender As Object, e As EventArgs) Handles Tile7.Click, PictureBox6.Click, Label6.Click
        Me.Hide()
        CManageAccounts.Show()
    End Sub

    Private Sub Tile8_Click(sender As Object, e As EventArgs) Handles Tile8.Click, PictureBox7.Click, Label7.Click
        Me.Hide()
        CQuestions.Show()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Help.Show()
    End Sub

    Private Sub Tile9_Click(sender As Object, e As EventArgs) Handles Tile9.Click, PictureBox8.Click, Label8.Click
        Me.Hide()
        Report.Show()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click, Panel1.Click, Label9.Click
        Me.Hide()
        AboutCompany.Show()
    End Sub

    Private Sub ToLogin_Click(sender As Object, e As EventArgs) Handles userprofilename.Click, toLogin.Click
        Me.Hide()
        AboutMe.Show()
    End Sub
End Class
