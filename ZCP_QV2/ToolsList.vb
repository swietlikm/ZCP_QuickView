Imports System.Data.Odbc
Public Class ToolsList
    '    Dim cykle As List(Of String)
    '    Dim fazy As List(Of String)
    '    Dim grupy_maszyn As List(Of String)

    Dim NewTool As DataGridViewRow

    Dim cykl As String
    Dim faza As String
    Dim grupa As String

    Private Sub ToolsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub Wyszukaj(Kod As String)
        TB_ilosc_narzedzi.Text = ""
        TB_koszt_narzedzi.Text = ""
        DGV_wybor.DataSource = Nothing
        DGV_tools.Rows.Clear()
        SQLstring = "SELECT ZUTPCUBASE.ARTICOLO, ZUTPCUBASE.CICLO, ZUTPCUBASE.FASE, ZUTPCUBASE.GRUMAC, ZUTPCUBASE.POSIZUT, ZUTPCUBASE.CORRETTORE,
        ZUTENSILI.TIPOUT, ZUTENSILI.MARCA, ZUTPCUBASE.CODINSERTOSTD, ZUTPCUBASE.CODUTFORNITORE, ZUTPCUBASE.NUMPZPREVISTISTD, ZUTENSILI.NUMTAGLIENTI, 
        ZUTENSILI.GIACENZA, ZUTENSILI.PRZLISTINO, ZUTENSILI.SCONTO1, ZUTENSILI.SCONTO2, ZUTENSILI.SCONTO3, ZUTENSILI.SCONTO4
        FROM RILTEMPI.ZUTENSILI ZUTENSILI, RILTEMPI.ZUTPCUBASE ZUTPCUBASE 
        WHERE ZUTPCUBASE.CODUTFORNITORE=ZUTENSILI.CODUTFORNITORE and ZUTPCUBASE.ARTICOLO = '" & Kod & "'
        ORDER BY ZUTPCUBASE.POSIZUT, ZUTPCUBASE.CICLO, ZUTPCUBASE.FASE"
        dtT = New DataTable
        da = New OdbcDataAdapter(SQLstring, ZCPCon)
        da.Fill(dtT)
        If dtT.Rows.Count > 0 Then
            PopulateWybor()
        Else
            MsgBox("Brak listy narzędzi dla podanego kodu", vbInformation)
        End If
    End Sub
    'Sub PopulateCB()
    '    cykle = New List(Of String)
    '    fazy = New List(Of String)
    '    grupy_maszyn = New List(Of String)
    '    For Each r As DataRow In dtT.Rows
    '        If Not cykle.Contains(r.Item(1).ToString) Then
    '            cykle.Add(r.Item(1).ToString)
    '        End If
    '        If Not fazy.Contains(r.Item(2).ToString) Then
    '            fazy.Add(r.Item(2).ToString)
    '        End If
    '        If Not grupy_maszyn.Contains(r.Item(3).ToString) Then
    '            grupy_maszyn.Add(r.Item(3).ToString)
    '        End If
    '    Next
    '    cykle.Sort()
    '    fazy.Sort()
    ''    grupy_maszyn.Sort()
    'End Sub
    Sub PopulateWybor()
        Dim dtD As DataTable = dtT.DefaultView.ToTable(True, "Ciclo", "Fase", "Grumac")
        dtD.Columns(0).ColumnName = "Cykl"
        dtD.Columns(1).ColumnName = "Faza"
        dtD.Columns(2).ColumnName = "Grupa"
        With DGV_wybor
            .DataSource = dtD
            .Columns(0).Width = 50
            .Columns(1).Width = 50
            .Columns(2).Width = 50
        End With
    End Sub
    Private Sub Wyszukaj_Click(sender As Object, e As EventArgs) Handles BT_wyszukaj.Click
        Wyszukaj(TB_kod.Text)
    End Sub

    Private Sub DGV_wybor_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_wybor.SelectionChanged
        Dim koszt_na_detal As Single
        Dim koszt As Single
        Dim cena_ori As Single
        Dim R1 As Single
        Dim R2 As Single
        Dim R3 As Single
        Dim R4 As Single
        Dim TL As Single
        Dim krawedzie As Byte
        cykl = DGV_wybor.CurrentRow.Cells("Cykl").Value
        faza = DGV_wybor.CurrentRow.Cells("Faza").Value
        grupa = DGV_wybor.CurrentRow.Cells("Grupa").Value

        DGV_tools.Rows.Clear()
        TB_ilosc_narzedzi.Text = ""
        TB_koszt_narzedzi.Text = ""

        For Each r As DataRow In dtT.Rows
            If r.Item(1) = cykl And r.Item(2) = faza And r.Item(3) = grupa Then
                NewTool = DGV_tools.Rows(DGV_tools.Rows.Add)
                NewTool.Cells(0).Value = r.Item(4)
                NewTool.Cells(1).Value = r.Item(5)
                NewTool.Cells(2).Value = r.Item(6)
                NewTool.Cells(3).Value = r.Item(7)
                NewTool.Cells(4).Value = r.Item(8)
                NewTool.Cells(5).Value = r.Item(9)
                NewTool.Cells(6).Value = r.Item(10)

                TL = r.Item("NUMPZPREVISTISTD")
                NewTool.Cells(6).Value = TL

                krawedzie = r.Item("NUMTAGLIENTI")
                NewTool.Cells(7).Value = krawedzie

                NewTool.Cells(9).Value = r.Item("GIACENZA")
                cena_ori = r.Item("PRZLISTINO")
                R1 = r.Item("SCONTO1")
                R2 = r.Item("SCONTO2")
                R3 = r.Item("SCONTO3")
                If r.Item("SCONTO4").ToString <> "" Then
                    R4 = r.Item("SCONTO4")
                End If
                koszt = cena_ori * (1 - R1 / 100) * (1 - R2 / 100) * (1 - R3 / 100) * (1 - R4 / 100)
                NewTool.Cells(8).Value = Math.Round(koszt, 2)
                koszt_na_detal += koszt / krawedzie / TL
                TB_koszt_narzedzi.Text = Math.Round(koszt_na_detal, 3) & " €"
            End If
        Next
        TB_ilosc_narzedzi.Text = DGV_tools.Rows.Count
    End Sub
End Class