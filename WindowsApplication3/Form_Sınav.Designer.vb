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
        Me.Button_SınavOlustur = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_DersAdı = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button_OgrListeSec = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label_Kapasite = New System.Windows.Forms.Label()
        Me.ComboBox_Sinif = New System.Windows.Forms.ComboBox()
        Me.gb_Siniflar = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'Button_SınavOlustur
        '
        Me.Button_SınavOlustur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button_SınavOlustur.Location = New System.Drawing.Point(95, 311)
        Me.Button_SınavOlustur.Name = "Button_SınavOlustur"
        Me.Button_SınavOlustur.Size = New System.Drawing.Size(170, 20)
        Me.Button_SınavOlustur.TabIndex = 9
        Me.Button_SınavOlustur.Text = "Sınav Oluştur"
        Me.Button_SınavOlustur.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(7, 290)
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
        'ComboBox_DersAdı
        '
        Me.ComboBox_DersAdı.FormattingEnabled = True
        Me.ComboBox_DersAdı.Location = New System.Drawing.Point(93, 27)
        Me.ComboBox_DersAdı.Name = "ComboBox_DersAdı"
        Me.ComboBox_DersAdı.Size = New System.Drawing.Size(170, 21)
        Me.ComboBox_DersAdı.TabIndex = 10
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button_OgrListeSec
        '
        Me.Button_OgrListeSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button_OgrListeSec.Location = New System.Drawing.Point(95, 286)
        Me.Button_OgrListeSec.Name = "Button_OgrListeSec"
        Me.Button_OgrListeSec.Size = New System.Drawing.Size(170, 20)
        Me.Button_OgrListeSec.TabIndex = 11
        Me.Button_OgrListeSec.Text = "Liste Seç"
        Me.Button_OgrListeSec.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 356)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "BU FORMUN GELİŞTİRİLMESİ GEREKİYOR !!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(36, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Kapasite:"
        '
        'Label_Kapasite
        '
        Me.Label_Kapasite.AutoSize = True
        Me.Label_Kapasite.Location = New System.Drawing.Point(94, 260)
        Me.Label_Kapasite.Name = "Label_Kapasite"
        Me.Label_Kapasite.Size = New System.Drawing.Size(0, 13)
        Me.Label_Kapasite.TabIndex = 13
        '
        'ComboBox_Sinif
        '
        Me.ComboBox_Sinif.FormattingEnabled = True
        Me.ComboBox_Sinif.Location = New System.Drawing.Point(93, 55)
        Me.ComboBox_Sinif.Name = "ComboBox_Sinif"
        Me.ComboBox_Sinif.Size = New System.Drawing.Size(170, 21)
        Me.ComboBox_Sinif.TabIndex = 14
        '
        'gb_Siniflar
        '
        Me.gb_Siniflar.Location = New System.Drawing.Point(26, 85)
        Me.gb_Siniflar.Name = "gb_Siniflar"
        Me.gb_Siniflar.Size = New System.Drawing.Size(292, 166)
        Me.gb_Siniflar.TabIndex = 15
        Me.gb_Siniflar.TabStop = False
        Me.gb_Siniflar.Text = "GroupBox1"
        '
        'Form_Sınav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 427)
        Me.Controls.Add(Me.gb_Siniflar)
        Me.Controls.Add(Me.ComboBox_Sinif)
        Me.Controls.Add(Me.Label_Kapasite)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button_OgrListeSec)
        Me.Controls.Add(Me.ComboBox_DersAdı)
        Me.Controls.Add(Me.Button_SınavOlustur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Sınav"
        Me.Text = "Form_Sınav"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_SınavOlustur As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox_DersAdı As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button_OgrListeSec As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label_Kapasite As Label
    Friend WithEvents ComboBox_Sinif As ComboBox
    Friend WithEvents gb_Siniflar As GroupBox
End Class
