Imports System.Data.SqlClient
''' <summary>
''' Customer DB class holds a function to load customer
''' </summary>
Public Class CustomerDB

    Public Shared Function GetCustomer(customerId As Integer) As Customer

        Dim customer As New Customer
        Dim connection As SqlConnection = MMABooksDB.GetConnection
        Dim selectStatement As String = "SELECT CustomerID, Name, Address, City, State, ZipCode " &   'set working variables and query statement
            "FROM Customers " &
            "WHERE CustomerID = @CustomerID"
        Dim selectCommand As New SqlCommand(selectStatement, connection)                              'create new sql command
        selectCommand.Parameters.AddWithValue("@CustomerID", customerId)

        Try
            connection.Open()
            Dim reader As SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)      'open connection and find tuple
            If reader.Read Then
                customer.CustomerID = CInt(reader("CustomerID"))
                customer.Name = reader("Name").ToString
                customer.Address = reader("Address").ToString                                         'if found set user input to display
                customer.City = reader("City").ToString
                customer.State = reader("State").ToString
                customer.Zipcode = reader("ZipCode").ToString
            Else
                customer = Nothing                                                                    'if not found set to nothing, close reader
            End If
            reader.Close()
        Catch ex As SqlException
            Throw ex
        Finally
            connection.Close()
        End Try
        Return customer
    End Function

End Class
