Imports System.Data.Odbc
Public Class PopUp_Pemeriksaan

    Public rno_pendaftaran As String
    Public rtgl_pendaftaran As Date
    Public rno_pasien As String
    Public rnm_pasien As String
    Public rjenis_kelamin As String
    Public rbiaya_daftar As String
    Public rbiaya_dokter As String
    Public rkd_dokter As String
    Public rnm_dokter As String
    Public rkd_petugas As String
    Public rusia As Integer
    Dim objpendaftaran As New ClsPendaftaran
    Dim objpasien As New ClsPasien
    Dim objdokter As New ClsDokter
    Dim objpetugas As New ClsPetugas


    Sub isiListView(Optional ByVal kriteria As String = "%")
        Dim xList As List(Of ClsPendaftaran)
        xList = objpendaftaran.tampildata(kriteria)
        ListViewPemeriksaan.Items.Clear()
        For baris As Integer = 0 To xList.Count - 1
            ListViewPemeriksaan.Items.Add(xList.Item(baris).pno_daftar)
            ListViewPemeriksaan.Items(baris).SubItems.Add(xList.Item(baris).ptgl_daftar)
            ListViewPemeriksaan.Items(baris).SubItems.Add(xList.Item(baris).pno_pasien)
            objpasien.pno_pasien = xList.Item(baris).pno_pasien
            If objpasien.cari = True Then
                ListViewPemeriksaan.Items(baris).SubItems.Add(objpasien.pnm_pasien)
                ListViewPemeriksaan.Items(baris).SubItems.Add(objpasien.pjns_kelamin)
            End If
            ListViewPemeriksaan.Items(baris).SubItems.Add(xList.Item(baris).pkd_dokter)
            objdokter.pkd_dokter = xList.Item(baris).pkd_dokter
            If objdokter.cari = True Then
                ListViewPemeriksaan.Items(baris).SubItems.Add(objdokter.pnm_dokter)
            End If
            ListViewPemeriksaan.Items(baris).SubItems.Add(xList.Item(baris).pbiaya_dokter)
            ListViewPemeriksaan.Items(baris).SubItems.Add(xList.Item(baris).pbiaya_daftar)
            ListViewPemeriksaan.Items(baris).SubItems.Add(xList.Item(baris).pkd_petugas)
            If objpasien.cari = True Then
                ListViewPemeriksaan.Items(baris).SubItems.Add(DateDiff(DateInterval.Year, objpasien.ptgl_lahir, Now))
            End If
        Next
    End Sub

    Sub PilihBarisView()
        rno_pendaftaran = ListViewPemeriksaan.FocusedItem.Text
        rtgl_pendaftaran = ListViewPemeriksaan.FocusedItem.SubItems(1).Text
        rno_pasien = ListViewPemeriksaan.FocusedItem.SubItems(2).Text
        rnm_pasien = ListViewPemeriksaan.FocusedItem.SubItems(3).Text
        rjenis_kelamin = ListViewPemeriksaan.FocusedItem.SubItems(4).Text
        rkd_dokter = ListViewPemeriksaan.FocusedItem.SubItems(5).Text
        rnm_dokter = ListViewPemeriksaan.FocusedItem.SubItems(6).Text
        rbiaya_dokter = ListViewPemeriksaan.FocusedItem.SubItems(7).Text
        rbiaya_daftar = ListViewPemeriksaan.FocusedItem.SubItems(8).Text
        rkd_petugas = ListViewPemeriksaan.FocusedItem.SubItems(9).Text
        rusia = ListViewPemeriksaan.FocusedItem.SubItems(10).Text
        Me.Close()
    End Sub

    Private Sub PopUp_Pemeriksaan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        Call isiListView()
    End Sub

    Private Sub btnPilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPilih.Click
        Call PilihBarisView()
    End Sub

    Private Sub ListViewPemeriksaan_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewPemeriksaan.MouseDoubleClick
        Call PilihBarisView()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Dispose()
    End Sub

    Private Sub txtKata_Kunci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKata_Kunci.TextChanged
        Call isiListView(txtKata_Kunci.Text)
    End Sub
End Class