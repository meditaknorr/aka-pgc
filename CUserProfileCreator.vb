Public Class CUserProfileCreator
    Dim hoje As Date = Date.Now()
    Dim dba As New dbamanager()

    Private Sub CUserProfileCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MonthCalendar1.MinDate = hoje
    End Sub

    Private Sub BackToHome_Click(sender As Object, e As EventArgs) Handles BackToHome.Click, Separator.Click
        Me.Close()
        Session.LogoutApp(Me)
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

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox10.Focus()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox11.Focus()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox12.Focus()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox13.Focus()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox14.Focus()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox15.Focus()
    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles TextBox4.Click, PictureBox4.Click, calendario2.Click
        If (MonthCalendar1.Visible = True) Then
            MonthCalendar1.Visible = False
        Else
            MonthCalendar1.Visible = True
        End If
    End Sub

    Private Sub CUserProfileCreator_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        MonthCalendar1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim userid As String = dba.getUserId(Session.GetSession_ID)
        Dim uname As String = TextBox1.Text
        Dim usurname As String = TextBox2.Text
        Dim uemail As String = TextBox3.Text
        Dim ubirth As String = TextBox4.Text
        Dim uphone As String = TextBox5.Text
        Dim ucountry As String = TextBox6.Text
        Dim uprovince As String = TextBox7.Text
        Dim ucity As String = TextBox8.Text
        Dim uquestion1 As String = TextBox9.Text
        Dim uquestion2 As String = TextBox11.Text
        Dim uanswer1 As String = TextBox10.Text
        Dim uanswer2 As String = TextBox12.Text
        Dim ucnuit As String = TextBox13.Text
        Dim ucalvara As String = TextBox14.Text
        Dim ugender As String = TextBox15.Text

        If (uname = "..." Or usurname = "..." Or uemail = "..." Or ubirth = "..." Or uphone = "..." Or ucountry = "..." Or uprovince = "..." Or ucity = "..." Or uquestion1 = "..." Or uquestion2 = "..." Or uanswer1 = "..." Or uanswer2 = "..." Or ucnuit = "..." Or ucalvara = "..." Or ugender = "...") Then
            MsgBox("There is a field which still empty. Please Review The fields with ... and fill in the information required.")
        Else
            dba.ProfileCreator(userid, uname, usurname, ugender, ucountry, uprovince, ucity, uphone, uemail)
            dba.UserCompanyAlvaraNuit(userid, ucnuit, ucalvara)
            MsgBox(uname & ", Your Profile Details has been Submited and Avatar Created Sucessfully...")
            Me.Close()
            Home.Show()
        End If
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        TextBox4.Text = MonthCalendar1.SelectionRange.Start.ToShortDateString()
    End Sub
End Class