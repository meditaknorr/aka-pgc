Imports System.Text

Public Class Session
    Private Shared usersession As String
    Dim allocated As List(Of StringBuilder) = New List(Of StringBuilder)

    Shared Function setSession(ByVal sessionString As String)
        usersession = sessionString
    End Function

    Shared Function getSession() As String
        Return usersession
    End Function

    Shared Function sessionExist() As Boolean
        If ((getSession() Is Nothing) Or (getSession() = "guest")) Then
            Return False
        Else
            Return True
        End If
    End Function

    Shared Function sessionDestroyer() As String
        Dim guest As String = "guest"
        setSession(guest)
        Return "guest"
    End Function

    Public Function generateSessionString() As String
        Dim s As String = "abcdefghijklmnopqrstuvwxz=_/|\-ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As Random = New Random
        Dim sb As StringBuilder = New StringBuilder
        Do
            For i As Integer = 1 To 20
                Dim idx As Integer = r.Next(0, 35) '26 letters + 10 digits
                sb.Append(s.Substring(idx, 1))
            Next
        Loop Until Not allocated.Contains(sb)
        allocated.Add(sb)
        Return sb.ToString()
    End Function

End Class
