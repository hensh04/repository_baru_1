Public Class popup_pasien

    Public rno_pasien As String
    Public rnm_pasien As String
    Public rtmpt_lahir As String
    Public rtgl_lahir As String
    Public rjns_kelamin As String
    Public rusia As String
    Public ralamat As String
    Public rtelepon As String
    Public ragama As String
    Public rgolongan_darah As String
    Public rpekerjaan As String
    Public rkk As String

    Dim objpasien As New ClsPasien

    Sub isiListView(Optional ByVal kriteria As String = "%")
        Dim xList As List(Of ClsPasien)
        xList = objpasien.tampildata(kriteria)
        ListViewPasien.Items.Clear()
        For baris As Integer = 0 To xList.Count - 1
            ListViewPasien.Items.Add(xList.Item(baris).pno_pasien)
            ListViewPasien.Items(baris).SubItems.Add(xList.Item(baris).pnm_pasien)
            ListViewPasien.Items(baris).SubItems.Add(xList.Item(baris).ptmpt_lahir)
            ListViewPasien.Items(baris).SubItems.Add(xList.Item(baris).ptgl_lahir)
            ListViewPasien.Items(baris).SubItems.Add(xList.Item(baris).pjns_kelamin)
            ListViewPasien.Items(baris).SubItems.Add(xList.Item(baris).pusia)
            ListViewPasien.Items(baris).SubItems.Add(xList.Item(baris).palamat)
            ListViewPasien.Items(baris).SubItems.Add(xList.Item(baris).ptelepon)
            ListViewPasien.Items(baris).SubItems.Add(xList.Item(baris).pagama)
            ListViewPasien.Items(baris).SubItems.Add(xList.Item(baris).ppekerjaan)
            ListViewPasien.Items(baris).SubItems.Add(xList.Item(baris).pgolongan_darah)
            ListViewPasien.Items(baris).SubItems.Add(xList.Item(baris).pkk)
        Next
    End Sub

    Sub PilihBarisView()
        rno_pasien = ListViewPasien.FocusedItem.Text
        rnm_pasien = ListViewPasien.FocusedItem.SubItems(1).Text
        rtmpt_lahir = ListViewPasien.FocusedItem.SubItems(2).Text
        rtgl_lahir = ListViewPasien.FocusedItem.SubItems(3).Text
        rjns_kelamin = ListViewPasien.FocusedItem.SubItems(4).Text
        rusia = ListViewPasien.FocusedItem.SubItems(5).Text
        ralamat = ListViewPasien.FocusedItem.SubItems(6).Text
        rtelepon = ListViewPasien.FocusedItem.SubItems(7).Text
        ragama = ListViewPasien.FocusedItem.SubItems(8).Text
        rpekerjaan = ListViewPasien.FocusedItem.SubItems(9).Text
        rgolongan_darah = ListViewPasien.FocusedItem.SubItems(10).Text
        rkk = ListViewPasien.FocusedItem.SubItems(11).Text
        Me.Dispose()
    End Sub

    Private Sub popup_pasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub ListViewPasien_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewPasien.MouseDoubleClick
        Call PilihBarisView()
    End Sub
End Class