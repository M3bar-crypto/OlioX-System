Imports System.Net
Imports System.IO
Imports System.Drawing.Printing

Public Class InvoiceForm

    Private Sub InvoiceForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ThemeManager.SetProjectTheme(Me, My.Settings.IsDarkMode)
        ServicePointManager.SecurityProtocol = DirectCast(3072, SecurityProtocolType)

        ApplyInterfaceFormatting()
        PopulateInvoiceDetails()
        GenerateMyQR()
    End Sub

    Private Sub PopulateInvoiceDetails()
        Dim customerBody As String = ""
        customerBody &= "CUSTOMER NAME : " & GlobalData.SelectedCustomerName & vbCrLf
        customerBody &= "PHONE NUMBER  : " & GlobalData.SelectedCustomerPhone & vbCrLf
        customerBody &= "VEHICLE TYPE  : " & GlobalData.SelectedCarType
        txtCustomerInfo.Text = customerBody

        Dim serviceBody As String = ""
        serviceBody &= "SERVICE".PadRight(18) & "PRICE (LYD)" & vbCrLf
        serviceBody &= "--------------------------------" & vbCrLf

        serviceBody &= "OIL: " & GlobalData.SelectedOilType.PadRight(12) & " : " & GlobalData.SelectedOilPrice.ToString("N2") & vbCrLf
        serviceBody &= "FLT: " & GlobalData.SelectedFilterType.PadRight(12) & " : " & GlobalData.SelectedFilterPrice.ToString("N2") & vbCrLf
        serviceBody &= "LABOR".PadRight(18) & " : " & GlobalData.LaborCost.ToString("N2") & vbCrLf
        serviceBody &= "--------------------------------" & vbCrLf
        serviceBody &= "TOTAL".PadRight(18) & " : " & GlobalData.FinalAmount.ToString("N2")

        txtServiceInfo.Text = serviceBody

        Dim nextServiceDate As Date = Date.Now.AddMonths(3)
        lblNextVisit.Text = "NEXT SERVICE DUE: " & nextServiceDate.ToString("yyyy-MM-dd")
    End Sub

    Private Sub ApplyInterfaceFormatting()
        Me.StartPosition = FormStartPosition.CenterScreen

        txtCustomerInfo.Font = New Font("Consolas", 11, FontStyle.Regular)
        txtServiceInfo.Font = New Font("Consolas", 11, FontStyle.Regular)

        txtCustomerInfo.ReadOnly = True
        txtServiceInfo.ReadOnly = True
        txtCustomerInfo.BackColor = Color.White
        txtServiceInfo.BackColor = Color.White
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        GlobalData.DailyCars += 1
        GlobalData.DailySales += GlobalData.FinalAmount

        MainDashboard.lblTodayCars.Text = GlobalData.DailyCars.ToString()
        MainDashboard.lblTodaySales.Text = GlobalData.DailySales.ToString("0.00")

        MainDashboard.grpResourceManagement.Enabled = False
        MainDashboard.lblTotalPrice.Text = "0.00"
        MainDashboard.numLiters.Value = 0

        MessageBox.Show("Transaction completed! The system is ready for the next car.", "Sale Finished", MessageBoxButtons.OK, MessageBoxIcon.Information)

        AddHandler pdPrintInvoice.PrintPage, AddressOf PrintDocumentHandler

        Dim printUI As New PrintDialog()
        printUI.Document = pdPrintInvoice

        If printUI.ShowDialog() = DialogResult.OK Then
            pdPrintInvoice.Print()
        End If
    End Sub

    Private Sub PrintDocumentHandler(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim canvas As New Bitmap(pnlInvoicePaper.Width, pnlInvoicePaper.Height)
        pnlInvoicePaper.DrawToBitmap(canvas, New Rectangle(0, 0, pnlInvoicePaper.Width, pnlInvoicePaper.Height))

        e.Graphics.DrawImage(canvas, 0, 0)
    End Sub

    Private Sub GenerateMyQR()
        Try
            Dim qrData As String = "OlioX Invoice - Customer: " & GlobalData.SelectedCustomerName & " | Total: " & GlobalData.FinalAmount.ToString() & " LYD"
            Dim apiUrl As String = "https://api.qrserver.com/v1/create-qr-code/?size=150x150&data=" & Uri.EscapeDataString(qrData)

            Dim client As New WebClient()
            Dim imageBytes As Byte() = client.DownloadData(apiUrl)
            Dim ms As New MemoryStream(imageBytes)

            picQRCode.Image = Image.FromStream(ms)
            picQRCode.SizeMode = PictureBoxSizeMode.Zoom
            picQRCode.BringToFront()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class