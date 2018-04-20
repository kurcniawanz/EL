Imports FirebirdSql.Data.FirebirdClient
Imports System.IO
Module CONNECTION
    Public konek As New FbConnection()
    Dim readText As String

    Sub texting()
        Dim path As String = "C:\DB\EL.conf"
        readText = File.ReadAllText(path)
    End Sub

    Sub koneksi_db()
        Dim IP_add As String = readText
        Dim constKoneksiString As String = "User ID=SYSDBA;Password=masterkey;Database=" + IP_add + ":C:\DB\EL.FDB;Datasource=" + IP_add + ";Charset=NONE;"
        Try
            If konek.State <> 0 Then konek.Close()
            konek.ConnectionString = constKoneksiString
            konek.Open()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical +
                  MsgBoxStyle.ApplicationModal + MsgBoxStyle.OkOnly,
                  "Koneksi Error")
        End Try
    End Sub

    Sub callprogress(ByVal sQl As String)
        Dim SQLCmd As New FbCommand()
        koneksi_db()
        Try
            SQLCmd.Connection = konek
            SQLCmd.CommandType = CommandType.Text
            SQLCmd.CommandText = sQl
            SQLCmd.ExecuteNonQuery()
            SQLCmd.Dispose()
            konek.Close()
            MsgBox("Sukses", vbInformation)
        Catch ex As Exception
            MsgBox("Gagal !!! " & ex.Message, vbIgnore)
        End Try
    End Sub

    Sub callprogress2(ByVal sQl As String)
        Dim SQLCmd As New FbCommand()
        koneksi_db()
        Try
            SQLCmd.Connection = konek
            SQLCmd.CommandType = CommandType.Text
            SQLCmd.CommandText = sQl
            SQLCmd.ExecuteNonQuery()
            SQLCmd.Dispose()
            konek.Close()
            'MsgBox("Sukses", vbInformation)
        Catch ex As Exception
            MsgBox("Gagal !!! " & ex.Message, vbIgnore)
        End Try
    End Sub

    Function call_qty(ByVal idbarang As Integer) As Double
        Dim tempqty As Integer = 0
        koneksi_db()
        Dim readqty As FbDataReader
        Dim cmdqty = New FbCommand("SELECT SUM(QTY) as QTY FROM TB_MUTASI WHERE IDBARANG = '" & CDbl(idbarang) & "' GROUP BY IDBARANG", konek)
        readqty = cmdqty.ExecuteReader

        If readqty.Read Then
            tempqty = readqty.Item("QTY")
        End If
        konek.Close()
        Return tempqty
    End Function

    Function call_hpp(ByVal idbarang As Integer) As Double
        Dim hpp As Double
        koneksi_db()
        Dim readhpp As FbDataReader
        Dim command = New FbCommand("SELECT CASE WHEN sum(a.QTY) = 0 THEN 0 ELSE sum(a.TOTHPP+(a.ONGKIR*a.QTY))/sum(a.QTY) END AS HPP FROM TB_MUTASI a WHERE IDBARANG = " & CDbl(idbarang) & " GROUP BY a.IDBARANG", konek)
        readhpp = command.ExecuteReader
        If readhpp.Read Then
            hpp = readhpp.Item("HPP")
        Else
            hpp = 0
        End If
        konek.Close()
        Return hpp
    End Function

    Function input_mutasi(ByVal ongkir As Double, ByVal nofak As String, ByVal idbarang As Integer, ByVal qty As Double, ByVal hpp As Double, ByVal tgl As Date) As String
        Dim temp2 As String = ""
        Dim vall2 As String = ""
        koneksi_db()
        Dim rddd2 As FbDataReader
        Dim cmd2 = New FbCommand("SELECT * FROM TB_MUTASI  ORDER BY ID DESC", konek)
        rddd2 = cmd2.ExecuteReader

        If rddd2.Read Then
            temp2 = rddd2.Item("ID")
            vall2 = Val(temp2) + 1
        Else
            vall2 = "1"
        End If
        konek.Close()

        Dim simpan As String
        simpan = "INSERT INTO TB_MUTASI (ID,ONGKIR, NOFAK, IDBARANG, QTY, HPP, TOTHPP, CREATE_UID, STAMP,TGL)" _
                   + "VALUES ('" & vall2 & "'," _
                   + "'" & CDbl(ongkir) & "'," _
                   + "'" & nofak & "'," _
                   + "'" & CDbl(idbarang) & "'," _
                   + "'" & CDbl(qty) & "'," _
                   + "'" & CDbl(hpp) & "'," _
                   + "'" & CDbl(qty) * CDbl(hpp) & "'," _
                   + "'" & HOME.usernya.Text & "'," _
                   + "cast('NOW' as timestamp)," _
                   + "'" & CDate(tgl) & "') ; "
        callprogress2(simpan)
        Return "OK"
    End Function


    Function call_bulan(ByVal idbulan As Integer) As String
        Dim bulan As String = ""
        If idbulan = 1 Then
            bulan = "Januari"
        ElseIf idbulan = 2 Then
            bulan = "Februari"
        ElseIf idbulan = 3 Then
            bulan = "Maret"
        ElseIf idbulan = 4 Then
            bulan = "April"
        ElseIf idbulan = 5 Then
            bulan = "Mei"
        ElseIf idbulan = 6 Then
            bulan = "Juni"
        ElseIf idbulan = 7 Then
            bulan = "Juli"
        ElseIf idbulan = 8 Then
            bulan = "Agustus"
        ElseIf idbulan = 9 Then
            bulan = "September"
        ElseIf idbulan = 10 Then
            bulan = "Oktober"
        ElseIf idbulan = 11 Then
            bulan = "November"
        ElseIf idbulan = 12 Then
            bulan = "Desember"
        End If
        Return bulan
    End Function

End Module
