Imports MySql.Data.MySqlClient

Public Class Pendataan
    Sub Kosong()
        txtKodeBarang.Clear()
        txtNamaBarang.Clear()
        txtSatuan.Clear()
        txtHargaBeliBarang.Clear()
        txtHargaJualBarang.Clear()
        txtStok.Clear()
        txtKodeBarang.Focus()
    End Sub
    Sub Isi()
        txtNamaBarang.Clear()
        txtSatuan.Clear()
        txtHargaBeliBarang.Clear()
        txtHargaJualBarang.Clear()
        txtStok.Clear()
        txtNamaBarang.Focus()
        txtSatuan.Focus()
        txtHargaBeliBarang.Focus()
        txtHargaJualBarang.Focus()
        txtStok.Focus()
    End Sub
    Sub TampilBarang()
        DA = New MySqlDataAdapter("select * from tbsembako", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "sembako")
        DataGridView1.DataSource = DS.Tables("sembako")
        DataGridView1.Refresh()
    End Sub
    Sub AturGrid()
        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).Width = 120
        DataGridView1.Columns(2).Width = 120
        DataGridView1.Columns(3).Width = 150
        DataGridView1.Columns(4).Width = 150
        DataGridView1.Columns(5).Width = 150


        DataGridView1.Columns(0).HeaderText = "ID BARANG"
        DataGridView1.Columns(1).HeaderText = "NAMA BARANG"
        DataGridView1.Columns(2).HeaderText = "SATUAN"
        DataGridView1.Columns(3).HeaderText = "HARGA BELI"
        DataGridView1.Columns(4).HeaderText = "HARGA JUAL"
        DataGridView1.Columns(5).HeaderText = "STOK"

    End Sub
    Private Sub Pendataan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call TampilBarang()
        Call Kosong()
        Call AturGrid()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKodeBarang.Text = "" Or txtNamaBarang.Text = "" Or txtSatuan.Text = "" Or txtHargaBeliBarang.Text = "" Or txtHargaJualBarang.Text = "" Or txtStok.Text = "" Then
            MsgBox("Data Belum Lengkap")
            txtKodeBarang.Focus()
            Exit Sub
        Else
            CMD = New MySqlCommand("Select * from tbsembako where id_barang ='" & txtKodeBarang.Text & "'OR nama_barang = '" & txtNamaBarang.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                Dim Simpan As String = "insert into tbsembako(id_barang,nama_barang,satuan,harga_beli,harga_jual,stok) values ('" & txtKodeBarang.Text & "','" & txtNamaBarang.Text & "','" & txtSatuan.Text & "','" & txtHargaBeliBarang.Text & "','" & txtHargaJualBarang.Text & "','" & txtStok.Text & "')"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Simpan data sukses!", MsgBoxStyle.Information, "Perhatian")
            Else
                RD.Close()
                MsgBox("Data terduplikat!", MsgBoxStyle.Information, "Perhatian")
            End If
            Call TampilBarang()
            Call Kosong()
            txtKodeBarang.Focus()
        End If
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodeBarang.Text = "" Then
            MsgBox("Masukkan data yang ingin dihapus!")
            txtKodeBarang.Focus()
        Else
            If MessageBox.Show("Yakin akan menghapus Kode Barang " & txtKodeBarang.Text &
                               " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete From tbsembako Where id_barang = '" & txtKodeBarang.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                Call Kosong()
                Call TampilBarang()

            Else
                Call Kosong()
            End If
        End If
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim close As String
        close = MessageBox.Show("Apakah anda yakin ingin keluar?", "Mau Kemana Atuh :{",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If close = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("SELECT * from tbsembako where (id_barang Like '%" & txtCari.Text & "%' OR nama_barang LIKE '%" & txtCari.Text & "%' OR satuan LIKE '%" & txtCari.Text & "%' OR harga_beli LIKE '%" & txtCari.Text & "%' OR harga_jual LIKE '%" & txtCari.Text & "%' OR stok LIKE '%" & txtCari.Text & "%')", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("SELECT * from tbsembako where (id_barang Like '%" & txtCari.Text & "%' OR nama_barang LIKE '%" & txtCari.Text & "%' OR satuan LIKE '%" & txtCari.Text & "%' OR harga_beli LIKE '%" & txtCari.Text & "%' OR harga_jual LIKE '%" & txtCari.Text & "%' OR stok LIKE '%" & txtCari.Text & "%')", CONN)
                DS = New DataSet
                DA.Fill(DS, "Dapat")
                DataGridView1.DataSource = DS.Tables("Dapat")
                DataGridView1.ReadOnly = True
            Else
                RD.Close()
                MsgBox("Data tidak ditemukan")
            End If
        End If
        'If e.KeyChar = Chr(13) Then
        '    CMD = New MySqlCommand("Select * From tbsembako where namabarang like '%" & txtCari.Text & "%'", CONN)
        '    RD = CMD.ExecuteReader
        '    RD.Read()

        '    If RD.HasRows Then

        '        DA = New MySqlDataAdapter("Select * From tbsembako where namabarang like '%" & txtCari.Text & "%'", CONN)
        '        DS = New DataSet
        '        RD.Close()
        '        DA.Fill(DS, "Dapat")
        '        DataGridView1.DataSource = DS.Tables("Dapat")
        '        DataGridView1.ReadOnly = True

        '    Else
        '        RD.Close()
        '        MsgBox("Upss.. Data Tidak ditemukan!")
        '    End If
        'End If
    End Sub
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click

        If txtKodeBarang.Text = "" Or txtNamaBarang.Text = "" Or txtSatuan.Text = "" Or txtHargaBeliBarang.Text = "" Or txtHargaJualBarang.Text = "" Or txtStok.Text = "" Then
            MsgBox("Data belum lengkap")
            txtKodeBarang.Focus()
        Else
            Call koneksi()
            Dim Ubah As String = "Update tbsembako set nama_barang ='" & txtNamaBarang.Text & "', satuan ='" & txtSatuan.Text & "', 
                               harga_beli ='" & txtHargaBeliBarang.Text & "', harga_jual ='" & txtHargaJualBarang.Text & "', stok ='" & txtStok.Text & "' where id_barang = '" & txtKodeBarang.Text & "'"
            CMD = New MySqlCommand(Ubah, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call TampilBarang()
            Call Kosong()
            txtKodeBarang.Focus()
        End If
    End Sub



    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)
            txtKodeBarang.Text = .Cells(0).Value
            txtNamaBarang.Text = .Cells(1).Value
            txtSatuan.Text = .Cells(2).Value
            txtHargaBeliBarang.Text = .Cells(3).Value
            txtHargaJualBarang.Text = .Cells(4).Value
            txtStok.Text = .Cells(5).Value
        End With
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call Kosong()
    End Sub

    Private Sub txtKodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeBarang.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) = False Then
                MessageBox.Show("Masukkan Angka!!!", "Error")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtHargaBeliBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaBeliBarang.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) = False Then
                MessageBox.Show("Masukkan Angka!!!", "Error")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtHargaJualBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaJualBarang.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) = False Then
                MessageBox.Show("Masukkan Angka!!!", "Error")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) = False Then
                MessageBox.Show("Masukkan Angka!!!", "Error")
                e.Handled = True
            End If
        End If
    End Sub
End Class

