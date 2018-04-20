Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class DASHBOARD

    Sub chartt1()
        With Chart1 '=Nama Group
            Dim data() As String = {"Omset", "Modal"}
            .Series.Clear()
            For i As Integer = 0 To data.Length - 1
                'nama series
                .Series.Add(data(i))
            Next
            'Format Series/Chart
            .ChartAreas(0).AxisX.Interval = 1
            .ChartAreas(0).AxisX.IsStartedFromZero = True
            For Each seri As Series In .Series
                'tipe Chart
                seri.ChartType = SeriesChartType.Column
                'tipe Nilai X
                seri.XValueType = ChartValueType.String
                'tipe Nilai Y
                seri.YValueType = ChartValueType.Double
            Next
            'Isi Nilai Series/Chart (X,Y)
            koneksi_db()
            Dim rddd As FbDataReader
            Dim cmd = New FbCommand(" SELECT a.NOFAK, a.TGL,  a.GRANDTOTAL as OMSET, bb.TOTMODAL*-1 AS MODAL FROM TB_JUAL a " _
                                    + " INNER JOIN ( " _
                                    + " SELECT b.NOFAK, sum(b.TOTHPP+(b.ONGKIR*b.QTY))AS TOTMODAL FROM TB_MUTASI b GROUP BY b.NOFAK) bb on bb.NOFAK = a.NOFAK " _
                                    + " WHERE EXTRACT(MONTH FROM a.TGL) = EXTRACT(MONTH FROM cast('NOW' as date)) AND  EXTRACT(YEAR FROM a.TGL) = EXTRACT(YEAR FROM cast('NOW' as date))", konek)
            rddd = cmd.ExecuteReader
            While rddd.Read()
                .Series(0).Points.AddXY(CDate(rddd("TGL")).ToString("dd-MMM-yyyy"), FormatNumber(CDbl(rddd("OMSET")), 0))
                .Series(1).Points.AddXY(CDate(rddd("TGL")).ToString("dd-MMM-yyyy"), FormatNumber(CDbl(rddd("MODAL")), 0))
            End While
            konek.Close()
        End With
    End Sub

    Sub chartt2()
        With Chart2
            Dim data() As String = {"Barang"}
            .Series.Clear()
            For i As Integer = 0 To data.Length - 1
                'nama series
                .Series.Add(data(i))
            Next
            'Format Series/Chart
            .ChartAreas(0).AxisX.Interval = 1
            .ChartAreas(0).AxisX.IsStartedFromZero = True
            For Each seri As Series In .Series
                'tipe Chart
                seri.ChartType = SeriesChartType.Column
                'tipe Nilai X
                seri.XValueType = ChartValueType.String
                'tipe Nilai Y
                seri.YValueType = ChartValueType.Double
            Next
            'Isi Nilai Series/Chart (X,Y)
            koneksi_db()
            Dim rddd As FbDataReader
            Dim cmd = New FbCommand(" SELECT b.NAMA, sum(a.QTY) AS QTY FROM TB_MUTASI a " _
                                    + " INNER JOIN TB_BARANG b ON b.ID = a.IDBARANG " _
                                    + " WHERE a.TGL = '" & CDate(tgl.Text) & "' GROUP BY b.NAMA", konek)
            rddd = cmd.ExecuteReader
            While rddd.Read()
                .Series(0).Points.AddXY(rddd("NAMA").ToString, FormatNumber(CDbl(rddd("QTY")), 0))
            End While
            konek.Close()
        End With
    End Sub

    Sub chartt3()
        With Chart3
            Dim data() As String = {"UserID"}
            .Series.Clear()
            For i As Integer = 0 To data.Length - 1
                'nama series
                .Series.Add(data(i))
            Next
            'Format Series/Chart
            .ChartAreas(0).AxisX.Interval = 1
            .ChartAreas(0).AxisX.IsStartedFromZero = True
            For Each seri As Series In .Series
                'tipe Chart
                seri.ChartType = SeriesChartType.Column
                'tipe Nilai X
                seri.XValueType = ChartValueType.String
                'tipe Nilai Y
                seri.YValueType = ChartValueType.Double
            Next
            'Isi Nilai Series/Chart (X,Y)
            koneksi_db()
            Dim rddd As FbDataReader
            Dim cmd = New FbCommand(" SELECT a.CREATE_USERID,sum( a.GRANDTOTAL) as OMSET FROM TB_JUAL a  " _
                                    + " INNER JOIN ( SELECT b.NOFAK, sum(b.TOTHPP+(b.ONGKIR*b.QTY))AS TOTMODAL FROM TB_MUTASI b GROUP BY b.NOFAK) bb on bb.NOFAK = a.NOFAK  " _
                                    + " WHERE a.TGL = '" & CDate(tgl.Text) & "' GROUP BY a.CREATE_USERID", konek)
            rddd = cmd.ExecuteReader
            While rddd.Read()
                .Series(0).Points.AddXY(rddd("CREATE_USERID").ToString, FormatNumber(CDbl(rddd("OMSET")), 0))
            End While
            konek.Close()
        End With
    End Sub

    Sub hitung()
        Dim omset, modal, bruto, cashout, cashin, netto, jual, rejual, beli, rebeli As Double
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand(" SELECT a.NOFAK, a.TGL,  a.GRANDTOTAL as OMSET, bb.TOTMODAL*-1 AS MODAL FROM TB_JUAL a " _
                                + " INNER JOIN ( " _
                                + " SELECT b.NOFAK, sum(b.TOTHPP+(b.ONGKIR*b.QTY))AS TOTMODAL FROM TB_MUTASI b GROUP BY b.NOFAK) bb on bb.NOFAK = a.NOFAK " _
                                + " WHERE a.TGL = '" & CDate(tgl.Text) & "'", konek)
        rddd = cmd.ExecuteReader
        If rddd.Read() Then
            omset = CDbl(rddd("OMSET"))
            modal = CDbl(rddd("MODAL"))
        End If
        konek.Close()

        koneksi_db()
        Dim rd As FbDataReader
        Dim cm = New FbCommand(" SELECT sum(z.REJUAL)AS REJUAL, sum(z.BELI)AS BELI, sum(z.REBELI)AS REBELI, sum(z.JUAL)AS JUAL FROM ( " _
                                + " SELECT 0 as REJUAL,0 AS BELI, 0 AS REBELI, sum(a.GRANDTOTAL)AS JUAL FROM TB_JUAL a WHERE a.TGL = '" & CDate(tgl.Text) & "' union " _
                                + " SELECT sum(a.GRANDTOTAL) as REJUAL,0 AS BELI, 0 AS REBELI, 0 AS JUAL FROM TB_REJUAL a WHERE a.TGL = '" & CDate(tgl.Text) & "' union " _
                                + " SELECT 0 as REJUAL,sum(a.GRANDTOTAL) AS BELI, 0 AS REBELI, 0 AS JUAL FROM TB_BELI a WHERE a.TGL = '" & CDate(tgl.Text) & "' union " _
                                + " SELECT 0 as REJUAL,0 AS BELI, sum(a.GRANDTOTAL) AS REBELI, 0 AS JUAL FROM TB_REBELI a WHERE a.TGL = '" & CDate(tgl.Text) & "' )z", konek)
        rd = cm.ExecuteReader
        If rd.Read() Then
            jual = CDbl(rd("JUAL"))
            rejual = CDbl(rd("REJUAL"))
            beli = CDbl(rd("BELI"))
            rebeli = CDbl(rd("REBELI"))
        End If
        konek.Close()

        bruto = omset - modal
        cashout = beli + rejual
        cashin = jual + rebeli
        netto = cashin - cashout
        txtomset.Text = FormatNumber(omset, 0)
        txtmodal.Text = FormatNumber(modal, 0)
        txtbruto.Text = FormatNumber(bruto, 0)
        txtcashout.Text = FormatNumber(cashout, 0)
        txtcasshin.Text = FormatNumber(cashin, 0)
        txtnetto.Text = FormatNumber(netto, 0)
    End Sub


    Sub chartt4()
        With Chart4 '=Nama Group
            Dim data() As String = {"Omset", "Modal"}
            .Series.Clear()
            For i As Integer = 0 To data.Length - 1
                'nama series
                .Series.Add(data(i))
            Next
            'Format Series/Chart
            .ChartAreas(0).AxisX.Interval = 1
            .ChartAreas(0).AxisX.IsStartedFromZero = True
            For Each seri As Series In .Series
                'tipe Chart
                seri.ChartType = SeriesChartType.Column
                'tipe Nilai X
                seri.XValueType = ChartValueType.String
                'tipe Nilai Y
                seri.YValueType = ChartValueType.Double
            Next
            'Isi Nilai Series/Chart (X,Y)
            koneksi_db()
            Dim rddd As FbDataReader
            Dim cmd = New FbCommand("       SELECT EXTRACT(MONTH FROM a.TGL) AS TGL, sum(a.GRANDTOTAL) as OMSET, sum(bb.TOTMODAL*-1) AS MODAL FROM TB_JUAL a " _
                                        + " INNER JOIN ( " _
                                        + " SELECT b.NOFAK, sum(b.TOTHPP+(b.ONGKIR*b.QTY))AS TOTMODAL FROM TB_MUTASI b GROUP BY b.NOFAK) bb on bb.NOFAK = a.NOFAK " _
                                        + " WHERE EXTRACT(YEAR FROM a.TGL) = EXTRACT(YEAR FROM cast('NOW' as date)) " _
                                        + " GROUP BY EXTRACT(MONTH FROM a.TGL)", konek)
            rddd = cmd.ExecuteReader
            While rddd.Read()
                .Series(0).Points.AddXY(call_bulan(CDbl(rddd("TGL"))), FormatNumber(CDbl(rddd("OMSET")), 0))
                .Series(1).Points.AddXY(call_bulan(CDbl(rddd("TGL"))), FormatNumber(CDbl(rddd("MODAL")), 0))
            End While
            konek.Close()
        End With
    End Sub

    Sub chartt5()
        With Chart5
            Dim data() As String = {"Barang"}
            .Series.Clear()
            For i As Integer = 0 To data.Length - 1
                'nama series
                .Series.Add(data(i))
            Next
            'Format Series/Chart
            .ChartAreas(0).AxisX.Interval = 1
            .ChartAreas(0).AxisX.IsStartedFromZero = True
            For Each seri As Series In .Series
                'tipe Chart
                seri.ChartType = SeriesChartType.Column
                'tipe Nilai X
                seri.XValueType = ChartValueType.String
                'tipe Nilai Y
                seri.YValueType = ChartValueType.Double
            Next
            'Isi Nilai Series/Chart (X,Y)
            koneksi_db()
            Dim rddd As FbDataReader
            Dim cmd = New FbCommand(" SELECT b.NAMA, sum(a.QTY) AS QTY FROM TB_MUTASI a " _
                                    + " INNER JOIN TB_BARANG b ON b.ID = a.IDBARANG " _
                                    + " WHERE EXTRACT(YEAR FROM a.TGL) = EXTRACT(YEAR FROM cast('NOW' as date)) AND EXTRACT(MONTH FROM a.TGL) ='" & txtbulan.SelectedValue & "' GROUP BY b.NAMA", konek)
            rddd = cmd.ExecuteReader
            While rddd.Read()
                .Series(0).Points.AddXY(rddd("NAMA").ToString, FormatNumber(CDbl(rddd("QTY")), 0))
            End While
            konek.Close()
        End With
    End Sub

    Sub chartt6()
        With Chart6
            Dim data() As String = {"UserID"}
            .Series.Clear()
            For i As Integer = 0 To data.Length - 1
                'nama series
                .Series.Add(data(i))
            Next
            'Format Series/Chart
            .ChartAreas(0).AxisX.Interval = 1
            .ChartAreas(0).AxisX.IsStartedFromZero = True
            For Each seri As Series In .Series
                'tipe Chart
                seri.ChartType = SeriesChartType.Column
                'tipe Nilai X
                seri.XValueType = ChartValueType.String
                'tipe Nilai Y
                seri.YValueType = ChartValueType.Double
            Next
            'Isi Nilai Series/Chart (X,Y)
            koneksi_db()
            Dim rddd As FbDataReader
            Dim cmd = New FbCommand(" SELECT a.CREATE_USERID,sum( a.GRANDTOTAL) as OMSET FROM TB_JUAL a  " _
                                    + " INNER JOIN ( SELECT b.NOFAK, sum(b.TOTHPP+(b.ONGKIR*b.QTY))AS TOTMODAL FROM TB_MUTASI b GROUP BY b.NOFAK) bb on bb.NOFAK = a.NOFAK  " _
                                    + " WHERE EXTRACT(YEAR FROM a.TGL) = EXTRACT(YEAR FROM cast('NOW' as date)) AND EXTRACT(MONTH FROM a.TGL) ='" & txtbulan.SelectedValue & "' GROUP BY a.CREATE_USERID", konek)
            rddd = cmd.ExecuteReader
            While rddd.Read()
                .Series(0).Points.AddXY(rddd("CREATE_USERID").ToString, FormatNumber(CDbl(rddd("OMSET")), 0))
            End While
            konek.Close()
        End With
    End Sub

    Sub hitung2()
        Dim omset, modal, bruto, cashout, cashin, netto, jual, rejual, beli, rebeli As Double
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand(" SELECT a.NOFAK, a.TGL,  a.GRANDTOTAL as OMSET, bb.TOTMODAL*-1 AS MODAL FROM TB_JUAL a " _
                                + " INNER JOIN ( " _
                                + " SELECT b.NOFAK, sum(b.TOTHPP+(b.ONGKIR*b.QTY))AS TOTMODAL FROM TB_MUTASI b GROUP BY b.NOFAK) bb on bb.NOFAK = a.NOFAK " _
                                + " WHERE EXTRACT(YEAR FROM a.TGL) = EXTRACT(YEAR FROM cast('NOW' as date)) AND EXTRACT(MONTH FROM a.TGL) ='" & txtbulan.SelectedValue & "'", konek)
        rddd = cmd.ExecuteReader
        If rddd.Read() Then
            omset = CDbl(rddd("OMSET"))
            modal = CDbl(rddd("MODAL"))
        End If
        konek.Close()

        koneksi_db()
        Dim rd As FbDataReader
        Dim cm = New FbCommand(" SELECT sum(z.REJUAL)AS REJUAL, sum(z.BELI)AS BELI, sum(z.REBELI)AS REBELI, sum(z.JUAL)AS JUAL FROM ( " _
                                + " SELECT 0 as REJUAL,0 AS BELI, 0 AS REBELI, sum(a.GRANDTOTAL)AS JUAL FROM TB_JUAL a WHERE EXTRACT(YEAR FROM a.TGL) = EXTRACT(YEAR FROM cast('NOW' as date)) AND EXTRACT(MONTH FROM a.TGL) ='" & txtbulan.SelectedValue & "' union " _
                                + " SELECT sum(a.GRANDTOTAL) as REJUAL,0 AS BELI, 0 AS REBELI, 0 AS JUAL FROM TB_REJUAL a WHERE EXTRACT(YEAR FROM a.TGL) = EXTRACT(YEAR FROM cast('NOW' as date)) AND EXTRACT(MONTH FROM a.TGL) ='" & txtbulan.SelectedValue & "' union " _
                                + " SELECT 0 as REJUAL,sum(a.GRANDTOTAL) AS BELI, 0 AS REBELI, 0 AS JUAL FROM TB_BELI a WHERE EXTRACT(YEAR FROM a.TGL) = EXTRACT(YEAR FROM cast('NOW' as date)) AND EXTRACT(MONTH FROM a.TGL) ='" & txtbulan.SelectedValue & "' union " _
                                + " SELECT 0 as REJUAL,0 AS BELI, sum(a.GRANDTOTAL) AS REBELI, 0 AS JUAL FROM TB_REBELI a WHERE EXTRACT(YEAR FROM a.TGL) = EXTRACT(YEAR FROM cast('NOW' as date)) AND EXTRACT(MONTH FROM a.TGL) ='" & txtbulan.SelectedValue & "' )z", konek)
        rd = cm.ExecuteReader
        If rd.Read() Then
            jual = CDbl(rd("JUAL"))
            rejual = CDbl(rd("REJUAL"))
            beli = CDbl(rd("BELI"))
            rebeli = CDbl(rd("REBELI"))
        End If
        konek.Close()

        bruto = omset - modal
        cashout = beli + rejual
        cashin = jual + rebeli
        netto = cashin - cashout
        txtomset2.Text = FormatNumber(omset, 0)
        txtmodal2.Text = FormatNumber(modal, 0)
        txtbruto2.Text = FormatNumber(bruto, 0)
        txtcashout2.Text = FormatNumber(cashout, 0)
        txtchasin2.Text = FormatNumber(cashin, 0)
        txtnetto2.Text = FormatNumber(netto, 0)
    End Sub

    Sub chartt7()
        With Chart7 '=Nama Group
            Dim data() As String = {"Omset", "Modal"}
            .Series.Clear()
            For i As Integer = 0 To data.Length - 1
                'nama series
                .Series.Add(data(i))
            Next
            'Format Series/Chart
            .ChartAreas(0).AxisX.Interval = 1
            .ChartAreas(0).AxisX.IsStartedFromZero = True
            For Each seri As Series In .Series
                'tipe Chart
                seri.ChartType = SeriesChartType.Column
                'tipe Nilai X
                seri.XValueType = ChartValueType.String
                'tipe Nilai Y
                seri.YValueType = ChartValueType.Double
            Next
            'Isi Nilai Series/Chart (X,Y)
            koneksi_db()
            Dim rddd As FbDataReader
            Dim cmd = New FbCommand("       SELECT EXTRACT(YEAR FROM a.TGL) AS TGL, sum(a.GRANDTOTAL) as OMSET, sum(bb.TOTMODAL*-1) AS MODAL FROM TB_JUAL a " _
                                        + " INNER JOIN ( " _
                                        + " SELECT b.NOFAK, sum(b.TOTHPP+(b.ONGKIR*b.QTY))AS TOTMODAL FROM TB_MUTASI b GROUP BY b.NOFAK) bb on bb.NOFAK = a.NOFAK " _
                                        + " GROUP BY EXTRACT(YEAR FROM a.TGL)", konek)
            rddd = cmd.ExecuteReader
            While rddd.Read()
                .Series(0).Points.AddXY(rddd("TGL").ToString, FormatNumber(CDbl(rddd("OMSET")), 0))
                .Series(1).Points.AddXY(rddd("TGL").ToString, FormatNumber(CDbl(rddd("MODAL")), 0))
            End While
            konek.Close()
        End With
    End Sub

    Sub chartt8()
        With Chart8
            Dim data() As String = {"Barang"}
            .Series.Clear()
            For i As Integer = 0 To data.Length - 1
                'nama series
                .Series.Add(data(i))
            Next
            'Format Series/Chart
            .ChartAreas(0).AxisX.Interval = 1
            .ChartAreas(0).AxisX.IsStartedFromZero = True
            For Each seri As Series In .Series
                'tipe Chart
                seri.ChartType = SeriesChartType.Column
                'tipe Nilai X
                seri.XValueType = ChartValueType.String
                'tipe Nilai Y
                seri.YValueType = ChartValueType.Double
            Next
            'Isi Nilai Series/Chart (X,Y)
            koneksi_db()
            Dim rddd As FbDataReader
            Dim cmd = New FbCommand(" SELECT b.NAMA, sum(a.QTY) AS QTY FROM TB_MUTASI a " _
                                    + " INNER JOIN TB_BARANG b ON b.ID = a.IDBARANG " _
                                    + " WHERE EXTRACT(YEAR FROM a.TGL) ='" & txttahun.SelectedValue & "' GROUP BY b.NAMA", konek)
            rddd = cmd.ExecuteReader
            While rddd.Read()
                .Series(0).Points.AddXY(rddd("NAMA").ToString, FormatNumber(CDbl(rddd("QTY")), 0))
            End While
            konek.Close()
        End With
    End Sub

    Sub chartt9()
        With Chart9
            Dim data() As String = {"UserID"}
            .Series.Clear()
            For i As Integer = 0 To data.Length - 1
                'nama series
                .Series.Add(data(i))
            Next
            'Format Series/Chart
            .ChartAreas(0).AxisX.Interval = 1
            .ChartAreas(0).AxisX.IsStartedFromZero = True
            For Each seri As Series In .Series
                'tipe Chart
                seri.ChartType = SeriesChartType.Column
                'tipe Nilai X
                seri.XValueType = ChartValueType.String
                'tipe Nilai Y
                seri.YValueType = ChartValueType.Double
            Next
            'Isi Nilai Series/Chart (X,Y)
            koneksi_db()
            Dim rddd As FbDataReader
            Dim cmd = New FbCommand(" SELECT a.CREATE_USERID,sum( a.GRANDTOTAL) as OMSET FROM TB_JUAL a  " _
                                    + " INNER JOIN ( SELECT b.NOFAK, sum(b.TOTHPP+(b.ONGKIR*b.QTY))AS TOTMODAL FROM TB_MUTASI b GROUP BY b.NOFAK) bb on bb.NOFAK = a.NOFAK  " _
                                    + " WHERE EXTRACT(YEAR FROM a.TGL) ='" & txttahun.SelectedValue & "' GROUP BY a.CREATE_USERID", konek)
            rddd = cmd.ExecuteReader
            While rddd.Read()
                .Series(0).Points.AddXY(rddd("CREATE_USERID").ToString, FormatNumber(CDbl(rddd("OMSET")), 0))
            End While
            konek.Close()
        End With
    End Sub

    Sub hitung3()
        Dim omset, modal, bruto, cashout, cashin, netto, jual, rejual, beli, rebeli As Double
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand(" SELECT a.NOFAK, a.TGL,  a.GRANDTOTAL as OMSET, bb.TOTMODAL*-1 AS MODAL FROM TB_JUAL a " _
                                + " INNER JOIN ( " _
                                + " SELECT b.NOFAK, sum(b.TOTHPP+(b.ONGKIR*b.QTY))AS TOTMODAL FROM TB_MUTASI b GROUP BY b.NOFAK) bb on bb.NOFAK = a.NOFAK " _
                                + " WHERE EXTRACT(YEAR FROM a.TGL) ='" & txttahun.SelectedValue & "'", konek)
        rddd = cmd.ExecuteReader
        If rddd.Read() Then
            omset = CDbl(rddd("OMSET"))
            modal = CDbl(rddd("MODAL"))
        End If
        konek.Close()

        koneksi_db()
        Dim rd As FbDataReader
        Dim cm = New FbCommand(" SELECT sum(z.REJUAL)AS REJUAL, sum(z.BELI)AS BELI, sum(z.REBELI)AS REBELI, sum(z.JUAL)AS JUAL FROM ( " _
                                + " SELECT 0 as REJUAL,0 AS BELI, 0 AS REBELI, sum(a.GRANDTOTAL)AS JUAL FROM TB_JUAL a WHERE EXTRACT(YEAR FROM a.TGL) ='" & txttahun.SelectedValue & "' union " _
                                + " SELECT sum(a.GRANDTOTAL) as REJUAL,0 AS BELI, 0 AS REBELI, 0 AS JUAL FROM TB_REJUAL a WHERE EXTRACT(YEAR FROM a.TGL) ='" & txttahun.SelectedValue & "' union " _
                                + " SELECT 0 as REJUAL,sum(a.GRANDTOTAL) AS BELI, 0 AS REBELI, 0 AS JUAL FROM TB_BELI a WHERE EXTRACT(YEAR FROM a.TGL) ='" & txttahun.SelectedValue & "' union " _
                                + " SELECT 0 as REJUAL,0 AS BELI, sum(a.GRANDTOTAL) AS REBELI, 0 AS JUAL FROM TB_REBELI a WHERE EXTRACT(YEAR FROM a.TGL) ='" & txttahun.SelectedValue & "' )z", konek)
        rd = cm.ExecuteReader
        If rd.Read() Then
            jual = CDbl(rd("JUAL"))
            rejual = CDbl(rd("REJUAL"))
            beli = CDbl(rd("BELI"))
            rebeli = CDbl(rd("REBELI"))
        End If
        konek.Close()

        bruto = omset - modal
        cashout = beli + rejual
        cashin = jual + rebeli
        netto = cashin - cashout
        txtomset3.Text = FormatNumber(omset, 0)
        txtmodal3.Text = FormatNumber(modal, 0)
        txtbruto3.Text = FormatNumber(bruto, 0)
        txtcashout3.Text = FormatNumber(cashout, 0)
        txtcashin3.Text = FormatNumber(cashin, 0)
        txtnetto3.Text = FormatNumber(netto, 0)
    End Sub

    Private Sub DASHBOARD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tgl.Value = Today
        chartt1()
        chartt2()
        chartt3()
        hitung()
        '---------------------------------------------------
        bulan()
        chartt4()
        chartt5()
        chartt6()
        hitung2()
        '-------------------------------------------------
        tahun()
        chartt7()
        chartt8()
        chartt9()
        hitung3()




        Chart1.Visible = True
        Chart2.Visible = False
        Chart3.Visible = False

        Chart4.Visible = True
        Chart5.Visible = False
        Chart6.Visible = False
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Chart1.Visible = True
        Chart2.Visible = False
        Chart3.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Chart1.Visible = False
        Chart2.Visible = True
        Chart3.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Chart1.Visible = False
        Chart2.Visible = False
        Chart3.Visible = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        chartt1()
        chartt2()
        chartt3()
        hitung()

    End Sub

    Sub bulan()
        txtbulan.DisplayMember = "Text"
        txtbulan.ValueMember = "Value"
        Dim data As New DataTable
        data.Columns.Add("Text", GetType(String))
        data.Columns.Add("Value", GetType(Integer))
        data.Rows.Add("Januari", 1)
        data.Rows.Add("Februari", 2)
        data.Rows.Add("Maret", 3)
        data.Rows.Add("April", 4)
        data.Rows.Add("Mei", 5)
        data.Rows.Add("Juni", 6)
        data.Rows.Add("Juli", 7)
        data.Rows.Add("Agustus", 8)
        data.Rows.Add("September", 9)
        data.Rows.Add("Oktober", 10)
        data.Rows.Add("November", 11)
        data.Rows.Add("Desember", 12)
        txtbulan.DataSource = data
        txtbulan.SelectedValue = CDbl(Today.Month)
    End Sub


    Sub tahun()
        txttahun.DisplayMember = "Text"
        txttahun.ValueMember = "Value"
        Dim data As New DataTable
        data.Columns.Add("Text", GetType(String))
        data.Columns.Add("Value", GetType(Integer))
        data.Rows.Add("2018", 2018)
        data.Rows.Add("2019", 2019)
        data.Rows.Add("2020", 2020)
        data.Rows.Add("2021", 2021)
        data.Rows.Add("2022", 2022)
        data.Rows.Add("2023", 2023)
        data.Rows.Add("2024", 2024)
        data.Rows.Add("2025", 2025)
        data.Rows.Add("2026", 2026)
        data.Rows.Add("2027", 2027)
        data.Rows.Add("2028", 2028)
        data.Rows.Add("2029", 2029)
        txttahun.DataSource = data
        txttahun.SelectedValue = CDbl(Today.Year)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Chart4.Visible = False
        Chart5.Visible = True
        Chart6.Visible = False
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Chart4.Visible = True
        Chart5.Visible = False
        Chart6.Visible = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Chart4.Visible = False
        Chart5.Visible = False
        Chart6.Visible = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        chartt4()
        chartt5()
        chartt6()
        hitung2()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Chart7.Visible = True
        Chart8.Visible = False
        Chart9.Visible = False
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Chart7.Visible = False
        Chart8.Visible = True
        Chart9.Visible = False
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Chart7.Visible = False
        Chart8.Visible = False
        Chart9.Visible = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        chartt7()
        chartt8()
        chartt9()
        hitung3()
    End Sub
End Class