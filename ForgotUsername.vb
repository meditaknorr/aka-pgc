Public Class ForgotUsername
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub InputUsernamebg_Click(sender As Object, e As EventArgs) Handles inputUsernamebg.Click
        email.Focus()
    End Sub

    Private Sub RememberButton_Click(sender As Object, e As EventArgs) Handles rememberButton.Click
        Dim eemail As String = email.Text()
        Dim guestemail As String = "'e-mail address'"

        If (eemail = guestemail) Then
            MsgBox("E-mail address field is empty. Please provide your account e-mail address.")
        Else

        End If
    End Sub
End Class