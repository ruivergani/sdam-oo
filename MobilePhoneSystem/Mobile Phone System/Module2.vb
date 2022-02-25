Module Module2
  
    Function calc_PlanCost(ByVal pt As String) As Decimal

        Dim result As Decimal

        If pt = "3G" Then
            result = 10
        ElseIf pt = "4G" Then
            result = 20
        ElseIf pt = "5G" Then
            result = 30
        Else
            result = 0
        End If
        Return result

    End Function

    Function calc_minscost(ByVal mu As UShort) As Decimal
        Dim mc As Decimal

        If mu <= 500 Then
            mc = 0
        ElseIf mu > 500 Then
            mc = (mu - 500) * 0.2
        End If

        Return mc


    End Function
   
   Function calc_Textscost(ByVal tu As UShort) As Decimal
        Dim tc As Decimal

        If tu <= 500 Then
            tc = 0
        ElseIf tu > 500 Then
            tc = (tu - 500) * 0.1
        End If

        Return tc
    End Function
  
  Function calc_Datacost(ByVal du As UShort) As Decimal
        Dim dc As Decimal

        If du <= 500 Then
            dc = 0
        ElseIf du > 500 Then
            dc = (du - 500) * 0.5
        End If

        Return dc
    End Function
    Function calc_SubTotal(ByVal pc As Decimal, ByVal mc As Decimal, ByVal tc As Decimal, ByVal dc As Decimal) As Decimal
        Dim st As Decimal

        st = pc + mc + tc + dc

        Return st
    End Function

    Function calc_VAT(ByVal st As Decimal) As Decimal
        Dim v As Decimal

        v = st * 0.2

        Return v
    End Function

    Function calc_GrandTotal(ByVal st As Decimal, ByVal v As Decimal) As Decimal
        Dim gt As Decimal

        gt = st + v

        Return gt
    End Function

 
End Module
