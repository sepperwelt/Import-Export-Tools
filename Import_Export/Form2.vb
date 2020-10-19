' This File is part of the program 'Import-Export-Tools für DigiKam', licensed under GNU General Public License Version 3.
' You should have received a copy Of the GNU General Public License along with 'Import-Export-Tools für DigiKam'.  If Not, see <http: //www.gnu.org/licenses/>.
' (c) Copyright  Laurenz Vogt, 2017-2019


Imports Import_Export.Objects
Imports Import_Export.Objects.MySQL
Imports System.IO

Public Class Form2
    'Dim con As MySQLConnection = New MySQLConnection
    Dim MySQL_Folder As String
    Dim Backup_Folder As String
    Dim Import_Folder As String
    Friend MyCon As MySQLConnector = New MySQLConnector
    Dim Port As Int16

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Txt_User.Text = INIDatei.WertLesen("Con", "User")
            Txt_Pass.Text = INIDatei.WertLesen("Con", "Pass")
            Txt_Host.Text = INIDatei.WertLesen("Con", "Host")
            Txt_Port.Text = INIDatei.WertLesen("Con", "Port")
            Txt_DB.Text = INIDatei.WertLesen("DB", "DB1")
            Txt_MySQL.Text = INIDatei.WertLesen("MySQL", "MySQL-Folder")
            Txt_Backup.Text = INIDatei.WertLesen("Settings", "Backup")
            Txt_Import.Text = INIDatei.WertLesen("Settings", "Import")
            CB_Date.Checked = INIDatei.WertLesen("Settings", "Date")
            CB_Time.Checked = INIDatei.WertLesen("Settings", "Time")

        Catch ex As Exception
            Faults.ErrHandler(911, , "The required setup.ini could not be opened or found.")
            Exit Try
        End Try

        Try
            Port = INIDatei.WertLesen("Con", "Port")
            Port = CDbl(Port)

        Catch
            Exit Try
        End Try
    End Sub

    Private Sub Settings_Close()
        Me.Hide()
        Form1.Visible = False
        Form1.Close()
        Form1.ShowDialog()

    End Sub

#Region "Dialogs"
    ' DB Test - Button
    Private Sub Btn_Test_Click(sender As Object, e As EventArgs) Handles Btn_Test.Click
        MyCon.TestConnection(Txt_Host.Text, Txt_User.Text, Txt_Pass.Text, Txt_DB.Text, Txt_Port.Text)
    End Sub

    ' MySQL-Folder - OpenDialog
    Private Sub Btn_Folder_Click(sender As Object, e As EventArgs) Handles Btn_Folder.Click
        FBD_MySQL.ShowDialog()
        MySQL_Folder = FBD_MySQL.SelectedPath
        Txt_MySQL.Text = FBD_MySQL.SelectedPath
    End Sub

    Private Sub Txt_MySQL_TextChanged(sender As Object, e As EventArgs) Handles Txt_MySQL.TextChanged
        MySQL_Folder = Txt_MySQL.Text
    End Sub

    Private Sub Btn_Backup_Click(sender As Object, e As EventArgs) Handles Btn_Backup.Click
        FBD_Backup.ShowDialog()
        Backup_Folder = FBD_Backup.SelectedPath
        Txt_Backup.Text = FBD_Backup.SelectedPath
    End Sub

    Private Sub Txt_Backup_TextChanged(sender As Object, e As EventArgs) Handles Txt_Backup.TextChanged
        Backup_Folder = Txt_Backup.Text
    End Sub

    Private Sub Btn_Import_Click(sender As Object, e As EventArgs) Handles Btn_Import.Click
        FBD_Import.ShowDialog()
        Import_Folder = FBD_Import.SelectedPath
        Txt_Import.Text = FBD_Import.SelectedPath
    End Sub

    Private Sub Txt_Import_TextChanged(sender As Object, e As EventArgs) Handles Txt_Import.TextChanged
        Import_Folder = Txt_Import.Text
    End Sub

    Private Sub CB_Date_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Date.CheckedChanged
        If CB_Date.Checked = True Then
            'INIDatei.WertSchreiben("Settings", "Date", "True")
            CB_Time.Enabled = True
        Else
            'INIDatei.WertSchreiben("Settings", "Date", "False")
            CB_Time.Checked = False
            CB_Time.Enabled = False
        End If
    End Sub

#End Region
#Region "Apply"
    ' Save Settings
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        INIDatei.Pfad = Form1.INIPfad + "\setup.ini"

        If Not My.Computer.FileSystem.FileExists(INIDatei.Pfad) Then
            My.Computer.FileSystem.CreateDirectory(Form1.INIPfad)
            File.Create(INIDatei.Pfad)
        End If

        INIDatei.WertSchreiben("Con", "User", Txt_User.Text)
        INIDatei.WertSchreiben("Con", "Pass", Txt_Pass.Text)
        INIDatei.WertSchreiben("Con", "Host", Txt_Host.Text)
        INIDatei.WertSchreiben("Con", "Port", Txt_Port.Text)
        INIDatei.WertSchreiben("DB", "DB1", Txt_DB.Text)
        INIDatei.WertSchreiben("MySQL", "MySQL-Folder", Txt_MySQL.Text)
        INIDatei.WertSchreiben("Settings", "Backup", Txt_Backup.Text)
        INIDatei.WertSchreiben("Settings", "Import", Txt_Import.Text)
        INIDatei.WertSchreiben("Settings", "Date", CB_Date.Checked)
        INIDatei.WertSchreiben("Settings", "Time", CB_Time.Checked)

        Info.ErrHandler(602)
        Form1.Close()

        'Settings_Close()
    End Sub

    ' Abort - Button
    Private Sub Btn_Abort_Click(sender As Object, e As EventArgs) Handles Btn_Abort.Click
        Me.Close()
    End Sub
#End Region
End Class