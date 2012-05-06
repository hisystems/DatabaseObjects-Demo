Namespace NorthwindImport

    Friend Class OrderDetailsImport
        Inherits DatabaseTableImport

        Public Sub New(database As DatabaseObjects.Database)

            MyBase.New(database, "OrderDetails.csv")

        End Sub

        Protected Overrides Function TableSchema() As DatabaseObjects.SQL.SQLCreateTable

            Dim orderDetailsTable As New DatabaseObjects.SQL.SQLCreateTable
            orderDetailsTable.Name = "OrderDetails"
            orderDetailsTable.Fields.Add("OrderID", DatabaseObjects.SQL.DataType.Integer)
            orderDetailsTable.Fields.Add("ProductID", DatabaseObjects.SQL.DataType.Integer)
            orderDetailsTable.Fields.Add("UnitPrice", DatabaseObjects.SQL.DataType.Money)
            orderDetailsTable.Fields.Add("Quantity", DatabaseObjects.SQL.DataType.SmallInteger)
            orderDetailsTable.Fields.Add("Discount", DatabaseObjects.SQL.DataType.Real)

            Return orderDetailsTable

        End Function

        Protected Overrides Sub TransformRecord(fieldValues As DatabaseObjects.SQL.SQLFieldValues)

            'Because the OrderID starts at 1 - not 10330
            fieldValues("OrderID").Value = CType(fieldValues("OrderID").Value, Integer) - 10247

        End Sub

        Protected Overrides Function CreateIndexes() As DatabaseObjects.SQL.ISQLStatement()

            Return New DatabaseObjects.SQL.ISQLStatement() _
            { _
                New DatabaseObjects.SQL.SQLCreateIndex("PrimaryKey", "OrderDetails", New String() {"OrderID", "ProductID"}, bIsUnique:=True), _
                New DatabaseObjects.SQL.SQLCreateIndex("OrderID", "OrderDetails", New String() {"OrderID"}), _
                New DatabaseObjects.SQL.SQLCreateIndex("ProductID", "OrderDetails", New String() {"ProductID"}) _
            }

        End Function

    End Class

End Namespace
