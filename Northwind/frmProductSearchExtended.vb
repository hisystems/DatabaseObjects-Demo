Option Strict Off
Option Explicit On 

Imports NorthwindDatabase

Friend Class frmProductSearchExtended
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
    Public WithEvents cmdSearch As System.Windows.Forms.Button
	Public WithEvents cboOnOrder As System.Windows.Forms.ComboBox
	Public WithEvents cboDiscontinued As System.Windows.Forms.ComboBox
	Public WithEvents cboInStock As System.Windows.Forms.ComboBox
	Public WithEvents txtProductName As System.Windows.Forms.TextBox
	Public WithEvents lblDiscontinued As System.Windows.Forms.Label
	Public WithEvents lblOnOrder As System.Windows.Forms.Label
	Public WithEvents lblInStock As System.Windows.Forms.Label
	Public WithEvents lblProductName As System.Windows.Forms.Label
	Public WithEvents fraSearch As System.Windows.Forms.GroupBox
    Public WithEvents cmdClose As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents lvwProducts As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.cboOnOrder = New System.Windows.Forms.ComboBox
        Me.fraSearch = New System.Windows.Forms.GroupBox
        Me.cboDiscontinued = New System.Windows.Forms.ComboBox
        Me.cboInStock = New System.Windows.Forms.ComboBox
        Me.txtProductName = New System.Windows.Forms.TextBox
        Me.lblDiscontinued = New System.Windows.Forms.Label
        Me.lblOnOrder = New System.Windows.Forms.Label
        Me.lblInStock = New System.Windows.Forms.Label
        Me.lblProductName = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.lvwProducts = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.fraSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSearch.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSearch.Location = New System.Drawing.Point(536, 108)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSearch.Size = New System.Drawing.Size(93, 24)
        Me.cmdSearch.TabIndex = 8
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'cboOnOrder
        '
        Me.cboOnOrder.BackColor = System.Drawing.SystemColors.Window
        Me.cboOnOrder.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboOnOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOnOrder.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOnOrder.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboOnOrder.Location = New System.Drawing.Point(116, 80)
        Me.cboOnOrder.Name = "cboOnOrder"
        Me.cboOnOrder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboOnOrder.Size = New System.Drawing.Size(145, 22)
        Me.cboOnOrder.TabIndex = 5
        '
        'fraSearch
        '
        Me.fraSearch.BackColor = System.Drawing.SystemColors.Control
        Me.fraSearch.Controls.Add(Me.cboDiscontinued)
        Me.fraSearch.Controls.Add(Me.cboInStock)
        Me.fraSearch.Controls.Add(Me.txtProductName)
        Me.fraSearch.Controls.Add(Me.lblDiscontinued)
        Me.fraSearch.Controls.Add(Me.lblOnOrder)
        Me.fraSearch.Controls.Add(Me.lblInStock)
        Me.fraSearch.Controls.Add(Me.lblProductName)
        Me.fraSearch.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraSearch.Location = New System.Drawing.Point(12, 8)
        Me.fraSearch.Name = "fraSearch"
        Me.fraSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraSearch.Size = New System.Drawing.Size(628, 137)
        Me.fraSearch.TabIndex = 0
        Me.fraSearch.TabStop = False
        Me.fraSearch.Text = "Search Criteria"
        '
        'cboDiscontinued
        '
        Me.cboDiscontinued.BackColor = System.Drawing.SystemColors.Window
        Me.cboDiscontinued.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDiscontinued.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiscontinued.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiscontinued.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDiscontinued.Location = New System.Drawing.Point(104, 96)
        Me.cboDiscontinued.Name = "cboDiscontinued"
        Me.cboDiscontinued.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboDiscontinued.Size = New System.Drawing.Size(144, 22)
        Me.cboDiscontinued.TabIndex = 7
        '
        'cboInStock
        '
        Me.cboInStock.BackColor = System.Drawing.SystemColors.Window
        Me.cboInStock.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboInStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInStock.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboInStock.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboInStock.Location = New System.Drawing.Point(104, 48)
        Me.cboInStock.Name = "cboInStock"
        Me.cboInStock.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboInStock.Size = New System.Drawing.Size(145, 22)
        Me.cboInStock.TabIndex = 3
        '
        'txtProductName
        '
        Me.txtProductName.AcceptsReturn = True
        Me.txtProductName.BackColor = System.Drawing.SystemColors.Window
        Me.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtProductName.Location = New System.Drawing.Point(104, 24)
        Me.txtProductName.MaxLength = 0
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtProductName.Size = New System.Drawing.Size(145, 21)
        Me.txtProductName.TabIndex = 1
        '
        'lblDiscontinued
        '
        Me.lblDiscontinued.BackColor = System.Drawing.SystemColors.Control
        Me.lblDiscontinued.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDiscontinued.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscontinued.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDiscontinued.Location = New System.Drawing.Point(16, 100)
        Me.lblDiscontinued.Name = "lblDiscontinued"
        Me.lblDiscontinued.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDiscontinued.Size = New System.Drawing.Size(77, 13)
        Me.lblDiscontinued.TabIndex = 6
        Me.lblDiscontinued.Text = "Discontinued:"
        '
        'lblOnOrder
        '
        Me.lblOnOrder.BackColor = System.Drawing.SystemColors.Control
        Me.lblOnOrder.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOnOrder.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnOrder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOnOrder.Location = New System.Drawing.Point(16, 76)
        Me.lblOnOrder.Name = "lblOnOrder"
        Me.lblOnOrder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOnOrder.Size = New System.Drawing.Size(77, 13)
        Me.lblOnOrder.TabIndex = 4
        Me.lblOnOrder.Text = "On Order:"
        '
        'lblInStock
        '
        Me.lblInStock.BackColor = System.Drawing.SystemColors.Control
        Me.lblInStock.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblInStock.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInStock.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblInStock.Location = New System.Drawing.Point(16, 52)
        Me.lblInStock.Name = "lblInStock"
        Me.lblInStock.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInStock.Size = New System.Drawing.Size(77, 13)
        Me.lblInStock.TabIndex = 2
        Me.lblInStock.Text = "In Stock:"
        '
        'lblProductName
        '
        Me.lblProductName.BackColor = System.Drawing.SystemColors.Control
        Me.lblProductName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblProductName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblProductName.Location = New System.Drawing.Point(16, 28)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblProductName.Size = New System.Drawing.Size(81, 13)
        Me.lblProductName.TabIndex = 0
        Me.lblProductName.Text = "Product Name:"
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClose.Location = New System.Drawing.Point(552, 476)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(89, 24)
        Me.cmdClose.TabIndex = 10
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'lvwProducts
        '
        Me.lvwProducts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvwProducts.Location = New System.Drawing.Point(16, 156)
        Me.lvwProducts.Name = "lvwProducts"
        Me.lvwProducts.Size = New System.Drawing.Size(624, 312)
        Me.lvwProducts.TabIndex = 9
        Me.lvwProducts.UseCompatibleStateImageBehavior = False
        Me.lvwProducts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Unit Price"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 70
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Quantity Per Unit"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 90
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "In Stock"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "On Order"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Discontinued"
        Me.ColumnHeader7.Width = 75
        '
        'frmProductSearchExtended
        '
        Me.AcceptButton = Me.cmdSearch
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(646, 506)
        Me.Controls.Add(Me.lvwProducts)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cboOnOrder)
        Me.Controls.Add(Me.fraSearch)
        Me.Controls.Add(Me.cmdClose)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductSearchExtended"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product Search Extended"
        Me.fraSearch.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private Sub LoadProducts(ByVal objProducts As Generic.IList(Of Product))

        Dim objProduct As Product

        With Me.lvwProducts.Items
            .Clear()
            For Each objProduct In objProducts
                With .Add(objProduct.Name)
                    .SubItems.Add(objProduct.UnitPrice())
                    .SubItems.Add(objProduct.QuantityPerUnit)
                    .SubItems.Add(ConvertBooleanToYesNo(objProduct.IsInStock))
                    .SubItems.Add(ConvertBooleanToYesNo(objProduct.IsOnOrder))
                    .SubItems.Add(ConvertBooleanToYesNo(objProduct.Discontinued))
                End With
            Next
        End With

    End Sub

    Private Sub cmdSearch_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSearch.Click

        Dim objSearch As New ProductSearch

        objSearch.Name = Me.txtProductName.Text

        If Me.cboInStock.Text <> Nothing Then
            objSearch.InStock = ConvertYesNoToBoolean(Me.cboInStock.Text)
        End If

        If Me.cboOnOrder.Text <> Nothing Then
            objSearch.OnOrder = ConvertYesNoToBoolean(Me.cboOnOrder.Text)
        End If

        If Me.cboDiscontinued.Text <> Nothing Then
            objSearch.Discontinued = ConvertYesNoToBoolean(Me.cboDiscontinued.Text)
        End If

        'The Search function returns a collection of Product objects that match the search criteria
        Dim colProducts As Generic.IList(Of Product) = objSearch.Search

        If colProducts.Count() = 0 Then
            Me.lvwProducts.Items.Clear()
            MessageBox.Show("There were no products that matched the specified criteria.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            LoadProducts(colProducts)
        End If

    End Sub

    Private Sub LoadYesNoComboBox(ByVal cboBox As System.Windows.Forms.ComboBox)

        With cboBox
            .Items.Add("")
            .Items.Add(ConvertBooleanToYesNo(True))
            .Items.Add(ConvertBooleanToYesNo(False))
            .SelectedIndex = 0
        End With

    End Sub

    Private Function ConvertBooleanToYesNo(ByVal bValue As Boolean) As String

        If bValue Then
            ConvertBooleanToYesNo = "Yes"
        Else
            ConvertBooleanToYesNo = "No"
        End If

    End Function

    Private Function ConvertYesNoToBoolean(ByVal strText As String) As Boolean

        If String.Compare(strText, "yes", ignoreCase:=True) = 0 Then
            ConvertYesNoToBoolean = True
        Else
            ConvertYesNoToBoolean = False
        End If

    End Function

    Private Sub frmProductSearchExtended_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        LoadYesNoComboBox(Me.cboInStock)
        LoadYesNoComboBox(Me.cboOnOrder)
        LoadYesNoComboBox(Me.cboDiscontinued)

    End Sub

    Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click

        Me.Close()

    End Sub

End Class