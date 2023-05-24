Public Class InitialLoad
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressTxt.Text = PB1.Value & "%"

        PB1.Value += 1

        If PB1.Value > 50 Then
            LoadingTxt.Text = "Memuat komponen..."
        End If

        If PB1.Value > 75 Then
            LoadingTxt.Text = "Dikit Lagi..."
        End If

        If PB1.Value > 95 Then
            LoadingTxt.Text = "Program akan dimulai..."

        End If

        If PB1.Value = 100 Then
            Me.Hide()
            FormLogin.Show()
            Timer1.Dispose()
        End If
    End Sub


End Class