
Option Strict Off
Option Explicit On

Imports System.Collections

<DatabaseObjects.Table("Orders")>
<DatabaseObjects.DistinctField("OrderID", True)>
<DatabaseObjects.ItemInstance(GetType(Order))>
Public Class Orders
    Inherits DatabaseObjects.Generic.DatabaseObjectsListUsingAttributes(Of Order)

    Public Sub New()

        MyBase.New(NorthwindDB.Database)

    End Sub

    Public Function First() As Order

        Return MyBase.ObjectByOrdinalFirst

    End Function

    Public Sub Delete(ByRef objOrder As Order)

        'The objOrder is passed ByRef because the ObjectDelete function
        'sets the objOrder = Nothing thereby ensuring it can no longer be accidentally used.

        objOrder.Details.DeleteAll()
        MyBase.ObjectDelete(objOrder)

    End Sub

End Class


Public Class Order
    Inherits DatabaseObjects.DatabaseObjectUsingAttributes

    Private pobjDetails As OrderDetails

    <DatabaseObjects.FieldMapping("ShipName")> _
    Public ShipName As String = String.Empty

    <DatabaseObjects.FieldMapping("ShipAddress")> _
    Public ShipAddress As String = String.Empty

    <DatabaseObjects.FieldMapping("ShipCity")> _
    Public ShipCity As String = String.Empty

    <DatabaseObjects.FieldMapping("ShipRegion")> _
    Public ShipRegion As String = String.Empty

    <DatabaseObjects.FieldMapping("ShipCountry")> _
    Public ShipCountry As String = String.Empty

    <DatabaseObjects.FieldMapping("ShipPostalCode")> _
    Private _ShipPostalCode As String = String.Empty

    Public ReadOnly ShipPostalCodeIsSet As DatabaseObjects.Constraints.ConstraintBinding(Of String)

    <DatabaseObjects.FieldMapping("OrderDate")> _
    Private _TheDate As Date = Date.MinValue

    Public ReadOnly DateIsSet As DatabaseObjects.Constraints.ConstraintBinding(Of Date)
    Public ReadOnly DateIsValid As DatabaseObjects.Constraints.ConstraintBinding(Of Date)

    <DatabaseObjects.FieldMapping("RequiredDate")> _
    Private _RequiredDate As Date = Date.MinValue

    Public ReadOnly RequiredDateIsSet As DatabaseObjects.Constraints.ConstraintBinding(Of Date)

    Public Sub New()

        MyBase.New(NorthwindDB.Orders)

        DateIsSet = New DatabaseObjects.Constraints.ConstraintBinding(Of Date)(Function() TheDate, New DatabaseObjects.Constraints.DateIsSetConstraint())
        DateIsValid = New DatabaseObjects.Constraints.ConstraintBinding(Of Date)(Function() TheDate, New DatabaseObjects.Constraints.DateIsTodayOrFutureForNewObjectConstraint(Me))
        RequiredDateIsSet = New DatabaseObjects.Constraints.ConstraintBinding(Of Date)(Function() RequiredDate, New DatabaseObjects.Constraints.DateIsSetConstraint(), "The required date has not been set")
        ShipPostalCodeIsSet = New DatabaseObjects.Constraints.ConstraintBinding(Of String)(Function() Me.ShipPostalCode, New DatabaseObjects.Constraints.StringIsSetConstraint(), "The ship to postal code must be set")

    End Sub

    Public Property ShipPostalCode As String
        Set(value As String)

            Me.ShipPostalCodeIsSet.Clone(value).EnsureConstraintSatisfied()
            Me._ShipPostalCode = value

        End Set

        Get

            Return Me._ShipPostalCode

        End Get
    End Property

    Public Property TheDate As Date
        Set(value As Date)

            Me.DateIsSet.Clone(value).EnsureConstraintSatisfied()
            Me.DateIsValid.Clone(value).EnsureConstraintSatisfied()
            Me._TheDate = value

        End Set

        Get

            Return Me._TheDate

        End Get
    End Property

    Public Property RequiredDate As Date
        Set(value As Date)

            Me.RequiredDateIsSet.Clone(value).EnsureConstraintSatisfied()
            Me._RequiredDate = value

        End Set

        Get

            Return Me._RequiredDate

        End Get
    End Property

    Friend ReadOnly Property ID() As Integer
        Get

            'Friend will allow public access within the NorthwindDatabase assembly but will be
            'private outside of the NorthwindDatabase assembly
            Return MyBase.DistinctValue

        End Get
    End Property

    Public ReadOnly Property Number() As Integer
        Get

            Return Me.ID

        End Get
    End Property

    Public ReadOnly Property Cost() As Decimal
        Get

            Dim curCost As Decimal = 0

            For Each objDetail As OrderDetail In Me.Details
                curCost = curCost + objDetail.Cost
            Next

            Return curCost

        End Get
    End Property

    Public ReadOnly Property Details() As OrderDetails
        Get

            If pobjDetails Is Nothing Then
                pobjDetails = New OrderDetails(Me)
            End If

            Details = pobjDetails

        End Get
    End Property

    Public Shadows Sub Save()

        DateIsSet.EnsureConstraintSatisfied()
        DateIsValid.EnsureConstraintSatisfied()
        RequiredDateIsSet.EnsureConstraintSatisfied()
        ShipPostalCodeIsSet.EnsureConstraintSatisfied()

        Using objTransaction As New System.Transactions.TransactionScope

            'Save the main header object before saving the details, because if this is a new
            'Order object then the OrderID won't have been set yet and the OrderDetail objects
            'won't save with the correctly associated OrderID.
            MyBase.Save()

            'If the details had been loaded then save the details
            If Not pobjDetails Is Nothing Then
                pobjDetails.SaveAll()
            End If

            objTransaction.Complete()

        End Using

    End Sub

End Class


'The ProductID uniquely identifies each OrderDetail object within the
'Order - see the Subset function below. The 'ProductID' field
'together with the 'OrderID' field will determine which record each OrderDetail
'object is associated with.
<DatabaseObjects.DistinctField("ProductID")>
<DatabaseObjects.Table("Order Details")>
<DatabaseObjects.Subset("OrderID")>
<DatabaseObjects.ItemInstance(GetType(OrderDetail))>
Public Class OrderDetails
    Inherits DatabaseObjects.Generic.DatabaseObjectsVolatileListUsingAttributes(Of OrderDetail)

    Friend Sub New(ByVal objParent As Order)

        'Loads any existing OrderDetail objects for the order.
        MyBase.New(objParent)

    End Sub

    Friend ReadOnly Property ParentOrder() As Order
        Get

            Return DirectCast(MyBase.Parent, Order)

        End Get
    End Property

    Friend Sub DeleteAll()

        MyBase.ObjectsDeleteAll()

    End Sub

    Friend Sub SaveAll()

        'Deletes all of the OrderDetail objects first have been deleted via Delete()
        'and then saves new or existing OrderDetail objects.
        MyBase.VolatileObjectsSave()

    End Sub

End Class


Public Class OrderDetail
    Inherits DatabaseObjects.DatabaseObjectUsingAttributes

    <DatabaseObjects.FieldMapping("ProductID")> _
    Private pobjProduct As New DatabaseObjects.Generic.ObjectReference(Of Product)(NorthwindDB.Products)

    <DatabaseObjects.FieldMapping("UnitPrice")> _
    Private pcurUnitPrice As Decimal

    <DatabaseObjects.FieldMapping("Quantity")> _
    Private pintQuantity As Integer

    <DatabaseObjects.FieldMapping("Discount")> _
    Private pdblDiscount As Double  'Some databases do not support Single

    Friend Sub New(ByVal objParent As OrderDetails)

        MyBase.New(objParent)

    End Sub

    Public Property UnitPrice() As Decimal
        Get

            Return pcurUnitPrice

        End Get

        Set(ByVal Value As Decimal)

            'check that valid prices are set
            If Value >= 0 Then
                pcurUnitPrice = Value
            Else
                Throw New ArgumentException(Value.ToString)
            End If

        End Set
    End Property

    Public Property Quantity() As Integer
        Get

            Return pintQuantity

        End Get

        Set(ByVal Value As Integer)

            'check that valid quantities are set
            If Value >= 0 Then
                pintQuantity = Value
            Else
                Throw New ArgumentException(Value.ToString)
            End If

        End Set
    End Property

    Public Property Discount() As Double
        Get

            Return pdblDiscount

        End Get

        Set(ByVal Value As Double)

            If Value >= 0 Then
                pdblDiscount = Value
            Else
                Throw New ArgumentException(Value.ToString)
            End If

        End Set
    End Property

    Public Property Product() As Product
        Get

            Return pobjProduct.Object

        End Get

        Set(ByVal Value As Product)

            If Value Is Nothing Then
                Throw New ArgumentNullException
            End If

            pobjProduct.Object = Value

        End Set
    End Property

    Public ReadOnly Property Cost() As Decimal
        Get

            Return Me.UnitPrice * Me.Quantity

        End Get
    End Property

    <DatabaseObjects.FieldMapping("OrderID")> _
    Private ReadOnly Property OrderID As Integer
        Get

            Return MyBase.GrandParentDistinctValue

        End Get
    End Property

End Class