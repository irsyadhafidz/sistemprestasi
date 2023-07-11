Public Class FormDataSiswa
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
            With dgSiswa.Rows(br)
                txtIDSiswa.Text = .Cells(0).Value.ToString
                txtNIS.Text = .Cells(1).Value.ToString
                txtNamaSiswa.Text = .Cells(2).Value.ToString


                Dim x As String
                x = .Cells(3).Value.ToString
                If x Is "Laki-laki" Then
                    radLaki.Checked = True

                ElseIf x Is "Perempuan" Then
                    radPerempuan.Checked = True



                End If



                txtTempatLahir.Text = .Cells(5).Value.ToString
                dateTglLahir.Text = .Cells(6).Value.ToString
                ComboBox1.SelectedItem = .Cells(4).Value.ToString
                ComboBox2.SelectedItem = .Cells(7).Value.ToString
                cmbKelas.selectedIndex = ComboBox1.SelectedIndex
                cmbTahunAngkatan.selectedIndex = ComboBox2.SelectedIndex


            End With
            lblBaris.Text = "Data ke-" & br + 1 & "  dari total  " & dgSiswa.RowCount & " data "
        End If
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolSiswa.tampilData.ToTable
        dgSiswa.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            dgSiswa.Rows(DTGrid.Rows.Count - 1).Selected = True
            dgSiswa.CurrentCell = dgSiswa.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If


    End Sub
    Private Sub FormDataSiswa_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'Siswa._Siswa' table. You can move, or remove it, as needed.
        'Me.SiswaTableAdapter.Fill(Me.Siswa._Siswa)
        'TODO: This line of code loads data into the 'Ewe.Siswa' table. You can move, or remove it, as needed.

        lblNamaAdmin.Text = NAMALOG + " !"
        lblIDPengguna.Text = KODELOG

        Call RefreshGrid()
        txtIDSiswa.Enabled = False
        txtNamaSiswa.Enabled = False
        txtNIS.Enabled = False
        txtTempatLahir.Enabled = False
        radLaki.Enabled = False
        radPerempuan.Enabled = False
        cmbKelas.Enabled = False
        cmbTahunAngkatan.Enabled = False
        ComboBox1.Visible = False
        ComboBox2.Visible = False

    End Sub
    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolSiswa.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            dgSiswa.DataSource = DTGrid
            dgSiswa.Rows(DTGrid.Rows.Count - 1).Selected = True
            dgSiswa.CurrentCell = dgSiswa.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub



    Private Sub dgSiswa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSiswa.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            dgSiswa.Rows(baris).Selected = True
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
        txtNamaSiswa.Enabled = True
        txtNIS.Enabled = True
        txtTempatLahir.Enabled = True
        radLaki.Enabled = True
        radPerempuan.Enabled = True
        cmbKelas.Enabled = True
        cmbTahunAngkatan.Enabled = True
        txtIDSiswa.Text = KontrolSiswa.kodeBaru()
        txtNamaSiswa.Text = ""
        txtNIS.Text = ""
        txtTempatLahir.Text = ""
        cmbKelas.selectedIndex = 0
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaSiswa.Text = "" Or txtNIS.Text = "" Or txtTempatLahir.Text = "" Then
            MsgBox("Data gagal disimpan ! Periksa kembali data yang Anda masukkan.")
        Else
            With EntitasSiswa
                .id_siswa = txtIDSiswa.Text
                .nis = txtNIS.Text
                .nama_siswa = txtNamaSiswa.Text
                If radLaki.Checked = True Then
                    .jenis_kelamin = radLaki.Text
                Else
                    .jenis_kelamin = radPerempuan.Text
                End If

                .kelas = cmbKelas.selectedValue.ToString
                .tempat_lahir = txtTempatLahir.Text
                .tgl_lahir = dateTglLahir.Value
                .th_angkatan = cmbTahunAngkatan.selectedValue.ToString
            End With

            If modeProses = 1 Then
                KontrolSiswa.InsertData(EntitasSiswa)
            ElseIf modeProses = 2 Then
                KontrolSiswa.updateData(EntitasSiswa)
            End If
            MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
            RefreshGrid()
            AturButton(True)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Apakah Anda yakin akan menghapus " & txtIDSiswa.Text & "-" & txtNamaSiswa.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolSiswa.deleteData(txtIDSiswa.Text)
            MsgBox("Data berhasil dihapus !")
        End If
        RefreshGrid()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        AturButton(False)
        txtNamaSiswa.Focus()
        txtNamaSiswa.Enabled = True
        txtNIS.Enabled = True
        txtTempatLahir.Enabled = True
        cmbKelas.Enabled = True
        cmbTahunAngkatan.Enabled = True
        radLaki.Enabled = True
        radPerempuan.Enabled = True
        modeProses = 2
    End Sub



End Class