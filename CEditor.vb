Public Class CEditor
    Dim data As Integer = 0

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

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox8.Focus()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox9.Focus()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        data = 1
        MonthCalendar1.Visible = True
        MonthCalendar1.Location = New Point(898, 110)
    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        data = 2
        MonthCalendar1.Visible = True
        MonthCalendar1.Location = New Point(898, 200)
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        data = 3
        MonthCalendar1.Visible = True
        MonthCalendar1.Location = New Point(898, 295)
    End Sub

    Private Sub CCreator_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        MonthCalendar1.Visible = False
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        If (data = 1) Then
            TextBox2.Text = MonthCalendar1.SelectionRange.Start.ToShortDateString()
        ElseIf (data = 2) Then
            TextBox4.Text = MonthCalendar1.SelectionRange.Start.ToShortDateString()
        ElseIf (data = 3) Then
            TextBox6.Text = MonthCalendar1.SelectionRange.Start.ToShortDateString()
        End If
    End Sub

    Private Sub Calendario1_Click(sender As Object, e As EventArgs) Handles calendario1.Click
        If (MonthCalendar1.Visible = True) Then
            MonthCalendar1.Visible = False
        Else
            data = 1
            MonthCalendar1.Visible = True
            MonthCalendar1.Location = New Point(898, 110)
        End If
    End Sub

    Private Sub Calendario2_Click(sender As Object, e As EventArgs) Handles calendario2.Click
        If (MonthCalendar1.Visible = True) Then
            MonthCalendar1.Visible = False
        Else
            data = 2
            MonthCalendar1.Visible = True
            MonthCalendar1.Location = New Point(898, 200)
        End If
    End Sub

    Private Sub Calendario3_Click(sender As Object, e As EventArgs) Handles calendario3.Click
        If (MonthCalendar1.Visible = True) Then
            MonthCalendar1.Visible = False
        Else
            data = 3
            MonthCalendar1.Visible = True
            MonthCalendar1.Location = New Point(898, 295)
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        TextBox10.Focus()
    End Sub
End Class