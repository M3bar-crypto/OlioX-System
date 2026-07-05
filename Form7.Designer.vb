<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryForm
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
        Me.tabInventory = New System.Windows.Forms.TabControl()
        Me.tabOils = New System.Windows.Forms.TabPage()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvOils = New System.Windows.Forms.DataGridView()
        Me.btnDeleteOil = New System.Windows.Forms.Button()
        Me.btnEditOil = New System.Windows.Forms.Button()
        Me.btnAddOil = New System.Windows.Forms.Button()
        Me.txtOilPrice = New System.Windows.Forms.TextBox()
        Me.numOilQty = New System.Windows.Forms.NumericUpDown()
        Me.cmbOilViscosity = New System.Windows.Forms.ComboBox()
        Me.txtOilName = New System.Windows.Forms.TextBox()
        Me.tabFilters = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgvFilters = New System.Windows.Forms.DataGridView()
        Me.btnDeleteFilter = New System.Windows.Forms.Button()
        Me.btnEditFilter = New System.Windows.Forms.Button()
        Me.btnAddFilter = New System.Windows.Forms.Button()
        Me.txtFilterPrice = New System.Windows.Forms.TextBox()
        Me.numFilterQty = New System.Windows.Forms.NumericUpDown()
        Me.cmbFilterCategory = New System.Windows.Forms.ComboBox()
        Me.txtFilterName = New System.Windows.Forms.TextBox()
        Me.tabInventory.SuspendLayout()
        Me.tabOils.SuspendLayout()
        CType(Me.dgvOils, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numOilQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFilters.SuspendLayout()
        CType(Me.dgvFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numFilterQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabInventory
        '
        Me.tabInventory.Controls.Add(Me.tabOils)
        Me.tabInventory.Controls.Add(Me.tabFilters)
        Me.tabInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabInventory.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabInventory.Location = New System.Drawing.Point(0, 0)
        Me.tabInventory.Name = "tabInventory"
        Me.tabInventory.SelectedIndex = 0
        Me.tabInventory.Size = New System.Drawing.Size(904, 535)
        Me.tabInventory.TabIndex = 0
        '
        'tabOils
        '
        Me.tabOils.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tabOils.Controls.Add(Me.btnBack)
        Me.tabOils.Controls.Add(Me.dgvOils)
        Me.tabOils.Controls.Add(Me.btnDeleteOil)
        Me.tabOils.Controls.Add(Me.btnEditOil)
        Me.tabOils.Controls.Add(Me.btnAddOil)
        Me.tabOils.Controls.Add(Me.txtOilPrice)
        Me.tabOils.Controls.Add(Me.numOilQty)
        Me.tabOils.Controls.Add(Me.cmbOilViscosity)
        Me.tabOils.Controls.Add(Me.txtOilName)
        Me.tabOils.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabOils.Location = New System.Drawing.Point(4, 37)
        Me.tabOils.Name = "tabOils"
        Me.tabOils.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOils.Size = New System.Drawing.Size(896, 494)
        Me.tabOils.TabIndex = 0
        Me.tabOils.Text = "Oils"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.OrangeRed
        Me.btnBack.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(852, 6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(38, 32)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "x"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'dgvOils
        '
        Me.dgvOils.BackgroundColor = System.Drawing.Color.Snow
        Me.dgvOils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOils.Location = New System.Drawing.Point(211, 76)
        Me.dgvOils.Name = "dgvOils"
        Me.dgvOils.RowTemplate.Height = 26
        Me.dgvOils.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOils.Size = New System.Drawing.Size(523, 343)
        Me.dgvOils.TabIndex = 10
        '
        'btnDeleteOil
        '
        Me.btnDeleteOil.BackColor = System.Drawing.Color.Salmon
        Me.btnDeleteOil.Location = New System.Drawing.Point(752, 279)
        Me.btnDeleteOil.Name = "btnDeleteOil"
        Me.btnDeleteOil.Size = New System.Drawing.Size(102, 39)
        Me.btnDeleteOil.TabIndex = 9
        Me.btnDeleteOil.Text = "Delete"
        Me.btnDeleteOil.UseVisualStyleBackColor = False
        '
        'btnEditOil
        '
        Me.btnEditOil.BackColor = System.Drawing.Color.Orange
        Me.btnEditOil.Location = New System.Drawing.Point(752, 194)
        Me.btnEditOil.Name = "btnEditOil"
        Me.btnEditOil.Size = New System.Drawing.Size(102, 39)
        Me.btnEditOil.TabIndex = 8
        Me.btnEditOil.Text = "Edit"
        Me.btnEditOil.UseVisualStyleBackColor = False
        '
        'btnAddOil
        '
        Me.btnAddOil.BackColor = System.Drawing.Color.Lime
        Me.btnAddOil.Location = New System.Drawing.Point(752, 104)
        Me.btnAddOil.Name = "btnAddOil"
        Me.btnAddOil.Size = New System.Drawing.Size(102, 39)
        Me.btnAddOil.TabIndex = 7
        Me.btnAddOil.Text = "Add Oil"
        Me.btnAddOil.UseVisualStyleBackColor = False
        '
        'txtOilPrice
        '
        Me.txtOilPrice.BackColor = System.Drawing.SystemColors.Info
        Me.txtOilPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOilPrice.Location = New System.Drawing.Point(36, 248)
        Me.txtOilPrice.Name = "txtOilPrice"
        Me.txtOilPrice.Size = New System.Drawing.Size(152, 25)
        Me.txtOilPrice.TabIndex = 4
        '
        'numOilQty
        '
        Me.numOilQty.BackColor = System.Drawing.SystemColors.Info
        Me.numOilQty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numOilQty.Location = New System.Drawing.Point(53, 301)
        Me.numOilQty.Name = "numOilQty"
        Me.numOilQty.Size = New System.Drawing.Size(120, 28)
        Me.numOilQty.TabIndex = 3
        '
        'cmbOilViscosity
        '
        Me.cmbOilViscosity.BackColor = System.Drawing.SystemColors.Info
        Me.cmbOilViscosity.FormattingEnabled = True
        Me.cmbOilViscosity.Location = New System.Drawing.Point(36, 185)
        Me.cmbOilViscosity.Name = "cmbOilViscosity"
        Me.cmbOilViscosity.Size = New System.Drawing.Size(152, 32)
        Me.cmbOilViscosity.TabIndex = 2
        '
        'txtOilName
        '
        Me.txtOilName.BackColor = System.Drawing.SystemColors.Info
        Me.txtOilName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOilName.Location = New System.Drawing.Point(36, 129)
        Me.txtOilName.Name = "txtOilName"
        Me.txtOilName.Size = New System.Drawing.Size(152, 25)
        Me.txtOilName.TabIndex = 1
        '
        'tabFilters
        '
        Me.tabFilters.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tabFilters.Controls.Add(Me.Button2)
        Me.tabFilters.Controls.Add(Me.dgvFilters)
        Me.tabFilters.Controls.Add(Me.btnDeleteFilter)
        Me.tabFilters.Controls.Add(Me.btnEditFilter)
        Me.tabFilters.Controls.Add(Me.btnAddFilter)
        Me.tabFilters.Controls.Add(Me.txtFilterPrice)
        Me.tabFilters.Controls.Add(Me.numFilterQty)
        Me.tabFilters.Controls.Add(Me.cmbFilterCategory)
        Me.tabFilters.Controls.Add(Me.txtFilterName)
        Me.tabFilters.Location = New System.Drawing.Point(4, 37)
        Me.tabFilters.Name = "tabFilters"
        Me.tabFilters.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFilters.Size = New System.Drawing.Size(896, 494)
        Me.tabFilters.TabIndex = 1
        Me.tabFilters.Text = "Filters"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.OrangeRed
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(850, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 32)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "x"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dgvFilters
        '
        Me.dgvFilters.BackgroundColor = System.Drawing.Color.Snow
        Me.dgvFilters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFilters.Location = New System.Drawing.Point(213, 81)
        Me.dgvFilters.Name = "dgvFilters"
        Me.dgvFilters.RowTemplate.Height = 26
        Me.dgvFilters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFilters.Size = New System.Drawing.Size(523, 355)
        Me.dgvFilters.TabIndex = 18
        '
        'btnDeleteFilter
        '
        Me.btnDeleteFilter.BackColor = System.Drawing.Color.Salmon
        Me.btnDeleteFilter.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteFilter.Location = New System.Drawing.Point(766, 289)
        Me.btnDeleteFilter.Name = "btnDeleteFilter"
        Me.btnDeleteFilter.Size = New System.Drawing.Size(102, 39)
        Me.btnDeleteFilter.TabIndex = 17
        Me.btnDeleteFilter.Text = "Delete"
        Me.btnDeleteFilter.UseVisualStyleBackColor = False
        '
        'btnEditFilter
        '
        Me.btnEditFilter.BackColor = System.Drawing.Color.Orange
        Me.btnEditFilter.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditFilter.Location = New System.Drawing.Point(766, 207)
        Me.btnEditFilter.Name = "btnEditFilter"
        Me.btnEditFilter.Size = New System.Drawing.Size(102, 39)
        Me.btnEditFilter.TabIndex = 16
        Me.btnEditFilter.Text = "Edit"
        Me.btnEditFilter.UseVisualStyleBackColor = False
        '
        'btnAddFilter
        '
        Me.btnAddFilter.BackColor = System.Drawing.Color.Lime
        Me.btnAddFilter.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFilter.Location = New System.Drawing.Point(753, 115)
        Me.btnAddFilter.Name = "btnAddFilter"
        Me.btnAddFilter.Size = New System.Drawing.Size(115, 44)
        Me.btnAddFilter.TabIndex = 15
        Me.btnAddFilter.Text = "Add filter"
        Me.btnAddFilter.UseVisualStyleBackColor = False
        '
        'txtFilterPrice
        '
        Me.txtFilterPrice.BackColor = System.Drawing.SystemColors.Info
        Me.txtFilterPrice.Location = New System.Drawing.Point(37, 231)
        Me.txtFilterPrice.Name = "txtFilterPrice"
        Me.txtFilterPrice.Size = New System.Drawing.Size(152, 35)
        Me.txtFilterPrice.TabIndex = 14
        '
        'numFilterQty
        '
        Me.numFilterQty.BackColor = System.Drawing.SystemColors.Info
        Me.numFilterQty.Location = New System.Drawing.Point(55, 291)
        Me.numFilterQty.Name = "numFilterQty"
        Me.numFilterQty.Size = New System.Drawing.Size(120, 35)
        Me.numFilterQty.TabIndex = 13
        '
        'cmbFilterCategory
        '
        Me.cmbFilterCategory.BackColor = System.Drawing.SystemColors.Info
        Me.cmbFilterCategory.FormattingEnabled = True
        Me.cmbFilterCategory.Location = New System.Drawing.Point(37, 175)
        Me.cmbFilterCategory.Name = "cmbFilterCategory"
        Me.cmbFilterCategory.Size = New System.Drawing.Size(152, 36)
        Me.cmbFilterCategory.TabIndex = 12
        '
        'txtFilterName
        '
        Me.txtFilterName.BackColor = System.Drawing.SystemColors.Info
        Me.txtFilterName.Location = New System.Drawing.Point(37, 119)
        Me.txtFilterName.Name = "txtFilterName"
        Me.txtFilterName.Size = New System.Drawing.Size(152, 35)
        Me.txtFilterName.TabIndex = 11
        '
        'InventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(904, 535)
        Me.Controls.Add(Me.tabInventory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InventoryForm"
        Me.Text = "InventoryForm"
        Me.tabInventory.ResumeLayout(False)
        Me.tabOils.ResumeLayout(False)
        Me.tabOils.PerformLayout()
        CType(Me.dgvOils, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numOilQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFilters.ResumeLayout(False)
        Me.tabFilters.PerformLayout()
        CType(Me.dgvFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numFilterQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabInventory As System.Windows.Forms.TabControl
    Friend WithEvents tabOils As System.Windows.Forms.TabPage
    Friend WithEvents tabFilters As System.Windows.Forms.TabPage
    Friend WithEvents txtOilName As System.Windows.Forms.TextBox
    Friend WithEvents numOilQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbOilViscosity As System.Windows.Forms.ComboBox
    Friend WithEvents dgvOils As System.Windows.Forms.DataGridView
    Friend WithEvents btnDeleteOil As System.Windows.Forms.Button
    Friend WithEvents btnEditOil As System.Windows.Forms.Button
    Friend WithEvents btnAddOil As System.Windows.Forms.Button
    Friend WithEvents txtOilPrice As System.Windows.Forms.TextBox
    Friend WithEvents dgvFilters As System.Windows.Forms.DataGridView
    Friend WithEvents btnDeleteFilter As System.Windows.Forms.Button
    Friend WithEvents btnEditFilter As System.Windows.Forms.Button
    Friend WithEvents btnAddFilter As System.Windows.Forms.Button
    Friend WithEvents txtFilterPrice As System.Windows.Forms.TextBox
    Friend WithEvents numFilterQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbFilterCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtFilterName As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
