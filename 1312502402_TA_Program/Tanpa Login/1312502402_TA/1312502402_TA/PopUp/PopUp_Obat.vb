Public Class PopUp_Obat
    Public rkd_obat As String
    Public rnm_obat As String
    Public rjns_obat As String
    Public rharga_obat As String
    Public rsatuan As String
    Public rstock As String

    Dim objobat As New ClsObat

    Sub isiListView(Optional ByVal kriteria As String = "%")
        Dim xList As List(Of ClsObat)
        xList = objobat.tampildata(kriteria)
        ListViewObat.Items.Clear()
        For baris As Integer = 0 To xList.Count - 1
            ListViewObat.Items.Add(xList.Item(baris).pkd_obat)
            ListViewObat.Items(baris).SubItems.Add(xList.Item(baris).pnm_obat)
            ListViewObat.Items(baris).SubItems.Add(xList.Item(baris).pjns_obat)
            ListViewObat.Items(baris).SubItems.Add(xList.Item(baris).pharga_obat)
            ListViewObat.Items(baris).SubItems.Add(xList.Item(baris).psatuan)
            ListViewObat.Items(baris).SubItems.Add(xList.Item(baris).pstock)
        Next
    End Sub

    Sub PilihBarisView()
        rkd_obat = ListViewObat.FocusedItem.Text
        rnm_obat = ListViewObat.FocusedItem.SubItems(1).Text
        rjns_obat = ListViewObat.FocusedItem.SubItems(2).Text
        rharga_obat = ListViewObat.FocusedItem.SubItems(3).Text
        rsatuan = ListViewObat.FocusedItem.SubItems(4).Text
        rstock = ListViewObat.FocusedItem.SubItems(5).Text
        Me.Dispose()
    End Sub

    Private Sub PopUp_Obat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        Call isiListView()
    End Sub

    Private Sub txtKata_Kunci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKata_Kunci.TextChanged
        Call isiListView(txtKata_Kunci.Text)
    End Sub

    Private Sub ListViewObat_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewObat.MouseDoubleClick
        Call PilihBarisView()
    End Sub

    Private Sub btnPilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPilih.Click
        Call PilihBarisView()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class