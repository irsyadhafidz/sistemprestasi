Imports System.Data.OleDb
Public Class ClsCtlSiswa : Implements InfProses
    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(id_siswa,9)) from Siswa", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "STD-" & Strings.Right("000" & kodeakhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntSiswa
        data = Ob
        CMD = New OleDbCommand("insert into Siswa values
        ('" & data.id_siswa & "','" & data.nis & "','" & data.nama_siswa & "','" & data.jenis_kelamin & "','" & data.kelas & "','" & data.tempat_lahir & "','" & Format(data.tgl_lahir, "yyyy/MM/dd") & "','" & data.th_angkatan & "')", BUKAKONEKSI)


        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntSiswa
        data = Ob
        CMD = New OleDbCommand("update Siswa set nis='" & data.nis _
                               & "',nama_siswa ='" & data.nama_siswa _
                               & "', jenis_kelamin = '" & data.jenis_kelamin _
                               & "',kelas ='" & data.kelas _
                               & "', tempat_lahir = '" & data.tempat_lahir _
                               & "',tgl_lahir ='" & Format(data.tgl_lahir, "yyyy/MM/dd") _
                               & "', th_angkatan = '" & data.th_angkatan _
                                & "' where id_siswa='" & data.id_siswa & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from Siswa " & "where id_siswa='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from Siswa", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Siswa")
            Dim grid As New DataView(DTS.Tables("Tabel_Siswa"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from Siswa where nama_siswa " & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Siswa")
            Dim grid As New DataView(DTS.Tables("Cari_Siswa"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
