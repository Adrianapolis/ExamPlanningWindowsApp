Public Class Form_Asistan
    Private Sub Button_AsistanEkle_Click(sender As Object, e As EventArgs) Handles Button_AsistanEkle.Click
        Dim a As New Asistan()
        a.AsistanAdi = TextBox_AsistanAdi.Text
        a.Mail = TextBox_AsistanEmail.Text
        database.AsistanEkle(a)
    End Sub
End Class