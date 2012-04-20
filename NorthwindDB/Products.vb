Option Strict Off
Option Explicit On

Imports System.Collections

''' <summary>
''' Demonstrates the use of overriding the base classes rather than attributing the class with 
''' the DatabaseObjects.DistinctField, DatabaseObjects.KeyField, DatabaseObjects.TableName attributes.
''' </summary>
<DatabaseObjects.Table("Products")>
<DatabaseObjects.DistinctField("ProductID", True)>
<DatabaseObjects.KeyField("ProductName")>
<DatabaseObjects.OrderByField("ProductName")>
Public Class Products
    Inherits DatabaseObjects.Generic.DatabaseObjectsListKeyed(Of Product, String)

    Public Enum SearchType
        NamePrefix
        Name
    End Enum

    Friend Sub New(parent As NorthwindDB)

        MyBase.New(parent)

    End Sub

    Public Function First() As Product

        Return MyBase.ObjectByOrdinalFirst

    End Function

    Public Shadows Function Add(Optional ByVal strProductName As String = "") As Product

        Add = ItemInstance()
        Add.Name = strProductName

    End Function

    Public Function Search(ByVal strName As String, ByVal eType As SearchType) As Generic.IList(Of Product)

        Dim objConditions As DatabaseObjects.SQL.SQLConditions = New DatabaseObjects.SQL.SQLConditions

        Select Case eType
            Case SearchType.NamePrefix
                objConditions.Add("ProductName", DatabaseObjects.SQL.ComparisonOperator.Like, strName & "%")
            Case SearchType.Name
                objConditions.Add("ProductName", DatabaseObjects.SQL.ComparisonOperator.Like, "%" & strName & "%")
        End Select

        Return MyBase.ObjectsSearch(objConditions)

    End Function

    Public Sub Delete(ByRef objProduct As Product)

        MyBase.ObjectDelete(objProduct)

    End Sub

End Class


Public Class Product
    Inherits DatabaseObjects.DatabaseObject

    <DatabaseObjects.FieldMapping("ProductName")> _
    Private pstrName As String

    <DatabaseObjects.FieldMapping("UnitPrice")> _
    Private pcurUnitPrice As Decimal

    <DatabaseObjects.FieldMapping("UnitsInStock")> _
    Private pintUnitsInStock As Short

    <DatabaseObjects.FieldMapping("UnitsOnOrder")> _
    Private pintUnitsOnOrder As Short

    <DatabaseObjects.FieldMapping("QuantityPerUnit")> _
    Private pstrQuantityPerUnit As String

    <DatabaseObjects.FieldMapping("Discontinued")> _
    Private pbDiscontinued As Boolean

    Friend Sub New(parent As Products)

        MyBase.New(parent)

    End Sub

    Friend ReadOnly Property ID() As Integer
        Get

            Return MyBase.DistinctValue

        End Get
    End Property

    Public ReadOnly Property QuantityPerUnit() As String
        Get

            Return pstrQuantityPerUnit

        End Get
    End Property

    Public ReadOnly Property Discontinued() As Boolean
        Get

            Return pbDiscontinued

        End Get
    End Property

    Public ReadOnly Property UnitsInStock() As Short
        Get

            Return pintUnitsInStock

        End Get
    End Property

    Public ReadOnly Property IsInStock() As Boolean
        Get

            Return pintUnitsInStock > 0

        End Get
    End Property

    Public ReadOnly Property IsOnOrder() As Boolean
        Get

            Return pintUnitsOnOrder > 0

        End Get
    End Property

    Public Property Name() As String
        Get

            Return pstrName

        End Get

        Set(ByVal Value As String)

            If Value.Trim = Nothing Then
                Throw New ArgumentNullException
            Else
                pstrName = Value
            End If

        End Set
    End Property

    Public Property UnitPrice() As Decimal
        Get

            Return pcurUnitPrice

        End Get

        Set(ByVal Value As Decimal)

            If Value >= 0 Then
                pcurUnitPrice = Value
            Else
                Throw New ArgumentException(Value)
            End If

        End Set
    End Property

    Public Sub AddUnits(ByVal intQuantity As Integer)

        If intQuantity >= 0 Then
            pintUnitsInStock = pintUnitsInStock + intQuantity
        Else
            Throw New ArgumentException(intQuantity)
        End If

    End Sub

    Public Sub RemoveUnits(ByVal intQuantity As Integer)

        If intQuantity >= 0 Then
            If intQuantity > pintUnitsInStock Then
                Throw New ArgumentException("Cannot remove more units than are available")
            End If
            pintUnitsInStock = pintUnitsInStock - intQuantity
        Else
            Throw New ArgumentException(intQuantity)
        End If

    End Sub

    Public Overloads Sub Save()

        MyBase.Save()

    End Sub

End Class

