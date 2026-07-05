Public Class SettingsForm

    Private Sub SettingsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ThemeManager.SetProjectTheme(Me, My.Settings.IsDarkMode)

        Try
            SetProjectTheme(Me, My.Settings.IsDarkMode)
            chkDarkMode.Checked = My.Settings.IsDarkMode

            txtCenterName.Text = My.Settings.CenterName
            txtPhone.Text = My.Settings.CenterPhone
            txtAddress.Text = My.Settings.CenterAddress

            txtUsername.Text = My.Settings.SavedUser
            txtPassword.Text = My.Settings.SavedPass

            txtLaborCost.Text = "15"

            txtPassword.UseSystemPasswordChar = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnBrowsePath_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBrowsePath.Click
        Try
            Dim fbd As New FolderBrowserDialog()
            fbd.Description = "Select the folder designated for backup. "

            If fbd.ShowDialog() = DialogResult.OK Then
                txtBackupPath.Text = fbd.SelectedPath
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while selecting the route. " & ex.Message)
        End Try
    End Sub

    Private Sub btnSaveSettings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaveSettings.Click
        Try
            My.Settings.IsDarkMode = chkDarkMode.Checked
            My.Settings.CenterName = txtCenterName.Text
            My.Settings.CenterPhone = txtPhone.Text
            My.Settings.CenterAddress = txtAddress.Text
            My.Settings.SavedUser = txtUsername.Text
            My.Settings.SavedPass = txtPassword.Text
            My.Settings.Save()

            GlobalData.CurrentLoggedIn = txtUsername.Text

            Dim mainForm = Application.OpenForms("MainDashboard")
            If mainForm IsNot Nothing Then
                CType(mainForm, MainDashboard).lblUserStatus.Text = "User: " & txtUsername.Text
            End If

            SetProjectTheme(Me, My.Settings.IsDarkMode)
            If mainForm IsNot Nothing Then
                SetProjectTheme(CType(mainForm, MainDashboard), My.Settings.IsDarkMode)
            End If

            If chkDarkMode.Checked Then
                MainDashboard.BackColor = Color.FromArgb(45, 45, 48)
            Else
                MainDashboard.BackColor = Color.FromKnownColor(KnownColor.Control)
            End If

            MessageBox.Show("All changes were successfully saved.", "Olio X Settings", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Settings could not be saved. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class