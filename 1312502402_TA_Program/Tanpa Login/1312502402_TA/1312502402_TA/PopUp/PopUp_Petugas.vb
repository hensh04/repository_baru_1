Public Class PopUp_Petugas
    Public rkd_petugas As String
    Public rnm_petugas As String
    Public rtgl_lahir As String
    Public rjns_kelamin As String
    Public ralamat As String
    Public rtelepon As String

    Dim objpetugas As New ClsPetugas

    Sub isiListView(Optional ByVal kriteria As String = "%")
        Dim xList As List(Of ClsPetugas)
        xList = objpetugas.tampildata(kriteria)
        ListViewPetugas.Items.Clear()
        For baris As Integer = 0 To xList.Count - 1
            ListViewPetugas.Items.Add(xList.Item(baris).pkd_petugas)
            ListViewPetugas.Items(baris).SubItems.Add(xList.Item(baris).pnm_petugas)
            ListViewPetugas.Items(baris).SubItems.Add(xList.Item(baris).ptgl_lahir)
            ListViewPetugas.Items(baris).SubItems.Add(xList.Item(baris).pjns_kelamin)
            ListViewPetugas.Items(baris).SubItems.Add(xList.Item(baris).palamat)
            ListViewPetugas.Items(baris).SubItems.Add(xList.Item(baris).ptelepon)
        Next
    End Sub

    Sub PilihBarisView()
        rkd_petugas = ListViewPetugas.FocusedItem.Text
        rnm_petugas = ListViewPetugas.FocusedItem.SubItems(1).Text
        rtgl_lahir = ListViewPetugas.FocusedItem.SubItems(2).Text
        rjns_kelamin = ListViewPetugas.FocusedItem.SubItems(3).Text
        ralamat = ListViewPetugas.FocusedItem.SubItems(4).Text
        rtelepon = ListViewPetugas.FocusedItem.SubItems(5).Text
        Me.Dispose()
    End Sub

    Private Sub PopUp_Petugas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        Call isiListView()
    End Sub

    Private Sub ListViewPetugas_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewPetugas.MouseDoubleClick
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