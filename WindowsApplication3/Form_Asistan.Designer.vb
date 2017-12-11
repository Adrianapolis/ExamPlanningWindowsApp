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
        Me.btnAsistanEkle = New System.Windows.Forms.Button()
        Me.tbAsistanMail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbAsistanAdi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAsistanEkle
        '
        Me.btnAsistanEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAsistanEkle.Location = New System.Drawing.Point(92, 146)
        Me.btnAsistanEkle.Name = "btnAsistanEkle"
        Me.btnAsistanEkle.Size = New System.Drawing.Size(170, 20)
        Me.btnAsistanEkle.TabIndex = 9
        Me.btnAsistanEkle.Text = "Ekle"
        Me.btnAsistanEkle.UseVisualStyleBackColor = True
        '
        'tbAsistanMail
        '
        Me.tbAsistanMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tbAsistanMail.Location = New System.Drawing.Point(92, 120)
        Me.tbAsistanMail.Name = "tbAsistanMail"
        Me.tbAsistanMail.Size = New System.Drawing.Size(170, 20)
        Me.tbAsistanMail.TabIndex = 8
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
        'tbAsistanAdi
        '
        Me.tbAsistanAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tbAsistanAdi.Location = New System.Drawing.Point(92, 94)
        Me.tbAsistanAdi.Name = "tbAsistanAdi"
        Me.tbAsistanAdi.Size = New System.Drawing.Size(170, 20)
        Me.tbAsistanAdi.TabIndex = 6
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
        Me.Controls.Add(Me.btnAsistanEkle)
        Me.Controls.Add(Me.tbAsistanMail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbAsistanAdi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Asistan"
        Me.Text = "Form_Asistan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAsistanEkle As Button
    Friend WithEvents tbAsistanMail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbAsistanAdi As TextBox
    Friend WithEvents Label1 As Label
End Class
