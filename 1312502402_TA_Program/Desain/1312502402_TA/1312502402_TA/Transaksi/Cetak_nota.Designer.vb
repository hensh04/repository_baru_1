<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cetak_nota
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtJnsObat = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAturanPakai = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtJmlObat = New System.Windows.Forms.TextBox()
        Me.txtHrgObat = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
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
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtNoNota = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.dtpTgl_Nota = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.ListViewNota = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNoPasien = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtNoResep = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtJnsKelamin = New System.Windows.Forms.TextBox()
        Me.txtNoPendaftaran = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNmDokter = New System.Windows.Forms.TextBox()
        Me.btnCariResep = New System.Windows.Forms.Button()
        Me.txtNmPasien = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtUsia = New System.Windows.Forms.TextBox()
        Me.dtpTgl_Pendaftaran = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtJnsObat)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtAturanPakai)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtJmlObat)
        Me.GroupBox4.Controls.Add(Me.txtHrgObat)
        Me.GroupBox4.Controls.Add(Me.btnUpdate)
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
        Me.GroupBox4.Location = New System.Drawing.Point(585, 140)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(467, 274)
        Me.GroupBox4.TabIndex = 94
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
        Me.txtAturanPakai.Name = "txtAturanPakai"
        Me.txtAturanPakai.Size = New System.Drawing.Size(84, 22)
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
        Me.txtJmlObat.Name = "txtJmlObat"
        Me.txtJmlObat.Size = New System.Drawing.Size(84, 22)
        Me.txtJmlObat.TabIndex = 84
        '
        'txtHrgObat
        '
        Me.txtHrgObat.Location = New System.Drawing.Point(197, 123)
        Me.txtHrgObat.Name = "txtHrgObat"
        Me.txtHrgObat.Size = New System.Drawing.Size(84, 22)
        Me.txtHrgObat.TabIndex = 55
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(273, 210)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(162, 51)
        Me.btnUpdate.TabIndex = 83
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
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
        Me.txtNmObat.Size = New System.Drawing.Size(283, 22)
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
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtNoNota)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Controls.Add(Me.dtpTgl_Nota)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Location = New System.Drawing.Point(15, 69)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1037, 58)
        Me.GroupBox6.TabIndex = 93
        Me.GroupBox6.TabStop = False
        '
        'txtNoNota
        '
        Me.txtNoNota.Location = New System.Drawing.Point(158, 24)
        Me.txtNoNota.Name = "txtNoNota"
        Me.txtNoNota.Size = New System.Drawing.Size(158, 22)
        Me.txtNoNota.TabIndex = 89
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(61, 26)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(84, 17)
        Me.Label27.TabIndex = 88
        Me.Label27.Text = "Nomor Nota"
        '
        'dtpTgl_Nota
        '
        Me.dtpTgl_Nota.Location = New System.Drawing.Point(773, 24)
        Me.dtpTgl_Nota.Name = "dtpTgl_Nota"
        Me.dtpTgl_Nota.Size = New System.Drawing.Size(200, 22)
        Me.dtpTgl_Nota.TabIndex = 80
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(646, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 17)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "Tanggal Nota"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnHapus)
        Me.GroupBox2.Controls.Add(Me.ListViewNota)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 435)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(869, 206)
        Me.GroupBox2.TabIndex = 92
        Me.GroupBox2.TabStop = False
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(758, 21)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(93, 71)
        Me.btnHapus.TabIndex = 95
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'ListViewNota
        '
        Me.ListViewNota.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader5})
        Me.ListViewNota.FullRowSelect = True
        Me.ListViewNota.GridLines = True
        Me.ListViewNota.Location = New System.Drawing.Point(9, 21)
        Me.ListViewNota.Name = "ListViewNota"
        Me.ListViewNota.Size = New System.Drawing.Size(739, 166)
        Me.ListViewNota.TabIndex = 65
        Me.ListViewNota.UseCompatibleStateImageBehavior = False
        Me.ListViewNota.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Kode Obat"
        Me.ColumnHeader1.Width = 116
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Obat"
        Me.ColumnHeader2.Width = 197
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Harga Obat"
        Me.ColumnHeader3.Width = 119
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Jumlah Obat"
        Me.ColumnHeader4.Width = 90
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Aturan Pakai"
        Me.ColumnHeader6.Width = 73
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Subtotal"
        Me.ColumnHeader5.Width = 140
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(926, 615)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(133, 22)
        Me.txtTotal.TabIndex = 97
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(890, 618)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 17)
        Me.Label16.TabIndex = 96
        Me.Label16.Text = "Rp."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(890, 582)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 17)
        Me.Label17.TabIndex = 95
        Me.Label17.Text = "Total Obat"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnKeluar)
        Me.GroupBox3.Controls.Add(Me.btnBatal)
        Me.GroupBox3.Controls.Add(Me.btnCetak)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 647)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1037, 75)
        Me.GroupBox3.TabIndex = 91
        Me.GroupBox3.TabStop = False
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(872, 21)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(145, 37)
        Me.btnKeluar.TabIndex = 68
        Me.btnKeluar.Text = "KELUAR"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(228, 21)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(145, 37)
        Me.btnBatal.TabIndex = 67
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(9, 21)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(145, 37)
        Me.btnCetak.TabIndex = 65
        Me.btnCetak.Text = "CETAK"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNoPasien)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtNoResep)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtJnsKelamin)
        Me.GroupBox1.Controls.Add(Me.txtNoPendaftaran)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtNmDokter)
        Me.GroupBox1.Controls.Add(Me.btnCariResep)
        Me.GroupBox1.Controls.Add(Me.txtNmPasien)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtUsia)
        Me.GroupBox1.Controls.Add(Me.dtpTgl_Pendaftaran)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(548, 274)
        Me.GroupBox1.TabIndex = 90
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Pendaftaran"
        '
        'txtNoPasien
        '
        Me.txtNoPasien.Location = New System.Drawing.Point(164, 123)
        Me.txtNoPasien.Name = "txtNoPasien"
        Me.txtNoPasien.Size = New System.Drawing.Size(158, 22)
        Me.txtNoPasien.TabIndex = 61
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(57, 124)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(97, 17)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "Nomor Pasien"
        '
        'txtNoResep
        '
        Me.txtNoResep.Location = New System.Drawing.Point(164, 38)
        Me.txtNoResep.Name = "txtNoResep"
        Me.txtNoResep.Size = New System.Drawing.Size(158, 22)
        Me.txtNoResep.TabIndex = 59
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(57, 39)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 17)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "Nomor Resep"
        '
        'txtJnsKelamin
        '
        Me.txtJnsKelamin.Location = New System.Drawing.Point(164, 179)
        Me.txtJnsKelamin.MaxLength = 12
        Me.txtJnsKelamin.Name = "txtJnsKelamin"
        Me.txtJnsKelamin.Size = New System.Drawing.Size(110, 22)
        Me.txtJnsKelamin.TabIndex = 57
        '
        'txtNoPendaftaran
        '
        Me.txtNoPendaftaran.Location = New System.Drawing.Point(164, 66)
        Me.txtNoPendaftaran.Name = "txtNoPendaftaran"
        Me.txtNoPendaftaran.Size = New System.Drawing.Size(158, 22)
        Me.txtNoPendaftaran.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 17)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Nomor Pendaftaran"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Nama Dokter"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Nama Pasien"
        '
        'txtNmDokter
        '
        Me.txtNmDokter.Location = New System.Drawing.Point(164, 239)
        Me.txtNmDokter.MaxLength = 30
        Me.txtNmDokter.Name = "txtNmDokter"
        Me.txtNmDokter.Size = New System.Drawing.Size(363, 22)
        Me.txtNmDokter.TabIndex = 32
        '
        'btnCariResep
        '
        Me.btnCariResep.Location = New System.Drawing.Point(328, 39)
        Me.btnCariResep.Name = "btnCariResep"
        Me.btnCariResep.Size = New System.Drawing.Size(75, 23)
        Me.btnCariResep.TabIndex = 33
        Me.btnCariResep.Text = "CARI"
        Me.btnCariResep.UseVisualStyleBackColor = True
        '
        'txtNmPasien
        '
        Me.txtNmPasien.Location = New System.Drawing.Point(164, 151)
        Me.txtNmPasien.MaxLength = 30
        Me.txtNmPasien.Name = "txtNmPasien"
        Me.txtNmPasien.Size = New System.Drawing.Size(363, 22)
        Me.txtNmPasien.TabIndex = 32
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(16, 99)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(142, 17)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Tanggal Pendaftaran"
        '
        'txtUsia
        '
        Me.txtUsia.Location = New System.Drawing.Point(164, 207)
        Me.txtUsia.MaxLength = 3
        Me.txtUsia.Name = "txtUsia"
        Me.txtUsia.Size = New System.Drawing.Size(55, 22)
        Me.txtUsia.TabIndex = 37
        '
        'dtpTgl_Pendaftaran
        '
        Me.dtpTgl_Pendaftaran.Location = New System.Drawing.Point(164, 94)
        Me.dtpTgl_Pendaftaran.Name = "dtpTgl_Pendaftaran"
        Me.dtpTgl_Pendaftaran.Size = New System.Drawing.Size(200, 22)
        Me.dtpTgl_Pendaftaran.TabIndex = 45
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(61, 182)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(95, 17)
        Me.Label20.TabIndex = 44
        Me.Label20.Text = "Jenis Kelamin"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(225, 210)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 17)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "Tahun"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(120, 210)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 17)
        Me.Label22.TabIndex = 41
        Me.Label22.Text = "Usia"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(454, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(195, 34)
        Me.Label14.TabIndex = 89
        Me.Label14.Text = "CETAK NOTA"
        '
        'Cetak_nota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 732)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label14)
        Me.Name = "Cetak_nota"
        Me.Text = "Cetak Nota"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtJnsObat As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtJmlObat As System.Windows.Forms.TextBox
    Friend WithEvents txtHrgObat As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
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
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoNota As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents dtpTgl_Nota As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListViewNota As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtJnsKelamin As System.Windows.Forms.TextBox
    Friend WithEvents txtNoPendaftaran As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNmDokter As System.Windows.Forms.TextBox
    Friend WithEvents btnCariResep As System.Windows.Forms.Button
    Friend WithEvents txtNmPasien As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtUsia As System.Windows.Forms.TextBox
    Friend WithEvents dtpTgl_Pendaftaran As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNoResep As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtNoPasien As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAturanPakai As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnHapus As System.Windows.Forms.Button
End Class
