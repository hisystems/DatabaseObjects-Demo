Option Strict On
Option Explicit On
Option Infer On

Imports System.Collections.Generic

Namespace NorthwindImport

    ''' <summary>
    ''' Represents a database table and the contents it will hold.
    ''' The data is sourced from a CSV resource file.
    ''' </summary>
    Friend MustInherit Class DatabaseTableImport

        ''' <summary>
        ''' Should return the statements required to create the table 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Protected MustOverride Function TableSchema() As DatabaseObjects.SQL.SQLCreateTable

        ''' <summary>
        ''' Should return the statements required to create the indexes
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Protected MustOverride Function CreateIndexes() As DatabaseObjects.SQL.ISQLStatement()

        Private _database As DatabaseObjects.Database
        Private _dataResourceFileName As String

        Protected Sub New(ByVal database As DatabaseObjects.Database, ByVal dataResourceFileName As String)

            If database Is Nothing Then
                Throw New ArgumentNullException
            End If

            Me._database = database
            Me._dataResourceFileName = dataResourceFileName

        End Sub

        ''' <summary>
        ''' If the database table does not exist it is created and populated with data from the CSV files.
        ''' </summary>
        Public Sub CreateTableAndPopulate()

            Dim createTable = TableSchema()

            Using connection As New DatabaseObjects.ConnectionScope(_database)
                If Not TableExists(createTable.Name, connection) Then
                    connection.ExecuteNonQuery(TableSchema())

                    For Each createIndex In CreateIndexes()
                        connection.ExecuteNonQuery(createIndex)
                    Next

                    Dim csvDataAssembly = Me.GetType.Assembly
                    PopulateData(connection, csvDataAssembly.GetManifestResourceStream(csvDataAssembly.GetName().Name & "." & _dataResourceFileName), createTable.Name)
                End If
            End Using

        End Sub

        Private Shared Function TableExists(tableName As String, connection As DatabaseObjects.ConnectionScope) As Boolean

            Using reader = connection.Execute(New DatabaseObjects.SQL.SQLTableExists(tableName))
                Return reader.Read
            End Using

        End Function

        Private Sub PopulateData(connection As DatabaseObjects.ConnectionScope, csvData As System.IO.Stream, insertIntoTable As String)

            Dim dataFile As New Microsoft.VisualBasic.FileIO.TextFieldParser(csvData) With {
                .TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited,
                .Delimiters = New String() {","},
                .HasFieldsEnclosedInQuotes = True
            }

            'Read the header line
            Dim headers = dataFile.ReadFields

            While Not dataFile.EndOfData
                Dim fields = dataFile.ReadFields
                Dim decimalValue As Decimal
                Dim fieldValues As New DatabaseObjects.SQL.SQLFieldValues

                For index = 0 To headers.Length - 1
                    If fields(index).StartsWith("0x") Then
                        fieldValues.Add(headers(index), ParseHexString(fields(index)))
                    ElseIf fields(index) = "NULL" Then
                        fieldValues.Add(headers(index), DBNull.Value)
                    ElseIf Decimal.TryParse(fields(index), decimalValue) Then
                        fieldValues.Add(headers(index), decimalValue)
                    Else
                        fieldValues.Add(headers(index), fields(index))
                    End If
                Next

                TransformRecord(fieldValues)

                Dim insert As New DatabaseObjects.SQL.SQLInsert
                insert.TableName = insertIntoTable
                insert.Fields = fieldValues
                _database.Connection.ExecuteNonQuery(insert)
            End While

            dataFile.Close()

        End Sub

        Private Shared Function ParseHexString(hexString As String) As Byte()

            If Not hexString.StartsWith("0x") Then
                Throw New ArgumentException("String does not start with 0x")
            End If

            Dim data As New List(Of Byte)

            For index = 2 To hexString.Length - 1 Step 2
                data.Add(Convert.ToByte(hexString.Substring(index, 2), 16))
            Next

            Return data.ToArray

        End Function

        ''' <summary>
        ''' Hook that allows super classes to modify / transform the data that will be imported into the database.
        ''' </summary>
        Protected Overridable Sub TransformRecord(ByVal fieldValues As DatabaseObjects.SQL.SQLFieldValues)

        End Sub

    End Class

End Namespace

