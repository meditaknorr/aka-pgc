Imports System.IO
Public Class UserBoard
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
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click, Button6.Click
        Me.Close()
        Home.Show()
    End Sub
End Class