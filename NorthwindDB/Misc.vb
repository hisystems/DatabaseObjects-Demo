Module Misc

    Public Function IIf(ByVal bValue As Boolean, ByVal objItem1 As Object, ByVal objItem2 As Object) As Object

        If bValue Then
            Return objItem1
        Else
            Return objItem2
        End If

    End Function

End Module
