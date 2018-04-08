Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class STOCK

    Sub nama()
        carikel.Text = ""
        carikel.Items.Clear()
        carikel.DisplayMember = "Text"
        carikel.ValueMember = "Value"
        Dim data As New DataTable
        data.Columns.Add("Text", GetType(String))
        data.Columns.Add("Value", GetType(Integer))
        data.Rows.Add("ALL", 0)
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_CATEGORY", konek)
        rddd = cmd.ExecuteReader
        While rddd.Read()
            data.Rows.Add(rddd("NAMA"), rddd("ID"))
        End While
        konek.Close()
        carikel.DataSource = data
        carikel.SelectedValue = 0

        carinama.Text = ""
        carinama.Items.Clear()
        carinama.Items.Add("ALL")
        koneksi_db()
        Dim read As FbDataReader
        Dim com = New FbCommand("SELECT * FROM TB_BARANG", konek)
        read = com.ExecuteReader
        While read.Read()
            carinama.Items.Add(read("NAMA"))
        End While
        konek.Close()
        carinama.Text = "ALL"
    End Sub

    Sub loaddata()
        Dim aa As String = "%"
        If Not carinama.Text = "ALL" Then
            aa = carinama.Text
        End If

        Dim bb As String = "%"
        If Not carikel.Text = "ALL" Then
            bb = carikel.SelectedValue
        End If

        Dim cc As String = ""
        If carimin.Checked = True Then
            cc = "AND (m.QTY-a.MINIMAL) <= 0"
        End If

        DataGridView1.AutoGenerateColumns = False
        koneksi_db()
        Dim dA As New FbDataAdapter("SELECT a.ID,a.NAMA,a.KELOMPOK,m.QTY,(m.TOTHPP/m.QTY) as HPP,m.TOTHPP,a.SATUAN,a.HARGAJUAL,a.MINIMAL,a.KET,a.CREATE_USERID,a.STAMP, " _
                                        + " b.NAMA as KELOMPOKNAMA FROM TB_BARANG a " _
                                        + " INNER JOIN TB_CATEGORY b ON b.ID = a.KELOMPOK " _
                                        + " INNER JOIN ( " _
                                        + " SELECT IDBARANG as  BARANGID,SUM(QTY) as QTY,SUM(TOTHPP) as TOTHPP FROM TB_MUTASI GROUP BY IDBARANG " _
                                        + " )m ON m.BARANGID = a.ID " _
                                        + " WHERE a.NAMA LIKE '" & aa & "' AND a.KELOMPOK LIKE '" & bb & "' " & cc & " ", konek)
        Dim dS As DataTable = New DataTable
        dS.Clear()
        dA.Fill(dS)
        DataGridView1.DataSource = (dS)
        DataGridView1.Enabled = True
        dA.Dispose()
        konek.Close()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub STOCK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nama()
        loaddata()
        carinama.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        loaddata()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If Me.MdiChildren.Length > 0 Then
            Dim childForm As Form = CType(ActiveMdiChild, Form)
            childForm.Close()
        End If
        Dim frm As BARANG
        frm = New BARANG
        frm.Text = "HOME"
        frm.MdiParent = HOME
        frm.Button3.Visible = False
        frm.Button2.Visible = True
        frm.Button1.Visible = True
        frm.nama()
        frm.dari = "BB"
        frm.txtid.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_ID").Value.ToString
        frm.txtnama.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_NAMA").Value.ToString
        frm.txtkelompok.SelectedValue = DataGridView1.Rows(e.RowIndex).Cells("DGV_KELOMPOK").Value
        frm.txtsatuan.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_SATUAN").Value.ToString
        frm.txtharga.Text = FormatNumber(DataGridView1.Rows(e.RowIndex).Cells("DGV_HARGAJUAL").Value, 0)
        frm.txtminimal.Text = FormatNumber(DataGridView1.Rows(e.RowIndex).Cells("DGV_MINIMAL").Value, 0)
        frm.txtket.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_KET").Value.ToString
        frm.Show()
        frm.Dock = DockStyle.Fill
    End Sub

    Private Sub carinama_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles carinama.KeyDown
        If e.KeyCode = Keys.Enter Then
            carikel.Focus()
        End If
    End Sub

    Private Sub carikel_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles carikel.KeyDown
        If e.KeyCode = Keys.Enter Then
            carimin.Focus()
        End If
    End Sub

    Private Sub carimin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles carimin.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button4.Focus()
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        For i As Integer = 0 To DataGridView1.RowCount - 1
            If CDbl(DataGridView1.Rows(i).Cells("DGV_QTY").Value) <= CDbl(DataGridView1.Rows(i).Cells("DGV_MINIMAL").Value) Then
                DataGridView1.Rows(i).DefaultCellStyle.ForeColor = Color.Red
            End If
        Next
    End Sub
End Class