Public Class SplashForm


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        If ProgressBar1.Value + 2 <= 100 Then
            ProgressBar1.Value += 2
        Else
            ProgressBar1.Value = 100
        End If

        If ProgressBar1.Value < 30 Then
            lblstatus.Text = "Loading resources ..."
        ElseIf ProgressBar1.Value < 70 Then
            lblstatus.Text = "Connecting to OlioX database ..."
        ElseIf ProgressBar1.Value < 100 Then
            lblstatus.Text = "Finalizing setup ..."
        End If

        If ProgressBar1.Value >= 100 Then

            Timer1.Stop()


            LogInForm.Show()
            Me.Hide()

        End If
    End Sub
End Class
