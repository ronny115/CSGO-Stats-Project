<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CSGOStats
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CSGOStats))
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.mainMenu = New System.Windows.Forms.Panel()
        Me.exportButtonPic = New System.Windows.Forms.PictureBox()
        Me.backButtonPic = New System.Windows.Forms.PictureBox()
        Me.osButtonPic = New System.Windows.Forms.PictureBox()
        Me.msButtonPic = New System.Windows.Forms.PictureBox()
        Me.gsButtonPic = New System.Windows.Forms.PictureBox()
        Me.MainScreen = New System.Windows.Forms.Panel()
        Me.aboutTextBox = New System.Windows.Forms.RichTextBox()
        Me.howtoTextBox = New System.Windows.Forms.RichTextBox()
        Me.helpButtonPic = New System.Windows.Forms.PictureBox()
        Me.steamNameInput = New System.Windows.Forms.TextBox()
        Me.loadDataButton = New System.Windows.Forms.Button()
        Me.closeHelpPic = New System.Windows.Forms.PictureBox()
        Me.howTabPic = New System.Windows.Forms.PictureBox()
        Me.aboutTabPic = New System.Windows.Forms.PictureBox()
        Me.helpPanelImage = New System.Windows.Forms.PictureBox()
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.mainMenu.SuspendLayout()
        CType(Me.exportButtonPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backButtonPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.osButtonPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.msButtonPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gsButtonPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainScreen.SuspendLayout()
        CType(Me.helpButtonPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeHelpPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.howTabPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aboutTabPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.helpPanelImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackgroundWorker
        '
        '
        'mainMenu
        '
        Me.mainMenu.BackColor = System.Drawing.Color.Transparent
        Me.mainMenu.BackgroundImage = Global.CSGOStats.My.Resources.Resources.bg_Menu
        Me.mainMenu.Controls.Add(Me.exportButtonPic)
        Me.mainMenu.Controls.Add(Me.backButtonPic)
        Me.mainMenu.Controls.Add(Me.osButtonPic)
        Me.mainMenu.Controls.Add(Me.msButtonPic)
        Me.mainMenu.Controls.Add(Me.gsButtonPic)
        Me.mainMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.mainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(200, 511)
        Me.mainMenu.TabIndex = 4
        '
        'exportButtonPic
        '
        Me.exportButtonPic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.export_dis
        Me.exportButtonPic.Location = New System.Drawing.Point(8, 480)
        Me.exportButtonPic.Name = "exportButtonPic"
        Me.exportButtonPic.Size = New System.Drawing.Size(19, 23)
        Me.exportButtonPic.TabIndex = 8
        Me.exportButtonPic.TabStop = False
        '
        'backButtonPic
        '
        Me.backButtonPic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.backButton_dis
        Me.backButtonPic.Location = New System.Drawing.Point(15, 257)
        Me.backButtonPic.Name = "backButtonPic"
        Me.backButtonPic.Size = New System.Drawing.Size(170, 30)
        Me.backButtonPic.TabIndex = 7
        Me.backButtonPic.TabStop = False
        '
        'osButtonPic
        '
        Me.osButtonPic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.osButton_dis
        Me.osButtonPic.Location = New System.Drawing.Point(15, 215)
        Me.osButtonPic.Name = "osButtonPic"
        Me.osButtonPic.Size = New System.Drawing.Size(170, 30)
        Me.osButtonPic.TabIndex = 6
        Me.osButtonPic.TabStop = False
        '
        'msButtonPic
        '
        Me.msButtonPic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.msButton_dis
        Me.msButtonPic.Location = New System.Drawing.Point(15, 173)
        Me.msButtonPic.Name = "msButtonPic"
        Me.msButtonPic.Size = New System.Drawing.Size(170, 30)
        Me.msButtonPic.TabIndex = 5
        Me.msButtonPic.TabStop = False
        '
        'gsButtonPic
        '
        Me.gsButtonPic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.gsButton_ena
        Me.gsButtonPic.Location = New System.Drawing.Point(15, 131)
        Me.gsButtonPic.Name = "gsButtonPic"
        Me.gsButtonPic.Size = New System.Drawing.Size(170, 30)
        Me.gsButtonPic.TabIndex = 4
        Me.gsButtonPic.TabStop = False
        '
        'MainScreen
        '
        Me.MainScreen.BackColor = System.Drawing.SystemColors.Highlight
        Me.MainScreen.BackgroundImage = Global.CSGOStats.My.Resources.Resources.msBackground
        Me.MainScreen.Controls.Add(Me.aboutTextBox)
        Me.MainScreen.Controls.Add(Me.howtoTextBox)
        Me.MainScreen.Controls.Add(Me.helpButtonPic)
        Me.MainScreen.Controls.Add(Me.steamNameInput)
        Me.MainScreen.Controls.Add(Me.loadDataButton)
        Me.MainScreen.Controls.Add(Me.closeHelpPic)
        Me.MainScreen.Controls.Add(Me.howTabPic)
        Me.MainScreen.Controls.Add(Me.aboutTabPic)
        Me.MainScreen.Controls.Add(Me.helpPanelImage)
        Me.MainScreen.Controls.Add(Me.errorLabel)
        Me.MainScreen.Location = New System.Drawing.Point(0, 0)
        Me.MainScreen.Margin = New System.Windows.Forms.Padding(0)
        Me.MainScreen.Name = "MainScreen"
        Me.MainScreen.Size = New System.Drawing.Size(904, 511)
        Me.MainScreen.TabIndex = 5
        '
        'aboutTextBox
        '
        Me.aboutTextBox.BackColor = System.Drawing.Color.White
        Me.aboutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.aboutTextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.aboutTextBox.DetectUrls = False
        Me.aboutTextBox.Location = New System.Drawing.Point(269, 85)
        Me.aboutTextBox.Name = "aboutTextBox"
        Me.aboutTextBox.ReadOnly = True
        Me.aboutTextBox.Size = New System.Drawing.Size(366, 393)
        Me.aboutTextBox.TabIndex = 11
        Me.aboutTextBox.Text = ""
        '
        'howtoTextBox
        '
        Me.howtoTextBox.BackColor = System.Drawing.Color.White
        Me.howtoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.howtoTextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.howtoTextBox.DetectUrls = False
        Me.howtoTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.howtoTextBox.Location = New System.Drawing.Point(267, 87)
        Me.howtoTextBox.Name = "howtoTextBox"
        Me.howtoTextBox.ReadOnly = True
        Me.howtoTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.howtoTextBox.Size = New System.Drawing.Size(368, 391)
        Me.howtoTextBox.TabIndex = 10
        Me.howtoTextBox.Text = ""
        '
        'helpButtonPic
        '
        Me.helpButtonPic.BackColor = System.Drawing.Color.White
        Me.helpButtonPic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.help_dis
        Me.helpButtonPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.helpButtonPic.Location = New System.Drawing.Point(567, 163)
        Me.helpButtonPic.Name = "helpButtonPic"
        Me.helpButtonPic.Size = New System.Drawing.Size(25, 23)
        Me.helpButtonPic.TabIndex = 3
        Me.helpButtonPic.TabStop = False
        '
        'steamNameInput
        '
        Me.steamNameInput.BackColor = System.Drawing.Color.White
        Me.steamNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.steamNameInput.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.steamNameInput.Location = New System.Drawing.Point(316, 167)
        Me.steamNameInput.Name = "steamNameInput"
        Me.steamNameInput.Size = New System.Drawing.Size(271, 14)
        Me.steamNameInput.TabIndex = 2
        '
        'loadDataButton
        '
        Me.loadDataButton.BackColor = System.Drawing.SystemColors.Control
        Me.loadDataButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.loadDataButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.loadDataButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.loadDataButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.loadDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loadDataButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadDataButton.Location = New System.Drawing.Point(405, 208)
        Me.loadDataButton.Name = "loadDataButton"
        Me.loadDataButton.Size = New System.Drawing.Size(109, 31)
        Me.loadDataButton.TabIndex = 0
        Me.loadDataButton.Text = "Load"
        Me.loadDataButton.UseVisualStyleBackColor = False
        '
        'closeHelpPic
        '
        Me.closeHelpPic.BackColor = System.Drawing.SystemColors.Control
        Me.closeHelpPic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.close_help_dis
        Me.closeHelpPic.Location = New System.Drawing.Point(617, 35)
        Me.closeHelpPic.Name = "closeHelpPic"
        Me.closeHelpPic.Size = New System.Drawing.Size(18, 23)
        Me.closeHelpPic.TabIndex = 7
        Me.closeHelpPic.TabStop = False
        '
        'howTabPic
        '
        Me.howTabPic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.htuse_dis
        Me.howTabPic.Location = New System.Drawing.Point(282, 41)
        Me.howTabPic.Name = "howTabPic"
        Me.howTabPic.Size = New System.Drawing.Size(94, 40)
        Me.howTabPic.TabIndex = 6
        Me.howTabPic.TabStop = False
        '
        'aboutTabPic
        '
        Me.aboutTabPic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.help_tab_dis
        Me.aboutTabPic.Location = New System.Drawing.Point(375, 40)
        Me.aboutTabPic.Name = "aboutTabPic"
        Me.aboutTabPic.Size = New System.Drawing.Size(95, 41)
        Me.aboutTabPic.TabIndex = 5
        Me.aboutTabPic.TabStop = False
        '
        'helpPanelImage
        '
        Me.helpPanelImage.BackColor = System.Drawing.Color.White
        Me.helpPanelImage.BackgroundImage = Global.CSGOStats.My.Resources.Resources.help_panel
        Me.helpPanelImage.Location = New System.Drawing.Point(252, 19)
        Me.helpPanelImage.Name = "helpPanelImage"
        Me.helpPanelImage.Size = New System.Drawing.Size(399, 479)
        Me.helpPanelImage.TabIndex = 4
        Me.helpPanelImage.TabStop = False
        '
        'errorLabel
        '
        Me.errorLabel.AutoSize = True
        Me.errorLabel.BackColor = System.Drawing.Color.Transparent
        Me.errorLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorLabel.ForeColor = System.Drawing.Color.Red
        Me.errorLabel.Location = New System.Drawing.Point(595, 165)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(0, 16)
        Me.errorLabel.TabIndex = 9
        '
        'CSGOStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 511)
        Me.Controls.Add(Me.mainMenu)
        Me.Controls.Add(Me.MainScreen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "CSGOStats"
        Me.Text = "CSGOStats"
        Me.mainMenu.ResumeLayout(False)
        CType(Me.exportButtonPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backButtonPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.osButtonPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.msButtonPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gsButtonPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainScreen.ResumeLayout(False)
        Me.MainScreen.PerformLayout()
        CType(Me.helpButtonPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeHelpPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.howTabPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aboutTabPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.helpPanelImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents mainMenu As Panel
    Friend WithEvents MainScreen As Panel
    Friend WithEvents loadDataButton As Button
    Friend WithEvents steamNameInput As TextBox
    Friend WithEvents helpButtonPic As PictureBox
    Friend WithEvents helpPanelImage As PictureBox
    Friend WithEvents aboutTabPic As PictureBox
    Friend WithEvents howTabPic As PictureBox
    Friend WithEvents closeHelpPic As PictureBox
    Friend WithEvents errorLabel As Label
    Friend WithEvents gsButtonPic As PictureBox
    Friend WithEvents msButtonPic As PictureBox
    Friend WithEvents osButtonPic As PictureBox
    Friend WithEvents backButtonPic As PictureBox
    Friend WithEvents exportButtonPic As PictureBox
    Friend WithEvents howtoTextBox As RichTextBox
    Friend WithEvents aboutTextBox As RichTextBox
End Class
