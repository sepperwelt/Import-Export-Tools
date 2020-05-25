' This File is part of the program 'Import-Export-Tools für DigiKam', licensed under GNU General Public License Version 3.
' You should have received a copy of the GNU General Public License along with 'Import-Export-Tools für DigiKam'.  If Not, see <http://www.gnu.org/licenses/>.
' (c) Copyright  Laurenz Vogt, 2017-2019

Option Explicit On
Imports MySql.Data.MySqlClient

Namespace Objects
    Public Module MySQL
        Public Class MySQLConnector
#Region "Properties"
            Private ReadOnly _ConStr As String
            'Private ReadOnly _MySQLQueryString As String

            Public Property Host As String
            Public Property User As String
            Public Property Pass As String
            Public Property DB As String
            Public Property Port As Int16
            Public Property MySQL_Folder As String
            Public Property ConnectionString As String
#End Region

#Region "Functions"
            Public Overloads Function TestConnection()
                If Not ConnectionString Or ConnectionString = "" Or ConnectionString = Nothing Then
                    Faults.ErrHandler(990, , "Es wurde kein Wert für 'ConnectionString' in 'MySQL.vb' angegeben.")
                    Return 1
                    Exit Function
                End If

                Dim Con As New MySqlConnection

                Try
                    Con.ConnectionString = ConnectionString
                    Con.Open()
                    'Verbindungsstatus:
                    If Con.State = ConnectionState.Open Then
                        Info.ErrHandler(600)
                    Else
                        Faults.ErrHandler(910)
                    End If
                Catch ex As MySqlException
                    Select Case ex.Number
                        Case 0
                            Faults.ErrHandler(910, , ex.Number)
                            Return 1
                            Exit Function
                        Case 1045
                            Faults.ErrHandler(907, , ex.Number)
                            Return 1
                            Exit Function

                        Case Else
                            Faults.ErrHandler(910, , ex.Number)
                            Return 1
                            Exit Function
                    End Select
                    Return 0

                    Exit Function
                End Try

                Con.Close()
                Return 0
            End Function

            Public Overloads Function TestConnection(ByVal ConnectionString As String)
                If Not ConnectionString Or ConnectionString = "" Or ConnectionString = Nothing Then
                    Faults.ErrHandler(990, , "Es wurde kein Wert für 'ConnectionString' in 'MySQL.vb' angegeben.")
                    Return 1
                    Exit Function
                End If

                Dim Con As New MySqlConnection

                Try
                    Con.ConnectionString = ConnectionString
                    Con.Open()
                    'Verbindungsstatus:
                    If Con.State = ConnectionState.Open Then
                        Info.ErrHandler(600)
                    Else
                        Faults.ErrHandler(910)
                    End If
                Catch ex As MySqlException
                    Select Case ex.Number
                        Case 0
                            Faults.ErrHandler(910, , ex.Number)
                            Return 1
                            Exit Function
                        Case 1045
                            Faults.ErrHandler(907, , ex.Number)
                            Return 1
                            Exit Function

                        Case Else
                            Faults.ErrHandler(910, , ex.Number)
                            Return 1
                            Exit Function
                    End Select
                    Return 0

                    Exit Function
                End Try

                Con.Close()
                Return 0
            End Function

            Public Overloads Function TestConnection(ByVal Host As String, ByVal User As String, ByVal Pass As String, Optional ByVal Port As Int16 = 3306)
                Dim Con As New MySqlConnection
                ConnectionString = "server=" & Host & ";uid=" & User & ";pwd=" & Pass & ";database=" & DB & ";port=" & Port & ";"

                Try
                    Con.ConnectionString = ConnectionString
                    Con.Open()
                    'Verbindungsstatus:
                    If Con.State = ConnectionState.Open Then
                        Info.ErrHandler(600)
                    Else
                        Faults.ErrHandler(910)
                    End If
                Catch ex As MySqlException
                    Select Case ex.Number
                        Case 0
                            Faults.ErrHandler(910, , ex.Number)
                            Return 1
                            Exit Function
                        Case 1045
                            Faults.ErrHandler(907, , ex.Number)
                            Return 1
                            Exit Function

                        Case Else
                            Faults.ErrHandler(910, , ex.Number)
                            Return 1
                            Exit Function
                    End Select
                    Return 0

                    Exit Function
                End Try

                Con.Close()
                Return 0
            End Function

            Public Overloads Function TestConnection(ByVal Host As String, ByVal User As String, ByVal Pass As String, ByVal DB As String, Optional ByVal Port As Int16 = 3306)
                Dim Con As New MySqlConnection
                ConnectionString = "server=" & Host & ";uid=" & User & ";pwd=" & Pass & ";database=" & DB & ";port=" & Port & ";"

                Try
                    Con.ConnectionString = ConnectionString
                    Con.Open()
                    'Verbindungsstatus:
                    If Con.State = ConnectionState.Open Then
                        Info.ErrHandler(600)
                    Else
                        Faults.ErrHandler(910)
                    End If
                Catch ex As MySqlException
                    Select Case ex.Number
                        Case 0
                            Faults.ErrHandler(910, , ex.Number)
                            Return 1
                            Exit Function
                        Case 1045
                            Faults.ErrHandler(907, , ex.Number)
                            Return 1
                            Exit Function

                        Case Else
                            Faults.ErrHandler(910, , ex.Number)
                            Return 1
                            Exit Function
                    End Select
                    Return 0

                    Exit Function
                End Try

                Con.Close()
                Return 0
            End Function

#End Region
        End Class
    End Module
End Namespace