<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entry_Resep
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListViewResep = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtJnsKelamin = New System.Windows.Forms.TextBox()
        Me.txtNoPendaftaran = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNmDokter = New System.Windows.Forms.TextBox()
        Me.btnCariPendaftaran = New System.Windows.Forms.Button()
        Me.txtNmPasien = New System.Windows.Forms.TextBox()
        Me.txtNoPasien = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtUsia = New System.Windows.Forms.TextBox()
        Me.dtpTgl_Pendaftaran = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpTgl_Resep = New System.Windows.Forms.DateTimePicker()
        Me.btnTambahObat = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtNoResep = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtJnsObat = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAturanPakai = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtJmlObat = New System.Windows.Forms.TextBox()
        Me.txtHrgObat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKdObat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNmObat = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCariObat = New System.Windows.Forms.Button()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSatuan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListViewResep)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 435)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(731, 248)
        Me.GroupBox2.TabIndex = 85
        Me.GroupBox2.TabStop = False
        '
        'ListViewResep
        '
        Me.ListViewResep.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListViewResep.FullRowSelect = True
        Me.ListViewResep.GridLines = True
        Me.ListViewResep.Location = New System.Drawing.Point(19, 21)
        Me.ListViewResep.Name = "ListViewResep"
        Me.ListViewResep.Size = New System.Drawing.Size(699, 203)
        Me.ListViewResep.TabIndex = 65
        Me.ListViewResep.UseCompatibleStateImageBehavior = False
        Me.ListViewResep.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Kode Obat"
        Me.ColumnHeader1.Width = 104
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Obat"
        Me.ColumnHeader2.Width = 259
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Jumlah Obat"
        Me.ColumnHeader3.Width = 97
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Aturan Pakai"
        Me.ColumnHeader4.Width = 227
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnKeluar)
        Me.GroupBox3.Controls.Add(Me.btnBatal)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox3.Controls.Add(Me.btnSimpan)
        Me.GroupBox3.Location = New System.Drawing.Point(769, 547)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(466, 136)
        Me.GroupBox3.TabIndex = 84
        Me.GroupBox3.TabStop = False
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(307, 93)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(145, 37)
        Me.btnKeluar.TabIndex = 68
        Me.btnKeluar.Text = "KELUAR"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(307, 21)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(145, 37)
        Me.btnBatal.TabIndex = 67
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(879, 21)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(96, 17)
        Me.Label24.TabIndex = 63
        Me.Label24.Text = "Tanggal Lahir"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(993, 21)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker3.TabIndex = 64
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(15, 21)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(145, 37)
        Me.btnSimpan.TabIndex = 65
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(856, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 17)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "Tanggal Resep"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtJnsKelamin)
        Me.GroupBox1.Controls.Add(Me.txtNoPendaftaran)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtNmDokter)
        Me.GroupBox1.Controls.Add(Me.btnCariPendaftaran)
        Me.GroupBox1.Controls.Add(Me.txtNmPasien)
        Me.GroupBox1.Controls.Add(Me.txtNoPasien)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtUsia)
        Me.GroupBox1.Controls.Add(Me.dtpTgl_Pendaftaran)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(548, 274)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Pendaftaran"
        '
        'txtJnsKelamin
        '
        Me.txtJnsKelamin.Location = New System.Drawing.Point(164, 151)
        Me.txtJnsKelamin.MaxLength = 12
        Me.txtJnsKelamin.Name = "txtJnsKelamin"
        Me.txtJnsKelamin.Size = New System.Drawing.Size(110, 22)
        Me.txtJnsKelamin.TabIndex = 57
        '
        'txtNoPendaftaran
        '
        Me.txtNoPendaftaran.Location = New System.Drawing.Point(164, 36)
        Me.txtNoPendaftaran.Name = "txtNoPendaftaran"
        Me.txtNoPendaftaran.Size = New System.Drawing.Size(158, 22)
        Me.txtNoPendaftaran.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 17)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Nomor Pendaftaran"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Nama Dokter"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Nama Pasien"
        '
        'txtNmDokter
        '
        Me.txtNmDokter.Location = New System.Drawing.Point(164, 226)
        Me.txtNmDokter.MaxLength = 30
        Me.txtNmDokter.Name = "txtNmDokter"
        Me.txtNmDokter.Size = New System.Drawing.Size(363, 22)
        Me.txtNmDokter.TabIndex = 32
        '
        'btnCariPendaftaran
        '
        Me.btnCariPendaftaran.Location = New System.Drawing.Point(328, 36)
        Me.btnCariPendaftaran.Name = "btnCariPendaftaran"
        Me.btnCariPendaftaran.Size = New System.Drawing.Size(75, 23)
        Me.btnCariPendaftaran.TabIndex = 33
        Me.btnCariPendaftaran.Text = "CARI"
        Me.btnCariPendaftaran.UseVisualStyleBackColor = True
        '
        'txtNmPasien
        '
        Me.txtNmPasien.Location = New System.Drawing.Point(164, 123)
        Me.txtNmPasien.MaxLength = 30
        Me.txtNmPasien.Name = "txtNmPasien"
        Me.txtNmPasien.Size = New System.Drawing.Size(363, 22)
        Me.txtNmPasien.TabIndex = 32
        '
        'txtNoPasien
        '
        Me.txtNoPasien.Location = New System.Drawing.Point(164, 95)
        Me.txtNoPasien.MaxLength = 20
        Me.txtNoPasien.Name = "txtNoPasien"
        Me.txtNoPasien.Size = New System.Drawing.Size(158, 22)
        Me.txtNoPasien.TabIndex = 35
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(61, 95)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 17)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Nomor Pasien"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(16, 70)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(142, 17)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Tanggal Pendaftaran"
        '
        'txtUsia
        '
        Me.txtUsia.Location = New System.Drawing.Point(164, 179)
        Me.txtUsia.MaxLength = 3
        Me.txtUsia.Name = "txtUsia"
        Me.txtUsia.Size = New System.Drawing.Size(55, 22)
        Me.txtUsia.TabIndex = 37
        '
        'dtpTgl_Pendaftaran
        '
        Me.dtpTgl_Pendaftaran.Location = New System.Drawing.Point(164, 65)
        Me.dtpTgl_Pendaftaran.Name = "dtpTgl_Pendaftaran"
        Me.dtpTgl_Pendaftaran.Size = New System.Drawing.Size(200, 22)
        Me.dtpTgl_Pendaftaran.TabIndex = 45
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(61, 154)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(95, 17)
        Me.Label20.TabIndex = 44
        Me.Label20.Text = "Jenis Kelamin"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(225, 182)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 17)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "Tahun"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(120, 182)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 17)
        Me.Label22.TabIndex = 41
        Me.Label22.Text = "Usia"
        '
        'dtpTgl_Resep
        '
        Me.dtpTgl_Resep.Location = New System.Drawing.Point(1004, 21)
        Me.dtpTgl_Resep.Name = "dtpTgl_Resep"
        Me.dtpTgl_Resep.Size = New System.Drawing.Size(200, 22)
        Me.dtpTgl_Resep.TabIndex = 80
        '
        'btnTambahObat
        '
        Me.btnTambahObat.Location = New System.Drawing.Point(495, 227)
        Me.btnTambahObat.Name = "btnTambahObat"
        Me.btnTambahObat.Size = New System.Drawing.Size(145, 41)
        Me.btnTambahObat.TabIndex = 83
        Me.btnTambahObat.Text = "TAMBAH"
        Me.btnTambahObat.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(518, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(208, 34)
        Me.Label14.TabIndex = 81
        Me.Label14.Text = "ENTRY RESEP"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtNoResep)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Controls.Add(Me.dtpTgl_Resep)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Location = New System.Drawing.Point(17, 69)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1216, 58)
        Me.GroupBox6.TabIndex = 87
        Me.GroupBox6.TabStop = False
        '
        'txtNoResep
        '
        Me.txtNoResep.Location = New System.Drawing.Point(158, 24)
        Me.txtNoResep.Name = "txtNoResep"
        Me.txtNoResep.Size = New System.Drawing.Size(158, 22)
        Me.txtNoResep.TabIndex = 89
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(20, 27)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(95, 17)
        Me.Label27.TabIndex = 88
        Me.Label27.Text = "Nomor Resep"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtJnsObat)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtAturanPakai)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtJmlObat)
        Me.GroupBox4.Controls.Add(Me.txtHrgObat)
        Me.GroupBox4.Controls.Add(Me.btnTambahObat)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtKdObat)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtNmObat)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.btnCariObat)
        Me.GroupBox4.Controls.Add(Me.txtStock)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtSatuan)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(587, 140)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(646, 274)
        Me.GroupBox4.TabIndex = 88
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Data Obat"
        '
        'txtJnsObat
        '
        Me.txtJnsObat.Location = New System.Drawing.Point(164, 92)
        Me.txtJnsObat.Name = "txtJnsObat"
        Me.txtJnsObat.Size = New System.Drawing.Size(144, 22)
        Me.txtJnsObat.TabIndex = 88
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(50, 238)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 17)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "Aturan Pakai"
        '
        'txtAturanPakai
        '
        Me.txtAturanPakai.Location = New System.Drawing.Point(164, 235)
        Me.txtAturanPakai.MaxLength = 20
        Me.txtAturanPakai.Name = "txtAturanPakai"
        Me.txtAturanPakai.Size = New System.Drawing.Size(144, 22)
        Me.txtAturanPakai.TabIndex = 86
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(50, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 17)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "Jumlah Obat"
        '
        'txtJmlObat
        '
        Me.txtJmlObat.Location = New System.Drawing.Point(164, 207)
        Me.txtJmlObat.MaxLength = 2
        Me.txtJmlObat.Name = "txtJmlObat"
        Me.txtJmlObat.Size = New System.Drawing.Size(45, 22)
        Me.txtJmlObat.TabIndex = 84
        '
        'txtHrgObat
        '
        Me.txtHrgObat.Location = New System.Drawing.Point(197, 123)
        Me.txtHrgObat.Name = "txtHrgObat"
        Me.txtHrgObat.Size = New System.Drawing.Size(84, 22)
        Me.txtHrgObat.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Rp."
        '
        'txtKdObat
        '
        Me.txtKdObat.Location = New System.Drawing.Point(164, 36)
        Me.txtKdObat.Name = "txtKdObat"
        Me.txtKdObat.Size = New System.Drawing.Size(158, 22)
        Me.txtKdObat.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Kode Obat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Nama Obat"
        '
        'txtNmObat
        '
        Me.txtNmObat.Location = New System.Drawing.Point(164, 64)
        Me.txtNmObat.Name = "txtNmObat"
        Me.txtNmObat.Size = New System.Drawing.Size(363, 22)
        Me.txtNmObat.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(50, 182)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 17)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Stock"
        '
        'btnCariObat
        '
        Me.btnCariObat.Location = New System.Drawing.Point(328, 36)
        Me.btnCariObat.Name = "btnCariObat"
        Me.btnCariObat.Size = New System.Drawing.Size(75, 23)
        Me.btnCariObat.TabIndex = 33
        Me.btnCariObat.Text = "CARI"
        Me.btnCariObat.UseVisualStyleBackColor = True
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(164, 179)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(84, 22)
        Me.txtStock.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Jenis Obat"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(50, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 17)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Satuan"
        '
        'txtSatuan
        '
        Me.txtSatuan.Location = New System.Drawing.Point(164, 151)
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.Size = New System.Drawing.Size(144, 22)
        Me.txtSatuan.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(50, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 17)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Harga Obat"
        '
        'Entry_Resep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 698)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label14)
        Me.Name = "Entry_Resep"
        Me.Text = "Entry Resep"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListViewResep As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtJnsKelamin As System.Windows.Forms.TextBox
    Friend WithEvents txtNoPendaftaran As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNmDokter As System.Windows.Forms.TextBox
    Friend WithEvents btnCariPendaftaran As System.Windows.Forms.Button
    Friend WithEvents txtNmPasien As System.Windows.Forms.TextBox
    Friend WithEvents txtNoPasien As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtUsia As System.Windows.Forms.TextBox
    Friend WithEvents dtpTgl_Pendaftaran As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents dtpTgl_Resep As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnTambahObat As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoResep As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHrgObat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKdObat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNmObat As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnCariObat As System.Windows.Forms.Button
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSatuan As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAturanPakai As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtJmlObat As System.Windows.Forms.TextBox
    Friend WithEvents txtJnsObat As System.Windows.Forms.TextBox
End Class
