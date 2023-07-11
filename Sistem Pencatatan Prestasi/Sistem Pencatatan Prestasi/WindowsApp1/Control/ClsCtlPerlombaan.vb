Imports System.Data.OleDb

Public Class ClsCtlPerlombaan : Implements InfProses
    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(id_perlombaan,4)) from Perlombaan", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "DAT-" & Strings.Right("00" & kodeakhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntPerlombaan
        data = Ob
        CMD = New OleDbCommand("insert into Perlombaan values
        ('" & data.id_perlombaan & "','" & data.nama_perlombaan & "','" & data.jenis & "','" & data.tingkat & "','" & data.jml_poin & "')", BUKAKONEKSI)


        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntPerlombaan
        data = Ob
        CMD = New OleDbCommand("update Perlombaan set nama_perlombaan='" & data.nama_perlombaan _
                               & "',jenis ='" & data.jenis _
                               & "', tingkat = '" & data.tingkat _
                               & "',jml_poin ='" & data.jml_poin _
                               & "' where id_perlombaan='" & data.id_perlombaan & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from Perlombaan " & "where id_perlombaan='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from Perlombaan", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Perlombaan")
            Dim grid As New DataView(DTS.Tables("Tabel_Perlombaan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from Perlombaan where nama_perlombaan " & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Perlombaan")
            Dim grid As New DataView(DTS.Tables("Cari_Perlombaan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
