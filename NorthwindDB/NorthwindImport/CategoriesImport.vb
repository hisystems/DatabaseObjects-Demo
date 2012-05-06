Namespace NorthwindImport

    Friend Class CategoriesImport
        Inherits DatabaseTableImport

        Public Sub New(database As DatabaseObjects.Database)

            MyBase.New(database, "Categories.csv")

        End Sub

        Protected Overrides Function TableSchema() As DatabaseObjects.SQL.SQLCreateTable

            Dim categoriesTable As New DatabaseObjects.SQL.SQLCreateTable
            categoriesTable.Name = "Categories"
            With categoriesTable.Fields.Add("CategoryID", DatabaseObjects.SQL.DataType.Integer)
                .AutoIncrements = True
                .KeyType = DatabaseObjects.SQL.KeyType.Primary
            End With
            categoriesTable.Fields.Add("CategoryName", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 15)
            categoriesTable.Fields.Add("Description", DatabaseObjects.SQL.DataType.UnicodeText)
            categoriesTable.Fields.Add("Picture", DatabaseObjects.SQL.DataType.Image)

            Return categoriesTable

        End Function

        Protected Overrides Sub TransformRecord(fieldValues As DatabaseObjects.SQL.SQLFieldValues)

            'CategoryID is an IDENTITY field and therefore should not be imported
            fieldValues.Delete(fieldValues("CategoryID"))

        End Sub

        Protected Overrides Function CreateIndexes() As DatabaseObjects.SQL.ISQLStatement()

            Return New DatabaseObjects.SQL.ISQLStatement() _
            {
                New DatabaseObjects.SQL.SQLCreateIndex("CategoryName", "Categories", New String() {"CategoryName"}) _
            }

        End Function

    End Class

End Namespace
