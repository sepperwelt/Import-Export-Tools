' This File is part of the program 'Import-Export-Tools für DigiKam', licensed under GNU General Public License Version 3.
' You should have received a copy Of the GNU General Public License along with 'Import-Export-Tools für DigiKam'.  If Not, see <http: //www.gnu.org/licenses/>.
' (c) Copyright  Laurenz Vogt, 2017-2019

Option Explicit On
Imports System.Deployment.Application
Imports Import_Export.Notification

Module Updater
    Public Class Data
        Private Shared Property AppDeploy As ApplicationDeployment = ApplicationDeployment.CurrentDeployment
        Private Shared Property Info As UpdateCheckInfo = Nothing
        Private Shared Property doUpdate As Boolean = True

        Shared Function CheckUpdates()
            If (ApplicationDeployment.IsNetworkDeployed) Then
                Try
                    Data.Info = Data.AppDeploy.CheckForDetailedUpdate()
                Catch dde As DeploymentDownloadException
                    Faults.ErrHandler(920, dde.Message)
                    Return False
                    Exit Function
                Catch ioe As System.InvalidOperationException
                    Faults.ErrHandler(921, ioe.Message)
                    Return False
                    Exit Function
                End Try

                Return True
            End If
            Return False
        End Function
        Shared Sub InstallUpdates()
            If (ApplicationDeployment.IsNetworkDeployed) Then
                If (Not Info.IsUpdateRequired) Then
                    doUpdate = Notification.Info.ErrHandler(603)
                Else
                    Hints.ErrHandler(701, , Info.MinimumRequiredVersion.ToString())
                    Return
                End If

                If (Info.UpdateAvailable) Then
                    If (doUpdate) Then
                        Try
                            AppDeploy.Update()
                            Notification.Info.ErrHandler(604)
                            Application.Restart()
                        Catch dde As DeploymentDownloadException
                            Faults.ErrHandler(922)
                            Return
                        End Try
                    End If
                Else
                    Notification.Info.ErrHandler(605)
                End If
            End If
        End Sub
    End Class
End Module