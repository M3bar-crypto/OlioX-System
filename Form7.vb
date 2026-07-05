Imports System.IO

Public Class InventoryForm

    Private Sub InventoryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ThemeManager.SetProjectTheme(Me, My.Settings.IsDarkMode)

        SetupDataGrids()

        LoadDataFromFile(dgvOils, "oils.txt")
        LoadDataFromFile(dgvFilters, "filters.txt")

        CheckInventoryAlerts()
    End Sub

    Private Sub SetupDataGrids()
        dgvOils.ColumnCount = 4
        dgvOils.Columns(0).Name = "Name"
        dgvOils.Columns(1).Name = "Viscosity"
        dgvOils.Columns(2).Name = "Quantity (Liters)"
        dgvOils.Columns(3).Name = "Price"
        dgvOils.AllowUserToAddRows = False
        dgvOils.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        dgvFilters.ColumnCount = 4
        dgvFilters.Columns(0).Name = "Name"
        dgvFilters.Columns(1).Name = "Type"
        dgvFilters.Columns(2).Name = "Quantity"
        dgvFilters.Columns(3).Name = "Price"
        dgvFilters.AllowUserToAddRows = False
        dgvFilters.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub LoadDataFromFile(ByVal dgv As DataGridView, ByVal fileName As String)
        dgv.Rows.Clear()
        Dim filePath As String = Path.Combine(Application.StartupPath, fileName)

        If Not File.Exists(filePath) Then
            CreateDefaultData(fileName, filePath)
        End If

        If File.Exists(filePath) Then
            Dim lines = File.ReadAllLines(filePath)
            For Each line In lines
                If line.Trim() <> "" Then
                    dgv.Rows.Add(line.Split("|"c))
                End If
            Next
        End If
    End Sub

    Private Sub CreateDefaultData(ByVal fileName As String, ByVal filePath As String)
        Dim defaultLines As New List(Of String)()

        If fileName = "oils.txt" Then
            defaultLines.Add("Toyota Genuine|5W-30|150|45.00")
            defaultLines.Add("Castrol Magnatec|10W-40|85|35.00")
            defaultLines.Add("Shell Helix Ultra|5W-40|110|55.00")
            defaultLines.Add("Liqui Moly Special Tec|5W-30|65|65.00")
            defaultLines.Add("Total Quartz|10W-40|90|32.00")
            defaultLines.Add("Eni i-Sint|20W-50|40|25.00")
        ElseIf fileName = "filters.txt" Then
            defaultLines.Add("Toyota Small Filter|Genuine|35|25.00")
            defaultLines.Add("Hyundai/Kia Filter|Genuine|50|20.00")
            defaultLines.Add("Nissan Commercial|Commercial|18|15.00")
            defaultLines.Add("German Cars Filter|Genuine|8|60.00")
        End If

        File.WriteAllLines(filePath, defaultLines.ToArray())
    End Sub

    Private Sub SaveDataToFile(ByVal dgv As DataGridView, ByVal fileName As String)
        Dim filePath As String = Path.Combine(Application.StartupPath, fileName)
        Dim lines As New List(Of String)

        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow Then
                Dim line As String = row.Cells(0).Value.ToString() & "|" &
                                     row.Cells(1).Value.ToString() & "|" &
                                     row.Cells(2).Value.ToString() & "|" &
                                     row.Cells(3).Value.ToString()
                lines.Add(line)
            End If
        Next
        File.WriteAllLines(filePath, lines.ToArray())

        CheckInventoryAlerts()
    End Sub

    Private Sub btnAddOil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddOil.Click
        If txtOilName.Text = "" Or txtOilPrice.Text = "" Then
            MessageBox.Show("Please fill all fields first!", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        dgvOils.Rows.Add(txtOilName.Text, cmbOilViscosity.Text, numOilQty.Value.ToString(), txtOilPrice.Text)
        SaveDataToFile(dgvOils, "oils.txt")
        ClearOilInputs()
    End Sub

    Private Sub btnEditOil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditOil.Click
        If dgvOils.SelectedRows.Count > 0 Then
            Dim row = dgvOils.SelectedRows(0)
            row.Cells(0).Value = txtOilName.Text
            row.Cells(1).Value = cmbOilViscosity.Text
            row.Cells(2).Value = numOilQty.Value.ToString()
            row.Cells(3).Value = txtOilPrice.Text

            SaveDataToFile(dgvOils, "oils.txt")
            ClearOilInputs()
            MessageBox.Show("Oil record updated successfully!", "Update Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDeleteOil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteOil.Click
        If dgvOils.SelectedRows.Count > 0 Then
            dgvOils.Rows.Remove(dgvOils.SelectedRows(0))
            SaveDataToFile(dgvOils, "oils.txt")
            ClearOilInputs()
        End If
    End Sub

    Private Sub dgvOils_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOils.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvOils.Rows(e.RowIndex)
            txtOilName.Text = row.Cells(0).Value.ToString()
            cmbOilViscosity.Text = row.Cells(1).Value.ToString()
            numOilQty.Value = CDec(row.Cells(2).Value)
            txtOilPrice.Text = row.Cells(3).Value.ToString()
        End If
    End Sub

    Private Sub ClearOilInputs()
        txtOilName.Clear()
        cmbOilViscosity.SelectedIndex = -1
        numOilQty.Value = 0
        txtOilPrice.Clear()
    End Sub

    Private Sub CheckInventoryAlerts()
        Dim totalOils As Integer = 0
        For Each row As DataGridViewRow In dgvOils.Rows
            If Not row.IsNewRow Then totalOils += CInt(row.Cells(2).Value)
        Next

        Dim totalFilters As Integer = 0
        For Each row As DataGridViewRow In dgvFilters.Rows
            If Not row.IsNewRow Then totalFilters += CInt(row.Cells(2).Value)
        Next

        If totalOils <= 20 AndAlso totalOils > 0 Then
            MessageBox.Show("Critical Alert: Total oil quantity in inventory has dropped to " & totalOils & " liters!", "Low Oil Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If totalFilters <= 10 AndAlso totalFilters > 0 Then
            MessageBox.Show("Critical Alert: Total filters in inventory have dropped to " & totalFilters & " units!", "Low Filter Inventory", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnAddFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFilter.Click
        If txtFilterName.Text = "" Or txtFilterPrice.Text = "" Then
            MessageBox.Show("Please fill all fields first!", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        dgvFilters.Rows.Add(txtFilterName.Text, cmbFilterCategory.Text, numFilterQty.Value.ToString(), txtFilterPrice.Text)
        SaveDataToFile(dgvFilters, "filters.txt")
    End Sub

    Private Sub btnEditFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditFilter.Click
        If dgvFilters.SelectedRows.Count > 0 Then
            Dim row = dgvFilters.SelectedRows(0)
            row.Cells(0).Value = txtFilterName.Text
            row.Cells(1).Value = cmbFilterCategory.Text
            row.Cells(2).Value = numFilterQty.Value.ToString()
            row.Cells(3).Value = txtFilterPrice.Text
            SaveDataToFile(dgvFilters, "filters.txt")
            MessageBox.Show("Filter record updated successfully!", "Update Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDeleteFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteFilter.Click
        If dgvFilters.SelectedRows.Count > 0 Then
            dgvFilters.Rows.Remove(dgvFilters.SelectedRows(0))
            SaveDataToFile(dgvFilters, "filters.txt")
        End If
    End Sub

    Private Sub dgvFilters_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFilters.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvFilters.Rows(e.RowIndex)
            txtFilterName.Text = row.Cells(0).Value.ToString()
            cmbFilterCategory.Text = row.Cells(1).Value.ToString()
            numFilterQty.Value = CDec(row.Cells(2).Value)
            txtFilterPrice.Text = row.Cells(3).Value.ToString()
        End If
    End Sub
End Class