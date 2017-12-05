<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_AnaSayfa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button_Sinif = New System.Windows.Forms.Button()
        Me.Button_Asistan = New System.Windows.Forms.Button()
        Me.Button_Sinav = New System.Windows.Forms.Button()
        Me.Button_Ders = New System.Windows.Forms.Button()
        Me.Button_Hoca = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Duzenle = New System.Windows.Forms.Button()
        Me.Button_Sil = New System.Windows.Forms.Button()
        Me.Button_YeniKayit = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Sinif
        '
        Me.Button_Sinif.Location = New System.Drawing.Point(12, 12)
        Me.Button_Sinif.Name = "Button_Sinif"
        Me.Button_Sinif.Size = New System.Drawing.Size(101, 23)
        Me.Button_Sinif.TabIndex = 0
        Me.Button_Sinif.Text = "Sınıflar"
        Me.Button_Sinif.UseVisualStyleBackColor = True
        '
        'Button_Asistan
        '
        Me.Button_Asistan.Location = New System.Drawing.Point(141, 12)
        Me.Button_Asistan.Name = "Button_Asistan"
        Me.Button_Asistan.Size = New System.Drawing.Size(101, 23)
        Me.Button_Asistan.TabIndex = 1
        Me.Button_Asistan.Text = "Asistanlar"
        Me.Button_Asistan.UseVisualStyleBackColor = True
        '
        'Button_Sinav
        '
        Me.Button_Sinav.Location = New System.Drawing.Point(272, 12)
        Me.Button_Sinav.Name = "Button_Sinav"
        Me.Button_Sinav.Size = New System.Drawing.Size(101, 23)
        Me.Button_Sinav.TabIndex = 2
        Me.Button_Sinav.Text = "Sınavlar"
        Me.Button_Sinav.UseVisualStyleBackColor = True
        '
        'Button_Ders
        '
        Me.Button_Ders.Location = New System.Drawing.Point(408, 12)
        Me.Button_Ders.Name = "Button_Ders"
        Me.Button_Ders.Size = New System.Drawing.Size(101, 23)
        Me.Button_Ders.TabIndex = 3
        Me.Button_Ders.Text = "Dersler"
        Me.Button_Ders.UseVisualStyleBackColor = True
        '
        'Button_Hoca
        '
        Me.Button_Hoca.Location = New System.Drawing.Point(537, 12)
        Me.Button_Hoca.Name = "Button_Hoca"
        Me.Button_Hoca.Size = New System.Drawing.Size(101, 23)
        Me.Button_Hoca.TabIndex = 4
        Me.Button_Hoca.Text = "Hocalar"
        Me.Button_Hoca.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Label1.Location = New System.Drawing.Point(126, 491)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(406, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Lütfen üst menüden seçim yapınız."
        '
        'Button_Duzenle
        '
        Me.Button_Duzenle.Location = New System.Drawing.Point(403, 51)
        Me.Button_Duzenle.Name = "Button_Duzenle"
        Me.Button_Duzenle.Size = New System.Drawing.Size(140, 23)
        Me.Button_Duzenle.TabIndex = 10
        Me.Button_Duzenle.Text = "SEÇİLİ OLANI DÜZENLE"
        Me.Button_Duzenle.UseVisualStyleBackColor = True
        '
        'Button_Sil
        '
        Me.Button_Sil.Location = New System.Drawing.Point(403, 22)
        Me.Button_Sil.Name = "Button_Sil"
        Me.Button_Sil.Size = New System.Drawing.Size(140, 23)
        Me.Button_Sil.TabIndex = 9
        Me.Button_Sil.Text = "SEÇİLİ OLANI SİL"
        Me.Button_Sil.UseVisualStyleBackColor = True
        '
        'Button_YeniKayit
        '
        Me.Button_YeniKayit.Location = New System.Drawing.Point(7, 382)
        Me.Button_YeniKayit.Name = "Button_YeniKayit"
        Me.Button_YeniKayit.Size = New System.Drawing.Size(361, 23)
        Me.Button_YeniKayit.TabIndex = 8
        Me.Button_YeniKayit.Text = "YENİ KAYIT EKLE"
        Me.Button_YeniKayit.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(7, 21)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(361, 355)
        Me.ListBox1.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_Duzenle)
        Me.GroupBox1.Controls.Add(Me.Button_Sil)
        Me.GroupBox1.Controls.Add(Me.Button_YeniKayit)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 443)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        Me.GroupBox1.Visible = False
        '
        'Form_AnaSayfa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 575)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Hoca)
        Me.Controls.Add(Me.Button_Ders)
        Me.Controls.Add(Me.Button_Sinav)
        Me.Controls.Add(Me.Button_Asistan)
        Me.Controls.Add(Me.Button_Sinif)
        Me.Name = "Form_AnaSayfa"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Sinif As Button
    Friend WithEvents Button_Asistan As Button
    Friend WithEvents Button_Sinav As Button
    Friend WithEvents Button_Ders As Button
    Friend WithEvents Button_Hoca As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_Duzenle As Button
    Friend WithEvents Button_Sil As Button
    Friend WithEvents Button_YeniKayit As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
