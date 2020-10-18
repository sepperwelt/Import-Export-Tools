Module Exceptions
    Private NotInheritable Class ErrType
        Inherits Exception
        Public Overrides ReadOnly Property Message As String
        Public Overrides ReadOnly Property Data As IDictionary

        Public Sub New(message As String)
            Me.Message = message
        End Sub
        Public Sub New(message As String, Data As IDictionary)
            Me.Message = message
            Me.Data = Data
        End Sub
    End Class
End Module
