Public Class FormLaporanAll
    Private Sub FormLaporanAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt2 As New ReportPrestasiAll
        rpt2.FileName = "ReportPrestasAll.rpt"
    End Sub
End Class