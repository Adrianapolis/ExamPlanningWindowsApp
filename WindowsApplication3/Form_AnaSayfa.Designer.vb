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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Duzenle = New System.Windows.Forms.Button()
        Me.Button_Sil = New System.Windows.Forms.Button()
        Me.Button_YeniKayit = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(386, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 11
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(665, 45)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(442, 361)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Location = New System.Drawing.Point(23, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(415, 353)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Location = New System.Drawing.Point(23, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(415, 353)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(87, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Button1"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(168, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Button1"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(179, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Button1"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(98, 17)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Button1"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(17, 17)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(705, 427)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(369, 287)
        Me.TreeView1.TabIndex = 13
        '
        'Form_AnaSayfa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 772)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Ders)
        Me.Controls.Add(Me.Button_Sinav)
        Me.Controls.Add(Me.Button_Asistan)
        Me.Controls.Add(Me.Button_Sinif)
        Me.Name = "Form_AnaSayfa"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Sinif As Button
    Friend WithEvents Button_Asistan As Button
    Friend WithEvents Button_Sinav As Button
    Friend WithEvents Button_Ders As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_Duzenle As Button
    Friend WithEvents Button_Sil As Button
    Friend WithEvents Button_YeniKayit As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TreeView1 As TreeView
End Class
