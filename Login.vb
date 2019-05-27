Public Class Login
    Dim dba As New dbamanager()

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadingPic.Hide()
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub maximize_Click(sender As Object, e As EventArgs) Handles maximize.Click
        'Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub closer_Click(sender As Object, e As EventArgs) Handles closer.Click
        Me.Close()
        Home.Show()
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

    Private Sub CreateAccount_Click(sender As Object, e As EventArgs) Handles CreateAccount.Click
        Me.Close()
        ACreator.Show()
    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        'loadingPic.Show()
        'Dim user As String = username.Text()
        'Dim psw As String = password.Text()

        'If (dba.loginStatus(user, psw)) Then
        'Me.Close()
        'UserBoard.Show()
        'Else
        'MsgBox("Incorrect username or password. Please try again using the correct credentials.")
        'password.PasswordChar = ControlChars.NullChar
        'username.Text = "'username'"
        'password.Text = "'password'"
        'loadingPic.Hide()
        'End If
        Me.Close()
        Home.Show()
    End Sub

End Class