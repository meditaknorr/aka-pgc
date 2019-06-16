Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Net.Sockets
Imports MySql.Data.MySqlClient

Public Class ACreator
    Dim dba As New dbamanager()
    Private comandoMySQl As MySqlCommand
    Private leitor As MySqlDataReader
    Dim language As String = "EN"
    Dim companyFields As Boolean = False
    Dim userFields As Boolean = False
    Dim attachments As Boolean = False
    Dim status As Integer = 0
    Dim company, yearsactivity, city_company, province_company, nuit_company, alvara_company, country_company, location_company, activity_company, contact_company, email_company, regcomercial_company As String
    Dim firstname_user, last_name, country_user, province_user, city_user, email_user, location_user, password1_user, password2_user, contact_user, id_user, position_user As String

    Private Sub ACreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ACTab1.TabPages.Remove(ACYou)
        ACTab1.TabPages.Remove(ACAttachments)

        Dim query1 As String = "Select * from country"
        dba.connectorAdder()
        comandoMySQl = New MySqlCommand(query1, dba.connectorRemoverORAdder)
        leitor = comandoMySQl.ExecuteReader()

        While (leitor.Read())
            Dim packetdata = leitor.GetString("countryname")
            countryCompany.Items.Add(packetdata)
            countryUser.Items.Add(packetdata)
        End While

        Dim query2 As String = "Select * from companysectors where language = '" + language + "'"
        dba.connectorAdder()
        comandoMySQl = New MySqlCommand(query2, dba.connectorRemoverORAdder)
        leitor = comandoMySQl.ExecuteReader()

        While (leitor.Read())
            Dim packetdata = leitor.GetString("sector")
            activityCompany.Items.Add(packetdata)
        End While

        leitor.Close()
        dba.connectorRemoverORAdder.Close()
    End Sub

    Private Sub closer_Click(sender As Object, e As EventArgs) Handles backtoLogin.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub maximize_Click(sender As Object, e As EventArgs)
        'Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        companyNamee.Focus()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        nuitCompany.Focus()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        countryCompany.Focus()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        countryCompany.Focus()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        alvaraCompany.Focus()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        regcomercialCompany.Focus()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        phoneCompany.Focus()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        emailCompany.Focus()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        locationCompany.Focus()
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        activityCompany.Focus()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        activityCompany.Focus()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        yearsinactivity.Focus()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        yearsinactivity.Focus()
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        firstname.Focus()
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        lastname.Focus()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        countryUser.Focus()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        countryUser.Focus()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        jobTitle.Focus()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        idCard.Focus()
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        emailUser.Focus()
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        phoneUser.Focus()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        locationUser.Focus()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        userpassword1.Focus()
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        userpassword2.Focus()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        provinceCompany.Focus()
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        provinceUser.Focus()
    End Sub

    Private Sub nuitButton_Click(sender As Object, e As EventArgs) Handles nuitButton.Click
        OpenFileSelector.ShowDialog()
        nuitlabel.Text = OpenFileSelector.FileName.Substring(OpenFileSelector.FileName.LastIndexOf("\") + 1)
    End Sub

    Private Sub alvaraButton_Click(sender As Object, e As EventArgs) Handles alvaraButton.Click
        OpenFileSelector.ShowDialog()
        alvaralabel.Text = OpenFileSelector.FileName.Substring(OpenFileSelector.FileName.LastIndexOf("\") + 1)
    End Sub

    Private Sub regcometcialButton_Click(sender As Object, e As EventArgs) Handles regcometcialButton.Click
        OpenFileSelector.ShowDialog()
        regcomerciallabel.Text = OpenFileSelector.FileName.Substring(OpenFileSelector.FileName.LastIndexOf("\") + 1)
    End Sub

    Private Sub brepublicaButton_Click(sender As Object, e As EventArgs) Handles brepublicaButton.Click
        OpenFileSelector.ShowDialog()
        brepublicalabel.Text = OpenFileSelector.FileName.Substring(OpenFileSelector.FileName.LastIndexOf("\") + 1)
    End Sub

    Private Sub bankstatementButton_Click(sender As Object, e As EventArgs) Handles bankstatementButton.Click
        OpenFileSelector.ShowDialog()
        bankstatementlabel.Text = OpenFileSelector.FileName.Substring(OpenFileSelector.FileName.LastIndexOf("\") + 1)
    End Sub

    Private Sub anualreportButton_Click(sender As Object, e As EventArgs) Handles anualreportButton.Click
        OpenFileSelector.ShowDialog()
        anualreportlabel.Text = OpenFileSelector.FileName.Substring(OpenFileSelector.FileName.LastIndexOf("\") + 1)
    End Sub

    Private Sub countryCompany_TextChanged(sender As Object, e As EventArgs) Handles countryCompany.TextChanged
        provinceCompany.Items.Clear()
        Dim code As Integer = Integer.Parse(dba.getCountryCode(countryCompany.SelectedItem))

        Dim query As String = "Select * from provinces where countrycode = " & code
        dba.connectorAdder()
        comandoMySQl = New MySqlCommand(query, dba.connectorRemoverORAdder)
        leitor = comandoMySQl.ExecuteReader()

        While (leitor.Read())
            Dim packetdata = leitor.GetString("provincename")
            provinceCompany.Items.Add(packetdata)
        End While

        leitor.Close()
        dba.connectorRemoverORAdder.Close()
    End Sub

    Private Sub provinceCompany_TextChanged(sender As Object, e As EventArgs) Handles provinceCompany.TextChanged
        cityCompany.Items.Clear()
        Dim code As Integer = Integer.Parse(dba.getProvinceCode(provinceCompany.SelectedItem))

        Dim query As String = "Select * from cities where provincesid = " & code
        dba.connectorAdder()
        comandoMySQl = New MySqlCommand(query, dba.connectorRemoverORAdder)
        leitor = comandoMySQl.ExecuteReader()

        While (leitor.Read())
            Dim packetdata = leitor.GetString("citynames")
            cityCompany.Items.Add(packetdata)
        End While

        leitor.Close()
        dba.connectorRemoverORAdder.Close()
    End Sub

    Private Sub countryUser_TextChanged(sender As Object, e As EventArgs) Handles countryUser.TextChanged
        provinceUser.Items.Clear()
        Dim code As Integer = Integer.Parse(dba.getCountryCode(countryUser.SelectedItem))

        Dim query As String = "Select * from provinces where countrycode = " & code
        dba.connectorAdder()
        comandoMySQl = New MySqlCommand(query, dba.connectorRemoverORAdder)
        leitor = comandoMySQl.ExecuteReader()

        While (leitor.Read())
            Dim packetdata = leitor.GetString("provincename")
            provinceUser.Items.Add(packetdata)
        End While

        leitor.Close()
        dba.connectorRemoverORAdder.Close()
    End Sub

    Private Sub provinceUser_TextChanged(sender As Object, e As EventArgs) Handles provinceUser.TextChanged
        cityUser.Items.Clear()
        Dim code As Integer = Integer.Parse(dba.getProvinceCode(provinceUser.SelectedItem))

        Dim query As String = "Select * from cities where provincesid = " & code
        dba.connectorAdder()
        comandoMySQl = New MySqlCommand(query, dba.connectorRemoverORAdder)
        leitor = comandoMySQl.ExecuteReader()

        While (leitor.Read())
            Dim packetdata = leitor.GetString("citynames")
            cityUser.Items.Add(packetdata)
        End While

        leitor.Close()
        dba.connectorRemoverORAdder.Close()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click

        If (companyNamee.Text <> "company name" Or companyNamee.Text = "") Then
            If (nuitCompany.Text <> "nuit" Or nuitCompany.Text = "") Then
                If (alvaraCompany.Text <> "alvara" Or alvaraCompany.Text = "") Then
                    If (regcomercialCompany.Text <> "reg. comercial" Or regcomercialCompany.Text = "") Then
                        If (phoneCompany.Text <> "contact number" Or phoneCompany.Text = "") Then
                            If (emailCompany.Text <> "e-mail address" Or phoneCompany.Text = "") Then
                                If (locationCompany.Text <> "location / physical address" Or phoneCompany.Text = "") Then
                                    If (yearsinactivity.Text <> "") Then
                                        If (countryCompany.SelectedItem) = "" Then
                                            If (provinceCompany.SelectedItem) = "" Then
                                                If (cityCompany.SelectedItem) = "" Then
                                                    If (activityCompany.SelectedItem) = "" Then
                                                        status = status + 1
                                                        company = companyNamee.Text
                                                        yearsactivity = yearsinactivity.Text
                                                        city_company = cityCompany.SelectedItem
                                                        province_company = provinceCompany.SelectedItem
                                                        nuit_company = nuitCompany.Text
                                                        alvara_company = alvaraCompany.Text
                                                        country_company = countryCompany.SelectedItem
                                                        location_company = locationCompany.Text
                                                        activity_company = activityCompany.SelectedItem
                                                        contact_company = phoneCompany.Text
                                                        email_company = emailCompany.Text
                                                        regcomercial_company = regcomercialCompany.Text
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If (firstname.Text <> "first name" Or firstname.Text = "") Then
            If (lastname.Text <> "last name" Or lastname.Text = "") Then
                If (jobTitle.Text <> "position" Or jobTitle.Text = "") Then
                    If (idCard.Text <> "identification card number" Or idCard.Text = "") Then
                        If (emailUser.Text <> "e-mail address" Or idCard.Text = "") Then
                            If (locationUser.Text <> "location / physical address" Or locationUser.Text = "") Then
                                If (userpassword1.Text <> "password" Or locationUser.Text = "") Then
                                    If (userpassword2.Text <> "confirm password" Or locationUser.Text = "") Then
                                        If (countryUser.SelectedItem) = "" Then
                                            If (provinceUser.SelectedItem) = "" Then
                                                If (cityUser.SelectedItem) = "" Then
                                                    If (phoneUser.Text) = "" Then
                                                        If (userpassword2.Text) = (userpassword1.Text) Then
                                                            status = status + 1
                                                            firstname_user = firstname.Text
                                                            last_name = lastname.Text
                                                            country_user = countryUser.SelectedItem
                                                            province_user = provinceUser.SelectedItem
                                                            city_user = cityUser.SelectedItem
                                                            email_user = emailUser.Text
                                                            location_user = locationUser.Text
                                                            password1_user = userpassword1.Text
                                                            password2_user = userpassword1.Text
                                                            contact_user = phoneUser.Text
                                                            id_user = idCard.Text
                                                            position_user = jobTitle.Text
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If status = 0 Then
            MsgBox("It's missing an information yet. Please Review the fields in Company and About You.")
        ElseIf status = 1 Then
            ACTab1.TabPages.Insert(0, ACYou)
            ACTab1.TabPages.Remove(ACCompany)
        ElseIf status > 1 Then
            Me.Close()
        End If

    End Sub

    Private Sub ACYou_Enter(sender As Object, e As EventArgs) Handles ACYou.Enter
        Label4.Text = company
    End Sub
End Class