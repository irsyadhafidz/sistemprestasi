<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDataPerlombaan = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnDataSiswa = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnDataPrestasi = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnDataPengguna = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(125, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1240, 768)
        Me.Panel1.TabIndex = 1
        '
        'btnDataPerlombaan
        '
        Me.btnDataPerlombaan.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDataPerlombaan.color = System.Drawing.Color.RoyalBlue
        Me.btnDataPerlombaan.colorActive = System.Drawing.Color.RoyalBlue
        Me.btnDataPerlombaan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDataPerlombaan.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDataPerlombaan.ForeColor = System.Drawing.Color.White
        Me.btnDataPerlombaan.Image = Global.WindowsApp1.My.Resources.Resources.icons8_winner_100
        Me.btnDataPerlombaan.ImagePosition = 13
        Me.btnDataPerlombaan.ImageZoom = 50
        Me.btnDataPerlombaan.LabelPosition = 26
        Me.btnDataPerlombaan.LabelText = "Data Perlombaan"
        Me.btnDataPerlombaan.Location = New System.Drawing.Point(2, 176)
        Me.btnDataPerlombaan.Margin = New System.Windows.Forms.Padding(6)
        Me.btnDataPerlombaan.Name = "btnDataPerlombaan"
        Me.btnDataPerlombaan.Size = New System.Drawing.Size(128, 118)
        Me.btnDataPerlombaan.TabIndex = 7
        '
        'btnDataSiswa
        '
        Me.btnDataSiswa.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDataSiswa.color = System.Drawing.Color.RoyalBlue
        Me.btnDataSiswa.colorActive = System.Drawing.Color.RoyalBlue
        Me.btnDataSiswa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDataSiswa.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDataSiswa.ForeColor = System.Drawing.Color.White
        Me.btnDataSiswa.Image = Global.WindowsApp1.My.Resources.Resources.icons8_student_100
        Me.btnDataSiswa.ImagePosition = 13
        Me.btnDataSiswa.ImageZoom = 50
        Me.btnDataSiswa.LabelPosition = 26
        Me.btnDataSiswa.LabelText = "Data Siswa"
        Me.btnDataSiswa.Location = New System.Drawing.Point(2, 26)
        Me.btnDataSiswa.Margin = New System.Windows.Forms.Padding(6)
        Me.btnDataSiswa.Name = "btnDataSiswa"
        Me.btnDataSiswa.Size = New System.Drawing.Size(128, 118)
        Me.btnDataSiswa.TabIndex = 5
        '
        'btnDataPrestasi
        '
        Me.btnDataPrestasi.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDataPrestasi.color = System.Drawing.Color.RoyalBlue
        Me.btnDataPrestasi.colorActive = System.Drawing.Color.RoyalBlue
        Me.btnDataPrestasi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDataPrestasi.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDataPrestasi.ForeColor = System.Drawing.Color.White
        Me.btnDataPrestasi.Image = Global.WindowsApp1.My.Resources.Resources.icons8_purchase_ordaer_100
        Me.btnDataPrestasi.ImagePosition = 13
        Me.btnDataPrestasi.ImageZoom = 50
        Me.btnDataPrestasi.LabelPosition = 26
        Me.btnDataPrestasi.LabelText = "Data Prestasi"
        Me.btnDataPrestasi.Location = New System.Drawing.Point(2, 324)
        Me.btnDataPrestasi.Margin = New System.Windows.Forms.Padding(6)
        Me.btnDataPrestasi.Name = "btnDataPrestasi"
        Me.btnDataPrestasi.Size = New System.Drawing.Size(128, 118)
        Me.btnDataPrestasi.TabIndex = 4
        '
        'btnDataPengguna
        '
        Me.btnDataPengguna.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDataPengguna.color = System.Drawing.Color.RoyalBlue
        Me.btnDataPengguna.colorActive = System.Drawing.Color.RoyalBlue
        Me.btnDataPengguna.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDataPengguna.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDataPengguna.ForeColor = System.Drawing.Color.White
        Me.btnDataPengguna.Image = Global.WindowsApp1.My.Resources.Resources.icons8_account_100
        Me.btnDataPengguna.ImagePosition = 13
        Me.btnDataPengguna.ImageZoom = 50
        Me.btnDataPengguna.LabelPosition = 26
        Me.btnDataPengguna.LabelText = "Data Pengguna"
        Me.btnDataPengguna.Location = New System.Drawing.Point(2, 469)
        Me.btnDataPengguna.Margin = New System.Windows.Forms.Padding(6)
        Me.btnDataPengguna.Name = "btnDataPengguna"
        Me.btnDataPengguna.Size = New System.Drawing.Size(128, 118)
        Me.btnDataPengguna.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnExit.color = System.Drawing.Color.RoyalBlue
        Me.btnExit.colorActive = System.Drawing.Color.RoyalBlue
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Image = Global.WindowsApp1.My.Resources.Resources.icons8_logout_rounded_left_100
        Me.btnExit.ImagePosition = 13
        Me.btnExit.ImageZoom = 50
        Me.btnExit.LabelPosition = 26
        Me.btnExit.LabelText = "Logout"
        Me.btnExit.Location = New System.Drawing.Point(2, 613)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 118)
        Me.btnExit.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.btnDataPerlombaan)
        Me.Panel2.Controls.Add(Me.btnDataSiswa)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnDataPrestasi)
        Me.Panel2.Controls.Add(Me.btnDataPengguna)
        Me.Panel2.Location = New System.Drawing.Point(-2, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(131, 917)
        Me.Panel2.TabIndex = 2
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnDataSiswa As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnDataPrestasi As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnDataPengguna As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnDataPerlombaan As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Panel2 As Panel
End Class
