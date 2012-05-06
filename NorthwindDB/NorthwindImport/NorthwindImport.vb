Option Explicit On
Option Strict On
Option Infer On

Imports System.Linq

Namespace NorthwindImport

    Public Class Installer

        ''' <summary>
        ''' Creates the table structure and imports the data structure does not exist.
        ''' </summary>
        Public Shared Sub Run(database As DatabaseObjects.Database)

            Dim tables = New DatabaseTableImport() { _
                New CategoriesImport(database), _
                New CustomersImport(database), _
                New EmployeesImport(database), _
                New OrderDetailsImport(database), _
                New OrdersImport(database), _
                New ProductsImport(database), _
                New ShippersImport(database), _
                New SuppliersImport(database) _
            }

            For Each table In tables
                table.CreateTableAndPopulate()
            Next

        End Sub

    End Class

End Namespace
