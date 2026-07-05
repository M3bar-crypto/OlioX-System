<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlInvoicePaper = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNextVisit = New System.Windows.Forms.Label()
        Me.picQRCode = New System.Windows.Forms.PictureBox()
        Me.grpServices = New System.Windows.Forms.GroupBox()
        Me.txtServiceInfo = New System.Windows.Forms.TextBox()
        Me.grpCustomer = New System.Windows.Forms.GroupBox()
        Me.txtCustomerInfo = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pdPrintInvoice = New System.Drawing.Printing.PrintDocument()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlInvoicePaper.SuspendLayout()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpServices.SuspendLayout()
        Me.grpCustomer.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlInvoicePaper
        '
        Me.pnlInvoicePaper.BackColor = System.Drawing.Color.Snow
        Me.pnlInvoicePaper.Controls.Add(Me.Label3)
        Me.pnlInvoicePaper.Controls.Add(Me.lblNextVisit)
        Me.pnlInvoicePaper.Controls.Add(Me.picQRCode)
        Me.pnlInvoicePaper.Controls.Add(Me.grpServices)
        Me.pnlInvoicePaper.Controls.Add(Me.grpCustomer)
        Me.pnlInvoicePaper.Controls.Add(Me.RichTextBox1)
        Me.pnlInvoicePaper.Controls.Add(Me.Label2)
        Me.pnlInvoicePaper.Controls.Add(Me.Label1)
        Me.pnlInvoicePaper.Location = New System.Drawing.Point(142, 24)
        Me.pnlInvoicePaper.Name = "pnlInvoicePaper"
        Me.pnlInvoicePaper.Size = New System.Drawing.Size(593, 722)
        Me.pnlInvoicePaper.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 625)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(303, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Address : Al Dahra | Phone :  0920000000"
        '
        'lblNextVisit
        '
        Me.lblNextVisit.AutoSize = True
        Me.lblNextVisit.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextVisit.Location = New System.Drawing.Point(38, 597)
        Me.lblNextVisit.Name = "lblNextVisit"
        Me.lblNextVisit.Size = New System.Drawing.Size(187, 17)
        Me.lblNextVisit.TabIndex = 1
        Me.lblNextVisit.Text = "Date of the next change : "
        '
        'picQRCode
        '
        Me.picQRCode.Location = New System.Drawing.Point(433, 606)
        Me.picQRCode.Name = "picQRCode"
        Me.picQRCode.Size = New System.Drawing.Size(129, 50)
        Me.picQRCode.TabIndex = 2
        Me.picQRCode.TabStop = False
        '
        'grpServices
        '
        Me.grpServices.Controls.Add(Me.txtServiceInfo)
        Me.grpServices.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpServices.Location = New System.Drawing.Point(72, 328)
        Me.grpServices.Name = "grpServices"
        Me.grpServices.Size = New System.Drawing.Size(445, 254)
        Me.grpServices.TabIndex = 3
        Me.grpServices.TabStop = False
        Me.grpServices.Text = "Friction material"
        '
        'txtServiceInfo
        '
        Me.txtServiceInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtServiceInfo.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceInfo.Location = New System.Drawing.Point(40, 46)
        Me.txtServiceInfo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtServiceInfo.Multiline = True
        Me.txtServiceInfo.Name = "txtServiceInfo"
        Me.txtServiceInfo.ReadOnly = True
        Me.txtServiceInfo.Size = New System.Drawing.Size(368, 180)
        Me.txtServiceInfo.TabIndex = 1
        '
        'grpCustomer
        '
        Me.grpCustomer.AutoSize = True
        Me.grpCustomer.Controls.Add(Me.txtCustomerInfo)
        Me.grpCustomer.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCustomer.Location = New System.Drawing.Point(112, 110)
        Me.grpCustomer.Name = "grpCustomer"
        Me.grpCustomer.Size = New System.Drawing.Size(368, 197)
        Me.grpCustomer.TabIndex = 1
        Me.grpCustomer.TabStop = False
        Me.grpCustomer.Text = "Customer Info"
        '
        'txtCustomerInfo
        '
        Me.txtCustomerInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustomerInfo.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerInfo.Location = New System.Drawing.Point(25, 42)
        Me.txtCustomerInfo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCustomerInfo.Multiline = True
        Me.txtCustomerInfo.Name = "txtCustomerInfo"
        Me.txtCustomerInfo.ReadOnly = True
        Me.txtCustomerInfo.Size = New System.Drawing.Size(319, 126)
        Me.txtCustomerInfo.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(32, 58)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(530, 598)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(311, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 46)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Olio"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.PaleGreen
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(763, 630)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(116, 33)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "Save and print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Salmon
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(763, 669)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 33)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Cancel"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'InvoiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(915, 771)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.pnlInvoicePaper)
        Me.Name = "InvoiceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InvoiceForm"
        Me.pnlInvoicePaper.ResumeLayout(False)
        Me.pnlInvoicePaper.PerformLayout()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpServices.ResumeLayout(False)
        Me.grpServices.PerformLayout()
        Me.grpCustomer.ResumeLayout(False)
        Me.grpCustomer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlInvoicePaper As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpServices As System.Windows.Forms.GroupBox
    Friend WithEvents grpCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents txtCustomerInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtServiceInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblNextVisit As System.Windows.Forms.Label
    Friend WithEvents picQRCode As System.Windows.Forms.PictureBox
    Friend WithEvents pdPrintInvoice As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
