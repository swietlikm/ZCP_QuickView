Imports System.ComponentModel
Imports System.Data.Odbc
Imports System.Reflection
Public Class Narz_na_prod
    Dim dvT As DataView
    Private Sub Narz_na_prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnableDoubleBuffered(DGV_tools_prod)
        LoadToolsOnProd()
        FormatujDGV()
        Status1.Text = "Ilość pozycji: " & DGV_tools_prod.Rows.Count
    End Sub
    Private Sub LoadToolsOnProd()
        SQLstring = "SELECT Trim(ZANAMACC.CDCENLAV), Trim(ZBOLLA.CDMACCHI), Trim(ZANAMACC.DSMACCHI), Cast(PCIMP00F.ORPRCI as INT), Trim(PCIMP00F.CDARCI),
                    Trim(ZUTPCU.POSIZUT), Trim(ZUTENSILI.MARCA), Trim(ZUTENSILI.TIPOUT), Trim(ZUTPCU.CODINSERTOSTD), Trim(ZUTPCU.CODUTFORNITORE),
                    Cast(ZUTPCU.NUMPZPREVISTISTD as INT), Cast(ZUTENSILI.NUMTAGLIENTI as INT), Cast(ZUTENSILI.GIACENZA as INT)

                    FROM AS400.MGART00F MGART00F, AS400.PCIMP00F PCIMP00F, AS400.PMORD00F PMORD00F, RILTEMPI.ZANAMACC ZANAMACC,
                    RILTEMPI.ZBOLLA ZBOLLA, RILTEMPI.ZUTPCU ZUTPCU, RILTEMPI.ZUTENSILI ZUTENSILI
                    WHERE ZBOLLA.NRTASK = PCIMP00F.NRBLCI AND ZANAMACC.CDMACCHI = ZBOLLA.CDMACCHI AND
                    PCIMP00F.CDARCI = PMORD00F.CDARPO AND PCIMP00F.ORPRCI = PMORD00F.ORPRPO AND MGART00F.CDARMA = PCIMP00F.CDARCI AND
                    PCIMP00F.CDARCI = ZUTPCU.ARTICOLO and ZUTPCU.CICLO = PMORD00F.CDCIPO and ZUTPCU.FASE = PCIMP00F.CDFACI AND
                    ZUTPCU.CODUTFORNITORE = ZUTENSILI.CODUTFORNITORE and ZBOLLA.NRTASK=ZUTPCU.BOLLA
                    ORDER BY ZUTPCU.CODINSERTOSTD"
        da = New OdbcDataAdapter(SQLstring, ZCPCon)
        dtT = New DataTable
        da.Fill(dtT)
        dtT.Columns(0).ColumnName = "Wyspa"
        dtT.Columns(1).ColumnName = "Nr_masz"
        dtT.Columns(2).ColumnName = "Maszyna"
        dtT.Columns(3).ColumnName = "Lotto"
        dtT.Columns(4).ColumnName = "KodZP"
        dtT.Columns(5).ColumnName = "Pozycja"
        dtT.Columns(6).ColumnName = "Producent"
        dtT.Columns(7).ColumnName = "Typ"
        dtT.Columns(8).ColumnName = "Kod_narzedzia"
        dtT.Columns(9).ColumnName = "Barcode"
        dtT.Columns(10).ColumnName = "Wytrzymalosc"
        dtT.Columns(11).ColumnName = "Il_kraw"
        dtT.Columns(12).ColumnName = "Stan_mag"
        DGV_tools_prod.DataSource = dtT
    End Sub
    Private Sub FormatujDGV()
        For Each col As DataGridViewColumn In DGV_tools_prod.Columns
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        With DGV_tools_prod
            .ColumnHeadersHeight = 25

            .Columns(0).HeaderText = "Wyspa"
            .Columns(0).Width = 50

            .Columns(1).HeaderText = "Nr masz."
            .Columns(1).Width = 40

            .Columns(2).HeaderText = "Maszyna"
            .Columns(2).Width = 100
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns(3).HeaderText = "Lotto"
            .Columns(3).Width = 70

            .Columns(4).HeaderText = "Kod"
            .Columns(4).Width = 80

            .Columns(5).HeaderText = "Pozycja"
            .Columns(5).Width = 50

            .Columns(6).HeaderText = "Producent"
            .Columns(6).Width = 100

            .Columns(7).HeaderText = "Typ"
            .Columns(7).Width = 90

            .Columns(8).HeaderText = "Kod narzędzia"
            .Columns(8).Width = 220

            .Columns(9).HeaderText = "Barcode"
            .Columns(9).Width = 190

            .Columns(10).HeaderText = "Wytrzymałość"
            .Columns(10).Width = 75

            .Columns(11).HeaderText = "Il. kraw."
            .Columns(11).Width = 40

            .Columns(12).HeaderText = "Stan MAG"
            .Columns(12).Width = 40
        End With

    End Sub
    Private Sub F_wyspa_TextChanged(sender As Object, e As EventArgs) Handles F_wyspa.TextChanged, F_wyspa.TextChanged, F_nr_maszyny.TextChanged, F_maszyna.TextChanged,
            F_lotto.TextChanged, F_kod_zp.TextChanged, F_lotto.TextChanged, F_kod_zp.TextChanged,
            F_pozycja.TextChanged, F_producent.TextChanged, F_typ.TextChanged, F_kod_narzedzia.TextChanged,
            F_barcode.TextChanged, F_mag.TextChanged
        Filtruj()
    End Sub
    Private Sub Filtruj()
        dvT = New DataView(dtT) With {
        .RowFilter = String.Format("Convert(Wyspa,'System.String') like '%{0}%' and Convert(Nr_masz,'System.String') like '%{1}%' and Convert(Maszyna,'System.String') like '%{2}%'
        and Convert(Lotto,'System.String') like '%{3}%' and Convert(KodZP,'System.String') like '%{4}%'
        and Convert(Pozycja,'System.String') like '%{5}%' and Convert(Producent,'System.String') like '%{6}%'
        and Convert(Typ,'System.String') like '%{7}%' and Convert(Kod_narzedzia,'System.String') like '%{8}%'
        and Convert(Barcode,'System.String') like '%{9}%' and Convert(Stan_mag,'System.String') like '{10}%'",
            F_wyspa.Text.ToString, F_nr_maszyny.Text.ToString, F_maszyna.Text.ToString,
            F_lotto.Text.ToString, F_kod_zp.Text.ToString,
            F_pozycja.Text.ToString, F_producent.Text.ToString,
            F_typ.Text.ToString, F_kod_narzedzia.Text.ToString,
            F_barcode.Text.ToString, F_mag.Text.ToString)
}

        DGV_tools_prod.DataSource = dvT
        Status1.Text = "Widok filtrowany włączony. Ilość widocznych pozycji: " & DGV_tools_prod.Rows.Count

        If F_wyspa.Text.ToString = "" And F_nr_maszyny.Text.ToString = "" And F_maszyna.Text.ToString = "" And
        F_lotto.Text.ToString = "" And F_kod_zp.Text.ToString = "" And
        F_pozycja.Text.ToString = "" And F_producent.Text.ToString = "" And
        F_typ.Text.ToString = "" And F_kod_narzedzia.Text.ToString = "" And
        F_barcode.Text.ToString = "" And F_mag.Text.ToString = "" Then

            DGV_tools_prod.DataSource = dtT
            Status1.Text = "Ilość pozycji: " & DGV_tools_prod.Rows.Count

        End If
    End Sub
    Private Sub DGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV_tools_prod.CellFormatting
        'Formatowanie ilości w kolumnach: ilość lotto,ilośc wyprod, ilość braków
        If (e.ColumnIndex = 10) AndAlso IsNumeric(e.Value) AndAlso e.Value >= 1000 AndAlso e.Value < 1000000 Then
            e.Value = Format(e.Value, "0 000")
        End If
        If (e.ColumnIndex = 10) AndAlso IsNumeric(e.Value) AndAlso e.Value >= 1000000 Then
            e.Value = Format(e.Value, "0 000 000")
        End If
    End Sub
    Public Sub EnableDoubleBuffered(ByVal dgv As DataGridView)
        Dim dgvType As Type = dgv.[GetType]()
        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered",
                                                     BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(dgv, True, Nothing)
    End Sub
    Private Sub Narz_na_prod_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class