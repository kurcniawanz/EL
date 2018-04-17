Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class DASHBOARD

    Private Sub DASHBOARD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                seri.ChartType = SeriesChartType.StackedColumn
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
                                    + " SELECT b.NOFAK, sum(b.TOTHPP+(b.ONGKIR*b.QTY))AS TOTMODAL FROM TB_MUTASI b GROUP BY b.NOFAK) bb on bb.NOFAK = a.NOFAK", konek)
            rddd = cmd.ExecuteReader
            While rddd.Read()
                .Series(0).Points.AddXY(CDate(rddd("TGL")).ToString("dd-MMM-yyyy"), FormatNumber(CDbl(rddd("OMSET")), 0))
                .Series(1).Points.AddXY(CDate(rddd("TGL")).ToString("dd-MMM-yyyy"), FormatNumber(CDbl(rddd("MODAL")), 0))
            End While
            konek.Close()
        End With
    End Sub


End Class