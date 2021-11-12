Public Class Favorites
    Implements IDisposable

    Private disposedValue As Boolean

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects)
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
            ' TODO: set large fields to null
            disposedValue = True
        End If
    End Sub

    ' ' TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
    ' Protected Overrides Sub Finalize()
    '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
    '     Dispose(disposing:=False)
    '     MyBase.Finalize()
    ' End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
        Dispose(disposing:=True)
        GC.SuppressFinalize(Me)
    End Sub

    'Public member
    Public FavoritesCollection As WebFavoriteCollection

    Public ReadOnly Property FavoritesFolder() As String
        Get
            'Return the path to the user’s Favorites folder
            Return Environment.GetFolderPath(
            Environment.SpecialFolder.Favorites)
        End Get
    End Property

    Public Sub ScanFavorites()
        'Scan the Favorites folder
        ScanFavorites(FavoritesFolder)
    End Sub
    Public Sub ScanFavorites(ByVal folderName As String)
        'If the FavoritesCollection member has not been instantiated
        'then instantiate it
        If FavoritesCollection Is Nothing Then
            FavoritesCollection = New WebFavoriteCollection
        End If
        'Process each file in the Favorites folder
        For Each strFile As String In
        My.Computer.FileSystem.GetFiles(folderName)
            'If the file has a url extension..
            If strFile.EndsWith(".url", True, Nothing) Then
                Try
                    'Create and use a new instance of the
                    'WebFavorite class
                    Using objWebFavorite As New WebFavorite
                        'Load the file information
                        objWebFavorite.Load(strFile)
                        'Add the object to the collection
                        FavoritesCollection.Add(objWebFavorite)
                    End Using
                Catch ExceptionErr As Exception
                    'Return the exception to the caller
                    Throw New Exception(ExceptionErr.Message)
                End Try
            End If
        Next
    End Sub
End Class
