<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Txt_Port = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Test = New System.Windows.Forms.Button()
        Me.Txt_DB = New System.Windows.Forms.TextBox()
        Me.Lbl_DB = New System.Windows.Forms.Label()
        Me.Txt_Host = New System.Windows.Forms.TextBox()
        Me.Lbl_Host = New System.Windows.Forms.Label()
        Me.Txt_Pass = New System.Windows.Forms.TextBox()
        Me.Lbl_Pass = New System.Windows.Forms.Label()
        Me.Txt_User = New System.Windows.Forms.TextBox()
        Me.Lbl_User = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_Import = New System.Windows.Forms.Button()
        Me.Txt_Import = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Backup = New System.Windows.Forms.Button()
        Me.Txt_Backup = New System.Windows.Forms.TextBox()
        Me.Btn_Folder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_MySQL = New System.Windows.Forms.TextBox()
        Me.Btn_Abort = New System.Windows.Forms.Button()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.CB_Date = New System.Windows.Forms.CheckBox()
        Me.CB_Time = New System.Windows.Forms.CheckBox()
        Me.FBD_MySQL = New System.Windows.Forms.FolderBrowserDialog()
        Me.FBD_Backup = New System.Windows.Forms.FolderBrowserDialog()
        Me.FBD_Import = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Btn_Abort)
        Me.GroupBox1.Controls.Add(Me.Btn_Save)
        Me.GroupBox1.Controls.Add(Me.CB_Date)
        Me.GroupBox1.Controls.Add(Me.CB_Time)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1095, 497)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General Settings"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Txt_Port)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Btn_Test)
        Me.GroupBox3.Controls.Add(Me.Txt_DB)
        Me.GroupBox3.Controls.Add(Me.Lbl_DB)
        Me.GroupBox3.Controls.Add(Me.Txt_Host)
        Me.GroupBox3.Controls.Add(Me.Lbl_Host)
        Me.GroupBox3.Controls.Add(Me.Txt_Pass)
        Me.GroupBox3.Controls.Add(Me.Lbl_Pass)
        Me.GroupBox3.Controls.Add(Me.Txt_User)
        Me.GroupBox3.Controls.Add(Me.Lbl_User)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1082, 155)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Connection"
        '
        'Txt_Port
        '
        Me.Txt_Port.Location = New System.Drawing.Point(212, 97)
        Me.Txt_Port.Name = "Txt_Port"
        Me.Txt_Port.Size = New System.Drawing.Size(864, 20)
        Me.Txt_Port.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Port"
        '
        'Btn_Test
        '
        Me.Btn_Test.Location = New System.Drawing.Point(954, 123)
        Me.Btn_Test.Name = "Btn_Test"
        Me.Btn_Test.Size = New System.Drawing.Size(121, 23)
        Me.Btn_Test.TabIndex = 27
        Me.Btn_Test.Text = "Test..."
        Me.Btn_Test.UseVisualStyleBackColor = True
        '
        'Txt_DB
        '
        Me.Txt_DB.Location = New System.Drawing.Point(212, 123)
        Me.Txt_DB.Name = "Txt_DB"
        Me.Txt_DB.Size = New System.Drawing.Size(736, 20)
        Me.Txt_DB.TabIndex = 25
        '
        'Lbl_DB
        '
        Me.Lbl_DB.AutoSize = True
        Me.Lbl_DB.Location = New System.Drawing.Point(5, 126)
        Me.Lbl_DB.Name = "Lbl_DB"
        Me.Lbl_DB.Size = New System.Drawing.Size(51, 13)
        Me.Lbl_DB.TabIndex = 28
        Me.Lbl_DB.Text = "DB name"
        '
        'Txt_Host
        '
        Me.Txt_Host.Location = New System.Drawing.Point(212, 71)
        Me.Txt_Host.Name = "Txt_Host"
        Me.Txt_Host.Size = New System.Drawing.Size(864, 20)
        Me.Txt_Host.TabIndex = 22
        '
        'Lbl_Host
        '
        Me.Lbl_Host.AutoSize = True
        Me.Lbl_Host.Location = New System.Drawing.Point(6, 74)
        Me.Lbl_Host.Name = "Lbl_Host"
        Me.Lbl_Host.Size = New System.Drawing.Size(29, 13)
        Me.Lbl_Host.TabIndex = 26
        Me.Lbl_Host.Text = "Host"
        '
        'Txt_Pass
        '
        Me.Txt_Pass.Location = New System.Drawing.Point(212, 45)
        Me.Txt_Pass.Name = "Txt_Pass"
        Me.Txt_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Pass.Size = New System.Drawing.Size(864, 20)
        Me.Txt_Pass.TabIndex = 21
        '
        'Lbl_Pass
        '
        Me.Lbl_Pass.AutoSize = True
        Me.Lbl_Pass.Location = New System.Drawing.Point(6, 48)
        Me.Lbl_Pass.Name = "Lbl_Pass"
        Me.Lbl_Pass.Size = New System.Drawing.Size(53, 13)
        Me.Lbl_Pass.TabIndex = 23
        Me.Lbl_Pass.Text = "Password"
        '
        'Txt_User
        '
        Me.Txt_User.Location = New System.Drawing.Point(212, 19)
        Me.Txt_User.Name = "Txt_User"
        Me.Txt_User.Size = New System.Drawing.Size(864, 20)
        Me.Txt_User.TabIndex = 19
        '
        'Lbl_User
        '
        Me.Lbl_User.AutoSize = True
        Me.Lbl_User.Location = New System.Drawing.Point(6, 22)
        Me.Lbl_User.Name = "Lbl_User"
        Me.Lbl_User.Size = New System.Drawing.Size(55, 13)
        Me.Lbl_User.TabIndex = 20
        Me.Lbl_User.Text = "Username"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_Import)
        Me.GroupBox2.Controls.Add(Me.Txt_Import)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Btn_Backup)
        Me.GroupBox2.Controls.Add(Me.Txt_Backup)
        Me.GroupBox2.Controls.Add(Me.Btn_Folder)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Txt_MySQL)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1082, 117)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Default directories"
        '
        'Btn_Import
        '
        Me.Btn_Import.Location = New System.Drawing.Point(955, 77)
        Me.Btn_Import.Name = "Btn_Import"
        Me.Btn_Import.Size = New System.Drawing.Size(121, 23)
        Me.Btn_Import.TabIndex = 37
        Me.Btn_Import.Text = "Browse..."
        Me.Btn_Import.UseVisualStyleBackColor = True
        '
        'Txt_Import
        '
        Me.Txt_Import.Location = New System.Drawing.Point(212, 79)
        Me.Txt_Import.Name = "Txt_Import"
        Me.Txt_Import.Size = New System.Drawing.Size(736, 20)
        Me.Txt_Import.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Default import location"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Default export location"
        '
        'Btn_Backup
        '
        Me.Btn_Backup.Location = New System.Drawing.Point(955, 48)
        Me.Btn_Backup.Name = "Btn_Backup"
        Me.Btn_Backup.Size = New System.Drawing.Size(121, 23)
        Me.Btn_Backup.TabIndex = 33
        Me.Btn_Backup.Text = "Browse..."
        Me.Btn_Backup.UseVisualStyleBackColor = True
        '
        'Txt_Backup
        '
        Me.Txt_Backup.Location = New System.Drawing.Point(213, 50)
        Me.Txt_Backup.Name = "Txt_Backup"
        Me.Txt_Backup.Size = New System.Drawing.Size(736, 20)
        Me.Txt_Backup.TabIndex = 32
        '
        'Btn_Folder
        '
        Me.Btn_Folder.Location = New System.Drawing.Point(955, 19)
        Me.Btn_Folder.Name = "Btn_Folder"
        Me.Btn_Folder.Size = New System.Drawing.Size(121, 23)
        Me.Btn_Folder.TabIndex = 28
        Me.Btn_Folder.Text = "Browse..."
        Me.Btn_Folder.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "MySQL directory"
        '
        'Txt_MySQL
        '
        Me.Txt_MySQL.Location = New System.Drawing.Point(213, 21)
        Me.Txt_MySQL.Name = "Txt_MySQL"
        Me.Txt_MySQL.Size = New System.Drawing.Size(736, 20)
        Me.Txt_MySQL.TabIndex = 27
        '
        'Btn_Abort
        '
        Me.Btn_Abort.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Abort.Location = New System.Drawing.Point(829, 468)
        Me.Btn_Abort.Name = "Btn_Abort"
        Me.Btn_Abort.Size = New System.Drawing.Size(127, 23)
        Me.Btn_Abort.TabIndex = 8
        Me.Btn_Abort.Text = "Cancel"
        Me.Btn_Abort.UseVisualStyleBackColor = True
        '
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(962, 468)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(127, 23)
        Me.Btn_Save.TabIndex = 9
        Me.Btn_Save.Text = "Apply"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'CB_Date
        '
        Me.CB_Date.AutoSize = True
        Me.CB_Date.Location = New System.Drawing.Point(16, 303)
        Me.CB_Date.Name = "CB_Date"
        Me.CB_Date.Size = New System.Drawing.Size(197, 17)
        Me.CB_Date.TabIndex = 30
        Me.CB_Date.Text = "Use current date for export file name"
        Me.CB_Date.UseVisualStyleBackColor = True
        '
        'CB_Time
        '
        Me.CB_Time.AutoSize = True
        Me.CB_Time.Enabled = False
        Me.CB_Time.Location = New System.Drawing.Point(44, 326)
        Me.CB_Time.Name = "CB_Time"
        Me.CB_Time.Size = New System.Drawing.Size(195, 17)
        Me.CB_Time.TabIndex = 31
        Me.CB_Time.Text = "Use current time for export file name"
        Me.CB_Time.UseVisualStyleBackColor = True
        '
        'FBD_MySQL
        '
        Me.FBD_MySQL.Description = "Wählen Sie den MySQL-Ordner aus, in dem sich mysql.exe und mysqldump.exe befinden" &
    "."
        Me.FBD_MySQL.RootFolder = System.Environment.SpecialFolder.CommonPrograms
        Me.FBD_MySQL.ShowNewFolderButton = False
        '
        'FBD_Backup
        '
        Me.FBD_Backup.Description = "Wählen Sie das Standar-Exportverzeichnis für Backups aus."
        Me.FBD_Backup.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'FBD_Import
        '
        Me.FBD_Import.Description = "Wählen Sie das Standart-Importverzeichnis aus."
        Me.FBD_Import.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'Form2
        '
        Me.AcceptButton = Me.Btn_Save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Btn_Abort
        Me.ClientSize = New System.Drawing.Size(1123, 521)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_Abort As Button
    Friend WithEvents Btn_Save As Button
    Friend WithEvents FBD_MySQL As FolderBrowserDialog
    Friend WithEvents FBD_Backup As FolderBrowserDialog
    Friend WithEvents FBD_Import As FolderBrowserDialog
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Txt_Port As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Test As Button
    Friend WithEvents Txt_DB As TextBox
    Friend WithEvents Lbl_DB As Label
    Friend WithEvents Txt_Host As TextBox
    Friend WithEvents Lbl_Host As Label
    Friend WithEvents Txt_Pass As TextBox
    Friend WithEvents Lbl_Pass As Label
    Friend WithEvents Txt_User As TextBox
    Friend WithEvents Lbl_User As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_Import As Button
    Friend WithEvents Txt_Import As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Backup As Button
    Friend WithEvents Txt_Backup As TextBox
    Friend WithEvents CB_Time As CheckBox
    Friend WithEvents CB_Date As CheckBox
    Friend WithEvents Btn_Folder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_MySQL As TextBox
End Class
