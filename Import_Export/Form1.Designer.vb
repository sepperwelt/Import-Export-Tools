<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PB_ = New System.Windows.Forms.ProgressBar()
        Me.Lbl_err = New System.Windows.Forms.Label()
        Me.Btn_Export = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Txt_Save = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PB_import = New System.Windows.Forms.ProgressBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btn_Import = New System.Windows.Forms.Button()
        Me.Btn_Load = New System.Windows.Forms.Button()
        Me.Txt_DB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_eig = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Menu_close = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Menu_Imp = New System.Windows.Forms.ToolStripMenuItem()
        Me.SBD_Save = New System.Windows.Forms.SaveFileDialog()
        Me.OFD_DB = New System.Windows.Forms.OpenFileDialog()
        Me.FBD_Save = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.PB_)
        Me.GroupBox1.Controls.Add(Me.Lbl_err)
        Me.GroupBox1.Controls.Add(Me.Btn_Export)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Btn_Save)
        Me.GroupBox1.Controls.Add(Me.Txt_Save)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 589)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sichern / Exportieren"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 11
        '
        'PB_
        '
        Me.PB_.Location = New System.Drawing.Point(6, 560)
        Me.PB_.Name = "PB_"
        Me.PB_.Size = New System.Drawing.Size(503, 23)
        Me.PB_.TabIndex = 10
        Me.PB_.Visible = False
        '
        'Lbl_err
        '
        Me.Lbl_err.AutoSize = True
        Me.Lbl_err.Location = New System.Drawing.Point(9, 88)
        Me.Lbl_err.Name = "Lbl_err"
        Me.Lbl_err.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_err.TabIndex = 6
        '
        'Btn_Export
        '
        Me.Btn_Export.Location = New System.Drawing.Point(421, 47)
        Me.Btn_Export.Name = "Btn_Export"
        Me.Btn_Export.Size = New System.Drawing.Size(93, 23)
        Me.Btn_Export.TabIndex = 5
        Me.Btn_Export.Text = "Export"
        Me.Btn_Export.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Speicherort:"
        '
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(421, 18)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(93, 23)
        Me.Btn_Save.TabIndex = 1
        Me.Btn_Save.Text = "Durchsuchen..."
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Txt_Save
        '
        Me.Txt_Save.Location = New System.Drawing.Point(76, 19)
        Me.Txt_Save.Name = "Txt_Save"
        Me.Txt_Save.Size = New System.Drawing.Size(339, 20)
        Me.Txt_Save.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PB_import)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Btn_Import)
        Me.GroupBox2.Controls.Add(Me.Btn_Load)
        Me.GroupBox2.Controls.Add(Me.Txt_DB)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(538, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(582, 589)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Wiederherstellen / Importieren"
        '
        'PB_import
        '
        Me.PB_import.Location = New System.Drawing.Point(7, 560)
        Me.PB_import.Name = "PB_import"
        Me.PB_import.Size = New System.Drawing.Size(569, 23)
        Me.PB_import.TabIndex = 16
        Me.PB_import.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(548, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Hinweis: Vor Importieren der Datenbanken müssen die Datenbanknamen in den Einstel" &
    "lungen gespeichert werden!"
        '
        'Btn_Import
        '
        Me.Btn_Import.Location = New System.Drawing.Point(483, 47)
        Me.Btn_Import.Name = "Btn_Import"
        Me.Btn_Import.Size = New System.Drawing.Size(93, 23)
        Me.Btn_Import.TabIndex = 14
        Me.Btn_Import.Text = "Import"
        Me.Btn_Import.UseVisualStyleBackColor = True
        '
        'Btn_Load
        '
        Me.Btn_Load.Location = New System.Drawing.Point(483, 18)
        Me.Btn_Load.Name = "Btn_Load"
        Me.Btn_Load.Size = New System.Drawing.Size(93, 23)
        Me.Btn_Load.TabIndex = 6
        Me.Btn_Load.Text = "Durchsuchen..."
        Me.Btn_Load.UseVisualStyleBackColor = True
        '
        'Txt_DB
        '
        Me.Txt_DB.Location = New System.Drawing.Point(135, 20)
        Me.Txt_DB.Name = "Txt_DB"
        Me.Txt_DB.Size = New System.Drawing.Size(342, 20)
        Me.Txt_DB.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Speicherort Digikam DB:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1130, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_eig, Me.ToolStripSeparator2, Me.Menu_close})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.DateiToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        Me.DateiToolStripMenuItem.ToolTipText = "Einstellungen"
        '
        'Menu_eig
        '
        Me.Menu_eig.Name = "Menu_eig"
        Me.Menu_eig.ShortcutKeyDisplayString = ""
        Me.Menu_eig.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.Menu_eig.Size = New System.Drawing.Size(185, 22)
        Me.Menu_eig.Text = "Einstellungen"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(182, 6)
        '
        'Menu_close
        '
        Me.Menu_close.Name = "Menu_close"
        Me.Menu_close.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.Menu_close.Size = New System.Drawing.Size(185, 22)
        Me.Menu_close.Text = "Beenden"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Help, Me.ToolStripSeparator1, Me.Menu_Imp})
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.HilfeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HilfeToolStripMenuItem.Text = "About"
        '
        'Menu_Help
        '
        Me.Menu_Help.Enabled = False
        Me.Menu_Help.Name = "Menu_Help"
        Me.Menu_Help.Size = New System.Drawing.Size(158, 22)
        Me.Menu_Help.Text = "Hilfe anzeigen"
        Me.Menu_Help.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(155, 6)
        '
        'Menu_Imp
        '
        Me.Menu_Imp.Name = "Menu_Imp"
        Me.Menu_Imp.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.Menu_Imp.Size = New System.Drawing.Size(158, 22)
        Me.Menu_Imp.Text = "Impressum"
        '
        'SBD_Save
        '
        Me.SBD_Save.DefaultExt = "sql"
        Me.SBD_Save.Filter = "SQL-Dateien (*.sql)|*.sql|Alle Dateien (*.*)|*.*"
        Me.SBD_Save.InitialDirectory = "Backup_Folder"
        Me.SBD_Save.OverwritePrompt = False
        Me.SBD_Save.Title = "Exportdatei wählen"
        '
        'OFD_DB
        '
        Me.OFD_DB.DefaultExt = "sql"
        Me.OFD_DB.Filter = "SQL-Dateien (*.sql)|*.sql|Alle Dateien (*.*)|*.*"
        Me.OFD_DB.InitialDirectory = "Import_Folder"
        Me.OFD_DB.Title = "Import Digikam Core DB"
        '
        'FBD_Save
        '
        Me.FBD_Save.Description = "Bitte wählen Sie das Zielverzeichnis aus."
        Me.FBD_Save.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 628)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Import - Export für Digikam"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Menu_close As ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu_Help As ToolStripMenuItem
    Friend WithEvents Menu_Imp As ToolStripMenuItem
    Friend WithEvents Menu_eig As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Txt_Save As TextBox
    Friend WithEvents Btn_Export As Button
    Friend WithEvents Lbl_err As Label
    Friend WithEvents SBD_Save As SaveFileDialog
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Btn_Load As Button
    Friend WithEvents Txt_DB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents OFD_DB As OpenFileDialog
    Friend WithEvents Btn_Import As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PB_ As ProgressBar
    Friend WithEvents PB_import As ProgressBar
    Friend WithEvents Label8 As Label
    Friend WithEvents FBD_Save As FolderBrowserDialog
End Class
