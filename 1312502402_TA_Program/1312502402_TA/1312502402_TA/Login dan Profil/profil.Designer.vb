<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profil
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
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKdPetugas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNmPetugas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.rbPria = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rbWanita = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpTglLahir = New System.Windows.Forms.DateTimePicker()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.SuspendLayout()
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(384, 387)
        Me.btnKeluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(104, 34)
        Me.btnKeluar.TabIndex = 61
        Me.btnKeluar.Text = "KELUAR"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(115, 135)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtpassword.MaxLength = 30
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(237, 22)
        Me.txtpassword.TabIndex = 72
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(274, 387)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(104, 34)
        Me.btnBatal.TabIndex = 60
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(19, 387)
        Me.btnUbah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(150, 34)
        Me.btnUbah.TabIndex = 57
        Me.btnUbah.Text = "UPDATE"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Password"
        '
        'txtKdPetugas
        '
        Me.txtKdPetugas.Location = New System.Drawing.Point(115, 83)
        Me.txtKdPetugas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKdPetugas.MaxLength = 6
        Me.txtKdPetugas.Name = "txtKdPetugas"
        Me.txtKdPetugas.Size = New System.Drawing.Size(159, 22)
        Me.txtKdPetugas.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Kode Petugas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Nama Petugas"
        '
        'txtNmPetugas
        '
        Me.txtNmPetugas.Location = New System.Drawing.Point(115, 109)
        Me.txtNmPetugas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNmPetugas.MaxLength = 30
        Me.txtNmPetugas.Name = "txtNmPetugas"
        Me.txtNmPetugas.Size = New System.Drawing.Size(363, 22)
        Me.txtNmPetugas.TabIndex = 59
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(52, 330)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 17)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Telepon"
        '
        'txtTelepon
        '
        Me.txtTelepon.Location = New System.Drawing.Point(115, 327)
        Me.txtTelepon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelepon.MaxLength = 12
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(173, 22)
        Me.txtTelepon.TabIndex = 12
        '
        'rbPria
        '
        Me.rbPria.AutoSize = True
        Me.rbPria.Location = New System.Drawing.Point(115, 187)
        Me.rbPria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbPria.Name = "rbPria"
        Me.rbPria.Size = New System.Drawing.Size(54, 21)
        Me.rbPria.TabIndex = 63
        Me.rbPria.TabStop = True
        Me.rbPria.Text = "Pria"
        Me.rbPria.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(121, 34)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "PROFIL"
        '
        'rbWanita
        '
        Me.rbWanita.AutoSize = True
        Me.rbWanita.Location = New System.Drawing.Point(190, 187)
        Me.rbWanita.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbWanita.Name = "rbWanita"
        Me.rbWanita.Size = New System.Drawing.Size(73, 21)
        Me.rbWanita.TabIndex = 64
        Me.rbWanita.TabStop = True
        Me.rbWanita.Text = "Wanita"
        Me.rbWanita.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 17)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Jenis Kelamin"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(115, 212)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAlamat.MaxLength = 100
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAlamat.Size = New System.Drawing.Size(363, 111)
        Me.txtAlamat.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(61, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 17)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Tanggal Lahir"
        '
        'dtpTglLahir
        '
        Me.dtpTglLahir.Location = New System.Drawing.Point(115, 161)
        Me.dtpTglLahir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpTglLahir.Name = "dtpTglLahir"
        Me.dtpTglLahir.Size = New System.Drawing.Size(200, 22)
        Me.dtpTglLahir.TabIndex = 68
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(494, 443)
        Me.ShapeContainer1.TabIndex = 74
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 3
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -2
        Me.LineShape2.X2 = 497
        Me.LineShape2.Y1 = 367
        Me.LineShape2.Y2 = 367
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -1
        Me.LineShape1.X2 = 498
        Me.LineShape1.Y1 = 51
        Me.LineShape1.Y2 = 51
        '
        'profil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 443)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtKdPetugas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNmPetugas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTelepon)
        Me.Controls.Add(Me.rbPria)
        Me.Controls.Add(Me.dtpTglLahir)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.rbWanita)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "profil"
        Me.Text = "profil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKdPetugas As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNmPetugas As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTelepon As System.Windows.Forms.TextBox
    Friend WithEvents rbPria As System.Windows.Forms.RadioButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents rbWanita As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpTglLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
