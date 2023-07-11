Public Class ClsEntSiswa
    Private idsiswa As String
    Private nomornis As String
    Private nama As String
    Private kls As String
    Private jk As String
    Private tmplahir As String
    Private tgllahir As String
    Private angkatan As String


    Public Property id_siswa() As String
        Get
            Return idsiswa
        End Get
        Set(value As String)
            idsiswa = value
        End Set
    End Property
    Public Property nis() As String
        Get
            Return nomornis
        End Get
        Set(value As String)
            nomornis = value
        End Set
    End Property
    Public Property nama_siswa() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property
    Public Property kelas() As String
        Get
            Return kls
        End Get
        Set(value As String)
            kls = value
        End Set
    End Property
    Public Property jenis_kelamin() As String
        Get
            Return jk
        End Get
        Set(value As String)
            jk = value
        End Set
    End Property
    Public Property tempat_lahir() As String
        Get
            Return tmplahir
        End Get
        Set(value As String)
            tmplahir = value
        End Set
    End Property
    Public Property tgl_lahir() As Date
        Get
            Return tgllahir
        End Get
        Set(value As Date)
            tgllahir = value
        End Set
    End Property
    Public Property th_angkatan() As String
        Get
            Return angkatan
        End Get
        Set(value As String)
            angkatan = value
        End Set
    End Property

End Class
