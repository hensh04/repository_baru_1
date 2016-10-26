Public Class Popup_Dokter
    Public rkd_dokter As String
    Public rnm_dokter As String
    Public rtgl_lahir As String
    Public rjns_kelamin As String
    Public ralamat As String
    Public rtelepon As String
    Public rbiaya_jasa As String

    Dim objdokter As New ClsDokter

    Sub isiListView(Optional ByVal kriteria As String = "%")
        Dim xList As List(Of ClsDokter)
        xList = objdokter.tampildata(kriteria)
        ListViewDokter.Items.Clear()
        For baris As Integer = 0 To xList.Count - 1
            ListViewDokter.Items.Add(xList.Item(baris).pkd_dokter)
            ListViewDokter.Items(baris).SubItems.Add(xList.Item(baris).pnm_dokter)
            ListViewDokter.Items(baris).SubItems.Add(xList.Item(baris).ptgl_lahir)
            ListViewDokter.Items(baris).SubItems.Add(xList.Item(baris).pjns_kelamin)
            ListViewDokter.Items(baris).SubItems.Add(xList.Item(baris).palamat)
            ListViewDokter.Items(baris).SubItems.Add(xList.Item(baris).ptelepon)
            ListViewDokter.Items(baris).SubItems.Add(xList.Item(baris).pbiaya_jasa)
        Next
    End Sub

    Sub PilihBarisView()
        rkd_dokter = ListViewDokter.FocusedItem.Text
        rnm_dokter = ListViewDokter.FocusedItem.SubItems(1).Text
        rtgl_lahir = ListViewDokter.FocusedItem.SubItems(2).Text
        rjns_kelamin = ListViewDokter.FocusedItem.SubItems(3).Text
        ralamat = ListViewDokter.FocusedItem.SubItems(4).Text
        rtelepon = ListViewDokter.FocusedItem.SubItems(5).Text
        rbiaya_jasa = ListViewDokter.FocusedItem.SubItems(6).Text
        Me.Dispose()
    End Sub

    Private Sub Popup_Dokter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        Call isiListView()
    End Sub

    Private Sub txtKata_Kunci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKata_Kunci.TextChanged
        Call isiListView(txtKata_Kunci.Text)
    End Sub

    Private Sub ListViewDokter_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewDokter.MouseDoubleClick
        Call PilihBarisView()
    End Sub

    Private Sub btnPilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPilih.Click
        Call PilihBarisView()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class