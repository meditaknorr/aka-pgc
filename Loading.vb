Public Class Loading
    Dim dba As New dbamanager()
    Dim closeForm As Boolean = False
    Dim status As Boolean = True
    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Temporizador_Tick(sender As Object, e As EventArgs) Handles Temporizador.Tick
        If (status) Then
            Me.Hide()
            Temporizador.Enabled = False
            Home.Show()
        Else
            loadingstatus.Text = "Could't connect. Please try again"
            closeForm = True
            Temporizador.Enabled = False
            formCloser.Enabled = True
        End If

    End Sub

    Private Sub formCloser_Tick(sender As Object, e As EventArgs) Handles formCloser.Tick
        If (closeForm) Then
            formCloser.Enabled = False
            Application.ExitThread()

        End If
    End Sub
End Class