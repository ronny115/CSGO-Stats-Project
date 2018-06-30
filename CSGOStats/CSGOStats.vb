Imports System.IO
Public Class CSGOStats
    Dim filePath As String
    Dim howTab_clicked, aboutTab_clicked, msButtonClicked, gsButtonClicked, osButtonClicked, backButtonClicked
    'Functions to get And delete the bevel inside the mdi parent
    <System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint:="SetWindowLong")>
    Private Shared Function SetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    End Function
    <System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint:="GetWindowLong")>
    Private Shared Function GetWindowLong(ByVal hWnd As System.IntPtr, ByVal nIndex As Integer) As Integer
    End Function
    Private Const GWL_EXSTYLE = (-20)
    Private Const WS_EX_CLIENTEDGE = &H200
    Private Sub CSGOStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the welcome screen config
        Me.IsMdiContainer = True
        mainMenu.Visible = False
        MainScreen.Visible = True
        helpPanelImage.Visible = False
        aboutTabPic.Visible = False
        howTabPic.Visible = False
        closeHelpPic.Visible = False
        howtoTextBox.Visible = False
        aboutTextBox.Visible = False

        If (steamNameInput.Text Is Nothing Or steamNameInput.Text.Trim().Length < 1) Then
            loadDataButton.Enabled = False
        End If
        'Delete the bevel
        For Each c As Control In Me.Controls()
            If TypeOf (c) Is MdiClient Then
                Dim windowLong As Integer = GetWindowLong(c.Handle, GWL_EXSTYLE)
                windowLong = windowLong And (Not WS_EX_CLIENTEDGE)
                SetWindowLong(c.Handle, GWL_EXSTYLE, windowLong)
                Exit For
            End If
        Next
    End Sub
    Private Sub LoadData_Click(sender As Object, e As EventArgs) Handles loadDataButton.Click
        Dim openFile As New OpenFileDialog
        Dim openFileCancel As DialogResult = openFile.ShowDialog()

        openFile.InitialDirectory = "C:\"
        steamN = steamNameInput.Text

        If openFileCancel = System.Windows.Forms.DialogResult.Cancel Then
            errorLabel.Text = "You need" & Environment.NewLine & "to select" & Environment.NewLine & "a file"
            MainScreen.Visible = True
        Else
            filePath = openFile.FileName
            startLoad()
        End If
    End Sub
    Private Sub BackgroundLoad_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        ' This event handler is called when the background thread finishes. 
        ' This method runs on the main thread. 
        If e.Error IsNot Nothing Then
            MessageBox.Show("Error: " & e.Error.Message)
        ElseIf e.Cancelled Then
            errorLabel.Text = "Steam Name" & Environment.NewLine & "or file" & Environment.NewLine & "incorrect" & Environment.NewLine & "please check"
        Else
            errorLabel.Text = ""
            MainScreen.Visible = False
            mainMenu.Visible = True
            generalStats.Show()
            generalStats.Dock = DockStyle.Fill
        End If
    End Sub
    Private Sub BackgroundLoad_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork
        Dim worker As System.ComponentModel.BackgroundWorker
        worker = CType(sender, System.ComponentModel.BackgroundWorker)

        Dim dataLoader As dataReader = CType(e.Argument, dataReader)
        dataLoader.loadData(filePath, steamN, worker, e)
        If e.Cancel = True Then
        Else
            dataLoader.matchData(worker, e)
            dataLoader.getPlayerData(worker, e)
        End If
    End Sub
    Sub startLoad()
        Dim dataLoader As New dataReader
        BackgroundWorker.RunWorkerAsync(dataLoader)
    End Sub
    '//////////////////////////////////////
    'Menu navigation///////////////////////
    '//////////////////////////////////////
    '///////////////
    'General Stats//
    '///////////////
    Private Sub generalStatsButtonEnter(sender As Object, e As EventArgs) Handles gsButtonPic.MouseEnter
        If gsButtonClicked IsNot Nothing Then
            gsButtonPic.Image = New Bitmap(My.Resources.gsButton_ena)
        End If
        If msButtonClicked IsNot Nothing Or osButtonClicked IsNot Nothing Or backButtonClicked IsNot Nothing Then
            gsButtonPic.Image = New Bitmap(My.Resources.gsButton_hov)
        End If
    End Sub
    Private Sub generalStatsButtonLeave(sender As Object, e As EventArgs) Handles gsButtonPic.MouseLeave
        If gsButtonClicked IsNot Nothing Then
            gsButtonPic.Image = New Bitmap(My.Resources.gsButton_ena)
        End If
        If msButtonClicked IsNot Nothing Or osButtonClicked IsNot Nothing Or backButtonClicked IsNot Nothing Then
            gsButtonPic.Image = New Bitmap(My.Resources.gsButton_dis)
        End If
    End Sub
    Private Sub generalStatsButtonClick(sender As Object, e As EventArgs) Handles gsButtonPic.Click
        gsButtonClicked = TryCast(sender, PictureBox)
        If msButtonClicked IsNot Nothing Or osButtonClicked IsNot Nothing Or backButtonClicked IsNot Nothing Then
            gsButtonPic.Image = New Bitmap(My.Resources.gsButton_ena)
            msButtonPic.Image = New Bitmap(My.Resources.msButton_dis)
            osButtonPic.Image = New Bitmap(My.Resources.osButton_dis)
            backButtonPic.Image = New Bitmap(My.Resources.backButton_dis)
        End If

        msButtonClicked = Nothing
        osButtonClicked = Nothing
        backButtonClicked = Nothing

        mapStats.Hide()
        otherStats.Hide()

        generalStats.Show()
        generalStats.Dock = DockStyle.Fill
    End Sub
    '///////////////
    'Map Stats//////
    '///////////////
    Private Sub mapStatsButtonEnter(sender As Object, e As EventArgs) Handles msButtonPic.MouseEnter
        If msButtonClicked IsNot Nothing Then
            msButtonPic.Image = New Bitmap(My.Resources.msButton_ena)
        Else
            msButtonPic.Image = New Bitmap(My.Resources.msButton_hov)
        End If
        If gsButtonClicked IsNot Nothing Or osButtonClicked IsNot Nothing Or backButtonClicked IsNot Nothing Then
            msButtonPic.Image = New Bitmap(My.Resources.msButton_hov)
        End If
    End Sub
    Private Sub mapStatsButtonLeave(sender As Object, e As EventArgs) Handles msButtonPic.MouseLeave
        If msButtonClicked IsNot Nothing Then
            msButtonPic.Image = New Bitmap(My.Resources.msButton_ena)
        Else
            msButtonPic.Image = New Bitmap(My.Resources.msButton_dis)
        End If
        If gsButtonClicked IsNot Nothing Or osButtonClicked IsNot Nothing Or backButtonClicked IsNot Nothing Then
            msButtonPic.Image = New Bitmap(My.Resources.msButton_dis)
        End If
    End Sub
    Private Sub mapStatsButtonClick(sender As Object, e As EventArgs) Handles msButtonPic.Click
        msButtonClicked = TryCast(sender, PictureBox)
        gsButtonPic.Image = New Bitmap(My.Resources.gsButton_dis)
        osButtonPic.Image = New Bitmap(My.Resources.osButton_dis)
        msButtonPic.Image = New Bitmap(My.Resources.msButton_ena)
        gsButtonClicked = Nothing
        osButtonClicked = Nothing
        backButtonClicked = Nothing

        generalStats.Hide()
        otherStats.Hide()

        mapStats.Show()
        mapStats.Dock = DockStyle.Fill
    End Sub
    '///////////////
    'Other Stats////
    '///////////////
    Private Sub otherStatsButtonEnter(sender As Object, e As EventArgs) Handles osButtonPic.MouseEnter
        If osButtonClicked IsNot Nothing Then
            osButtonPic.Image = New Bitmap(My.Resources.osButton_ena)
        Else
            osButtonPic.Image = New Bitmap(My.Resources.osButton_hov)
        End If
        If gsButtonClicked IsNot Nothing Or msButtonClicked IsNot Nothing Or backButtonClicked IsNot Nothing Then
            osButtonPic.Image = New Bitmap(My.Resources.osButton_hov)
        End If
    End Sub
    Private Sub otherStatsButtonLeave(sender As Object, e As EventArgs) Handles osButtonPic.MouseLeave
        If osButtonClicked IsNot Nothing Then
            osButtonPic.Image = New Bitmap(My.Resources.osButton_ena)
        Else
            osButtonPic.Image = New Bitmap(My.Resources.osButton_dis)
        End If
        If gsButtonClicked IsNot Nothing Or msButtonClicked IsNot Nothing Or backButtonClicked IsNot Nothing Then
            osButtonPic.Image = New Bitmap(My.Resources.osButton_dis)
        End If
    End Sub
    Private Sub otherStatsButtonClick(sender As Object, e As EventArgs) Handles osButtonPic.Click
        osButtonClicked = TryCast(sender, PictureBox)
        gsButtonPic.Image = New Bitmap(My.Resources.gsButton_dis)
        msButtonPic.Image = New Bitmap(My.Resources.msButton_dis)
        osButtonPic.Image = New Bitmap(My.Resources.osButton_ena)
        gsButtonClicked = Nothing
        msButtonClicked = Nothing
        backButtonClicked = Nothing
        generalStats.Hide()
        mapStats.Hide()

        otherStats.Show()
        otherStats.Dock = DockStyle.Fill
    End Sub
    '///////////////
    'Back///////////
    '///////////////
    Private Sub backButtonEnter(sender As Object, e As EventArgs) Handles backButtonPic.MouseEnter
        If backButtonClicked IsNot Nothing Then
            backButtonPic.Image = New Bitmap(My.Resources.backButton_ena)
        Else
            backButtonPic.Image = New Bitmap(My.Resources.backButton_hov)
        End If
        If gsButtonClicked IsNot Nothing Or msButtonClicked IsNot Nothing Or msButtonClicked IsNot Nothing Then
            backButtonPic.Image = New Bitmap(My.Resources.backButton_hov)
        End If
    End Sub
    Private Sub backButtonLeave(sender As Object, e As EventArgs) Handles backButtonPic.MouseLeave
        If backButtonClicked IsNot Nothing Then
            backButtonPic.Image = New Bitmap(My.Resources.backButton_ena)
        Else
            backButtonPic.Image = New Bitmap(My.Resources.backButton_dis)
        End If
        If gsButtonClicked IsNot Nothing Or msButtonClicked IsNot Nothing Or msButtonClicked IsNot Nothing Then
            backButtonPic.Image = New Bitmap(My.Resources.backButton_dis)
        End If
    End Sub
    Private Sub backButtonClick(sender As Object, e As EventArgs) Handles backButtonPic.Click
        backButtonClicked = TryCast(sender, PictureBox)
        gsButtonPic.Image = New Bitmap(My.Resources.gsButton_ena)
        msButtonPic.Image = New Bitmap(My.Resources.msButton_dis)
        osButtonPic.Image = New Bitmap(My.Resources.osButton_dis)
        backButtonPic.Image = New Bitmap(My.Resources.backButton_ena)
        backButtonClicked = Nothing
        msButtonClicked = Nothing
        osButtonClicked = Nothing

        MainScreen.Visible = True
        mainMenu.Visible = False

        generalStats.Close()
        mapStats.Close()
        otherStats.Close()
        clearVar()
    End Sub
    '//////////////////////
    'Export to CSV Button//
    '//////////////////////
    Private Sub exportButtonEnter(sender As Object, e As EventArgs) Handles exportButtonPic.MouseEnter
        exportButtonPic.Image = New Bitmap(My.Resources.export_ena)
    End Sub
    Private Sub exportButtonLeave(sender As Object, e As EventArgs) Handles exportButtonPic.MouseLeave
        exportButtonPic.Image = New Bitmap(My.Resources.export_dis)
    End Sub
    Private Sub exportButtonClick(sender As Object, e As EventArgs) Handles exportButtonPic.Click
        Dim exportFile As New SaveFileDialog()
        exportFile.InitialDirectory = "C:\Users\Public\Public Desktop\"
        exportFile.Filter = "CSV (comma delimited) (*.csv)|*.csv|Txt (*.txt)|*.txt"
        exportFile.FilterIndex = 0
        exportFile.ShowDialog()
        IO.File.WriteAllText(exportFile.FileName, exportFileData.ToString())
    End Sub

    '//////////////////////////
    'Main Screen Navigation////
    '//////////////////////////
    Private Sub steamNameInput_TextChanged(sender As Object, e As EventArgs) Handles steamNameInput.TextChanged
        loadDataButton.Enabled = True
    End Sub
    '/////////////////////
    'Help Button handle///
    '/////////////////////
    Private Sub helpButtonPicEnter(sender As Object, e As EventArgs) Handles helpButtonPic.MouseEnter
        helpButtonPic.Image = New Bitmap(My.Resources.help_ena)
    End Sub
    Private Sub helpButtonPic_MouseLeave(sender As Object, e As EventArgs) Handles helpButtonPic.MouseLeave
        helpButtonPic.Image = New Bitmap(My.Resources.help_dis)
    End Sub
    Private Sub helpButtonPic_Click(sender As Object, e As EventArgs) Handles helpButtonPic.Click
        helpPanelImage.Visible = True
        aboutTabPic.Visible = True
        closeHelpPic.Visible = True
        helpPanelImage.Visible = True
        howtoTextBox.Visible = True
        howtoTextBox.Rtf = My.Resources.howto
    End Sub
    '/////////////////
    'How tab handle///
    '/////////////////
    Private Sub howTabDisPicEnter(sender As Object, e As EventArgs) Handles howTabPic.MouseEnter
        howTabPic.Image = New Bitmap(My.Resources.htuse_hover)
    End Sub
    Private Sub howTabDisPic_MouseLeave(sender As Object, e As EventArgs) Handles howTabPic.MouseLeave
        howTabPic.Image = New Bitmap(My.Resources.htuse_dis)
    End Sub
    Private Sub howTabDisPic_MouseClick(sender As Object, e As EventArgs) Handles howTabPic.Click
        howTab_clicked = TryCast(sender, PictureBox)
        howTabPic.Visible = False
        aboutTabPic.Image = New Bitmap(My.Resources.help_tab_dis)
        aboutTab_clicked = Nothing
        howtoTextBox.Visible = True
        aboutTextBox.Visible = False
        howtoTextBox.Rtf = My.Resources.howto


    End Sub
    '//////////////////
    'About tab handle//
    '//////////////////
    Private Sub aboutTabDisPicEnter(sender As Object, e As EventArgs) Handles aboutTabPic.MouseEnter
        If howTab_clicked IsNot Nothing Then
            aboutTabPic.Image = New Bitmap(My.Resources.help_tab_hov)
        End If
        If aboutTab_clicked IsNot Nothing Then
            aboutTabPic.Image = New Bitmap(My.Resources.help_tab_act)
        Else
            aboutTabPic.Image = New Bitmap(My.Resources.help_tab_hov)
        End If
    End Sub
    Private Sub aboutTabDisPic_MouseLeave(sender As Object, e As EventArgs) Handles aboutTabPic.MouseLeave
        If aboutTab_clicked IsNot Nothing Then
            aboutTabPic.Image = New Bitmap(My.Resources.help_tab_act)
        Else
            aboutTabPic.Image = New Bitmap(My.Resources.help_tab_dis)
        End If
    End Sub
    Private Sub aboutTabDisPic_Click(sender As Object, e As EventArgs) Handles aboutTabPic.Click
        aboutTab_clicked = TryCast(sender, PictureBox)
        aboutTabPic.Image = New Bitmap(My.Resources.help_tab_act)
        howTabPic.Visible = True
        howTab_clicked = Nothing
        howtoTextBox.Visible = False
        aboutTextBox.Visible = True
        aboutTextBox.Rtf = My.Resources.about
    End Sub
    '///////////////////
    'Close help Handle//
    '///////////////////
    Private Sub closeHelpPicEnter(sender As Object, e As EventArgs) Handles closeHelpPic.MouseEnter
        closeHelpPic.Image = New Bitmap(My.Resources.close_help_ena)
    End Sub
    Private Sub closeHelpPic_MouseLeave(sender As Object, e As EventArgs) Handles closeHelpPic.MouseLeave
        closeHelpPic.Image = New Bitmap(My.Resources.close_help_dis)
    End Sub
    Private Sub closeHelpPic_MouseClick(sender As Object, e As EventArgs) Handles closeHelpPic.Click
        closeHelpPic.Visible = False
        aboutTabPic.Visible = False
        howTabPic.Visible = False
        helpPanelImage.Visible = False
        howtoTextBox.Visible = False
        aboutTextBox.Visible = False
        aboutTab_clicked = Nothing
        howTab_clicked = Nothing
        aboutTabPic.Image = New Bitmap(My.Resources.help_tab_dis)
    End Sub

    '////////////////////////////////
    'Clear all the public Variables//
    '////////////////////////////////
    Private Sub clearVar()
        steamN = ""
        exportFileData.Clear()
        ping.Clear() : frags.Clear() : assists.Clear() : deaths.Clear() : mvps.Clear() : hs.Clear() : points.Clear()
        janKD.Clear() : febKD.Clear() : marKD.Clear() : aprKD.Clear() : mayKD.Clear() : junKD.Clear() : julKD.Clear()
        augKD.Clear() : sepKD.Clear() : octKD.Clear() : novKD.Clear() : decKD.Clear()
        mapCount.Clear() : mapWin.Clear() : mapTie.Clear() : mapLost.Clear()
        kdRatio = 0 : killsRound = 0 : assistsRound = 0 : deathRound = 0
        avgPing = 0 : avgFrags = 0 : avgAssists = 0 : avgDeaths = 0 : avgMvp = 0 : avgHs = 0 : avgPoints = 0
        avgWPing = 0 : avgWFrags = 0 : avgWAssists = 0 : avgWDeaths = 0 : avgWMvp = 0 : avgWHs = 0 : avgWPoints = 0
        avgLPing = 0 : avgLFrags = 0 : avgLAssists = 0 : avgLDeaths = 0 : avgLMvp = 0 : avgLHs = 0 : avgLPoints = 0
        totalKills = 0 : totalAssists = 0 : totalDeaths = 0 : roundsPlayed = 0 : mapsPlayedCount = 0 : firstYear = 0 : lastYear = 0
        maxPing = 0 : maxFrags = 0 : maxAssists = 0 : maxDeaths = 0 : maxMvp = 0 : maxHs = 0 : maxPoints = 0
        minPing = 0 : minFrags = 0 : minAssists = 0 : minDeaths = 0 : minMvp = 0 : minHs = 0 : minPoints = 0
        winCount = 0 : lostCount = 0 : tieCount = 0 : winStreak = 0 : lostStreak = 0 : tieStreak = 0 : totalRoundsWin = 0 : totalRoundsLost = 0 : winBySurrender = 0 : lostBySurrender = 0
        maxMatchDuration = 0 : avgMatchDuration = 0 : minMatchDuration = 0 : maxMatchWait = 0 : avgMatchWait = 0 : minMatchWait = 0
    End Sub
End Class
