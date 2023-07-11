Imports System.Data.OleDb

Public Class ClsCtlPrestasi : Implements InfProses
    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(id_Prestasi,5)) from Prestasi", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "PRS-" & Strings.Right("000" & kodeakhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntPrestasi
        data = Ob
        CMD = New OleDbCommand("insert into Prestasi values
        ('" & data.id_prestasi & "','" & data.id_siswa & "','" & data.id_perlombaan & "','" & data.peringkat & "','" & data.total_poin & "')", BUKAKONEKSI)


        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntPrestasi
        data = Ob
        CMD = New OleDbCommand("update Prestasi set id_siswa='" & data.id_siswa _
                               & "',id_perlombaan ='" & data.id_perlombaan _
                               & "', peringkat = '" & data.peringkat _
                               & "',total_poin ='" & data.total_poin _
                               & "' where id_prestasi='" & data.id_prestasi & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from Prestasi " & "where id_prestasi='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("SELECT        Prestasi.id_prestasi, Siswa.nama_siswa, Perlombaan.nama_perlombaan, Perlombaan.jenis, Perlombaan.tingkat, Prestasi.peringkat, Prestasi.total_poin
FROM            Prestasi INNER JOIN
                         Siswa ON Prestasi.id_siswa = Siswa.id_siswa AND Prestasi.id_siswa = Siswa.id_siswa AND Prestasi.id_siswa = Siswa.id_siswa AND Prestasi.id_siswa = Siswa.id_siswa AND Prestasi.id_siswa = Siswa.id_siswa INNER JOIN
                         Perlombaan ON Prestasi.id_perlombaan = Perlombaan.id_perlombaan", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Prestasi")
            Dim grid As New DataView(DTS.Tables("Tabel_Prestasi"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("SELECT        Prestasi.id_prestasi, Siswa.nama_siswa, Perlombaan.nama_perlombaan, Perlombaan.jenis, Perlombaan.tingkat, Prestasi.peringkat, Prestasi.total_poin
FROM            Prestasi INNER JOIN
                         Siswa ON Prestasi.id_siswa = Siswa.id_siswa AND Prestasi.id_siswa = Siswa.id_siswa AND Prestasi.id_siswa = Siswa.id_siswa AND Prestasi.id_siswa = Siswa.id_siswa AND Prestasi.id_siswa = Siswa.id_siswa INNER JOIN
                         Perlombaan ON Prestasi.id_perlombaan = Perlombaan.id_perlombaan WHERE Siswa.nama_siswa " & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Prestasi")
            Dim grid As New DataView(DTS.Tables("Cari_Prestasi"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
