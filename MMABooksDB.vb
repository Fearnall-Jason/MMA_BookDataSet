Imports System.Data.SqlClient
''' <summary>
''' Class to create connection to database
''' </summary>
Public Class MMABooksDB

    Public Shared Function GetConnection() As SqlConnection                              'Function to add connection to database
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;" &
        "AttachDbFilename=|DataDirectory|\MMABooks.mdf;Integrated Security=True"         'set address to variable and return connection
        Return New SqlConnection(connectionString)
    End Function

End Class
