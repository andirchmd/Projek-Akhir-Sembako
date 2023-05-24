
Imports MySql.Data.MySqlClient
Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Call koneksi()
        CMD = New MySqlCommand("select * from tbakun where username='" & TxtUser.Text & "' and password='" & TxtPass.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Timer1.Dispose()
            Me.Close()
            MessageBox.Show("Selamat datang " + RD.GetString(3) + "!", "Berhasil Login",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            MainMenu.Show()
            MainMenu.NamaLabel.Text = RD.GetString(1)
            MainMenu.StatusID.Text = RD.GetString(0)
            If RD.GetString(0) <> 1 Then
                MainMenu.PendataanBarangToolStripMenuItem.Enabled = False
                MainMenu.PendataanBarangToolStripMenuItem.Visible = False
            Else
                MainMenu.PendataanBarangToolStripMenuItem.Enabled = True
                MainMenu.PendataanBarangToolStripMenuItem.Visible = True
            End If
            RD.Close()
        ElseIf Not RD.HasRows Then
            RD.Close()
            MessageBox.Show("Periksa Kembali Username dan Password", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtUser.Focus()
            TxtUser.Clear()
            TxtPass.Clear()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        End
    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUser.KeyPress
        If e.KeyChar = Chr(13) Then TxtPass.Focus()
    End Sub
    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPass.KeyPress
        If e.KeyChar = Chr(13) Then BtnLogin.Focus()
    End Sub
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Start()
        TxtUser.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity <= 1.0 Then
            Me.Opacity = Me.Opacity + 0.1
        End If

    End Sub

    Private Sub BtnRegis_Click(sender As Object, e As EventArgs) Handles BtnRegis.Click
        Timer1.Dispose()
        Me.Close()
        FormRegis.Show()
    End Sub
End Class