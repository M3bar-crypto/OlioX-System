Public Class LogInForm

    Dim attempts As Integer = 0

    Private Sub LogInForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click

        If txtUser.Text = My.Settings.SavedUser And txtPass.Text = My.Settings.SavedPass Then
            MsgBox("Access Granted! Welcome back.", MsgBoxStyle.Information, "Olio X")


            My.Settings.CurrentLoggedIn = txtUser.Text
            My.Settings.Save()

            MainDashboard.Show()
            Me.Close()
        Else
            attempts += 1
            Dim remaining As Integer = 3 - attempts

            If attempts >= 3 Then
                MsgBox("Too many failed attempts. System Locking!", MsgBoxStyle.Critical, "Security")
                End
            Else
                MsgBox("Invalid Credentials! Remaining attempts: " & remaining, MsgBoxStyle.Exclamation, "Access Denied")
            End If
        End If
    End Sub


    Private Sub chkShow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub


    Private Sub btnLogin_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.MouseEnter
        btnLogin.BackColor = Color.LimeGreen
    End Sub

    Private Sub btnLogin_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.BackColor = Color.DimGray

    End Sub



    Private Sub btnExit_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.MouseEnter
        btnCancel.BackColor = Color.Red
    End Sub


    Private Sub btnCancel_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.MouseLeave
        btnCancel.BackColor = Color.DimGray
    End Sub

End Class