Imports System.Runtime.InteropServices

Public Class AddCustomerForm

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As String) As Int32
    End Function
    Private Const EM_SETCUEBANNER As Integer = &H1501

    Private Sub SetPlaceholder(ByVal textBox As Control, ByVal text As String)
        SendMessage(textBox.Handle, EM_SETCUEBANNER, 1, text)
    End Sub

    Private Sub AddCustomerForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ThemeManager.SetProjectTheme(Me, My.Settings.IsDarkMode)
        Me.StartPosition = FormStartPosition.CenterScreen

        SetPlaceholder(txtCustName, "Customer name ...")
        SetPlaceholder(mtbPhone, "09X-XXXXXXX ...")
        SetPlaceholder(txtCarType, "Car type , for EX : Toyota ...")
        SetPlaceholder(txtPlateNum, "Plate number")

        txtCustName.Focus()

        If My.Settings.IsDarkMode = True Then
            Me.BackColor = Color.FromArgb(45, 45, 48)
            grpCustInfo.ForeColor = Color.White
            lblTitle.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Fields_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtCustName.KeyDown, mtbPhone.KeyDown, txtCarType.KeyDown, txtPlateNum.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.SelectNextControl(DirectCast(sender, Control), True, True, True, True)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaveAndInvoice.Click
        If String.IsNullOrWhiteSpace(txtCustName.Text) Then
            errValidation.SetError(txtCustName, "Please enter the Customer name !")
            txtCustName.Focus()
            Exit Sub
        Else
            errValidation.Clear()
        End If

        GlobalData.SelectedCustomerName = txtCustName.Text
        GlobalData.SelectedCustomerPhone = mtbPhone.Text
        GlobalData.SelectedCarType = txtCarType.Text

        MessageBox.Show("Customer data stored. Please complete service details on the Main Dashboard.", "Olio X", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        txtCustName.Clear()
        mtbPhone.Clear()
        txtCarType.Clear()
        txtPlateNum.Clear()
        errValidation.Clear()
        txtCustName.Focus()
    End Sub

    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class