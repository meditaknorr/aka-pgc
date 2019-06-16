Public Class CQuestions
    Private Sub BackToHome_Click(sender As Object, e As EventArgs) Handles BackToHome.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Minimize_MouseEnter(sender As Object, e As EventArgs) Handles minimize.MouseHover
        Style.Link_MouseHover(sender)
    End Sub

    Private Sub Minimize_MouseLeave(sender As Object, e As EventArgs) Handles minimize.MouseLeave
        Style.Link(sender)
    End Sub

    Private Sub BackToHome_MouseHover(sender As Object, e As EventArgs) Handles BackToHome.MouseHover
        Style.Link_MouseHover(sender)
    End Sub

    Private Sub BackToHome_MouseLeave(sender As Object, e As EventArgs) Handles BackToHome.MouseLeave
        Style.Link(sender)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox1.Focus()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox2.Focus()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox3.Focus()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox4.Focus()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox5.Focus()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox6.Focus()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox7.Focus()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox9.Focus()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox11.Focus()
    End Sub

End Class