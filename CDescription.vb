Imports System.IO
Public Class CDescription
    Private Sub closer_Click(sender As Object, e As EventArgs) Handles closer.Click, Button1.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub CDescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True
        Using writer As StreamWriter = New StreamWriter(IO.Path.GetFullPath(".\SysPages\CDescription.html"))
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
        CDBrowser.Navigate("file:///" & IO.Path.GetFullPath(".\SysPages\CDescription.html"))
    End Sub
End Class