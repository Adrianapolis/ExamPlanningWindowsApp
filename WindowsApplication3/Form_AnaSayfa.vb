'Imports System.Data.SqlClient

Public Class Form_AnaSayfa


    'Dim constr As String = "server = DESKTOP-AUOLGK4\SQL_2016;database = GorselDB; User Id=sa; password=123mehmetr"
    'Dim baglanti As New SqlConnection(constr)

    'POP-UP AÇMAK İÇİN'
    Dim secim As String


    Private Sub Button_Sinif_Click(sender As Object, e As EventArgs) Handles Button_Sinif.Click

        'baglanti.Open()

        'Dim c As New SqlCommand()
        'c.CommandType = CommandType.Text
        'c.Connection = baglanti
        'c.CommandText = "insert into dersler values('10','d1')"

        'c.ExecuteNonQuery()
        'baglanti.Close()

        Label1.Hide()
        GroupBox1.Visible = True
        GroupBox1.Text = Button_Sinif.Text

        secim = "sinif"
    End Sub

    Private Sub Button_Asistan_Click(sender As Object, e As EventArgs) Handles Button_Asistan.Click

        Label1.Hide()
        GroupBox1.Visible = True
        GroupBox1.Text = Button_Asistan.Text

        secim = "asistan"
    End Sub

    Private Sub Button_Sinav_Click(sender As Object, e As EventArgs) Handles Button_Sinav.Click

        Label1.Hide()
        GroupBox1.Visible = True
        GroupBox1.Text = Button_Sinav.Text

        secim = "sinav"

    End Sub

    Private Sub Button_Ders_Click(sender As Object, e As EventArgs) Handles Button_Ders.Click

        Label1.Hide()
        GroupBox1.Visible = True
        GroupBox1.Text = Button_Ders.Text

        secim = "ders"

    End Sub



    Private Sub Button_YeniKayit_Click(sender As Object, e As EventArgs) Handles Button_YeniKayit.Click
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
        DataGridView1.DataSource = database.AsistanListesiAl()
        ListBox1.DataSource = database.AsistanListesiAl()

        Dim tnUst As New TreeNode("Vize")
        Dim tn As New TreeNode("Sinav1")
        tnUst.Nodes.Add(tn)
        TreeView1.Nodes.Add(tnUst)
    End Sub
End Class
