' This File is part of the program 'Import-Export-Tools für DigiKam', licensed under GNU General Public License Version 3.
' You should have received a copy Of the GNU General Public License along with 'Import-Export-Tools für DigiKam'.  If Not, see <http: //www.gnu.org/licenses/>.
' (c) Copyright  Laurenz Vogt, 2017-2019


Public Class INIDatei
    ' -------------------------------------------------------------------------------------------------------
    ' --- Diese Klasse besteht aus leicht geändertem Code von 'Anonymous', Veröffentlichung am 30.08.2008 ---
    ' ---   unter 'https://dotnet-snippets.de/snippet/klasse-fuer-verwendung-von-ini-dateien/938'.        ---
    ' --- Grundlage bildet die kernel32.dll-Klassenbibilothek von Windows.                                ---
    ' -------------------------------------------------------------------------------------------------------


    ' DLL-Funktionen zum LESEN der INI deklarieren
    Private Declare Ansi Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (
        ByVal lpApplicationName As String, ByVal lpSchlüsselName As String, ByVal lpDefault As String,
        ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer

    'DLL-Funktion zum SCHREIBEN in die INI deklarieren
    Private Declare Ansi Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (
        ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String,
        ByVal lpFileName As String) As Integer

    'DLL-Funktion zum Löschen einer ganzen Sektion deklarieren
    Private Declare Ansi Function DeletePrivateProfileSection Lib "kernel32" Alias "WritePrivateProfileStringA" (
        ByVal Section As String, ByVal NoKey As Integer, ByVal NoSetting As Integer,
    ByVal FileName As String) As Integer

    ' Öffentliche Klassenvariablen
    Public Shared Pfad As String

    Public Shared Function WertLesen(ByVal Sektion As String, ByVal Schlüssel As String, Optional ByVal Standardwert As String = "", Optional ByVal BufferSize As Integer = 1024) As String
        ' Testen, ob ein Pfad zur INI vorhanden ist
        If Pfad = "" Then
            Throw New Exception("INI-Fehler. ErrCode: #01" & vbNewLine & vbNewLine & "Es ist kein Pfad zur INI angegeben. Deshalb ist das Auslesen des Wertes nicht möglich." _
        & vbCrLf & vbCrLf & "Angeforderte Sektion: " & Sektion & vbCrLf & "Angeforderter Schlüssel: " _
        & Schlüssel)
            WertLesen = "Lesefehler"
            Exit Function
        End If

        ' Testen, ob die Datei existiert
        If IO.File.Exists(Pfad) = False Then
            Throw New Exception("INI-Fehler. ErrCode: #02" & vbNewLine & vbNewLine & "Die angegebene INI-Datei exstiert auf diesem Rechner nicht. Deshalb ist das " _
        & "Auslesen des Wertes nicht möglich." & vbCrLf & vbCrLf & "INI-Datei: " & Pfad _
        & vbCrLf & "Angeforderte Sektion: " & Sektion & vbCrLf & "Angeforderter Schlüssel: " _
        & Schlüssel)
            WertLesen = "Lesefehler"
            Exit Function
        End If

        ' Auslesen des Wertes
        Dim sTemp As String = Space(BufferSize)
        Dim Length As Integer = GetPrivateProfileString(Sektion, Schlüssel, Standardwert, sTemp, BufferSize, Pfad)
        Return Left(sTemp, Length)
    End Function

    Public Shared Function WertSchreiben(ByVal Sektion As String, ByVal Schlüssel As String, ByVal Wert As String)
        ' Testen, ob ein Pfad zur INI vorhanden ist
        If Pfad = "" Then
            Throw New Exception("INI-Fehler. ErrCode: #03" & vbNewLine & vbNewLine & "Es ist kein Pfad zur INI angegeben. Deshalb ist das Schreiben des Wertes nicht möglich." _
        & vbCrLf & vbCrLf & "Angeforderte Sektion: " & Sektion & vbCrLf & "Zu schreibender Schlüssel: " _
        & Schlüssel)

            Return 2
            Exit Function
        End If

        ' Testen, ob der Order, in dem die INI liegen soll, existiert
        Dim Ordner As String
        Ordner = IO.Path.GetDirectoryName(Pfad)
        If IO.Directory.Exists(Ordner) = False Then
            Throw New Exception("INI-Fehler. ErrCode: #04" & vbNewLine & vbNewLine & "Die angegebene Ordner für die INI-Datei exstiert auf diesem Rechner nicht. Deshalb ist das " _
        & "Schreiben des Wertes nicht möglich." & vbCrLf & vbCrLf & "Fehlender Ordner: " & Ordner _
        & vbCrLf & "Angeforderte Sektion: " & Sektion & vbCrLf & "Zu schreibender Schlüssel: " _
        & Schlüssel)

            Return 1
            Exit Function
        End If

        ' Schreiben in die INI durchführen
        WritePrivateProfileString(Sektion, Schlüssel, Wert, Pfad)
        Return 0
    End Function

    Public Shared Function SchlüsselLöschen(ByVal Sektion As String, ByVal Schlüssel As String)
        ' Testen, ob ein Pfad zur INI vorhanden ist
        If Pfad = "" Then
            MsgBox("Es ist kein Pfad zur INI angegeben. Deshalb ist das Löschen des Schlüssels nicht möglich." _
        & vbCrLf & vbCrLf & "Angeforderte Sektion: " & Sektion & vbCrLf & "Zu löschender Schlüssel: " _
        & Schlüssel, MsgBoxStyle.Exclamation, "Pfad zur INI-Datei fehlt")

            Return 2
            Exit Function
        End If

        ' Testen, ob die der Order, in dem die INI liegen soll, existiert
        Dim Ordner As String
        Ordner = IO.Path.GetDirectoryName(Pfad)
        If IO.Directory.Exists(Ordner) = False Then
            MsgBox("Die angegebene Ordner für die INI-Datei exstiert auf diesem Rechner nicht. Deshalb ist das " _
        & "Löschen des Wertes nicht möglich." & vbCrLf & vbCrLf & "Fehlender Ordner: " & Ordner _
        & vbCrLf & "Angeforderte Sektion: " & Sektion & vbCrLf & "Zu löschender Schlüssel: " _
        & Schlüssel, MsgBoxStyle.Exclamation, "Pfad zur INI-Datei existiert nicht")

            Return 1
            Exit Function
        End If

        ' Löschen des Schlüssels durch eine Schreiboperation durchführen
        WritePrivateProfileString(Sektion, Schlüssel, Nothing, Pfad)
        Return 0
    End Function

    Public Shared Function SektionLöschen(ByVal Sektion As String)
        ' Testen, ob ein Pfad zur INI vorhanden ist
        If Pfad = "" Then
            MsgBox("Es ist kein Pfad zur INI angegeben. Deshalb ist das Löschen der Sektion nicht möglich." _
        & vbCrLf & vbCrLf & "Angeforderte Sektion: " & Sektion, MsgBoxStyle.Exclamation,
        "Pfad zur INI-Datei fehlt")

            Return 2
            Exit Function
        End If

        ' Testen, ob die Datei existiert
        If IO.File.Exists(Pfad) = False Then
            MsgBox("Die angegebene INI-Datei exstiert auf diesem Rechner nicht. Deshalb ist das " _
        & "Löschen der Sektion nicht möglich." & vbCrLf & vbCrLf & "INI-Datei: " & Pfad _
        & vbCrLf & "Angeforderte Sektion: ", MsgBoxStyle.Exclamation, "Pfad zur INI-Datei fehlt")

            Return 1
            Exit Function
        End If

        'Löschen der Sektion durchführen
        DeletePrivateProfileSection(Sektion, 0, 0, Pfad)
        Return 0
    End Function

    Public Shared Function BackupAnlegen(ByVal Zielpfad As String, Optional ByVal FehlermeldungAnzeigen As Boolean = False)
        'Als Zielpfad muss ein DATEIpfad angegeben werden, nicht nur der Ordner
        ' (also z.B. "D:\Test\MeinProgrammEinstellungen_Backup.ini"

        ' Testen, ob ein Pfad zur INI (der Quelldatei) vorhanden ist
        If Pfad = "" Then
            If FehlermeldungAnzeigen = True Then
                MsgBox("Es ist kein Pfad zur INI, von der ein Backup angelegt werden soll, angegeben." _
            & "Das Backup konnte NICHT angelegt werden.", MsgBoxStyle.Exclamation, "Pfad zur INI-Datei fehlt")
            End If

            Return 2
            Exit Function
        End If

        ' Testen, ob der Ordner des Zielpfades existiert
        Dim Ordner As String
        Ordner = IO.Path.GetDirectoryName(Pfad)
        If IO.Directory.Exists(Ordner) = False Then
            If FehlermeldungAnzeigen = True Then
                MsgBox(Zielpfad & vbCrLf & vbCrLf & "Dieser Ordner existiert nicht." _
           & vbCrLf & vbCrLf & "Das Backup konnte NICHT angelegt werden.", MsgBoxStyle.Exclamation,
           "Zielordner existiert nicht")
            End If

            Return 1
            Exit Function
        End If
        ' Kopie der INI erstellen
        IO.File.Copy(Pfad, Zielpfad)
        Return 0
    End Function

    Private Shared Function DateiLöschen(Optional ByVal FehlermeldungAnzeigen As Boolean = False)
        ' Testen, ob ein Pfad zur INI (der Quelldatei) vorhanden ist
        If Pfad = "" Then
            If FehlermeldungAnzeigen = True Then
                MsgBox("Es ist kein Pfad zur INI, die gelöscht werden soll, angegeben." _
            & "Das Löschen konnte NICHT durchgeführt werden.", MsgBoxStyle.Exclamation, "Pfad zur INI-Datei fehlt")
            End If

            Return 2
            Exit Function
        End If

        ' Testen, ob die Datei existiert
        If IO.File.Exists(Pfad) = False Then
            If FehlermeldungAnzeigen = True Then
                MsgBox(Pfad & vbCrLf & vbCrLf & "Diese Datei existiert bereits nicht mehr. " _
            & "Das Löschen hat sich damit erübrigt.", MsgBoxStyle.Exclamation,
           "Datei existiert nicht mehr")
            End If

            Return 1
            Exit Function
        End If

        ' Löschen durchführen
        IO.File.Delete(Pfad)
        Return 0
    End Function

End Class
