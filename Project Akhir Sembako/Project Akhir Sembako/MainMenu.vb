Public Class MainMenu
    Private Sub PendataanBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PendataanBarangToolStripMenuItem.Click
        Pendataan.Show()
    End Sub

    Private Sub PembelianBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianBarangToolStripMenuItem.Click
        Pembelian.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim close As String
        close = MessageBox.Show("Apakah anda yakin ingin keluar?", "Mau Kemana Atuh :{",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If close = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
    Private Sub GantiUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GantiUserToolStripMenuItem.Click
        Me.Close()
        FormLogin.Show()
    End Sub


End Class
