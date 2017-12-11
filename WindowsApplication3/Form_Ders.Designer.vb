<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Ders
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbDersAdi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbDersKodu = New System.Windows.Forms.TextBox()
        Me.btnDersEkle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(32, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ders Adı :"
        '
        'tbDersAdi
        '
        Me.tbDersAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tbDersAdi.Location = New System.Drawing.Point(91, 73)
        Me.tbDersAdi.Name = "tbDersAdi"
        Me.tbDersAdi.Size = New System.Drawing.Size(170, 20)
        Me.tbDersAdi.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(22, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ders Kodu :"
        '
        'tbDersKodu
        '
        Me.tbDersKodu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tbDersKodu.Location = New System.Drawing.Point(91, 99)
        Me.tbDersKodu.Name = "tbDersKodu"
        Me.tbDersKodu.Size = New System.Drawing.Size(170, 20)
        Me.tbDersKodu.TabIndex = 3
        '
        'btnDersEkle
        '
        Me.btnDersEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnDersEkle.Location = New System.Drawing.Point(91, 125)
        Me.btnDersEkle.Name = "btnDersEkle"
        Me.btnDersEkle.Size = New System.Drawing.Size(170, 20)
        Me.btnDersEkle.TabIndex = 4
        Me.btnDersEkle.Text = "Ekle"
        Me.btnDersEkle.UseVisualStyleBackColor = True
        '
        'Form_Ders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnDersEkle)
        Me.Controls.Add(Me.tbDersKodu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbDersAdi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Ders"
        Me.Text = "Form_Ders"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbDersAdi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbDersKodu As TextBox
    Friend WithEvents btnDersEkle As Button
End Class
