Public Class Form_Derslik
    Private Sub Button_DerslikOlustur_Click(sender As Object, e As EventArgs) Handles Button_DerslikOlustur.Click
        Dim eklencekderslik As New Derslik
        eklencekderslik.DerslikAdi = TextBox_DerslikAdi.Text
        eklencekderslik.Kapasite = Convert.ToInt32(TextBox_DerslikKapasite.Text)
        database.DerslikEkle(eklencekderslik)
    End Sub
End Class