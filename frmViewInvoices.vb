''' <summary>
''' This class shows all invoices for a customer
''' </summary>
Public Class frmViewInvoices
    Private Sub InvoicesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles InvoicesBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.InvoicesBindingSource.EndEdit()                                                  'update Database
            Me.TableAdapterManager.UpdateAll(Me.MMABooksDataSet)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmViewInvoices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InvoicesTableAdapter.Fill(Me.MMABooksDataSet.Invoices)                            'load data
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles btnInvoicesByDate.Click
        Try
            Me.InvoicesTableAdapter.FillBy(Me.MMABooksDataSet.Invoices)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class