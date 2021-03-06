﻿' This File is part of the program 'Import-Export-Tools für DigiKam', licensed under GNU General Public License Version 3.
' You should have received a copy Of the GNU General Public License along with 'Import-Export-Tools für DigiKam'.  If Not, see <http: //www.gnu.org/licenses/>.
' (c) Copyright  Laurenz Vogt, 2017-2019


Option Explicit On

Namespace Objects
    Module Functions
        Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

        Public Class Query
#Region "Properties"
            Private Shared _R As Int16
            Private Shared _mysqldump As String
            'Friend Shared mysqldump As String = INIDatei.WertLesen("MySQL", "mysqldump")

            Friend Shared Property Mysqldump As String
                Set(file As String)
                    _mysqldump = INIDatei.WertLesen("MySQL", "MySQL-Folder") + file
                End Set
                Get
                    Return "" + _mysqldump + ""
                End Get
            End Property

            Public ReadOnly Property Back As Int16
                Get
                    Return _R
                End Get
            End Property

            Private Sub Store(ByVal Var As Int16)
                _R = Var
            End Sub
#End Region

            Public Shared Sub Execute_Query(ByVal Pfad As String, ByVal Host As String, ByVal User As String, ByVal Pass As String, ByVal DB As String, Optional ByVal Import_true As Boolean = False, Optional ByVal Port As Int16 = 3306)
                Dim Connectionstring As String
                Dim Query_Process As New Process

                'MessageBox.Show(Pfad)

                If Import_true = False Then
                    If My.Computer.FileSystem.FileExists(Pfad) = True Then
                        Dim result As Int16 = Warnings.ErrHandler(802, Pfad)

                        If result = 0 Then
                            Warnings.ErrHandler(801)
                            Exit Sub
                        ElseIf result = 1 Then
                            My.Computer.FileSystem.DeleteFile(Pfad)
                        Else
                            Warnings.ErrHandler(899)
                        End If
                    End If

                    Connectionstring = "--column-statistics=0 --events --routines --triggers --comments -l -c --host=" & Host & " --user=" & User & " --password=" & Pass & " --port=" & Port & " --result-file=" & Pfad & " " & DB
                    'MessageBox.Show(Connectionstring)
                    Query.Mysqldump = "\mysqldump.exe"
                    'MessageBox.Show(Query.Mysqldump)

                    Query_Process.StartInfo.UseShellExecute = False
                    Query_Process.StartInfo.FileName = Query.Mysqldump
                    Query_Process.StartInfo.CreateNoWindow = True
                    Query_Process.StartInfo.Arguments = Connectionstring

                    Try
                        Query_Process.Start()

                    Catch ex As Exception
                        Faults.ErrHandler(904, ex.ToString)
                        Query_Process.Kill()
                        _R = 1
                    End Try
                ElseIf Import_true = True Then
                    'MessageBox.Show(Pfad)
                    If My.Computer.FileSystem.FileExists(Pfad) = False Then
                        Faults.ErrHandler(908)
                        Exit Sub
                    End If

                    Connectionstring = "--host=" & Host & " --user=" & User & " --password=" & Pass & " --port=" & Port & " " & DB & " < " & Pfad
                    'MessageBox.Show(Connectionstring)
                    Query.Mysqldump = "\mysql.exe"
                    'MessageBox.Show(Query.Mysqldump)

                    Query_Process.StartInfo.UseShellExecute = False
                    Query_Process.StartInfo.FileName = Query.Mysqldump
                    Query_Process.StartInfo.CreateNoWindow = True
                    Query_Process.StartInfo.Arguments = Connectionstring

                    Try
                        CreateDB(Host, User, Pass, DB, Port)
                        'Sleep(10000)
                        Query_Process.Start()

                    Catch ex As Exception
                        Faults.ErrHandler(904, ex.ToString)
                        Query_Process.Kill()
                        _R = 1
                    End Try
                Else
                    Faults.ErrHandler(900)
                    Exit Sub
                End If
            End Sub

            Friend Shared Sub CreateDB(ByVal Host As String, ByVal User As String, ByVal Pass As String, ByVal DB As String, Optional ByVal Port As Int16 = 3306)
                Dim Connectionstring As String
                Dim Create_Process As New Process

                Connectionstring = "--host=" & Host & " --user=" & User & " --password=" & Pass & " --port=" & Port & " --execute=""create database if not exists " & DB & """"
                'MessageBox.Show(Connectionstring)
                Query.Mysqldump = "\mysql.exe"
                'MessageBox.Show(Query.Mysqldump)

                Create_Process.StartInfo.UseShellExecute = False
                Create_Process.StartInfo.FileName = Query.Mysqldump
                Create_Process.StartInfo.CreateNoWindow = True
                Create_Process.StartInfo.Arguments = Connectionstring

                Try
                    Create_Process.Start()

                Catch ex As Exception
                    Faults.ErrHandler(909, ex.Message)
                    Create_Process.Kill()
                    _R = 1
                End Try
            End Sub
        End Class
    End Module
End Namespace