<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mapStats
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.varMapComboBox = New System.Windows.Forms.ComboBox()
        Me.miragePic = New System.Windows.Forms.PictureBox()
        Me.cachePic = New System.Windows.Forms.PictureBox()
        Me.infernoPic = New System.Windows.Forms.PictureBox()
        Me.overpassPic = New System.Windows.Forms.PictureBox()
        Me.trainPic = New System.Windows.Forms.PictureBox()
        Me.nukePic = New System.Windows.Forms.PictureBox()
        Me.dust2Pic = New System.Windows.Forms.PictureBox()
        Me.cobblestonePic = New System.Windows.Forms.PictureBox()
        Me.officePic = New System.Windows.Forms.PictureBox()
        Me.canalsPic = New System.Windows.Forms.PictureBox()
        Me.agencyPic = New System.Windows.Forms.PictureBox()
        Me.variousPic = New System.Windows.Forms.PictureBox()
        Me.mapStatsChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.mirageCountLabel = New System.Windows.Forms.Label()
        Me.cacheCountLabel = New System.Windows.Forms.Label()
        Me.infernoCountLabel = New System.Windows.Forms.Label()
        Me.overpassCountLabel = New System.Windows.Forms.Label()
        Me.trainCountLabel = New System.Windows.Forms.Label()
        Me.nukeCountLabel = New System.Windows.Forms.Label()
        Me.dustCountLabel = New System.Windows.Forms.Label()
        Me.cobbleCountLabel = New System.Windows.Forms.Label()
        Me.officeCountLabel = New System.Windows.Forms.Label()
        Me.canalsCountLabel = New System.Windows.Forms.Label()
        Me.agencyCountLabel = New System.Windows.Forms.Label()
        Me.saveButtonPic = New System.Windows.Forms.PictureBox()
        CType(Me.miragePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cachePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.infernoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.overpassPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trainPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nukePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dust2Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cobblestonePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.canalsPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agencyPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.variousPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mapStatsChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.saveButtonPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'varMapComboBox
        '
        Me.varMapComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.varMapComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.varMapComboBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.varMapComboBox.FormattingEnabled = True
        Me.varMapComboBox.Location = New System.Drawing.Point(586, 193)
        Me.varMapComboBox.Name = "varMapComboBox"
        Me.varMapComboBox.Size = New System.Drawing.Size(102, 24)
        Me.varMapComboBox.TabIndex = 1
        '
        'miragePic
        '
        Me.miragePic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.mir_dis
        Me.miragePic.Location = New System.Drawing.Point(8, 14)
        Me.miragePic.Name = "miragePic"
        Me.miragePic.Size = New System.Drawing.Size(111, 61)
        Me.miragePic.TabIndex = 2
        Me.miragePic.TabStop = False
        '
        'cachePic
        '
        Me.cachePic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.cac_dis
        Me.cachePic.Location = New System.Drawing.Point(123, 14)
        Me.cachePic.Name = "cachePic"
        Me.cachePic.Size = New System.Drawing.Size(111, 61)
        Me.cachePic.TabIndex = 3
        Me.cachePic.TabStop = False
        '
        'infernoPic
        '
        Me.infernoPic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.inf_dis
        Me.infernoPic.Location = New System.Drawing.Point(238, 14)
        Me.infernoPic.Name = "infernoPic"
        Me.infernoPic.Size = New System.Drawing.Size(111, 61)
        Me.infernoPic.TabIndex = 4
        Me.infernoPic.TabStop = False
        '
        'overpassPic
        '
        Me.overpassPic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.ove_dis
        Me.overpassPic.Location = New System.Drawing.Point(353, 14)
        Me.overpassPic.Name = "overpassPic"
        Me.overpassPic.Size = New System.Drawing.Size(111, 61)
        Me.overpassPic.TabIndex = 5
        Me.overpassPic.TabStop = False
        '
        'trainPic
        '
        Me.trainPic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.tra_dis
        Me.trainPic.Location = New System.Drawing.Point(467, 14)
        Me.trainPic.Name = "trainPic"
        Me.trainPic.Size = New System.Drawing.Size(111, 61)
        Me.trainPic.TabIndex = 6
        Me.trainPic.TabStop = False
        '
        'nukePic
        '
        Me.nukePic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.nuk_dis
        Me.nukePic.Location = New System.Drawing.Point(582, 14)
        Me.nukePic.Name = "nukePic"
        Me.nukePic.Size = New System.Drawing.Size(111, 61)
        Me.nukePic.TabIndex = 7
        Me.nukePic.TabStop = False
        '
        'dust2Pic
        '
        Me.dust2Pic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.dus_dis
        Me.dust2Pic.Location = New System.Drawing.Point(8, 130)
        Me.dust2Pic.Name = "dust2Pic"
        Me.dust2Pic.Size = New System.Drawing.Size(111, 61)
        Me.dust2Pic.TabIndex = 8
        Me.dust2Pic.TabStop = False
        '
        'cobblestonePic
        '
        Me.cobblestonePic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.cob_dis
        Me.cobblestonePic.Location = New System.Drawing.Point(123, 130)
        Me.cobblestonePic.Name = "cobblestonePic"
        Me.cobblestonePic.Size = New System.Drawing.Size(111, 61)
        Me.cobblestonePic.TabIndex = 9
        Me.cobblestonePic.TabStop = False
        '
        'officePic
        '
        Me.officePic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.off_dis
        Me.officePic.Location = New System.Drawing.Point(238, 130)
        Me.officePic.Name = "officePic"
        Me.officePic.Size = New System.Drawing.Size(111, 61)
        Me.officePic.TabIndex = 10
        Me.officePic.TabStop = False
        '
        'canalsPic
        '
        Me.canalsPic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.can_dis
        Me.canalsPic.Location = New System.Drawing.Point(353, 130)
        Me.canalsPic.Name = "canalsPic"
        Me.canalsPic.Size = New System.Drawing.Size(111, 61)
        Me.canalsPic.TabIndex = 11
        Me.canalsPic.TabStop = False
        '
        'agencyPic
        '
        Me.agencyPic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.age_dis
        Me.agencyPic.Location = New System.Drawing.Point(467, 130)
        Me.agencyPic.Name = "agencyPic"
        Me.agencyPic.Size = New System.Drawing.Size(111, 61)
        Me.agencyPic.TabIndex = 12
        Me.agencyPic.TabStop = False
        '
        'variousPic
        '
        Me.variousPic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.var_ena
        Me.variousPic.Location = New System.Drawing.Point(582, 130)
        Me.variousPic.Name = "variousPic"
        Me.variousPic.Size = New System.Drawing.Size(111, 61)
        Me.variousPic.TabIndex = 13
        Me.variousPic.TabStop = False
        '
        'mapStatsChart
        '
        ChartArea3.Name = "mapStatsChartArea"
        Me.mapStatsChart.ChartAreas.Add(ChartArea3)
        Legend3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend3.IsTextAutoFit = False
        Legend3.Name = "Legend1"
        Legend3.TitleFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mapStatsChart.Legends.Add(Legend3)
        Me.mapStatsChart.Location = New System.Drawing.Point(97, 241)
        Me.mapStatsChart.Name = "mapStatsChart"
        Me.mapStatsChart.Size = New System.Drawing.Size(447, 258)
        Me.mapStatsChart.TabIndex = 14
        Title3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.Name = "MapTitle"
        Me.mapStatsChart.Titles.Add(Title3)
        '
        'mirageCountLabel
        '
        Me.mirageCountLabel.BackColor = System.Drawing.Color.Transparent
        Me.mirageCountLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mirageCountLabel.Location = New System.Drawing.Point(78, 76)
        Me.mirageCountLabel.Name = "mirageCountLabel"
        Me.mirageCountLabel.Size = New System.Drawing.Size(40, 23)
        Me.mirageCountLabel.TabIndex = 15
        Me.mirageCountLabel.Text = "0"
        Me.mirageCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cacheCountLabel
        '
        Me.cacheCountLabel.BackColor = System.Drawing.Color.Transparent
        Me.cacheCountLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cacheCountLabel.Location = New System.Drawing.Point(192, 76)
        Me.cacheCountLabel.Name = "cacheCountLabel"
        Me.cacheCountLabel.Size = New System.Drawing.Size(40, 23)
        Me.cacheCountLabel.TabIndex = 16
        Me.cacheCountLabel.Text = "0"
        Me.cacheCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'infernoCountLabel
        '
        Me.infernoCountLabel.BackColor = System.Drawing.Color.Transparent
        Me.infernoCountLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infernoCountLabel.Location = New System.Drawing.Point(307, 76)
        Me.infernoCountLabel.Name = "infernoCountLabel"
        Me.infernoCountLabel.Size = New System.Drawing.Size(40, 23)
        Me.infernoCountLabel.TabIndex = 17
        Me.infernoCountLabel.Text = "0"
        Me.infernoCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'overpassCountLabel
        '
        Me.overpassCountLabel.BackColor = System.Drawing.Color.Transparent
        Me.overpassCountLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.overpassCountLabel.Location = New System.Drawing.Point(422, 76)
        Me.overpassCountLabel.Name = "overpassCountLabel"
        Me.overpassCountLabel.Size = New System.Drawing.Size(40, 23)
        Me.overpassCountLabel.TabIndex = 18
        Me.overpassCountLabel.Text = "0"
        Me.overpassCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'trainCountLabel
        '
        Me.trainCountLabel.BackColor = System.Drawing.Color.Transparent
        Me.trainCountLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trainCountLabel.Location = New System.Drawing.Point(536, 76)
        Me.trainCountLabel.Name = "trainCountLabel"
        Me.trainCountLabel.Size = New System.Drawing.Size(40, 23)
        Me.trainCountLabel.TabIndex = 19
        Me.trainCountLabel.Text = "0"
        Me.trainCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nukeCountLabel
        '
        Me.nukeCountLabel.BackColor = System.Drawing.Color.Transparent
        Me.nukeCountLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nukeCountLabel.Location = New System.Drawing.Point(651, 76)
        Me.nukeCountLabel.Name = "nukeCountLabel"
        Me.nukeCountLabel.Size = New System.Drawing.Size(40, 23)
        Me.nukeCountLabel.TabIndex = 20
        Me.nukeCountLabel.Text = "0"
        Me.nukeCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dustCountLabel
        '
        Me.dustCountLabel.BackColor = System.Drawing.Color.Transparent
        Me.dustCountLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dustCountLabel.Location = New System.Drawing.Point(77, 192)
        Me.dustCountLabel.Name = "dustCountLabel"
        Me.dustCountLabel.Size = New System.Drawing.Size(40, 23)
        Me.dustCountLabel.TabIndex = 21
        Me.dustCountLabel.Text = "0"
        Me.dustCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cobbleCountLabel
        '
        Me.cobbleCountLabel.BackColor = System.Drawing.Color.Transparent
        Me.cobbleCountLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobbleCountLabel.Location = New System.Drawing.Point(192, 192)
        Me.cobbleCountLabel.Name = "cobbleCountLabel"
        Me.cobbleCountLabel.Size = New System.Drawing.Size(40, 23)
        Me.cobbleCountLabel.TabIndex = 22
        Me.cobbleCountLabel.Text = "0"
        Me.cobbleCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'officeCountLabel
        '
        Me.officeCountLabel.BackColor = System.Drawing.Color.Transparent
        Me.officeCountLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeCountLabel.Location = New System.Drawing.Point(307, 192)
        Me.officeCountLabel.Name = "officeCountLabel"
        Me.officeCountLabel.Size = New System.Drawing.Size(40, 23)
        Me.officeCountLabel.TabIndex = 23
        Me.officeCountLabel.Text = "0"
        Me.officeCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'canalsCountLabel
        '
        Me.canalsCountLabel.BackColor = System.Drawing.Color.Transparent
        Me.canalsCountLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.canalsCountLabel.Location = New System.Drawing.Point(422, 192)
        Me.canalsCountLabel.Name = "canalsCountLabel"
        Me.canalsCountLabel.Size = New System.Drawing.Size(40, 23)
        Me.canalsCountLabel.TabIndex = 24
        Me.canalsCountLabel.Text = "0"
        Me.canalsCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'agencyCountLabel
        '
        Me.agencyCountLabel.BackColor = System.Drawing.Color.Transparent
        Me.agencyCountLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agencyCountLabel.Location = New System.Drawing.Point(536, 192)
        Me.agencyCountLabel.Name = "agencyCountLabel"
        Me.agencyCountLabel.Size = New System.Drawing.Size(40, 23)
        Me.agencyCountLabel.TabIndex = 25
        Me.agencyCountLabel.Text = "0"
        Me.agencyCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'saveButtonPic
        '
        Me.saveButtonPic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.down_dis
        Me.saveButtonPic.Location = New System.Drawing.Point(666, 478)
        Me.saveButtonPic.Name = "saveButtonPic"
        Me.saveButtonPic.Size = New System.Drawing.Size(20, 20)
        Me.saveButtonPic.TabIndex = 26
        Me.saveButtonPic.TabStop = False
        '
        'mapStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CSGOStats.My.Resources.Resources.bg_Maps
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(705, 511)
        Me.Controls.Add(Me.saveButtonPic)
        Me.Controls.Add(Me.agencyCountLabel)
        Me.Controls.Add(Me.canalsCountLabel)
        Me.Controls.Add(Me.officeCountLabel)
        Me.Controls.Add(Me.cobbleCountLabel)
        Me.Controls.Add(Me.dustCountLabel)
        Me.Controls.Add(Me.nukeCountLabel)
        Me.Controls.Add(Me.trainCountLabel)
        Me.Controls.Add(Me.overpassCountLabel)
        Me.Controls.Add(Me.infernoCountLabel)
        Me.Controls.Add(Me.cacheCountLabel)
        Me.Controls.Add(Me.mirageCountLabel)
        Me.Controls.Add(Me.mapStatsChart)
        Me.Controls.Add(Me.variousPic)
        Me.Controls.Add(Me.agencyPic)
        Me.Controls.Add(Me.canalsPic)
        Me.Controls.Add(Me.officePic)
        Me.Controls.Add(Me.cobblestonePic)
        Me.Controls.Add(Me.dust2Pic)
        Me.Controls.Add(Me.nukePic)
        Me.Controls.Add(Me.trainPic)
        Me.Controls.Add(Me.overpassPic)
        Me.Controls.Add(Me.infernoPic)
        Me.Controls.Add(Me.cachePic)
        Me.Controls.Add(Me.miragePic)
        Me.Controls.Add(Me.varMapComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mapStats"
        Me.Text = "mapStats"
        CType(Me.miragePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cachePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.infernoPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.overpassPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trainPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nukePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dust2Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cobblestonePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.canalsPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agencyPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.variousPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mapStatsChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.saveButtonPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents varMapComboBox As ComboBox
    Friend WithEvents miragePic As PictureBox
    Friend WithEvents cachePic As PictureBox
    Friend WithEvents infernoPic As PictureBox
    Friend WithEvents overpassPic As PictureBox
    Friend WithEvents trainPic As PictureBox
    Friend WithEvents nukePic As PictureBox
    Friend WithEvents dust2Pic As PictureBox
    Friend WithEvents cobblestonePic As PictureBox
    Friend WithEvents officePic As PictureBox
    Friend WithEvents canalsPic As PictureBox
    Friend WithEvents agencyPic As PictureBox
    Friend WithEvents variousPic As PictureBox
    Friend WithEvents mapStatsChart As DataVisualization.Charting.Chart
    Friend WithEvents mirageCountLabel As Label
    Friend WithEvents cacheCountLabel As Label
    Friend WithEvents infernoCountLabel As Label
    Friend WithEvents overpassCountLabel As Label
    Friend WithEvents trainCountLabel As Label
    Friend WithEvents nukeCountLabel As Label
    Friend WithEvents dustCountLabel As Label
    Friend WithEvents cobbleCountLabel As Label
    Friend WithEvents officeCountLabel As Label
    Friend WithEvents canalsCountLabel As Label
    Friend WithEvents agencyCountLabel As Label
    Friend WithEvents saveButtonPic As PictureBox
End Class
