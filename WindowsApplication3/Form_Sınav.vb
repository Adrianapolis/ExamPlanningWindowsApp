Public Class Form_Sınav
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_OgrListeSec.Click
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim sr As New System.IO.StreamReader(OpenFileDialog1.FileName)
            MessageBox.Show(sr.ReadToEnd)
            sr.Close()
        End If
    End Sub

    Private Sub Form_Sınav_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_DersAdı.DataSource = database.DersAdiGetir()
        ComboBox_Sinif.DataSource = database.DerslikGetir()
        Dim siniflar As List(Of String) = database.DerslikGetir()
        Dim x = 10, y As Integer = 20
        For i As Integer = 0 To siniflar.Count - 1
            Dim cb As New CheckBox
            Dim rbKonum As New Point(x, y)
            cb.Location = rbKonum
            cb.Width = 60
            cb.Text = siniflar(i).ToString()
            cb.Name = "cb" + siniflar(i).ToString()
            gb_Siniflar.Controls.Add(cb)
            x = x + 70
            If (i + 1) Mod 4 = 0 And i <> 0 Then
                y = y + 30
                x = 10
            End If
        Next


    End Sub

    Private Sub ComboBox_DersAdı_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_DersAdı.SelectedIndexChanged
        'Dim SeciliSinif As String
        'SeciliSinif = ComboBox_DersAdı.SelectedValue.ToString()
        'SeciliSinif = ComboBox_Sinif.SelectedValue.ToString()
        'Label_Kapasite.Text = database.DerslikKapasiteGetir(SeciliSinif)
    End Sub

    Private Sub ComboBox_Sinif_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Sinif.SelectedIndexChanged
        Dim SeciliSinif As String
        'SeciliSinif = ComboBox_DersAdı.SelectedValue.ToString()
        SeciliSinif = ComboBox_Sinif.SelectedValue.ToString()
        Label_Kapasite.Text = database.DerslikKapasiteGetir(SeciliSinif)
    End Sub
End Class