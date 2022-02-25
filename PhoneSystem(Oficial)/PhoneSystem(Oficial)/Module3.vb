Module Module3
    '|=============================================================================|
    '| Module 3 Used to Define Functions        ONLY                               |
    '| Author: Rui Vergani                                                         |
    '|=============================================================================|


    'Function that calculates the Plan cost - needs the plantype as parameter
    Function CalcPlanCost(ByVal plantype As String) As Decimal
        Dim cost As Decimal

        If plantype = "3G" Or plantype = "3g" Then
            cost = 10
        ElseIf plantype = "4g" Or plantype = "4G" Then
            cost = 20
        ElseIf plantype = "5g" Or plantype = "5G" Then
            cost = 30
        End If

        Return cost
    End Function

    'Function that calculates the minutes cost - needs the minutes as parameter
    Function CalcMinCost(ByVal min As Decimal) As Decimal
        Dim cost As Decimal
        If min > 500 Then
            cost = ((min - 500) * 0.2)
        Else
            cost = 0
        End If

        Return cost
    End Function

    'Function that calculates the text cost - needs the text as parameter
    Function CalcTextCost(ByVal text As Decimal) As Decimal
        Dim cost As Decimal
        If text > 500 Then
            cost = ((text - 500) * 0.1)
        Else
            cost = 0
        End If

        Return cost
    End Function

    'Function that calculates the data cost - needs the data as parameter
    Function CalcDataCost(ByVal data As Decimal) As Decimal
        Dim cost As Decimal
        If data > 500 Then
            cost = ((data - 500) * 0.5)
        Else
            cost = 0
        End If

        Return cost
    End Function

    'Function to calculate the Subtotal value of monthly bill
    Function SubtotalOfCustomerBill(ByVal data As Decimal, ByVal text As Decimal, ByVal min As Decimal, ByVal planTypeCost As Decimal) As Decimal
        Dim result As Decimal
        result = (data + text + min + planTypeCost)

        Return result
    End Function

End Module
