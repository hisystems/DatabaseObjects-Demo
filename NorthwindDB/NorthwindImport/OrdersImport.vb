Namespace NorthwindImport

    Friend Class OrdersImport
        Inherits DatabaseTableImport

        Public Sub New(database As DatabaseObjects.Database)

            MyBase.New(database, "Orders.csv")

        End Sub

        Protected Overrides Function TableSchema() As DatabaseObjects.SQL.SQLCreateTable

            Dim ordersTable As New DatabaseObjects.SQL.SQLCreateTable
            ordersTable.Name = "Orders"
            With ordersTable.Fields.Add("OrderID", DatabaseObjects.SQL.DataType.Integer)
                .AutoIncrements = True
                .KeyType = DatabaseObjects.SQL.KeyType.Primary
            End With
            ordersTable.Fields.Add("CustomerID", DatabaseObjects.SQL.DataType.VariableCharacter, 5)
            ordersTable.Fields.Add("EmployeeID", DatabaseObjects.SQL.DataType.Integer)
            ordersTable.Fields.Add("OrderDate", DatabaseObjects.SQL.DataType.DateTime)
            ordersTable.Fields.Add("RequiredDate", DatabaseObjects.SQL.DataType.DateTime)
            ordersTable.Fields.Add("ShippedDate", DatabaseObjects.SQL.DataType.DateTime)
            ordersTable.Fields.Add("ShipVia", DatabaseObjects.SQL.DataType.Integer)
            ordersTable.Fields.Add("Freight", DatabaseObjects.SQL.DataType.Money)
            ordersTable.Fields.Add("ShipName", DatabaseObjects.SQL.DataType.VariableCharacter, 40)
            ordersTable.Fields.Add("ShipAddress", DatabaseObjects.SQL.DataType.VariableCharacter, 60)
            ordersTable.Fields.Add("ShipCity", DatabaseObjects.SQL.DataType.VariableCharacter, 15)
            ordersTable.Fields.Add("ShipRegion", DatabaseObjects.SQL.DataType.VariableCharacter, 15)
            ordersTable.Fields.Add("ShipPostalCode", DatabaseObjects.SQL.DataType.VariableCharacter, 10)
            ordersTable.Fields.Add("ShipCountry", DatabaseObjects.SQL.DataType.VariableCharacter, 15)

            Return ordersTable

        End Function

        Protected Overrides Sub TransformRecord(fieldValues As DatabaseObjects.SQL.SQLFieldValues)

            fieldValues.Delete(fieldValues("OrderID"))

        End Sub

        Protected Overrides Function CreateIndexes() As DatabaseObjects.SQL.ISQLStatement()

            Return New DatabaseObjects.SQL.ISQLStatement() _
            { _
                New DatabaseObjects.SQL.SQLCreateIndex("CustomerID", "Orders", New String() {"CustomerID"}), _
                New DatabaseObjects.SQL.SQLCreateIndex("EmployeeID", "Orders", New String() {"EmployeeID"}), _
                New DatabaseObjects.SQL.SQLCreateIndex("OrderDate", "Orders", New String() {"OrderDate"}), _
                New DatabaseObjects.SQL.SQLCreateIndex("ShippedDate", "Orders", New String() {"ShippedDate"}), _
                New DatabaseObjects.SQL.SQLCreateIndex("ShipPostalCode", "Orders", New String() {"ShipPostalCode"}) _
            }

        End Function

    End Class

End Namespace
