Public Class FormCariPerlombaan
    Sub buatPerlombaan()
        LVPerlombaan.Columns.Add("ID Perlombaan", 70, HorizontalAlignment.Center)
        LVPerlombaan.Columns.Add("Nama Perlombaan", 150, HorizontalAlignment.Center)
        LVPerlombaan.Columns.Add("Jenis", 70, HorizontalAlignment.Center)
        LVPerlombaan.Columns.Add("Tingkat", 70, HorizontalAlignment.Center)
        LVPerlombaan.Columns.Add("Jumlah Poin", 70, HorizontalAlignment.Center)
        LVPerlombaan.View = View.Details
        LVPerlombaan.GridLines = True
        LVPerlombaan.FullRowSelect = True
    End Sub

    Private Sub FormCariPerlombaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call buatPerlombaan()
    End Sub

    Private Sub LVPerlombaan_DoubleClick(sender As Object, e As EventArgs) Handles LVPerlombaan.DoubleClick
        With FormDataPrestasi
            .txtIDPerlombaan.Text = LVPerlombaan.SelectedItems(0).SubItems(0).Text
            .txtNamaPerlombaan.Text = LVPerlombaan.SelectedItems(0).SubItems(1).Text
            .txtTingkat.Text = LVPerlombaan.SelectedItems(0).SubItems(2).Text
            .txtJenisPerlombaan.Text = LVPerlombaan.SelectedItems(0).SubItems(3).Text
            .txtJmlPoin.Text = LVPerlombaan.SelectedItems(0).SubItems(4).Text
            Me.Close()
            'txtNamaPerlombaan.Focus()
        End With
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        DTGrid = KontrolPerlombaan.cariData(txtCari.Text).ToTable
        LVPerlombaan.Items.Clear()
        Dim strItem(4) As String
        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                strItem(0) = DTGrid.Rows(i).Item(0).ToString
                strItem(1) = DTGrid.Rows(i).Item(1).ToString
                strItem(2) = DTGrid.Rows(i).Item(2).ToString
                strItem(3) = DTGrid.Rows(i).Item(3).ToString
                strItem(4) = DTGrid.Rows(i).Item(4)

                LVPerlombaan.Items.Add(New ListViewItem(strItem))
            Next

        Else
            MsgBox("Data tidak ditemukan")
        End If
    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If (e.KeyChar = Chr(13)) Then
            DTGrid = KontrolPerlombaan.cariData(txtCari.Text).ToTable
            LVPerlombaan.Items.Clear()
            Dim strItem(4) As String
            If DTGrid.Rows.Count > 0 Then
                For i = 0 To DTGrid.Rows.Count - 1
                    strItem(0) = DTGrid.Rows(i).Item(0).ToString
                    strItem(1) = DTGrid.Rows(i).Item(1).ToString
                    strItem(2) = DTGrid.Rows(i).Item(2).ToString
                    strItem(3) = DTGrid.Rows(i).Item(3).ToString
                    strItem(4) = DTGrid.Rows(i).Item(4).ToString

                    LVPerlombaan.Items.Add(New ListViewItem(strItem))
                Next

            Else
                MsgBox("Data tidak ditemukan")
            End If
        End If
    End Sub


End Class