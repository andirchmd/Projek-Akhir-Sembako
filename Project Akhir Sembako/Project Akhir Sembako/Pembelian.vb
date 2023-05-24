Imports MySql.Data.MySqlClient

Public Class Pembelian
    Private Sub Pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call Kosong()
        If MainMenu.StatusID.Text <> 1 Then
            Call TampilPembelianUser()
            Call AturGridUser()
            txtIdUser.Text = MainMenu.StatusID.Text
            Label10.Visible = False
            txtIdRiwayat.Visible = False
            btnubah.Visible = False
            btnhapus.Visible = False
        Else
            Call TampilPembelianAdmin()
            Call AturGridAdmin()
            Label10.Visible = True
            txtIdRiwayat.Visible = True
            btnubah.Visible = True
            btnhapus.Visible = True
            txtIdRiwayat.Enabled = True
            txtIdUser.Enabled = True
            txtIdRiwayat.ReadOnly = False
            txtIdUser.ReadOnly = False
        End If
        Call TampilPendataan()

    End Sub

    Sub Kosong()
        txtNamaBarang.Clear()
        txtHargaBarang.Clear()
        txtJumlah.Clear()
        txtTotal.Clear()
        cbkodebarang.Text = ""
        txtIdUser.Focus()
        txtStok.Clear()
    End Sub

    Sub Isi()
        cbkodebarang.Text = ""
        txtIdUser.Clear()
        txtTotal.Clear()
        txtHargaBarang.Clear()
        txtJumlah.Clear()
        cbkodebarang.Focus()
    End Sub

    Sub TampilPembelianUser()
        DA = New MySqlDataAdapter("SELECT a.id_riwayat, b.nama, b.no_telp, c.nama_barang, c.satuan, c.harga_jual, a.jumlah_beli, a.total_harga, a.tanggal_pembelian FROM tbriwayat a INNER JOIN tbakun b ON a.id_user = b.id_user INNER JOIN tbsembako c ON a.id_barang = c.id_barang WHERE a.id_user = '" & MainMenu.StatusID.Text & "' ORDER BY a.id_riwayat", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "pembelian")
        DataGridView1.DataSource = DS.Tables("pembelian")
        DataGridView1.Refresh()
    End Sub

    Sub TampilPembelianAdmin()
        DA = New MySqlDataAdapter("SELECT a.id_riwayat, a.id_user, b.nama, b.no_telp, a.id_barang, c.nama_barang, c.satuan, c.harga_jual, a.jumlah_beli, a.total_harga, a.tanggal_pembelian FROM tbriwayat a INNER JOIN tbakun b ON a.id_user = b.id_user INNER JOIN tbsembako c ON a.id_barang = c.id_barang ORDER BY a.id_riwayat", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "pembelian")
        DataGridView1.DataSource = DS.Tables("pembelian")
        DataGridView1.Refresh()
    End Sub

    Sub TampilPendataan()
        CMD = New MySqlCommand("SELECT * from tbsembako", CONN)
        RD = CMD.ExecuteReader
        Do While RD.Read
            cbkodebarang.Items.Add(RD.Item(0))
        Loop
        RD.Close()
    End Sub

    Sub AturGridUser()
        'untuk mengatur luas kolom
        DataGridView1.Columns(0).Width = 110
        DataGridView1.Columns(1).Width = 110
        DataGridView1.Columns(2).Width = 130
        DataGridView1.Columns(3).Width = 130
        DataGridView1.Columns(4).Width = 130
        DataGridView1.Columns(5).Width = 130
        DataGridView1.Columns(6).Width = 130
        DataGridView1.Columns(7).Width = 130
        DataGridView1.Columns(8).Width = 130

        'untuk menampilkan judul header
        DataGridView1.Columns(0).HeaderText = "ID RIWAYAT"
        DataGridView1.Columns(1).HeaderText = "NAMA PEMBELI"
        DataGridView1.Columns(2).HeaderText = "NO TELPON"
        DataGridView1.Columns(3).HeaderText = "NAMA BARANG"
        DataGridView1.Columns(4).HeaderText = "SATUAN"
        DataGridView1.Columns(5).HeaderText = "HARGA"
        DataGridView1.Columns(6).HeaderText = "JUMLAH"
        DataGridView1.Columns(7).HeaderText = "TOTAL"
        DataGridView1.Columns(8).HeaderText = "TANGGAL"
    End Sub
    Sub AturGridAdmin()
        'untuk mengatur luas kolom
        DataGridView1.Columns(0).Width = 110
        DataGridView1.Columns(1).Width = 110
        DataGridView1.Columns(2).Width = 130
        DataGridView1.Columns(3).Width = 130
        DataGridView1.Columns(4).Width = 130
        DataGridView1.Columns(5).Width = 130
        DataGridView1.Columns(6).Width = 130
        DataGridView1.Columns(7).Width = 130
        DataGridView1.Columns(8).Width = 130
        DataGridView1.Columns(9).Width = 130
        DataGridView1.Columns(10).Width = 130

        'untuk menampilkan judul header 
        DataGridView1.Columns(0).HeaderText = "ID RIWAYAT"
        DataGridView1.Columns(1).HeaderText = "ID PEMBELI"
        DataGridView1.Columns(2).HeaderText = "NAMA PEMBELI"
        DataGridView1.Columns(3).HeaderText = "NO TELPON"
        DataGridView1.Columns(4).HeaderText = "ID BARANG"
        DataGridView1.Columns(5).HeaderText = "NAMA BARANG"
        DataGridView1.Columns(6).HeaderText = "SATUAN"
        DataGridView1.Columns(7).HeaderText = "HARGA"
        DataGridView1.Columns(8).HeaderText = "JUMLAH"
        DataGridView1.Columns(9).HeaderText = "TOTAL"
        DataGridView1.Columns(10).HeaderText = "TANGGAL"
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtIdUser.Text = "" Or cbkodebarang.Text = "" Or txtJumlah.Text = "" Then
            MsgBox("Data Belum Lengkap")
            txtIdUser.Focus()
            Exit Sub
        Else
            CMD = New MySqlCommand("SELECT stok FROM tbsembako where id_barang = '" & cbkodebarang.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            Dim stok As Integer = RD.GetValue(0)
            Dim stokkurang As Integer = txtJumlah.Text
            RD.Close()
            Dim stokakhir As Integer = stok - stokkurang
            If stokakhir < 0 Then
                MsgBox("Stok tidak cukup mohon kurangi jumlah pembelian!")
            Else
                Dim Simpan As String = "insert into tbriwayat(id_user, id_barang, jumlah_beli, total_harga, tanggal_pembelian) values
                                        ('" & txtIdUser.Text & "','" & cbkodebarang.Text & "','" & txtJumlah.Text & "',
                                        '" & txtTotal.Text & "',@datetimevalue)"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.Parameters.AddWithValue("@DateTimeValue", DateTime.Now)
                CMD.ExecuteNonQuery()

                Dim Ubah As String = "Update tbsembako set stok = '" & stokakhir & "' where id_barang = '" & cbkodebarang.Text & "'"
                CMD = New MySqlCommand(Ubah, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Simpan data sukses.....!", MsgBoxStyle.Information, "Perhatian")
            End If


            If MainMenu.StatusID.Text <> 1 Then
                Call TampilPembelianUser()
            Else
                Call TampilPembelianAdmin()
            End If
            Call Kosong()
            txtIdUser.Focus()
        End If
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Call Kosong()
        If MainMenu.StatusID.Text <> 1 Then
            Call TampilPembelianUser()
        Else
            Call TampilPembelianAdmin()
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtIdUser.Text = "" Then
            MsgBox("kode pembeli belum diisi!")
            txtIdUser.Focus()
        Else
            If MessageBox.Show("Yakin akan menghapus data tabel id " & txtIdRiwayat.Text &
                               " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete From tbriwayat Where id_riwayat = '" & txtIdRiwayat.Text & "'", CONN)
                CMD.ExecuteNonQuery()

                Call Kosong()
                If MainMenu.StatusID.Text <> 1 Then
                    Call TampilPembelianUser()
                Else
                    Call TampilPembelianAdmin()
                End If
            Else
                Call Kosong()
            End If
        End If
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim tutup As String
        tutup = MessageBox.Show("Yakin Ingin tutup?", "Byeee byeee!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tutup = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub TxtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCari.KeyPress
        If e.KeyChar = Chr(13) Then
            If MainMenu.StatusID.Text <> 1 Then
                CMD = New MySqlCommand("SELECT a.id_riwayat, b.nama, b.no_telp, c.nama_barang, c.satuan, c.harga_jual, a.jumlah_beli, a.total_harga, a.tanggal_pembelian FROM tbriwayat a INNER JOIN tbakun b ON a.id_user = b.id_user INNER JOIN tbsembako c ON a.id_barang = c.id_barang WHERE (a.id_user = '" & MainMenu.StatusID.Text & "'OR c.nama_barang LIKE '%" & TxtCari.Text & "%' OR b.nama LIKE '%" & TxtCari.Text & "%' OR a.tanggal_pembelian LIKE '%" & TxtCari.Text & "%') ORDER BY a.id_riwayat", CONN)
                RD = CMD.ExecuteReader
                RD.Read()

                If RD.HasRows Then
                    RD.Close()
                    DA = New MySqlDataAdapter("SELECT a.id_riwayat, b.nama, b.no_telp, c.nama_barang, c.satuan, c.harga_jual, a.jumlah_beli, a.total_harga, a.tanggal_pembelian FROM tbriwayat a INNER JOIN tbakun b ON a.id_user = b.id_user INNER JOIN tbsembako c ON a.id_barang = c.id_barang WHERE (a.id_user = '" & MainMenu.StatusID.Text & "'OR c.nama_barang LIKE '%" & TxtCari.Text & "%' OR b.nama LIKE '%" & TxtCari.Text & "%' OR a.tanggal_pembelian LIKE '%" & TxtCari.Text & "%') ORDER BY a.id_riwayat", CONN)
                    DS = New DataSet
                    DA.Fill(DS, "Dapat")
                    DataGridView1.DataSource = DS.Tables("Dapat")
                    DataGridView1.ReadOnly = True
                Else
                    RD.Close()
                    MsgBox("Data Tidak ditemukan!")
                End If
                RD.Close()
            Else
                CMD = New MySqlCommand("SELECT a.id_riwayat, a.id_user, b.nama, b.no_telp, a.id_barang, c.nama_barang, c.satuan, c.harga_jual, a.jumlah_beli, a.total_harga, a.tanggal_pembelian FROM tbriwayat a INNER JOIN tbakun b ON a.id_user = b.id_user INNER JOIN tbsembako c ON a.id_barang = c.id_barang WHERE (c.nama_barang LIKE '%" & TxtCari.Text & "%' OR b.nama LIKE '%" & TxtCari.Text & "%' OR a.tanggal_pembelian LIKE '%" & TxtCari.Text & "%') ORDER BY a.id_riwayat", CONN)
                RD = CMD.ExecuteReader
                RD.Read()

                If RD.HasRows Then
                    RD.Close()
                    DA = New MySqlDataAdapter("SELECT a.id_riwayat, a.id_user, b.nama, b.no_telp, a.id_barang, c.nama_barang, c.satuan, c.harga_jual, a.jumlah_beli, a.total_harga, a.tanggal_pembelian FROM tbriwayat a INNER JOIN tbakun b ON a.id_user = b.id_user INNER JOIN tbsembako c ON a.id_barang = c.id_barang WHERE (c.nama_barang LIKE '%" & TxtCari.Text & "%' OR b.nama LIKE '%" & TxtCari.Text & "%' OR a.tanggal_pembelian LIKE '%" & TxtCari.Text & "%') ORDER BY a.id_riwayat", CONN)
                    DS = New DataSet
                    DA.Fill(DS, "Dapat")
                    DataGridView1.DataSource = DS.Tables("Dapat")
                    DataGridView1.ReadOnly = True
                Else
                    RD.Close()
                    MsgBox("Data Tidak ditemukan!")
                End If
                RD.Close()
            End If

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        If MainMenu.StatusID.Text = 1 Then
            With DataGridView1.Rows.Item(i)


                txtIdRiwayat.Text = .Cells(0).Value
                txtIdUser.Text = .Cells(1).Value
                cbkodebarang.Text = .Cells(4).Value
                txtNamaBarang.Text = .Cells(5).Value
                txtHargaBarang.Text = .Cells(7).Value
                txtJumlah.Text = .Cells(8).Value
                txtTotal.Text = .Cells(9).Value

            End With
        End If

    End Sub

    Private Sub cbkodebarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbkodebarang.SelectedIndexChanged
        CMD = New MySqlCommand("Select * From tbsembako where id_barang ='" & cbkodebarang.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows = True Then
            txtNamaBarang.Text = RD.Item(1)
            txtHargaBarang.Text = RD.Item(4)
            txtStok.Text = RD.Item(5)
            If Not txtJumlah.Text = "" Then
                Call hitung()
            End If
        Else
            MsgBox("Kode Barang ini tidak terdaftar")
        End If
        RD.Close()
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If txtIdUser.Text = "" Or txtIdRiwayat.Text = "" Then
            MsgBox("Data ada yang belum di isi!")
            txtIdUser.Focus()
        Else
            Dim Ubah As String = "Update tbriwayat set id_user = '" & txtIdUser.Text & "', 
                                                    id_barang = '" & cbkodebarang.Text & "', 
                                                    jumlah_beli = '" & txtJumlah.Text & "',
                                                    total_harga = '" & txtTotal.Text & "',
                                                    tanggal_pembelian = @datetimevalue
                                      where id_riwayat = '" & txtIdRiwayat.Text & "'"
            CMD = New MySqlCommand(Ubah, CONN)
            CMD.Parameters.AddWithValue("@DateTimeValue", DateTime.Now)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Telah Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If MainMenu.StatusID.Text <> 1 Then
                Call TampilPembelianUser()
            Else
                Call TampilPembelianAdmin()
            End If
            Call Kosong()
            txtIdUser.Focus()
        End If
    End Sub

    Private Sub btnreturn_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) = False Then
                MessageBox.Show("Masukkan Angka!!!", "Error")
                e.Handled = True
            End If

        End If


    End Sub

    Sub hitung()
        If txtHargaBarang.Text = "" Then
        ElseIf txtJumlah.Text = "" Then
            txtTotal.Clear()
        Else
            Dim Hasil As Integer
            Dim HargaBrg As Integer = txtHargaBarang.Text
            Dim JumlahBrg As Integer = txtJumlah.Text
            Hasil = HargaBrg * JumlahBrg
            txtTotal.Text = Hasil
        End If
    End Sub

    Private Sub txtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged
        Call hitung()
    End Sub
End Class