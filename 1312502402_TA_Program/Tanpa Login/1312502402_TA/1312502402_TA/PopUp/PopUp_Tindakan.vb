Public Class PopUp_Tindakan

    Public rkd_tindakan As String
    Public rnm_tindakan As String
    Public rharga_tindakan As String

    Dim objtindakan As New ClsTindakan

    Sub isiListView(Optional ByVal kriteria As String = "%")
        Dim xList As List(Of ClsTindakan)
        xList = objtindakan.tampildata(kriteria)
        ListViewTindakan.Items.Clear()
        For baris As Integer = 0 To xList.Count - 1
            ListViewTindakan.Items.Add(xList.Item(baris).pkd_tindakan)
            ListViewTindakan.Items(baris).SubItems.Add(xList.Item(baris).pnm_tindakan)
            ListViewTindakan.Items(baris).SubItems.Add(xList.Item(baris).pharga_tindakan)
        Next
    End Sub

    Sub PilihBarisView()
        rkd_tindakan = ListViewTindakan.FocusedItem.Text
        rnm_tindakan = ListViewTindakan.FocusedItem.SubItems(1).Text
        rharga_tindakan = ListViewTindakan.FocusedItem.SubItems(2).Text
        Me.Dispose()
    End Sub

    Private Sub PopUp_Tindakan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        Call isiListView()
    End Sub

    Private Sub ListViewTindakan_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewTindakan.MouseDoubleClick
        Call PilihBarisView()
    End Sub

    Private Sub txtKata_Kunci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKata_Kunci.TextChanged
        Call isiListView(txtKata_Kunci.Text)
    End Sub

    Private Sub btnPilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPilih.Click
        Call PilihBarisView()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class