Imports System.IO

Public Class Login
    Dim dba As New dbamanager()

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadingPic.Hide()
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub closer_Click(sender As Object, e As EventArgs) Handles CloseApp.Click
        Me.Close()
    End Sub

    Private Sub inputUsernamebg_Click(sender As Object, e As EventArgs) Handles inputUsernamebg.Click
        username.Focus()
    End Sub

    Private Sub inputPasswordbg_Click(sender As Object, e As EventArgs) Handles inputPasswordbg.Click
        password.Focus()
    End Sub

    Private Sub username_MouseLeave(sender As Object, e As EventArgs) Handles username.MouseLeave
        Dim input As String = username.Text
        Dim len As Integer = input.Length

        If (len < 1) Then
            username.Text = "'username'"
        End If
    End Sub

    Private Sub password_MouseLeave(sender As Object, e As EventArgs) Handles password.MouseLeave
        Dim input As String = password.Text
        Dim len As Integer = input.Length

        If (len < 1) Then
            password.Text = "'password'"
            password.PasswordChar = ControlChars.NullChar
        End If
    End Sub

    Private Sub username_MouseClick(sender As Object, e As MouseEventArgs) Handles username.MouseClick
        Dim input As String = password.Text
        Dim len As Integer = input.Length

        If (len < 1) Then
            password.PasswordChar = username.PasswordChar
            password.Text = "'password'"
        End If
    End Sub

    Private Sub password_MouseClick(sender As Object, e As MouseEventArgs) Handles password.MouseClick
        Dim input As String = username.Text
        Dim len As Integer = input.Length

        If (len < 1) Then
            username.Text = "'username'"
        End If
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        LoginBg.Focus()
    End Sub

    Private Sub password_KeyUp(sender As Object, e As KeyEventArgs) Handles password.KeyUp
        Dim input As String = password.Text
        Dim len As Integer = input.Length

        If (len > 0) Then
            If (input <> "'password'") Then
                password.PasswordChar = "●"
            End If
        End If
    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        loadingPic.Show()
        Dim user As String = username.Text()
        Dim psw As String = password.Text()
        Dim guestuder As String = "'username'"
        Dim guestpsw As String = "'password'"

        If (user = guestuder) Then

            MsgBox("Username field is yet not set. Please review the details and try again")
            loadingPic.Hide()
        ElseIf (psw = guestpsw) Then

            MsgBox("Password field is not set. Please review the details and try again")
            loadingPic.Hide()
        Else

            If (dba.loginStatus(user, psw)) Then
                Session.SetSession_ID(dba.getUserSessionId(user))
                If (dba.ProfileExist(dba.getUserId(dba.getUserSessionId(user))) > 0) Then
                    'tem perfil
                    Me.Hide()
                    Home.Show()
                Else
                    'nao tem perfil
                    Me.Hide()
                    CUserProfileCreator.Show()
                End If
            Else
                MsgBox("Incorrect username or password. Please try again using the correct credentials.")
                password.PasswordChar = ControlChars.NullChar
                username.Text = "'username'"
                password.Text = "'password'"
                loadingPic.Hide()
            End If

        End If

    End Sub

    Private Sub ForgotDetailsLink_Click(sender As Object, e As EventArgs) Handles ForgotUsernameLink.Click
        Me.Hide()
        ForgotUsername.Show()
    End Sub

    Private Sub ForgotPasswordlink_Click(sender As Object, e As EventArgs) Handles ForgotPasswordlink.Click
        Me.Hide()
        ForgotPassword.Show()
    End Sub

    Private Sub Minimize_MouseEnter(sender As Object, e As EventArgs) Handles minimize.MouseHover, CloseApp.MouseHover
        Style.Link_MouseHover(sender)
    End Sub

    Private Sub Minimize_MouseLeave(sender As Object, e As EventArgs) Handles minimize.MouseLeave, CloseApp.MouseLeave
        Style.Link(sender)
    End Sub

    Private Sub Username_KeyDown(sender As Object, e As KeyEventArgs) Handles username.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            password.Focus()
        End If
    End Sub

    Private Sub Password_KeyDown(sender As Object, e As KeyEventArgs) Handles password.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            loginButton.PerformClick()
        End If
    End Sub
End Class