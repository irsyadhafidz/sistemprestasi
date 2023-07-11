Imports System.Data.OleDb

Public Class ClsCtlPengguna : Implements InfProses
    Public Function loginPengguna(username As String) As DataView
        Try
            DTA = New OleDbDataAdapter("Select * from Pengguna where username ='" & username & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Pengguna")
            Dim grid As New DataView(DTS.Tables("Cari_Pengguna"))
            Return grid
        Catch ex As Exception

        End Try
    End Function

    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(id_pengguna,2)) from Pengguna", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "USR-" & Strings.Right("0" & kodeakhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from Pengguna where nama_pengguna " & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Pengguna")
            Dim grid As New DataView(DTS.Tables("Cari_Pengguna"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from Pengguna " & "where id_pengguna='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function insertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntPengguna
        data = Ob
        CMD = New OleDbCommand("insert into Pengguna values('" & data.id_pengguna & "','" & data.nama_pengguna & "','" & data.username & "','" & data.password & "' )", BUKAKONEKSI)


        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from Pengguna", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Pengguna")
            Dim grid As New DataView(DTS.Tables("Tabel_Pengguna"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntPengguna
        data = Ob
        CMD = New OleDbCommand("update Pengguna set nama_pengguna='" & data.nama_pengguna _
                               & "',username ='" & data.username _
                               & "', password = '" & data.password _
                                & "' where id_pengguna='" & data.id_pengguna & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function


End Class
