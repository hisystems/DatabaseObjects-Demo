
Public Class ProductSearch

    'This class provides the ability to search on multiple fields on multiple criteria
    'for a product, as opposed to the Product.Search function which only provides searching
    'on 1 field.

    'This class also demonstrates how to optimise the objects so that rather than loading
    'referenced objects (in this case the product's Supplier object) via multiple SQL calls
    'all of the associated tables are joined and returned in one recordset. Have a look in the
    'Product's Load to see how the objects are loaded from the same
    'recordset, and in particular the ObjectFromFieldValues function.

    Private Enum TriState
        [Default] = -2
        [True] = True
        [False] = False
    End Enum

    Private pstrName As String
    Private peInStock As TriState = TriState.Default
    Private peOnOrder As TriState = TriState.Default
    Private peDiscontinued As TriState = TriState.Default

    Public WriteOnly Property Name() As String
        Set(ByVal Value As String)

            pstrName = Value.Trim

        End Set
    End Property

    Public WriteOnly Property InStock() As Boolean
        Set(ByVal Value As Boolean)

            peInStock = Value

        End Set
    End Property

    Public WriteOnly Property OnOrder() As Boolean
        Set(ByVal Value As Boolean)

            peOnOrder = Value

        End Set
    End Property

    Public WriteOnly Property Discontinued() As Boolean
        Set(ByVal Value As Boolean)

            peDiscontinued = Value

        End Set
    End Property

    Public Function Search() As Collections.Generic.IList(Of Product)

        Dim objProducts As DatabaseObjects.IDatabaseObjects
        Dim objProduct As Product
        Dim objResults As IDataReader
        Dim objResultsList As New Collections.Generic.List(Of Product)
        Dim objSelect As New DatabaseObjects.SQL.SQLSelect

        'The TableJoins function will join the Products and Suppliers tables so that the
        'results are returned in one recordset, rather than requiring multiple statements to read
        'each product's associated supplier record. See the Products' TableJoins
        'on how this is done.

        objProducts = NorthwindDB.Products
        objSelect.Tables.Add(objProducts.TableName)
        objSelect.Tables.Joins = objProducts.TableJoins(objSelect.Tables(0), objSelect.Tables)

        'search for the product name if it has been set
        If pstrName <> Nothing Then
            objSelect.Where.Add("ProductName", DatabaseObjects.SQL.ComparisonOperator.Like, "%" & pstrName & "%")
        End If

        If peInStock <> TriState.Default Then
            If peInStock = TriState.True Then
                'select products that are in stock
                objSelect.Where.Add("UnitsInStock", DatabaseObjects.SQL.ComparisonOperator.GreaterThan, 0)
            Else
                'select products that are not in stock
                objSelect.Where.Add("UnitsInStock", DatabaseObjects.SQL.ComparisonOperator.EqualTo, 0)
            End If
        End If

        If peOnOrder <> TriState.Default Then
            If peOnOrder = TriState.True Then
                'select products that are on order
                objSelect.Where.Add("UnitsOnOrder", DatabaseObjects.SQL.ComparisonOperator.GreaterThan, 0)
            Else
                'select products that are not on order
                objSelect.Where.Add("UnitsOnOrder", DatabaseObjects.SQL.ComparisonOperator.EqualTo, 0)
            End If
        End If

        If peDiscontinued <> TriState.Default Then
            objSelect.Where.Add("Discontinued", DatabaseObjects.SQL.ComparisonOperator.EqualTo, CBool(peDiscontinued))
        End If

        objSelect.OrderBy.Add("ProductName", DatabaseObjects.SQL.OrderBy.Ascending)

        NorthwindDB.Database.Connection.Start()
        objResults = NorthwindDB.Database.Connection.Execute(objSelect)

        While objResults.Read()
            objProduct = DatabaseObjects.Database.ObjectFromDataReader(NorthwindDB.Products, objResults)
            objResultsList.Add(objProduct)
        End While

        NorthwindDB.Database.Connection.Finished()

        Return objResultsList

    End Function

End Class