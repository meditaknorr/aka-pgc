Public Class CCreator
    Dim data As Integer = 0
    Dim hoje As Date = Date.Now()
    Dim dba As New dbamanager

    Private Sub CCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MonthCalendar1.MinDate = hoje
    End Sub

    Private Sub BackToHome_Click(sender As Object, e As EventArgs) Handles BackToHome.Click, Separator.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Minimize_MouseEnter(sender As Object, e As EventArgs)
        Style.Link_MouseHover(sender)
    End Sub

    Private Sub Minimize_MouseLeave(sender As Object, e As EventArgs)
        Style.Link(sender)
    End Sub

    Private Sub BackToHome_MouseHover(sender As Object, e As EventArgs)
        Style.Link_MouseHover(sender)
    End Sub

    Private Sub BackToHome_MouseLeave(sender As Object, e As EventArgs)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim userid As String = dba.getUserId(Session.GetSession_ID)
        Dim ctitle As String = TextBox1.Text
        Dim cstart As String = TextBox2.Text
        Dim cservice As String = TextBox3.Text
        Dim cend As String = TextBox4.Text
        Dim ctarget As String = TextBox5.Text
        Dim cannouncement As String = TextBox6.Text
        Dim cquestion1 As String = TextBox7.Text
        Dim cquestion2 As String = TextBox8.Text
        Dim description As String = TextBox9.Text
        Dim status As Integer = 1

        If (ctitle = "..." Or cstart = "..." Or cend = "..." Or cannouncement = "..." Or ctarget = "..." Or cservice = "..." Or cquestion1 = "..." Or description = "...") Then
            MsgBox("There is a field which still empty. Please Review The fields with ... and fill in the information required.")
        Else
            dba.ConcourseCreator(userid, ctitle, description, cservice, ctarget, cquestion1, cquestion2, cstart, cend, cannouncement, status)
            MsgBox("Concourse Created Sucessfully.")
            Me.Close()
            Home.Show()
        End If

    End Sub

End Class