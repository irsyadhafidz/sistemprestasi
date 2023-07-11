Imports System.ComponentModel

Public Class FormLaporan
    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New ReportPrestasi
        rpt.FileName = "ReportPrestasi.rpt"


    End Sub



    Private Sub FormLaporan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing


        Dim closingfrm = MsgBox(" Apakah Anda yakin ingin menutup laporan?", MsgBoxStyle.YesNo)
        If closingfrm = DialogResult.Yes Then
            e.Cancel = False
            FormDataPrestasi.Show()

        End If
    End Sub


End Class