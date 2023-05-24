<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendataanBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengaturanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GantiUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.NamaLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StatusID = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.KeluarToolStripMenuItem, Me.PengaturanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(570, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.BackColor = System.Drawing.Color.Yellow
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PendataanBarangToolStripMenuItem, Me.PembelianBarangToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 22)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'PendataanBarangToolStripMenuItem
        '
        Me.PendataanBarangToolStripMenuItem.Name = "PendataanBarangToolStripMenuItem"
        Me.PendataanBarangToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PendataanBarangToolStripMenuItem.Text = "Pendataan Barang"
        '
        'PembelianBarangToolStripMenuItem
        '
        Me.PembelianBarangToolStripMenuItem.Name = "PembelianBarangToolStripMenuItem"
        Me.PembelianBarangToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PembelianBarangToolStripMenuItem.Text = "Pembelian Barang"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.BackColor = System.Drawing.Color.Chartreuse
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'PengaturanToolStripMenuItem
        '
        Me.PengaturanToolStripMenuItem.BackColor = System.Drawing.Color.DimGray
        Me.PengaturanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.GantiUserToolStripMenuItem})
        Me.PengaturanToolStripMenuItem.Name = "PengaturanToolStripMenuItem"
        Me.PengaturanToolStripMenuItem.Size = New System.Drawing.Size(80, 22)
        Me.PengaturanToolStripMenuItem.Text = "Pengaturan"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'GantiUserToolStripMenuItem
        '
        Me.GantiUserToolStripMenuItem.Name = "GantiUserToolStripMenuItem"
        Me.GantiUserToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.GantiUserToolStripMenuItem.Text = "Ganti User"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NamaLabel, Me.StatusID})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 297)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 9, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(570, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'NamaLabel
        '
        Me.NamaLabel.Name = "NamaLabel"
        Me.NamaLabel.Size = New System.Drawing.Size(39, 17)
        Me.NamaLabel.Text = "Nama"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(76, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(423, 25)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "MENU UTAMA TOKO SEMBAKO DAENG"
        '
        'StatusID
        '
        Me.StatusID.Name = "StatusID"
        Me.StatusID.Size = New System.Drawing.Size(44, 17)
        Me.StatusID.Text = "ID User"
        Me.StatusID.Visible = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(570, 319)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PendataanBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembelianBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengaturanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GantiUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents NamaLabel As ToolStripStatusLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents StatusID As ToolStripStatusLabel
End Class
