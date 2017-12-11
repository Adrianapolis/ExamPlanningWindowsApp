Public Class Form_Derslik
    Private Sub Button_DerslikOlustur_Click(sender As Object, e As EventArgs) Handles btnDerslikOlustur.Click
        Dim eklencekderslik As New Derslik
        eklencekderslik.DerslikAdi = tbDerslikAdi.Text
        eklencekderslik.Kapasite = Convert.ToInt32(tbDerslikKapasite.Text)
        database.DerslikEkle(eklencekderslik)
    End Sub
End Class