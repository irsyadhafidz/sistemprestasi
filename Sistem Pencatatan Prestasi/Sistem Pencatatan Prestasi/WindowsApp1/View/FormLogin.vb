Public Class FormLogin

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtUsername.Select()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        DTGrid = KontrolPengguna.loginPengguna(txtUsername.Text).ToTable

        If DTGrid.Rows.Count > 0 Then
            EntitasPengguna.id_pengguna = DTGrid.Rows(0).Item(0)
            EntitasPengguna.nama_pengguna = DTGrid.Rows(0).Item(1)
            EntitasPengguna.username = DTGrid.Rows(0).Item(2)
            EntitasPengguna.password = DTGrid.Rows(0).Item(3)



            KODELOG = EntitasPengguna.id_pengguna
            NAMALOG = EntitasPengguna.nama_pengguna


            If txtPassword.Text = EntitasPengguna.password Then

                Dashboard.Show()
                txtPassword.Text = ""
                txtUsername.Text = ""
                Me.Hide()

            ElseIf txtPassword.Text = "" Then
                MessageBox.Show("PASSWORD TIDAK BOLEH KOSONG !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Text = ""
                txtUsername.Focus()

            Else
                MessageBox.Show("PASSWORD SALAH !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Text = ""
                txtUsername.Focus()

            End If
        ElseIf txtUsername.Text = "" Then
            MessageBox.Show("USERNAME TIDAK BOLEH KOSONG !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Text = ""
            txtUsername.Focus()

        ElseIf txtPassword.Text = "" And txtUsername.Text = "" Then
            MessageBox.Show("USERNAME DAN PASSWORD TIDAK BOLEH KOSONG !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Text = ""
            txtUsername.Focus()



        Else
            MessageBox.Show("Username tidak dikenali! Harap mengisikan data yang benar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Text = ""
            txtUsername.Text = ""
            txtUsername.Focus()
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Application.Exit()
    End Sub

    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles txtUsername.OnValueChanged

    End Sub

    Private Sub txtPassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtPassword.OnValueChanged
        txtPassword.isPassword = True
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If (e.KeyChar = Chr(13)) Then
            DTGrid = KontrolPengguna.loginPengguna(txtUsername.Text).ToTable

            If DTGrid.Rows.Count > 0 Then
                EntitasPengguna.id_pengguna = DTGrid.Rows(0).Item(0)
                EntitasPengguna.nama_pengguna = DTGrid.Rows(0).Item(1)
                EntitasPengguna.username = DTGrid.Rows(0).Item(2)
                EntitasPengguna.password = DTGrid.Rows(0).Item(3)



                KODELOG = EntitasPengguna.id_pengguna
                NAMALOG = EntitasPengguna.nama_pengguna


                If txtPassword.Text = EntitasPengguna.password Then
                    Dashboard.Show()
                    txtPassword.Text = ""
                    txtUsername.Text = ""
                    Me.Hide()

                ElseIf txtPassword.Text = "" Then
                    MessageBox.Show("PASSWORD TIDAK BOLEH KOSONG !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtPassword.Text = ""
                    txtPassword.Focus()

                Else
                    MessageBox.Show("PASSWORD SALAH !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtPassword.Text = ""
                    txtPassword.Focus()

                End If
            ElseIf txtUsername.Text = "" Then
                MessageBox.Show("USERNAME TIDAK BOLEH KOSONG !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Text = ""
                txtUsername.Focus()

            ElseIf txtPassword.Text = "" And txtUsername.Text = "" Then
                MessageBox.Show("USERNAME DAN PASSWORD TIDAK BOLEH KOSONG !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Text = ""
                txtUsername.Focus()



            Else
                MessageBox.Show("Username tidak dikenali! Harap mengisikan data yang benar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Text = ""
                txtUsername.Text = ""
                txtUsername.Focus()
            End If
        End If
    End Sub


End Class