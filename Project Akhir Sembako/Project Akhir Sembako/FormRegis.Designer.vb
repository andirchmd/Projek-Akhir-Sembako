<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegis
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegis))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNomorTlp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.BtnReturn = New System.Windows.Forms.Button()
        Me.BtnRegis = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtNomorTlp)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtNama)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TxtPass)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtUser)
        Me.Panel1.Controls.Add(Me.BtnReturn)
        Me.Panel1.Controls.Add(Me.BtnRegis)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 187)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(399, 406)
        Me.Panel1.TabIndex = 3
        '
        'txtNomorTlp
        '
        Me.txtNomorTlp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomorTlp.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.txtNomorTlp.Location = New System.Drawing.Point(50, 247)
        Me.txtNomorTlp.Name = "txtNomorTlp"
        Me.txtNomorTlp.Size = New System.Drawing.Size(300, 23)
        Me.txtNomorTlp.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(55, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(290, 3)
        Me.Label6.TabIndex = 17
        '
        'txtNama
        '
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNama.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.txtNama.Location = New System.Drawing.Point(50, 179)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(300, 23)
        Me.txtNama.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label7.Location = New System.Drawing.Point(148, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 24)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "NO TELPON"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label8.Location = New System.Drawing.Point(166, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 24)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "NAMA"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(55, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(290, 3)
        Me.Label9.TabIndex = 14
        '
        'TxtPass
        '
        Me.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPass.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.TxtPass.Location = New System.Drawing.Point(50, 110)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(300, 23)
        Me.TxtPass.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(55, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(290, 3)
        Me.Label4.TabIndex = 11
        '
        'TxtUser
        '
        Me.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUser.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.TxtUser.Location = New System.Drawing.Point(50, 42)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(300, 23)
        Me.TxtUser.TabIndex = 10
        '
        'BtnReturn
        '
        Me.BtnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.BtnReturn.FlatAppearance.BorderSize = 0
        Me.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReturn.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.BtnReturn.Location = New System.Drawing.Point(50, 344)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(300, 47)
        Me.BtnReturn.TabIndex = 9
        Me.BtnReturn.Text = "KEMBALI"
        Me.BtnReturn.UseVisualStyleBackColor = False
        '
        'BtnRegis
        '
        Me.BtnRegis.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.BtnRegis.FlatAppearance.BorderSize = 0
        Me.BtnRegis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegis.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.BtnRegis.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnRegis.Location = New System.Drawing.Point(50, 291)
        Me.BtnRegis.Name = "BtnRegis"
        Me.BtnRegis.Size = New System.Drawing.Size(300, 47)
        Me.BtnRegis.TabIndex = 8
        Me.BtnRegis.Text = "REGISTRASI"
        Me.BtnRegis.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(148, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(148, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "USERNAME"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(55, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(290, 3)
        Me.Label3.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(147, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "REGISTRASI"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(134, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'FormRegis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(398, 589)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormRegis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRegis"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNomorTlp As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents BtnReturn As Button
    Friend WithEvents BtnRegis As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
