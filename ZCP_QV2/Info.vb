Imports System.Data.Odbc
Imports System.Math
Public Class Info
    Dim pUruchomienie As Boolean
    Dim pUruchomieniePrzelew As Boolean
    Private Sub MG_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StartTime As Integer = Environment.TickCount
        If PCuser = "moreno" Or PCuser = "mateusz.swietlik" Then
            TB_loading.Visible = True
        End If
        pUruchomienie = True
        pUruchomieniePrzelew = True
        ZCP_QV.Timer.Stop()
        Me.Size = New Size(553, 510)
        Me.TabControl1.Size = New Size(515, 451)
        Me.CenterToScreen()

        Me.Text = "Maszyna: " & maszyna & " - informacje"

        TB_maszyna.Text = maszyna
        TB_kod.Text = kod
        TB_opis.Text = opis
        TB_lotto.Text = lotto
        TB_klient.Text = klient
        TB_bolla.Text = bolla

        LoadOperator()
        LoadProductionData()
        LoadSetupOfMachine()
        LoadGalileoCycleTime()
        Dim StopTime As Integer = Environment.TickCount
        TB_loading.Text = Round((StopTime - StartTime) / 1000, 2)
    End Sub
    Sub LoadOperator()
        SQLstring = "SELECT OPERAT.NMCOGN 
                     FROM RILTEMPI.ZEVENTI ZEVENTI, COMUNE.OPERAT OPERAT
                        WHERE ZEVENTI.CDOPERAT = OPERAT.CDOPERAT and ZEVENTI.NREVENTO=(SELECT max(ZEVENTI.NREVENTO) 
                        FROM RILTEMPI.ZEVENTI ZEVENTI WHERE (ZEVENTI.NRTASK='" & bolla & "') AND (ZEVENTI.CDMACCHI ='" & maszyna & "'))"
        da = New OdbcDataAdapter(SQLstring, ZCPCon)
        dtT = New DataTable
        da.Fill(dtT)
        If dtT.Rows.Count > 0 And stan <> 8 Then
            TB_op.Text = Trim(dtT.Rows(0).Item(0).ToString)
        Else
            TB_op.Text = String.Empty
        End If
    End Sub
    Sub LoadSetupOfMachine()
        Dim data_rozpoczecia As DateTime
        Dim data_zakonczenia As DateTime
        Dim ile_dni As Integer
        Dim ile_godzin As Integer
        SQLstring = "Select OPERAT.NMCOGN, ZEVENTI.DATRILAP, ZEVENTI.ORARILAP,
                     ZEVENTI.DATRILCH, ZEVENTI.ORARILCH, ZEVENTI.NREVENTO FROM RILTEMPI.ZEVENTI ZEVENTI, COMUNE.OPERAT OPERAT
                     WHERE (ZEVENTI.NRTASK ='" & bolla & "') and (ZEVENTI.TPCAUSA = '2') and ZEVENTI.CDOPERAT = OPERAT.CDOPERAT
                        AND (ZEVENTI.CDMACCHI ='" & maszyna & "')
                     ORDER BY ZEVENTI.NREVENTO"
        da = New OdbcDataAdapter(SQLstring, ZCPCon)
        dtT = New DataTable
        da.Fill(dtT)
        If dtT.Rows.Count > 0 Then

            TB_ustawiacz.Text = Trim(dtT.Rows(0).Item(0).ToString) 'nr ustawiacza
            data_rozpoczecia = dtT.Rows(0).Item(1).Add(dtT.Rows(0).Item(2))
            TB_rozp_ust.Text = Format(data_rozpoczecia, "dd-MM-yyyy HH:mm:ss")

            If dtT.Rows.Count > 1 And TB_rozp_prod.Text <> "" Then
                data_zakonczenia = dtT.Rows(dtT.Rows.Count - 1).Item(3).add(dtT.Rows(dtT.Rows.Count - 1).Item(4))
                TB_zak_ust.Text = Format(data_zakonczenia, "dd-MM-yyyy HH:mm:ss")
                ile_dni = DateDiff(DateInterval.Day, data_rozpoczecia, data_zakonczenia)
                ile_godzin = DateDiff(DateInterval.Hour, data_rozpoczecia, data_zakonczenia)
                TB_czas_ust.Text = ile_dni & " dni " & ile_godzin - 24 * ile_dni & " godz."
            End If

            If dtT.Rows.Count = 1 And TB_rozp_prod.Text <> "" Then
                data_zakonczenia = dtT.Rows(0).Item(3).add(dtT.Rows(0).Item(4))
                TB_zak_ust.Text = Format(data_zakonczenia, "dd-MM-yyyy HH:mm:ss")
                ile_dni = DateDiff(DateInterval.Day, data_rozpoczecia, data_zakonczenia)
                ile_godzin = DateDiff(DateInterval.Hour, data_rozpoczecia, data_zakonczenia)
                TB_czas_ust.Text = ile_dni & " dni " & ile_godzin - 24 * ile_dni & " godz."
            End If
        End If
    End Sub
    Sub LoadProductionData()
        Dim i As Integer
        Dim czas_cykluS() As Double
        Dim data_rozpoczecia As DateTime
        Dim data_zakonczenia As DateTime
        Dim ile_dni As Integer
        Dim ile_godzin As Integer
        Dim ile_sekund As Integer
        Dim ile_sekund_do_konca As Integer

        SQLstring = "Select ZCONTTASK.DATACONT, ZCONTTASK.ORACONT, ZCONTTASK.CONTATORE From RILTEMPI.ZCONTTASK ZCONTTASK
                    Where (ZCONTTASK.BOLLA ='" & bolla & "') and (ZCONTTASK.CONTATORE = 1) and (ZCONTTASK.MACCHINA ='" & maszyna & "')
                    ORDER BY ZCONTTASK.CONTATORE"
        da = New OdbcDataAdapter(SQLstring, ZCPCon)
        dtT = New DataTable
        da.Fill(dtT)
        If dtT.Rows.Count > 0 Then
            data_rozpoczecia = dtT.Rows(0).Item(0).add(dtT.Rows(0).Item(1))
            TB_rozp_prod.Text = Format(data_rozpoczecia, "dd-MM-yyyy HH:mm:ss")
            TB_stan.Text = procenty & " %"
            ile_dni = DateDiff(DateInterval.Day, data_rozpoczecia, Now)
            ile_godzin = DateDiff(DateInterval.Hour, data_rozpoczecia, Now)
            ile_sekund = DateDiff(DateInterval.Second, data_rozpoczecia, Now)
            TB_czas_aktual.Text = ile_dni & " dni " & ile_godzin - 24 * ile_dni & " godz."

            If procenty > 100 Then
                TB_stan.ForeColor = Color.Red
            ElseIf procenty > 0 Then
                ile_sekund_do_konca = Round((ile_sekund * (1 - procenty / 100)) / (procenty / 100))
                data_zakonczenia = Now.AddSeconds(ile_sekund_do_konca)
                ile_dni = DateDiff(DateInterval.Day, data_rozpoczecia, data_zakonczenia)
                ile_godzin = DateDiff(DateInterval.Hour, data_rozpoczecia, data_zakonczenia)
                TB_koniec.Text = Format(data_zakonczenia, "dd-MM-yyyy HH:mm:ss")
                TB_orient_czas_prod.Text = ile_dni & " dni " & ile_godzin - 24 * ile_dni & " godz."
            End If

            'czas cyklu
            SQLstring = "Select ZCONTTASK.CONTATORE, ZCONTTASK.DATACONT, ZCONTTASK.ORACONT From RILTEMPI.ZCONTTASK ZCONTTASK
                    Where (ZCONTTASK.BOLLA ='" & bolla & "') and (ZCONTTASK.MACCHINA ='" & maszyna & "') and ZCONTTASK.DATACONT='" & Today().ToString("yyyy-MM-dd") & "'
                    ORDER BY ZCONTTASK.CONTATORE DESC
                    FETCH FIRST 51 ROWS ONLY"
            da = New OdbcDataAdapter(SQLstring, ZCPCon)
            dtT = New DataTable
            da.Fill(dtT)
            If dtT.Rows.Count > 0 Then
                ReDim czas_cykluS(dtT.Rows.Count - 2)

                For i = 0 To dtT.Rows.Count - 2
                    data_zakonczenia = dtT.Rows(i).Item(1).Add(dtT.Rows(i).Item(2))
                    data_rozpoczecia = dtT.Rows(i + 1).Item(1).Add(dtT.Rows(i + 1).Item(2))
                    czas_cykluS(i) = DateDiff(DateInterval.Second, data_rozpoczecia, data_zakonczenia)
                Next
                TB_czas_cyklu_mediana.Text = Mediana(czas_cykluS)
            End If
        End If
    End Sub
    Sub LoadGalileoCycleTime()
        Dim czas_prod As Single
        Dim czas_ust As Single
        Dim wydajnosc As Single
        Dim czas_cyklu As Single
        SQLstring = "SELECT PCIMP00F.OILMCI, PCIMP00F.OIAMCI, PCIMP00F.EFSMCI FROM AS400.PCIMP00F PCIMP00F 
                     WHERE PCIMP00F.NRBLCI = '" & bolla & " '"
        da = New OdbcDataAdapter(SQLstring, ZCPCon)
        dtT = New DataTable
        da.Fill(dtT)
        If dtT.Rows.Count = 1 Then
            czas_prod = dtT.Rows(0).Item("OILMCI") / 100
            czas_ust = dtT.Rows(0).Item("OIAMCI") / 100
            wydajnosc = dtT.Rows(0).Item("EFSMCI") / 100
            czas_cyklu = czas_prod * 3600 / ilosc_lotto * (wydajnosc / 100)

            G_czas_ust.Text = Round(czas_ust / 24 - 0.5) & " dni " & Round(czas_ust Mod 24) & " godz."
            G_czas_prod.Text = Round(czas_prod / 24 - 0.5) & " dni " & Round(czas_prod Mod 24) & " godz."
            G_czas_cykl.Text = Round(czas_cyklu, 2)
        End If
    End Sub
    Sub LoadLottoProd()
        SQLstring = "Select PMORD00F.CDARPO, PMORD00F.QORDPO, PMORD00F.CDCIPO, PMORD00F.DT01PO, PMORD00F.DTMNPO 
        From AS400.PMORD00F PMORD00F Where PMORD00F.ORPRPO ='" & lotto & "'"
        da = New OdbcDataAdapter(SQLstring, ZCPCon)
        dtL = New DataTable
        da.Fill(dtL)
        If dtL.Rows.Count > 0 Then
            With dtL.Rows(0)
                TB_lotto2.Text = lotto 'Trim(.Item("CDARPO")).ToString
                TB_ilosc_zam.Text = .Item("QORDPO") / 10000
                TB_cykl.Text = Trim(.Item("CDCIPO"))
                TB_data_utw.Text = .Item("DT01PO")
                TB_data_mod.Text = .Item("DTMNPO")
            End With
        End If
    End Sub
    Private Sub Pobierz_wykaz()
        Dim MP As String
        SQLstring = "SELECT MGART00F.DSARMA, MGART00F.UMBAMA, PMIMP00F.CDARPI, PMIMP00F.QIMPPI, PMIMP00F.QPREPI, Cast(PMIMP00F.DTUMPI as int)
                     FROM " & ZCP_DB & "80DAT.PMIMP00F PMIMP00F, " & ZCP_DB & "80DAT.MGART00F MGART00F 
                     WHERE MGART00F.CDARMA=PMIMP00F.CDARPI and PMIMP00F.ORPRPI='" & lotto & "'"
        da = New OdbcDataAdapter(SQLstring, GalileoCon)
        dtL = New DataTable
        da.Fill(dtL)
        Tabela_MP.Rows.Clear() 'czyszczenie tabeli przed odświeżeniem
        If dtL.Rows.Count > 0 Then
            Tabela_MP.Rows.Add(dtL.Rows.Count)
            For i = 0 To dtL.Rows.Count - 1
                Tabela_MP.Rows(i).Cells(0).Value = Trim(dtL.Rows(i).Item("CDARPI")) 'kod z wykazu
                Tabela_MP.Rows(i).Cells(1).Value = dtL.Rows(i).Item("DSARMA") 'opis z MGART00F
                Tabela_MP.Rows(i).Cells(2).Value = dtL.Rows(i).Item("UMBAMA") 'jednostka KG/NR

                Dim ilosc As Single = dtL.Rows(i).Item("QIMPPI") 'ilość
                Tabela_MP.Rows(i).Cells(3).Value = ilosc

                Dim ilosc_przelana As Single = dtL.Rows(i).Item("QPREPI") 'ilość zam
                Tabela_MP.Rows(i).Cells(4).Value = ilosc_przelana
                If dtL.Rows(i).Item(5).ToString <> 0 Then
                    Dim data = DateTime.ParseExact(dtL.Rows(i).Item(5).ToString, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                    Tabela_MP.Rows(i).Cells(5).Value = data.ToString("dd.MM.yyyy")
                End If
            Next
        End If
        If Tabela_MP.Rows.Count > 0 Then
            For Each r As DataGridViewRow In Tabela_MP.Rows
                MP = r.Cells(0).Value
                SQLstring = "SELECT Sum(cast(MGESI00F.GIATME as INT))
                         FROM S100A014." & ZCP_DB & "80DAT.MGESI00F MGESI00F
                         WHERE (MGESI00F.CDMGME<>'900') and MGESI00F.CDARME = '" & MP & "'
                         GROUP BY MGESI00F.CDARME
                         ORDER BY MGESI00F.CDARME"
                da = New OdbcDataAdapter(SQLstring, GalileoCon)
                dtT = New DataTable
                da.Fill(dtT)
                r.Cells(6).Value = dtT.Rows(0).Item(0)
            Next
        End If
    End Sub
    Private Sub Pobierz_fazy()
        SQLstring = "SELECT PCIMP00F.CDFACI, PCIMP00F.DSFACI, PCIMP00F.CDCLCI, cast(PCIMP00F.QPROCI as INT),
                     cast(PCIMP00F.QSCACI as INT), PCIMP00F.DTFICI
                     FROM AS400.PCIMP00F PCIMP00F WHERE PCIMP00F.ORPRCI='" & lotto & "'"
        da = New OdbcDataAdapter(SQLstring, ZCPCon)
        dtL = New DataTable
        da.Fill(dtL)
        Tabela_fazy.Rows.Clear() 'czyszczenie tabeli przed odświeżeniem
        If dtL.Rows.Count > 0 Then
            Tabela_fazy.Rows.Add(dtL.Rows.Count)
            For i = 0 To dtL.Rows.Count - 1
                Tabela_fazy.Rows(i).Cells(0).Value = dtL.Rows(i).Item("CDFACI") 'faza
                Tabela_fazy.Rows(i).Cells(1).Value = Trim(dtL.Rows(i).Item("DSFACI")) 'opis fazy
                Tabela_fazy.Rows(i).Cells(2).Value = dtL.Rows(i).Item("CDCLCI") 'grupa maszyn
                Tabela_fazy.Rows(i).Cells(3).Value = dtL.Rows(i).Item(3) 'wyprodukowano
                Tabela_fazy.Rows(i).Cells(4).Value = dtL.Rows(i).Item(4) 'braki
                Tabela_fazy.Rows(i).Cells(5).Value = dtL.Rows(i).Item("DTFICI") 'data ost mod
            Next
        End If
    End Sub
    Private Sub MP_info_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Sub LoadPrzelewy()
        SQLstring = "SELECT RLMOV00F.SEGNRM, Trim(RLMOV00F.CDLTRM), Trim(RLMOV00F.CDARRM), Trim(RLMOV00F.DSARRM), 
                    Cast(RLMOV00F.QTMORM as float), RLMOV00F.CDUMRM, Cast(RLMOV00F.DTOPRM as int), CGPCO00F.DSCOCP, 
                    RLAN100F.LTFORA, RLAN100F.NRORRA, RLAN100F.DTAPRA
                    FROM " & ZCP_DB & "80DAT.RLMOV00F RLMOV00F, " & ZCP_DB & "80DAT.RLAN100F RLAN100F, S100A014." & ZCP_DB & "80DAT.CGPCO00F CGPCO00F
                    WHERE RLAN100F.CDCFRA=CGPCO00F.CONTCP and RLAN100F.CDLTRA=RLMOV00F.CDLTRM and RLMOV00F.ORPRRM ='" & lotto & "'"
        da = New OdbcDataAdapter(SQLstring, GalileoCon)
        dtP = New DataTable
        da.Fill(dtP)
        DGV_przelewy.Rows.Clear() 'czyszczenie tabeli przed odświeżeniem
        If dtP.Rows.Count > 0 Then
            DGV_przelewy.Rows.Add(dtP.Rows.Count)
            For i = 0 To dtP.Rows.Count - 1
                With DGV_przelewy.Rows(i)
                    .Cells(0).Value = dtP.Rows(i).Item(0)
                    .Cells(1).Value = dtP.Rows(i).Item(1)
                    .Cells(2).Value = dtP.Rows(i).Item(2)
                    .Cells(3).Value = dtP.Rows(i).Item(3)
                    .Cells(4).Value = dtP.Rows(i).Item(4)
                    .Cells(5).Value = dtP.Rows(i).Item(5)
                    If dtP.Rows(i).Item(6).ToString <> 0 Then
                        Dim data = DateTime.ParseExact(dtP.Rows(i).Item(6).ToString, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                        .Cells(6).Value = data.ToString("dd.MM.yyyy")
                    End If
                End With
            Next
        End If
        If dtP.Rows.Count > 1 Then
            DGV_przelewy.CurrentCell.Selected = False
            TB_przel_lotto.Text = ""
            TB_przel_dostawca.Text = ""
            TB_przel_lotto_dostawcy.Text = ""
            TB_przel_numer_zam.Text = ""
            TB_przel_data_dodania.Text = ""
        End If
    End Sub
    Private Sub DGV_przelewy_CellMouseClick(sender As Object, e As EventArgs) Handles DGV_przelewy.SelectionChanged, DGV_przelewy.CellMouseClick
        If DGV_przelewy.CurrentRow.Index >= 0 Then
            Dim index As Integer = DGV_przelewy.CurrentRow.Index
            TB_przel_lotto.Text = Trim(dtP.Rows(index).Item(1)).ToString
            TB_przel_dostawca.Text = Trim(dtP.Rows(index).Item("DSCOCP")).ToString
            TB_przel_lotto_dostawcy.Text = Trim(dtP.Rows(index).Item("LTFORA")).ToString
            TB_przel_numer_zam.Text = Trim(dtP.Rows(index).Item("NRORRA")).ToString
            If dtP.Rows(index).Item("DTAPRA").ToString <> 0 Then
                Dim data = DateTime.ParseExact(dtP.Rows(index).Item("DTAPRA").ToString, "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
                TB_przel_data_dodania.Text = data.ToString("dd.MM.yyyy")
            End If
        End If
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex

            Case 0
                Me.Size = New Size(553, 510)
                Me.TabControl1.Size = New Size(515, 451)
                Me.CenterToScreen()
            Case 1
                Me.Size = New Size(735, 553)
                Me.TabControl1.Size = New Size(699, 494)
                Me.CenterToScreen()
                If pUruchomienie = True Then
                    LoadLottoProd()
                    Pobierz_wykaz()
                    Pobierz_fazy()
                    pUruchomienie = False
                End If
            Case 2
                Me.Size = New Size(735, 553)
                Me.TabControl1.Size = New Size(699, 494)
                Me.CenterToScreen()
                If pUruchomieniePrzelew = True Then
                    LoadPrzelewy
                    pUruchomieniePrzelew = False
                End If
        End Select
    End Sub
    Private Sub Info_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ZCP_QV.Timer.Start()
        Me.Dispose()
    End Sub

    Private Sub G_czas_cykl_TextChanged(sender As Object, e As EventArgs) Handles G_czas_cykl.TextChanged
        If TB_czas_cyklu_mediana.Text <> "" And G_czas_cykl.Text <> "" Then
            If Math.Abs(TB_czas_cyklu_mediana.Text - G_czas_cykl.Text) > 0.1 * TB_czas_cyklu_mediana.Text Then
                G_czas_cykl.BackColor = Color.Yellow
            End If
        End If
    End Sub
End Class