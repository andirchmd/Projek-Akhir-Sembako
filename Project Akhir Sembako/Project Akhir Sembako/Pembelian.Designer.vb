<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pembelian))
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.cbkodebarang = New System.Windows.Forms.ComboBox()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtHargaBarang = New System.Windows.Forms.TextBox()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.txtIdUser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIdRiwayat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnmenu
        '
        Me.btnmenu.BackColor = System.Drawing.Color.DimGray
        Me.btnmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmenu.Location = New System.Drawing.Point(38, 369)
        Me.btnmenu.Margin = New System.Windows.Forms.Padding(2)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(76, 26)
        Me.btnmenu.TabIndex = 91
        Me.btnmenu.Text = "Menu"
        Me.btnmenu.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(249, 102)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(792, 293)
        Me.DataGridView1.TabIndex = 89
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Location = New System.Drawing.Point(136, 369)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(76, 26)
        Me.btnexit.TabIndex = 88
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Silver
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Location = New System.Drawing.Point(136, 280)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(76, 26)
        Me.btnclear.TabIndex = 87
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.Red
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapus.Location = New System.Drawing.Point(136, 325)
        Me.btnhapus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(76, 26)
        Me.btnhapus.TabIndex = 86
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnubah
        '
        Me.btnubah.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnubah.Location = New System.Drawing.Point(38, 325)
        Me.btnubah.Margin = New System.Windows.Forms.Padding(2)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(76, 26)
        Me.btnubah.TabIndex = 85
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsimpan.Location = New System.Drawing.Point(38, 280)
        Me.btnsimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(76, 26)
        Me.btnsimpan.TabIndex = 84
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'cbkodebarang
        '
        Me.cbkodebarang.FormattingEnabled = True
        Me.cbkodebarang.Location = New System.Drawing.Point(101, 99)
        Me.cbkodebarang.Margin = New System.Windows.Forms.Padding(2)
        Me.cbkodebarang.Name = "cbkodebarang"
        Me.cbkodebarang.Size = New System.Drawing.Size(120, 21)
        Me.cbkodebarang.TabIndex = 83
        '
        'TxtCari
        '
        Me.TxtCari.Location = New System.Drawing.Point(345, 68)
        Me.TxtCari.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(637, 20)
        Me.TxtCari.TabIndex = 82
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(101, 249)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(120, 20)
        Me.txtTotal.TabIndex = 81
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(101, 219)
        Me.txtJumlah.Margin = New System.Windows.Forms.Padding(2)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(120, 20)
        Me.txtJumlah.TabIndex = 80
        '
        'txtHargaBarang
        '
        Me.txtHargaBarang.Enabled = False
        Me.txtHargaBarang.Location = New System.Drawing.Point(101, 160)
        Me.txtHargaBarang.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHargaBarang.Name = "txtHargaBarang"
        Me.txtHargaBarang.ReadOnly = True
        Me.txtHargaBarang.Size = New System.Drawing.Size(120, 20)
        Me.txtHargaBarang.TabIndex = 79
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Enabled = False
        Me.txtNamaBarang.Location = New System.Drawing.Point(101, 128)
        Me.txtNamaBarang.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.ReadOnly = True
        Me.txtNamaBarang.Size = New System.Drawing.Size(120, 20)
        Me.txtNamaBarang.TabIndex = 78
        '
        'txtIdUser
        '
        Me.txtIdUser.Enabled = False
        Me.txtIdUser.Location = New System.Drawing.Point(101, 68)
        Me.txtIdUser.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdUser.Name = "txtIdUser"
        Me.txtIdUser.ReadOnly = True
        Me.txtIdUser.Size = New System.Drawing.Size(120, 20)
        Me.txtIdUser.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(24, 252)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(24, 222)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Jumlah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 163)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Harga Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Kode Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "ID Pembeli"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(25, 131)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Nama Barang"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(270, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 25)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "Cari"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(304, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(470, 25)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "MENU PEMBELIAN TOKO SEMBAKO DAENG" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtStok
        '
        Me.txtStok.Enabled = False
        Me.txtStok.Location = New System.Drawing.Point(101, 190)
        Me.txtStok.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.ReadOnly = True
        Me.txtStok.Size = New System.Drawing.Size(120, 20)
        Me.txtStok.TabIndex = 95
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(24, 193)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Stok"
        '
        'txtIdRiwayat
        '
        Me.txtIdRiwayat.Enabled = False
        Me.txtIdRiwayat.Location = New System.Drawing.Point(101, 38)
        Me.txtIdRiwayat.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdRiwayat.Name = "txtIdRiwayat"
        Me.txtIdRiwayat.ReadOnly = True
        Me.txtIdRiwayat.Size = New System.Drawing.Size(120, 20)
        Me.txtIdRiwayat.TabIndex = 97
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(24, 41)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 96
        Me.Label10.Text = "ID Riwayat"
        '
        'Pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1066, 413)
        Me.Controls.Add(Me.txtIdRiwayat)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.cbkodebarang)
        Me.Controls.Add(Me.TxtCari)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.txtHargaBarang)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.txtIdUser)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembelian"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnmenu As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnexit As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnubah As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents cbkodebarang As ComboBox
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtHargaBarang As TextBox
    Friend WithEvents txtNamaBarang As TextBox
    Friend WithEvents txtIdUser As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStok As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtIdRiwayat As TextBox
    Friend WithEvents Label10 As Label
End Class
