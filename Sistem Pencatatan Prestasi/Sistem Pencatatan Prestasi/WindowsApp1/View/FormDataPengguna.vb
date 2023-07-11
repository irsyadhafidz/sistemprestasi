Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Public Class FormDataPengguna
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
            With dgPengguna.Rows(br)
                txtIDPengguna.Text = .Cells(0).Value.ToString
                txtNamaPengguna.Text = .Cells(1).Value.ToString
                txtUsername.Text = .Cells(2).Value.ToString
                txtPassword.Text = .Cells(3).Value.ToString

                txtCari.Text = .Cells(1).Value.ToString

            End With
            lblBaris.Text = "Data ke-" & br + 1 & "  dari total  " & dgPengguna.RowCount & " data "
        End If
    End Sub
    Private Sub RefreshGrid()
        DTGrid = KontrolPengguna.tampilData.ToTable
        dgPengguna.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            dgPengguna.Rows(DTGrid.Rows.Count - 1).Selected = True
            dgPengguna.CurrentCell = dgPengguna.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
        'COMBOBOX BINDING
        cmbUser.DataSource = DTGrid
        cmbUser.DisplayMember = "nama_pengguna"
        cmbUser.ValueMember = "id_pengguna"
    End Sub

    'Sub TampilPengguna()
    '    CMD = New OleDbCommand("select distinct level_karyawan from Karyawan", BUKAKONEKSI)
    '    DTR = CMD.ExecuteReader
    '    cbLevel.Items.Clear()
    '    Do While DTR.Read
    '        cbLevel.Items.Add(DTR.Item("Level_Karyawan"))
    '    Loop
    '    BUKAKONEKSI.Close()
    'End Sub
    Private Sub FormDataPengguna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pengguna._Pengguna' table. You can move, or remove it, as needed.
        'Me.PenggunaTableAdapter.Fill(Me.Pengguna._Pengguna)

        Call RefreshGrid()
        txtIDPengguna.Enabled = False
        txtNamaPengguna.Enabled = False
        txtUsername.Enabled = False
        txtPassword.Enabled = False

        cmbUser.Visible = False

        'Call TampilPengguna()
        lblNamaAdmin.Text = NAMALOG + " !"
        lblIDPengguna.Text = KODELOG



    End Sub




    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolPengguna.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            dgPengguna.DataSource = DTGrid
            dgPengguna.Rows(DTGrid.Rows.Count - 1).Selected = True
            dgPengguna.CurrentCell = dgPengguna.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.PenggunaTableAdapter.FillBy(Me.Pengguna._Pengguna)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub dgPengguna_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPengguna.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            dgPengguna.Rows(baris).Selected = True
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
        txtNamaPengguna.Enabled = True
        txtUsername.Enabled = True
        txtPassword.Enabled = True
        txtIDPengguna.Text = ""
        txtNamaPengguna.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtIDPengguna.Text = KontrolPengguna.kodeBaru()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        AturButton(False)
        txtNamaPengguna.Focus()
        txtNamaPengguna.Enabled = True
        txtUsername.Enabled = True
        txtPassword.Enabled = True
        modeProses = 2
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaPengguna.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Data gagal disimpan ! Periksa kembali data yang Anda masukkan.")
        Else
            With EntitasPengguna
                .id_pengguna = txtIDPengguna.Text
                .nama_pengguna = txtNamaPengguna.Text
                .username = txtUsername.Text
                .password = txtPassword.Text
            End With

            If modeProses = 1 Then
                KontrolPengguna.insertData(EntitasPengguna)
            ElseIf modeProses = 2 Then
                KontrolPengguna.updateData(EntitasPengguna)
            End If
            MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
            RefreshGrid()
            AturButton(True)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click


        If txtIDPengguna.Text = lblIDPengguna.Text Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub


        ElseIf MsgBox("Apakah Anda yakin akan menghapus " & txtIDPengguna.Text & "-" & txtNamaPengguna.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolPengguna.deleteData(txtIDPengguna.Text)
            MsgBox("Data berhasil dihapus !")
        End If
        RefreshGrid()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.PenggunaTableAdapter.FillBy1(Me.Pengguna._Pengguna)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cmbUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUser.SelectedIndexChanged
        IsiBox(baris)
        RefreshGrid()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class