<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entry_Data_Pasien
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbGolongan_darah = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNoPasien = New System.Windows.Forms.TextBox()
        Me.txtKK = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNmPasien = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.cmbAgama = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTmptLahir = New System.Windows.Forms.TextBox()
        Me.txtPekerjaan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtUsia = New System.Windows.Forms.TextBox()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.rbPria = New System.Windows.Forms.RadioButton()
        Me.dtpTglLahir = New System.Windows.Forms.DateTimePicker()
        Me.rbWanita = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.dtpNow = New System.Windows.Forms.DateTimePicker()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(173, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(310, 34)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "ENTRY DATA PASIEN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbGolongan_darah)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtNoPasien)
        Me.GroupBox1.Controls.Add(Me.txtKK)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNmPasien)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Controls.Add(Me.cmbAgama)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtTmptLahir)
        Me.GroupBox1.Controls.Add(Me.txtPekerjaan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtUsia)
        Me.GroupBox1.Controls.Add(Me.txtTelepon)
        Me.GroupBox1.Controls.Add(Me.rbPria)
        Me.GroupBox1.Controls.Add(Me.dtpTglLahir)
        Me.GroupBox1.Controls.Add(Me.rbWanita)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(591, 478)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Pasien"
        '
        'cmbGolongan_darah
        '
        Me.cmbGolongan_darah.FormattingEnabled = True
        Me.cmbGolongan_darah.Items.AddRange(New Object() {"--", "A", "B", "AB", "O"})
        Me.cmbGolongan_darah.Location = New System.Drawing.Point(164, 406)
        Me.cmbGolongan_darah.Name = "cmbGolongan_darah"
        Me.cmbGolongan_darah.Size = New System.Drawing.Size(55, 24)
        Me.cmbGolongan_darah.TabIndex = 56
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(50, 437)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 17)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "KK"
        '
        'txtNoPasien
        '
        Me.txtNoPasien.Location = New System.Drawing.Point(164, 36)
        Me.txtNoPasien.Name = "txtNoPasien"
        Me.txtNoPasien.Size = New System.Drawing.Size(158, 22)
        Me.txtNoPasien.TabIndex = 31
        '
        'txtKK
        '
        Me.txtKK.Location = New System.Drawing.Point(164, 434)
        Me.txtKK.MaxLength = 30
        Me.txtKK.Name = "txtKK"
        Me.txtKK.Size = New System.Drawing.Size(363, 22)
        Me.txtKK.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Nomor Pasien"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(50, 409)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 17)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Golongan Darah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Nama Pasien"
        '
        'txtNmPasien
        '
        Me.txtNmPasien.Location = New System.Drawing.Point(164, 64)
        Me.txtNmPasien.MaxLength = 30
        Me.txtNmPasien.Name = "txtNmPasien"
        Me.txtNmPasien.Size = New System.Drawing.Size(363, 22)
        Me.txtNmPasien.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(50, 381)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 17)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Pekerjaan"
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(328, 36)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 33
        Me.btnCari.Text = "CARI"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'cmbAgama
        '
        Me.cmbAgama.FormattingEnabled = True
        Me.cmbAgama.Items.AddRange(New Object() {"--Pilih--", "Islam", "Katolik", "Protestan", "Buddha", "Hindu", "Kong Hu Cu", "Lainnya"})
        Me.cmbAgama.Location = New System.Drawing.Point(164, 348)
        Me.cmbAgama.Name = "cmbAgama"
        Me.cmbAgama.Size = New System.Drawing.Size(121, 24)
        Me.cmbAgama.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Tempat Lahir"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(50, 351)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 17)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Agama"
        '
        'txtTmptLahir
        '
        Me.txtTmptLahir.Location = New System.Drawing.Point(164, 92)
        Me.txtTmptLahir.MaxLength = 20
        Me.txtTmptLahir.Name = "txtTmptLahir"
        Me.txtTmptLahir.Size = New System.Drawing.Size(200, 22)
        Me.txtTmptLahir.TabIndex = 35
        '
        'txtPekerjaan
        '
        Me.txtPekerjaan.Location = New System.Drawing.Point(164, 378)
        Me.txtPekerjaan.MaxLength = 25
        Me.txtPekerjaan.Name = "txtPekerjaan"
        Me.txtPekerjaan.Size = New System.Drawing.Size(239, 22)
        Me.txtPekerjaan.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(50, 323)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 17)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Telepon"
        '
        'txtUsia
        '
        Me.txtUsia.Location = New System.Drawing.Point(164, 175)
        Me.txtUsia.MaxLength = 3
        Me.txtUsia.Name = "txtUsia"
        Me.txtUsia.Size = New System.Drawing.Size(55, 22)
        Me.txtUsia.TabIndex = 37
        '
        'txtTelepon
        '
        Me.txtTelepon.Location = New System.Drawing.Point(164, 320)
        Me.txtTelepon.MaxLength = 12
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(173, 22)
        Me.txtTelepon.TabIndex = 46
        '
        'rbPria
        '
        Me.rbPria.AutoSize = True
        Me.rbPria.Location = New System.Drawing.Point(165, 148)
        Me.rbPria.Name = "rbPria"
        Me.rbPria.Size = New System.Drawing.Size(54, 21)
        Me.rbPria.TabIndex = 38
        Me.rbPria.TabStop = True
        Me.rbPria.Text = "Pria"
        Me.rbPria.UseVisualStyleBackColor = True
        '
        'dtpTglLahir
        '
        Me.dtpTglLahir.Location = New System.Drawing.Point(164, 120)
        Me.dtpTglLahir.Name = "dtpTglLahir"
        Me.dtpTglLahir.Size = New System.Drawing.Size(200, 22)
        Me.dtpTglLahir.TabIndex = 45
        '
        'rbWanita
        '
        Me.rbWanita.AutoSize = True
        Me.rbWanita.Location = New System.Drawing.Point(264, 148)
        Me.rbWanita.Name = "rbWanita"
        Me.rbWanita.Size = New System.Drawing.Size(73, 21)
        Me.rbWanita.TabIndex = 39
        Me.rbWanita.TabStop = True
        Me.rbWanita.Text = "Wanita"
        Me.rbWanita.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(50, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 17)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(225, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Tahun"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(164, 203)
        Me.txtAlamat.MaxLength = 50
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAlamat.Size = New System.Drawing.Size(363, 111)
        Me.txtAlamat.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 17)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Usia"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Alamat"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnKeluar)
        Me.GroupBox2.Controls.Add(Me.btnSimpan)
        Me.GroupBox2.Controls.Add(Me.btnBatal)
        Me.GroupBox2.Controls.Add(Me.btnUbah)
        Me.GroupBox2.Controls.Add(Me.btnHapus)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 565)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(591, 67)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(464, 18)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(104, 34)
        Me.btnKeluar.TabIndex = 33
        Me.btnKeluar.Text = "KELUAR"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(24, 18)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(104, 34)
        Me.btnSimpan.TabIndex = 29
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(354, 18)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(104, 34)
        Me.btnBatal.TabIndex = 32
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(134, 18)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(104, 34)
        Me.btnUbah.TabIndex = 30
        Me.btnUbah.Text = "UBAH"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(244, 18)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(104, 34)
        Me.btnHapus.TabIndex = 31
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'dtpNow
        '
        Me.dtpNow.Location = New System.Drawing.Point(416, 63)
        Me.dtpNow.Name = "dtpNow"
        Me.dtpNow.Size = New System.Drawing.Size(200, 22)
        Me.dtpNow.TabIndex = 57
        Me.dtpNow.Visible = False
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(159, 654)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(324, 34)
        Me.btnCetak.TabIndex = 58
        Me.btnCetak.Text = "CETAK"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'Entry_Data_Pasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 715)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.dtpNow)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label14)
        Me.Name = "Entry_Data_Pasien"
        Me.Text = "Form Entry Data Pasien"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNoPasien As System.Windows.Forms.TextBox
    Friend WithEvents txtKK As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNmPasien As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents cmbAgama As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTmptLahir As System.Windows.Forms.TextBox
    Friend WithEvents txtPekerjaan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtUsia As System.Windows.Forms.TextBox
    Friend WithEvents txtTelepon As System.Windows.Forms.TextBox
    Friend WithEvents rbPria As System.Windows.Forms.RadioButton
    Friend WithEvents dtpTglLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbWanita As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents cmbGolongan_darah As System.Windows.Forms.ComboBox
    Friend WithEvents dtpNow As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCetak As System.Windows.Forms.Button
End Class
