
Option Strict Off
Option Explicit On

Imports DatabaseObjects

Public Class NorthwindDB

    Private Shared pobjProducts As Products
    Private Shared pobjOrders As Orders

    Friend Shared Database As DatabaseObjects.Database

    Private Sub New()

    End Sub

    Public Shared Sub Connect_SQLServer(ByVal strDataSource As String, ByVal strDatabaseName As String)

        Database = New DatabaseObjects.MicrosoftSQLServerDatabase(strDataSource, strDatabaseName)

    End Sub

    Public Shared Sub Connect_MicrosoftAccess(ByVal strDatabaseFilePath As String)

        Database = New DatabaseObjects.MicrosoftAccessDatabase(strDatabaseFilePath)

    End Sub

    Public Shared Sub Connect_MySQL(ByVal strDataSource As String, ByVal strDatabaseName As String)

        Database = New DatabaseObjects.MySQLDatabase(strDataSource, strDatabaseName, "root", String.Empty)

    End Sub

    Public Shared ReadOnly Property Products() As Products
        Get

            If pobjProducts Is Nothing Then
                pobjProducts = New Products(Database)
            End If

            Return pobjProducts

        End Get
    End Property

    Public Shared ReadOnly Property Orders() As Orders
        Get

            If pobjOrders Is Nothing Then
                pobjOrders = New Orders()
            End If

            Return pobjOrders

        End Get
    End Property

End Class
