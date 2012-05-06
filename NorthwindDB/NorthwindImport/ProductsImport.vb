
Namespace NorthwindImport

    Friend Class ProductsImport
        Inherits DatabaseTableImport

        Public Sub New(database As DatabaseObjects.Database)

            MyBase.New(database, "Products.csv")

        End Sub

        Protected Overrides Function TableSchema() As DatabaseObjects.SQL.SQLCreateTable

            Dim productsTable As New DatabaseObjects.SQL.SQLCreateTable
            productsTable.Name = "Products"
            With productsTable.Fields.Add("ProductID", DatabaseObjects.SQL.DataType.Integer)
                .AutoIncrements = True
                .KeyType = DatabaseObjects.SQL.KeyType.Primary
            End With
            productsTable.Fields.Add("ProductName", DatabaseObjects.SQL.DataType.VariableCharacter, 40)
            productsTable.Fields.Add("SupplierID", DatabaseObjects.SQL.DataType.Integer)
            productsTable.Fields.Add("CategoryID", DatabaseObjects.SQL.DataType.Integer)
            productsTable.Fields.Add("QuantityPerUnit", DatabaseObjects.SQL.DataType.VariableCharacter, 20)
            productsTable.Fields.Add("UnitPrice", DatabaseObjects.SQL.DataType.Money)
            productsTable.Fields.Add("UnitsInStock", DatabaseObjects.SQL.DataType.SmallInteger)
            productsTable.Fields.Add("UnitsOnOrder", DatabaseObjects.SQL.DataType.SmallInteger)
            productsTable.Fields.Add("ReorderLevel", DatabaseObjects.SQL.DataType.SmallInteger)
            productsTable.Fields.Add("Discontinued", DatabaseObjects.SQL.DataType.Boolean)

            Return productsTable

        End Function

        Protected Overrides Sub TransformRecord(fieldValues As DatabaseObjects.SQL.SQLFieldValues)

            fieldValues.Delete(fieldValues("ProductID"))

        End Sub

        Protected Overrides Function CreateIndexes() As DatabaseObjects.SQL.ISQLStatement()

            Return New DatabaseObjects.SQL.ISQLStatement() _
            { _
                New DatabaseObjects.SQL.SQLCreateIndex("CategoryID", "Products", New String() {"CategoryID"}), _
                New DatabaseObjects.SQL.SQLCreateIndex("ProductName", "Products", New String() {"ProductName"}), _
                New DatabaseObjects.SQL.SQLCreateIndex("SupplierID", "Products", New String() {"SupplierID"}) _
            }

        End Function

    End Class

End Namespace
