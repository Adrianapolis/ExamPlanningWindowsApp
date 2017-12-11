Public Class Form_AnaSayfa




    'POP-UP AÇMAK İÇİN'
    Dim secim As String


    Private Sub Button_Sinif_Click(sender As Object, e As EventArgs) Handles btnSinif.Click
        Label1.Hide()
        GroupBox1.Visible = True
        GroupBox1.Text = btnSinif.Text

        secim = "sinif"
    End Sub

    Private Sub Button_Asistan_Click(sender As Object, e As EventArgs) Handles btnAsistan.Click

        Label1.Hide()
        GroupBox1.Visible = True
        GroupBox1.Text = btnAsistan.Text

        secim = "asistan"
    End Sub

    Private Sub Button_Sinav_Click(sender As Object, e As EventArgs) Handles btnSinav.Click

        Label1.Hide()
        GroupBox1.Visible = True
        GroupBox1.Text = btnSinav.Text

        secim = "sinav"

    End Sub

    Private Sub Button_Ders_Click(sender As Object, e As EventArgs) Handles btnDers.Click

        Label1.Hide()
        GroupBox1.Visible = True
        GroupBox1.Text = btnDers.Text

        secim = "ders"

    End Sub



    Private Sub Button_YeniKayit_Click(sender As Object, e As EventArgs) Handles btnKayitEkle.Click
        'POP-UP AÇMAK İÇİN'
        Select Case secim
            Case "sinav"
                Dim MyForm As New Form_Sınav
                MyForm.ShowDialog()
            Case "sinif"
                Dim MyForm As New Form_Derslik
                MyForm.ShowDialog()
            Case "ders"
                Dim MyForm As New Form_Ders
                MyForm.ShowDialog()
            Case "asistan"
                Dim MyForm As New Form_Asistan
                MyForm.ShowDialog()
        End Select

    End Sub

    Private Sub Form_AnaSayfa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.DataSource = database.AsistanListesiAl()
    End Sub
End Class
