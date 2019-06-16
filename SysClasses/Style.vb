Public Class Style

    Shared Sub Link(ByRef link As Object)
        link.ForeColor = Color.Gray
    End Sub

    Shared Sub Link_MouseHover(ByRef link As Object)
        link.ForeColor = Color.DimGray
    End Sub

    Shared Sub Tile_MouseHover(ByRef tile As Object)
        tile.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Shared Sub Tile(ByRef tile As Object)
        tile.BackgroundImageLayout = ImageLayout.None
    End Sub

End Class
