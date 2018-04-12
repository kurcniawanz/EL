Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class MUTASI_KAS

    Sub loaddata()

        Dim cc As String = "%"
        If Not carinokas.Text = "" Then
            cc = carinokas.Text + "%"
        End If

        Dim dd As String = "%"
        If Not carifaktur.Text = "" Then
            dd = carifaktur.Text + "%"
        End If

        dgv_det.AutoGenerateColumns = False
        koneksi_db()
        Dim dA As New FbDataAdapter("SELECT a.ID,b.TGL, a.NOKAS, a.NOFAK,c.NAMA  AS PARTNER,d.NAMA AS ACCOUNT, " _
                                    + " a.BAYAR, " _
                                    + "   a.CREATE_USERID, a.STAMP " _
                                    + " FROM TB_KAS_DET a " _
                                    + "  INNER JOIN TB_KAS b ON b.NOKAS = a.NOKAS " _
                                    + "  INNER JOIN TB_PARTNER c ON c.ID = b.PARTNER " _
                                    + "  INNER JOIN TB_ACCOUNT d ON d.ID = b.ACCOUNT " _
                                    + "  WHERE b.TGL between '" & CDate(tgl1.Text) & "' AND '" & CDate(tgl2.Text) & "' AND a.NOKAS LIKE '" & cc & "' AND a.NOFAK LIKE '" & dd & "' ", konek)
        Dim dS As DataTable = New DataTable
        dS.Clear()
        dA.Fill(dS)
        dgv_det.DataSource = (dS)
        dgv_det.Enabled = True
        dA.Dispose()
        konek.Close()

        Dim tot As Double
        For i As Integer = 0 To dgv_det.RowCount - 1
            tot += CDbl(dgv_det.Rows(i).Cells("DGV_BAYAR").Value)
        Next

        txttot.Text = FormatNumber(tot, 0)

    End Sub
    Private Sub MUTASI_KAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
        tgl1.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        loaddata()
    End Sub

    Private Sub tgl1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tgl1.KeyDown
        If e.KeyCode = Keys.Enter Then
            tgl2.Focus()
        End If
    End Sub

    Private Sub tgl2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tgl2.KeyDown
        If e.KeyCode = Keys.Enter Then
            carinokas.Focus()
        End If
    End Sub

    Private Sub carinokas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles carinokas.KeyDown
        If e.KeyCode = Keys.Enter Then
            carifaktur.Focus()
        End If
    End Sub

    Private Sub carifaktur_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles carifaktur.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button4.Focus()
        End If
    End Sub
End Class