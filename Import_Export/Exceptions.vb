Module Exceptions
    Private NotInheritable Class ExceptionType
        Inherits Exception
        Public Overrides ReadOnly Property Message As String
        Public Overrides ReadOnly Property Data As IDictionary

        Protected Sub New(message As String)
            Me.Message = message
        End Sub
        Protected Sub New(message As String, Data As IDictionary)
            Me.Message = message
            Me.Data = Data
        End Sub
    End Class
    Public Class ExportException
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

    Public Class InternalException
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

    Public Class DbConnectionException
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

    Public Class DbCredentialException
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

    Public Class DbCreateException
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
    Public Class FileAccessException
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
    Public Class FileCreateException
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
