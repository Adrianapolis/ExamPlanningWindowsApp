Public Class Form_Sınav
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_OgrListeSec.Click
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim sr As New System.IO.StreamReader(OpenFileDialog1.FileName)
            MessageBox.Show(sr.ReadToEnd)
            sr.Close()
        End If
    End Sub

    Private Sub Form_Sınav_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class