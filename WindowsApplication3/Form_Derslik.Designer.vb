<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Derslik
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
        Me.Button_DerslikOlustur = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox_DerslikAdi = New System.Windows.Forms.TextBox()
        Me.TextBox_DerslikKapasite = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button_DerslikOlustur
        '
        Me.Button_DerslikOlustur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button_DerslikOlustur.Location = New System.Drawing.Point(102, 134)
        Me.Button_DerslikOlustur.Name = "Button_DerslikOlustur"
        Me.Button_DerslikOlustur.Size = New System.Drawing.Size(170, 20)
        Me.Button_DerslikOlustur.TabIndex = 15
        Me.Button_DerslikOlustur.Text = "Derslik Oluştur"
        Me.Button_DerslikOlustur.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(4, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Derslik Kapasitesi :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(37, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Derslik Adı :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox_DerslikAdi
        '
        Me.TextBox_DerslikAdi.Location = New System.Drawing.Point(102, 83)
        Me.TextBox_DerslikAdi.Name = "TextBox_DerslikAdi"
        Me.TextBox_DerslikAdi.Size = New System.Drawing.Size(170, 20)
        Me.TextBox_DerslikAdi.TabIndex = 19
        '
        'TextBox_DerslikKapasite
        '
        Me.TextBox_DerslikKapasite.Location = New System.Drawing.Point(102, 108)
        Me.TextBox_DerslikKapasite.Name = "TextBox_DerslikKapasite"
        Me.TextBox_DerslikKapasite.Size = New System.Drawing.Size(170, 20)
        Me.TextBox_DerslikKapasite.TabIndex = 20
        '
        'Form_Derslik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TextBox_DerslikKapasite)
        Me.Controls.Add(Me.TextBox_DerslikAdi)
        Me.Controls.Add(Me.Button_DerslikOlustur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Derslik"
        Me.Text = "Form_Derslik"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_DerslikOlustur As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox_DerslikAdi As TextBox
    Friend WithEvents TextBox_DerslikKapasite As TextBox
End Class
