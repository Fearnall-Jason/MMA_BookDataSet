Imports System.Data.SqlClient
''' <summary>
''' This Class handles the Customer form event handlers and functions to display customers
''' </summary>
Public Class frmCustomers

    Dim customer As Customer

    Private Sub SaveItem_Click_1(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click  'save changes to database
        Me.Validate()                                                                                               'validate and update DB
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MMABooksDataSet)
    End Sub

    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StatesTableAdapter.Fill(Me.MMABooksDataSet.States)                                                       'load states and set index
        cboState.SelectedIndex = -1
        Me.CustomersTableAdapter.Fill(Me.MMABooksDataSet.Customers)                                                 '***NOTE: I could not eliminate this line and
    End Sub                                                                                                         '***still have the DB save. Even with editing event handler!

    Private Sub btnGetCustomer_Click(sender As Object, e As EventArgs) Handles btnGetCustomer.Click

        If Validator.IsPresent(txtCustomerID) AndAlso                                                               'validate input
           Validator.IsInt32(txtCustomerID) Then
            Dim customerID As Integer = CInt(txtCustomerID.Text)                                                    'set input into variable and call function
            Me.GetCustomer(customerID)
            If customer Is Nothing Then
                MessageBox.Show("No customer found with this ID. " &                                                'show error if customer not found, and clear controls
                    "Please try again.", "Customer Not Found")
                Me.ClearControls()
            Else
                Me.DisplayCustomer()                                                                                'call display function and enable invoice button
                btnViewInvoices.Enabled = True
            End If
        End If
    End Sub

    Private Sub GetCustomer(ByVal customerID As Integer)
        Try
            customer = CustomerDB.GetCustomer(customerID)                                                           'find customer and set to object variable
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)                                                        'show error if failed execution
        End Try
    End Sub
    Private Sub ClearControls()
        txtCustomerID.Text = ""
        txtName.Text = ""
        txtAddress.Text = ""                                                                                        'clear all form text boxes
        txtCity.Text = ""
        cboState.Text = ""
        txtZipCode.Text = ""
        txtCustomerID.Select()
    End Sub

    Private Sub DisplayCustomer()
        txtDisplayCustomerId.Text = customer.CustomerID
        txtName.Text = customer.Name
        txtAddress.Text = customer.Address                                                                          'set textboxes to customer infor
        txtCity.Text = customer.City
        cboState.Text = customer.State
        txtZipCode.Text = customer.ZipCode
    End Sub

    Private Sub btnViewInvoices_Click(sender As Object, e As EventArgs) Handles btnViewInvoices.Click
        frmViewInvoices.MdiParent = frmMain
        frmViewInvoices.Show()                                                                                      'launch invoices form
    End Sub

End Class


