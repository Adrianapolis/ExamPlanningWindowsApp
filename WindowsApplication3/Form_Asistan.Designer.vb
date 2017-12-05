<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Asistan
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
        Me.Button_AsistanEkle = New System.Windows.Forms.Button()
        Me.TextBox_AsistanEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_AsistanAdı = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_AsistanEkle
        '
        Me.Button_AsistanEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button_AsistanEkle.Location = New System.Drawing.Point(92, 146)
        Me.Button_AsistanEkle.Name = "Button_AsistanEkle"
        Me.Button_AsistanEkle.Size = New System.Drawing.Size(170, 20)
        Me.Button_AsistanEkle.TabIndex = 9
        Me.Button_AsistanEkle.Text = "Ekle"
        Me.Button_AsistanEkle.UseVisualStyleBackColor = True
        '
        'TextBox_AsistanEmail
        '
        Me.TextBox_AsistanEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextBox_AsistanEmail.Location = New System.Drawing.Point(92, 120)
        Me.TextBox_AsistanEmail.Name = "TextBox_AsistanEmail"
        Me.TextBox_AsistanEmail.Size = New System.Drawing.Size(170, 20)
        Me.TextBox_AsistanEmail.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(49, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "E-Mail:"
        '
        'TextBox_AsistanAdı
        '
        Me.TextBox_AsistanAdı.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextBox_AsistanAdı.Location = New System.Drawing.Point(92, 94)
        Me.TextBox_AsistanAdı.Name = "TextBox_AsistanAdı"
        Me.TextBox_AsistanAdı.Size = New System.Drawing.Size(170, 20)
        Me.TextBox_AsistanAdı.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(23, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Asistan Adı :"
        '
        'Form_Asistan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button_AsistanEkle)
        Me.Controls.Add(Me.TextBox_AsistanEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_AsistanAdı)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Asistan"
        Me.Text = "Form_Asistan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_AsistanEkle As Button
    Friend WithEvents TextBox_AsistanEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_AsistanAdı As TextBox
    Friend WithEvents Label1 As Label
End Class
