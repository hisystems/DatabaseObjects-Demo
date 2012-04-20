Option Strict Off
Option Explicit On 

Imports NorthwindDatabase
Imports System.Windows.Forms

Friend Class frmOrder
    Inherits System.Windows.Forms.Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents cmdEditQuantity As System.Windows.Forms.Button
    Public WithEvents cmdDelete As System.Windows.Forms.Button
    Public WithEvents txtCost As System.Windows.Forms.TextBox
    Public WithEvents fraDetails As System.Windows.Forms.GroupBox
    Public WithEvents txtShipName As System.Windows.Forms.TextBox
    Public WithEvents txtPostalCode As System.Windows.Forms.TextBox
    Public WithEvents txtRegion As System.Windows.Forms.TextBox
    Public WithEvents txtCity As System.Windows.Forms.TextBox
    Public WithEvents txtAddress As System.Windows.Forms.TextBox
    Public WithEvents lblShipName As System.Windows.Forms.Label
    Public WithEvents lblPostalCode As System.Windows.Forms.Label
    Public WithEvents lblRegion As System.Windows.Forms.Label
    Public WithEvents lblCity As System.Windows.Forms.Label
    Public WithEvents lblAddress As System.Windows.Forms.Label
    Public WithEvents fraShipTo As System.Windows.Forms.GroupBox
    Public WithEvents txtOrdered As System.Windows.Forms.TextBox
    Public WithEvents txtOrderNumber As System.Windows.Forms.TextBox
    Public WithEvents cmdOK As System.Windows.Forms.Button
    Public WithEvents cmdCancel As System.Windows.Forms.Button
    Public WithEvents lblCost As System.Windows.Forms.Label
    Public WithEvents lblOrdered As System.Windows.Forms.Label
    Public WithEvents lblRequired As System.Windows.Forms.Label
    Public WithEvents lblOrderNumber As System.Windows.Forms.Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents lvwDetails As System.Windows.Forms.ListView
    Friend WithEvents dtpRequired As System.Windows.Forms.DateTimePicker
    Friend WithEvents column1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdEditQuantity = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.txtCost = New System.Windows.Forms.TextBox
        Me.fraDetails = New System.Windows.Forms.GroupBox
        Me.lvwDetails = New System.Windows.Forms.ListView
        Me.column1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.fraShipTo = New System.Windows.Forms.GroupBox
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.txtPostalCode = New System.Windows.Forms.TextBox
        Me.txtRegion = New System.Windows.Forms.TextBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.lblShipName = New System.Windows.Forms.Label
        Me.lblPostalCode = New System.Windows.Forms.Label
        Me.lblRegion = New System.Windows.Forms.Label
        Me.lblCity = New System.Windows.Forms.Label
        Me.lblAddress = New System.Windows.Forms.Label
        Me.txtOrdered = New System.Windows.Forms.TextBox
        Me.txtOrderNumber = New System.Windows.Forms.TextBox
        Me.cmdOK = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.lblCost = New System.Windows.Forms.Label
        Me.lblOrdered = New System.Windows.Forms.Label
        Me.lblRequired = New System.Windows.Forms.Label
        Me.lblOrderNumber = New System.Windows.Forms.Label
        Me.dtpRequired = New System.Windows.Forms.DateTimePicker
        Me.fraDetails.SuspendLayout()
        Me.fraShipTo.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdEditQuantity
        '
        Me.cmdEditQuantity.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEditQuantity.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEditQuantity.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditQuantity.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEditQuantity.Location = New System.Drawing.Point(32, 440)
        Me.cmdEditQuantity.Name = "cmdEditQuantity"
        Me.cmdEditQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEditQuantity.Size = New System.Drawing.Size(101, 24)
        Me.cmdEditQuantity.TabIndex = 10
        Me.cmdEditQuantity.Text = "Edit Quantity"
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelete.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDelete.Location = New System.Drawing.Point(8, 496)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDelete.Size = New System.Drawing.Size(89, 24)
        Me.cmdDelete.TabIndex = 11
        Me.cmdDelete.Text = "Delete"
        '
        'txtCost
        '
        Me.txtCost.AcceptsReturn = True
        Me.txtCost.AutoSize = False
        Me.txtCost.BackColor = System.Drawing.SystemColors.Window
        Me.txtCost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCost.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCost.Location = New System.Drawing.Point(420, 40)
        Me.txtCost.MaxLength = 0
        Me.txtCost.Name = "txtCost"
        Me.txtCost.ReadOnly = True
        Me.txtCost.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCost.Size = New System.Drawing.Size(97, 21)
        Me.txtCost.TabIndex = 3
        Me.txtCost.TabStop = False
        Me.txtCost.Text = ""
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fraDetails
        '
        Me.fraDetails.BackColor = System.Drawing.SystemColors.Control
        Me.fraDetails.Controls.Add(Me.lvwDetails)
        Me.fraDetails.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraDetails.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraDetails.Location = New System.Drawing.Point(12, 236)
        Me.fraDetails.Name = "fraDetails"
        Me.fraDetails.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraDetails.Size = New System.Drawing.Size(509, 244)
        Me.fraDetails.TabIndex = 19
        Me.fraDetails.TabStop = False
        Me.fraDetails.Text = "Details"
        '
        'lvwDetails
        '
        Me.lvwDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.column1, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvwDetails.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwDetails.FullRowSelect = True
        Me.lvwDetails.Location = New System.Drawing.Point(16, 24)
        Me.lvwDetails.Name = "lvwDetails"
        Me.lvwDetails.Size = New System.Drawing.Size(480, 160)
        Me.lvwDetails.TabIndex = 9
        Me.lvwDetails.View = System.Windows.Forms.View.Details
        '
        'column1
        '
        Me.column1.Text = "Product"
        Me.column1.Width = 160
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Quantity"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Unit Price"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cost"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 90
        '
        'fraShipTo
        '
        Me.fraShipTo.BackColor = System.Drawing.SystemColors.Control
        Me.fraShipTo.Controls.Add(Me.txtShipName)
        Me.fraShipTo.Controls.Add(Me.txtPostalCode)
        Me.fraShipTo.Controls.Add(Me.txtRegion)
        Me.fraShipTo.Controls.Add(Me.txtCity)
        Me.fraShipTo.Controls.Add(Me.txtAddress)
        Me.fraShipTo.Controls.Add(Me.lblShipName)
        Me.fraShipTo.Controls.Add(Me.lblPostalCode)
        Me.fraShipTo.Controls.Add(Me.lblRegion)
        Me.fraShipTo.Controls.Add(Me.lblCity)
        Me.fraShipTo.Controls.Add(Me.lblAddress)
        Me.fraShipTo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraShipTo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraShipTo.Location = New System.Drawing.Point(12, 72)
        Me.fraShipTo.Name = "fraShipTo"
        Me.fraShipTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraShipTo.Size = New System.Drawing.Size(509, 153)
        Me.fraShipTo.TabIndex = 8
        Me.fraShipTo.TabStop = False
        Me.fraShipTo.Text = "Ship To"
        '
        'txtShipName
        '
        Me.txtShipName.AcceptsReturn = True
        Me.txtShipName.AutoSize = False
        Me.txtShipName.BackColor = System.Drawing.SystemColors.Window
        Me.txtShipName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShipName.Location = New System.Drawing.Point(88, 20)
        Me.txtShipName.MaxLength = 0
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtShipName.Size = New System.Drawing.Size(221, 21)
        Me.txtShipName.TabIndex = 4
        Me.txtShipName.Text = ""
        '
        'txtPostalCode
        '
        Me.txtPostalCode.AcceptsReturn = True
        Me.txtPostalCode.AutoSize = False
        Me.txtPostalCode.BackColor = System.Drawing.SystemColors.Window
        Me.txtPostalCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPostalCode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostalCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPostalCode.Location = New System.Drawing.Point(88, 116)
        Me.txtPostalCode.MaxLength = 0
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPostalCode.Size = New System.Drawing.Size(69, 21)
        Me.txtPostalCode.TabIndex = 8
        Me.txtPostalCode.Text = ""
        '
        'txtRegion
        '
        Me.txtRegion.AcceptsReturn = True
        Me.txtRegion.AutoSize = False
        Me.txtRegion.BackColor = System.Drawing.SystemColors.Window
        Me.txtRegion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRegion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRegion.Location = New System.Drawing.Point(88, 92)
        Me.txtRegion.MaxLength = 0
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRegion.Size = New System.Drawing.Size(69, 21)
        Me.txtRegion.TabIndex = 7
        Me.txtRegion.Text = ""
        '
        'txtCity
        '
        Me.txtCity.AcceptsReturn = True
        Me.txtCity.AutoSize = False
        Me.txtCity.BackColor = System.Drawing.SystemColors.Window
        Me.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCity.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCity.Location = New System.Drawing.Point(88, 68)
        Me.txtCity.MaxLength = 0
        Me.txtCity.Name = "txtCity"
        Me.txtCity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCity.Size = New System.Drawing.Size(113, 21)
        Me.txtCity.TabIndex = 6
        Me.txtCity.Text = ""
        '
        'txtAddress
        '
        Me.txtAddress.AcceptsReturn = True
        Me.txtAddress.AutoSize = False
        Me.txtAddress.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAddress.Location = New System.Drawing.Point(88, 44)
        Me.txtAddress.MaxLength = 0
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAddress.Size = New System.Drawing.Size(221, 21)
        Me.txtAddress.TabIndex = 5
        Me.txtAddress.Text = ""
        '
        'lblShipName
        '
        Me.lblShipName.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShipName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShipName.Location = New System.Drawing.Point(16, 24)
        Me.lblShipName.Name = "lblShipName"
        Me.lblShipName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipName.Size = New System.Drawing.Size(65, 17)
        Me.lblShipName.TabIndex = 18
        Me.lblShipName.Text = "Name:"
        '
        'lblPostalCode
        '
        Me.lblPostalCode.BackColor = System.Drawing.SystemColors.Control
        Me.lblPostalCode.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPostalCode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostalCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPostalCode.Location = New System.Drawing.Point(16, 120)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPostalCode.Size = New System.Drawing.Size(72, 17)
        Me.lblPostalCode.TabIndex = 16
        Me.lblPostalCode.Text = "Postal Code:"
        '
        'lblRegion
        '
        Me.lblRegion.BackColor = System.Drawing.SystemColors.Control
        Me.lblRegion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRegion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRegion.Location = New System.Drawing.Point(16, 96)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRegion.Size = New System.Drawing.Size(65, 17)
        Me.lblRegion.TabIndex = 14
        Me.lblRegion.Text = "Region:"
        '
        'lblCity
        '
        Me.lblCity.BackColor = System.Drawing.SystemColors.Control
        Me.lblCity.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCity.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCity.Location = New System.Drawing.Point(16, 72)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCity.Size = New System.Drawing.Size(65, 17)
        Me.lblCity.TabIndex = 12
        Me.lblCity.Text = "City:"
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.SystemColors.Control
        Me.lblAddress.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAddress.Location = New System.Drawing.Point(16, 48)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAddress.Size = New System.Drawing.Size(65, 17)
        Me.lblAddress.TabIndex = 10
        Me.lblAddress.Text = "Address:"
        '
        'txtOrdered
        '
        Me.txtOrdered.AcceptsReturn = True
        Me.txtOrdered.AutoSize = False
        Me.txtOrdered.BackColor = System.Drawing.SystemColors.Window
        Me.txtOrdered.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOrdered.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdered.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOrdered.Location = New System.Drawing.Point(420, 12)
        Me.txtOrdered.MaxLength = 0
        Me.txtOrdered.Name = "txtOrdered"
        Me.txtOrdered.ReadOnly = True
        Me.txtOrdered.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOrdered.Size = New System.Drawing.Size(97, 21)
        Me.txtOrdered.TabIndex = 2
        Me.txtOrdered.Text = ""
        Me.txtOrdered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOrderNumber
        '
        Me.txtOrderNumber.AcceptsReturn = True
        Me.txtOrderNumber.AutoSize = False
        Me.txtOrderNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtOrderNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOrderNumber.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderNumber.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOrderNumber.Location = New System.Drawing.Point(104, 12)
        Me.txtOrderNumber.MaxLength = 0
        Me.txtOrderNumber.Name = "txtOrderNumber"
        Me.txtOrderNumber.ReadOnly = True
        Me.txtOrderNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOrderNumber.Size = New System.Drawing.Size(120, 21)
        Me.txtOrderNumber.TabIndex = 0
        Me.txtOrderNumber.Text = ""
        Me.txtOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(336, 496)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(89, 24)
        Me.cmdOK.TabIndex = 12
        Me.cmdOK.Text = "OK"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(432, 496)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(89, 24)
        Me.cmdCancel.TabIndex = 13
        Me.cmdCancel.Text = "&Cancel"
        '
        'lblCost
        '
        Me.lblCost.BackColor = System.Drawing.SystemColors.Control
        Me.lblCost.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCost.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCost.Location = New System.Drawing.Point(336, 44)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCost.Size = New System.Drawing.Size(77, 17)
        Me.lblCost.TabIndex = 22
        Me.lblCost.Text = "Total Cost:"
        Me.lblCost.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblOrdered
        '
        Me.lblOrdered.BackColor = System.Drawing.SystemColors.Control
        Me.lblOrdered.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOrdered.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdered.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOrdered.Location = New System.Drawing.Point(336, 16)
        Me.lblOrdered.Name = "lblOrdered"
        Me.lblOrdered.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOrdered.Size = New System.Drawing.Size(77, 17)
        Me.lblOrdered.TabIndex = 7
        Me.lblOrdered.Text = "Ordered:"
        Me.lblOrdered.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRequired
        '
        Me.lblRequired.BackColor = System.Drawing.SystemColors.Control
        Me.lblRequired.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRequired.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequired.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRequired.Location = New System.Drawing.Point(12, 40)
        Me.lblRequired.Name = "lblRequired"
        Me.lblRequired.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRequired.Size = New System.Drawing.Size(77, 17)
        Me.lblRequired.TabIndex = 5
        Me.lblRequired.Text = "Required:"
        '
        'lblOrderNumber
        '
        Me.lblOrderNumber.BackColor = System.Drawing.SystemColors.Control
        Me.lblOrderNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOrderNumber.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderNumber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOrderNumber.Location = New System.Drawing.Point(12, 16)
        Me.lblOrderNumber.Name = "lblOrderNumber"
        Me.lblOrderNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOrderNumber.Size = New System.Drawing.Size(77, 17)
        Me.lblOrderNumber.TabIndex = 2
        Me.lblOrderNumber.Text = "Order Number:"
        '
        'dtpRequired
        '
        Me.dtpRequired.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpRequired.Location = New System.Drawing.Point(104, 40)
        Me.dtpRequired.Name = "dtpRequired"
        Me.dtpRequired.Size = New System.Drawing.Size(120, 20)
        Me.dtpRequired.TabIndex = 1
        '
        'frmOrder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(533, 528)
        Me.Controls.Add(Me.dtpRequired)
        Me.Controls.Add(Me.cmdEditQuantity)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtOrdered)
        Me.Controls.Add(Me.txtOrderNumber)
        Me.Controls.Add(Me.fraDetails)
        Me.Controls.Add(Me.fraShipTo)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblOrdered)
        Me.Controls.Add(Me.lblRequired)
        Me.Controls.Add(Me.lblOrderNumber)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOrder"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Order"
        Me.fraDetails.ResumeLayout(False)
        Me.fraShipTo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 

    Private pobjOrder As NorthwindDatabase.Order
	
    Private Sub LoadOrder(ByVal objOrder As Order)

        Dim objDetail As OrderDetail

        Me.txtOrderNumber.Text = objOrder.Number
        Me.dtpRequired.Value = objOrder.RequiredDate
        Me.txtOrdered.Text = objOrder.TheDate.ToShortDateString

        Me.txtShipName.Text = objOrder.ShipName

        Me.txtAddress.Text = objOrder.ShipAddress
        Me.txtCity.Text = objOrder.ShipCity
        Me.txtPostalCode.Text = objOrder.ShipPostalCode
        Me.txtRegion.Text = objOrder.ShipRegion

        With Me.lvwDetails.Items
            For Each objDetail In objOrder.Details
                LoadOrderDetail(objDetail, .Add(objDetail.Product.Name))
            Next
        End With

        RefreshTotals()

    End Sub

    Private Sub LoadOrderDetail(ByVal objOrderDetail As OrderDetail, ByVal objItem As System.Windows.Forms.ListViewItem)

        If objItem.SubItems.Count > 1 Then
            objItem.SubItems(1).Text = (objOrderDetail.Quantity)
            objItem.SubItems(2).Text = (objOrderDetail.UnitPrice)
            objItem.SubItems(3).Text = (objOrderDetail.Cost)
        Else
            objItem.SubItems.Add(objOrderDetail.Quantity)
            objItem.SubItems.Add(objOrderDetail.UnitPrice)
            objItem.SubItems.Add(objOrderDetail.Cost)
        End If

    End Sub

    Private Sub cmdDelete_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelete.Click

        If MessageBox.Show("Are you sure you want to delete this order.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Program.NorthWindDB.Orders.Delete(pobjOrder)
            Me.Close()
        End If

    End Sub

    Private Sub cmdEditQuantity_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEditQuantity.Click

        EditQuantity()

    End Sub

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click

        pobjOrder.RequiredDate = Me.dtpRequired.Value
        pobjOrder.ShipName = Me.txtShipName.Text
        pobjOrder.ShipAddress = Me.txtAddress.Text
        pobjOrder.ShipCity = Me.txtCity.Text
        pobjOrder.ShipPostalCode = Me.txtPostalCode.Text
        pobjOrder.ShipRegion = Me.txtRegion.Text

        If Not pobjOrder.ShipPostalCodeIsSet.ConstraintSatisfied Then
            MessageBox.Show(pobjOrder.ShipPostalCodeIsSet.ErrorMessage)
        Else
            pobjOrder.Save()
            Me.Close()
        End If

    End Sub

    Private Sub frmOrder_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        pobjOrder = Program.NorthWindDB.Orders.First
        LoadOrder(pobjOrder)

    End Sub

    Private Sub LoadProducts(ByVal cboBox As System.Windows.Forms.ComboBox)

        Dim objProduct As Product

        With cboBox
            .Items.Clear()
            For Each objProduct In Program.NorthWindDB.Products
                .Items.Add(objProduct.Name)
            Next
            .SelectedIndex = 0
        End With

    End Sub

    Private Sub EditQuantity()

        Dim objItem As ListViewItem
        Dim objOrderDetail As OrderDetail
        Dim strQuantity As String
        Dim intQuantity As Integer

        If Me.lvwDetails.SelectedIndices.Count > 0 Then
            objItem = Me.lvwDetails.SelectedItems(0)
            objOrderDetail = pobjOrder.Details(objItem.Index)

            strQuantity = InputDialog.InputBox("Please enter the new quantity for the '" & objOrderDetail.Product.Name & "' product.", "", objOrderDetail.Quantity)

            If strQuantity <> Nothing Then
                Try
                    intQuantity = Short.Parse(strQuantity)
                Catch
                    intQuantity = 0
                End Try
                If intQuantity > 0 Then
                    'update the detail lines on the fly
                    objOrderDetail.Quantity = intQuantity
                    LoadOrderDetail(objOrderDetail, objItem)
                    RefreshTotals()
                End If
            End If
        Else
            MessageBox.Show("Please select a detail line to edit.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub RefreshTotals()

        Me.txtCost.Text = pobjOrder.Cost

    End Sub

    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub lvwDetails_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwDetails.DoubleClick

        'EditQuantity()

    End Sub
End Class