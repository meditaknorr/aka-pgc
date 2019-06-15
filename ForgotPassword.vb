Public Class ForgotPassword
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles backky.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox1.Focus()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TextBox2.Focus()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim username As String = TextBox1.Text()
        Dim guestuser As String = "'username'"
        Dim eemail As String = TextBox2.Text()
        Dim guestemail As String = "'e-mail address'"

        If (eemail = guestemail) Then
            MsgBox("E-mail address field is empty. Please provide your account e-mail address.")
        ElseIf (username = guestuser) Then
            MsgBox("Username field still empty. Please provide your account username address.")
        Else

        End If
    End Sub
End Class