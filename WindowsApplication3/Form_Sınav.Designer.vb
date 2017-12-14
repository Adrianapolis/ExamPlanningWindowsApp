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
        Me.btnListeYukle = New System.Windows.Forms.Button()
        Me.lblOgrenciSayisi = New System.Windows.Forms.Label()
        Me.lblOgrenciSayisi1 = New System.Windows.Forms.Label()
        Me.flSinifListele = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblYerlestirilen = New System.Windows.Forms.Label()
        Me.lblyrlssayi = New System.Windows.Forms.Label()
        Me.lblsnfsyi = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblSecilenDerslikSayi = New System.Windows.Forms.Label()
        Me.lblAcilanDosya = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbSinavTuru = New System.Windows.Forms.ComboBox()
        Me.flAsistanlar = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSinavOlustur
        '
        Me.btnSinavOlustur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnSinavOlustur.Location = New System.Drawing.Point(28, 189)
        Me.btnSinavOlustur.Name = "btnSinavOlustur"
        Me.btnSinavOlustur.Size = New System.Drawing.Size(237, 20)
        Me.btnSinavOlustur.TabIndex = 9
        Me.btnSinavOlustur.Text = "Sınav Oluştur"
        Me.btnSinavOlustur.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(25, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Öğrenci Listesi :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(34, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ders Adı :"
        '
        'cbDersAdi
        '
        Me.cbDersAdi.FormattingEnabled = True
        Me.cbDersAdi.Location = New System.Drawing.Point(93, 27)
        Me.cbDersAdi.Name = "cbDersAdi"
        Me.cbDersAdi.Size = New System.Drawing.Size(170, 21)
        Me.cbDersAdi.TabIndex = 10
        '
        'btnListeYukle
        '
        Me.btnListeYukle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnListeYukle.Location = New System.Drawing.Point(113, 163)
        Me.btnListeYukle.Name = "btnListeYukle"
        Me.btnListeYukle.Size = New System.Drawing.Size(152, 20)
        Me.btnListeYukle.TabIndex = 11
        Me.btnListeYukle.Text = "Liste Seç"
        Me.btnListeYukle.UseVisualStyleBackColor = True
        '
        'lblOgrenciSayisi
        '
        Me.lblOgrenciSayisi.AutoSize = True
        Me.lblOgrenciSayisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblOgrenciSayisi.Location = New System.Drawing.Point(25, 97)
        Me.lblOgrenciSayisi.Name = "lblOgrenciSayisi"
        Me.lblOgrenciSayisi.Size = New System.Drawing.Size(86, 13)
        Me.lblOgrenciSayisi.TabIndex = 5
        Me.lblOgrenciSayisi.Text = "Öğrenci Sayısı : -"
        '
        'lblOgrenciSayisi1
        '
        Me.lblOgrenciSayisi1.AutoSize = True
        Me.lblOgrenciSayisi1.Location = New System.Drawing.Point(520, 209)
        Me.lblOgrenciSayisi1.Name = "lblOgrenciSayisi1"
        Me.lblOgrenciSayisi1.Size = New System.Drawing.Size(0, 13)
        Me.lblOgrenciSayisi1.TabIndex = 13
        '
        'flSinifListele
        '
        Me.flSinifListele.AutoScroll = True
        Me.flSinifListele.Location = New System.Drawing.Point(304, 43)
        Me.flSinifListele.Name = "flSinifListele"
        Me.flSinifListele.Size = New System.Drawing.Size(226, 205)
        Me.flSinifListele.TabIndex = 16
        '
        'lblYerlestirilen
        '
        Me.lblYerlestirilen.AutoSize = True
        Me.lblYerlestirilen.Location = New System.Drawing.Point(25, 144)
        Me.lblYerlestirilen.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblYerlestirilen.Name = "lblYerlestirilen"
        Me.lblYerlestirilen.Size = New System.Drawing.Size(142, 13)
        Me.lblYerlestirilen.TabIndex = 18
        Me.lblYerlestirilen.Text = "Yerleştirilen Öğrenci Sayısı : -"
        '
        'lblyrlssayi
        '
        Me.lblyrlssayi.AutoSize = True
        Me.lblyrlssayi.Location = New System.Drawing.Point(136, 131)
        Me.lblyrlssayi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblyrlssayi.Name = "lblyrlssayi"
        Me.lblyrlssayi.Size = New System.Drawing.Size(0, 13)
        Me.lblyrlssayi.TabIndex = 19
        '
        'lblsnfsyi
        '
        Me.lblsnfsyi.AutoSize = True
        Me.lblsnfsyi.Location = New System.Drawing.Point(103, 110)
        Me.lblsnfsyi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsnfsyi.Name = "lblsnfsyi"
        Me.lblsnfsyi.Size = New System.Drawing.Size(0, 13)
        Me.lblsnfsyi.TabIndex = 20
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Brown
        Me.lblError.Location = New System.Drawing.Point(25, 212)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(175, 16)
        Me.lblError.TabIndex = 12
        Me.lblError.Text = "Öğrenci listesini seçiniz."
        '
        'lblSecilenDerslikSayi
        '
        Me.lblSecilenDerslikSayi.AutoSize = True
        Me.lblSecilenDerslikSayi.Location = New System.Drawing.Point(25, 123)
        Me.lblSecilenDerslikSayi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSecilenDerslikSayi.Name = "lblSecilenDerslikSayi"
        Me.lblSecilenDerslikSayi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSecilenDerslikSayi.Size = New System.Drawing.Size(119, 13)
        Me.lblSecilenDerslikSayi.TabIndex = 21
        Me.lblSecilenDerslikSayi.Text = "Seçilen Derslik Sayısı : -"
        '
        'lblAcilanDosya
        '
        Me.lblAcilanDosya.AutoSize = True
        Me.lblAcilanDosya.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAcilanDosya.ForeColor = System.Drawing.Color.Brown
        Me.lblAcilanDosya.Location = New System.Drawing.Point(25, 232)
        Me.lblAcilanDosya.Name = "lblAcilanDosya"
        Me.lblAcilanDosya.Size = New System.Drawing.Size(117, 16)
        Me.lblAcilanDosya.TabIndex = 22
        Me.lblAcilanDosya.Text = "Açılan Dosya : -"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(301, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Derslikler"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Sınav Türü:"
        '
        'cbSinavTuru
        '
        Me.cbSinavTuru.FormattingEnabled = True
        Me.cbSinavTuru.Items.AddRange(New Object() {"Vize", "Final", "Bütünleme"})
        Me.cbSinavTuru.Location = New System.Drawing.Point(93, 61)
        Me.cbSinavTuru.Name = "cbSinavTuru"
        Me.cbSinavTuru.Size = New System.Drawing.Size(170, 21)
        Me.cbSinavTuru.TabIndex = 25
        '
        'flAsistanlar
        '
        Me.flAsistanlar.Location = New System.Drawing.Point(558, 43)
        Me.flAsistanlar.Name = "flAsistanlar"
        Me.flAsistanlar.Size = New System.Drawing.Size(226, 205)
        Me.flAsistanlar.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(555, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Asistanlar"
        '
        'Form_Sınav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 291)
        Me.Controls.Add(Me.flAsistanlar)
        Me.Controls.Add(Me.cbSinavTuru)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblAcilanDosya)
        Me.Controls.Add(Me.lblSecilenDerslikSayi)
        Me.Controls.Add(Me.lblsnfsyi)
        Me.Controls.Add(Me.lblyrlssayi)
        Me.Controls.Add(Me.lblYerlestirilen)
        Me.Controls.Add(Me.flSinifListele)
        Me.Controls.Add(Me.lblOgrenciSayisi1)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnListeYukle)
        Me.Controls.Add(Me.cbDersAdi)
        Me.Controls.Add(Me.btnSinavOlustur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblOgrenciSayisi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Sınav"
        Me.Text = "Form_Sınav"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSinavOlustur As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbDersAdi As ComboBox
    Friend WithEvents btnListeYukle As Button
    Friend WithEvents lblOgrenciSayisi As Label
    Friend WithEvents lblOgrenciSayisi1 As Label
    Friend WithEvents flSinifListele As FlowLayoutPanel
    Friend WithEvents lblYerlestirilen As Label
    Friend WithEvents lblyrlssayi As Label
    Friend WithEvents lblsnfsyi As Label
    Friend WithEvents lblError As Label
    Friend WithEvents lblSecilenDerslikSayi As Label
    Friend WithEvents lblAcilanDosya As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbSinavTuru As ComboBox
    Friend WithEvents flAsistanlar As FlowLayoutPanel
    Friend WithEvents Label5 As Label
End Class
