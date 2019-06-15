Public Class Style

    Shared Sub Link(ByRef link As Object)
        link.ForeColor = Color.Gray
    End Sub

    Shared Sub Link_MouseHover(ByRef link As Object)
        link.ForeColor = Color.DimGray
    End Sub

End Class
