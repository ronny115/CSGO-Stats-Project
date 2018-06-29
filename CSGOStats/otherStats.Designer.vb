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
        Me.avgMapLabel = New System.Windows.Forms.Label()
        Me.avgWLabel = New System.Windows.Forms.Label()
        Me.avgLLabel = New System.Windows.Forms.Label()
        Me.maxLabel = New System.Windows.Forms.Label()
        Me.minLabel = New System.Windows.Forms.Label()
        Me.otherChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.otherStatsComboBox = New System.Windows.Forms.ComboBox()
        Me.saveButtonPic = New System.Windows.Forms.PictureBox()
        Me.longMDLabel = New System.Windows.Forms.Label()
        Me.shortMDLabel = New System.Windows.Forms.Label()
        Me.longWTLabel = New System.Windows.Forms.Label()
        Me.shortWTLabel = New System.Windows.Forms.Label()
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
        'avgMapLabel
        '
        Me.avgMapLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgMapLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgMapLabel.Location = New System.Drawing.Point(300, 54)
        Me.avgMapLabel.Name = "avgMapLabel"
        Me.avgMapLabel.Size = New System.Drawing.Size(387, 27)
        Me.avgMapLabel.TabIndex = 8
        Me.avgMapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgWLabel
        '
        Me.avgWLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgWLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgWLabel.Location = New System.Drawing.Point(300, 84)
        Me.avgWLabel.Name = "avgWLabel"
        Me.avgWLabel.Size = New System.Drawing.Size(387, 18)
        Me.avgWLabel.TabIndex = 9
        Me.avgWLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'avgLLabel
        '
        Me.avgLLabel.BackColor = System.Drawing.Color.Transparent
        Me.avgLLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avgLLabel.Location = New System.Drawing.Point(300, 105)
        Me.avgLLabel.Name = "avgLLabel"
        Me.avgLLabel.Size = New System.Drawing.Size(387, 18)
        Me.avgLLabel.TabIndex = 10
        Me.avgLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'maxLabel
        '
        Me.maxLabel.BackColor = System.Drawing.Color.Transparent
        Me.maxLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxLabel.Location = New System.Drawing.Point(300, 126)
        Me.maxLabel.Name = "maxLabel"
        Me.maxLabel.Size = New System.Drawing.Size(387, 26)
        Me.maxLabel.TabIndex = 11
        Me.maxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'minLabel
        '
        Me.minLabel.BackColor = System.Drawing.Color.Transparent
        Me.minLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minLabel.Location = New System.Drawing.Point(300, 155)
        Me.minLabel.Name = "minLabel"
        Me.minLabel.Size = New System.Drawing.Size(387, 26)
        Me.minLabel.TabIndex = 12
        Me.minLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'otherStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CSGOStats.My.Resources.Resources.bg_Other
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(705, 511)
        Me.Controls.Add(Me.shortWTLabel)
        Me.Controls.Add(Me.longWTLabel)
        Me.Controls.Add(Me.shortMDLabel)
        Me.Controls.Add(Me.longMDLabel)
        Me.Controls.Add(Me.saveButtonPic)
        Me.Controls.Add(Me.otherStatsComboBox)
        Me.Controls.Add(Me.otherChart)
        Me.Controls.Add(Me.minLabel)
        Me.Controls.Add(Me.maxLabel)
        Me.Controls.Add(Me.avgLLabel)
        Me.Controls.Add(Me.avgWLabel)
        Me.Controls.Add(Me.avgMapLabel)
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
    Friend WithEvents avgMapLabel As Label
    Friend WithEvents avgWLabel As Label
    Friend WithEvents avgLLabel As Label
    Friend WithEvents maxLabel As Label
    Friend WithEvents minLabel As Label
    Friend WithEvents otherChart As DataVisualization.Charting.Chart
    Friend WithEvents otherStatsComboBox As ComboBox
    Friend WithEvents saveButtonPic As PictureBox
    Friend WithEvents longMDLabel As Label
    Friend WithEvents shortMDLabel As Label
    Friend WithEvents longWTLabel As Label
    Friend WithEvents shortWTLabel As Label
End Class
