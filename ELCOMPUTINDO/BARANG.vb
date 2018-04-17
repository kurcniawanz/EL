Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class BARANG
    Public dari As String = "AA"
    Sub nomor()
        Dim temp As String = ""
        Dim vall As String = ""
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_BARANG  ORDER BY ID DESC", konek)
        rddd = cmd.ExecuteReader

        If rddd.Read Then
            temp = rddd.Item("ID")
            vall = Val(temp) + 1
            txtid.Text = vall
        Else
            txtid.Text = 1
        End If
        konek.Close()
    End Sub

    Sub nama()
        txtkelompok.DisplayMember = "Text"
        txtkelompok.ValueMember = "Value"
        Dim data As New DataTable
        data.Columns.Add("Text", GetType(String))
        data.Columns.Add("Value", GetType(Integer))
        data.Rows.Add(" ", 0)
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_CATEGORY", konek)
        rddd = cmd.ExecuteReader
        While rddd.Read()
            data.Rows.Add(rddd("NAMA"), rddd("ID"))
        End While
        konek.Close()
        txtkelompok.DataSource = data
        txtkelompok.SelectedValue = 0
    End Sub

    Private Sub BARANG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If dari = "AA" Then
            nama()
        End If
        txtnama.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtnama.Text = "" Then
            MsgBox("Isi Nama Barang !!!!  ", vbExclamation)
            txtnama.Focus()
            Exit Sub
        End If

        If txtkelompok.SelectedValue = 0 Then
            MsgBox("Pilih Kelompok Barang !!!!  ", vbExclamation)
            txtkelompok.Focus()
            Exit Sub
        End If

        If txtsatuan.Text = "" Then
            MsgBox("Isi Satuan !!!!  ", vbExclamation)
            txtsatuan.Focus()
            Exit Sub
        End If

        If txtharga.Text = Nothing Then
            MsgBox("Cek Harga Jual !!!!  ", vbExclamation)
            txtharga.Focus()
            Exit Sub
        End If

        If CDbl(txtharga.Text) < 0 Then
            MsgBox("Cek Harga Jual !!!!  ", vbExclamation)
            txtharga.Focus()
            Exit Sub
        End If

        If txtminimal.Text = Nothing Then
            MsgBox("Cek Stock Minimal !!!!  ", vbExclamation)
            txtminimal.Focus()
            Exit Sub
        End If

        If CDbl(txtminimal.Text) < 0 Then
            MsgBox("Cek Stock Minimal !!!!  ", vbExclamation)
            txtminimal.Focus()
            Exit Sub
        End If

        nomor()
        Dim simpan As String
        simpan = "INSERT INTO TB_BARANG(ID,NAMA,KELOMPOK,SATUAN,HARGAJUAL,HARGAJUAL2,MINIMAL,CREATE_USERID,STAMP,KET)" _
           + "VALUES ('" & txtid.Text & "'," _
           + "'" & txtnama.Text & "'," _
           + "'" & txtkelompok.SelectedValue & "'," _
           + "'" & txtsatuan.Text & "'," _
           + "'" & CDbl(txtharga.Text) & "'," _
           + "'" & CDbl(txtharga2.Text) & "'," _
           + "'" & CDbl(txtminimal.Text) & "'," _
           + "'" & HOME.usernya.Text & "'," _
           + "cast('NOW' as timestamp)," _
           + "'" & txtket.Text & "') ; "
        callprogress(simpan)
        txtid.Clear()
        txtnama.Clear()
        txtkelompok.SelectedValue = 0
        txtsatuan.Clear()
        txtharga.Text = 0
        txtharga2.Text = 0
        txtket.Clear()
        txtminimal.Text = "0"
        txtnama.Focus()
    End Sub

    Private Sub txtharga_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtharga.Leave
        If Not txtharga.Text = "" Then
            txtharga.Text = FormatNumber(txtharga.Text, 0)
        End If
    End Sub

    Private Sub txtnama_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnama.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtkelompok.Focus()
        End If
    End Sub

    Private Sub txtkelompok_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtkelompok.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsatuan.Focus()
        End If
    End Sub

    Private Sub txtsatuan_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsatuan.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtharga.Focus()
        End If
    End Sub

    Private Sub txtharga_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtharga.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtharga2.Focus()
        End If
    End Sub

    Private Sub txtket_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtket.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Button3.Visible = True Then
                Button3.Focus()
            Else
                Button2.Focus()
            End If

        End If
    End Sub

    Private Sub txtminimal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtminimal.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtket.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtnama.Text = "" Then
            MsgBox("Isi Nama Barang !!!!  ", vbExclamation)
            txtnama.Focus()
            Exit Sub
        End If

        If txtkelompok.SelectedValue = 0 Then
            MsgBox("Pilih Kelompok Barang !!!!  ", vbExclamation)
            txtkelompok.Focus()
            Exit Sub
        End If

        If txtsatuan.Text = "" Then
            MsgBox("Isi Satuan !!!!  ", vbExclamation)
            txtsatuan.Focus()
            Exit Sub
        End If

        If txtharga.Text = Nothing Then
            MsgBox("Cek Harga Jual !!!!  ", vbExclamation)
            txtharga.Focus()
            Exit Sub
        End If

        If CDbl(txtharga.Text) < 0 Then
            MsgBox("Cek Harga Jual !!!!  ", vbExclamation)
            txtharga.Focus()
            Exit Sub
        End If

        If txtminimal.Text = Nothing Then
            MsgBox("Cek Stock Minimal !!!!  ", vbExclamation)
            txtminimal.Focus()
            Exit Sub
        End If

        If CDbl(txtminimal.Text) < 0 Then
            MsgBox("Cek Stock Minimal !!!!  ", vbExclamation)
            txtminimal.Focus()
            Exit Sub
        End If
        Dim edit As String
        edit = "UPDATE TB_BARANG SET STAMP = cast('NOW' as timestamp), NAMA = '" & txtnama.Text & "'," _
            + "KELOMPOK = '" & txtkelompok.SelectedValue & "',KET = '" & txtket.Text & "'," _
            + "SATUAN = '" & txtsatuan.Text & "',HARGAJUAL = '" & CDbl(txtharga.Text) & "', HARGAJUAL2 = '" & CDbl(txtharga2.Text) & "', MINIMAL = '" & CDbl(txtminimal.Text) & "'," _
            + "CREATE_USERID = '" & HOME.usernya.Text & "' WHERE ID = '" & txtid.Text & "' "
        callprogress(edit)
        txtid.Clear()
        txtnama.Clear()
        txtkelompok.SelectedValue = 0
        txtsatuan.Clear()
        txtharga.Text = 0
        txtharga2.Text = 0
        txtket.Clear()
        txtminimal.Text = "0"
        txtnama.Focus()

        If dari = "BB" Then
            If Me.MdiChildren.Length > 0 Then
                Dim childForm As Form = CType(ActiveMdiChild, Form)
                childForm.Close()
            End If
            Dim frm As STOCK
            frm = New STOCK
            frm.Text = "HOME"
            frm.MdiParent = HOME
            frm.Show()
            frm.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Hapus As String
        Dim pesan As Integer
        pesan = MsgBox("Apakah anda yakin akan menghapus Data ??", vbExclamation + vbYesNo, "perhatian")
        If pesan = vbNo Then Exit Sub
        Hapus = "DELETE FROM TB_BARANG WHERE ID ='" & txtid.Text & "'"
        callprogress(Hapus)
        txtid.Clear()
        txtnama.Clear()
        txtkelompok.SelectedValue = 0
        txtsatuan.Clear()
        txtharga.Text = 0
        txtharga2.Text = 0
        txtket.Clear()
        txtminimal.Text = "0"
        txtnama.Focus()

        If dari = "BB" Then
            If Me.MdiChildren.Length > 0 Then
                Dim childForm As Form = CType(ActiveMdiChild, Form)
                childForm.Close()
            End If
            Dim frm As STOCK
            frm = New STOCK
            frm.Text = "HOME"
            frm.MdiParent = HOME
            frm.Show()
            frm.Dock = DockStyle.Fill
        End If
        
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtharga2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtharga2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtminimal.Focus()
        End If
    End Sub

    Private Sub txtharga2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtharga2.Leave
        If Not txtharga2.Text = "" Then
            txtharga2.Text = FormatNumber(txtharga2.Text, 0)
        End If
    End Sub
End Class