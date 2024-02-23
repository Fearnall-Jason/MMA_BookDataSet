''' <summary>
''' This main class holds the button events that are involved in the main form.
''' </summary>
Public Class frmMain
    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click                             'When customer button pressed, display form
        frmCustomers.MdiParent = Me
        frmCustomers.Show()
    End Sub
    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click                               'when products button pressed, display form
        frmProducts.MdiParent = Me
        frmProducts.Show()
    End Sub

    Private Sub mnuToolbar_Click(sender As Object, e As EventArgs) Handles mnuToolbar.Click                                 'Toolbar display option
        tsMain.Visible = mnuToolbar.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnCascade.Click                   'option to cascade windows
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileHorizontallyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnTileHorizontal.Click   'option to tile widows horizontally
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub TileVertiallyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnTileVertical.Click        'option to tile windows vertically
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        sbMain.Items("lblDate").Text = Today.ToShortDateString                                                              'set date and time when form loads
        sbMain.Items("lblTime").Text = Now.ToLongTimeString
    End Sub
End Class
