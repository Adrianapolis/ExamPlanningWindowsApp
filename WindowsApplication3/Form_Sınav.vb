Imports System.IO
Imports System.Net
Imports System.Net.Mail
Public Class Form_Sınav
    Private Sub OgrenciListesiniOku()
        Dim sayac As Integer = -1   'öğrenci okumak için
        Dim oku As String 'satır satır okumak için kullanılan değişken
        Dim fs As FileStream 'dosyayı okumak için kullanılır
        Dim dosyaacici As New OpenFileDialog() 'windowsta dosya açmak için

        If dosyaacici.ShowDialog = DialogResult.OK Then
            fs = New FileStream(dosyaacici.FileName, FileMode.Open)
            Dim sr As StreamReader = New StreamReader(fs, System.Text.Encoding.Default) 'fsten üretilmiş okumak için kullanılır

            Do
                oku = sr.ReadLine
                sayac = sayac + 1

                Try
                    RichTextBox1.AppendText(oku + vbNewLine) 'ilk okurken boş geldiği için try içine alındı
                Catch ex As Exception
                End Try

            Loop Until oku Is Nothing
            kapasite = sayac
            fs.Close()
            lblOgrenciSayisi.Text = kapasite
        End If

    End Sub
    Dim kapasite As Integer
    Private Sub Button_OgrListeSec_Click(sender As Object, e As EventArgs) Handles btnListeYukle.Click
        OgrenciListesiniOku()
    End Sub

    Private Sub Form_Sınav_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbDersAdi.DataSource = database.DersAdiGetir()
        Dim siniflar As List(Of String) = database.DerslikGetir()
        Dim x = 10, y As Integer = 20
        For i As Integer = 0 To siniflar.Count - 1
            Dim cb As New CheckBox
            cb.Width = 80
            cb.Text = siniflar(i).ToString() + "-" + database.DerslikKapasiteGetir(siniflar(i)).ToString()
            cb.Name = siniflar(i).ToString()
            AddHandler cb.Click, AddressOf cb_click
            flSinifListele.Controls.Add(cb)
            x = x + 70
            If (i + 1) Mod 4 = 0 And i <> 0 Then
                y = y + 30
                x = 10
            End If
        Next


    End Sub
    Private Sub cb_click(sender As Object, e As EventArgs)
        Dim ulasilan As CheckBox = CType(sender, CheckBox)
        Dim kap = database.DerslikKapasiteGetir(ulasilan.Name)

        If ulasilan.Checked And kapasite - kap >= 0 Then
            kapasite -= kap
        ElseIf ulasilan.Checked = False Then
            kapasite += kap
        Else

            Label3.Text = "Kapasite aştı"
            ulasilan.Checked = False
        End If
        lblOgrenciSayisi.Text = kapasite.ToString()
    End Sub



End Class