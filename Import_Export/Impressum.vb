' This File is part of the program 'Import-Export-Tools für DigiKam', licensed under GNU General Public License Version 3.
' You should have received a copy Of the GNU General Public License along with 'Import-Export-Tools für DigiKam'.  If Not, see <http: //www.gnu.org/licenses/>.
' (c) Copyright  Laurenz Vogt, 2017-2019

Public NotInheritable Class Impressum

    Private Sub Impressum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ApplicationTitle As String

        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        Me.Text = String.Format("About {0}", ApplicationTitle)
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Deployment.CurrentVersion.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = My.Application.Info.Description & vbNewLine & vbNewLine &
            "Dieses Programm wurde im Rahmen der Besonderen Lernleistung im Fach Informatik von Laurenz Vogt entwickelt." & vbNewLine & vbNewLine &
            "Vielen Dank an meinen Begleiter C. Stauch." & vbNewLine & vbNewLine & "Dieses Programm ist lizensiert unter GNU General Public License v3." &
            vbNewLine & "Siehe http: //www.gnu.org/licenses/ für weitere Informationen."

    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
