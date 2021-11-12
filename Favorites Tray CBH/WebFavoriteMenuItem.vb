Public Class WebFavoriteMenuItem
    Inherits MenuItem

    'Public member
    Public Favorite As WebFavorite

    'Constructor
    Public Sub New(ByVal newFavorite As WebFavorite)
        'Set the property
        Favorite = newFavorite
        'Update the text
        Text = Favorite.Name
    End Sub

    Private Sub WebFavoriteMenuItem_Click(sender As Object, e As EventArgs) Handles Me.Click
        'Open the favorite
        If Not Favorite Is Nothing Then
            Process.Start(Favorite.Url)
        End If
    End Sub
End Class
