<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopUp_Petugas
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
        Me.ListViewPetugas = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtKata_Kunci = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPilih
        '
        Me.btnPilih.Location = New System.Drawing.Point(134, 279)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(104, 34)
        Me.btnPilih.TabIndex = 42
        Me.btnPilih.Text = "PILIH"
        Me.btnPilih.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(668, 279)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(104, 34)
        Me.btnBatal.TabIndex = 41
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'ListViewPetugas
        '
        Me.ListViewPetugas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListViewPetugas.FullRowSelect = True
        Me.ListViewPetugas.GridLines = True
        Me.ListViewPetugas.Location = New System.Drawing.Point(12, 60)
        Me.ListViewPetugas.Name = "ListViewPetugas"
        Me.ListViewPetugas.Size = New System.Drawing.Size(889, 195)
        Me.ListViewPetugas.TabIndex = 39
        Me.ListViewPetugas.UseCompatibleStateImageBehavior = False
        Me.ListViewPetugas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Kode Petugas"
        Me.ColumnHeader1.Width = 114
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Petugas"
        Me.ColumnHeader2.Width = 184
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tanggal Lahir"
        Me.ColumnHeader3.Width = 128
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Jenis Kelamin"
        Me.ColumnHeader4.Width = 97
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Alamat"
        Me.ColumnHeader5.Width = 243
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Telepon"
        Me.ColumnHeader6.Width = 115
        '
        'txtKata_Kunci
        '
        Me.txtKata_Kunci.Location = New System.Drawing.Point(99, 20)
        Me.txtKata_Kunci.Name = "txtKata_Kunci"
        Me.txtKata_Kunci.Size = New System.Drawing.Size(213, 22)
        Me.txtKata_Kunci.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Kata Kunci :"
        '
        'PopUp_Petugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 348)
        Me.Controls.Add(Me.btnPilih)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.ListViewPetugas)
        Me.Controls.Add(Me.txtKata_Kunci)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PopUp_Petugas"
        Me.Text = "PopUp Petugas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPilih As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents ListViewPetugas As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtKata_Kunci As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
