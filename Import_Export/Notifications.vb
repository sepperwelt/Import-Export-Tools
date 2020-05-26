' This File is part of the program 'Import-Export-Tools für DigiKam', licensed under GNU General Public License Version 3.
' You should have received a copy Of the GNU General Public License along with 'Import-Export-Tools für DigiKam'.  If Not, see <http: //www.gnu.org/licenses/>.
' (c) Copyright  Laurenz Vogt, 2017-2019

Option Explicit On
Module Notification
    Public Class Faults
        Shared Sub ErrHandler(ErrCode As Int16, Optional Pfad As String = Nothing, Optional ex As String = Nothing)
            Select Case ErrCode
                Case 900
                    MessageBox.Show("Err #900: Faulty argument in query function!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                Case 901
                    MessageBox.Show("Err #901: Please enter a proper file location for saving the database!", "Error: No directory", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Exit Sub

                Case 902
                    MessageBox.Show("Err #902: Please enter a proper file for loading the database!", "Error: No file", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                    'Case 903
                    '    MessageBox.Show("Err #903: An error occured during export." & vbNewLine & "Please check the given data or settings and try again." & vbNewLine & vbNewLine & "Error text: " & ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    '    Exit Sub

                Case 904
                    MessageBox.Show("Err #904: An error occured while trying to save the database. " & vbNewLine & vbNewLine & "Error text: " & ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                Case 905
                    MessageBox.Show("Err #990: Internal Error" & vbNewLine & vbNewLine & "Error text: " & ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                Case 906
                    MessageBox.Show("Err #906: An error occured while trying to connect with the server." & vbNewLine & vbNewLine & "MySQL-Error number: #" & ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                Case 907
                    MessageBox.Show("Err #907: The given connection details aren't correct." & vbNewLine & vbNewLine & "MySQL-Error number: #" & ex, "Err", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                Case 908
                    MessageBox.Show("Err #908: The given file does not exist or was moved." & vbNewLine & vbNewLine & "Please check the file and restart the process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                Case 909
                    MessageBox.Show("Err #909: An error occured while trying to create the database." & vbNewLine & "Please check the given data and restart the process." & vbNewLine & vbNewLine & "Error text: " & ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                Case 910
                    MessageBox.Show("Err #910: An error occured while trying to connect to the server. Please check the connection data or availability of the server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                Case 911
                    MessageBox.Show("Err #911: An error occured while loading the file." & vbNewLine & vbNewLine & "Error: " & ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                Case 912
                    MessageBox.Show("Err #912: A file with the same name exists already." & vbNewLine & "Please change the name or delete the existing file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub


                Case 920
                    MessageBox.Show("Err #920: The new version of the application cannot be downloaded at this time. " + vbNewLine & vbNewLine & "Please check your network connection, or try again later. Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                Case 921
                    MessageBox.Show("Err #921: This application cannot be updated. Please contact the publisher. Error: " & ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                Case 922
                    MessageBox.Show("Err #922: Cannot install the latest version of the application. " & vbNewLine & vbNewLine & "Please check your network connection, or try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                Case 999
                    MessageBox.Show("Err #999: An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

            End Select
        End Sub
    End Class

    Public Class Warnings
        Shared Function ErrHandler(ErrCode As Int16, Optional Pfad As String = Nothing, Optional Msg As String = Nothing)
            Select Case ErrCode
                Case 800
                    Dim result As String
                    result = MessageBox.Show("Warning #800: The given location does not exist." & vbNewLine & "Shall it be created?" & vbNewLine & vbNewLine & "Given path: '" & Pfad & "'.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If result = DialogResult.Yes Then
                        Return 1
                    ElseIf result = DialogResult.No Then
                        Return 0
                    End If

                    Return Nothing
                    Exit Function

                Case 801
                    MessageBox.Show("Warning #801: The process was cancelled by the user.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return Nothing
                    Exit Function

                Case 802
                    Dim result As String
                    result = MessageBox.Show("Warning #802: The specified file exists already." & vbNewLine & "Shall it be replaced?" & vbNewLine & vbNewLine & "Given file: '" & Pfad & "'.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If result = DialogResult.Yes Then
                        Return 1
                    ElseIf result = DialogResult.No Then
                        Return 0
                    End If

                    Return Nothing
                    Exit Function

                Case 899
                    MessageBox.Show("Warning #899: A problem might have occured.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return Nothing
                    Exit Function

            End Select
            Return Nothing
        End Function
    End Class

    Public Class Hints
        Shared Sub ErrHandler(ErrCode As Int16, Optional Pfad As String = Nothing, Optional Msg As String = Nothing)
            Select Case ErrCode
                Case 700
                    MessageBox.Show("Hint #700: The requiered setup.ini is missing or was deleted. Please enter the needed data to recover the file properly.", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub

                Case 701
                    MessageBox.Show("This application has detected a mandatory update from your current version to version " & Msg & ". The application will now install the update and restart.", "Update Available", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select

        End Sub
    End Class

    Public Class Info
        Shared Function ErrHandler(ErrCode As Int16, Optional Pfad As String = Nothing, Optional Msg As String = Nothing)
            Select Case ErrCode
                Case 600
                    MessageBox.Show("Message #600: The connection with the server was successful.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return Nothing
                    Exit Function

                Case 601
                    MessageBox.Show("Melung #601: Import successful.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return Nothing
                    Exit Function

                Case 602
                    MessageBox.Show("Message #602: The changes were saved successfully." + vbNewLine + "Please restart the program in order to use the new data.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return Nothing
                    Exit Function

                Case 603
                    Dim result As String
                    result = MessageBox.Show("Message #603: An update is available. Would you like to update the application now?", "Update Available", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    If result = DialogResult.OK Then
                        Return True
                    End If
                    Exit Function

                Case 604
                    MessageBox.Show("Message #604: The application has been upgraded, and will now restart.", "Update finished", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return Nothing
                    Exit Function

                Case 605
                    MessageBox.Show("Message #605: The latest version of " + Application.ProductName + " is curretly installed.", "Already up-to-date", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
            Return Nothing
        End Function
    End Class
End Module