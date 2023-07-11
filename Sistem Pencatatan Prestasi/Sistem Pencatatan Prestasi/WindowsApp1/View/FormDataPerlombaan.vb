Public Class FormDataPerlombaan
    Dim modeProses As Integer
    Dim baris As Integer
    Private Sub AturButton(st As Boolean)
        btnTambah.Enabled = st
        btnUbah.Enabled = st
        btnHapus.Enabled = st
        btnSimpan.Enabled = Not st
        btnBatal.Enabled = Not st

        'Gr.Enabled = st
    End Sub
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With dgPerlombaan.Rows(br)
                txtIDPerlombaan.Text = .Cells(0).Value.ToString
                txtNamaPerlombaan.Text = .Cells(1).Value.ToString
                cmbJenisPerlombaan.selectedIndex = ComboBox1.SelectedIndex
                cmbTingkat.selectedIndex = ComboBox2.SelectedIndex
                txtJmlPoin.Text = .Cells(4).Value.ToString

                ComboBox1.SelectedItem = .Cells(2).Value.ToString
                ComboBox2.SelectedItem = .Cells(3).Value.ToString




            End With
            lblBaris.Text = "Data ke-" & br + 1 & "  dari total  " & dgPerlombaan.RowCount & " data "
        End If
    End Sub
    Private Sub RefreshGrid()
        DTGrid = KontrolPerlombaan.tampilData.ToTable
        dgPerlombaan.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            dgPerlombaan.Rows(DTGrid.Rows.Count - 1).Selected = True
            dgPerlombaan.CurrentCell = dgPerlombaan.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub
    Private Sub FormDataPerlombaan_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'Perlombaan._Perlombaan' table. You can move, or remove it, as needed.
        'Me.PerlombaanTableAdapter.Fill(Me.Perlombaan._Perlombaan)
        lblNamaAdmin.Text = NAMALOG + " !"
        lblIDPengguna.Text = KODELOG
        txtIDPerlombaan.Enabled = False
        txtNamaPerlombaan.Enabled = False
        cmbJenisPerlombaan.Enabled = False
        cmbTingkat.Enabled = False
        txtJmlPoin.Enabled = False
        Call RefreshGrid()
        ComboBox1.Visible = False
        ComboBox2.Visible = False
    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolPerlombaan.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            dgPerlombaan.DataSource = DTGrid
            dgPerlombaan.Rows(DTGrid.Rows.Count - 1).Selected = True
            dgPerlombaan.CurrentCell = dgPerlombaan.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub dgPerlombaan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPerlombaan.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            dgPerlombaan.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(txtCari.Text)
            txtCari.Focus()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturButton(False)
        modeProses = 1
        txtNamaPerlombaan.Enabled = True
        cmbJenisPerlombaan.Enabled = True
        cmbTingkat.Enabled = True
        txtJmlPoin.Enabled = True
        txtIDPerlombaan.Text = ""
        txtNamaPerlombaan.Text = ""
        txtJmlPoin.Text = ""
        txtIDPerlombaan.Text = KontrolPerlombaan.kodeBaru()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        AturButton(False)
        txtNamaPerlombaan.Focus()
        txtNamaPerlombaan.Enabled = True
        cmbJenisPerlombaan.Enabled = True
        cmbTingkat.Enabled = True
        txtJmlPoin.Enabled = True
        modeProses = 2
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaPerlombaan.Text = "" Or txtJmlPoin.Text = "" Then
            MsgBox("Data gagal disimpan ! Periksa kembali data yang Anda masukkan.")
        Else
            With EntitasPerlombaan
                .id_perlombaan = txtIDPerlombaan.Text
                .nama_perlombaan = txtNamaPerlombaan.Text
                .jenis = cmbJenisPerlombaan.selectedValue.ToString
                .tingkat = cmbTingkat.selectedValue.ToString
                .jml_poin = txtJmlPoin.Text
            End With

            If modeProses = 1 Then
                KontrolPerlombaan.InsertData(EntitasPerlombaan)
            ElseIf modeProses = 2 Then
                KontrolPerlombaan.updateData(EntitasPerlombaan)
            End If
            MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
            RefreshGrid()
            AturButton(True)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Apakah Anda yakin akan menghapus " & txtIDPerlombaan.Text & "-" & txtNamaPerlombaan.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolPerlombaan.deleteData(txtIDPerlombaan.Text)
            MsgBox("Data berhasil dihapus !")
        End If
        RefreshGrid()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub

End Class