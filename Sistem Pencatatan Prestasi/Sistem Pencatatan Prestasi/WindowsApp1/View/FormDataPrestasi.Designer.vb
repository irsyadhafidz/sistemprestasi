<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDataPrestasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataPrestasi))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lblNamaAdmin = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotalPoin = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtIDPrestasi = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtJmlPoin = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtIDPerlombaan = New System.Windows.Forms.TextBox()
        Me.btnPilihPerlombaan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtNamaPerlombaan = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtIDSiswa = New System.Windows.Forms.TextBox()
        Me.cmbPeringkat = New System.Windows.Forms.ComboBox()
        Me.txtPoinTambahan = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPilihSiswa = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtNamaSiswa = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtTingkat = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtJenisPerlombaan = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.btnBatal = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnHapus = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnSimpan = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnUbah = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnTambah = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnCari = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.dgPrestasi = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.IdprestasiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamasiswaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaperlombaanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TingkatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeringkatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalpoinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableJoinPrestasiBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Prestasi = New WindowsApp1.Prestasi()
        Me.lblBaris = New System.Windows.Forms.Label()
        Me.txtCari = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblIDPengguna = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCards4 = New Bunifu.Framework.UI.BunifuCards()
        Me.btnExportAll = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SiswaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Siswa = New WindowsApp1.Siswa()
        Me.TableJoinPrestasiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableJoinPrestasiTableAdapter = New WindowsApp1.PrestasiTableAdapters.TableJoinPrestasiTableAdapter()
        Me.SiswaTableAdapter = New WindowsApp1.SiswaTableAdapters.SiswaTableAdapter()
        Me.txt = New System.Windows.Forms.Label()
        Me.BunifuCards1.SuspendLayout()
        Me.BunifuCards3.SuspendLayout()
        CType(Me.btnBatal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHapus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSimpan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUbah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnTambah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards2.SuspendLayout()
        CType(Me.dgPrestasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableJoinPrestasiBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Prestasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.BunifuCards4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiswaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Siswa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableJoinPrestasiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(405, 63)
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
        Me.Label1.Size = New System.Drawing.Size(295, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Data Prestasi"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 19)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Tingkat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 38)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Jenis" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Perlombaan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtTotalPoin
        '
        Me.txtTotalPoin.BorderColor = System.Drawing.Color.RoyalBlue
        Me.txtTotalPoin.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPoin.Location = New System.Drawing.Point(132, 362)
        Me.txtTotalPoin.Multiline = True
        Me.txtTotalPoin.Name = "txtTotalPoin"
        Me.txtTotalPoin.Size = New System.Drawing.Size(304, 29)
        Me.txtTotalPoin.TabIndex = 13
        '
        'txtIDPrestasi
        '
        Me.txtIDPrestasi.BorderColor = System.Drawing.Color.RoyalBlue
        Me.txtIDPrestasi.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDPrestasi.Location = New System.Drawing.Point(132, 32)
        Me.txtIDPrestasi.Multiline = True
        Me.txtIDPrestasi.Name = "txtIDPrestasi"
        Me.txtIDPrestasi.Size = New System.Drawing.Size(304, 29)
        Me.txtIDPrestasi.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 367)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 19)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Total Poin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 38)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nama " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Perlombaan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ID"
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.DarkOrange
        Me.BunifuCards1.Controls.Add(Me.txtJmlPoin)
        Me.BunifuCards1.Controls.Add(Me.txtIDPerlombaan)
        Me.BunifuCards1.Controls.Add(Me.btnPilihPerlombaan)
        Me.BunifuCards1.Controls.Add(Me.txtNamaPerlombaan)
        Me.BunifuCards1.Controls.Add(Me.txtIDSiswa)
        Me.BunifuCards1.Controls.Add(Me.cmbPeringkat)
        Me.BunifuCards1.Controls.Add(Me.txtPoinTambahan)
        Me.BunifuCards1.Controls.Add(Me.Label11)
        Me.BunifuCards1.Controls.Add(Me.Label3)
        Me.BunifuCards1.Controls.Add(Me.btnPilihSiswa)
        Me.BunifuCards1.Controls.Add(Me.txtNamaSiswa)
        Me.BunifuCards1.Controls.Add(Me.txtTingkat)
        Me.BunifuCards1.Controls.Add(Me.txtJenisPerlombaan)
        Me.BunifuCards1.Controls.Add(Me.Label9)
        Me.BunifuCards1.Controls.Add(Me.Label6)
        Me.BunifuCards1.Controls.Add(Me.Label8)
        Me.BunifuCards1.Controls.Add(Me.txtTotalPoin)
        Me.BunifuCards1.Controls.Add(Me.txtIDPrestasi)
        Me.BunifuCards1.Controls.Add(Me.Label7)
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
        'txtJmlPoin
        '
        Me.txtJmlPoin.BorderColor = System.Drawing.Color.RoyalBlue
        Me.txtJmlPoin.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJmlPoin.Location = New System.Drawing.Point(358, 172)
        Me.txtJmlPoin.Multiline = True
        Me.txtJmlPoin.Name = "txtJmlPoin"
        Me.txtJmlPoin.Size = New System.Drawing.Size(78, 20)
        Me.txtJmlPoin.TabIndex = 203
        '
        'txtIDPerlombaan
        '
        Me.txtIDPerlombaan.Location = New System.Drawing.Point(263, 172)
        Me.txtIDPerlombaan.Name = "txtIDPerlombaan"
        Me.txtIDPerlombaan.Size = New System.Drawing.Size(78, 20)
        Me.txtIDPerlombaan.TabIndex = 202
        '
        'btnPilihPerlombaan
        '
        Me.btnPilihPerlombaan.Activecolor = System.Drawing.Color.CornflowerBlue
        Me.btnPilihPerlombaan.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnPilihPerlombaan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPilihPerlombaan.BorderRadius = 0
        Me.btnPilihPerlombaan.ButtonText = "Pilih"
        Me.btnPilihPerlombaan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPilihPerlombaan.DisabledColor = System.Drawing.Color.CornflowerBlue
        Me.btnPilihPerlombaan.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPilihPerlombaan.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPilihPerlombaan.Iconimage = Nothing
        Me.btnPilihPerlombaan.Iconimage_right = Nothing
        Me.btnPilihPerlombaan.Iconimage_right_Selected = Nothing
        Me.btnPilihPerlombaan.Iconimage_Selected = Nothing
        Me.btnPilihPerlombaan.IconMarginLeft = 0
        Me.btnPilihPerlombaan.IconMarginRight = 0
        Me.btnPilihPerlombaan.IconRightVisible = True
        Me.btnPilihPerlombaan.IconRightZoom = 0R
        Me.btnPilihPerlombaan.IconVisible = True
        Me.btnPilihPerlombaan.IconZoom = 90.0R
        Me.btnPilihPerlombaan.IsTab = False
        Me.btnPilihPerlombaan.Location = New System.Drawing.Point(356, 140)
        Me.btnPilihPerlombaan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPilihPerlombaan.Name = "btnPilihPerlombaan"
        Me.btnPilihPerlombaan.Normalcolor = System.Drawing.Color.CornflowerBlue
        Me.btnPilihPerlombaan.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.btnPilihPerlombaan.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPilihPerlombaan.selected = False
        Me.btnPilihPerlombaan.Size = New System.Drawing.Size(80, 29)
        Me.btnPilihPerlombaan.TabIndex = 201
        Me.btnPilihPerlombaan.Text = "Pilih"
        Me.btnPilihPerlombaan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnPilihPerlombaan.Textcolor = System.Drawing.Color.White
        Me.btnPilihPerlombaan.TextFont = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtNamaPerlombaan
        '
        Me.txtNamaPerlombaan.BorderColor = System.Drawing.Color.RoyalBlue
        Me.txtNamaPerlombaan.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaPerlombaan.Location = New System.Drawing.Point(132, 140)
        Me.txtNamaPerlombaan.Multiline = True
        Me.txtNamaPerlombaan.Name = "txtNamaPerlombaan"
        Me.txtNamaPerlombaan.Size = New System.Drawing.Size(209, 29)
        Me.txtNamaPerlombaan.TabIndex = 200
        '
        'txtIDSiswa
        '
        Me.txtIDSiswa.Location = New System.Drawing.Point(263, 117)
        Me.txtIDSiswa.Name = "txtIDSiswa"
        Me.txtIDSiswa.Size = New System.Drawing.Size(78, 20)
        Me.txtIDSiswa.TabIndex = 193
        '
        'cmbPeringkat
        '
        Me.cmbPeringkat.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPeringkat.FormattingEnabled = True
        Me.cmbPeringkat.Items.AddRange(New Object() {"Juara I", "Juara II", "Juara III", "Harapan I", "Harapan II", "Harapan III"})
        Me.cmbPeringkat.Location = New System.Drawing.Point(132, 195)
        Me.cmbPeringkat.Name = "cmbPeringkat"
        Me.cmbPeringkat.Size = New System.Drawing.Size(128, 27)
        Me.cmbPeringkat.TabIndex = 199
        '
        'txtPoinTambahan
        '
        Me.txtPoinTambahan.BorderColor = System.Drawing.Color.RoyalBlue
        Me.txtPoinTambahan.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoinTambahan.Location = New System.Drawing.Point(358, 194)
        Me.txtPoinTambahan.Multiline = True
        Me.txtPoinTambahan.Name = "txtPoinTambahan"
        Me.txtPoinTambahan.Size = New System.Drawing.Size(78, 29)
        Me.txtPoinTambahan.TabIndex = 198
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(277, 189)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 38)
        Me.Label11.TabIndex = 197
        Me.Label11.Text = "Poin " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tambahan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 19)
        Me.Label3.TabIndex = 195
        Me.Label3.Text = "Peringkat"
        '
        'btnPilihSiswa
        '
        Me.btnPilihSiswa.Activecolor = System.Drawing.Color.CornflowerBlue
        Me.btnPilihSiswa.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnPilihSiswa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPilihSiswa.BorderRadius = 0
        Me.btnPilihSiswa.ButtonText = "Pilih"
        Me.btnPilihSiswa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPilihSiswa.DisabledColor = System.Drawing.Color.CornflowerBlue
        Me.btnPilihSiswa.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPilihSiswa.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPilihSiswa.Iconimage = Nothing
        Me.btnPilihSiswa.Iconimage_right = Nothing
        Me.btnPilihSiswa.Iconimage_right_Selected = Nothing
        Me.btnPilihSiswa.Iconimage_Selected = Nothing
        Me.btnPilihSiswa.IconMarginLeft = 0
        Me.btnPilihSiswa.IconMarginRight = 0
        Me.btnPilihSiswa.IconRightVisible = True
        Me.btnPilihSiswa.IconRightZoom = 0R
        Me.btnPilihSiswa.IconVisible = True
        Me.btnPilihSiswa.IconZoom = 90.0R
        Me.btnPilihSiswa.IsTab = False
        Me.btnPilihSiswa.Location = New System.Drawing.Point(356, 85)
        Me.btnPilihSiswa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPilihSiswa.Name = "btnPilihSiswa"
        Me.btnPilihSiswa.Normalcolor = System.Drawing.Color.CornflowerBlue
        Me.btnPilihSiswa.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.btnPilihSiswa.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPilihSiswa.selected = False
        Me.btnPilihSiswa.Size = New System.Drawing.Size(80, 29)
        Me.btnPilihSiswa.TabIndex = 194
        Me.btnPilihSiswa.Text = "Pilih"
        Me.btnPilihSiswa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnPilihSiswa.Textcolor = System.Drawing.Color.White
        Me.btnPilihSiswa.TextFont = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtNamaSiswa
        '
        Me.txtNamaSiswa.BorderColor = System.Drawing.Color.RoyalBlue
        Me.txtNamaSiswa.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaSiswa.Location = New System.Drawing.Point(132, 85)
        Me.txtNamaSiswa.Multiline = True
        Me.txtNamaSiswa.Name = "txtNamaSiswa"
        Me.txtNamaSiswa.Size = New System.Drawing.Size(209, 29)
        Me.txtNamaSiswa.TabIndex = 24
        '
        'txtTingkat
        '
        Me.txtTingkat.BorderColor = System.Drawing.Color.RoyalBlue
        Me.txtTingkat.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTingkat.Location = New System.Drawing.Point(132, 306)
        Me.txtTingkat.Multiline = True
        Me.txtTingkat.Name = "txtTingkat"
        Me.txtTingkat.Size = New System.Drawing.Size(304, 29)
        Me.txtTingkat.TabIndex = 23
        '
        'txtJenisPerlombaan
        '
        Me.txtJenisPerlombaan.BorderColor = System.Drawing.Color.RoyalBlue
        Me.txtJenisPerlombaan.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJenisPerlombaan.Location = New System.Drawing.Point(132, 251)
        Me.txtJenisPerlombaan.Multiline = True
        Me.txtJenisPerlombaan.Name = "txtJenisPerlombaan"
        Me.txtJenisPerlombaan.Size = New System.Drawing.Size(304, 29)
        Me.txtJenisPerlombaan.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 19)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Nama Siswa"
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me
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
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.White
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.DarkOrange
        Me.BunifuCards2.Controls.Add(Me.dgPrestasi)
        Me.BunifuCards2.Controls.Add(Me.lblBaris)
        Me.BunifuCards2.Controls.Add(Me.btnCari)
        Me.BunifuCards2.Controls.Add(Me.txtCari)
        Me.BunifuCards2.Controls.Add(Me.Label10)
        Me.BunifuCards2.LeftSahddow = True
        Me.BunifuCards2.Location = New System.Drawing.Point(696, 165)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(498, 454)
        Me.BunifuCards2.TabIndex = 18
        '
        'dgPrestasi
        '
        Me.dgPrestasi.AllowUserToAddRows = False
        Me.dgPrestasi.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgPrestasi.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgPrestasi.AutoGenerateColumns = False
        Me.dgPrestasi.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgPrestasi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgPrestasi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle11.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPrestasi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgPrestasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPrestasi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdprestasiDataGridViewTextBoxColumn, Me.NamasiswaDataGridViewTextBoxColumn, Me.NamaperlombaanDataGridViewTextBoxColumn, Me.JenisDataGridViewTextBoxColumn, Me.TingkatDataGridViewTextBoxColumn, Me.PeringkatDataGridViewTextBoxColumn, Me.TotalpoinDataGridViewTextBoxColumn})
        Me.dgPrestasi.DataSource = Me.TableJoinPrestasiBindingSource1
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPrestasi.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgPrestasi.DoubleBuffered = True
        Me.dgPrestasi.EnableHeadersVisualStyles = False
        Me.dgPrestasi.HeaderBgColor = System.Drawing.Color.DarkOrange
        Me.dgPrestasi.HeaderForeColor = System.Drawing.Color.Black
        Me.dgPrestasi.Location = New System.Drawing.Point(27, 76)
        Me.dgPrestasi.Name = "dgPrestasi"
        Me.dgPrestasi.ReadOnly = True
        Me.dgPrestasi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgPrestasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPrestasi.ShowCellToolTips = False
        Me.dgPrestasi.Size = New System.Drawing.Size(449, 327)
        Me.dgPrestasi.TabIndex = 196
        '
        'IdprestasiDataGridViewTextBoxColumn
        '
        Me.IdprestasiDataGridViewTextBoxColumn.DataPropertyName = "id_prestasi"
        Me.IdprestasiDataGridViewTextBoxColumn.HeaderText = "id_prestasi"
        Me.IdprestasiDataGridViewTextBoxColumn.Name = "IdprestasiDataGridViewTextBoxColumn"
        Me.IdprestasiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamasiswaDataGridViewTextBoxColumn
        '
        Me.NamasiswaDataGridViewTextBoxColumn.DataPropertyName = "nama_siswa"
        Me.NamasiswaDataGridViewTextBoxColumn.HeaderText = "nama_siswa"
        Me.NamasiswaDataGridViewTextBoxColumn.Name = "NamasiswaDataGridViewTextBoxColumn"
        Me.NamasiswaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaperlombaanDataGridViewTextBoxColumn
        '
        Me.NamaperlombaanDataGridViewTextBoxColumn.DataPropertyName = "nama_perlombaan"
        Me.NamaperlombaanDataGridViewTextBoxColumn.HeaderText = "nama_perlombaan"
        Me.NamaperlombaanDataGridViewTextBoxColumn.Name = "NamaperlombaanDataGridViewTextBoxColumn"
        Me.NamaperlombaanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JenisDataGridViewTextBoxColumn
        '
        Me.JenisDataGridViewTextBoxColumn.DataPropertyName = "jenis"
        Me.JenisDataGridViewTextBoxColumn.HeaderText = "jenis"
        Me.JenisDataGridViewTextBoxColumn.Name = "JenisDataGridViewTextBoxColumn"
        Me.JenisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TingkatDataGridViewTextBoxColumn
        '
        Me.TingkatDataGridViewTextBoxColumn.DataPropertyName = "tingkat"
        Me.TingkatDataGridViewTextBoxColumn.HeaderText = "tingkat"
        Me.TingkatDataGridViewTextBoxColumn.Name = "TingkatDataGridViewTextBoxColumn"
        Me.TingkatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PeringkatDataGridViewTextBoxColumn
        '
        Me.PeringkatDataGridViewTextBoxColumn.DataPropertyName = "peringkat"
        Me.PeringkatDataGridViewTextBoxColumn.HeaderText = "peringkat"
        Me.PeringkatDataGridViewTextBoxColumn.Name = "PeringkatDataGridViewTextBoxColumn"
        Me.PeringkatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalpoinDataGridViewTextBoxColumn
        '
        Me.TotalpoinDataGridViewTextBoxColumn.DataPropertyName = "total_poin"
        Me.TotalpoinDataGridViewTextBoxColumn.HeaderText = "total_poin"
        Me.TotalpoinDataGridViewTextBoxColumn.Name = "TotalpoinDataGridViewTextBoxColumn"
        Me.TotalpoinDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TableJoinPrestasiBindingSource1
        '
        Me.TableJoinPrestasiBindingSource1.DataMember = "TableJoinPrestasi"
        Me.TableJoinPrestasiBindingSource1.DataSource = Me.Prestasi
        '
        'Prestasi
        '
        Me.Prestasi.DataSetName = "Prestasi"
        Me.Prestasi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblBaris
        '
        Me.lblBaris.AutoSize = True
        Me.lblBaris.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBaris.Location = New System.Drawing.Point(23, 417)
        Me.lblBaris.Name = "lblBaris"
        Me.lblBaris.Size = New System.Drawing.Size(63, 19)
        Me.lblBaris.TabIndex = 197
        Me.lblBaris.Text = "Total Row"
        Me.lblBaris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BunifuCards4)
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
        Me.Panel1.TabIndex = 2
        '
        'BunifuCards4
        '
        Me.BunifuCards4.BackColor = System.Drawing.Color.White
        Me.BunifuCards4.BorderRadius = 5
        Me.BunifuCards4.BottomSahddow = True
        Me.BunifuCards4.color = System.Drawing.Color.DarkOrange
        Me.BunifuCards4.Controls.Add(Me.txt)
        Me.BunifuCards4.Controls.Add(Me.btnExportAll)
        Me.BunifuCards4.Controls.Add(Me.cmbFilter)
        Me.BunifuCards4.LeftSahddow = True
        Me.BunifuCards4.Location = New System.Drawing.Point(696, 634)
        Me.BunifuCards4.Name = "BunifuCards4"
        Me.BunifuCards4.RightSahddow = True
        Me.BunifuCards4.ShadowDepth = 20
        Me.BunifuCards4.Size = New System.Drawing.Size(498, 68)
        Me.BunifuCards4.TabIndex = 193
        '
        'btnExportAll
        '
        Me.btnExportAll.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnExportAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnExportAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExportAll.BorderRadius = 0
        Me.btnExportAll.ButtonText = "Export Data"
        Me.btnExportAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportAll.DisabledColor = System.Drawing.Color.Gray
        Me.btnExportAll.Font = New System.Drawing.Font("HelveticaNowDisplay Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportAll.Iconcolor = System.Drawing.Color.Transparent
        Me.btnExportAll.Iconimage = Global.WindowsApp1.My.Resources.Resources.icons8_export_pdf_100
        Me.btnExportAll.Iconimage_right = Nothing
        Me.btnExportAll.Iconimage_right_Selected = Nothing
        Me.btnExportAll.Iconimage_Selected = Nothing
        Me.btnExportAll.IconMarginLeft = 0
        Me.btnExportAll.IconMarginRight = 0
        Me.btnExportAll.IconRightVisible = False
        Me.btnExportAll.IconRightZoom = 0R
        Me.btnExportAll.IconVisible = True
        Me.btnExportAll.IconZoom = 45.0R
        Me.btnExportAll.IsTab = False
        Me.btnExportAll.Location = New System.Drawing.Point(375, 18)
        Me.btnExportAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExportAll.Name = "btnExportAll"
        Me.btnExportAll.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnExportAll.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnExportAll.OnHoverTextColor = System.Drawing.Color.White
        Me.btnExportAll.selected = False
        Me.btnExportAll.Size = New System.Drawing.Size(102, 35)
        Me.btnExportAll.TabIndex = 3
        Me.btnExportAll.Text = "Export Data"
        Me.btnExportAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnExportAll.Textcolor = System.Drawing.Color.White
        Me.btnExportAll.TextFont = New System.Drawing.Font("HelveticaNowDisplay Bold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cmbFilter
        '
        Me.cmbFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"Export All", "Export Selection"})
        Me.cmbFilter.Location = New System.Drawing.Point(97, 18)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(258, 24)
        Me.cmbFilter.TabIndex = 2
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
        'SiswaBindingSource1
        '
        Me.SiswaBindingSource1.DataMember = "Siswa"
        Me.SiswaBindingSource1.DataSource = Me.SiswaBindingSource
        '
        'SiswaBindingSource
        '
        Me.SiswaBindingSource.DataSource = Me.Siswa
        Me.SiswaBindingSource.Position = 0
        '
        'Siswa
        '
        Me.Siswa.DataSetName = "Siswa"
        Me.Siswa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableJoinPrestasiBindingSource
        '
        Me.TableJoinPrestasiBindingSource.DataMember = "TableJoinPrestasi"
        Me.TableJoinPrestasiBindingSource.DataSource = Me.Prestasi
        '
        'TableJoinPrestasiTableAdapter
        '
        Me.TableJoinPrestasiTableAdapter.ClearBeforeFill = True
        '
        'SiswaTableAdapter
        '
        Me.SiswaTableAdapter.ClearBeforeFill = True
        '
        'txt
        '
        Me.txt.AutoSize = True
        Me.txt.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.Location = New System.Drawing.Point(23, 18)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(62, 19)
        Me.txt.TabIndex = 198
        Me.txt.Text = "Pilih Data"
        Me.txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormDataPrestasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1240, 768)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormDataPrestasi"
        Me.Text = "Form2"
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.BunifuCards3.ResumeLayout(False)
        CType(Me.btnBatal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHapus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSimpan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUbah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnTambah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        CType(Me.dgPrestasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableJoinPrestasiBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Prestasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BunifuCards4.ResumeLayout(False)
        Me.BunifuCards4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiswaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Siswa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableJoinPrestasiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnBatal As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnHapus As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnSimpan As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnUbah As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnTambah As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnCari As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtCari As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTotalPoin As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtIDPrestasi As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblIDPengguna As Label
    Friend WithEvents lblNamaAdmin As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTingkat As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtJenisPerlombaan As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtNamaSiswa As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents btnPilihSiswa As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dgPrestasi As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents lblBaris As Label
    Friend WithEvents cmbPeringkat As ComboBox
    Friend WithEvents txtIDSiswa As TextBox
    Friend WithEvents btnPilihPerlombaan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtNamaPerlombaan As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtIDPerlombaan As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtPoinTambahan As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtJmlPoin As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCards4 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents Prestasi As Prestasi
    Friend WithEvents TableJoinPrestasiBindingSource As BindingSource
    Friend WithEvents TableJoinPrestasiTableAdapter As PrestasiTableAdapters.TableJoinPrestasiTableAdapter
    Friend WithEvents IdprestasiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamasiswaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaperlombaanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JenisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TingkatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeringkatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalpoinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableJoinPrestasiBindingSource1 As BindingSource
    Friend WithEvents SiswaBindingSource As BindingSource
    Friend WithEvents Siswa As Siswa
    Friend WithEvents SiswaBindingSource1 As BindingSource
    Friend WithEvents SiswaTableAdapter As SiswaTableAdapters.SiswaTableAdapter
    Friend WithEvents btnExportAll As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txt As Label
End Class
