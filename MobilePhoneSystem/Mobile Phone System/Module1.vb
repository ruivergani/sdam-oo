Module Module1
    Structure customer
        Dim customername As String
        Dim address As String
        Dim postcode As String
        Dim mobilenumber As String

    End Structure

    Public mycustomerlist As New List(Of customer)




    Public strName, strAddress, strPostcode, strmobileNo, strPlantype As String

    Public ushMinsused, ushTextsSent, ushDataUsed As UShort

End Module
