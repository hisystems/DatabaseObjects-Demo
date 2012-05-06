Namespace NorthwindImport

    Friend Class EmployeesImport
        Inherits DatabaseTableImport

        Public Sub New(database As DatabaseObjects.Database)

            MyBase.New(database, "Employees.csv")

        End Sub

        Protected Overrides Function TableSchema() As DatabaseObjects.SQL.SQLCreateTable

            Dim employeesTable As New DatabaseObjects.SQL.SQLCreateTable
            employeesTable.Name = "Employees"
            With employeesTable.Fields.Add("EmployeeID", DatabaseObjects.SQL.DataType.Integer)
                .AutoIncrements = True
                .KeyType = DatabaseObjects.SQL.KeyType.Primary
            End With
            employeesTable.Fields.Add("LastName", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 20)
            employeesTable.Fields.Add("FirstName", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 10)
            employeesTable.Fields.Add("Title", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 30)
            employeesTable.Fields.Add("TitleOfCourtesy", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 25)
            employeesTable.Fields.Add("BirthDate", DatabaseObjects.SQL.DataType.DateTime)
            employeesTable.Fields.Add("HireDate", DatabaseObjects.SQL.DataType.DateTime)
            employeesTable.Fields.Add("Address", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 60)
            employeesTable.Fields.Add("City", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 15)
            employeesTable.Fields.Add("Region", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 15)
            employeesTable.Fields.Add("PostalCode", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 10)
            employeesTable.Fields.Add("Country", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 15)
            employeesTable.Fields.Add("HomePhone", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 24)
            employeesTable.Fields.Add("Extension", DatabaseObjects.SQL.DataType.UnicodeVariableCharacter, 4)
            employeesTable.Fields.Add("Photo", DatabaseObjects.SQL.DataType.Image)
            employeesTable.Fields.Add("Notes", DatabaseObjects.SQL.DataType.UnicodeText)
            employeesTable.Fields.Add("ReportsTo", DatabaseObjects.SQL.DataType.Integer)

            Return employeesTable

        End Function

        Protected Overrides Sub TransformRecord(fieldValues As DatabaseObjects.SQL.SQLFieldValues)

            fieldValues.Delete(fieldValues("EmployeeID"))

        End Sub

        Protected Overrides Function CreateIndexes() As DatabaseObjects.SQL.ISQLStatement()

            Return New DatabaseObjects.SQL.ISQLStatement() _
            { _
                New DatabaseObjects.SQL.SQLCreateIndex("PostalCode", "Employees", New String() {"PostalCode"}), _
                New DatabaseObjects.SQL.SQLCreateIndex("LastName", "Employees", New String() {"LastName"}) _
            }

        End Function

    End Class

End Namespace