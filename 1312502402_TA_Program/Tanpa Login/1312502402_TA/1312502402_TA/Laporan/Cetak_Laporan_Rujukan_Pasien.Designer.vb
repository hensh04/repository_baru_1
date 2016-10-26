<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cetak_Laporan_Rujukan_Pasien
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtpTanggal2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpTanggal1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtpTanggal2)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.dtpTanggal1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(70, 94)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(591, 67)
        Me.GroupBox3.TabIndex = 65
        Me.GroupBox3.TabStop = False
        '
        'dtpTanggal2
        '
        Me.dtpTanggal2.Location = New System.Drawing.Point(368, 21)
        Me.dtpTanggal2.Name = "dtpTanggal2"
        Me.dtpTanggal2.Size = New System.Drawing.Size(200, 22)
        Me.dtpTanggal2.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(316, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 17)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "s/d"
        '
        'dtpTanggal1
        '
        Me.dtpTanggal1.Location = New System.Drawing.Point(89, 21)
        Me.dtpTanggal1.Name = "dtpTanggal1"
        Me.dtpTanggal1.Size = New System.Drawing.Size(200, 22)
        Me.dtpTanggal1.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(512, 34)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "CETAK LAPORAN RUJUKAN PASIEN"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnKeluar)
        Me.GroupBox2.Controls.Add(Me.btnCetak)
        Me.GroupBox2.Location = New System.Drawing.Point(70, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(591, 67)
        Me.GroupBox2.TabIndex = 63
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
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(24, 18)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(104, 34)
        Me.btnCetak.TabIndex = 29
        Me.btnCetak.Text = "CETAK"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'Cetak_Laporan_Rujukan_Pasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 287)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Cetak_Laporan_Rujukan_Pasien"
        Me.Text = "Cetak_Laporan_Rujukan_Pasien"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpTanggal2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpTanggal1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnCetak As System.Windows.Forms.Button
End Class
