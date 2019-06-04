Imports System.IO
Imports MySql.Data.MySqlClient
Public Class UserBoard
    Dim dba As New dbamanager()
    Dim language As String = "EN"
    Private comandoMySQl As MySqlCommand
    Private leitor As MySqlDataReader

    Private Sub UserBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using writer As StreamWriter = New StreamWriter(IO.Path.GetFullPath(".\HPages\CDescription.html"))
            Dim HTML As String = "
                                <!DOCTYPE html>

                                <html>
                                <head>
                                    <meta charset='utf-8' />
                                    <title> teste </title>
                                </head>
                                <body>
                                    <b>Nao ehnteste</b>
                                </body>
                                </html>
                                "
            writer.Write(HTML)
        End Using
        CAppliedbyme.Navigate("file:///" & IO.Path.GetFullPath(".\HPages\CAppliedbyme.html"))

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

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Close()
        Home.Show()
    End Sub
End Class