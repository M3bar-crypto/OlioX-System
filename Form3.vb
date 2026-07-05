Imports System.IO

Public Class MainDashboard

    Private Sub LoadInventoryToComboBoxes()
        cmbOilType.Items.Clear()
        cmbFilterType.Items.Clear()

        Dim oilsFile As String = Application.StartupPath & "\oils.txt"
        If File.Exists(oilsFile) Then
            Dim lines = File.ReadAllLines(oilsFile)
            For Each line In lines
                Dim data = line.Split("|"c)
                If data.Length >= 4 Then
                    Dim displayName As String = data(0) & " " & data(1)
                    cmbOilType.Items.Add(displayName)
                End If
            Next
        End If

        Dim filtersFile As String = Application.StartupPath & "\filters.txt"
        If File.Exists(filtersFile) Then
            Dim lines = File.ReadAllLines(filtersFile)
            For Each line In lines
                Dim data = line.Split("|"c)
                If data.Length >= 4 Then
                    cmbFilterType.Items.Add(data(0))
                End If
            Next
        End If
    End Sub

    Private Sub MainDashboard_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ThemeManager.SetProjectTheme(Me, My.Settings.IsDarkMode)
        grpResourceManagement.Enabled = False
        lblTotalPrice.Text = "0.00"

        lblTodayCars.Text = "0"
        lblTodaySales.Text = "0.00"

        tmrClock.Interval = 1000
        tmrClock.Enabled = True
        lblTimeStatus.Text = DateTime.Now.ToString("dd/MM/yyyy  -  hh:mm:ss tt")

        LoadInventoryToComboBoxes()

        lblUserStatus.Text = "User: " & My.Settings.CurrentLoggedIn

        ' تمت إزالة الـ AddHandler المكررين من هنا لمنع تكرار فتح الواجهات
        AddHandler cmbOilType.SelectedIndexChanged, AddressOf UpdateUI_Changed
        AddHandler cmbFilterType.SelectedIndexChanged, AddressOf UpdateUI_Changed
        AddHandler numLiters.ValueChanged, AddressOf UpdateUI_Changed
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrClock.Tick
        lblTimeStatus.Text = DateTime.Now.ToString("dd/MM/yyyy  -  hh:mm:ss tt")
    End Sub

    Private Sub CalculateTotal()
        Dim oilPricePerLiter As Decimal = 0
        Dim filterPrice As Decimal = 0

        Dim oilsFile As String = Application.StartupPath & "\oils.txt"
        If File.Exists(oilsFile) AndAlso cmbOilType.SelectedIndex <> -1 Then
            Dim lines = File.ReadAllLines(oilsFile)
            For Each line In lines
                Dim data = line.Split("|"c)
                If data.Length >= 4 Then
                    Dim displayName As String = data(0) & " " & data(1)
                    If displayName = cmbOilType.Text Then
                        oilPricePerLiter = CDec(data(3))
                        Exit For
                    End If
                End If
            Next
        End If

        Dim filtersFile As String = Application.StartupPath & "\filters.txt"
        If File.Exists(filtersFile) AndAlso cmbFilterType.SelectedIndex <> -1 Then
            Dim lines = File.ReadAllLines(filtersFile)
            For Each line In lines
                Dim data = line.Split("|"c)
                If data.Length >= 4 Then
                    If data(0) = cmbFilterType.Text Then
                        filterPrice = CDec(data(3))
                        Exit For
                    End If
                End If
            Next
        End If

        Dim totalOilPrice As Decimal = (oilPricePerLiter * numLiters.Value)
        Dim finalTotal As Decimal = totalOilPrice + filterPrice + GlobalData.LaborCost

        lblTotalPrice.Text = finalTotal.ToString("0.00")

        GlobalData.SelectedOilPrice = totalOilPrice
        GlobalData.SelectedFilterPrice = filterPrice
        GlobalData.FinalAmount = finalTotal
    End Sub

    Private Sub UpdateUI_Changed(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cmbFilterType.SelectedIndexChanged, numLiters.ValueChanged, cmbOilType.SelectedIndexChanged
        CalculateTotal()
    End Sub

    Private Sub menuSettings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuSettings.Click
        SettingsForm.ShowDialog()
    End Sub

    Private Sub menuLogOut_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuLogOut.Click
        Dim response = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = DialogResult.Yes Then
            Me.Close()
            Application.Restart()
        End If
    End Sub

    Private Sub menuInventory_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuInventory.Click
        InventoryForm.ShowDialog()
        LoadInventoryToComboBoxes()
        CalculateTotal()
    End Sub

    Private Sub menuReports_Click(ByVal sender As Object, ByVal e As EventArgs)
        MessageBox.Show("Generating Reports...", "Reports")
    End Sub

    Private Sub btnAddCustomer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCustomer.Click
        AddCustomerForm.ShowDialog()
        grpResourceManagement.Enabled = True
        MessageBox.Show("Customer registered successfully. Resource Management is now active.", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnBillPayment_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBillPayment.Click
        If lblTotalPrice.Text = "0.00" Or grpResourceManagement.Enabled = False Then
            MessageBox.Show("Please add a customer and select services first!", "Action Required")
            Return
        End If

        GlobalData.SelectedOilType = cmbOilType.Text
        GlobalData.SelectedFilterType = cmbFilterType.Text

        InvoiceForm.Show()
    End Sub
End Class