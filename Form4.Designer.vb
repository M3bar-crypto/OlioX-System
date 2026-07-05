<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPageGeneral = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblOlio = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCenterName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabPageSecurity = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tabPageSystem = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtLaborCost = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkDarkMode = New System.Windows.Forms.CheckBox()
        Me.tabPageBackup = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnBrowsePath = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBackupPath = New System.Windows.Forms.TextBox()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.btnCancelSettings = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabPageGeneral.SuspendLayout()
        Me.tabPageSecurity.SuspendLayout()
        Me.tabPageSystem.SuspendLayout()
        Me.tabPageBackup.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabPageGeneral)
        Me.TabControl1.Controls.Add(Me.tabPageSecurity)
        Me.TabControl1.Controls.Add(Me.tabPageSystem)
        Me.TabControl1.Controls.Add(Me.tabPageBackup)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(87, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(680, 295)
        Me.TabControl1.TabIndex = 0
        '
        'tabPageGeneral
        '
        Me.tabPageGeneral.BackColor = System.Drawing.Color.Snow
        Me.tabPageGeneral.Controls.Add(Me.Label8)
        Me.tabPageGeneral.Controls.Add(Me.lblOlio)
        Me.tabPageGeneral.Controls.Add(Me.Label3)
        Me.tabPageGeneral.Controls.Add(Me.txtAddress)
        Me.tabPageGeneral.Controls.Add(Me.txtPhone)
        Me.tabPageGeneral.Controls.Add(Me.Label2)
        Me.tabPageGeneral.Controls.Add(Me.txtCenterName)
        Me.tabPageGeneral.Controls.Add(Me.Label1)
        Me.tabPageGeneral.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPageGeneral.Location = New System.Drawing.Point(4, 30)
        Me.tabPageGeneral.Name = "tabPageGeneral"
        Me.tabPageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageGeneral.Size = New System.Drawing.Size(672, 261)
        Me.tabPageGeneral.TabIndex = 0
        Me.tabPageGeneral.Text = "General"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(635, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 40)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "X"
        '
        'lblOlio
        '
        Me.lblOlio.AutoSize = True
        Me.lblOlio.BackColor = System.Drawing.Color.Transparent
        Me.lblOlio.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOlio.Location = New System.Drawing.Point(557, 217)
        Me.lblOlio.Name = "lblOlio"
        Me.lblOlio.Size = New System.Drawing.Size(82, 40)
        Me.lblOlio.TabIndex = 7
        Me.lblOlio.Text = "Olio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.SystemColors.Info
        Me.txtAddress.Location = New System.Drawing.Point(300, 186)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(116, 28)
        Me.txtAddress.TabIndex = 5
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.SystemColors.Info
        Me.txtPhone.Location = New System.Drawing.Point(300, 123)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(116, 28)
        Me.txtPhone.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Phone number"
        '
        'txtCenterName
        '
        Me.txtCenterName.BackColor = System.Drawing.SystemColors.Info
        Me.txtCenterName.Location = New System.Drawing.Point(300, 57)
        Me.txtCenterName.Name = "txtCenterName"
        Me.txtCenterName.Size = New System.Drawing.Size(116, 28)
        Me.txtCenterName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Center name "
        '
        'tabPageSecurity
        '
        Me.tabPageSecurity.Controls.Add(Me.Label12)
        Me.tabPageSecurity.Controls.Add(Me.Label9)
        Me.tabPageSecurity.Controls.Add(Me.Label5)
        Me.tabPageSecurity.Controls.Add(Me.txtPassword)
        Me.tabPageSecurity.Controls.Add(Me.txtUsername)
        Me.tabPageSecurity.Controls.Add(Me.Label4)
        Me.tabPageSecurity.Location = New System.Drawing.Point(4, 30)
        Me.tabPageSecurity.Name = "tabPageSecurity"
        Me.tabPageSecurity.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageSecurity.Size = New System.Drawing.Size(672, 261)
        Me.tabPageSecurity.TabIndex = 1
        Me.tabPageSecurity.Text = "Security"
        Me.tabPageSecurity.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Green
        Me.Label12.Location = New System.Drawing.Point(635, 217)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 40)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "X"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(557, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 40)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Olio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(223, 29)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Change password"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Info
        Me.txtPassword.Location = New System.Drawing.Point(304, 163)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(115, 28)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.Info
        Me.txtUsername.Location = New System.Drawing.Point(304, 62)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(115, 28)
        Me.txtUsername.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 29)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "User name"
        '
        'tabPageSystem
        '
        Me.tabPageSystem.Controls.Add(Me.Label13)
        Me.tabPageSystem.Controls.Add(Me.Label10)
        Me.tabPageSystem.Controls.Add(Me.txtLaborCost)
        Me.tabPageSystem.Controls.Add(Me.Label6)
        Me.tabPageSystem.Controls.Add(Me.chkDarkMode)
        Me.tabPageSystem.Location = New System.Drawing.Point(4, 30)
        Me.tabPageSystem.Name = "tabPageSystem"
        Me.tabPageSystem.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageSystem.Size = New System.Drawing.Size(672, 261)
        Me.tabPageSystem.TabIndex = 2
        Me.tabPageSystem.Text = "System"
        Me.tabPageSystem.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Green
        Me.Label13.Location = New System.Drawing.Point(635, 217)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 40)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "X"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(557, 217)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 40)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Olio"
        '
        'txtLaborCost
        '
        Me.txtLaborCost.BackColor = System.Drawing.SystemColors.Info
        Me.txtLaborCost.Location = New System.Drawing.Point(304, 163)
        Me.txtLaborCost.Name = "txtLaborCost"
        Me.txtLaborCost.Size = New System.Drawing.Size(53, 28)
        Me.txtLaborCost.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 29)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Labor cost"
        '
        'chkDarkMode
        '
        Me.chkDarkMode.AutoSize = True
        Me.chkDarkMode.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDarkMode.Location = New System.Drawing.Point(36, 57)
        Me.chkDarkMode.Name = "chkDarkMode"
        Me.chkDarkMode.Size = New System.Drawing.Size(172, 33)
        Me.chkDarkMode.TabIndex = 0
        Me.chkDarkMode.Text = "Dark mode "
        Me.chkDarkMode.UseVisualStyleBackColor = True
        '
        'tabPageBackup
        '
        Me.tabPageBackup.BackColor = System.Drawing.Color.Snow
        Me.tabPageBackup.Controls.Add(Me.Label14)
        Me.tabPageBackup.Controls.Add(Me.Label11)
        Me.tabPageBackup.Controls.Add(Me.btnBrowsePath)
        Me.tabPageBackup.Controls.Add(Me.Label7)
        Me.tabPageBackup.Controls.Add(Me.txtBackupPath)
        Me.tabPageBackup.Location = New System.Drawing.Point(4, 30)
        Me.tabPageBackup.Name = "tabPageBackup"
        Me.tabPageBackup.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageBackup.Size = New System.Drawing.Size(672, 261)
        Me.tabPageBackup.TabIndex = 3
        Me.tabPageBackup.Text = "Backup"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Green
        Me.Label14.Location = New System.Drawing.Point(635, 217)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 40)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "X"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(557, 217)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 40)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Olio"
        '
        'btnBrowsePath
        '
        Me.btnBrowsePath.BackColor = System.Drawing.Color.LightGray
        Me.btnBrowsePath.Location = New System.Drawing.Point(359, 138)
        Me.btnBrowsePath.Name = "btnBrowsePath"
        Me.btnBrowsePath.Size = New System.Drawing.Size(98, 29)
        Me.btnBrowsePath.TabIndex = 2
        Me.btnBrowsePath.Text = "Browse .."
        Me.btnBrowsePath.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 29)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Backup Path"
        '
        'txtBackupPath
        '
        Me.txtBackupPath.BackColor = System.Drawing.SystemColors.Info
        Me.txtBackupPath.Location = New System.Drawing.Point(246, 60)
        Me.txtBackupPath.Name = "txtBackupPath"
        Me.txtBackupPath.Size = New System.Drawing.Size(335, 28)
        Me.txtBackupPath.TabIndex = 0
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.BackColor = System.Drawing.Color.Lime
        Me.btnSaveSettings.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSettings.Location = New System.Drawing.Point(508, 392)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(164, 36)
        Me.btnSaveSettings.TabIndex = 7
        Me.btnSaveSettings.Text = "Save changes"
        Me.btnSaveSettings.UseVisualStyleBackColor = False
        '
        'btnCancelSettings
        '
        Me.btnCancelSettings.BackColor = System.Drawing.Color.Salmon
        Me.btnCancelSettings.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelSettings.Location = New System.Drawing.Point(174, 392)
        Me.btnCancelSettings.Name = "btnCancelSettings"
        Me.btnCancelSettings.Size = New System.Drawing.Size(164, 36)
        Me.btnCancelSettings.TabIndex = 8
        Me.btnCancelSettings.Text = "Cancel"
        Me.btnCancelSettings.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.OrangeRed
        Me.btnBack.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(793, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(38, 32)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "x"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(843, 473)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCancelSettings)
        Me.Controls.Add(Me.btnSaveSettings)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SettingsForm"
        Me.TabControl1.ResumeLayout(False)
        Me.tabPageGeneral.ResumeLayout(False)
        Me.tabPageGeneral.PerformLayout()
        Me.tabPageSecurity.ResumeLayout(False)
        Me.tabPageSecurity.PerformLayout()
        Me.tabPageSystem.ResumeLayout(False)
        Me.tabPageSystem.PerformLayout()
        Me.tabPageBackup.ResumeLayout(False)
        Me.tabPageBackup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabPageSecurity As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCenterName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tabPageSystem As System.Windows.Forms.TabPage
    Friend WithEvents txtLaborCost As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkDarkMode As System.Windows.Forms.CheckBox
    Friend WithEvents tabPageBackup As System.Windows.Forms.TabPage
    Friend WithEvents btnBrowsePath As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBackupPath As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveSettings As System.Windows.Forms.Button
    Friend WithEvents btnCancelSettings As System.Windows.Forms.Button
    Friend WithEvents lblOlio As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
