Public Class Report

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

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        TextBox1.Text = MonthCalendar1.SelectionRange.Start.ToShortDateString()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click, PictureBox3.Click, PictureBox1.Click
        MonthCalendar1.Visible = True
    End Sub

    Private Sub MonthCalendar2_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateSelected
        TextBox2.Text = MonthCalendar2.SelectionRange.Start.ToShortDateString()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click, PictureBox2.Click, calendario1.Click
        MonthCalendar2.Visible = True
    End Sub

    Private Sub Report_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        MonthCalendar1.Visible = False
        MonthCalendar2.Visible = True
    End Sub
End Class