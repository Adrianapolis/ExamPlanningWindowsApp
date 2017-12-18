<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_AnaSayfa
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
        Me.btnDerslik = New System.Windows.Forms.Button()
        Me.btnAsistan = New System.Windows.Forms.Button()
        Me.btnSinav = New System.Windows.Forms.Button()
        Me.btnDers = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDuzenle = New System.Windows.Forms.Button()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.btnKayitEkle = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDerslik
        '
        Me.btnDerslik.Location = New System.Drawing.Point(12, 12)
        Me.btnDerslik.Name = "btnDerslik"
        Me.btnDerslik.Size = New System.Drawing.Size(101, 23)
        Me.btnDerslik.TabIndex = 0
        Me.btnDerslik.Text = "Derslikler"
        Me.btnDerslik.UseVisualStyleBackColor = True
        '
        'btnAsistan
        '
        Me.btnAsistan.Location = New System.Drawing.Point(141, 12)
        Me.btnAsistan.Name = "btnAsistan"
        Me.btnAsistan.Size = New System.Drawing.Size(101, 23)
        Me.btnAsistan.TabIndex = 1
        Me.btnAsistan.Text = "Asistanlar"
        Me.btnAsistan.UseVisualStyleBackColor = True
        '
        'btnSinav
        '
        Me.btnSinav.Location = New System.Drawing.Point(272, 12)
        Me.btnSinav.Name = "btnSinav"
        Me.btnSinav.Size = New System.Drawing.Size(101, 23)
        Me.btnSinav.TabIndex = 2
        Me.btnSinav.Text = "Sınavlar"
        Me.btnSinav.UseVisualStyleBackColor = True
        '
        'btnDers
        '
        Me.btnDers.Location = New System.Drawing.Point(408, 12)
        Me.btnDers.Name = "btnDers"
        Me.btnDers.Size = New System.Drawing.Size(101, 23)
        Me.btnDers.TabIndex = 3
        Me.btnDers.Text = "Dersler"
        Me.btnDers.UseVisualStyleBackColor = True
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
        'btnDuzenle
        '
        Me.btnDuzenle.Location = New System.Drawing.Point(403, 51)
        Me.btnDuzenle.Name = "btnDuzenle"
        Me.btnDuzenle.Size = New System.Drawing.Size(140, 23)
        Me.btnDuzenle.TabIndex = 10
        Me.btnDuzenle.Text = "SEÇİLİ OLANI DÜZENLE"
        Me.btnDuzenle.UseVisualStyleBackColor = True
        '
        'btnSil
        '
        Me.btnSil.Location = New System.Drawing.Point(403, 22)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(140, 23)
        Me.btnSil.TabIndex = 9
        Me.btnSil.Text = "SEÇİLİ OLANI SİL"
        Me.btnSil.UseVisualStyleBackColor = True
        '
        'btnKayitEkle
        '
        Me.btnKayitEkle.Location = New System.Drawing.Point(7, 382)
        Me.btnKayitEkle.Name = "btnKayitEkle"
        Me.btnKayitEkle.Size = New System.Drawing.Size(361, 23)
        Me.btnKayitEkle.TabIndex = 8
        Me.btnKayitEkle.Text = "YENİ KAYIT EKLE"
        Me.btnKayitEkle.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Controls.Add(Me.btnDuzenle)
        Me.GroupBox1.Controls.Add(Me.btnSil)
        Me.GroupBox1.Controls.Add(Me.btnKayitEkle)
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
        Me.ClientSize = New System.Drawing.Size(647, 552)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDers)
        Me.Controls.Add(Me.btnSinav)
        Me.Controls.Add(Me.btnAsistan)
        Me.Controls.Add(Me.btnDerslik)
        Me.Name = "Form_AnaSayfa"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDerslik As Button
    Friend WithEvents btnAsistan As Button
    Friend WithEvents btnSinav As Button
    Friend WithEvents btnDers As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDuzenle As Button
    Friend WithEvents btnSil As Button
    Friend WithEvents btnKayitEkle As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
