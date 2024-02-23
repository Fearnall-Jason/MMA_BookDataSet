<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tbMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolbar = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnTileHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnTileVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutThisApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.btnCustomers = New System.Windows.Forms.ToolStripButton()
        Me.btnProducts = New System.Windows.Forms.ToolStripButton()
        Me.sbMain = New System.Windows.Forms.StatusStrip()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsTitle = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tbMain.SuspendLayout()
        Me.tsMain.SuspendLayout()
        Me.sbMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbMain
        '
        Me.tbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.WindowToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.tbMain.Location = New System.Drawing.Point(0, 0)
        Me.tbMain.Name = "tbMain"
        Me.tbMain.Size = New System.Drawing.Size(914, 24)
        Me.tbMain.TabIndex = 0
        Me.tbMain.Text = "tbMain"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuToolbar})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'mnuToolbar
        '
        Me.mnuToolbar.Checked = True
        Me.mnuToolbar.CheckOnClick = True
        Me.mnuToolbar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuToolbar.Name = "mnuToolbar"
        Me.mnuToolbar.Size = New System.Drawing.Size(113, 22)
        Me.mnuToolbar.Text = "Toolbar"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCascade, Me.btnTileHorizontal, Me.btnTileVertical})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'btnCascade
        '
        Me.btnCascade.Name = "btnCascade"
        Me.btnCascade.Size = New System.Drawing.Size(159, 22)
        Me.btnCascade.Text = "Cascade"
        '
        'btnTileHorizontal
        '
        Me.btnTileHorizontal.Name = "btnTileHorizontal"
        Me.btnTileHorizontal.Size = New System.Drawing.Size(159, 22)
        Me.btnTileHorizontal.Text = "Tile Horizontally"
        '
        'btnTileVertical
        '
        Me.btnTileVertical.Name = "btnTileVertical"
        Me.btnTileVertical.Size = New System.Drawing.Size(159, 22)
        Me.btnTileVertical.Text = "Tile Vertially"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutThisApplicationToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutThisApplicationToolStripMenuItem
        '
        Me.AboutThisApplicationToolStripMenuItem.Name = "AboutThisApplicationToolStripMenuItem"
        Me.AboutThisApplicationToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AboutThisApplicationToolStripMenuItem.Text = "About This Application"
        '
        'tsMain
        '
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCustomers, Me.btnProducts})
        Me.tsMain.Location = New System.Drawing.Point(0, 24)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(914, 25)
        Me.tsMain.TabIndex = 1
        Me.tsMain.Text = "tsMain"
        '
        'btnCustomers
        '
        Me.btnCustomers.Image = CType(resources.GetObject("btnCustomers.Image"), System.Drawing.Image)
        Me.btnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(84, 22)
        Me.btnCustomers.Text = "Customers"
        '
        'btnProducts
        '
        Me.btnProducts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnProducts.Image = CType(resources.GetObject("btnProducts.Image"), System.Drawing.Image)
        Me.btnProducts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(58, 22)
        Me.btnProducts.Text = "Products"
        '
        'sbMain
        '
        Me.sbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDate, Me.tsTitle, Me.lblTime})
        Me.sbMain.Location = New System.Drawing.Point(0, 550)
        Me.sbMain.Name = "sbMain"
        Me.sbMain.Size = New System.Drawing.Size(914, 24)
        Me.sbMain.TabIndex = 3
        Me.sbMain.Text = "StatusStrip1"
        '
        'lblDate
        '
        Me.lblDate.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblDate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(35, 19)
        Me.lblDate.Text = "Date"
        '
        'tsTitle
        '
        Me.tsTitle.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsTitle.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.tsTitle.Name = "tsTitle"
        Me.tsTitle.Size = New System.Drawing.Size(827, 19)
        Me.tsTitle.Spring = True
        Me.tsTitle.Text = "Welcome to the Bookstore!"
        '
        'lblTime
        '
        Me.lblTime.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblTime.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(37, 19)
        Me.lblTime.Text = "Time"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 574)
        Me.Controls.Add(Me.sbMain)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.tbMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.tbMain
        Me.Name = "frmMain"
        Me.Text = "Buffalo State Bookstore"
        Me.tbMain.ResumeLayout(False)
        Me.tbMain.PerformLayout()
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.sbMain.ResumeLayout(False)
        Me.sbMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsMain As ToolStrip
    Friend WithEvents btnCustomers As ToolStripButton
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuToolbar As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCascade As ToolStripMenuItem
    Friend WithEvents btnTileHorizontal As ToolStripMenuItem
    Friend WithEvents btnTileVertical As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutThisApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnProducts As ToolStripButton
    Friend WithEvents sbMain As StatusStrip
    Friend WithEvents lblDate As ToolStripStatusLabel
    Friend WithEvents tsTitle As ToolStripStatusLabel
    Friend WithEvents lblTime As ToolStripStatusLabel
End Class
