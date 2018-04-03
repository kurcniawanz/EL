Imports System.Windows.Forms.DataVisualization.Charting
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
            .Series(0).Points.AddXY("1", 100)
            .Series(0).Points.AddXY("2", 70)
            .Series(0).Points.AddXY("3", 45)
            .Series(0).Points.AddXY("4", 60)
            .Series(0).Points.AddXY("5", 100)
            .Series(0).Points.AddXY("6", 70)
            .Series(0).Points.AddXY("7", 45)
            .Series(0).Points.AddXY("8", 60)
            .Series(0).Points.AddXY("9", 100)
            .Series(0).Points.AddXY("10", 70)
            .Series(0).Points.AddXY("11", 45)
            .Series(0).Points.AddXY("12", 60)
            .Series(0).Points.AddXY("13", 100)
            .Series(0).Points.AddXY("14", 70)
            .Series(0).Points.AddXY("15", 45)
            .Series(0).Points.AddXY("16", 60)
            .Series(0).Points.AddXY("17", 100)
            .Series(0).Points.AddXY("18", 70)
            .Series(0).Points.AddXY("19", 45)
            .Series(0).Points.AddXY("20", 60)
            .Series(0).Points.AddXY("21", 100)
            .Series(0).Points.AddXY("22", 70)
            .Series(0).Points.AddXY("23", 45)
            .Series(0).Points.AddXY("24", 60)
            .Series(0).Points.AddXY("25", 100)
            .Series(0).Points.AddXY("26", 70)
            .Series(0).Points.AddXY("27", 45)
            .Series(0).Points.AddXY("28", 60)
            .Series(0).Points.AddXY("29", 70)
            .Series(0).Points.AddXY("30", 45)
            .Series(0).Points.AddXY("31", 60)
        End With
    End Sub
End Class