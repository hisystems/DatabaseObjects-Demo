Namespace NorthwindImport

    Friend Class CustomersImport
        Inherits DatabaseTableImport

        Public Sub New(database As DatabaseObjects.Database)

            MyBase.New(database, "Customers.csv")

        End Sub

        Protected Overrides Function TableSchema() As DatabaseObjects.SQL.SQLCreateTable

            Dim customersTable As New DatabaseObjects.SQL.SQLCreateTable
            customersTable.Name = "Customers"
            customersTable.Fields.Add("CustomerID", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 5).KeyType = DatabaseObjects.SQL.KeyType.Primary
            customersTable.Fields.Add("CompanyName", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 40)
            customersTable.Fields.Add("ContactName", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 30)
            customersTable.Fields.Add("ContactTitle", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 30)
            customersTable.Fields.Add("Address", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 60)
            customersTable.Fields.Add("City", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 15)
            customersTable.Fields.Add("Region", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 15)
            customersTable.Fields.Add("PostalCode", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 10)
            customersTable.Fields.Add("Country", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 15)
            customersTable.Fields.Add("Phone", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 24)
            customersTable.Fields.Add("Fax", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 24)

            Return customersTable

        End Function

        Protected Overrides Function CreateIndexes() As DatabaseObjects.SQL.ISQLStatement()

            Return New DatabaseObjects.SQL.ISQLStatement() _
            { _
                New DatabaseObjects.SQL.SQLCreateIndex("Region", "Customers", New String() {"Region"}), _
                New DatabaseObjects.SQL.SQLCreateIndex("PostalCode", "Customers", New String() {"PostalCode"}), _
                New DatabaseObjects.SQL.SQLCreateIndex("CompanyName", "Customers", New String() {"CompanyName"}), _
                New DatabaseObjects.SQL.SQLCreateIndex("City", "Customers", New String() {"City"}) _
            }

        End Function

    End Class

End Namespace