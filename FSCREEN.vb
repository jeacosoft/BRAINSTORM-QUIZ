Public Class FSCREEN
    Dim flash As Integer = 50
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If flash = 600 Then
            Timer1.Stop()

            Me.Hide()
            Form1.Show()
        Else
            flash += 5

        End If
    End Sub

    Private Sub FSCREEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class