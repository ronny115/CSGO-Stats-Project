<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class otherStats
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.winSurrLabel = New System.Windows.Forms.Label()
        Me.lossSurrLabel = New System.Windows.Forms.Label()
        Me.roundsWinLabel = New System.Windows.Forms.Label()
        Me.roundsLostLabel = New System.Windows.Forms.Label()
        Me.avgMapPointsLabel = New System.Windows.Forms.Label()
        Me.avgWPointsLabel = New System.Windows.Forms.Label()
        Me.avgLPointsLabel = New System.Windows.Forms.Label()
        Me.maxPointsLabel = New System.Windows.Forms.Label()
        Me.minPointsLabel = New System.Windows.Forms.Label()
        Me.otherChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.otherStatsComboBox = New System.Windows.Forms.ComboBox()
        Me.saveButtonPic = New System.Windows.Forms.PictureBox()
        Me.longMDLabel = New System.Windows.Forms.Label()
        Me.shortMDLabel = New System.Windows.Forms.Label()
        Me.longWTLabel = New System.Windows.Forms.Label()
        Me.shortWTLabel = New System.Windows.Forms.Label()
        Me.minHsLabel = New System.Windows.Forms.Label()
        Me.maxHsLabel = New System.Windows.Forms.Label()
        Me.avgLHsLabel = New System.Windows.Forms.Label()
        Me.avgWHsLabel = New System.Windows.Forms.Label()
        Me.avgMapHsLabel = New System.Windows.Forms.Label()
        Me.minMvpLabel = New System.Windows.Forms.Label()
        Me.maxMvpLabel = New System.Windows.Forms.Label()
        Me.avgLMvpLabel = New System.Windows.Forms.Label()
        Me.avgWMvpLabel = New System.Windows.Forms.Label()
        Me.avgMapMvpLabel = New System.Windows.Forms.Label()
        Me.minDeathsLabel = New System.Windows.Forms.Label()
        Me.maxDeathsLabel = New System.Windows.Forms.Label()
        Me.avgLDeathsLabel = New System.Windows.Forms.Label()
        Me.avgWDeathsLabel = New System.Windows.Forms.Label()
        Me.avgMapDeathsLabel = New System.Windows.Forms.Label()
        Me.minAssistsLabel = New System.Windows.Forms.Label()
        Me.maxAssistsLabel = New System.Windows.Forms.Label()
        Me.avgLAssistsLabel = New System.Windows.Forms.Label()
        Me.avgWAssistsLabel = New System.Windows.Forms.Label()
        Me.avgMapAssistsLabel = New System.Windows.Forms.Label()
        Me.minKillsLabel = New System.Windows.Forms.Label()
        Me.maxKillsLabel = New System.Windows.Forms.Label()
        Me.avgLKillsLabel = New System.Windows.Forms.Label()
        Me.avgWKillsLabel = New System.Windows.Forms.Label()
        Me.avgMapKillsLabel = New System.Windows.Forms.Label()
        Me.minPingLabel = New System.Windows.Forms.Label()
        Me.maxPingLabel = New System.Windows.Forms.Label()
        Me.avgLPingLabel = New System.Windows.Forms.Label()
        Me.avgWPingLabel = New System.Windows.Forms.Label()
        Me.avgMapPingLabel = New System.Windows.Forms.Label()
        CType(Me.otherChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.saveButtonPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'winSurrLabel
        '
        Me.winSurrLabel.BackColor = System.Drawing.Color.Transparent
        Me.winSurrLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.winSurrLabel.Location = New System.Drawing.Point(74, 161)
        Me.winSurrLabel.Name = "winSurrLabel"
        Me.winSurrLabel.Size = New System.Drawing.Size(135, 22)
        Me.winSurrLabel.TabIndex = 4
        Me.winSurrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lossSurrLabel
        '
        Me.lossSurrLabel.BackColor = System.Drawing.Color.Transparent
        Me.lossSurrLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lossSurrLabel.Location = New System.Drawing.Point(74, 187)
        Me.lossSurrLabel.Name = "lossSurrLabel"
        Me.lossSurrLabel.Size = New System.Drawing.Size(135, 22)
        Me.lossSurrLabel.TabIndex = 5
        Me.lossSurrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'roundsWinLabel
        '
        Me.roundsWinLabel.BackColor = System.Drawing.Color.Transparent
        Me.roundsWinLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roundsWinLabel.Location = New System.Drawing.Point(74, 110)
        Me.roundsWinLabel.Name = "roundsWinLabel"
        Me.roundsWinLabel.Size = New System.Drawing.Size(135, 22)
        Me.roundsWinLabel.TabIndex = 6
        Me.roundsWinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'roundsLostLabel
        '
        Me.roundsLostLabel.BackColor = System.Drawing.Color.Transparent
        Me.roundsLostLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roundsLostLabel.Location = New System.Drawing.Point(74, 135)
        Me.roundsLostLabel.Name = "roundsLostLabel"
        Me.roundsLostLabel.Size = New System.Drawing.Size(135, 22)
        Me.roundsLostLabel.TabIndex = 7
        Me.roundsLostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgMapPointsLabel
        '
        Me.avgMapPointsLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgMapPointsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgMapPointsLabel.Location = New System.Drawing.Point(640, 54)
        Me.avgMapPointsLabel.Name = "avgMapPointsLabel"
        Me.avgMapPointsLabel.Size = New System.Drawing.Size(46, 27)
        Me.avgMapPointsLabel.TabIndex = 8
        Me.avgMapPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgWPointsLabel
        '
        Me.avgWPointsLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgWPointsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgWPointsLabel.Location = New System.Drawing.Point(640, 84)
        Me.avgWPointsLabel.Name = "avgWPointsLabel"
        Me.avgWPointsLabel.Size = New System.Drawing.Size(46, 18)
        Me.avgWPointsLabel.TabIndex = 9
        Me.avgWPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgLPointsLabel
        '
        Me.avgLPointsLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgLPointsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgLPointsLabel.Location = New System.Drawing.Point(640, 105)
        Me.avgLPointsLabel.Name = "avgLPointsLabel"
        Me.avgLPointsLabel.Size = New System.Drawing.Size(46, 18)
        Me.avgLPointsLabel.TabIndex = 10
        Me.avgLPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'maxPointsLabel
        '
        Me.maxPointsLabel.BackColor = System.Drawing.Color.Transparent
        Me.maxPointsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxPointsLabel.Location = New System.Drawing.Point(640, 126)
        Me.maxPointsLabel.Name = "maxPointsLabel"
        Me.maxPointsLabel.Size = New System.Drawing.Size(46, 26)
        Me.maxPointsLabel.TabIndex = 11
        Me.maxPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'minPointsLabel
        '
        Me.minPointsLabel.BackColor = System.Drawing.Color.Transparent
        Me.minPointsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minPointsLabel.Location = New System.Drawing.Point(640, 155)
        Me.minPointsLabel.Name = "minPointsLabel"
        Me.minPointsLabel.Size = New System.Drawing.Size(46, 26)
        Me.minPointsLabel.TabIndex = 12
        Me.minPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'otherChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.otherChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.otherChart.Legends.Add(Legend1)
        Me.otherChart.Location = New System.Drawing.Point(12, 222)
        Me.otherChart.Name = "otherChart"
        Me.otherChart.Size = New System.Drawing.Size(681, 277)
        Me.otherChart.TabIndex = 14
        Me.otherChart.Text = "Chart1"
        '
        'otherStatsComboBox
        '
        Me.otherStatsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.otherStatsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.otherStatsComboBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otherStatsComboBox.FormattingEnabled = True
        Me.otherStatsComboBox.Location = New System.Drawing.Point(12, 222)
        Me.otherStatsComboBox.Name = "otherStatsComboBox"
        Me.otherStatsComboBox.Size = New System.Drawing.Size(120, 22)
        Me.otherStatsComboBox.TabIndex = 15
        '
        'saveButtonPic
        '
        Me.saveButtonPic.BackgroundImage = Global.CSGOStats.My.Resources.Resources.down_dis
        Me.saveButtonPic.Location = New System.Drawing.Point(671, 480)
        Me.saveButtonPic.Name = "saveButtonPic"
        Me.saveButtonPic.Size = New System.Drawing.Size(20, 20)
        Me.saveButtonPic.TabIndex = 16
        Me.saveButtonPic.TabStop = False
        '
        'longMDLabel
        '
        Me.longMDLabel.BackColor = System.Drawing.Color.Transparent
        Me.longMDLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.longMDLabel.Location = New System.Drawing.Point(74, 9)
        Me.longMDLabel.Name = "longMDLabel"
        Me.longMDLabel.Size = New System.Drawing.Size(135, 22)
        Me.longMDLabel.TabIndex = 17
        Me.longMDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'shortMDLabel
        '
        Me.shortMDLabel.BackColor = System.Drawing.Color.Transparent
        Me.shortMDLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shortMDLabel.Location = New System.Drawing.Point(74, 35)
        Me.shortMDLabel.Name = "shortMDLabel"
        Me.shortMDLabel.Size = New System.Drawing.Size(135, 22)
        Me.shortMDLabel.TabIndex = 18
        Me.shortMDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'longWTLabel
        '
        Me.longWTLabel.BackColor = System.Drawing.Color.Transparent
        Me.longWTLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.longWTLabel.Location = New System.Drawing.Point(74, 60)
        Me.longWTLabel.Name = "longWTLabel"
        Me.longWTLabel.Size = New System.Drawing.Size(135, 22)
        Me.longWTLabel.TabIndex = 19
        Me.longWTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'shortWTLabel
        '
        Me.shortWTLabel.BackColor = System.Drawing.Color.Transparent
        Me.shortWTLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shortWTLabel.Location = New System.Drawing.Point(74, 85)
        Me.shortWTLabel.Name = "shortWTLabel"
        Me.shortWTLabel.Size = New System.Drawing.Size(135, 22)
        Me.shortWTLabel.TabIndex = 20
        Me.shortWTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'minHsLabel
        '
        Me.minHsLabel.BackColor = System.Drawing.Color.Transparent
        Me.minHsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minHsLabel.Location = New System.Drawing.Point(584, 155)
        Me.minHsLabel.Name = "minHsLabel"
        Me.minHsLabel.Size = New System.Drawing.Size(53, 26)
        Me.minHsLabel.TabIndex = 25
        Me.minHsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'maxHsLabel
        '
        Me.maxHsLabel.BackColor = System.Drawing.Color.Transparent
        Me.maxHsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxHsLabel.Location = New System.Drawing.Point(584, 126)
        Me.maxHsLabel.Name = "maxHsLabel"
        Me.maxHsLabel.Size = New System.Drawing.Size(53, 26)
        Me.maxHsLabel.TabIndex = 24
        Me.maxHsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgLHsLabel
        '
        Me.avgLHsLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgLHsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgLHsLabel.Location = New System.Drawing.Point(584, 105)
        Me.avgLHsLabel.Name = "avgLHsLabel"
        Me.avgLHsLabel.Size = New System.Drawing.Size(53, 18)
        Me.avgLHsLabel.TabIndex = 23
        Me.avgLHsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgWHsLabel
        '
        Me.avgWHsLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgWHsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgWHsLabel.Location = New System.Drawing.Point(584, 84)
        Me.avgWHsLabel.Name = "avgWHsLabel"
        Me.avgWHsLabel.Size = New System.Drawing.Size(53, 18)
        Me.avgWHsLabel.TabIndex = 22
        Me.avgWHsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgMapHsLabel
        '
        Me.avgMapHsLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgMapHsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgMapHsLabel.Location = New System.Drawing.Point(584, 54)
        Me.avgMapHsLabel.Name = "avgMapHsLabel"
        Me.avgMapHsLabel.Size = New System.Drawing.Size(53, 27)
        Me.avgMapHsLabel.TabIndex = 21
        Me.avgMapHsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'minMvpLabel
        '
        Me.minMvpLabel.BackColor = System.Drawing.Color.Transparent
        Me.minMvpLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minMvpLabel.Location = New System.Drawing.Point(528, 155)
        Me.minMvpLabel.Name = "minMvpLabel"
        Me.minMvpLabel.Size = New System.Drawing.Size(53, 26)
        Me.minMvpLabel.TabIndex = 30
        Me.minMvpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'maxMvpLabel
        '
        Me.maxMvpLabel.BackColor = System.Drawing.Color.Transparent
        Me.maxMvpLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxMvpLabel.Location = New System.Drawing.Point(528, 126)
        Me.maxMvpLabel.Name = "maxMvpLabel"
        Me.maxMvpLabel.Size = New System.Drawing.Size(53, 26)
        Me.maxMvpLabel.TabIndex = 29
        Me.maxMvpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgLMvpLabel
        '
        Me.avgLMvpLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgLMvpLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgLMvpLabel.Location = New System.Drawing.Point(528, 105)
        Me.avgLMvpLabel.Name = "avgLMvpLabel"
        Me.avgLMvpLabel.Size = New System.Drawing.Size(53, 18)
        Me.avgLMvpLabel.TabIndex = 28
        Me.avgLMvpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgWMvpLabel
        '
        Me.avgWMvpLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgWMvpLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgWMvpLabel.Location = New System.Drawing.Point(528, 84)
        Me.avgWMvpLabel.Name = "avgWMvpLabel"
        Me.avgWMvpLabel.Size = New System.Drawing.Size(53, 18)
        Me.avgWMvpLabel.TabIndex = 27
        Me.avgWMvpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgMapMvpLabel
        '
        Me.avgMapMvpLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgMapMvpLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgMapMvpLabel.Location = New System.Drawing.Point(528, 54)
        Me.avgMapMvpLabel.Name = "avgMapMvpLabel"
        Me.avgMapMvpLabel.Size = New System.Drawing.Size(53, 27)
        Me.avgMapMvpLabel.TabIndex = 26
        Me.avgMapMvpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'minDeathsLabel
        '
        Me.minDeathsLabel.BackColor = System.Drawing.Color.Transparent
        Me.minDeathsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minDeathsLabel.Location = New System.Drawing.Point(469, 155)
        Me.minDeathsLabel.Name = "minDeathsLabel"
        Me.minDeathsLabel.Size = New System.Drawing.Size(53, 26)
        Me.minDeathsLabel.TabIndex = 35
        Me.minDeathsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'maxDeathsLabel
        '
        Me.maxDeathsLabel.BackColor = System.Drawing.Color.Transparent
        Me.maxDeathsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxDeathsLabel.Location = New System.Drawing.Point(469, 126)
        Me.maxDeathsLabel.Name = "maxDeathsLabel"
        Me.maxDeathsLabel.Size = New System.Drawing.Size(53, 26)
        Me.maxDeathsLabel.TabIndex = 34
        Me.maxDeathsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgLDeathsLabel
        '
        Me.avgLDeathsLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgLDeathsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgLDeathsLabel.Location = New System.Drawing.Point(469, 105)
        Me.avgLDeathsLabel.Name = "avgLDeathsLabel"
        Me.avgLDeathsLabel.Size = New System.Drawing.Size(53, 18)
        Me.avgLDeathsLabel.TabIndex = 33
        Me.avgLDeathsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgWDeathsLabel
        '
        Me.avgWDeathsLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgWDeathsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgWDeathsLabel.Location = New System.Drawing.Point(469, 84)
        Me.avgWDeathsLabel.Name = "avgWDeathsLabel"
        Me.avgWDeathsLabel.Size = New System.Drawing.Size(53, 18)
        Me.avgWDeathsLabel.TabIndex = 32
        Me.avgWDeathsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgMapDeathsLabel
        '
        Me.avgMapDeathsLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgMapDeathsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgMapDeathsLabel.Location = New System.Drawing.Point(469, 54)
        Me.avgMapDeathsLabel.Name = "avgMapDeathsLabel"
        Me.avgMapDeathsLabel.Size = New System.Drawing.Size(53, 27)
        Me.avgMapDeathsLabel.TabIndex = 31
        Me.avgMapDeathsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'minAssistsLabel
        '
        Me.minAssistsLabel.BackColor = System.Drawing.Color.Transparent
        Me.minAssistsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minAssistsLabel.Location = New System.Drawing.Point(415, 155)
        Me.minAssistsLabel.Name = "minAssistsLabel"
        Me.minAssistsLabel.Size = New System.Drawing.Size(53, 26)
        Me.minAssistsLabel.TabIndex = 40
        Me.minAssistsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'maxAssistsLabel
        '
        Me.maxAssistsLabel.BackColor = System.Drawing.Color.Transparent
        Me.maxAssistsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxAssistsLabel.Location = New System.Drawing.Point(415, 126)
        Me.maxAssistsLabel.Name = "maxAssistsLabel"
        Me.maxAssistsLabel.Size = New System.Drawing.Size(53, 26)
        Me.maxAssistsLabel.TabIndex = 39
        Me.maxAssistsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgLAssistsLabel
        '
        Me.avgLAssistsLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgLAssistsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgLAssistsLabel.Location = New System.Drawing.Point(415, 105)
        Me.avgLAssistsLabel.Name = "avgLAssistsLabel"
        Me.avgLAssistsLabel.Size = New System.Drawing.Size(53, 18)
        Me.avgLAssistsLabel.TabIndex = 38
        Me.avgLAssistsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgWAssistsLabel
        '
        Me.avgWAssistsLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgWAssistsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgWAssistsLabel.Location = New System.Drawing.Point(415, 84)
        Me.avgWAssistsLabel.Name = "avgWAssistsLabel"
        Me.avgWAssistsLabel.Size = New System.Drawing.Size(53, 18)
        Me.avgWAssistsLabel.TabIndex = 37
        Me.avgWAssistsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgMapAssistsLabel
        '
        Me.avgMapAssistsLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgMapAssistsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgMapAssistsLabel.Location = New System.Drawing.Point(415, 54)
        Me.avgMapAssistsLabel.Name = "avgMapAssistsLabel"
        Me.avgMapAssistsLabel.Size = New System.Drawing.Size(53, 27)
        Me.avgMapAssistsLabel.TabIndex = 36
        Me.avgMapAssistsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'minKillsLabel
        '
        Me.minKillsLabel.BackColor = System.Drawing.Color.Transparent
        Me.minKillsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minKillsLabel.Location = New System.Drawing.Point(359, 155)
        Me.minKillsLabel.Name = "minKillsLabel"
        Me.minKillsLabel.Size = New System.Drawing.Size(53, 26)
        Me.minKillsLabel.TabIndex = 45
        Me.minKillsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'maxKillsLabel
        '
        Me.maxKillsLabel.BackColor = System.Drawing.Color.Transparent
        Me.maxKillsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxKillsLabel.Location = New System.Drawing.Point(359, 126)
        Me.maxKillsLabel.Name = "maxKillsLabel"
        Me.maxKillsLabel.Size = New System.Drawing.Size(53, 26)
        Me.maxKillsLabel.TabIndex = 44
        Me.maxKillsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgLKillsLabel
        '
        Me.avgLKillsLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgLKillsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgLKillsLabel.Location = New System.Drawing.Point(359, 105)
        Me.avgLKillsLabel.Name = "avgLKillsLabel"
        Me.avgLKillsLabel.Size = New System.Drawing.Size(53, 18)
        Me.avgLKillsLabel.TabIndex = 43
        Me.avgLKillsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgWKillsLabel
        '
        Me.avgWKillsLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgWKillsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgWKillsLabel.Location = New System.Drawing.Point(359, 84)
        Me.avgWKillsLabel.Name = "avgWKillsLabel"
        Me.avgWKillsLabel.Size = New System.Drawing.Size(53, 18)
        Me.avgWKillsLabel.TabIndex = 42
        Me.avgWKillsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgMapKillsLabel
        '
        Me.avgMapKillsLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgMapKillsLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgMapKillsLabel.Location = New System.Drawing.Point(359, 54)
        Me.avgMapKillsLabel.Name = "avgMapKillsLabel"
        Me.avgMapKillsLabel.Size = New System.Drawing.Size(53, 27)
        Me.avgMapKillsLabel.TabIndex = 41
        Me.avgMapKillsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'minPingLabel
        '
        Me.minPingLabel.BackColor = System.Drawing.Color.Transparent
        Me.minPingLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minPingLabel.Location = New System.Drawing.Point(302, 155)
        Me.minPingLabel.Name = "minPingLabel"
        Me.minPingLabel.Size = New System.Drawing.Size(53, 26)
        Me.minPingLabel.TabIndex = 50
        Me.minPingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'maxPingLabel
        '
        Me.maxPingLabel.BackColor = System.Drawing.Color.Transparent
        Me.maxPingLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxPingLabel.Location = New System.Drawing.Point(302, 126)
        Me.maxPingLabel.Name = "maxPingLabel"
        Me.maxPingLabel.Size = New System.Drawing.Size(53, 26)
        Me.maxPingLabel.TabIndex = 49
        Me.maxPingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgLPingLabel
        '
        Me.avgLPingLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgLPingLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgLPingLabel.Location = New System.Drawing.Point(302, 105)
        Me.avgLPingLabel.Name = "avgLPingLabel"
        Me.avgLPingLabel.Size = New System.Drawing.Size(53, 18)
        Me.avgLPingLabel.TabIndex = 48
        Me.avgLPingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgWPingLabel
        '
        Me.avgWPingLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgWPingLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgWPingLabel.Location = New System.Drawing.Point(302, 84)
        Me.avgWPingLabel.Name = "avgWPingLabel"
        Me.avgWPingLabel.Size = New System.Drawing.Size(53, 18)
        Me.avgWPingLabel.TabIndex = 47
        Me.avgWPingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgMapPingLabel
        '
        Me.avgMapPingLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgMapPingLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgMapPingLabel.Location = New System.Drawing.Point(302, 54)
        Me.avgMapPingLabel.Name = "avgMapPingLabel"
        Me.avgMapPingLabel.Size = New System.Drawing.Size(53, 27)
        Me.avgMapPingLabel.TabIndex = 46
        Me.avgMapPingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'otherStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CSGOStats.My.Resources.Resources.bg_Other
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(705, 511)
        Me.Controls.Add(Me.minPingLabel)
        Me.Controls.Add(Me.maxPingLabel)
        Me.Controls.Add(Me.avgLPingLabel)
        Me.Controls.Add(Me.avgWPingLabel)
        Me.Controls.Add(Me.avgMapPingLabel)
        Me.Controls.Add(Me.minKillsLabel)
        Me.Controls.Add(Me.maxKillsLabel)
        Me.Controls.Add(Me.avgLKillsLabel)
        Me.Controls.Add(Me.avgWKillsLabel)
        Me.Controls.Add(Me.avgMapKillsLabel)
        Me.Controls.Add(Me.minAssistsLabel)
        Me.Controls.Add(Me.maxAssistsLabel)
        Me.Controls.Add(Me.avgLAssistsLabel)
        Me.Controls.Add(Me.avgWAssistsLabel)
        Me.Controls.Add(Me.avgMapAssistsLabel)
        Me.Controls.Add(Me.minDeathsLabel)
        Me.Controls.Add(Me.maxDeathsLabel)
        Me.Controls.Add(Me.avgLDeathsLabel)
        Me.Controls.Add(Me.avgWDeathsLabel)
        Me.Controls.Add(Me.avgMapDeathsLabel)
        Me.Controls.Add(Me.minMvpLabel)
        Me.Controls.Add(Me.maxMvpLabel)
        Me.Controls.Add(Me.avgLMvpLabel)
        Me.Controls.Add(Me.avgWMvpLabel)
        Me.Controls.Add(Me.avgMapMvpLabel)
        Me.Controls.Add(Me.minHsLabel)
        Me.Controls.Add(Me.maxHsLabel)
        Me.Controls.Add(Me.avgLHsLabel)
        Me.Controls.Add(Me.avgWHsLabel)
        Me.Controls.Add(Me.avgMapHsLabel)
        Me.Controls.Add(Me.shortWTLabel)
        Me.Controls.Add(Me.longWTLabel)
        Me.Controls.Add(Me.shortMDLabel)
        Me.Controls.Add(Me.longMDLabel)
        Me.Controls.Add(Me.saveButtonPic)
        Me.Controls.Add(Me.otherStatsComboBox)
        Me.Controls.Add(Me.otherChart)
        Me.Controls.Add(Me.minPointsLabel)
        Me.Controls.Add(Me.maxPointsLabel)
        Me.Controls.Add(Me.avgLPointsLabel)
        Me.Controls.Add(Me.avgWPointsLabel)
        Me.Controls.Add(Me.avgMapPointsLabel)
        Me.Controls.Add(Me.roundsLostLabel)
        Me.Controls.Add(Me.roundsWinLabel)
        Me.Controls.Add(Me.lossSurrLabel)
        Me.Controls.Add(Me.winSurrLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "otherStats"
        Me.Text = "otherStats"
        CType(Me.otherChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.saveButtonPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents winSurrLabel As Label
    Friend WithEvents lossSurrLabel As Label
    Friend WithEvents roundsWinLabel As Label
    Friend WithEvents roundsLostLabel As Label
    Friend WithEvents avgMapPointsLabel As Label
    Friend WithEvents avgWPointsLabel As Label
    Friend WithEvents avgLPointsLabel As Label
    Friend WithEvents maxPointsLabel As Label
    Friend WithEvents minPointsLabel As Label
    Friend WithEvents otherChart As DataVisualization.Charting.Chart
    Friend WithEvents otherStatsComboBox As ComboBox
    Friend WithEvents saveButtonPic As PictureBox
    Friend WithEvents longMDLabel As Label
    Friend WithEvents shortMDLabel As Label
    Friend WithEvents longWTLabel As Label
    Friend WithEvents shortWTLabel As Label
    Friend WithEvents minHsLabel As Label
    Friend WithEvents maxHsLabel As Label
    Friend WithEvents avgLHsLabel As Label
    Friend WithEvents avgWHsLabel As Label
    Friend WithEvents avgMapHsLabel As Label
    Friend WithEvents minMvpLabel As Label
    Friend WithEvents maxMvpLabel As Label
    Friend WithEvents avgLMvpLabel As Label
    Friend WithEvents avgWMvpLabel As Label
    Friend WithEvents avgMapMvpLabel As Label
    Friend WithEvents minDeathsLabel As Label
    Friend WithEvents maxDeathsLabel As Label
    Friend WithEvents avgLDeathsLabel As Label
    Friend WithEvents avgWDeathsLabel As Label
    Friend WithEvents avgMapDeathsLabel As Label
    Friend WithEvents minAssistsLabel As Label
    Friend WithEvents maxAssistsLabel As Label
    Friend WithEvents avgLAssistsLabel As Label
    Friend WithEvents avgWAssistsLabel As Label
    Friend WithEvents avgMapAssistsLabel As Label
    Friend WithEvents minKillsLabel As Label
    Friend WithEvents maxKillsLabel As Label
    Friend WithEvents avgLKillsLabel As Label
    Friend WithEvents avgWKillsLabel As Label
    Friend WithEvents avgMapKillsLabel As Label
    Friend WithEvents minPingLabel As Label
    Friend WithEvents maxPingLabel As Label
    Friend WithEvents avgLPingLabel As Label
    Friend WithEvents avgWPingLabel As Label
    Friend WithEvents avgMapPingLabel As Label
End Class
