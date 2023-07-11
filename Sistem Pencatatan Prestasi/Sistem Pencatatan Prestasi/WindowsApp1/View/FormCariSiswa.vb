Public Class FormCariSiswa
    Sub buatSiswa()
        LVSiswa.Columns.Add("ID Siswa", 70, HorizontalAlignment.Center)
        LVSiswa.Columns.Add("NIS", 70, HorizontalAlignment.Center)
        LVSiswa.Columns.Add("Nama Siswa", 150, HorizontalAlignment.Center)
        LVSiswa.Columns.Add("Jenis Kelamin", 75, HorizontalAlignment.Center)
        LVSiswa.Columns.Add("Kelas", 70, HorizontalAlignment.Center)
        LVSiswa.View = View.Details
        LVSiswa.GridLines = True
        LVSiswa.FullRowSelect = True
    End Sub

    Private Sub FormCariSiswa_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call buatSiswa()
    End Sub

    Private Sub LVSiswa_DoubleClick(sender As Object, e As EventArgs) Handles LVSiswa.DoubleClick
        With FormDataPrestasi
            .txtIDSiswa.Text = LVSiswa.SelectedItems(0).SubItems(0).Text
            .txtNamaSiswa.Text = LVSiswa.SelectedItems(0).SubItems(2).Text
            Me.Close()
            'txtNamaPerlombaan.Focus()
        End With
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        DTGrid = KontrolSiswa.cariData(txtCari.Text).ToTable
        LVSiswa.Items.Clear()
        Dim strItem(4) As String
        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                strItem(0) = DTGrid.Rows(i).Item(0).ToString
                strItem(1) = DTGrid.Rows(i).Item(1).ToString
                strItem(2) = DTGrid.Rows(i).Item(2).ToString
                strItem(3) = DTGrid.Rows(i).Item(3).ToString
                strItem(4) = DTGrid.Rows(i).Item(4).ToString

                LVSiswa.Items.Add(New ListViewItem(strItem))
            Next

        Else
            MsgBox("Data tidak ditemukan")
        End If
    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If (e.KeyChar = Chr(13)) Then
            DTGrid = KontrolSiswa.cariData(txtCari.Text).ToTable
            LVSiswa.Items.Clear()
            Dim strItem(4) As String
            If DTGrid.Rows.Count > 0 Then
                For i = 0 To DTGrid.Rows.Count - 1
                    strItem(0) = DTGrid.Rows(i).Item(0).ToString
                    strItem(1) = DTGrid.Rows(i).Item(1).ToString
                    strItem(2) = DTGrid.Rows(i).Item(2).ToString
                    strItem(3) = DTGrid.Rows(i).Item(3).ToString
                    strItem(4) = DTGrid.Rows(i).Item(4).ToString

                    LVSiswa.Items.Add(New ListViewItem(strItem))
                Next

            Else
                MsgBox("Data tidak ditemukan")
            End If
        End If
    End Sub
End Class