Imports System.ComponentModel
Imports System.Data.Odbc
Public Class Tools
    Private Sub Tools_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TB_maszyna.Text = maszyna
        TB_lotto.Text = lotto
        TB_kod.Text = kod
        TB_opis.Text = opis
        TB_bolla.Text = bolla
        TB_procenty.Text = procenty & " %"
        LoadToolList()
    End Sub
    Sub LoadToolList()
        Dim cena As Single
        Dim cena_ori As Single
        Dim R1 As Single
        Dim R2 As Single
        Dim R3 As Single
        Dim R4 As Single
        Dim koszt_na_detal As Single
        Dim TL As Single
        Dim krawedzie As Byte
        SQLstring = "SELECT ZUTPCU.CICLO, ZUTPCU.FASE, ZUTPCU.MACCHINA, ZUTPCU.POSIZUT, 
                    ZUTPCU.CORRETTORE, ZUTENSILI.TIPOUT, ZUTPCU.CODINSERTOSTD, ZUTPCU.NUMPZPREVISTISTD, ZUTPCU.BOLLA, 
                    ZUTPCU.CODUTFORNITORE, ZUTPCU.IDPCU, ZUTENSILI.MARCA, ZUTENSILI.NUMTAGLIENTI, ZUTENSILI.GIACENZA, 
                    ZUTENSILI.PRZLISTINO, ZUTENSILI.SCONTO1, ZUTENSILI.SCONTO2, ZUTENSILI.SCONTO3, ZUTENSILI.SCONTO4
                    FROM RILTEMPI.ZUTPCU ZUTPCU, RILTEMPI.ZUTENSILI ZUTENSILI
                    WHERE ZUTPCU.BOLLA = '" & bolla & "' and ZUTPCU.MACCHINA= '" & maszyna & "' and ZUTPCU.CODUTFORNITORE=ZUTENSILI.CODUTFORNITORE
                    ORDER BY ZUTPCU.POSIZUT"
        da = New OdbcDataAdapter(SQLstring, ZCPCon)
        dtT = New DataTable
        da.Fill(dtT)
        DGV_tools.Rows.Clear() 'czyszczenie tabeli przed odświeżeniem
        If dtT.Rows.Count > 0 Then

            TB_cykl.Text = dtT.Rows(0).Item("CICLO")
            TB_faza.Text = dtT.Rows(0).Item("FASE")

            DGV_tools.Rows.Add(dtT.Rows.Count)
            For i = 0 To dtT.Rows.Count - 1
                With DGV_tools.Rows(i)
                    .Cells(0).Value = dtT.Rows(i).Item("POSIZUT")
                    .Cells(1).Value = dtT.Rows(i).Item("CORRETTORE")
                    .Cells(2).Value = dtT.Rows(i).Item("TIPOUT")
                    .Cells(3).Value = dtT.Rows(i).Item("MARCA")
                    .Cells(4).Value = dtT.Rows(i).Item("CODINSERTOSTD")
                    .Cells(5).Value = dtT.Rows(i).Item("CODUTFORNITORE")

                    TL = dtT.Rows(i).Item("NUMPZPREVISTISTD")
                    .Cells(6).Value = TL

                    krawedzie = dtT.Rows(i).Item("NUMTAGLIENTI")
                    .Cells(7).Value = krawedzie

                    .Cells(9).Value = dtT.Rows(i).Item("GIACENZA")
                    cena_ori = dtT.Rows(i).Item("PRZLISTINO")
                    R1 = dtT.Rows(i).Item("SCONTO1")
                    R2 = dtT.Rows(i).Item("SCONTO2")
                    R3 = dtT.Rows(i).Item("SCONTO3")
                    If dtT.Rows(i).Item("SCONTO4").ToString <> "" Then
                        R4 = dtT.Rows(i).Item("SCONTO4")
                    End If
                    cena = cena_ori * (1 - R1 / 100) * (1 - R2 / 100) * (1 - R3 / 100) * (1 - R4 / 100)
                    .Cells(8).Value = Math.Round(cena, 2)
                    koszt_na_detal += cena / krawedzie / TL
                End With
            Next
            TB_koszt.Text = Math.Round(koszt_na_detal, 3) & " €"
            TB_l_narz.Text = DGV_tools.Rows.Count
        End If
    End Sub
    Private Sub DGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV_tools.CellFormatting
        'Formatowanie ilości w kolumnach: ilość lotto,ilośc wyprod, ilość braków
        If (e.ColumnIndex = 6) AndAlso IsNumeric(e.Value) AndAlso e.Value >= 1000 AndAlso e.Value < 1000000 Then
            e.Value = Format(e.Value, "0 000")
        End If
        If (e.ColumnIndex = 6) AndAlso IsNumeric(e.Value) AndAlso e.Value >= 1000000 Then
            e.Value = Format(e.Value, "0 000 000")
        End If
    End Sub

    Private Sub Tools_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class