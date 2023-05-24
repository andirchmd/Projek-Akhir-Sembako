Imports MySql.Data.MySqlClient
Public Class FormRegis
    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUser.KeyPress
        If e.KeyChar = Chr(13) Then TxtPass.Focus()
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPass.KeyPress
        If e.KeyChar = Chr(13) Then txtNama.Focus()
    End Sub
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If e.KeyChar = Chr(13) Then txtNomorTlp.Focus()
    End Sub
    Private Sub txtNomorTlp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomorTlp.KeyPress
        If e.KeyChar = Chr(13) Then BtnRegis.Focus()
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) = False Then
                MessageBox.Show("Masukkan Angka!!!", "Error")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        Me.Close()
        FormLogin.Show()
    End Sub

    Private Sub BtnRegis_Click(sender As Object, e As EventArgs) Handles BtnRegis.Click
        Call koneksi()
        If TxtUser.Text = "" Or TxtPass.Text = "" Or txtNama.Text = "" Or txtNomorTlp.Text = "" Then
            MsgBox("Data Belum Lengkap")
            TxtUser.Focus()
            Exit Sub
        Else
            CMD = New MySqlCommand("Select * from tbakun where username ='" & TxtUser.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                Dim Simpan As String = "insert into tbakun (username,password,nama,no_telp) values ('" & TxtUser.Text & "','" & TxtPass.Text & "','" & txtNama.Text & "','" & txtNomorTlp.Text & "')"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Registrasi Berhasil!", MsgBoxStyle.Information, "Perhatian")
                Me.Close()
                FormLogin.Show()
            Else
                RD.Close()
                MsgBox("Data terduplikat!", MsgBoxStyle.Information, "Perhatian")
            End If
            TxtUser.Focus()
        End If
    End Sub
End Class