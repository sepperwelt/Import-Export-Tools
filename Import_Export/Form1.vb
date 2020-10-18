' This File is part of the program 'Import-Export-Tools für DigiKam', licensed under GNU General Public License Version 3.
' You should have received a copy Of the GNU General Public License along with 'Import-Export-Tools für DigiKam'.  If Not, see <http: //www.gnu.org/licenses/>.
' (c) Copyright  Laurenz Vogt, 2017-2019

Option Explicit On
Imports Import_Export.Objects
Imports Import_Export.Objects.MySQL

Public Class Form1
    Dim Pfad As String
    Dim User As String
    Dim Recover As String
    Dim Pass As String
    Dim Host As String
    Dim Port As Double
    Dim Path As String
    Dim DB1 As String
    Dim Time_sel As Boolean
    Dim Date_sel As Boolean
    Dim Path_DB1 As String
    Dim Backup_Folder As String
    Dim Import_Folder As String
    Public INIPfad As String
    Friend MyCon As MySQLConnector = New MySQLConnector

    Function Query(Methode As Integer, Optional Path As String = Nothing)
        Select Case Methode
            Case 1  ' Export
                If (Path = Nothing) Then
                    Faults.ErrHandler(901)
                    Return 1
                    Exit Function
                End If


                Functions.Query.Execute_Query(Path, Host, User, Pass, DB1, False, Port)

                Return 0
                Exit Function

            Case 2  ' Import
                If (Path = Nothing) Then
                    Faults.ErrHandler(902)
                    Return 1
                    Exit Function
                End If

                Functions.Query.Execute_Query(Path, Host, User, Pass, DB1, True, Port)

                Info.ErrHandler(601)
                Return 0
                Exit Function

            Case Else
                Faults.ErrHandler(900)
                Return 1
                Exit Function
        End Select
        Notification.Warnings.ErrHandler(899)

        Return 1
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        INIPfad = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\Import_Export\"
        INIDatei.Pfad = INIPfad + "setup.ini"

        If Not My.Computer.FileSystem.FileExists(INIDatei.Pfad) Then
            Hints.ErrHandler(700)
            Exit Sub
        End If

        OFD_DB.FileName = INIDatei.WertLesen("DB", "DB1") + ".sql"

        Try
            User = INIDatei.WertLesen("Con", "User")
            Pass = INIDatei.WertLesen("Con", "Pass")
            Host = INIDatei.WertLesen("Con", "Host")
            Port = INIDatei.WertLesen("Con", "Port")
            DB1 = INIDatei.WertLesen("DB", "DB1")
            MyCon.MySQL_Folder = INIDatei.WertLesen("MySQL", "MySQL-Folder")
            Date_sel = INIDatei.WertLesen("Settings", "Date")
            Time_sel = INIDatei.WertLesen("Settings", "Time")
            Backup_Folder = INIDatei.WertLesen("Settings", "Backup")
            FBD_Save.RootFolder = Backup_Folder
            Import_Folder = INIDatei.WertLesen("Settings", "Import")

            If (Date_sel = False) And (Time_sel = True) Then
                INIDatei.WertSchreiben("Settings", "Date", "True")
            End If
        Catch
            Exit Try
        End Try

        If (Date_sel = True) Or (Time_sel = True) Then
            Label8.Text = "Date and Time are added to the file name after the process has started."
        Else
            Label8.Text = ""
        End If

        If (Backup_Folder = Nothing) Or (Backup_Folder = "") Then
            SBD_Save.InitialDirectory = Environment.SpecialFolder.MyComputer
            FBD_Save.RootFolder = Environment.SpecialFolder.MyComputer

        End If

        If (Import_Folder = Nothing) Or (Import_Folder = "") Then
            OFD_DB.InitialDirectory = Environment.SpecialFolder.MyComputer
        End If
    End Sub

#Region "Buttons"
    ' SaveDialog - Button
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        If (Date_sel = False) And (Time_sel = False) Then
            SBD_Save.ShowDialog()
            Path = SBD_Save.FileName
            Txt_Save.Text = SBD_Save.FileName
        Else
            FBD_Save.ShowDialog()
            Path = FBD_Save.SelectedPath
            Txt_Save.Text = FBD_Save.SelectedPath
        End If
    End Sub

    ' OpenDialog - Button
    Private Sub Btn_Load_Click(sender As Object, e As EventArgs) Handles Btn_Load.Click
        OFD_DB.ShowDialog()
        Txt_DB.Text = OFD_DB.FileName
        Path_DB1 = Txt_DB.Text

    End Sub

    ' Export-DB - Button
    Private Sub Btn_Export_Click(sender As Object, e As EventArgs) Handles Btn_Export.Click
        If (Date_sel = True) And (Time_sel = False) Then
            Path = Path &
                "\" & DateTime.Now.Year &
                "-" & DateTime.Now.Month &
                "-" & DateTime.Now.Day &
                ".sql"

        ElseIf (Date_sel = True) And (Time_sel = True) Then
            Path = Path &
                "\" & DateTime.Now.Year &
                "-" & DateTime.Now.Month &
                "-" & DateTime.Now.Day &
                "_" & DateTime.Now.Hour &
                "-" & DateTime.Now.Minute &
                "-" & DateTime.Now.Second &
                ".sql"
        End If


        Try
            Query(1, Path)      ' ### neue Meldung einfügen ###
            MessageBox.Show("The Database is exported successfully and the file is saved in the specified directory.", "Export successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Faults.ErrHandler(904, , ex.Message)
        End Try
    End Sub

    ' Import-DB - Button
    Private Sub Btn_Import_Click(sender As Object, e As EventArgs) Handles Btn_Import.Click
        Query(2, Txt_DB.Text)
    End Sub
#End Region

#Region "Menu"
    ' Menü konfigurieren

    Private Sub Menu_Imp_Click(sender As Object, e As EventArgs) Handles Menu_Imp.Click
        'Dim Impressum As String = "Import-Export-Tools für Digikam (ext. MySql)" & vbNewLine & "Dieses Programm wurde im Rahmen der Besonderen Lernleistung im Fach Informatik von Laurenz Vogt entwickelt." _
        '        & vbNewLine & vbNewLine & "(c) Laurenz Vogt" & vbNewLine & "(c) 2017-2019" & vbNewLine & "Alle Rechte vorbehalten." & vbNewLine & vbNewLine & "Vielen Dank an meinen Begleiter C. Stauch."

        'MessageBox.Show(Impressum, "Impressum", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Impressum.ShowDialog()
    End Sub

    ' Menü - Einstellungen
    Private Sub Menu_eig_Click(sender As Object, e As EventArgs) Handles Menu_eig.Click
        Form2.Show()
    End Sub

    ' Hilfe - MenuItem
    Private Sub Menu_Help_Click(sender As Object, e As EventArgs) Handles Menu_Help.Click
        Process.Start(INIPfad + "\Hilfe.chm")
    End Sub

    ' Programm schließen
    Private Sub Menu_Close_Click(sender As Object, e As EventArgs) Handles Menu_close.Click
        Me.Close()
    End Sub
#End Region
End Class