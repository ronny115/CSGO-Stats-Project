Public Class otherStats
    'Reduces loading flicker
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As System.Windows.Forms.CreateParams = MyBase.CreateParams
            cp.ExStyle += 33554432
            Return cp
        End Get
    End Property
    Private Sub statsByYear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = CSGOStats
        otherStatsComboBox.Items.Add("Rounds W/L")
        otherStatsComboBox.Items.Add("Kills Distribution")
        otherStatsComboBox.Items.Add("Asissts Distribution")
        otherStatsComboBox.Items.Add("Deaths Distribution")
        otherStatsComboBox.SelectedIndex = 0
        Dim time As New TimeSpan(0, 0, maxMatchDuration)
        longMDLabel.Text = Int(time.TotalMinutes) & ":" & time.ToString("ss")
        Dim time1 As New TimeSpan(0, 0, minMatchDuration)
        shortMDLabel.Text = Int(time1.TotalMinutes) & ":" & time1.ToString("ss")
        Dim time2 As New TimeSpan(0, 0, maxMatchWait)
        longWTLabel.Text = Int(time2.TotalMinutes) & ":" & time2.ToString("ss")
        Dim time3 As New TimeSpan(0, 0, minMatchWait)
        shortWTLabel.Text = Int(time3.TotalMinutes) & ":" & time3.ToString("ss")

        winSurrLabel.Text = winBySurrender
        lossSurrLabel.Text = lostBySurrender
        roundsWinLabel.Text = totalRoundsWin
        roundsLostLabel.Text = totalRoundsLost

        avgMapLabel.Text = avgPing & "          " & Format(avgFrags, "00.00") & "           " & Format(avgAssists, "0.00") & "          " & Format(avgDeaths, "00.00") _
            & "          " & Format(avgMvp, "0.00") & "★      " & Format(avgHs, "00.00") & "%            " & Format(avgPoints, "00")
        avgWLabel.Text = avgWPing & "          " & Format(avgWFrags, "00.00") & "           " & Format(avgWAssists, "0.00") & "          " & Format(avgWDeaths, "00.00") _
            & "          " & Format(avgWMvp, "0.00") & "★      " & Format(avgWHs, "00.00") & "%            " & Format(avgWPoints, "00")
        avgLLabel.Text = avgLPing & "          " & Format(avgLFrags, "00.00") & "           " & Format(avgLAssists, "0.00") & "          " & Format(avgLDeaths, "00.00") _
            & "          " & Format(avgLMvp, "0.00") & "★      " & Format(avgLHs, "00.00") & "%            " & Format(avgLPoints, "00")
        maxLabel.Text = maxPing & "               " & Format(maxFrags, "00") & "               " & Format(maxAssists, "00") & "               " & Format(maxDeaths, "00") _
            & "             " & Format(maxMvp, "00") & "★         " & Format(maxHs, "00") & "%            " & Format(maxPoints, "00")
        minLabel.Text = minPing & "               " & Format(minFrags, "00") & "               " & Format(minAssists, "00") & "               " & Format(minDeaths, "00") _
            & "             " & Format(minMvp, "00") & "★         " & Format(minHs, "000") & "%            " & Format(minPoints, "00")
    End Sub
    Private Sub roundsChartLoad()
        otherChart.Series.Clear()
        otherChart.Titles.Clear()
        otherChart.Titles.Add("OtherTitle")
        otherChart.Titles(0).Text = "Rounds Won/Lost"
        otherChart.Titles(0).Font = New Font("Arial", 9, FontStyle.Bold)
        otherChart.Series.Add("Other Stats")
        otherChart.Series(0).Font = New Font("Arial", 8, FontStyle.Regular)
        otherChart.Series(0).Points.AddXY(Math.Round(((totalRoundsWin * 100) / roundsPlayed), 2, MidpointRounding.AwayFromZero) & "%", totalRoundsWin)
        otherChart.Series(0).Points(0).LegendText = "Rounds Won"
        otherChart.Series(0).Points(0).Font = New Font("Arial", 8, FontStyle.Regular)
        otherChart.Series(0).Points.AddXY(Math.Round(((totalRoundsLost * 100) / roundsPlayed), 2, MidpointRounding.AwayFromZero) & "%", totalRoundsLost)
        otherChart.Series(0).Points(1).LegendText = "Rounds Lost"
        otherChart.Series(0).Points(1).Font = New Font("Arial", 8, FontStyle.Regular)
        otherChart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
    End Sub
    Private Sub distributionChartLoad()
        Dim killsDist, asisstsDist, deathsDist As New List(Of String)
        Dim ki, assi, de As New List(Of Integer)
        ki = frags : ki.Sort()
        assi = assists : assi.Sort()
        de = deaths : de.Sort()

        otherChart.Series.Clear()
        otherChart.Titles.Clear()
        otherChart.Titles.Add("OtherTitle")
        otherChart.Titles(0).Text = otherStatsComboBox.SelectedItem
        otherChart.Titles(0).Font = New Font("Arial", 9, FontStyle.Bold)
        otherChart.Series.Add("Other Stats")
        otherChart.Series(0).Font = New Font("Arial", 8, FontStyle.Regular)
        otherChart.Series(0).IsVisibleInLegend = False
        otherChart.ChartAreas(0).AxisY.MajorGrid.LineDashStyle = 2
        otherChart.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.LightGray
        otherChart.ChartAreas(0).AxisY.Title = "Occurrences"
        otherChart.ChartAreas(0).AxisY.TitleAlignment = StringAlignment.Center
        otherChart.ChartAreas(0).AxisY.TitleFont = New Font("Arial", 9, FontStyle.Bold)
        otherChart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
        If otherStatsComboBox.SelectedIndex = 1 Then
            Dim killList = ki.GroupBy(Function(value) value)
            For Each frag In killList
                otherChart.ChartAreas(0).AxisX.Interval = 1
                otherChart.ChartAreas(0).AxisX.MajorGrid.Enabled = False
                otherChart.ChartAreas(0).AxisX.Title = ""
                otherChart.ChartAreas(0).AxisX.TitleAlignment = StringAlignment.Center
                otherChart.ChartAreas(0).AxisX.TitleFont = New Font("Arial", 9, FontStyle.Bold)
                otherChart.Series(0).Points.AddXY(" " & frag(0), frag.Count)
            Next
        End If
        If otherStatsComboBox.SelectedIndex = 2 Then
            Dim assistList = assi.GroupBy(Function(value) value)
            For Each assist In assistList
                otherChart.ChartAreas(0).AxisX.Interval = 1
                otherChart.ChartAreas(0).AxisX.MajorGrid.Enabled = False
                otherChart.ChartAreas(0).AxisX.Title = ""
                otherChart.ChartAreas(0).AxisX.TitleAlignment = StringAlignment.Center
                otherChart.ChartAreas(0).AxisX.TitleFont = New Font("Arial", 9, FontStyle.Bold)
                otherChart.Series(0).Points.AddXY(" " & assist(0), assist.Count)
            Next
        End If
        If otherStatsComboBox.SelectedIndex = 3 Then
            Dim deathList = de.GroupBy(Function(value) value)
            For Each death In deathList
                otherChart.ChartAreas(0).AxisX.Interval = 1
                otherChart.ChartAreas(0).AxisX.MajorGrid.Enabled = False
                otherChart.ChartAreas(0).AxisX.Title = ""
                otherChart.ChartAreas(0).AxisX.TitleAlignment = StringAlignment.Center
                otherChart.ChartAreas(0).AxisX.TitleFont = New Font("Arial", 9, FontStyle.Bold)
                otherChart.Series(0).Points.AddXY(" " & death(0), death.Count)
            Next
        End If
        otherChart.Series(0).Points(0).Font = New Font("Arial", 8, FontStyle.Regular)
    End Sub
    Private Sub otherStatsComboBoxItemChanged(sender As Object, e As EventArgs) Handles otherStatsComboBox.SelectedIndexChanged
        otherChart.Focus()
        If otherStatsComboBox.SelectedIndex = 0 Then
            roundsChartLoad()
        Else
            distributionChartLoad()
        End If
    End Sub
    '//////////////
    'Save button///
    '//////////////
    Private Sub saveButtonPicEnter(sender As Object, e As EventArgs) Handles saveButtonPic.MouseEnter
        saveButtonPic.Image = New Bitmap(My.Resources.down_ena)
    End Sub
    Private Sub saveButtonPicLeave(sender As Object, e As EventArgs) Handles saveButtonPic.MouseLeave
        saveButtonPic.Image = New Bitmap(My.Resources.down_dis)
    End Sub
    Private Sub saveButtonPicClick(sender As Object, e As EventArgs) Handles saveButtonPic.Click
        Dim saveMapChart As New SaveFileDialog()
        Dim saveMapImage As String
        saveMapChart.InitialDirectory = "C:\Users\Public\Public Desktop\"
        saveMapChart.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpeg)|*.jpeg|EMF (*.emf)|*.emf|PNG (*.png)|*.png|GIF (*.gif)|*.gif|TIFF (*.tif)|*.tif"
        saveMapChart.FilterIndex = 4
        saveMapChart.ShowDialog()
        saveMapImage = saveMapChart.FileName
        If saveMapChart.FileName <> "" Then
            Select Case saveMapChart.FilterIndex
                Case 1
                    otherChart.SaveImage(saveMapChart.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
                Case 2
                    otherChart.SaveImage(saveMapChart.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                Case 3
                    otherChart.SaveImage(saveMapChart.FileName, System.Drawing.Imaging.ImageFormat.Emf)
                Case 4
                    otherChart.SaveImage(saveMapChart.FileName, System.Drawing.Imaging.ImageFormat.Png)
                Case 5
                    otherChart.SaveImage(saveMapChart.FileName, System.Drawing.Imaging.ImageFormat.Gif)
                Case 6
                    otherChart.SaveImage(saveMapChart.FileName, System.Drawing.Imaging.ImageFormat.Tiff)
            End Select
        End If
    End Sub
End Class