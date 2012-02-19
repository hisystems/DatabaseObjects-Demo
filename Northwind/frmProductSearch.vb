Option Strict Off
Option Explicit On 

Imports NorthwindDatabase

Friend Class frmProductSearch
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
	Public WithEvents cmdSearch As System.Windows.Forms.Button
	Public WithEvents optProductDescription As System.Windows.Forms.RadioButton
	Public WithEvents optProductDescriptionPrefix As System.Windows.Forms.RadioButton
	Public WithEvents picOptionsContainer As System.Windows.Forms.Panel
	Public WithEvents txtSearch As System.Windows.Forms.TextBox
	Public WithEvents fraSearch As System.Windows.Forms.GroupBox
    Public WithEvents cmdClose As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents lvwProducts As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.fraSearch = New System.Windows.Forms.GroupBox
        Me.picOptionsContainer = New System.Windows.Forms.Panel
        Me.optProductDescription = New System.Windows.Forms.RadioButton
        Me.optProductDescriptionPrefix = New System.Windows.Forms.RadioButton
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.cmdClose = New System.Windows.Forms.Button
        Me.lvwProducts = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.fraSearch.SuspendLayout()
        Me.picOptionsContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSearch.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSearch.Location = New System.Drawing.Point(360, 76)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSearch.Size = New System.Drawing.Size(93, 28)
        Me.cmdSearch.TabIndex = 7
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'fraSearch
        '
        Me.fraSearch.BackColor = System.Drawing.SystemColors.Control
        Me.fraSearch.Controls.Add(Me.picOptionsContainer)
        Me.fraSearch.Controls.Add(Me.txtSearch)
        Me.fraSearch.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraSearch.Location = New System.Drawing.Point(12, 8)
        Me.fraSearch.Name = "fraSearch"
        Me.fraSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraSearch.Size = New System.Drawing.Size(457, 109)
        Me.fraSearch.TabIndex = 3
        Me.fraSearch.TabStop = False
        Me.fraSearch.Text = "Search Criteria"
        '
        'picOptionsContainer
        '
        Me.picOptionsContainer.BackColor = System.Drawing.SystemColors.Control
        Me.picOptionsContainer.Controls.Add(Me.optProductDescription)
        Me.picOptionsContainer.Controls.Add(Me.optProductDescriptionPrefix)
        Me.picOptionsContainer.Cursor = System.Windows.Forms.Cursors.Default
        Me.picOptionsContainer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picOptionsContainer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picOptionsContainer.Location = New System.Drawing.Point(16, 56)
        Me.picOptionsContainer.Name = "picOptionsContainer"
        Me.picOptionsContainer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picOptionsContainer.Size = New System.Drawing.Size(285, 41)
        Me.picOptionsContainer.TabIndex = 4
        '
        'optProductDescription
        '
        Me.optProductDescription.BackColor = System.Drawing.SystemColors.Control
        Me.optProductDescription.Cursor = System.Windows.Forms.Cursors.Default
        Me.optProductDescription.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optProductDescription.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optProductDescription.Location = New System.Drawing.Point(4, 24)
        Me.optProductDescription.Name = "optProductDescription"
        Me.optProductDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optProductDescription.Size = New System.Drawing.Size(181, 13)
        Me.optProductDescription.TabIndex = 6
        Me.optProductDescription.TabStop = True
        Me.optProductDescription.Text = "Product Name"
        Me.optProductDescription.UseVisualStyleBackColor = False
        '
        'optProductDescriptionPrefix
        '
        Me.optProductDescriptionPrefix.BackColor = System.Drawing.SystemColors.Control
        Me.optProductDescriptionPrefix.Checked = True
        Me.optProductDescriptionPrefix.Cursor = System.Windows.Forms.Cursors.Default
        Me.optProductDescriptionPrefix.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optProductDescriptionPrefix.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optProductDescriptionPrefix.Location = New System.Drawing.Point(4, 4)
        Me.optProductDescriptionPrefix.Name = "optProductDescriptionPrefix"
        Me.optProductDescriptionPrefix.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optProductDescriptionPrefix.Size = New System.Drawing.Size(185, 13)
        Me.optProductDescriptionPrefix.TabIndex = 5
        Me.optProductDescriptionPrefix.TabStop = True
        Me.optProductDescriptionPrefix.Text = "Product Name Prefix"
        Me.optProductDescriptionPrefix.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.AcceptsReturn = True
        Me.txtSearch.BackColor = System.Drawing.SystemColors.Window
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSearch.Location = New System.Drawing.Point(20, 24)
        Me.txtSearch.MaxLength = 0
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSearch.Size = New System.Drawing.Size(421, 21)
        Me.txtSearch.TabIndex = 0
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClose.Location = New System.Drawing.Point(380, 476)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(89, 24)
        Me.cmdClose.TabIndex = 9
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'lvwProducts
        '
        Me.lvwProducts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvwProducts.FullRowSelect = True
        Me.lvwProducts.Location = New System.Drawing.Point(16, 124)
        Me.lvwProducts.Name = "lvwProducts"
        Me.lvwProducts.Size = New System.Drawing.Size(452, 344)
        Me.lvwProducts.TabIndex = 8
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
        Me.ColumnHeader4.Width = 100
        '
        'frmProductSearch
        '
        Me.AcceptButton = Me.cmdSearch
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(482, 506)
        Me.Controls.Add(Me.lvwProducts)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.fraSearch)
        Me.Controls.Add(Me.cmdClose)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductSearch"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product Search"
        Me.fraSearch.ResumeLayout(False)
        Me.picOptionsContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private Sub LoadProducts(ByVal objProducts As Generic.IList(Of Product))

        With Me.lvwProducts.Items
            .Clear()
            For Each objProduct As Product In objProducts
                With .Add(objProduct.Name)
                    .SubItems.Add(objProduct.UnitPrice)
                    .SubItems.Add(objProduct.QuantityPerUnit)
                End With
            Next
        End With

    End Sub

    Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click

        Me.Close()

    End Sub

    Private Sub cmdSearch_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSearch.Click

        Dim eSearchType As Products.SearchType

        If Me.optProductDescriptionPrefix.Checked Then
            eSearchType = Products.SearchType.NamePrefix
        Else
            eSearchType = Products.SearchType.Name
        End If

        'The Search function returns a collection of Product objects that match the search criteria
        Dim objProducts As Generic.IList(Of Product) = NorthwindDB.Products.Search(Me.txtSearch.Text, eSearchType)

        If objProducts.Count() = 0 Then
            Me.lvwProducts.Items.Clear()
            MessageBox.Show("There were no products that matched the specified criteria.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            LoadProducts(objProducts)
        End If

    End Sub

End Class