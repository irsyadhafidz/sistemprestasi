Public Class FormDataPrestasi
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
            With dgPrestasi.Rows(br)
                txtIDPrestasi.Text = .Cells(0).Value.ToString
                txtNamaSiswa.Text = .Cells(1).Value.ToString
                txtNamaPerlombaan.Text = .Cells(2).Value.ToString
                txtJenisPerlombaan.Text = .Cells(3).Value.ToString
                txtTingkat.Text = .Cells(4).Value.ToString
                cmbPeringkat.Text = .Cells(5).Value.ToString
                txtTotalPoin.Text = .Cells(6).Value.ToString
            End With
            lblBaris.Text = "Data ke-" & br + 1 & "  dari total  " & dgPrestasi.RowCount & " data "
        End If
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolPrestasi.tampilData.ToTable
        dgPrestasi.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            dgPrestasi.Rows(DTGrid.Rows.Count - 1).Selected = True
            dgPrestasi.CurrentCell = dgPrestasi.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolPrestasi.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            dgPrestasi.DataSource = DTGrid
            dgPrestasi.Rows(DTGrid.Rows.Count - 1).Selected = True
            dgPrestasi.CurrentCell = dgPrestasi.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub FormDataPrestasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'Siswa._Siswa' table. You can move, or remove it, as needed.
        'Me.SiswaTableAdapter.Fill(Me.Siswa._Siswa)


        lblNamaAdmin.Text = NAMALOG + " !"
        lblIDPengguna.Text = KODELOG

        Call RefreshGrid()
        txtIDPrestasi.ReadOnly = True
        txtJenisPerlombaan.ReadOnly = True
        txtNamaSiswa.ReadOnly = True
        txtPoinTambahan.ReadOnly = True
        txtIDSiswa.Visible = False
        txtNamaPerlombaan.ReadOnly = True
        txtIDPerlombaan.Visible = False
        txtJmlPoin.Visible = False

        cmbPeringkat.Text = "Pilih Peringkat"
        cmbPeringkat.Enabled = False
        cmbFilter.SelectedIndex = 0

    End Sub

    Private Sub btnPilihSiswa_Click(sender As Object, e As EventArgs) Handles btnPilihSiswa.Click
        FormCariSiswa.Show()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturButton(False)
        modeProses = 1
        txtIDPrestasi.Text = ""
        txtNamaSiswa.Text = ""
        txtNamaPerlombaan.Text = ""
        txtPoinTambahan.Text = ""
        txtJenisPerlombaan.Text = ""
        cmbPeringkat.Text = "Pilih Peringkat"
        txtTingkat.Text = ""
        txtTotalPoin.Text = ""
        txtIDPrestasi.Text = KontrolPrestasi.kodeBaru()
        cmbPeringkat.Enabled = True
    End Sub

    Private Sub btnPilihPerlombaan_Click(sender As Object, e As EventArgs) Handles btnPilihPerlombaan.Click
        FormCariPerlombaan.Show()
    End Sub

    Private Sub cmbPeringkat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPeringkat.SelectedIndexChanged
        Dim poinTambahan As Integer
        If cmbPeringkat.SelectedIndex = 0 Then
            txtPoinTambahan.Text = "100"
        ElseIf cmbPeringkat.SelectedIndex = 1 Then
            txtPoinTambahan.Text = "75"
        ElseIf cmbPeringkat.SelectedIndex = 2 Then
            txtPoinTambahan.Text = "50"
        ElseIf cmbPeringkat.SelectedIndex = 3 Then
            txtPoinTambahan.Text = "0"
        ElseIf cmbPeringkat.SelectedIndex = 4 Then
            txtPoinTambahan.Text = "0"
        ElseIf cmbPeringkat.SelectedIndex = 5 Then
            txtPoinTambahan.Text = "0"
        End If
        poinTambahan = txtPoinTambahan.Text
        Dim total As Integer
        total = poinTambahan + txtJmlPoin.Text
        txtTotalPoin.Text = total
    End Sub


    Private Sub dgPrestasi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPrestasi.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            dgPrestasi.Rows(baris).Selected = True
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

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        AturButton(False)
        btnPilihSiswa.Focus()
        modeProses = 2
        cmbPeringkat.Enabled = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaSiswa.Text = "" Or txtNamaPerlombaan.Text = "" Or cmbPeringkat.SelectedIndex = -1 Then
            MsgBox("Data gagal disimpan ! Periksa kembali data yang Anda masukkan.")
        Else
            With EntitasPrestasi
                .id_prestasi = txtIDPrestasi.Text
                .id_siswa = txtIDSiswa.Text
                .id_perlombaan = txtIDPerlombaan.Text
                .peringkat = cmbPeringkat.SelectedItem.ToString
                .total_poin = txtTotalPoin.Text
            End With

            If modeProses = 1 Then
                KontrolPrestasi.InsertData(EntitasPrestasi)
            ElseIf modeProses = 2 Then
                KontrolPrestasi.updateData(EntitasPrestasi)
            End If
            MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
            RefreshGrid()
            AturButton(True)

            txtNamaSiswa.Text = ""
            txtNamaPerlombaan.Text = ""
            txtPoinTambahan.Text = ""
            txtJenisPerlombaan.Text = ""
            cmbPeringkat.Text = "Pilih Peringkat"
            txtTingkat.Text = ""
            txtTotalPoin.Text = ""
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Apakah Anda yakin akan menghapus " & txtIDPrestasi.Text & "-" & txtNamaSiswa.Text & "-" & txtNamaPerlombaan.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolPrestasi.deleteData(txtIDPrestasi.Text)
            MsgBox("Data berhasil dihapus !")
        End If
        RefreshGrid()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub

    Private Sub dgPrestasi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPrestasi.CellContentClick

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub btnExportAll_Click(sender As Object, e As EventArgs) Handles btnExportAll.Click


        If cmbFilter.SelectedIndex = 0 Then
            Dim rpt As New ReportPrestasiAll
            rpt.Refresh()
            FormLaporanAll.Show()
        ElseIf cmbFilter.SelectedIndex = 1 Then
            Dim report As New ReportPrestasi
            'report.SetParameterValue(0, cmbFilter.Text)
            report.Refresh()
            FormLaporan.Show()
        End If


    End Sub


End Class