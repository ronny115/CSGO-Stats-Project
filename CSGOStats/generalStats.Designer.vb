<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class generalStats
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
        Me.BackgroundWorkerGeneral = New System.ComponentModel.BackgroundWorker()
        Me.avgHsLabel = New System.Windows.Forms.Label()
        Me.avgPointsLabel = New System.Windows.Forms.Label()
        Me.totalKillsLabel = New System.Windows.Forms.Label()
        Me.totalDeathsLabel = New System.Windows.Forms.Label()
        Me.kdRatioLabel = New System.Windows.Forms.Label()
        Me.mapsPlayedLabel = New System.Windows.Forms.Label()
        Me.totalRoundsLabel = New System.Windows.Forms.Label()
        Me.killsRoundLabel = New System.Windows.Forms.Label()
        Me.assistsRoundLabel = New System.Windows.Forms.Label()
        Me.deathRoundLabel = New System.Windows.Forms.Label()
        Me.anualKDcomboBox = New System.Windows.Forms.ComboBox()
        Me.kdRatioChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.saveButtonPic = New System.Windows.Forms.PictureBox()
        Me.totalAssistsLabel = New System.Windows.Forms.Label()
        Me.winStrLabel = New System.Windows.Forms.Label()
        Me.lostStrLabel = New System.Windows.Forms.Label()
        Me.tieStrLabel = New System.Windows.Forms.Label()
        Me.avgMapDurationLabel = New System.Windows.Forms.Label()
        CType(Me.kdRatioChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.saveButtonPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'avgHsLabel
        '
        Me.avgHsLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgHsLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgHsLabel.Location = New System.Drawing.Point(102, 59)
        Me.avgHsLabel.Name = "avgHsLabel"
        Me.avgHsLabel.Size = New System.Drawing.Size(108, 23)
        Me.avgHsLabel.TabIndex = 30
        Me.avgHsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'avgPointsLabel
        '
        Me.avgPointsLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgPointsLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgPointsLabel.Location = New System.Drawing.Point(339, 167)
        Me.avgPointsLabel.Name = "avgPointsLabel"
        Me.avgPointsLabel.Size = New System.Drawing.Size(108, 23)
        Me.avgPointsLabel.TabIndex = 31
        Me.avgPointsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'totalKillsLabel
        '
        Me.totalKillsLabel.BackColor = System.Drawing.Color.Transparent
        Me.totalKillsLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalKillsLabel.Location = New System.Drawing.Point(102, 20)
        Me.totalKillsLabel.Name = "totalKillsLabel"
        Me.totalKillsLabel.Size = New System.Drawing.Size(108, 23)
        Me.totalKillsLabel.TabIndex = 32
        Me.totalKillsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'totalDeathsLabel
        '
        Me.totalDeathsLabel.BackColor = System.Drawing.Color.Transparent
        Me.totalDeathsLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalDeathsLabel.Location = New System.Drawing.Point(102, 95)
        Me.totalDeathsLabel.Name = "totalDeathsLabel"
        Me.totalDeathsLabel.Size = New System.Drawing.Size(108, 23)
        Me.totalDeathsLabel.TabIndex = 33
        Me.totalDeathsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'kdRatioLabel
        '
        Me.kdRatioLabel.BackColor = System.Drawing.Color.Transparent
        Me.kdRatioLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kdRatioLabel.Location = New System.Drawing.Point(102, 131)
        Me.kdRatioLabel.Name = "kdRatioLabel"
        Me.kdRatioLabel.Size = New System.Drawing.Size(108, 23)
        Me.kdRatioLabel.TabIndex = 34
        Me.kdRatioLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'mapsPlayedLabel
        '
        Me.mapsPlayedLabel.BackColor = System.Drawing.Color.Transparent
        Me.mapsPlayedLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mapsPlayedLabel.Location = New System.Drawing.Point(577, 20)
        Me.mapsPlayedLabel.Name = "mapsPlayedLabel"
        Me.mapsPlayedLabel.Size = New System.Drawing.Size(108, 23)
        Me.mapsPlayedLabel.TabIndex = 35
        Me.mapsPlayedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'totalRoundsLabel
        '
        Me.totalRoundsLabel.BackColor = System.Drawing.Color.Transparent
        Me.totalRoundsLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalRoundsLabel.Location = New System.Drawing.Point(339, 20)
        Me.totalRoundsLabel.Name = "totalRoundsLabel"
        Me.totalRoundsLabel.Size = New System.Drawing.Size(108, 23)
        Me.totalRoundsLabel.TabIndex = 36
        Me.totalRoundsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'killsRoundLabel
        '
        Me.killsRoundLabel.BackColor = System.Drawing.Color.Transparent
        Me.killsRoundLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.killsRoundLabel.Location = New System.Drawing.Point(339, 59)
        Me.killsRoundLabel.Name = "killsRoundLabel"
        Me.killsRoundLabel.Size = New System.Drawing.Size(108, 23)
        Me.killsRoundLabel.TabIndex = 37
        Me.killsRoundLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'assistsRoundLabel
        '
        Me.assistsRoundLabel.BackColor = System.Drawing.Color.Transparent
        Me.assistsRoundLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.assistsRoundLabel.Location = New System.Drawing.Point(339, 95)
        Me.assistsRoundLabel.Name = "assistsRoundLabel"
        Me.assistsRoundLabel.Size = New System.Drawing.Size(108, 23)
        Me.assistsRoundLabel.TabIndex = 38
        Me.assistsRoundLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'deathRoundLabel
        '
        Me.deathRoundLabel.BackColor = System.Drawing.Color.Transparent
        Me.deathRoundLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deathRoundLabel.Location = New System.Drawing.Point(339, 131)
        Me.deathRoundLabel.Name = "deathRoundLabel"
        Me.deathRoundLabel.Size = New System.Drawing.Size(108, 23)
        Me.deathRoundLabel.TabIndex = 39
        Me.deathRoundLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'anualKDcomboBox
        '
        Me.anualKDcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.anualKDcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.anualKDcomboBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.anualKDcomboBox.FormattingEnabled = True
        Me.anualKDcomboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.anualKDcomboBox.Location = New System.Drawing.Point(18, 214)
        Me.anualKDcomboBox.MaxDropDownItems = 15
        Me.anualKDcomboBox.Name = "anualKDcomboBox"
        Me.anualKDcomboBox.Size = New System.Drawing.Size(57, 22)
        Me.anualKDcomboBox.TabIndex = 40
        '
        'kdRatioChart
        '
        ChartArea3.AxisX.IsLabelAutoFit = False
        ChartArea3.AxisX.LabelStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea3.AxisX.LineColor = System.Drawing.Color.Gray
        ChartArea3.AxisX.Maximum = 12.0R
        ChartArea3.AxisX.Minimum = 1.0R
        ChartArea3.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea3.AxisY.LineColor = System.Drawing.Color.Gray
        ChartArea3.AxisY.Maximum = 2.5R
        ChartArea3.AxisY.Minimum = 0R
        ChartArea3.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea3.Name = "kdRatioChartArea"
        Me.kdRatioChart.ChartAreas.Add(ChartArea3)
        Legend3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend3.IsTextAutoFit = False
        Legend3.Name = "kdRatioLegend"
        Me.kdRatioChart.Legends.Add(Legend3)
        Me.kdRatioChart.Location = New System.Drawing.Point(18, 214)
        Me.kdRatioChart.Name = "kdRatioChart"
        Me.kdRatioChart.Size = New System.Drawing.Size(665, 285)
        Me.kdRatioChart.TabIndex = 41
        '
        'saveButtonPic
        '
        Me.saveButtonPic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.down_dis
        Me.saveButtonPic.Location = New System.Drawing.Point(665, 478)
        Me.saveButtonPic.Name = "saveButtonPic"
        Me.saveButtonPic.Size = New System.Drawing.Size(20, 20)
        Me.saveButtonPic.TabIndex = 42
        Me.saveButtonPic.TabStop = False
        '
        'totalAssistsLabel
        '
        Me.totalAssistsLabel.BackColor = System.Drawing.Color.Transparent
        Me.totalAssistsLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalAssistsLabel.Location = New System.Drawing.Point(102, 167)
        Me.totalAssistsLabel.Name = "totalAssistsLabel"
        Me.totalAssistsLabel.Size = New System.Drawing.Size(108, 23)
        Me.totalAssistsLabel.TabIndex = 43
        Me.totalAssistsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'winStrLabel
        '
        Me.winStrLabel.BackColor = System.Drawing.Color.Transparent
        Me.winStrLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.winStrLabel.Location = New System.Drawing.Point(577, 59)
        Me.winStrLabel.Name = "winStrLabel"
        Me.winStrLabel.Size = New System.Drawing.Size(108, 23)
        Me.winStrLabel.TabIndex = 44
        Me.winStrLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lostStrLabel
        '
        Me.lostStrLabel.BackColor = System.Drawing.Color.Transparent
        Me.lostStrLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lostStrLabel.Location = New System.Drawing.Point(577, 131)
        Me.lostStrLabel.Name = "lostStrLabel"
        Me.lostStrLabel.Size = New System.Drawing.Size(108, 23)
        Me.lostStrLabel.TabIndex = 45
        Me.lostStrLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tieStrLabel
        '
        Me.tieStrLabel.BackColor = System.Drawing.Color.Transparent
        Me.tieStrLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tieStrLabel.Location = New System.Drawing.Point(577, 95)
        Me.tieStrLabel.Name = "tieStrLabel"
        Me.tieStrLabel.Size = New System.Drawing.Size(108, 23)
        Me.tieStrLabel.TabIndex = 46
        Me.tieStrLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'avgMapDurationLabel
        '
        Me.avgMapDurationLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgMapDurationLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgMapDurationLabel.Location = New System.Drawing.Point(577, 167)
        Me.avgMapDurationLabel.Name = "avgMapDurationLabel"
        Me.avgMapDurationLabel.Size = New System.Drawing.Size(108, 23)
        Me.avgMapDurationLabel.TabIndex = 47
        Me.avgMapDurationLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'generalStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CSGOStats.My.Resources.Resources.bg_Gstats
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(705, 511)
        Me.Controls.Add(Me.avgMapDurationLabel)
        Me.Controls.Add(Me.tieStrLabel)
        Me.Controls.Add(Me.lostStrLabel)
        Me.Controls.Add(Me.winStrLabel)
        Me.Controls.Add(Me.totalAssistsLabel)
        Me.Controls.Add(Me.saveButtonPic)
        Me.Controls.Add(Me.anualKDcomboBox)
        Me.Controls.Add(Me.kdRatioChart)
        Me.Controls.Add(Me.deathRoundLabel)
        Me.Controls.Add(Me.assistsRoundLabel)
        Me.Controls.Add(Me.killsRoundLabel)
        Me.Controls.Add(Me.totalRoundsLabel)
        Me.Controls.Add(Me.mapsPlayedLabel)
        Me.Controls.Add(Me.kdRatioLabel)
        Me.Controls.Add(Me.totalDeathsLabel)
        Me.Controls.Add(Me.totalKillsLabel)
        Me.Controls.Add(Me.avgPointsLabel)
        Me.Controls.Add(Me.avgHsLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(20, 0)
        Me.Name = "generalStats"
        Me.Text = "generalStats"
        CType(Me.kdRatioChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.saveButtonPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorkerGeneral As System.ComponentModel.BackgroundWorker
    Friend WithEvents avgHsLabel As Label
    Friend WithEvents avgPointsLabel As Label
    Friend WithEvents totalKillsLabel As Label
    Friend WithEvents totalDeathsLabel As Label
    Friend WithEvents kdRatioLabel As Label
    Friend WithEvents mapsPlayedLabel As Label
    Friend WithEvents totalRoundsLabel As Label
    Friend WithEvents killsRoundLabel As Label
    Friend WithEvents assistsRoundLabel As Label
    Friend WithEvents deathRoundLabel As Label
    Friend WithEvents anualKDcomboBox As ComboBox
    Friend WithEvents kdRatioChart As DataVisualization.Charting.Chart
    Friend WithEvents saveButtonPic As PictureBox
    Friend WithEvents totalAssistsLabel As Label
    Friend WithEvents winStrLabel As Label
    Friend WithEvents lostStrLabel As Label
    Friend WithEvents tieStrLabel As Label
    Friend WithEvents avgMapDurationLabel As Label
End Class
