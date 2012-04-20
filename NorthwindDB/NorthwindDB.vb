
Option Strict Off
Option Explicit On

Imports DatabaseObjects

Public Class NorthwindDB
    Inherits DatabaseObjects.RootContainer

    Private _products As Products
    Private _orders As Orders

    Public Sub New(ByVal database As Database)

        MyBase.New(database)

    End Sub

    Public ReadOnly Property Products() As Products
        Get

            If _products Is Nothing Then
                _products = New Products(Me)
            End If

            Return _products

        End Get
    End Property

    Public ReadOnly Property Orders() As Orders
        Get

            If _orders Is Nothing Then
                _orders = New Orders(Me)
            End If

            Return _orders

        End Get
    End Property

    Public Function ProductSearch() As ProductSearch

        Return New ProductSearch(Me.Products, MyBase.Database)

    End Function

End Class
