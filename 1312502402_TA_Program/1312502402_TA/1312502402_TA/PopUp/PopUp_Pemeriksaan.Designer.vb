<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopUp_Pemeriksaan
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
        Me.btnPilih = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.ListViewPemeriksaan = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtKata_Kunci = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnPilih
        '
        Me.btnPilih.Location = New System.Drawing.Point(282, 277)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(104, 34)
        Me.btnPilih.TabIndex = 45
        Me.btnPilih.Text = "PILIH"
        Me.btnPilih.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(816, 277)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(104, 34)
        Me.btnBatal.TabIndex = 44
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'ListViewPemeriksaan
        '
        Me.ListViewPemeriksaan.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader9, Me.ColumnHeader3, Me.ColumnHeader10, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader5, Me.ColumnHeader4, Me.ColumnHeader8, Me.ColumnHeader11})
        Me.ListViewPemeriksaan.FullRowSelect = True
        Me.ListViewPemeriksaan.GridLines = True
        Me.ListViewPemeriksaan.Location = New System.Drawing.Point(10, 57)
        Me.ListViewPemeriksaan.Margin = New System.Windows.Forms.Padding(4)
        Me.ListViewPemeriksaan.Name = "ListViewPemeriksaan"
        Me.ListViewPemeriksaan.Size = New System.Drawing.Size(1207, 189)
        Me.ListViewPemeriksaan.TabIndex = 43
        Me.ListViewPemeriksaan.UseCompatibleStateImageBehavior = False
        Me.ListViewPemeriksaan.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nomor Pendaftaran"
        Me.ColumnHeader1.Width = 135
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tanggal Pendaftaran"
        Me.ColumnHeader2.Width = 149
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Nomor Pasien"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nama Pasien"
        Me.ColumnHeader3.Width = 105
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Jenis Kelamin"
        Me.ColumnHeader10.Width = 95
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Kode Dokter"
        Me.ColumnHeader6.Width = 122
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Nama Dokter"
        Me.ColumnHeader7.Width = 104
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Biaya Dokter"
        Me.ColumnHeader5.Width = 108
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Biaya Daftar"
        Me.ColumnHeader4.Width = 137
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Kode Petugas"
        Me.ColumnHeader8.Width = 102
        '
        'txtKata_Kunci
        '
        Me.txtKata_Kunci.Location = New System.Drawing.Point(97, 12)
        Me.txtKata_Kunci.Name = "txtKata_Kunci"
        Me.txtKata_Kunci.Size = New System.Drawing.Size(213, 22)
        Me.txtKata_Kunci.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Kata Kunci :"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Usia"
        '
        'PopUp_Pemeriksaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 331)
        Me.Controls.Add(Me.btnPilih)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.ListViewPemeriksaan)
        Me.Controls.Add(Me.txtKata_Kunci)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PopUp_Pemeriksaan"
        Me.Text = "PopUp_Pemeriksaan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPilih As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents ListViewPemeriksaan As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtKata_Kunci As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
End Class
