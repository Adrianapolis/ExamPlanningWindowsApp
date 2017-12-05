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
        Me.TextBox_DersAdi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_DersKodu = New System.Windows.Forms.TextBox()
        Me.Button_DersEkle = New System.Windows.Forms.Button()
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
        'TextBox_DersAdi
        '
        Me.TextBox_DersAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextBox_DersAdi.Location = New System.Drawing.Point(91, 73)
        Me.TextBox_DersAdi.Name = "TextBox_DersAdi"
        Me.TextBox_DersAdi.Size = New System.Drawing.Size(170, 20)
        Me.TextBox_DersAdi.TabIndex = 1
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
        'TextBox_DersKodu
        '
        Me.TextBox_DersKodu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextBox_DersKodu.Location = New System.Drawing.Point(91, 99)
        Me.TextBox_DersKodu.Name = "TextBox_DersKodu"
        Me.TextBox_DersKodu.Size = New System.Drawing.Size(170, 20)
        Me.TextBox_DersKodu.TabIndex = 3
        '
        'Button_DersEkle
        '
        Me.Button_DersEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button_DersEkle.Location = New System.Drawing.Point(91, 125)
        Me.Button_DersEkle.Name = "Button_DersEkle"
        Me.Button_DersEkle.Size = New System.Drawing.Size(170, 20)
        Me.Button_DersEkle.TabIndex = 4
        Me.Button_DersEkle.Text = "Ekle"
        Me.Button_DersEkle.UseVisualStyleBackColor = True
        '
        'Form_Ders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button_DersEkle)
        Me.Controls.Add(Me.TextBox_DersKodu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_DersAdi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Ders"
        Me.Text = "Form_Ders"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_DersAdi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_DersKodu As TextBox
    Friend WithEvents Button_DersEkle As Button
End Class
