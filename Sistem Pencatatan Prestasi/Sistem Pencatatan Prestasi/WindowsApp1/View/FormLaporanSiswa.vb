Public Class FormLaporanSiswa
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim rpt As New ReportSiswa
        rpt.SetParameterValue("kelas", "X MIPA 1")

    End Sub
End Class