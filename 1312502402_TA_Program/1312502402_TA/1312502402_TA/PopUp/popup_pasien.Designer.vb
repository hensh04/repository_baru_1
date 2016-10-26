<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popup_pasien
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKata_Kunci = New System.Windows.Forms.TextBox()
        Me.ListViewPasien = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnPilih = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kata Kunci :"
        '
        'txtKata_Kunci
        '
        Me.txtKata_Kunci.Location = New System.Drawing.Point(102, 21)
        Me.txtKata_Kunci.Name = "txtKata_Kunci"
        Me.txtKata_Kunci.Size = New System.Drawing.Size(213, 22)
        Me.txtKata_Kunci.TabIndex = 1
        '
        'ListViewPasien
        '
        Me.ListViewPasien.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.ListViewPasien.FullRowSelect = True
        Me.ListViewPasien.GridLines = True
        Me.ListViewPasien.Location = New System.Drawing.Point(15, 61)
        Me.ListViewPasien.Name = "ListViewPasien"
        Me.ListViewPasien.Size = New System.Drawing.Size(1537, 195)
        Me.ListViewPasien.TabIndex = 0
        Me.ListViewPasien.UseCompatibleStateImageBehavior = False
        Me.ListViewPasien.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nomor Pasien"
        Me.ColumnHeader1.Width = 114
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Pasien"
        Me.ColumnHeader2.Width = 184
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tempat Lahir"
        Me.ColumnHeader3.Width = 128
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Tanggal Lahir"
        Me.ColumnHeader4.Width = 114
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Jenis Kelamin"
        Me.ColumnHeader5.Width = 99
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Usia"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Alamat"
        Me.ColumnHeader7.Width = 285
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Telepon"
        Me.ColumnHeader8.Width = 136
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Agama"
        Me.ColumnHeader9.Width = 88
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Pekerjaan"
        Me.ColumnHeader10.Width = 98
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Golongan Darah"
        Me.ColumnHeader11.Width = 112
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "KK"
        Me.ColumnHeader12.Width = 170
        '
        'btnPilih
        '
        Me.btnPilih.Location = New System.Drawing.Point(501, 290)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(104, 34)
        Me.btnPilih.TabIndex = 35
        Me.btnPilih.Text = "PILIH"
        Me.btnPilih.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(1035, 290)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(104, 34)
        Me.btnBatal.TabIndex = 34
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'popup_pasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1564, 349)
        Me.Controls.Add(Me.btnPilih)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.ListViewPasien)
        Me.Controls.Add(Me.txtKata_Kunci)
        Me.Controls.Add(Me.Label1)
        Me.Name = "popup_pasien"
        Me.Text = "PopUp Pasien"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKata_Kunci As System.Windows.Forms.TextBox
    Friend WithEvents ListViewPasien As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPilih As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
End Class
