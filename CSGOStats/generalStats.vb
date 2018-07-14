Public Class generalStats
    'Reduces loading flicker
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As System.Windows.Forms.CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432 '// WS_EX_COMPOSITED
            Return cp
        End Get
    End Property
    Private Sub generalStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MdiParent = CSGOStats
        'Panel 1
        totalKillsLabel.Text = totalKills
        totalDeathsLabel.Text = totalDeaths
        avgHsLabel.Text = avgHs & "%"
        kdRatioLabel.Text = kdRatio
        totalAssistsLabel.Text = totalAssists
        'Panel 2
        totalRoundsLabel.Text = roundsPlayed
        killsRoundLabel.Text = killsRound
        assistsRoundLabel.Text = assistsRound
        deathRoundLabel.Text = deathRound
        avgPointsLabel.Text = avgPoints
        'Panel 3
        mapsPlayedLabel.Text = mapsPlayedCount
        winStrLabel.Text = winStreak
        tieStrLabel.Text = tieStreak
        lostStrLabel.Text = lostStreak
        Dim time As New TimeSpan(0, 0, avgMatchDuration)
        avgMapDurationLabel.Text = Int(time.TotalMinutes) & ":" & time.ToString("ss")
        'Anual KD combobox
        kdRatioGraph()
        For i As Integer = 0 To (lastYear - firstYear)
            anualKDcomboBox.Items.Add(firstYear + i)
        Next
        anualKDcomboBox.Items.Add("All")
        anualKDcomboBox.SelectedIndex = 0
    End Sub
    Private Sub kdRatioGraph()
        kdRatioChart.Series.Clear()
        kdRatioChart.Titles.Clear()
        kdRatioChart.Series.Add("K/D Ratio")
        kdRatioChart.Titles.Add("kdTitle")
        kdRatioChart.Titles(0).Font = New Font("Arial", 10, FontStyle.Bold)
        kdRatioChart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
        kdRatioChart.Titles(0).Text = "K/D Ratio throughout the year " & anualKDcomboBox.SelectedItem
        If Convert.ToString(anualKDcomboBox.SelectedItem).Contains("All") Then
            kdRatioChart.Titles(0).Text = anualKDcomboBox.SelectedItem & " years K/D Ratio"
        End If
        kdRatioChart.ChartAreas(0).AxisX.Interval = 1
        kdRatioChart.ChartAreas(0).AxisX.MajorGrid.Enabled = False
        kdRatioChart.ChartAreas(0).AxisY.MajorGrid.LineDashStyle = 2
        kdRatioChart.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.LightGray
    End Sub
    Private Sub comboBoxSelectedItem(sender As Object, e As EventArgs) Handles anualKDcomboBox.SelectedIndexChanged
        kdRatioChart.Focus()
        kdRatioGraph()
        kdRatioChart.Series("K/D Ratio").Points.Clear()
        For i As Integer = 0 To (lastYear - firstYear)
            If anualKDcomboBox.SelectedIndex = i Then
                kdRatioChart.Series("K/D Ratio").Points.AddXY("Jan", janKD(i))
                kdRatioChart.Series("K/D Ratio").Points.AddXY("Feb", febKD(i))
                kdRatioChart.Series("K/D Ratio").Points.AddXY("Mar", marKD(i))
                kdRatioChart.Series("K/D Ratio").Points.AddXY("Apr", aprKD(i))
                kdRatioChart.Series("K/D Ratio").Points.AddXY("May", mayKD(i))
                kdRatioChart.Series("K/D Ratio").Points.AddXY("Jun", junKD(i))
                kdRatioChart.Series("K/D Ratio").Points.AddXY("Jul", julKD(i))
                kdRatioChart.Series("K/D Ratio").Points.AddXY("Aug", augKD(i))
                kdRatioChart.Series("K/D Ratio").Points.AddXY("Sep", sepKD(i))
                kdRatioChart.Series("K/D Ratio").Points.AddXY("Oct", octKD(i))
                kdRatioChart.Series("K/D Ratio").Points.AddXY("Nov", novKD(i))
                kdRatioChart.Series("K/D Ratio").Points.AddXY("Dec", decKD(i))
                If janKD(i) > 2.5 Or febKD(i) > 2.5 Or marKD(i) > 2.5 Or aprKD(i) > 2.5 Or mayKD(i) > 2.5 Or junKD(i) > 2.5 Or julKD(i) > 2.5 Or augKD(i) > 2.5 Or sepKD(i) > 2.5 Or
            octKD(i) > 2.5 Or novKD(i) > 2.5 Or decKD(i) > 2.5 Then
                    kdRatioChart.ChartAreas(0).AxisY.Maximum = (Math.Max(Math.Max(Math.Max(Math.Max(janKD(i), febKD(i)), Math.Max(marKD(i), aprKD(i))), Math.Max(Math.Max(mayKD(i), junKD(i)), Math.Max(julKD(i), augKD(i)))), Math.Max(Math.Max(sepKD(i), octKD(i)), Math.Max(novKD(i), decKD(i)))))
                Else
                    kdRatioChart.ChartAreas(0).AxisY.Maximum = (2.5)
                End If
            End If
            If anualKDcomboBox.SelectedIndex = (lastYear - firstYear) + 1 Then
                If kdRatioChart.Series.IndexOf("K/D Ratio") > -1 Then
                    kdRatioChart.Series.Remove(kdRatioChart.Series("K/D Ratio"))
                End If
                kdRatioChart.Series.Add("K/D Ratio " & firstYear + i)
                kdRatioChart.Series(i).ChartType = DataVisualization.Charting.SeriesChartType.Line
                kdRatioChart.ChartAreas(0).AxisX.Interval = 1
                kdRatioChart.ChartAreas(0).AxisX.MajorGrid.Enabled = False
                kdRatioChart.ChartAreas(0).AxisY.MajorGrid.LineDashStyle = 2
                kdRatioChart.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.LightGray
                kdRatioChart.Series("K/D Ratio " & firstYear + i).Points.AddXY("Jan", janKD(i))
                kdRatioChart.Series("K/D Ratio " & firstYear + i).Points.AddXY("Feb", febKD(i))
                kdRatioChart.Series("K/D Ratio " & firstYear + i).Points.AddXY("Mar", marKD(i))
                kdRatioChart.Series("K/D Ratio " & firstYear + i).Points.AddXY("Apr", aprKD(i))
                kdRatioChart.Series("K/D Ratio " & firstYear + i).Points.AddXY("May", mayKD(i))
                kdRatioChart.Series("K/D Ratio " & firstYear + i).Points.AddXY("Jun", junKD(i))
                kdRatioChart.Series("K/D Ratio " & firstYear + i).Points.AddXY("Jul", julKD(i))
                kdRatioChart.Series("K/D Ratio " & firstYear + i).Points.AddXY("Aug", augKD(i))
                kdRatioChart.Series("K/D Ratio " & firstYear + i).Points.AddXY("Sep", sepKD(i))
                kdRatioChart.Series("K/D Ratio " & firstYear + i).Points.AddXY("Oct", octKD(i))
                kdRatioChart.Series("K/D Ratio " & firstYear + i).Points.AddXY("Nov", novKD(i))
                kdRatioChart.Series("K/D Ratio " & firstYear + i).Points.AddXY("Dec", decKD(i))
                If janKD(i) > 2.5 Or febKD(i) > 2.5 Or marKD(i) > 2.5 Or aprKD(i) > 2.5 Or mayKD(i) > 2.5 Or junKD(i) > 2.5 Or julKD(i) > 2.5 Or augKD(i) > 2.5 Or sepKD(i) > 2.5 Or
            octKD(i) > 2.5 Or novKD(i) > 2.5 Or decKD(i) > 2.5 Then
                    kdRatioChart.ChartAreas(0).AxisY.Maximum = (Math.Max(Math.Max(Math.Max(Math.Max(janKD(i), febKD(i)), Math.Max(marKD(i), aprKD(i))), Math.Max(Math.Max(mayKD(i), junKD(i)), Math.Max(julKD(i), augKD(i)))), Math.Max(Math.Max(sepKD(i), octKD(i)), Math.Max(novKD(i), decKD(i)))))
                ElseIf kdRatioChart.ChartAreas(0).AxisY.Maximum < 2.5 Then
                    kdRatioChart.ChartAreas(0).AxisY.Maximum = (2.5)
                End If
            End If
        Next
    End Sub
    '//////////////
    'Save Button///
    '//////////////
    Private Sub saveButtonPicEnter(sender As Object, e As EventArgs) Handles saveButtonPic.MouseEnter
        saveButtonPic.Image = New Bitmap(My.Resources.down_ena)
    End Sub
    Private Sub saveButtonPicLeave(sender As Object, e As EventArgs) Handles saveButtonPic.MouseLeave
        saveButtonPic.Image = New Bitmap(My.Resources.down_dis)
    End Sub
    Private Sub saveButtonPicClick(sender As Object, e As EventArgs) Handles saveButtonPic.Click
        Dim saveKdChart As New SaveFileDialog()
        Dim saveKdImage As String
        saveKdChart.InitialDirectory = "C:\Users\Public\Public Desktop\"
        saveKdChart.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpeg)|*.jpeg|EMF (*.emf)|*.emf|PNG (*.png)|*.png|GIF (*.gif)|*.gif|TIFF (*.tif)|*.tif"
        saveKdChart.FilterIndex = 4
        saveKdChart.ShowDialog()
        saveKdImage = saveKdChart.FileName
        If saveKdChart.FileName <> "" Then
            Select Case saveKdChart.FilterIndex
                Case 1
                    kdRatioChart.SaveImage(saveKdChart.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
                Case 2
                    kdRatioChart.SaveImage(saveKdChart.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                Case 3
                    kdRatioChart.SaveImage(saveKdChart.FileName, System.Drawing.Imaging.ImageFormat.Emf)
                Case 4
                    kdRatioChart.SaveImage(saveKdChart.FileName, System.Drawing.Imaging.ImageFormat.Png)
                Case 5
                    kdRatioChart.SaveImage(saveKdChart.FileName, System.Drawing.Imaging.ImageFormat.Gif)
                Case 6
                    kdRatioChart.SaveImage(saveKdChart.FileName, System.Drawing.Imaging.ImageFormat.Tiff)
            End Select
        End If
    End Sub
End Class