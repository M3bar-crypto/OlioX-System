<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCustomerForm
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
        Me.components = New System.ComponentModel.Container()
        Me.grpCustInfo = New System.Windows.Forms.GroupBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtCustName = New System.Windows.Forms.MaskedTextBox()
        Me.mtbPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtPlateNum = New System.Windows.Forms.MaskedTextBox()
        Me.txtCarType = New System.Windows.Forms.MaskedTextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.errValidation = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnSaveAndInvoice = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.grpCustInfo.SuspendLayout()
        CType(Me.errValidation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCustInfo
        '
        Me.grpCustInfo.BackColor = System.Drawing.Color.Snow
        Me.grpCustInfo.Controls.Add(Me.dtpDate)
        Me.grpCustInfo.Controls.Add(Me.txtCustName)
        Me.grpCustInfo.Controls.Add(Me.mtbPhone)
        Me.grpCustInfo.Controls.Add(Me.txtPlateNum)
        Me.grpCustInfo.Controls.Add(Me.txtCarType)
        Me.grpCustInfo.Controls.Add(Me.lblTitle)
        Me.grpCustInfo.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCustInfo.Location = New System.Drawing.Point(113, 23)
        Me.grpCustInfo.Name = "grpCustInfo"
        Me.grpCustInfo.Size = New System.Drawing.Size(653, 415)
        Me.grpCustInfo.TabIndex = 0
        Me.grpCustInfo.TabStop = False
        Me.grpCustInfo.Text = "Customer Info"
        '
        'dtpDate
        '
        Me.dtpDate.CalendarMonthBackground = System.Drawing.Color.LightGray
        Me.dtpDate.CalendarTitleBackColor = System.Drawing.Color.LightGray
        Me.dtpDate.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.dtpDate.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dtpDate.Location = New System.Drawing.Point(230, 336)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 23)
        Me.dtpDate.TabIndex = 5
        '
        'txtCustName
        '
        Me.txtCustName.BackColor = System.Drawing.SystemColors.Info
        Me.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustName.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustName.Location = New System.Drawing.Point(200, 101)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(273, 28)
        Me.txtCustName.TabIndex = 9
        '
        'mtbPhone
        '
        Me.mtbPhone.BackColor = System.Drawing.SystemColors.Info
        Me.mtbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbPhone.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbPhone.Location = New System.Drawing.Point(201, 156)
        Me.mtbPhone.Name = "mtbPhone"
        Me.mtbPhone.Size = New System.Drawing.Size(272, 28)
        Me.mtbPhone.TabIndex = 8
        '
        'txtPlateNum
        '
        Me.txtPlateNum.BackColor = System.Drawing.SystemColors.Info
        Me.txtPlateNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPlateNum.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlateNum.Location = New System.Drawing.Point(200, 275)
        Me.txtPlateNum.Name = "txtPlateNum"
        Me.txtPlateNum.Size = New System.Drawing.Size(273, 28)
        Me.txtPlateNum.TabIndex = 7
        '
        'txtCarType
        '
        Me.txtCarType.BackColor = System.Drawing.SystemColors.Info
        Me.txtCarType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCarType.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarType.Location = New System.Drawing.Point(200, 214)
        Me.txtCarType.Name = "txtCarType"
        Me.txtCarType.Size = New System.Drawing.Size(273, 28)
        Me.txtCarType.TabIndex = 6
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(181, 32)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(325, 34)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Add a new Customer :"
        '
        'errValidation
        '
        Me.errValidation.ContainerControl = Me
        '
        'btnSaveAndInvoice
        '
        Me.btnSaveAndInvoice.BackColor = System.Drawing.Color.Lime
        Me.btnSaveAndInvoice.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAndInvoice.Location = New System.Drawing.Point(544, 444)
        Me.btnSaveAndInvoice.Name = "btnSaveAndInvoice"
        Me.btnSaveAndInvoice.Size = New System.Drawing.Size(75, 32)
        Me.btnSaveAndInvoice.TabIndex = 6
        Me.btnSaveAndInvoice.Text = "Save"
        Me.btnSaveAndInvoice.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Orange
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(271, 444)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 32)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.OrangeRed
        Me.btnBack.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(838, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(38, 32)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "x"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'AddCustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(888, 488)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSaveAndInvoice)
        Me.Controls.Add(Me.grpCustInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddCustomerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddCustomerForm"
        Me.grpCustInfo.ResumeLayout(False)
        Me.grpCustInfo.PerformLayout()
        CType(Me.errValidation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpCustInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents errValidation As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSaveAndInvoice As System.Windows.Forms.Button
    Friend WithEvents txtCustName As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPlateNum As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCarType As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker

End Class