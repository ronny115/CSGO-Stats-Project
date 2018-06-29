Public Class mapStats
    'Reduces loading flicker
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As System.Windows.Forms.CreateParams = MyBase.CreateParams
            cp.ExStyle += 33554432
            Return cp
        End Get
    End Property
    Dim mirClicked, cacClicked, infClicked, oveClicked, traClicked, nukClicked, dusClicked, cobClicked, offClicked, canClicked, ageClicked, varClicked
    Dim otherMaps As New List(Of String)
    Private Sub statsMaps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = CSGOStats
        Dim int As Integer
        varMapComboBox.Items.Add("All Maps")
        varMapComboBox.SelectedIndex = 0
        '////////////////////////////////////////////////////
        'Set the values for each map in the actual map pool//
        '////////////////////////////////////////////////////
        For i As Integer = 0 To mapCount.Count - 1
            If mapCount(i).Contains("Mirage") Then
                mirageCountLabel.Text = mapCount(i + 1)
            ElseIf mapCount(i).Contains("Cache") Then
                cacheCountLabel.Text = mapCount(i + 1)
            ElseIf mapCount(i).Contains("Inferno") Then
                infernoCountLabel.Text = mapCount(i + 1)
            ElseIf mapCount(i).Contains("Overpass") Then
                overpassCountLabel.Text = mapCount(i + 1)
            ElseIf mapCount(i).Contains("Train") Then
                trainCountLabel.Text = mapCount(i + 1)
            ElseIf mapCount(i).Contains("Nuke") Then
                nukeCountLabel.Text = mapCount(i + 1)
            ElseIf mapCount(i).Contains("Dust II") Then
                dustCountLabel.Text = mapCount(i + 1)
            ElseIf mapCount(i).Contains("Cobblestone") Then
                cobbleCountLabel.Text = mapCount(i + 1)
            ElseIf mapCount(i).Contains("Office") Then
                officeCountLabel.Text = mapCount(i + 1)
            ElseIf mapCount(i).Contains("Canals") Then
                canalsCountLabel.Text = mapCount(i + 1)
            ElseIf mapCount(i).Contains("Agency") Then
                agencyCountLabel.Text = mapCount(i + 1)
            ElseIf Not mapCount(i).Contains("Mirage") Or Not mapCount(i).Contains("Cache") Or Not mapCount(i).Contains("Inferno") Or Not mapCount(i).Contains("Overpass") _
                Or Not mapCount(i).Contains("Train") Or Not mapCount(i).Contains("Nuke") Or Not mapCount(i).Contains("Dust II") Or Not mapCount(i).Contains("Cobblestone") _
                Or Not mapCount(i).Contains("Office") Or Not mapCount(i).Contains("Canals") Or Not mapCount(i).Contains("Agency") Then
                otherMaps.Add(mapCount(i))
            End If
        Next
        For i As Integer = 0 To otherMaps.Count - 1
            If Integer.TryParse(otherMaps(i), int) = False Then
                varMapComboBox.Items.Add(otherMaps(i))
            End If
        Next
        loadMapChart()
    End Sub
    Private Sub loadMapChart()
        mapStatsChart.Series.Clear()
        mapStatsChart.Titles("MapTitle").Text = "All Maps Wins/Losses/Ties"
        mapStatsChart.Series.Add("Map Stats")
        mapStatsChart.Series(0).Font = New Font("Arial", 8, FontStyle.Regular)
        mapStatsChart.Series(0).Points.AddXY(Math.Round(((winCount * 100) / (winCount + tieCount + lostCount)), 2, MidpointRounding.AwayFromZero) & "%", winCount)
        mapStatsChart.Series(0).Points(0).LegendText = "Wins - " & winCount
        mapStatsChart.Series(0).Points.AddXY(Math.Round(((tieCount * 100) / (winCount + tieCount + lostCount)), 2, MidpointRounding.AwayFromZero) & "%", tieCount)
        mapStatsChart.Series(0).Points(1).LegendText = "Ties - " & tieCount
        mapStatsChart.Series(0).Points.AddXY(Math.Round(((lostCount * 100) / (winCount + tieCount + lostCount)), 2, MidpointRounding.AwayFromZero) & "%", lostCount)
        mapStatsChart.Series(0).Points(2).LegendText = "Losses - " & lostCount
        mapStatsChart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
    End Sub
    Private Sub mapChart(mapName As String)
        Dim wins, losses, ties As Integer
        For i As Integer = 0 To mapWin.Count - 1
            If mapWin(i).Contains(mapName) Then
                wins += 1
            End If
        Next
        For i As Integer = 0 To mapTie.Count - 1
            If mapTie(i).Contains(mapName) Then
                ties += 1
            End If
        Next
        For i As Integer = 0 To mapLost.Count - 1
            If mapLost(i).Contains(mapName) Then
                losses += 1
            End If
        Next
        mapStatsChart.Series.Clear()
        mapStatsChart.Titles("MapTitle").Text = mapName & " Wins/Losses/Ties"
        mapStatsChart.Series.Add("Map Stats")
        mapStatsChart.Series(0).Font = New Font("Arial", 8, FontStyle.Regular)
        If wins = 0 Then
            mapStatsChart.Series(0).Points.AddXY("", wins)
        Else
            mapStatsChart.Series(0).Points.AddXY(Math.Round(((wins * 100) / (wins + ties + losses)), 2, MidpointRounding.AwayFromZero) & "%", wins)
        End If
        mapStatsChart.Series(0).Points(0).LegendText = "Wins - " & wins
        If ties = 0 Then
            mapStatsChart.Series(0).Points.AddXY("", ties)
        Else
            mapStatsChart.Series(0).Points.AddXY(Math.Round(((ties * 100) / (wins + ties + losses)), 2, MidpointRounding.AwayFromZero) & "%", ties)
        End If
        mapStatsChart.Series(0).Points(1).LegendText = "Ties - " & ties
        If losses = 0 Then
            mapStatsChart.Series(0).Points.AddXY("", losses)
        Else
            mapStatsChart.Series(0).Points.AddXY(Math.Round(((losses * 100) / (wins + ties + losses)), 2, MidpointRounding.AwayFromZero) & "%", losses)
        End If
        mapStatsChart.Series(0).Points(2).LegendText = "Losses - " & losses
        mapStatsChart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
        wins = 0 : ties = 0 : losses = 0
    End Sub
    Private Sub varMapComboBoxSelectedItem(sender As Object, e As EventArgs) Handles varMapComboBox.SelectedIndexChanged
        mapStatsChart.Focus()
        If varMapComboBox.SelectedIndex = 0 Then
            loadMapChart()
        ElseIf varMapComboBox.SelectedIndex > 0 Then
            mapChart(varMapComboBox.SelectedItem)
        End If
        variousPic.Image = New Bitmap(My.Resources.var_ena)
        miragePic.Image = New Bitmap(My.Resources.mir_dis)
        cachePic.Image = New Bitmap(My.Resources.cac_dis)
        infernoPic.Image = New Bitmap(My.Resources.inf_dis)
        overpassPic.Image = New Bitmap(My.Resources.ove_dis)
        trainPic.Image = New Bitmap(My.Resources.tra_dis)
        nukePic.Image = New Bitmap(My.Resources.nuk_dis)
        dust2Pic.Image = New Bitmap(My.Resources.dus_dis)
        cobblestonePic.Image = New Bitmap(My.Resources.cob_dis)
        officePic.Image = New Bitmap(My.Resources.off_dis)
        canalsPic.Image = New Bitmap(My.Resources.can_dis)
        agencyPic.Image = New Bitmap(My.Resources.age_dis)
        mirClicked = Nothing
        cacClicked = Nothing
        infClicked = Nothing
        oveClicked = Nothing
        traClicked = Nothing
        nukClicked = Nothing
        dusClicked = Nothing
        cobClicked = Nothing
        offClicked = Nothing
        canClicked = Nothing
        ageClicked = Nothing
        varClicked = Nothing
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
                    mapStatsChart.SaveImage(saveMapChart.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
                Case 2
                    mapStatsChart.SaveImage(saveMapChart.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                Case 3
                    mapStatsChart.SaveImage(saveMapChart.FileName, System.Drawing.Imaging.ImageFormat.Emf)
                Case 4
                    mapStatsChart.SaveImage(saveMapChart.FileName, System.Drawing.Imaging.ImageFormat.Png)
                Case 5
                    mapStatsChart.SaveImage(saveMapChart.FileName, System.Drawing.Imaging.ImageFormat.Gif)
                Case 6
                    mapStatsChart.SaveImage(saveMapChart.FileName, System.Drawing.Imaging.ImageFormat.Tiff)
            End Select
        End If
    End Sub
    '/////////////////
    'Maps navigation//
    '/////////////////
    'Mirage
    Private Sub miragePicEnter(sender As Object, e As EventArgs) Handles miragePic.MouseEnter
        miragePic.Image = New Bitmap(My.Resources.mir_ena)
    End Sub
    Private Sub miragePicLeave(sender As Object, e As EventArgs) Handles miragePic.MouseLeave
        If mirClicked IsNot Nothing Then
            miragePic.Image = New Bitmap(My.Resources.mir_ena)
        End If
        If mirClicked Is Nothing Then
            miragePic.Image = New Bitmap(My.Resources.mir_dis)
        End If
    End Sub
    Private Sub miragePicClick(sender As Object, e As EventArgs) Handles miragePic.MouseClick
        mirClicked = TryCast(sender, PictureBox)
        mapChart("Mirage")
        miragePic.Image = New Bitmap(My.Resources.mir_ena)
        cachePic.Image = New Bitmap(My.Resources.cac_dis)
        infernoPic.Image = New Bitmap(My.Resources.inf_dis)
        overpassPic.Image = New Bitmap(My.Resources.ove_dis)
        trainPic.Image = New Bitmap(My.Resources.tra_dis)
        nukePic.Image = New Bitmap(My.Resources.nuk_dis)
        dust2Pic.Image = New Bitmap(My.Resources.dus_dis)
        cobblestonePic.Image = New Bitmap(My.Resources.cob_dis)
        officePic.Image = New Bitmap(My.Resources.off_dis)
        canalsPic.Image = New Bitmap(My.Resources.can_dis)
        agencyPic.Image = New Bitmap(My.Resources.age_dis)
        variousPic.Image = New Bitmap(My.Resources.var_dis)
        cacClicked = Nothing
        infClicked = Nothing
        oveClicked = Nothing
        traClicked = Nothing
        nukClicked = Nothing
        dusClicked = Nothing
        cobClicked = Nothing
        offClicked = Nothing
        canClicked = Nothing
        ageClicked = Nothing
        varClicked = Nothing
    End Sub
    'Cache
    Private Sub cachePicEnter(sender As Object, e As EventArgs) Handles cachePic.MouseEnter
        cachePic.Image = New Bitmap(My.Resources.cac_ena)
    End Sub
    Private Sub cachePicLeave(sender As Object, e As EventArgs) Handles cachePic.MouseLeave
        If cacClicked IsNot Nothing Then
            cachePic.Image = New Bitmap(My.Resources.cac_ena)
        End If
        If cacClicked Is Nothing Then
            cachePic.Image = New Bitmap(My.Resources.cac_dis)
        End If
    End Sub
    Private Sub cachePicClick(sender As Object, e As EventArgs) Handles cachePic.MouseClick
        cacClicked = TryCast(sender, PictureBox)
        mapChart("Cache")
        cachePic.Image = New Bitmap(My.Resources.cac_ena)
        miragePic.Image = New Bitmap(My.Resources.mir_dis)
        infernoPic.Image = New Bitmap(My.Resources.inf_dis)
        overpassPic.Image = New Bitmap(My.Resources.ove_dis)
        trainPic.Image = New Bitmap(My.Resources.tra_dis)
        nukePic.Image = New Bitmap(My.Resources.nuk_dis)
        dust2Pic.Image = New Bitmap(My.Resources.dus_dis)
        cobblestonePic.Image = New Bitmap(My.Resources.cob_dis)
        officePic.Image = New Bitmap(My.Resources.off_dis)
        canalsPic.Image = New Bitmap(My.Resources.can_dis)
        agencyPic.Image = New Bitmap(My.Resources.age_dis)
        variousPic.Image = New Bitmap(My.Resources.var_dis)
        mirClicked = Nothing
        infClicked = Nothing
        oveClicked = Nothing
        traClicked = Nothing
        nukClicked = Nothing
        dusClicked = Nothing
        cobClicked = Nothing
        offClicked = Nothing
        canClicked = Nothing
        ageClicked = Nothing
        varClicked = Nothing
    End Sub
    'Inferno
    Private Sub infernoPicEnter(sender As Object, e As EventArgs) Handles infernoPic.MouseEnter
        infernoPic.Image = New Bitmap(My.Resources.inf_ena)
    End Sub
    Private Sub infernoPicLeave(sender As Object, e As EventArgs) Handles infernoPic.MouseLeave
        If infClicked IsNot Nothing Then
            infernoPic.Image = New Bitmap(My.Resources.inf_ena)
        End If
        If infClicked Is Nothing Then
            infernoPic.Image = New Bitmap(My.Resources.inf_dis)
        End If
    End Sub
    Private Sub infernoPicClick(sender As Object, e As EventArgs) Handles infernoPic.MouseClick
        infClicked = TryCast(sender, PictureBox)
        mapChart("Inferno")
        infernoPic.Image = New Bitmap(My.Resources.inf_ena)
        miragePic.Image = New Bitmap(My.Resources.mir_dis)
        cachePic.Image = New Bitmap(My.Resources.cac_dis)
        overpassPic.Image = New Bitmap(My.Resources.ove_dis)
        trainPic.Image = New Bitmap(My.Resources.tra_dis)
        nukePic.Image = New Bitmap(My.Resources.nuk_dis)
        dust2Pic.Image = New Bitmap(My.Resources.dus_dis)
        cobblestonePic.Image = New Bitmap(My.Resources.cob_dis)
        officePic.Image = New Bitmap(My.Resources.off_dis)
        canalsPic.Image = New Bitmap(My.Resources.can_dis)
        agencyPic.Image = New Bitmap(My.Resources.age_dis)
        variousPic.Image = New Bitmap(My.Resources.var_dis)
        mirClicked = Nothing
        cacClicked = Nothing
        oveClicked = Nothing
        traClicked = Nothing
        nukClicked = Nothing
        dusClicked = Nothing
        cobClicked = Nothing
        offClicked = Nothing
        canClicked = Nothing
        ageClicked = Nothing
        varClicked = Nothing
    End Sub
    'Overpass
    Private Sub overpassPicEnter(sender As Object, e As EventArgs) Handles overpassPic.MouseEnter
        overpassPic.Image = New Bitmap(My.Resources.ove_ena)
    End Sub
    Private Sub overpassPicLeave(sender As Object, e As EventArgs) Handles overpassPic.MouseLeave
        If oveClicked IsNot Nothing Then
            overpassPic.Image = New Bitmap(My.Resources.ove_ena)
        End If
        If oveClicked Is Nothing Then
            overpassPic.Image = New Bitmap(My.Resources.ove_dis)
        End If
    End Sub
    Private Sub overpassPicClick(sender As Object, e As EventArgs) Handles overpassPic.MouseClick
        oveClicked = TryCast(sender, PictureBox)
        mapChart("Overpass")
        overpassPic.Image = New Bitmap(My.Resources.ove_ena)
        miragePic.Image = New Bitmap(My.Resources.mir_dis)
        cachePic.Image = New Bitmap(My.Resources.cac_dis)
        infernoPic.Image = New Bitmap(My.Resources.inf_dis)
        trainPic.Image = New Bitmap(My.Resources.tra_dis)
        nukePic.Image = New Bitmap(My.Resources.nuk_dis)
        dust2Pic.Image = New Bitmap(My.Resources.dus_dis)
        cobblestonePic.Image = New Bitmap(My.Resources.cob_dis)
        officePic.Image = New Bitmap(My.Resources.off_dis)
        canalsPic.Image = New Bitmap(My.Resources.can_dis)
        agencyPic.Image = New Bitmap(My.Resources.age_dis)
        variousPic.Image = New Bitmap(My.Resources.var_dis)
        mirClicked = Nothing
        cacClicked = Nothing
        infClicked = Nothing
        traClicked = Nothing
        nukClicked = Nothing
        dusClicked = Nothing
        cobClicked = Nothing
        offClicked = Nothing
        canClicked = Nothing
        ageClicked = Nothing
        varClicked = Nothing
    End Sub
    'Train
    Private Sub trainPicEnter(sender As Object, e As EventArgs) Handles trainPic.MouseEnter
        trainPic.Image = New Bitmap(My.Resources.tra_ena)
    End Sub
    Private Sub trainPicLeave(sender As Object, e As EventArgs) Handles trainPic.MouseLeave
        If traClicked IsNot Nothing Then
            trainPic.Image = New Bitmap(My.Resources.tra_ena)
        End If
        If traClicked Is Nothing Then
            trainPic.Image = New Bitmap(My.Resources.tra_dis)
        End If
    End Sub
    Private Sub trainPicClick(sender As Object, e As EventArgs) Handles trainPic.MouseClick
        traClicked = TryCast(sender, PictureBox)
        mapChart("Train")
        trainPic.Image = New Bitmap(My.Resources.tra_ena)
        miragePic.Image = New Bitmap(My.Resources.mir_dis)
        cachePic.Image = New Bitmap(My.Resources.cac_dis)
        infernoPic.Image = New Bitmap(My.Resources.inf_dis)
        overpassPic.Image = New Bitmap(My.Resources.ove_dis)
        nukePic.Image = New Bitmap(My.Resources.nuk_dis)
        dust2Pic.Image = New Bitmap(My.Resources.dus_dis)
        cobblestonePic.Image = New Bitmap(My.Resources.cob_dis)
        officePic.Image = New Bitmap(My.Resources.off_dis)
        canalsPic.Image = New Bitmap(My.Resources.can_dis)
        agencyPic.Image = New Bitmap(My.Resources.age_dis)
        variousPic.Image = New Bitmap(My.Resources.var_dis)
        mirClicked = Nothing
        cacClicked = Nothing
        infClicked = Nothing
        oveClicked = Nothing
        nukClicked = Nothing
        dusClicked = Nothing
        cobClicked = Nothing
        offClicked = Nothing
        canClicked = Nothing
        ageClicked = Nothing
        varClicked = Nothing
    End Sub
    'Nuke
    Private Sub nukePicEnter(sender As Object, e As EventArgs) Handles nukePic.MouseEnter
        nukePic.Image = New Bitmap(My.Resources.nuk_ena)
    End Sub
    Private Sub nukePicLeave(sender As Object, e As EventArgs) Handles nukePic.MouseLeave
        If nukClicked IsNot Nothing Then
            nukePic.Image = New Bitmap(My.Resources.nuk_ena)
        End If
        If nukClicked Is Nothing Then
            nukePic.Image = New Bitmap(My.Resources.nuk_dis)
        End If
    End Sub
    Private Sub nukePicClick(sender As Object, e As EventArgs) Handles nukePic.MouseClick
        nukClicked = TryCast(sender, PictureBox)
        mapChart("Nuke")
        nukePic.Image = New Bitmap(My.Resources.nuk_ena)
        miragePic.Image = New Bitmap(My.Resources.mir_dis)
        cachePic.Image = New Bitmap(My.Resources.cac_dis)
        infernoPic.Image = New Bitmap(My.Resources.inf_dis)
        overpassPic.Image = New Bitmap(My.Resources.ove_dis)
        trainPic.Image = New Bitmap(My.Resources.tra_dis)
        dust2Pic.Image = New Bitmap(My.Resources.dus_dis)
        cobblestonePic.Image = New Bitmap(My.Resources.cob_dis)
        officePic.Image = New Bitmap(My.Resources.off_dis)
        canalsPic.Image = New Bitmap(My.Resources.can_dis)
        agencyPic.Image = New Bitmap(My.Resources.age_dis)
        variousPic.Image = New Bitmap(My.Resources.var_dis)
        mirClicked = Nothing
        cacClicked = Nothing
        infClicked = Nothing
        oveClicked = Nothing
        traClicked = Nothing
        dusClicked = Nothing
        cobClicked = Nothing
        offClicked = Nothing
        canClicked = Nothing
        ageClicked = Nothing
        varClicked = Nothing
    End Sub
    'Dust2
    Private Sub dust2PicEnter(sender As Object, e As EventArgs) Handles dust2Pic.MouseEnter
        dust2Pic.Image = New Bitmap(My.Resources.dus_ena)
    End Sub
    Private Sub dust2PicLeave(sender As Object, e As EventArgs) Handles dust2Pic.MouseLeave
        If dusClicked IsNot Nothing Then
            dust2Pic.Image = New Bitmap(My.Resources.dus_ena)
        End If
        If dusClicked Is Nothing Then
            dust2Pic.Image = New Bitmap(My.Resources.dus_dis)
        End If
    End Sub
    Private Sub dust2PicClick(sender As Object, e As EventArgs) Handles dust2Pic.MouseClick
        dusClicked = TryCast(sender, PictureBox)
        mapChart("Dust II")
        dust2Pic.Image = New Bitmap(My.Resources.dus_ena)
        miragePic.Image = New Bitmap(My.Resources.mir_dis)
        cachePic.Image = New Bitmap(My.Resources.cac_dis)
        infernoPic.Image = New Bitmap(My.Resources.inf_dis)
        overpassPic.Image = New Bitmap(My.Resources.ove_dis)
        trainPic.Image = New Bitmap(My.Resources.tra_dis)
        nukePic.Image = New Bitmap(My.Resources.nuk_dis)
        cobblestonePic.Image = New Bitmap(My.Resources.cob_dis)
        officePic.Image = New Bitmap(My.Resources.off_dis)
        canalsPic.Image = New Bitmap(My.Resources.can_dis)
        agencyPic.Image = New Bitmap(My.Resources.age_dis)
        variousPic.Image = New Bitmap(My.Resources.var_dis)
        mirClicked = Nothing
        cacClicked = Nothing
        infClicked = Nothing
        oveClicked = Nothing
        traClicked = Nothing
        nukClicked = Nothing
        cobClicked = Nothing
        offClicked = Nothing
        canClicked = Nothing
        ageClicked = Nothing
        varClicked = Nothing
    End Sub
    'Cobblestone
    Private Sub CobblestonePicEnter(sender As Object, e As EventArgs) Handles cobblestonePic.MouseEnter
        cobblestonePic.Image = New Bitmap(My.Resources.cob_ena)
    End Sub
    Private Sub CobblestonePicLeave(sender As Object, e As EventArgs) Handles cobblestonePic.MouseLeave
        If cobClicked IsNot Nothing Then
            cobblestonePic.Image = New Bitmap(My.Resources.cob_ena)
        End If
        If cobClicked Is Nothing Then
            cobblestonePic.Image = New Bitmap(My.Resources.cob_dis)
        End If
    End Sub
    Private Sub CobblestonePicClick(sender As Object, e As EventArgs) Handles cobblestonePic.MouseClick
        cobClicked = TryCast(sender, PictureBox)
        mapChart("Cobblestone")
        cobblestonePic.Image = New Bitmap(My.Resources.cob_ena)
        miragePic.Image = New Bitmap(My.Resources.mir_dis)
        cachePic.Image = New Bitmap(My.Resources.cac_dis)
        infernoPic.Image = New Bitmap(My.Resources.inf_dis)
        overpassPic.Image = New Bitmap(My.Resources.ove_dis)
        trainPic.Image = New Bitmap(My.Resources.tra_dis)
        nukePic.Image = New Bitmap(My.Resources.nuk_dis)
        dust2Pic.Image = New Bitmap(My.Resources.dus_dis)
        officePic.Image = New Bitmap(My.Resources.off_dis)
        canalsPic.Image = New Bitmap(My.Resources.can_dis)
        agencyPic.Image = New Bitmap(My.Resources.age_dis)
        variousPic.Image = New Bitmap(My.Resources.var_dis)
        mirClicked = Nothing
        cacClicked = Nothing
        infClicked = Nothing
        oveClicked = Nothing
        traClicked = Nothing
        nukClicked = Nothing
        dusClicked = Nothing
        offClicked = Nothing
        canClicked = Nothing
        ageClicked = Nothing
        varClicked = Nothing
    End Sub
    'Office
    Private Sub officePicEnter(sender As Object, e As EventArgs) Handles officePic.MouseEnter
        officePic.Image = New Bitmap(My.Resources.off_ena)
    End Sub
    Private Sub officePicLeave(sender As Object, e As EventArgs) Handles officePic.MouseLeave
        If offClicked IsNot Nothing Then
            officePic.Image = New Bitmap(My.Resources.off_ena)
        End If
        If offClicked Is Nothing Then
            officePic.Image = New Bitmap(My.Resources.off_dis)
        End If
    End Sub
    Private Sub officePicClick(sender As Object, e As EventArgs) Handles officePic.MouseClick
        offClicked = TryCast(sender, PictureBox)
        mapChart("Office")
        officePic.Image = New Bitmap(My.Resources.off_ena)
        miragePic.Image = New Bitmap(My.Resources.mir_dis)
        cachePic.Image = New Bitmap(My.Resources.cac_dis)
        infernoPic.Image = New Bitmap(My.Resources.inf_dis)
        overpassPic.Image = New Bitmap(My.Resources.ove_dis)
        trainPic.Image = New Bitmap(My.Resources.tra_dis)
        nukePic.Image = New Bitmap(My.Resources.nuk_dis)
        dust2Pic.Image = New Bitmap(My.Resources.dus_dis)
        cobblestonePic.Image = New Bitmap(My.Resources.cob_dis)
        canalsPic.Image = New Bitmap(My.Resources.can_dis)
        agencyPic.Image = New Bitmap(My.Resources.age_dis)
        variousPic.Image = New Bitmap(My.Resources.var_dis)
        mirClicked = Nothing
        cacClicked = Nothing
        infClicked = Nothing
        oveClicked = Nothing
        traClicked = Nothing
        nukClicked = Nothing
        dusClicked = Nothing
        cobClicked = Nothing
        canClicked = Nothing
        ageClicked = Nothing
        varClicked = Nothing
    End Sub
    'Canals
    Private Sub canalsPicEnter(sender As Object, e As EventArgs) Handles canalsPic.MouseEnter
        canalsPic.Image = New Bitmap(My.Resources.can_ena)
    End Sub
    Private Sub canalsPicLeave(sender As Object, e As EventArgs) Handles canalsPic.MouseLeave
        If canClicked IsNot Nothing Then
            canalsPic.Image = New Bitmap(My.Resources.can_ena)
        End If
        If canClicked Is Nothing Then
            canalsPic.Image = New Bitmap(My.Resources.can_dis)
        End If
    End Sub
    Private Sub canalsPicClick(sender As Object, e As EventArgs) Handles canalsPic.MouseClick
        canClicked = TryCast(sender, PictureBox)
        mapChart("Canals")
        canalsPic.Image = New Bitmap(My.Resources.can_ena)
        miragePic.Image = New Bitmap(My.Resources.mir_dis)
        cachePic.Image = New Bitmap(My.Resources.cac_dis)
        infernoPic.Image = New Bitmap(My.Resources.inf_dis)
        overpassPic.Image = New Bitmap(My.Resources.ove_dis)
        trainPic.Image = New Bitmap(My.Resources.tra_dis)
        nukePic.Image = New Bitmap(My.Resources.nuk_dis)
        dust2Pic.Image = New Bitmap(My.Resources.dus_dis)
        cobblestonePic.Image = New Bitmap(My.Resources.cob_dis)
        officePic.Image = New Bitmap(My.Resources.off_dis)
        agencyPic.Image = New Bitmap(My.Resources.age_dis)
        variousPic.Image = New Bitmap(My.Resources.var_dis)
        mirClicked = Nothing
        cacClicked = Nothing
        infClicked = Nothing
        oveClicked = Nothing
        traClicked = Nothing
        nukClicked = Nothing
        dusClicked = Nothing
        cobClicked = Nothing
        offClicked = Nothing
        ageClicked = Nothing
        varClicked = Nothing
    End Sub
    'Agency
    Private Sub agencyPicEnter(sender As Object, e As EventArgs) Handles agencyPic.MouseEnter
        agencyPic.Image = New Bitmap(My.Resources.age_ena)
    End Sub
    Private Sub agencyPicLeave(sender As Object, e As EventArgs) Handles agencyPic.MouseLeave
        If ageClicked IsNot Nothing Then
            agencyPic.Image = New Bitmap(My.Resources.age_ena)
        End If
        If ageClicked Is Nothing Then
            agencyPic.Image = New Bitmap(My.Resources.age_dis)
        End If
    End Sub
    Private Sub agencyPicClick(sender As Object, e As EventArgs) Handles agencyPic.MouseClick
        ageClicked = TryCast(sender, PictureBox)
        mapChart("Agency")
        agencyPic.Image = New Bitmap(My.Resources.age_ena)
        miragePic.Image = New Bitmap(My.Resources.mir_dis)
        cachePic.Image = New Bitmap(My.Resources.cac_dis)
        infernoPic.Image = New Bitmap(My.Resources.inf_dis)
        overpassPic.Image = New Bitmap(My.Resources.ove_dis)
        trainPic.Image = New Bitmap(My.Resources.tra_dis)
        nukePic.Image = New Bitmap(My.Resources.nuk_dis)
        dust2Pic.Image = New Bitmap(My.Resources.dus_dis)
        cobblestonePic.Image = New Bitmap(My.Resources.cob_dis)
        officePic.Image = New Bitmap(My.Resources.off_dis)
        canalsPic.Image = New Bitmap(My.Resources.can_dis)
        variousPic.Image = New Bitmap(My.Resources.var_dis)
        mirClicked = Nothing
        cacClicked = Nothing
        infClicked = Nothing
        oveClicked = Nothing
        traClicked = Nothing
        nukClicked = Nothing
        dusClicked = Nothing
        cobClicked = Nothing
        offClicked = Nothing
        canClicked = Nothing
        varClicked = Nothing
    End Sub
    'Various
    Private Sub VariousPicEnter(sender As Object, e As EventArgs) Handles variousPic.MouseEnter
        variousPic.Image = New Bitmap(My.Resources.var_ena)
    End Sub
    Private Sub VariousPicLeave(sender As Object, e As EventArgs) Handles variousPic.MouseLeave
        If mirClicked IsNot Nothing Or cacClicked IsNot Nothing Or infClicked IsNot Nothing Or oveClicked IsNot Nothing Or traClicked IsNot Nothing Or nukClicked IsNot Nothing Or dusClicked IsNot Nothing Or
            cobClicked IsNot Nothing Or offClicked IsNot Nothing Or canClicked IsNot Nothing Or ageClicked IsNot Nothing Then
            variousPic.Image = New Bitmap(My.Resources.var_dis)
        Else
            variousPic.Image = New Bitmap(My.Resources.var_ena)
        End If
    End Sub
    Private Sub VariousPicClick(sender As Object, e As EventArgs) Handles variousPic.MouseClick
        varClicked = TryCast(sender, PictureBox)
        If varMapComboBox.SelectedItem.Equals("All Maps") Then
            loadMapChart()
        Else
            mapChart(varMapComboBox.SelectedItem)
        End If
        variousPic.Image = New Bitmap(My.Resources.var_ena)
        miragePic.Image = New Bitmap(My.Resources.mir_dis)
        cachePic.Image = New Bitmap(My.Resources.cac_dis)
        infernoPic.Image = New Bitmap(My.Resources.inf_dis)
        overpassPic.Image = New Bitmap(My.Resources.ove_dis)
        trainPic.Image = New Bitmap(My.Resources.tra_dis)
        nukePic.Image = New Bitmap(My.Resources.nuk_dis)
        dust2Pic.Image = New Bitmap(My.Resources.dus_dis)
        cobblestonePic.Image = New Bitmap(My.Resources.cob_dis)
        officePic.Image = New Bitmap(My.Resources.off_dis)
        canalsPic.Image = New Bitmap(My.Resources.can_dis)
        agencyPic.Image = New Bitmap(My.Resources.age_dis)
        mirClicked = Nothing
        cacClicked = Nothing
        infClicked = Nothing
        oveClicked = Nothing
        traClicked = Nothing
        nukClicked = Nothing
        dusClicked = Nothing
        cobClicked = Nothing
        offClicked = Nothing
        canClicked = Nothing
        ageClicked = Nothing
    End Sub
End Class