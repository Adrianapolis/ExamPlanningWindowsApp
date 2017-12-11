Public Class Form_Ders
    Private Sub Button_DersEkle_Click(sender As Object, e As EventArgs) Handles btnDersEkle.Click
        Dim ders As New Dersler
        ders.DersAdi = tbDersAdi.Text
        ders.DersKodu = tbDersKodu.Text
        database.DersEkle(ders)
    End Sub
End Class