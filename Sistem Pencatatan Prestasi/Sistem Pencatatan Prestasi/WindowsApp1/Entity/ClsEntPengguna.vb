Public Class ClsEntPengguna
    Private iduser As String
    Private nama As String
    Private usrname As String
    Private passwd As String

    Public Property id_pengguna() As String
        Get
            Return iduser
        End Get
        Set(value As String)
            iduser = value
        End Set
    End Property

    Public Property nama_pengguna() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property username() As String
        Get
            Return usrname
        End Get
        Set(value As String)
            usrname = value
        End Set
    End Property

    Public Property password() As String
        Get
            Return passwd
        End Get
        Set(value As String)
            passwd = value
        End Set
    End Property

End Class
