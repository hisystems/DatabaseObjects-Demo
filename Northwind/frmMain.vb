Option Strict Off
Option Explicit On 

Imports NorthwindDatabase
Imports System.Windows.Forms

Friend Class frmMain
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
    Public WithEvents cmdProductSearchExtended As System.Windows.Forms.Button
	Public WithEvents wbMain As AxSHDocVw.AxWebBrowser
	Public WithEvents lblGeneralIntroduction As System.Windows.Forms.Label
	Public WithEvents Line1 As System.Windows.Forms.Label
	Public WithEvents lblBack As System.Windows.Forms.Label
	Public WithEvents lblDocumentation As System.Windows.Forms.Label
	Public WithEvents lblWelcome As System.Windows.Forms.Label
    Public WithEvents picContainer As System.Windows.Forms.Panel
	Public WithEvents cmdProductSearch As System.Windows.Forms.Button
	Public WithEvents cmdOrder As System.Windows.Forms.Button
    Public WithEvents fraBorder As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents lblExample As System.Windows.Forms.Label
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Public WithEvents lblDemonstration As System.Windows.Forms.Label
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Public WithEvents lnTitleUnderline As System.Windows.Forms.Label
    Public WithEvents imgLogo As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cmdProductSearchExtended = New System.Windows.Forms.Button
        Me.picContainer = New System.Windows.Forms.Panel
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.imgLogo = New System.Windows.Forms.PictureBox
        Me.lnTitleUnderline = New System.Windows.Forms.Label
        Me.lblDemonstration = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.wbMain = New AxSHDocVw.AxWebBrowser
        Me.lblGeneralIntroduction = New System.Windows.Forms.Label
        Me.Line1 = New System.Windows.Forms.Label
        Me.lblBack = New System.Windows.Forms.Label
        Me.lblDocumentation = New System.Windows.Forms.Label
        Me.lblWelcome = New System.Windows.Forms.Label
        Me.cmdProductSearch = New System.Windows.Forms.Button
        Me.cmdOrder = New System.Windows.Forms.Button
        Me.fraBorder = New System.Windows.Forms.GroupBox
        Me.lblExample = New System.Windows.Forms.Label
        Me.picContainer.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wbMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdProductSearchExtended
        '
        Me.cmdProductSearchExtended.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdProductSearchExtended.BackColor = System.Drawing.SystemColors.Control
        Me.cmdProductSearchExtended.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdProductSearchExtended.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProductSearchExtended.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdProductSearchExtended.Location = New System.Drawing.Point(595, 144)
        Me.cmdProductSearchExtended.Name = "cmdProductSearchExtended"
        Me.cmdProductSearchExtended.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdProductSearchExtended.Size = New System.Drawing.Size(113, 37)
        Me.cmdProductSearchExtended.TabIndex = 4
        Me.cmdProductSearchExtended.Text = "Search Products (Extended)"
        Me.cmdProductSearchExtended.UseVisualStyleBackColor = False
        '
        'picContainer
        '
        Me.picContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.picContainer.Controls.Add(Me.pnlTitle)
        Me.picContainer.Controls.Add(Me.wbMain)
        Me.picContainer.Controls.Add(Me.lblGeneralIntroduction)
        Me.picContainer.Controls.Add(Me.Line1)
        Me.picContainer.Controls.Add(Me.lblBack)
        Me.picContainer.Controls.Add(Me.lblDocumentation)
        Me.picContainer.Controls.Add(Me.lblWelcome)
        Me.picContainer.Cursor = System.Windows.Forms.Cursors.Default
        Me.picContainer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picContainer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picContainer.Location = New System.Drawing.Point(0, 0)
        Me.picContainer.Name = "picContainer"
        Me.picContainer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picContainer.Size = New System.Drawing.Size(572, 507)
        Me.picContainer.TabIndex = 5
        '
        'pnlTitle
        '
        Me.pnlTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTitle.BackColor = System.Drawing.SystemColors.Window
        Me.pnlTitle.Controls.Add(Me.imgLogo)
        Me.pnlTitle.Controls.Add(Me.lnTitleUnderline)
        Me.pnlTitle.Controls.Add(Me.lblDemonstration)
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(572, 64)
        Me.pnlTitle.TabIndex = 22
        '
        'imgLogo
        '
        Me.imgLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgLogo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.imgLogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgLogo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imgLogo.Image = CType(resources.GetObject("imgLogo.Image"), System.Drawing.Image)
        Me.imgLogo.Location = New System.Drawing.Point(508, 0)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(61, 62)
        Me.imgLogo.TabIndex = 24
        Me.imgLogo.TabStop = False
        '
        'lnTitleUnderline
        '
        Me.lnTitleUnderline.BackColor = System.Drawing.SystemColors.WindowText
        Me.lnTitleUnderline.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnTitleUnderline.Location = New System.Drawing.Point(16, 40)
        Me.lnTitleUnderline.Name = "lnTitleUnderline"
        Me.lnTitleUnderline.Size = New System.Drawing.Size(329, 1)
        Me.lnTitleUnderline.TabIndex = 23
        '
        'lblDemonstration
        '
        Me.lblDemonstration.BackColor = System.Drawing.Color.White
        Me.lblDemonstration.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDemonstration.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDemonstration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblDemonstration.Location = New System.Drawing.Point(248, 40)
        Me.lblDemonstration.Name = "lblDemonstration"
        Me.lblDemonstration.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDemonstration.Size = New System.Drawing.Size(105, 17)
        Me.lblDemonstration.TabIndex = 22
        Me.lblDemonstration.Text = "Demonstration"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitle.Location = New System.Drawing.Point(12, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitle.Size = New System.Drawing.Size(357, 37)
        Me.lblTitle.TabIndex = 21
        Me.lblTitle.Text = "Database Objects .NET"
        '
        'wbMain
        '
        Me.wbMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wbMain.Enabled = True
        Me.wbMain.Location = New System.Drawing.Point(1, 96)
        Me.wbMain.OcxState = CType(resources.GetObject("wbMain.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wbMain.Size = New System.Drawing.Size(572, 412)
        Me.wbMain.TabIndex = 11
        '
        'lblGeneralIntroduction
        '
        Me.lblGeneralIntroduction.BackColor = System.Drawing.Color.Transparent
        Me.lblGeneralIntroduction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblGeneralIntroduction.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneralIntroduction.ForeColor = System.Drawing.Color.Blue
        Me.lblGeneralIntroduction.Location = New System.Drawing.Point(158, 72)
        Me.lblGeneralIntroduction.Name = "lblGeneralIntroduction"
        Me.lblGeneralIntroduction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblGeneralIntroduction.Size = New System.Drawing.Size(76, 17)
        Me.lblGeneralIntroduction.TabIndex = 9
        Me.lblGeneralIntroduction.Text = "Quick Start"
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Line1.Location = New System.Drawing.Point(72, 68)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(1, 20)
        Me.Line1.TabIndex = 15
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBack.ForeColor = System.Drawing.Color.Blue
        Me.lblBack.Location = New System.Drawing.Point(12, 72)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBack.Size = New System.Drawing.Size(57, 17)
        Me.lblBack.TabIndex = 7
        Me.lblBack.Text = "< Back"
        '
        'lblDocumentation
        '
        Me.lblDocumentation.BackColor = System.Drawing.Color.Transparent
        Me.lblDocumentation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDocumentation.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumentation.ForeColor = System.Drawing.Color.Blue
        Me.lblDocumentation.Location = New System.Drawing.Point(240, 72)
        Me.lblDocumentation.Name = "lblDocumentation"
        Me.lblDocumentation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDocumentation.Size = New System.Drawing.Size(114, 17)
        Me.lblDocumentation.TabIndex = 10
        Me.lblDocumentation.Text = "Documentation"
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblWelcome.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Blue
        Me.lblWelcome.Location = New System.Drawing.Point(88, 72)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWelcome.Size = New System.Drawing.Size(64, 17)
        Me.lblWelcome.TabIndex = 8
        Me.lblWelcome.Text = "Welcome"
        '
        'cmdProductSearch
        '
        Me.cmdProductSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdProductSearch.BackColor = System.Drawing.SystemColors.Control
        Me.cmdProductSearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdProductSearch.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProductSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdProductSearch.Location = New System.Drawing.Point(595, 96)
        Me.cmdProductSearch.Name = "cmdProductSearch"
        Me.cmdProductSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdProductSearch.Size = New System.Drawing.Size(113, 33)
        Me.cmdProductSearch.TabIndex = 3
        Me.cmdProductSearch.Text = "Search Products"
        Me.cmdProductSearch.UseVisualStyleBackColor = False
        '
        'cmdOrder
        '
        Me.cmdOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOrder.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOrder.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOrder.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOrder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOrder.Location = New System.Drawing.Point(594, 196)
        Me.cmdOrder.Name = "cmdOrder"
        Me.cmdOrder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOrder.Size = New System.Drawing.Size(113, 33)
        Me.cmdOrder.TabIndex = 2
        Me.cmdOrder.Text = "View An Order"
        Me.cmdOrder.UseVisualStyleBackColor = False
        '
        'fraBorder
        '
        Me.fraBorder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fraBorder.BackColor = System.Drawing.SystemColors.Control
        Me.fraBorder.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraBorder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraBorder.Location = New System.Drawing.Point(549, -20)
        Me.fraBorder.Name = "fraBorder"
        Me.fraBorder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraBorder.Size = New System.Drawing.Size(26, 533)
        Me.fraBorder.TabIndex = 8
        Me.fraBorder.TabStop = False
        '
        'lblExample
        '
        Me.lblExample.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblExample.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExample.Location = New System.Drawing.Point(596, 65)
        Me.lblExample.Name = "lblExample"
        Me.lblExample.Size = New System.Drawing.Size(112, 20)
        Me.lblExample.TabIndex = 9
        Me.lblExample.Text = "Examples"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(725, 507)
        Me.Controls.Add(Me.lblExample)
        Me.Controls.Add(Me.cmdProductSearchExtended)
        Me.Controls.Add(Me.picContainer)
        Me.Controls.Add(Me.cmdProductSearch)
        Me.Controls.Add(Me.cmdOrder)
        Me.Controls.Add(Me.fraBorder)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Objects .NET Demonstration"
        Me.picContainer.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wbMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private Sub frmMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        lblWelcome_Click(lblWelcome, New System.EventArgs)

    End Sub

    Private Sub cmdOrder_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOrder.Click

        Dim frmOrder As frmOrder = New frmOrder

        frmOrder.ShowDialog(Me)

    End Sub

    Private Sub cmdProductSearch_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdProductSearch.Click

        Dim frmProductSearch As frmProductSearch = New frmProductSearch

        frmProductSearch.ShowDialog(Me)

    End Sub

    Private Sub cmdProductSearchExtended_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdProductSearchExtended.Click

        Dim frmProductSearchExtended As frmProductSearchExtended = New frmProductSearchExtended

        frmProductSearchExtended.ShowDialog(Me)

    End Sub

    Private Sub lblBack_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblBack.Click

        Me.wbMain.GoBack()

    End Sub

    Private Sub lblDocumentation_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblDocumentation.Click

        Me.wbMain.Navigate("http://www.hisystems.com.au/databaseobjects/documentation_net/")

    End Sub

    Private Sub lblGeneralIntroduction_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblGeneralIntroduction.Click

        Me.wbMain.Navigate("http://www.hisystems.com.au/databaseobjects/DatabaseObjects_QuickStart_net.htm")

    End Sub

    Private Sub lblWelcome_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblWelcome.Click

        Me.wbMain.Navigate(Application.StartupPath & "\welcome.html")

    End Sub

    Private Sub wbMain_CommandStateChange(ByVal eventSender As System.Object, ByVal eventArgs As AxSHDocVw.DWebBrowserEvents2_CommandStateChangeEvent) Handles wbMain.CommandStateChange

        If eventArgs.command = SHDocVw.CommandStateChangeConstants.CSC_NAVIGATEBACK Then
            Me.lblBack.Enabled = eventArgs.enable
        End If

    End Sub

    Private Sub wbMain_DocumentComplete(ByVal eventSender As System.Object, ByVal eventArgs As AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEvent) Handles wbMain.DocumentComplete

        Me.wbMain.Document.body.Style.borderstyle = "none"

    End Sub

End Class