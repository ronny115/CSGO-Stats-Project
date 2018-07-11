Imports System.Text
Module pubVars
    Public steamN, playerSteamID As String
    Public exportFileData As New StringBuilder()

    Public ping, frags, assists, deaths, mvps, hs, points As New List(Of Integer)
    Public janKD, febKD, marKD, aprKD, mayKD, junKD, julKD, augKD, sepKD, octKD, novKD, decKD As New List(Of Double)
    Public mapCount, mapWin, mapLost, mapTie As New List(Of String)

    Public kdRatio, killsRound, assistsRound, deathRound As Double
    Public avgPing, avgFrags, avgAssists, avgDeaths, avgMvp, avgHs, avgPoints As Double
    Public avgWPing, avgWFrags, avgWAssists, avgWDeaths, avgWMvp, avgWHs, avgWPoints As Double
    Public avgLPing, avgLFrags, avgLAssists, avgLDeaths, avgLMvp, avgLHs, avgLPoints As Double

    Public totalKills, totalAssists, totalDeaths, roundsPlayed, mapsPlayedCount, firstYear, lastYear As Integer
    Public maxPing, maxFrags, maxAssists, maxDeaths, maxMvp, maxHs, maxPoints As Integer
    Public minPing, minFrags, minAssists, minDeaths, minMvp, minHs, minPoints As Integer
    Public winCount, lostCount, tieCount, winStreak, lostStreak, tieStreak, totalRoundsWin, totalRoundsLost, winBySurrender, lostBySurrender As Integer
    Public maxMatchDuration, avgMatchDuration, minMatchDuration, maxMatchWait, avgMatchWait, minMatchWait As Integer
End Module
