<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Sınav
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSinavOlustur = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbDersAdi = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnListeYukle = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblOgrenciSayisi = New System.Windows.Forms.Label()
        Me.flSinifListele = New System.Windows.Forms.FlowLayoutPanel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.lblyrls = New System.Windows.Forms.Label()
        Me.lblyrlssayi = New System.Windows.Forms.Label()
        Me.lblsnfsyi = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblsclnsnfsayi = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSinavOlustur
        '
        Me.btnSinavOlustur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnSinavOlustur.Location = New System.Drawing.Point(134, 360)
        Me.btnSinavOlustur.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSinavOlustur.Name = "btnSinavOlustur"
        Me.btnSinavOlustur.Size = New System.Drawing.Size(227, 25)
        Me.btnSinavOlustur.TabIndex = 9
        Me.btnSinavOlustur.Text = "Sınav Oluştur"
        Me.btnSinavOlustur.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(16, 334)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Öğrenci Listesi :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(45, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ders Adı :"
        '
        'cbDersAdi
        '
        Me.cbDersAdi.FormattingEnabled = True
        Me.cbDersAdi.Location = New System.Drawing.Point(124, 33)
        Me.cbDersAdi.Margin = New System.Windows.Forms.Padding(4)
        Me.cbDersAdi.Name = "cbDersAdi"
        Me.cbDersAdi.Size = New System.Drawing.Size(225, 24)
        Me.cbDersAdi.TabIndex = 10
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnListeYukle
        '
        Me.btnListeYukle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnListeYukle.Location = New System.Drawing.Point(134, 329)
        Me.btnListeYukle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListeYukle.Name = "btnListeYukle"
        Me.btnListeYukle.Size = New System.Drawing.Size(227, 25)
        Me.btnListeYukle.TabIndex = 11
        Me.btnListeYukle.Text = "Liste Seç"
        Me.btnListeYukle.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(16, 271)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Öğrenci Sayısı:"
        '
        'lblOgrenciSayisi
        '
        Me.lblOgrenciSayisi.AutoSize = True
        Me.lblOgrenciSayisi.Location = New System.Drawing.Point(125, 271)
        Me.lblOgrenciSayisi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOgrenciSayisi.Name = "lblOgrenciSayisi"
        Me.lblOgrenciSayisi.Size = New System.Drawing.Size(0, 17)
        Me.lblOgrenciSayisi.TabIndex = 13
        '
        'flSinifListele
        '
        Me.flSinifListele.AutoScroll = True
        Me.flSinifListele.Location = New System.Drawing.Point(49, 66)
        Me.flSinifListele.Margin = New System.Windows.Forms.Padding(4)
        Me.flSinifListele.Name = "flSinifListele"
        Me.flSinifListele.Size = New System.Drawing.Size(301, 201)
        Me.flSinifListele.TabIndex = 16
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(379, 33)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(339, 374)
        Me.RichTextBox1.TabIndex = 17
        Me.RichTextBox1.Text = ""
        '
        'lblyrls
        '
        Me.lblyrls.AutoSize = True
        Me.lblyrls.Location = New System.Drawing.Point(159, 272)
        Me.lblyrls.Name = "lblyrls"
        Me.lblyrls.Size = New System.Drawing.Size(170, 17)
        Me.lblyrls.TabIndex = 18
        Me.lblyrls.Text = "Yerletirilen Öğrenci Sayısı"
        '
        'lblyrlssayi
        '
        Me.lblyrlssayi.AutoSize = True
        Me.lblyrlssayi.Location = New System.Drawing.Point(336, 271)
        Me.lblyrlssayi.Name = "lblyrlssayi"
        Me.lblyrlssayi.Size = New System.Drawing.Size(0, 17)
        Me.lblyrlssayi.TabIndex = 19
        '
        'lblsnfsyi
        '
        Me.lblsnfsyi.AutoSize = True
        Me.lblsnfsyi.Location = New System.Drawing.Point(178, 298)
        Me.lblsnfsyi.Name = "lblsnfsyi"
        Me.lblsnfsyi.Size = New System.Drawing.Size(0, 17)
        Me.lblsnfsyi.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Brown
        Me.Label3.Location = New System.Drawing.Point(115, 449)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 12
        '
        'lblsclnsnfsayi
        '
        Me.lblsclnsnfsayi.AutoSize = True
        Me.lblsclnsnfsayi.Location = New System.Drawing.Point(46, 298)
        Me.lblsclnsnfsayi.Name = "lblsclnsnfsayi"
        Me.lblsclnsnfsayi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblsclnsnfsayi.Size = New System.Drawing.Size(126, 17)
        Me.lblsclnsnfsayi.TabIndex = 21
        Me.lblsclnsnfsayi.Text = "Seçilen Sınıf Sayısı"
        '
        'Form_Sınav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 779)
        Me.Controls.Add(Me.lblsclnsnfsayi)
        Me.Controls.Add(Me.lblsnfsyi)
        Me.Controls.Add(Me.lblyrlssayi)
        Me.Controls.Add(Me.lblyrls)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.flSinifListele)
        Me.Controls.Add(Me.lblOgrenciSayisi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnListeYukle)
        Me.Controls.Add(Me.cbDersAdi)
        Me.Controls.Add(Me.btnSinavOlustur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form_Sınav"
        Me.Text = "Form_Sınav"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSinavOlustur As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbDersAdi As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnListeYukle As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblOgrenciSayisi As Label
    Friend WithEvents flSinifListele As FlowLayoutPanel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents lblyrls As Label
    Friend WithEvents lblyrlssayi As Label
    Friend WithEvents lblsnfsyi As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblsclnsnfsayi As Label
End Class
