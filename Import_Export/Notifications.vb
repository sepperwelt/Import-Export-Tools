' This File is part of the program 'Import-Export-Tools für DigiKam', licensed under GNU General Public License Version 3.
' You should have received a copy Of the GNU General Public License along with 'Import-Export-Tools für DigiKam'.  If Not, see <http: //www.gnu.org/licenses/>.
' (c) Copyright  Laurenz Vogt, 2017-2019

Option Explicit On

Namespace Objects
    Public Module Notification
        Class Faults
            Shared Sub ErrHandler(ErrCode As Int16, Optional Pfad As String = Nothing, Optional ex As String = Nothing)
                Select Case ErrCode
                    Case 900
                        MessageBox.Show("Fehler #900: Fehlerhaftes Argument in der Abfragenfunkton!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub

                    Case 901
                        MessageBox.Show("Fehler #901: Bitte geben Sie eine Datei zum Speichern und exportieren der Datenbank an!", "Fehler: Keine Datei angegeben", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        Exit Sub

                    Case 902
                        MessageBox.Show("Fehler #902: Bitte geben Sie eine Datei zum Laden und importieren der Datenbank an!", "Fehler: Keine Datei angegeben", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub

                    'Case 903
                    '    MessageBox.Show("Fehler #903: Beim Sichern der Datenbank ist ein Fehler aufgetreten. " & vbNewLine & "Bitte überprüfen Sie die angegebenen Daten oder die Einstellungen und versuchen Sie den Vorgang erneut." & vbNewLine & vbNewLine & "Fehlertext: " & ex, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    '    Exit Sub

                    Case 904
                        MessageBox.Show("Fehler #904: Beim Versuch, die Datenbanken zu sichern, ist ein Fehler aufgetreten." & vbNewLine & vbNewLine & "Fehlertext: " & ex, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub

                    Case 905
                        MessageBox.Show("Fehler #990: Interner Fehler." & vbNewLine & vbNewLine & "Fehlertext: " & ex, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub

                    Case 906
                        MessageBox.Show("Fehler #906: Beim Versuch, eine Verbindung mit der Datenbank herzustellen, ist ein Fehler aufgetreten." & vbNewLine & vbNewLine & "MySQL-Fehlernummer: #" & ex, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub

                    Case 907
                        MessageBox.Show("Fehler #907: Die zur Verbindung mit der Datenbank nötigen Zugangsdaten stimmen nicht.", "Fehler" & vbNewLine & vbNewLine & "MySQL-Fehlernummer: #" & ex, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub

                    Case 908
                        MessageBox.Show("Fehler #908: Die angegebene Datei existiert nicht oder wurde verschoben." & vbNewLine & vbNewLine & "Bitte überprüfen Sie die angegebene Datei und starten Sie den Vorgang neu.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub

                    Case 909
                        MessageBox.Show("Fehler #909: Beim Versuch, eine neue Datenbank zu erstellen, ist ein Fehler aufgetreten." & vbNewLine & "Bitte überprüfen Sie die angegebenen Daten und wiederholen Sie den Vorgang." & vbNewLine & vbNewLine & "Fehlertext: " & ex, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub

                    Case 910
                        MessageBox.Show("Fehler #910: Beim Versuch, eine Verbindung mit der Datenbank herzustellen, ist ein Fehler aufgetreten. Möglicherweise stimmen die eingegebenen Zugangsdaten nicht oder der Server ist nicht bereit.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub

                    Case 911
                        MessageBox.Show("Fehler #911: Beim Laden der Daten ist ein Fehler aufgetreten." & vbNewLine & vbNewLine & "Fehler: " & ex, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub

                    Case 912
                        MessageBox.Show("Fehler #912: Die angegebene Datei existiert bereits." & vbNewLine & "Bitte entfernen Sie die Datei oder geben Sie eine andere Datei an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub

                    Case 999
                        MessageBox.Show("Fehler #999: Es ist ein Fehler aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub

                End Select
            End Sub
        End Class

        Class Warnings
            Shared Function ErrHandler(ErrCode As Int16, Optional Pfad As String = Nothing, Optional Msg As String = Nothing)
                Select Case ErrCode
                    Case 800
                        Dim result As String
                        result = MessageBox.Show("Warnung #800: Der angegebene Pfad existiert noch nicht." & vbNewLine & "Soll er erstellt werden?" & vbNewLine & vbNewLine & "Angegebener Pfad: '" & Pfad & "'.", "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        If result = DialogResult.Yes Then
                            Return 1
                        ElseIf result = DialogResult.No Then
                            Return 0
                        End If

                        Return Nothing
                        Exit Function

                    Case 801
                        MessageBox.Show("Warnung #801: Der Vorgang wurde durch den Benutzer abgebrochen.", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return Nothing
                        Exit Function

                    Case 802
                        Dim result As String
                        result = MessageBox.Show("Warnung #802: Die angegebene Datei existiert bereits. " & vbNewLine & "Soll sie ersetzt werden?" & vbNewLine & vbNewLine & "Angegebene Datei: '" & Pfad & "'.", "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        If result = DialogResult.Yes Then
                            Return 1
                        ElseIf result = DialogResult.No Then
                            Return 0
                        End If

                        Return Nothing
                        Exit Function

                    Case 899
                        MessageBox.Show("Warnung #899: Es könnte ein Problem aufgetreten sein.", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return Nothing
                        Exit Function

                End Select
                Return Nothing
            End Function
        End Class

        Class Hints
            Shared Sub ErrHandler(ErrCode As Int16, Optional Pfad As String = Nothing, Optional Msg As String = Nothing)
                Select Case ErrCode
                    Case 700
                        MessageBox.Show("Hinweis #700: Die erforderliche setup.ini existiert entweder noch nicht, oder wurde versehentlich gelöscht. Bitte tragen Sie in den Einstellungen die jeweiligen Daten zur Wiederherstellung der Datei ein.", "Hinweis")

                        Exit Sub
                End Select

            End Sub
        End Class

        Class Info
            Shared Sub ErrHandler(ErrCode As Int16, Optional Pfad As String = Nothing, Optional Msg As String = Nothing)
                Select Case ErrCode
                    Case 600
                        MessageBox.Show("Meldung #600: Die Verbindung mit der Datenbank war erfolgreich.", "Meldung", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Exit Sub

                    Case 601
                        MessageBox.Show("Melung #601: Importieren der Datenbank erfolgreich.", "Meldung", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Exit Sub

                    Case 602
                        MessageBox.Show("Meldung #602: Die Änderungen wurden erfolgreich gespeichert." + vbNewLine + "Um die Änderungen wirksam zu machen, Starten Sie das Programm bitte neu.", "Meldung", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                End Select
            End Sub
        End Class
    End Module
End Namespace