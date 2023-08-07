Imports System.Data.Odbc
Imports System.Math

Module Funkcje
    Public PCuser As String = Environment.UserName

    Public ZCP_DB As String = My.Settings.ZCP_DB
    Private ReadOnly GAL_DB As String = My.Settings.GAL_DB
    Private ReadOnly GAL_UID As String = My.Settings.GAL_UID
    Private ReadOnly GAL_PWD As String = My.Settings.GAL_PWD
    Public SQLstringChoice As String

    Public strFile As String = "V:\ZCPQVlog_" & ZCP_DB & ".txt"
    Public strFileOpened As String = "V:\ZCPQVopened_" & ZCP_DB & ".txt"

    Private ReadOnly ZCP As String = "DSN=DB2" & ZCP_DB & ";UID=smidb2user;PWD=smidb2userpwd;"
    Public ZCPCon As New OdbcConnection(ZCP)

    Private ReadOnly Galileo As String = "DSN=" & GAL_DB & ";Uid=" & GAL_UID & ";Pwd=" & GAL_PWD & ";"
    Public GalileoCon As New OdbcConnection(Galileo)

    Public da As OdbcDataAdapter

    Public dt As DataTable
    Public dtT As DataTable

    Public dtL As DataTable
    Public dtMP As DataTable
    Public dtP As DataTable

    Public dr As DataRow

    Public SQLstring As String

    Public maszyna As String
    Public stan As Integer
    Public lotto As Integer
    Public ilosc_lotto As Integer
    Public kod As String
    Public opis As String
    Public klient As String
    Public bolla As String
    Public procenty As Single
    'formatowanie daty
    Public FormatDaty As String = "dd-MM-yyyy, HH:mm:ss "
    Public timeStart As Integer
    Public timeStop As Integer
    Public time As Double
    Sub StartTime()
        timeStart = My.Computer.Clock.TickCount
    End Sub
    Sub ShowTime(timeStart As Integer)
        timeStop = My.Computer.Clock.TickCount
        time = Round((timeStop - timeStart) / 1000, 1)
        ZCP_QV.Status.Text = "Czas ładowania: " & time & " sek"
        ZCP_QV.Status2.Text = "    Dane z : " & Now.ToString(FormatDaty)
        ZCP_QV.Status3.Text = "    Automatyczne odświeżanie co : " & ZCP_QV.Timer.Interval / 1000 & " sek"
        ZCP_QV.Status3.ForeColor = Color.Empty
    End Sub
    Sub PokazBlad()
        Dim Msg As String
        Msg = "Błąd #" & Str(Err.Number) & " został wygenerowany przez " &
        Err.Source & ControlChars.CrLf & Err.Description
        MsgBox(Msg, MsgBoxStyle.Critical, "Błąd")
    End Sub
    Sub OpenGalileoConnection()
        Try
            If GalileoCon.State = ConnectionState.Closed Then
                GalileoCon.Open()
            End If
        Catch ex As Exception
            If Err.Number = 5 Then
                MsgBox("Brak połączenia z bazą danych Galileo", vbCritical)
            Else
                PokazBlad()
            End If
            Exit Sub
        End Try
    End Sub
    Sub OpenZCPConnection()
        Try
            If ZCPCon.State = ConnectionState.Closed Then
                ZCPCon.Open()
            End If
        Catch ex As Exception
            If Err.Number = 5 Then
                MsgBox("Brak połączenia z bazą danych Galileo", vbCritical)
            Else
                PokazBlad()
            End If
            Exit Sub
        End Try
    End Sub
    Sub ClearTB()
        For Each TB As Control In ZCP_QV.Controls
            If TB.GetType Is GetType(TextBox) Then
                TB.Text = Nothing
            End If
        Next
    End Sub
    Public Function Mediana(data As Double()) As Double
        Array.Sort(data)
        If data.Length Mod 2 = 0 Then
            Return (data(data.Length \ 2 - 1) + data(data.Length \ 2)) / 2
        Else
            Return data(data.Length \ 2)
        End If
    End Function
End Module
