Imports System.Data.SqlClient
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient
Public Class PARTNER

    Sub nomor()
        Dim temp As String = ""
        Dim vall As String = ""
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_PARTNER  ORDER BY ID DESC", konek)
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
        ComboBox1.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("ALL")
        koneksi_db()
        Dim rddd As FbDataReader
        Dim cmd = New FbCommand("SELECT * FROM TB_PARTNER", konek)
        rddd = cmd.ExecuteReader
        While rddd.Read()
            ComboBox1.Items.Add(rddd("NAMA"))
        End While
        konek.Close()
    End Sub

    Sub loaddata()
        Dim aa As String = "%"
        If Not ComboBox1.Text = "ALL" Then
            aa = ComboBox1.Text
        End If

        Dim bb As String = "0"
        If CheckBox3.Checked = True And CheckBox4.Checked = False Then
            bb = "C%"
        ElseIf CheckBox4.Checked = True And CheckBox3.Checked = False Then
            bb = "%S"
        ElseIf CheckBox3.Checked = False And CheckBox4.Checked = False Then
            bb = "-"
        ElseIf CheckBox3.Checked = True And CheckBox4.Checked = True Then
            bb = "%"
        End If

        DataGridView1.AutoGenerateColumns = False
        koneksi_db()
        Dim dA As New FbDataAdapter("SELECT * FROM TB_PARTNER WHERE NAMA LIKE '" & aa & "' AND STATUS LIKE '" & bb & "'", konek)
        Dim dS As DataTable = New DataTable
        dS.Clear()
        dA.Fill(dS)
        DataGridView1.DataSource = (dS)
        DataGridView1.Enabled = True
        dA.Dispose()
        konek.Close()
    End Sub

    Private Sub PARTNER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nama()
        ComboBox1.Text = "ALL"
        CheckBox3.Checked = True
        CheckBox4.Checked = True
        loaddata()
        txtnama.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtnama.Text = "" Then
            MsgBox("Isi Nama Partner !!!!  ", vbExclamation)
            txtnama.Focus()
            Exit Sub
        End If

        If txttelp.Text = "" Then
            MsgBox("Isi No Telp !!!!  ", vbExclamation)
            txttelp.Focus()
            Exit Sub
        End If

        If txtalamat.Text = "" Then
            MsgBox("Isi Alamat !!!!  ", vbExclamation)
            txtalamat.Focus()
            Exit Sub
        End If

        Dim bb As String = "0"
        If CheckBox2.Checked = True And CheckBox1.Checked = False Then
            bb = "C"
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = False Then
            bb = "S"
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False Then
            bb = "-"
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True Then
            bb = "C-S"
        End If

        nomor()
        Dim simpan As String
        simpan = "INSERT INTO TB_PARTNER(ID,NAMA,TELP,STATUS,CREATE_USERID,STAMP,ALAMAT)" _
           + "VALUES ('" & txtid.Text & "'," _
           + "'" & txtnama.Text & "'," _
           + "'" & txttelp.Text & "'," _
           + "'" & bb & "'," _
           + "'" & HOME.usernya.Text & "'," _
           + "cast('NOW' as timestamp)," _
           + "'" & txtalamat.Text & "') ; "
        callprogress(simpan)
        loaddata()
        txtid.Clear()
        txttelp.Clear()
        txtnama.Clear()
        txtalamat.Clear()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        txtnama.Focus()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        txtid.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_ID").Value.ToString
        txtnama.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_NAMA").Value.ToString
        txttelp.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_TELP").Value.ToString
        txtalamat.Text = DataGridView1.Rows(e.RowIndex).Cells("DGV_ALAMAT").Value.ToString

        Dim bb As String = DataGridView1.Rows(e.RowIndex).Cells("DGV_STATUS").Value.ToString
        If bb = "C" Then
            CheckBox2.Checked = True
            CheckBox1.Checked = False
        ElseIf bb = "S" Then
            CheckBox1.Checked = True
            CheckBox2.Checked = False
        ElseIf bb = "-" Then
            CheckBox2.Checked = False
            CheckBox1.Checked = False
        ElseIf bb = "C-S" Then
            CheckBox2.Checked = True
            CheckBox1.Checked = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Hapus As String
        Dim pesan As Integer
        pesan = MsgBox("Apakah anda yakin akan menghapus Data ??", vbExclamation + vbYesNo, "perhatian")
        If pesan = vbNo Then Exit Sub
        Hapus = "DELETE FROM TB_PARTNER WHERE ID ='" & txtid.Text & "'"
        callprogress(Hapus)
        loaddata()
        txtid.Clear()
        txttelp.Clear()
        txtnama.Clear()
        txtalamat.Clear()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        txtnama.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim bb As String = "0"
        If CheckBox2.Checked = True And CheckBox1.Checked = False Then
            bb = "C"
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = False Then
            bb = "S"
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False Then
            bb = "-"
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True Then
            bb = "C-S"
        End If
        Dim edit As String
        edit = "UPDATE TB_PARTNER SET STAMP = cast('NOW' as timestamp),status = '" & bb & "', NAMA = '" & txtnama.Text & "',TELP = '" & txttelp.Text & "',ALAMAT = '" & txtalamat.Text & "',CREATE_USERID = '" & HOME.usernya.Text & "' WHERE ID = '" & txtid.Text & "' "
        callprogress(edit)
        loaddata()
        txtid.Clear()
        txttelp.Clear()
        txtnama.Clear()
        txtalamat.Clear()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        txtnama.Focus()
    End Sub

    Private Sub txtnama_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnama.KeyDown
        If e.KeyCode = Keys.Enter Then
            txttelp.Focus()
        End If
    End Sub

    Private Sub txttelp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttelp.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtalamat.Focus()
        End If
    End Sub

    Private Sub txtalamat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtalamat.KeyDown
        If e.KeyCode = Keys.Enter Then
            CheckBox1.Focus()
        End If
    End Sub

    Private Sub CheckBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CheckBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            CheckBox2.Focus()
        End If
    End Sub

    Private Sub CheckBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CheckBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3.Focus()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        loaddata()
    End Sub
End Class