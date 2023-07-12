Public Class Dashboard
    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim closingfrm = MsgBox(" Apakah Anda yakin ingin keluar?", MsgBoxStyle.YesNo)
        If closingfrm = DialogResult.Yes Then
            Me.Hide()
            FormLogin.Show()

        End If
    End Sub

    Private Sub btnDataSiswa_Click(sender As Object, e As EventArgs) Handles btnDataSiswa.Click
        FormDataSiswa.MdiParent = Me
        Me.Panel1.Controls.Add(FormDataSiswa)
        FormDataSiswa.Show()
        FormDataPerlombaan.Hide()
        FormDataPrestasi.Hide()
        FormDataPengguna.Hide()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormDataSiswa.MdiParent = Me
        Me.Panel1.Controls.Add(FormDataSiswa)
        FormDataSiswa.Show()



    End Sub

    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs) Handles btnDataPerlombaan.Click
        FormDataPerlombaan.MdiParent = Me
        Me.Panel1.Controls.Add(FormDataPerlombaan)
        FormDataSiswa.Hide()
        FormDataPerlombaan.Show()
        FormDataSiswa.Hide()
        FormDataPrestasi.Hide()
        FormDataPengguna.Hide()
    End Sub

    Private Sub btnDataPrestasi_Click(sender As Object, e As EventArgs) Handles btnDataPrestasi.Click
        FormDataPrestasi.MdiParent = Me
        Me.Panel1.Controls.Add(FormDataPrestasi)
        FormDataSiswa.Hide()
        FormDataPrestasi.Show()
        FormDataSiswa.Hide()
        FormDataPerlombaan.Hide()
        FormDataPengguna.Hide()
    End Sub

    Private Sub btnDataPengguna_Click(sender As Object, e As EventArgs) Handles btnDataPengguna.Click
        FormDataPengguna.MdiParent = Me
        Me.Panel1.Controls.Add(FormDataPengguna)
        FormDataSiswa.Hide()
        FormDataPengguna.Show()
        FormDataSiswa.Hide()
        FormDataPerlombaan.Hide()
        FormDataPrestasi.Hide()
    End Sub
End Class