
Namespace NorthwindImport

    Friend Class ShippersImport
        Inherits DatabaseTableImport

        Public Sub New(database As DatabaseObjects.Database)

            MyBase.New(database, "Shippers.csv")

        End Sub

        Protected Overrides Function TableSchema() As DatabaseObjects.SQL.SQLCreateTable

            Dim shippersTable As New DatabaseObjects.SQL.SQLCreateTable
            shippersTable.Name = "Shippers"
            With shippersTable.Fields.Add("ShipperID", DatabaseObjects.SQL.DataType.Integer)
                .KeyType = DatabaseObjects.SQL.KeyType.Primary
                .AutoIncrements = True
            End With
            shippersTable.Fields.Add("CompanyName", DatabaseObjects.SQL.DataType.VariableCharacter, 40)
            shippersTable.Fields.Add("Phone", DatabaseObjects.SQL.DataType.VariableCharacter, 24)

            Return shippersTable

        End Function

        Protected Overrides Sub TransformRecord(fieldValues As DatabaseObjects.SQL.SQLFieldValues)

            fieldValues.Delete(fieldValues("ShipperID"))

        End Sub

        Protected Overrides Function CreateIndexes() As DatabaseObjects.SQL.ISQLStatement()

            Return New DatabaseObjects.SQL.ISQLStatement() {}

        End Function

    End Class

End Namespace