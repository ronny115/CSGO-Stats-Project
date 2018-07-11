Imports System.IO
Imports System.Text.RegularExpressions

Public Class dataReader
    Dim dataList, matchDate As New List(Of String)
    Dim matchSearchQuery As String
    Dim index As Integer
    Dim winList, lostList, tieList As New List(Of Integer)
    Dim matchDuration, matchWait, teamA, teamB As New List(Of Integer)
    Dim matchRounds, matchInfo, mapsPlayed As New List(Of String)
    Public Function loadData(ByVal Path As String, ByVal Name As String, ByVal worker As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs)
        Dim isNameCorrect As Boolean
        Dim rawData As String
        Dim sR As New StreamReader(Path)

        rawData = sR.ReadToEnd
        sR.Close()
        Dim elements() As String = Regex.Split(rawData, "<|>")
        For Each element In elements
            dataList.Add(element.Trim())
        Next
        dataList.RemoveAll(Function(str) String.IsNullOrWhiteSpace(str))
        'Check if steamN is one of the steamid types and then convert it to what we need
        If Regex.IsMatch(steamN, "^[0-9]{17}$") Then
            Dim id As Long
            id = Convert.ToInt64(steamN)
            id -= 76561197960265728
            steamN = Convert.ToString(id)
        ElseIf Regex.IsMatch(steamN, "^\[U:1:[0-9]+\]$") Then
            steamN = steamN.Substring(5, steamN.Length - 6)
        ElseIf Regex.IsMatch(steamN, "^U:1:[0-9]+$") Then
            steamN = steamN.Substring(4)
        ElseIf Regex.IsMatch(steamN, "^STEAM_0|1:0|1:[0-9]+$") Then
            Dim id As Integer
            id = Convert.ToInt32(steamN.Substring(10)) * 2
            If Regex.IsMatch(steamN, "^STEAM_0|1:1") Then
                id += 1
            End If
            steamN = Convert.ToString(id)
        Else
            matchSearchQuery = "Nothing"
            e.Cancel = True
        End If
        isNameCorrect = False
        'Search if id appears in data list
        For i As Integer = 0 To dataList.Count - 1
            If dataList(i).Contains("""" + steamN + """") AndAlso dataList(i).Contains("a class=""linkTitle"" href=""") Then
                isNameCorrect = True
                Exit For
            End If
        Next
        If isNameCorrect = True Then
            searchLang()
        Else
            matchSearchQuery = "Nothing"
            e.Cancel = True
        End If
        Return e
    End Function
    Private Function searchLang()
        '/////////////////////////////////////////
        'Determines the search query by language//
        '/////////////////////////////////////////
        For i As Integer = 0 To 5
            If dataList(i).Equals("html class="" responsive"" lang=""es""") Then
                matchSearchQuery = "Competitivo"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""en""") Then
                matchSearchQuery = "Competitive"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""bg""") Then
                matchSearchQuery = "Съревнователен"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""cs""") Then
                matchSearchQuery = "Kompetitivní"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""da""") Then
                matchSearchQuery = "Competitive"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""nl""") Then
                matchSearchQuery = "Competitief"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""fi""") Then
                matchSearchQuery = "Kilpailullinen"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""fr""") Then
                matchSearchQuery = "Compétitif"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""de""") Then
                matchSearchQuery = "Wettkampf"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""el""") Then
                matchSearchQuery = "Competitive"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""hu""") Then
                matchSearchQuery = "Versengő"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""it""") Then
                matchSearchQuery = "Competitiva"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""ja""") Then
                matchSearchQuery = "対戦"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""ko""") Then
                matchSearchQuery = "경쟁"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""no""") Then
                matchSearchQuery = "Konkurransespilling"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""pl""") Then
                matchSearchQuery = "Turniejowy"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""pt""") Then
                matchSearchQuery = "Competitivo"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""pt-br""") Then
                matchSearchQuery = "Competitivo"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""ro""") Then
                matchSearchQuery = "Competitive"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""ru""") Then
                matchSearchQuery = "Соревновательный режим"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""zh-cn""") Then
                matchSearchQuery = "竞技模式"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""sv""") Then
                matchSearchQuery = "Tävlingsinriktat"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""zh-tw""") Then
                matchSearchQuery = "競技模式"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""th""") Then
                matchSearchQuery = "แข่งขัน"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""tr""") Then
                matchSearchQuery = "Rekabetçi"
                Exit For
            ElseIf dataList(i).Equals("html class="" responsive"" lang=""uk""") Then
                matchSearchQuery = "Змагальний режим"
                Exit For
            Else
                matchSearchQuery = "Nothing"
            End If
        Next
        '////////////////////////
        'Remove inncessary data//
        '////////////////////////
        For i As Integer = 850 To dataList.Count - 1
            If dataList(i).Contains(matchSearchQuery) Then
                dataList.RemoveRange(0, (i - 1))
                Exit For
            End If
        Next
        Return matchSearchQuery
    End Function
    Public Sub matchData(ByVal worker As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs)

        Dim roundsTeamA, roundsTeamB, stringLength As Integer
        Dim splitedTime() As String
        For i As Integer = 0 To dataList.Count - 1
            '////////////////////
            'Get the match info//
            '////////////////////
            If dataList(i).Contains(matchSearchQuery) Then
                'Ignore ban checker added code
                If dataList(i).Contains("ElementsContainerHistory_LoadMore") Then
                    Continue For
                End If
                index = i
                stringLength = matchSearchQuery.Length
                matchInfo.Add(dataList(index).Remove(0, stringLength + 1))
                index += 5
                'Date
                matchInfo.Add(dataList(index))
                'Wait Time
                index += 5
                stringLength = dataList(index).Length
                matchInfo.Add(dataList(index).Remove(0, (stringLength - 5)))
                'Match Duration
                index += 5
                If Regex.IsMatch(dataList(index), "[0-9]{2}:[0-9]{2}") Then
                    stringLength = dataList(index).Length
                    matchInfo.Add(dataList(index).Remove(0, (stringLength - 5)))
                Else
                    matchInfo.Add("00:00")
                End If
            End If
            index = 0
            '////////////////////////////////////////////////////////////////////
            'Search for player name in team A or B, we also get the round count//
            '////////////////////////////////////////////////////////////////////
            If dataList(i).Equals("td colspan=""8"" class=""csgo_scoreboard_score""") Then
                Dim roundsCurrentMatch() As String = Regex.Split(dataList(i + 1), ":")
                roundsTeamA = Convert.ToInt32(roundsCurrentMatch(0))
                roundsTeamB = Convert.ToInt32(roundsCurrentMatch(1))
                For k As Integer = i - 195 To i
                    If dataList(k).Contains("""" + steamN + """") AndAlso dataList(k).Contains("a class=""linkTitle"" href=""") Then
                        If roundsTeamA > roundsTeamB Then
                            'win
                            winCount += 1
                            lostCount = 0
                            tieCount = 0
                            totalRoundsWin += roundsTeamA
                            totalRoundsLost += roundsTeamB
                            If roundsTeamA < 15 Then
                                winBySurrender += 1
                            End If
                        ElseIf roundsTeamA < roundsTeamB Then
                            'lost
                            winCount = 0
                            lostCount += 1
                            tieCount = 0
                            totalRoundsWin += roundsTeamA
                            totalRoundsLost += roundsTeamB
                            If roundsTeamB < 15 Then
                                lostBySurrender += 1
                            End If
                        ElseIf roundsTeamA = roundsTeamB Then
                            'tie
                            tieCount += 1
                            lostCount = 0
                            winCount = 0
                            totalRoundsWin += roundsTeamA
                            totalRoundsLost += roundsTeamB
                        Else
                            winCount = 0 : tieCount = 0 : lostCount = 0
                        End If
                        winList.Add(winCount)
                        lostList.Add(lostCount)
                        tieList.Add(tieCount)
                    End If
                Next
                For k As Integer = i To i + 205
                    If dataList(k).Contains("""" + steamN + """") AndAlso dataList(k).Contains("a class=""linkTitle"" href=""") Then
                        If roundsTeamA > roundsTeamB Then
                            'lost
                            lostCount += 1
                            winCount = 0
                            tieCount = 0
                            totalRoundsWin += roundsTeamB
                            totalRoundsLost += roundsTeamA
                            If roundsTeamA < 15 Then
                                lostBySurrender += 1
                            End If
                        ElseIf roundsTeamA < roundsTeamB Then
                            'win
                            lostCount = 0
                            winCount += 1
                            tieCount = 0
                            totalRoundsWin += roundsTeamB
                            totalRoundsLost += roundsTeamA
                            If roundsTeamB < 15 Then
                                winBySurrender += 1
                            End If
                        ElseIf roundsTeamA = roundsTeamB Then
                            'tie
                            tieCount += 1
                            lostCount = 0
                            winCount = 0
                            totalRoundsWin += roundsTeamA
                            totalRoundsLost += roundsTeamB
                        Else
                            winCount = 0 : tieCount = 0 : lostCount = 0
                        End If
                        winList.Add(winCount)
                        lostList.Add(lostCount)
                        tieList.Add(tieCount)
                    End If
                Next
                teamA.Add(roundsTeamA)
                teamB.Add(roundsTeamB)
            End If
        Next
        'Reset the counters and get the longest streak for each win/lost/tie
        winCount = 0 : lostCount = 0 : tieCount = 0
        winStreak = winList.Max : lostStreak = lostList.Max : tieStreak = tieList.Max
        '////////////////////////////////////////////////////////////////
        'Get match map duration and wait time and convert it to seconds//
        '////////////////////////////////////////////////////////////////
        Dim totalMatchTime, totalWaitTime As Integer
        For i As Integer = 0 To matchInfo.Count - 1
            index += 1
            mapsPlayed.Add(matchInfo(i))
            matchDate.Add(matchInfo(i + 1))
            splitedTime = Regex.Split(matchInfo(i + 2), ":")
            matchWait.Add((Convert.ToInt32(splitedTime(0)) * 60) + Convert.ToInt32(splitedTime(1)))
            splitedTime = Regex.Split(matchInfo(i + 3), ":")
            matchDuration.Add((Convert.ToInt32(splitedTime(0)) * 60) + Convert.ToInt32(splitedTime(1)))
            totalMatchTime += matchDuration(index - 1)
            totalWaitTime += matchWait(index - 1)
            i += 3
        Next
        'Get the mins max and averages of match duration and wait time
        maxMatchDuration = matchDuration.Max
        minMatchDuration = matchDuration.Min
        maxMatchWait = matchWait.Max
        minMatchWait = matchWait.Min
        avgMatchDuration = (totalMatchTime / mapsPlayed.Count)
        avgMatchWait = (totalWaitTime / mapsPlayed.Count)
        '//////////////////////
        'Total wins/lost/ties//
        '//////////////////////
        For i As Integer = 0 To mapsPlayed.Count - 1
            If winList(i) > 0 Then
                winCount += 1
                mapWin.Add(mapsPlayed(i))
            ElseIf lostList(i) > 0 Then
                lostCount += 1
                mapLost.Add(mapsPlayed(i))
            ElseIf tieList(i) > 0 Then
                tieCount += 1
                mapTie.Add(mapsPlayed(i))
            End If
        Next
        '///////////////////////
        'Count the maps played//
        '///////////////////////
        Dim maps = mapsPlayed.GroupBy(Function(value) value)
        For Each map In maps
            mapCount.Add(map(0))
            mapCount.Add(map.Count)
        Next
    End Sub
    Public Sub getPlayerData(ByVal worker As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs)
        For i As Integer = 0 To dataList.Count - 1
           If dataList(i).Contains("""" + steamN + """") AndAlso dataList(i).Contains("a class=""linkTitle"" href=""") Then
                ping.Add(dataList(i + 6))
                avgPing += (dataList(i + 6))
                frags.Add(dataList(i + 9))
                avgFrags += (dataList(i + 9))
                assists.Add(dataList(i + 12))
                avgAssists += (dataList(i + 12))
                deaths.Add(dataList(i + 15))
                avgDeaths += (dataList(i + 15))
                'Get Mvps
                If dataList(i + 18).IndexOf("★") = 0 Then
                    If dataList(i + 18).Remove(0, 1) = "" Then
                        mvps.Add(1)
                        avgMvp += 1
                    Else
                        mvps.Add(Convert.ToInt32(dataList(i + 18).Remove(0, 1)))
                        avgMvp += (dataList(i + 18).Remove(0, 1))
                    End If
                Else
                    mvps.Add(0)
                End If
                'Get HS% this can be empty
                If dataList(i + 21).IndexOf("&nbsp;") = 0 Then
                    hs.Add(0)
                Else
                    hs.Add(Convert.ToInt32(dataList(i + 21).TrimEnd("%")))
                    avgHs += (dataList(i + 21).TrimEnd("%"))
                End If
                points.Add(Convert.ToInt32(dataList(i + 24)))
                avgPoints += (dataList(i + 24))
            End If
        Next
        'Total Kills/deaths/assists
        totalKills = avgFrags
        totalAssists = avgAssists
        totalDeaths = avgDeaths
        'K/D Ratio
        kdRatio = Math.Round((totalKills / totalDeaths), 2, MidpointRounding.AwayFromZero)
        'Maps Played
        mapsPlayedCount = ping.Count
        'Total rounds played
        roundsPlayed += totalRoundsWin + totalRoundsLost
        'Kills Assists Death/round
        killsRound = Math.Round((totalKills / roundsPlayed), 2, MidpointRounding.AwayFromZero)
        assistsRound = Math.Round((totalAssists / roundsPlayed), 2, MidpointRounding.AwayFromZero)
        deathRound = Math.Round((totalDeaths / roundsPlayed), 2, MidpointRounding.AwayFromZero)
        'Calculate the averages
        avgPing = Math.Round((avgPing / ping.Count), 0, MidpointRounding.AwayFromZero)
        avgFrags = Math.Round((avgFrags / frags.Count), 2, MidpointRounding.AwayFromZero)
        avgAssists = Math.Round((avgAssists / assists.Count), 2, MidpointRounding.AwayFromZero)
        avgDeaths = Math.Round((avgDeaths / deaths.Count), 2, MidpointRounding.AwayFromZero)
        avgMvp = Math.Round((avgMvp / mvps.Count), 2, MidpointRounding.AwayFromZero)
        avgHs = Math.Round((avgHs / hs.Count), 2, MidpointRounding.AwayFromZero)
        avgPoints = Math.Round((avgPoints / points.Count), 0, MidpointRounding.AwayFromZero)
        'Get player data in wins
        For i As Integer = 0 To frags.Count - 1
            If winList(i) > 0 Then
                avgWPing += ping(i)
                avgWFrags += frags(i)
                avgWAssists += assists(i)
                avgWDeaths += deaths(i)
                avgWMvp += mvps(i)
                avgWHs += hs(i)
                avgWPoints += points(i)
            End If
        Next
        avgWPing = Math.Round((avgWPing / winCount), 0, MidpointRounding.AwayFromZero)
        avgWFrags = Math.Round((avgWFrags / winCount), 2, MidpointRounding.AwayFromZero)
        avgWAssists = Math.Round((avgWAssists / winCount), 2, MidpointRounding.AwayFromZero)
        avgWDeaths = Math.Round((avgWDeaths / winCount), 2, MidpointRounding.AwayFromZero)
        avgWMvp = Math.Round((avgWMvp / winCount), 2, MidpointRounding.AwayFromZero)
        avgWHs = Math.Round((avgWHs / winCount), 2, MidpointRounding.AwayFromZero)
        avgWPoints = Math.Round((avgWPoints / winCount), 0, MidpointRounding.AwayFromZero)
        'Get player data in losses
        For i As Integer = 0 To deaths.Count - 1
            If lostList(i) > 0 Then
                avgLPing += ping(i)
                avgLFrags += frags(i)
                avgLAssists += assists(i)
                avgLDeaths += deaths(i)
                avgLMvp += mvps(i)
                avgLHs += hs(i)
                avgLPoints += points(i)
            End If
        Next
        avgLPing = Math.Round((avgLPing / lostCount), 0, MidpointRounding.AwayFromZero)
        avgLFrags = Math.Round((avgLFrags / lostCount), 2, MidpointRounding.AwayFromZero)
        avgLAssists = Math.Round((avgLAssists / lostCount), 2, MidpointRounding.AwayFromZero)
        avgLDeaths = Math.Round((avgLDeaths / lostCount), 2, MidpointRounding.AwayFromZero)
        avgLMvp = Math.Round((avgLMvp / lostCount), 2, MidpointRounding.AwayFromZero)
        avgLHs = Math.Round((avgLHs / lostCount), 2, MidpointRounding.AwayFromZero)
        avgLPoints = Math.Round((avgLPoints / lostCount), 0, MidpointRounding.AwayFromZero)
        'Get the maxs
        maxPing = ping.Max
        maxFrags = frags.Max
        maxAssists = assists.Max
        maxDeaths = deaths.Max
        maxMvp = mvps.Max
        maxHs = hs.Max
        maxPoints = points.Max
        'Get the mins
        minPing = ping.Min
        minFrags = frags.Min
        minAssists = assists.Min
        minDeaths = deaths.Min
        minMvp = mvps.Min
        minHs = hs.Min
        minPoints = points.Min
        'Calculate the K/D ratio for each month each year
        Dim currentYear(), currentMonth As String
        Dim janK, febK, marK, aprK, mayK, junK, julK, augK, sepK, octK, novK, decK As Integer
        Dim janD, febD, marD, aprD, mayD, junD, julD, augD, sepD, octD, novD, decD As Integer
        lastYear = Convert.ToInt32(matchDate(0).Remove(4, matchDate(0).Length - 4))
        firstYear = Convert.ToInt32(matchDate(matchDate.Count - 1).Remove(4, matchDate(0).Length - 4))
        For i As Integer = 0 To (lastYear - firstYear)
            For j As Integer = mapsPlayedCount - 1 To 0 Step -1
                currentYear = Regex.Split(matchDate(j), "-")
                currentMonth = Convert.ToInt32(currentYear(1))
                If matchDate(j).Contains(firstYear + i) Then
                    If currentMonth = 1 Then
                        janK += frags(j)
                        janD += deaths(j)
                    ElseIf currentMonth = 2 Then
                        febK += frags(j)
                        febD += deaths(j)
                    ElseIf currentMonth = 3 Then
                        marK += frags(j)
                        marD += deaths(j)
                    ElseIf currentMonth = 4 Then
                        aprK += frags(j)
                        aprD += deaths(j)
                    ElseIf currentMonth = 5 Then
                        mayK += frags(j)
                        mayD += deaths(j)
                    ElseIf currentMonth = 6 Then
                        junK += frags(j)
                        junD += deaths(j)
                    ElseIf currentMonth = 7 Then
                        julK += frags(j)
                        julD += deaths(j)
                    ElseIf currentMonth = 8 Then
                        augK += frags(j)
                        augD += deaths(j)
                    ElseIf currentMonth = 9 Then
                        sepK += frags(j)
                        sepD += deaths(j)
                    ElseIf currentMonth = 10 Then
                        octK += frags(j)
                        octD += deaths(j)
                    ElseIf currentMonth = 11 Then
                        novK += frags(j)
                        novD += deaths(j)
                    ElseIf currentMonth = 12 Then
                        decK += frags(j)
                        decD += deaths(j)
                    End If
                End If
            Next
            If janK = 0 Then
                janKD.Add(0)
            Else
                janKD.Add(Math.Round((janK / janD), 2, MidpointRounding.AwayFromZero))
                janK = 0 : janD = 0
            End If
            If febK = 0 Then
                febKD.Add(0)
            Else
                febKD.Add(Math.Round((febK / febD), 2, MidpointRounding.AwayFromZero))
                febK = 0 : febD = 0
            End If
            If marK = 0 Then
                marKD.Add(0)
            Else
                marKD.Add(Math.Round((marK / marD), 2, MidpointRounding.AwayFromZero))
                marK = 0 : marD = 0
            End If
            If aprK = 0 Then
                aprKD.Add(0)
            Else
                aprKD.Add(Math.Round((aprK / aprD), 2, MidpointRounding.AwayFromZero))
                aprK = 0 : aprD = 0
            End If
            If mayK = 0 Then
                mayKD.Add(0)
            Else
                mayKD.Add(Math.Round((mayK / mayD), 2, MidpointRounding.AwayFromZero))
                mayK = 0 : mayD = 0
            End If
            If junK = 0 Then
                junKD.Add(0)
            Else
                junKD.Add(Math.Round((junK / junD), 2, MidpointRounding.AwayFromZero))
                junK = 0 : junD = 0
            End If
            If julK = 0 Then
                julKD.Add(0)
            Else
                julKD.Add(Math.Round((julK / julD), 2, MidpointRounding.AwayFromZero))
                julK = 0 : julD = 0
            End If
            If augK = 0 Then
                augKD.Add(0)
            Else
                augKD.Add(Math.Round((augK / augD), 2, MidpointRounding.AwayFromZero))
                augK = 0 : augD = 0
            End If
            If sepK = 0 Then
                sepKD.Add(0)
            Else
                sepKD.Add(Math.Round((sepK / sepD), 2, MidpointRounding.AwayFromZero))
                sepK = 0 : sepD = 0
            End If
            If octK = 0 Then
                octKD.Add(0)
            Else
                octKD.Add(Math.Round((octK / octD), 2, MidpointRounding.AwayFromZero))
                octK = 0 : octD = 0
            End If
            If novK = 0 Then
                novKD.Add(0)
            Else
                novKD.Add(Math.Round((novK / novD), 2, MidpointRounding.AwayFromZero))
                novK = 0 : novD = 0
            End If
            If decK = 0 Then
                decKD.Add(0)
            Else
                decKD.Add(Math.Round((decK / decD), 2, MidpointRounding.AwayFromZero))
                decK = 0 : decD = 0
            End If
        Next
        '/////////////////////
        'Create the csv file//
        '/////////////////////
        Dim format, line, currentDate() As String
        Dim result, year, month, day As New List(Of String)
        format = "Map,Day,Month,Year,Wait Time(s), Match Time(s),Team A Rounds,Team B Rounds,Ping,Kills,Assists,Deaths,Mvp's,HS%,Points,Result"
        exportFileData.AppendLine(format)
        For i As Integer = 0 To mapsPlayedCount - 1
            If winList(i) > 0 Then
                result.Add("Win")
            ElseIf tieList(i) > 0 Then
                result.Add("Tie")
            ElseIf lostList(i) > 0 Then
                result.Add("Lost")
            End If
            currentDate = Regex.Split(matchDate(i), "-")
            year.Add(currentDate(0))
            month.Add(currentDate(1))
            day.Add(currentDate(2).Remove(2, currentDate(2).Length - 2))
            line = mapsPlayed(i) & "," & day(i) & "," & month(i) & "," & year(i) & "," & matchWait(i) & "," & matchDuration(i) & "," & teamA(i) & "," & teamB(i) & "," & ping(i) &
                "," & frags(i) & "," & assists(i) & "," & deaths(i) & "," & mvps(i) & "," & hs(i) & "," & points(i) & "," & result(i)
            exportFileData.AppendLine(line)
        Next
    End Sub
End Class
