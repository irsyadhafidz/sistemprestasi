<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDataSiswa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataSiswa))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.btnBatal = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnHapus = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnSimpan = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnUbah = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnTambah = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.dgSiswa = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.lblBaris = New System.Windows.Forms.Label()
        Me.btnCari = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtCari = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmbKelas = New Bunifu.Framework.UI.BunifuDropdown()
        Me.txtIDSiswa = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbTahunAngkatan = New Bunifu.Framework.UI.BunifuDropdown()
        Me.dateTglLahir = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.txtTempatLahir = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.radPerempuan = New System.Windows.Forms.RadioButton()
        Me.radLaki = New System.Windows.Forms.RadioButton()
        Me.txtNamaSiswa = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtNIS = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblIDPengguna = New System.Windows.Forms.Label()
        Me.lblNamaAdmin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Siswa = New WindowsApp1.Siswa()
        Me.SiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SiswaTableAdapter = New WindowsApp1.SiswaTableAdapters.SiswaTableAdapter()
        Me.IdsiswaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamasiswaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JeniskelaminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KelasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TempatlahirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TgllahirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThangkatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.BunifuCards3.SuspendLayout()
        CType(Me.btnBatal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHapus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSimpan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUbah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnTambah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards2.SuspendLayout()
        CType(Me.dgSiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Siswa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BunifuCards3)
        Me.Panel1.Controls.Add(Me.BunifuCards2)
        Me.Panel1.Controls.Add(Me.BunifuCards1)
        Me.Panel1.Controls.Add(Me.lblIDPengguna)
        Me.Panel1.Controls.Add(Me.lblNamaAdmin)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1240, 768)
        Me.Panel1.TabIndex = 0
        '
        'BunifuCards3
        '
        Me.BunifuCards3.BackColor = System.Drawing.Color.White
        Me.BunifuCards3.BorderRadius = 5
        Me.BunifuCards3.BottomSahddow = True
        Me.BunifuCards3.color = System.Drawing.Color.DarkOrange
        Me.BunifuCards3.Controls.Add(Me.btnBatal)
        Me.BunifuCards3.Controls.Add(Me.btnHapus)
        Me.BunifuCards3.Controls.Add(Me.btnSimpan)
        Me.BunifuCards3.Controls.Add(Me.btnUbah)
        Me.BunifuCards3.Controls.Add(Me.btnTambah)
        Me.BunifuCards3.LeftSahddow = True
        Me.BunifuCards3.Location = New System.Drawing.Point(547, 165)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = True
        Me.BunifuCards3.ShadowDepth = 20
        Me.BunifuCards3.Size = New System.Drawing.Size(120, 454)
        Me.BunifuCards3.TabIndex = 192
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Transparent
        Me.btnBatal.Image = Global.WindowsApp1.My.Resources.Resources.icons8_cancel_1002
        Me.btnBatal.ImageActive = Nothing
        Me.btnBatal.InitialImage = Global.WindowsApp1.My.Resources.Resources.icons8_cancel_1001
        Me.btnBatal.Location = New System.Drawing.Point(29, 364)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(60, 60)
        Me.btnBatal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnBatal.TabIndex = 191
        Me.btnBatal.TabStop = False
        Me.btnBatal.Zoom = 10
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.Transparent
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.ImageActive = Nothing
        Me.btnHapus.Location = New System.Drawing.Point(29, 280)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(60, 60)
        Me.btnHapus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnHapus.TabIndex = 190
        Me.btnHapus.TabStop = False
        Me.btnHapus.Zoom = 10
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.Transparent
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.ImageActive = Nothing
        Me.btnSimpan.Location = New System.Drawing.Point(29, 194)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(60, 60)
        Me.btnSimpan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSimpan.TabIndex = 189
        Me.btnSimpan.TabStop = False
        Me.btnSimpan.Zoom = 10
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.Transparent
        Me.btnUbah.Image = CType(resources.GetObject("btnUbah.Image"), System.Drawing.Image)
        Me.btnUbah.ImageActive = Nothing
        Me.btnUbah.Location = New System.Drawing.Point(29, 109)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(60, 60)
        Me.btnUbah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnUbah.TabIndex = 188
        Me.btnUbah.TabStop = False
        Me.btnUbah.Zoom = 10
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.Transparent
        Me.btnTambah.Image = CType(resources.GetObject("btnTambah.Image"), System.Drawing.Image)
        Me.btnTambah.ImageActive = Nothing
        Me.btnTambah.Location = New System.Drawing.Point(29, 23)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(60, 60)
        Me.btnTambah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnTambah.TabIndex = 187
        Me.btnTambah.TabStop = False
        Me.btnTambah.Zoom = 10
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.White
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.DarkOrange
        Me.BunifuCards2.Controls.Add(Me.dgSiswa)
        Me.BunifuCards2.Controls.Add(Me.lblBaris)
        Me.BunifuCards2.Controls.Add(Me.btnCari)
        Me.BunifuCards2.Controls.Add(Me.txtCari)
        Me.BunifuCards2.Controls.Add(Me.Label10)
        Me.BunifuCards2.LeftSahddow = True
        Me.BunifuCards2.Location = New System.Drawing.Point(696, 165)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(499, 460)
        Me.BunifuCards2.TabIndex = 18
        '
        'dgSiswa
        '
        Me.dgSiswa.AllowUserToAddRows = False
        Me.dgSiswa.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgSiswa.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgSiswa.AutoGenerateColumns = False
        Me.dgSiswa.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgSiswa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgSiswa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSiswa.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSiswa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdsiswaDataGridViewTextBoxColumn, Me.NisDataGridViewTextBoxColumn, Me.NamasiswaDataGridViewTextBoxColumn, Me.JeniskelaminDataGridViewTextBoxColumn, Me.KelasDataGridViewTextBoxColumn, Me.TempatlahirDataGridViewTextBoxColumn, Me.TgllahirDataGridViewTextBoxColumn, Me.ThangkatanDataGridViewTextBoxColumn})
        Me.dgSiswa.DataSource = Me.SiswaBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSiswa.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgSiswa.DoubleBuffered = True
        Me.dgSiswa.EnableHeadersVisualStyles = False
        Me.dgSiswa.HeaderBgColor = System.Drawing.Color.DarkOrange
        Me.dgSiswa.HeaderForeColor = System.Drawing.Color.Black
        Me.dgSiswa.Location = New System.Drawing.Point(28, 77)
        Me.dgSiswa.Name = "dgSiswa"
        Me.dgSiswa.ReadOnly = True
        Me.dgSiswa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgSiswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSiswa.ShowCellToolTips = False
        Me.dgSiswa.Size = New System.Drawing.Size(449, 327)
        Me.dgSiswa.TabIndex = 195
        '
        'lblBaris
        '
        Me.lblBaris.AutoSize = True
        Me.lblBaris.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBaris.Location = New System.Drawing.Point(24, 418)
        Me.lblBaris.Name = "lblBaris"
        Me.lblBaris.Size = New System.Drawing.Size(63, 19)
        Me.lblBaris.TabIndex = 195
        Me.lblBaris.Text = "Total Row"
        Me.lblBaris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCari
        '
        Me.btnCari.Activecolor = System.Drawing.Color.CornflowerBlue
        Me.btnCari.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCari.BorderRadius = 0
        Me.btnCari.ButtonText = "Cari"
        Me.btnCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCari.DisabledColor = System.Drawing.Color.CornflowerBlue
        Me.btnCari.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCari.Iconimage = Nothing
        Me.btnCari.Iconimage_right = Nothing
        Me.btnCari.Iconimage_right_Selected = Nothing
        Me.btnCari.Iconimage_Selected = Nothing
        Me.btnCari.IconMarginLeft = 0
        Me.btnCari.IconMarginRight = 0
        Me.btnCari.IconRightVisible = True
        Me.btnCari.IconRightZoom = 0R
        Me.btnCari.IconVisible = True
        Me.btnCari.IconZoom = 90.0R
        Me.btnCari.IsTab = False
        Me.btnCari.Location = New System.Drawing.Point(397, 24)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Normalcolor = System.Drawing.Color.CornflowerBlue
        Me.btnCari.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.btnCari.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCari.selected = False
        Me.btnCari.Size = New System.Drawing.Size(80, 32)
        Me.btnCari.TabIndex = 193
        Me.btnCari.Text = "Cari"
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCari.Textcolor = System.Drawing.Color.White
        Me.btnCari.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtCari
        '
        Me.txtCari.BorderColor = System.Drawing.Color.RoyalBlue
        Me.txtCari.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(97, 24)
        Me.txtCari.Multiline = True
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(280, 29)
        Me.txtCari.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 19)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Cari Data"
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.DarkOrange
        Me.BunifuCards1.Controls.Add(Me.ComboBox2)
        Me.BunifuCards1.Controls.Add(Me.ComboBox1)
        Me.BunifuCards1.Controls.Add(Me.cmbKelas)
        Me.BunifuCards1.Controls.Add(Me.txtIDSiswa)
        Me.BunifuCards1.Controls.Add(Me.Label12)
        Me.BunifuCards1.Controls.Add(Me.Label8)
        Me.BunifuCards1.Controls.Add(Me.cmbTahunAngkatan)
        Me.BunifuCards1.Controls.Add(Me.dateTglLahir)
        Me.BunifuCards1.Controls.Add(Me.txtTempatLahir)
        Me.BunifuCards1.Controls.Add(Me.Label9)
        Me.BunifuCards1.Controls.Add(Me.Label11)
        Me.BunifuCards1.Controls.Add(Me.radPerempuan)
        Me.BunifuCards1.Controls.Add(Me.radLaki)
        Me.BunifuCards1.Controls.Add(Me.txtNamaSiswa)
        Me.BunifuCards1.Controls.Add(Me.txtNIS)
        Me.BunifuCards1.Controls.Add(Me.Label7)
        Me.BunifuCards1.Controls.Add(Me.Label6)
        Me.BunifuCards1.Controls.Add(Me.Label5)
        Me.BunifuCards1.Controls.Add(Me.Label4)
        Me.BunifuCards1.LeftSahddow = True
        Me.BunifuCards1.Location = New System.Drawing.Point(47, 165)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(474, 454)
        Me.BunifuCards1.TabIndex = 7
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"2020/2021", "2021/2022", "2022/2023", "2023/2024"})
        Me.ComboBox2.Location = New System.Drawing.Point(352, 167)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(83, 21)
        Me.ComboBox2.TabIndex = 22
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"- Pilih Kelas -", "X IPA 1", "X IPA 2", "X IPA 3", "X IPA 4", "", "X IPS 1", "X IPS 2", "X IPS 3", "X IPS 4", "", "XI IPA 1", "XI IPA 2", "XI IPA 3", "XI IPA 4", "", "XI IPS 1", "XI IPS 2", "XI IPS 3", "XI IPS 4", "", "XII IPA 1", "XII IPA 2", "XII IPA 3", "XII IPA 4", "", "XII IPS 1", "XII IPS 2", "XII IPS 3", "XII IPS 4"})
        Me.ComboBox1.Location = New System.Drawing.Point(338, 194)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(98, 21)
        Me.ComboBox1.TabIndex = 21
        '
        'cmbKelas
        '
        Me.cmbKelas.BackColor = System.Drawing.Color.Transparent
        Me.cmbKelas.BorderRadius = 3
        Me.cmbKelas.DisabledColor = System.Drawing.Color.Gray
        Me.cmbKelas.ForeColor = System.Drawing.Color.White
        Me.cmbKelas.Items = New String() {"- Pilih Kelas -", "X MIPA 1", "X MIPA 2", "X MIPA 3", "X MIPA 4", "", "X IPS 1", "X IPS 2", "X IPS 3", "X IPS 4", "", "XI MIPA 1", "XI MIPA 2", "XI MIPA 3", "XI MIPA 4", "", "XI IPS 1", "XI IPS 2", "XI IPS 3", "XI IPS 4", "", "XII MIPA 1", "XII MIPA 2", "XII MIPA 3", "XII MIPA 4", "", "XII IPS 1", "XII IPS 2", "XII IPS 3", "XII IPS 4"}
        Me.cmbKelas.Location = New System.Drawing.Point(132, 224)
        Me.cmbKelas.Name = "cmbKelas"
        Me.cmbKelas.NomalColor = System.Drawing.Color.CornflowerBlue
        Me.cmbKelas.onHoverColor = System.Drawing.Color.CornflowerBlue
        Me.cmbKelas.selectedIndex = -1
        Me.cmbKelas.Size = New System.Drawing.Size(304, 35)
        Me.cmbKelas.TabIndex = 20
        '
        'txtIDSiswa
        '
        Me.txtIDSiswa.BorderColor = System.Drawing.Color.RoyalBlue
        Me.txtIDSiswa.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDSiswa.Location = New System.Drawing.Point(132, 23)
        Me.txtIDSiswa.Multiline = True
        Me.txtIDSiswa.Name = "txtIDSiswa"
        Me.txtIDSiswa.Size = New System.Drawing.Size(304, 29)
        Me.txtIDSiswa.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(30, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 19)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 19)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Kelas"
        '
        'cmbTahunAngkatan
        '
        Me.cmbTahunAngkatan.BackColor = System.Drawing.Color.Transparent
        Me.cmbTahunAngkatan.BorderRadius = 3
        Me.cmbTahunAngkatan.DisabledColor = System.Drawing.Color.Gray
        Me.cmbTahunAngkatan.ForeColor = System.Drawing.Color.White
        Me.cmbTahunAngkatan.Items = New String() {"2020/2021", "2021/2022", "2022/2023", "2023/2024"}
        Me.cmbTahunAngkatan.Location = New System.Drawing.Point(132, 395)
        Me.cmbTahunAngkatan.Name = "cmbTahunAngkatan"
        Me.cmbTahunAngkatan.NomalColor = System.Drawing.Color.CornflowerBlue
        Me.cmbTahunAngkatan.onHoverColor = System.Drawing.Color.CornflowerBlue
        Me.cmbTahunAngkatan.selectedIndex = 0
        Me.cmbTahunAngkatan.Size = New System.Drawing.Size(304, 35)
        Me.cmbTahunAngkatan.TabIndex = 15
        '
        'dateTglLahir
        '
        Me.dateTglLahir.BackColor = System.Drawing.Color.CornflowerBlue
        Me.dateTglLahir.BorderRadius = 0
        Me.dateTglLahir.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTglLahir.ForeColor = System.Drawing.Color.White
        Me.dateTglLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTglLahir.FormatCustom = "yyyy-MM-dd"
        Me.dateTglLahir.Location = New System.Drawing.Point(132, 335)
        Me.dateTglLahir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dateTglLahir.Name = "dateTglLahir"
        Me.dateTglLahir.Size = New System.Drawing.Size(303, 36)
        Me.dateTglLahir.TabIndex = 14
        Me.dateTglLahir.Value = New Date(2023, 6, 25, 0, 0, 0, 0)
        '
        'txtTempatLahir
        '
        Me.txtTempatLahir.BorderColor = System.Drawing.Color.RoyalBlue
        Me.txtTempatLahir.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempatLahir.Location = New System.Drawing.Point(132, 283)
        Me.txtTempatLahir.Multiline = True
        Me.txtTempatLahir.Name = "txtTempatLahir"
        Me.txtTempatLahir.Size = New System.Drawing.Size(304, 29)
        Me.txtTempatLahir.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 393)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 38)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Tahun" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angkatan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 344)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 19)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Tgl Lahir"
        '
        'radPerempuan
        '
        Me.radPerempuan.AutoSize = True
        Me.radPerempuan.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPerempuan.Location = New System.Drawing.Point(214, 178)
        Me.radPerempuan.Name = "radPerempuan"
        Me.radPerempuan.Size = New System.Drawing.Size(92, 23)
        Me.radPerempuan.TabIndex = 8
        Me.radPerempuan.Text = "Perempuan"
        Me.radPerempuan.UseVisualStyleBackColor = True
        '
        'radLaki
        '
        Me.radLaki.AutoSize = True
        Me.radLaki.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLaki.Location = New System.Drawing.Point(132, 178)
        Me.radLaki.Name = "radLaki"
        Me.radLaki.Size = New System.Drawing.Size(76, 23)
        Me.radLaki.TabIndex = 7
        Me.radLaki.Text = "Laki-laki"
        Me.radLaki.UseVisualStyleBackColor = True
        '
        'txtNamaSiswa
        '
        Me.txtNamaSiswa.BorderColor = System.Drawing.Color.RoyalBlue
        Me.txtNamaSiswa.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaSiswa.Location = New System.Drawing.Point(132, 129)
        Me.txtNamaSiswa.Multiline = True
        Me.txtNamaSiswa.Name = "txtNamaSiswa"
        Me.txtNamaSiswa.Size = New System.Drawing.Size(304, 29)
        Me.txtNamaSiswa.TabIndex = 6
        '
        'txtNIS
        '
        Me.txtNIS.BorderColor = System.Drawing.Color.RoyalBlue
        Me.txtNIS.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIS.Location = New System.Drawing.Point(132, 77)
        Me.txtNIS.Multiline = True
        Me.txtNIS.Name = "txtNIS"
        Me.txtNIS.Size = New System.Drawing.Size(304, 29)
        Me.txtNIS.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 19)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Tempat Lahir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "NIS"
        '
        'lblIDPengguna
        '
        Me.lblIDPengguna.AutoSize = True
        Me.lblIDPengguna.BackColor = System.Drawing.Color.DarkOrange
        Me.lblIDPengguna.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDPengguna.Location = New System.Drawing.Point(1049, 81)
        Me.lblIDPengguna.Name = "lblIDPengguna"
        Me.lblIDPengguna.Size = New System.Drawing.Size(55, 24)
        Me.lblIDPengguna.TabIndex = 6
        Me.lblIDPengguna.Text = "Admin"
        '
        'lblNamaAdmin
        '
        Me.lblNamaAdmin.AutoSize = True
        Me.lblNamaAdmin.Font = New System.Drawing.Font("HelveticaNowDisplay Bold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaAdmin.Location = New System.Drawing.Point(1097, 53)
        Me.lblNamaAdmin.Name = "lblNamaAdmin"
        Me.lblNamaAdmin.Size = New System.Drawing.Size(56, 28)
        Me.lblNamaAdmin.TabIndex = 5
        Me.lblNamaAdmin.Text = "Hello"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("HelveticaNowDisplay Bold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1048, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hello"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.man
        Me.PictureBox1.Location = New System.Drawing.Point(945, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(372, 63)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePicker1.TabIndex = 2
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.DarkOrange
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = " "
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(47, 66)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.DarkOrange
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.DarkOrange
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(50, 10)
        Me.BunifuFlatButton1.TabIndex = 1
        Me.BunifuFlatButton1.Text = " "
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HelveticaNowDisplay Bold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Data Siswa"
        '
        'Siswa
        '
        Me.Siswa.DataSetName = "Siswa"
        Me.Siswa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SiswaBindingSource
        '
        Me.SiswaBindingSource.DataMember = "Siswa"
        Me.SiswaBindingSource.DataSource = Me.Siswa
        '
        'SiswaTableAdapter
        '
        Me.SiswaTableAdapter.ClearBeforeFill = True
        '
        'IdsiswaDataGridViewTextBoxColumn
        '
        Me.IdsiswaDataGridViewTextBoxColumn.DataPropertyName = "id_siswa"
        Me.IdsiswaDataGridViewTextBoxColumn.HeaderText = "id_siswa"
        Me.IdsiswaDataGridViewTextBoxColumn.Name = "IdsiswaDataGridViewTextBoxColumn"
        Me.IdsiswaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NisDataGridViewTextBoxColumn
        '
        Me.NisDataGridViewTextBoxColumn.DataPropertyName = "nis"
        Me.NisDataGridViewTextBoxColumn.HeaderText = "nis"
        Me.NisDataGridViewTextBoxColumn.Name = "NisDataGridViewTextBoxColumn"
        Me.NisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamasiswaDataGridViewTextBoxColumn
        '
        Me.NamasiswaDataGridViewTextBoxColumn.DataPropertyName = "nama_siswa"
        Me.NamasiswaDataGridViewTextBoxColumn.HeaderText = "nama_siswa"
        Me.NamasiswaDataGridViewTextBoxColumn.Name = "NamasiswaDataGridViewTextBoxColumn"
        Me.NamasiswaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JeniskelaminDataGridViewTextBoxColumn
        '
        Me.JeniskelaminDataGridViewTextBoxColumn.DataPropertyName = "jenis_kelamin"
        Me.JeniskelaminDataGridViewTextBoxColumn.HeaderText = "jenis_kelamin"
        Me.JeniskelaminDataGridViewTextBoxColumn.Name = "JeniskelaminDataGridViewTextBoxColumn"
        Me.JeniskelaminDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KelasDataGridViewTextBoxColumn
        '
        Me.KelasDataGridViewTextBoxColumn.DataPropertyName = "kelas"
        Me.KelasDataGridViewTextBoxColumn.HeaderText = "kelas"
        Me.KelasDataGridViewTextBoxColumn.Name = "KelasDataGridViewTextBoxColumn"
        Me.KelasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TempatlahirDataGridViewTextBoxColumn
        '
        Me.TempatlahirDataGridViewTextBoxColumn.DataPropertyName = "tempat_lahir"
        Me.TempatlahirDataGridViewTextBoxColumn.HeaderText = "tempat_lahir"
        Me.TempatlahirDataGridViewTextBoxColumn.Name = "TempatlahirDataGridViewTextBoxColumn"
        Me.TempatlahirDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TgllahirDataGridViewTextBoxColumn
        '
        Me.TgllahirDataGridViewTextBoxColumn.DataPropertyName = "tgl_lahir"
        Me.TgllahirDataGridViewTextBoxColumn.HeaderText = "tgl_lahir"
        Me.TgllahirDataGridViewTextBoxColumn.Name = "TgllahirDataGridViewTextBoxColumn"
        Me.TgllahirDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ThangkatanDataGridViewTextBoxColumn
        '
        Me.ThangkatanDataGridViewTextBoxColumn.DataPropertyName = "th_angkatan"
        Me.ThangkatanDataGridViewTextBoxColumn.HeaderText = "th_angkatan"
        Me.ThangkatanDataGridViewTextBoxColumn.Name = "ThangkatanDataGridViewTextBoxColumn"
        Me.ThangkatanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FormDataSiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 768)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormDataSiswa"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BunifuCards3.ResumeLayout(False)
        CType(Me.btnBatal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHapus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSimpan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUbah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnTambah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        CType(Me.dgSiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Siswa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblNamaAdmin As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblIDPengguna As Label
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtNIS As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNamaSiswa As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents radPerempuan As RadioButton
    Friend WithEvents radLaki As RadioButton
    Friend WithEvents txtTempatLahir As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dateTglLahir As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents cmbTahunAngkatan As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label8 As Label
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnBatal As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnHapus As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnSimpan As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnUbah As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnTambah As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtCari As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCari As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label12 As Label
    Friend WithEvents txtIDSiswa As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents cmbKelas As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents lblBaris As Label
    Friend WithEvents dgSiswa As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Siswa As Siswa
    Friend WithEvents SiswaBindingSource As BindingSource
    Friend WithEvents SiswaTableAdapter As SiswaTableAdapters.SiswaTableAdapter
    Friend WithEvents IdsiswaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamasiswaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JeniskelaminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KelasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TempatlahirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TgllahirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ThangkatanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
