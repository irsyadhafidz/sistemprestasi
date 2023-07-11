<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataPengguna
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataPengguna))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lblNamaAdmin = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtNamaPengguna = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtIDPengguna = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.cmbUser = New System.Windows.Forms.ComboBox()
        Me.txtUsername = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.btnBatal = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnHapus = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnSimpan = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnUbah = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnTambah = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnCari = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PenggunaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pengguna = New WindowsApp1.Pengguna()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.dgPengguna = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.IdpenggunaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamapenggunaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblBaris = New System.Windows.Forms.Label()
        Me.txtCari = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblIDPengguna = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PenggunaTableAdapter = New WindowsApp1.PenggunaTableAdapters.PenggunaTableAdapter()
        Me.BunifuCards1.SuspendLayout()
        Me.BunifuCards3.SuspendLayout()
        CType(Me.btnBatal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHapus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSimpan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUbah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnTambah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenggunaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pengguna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards2.SuspendLayout()
        CType(Me.dgPengguna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DateTimePicker1.Location = New System.Drawing.Point(434, 63)
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
        Me.Label1.Size = New System.Drawing.Size(325, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Data Pengguna"
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
        'txtPassword
        '
        Me.txtPassword.BorderColor = System.Drawing.Color.RoyalBlue
        Me.txtPassword.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(132, 193)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(304, 29)
        Me.txtPassword.TabIndex = 13
        '
        'txtNamaPengguna
        '
        Me.txtNamaPengguna.BorderColor = System.Drawing.Color.RoyalBlue
        Me.txtNamaPengguna.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaPengguna.Location = New System.Drawing.Point(132, 85)
        Me.txtNamaPengguna.Multiline = True
        Me.txtNamaPengguna.Name = "txtNamaPengguna"
        Me.txtNamaPengguna.Size = New System.Drawing.Size(304, 29)
        Me.txtNamaPengguna.TabIndex = 6
        '
        'txtIDPengguna
        '
        Me.txtIDPengguna.BorderColor = System.Drawing.Color.RoyalBlue
        Me.txtIDPengguna.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDPengguna.Location = New System.Drawing.Point(132, 32)
        Me.txtIDPengguna.Multiline = True
        Me.txtIDPengguna.Name = "txtIDPengguna"
        Me.txtIDPengguna.Size = New System.Drawing.Size(304, 29)
        Me.txtIDPengguna.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 19)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 38)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nama" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pengguna"
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
        Me.BunifuCards1.Controls.Add(Me.cmbUser)
        Me.BunifuCards1.Controls.Add(Me.txtUsername)
        Me.BunifuCards1.Controls.Add(Me.Label6)
        Me.BunifuCards1.Controls.Add(Me.txtPassword)
        Me.BunifuCards1.Controls.Add(Me.txtNamaPengguna)
        Me.BunifuCards1.Controls.Add(Me.txtIDPengguna)
        Me.BunifuCards1.Controls.Add(Me.Label7)
        Me.BunifuCards1.Controls.Add(Me.Label5)
        Me.BunifuCards1.Controls.Add(Me.Label4)
        Me.BunifuCards1.LeftSahddow = True
        Me.BunifuCards1.Location = New System.Drawing.Point(47, 165)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(474, 318)
        Me.BunifuCards1.TabIndex = 7
        '
        'cmbUser
        '
        Me.cmbUser.FormattingEnabled = True
        Me.cmbUser.Location = New System.Drawing.Point(178, 280)
        Me.cmbUser.Name = "cmbUser"
        Me.cmbUser.Size = New System.Drawing.Size(121, 21)
        Me.cmbUser.TabIndex = 193
        '
        'txtUsername
        '
        Me.txtUsername.BorderColor = System.Drawing.Color.RoyalBlue
        Me.txtUsername.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(132, 139)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(304, 29)
        Me.txtUsername.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 19)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Username"
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
        'PenggunaBindingSource
        '
        Me.PenggunaBindingSource.DataMember = "Pengguna"
        Me.PenggunaBindingSource.DataSource = Me.Pengguna
        '
        'Pengguna
        '
        Me.Pengguna.DataSetName = "Pengguna"
        Me.Pengguna.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.White
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.DarkOrange
        Me.BunifuCards2.Controls.Add(Me.dgPengguna)
        Me.BunifuCards2.Controls.Add(Me.lblBaris)
        Me.BunifuCards2.Controls.Add(Me.btnCari)
        Me.BunifuCards2.Controls.Add(Me.txtCari)
        Me.BunifuCards2.Controls.Add(Me.Label10)
        Me.BunifuCards2.LeftSahddow = True
        Me.BunifuCards2.Location = New System.Drawing.Point(696, 165)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(499, 456)
        Me.BunifuCards2.TabIndex = 18
        '
        'dgPengguna
        '
        Me.dgPengguna.AllowUserToAddRows = False
        Me.dgPengguna.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgPengguna.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgPengguna.AutoGenerateColumns = False
        Me.dgPengguna.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgPengguna.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgPengguna.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPengguna.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgPengguna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPengguna.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdpenggunaDataGridViewTextBoxColumn1, Me.NamapenggunaDataGridViewTextBoxColumn1, Me.UsernameDataGridViewTextBoxColumn1, Me.PasswordDataGridViewTextBoxColumn1})
        Me.dgPengguna.DataSource = Me.PenggunaBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPengguna.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgPengguna.DoubleBuffered = True
        Me.dgPengguna.EnableHeadersVisualStyles = False
        Me.dgPengguna.HeaderBgColor = System.Drawing.Color.DarkOrange
        Me.dgPengguna.HeaderForeColor = System.Drawing.Color.Black
        Me.dgPengguna.Location = New System.Drawing.Point(28, 72)
        Me.dgPengguna.Name = "dgPengguna"
        Me.dgPengguna.ReadOnly = True
        Me.dgPengguna.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgPengguna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPengguna.ShowCellToolTips = False
        Me.dgPengguna.Size = New System.Drawing.Size(449, 338)
        Me.dgPengguna.TabIndex = 194
        '
        'IdpenggunaDataGridViewTextBoxColumn1
        '
        Me.IdpenggunaDataGridViewTextBoxColumn1.DataPropertyName = "id_pengguna"
        Me.IdpenggunaDataGridViewTextBoxColumn1.HeaderText = "id_pengguna"
        Me.IdpenggunaDataGridViewTextBoxColumn1.Name = "IdpenggunaDataGridViewTextBoxColumn1"
        Me.IdpenggunaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NamapenggunaDataGridViewTextBoxColumn1
        '
        Me.NamapenggunaDataGridViewTextBoxColumn1.DataPropertyName = "nama_pengguna"
        Me.NamapenggunaDataGridViewTextBoxColumn1.HeaderText = "nama_pengguna"
        Me.NamapenggunaDataGridViewTextBoxColumn1.Name = "NamapenggunaDataGridViewTextBoxColumn1"
        Me.NamapenggunaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn1
        '
        Me.UsernameDataGridViewTextBoxColumn1.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn1.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn1.Name = "UsernameDataGridViewTextBoxColumn1"
        Me.UsernameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PasswordDataGridViewTextBoxColumn1
        '
        Me.PasswordDataGridViewTextBoxColumn1.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn1.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn1.Name = "PasswordDataGridViewTextBoxColumn1"
        Me.PasswordDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'lblBaris
        '
        Me.lblBaris.AutoSize = True
        Me.lblBaris.Font = New System.Drawing.Font("HelveticaNowDisplay Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBaris.Location = New System.Drawing.Point(20, 423)
        Me.lblBaris.Name = "lblBaris"
        Me.lblBaris.Size = New System.Drawing.Size(63, 19)
        Me.lblBaris.TabIndex = 194
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
        'PenggunaTableAdapter
        '
        Me.PenggunaTableAdapter.ClearBeforeFill = True
        '
        'FormDataPengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1240, 768)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormDataPengguna"
        Me.Text = "Form2"
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.BunifuCards3.ResumeLayout(False)
        CType(Me.btnBatal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHapus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSimpan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUbah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnTambah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenggunaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pengguna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        CType(Me.dgPengguna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtPassword As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtNamaPengguna As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtIDPengguna As WindowsFormsControlLibrary1.BunifuCustomTextbox
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
    Friend WithEvents txtUsername As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents Pengguna As Pengguna
    Friend WithEvents PenggunaBindingSource As BindingSource
    Friend WithEvents PenggunaTableAdapter As PenggunaTableAdapters.PenggunaTableAdapter
    Friend WithEvents lblBaris As Label
    Friend WithEvents cmbUser As ComboBox
    Friend WithEvents dgPengguna As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents IdpenggunaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NamapenggunaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
