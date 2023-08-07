Imports System.Reflection
Imports System.Data.Odbc
Imports System.Math
Imports System.ComponentModel
Imports System.IO
Public Class ZCP_QV
    Dim dv As DataView
    Dim max As Integer = 0
    Dim min As Integer = 2147483647
    Dim Lmax As Integer = 0
    Dim Lmin As Integer = 99999999
    Dim wwyspa As String

    Dim DGVsortmode As ListSortDirection
    Dim DGVsortcolumn As DataGridViewColumn
    Dim DGVsortcolumnindex As Integer
    Private Sub LoadDGV()
        StartTime()

        Try
            LoadBasic()
        Catch ex As Exception
            If Err.Number = 5 Then
                MsgBox("Brak połączenia z bazą danych ZCP", vbCritical)
                PokazBlad()
                Exit Sub
            Else
                PokazBlad()
                Exit Sub
            End If
        End Try

        Try
            LoadCustomers()
            LoadMP()
            'LoadEmptyMachines()
        Catch ex As Exception
            If Err.Number = 5 Then
                MsgBox("Brak połączenia z bazą danych Galileo", vbCritical)
                PokazBlad()
                Exit Sub
            Else
                PokazBlad()
                Exit Sub
            End If
        End Try

        DGV.DataSource = dt
        FormatDGV()
        If DGVsortcolumn IsNot Nothing Then
            DGV.Sort(DGV.Columns(DGVsortcolumnindex), DGVsortmode)
        End If
        Filtruj()
        ShowTime(timeStart)
    End Sub
    Private Sub ZCP_QV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartAPPlog()

        Me.Size = New Size(1348, 640)
        Me.DGV.Size = New Size(1308, 523)
        Me.CenterToScreen()

        Timer.Interval = My.Settings.RefreshTimer * 1000
        Timer.Start()

        EnableDoubleBuffered(DGV)
        LoadDGV()
        GetIslands()
    End Sub
    Private Sub LoadBasic()
        Select Case ZCP_DB
            Case "ZPL"
                SQLstringChoice = "AND (ZANAMACC.CDCENLAV like 'PRO0%')"
            Case "ZAN"
                SQLstringChoice = "AND (ZANAMACC.CDCENLAV not like 'ZAS%') AND (ZANAMACC.CDCENLAV not like 'ZMG%')"
            Case "MCV"
                SQLstringChoice = "AND (ZANAMACC.CDCENLAV not like 'REP31')"
            Case Else
                MsgBox("Wrong prefix in the configuration file!" & vbNewLine & "Check .config", vbCritical)
                Me.Close()
                Exit Sub
        End Select
        SQLstring = "SELECT Trim(ZANAMACC.CDCENLAV), Trim(ZBOLLA.CDMACCHI), Trim(ZANAMACC.DSMACCHI), ZANAMACC.STATO, Cast(PCIMP00F.ORPRCI as INT),
                     Trim(PMORD00F.CDCIPO), Trim(PCIMP00F.CDARCI), Trim(MGART00F.DSARMA), Cast(PMORD00F.QORDPO as INT), Cast(PCIMP00F.QPROCI as INT) + Cast(ZANAMACC.CONTATORE as INT), 
                     Cast(PCIMP00F.QSCACI as INT), Trim(PMORD00F.CLIEPO), ZBOLLA.NRTASK

                      FROM AS400.MGART00F MGART00F, AS400.PCIMP00F PCIMP00F, AS400.PMORD00F PMORD00F, RILTEMPI.ZANAMACC ZANAMACC, 
                      RILTEMPI.ZBOLLA ZBOLLA 

                     WHERE ZBOLLA.NRTASK = PCIMP00F.NRBLCI AND ZANAMACC.CDMACCHI = ZBOLLA.CDMACCHI
                     AND PCIMP00F.CDARCI = PMORD00F.CDARPO AND PCIMP00F.ORPRCI = PMORD00F.ORPRPO AND MGART00F.CDARMA = PCIMP00F.CDARCI and PMORD00F.CLIEPO NOT LIKE ' '
                     

                    " & SQLstringChoice & " ORDER BY ZBOLLA.CDMACCHI"
        da = New OdbcDataAdapter(SQLstring, ZCPCon)
        dt = New DataTable
        da.Fill(dt)
        dt.Columns(0).ColumnName = "Wyspa"
        dt.Columns(1).ColumnName = "Nr_masz"
        dt.Columns(2).ColumnName = "Maszyna"
        dt.Columns(3).ColumnName = "Status"
        dt.Columns(4).ColumnName = "Lotto"
        dt.Columns(5).ColumnName = "Cykl"
        dt.Columns(6).ColumnName = "Kod"
        dt.Columns(7).ColumnName = "Opis"
        dt.Columns(8).ColumnName = "Ilosc_zam"
        dt.Columns(9).ColumnName = "Ilosc_wyp"
        dt.Columns(10).ColumnName = "Ilosc_bra"
        dt.Columns(11).ColumnName = "CONTCP"
        dt.Columns(12).ColumnName = "Bolla"
        dt.Columns.Add("% Lotto", GetType(Single)) 'ID13
        For Each row As DataRow In dt.Rows
            row.Item(13) = Round(row.Item(9) / row.Item(8) * 100, 1)
        Next

        dt.Columns.Add("% NOK", GetType(Single)) 'ID14
        For Each row As DataRow In dt.Rows
            If row.Item(9) + row.Item(10) = 0 Then
                row.Item(14) = 0
            Else
                row.Item(14) = Round(row.Item(10) / (row.Item(9) + row.Item(10)) * 100, 1)
            End If
        Next
        For Each row As DataRow In dt.Rows
            If row.Item(11) <> "" Then
                'przeszukiwanie min/max dla numeru klienta
                If IsNumeric(row.Item(11)) And row.Item(11) > 1 Then
                    If row.Item(11) > max Then
                        max = row.Item(11)
                    End If
                    If row.Item(11) < min Then
                        min = row.Item(11)
                    End If
                End If

                'przeszukiwanie min/max numeru lotto
                If IsNumeric(row.Item(4)) And row.Item(4) > 1 Then
                    If row.Item(4) > Lmax Then
                        Lmax = row.Item(4)
                    End If
                    If row.Item(4) < Lmin Then
                        Lmin = row.Item(4)
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub LoadCustomers()
        Dim dtT As New DataTable
        Dim CustomerCode As Integer
        Dim LookupRow As DataRow
        dt.Columns.Add("Klient") 'ID 15
        Select Case ZCP_DB
            Case "ZPL"
                SQLstring = "SELECT CGPCO00F.CONTCP, CGPCO00F.DSCOCP FROM S100A014." & ZCP_DB & "80DAT.CGPCO00F CGPCO00F 
                WHERE CGPCO00F.CONTCP >= '" & min & "' And CGPCO00F.CONTCP <= '" & max & "'"
            Case "ZAN"
                SQLstring = "SELECT CGPCO00F.CONTCP, CGPCO00F.DSCOCP FROM S100A014." & ZCP_DB & "80DAT.CGPCO00F CGPCO00F 
                WHERE Cast(CGPCO00F.CONTCP as int) >= '" & min & "' And Cast(CGPCO00F.CONTCP as INT) <= '" & max & "'"
        End Select
        da = New OdbcDataAdapter(SQLstring, GalileoCon)
        dtT = New DataTable
        da.Fill(dtT)
        For Each r As DataRow In dt.Rows
            If IsNumeric(r.Item(11)) Then
                CustomerCode = r.Item(11)
                Dim fRow = From row In dtT.AsEnumerable()
                           Where row.Field(Of String)(dtT.Columns(0).ColumnName) = CustomerCode
                If fRow.Count > 0 Then
                    LookupRow = fRow.First
                    r.Item("Klient") = Trim(LookupRow.Item(1))
                Else
                    r.Item("Klient") = " "
                End If
            Else
                r.Item("Klient") = " "
            End If
        Next
        dtT.Dispose()
    End Sub
    Private Sub LoadMP()
        Dim dtT As New DataTable
        Dim lotto As Integer
        Dim LookupRow As DataRow
        dt.Columns.Add("MP", GetType(String)) 'ID16
        dt.Columns.Add("Opis_MP", GetType(String)) 'ID17
        SQLstring = "Select PMIMP00F.ORPRPI, PMIMP00F.CDARPI, MGART00F.DSARMA 
                     From " & ZCP_DB & "80DAT.MGART00F MGART00F, " & ZCP_DB & "80DAT.PMIMP00F PMIMP00F 
                     WHERE PMIMP00F.CDARPI = MGART00F.CDARMA And (PMIMP00F.CDARPI Like 'MP%')
                     AND PMIMP00F.ORPRPI >= '" & Lmin & "' And PMIMP00F.ORPRPI <= '" & Lmax & "'"
        da = New OdbcDataAdapter(SQLstring, GalileoCon)
        dtT = New DataTable
        da.Fill(dtT)
        For Each r As DataRow In dt.Rows
            lotto = r.Item(4)
            Dim fRow = From row In dtT.AsEnumerable()
                       Where row.Field(Of String)(dtT.Columns(0).ColumnName) = lotto
            If fRow.Count > 0 Then
                LookupRow = fRow.First
                r.Item("MP") = Trim(LookupRow.Item(1))
                r.Item("Opis_MP") = Trim(LookupRow.Item(2))
            Else
                r.Item("MP") = " "
                r.Item("Opis_MP") = " "
            End If
        Next
        dtT.Dispose()
    End Sub
    Sub LoadEmptyMachines()
        Dim dtT As New DataTable
        Dim maszyna As String
        Dim dNewRow As DataRow
        SQLstring = "Select Trim(ZANAMACC.CDCENLAV), Trim(ZANAMACC.CDMACCHI), Trim(ZANAMACC.DSMACCHI), ZANAMACC.STATO FROM RILTEMPI.ZANAMACC ZANAMACC
                     WHERE ZANAMACC.CDMACCHI LIKE '%' " & SQLstringChoice & ""
        dtT = New DataTable
        da = New OdbcDataAdapter(SQLstring, ZCPCon)
        da.Fill(dtT)
        For Each r As DataRow In dtT.Rows
            maszyna = r.Item(1)
            Dim fRow = From row In dt.AsEnumerable()
                       Where row.Field(Of String)(dt.Columns(1).ColumnName) = maszyna
            If fRow.Count < 1 Then
                dNewRow = dt.NewRow
                With dNewRow
                    .Item(0) = r.Item(0)
                    .Item(1) = r.Item(1)
                    .Item(2) = r.Item(2)
                    .Item(3) = r.Item(3)
                End With
                dt.Rows.Add(dNewRow)
            End If
        Next
    End Sub
    Private Sub FormatDGV()
        For Each col As DataGridViewColumn In DGV.Columns
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        With DGV
            .ColumnHeadersHeight = 25

            .Columns(0).HeaderText = "Wyspa"
            .Columns(0).Width = 50

            .Columns(1).HeaderText = "Nr masz."
            .Columns(1).Width = 40

            .Columns(2).HeaderText = "Maszyna"
            .Columns(2).Width = 100
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns(3).HeaderText = "Status"
            .Columns(3).Width = 35

            .Columns(4).HeaderText = "Lotto"
            .Columns(4).Width = 60

            .Columns(5).HeaderText = "Cykl"
            .Columns(5).Width = 32

            .Columns(6).HeaderText = "Kod"
            .Columns(6).Width = 80
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns(7).HeaderText = "Opis Galileo"
            .Columns(7).Width = 180
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns(8).HeaderText = "Ilość Lotto"
            .Columns(8).Width = 60

            .Columns(9).HeaderText = "Ilość wypr."
            .Columns(9).Width = 60

            .Columns(10).HeaderText = "Ilość NOK"
            .Columns(10).Width = 50

            .Columns(11).HeaderText = "Nr klienta"
            .Columns(11).Width = 75
            .Columns(11).Visible = False

            .Columns(12).HeaderText = "Bolla"
            .Columns(12).Width = 75
            .Columns(12).Visible = False

            .Columns(13).DisplayIndex = 10
            .Columns(13).HeaderText = "% Lotto"
            .Columns(13).Width = 40

            .Columns(14).HeaderText = "% NOK"
            .Columns(14).Width = 35

            .Columns(15).Width = 150 'Klient
            .Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns(16).Width = 50 'MP

            .Columns(17).HeaderText = "Opis MP"
            .Columns(17).Width = 265
            .Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With
    End Sub
    Private Sub OdświeżToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OdświeżToolStripMenuItem.Click
        LoadDGV()
    End Sub
    Private Sub DGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        'Formatowanie ilości w kolumnach: ilość lotto,ilośc wyprod, ilość braków
        If (e.ColumnIndex = 8 Or e.ColumnIndex = 9 Or e.ColumnIndex = 10) AndAlso IsNumeric(e.Value) AndAlso e.Value >= 1000 AndAlso e.Value < 1000000 Then
            e.Value = Format(e.Value, "0 000")
        End If
        If (e.ColumnIndex = 8 Or e.ColumnIndex = 9 Or e.ColumnIndex = 10) AndAlso IsNumeric(e.Value) AndAlso e.Value >= 1000000 Then
            e.Value = Format(e.Value, "0 000 000")
        End If

        'Kolorowanie statusu
        With e.CellStyle
            If (e.ColumnIndex = 3) And IsNumeric(e.Value) Then
                Select Case e.Value
                    Case 1
                        .BackColor = Color.FromArgb(112, 250, 149)
                        .SelectionBackColor = Color.FromArgb(112, 250, 149)
                    Case 2
                        .BackColor = Color.FromArgb(244, 255, 161)
                        .SelectionBackColor = Color.FromArgb(244, 255, 161)
                    Case 4
                        .BackColor = Color.FromArgb(250, 103, 95)
                        .SelectionBackColor = Color.FromArgb(250, 103, 95)
                    Case 8
                        .BackColor = Color.White
                        .SelectionBackColor = Color.White
                End Select
            End If
            If (e.ColumnIndex = 13) And IsNumeric(e.Value) Then
                Select Case e.Value
                    Case 0 To 10
                        .BackColor = Color.FromArgb(220, 255, 219)
                        .SelectionBackColor = Color.FromArgb(220, 255, 219)
                    Case 10 To 25
                        .BackColor = Color.FromArgb(169, 252, 167)
                        .SelectionBackColor = Color.FromArgb(169, 252, 167)
                    Case 25 To 50
                        .BackColor = Color.FromArgb(146, 247, 173)
                        .SelectionBackColor = Color.FromArgb(146, 247, 173)
                    Case 50 To 75
                        .BackColor = Color.FromArgb(112, 250, 149)
                        .SelectionBackColor = Color.FromArgb(112, 250, 149)
                    Case 75 To 105
                        .BackColor = Color.FromArgb(72, 250, 120)
                        .SelectionBackColor = Color.FromArgb(72, 250, 120)
                    Case > 105
                        .BackColor = Color.FromArgb(39, 227, 90)
                        .SelectionBackColor = Color.FromArgb(39, 227, 90)
                End Select
            End If
            If (e.ColumnIndex = 14) And IsNumeric(e.Value) Then
                Select Case e.Value
                    Case 1 To 2
                        .BackColor = Color.FromArgb(252, 252, 230)
                        .SelectionBackColor = Color.FromArgb(252, 252, 230)
                    Case 2 To 3
                        .BackColor = Color.FromArgb(252, 252, 199)
                        .SelectionBackColor = Color.FromArgb(252, 252, 199)
                    Case 3 To 4
                        .BackColor = Color.FromArgb(255, 255, 181)
                        .SelectionBackColor = Color.FromArgb(255, 255, 181)
                    Case 4 To 5
                        .BackColor = Color.FromArgb(252, 252, 154)
                        .SelectionBackColor = Color.FromArgb(252, 252, 154)
                    Case 5 To 6
                        .BackColor = Color.FromArgb(252, 252, 134)
                        .SelectionBackColor = Color.FromArgb(252, 252, 134)
                    Case 6 To 7
                        .BackColor = Color.FromArgb(252, 252, 111)
                        .SelectionBackColor = Color.FromArgb(252, 252, 111)
                    Case 7 To 8
                        .BackColor = Color.FromArgb(252, 252, 86)
                        .SelectionBackColor = Color.FromArgb(252, 252, 86)
                    Case 8 To 9
                        .BackColor = Color.FromArgb(252, 214, 61)
                        .SelectionBackColor = Color.FromArgb(252, 214, 61)
                    Case 9 To 10
                        .BackColor = Color.FromArgb(252, 160, 61)
                        .SelectionBackColor = Color.FromArgb(252, 160, 61)
                    Case 10 To 15
                        .BackColor = Color.FromArgb(252, 99, 61)
                        .SelectionBackColor = Color.FromArgb(252, 99, 61)
                    Case > 15
                        .BackColor = Color.Red
                        .SelectionBackColor = Color.Red
                End Select
            End If
        End With
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        LoadDGV()
    End Sub
    Private Sub DGV_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseDown
        If (e.Button = MouseButtons.Right) Then
            If e.ColumnIndex = -1 = False And e.RowIndex = -1 = False Then
                DGV.CurrentCell = DGV.Item(e.ColumnIndex, e.RowIndex)
                maszyna = DGV.Item(1, e.RowIndex).Value
                stan = DGV.Item(3, e.RowIndex).Value
                lotto = DGV.Item(4, e.RowIndex).Value
                kod = DGV.Item(6, e.RowIndex).Value
                opis = DGV.Item(7, e.RowIndex).Value
                ilosc_lotto = DGV.Item(8, e.RowIndex).Value
                bolla = DGV.Item(12, e.RowIndex).Value
                procenty = DGV.Item(13, e.RowIndex).Value
                klient = DGV.Item(15, e.RowIndex).Value
            End If
            Menu_rozwijane.Show(Cursor.Position)
        End If
    End Sub
    Private Sub DGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            maszyna = DGV.Item(1, e.RowIndex).Value
            stan = DGV.Item(3, e.RowIndex).Value
            lotto = DGV.Item(4, e.RowIndex).Value
            kod = DGV.Item(6, e.RowIndex).Value
            opis = DGV.Item(7, e.RowIndex).Value
            ilosc_lotto = DGV.Item(8, e.RowIndex).Value
            bolla = DGV.Item(12, e.RowIndex).Value
            procenty = DGV.Item(13, e.RowIndex).Value
            klient = DGV.Item(15, e.RowIndex).Value
            Info.ShowDialog()
        End If
    End Sub
    Private Sub Filtrowanie_TextChanged(sender As Object, e As EventArgs) Handles TB_wyspa.TextChanged, TB_nr_masz.TextChanged,
        TB_masz.TextChanged, TB_status.TextChanged, TB_lotto.TextChanged, TB_cykl.TextChanged, TB_kod.TextChanged, TB_opis.TextChanged,
        TB_klient.TextChanged, TB_mp.TextChanged, TB_opis_mp.TextChanged

        Filtruj()

    End Sub
    Private Sub Filtruj()
        Try
            dv = New DataView(dt) With {
            .RowFilter = String.Format("CONVERT(ISNULL(Wyspa, ''),'System.String') like '%{0}%' and CONVERT(ISNULL(Nr_masz, ''),'System.String') like '%{1}%' and CONVERT(ISNULL(Maszyna, ''),'System.String') like '%{2}%' and
            CONVERT(ISNULL(Status, ''),'System.String') like '%{3}%' and CONVERT(ISNULL(Lotto, ''),'System.String') like '%{4}%' and CONVERT(ISNULL(Cykl, ''),'System.String') like '%{5}%' and
            CONVERT(ISNULL(kod, ''),'System.String') like '%{6}%' and CONVERT(ISNULL(opis, ''),'System.String') like '%{7}%' and CONVERT(ISNULL(klient, ''),'System.String') like '%{8}%' and CONVERT(ISNULL(MP, ''),'System.String') like '%{9}%' 
            and CONVERT(ISNULL(Opis_MP, ''),'System.String') like '%{10}%'",
            TB_wyspa.Text, TB_nr_masz.Text, TB_masz.Text,
            TB_status.Text, TB_lotto.Text, TB_cykl.Text, TB_kod.Text, TB_opis.Text,
            TB_klient.Text, TB_mp.Text, TB_opis_mp.Text)
            }

            DGV.DataSource = dv

            If DGVsortcolumn IsNot Nothing Then
                DGV.Sort(DGV.Columns(DGVsortcolumnindex), DGVsortmode)
            End If

            Status4.Visible = True
            Status4.Text = "   Widok filtrowany włączony. Ilość widocznych pozycji: " & DGV.Rows.Count
            BTx.BackColor = Color.OrangeRed

            If TB_wyspa.Text = "" And TB_nr_masz.Text = "" And TB_masz.Text = "" And
               TB_status.Text = "" And TB_lotto.Text = "" And TB_cykl.Text = "" And
               TB_kod.Text = "" And TB_opis.Text = "" And TB_klient.Text = "" And
                TB_mp.Text = "" And TB_opis_mp.Text = "" Then

                DGV.DataSource = dt

                If DGVsortcolumn IsNot Nothing Then
                    DGV.Sort(DGV.Columns(DGVsortcolumnindex), DGVsortmode)
                End If

                Status4.Visible = False
                BTx.BackColor = Color.Empty
            End If

        Catch
        End Try
    End Sub
    Sub GetIslands()
        Dim wyspy As New List(Of String)
        For Each r As DataRow In dt.Rows
            If Not wyspy.Contains(r.Item(0).ToString) Then
                wyspy.Add(r.Item(0).ToString)
            End If
        Next
        wyspy.Sort()

        For Each wsp As String In wyspy
            Dim Btn As New ToolStripButton
            With Btn
                .Text = wsp
                .DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            End With
            AddHandler Btn.Click, AddressOf Btn_Click
            CzasCykluToolStripMenuItem.DropDownItems.Add(Btn)
        Next
    End Sub
    Private Sub Btn_Click(sender As Object, e As EventArgs)
        wwyspa = sender.ToString
        LoadTimes(wwyspa)
    End Sub
    Private Sub WyszukajRysunekToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WyszukajRysunekToolStripMenuItem.Click
        Dim szukaj As String = opis
        Dim srch As String = ""
        If DGV.CurrentRow IsNot Nothing Then
            If szukaj <> "" Then
                szukaj = szukaj.Substring(0, szukaj.IndexOf("_")).ToString
                If szukaj.Contains("/") Then
                    szukaj = szukaj.Substring(0, szukaj.IndexOf("/")).ToString
                End If

                Select Case ZCP_DB
                    Case "ZPL"
                        srch = "search-ms:query=" & szukaj & "&crumb=location:I:\Prodotti Clienti\&"
                    Case "ZAN"
                        srch = "search-ms:query=" & szukaj & "&crumb=location:H:\Prodotti Clienti\&"
                End Select

                Try
                    Process.Start(srch)
                Catch
                    MsgBox("Unable to start search process", vbCritical)
                End Try
            End If
        Else
            MsgBox("Brak danych!")
        End If
    End Sub
    Public Sub EnableDoubleBuffered(ByVal dgv As DataGridView)
        Dim dgvType As Type = dgv.[GetType]()
        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered",
                                                     BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(dgv, True, Nothing)
    End Sub

    Private Sub DGV_Sorted(sender As Object, e As EventArgs) Handles DGV.Sorted
        DGVsortcolumn = DGV.SortedColumn
        DGVsortcolumnindex = DGVsortcolumn.Index
        DGVsortmode = DGV.SortOrder - 1
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Oprogramie.ShowDialog()
    End Sub

    Private Sub NarzędziaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NarzędziaToolStripMenuItem.Click
        Tools.ShowDialog()
    End Sub

    Private Sub WszystkieNarzędziaNaProdukcjiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WszystkieNarzędziaNaProdukcjiToolStripMenuItem.Click
        Narz_na_prod.ShowDialog()
    End Sub

    Private Sub LoadTimes(wwyspa As String)
        Dim dtT As New DataTable
        Dim LookupRow As DataRow
        Dim bolla As String
        Dim ilosc_lotto As Integer
        Dim czas_prod As Single
        Dim wydajnosc As Single
        Dim czas_cyklu As Single
        Dim ilosc_maszyn As Integer
        Dim data_rozpoczecia As DateTime
        Dim data_zakonczenia As DateTime
        For Each r As DataRow In dt.Rows
            If r.Item(0) = wwyspa Then
                ilosc_maszyn += 1
            End If
        Next
        Timer.Stop()
        Status3.Text = "Automatyczne odświeżanie wyłączone"
        Status3.ForeColor = Color.DarkOrange
        If dt.Columns.Count = 18 Then
            dt.Columns.Add("T.Gal", GetType(Single)) 'ID18
            DGV.Columns("T.Gal").Width = 50
            DGV.Columns("T.Gal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dt.Columns.Add("T.Masz", GetType(Single)) 'ID19
            DGV.Columns("T.Masz").Width = 50
            DGV.Columns("T.Masz").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If
        Me.Size = New Size(1448, 640)
        Me.DGV.Size = New Size(1408, 523)
        Me.CenterToScreen()
        Loading.Show()
        SQLstring = "SELECT PCIMP00F.NRBLCI, Cast(PCIMP00F.QORDCI as INT), PCIMP00F.OILMCI, PCIMP00F.OIAMCI, PCIMP00F.EFSMCI FROM AS400.PCIMP00F PCIMP00F  
                     WHERE PCIMP00F.ORPRCI >= '" & Lmin & "' And PCIMP00F.ORPRCI <= '" & Lmax & "'"
        da = New OdbcDataAdapter(SQLstring, ZCPCon)
        dtT = New DataTable
        da.Fill(dtT)
        dtT.Columns.Add("T", GetType(Single))
        For Each r As DataRow In dtT.Rows
            ilosc_lotto = r.Item(1)
            czas_prod = r.Item("OILMCI") / 100
            wydajnosc = r.Item("EFSMCI") / 100
            czas_cyklu = czas_prod * 3600 / ilosc_lotto * (wydajnosc / 100)
            r.Item("T") = Math.Round(czas_cyklu, 2)
        Next
        For Each r As DataRow In dt.Rows
            If r.Item(0) = wwyspa Then
                bolla = r.Item(12)
                Dim fRow = From row In dtT.AsEnumerable()
                           Where row.Field(Of String)(dtT.Columns(0).ColumnName) = bolla
                If fRow.Count > 0 Then
                    LookupRow = fRow.First
                    r.Item("T.Gal") = LookupRow.Item("T")
                End If
            End If
        Next
        'MEDIANA
        Dim i As Integer
        Dim counter As Single
        Dim maszyna As String
        Dim countermaszyny As Integer

        For Each r As DataRow In dt.Rows
            If r.Item(0) = wwyspa Then
                bolla = r.Item(12)
                maszyna = r.Item(1)
                SQLstring = "Select ZCONTTASK.CONTATORE, ZCONTTASK.DATACONT, ZCONTTASK.ORACONT From RILTEMPI.ZCONTTASK ZCONTTASK
                    Where (ZCONTTASK.BOLLA ='" & bolla & "') and (ZCONTTASK.MACCHINA ='" & maszyna & "') and ZCONTTASK.DATACONT='" & Today().ToString("yyyy-MM-dd") & "'
                    ORDER BY ZCONTTASK.CONTATORE DESC
                    FETCH FIRST 51 ROWS ONLY"
                da = New OdbcDataAdapter(SQLstring, ZCPCon)
                dtT = New DataTable
                Dim czas_cykluS(100) As Double
                da.Fill(dtT)
                If dtT.Rows.Count > 0 Then
                    ReDim czas_cykluS(dtT.Rows.Count - 2)

                    For i = 0 To dtT.Rows.Count - 2
                        data_zakonczenia = dtT.Rows(i).Item(1).Add(dtT.Rows(i).Item(2))
                        data_rozpoczecia = dtT.Rows(i + 1).Item(1).Add(dtT.Rows(i + 1).Item(2))
                        czas_cykluS(i) = DateDiff(DateInterval.Second, data_rozpoczecia, data_zakonczenia)
                    Next
                    r.Item("T.Masz") = Mediana(czas_cykluS)
                Else
                    SQLstring = "Select ZCONTTASK.CONTATORE, ZCONTTASK.DATACONT, ZCONTTASK.ORACONT From RILTEMPI.ZCONTTASK ZCONTTASK
                    Where (ZCONTTASK.BOLLA ='" & bolla & "') and (ZCONTTASK.MACCHINA ='" & maszyna & "') and ZCONTTASK.DATACONT='" & DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") & "'
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
                        r.Item("T.Masz") = Mediana(czas_cykluS)
                    End If
                End If

                countermaszyny += 1
                counter = (countermaszyny / ilosc_maszyn) * 100
                If counter > 100 Then
                    counter = 100
                End If
                Loading.PB.Value = counter

            End If

        Next
        TB_wyspa.Text = wwyspa
        Loading.Close()
    End Sub
    Private Sub ZCP_QV_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        StopAPPlog()
    End Sub

    Private Sub ListaNarzędziToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaNarzędziToolStripMenuItem.Click
        ToolsList.Show()
    End Sub

    Private Sub BTx_Click(sender As Object, e As EventArgs) Handles BTx.Click
        For Each bt As Control In Controls
            If bt.GetType Is GetType(TextBox) Then
                bt.Text = Nothing
            End If
        Next
    End Sub

    Private Sub ZaładujPusteMaszynyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZaładujPusteMaszynyToolStripMenuItem.Click
        LoadEmptyMachines()
        MsgBox("Wczytano maszyny bez przypisanego numeru lotto", vbInformation)
    End Sub
    Sub StartAPPlog()
        Try
            'Using sw As New StreamWriter(File.Open(strFile, FileMode.OpenOrCreate))
            'End Using
            Using sw As New StreamWriter(strFile, True)
                sw.WriteLine("Otwarto QV: " & PCuser & " @ " & DateTime.Now)
            End Using
            Using sw As New StreamWriter(strFileOpened, True)
                sw.WriteLine("Otwarto QV: " & PCuser & " @ " & DateTime.Now)
            End Using
        Catch
        End Try
    End Sub
    Sub StopAPPlog()
        Try
            'koniec log
            Using sw As New StreamWriter(strFile, True)
                sw.WriteLine("Zamknięto QV: " & PCuser & " @ " & DateTime.Now)
            End Using

            'kasowanie 
            Dim fileContents = File.ReadAllLines(strFileOpened).ToList
            For i = fileContents.Count - 1 To 0 Step -1
                If fileContents(i).Contains(PCuser) Then
                    fileContents.RemoveAt(i)
                End If
            Next
            File.WriteAllLines(strFileOpened, fileContents.ToArray)
        Catch
        End Try
    End Sub

End Class
