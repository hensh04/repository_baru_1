Imports System.Data.Odbc
Public Class PopUp_Pendaftaran

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
    Dim objpendaftaran As New ClsPendaftaran
    Dim objpasien As New ClsPasien
    Dim objdokter As New ClsDokter
    Dim objpetugas As New ClsPetugas

    Sub isiListView(Optional ByVal kriteria As String = "%")
        Dim xList As List(Of ClsPendaftaran)
        xList = objpendaftaran.tampildata(kriteria)
        ListViewPendaftaran.Items.Clear()
        For baris As Integer = 0 To xList.Count - 1
            ListViewPendaftaran.Items.Add(xList.Item(baris).pno_daftar)
            ListViewPendaftaran.Items(baris).SubItems.Add(xList.Item(baris).ptgl_daftar)
            ListViewPendaftaran.Items(baris).SubItems.Add(xList.Item(baris).pno_pasien)
            objpasien.pno_pasien = xList.Item(baris).pno_pasien
            If objpasien.cari = True Then
                ListViewPendaftaran.Items(baris).SubItems.Add(objpasien.pnm_pasien)
                ListViewPendaftaran.Items(baris).SubItems.Add(objpasien.pjns_kelamin)
            End If
            ListViewPendaftaran.Items(baris).SubItems.Add(xList.Item(baris).pkd_dokter)
            objdokter.pkd_dokter = xList.Item(baris).pkd_dokter
            If objdokter.cari = True Then
                ListViewPendaftaran.Items(baris).SubItems.Add(objdokter.pnm_dokter)
            End If
            ListViewPendaftaran.Items(baris).SubItems.Add(xList.Item(baris).pbiaya_dokter)
            ListViewPendaftaran.Items(baris).SubItems.Add(xList.Item(baris).pbiaya_daftar)
            ListViewPendaftaran.Items(baris).SubItems.Add(xList.Item(baris).pkd_petugas)
        Next
    End Sub

    Sub PilihBarisView()
        rno_pendaftaran = ListViewPendaftaran.FocusedItem.Text
        rtgl_pendaftaran = ListViewPendaftaran.FocusedItem.SubItems(1).Text
        rno_pasien = ListViewPendaftaran.FocusedItem.SubItems(2).Text
        rnm_pasien = ListViewPendaftaran.FocusedItem.SubItems(3).Text
        rjenis_kelamin = ListViewPendaftaran.FocusedItem.SubItems(4).Text
        rkd_dokter = ListViewPendaftaran.FocusedItem.SubItems(5).Text
        rnm_dokter = ListViewPendaftaran.FocusedItem.SubItems(6).Text
        rbiaya_dokter = ListViewPendaftaran.FocusedItem.SubItems(7).Text
        rbiaya_daftar = ListViewPendaftaran.FocusedItem.SubItems(8).Text
        rkd_petugas = ListViewPendaftaran.FocusedItem.SubItems(9).Text
        Me.Close()
    End Sub

    Private Sub PopUp_Pendaftaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        Call isiListView()
    End Sub

    Private Sub btnPilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPilih.Click
        Call PilihBarisView()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub txtKata_Kunci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKata_Kunci.TextChanged
        Call isiListView(txtKata_Kunci.Text)
    End Sub

    Private Sub ListViewPendaftaran_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewPendaftaran.MouseDoubleClick
        Call PilihBarisView()
    End Sub

    Private Sub ListViewPendaftaran_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewPendaftaran.SelectedIndexChanged

    End Sub
End Class