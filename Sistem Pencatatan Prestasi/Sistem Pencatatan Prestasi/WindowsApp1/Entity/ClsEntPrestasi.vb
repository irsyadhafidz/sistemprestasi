Public Class ClsEntPrestasi
    Private idpres As String
    Private idsiswa As String
    Private idlomba As String
    Private peringkt As String
    Private total As Integer

    Public Property id_prestasi() As String
        Get
            Return idpres
        End Get
        Set(value As String)
            idpres = value
        End Set
    End Property
    Public Property id_siswa() As String
        Get
            Return idsiswa
        End Get
        Set(value As String)
            idsiswa = value
        End Set
    End Property
    Public Property id_perlombaan() As String
        Get
            Return idlomba
        End Get
        Set(value As String)
            idlomba = value
        End Set
    End Property
    Public Property peringkat() As String
        Get
            Return peringkt
        End Get
        Set(value As String)
            peringkt = value
        End Set
    End Property
    Public Property total_poin() As String
        Get
            Return total
        End Get
        Set(value As String)
            total = value
        End Set
    End Property

End Class
