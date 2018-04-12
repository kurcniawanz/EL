Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class DASHBOARD

    Private Sub DASHBOARD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With Chart1 '=Nama Group
            Dim namaMHS() As String = {"Total Omset"}
            .Series.Clear()
            For i As Integer = 0 To namaMHS.Length - 1
                'nama series
                .Series.Add(namaMHS(i))
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
            Dim cmd = New FbCommand("SELECT a.TGL,  sum(a.GRANDTOTAL) as TOTAL FROM TB_JUAL a GROUP BY a.TGL", konek)
            rddd = cmd.ExecuteReader
            While rddd.Read()
                .Series(0).Points.AddXY(CDate(rddd("TGL")).ToString("dd-MMM-yyyy"), FormatNumber(CDbl(rddd("TOTAL")), 0))
            End While
            konek.Close()
        End With
    End Sub
End Class