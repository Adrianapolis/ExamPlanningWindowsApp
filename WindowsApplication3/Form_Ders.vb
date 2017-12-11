Public Class Form_Ders
    Private Sub Button_DersEkle_Click(sender As Object, e As EventArgs) Handles Button_DersEkle.Click
        Dim ders As New Dersler
        ders.DersAdi = TextBox_DersAdi.Text
        ders.DersKodu = TextBox_DersKodu.Text
        database.DersEkle(ders)
    End Sub
End Class