Imports System.Data.Odbc
Public Class Popup_Resep

    Public rno_resep As String
    Public rno_pendaftaran As String
    Public rtgl_pendaftaran As Date
    Public rno_pasien As String
    Public rnm_pasien As String
    Public rjenis_kelamin As String
    Public rusia As String
    Public rkd_dokter As String
    Public rnm_dokter As String
    Dim objresep As New ClsResep
    Dim objpendaftaran As New ClsPendaftaran
    Dim objpasien As New ClsPasien
    Dim objdokter As New ClsDokter
    Dim objpetugas As New ClsPetugas

    Sub isiListView(Optional ByVal kriteria As String = "%")
        Dim xList As List(Of ClsResep)

        xList = objresep.tampildata(kriteria)

        ListViewResep.Items.Clear()
        For baris As Integer = 0 To xList.Count - 1
            ListViewResep.Items.Add(xList.Item(baris).pno_resep)
            ListViewResep.Items(baris).SubItems.Add(xList.Item(baris).pno_daftar)
            objpendaftaran.pno_daftar = xList.Item(baris).pno_daftar
            If objpendaftaran.cari = True Then
                ListViewResep.Items(baris).SubItems.Add(objpendaftaran.ptgl_daftar)
                ListViewResep.Items(baris).SubItems.Add(objpendaftaran.pno_pasien)
            End If
            objpasien.pno_pasien = objpendaftaran.pno_pasien
            If objpasien.cari = True Then
                ListViewResep.Items(baris).SubItems.Add(objpasien.pnm_pasien)
                ListViewResep.Items(baris).SubItems.Add(objpasien.pjns_kelamin)
                ListViewResep.Items(baris).SubItems.Add(objpasien.pusia)
            End If
            objdokter.pkd_dokter = objpendaftaran.pkd_dokter
            If objdokter.cari = True Then
                ListViewResep.Items(baris).SubItems.Add(objdokter.pkd_dokter)
                ListViewResep.Items(baris).SubItems.Add(objdokter.pnm_dokter)
            End If
        Next
    End Sub

    Sub PilihBarisView()
        rno_resep = ListViewResep.FocusedItem.Text
        rno_pendaftaran = ListViewResep.FocusedItem.SubItems(1).Text
        rtgl_pendaftaran = ListViewResep.FocusedItem.SubItems(2).Text
        rno_pasien = ListViewResep.FocusedItem.SubItems(3).Text
        rnm_pasien = ListViewResep.FocusedItem.SubItems(4).Text
        rjenis_kelamin = ListViewResep.FocusedItem.SubItems(5).Text
        rusia = ListViewResep.FocusedItem.SubItems(6).Text
        rkd_dokter = ListViewResep.FocusedItem.SubItems(7).Text
        rnm_dokter = ListViewResep.FocusedItem.SubItems(8).Text
        Me.Close()
    End Sub

    Private Sub Popup_Resep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        isiListView()
    End Sub

    Private Sub btnPilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPilih.Click
        PilihBarisView()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub txtKata_Kunci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKata_Kunci.TextChanged
        Call isiListView(txtKata_Kunci.Text)
    End Sub

    Private Sub Popup_Resep_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        Call PilihBarisView()
    End Sub
End Class