
Namespace NorthwindImport

    Friend Class SuppliersImport
        Inherits DatabaseTableImport

        Public Sub New(database As DatabaseObjects.Database)

            MyBase.New(database, "Suppliers.csv")

        End Sub

        Protected Overrides Function TableSchema() As DatabaseObjects.SQL.SQLCreateTable

            Dim suppliersTable As New DatabaseObjects.SQL.SQLCreateTable
            suppliersTable.Name = "Suppliers"
            With suppliersTable.Fields.Add("SupplierID", DatabaseObjects.SQL.DataType.Integer)
                .AutoIncrements = True
                .KeyType = DatabaseObjects.SQL.KeyType.Primary
            End With
            suppliersTable.Fields.Add("CompanyName", DatabaseObjects.SQL.DataType.VariableCharacter, 40)
            suppliersTable.Fields.Add("ContactName", DatabaseObjects.SQL.DataType.VariableCharacter, 30)
            suppliersTable.Fields.Add("ContactTitle", DatabaseObjects.SQL.DataType.VariableCharacter, 30)
            suppliersTable.Fields.Add("Address", DatabaseObjects.SQL.DataType.VariableCharacter, 60)
            suppliersTable.Fields.Add("City", DatabaseObjects.SQL.DataType.VariableCharacter, 15)
            suppliersTable.Fields.Add("Region", DatabaseObjects.SQL.DataType.VariableCharacter, 15)
            suppliersTable.Fields.Add("PostalCode", DatabaseObjects.SQL.DataType.VariableCharacter, 10)
            suppliersTable.Fields.Add("Country", DatabaseObjects.SQL.DataType.VariableCharacter, 15)
            suppliersTable.Fields.Add("Phone", DatabaseObjects.SQL.DataType.VariableCharacter, 24)
            suppliersTable.Fields.Add("Fax", DatabaseObjects.SQL.DataType.VariableCharacter, 24)
            suppliersTable.Fields.Add("HomePage", DatabaseObjects.SQL.DataType.VariableCharacter, 1024)

            Return suppliersTable

        End Function

        Protected Overrides Sub TransformRecord(fieldValues As DatabaseObjects.SQL.SQLFieldValues)

            fieldValues.Delete(fieldValues("SupplierID"))

        End Sub

        Protected Overrides Function CreateIndexes() As DatabaseObjects.SQL.ISQLStatement()

            Return New DatabaseObjects.SQL.ISQLStatement() _
            { _
                New DatabaseObjects.SQL.SQLCreateIndex("CompanyName", "Suppliers", New String() {"CompanyName"}), _
                New DatabaseObjects.SQL.SQLCreateIndex("PostalCode", "Suppliers", New String() {"PostalCode"}) _
            }

        End Function

    End Class

End Namespace