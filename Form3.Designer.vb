<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainDashboard
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
        Me.lblOlio = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.menuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblUserStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTimeStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grpResourceManagement = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbFilterType = New System.Windows.Forms.ComboBox()
        Me.numLiters = New System.Windows.Forms.NumericUpDown()
        Me.cmbOilType = New System.Windows.Forms.ComboBox()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblTodayCars = New System.Windows.Forms.Panel()
        Me.lblCarsCount = New System.Windows.Forms.Label()
        Me.lblCarsTitle = New System.Windows.Forms.Label()
        Me.lblTodaySales = New System.Windows.Forms.Panel()
        Me.lblSalesTotal = New System.Windows.Forms.Label()
        Me.LalblSaletle = New System.Windows.Forms.Label()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.btnBilling = New System.Windows.Forms.Button()
        Me.btnBillPayment = New System.Windows.Forms.Button()
        Me.mnuMain.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.grpResourceManagement.SuspendLayout()
        CType(Me.numLiters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lblTodayCars.SuspendLayout()
        Me.lblTodaySales.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblOlio
        '
        Me.lblOlio.AutoSize = True
        Me.lblOlio.BackColor = System.Drawing.Color.Transparent
        Me.lblOlio.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOlio.Location = New System.Drawing.Point(114, 124)
        Me.lblOlio.Name = "lblOlio"
        Me.lblOlio.Size = New System.Drawing.Size(201, 97)
        Me.lblOlio.TabIndex = 0
        Me.lblOlio.Text = "Olio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(300, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 97)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "X"
        '
        'mnuMain
        '
        Me.mnuMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFile, Me.menuInventory})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(1000, 33)
        Me.mnuMain.TabIndex = 2
        Me.mnuMain.Text = "MenuStrip1"
        '
        'menuFile
        '
        Me.menuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuSettings, Me.menuLogOut})
        Me.menuFile.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Size = New System.Drawing.Size(56, 29)
        Me.menuFile.Text = "File"
        '
        'menuSettings
        '
        Me.menuSettings.Name = "menuSettings"
        Me.menuSettings.Size = New System.Drawing.Size(154, 30)
        Me.menuSettings.Text = "Settings"
        '
        'menuLogOut
        '
        Me.menuLogOut.Name = "menuLogOut"
        Me.menuLogOut.Size = New System.Drawing.Size(154, 30)
        Me.menuLogOut.Text = "Log out"
        '
        'menuInventory
        '
        Me.menuInventory.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuInventory.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.menuInventory.Name = "menuInventory"
        Me.menuInventory.Size = New System.Drawing.Size(108, 29)
        Me.menuInventory.Text = "Inventory"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUserStatus, Me.lblTimeStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 530)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1000, 28)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblUserStatus
        '
        Me.lblUserStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblUserStatus.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUserStatus.Name = "lblUserStatus"
        Me.lblUserStatus.Size = New System.Drawing.Size(792, 23)
        Me.lblUserStatus.Spring = True
        Me.lblUserStatus.Text = "User  :  Mustafa"
        '
        'lblTimeStatus
        '
        Me.lblTimeStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTimeStatus.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTimeStatus.Name = "lblTimeStatus"
        Me.lblTimeStatus.Size = New System.Drawing.Size(193, 23)
        Me.lblTimeStatus.Text = "ToolStripStatusLabel2"
        '
        'grpResourceManagement
        '
        Me.grpResourceManagement.BackColor = System.Drawing.Color.Snow
        Me.grpResourceManagement.Controls.Add(Me.Label5)
        Me.grpResourceManagement.Controls.Add(Me.lblTotalPrice)
        Me.grpResourceManagement.Controls.Add(Me.Label4)
        Me.grpResourceManagement.Controls.Add(Me.Label3)
        Me.grpResourceManagement.Controls.Add(Me.cmbFilterType)
        Me.grpResourceManagement.Controls.Add(Me.numLiters)
        Me.grpResourceManagement.Controls.Add(Me.cmbOilType)
        Me.grpResourceManagement.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpResourceManagement.Location = New System.Drawing.Point(547, 36)
        Me.grpResourceManagement.Name = "grpResourceManagement"
        Me.grpResourceManagement.Size = New System.Drawing.Size(453, 491)
        Me.grpResourceManagement.TabIndex = 4
        Me.grpResourceManagement.TabStop = False
        Me.grpResourceManagement.Text = "Resource Management"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 349)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Liters required"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblTotalPrice.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.ForeColor = System.Drawing.Color.Green
        Me.lblTotalPrice.Location = New System.Drawing.Point(186, 460)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(78, 34)
        Me.lblTotalPrice.TabIndex = 3
        Me.lblTotalPrice.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(253, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Choose the type of filter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Choose the type of oil"
        '
        'cmbFilterType
        '
        Me.cmbFilterType.BackColor = System.Drawing.Color.LightGreen
        Me.cmbFilterType.FormattingEnabled = True
        Me.cmbFilterType.Location = New System.Drawing.Point(303, 193)
        Me.cmbFilterType.Name = "cmbFilterType"
        Me.cmbFilterType.Size = New System.Drawing.Size(144, 24)
        Me.cmbFilterType.TabIndex = 2
        '
        'numLiters
        '
        Me.numLiters.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.numLiters.ForeColor = System.Drawing.Color.Green
        Me.numLiters.Location = New System.Drawing.Point(341, 349)
        Me.numLiters.Name = "numLiters"
        Me.numLiters.Size = New System.Drawing.Size(100, 23)
        Me.numLiters.TabIndex = 1
        '
        'cmbOilType
        '
        Me.cmbOilType.BackColor = System.Drawing.Color.LightGreen
        Me.cmbOilType.FormattingEnabled = True
        Me.cmbOilType.Location = New System.Drawing.Point(303, 46)
        Me.cmbOilType.Name = "cmbOilType"
        Me.cmbOilType.Size = New System.Drawing.Size(144, 24)
        Me.cmbOilType.TabIndex = 0
        '
        'tmrClock
        '
        Me.tmrClock.Enabled = True
        Me.tmrClock.Interval = 1000
        '
        'lblTodayCars
        '
        Me.lblTodayCars.BackColor = System.Drawing.Color.Snow
        Me.lblTodayCars.Controls.Add(Me.lblCarsCount)
        Me.lblTodayCars.Controls.Add(Me.lblCarsTitle)
        Me.lblTodayCars.Location = New System.Drawing.Point(12, 425)
        Me.lblTodayCars.Name = "lblTodayCars"
        Me.lblTodayCars.Size = New System.Drawing.Size(172, 65)
        Me.lblTodayCars.TabIndex = 7
        '
        'lblCarsCount
        '
        Me.lblCarsCount.AutoSize = True
        Me.lblCarsCount.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarsCount.ForeColor = System.Drawing.Color.Green
        Me.lblCarsCount.Location = New System.Drawing.Point(35, 32)
        Me.lblCarsCount.Name = "lblCarsCount"
        Me.lblCarsCount.Size = New System.Drawing.Size(28, 29)
        Me.lblCarsCount.TabIndex = 9
        Me.lblCarsCount.Text = "0"
        '
        'lblCarsTitle
        '
        Me.lblCarsTitle.AutoSize = True
        Me.lblCarsTitle.Font = New System.Drawing.Font("Tahoma", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarsTitle.Location = New System.Drawing.Point(37, 0)
        Me.lblCarsTitle.Name = "lblCarsTitle"
        Me.lblCarsTitle.Size = New System.Drawing.Size(94, 17)
        Me.lblCarsTitle.TabIndex = 9
        Me.lblCarsTitle.Text = "Today's cars"
        '
        'lblTodaySales
        '
        Me.lblTodaySales.BackColor = System.Drawing.Color.Snow
        Me.lblTodaySales.Controls.Add(Me.lblSalesTotal)
        Me.lblTodaySales.Controls.Add(Me.LalblSaletle)
        Me.lblTodaySales.Location = New System.Drawing.Point(371, 425)
        Me.lblTodaySales.Name = "lblTodaySales"
        Me.lblTodaySales.Size = New System.Drawing.Size(170, 64)
        Me.lblTodaySales.TabIndex = 0
        '
        'lblSalesTotal
        '
        Me.lblSalesTotal.AutoSize = True
        Me.lblSalesTotal.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesTotal.ForeColor = System.Drawing.Color.Green
        Me.lblSalesTotal.Location = New System.Drawing.Point(3, 32)
        Me.lblSalesTotal.Name = "lblSalesTotal"
        Me.lblSalesTotal.Size = New System.Drawing.Size(66, 29)
        Me.lblSalesTotal.TabIndex = 9
        Me.lblSalesTotal.Text = "0.00"
        '
        'LalblSaletle
        '
        Me.LalblSaletle.AutoSize = True
        Me.LalblSaletle.Font = New System.Drawing.Font("Tahoma", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LalblSaletle.Location = New System.Drawing.Point(37, 0)
        Me.LalblSaletle.Name = "LalblSaletle"
        Me.LalblSaletle.Size = New System.Drawing.Size(99, 17)
        Me.LalblSaletle.TabIndex = 9
        Me.LalblSaletle.Text = "Today's sales"
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.BackColor = System.Drawing.Color.Snow
        Me.btnAddCustomer.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCustomer.ForeColor = System.Drawing.Color.Green
        Me.btnAddCustomer.Location = New System.Drawing.Point(285, 282)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(222, 45)
        Me.btnAddCustomer.TabIndex = 9
        Me.btnAddCustomer.Text = "Add customer +"
        Me.btnAddCustomer.UseVisualStyleBackColor = False
        '
        'btnBilling
        '
        Me.btnBilling.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnBilling.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBilling.ForeColor = System.Drawing.Color.Green
        Me.btnBilling.Location = New System.Drawing.Point(180, 229)
        Me.btnBilling.Name = "btnBilling"
        Me.btnBilling.Size = New System.Drawing.Size(222, 43)
        Me.btnBilling.TabIndex = 10
        Me.btnBilling.Text = "Bill payment #"
        Me.btnBilling.UseVisualStyleBackColor = False
        '
        'btnBillPayment
        '
        Me.btnBillPayment.BackColor = System.Drawing.Color.Snow
        Me.btnBillPayment.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBillPayment.ForeColor = System.Drawing.Color.Green
        Me.btnBillPayment.Location = New System.Drawing.Point(37, 282)
        Me.btnBillPayment.Name = "btnBillPayment"
        Me.btnBillPayment.Size = New System.Drawing.Size(222, 45)
        Me.btnBillPayment.TabIndex = 10
        Me.btnBillPayment.Text = "Bill Payment #"
        Me.btnBillPayment.UseVisualStyleBackColor = False
        '
        'MainDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(1000, 558)
        Me.Controls.Add(Me.btnBillPayment)
        Me.Controls.Add(Me.btnAddCustomer)
        Me.Controls.Add(Me.lblTodaySales)
        Me.Controls.Add(Me.lblTodayCars)
        Me.Controls.Add(Me.grpResourceManagement)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblOlio)
        Me.Controls.Add(Me.mnuMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "MainDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainDashboard"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.grpResourceManagement.ResumeLayout(False)
        Me.grpResourceManagement.PerformLayout()
        CType(Me.numLiters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lblTodayCars.ResumeLayout(False)
        Me.lblTodayCars.PerformLayout()
        Me.lblTodaySales.ResumeLayout(False)
        Me.lblTodaySales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOlio As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents menuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblUserStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents menuInventory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpResourceManagement As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents cmbFilterType As System.Windows.Forms.ComboBox
    Friend WithEvents numLiters As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbOilType As System.Windows.Forms.ComboBox
    Friend WithEvents tmrClock As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCarsCount As System.Windows.Forms.Label
    Friend WithEvents lblCarsTitle As System.Windows.Forms.Label
    Friend WithEvents LalblSaletle As System.Windows.Forms.Label
    Friend WithEvents lblSalesTotal As System.Windows.Forms.Label
    Friend WithEvents menuLogOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAddCustomer As System.Windows.Forms.Button
    Friend WithEvents btnBilling As System.Windows.Forms.Button
    Friend WithEvents btnBillPayment As System.Windows.Forms.Button
    Friend WithEvents lblTimeStatus As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents lblTodayCars As System.Windows.Forms.Panel
    Public WithEvents lblTodaySales As System.Windows.Forms.Panel
End Class
