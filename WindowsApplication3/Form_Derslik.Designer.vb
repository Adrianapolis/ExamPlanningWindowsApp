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
        Me.btnDerslikOlustur = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tbDerslikAdi = New System.Windows.Forms.TextBox()
        Me.tbDerslikKapasite = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDerslikOlustur
        '
        Me.btnDerslikOlustur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnDerslikOlustur.Location = New System.Drawing.Point(102, 134)
        Me.btnDerslikOlustur.Name = "btnDerslikOlustur"
        Me.btnDerslikOlustur.Size = New System.Drawing.Size(170, 20)
        Me.btnDerslikOlustur.TabIndex = 15
        Me.btnDerslikOlustur.Text = "Derslik Oluştur"
        Me.btnDerslikOlustur.UseVisualStyleBackColor = True
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
        'tbDerslikAdi
        '
        Me.tbDerslikAdi.Location = New System.Drawing.Point(102, 83)
        Me.tbDerslikAdi.Name = "tbDerslikAdi"
        Me.tbDerslikAdi.Size = New System.Drawing.Size(170, 20)
        Me.tbDerslikAdi.TabIndex = 19
        '
        'tbDerslikKapasite
        '
        Me.tbDerslikKapasite.Location = New System.Drawing.Point(102, 108)
        Me.tbDerslikKapasite.Name = "tbDerslikKapasite"
        Me.tbDerslikKapasite.Size = New System.Drawing.Size(170, 20)
        Me.tbDerslikKapasite.TabIndex = 20
        '
        'Form_Derslik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.tbDerslikKapasite)
        Me.Controls.Add(Me.tbDerslikAdi)
        Me.Controls.Add(Me.btnDerslikOlustur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Derslik"
        Me.Text = "Form_Derslik"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDerslikOlustur As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents tbDerslikAdi As TextBox
    Friend WithEvents tbDerslikKapasite As TextBox
End Class
