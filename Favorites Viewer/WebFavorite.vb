Imports System.IO

Public Class WebFavorite
    Implements IDisposable


    Private disposedValue As Boolean = False        ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: free other state (managed objects).
            End If

            ' TODO: free your own state (unmanaged objects).
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

#Region " IDisposable Support "
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

    'Public Members
    Public Name As String
    Public Url As String

    Public Sub Load(ByVal fileName As String)
        'Declare variables
        Dim strData As String
        Dim strLines() As String
        Dim strLine As String
        Dim objFileInfo As New FileInfo(fileName)

        'Set the Name member to the file name minus the extension
        Name = objFileInfo.Name.Substring(0, _
            objFileInfo.Name.Length - objFileInfo.Extension.Length)

        Try
            'Read the entire contents of the file
            strData = My.Computer.FileSystem.ReadAllText(fileName)

            'Split the lines of data in the file
            strLines = strData.Split(New String() {ControlChars.CrLf}, _
                StringSplitOptions.RemoveEmptyEntries)

            'Process each line looking for the URL
            For Each strLine In strLines
                'Does the line of data start with URL=
                If strLine.StartsWith("URL=") Then
                    'Yes, set the Url member to the actual URL
                    Url = strLine.Substring(4)
                    'Exit the For..Next loop
                    Exit For
                End If
            Next
        Catch IOExceptionErr As IOException
            'Return the exception to the caller
            Throw New Exception(IOExceptionErr.Message)
        End Try
    End Sub

End Class
