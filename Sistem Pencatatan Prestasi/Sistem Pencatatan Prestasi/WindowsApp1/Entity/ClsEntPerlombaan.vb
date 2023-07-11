Public Class ClsEntPerlombaan
    Private idlomba As String
    Private namalomba As String
    Private jenislomba As String
    Private tingkatlomba As String
    Private jmlpoin As Integer

    Public Property id_perlombaan() As String
        Get
            Return idlomba
        End Get
        Set(value As String)
            idlomba = value
        End Set
    End Property
    Public Property nama_perlombaan() As String
        Get
            Return namalomba
        End Get
        Set(value As String)
            namalomba = value
        End Set
    End Property
    Public Property jenis() As String
        Get
            Return jenislomba
        End Get
        Set(value As String)
            jenislomba = value
        End Set
    End Property
    Public Property tingkat() As String
        Get
            Return tingkatlomba
        End Get
        Set(value As String)
            tingkatlomba = value
        End Set
    End Property
    Public Property jml_poin() As Integer
        Get
            Return jmlpoin
        End Get
        Set(value As Integer)
            jmlpoin = value
        End Set
    End Property



End Class
