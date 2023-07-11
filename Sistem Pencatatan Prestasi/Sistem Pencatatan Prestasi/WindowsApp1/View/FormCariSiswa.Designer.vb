<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCariSiswa
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
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.LVSiswa = New System.Windows.Forms.ListView()
        Me.lblBaris = New System.Windows.Forms.Label()
        Me.btnCari = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtCari = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BunifuCards2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.White
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.DarkOrange
        Me.BunifuCards2.Controls.Add(Me.LVSiswa)
        Me.BunifuCards2.Controls.Add(Me.lblBaris)
        Me.BunifuCards2.Controls.Add(Me.btnCari)
        Me.BunifuCards2.Controls.Add(Me.txtCari)
        Me.BunifuCards2.Controls.Add(Me.Label10)
        Me.BunifuCards2.LeftSahddow = True
        Me.BunifuCards2.Location = New System.Drawing.Point(12, 12)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(591, 449)
        Me.BunifuCards2.TabIndex = 19
        '
        'LVSiswa
        '
        Me.LVSiswa.HideSelection = False
        Me.LVSiswa.Location = New System.Drawing.Point(28, 77)
        Me.LVSiswa.Name = "LVSiswa"
        Me.LVSiswa.Size = New System.Drawing.Size(535, 327)
        Me.LVSiswa.TabIndex = 196
        Me.LVSiswa.UseCompatibleStateImageBehavior = False
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
        Me.btnCari.Location = New System.Drawing.Point(483, 24)
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
        Me.txtCari.Size = New System.Drawing.Size(368, 29)
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
        'FormCariSiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(615, 480)
        Me.Controls.Add(Me.BunifuCards2)
        Me.Name = "FormCariSiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCariSiswa"
        Me.TopMost = True
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblBaris As Label
    Friend WithEvents btnCari As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtCari As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents LVSiswa As ListView
End Class
