Imports System.IO
Imports System.FileStyleUriParser

'|=============================================================================|
'| Module 2 Used to Define Sub Procedures                                      |
'| Author: Rui Vergani Neto                                                    |
'| Date: December 2020                                                         |
'|=============================================================================|

Module Module2

    Sub addCustomer()

        'Sub Procedure to add a new customer
        Dim trueval As Boolean = False
        Dim i As Integer


        'This gets the upper bound of the Array 
        ' Resize the Array and preserve existing data at the same time. This will allow a new record to be added to the Array

        position = UBound(vetorCustomer) + 1
        ReDim Preserve vetorCustomer(position)
        ReDim Preserve vetorCustomer(position).statement(11) 'size the array'

        Console.WriteLine()
        Console.WriteLine("**** Enter the Customer Details *****")
        Console.WriteLine()

        'Input and validate Customer ID (number)
        Do
            Try
                Console.Write("ID: ")
                vetorCustomer(position).id = Console.ReadLine()
                trueval = True
            Catch ex As Exception
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Error! This is not a number...")
                Console.ForegroundColor = ConsoleColor.Gray
                trueval = False
            End Try

        Loop Until trueval = True

        trueval = False

        'Input and validate Customer First Name (Structure to validate the string). User will not be able to enter a Null Value
        Do
            Console.Write("First Name: ")
            vetorCustomer(position).firstName = StrConv(Console.ReadLine, VbStrConv.ProperCase)

            If String.IsNullOrEmpty(vetorCustomer(position).firstName) Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("Name cannot be blank...")
                Console.ForegroundColor = ConsoleColor.Gray
            End If

        Loop Until Not (String.IsNullOrEmpty(vetorCustomer(position).firstName))

        'Input and validate Customer Surname Name (Structure to validate the string).  User will not be able to enter a Null Value
        Do
            Console.Write("Surname: ")
            vetorCustomer(position).surname = StrConv(Console.ReadLine, VbStrConv.ProperCase)

            If String.IsNullOrEmpty(vetorCustomer(position).surname) Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("Surname cannot be blank...")
                Console.ForegroundColor = ConsoleColor.Gray
            End If

        Loop Until Not (String.IsNullOrEmpty(vetorCustomer(position).surname))

        'Get Input for Customer Date of Birth. User has to type in DoB using dd/mm/yyyy format.  User will not be able to enter a Null Value
        trueval = False
        Do
            Try
                Console.Write("Date of Birth [dd/mm/yyyy]: ")
                vetorCustomer(position).DoB = Console.ReadLine()
                trueval = True
            Catch ex As Exception
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Error! This is not a Date")
                Console.ForegroundColor = ConsoleColor.Gray
            End Try
        Loop Until trueval = True

        'Input and validate Customer address (Structure to validate the string).  User will not be able to enter a Null Value
        Do
            Console.Write("Address: ")
            vetorCustomer(position).address = StrConv(Console.ReadLine, VbStrConv.ProperCase)

            If String.IsNullOrEmpty(vetorCustomer(position).address) Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("Address cannot be blank...")
                Console.ForegroundColor = ConsoleColor.Gray
            End If

        Loop Until Not (String.IsNullOrEmpty(vetorCustomer(position).address))

        'Input and validate Customer PostCode (Structure to validate the string).  User will not be able to enter a Null Value
        Do
            Console.Write("Post Code: ")
            vetorCustomer(position).postcode = StrConv(Console.ReadLine, VbStrConv.ProperCase)

            If String.IsNullOrEmpty(vetorCustomer(position).postcode) Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("PostCode cannot be blank...")
                Console.ForegroundColor = ConsoleColor.Gray
            End If

        Loop Until Not (String.IsNullOrEmpty(vetorCustomer(position).postcode))

        'Input and validate Customer Phone Number (Structure to validate the string).  User will not be able to enter a Null Value
        Do
            Console.Write("Phone Number: ")
            vetorCustomer(position).phoneNumber = StrConv(Console.ReadLine, VbStrConv.ProperCase)

            If String.IsNullOrEmpty(vetorCustomer(position).phoneNumber) Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("Phone Number cannot be blank...")
                Console.ForegroundColor = ConsoleColor.Gray
            End If

        Loop Until Not (String.IsNullOrEmpty(vetorCustomer(position).phoneNumber))

    End Sub

    Sub Displayall()

        'Sub Procedure to display all Customers'

        Dim i As Integer
        Dim swapped As Boolean = False
        Dim temp As customer

        'Use Bubble Sort algorithm to sort an array by Customer ID'
        Do
            swapped = False

            For i = 1 To vetorCustomer.Length - 1
                If vetorCustomer(i - 1).id > vetorCustomer(i).id Then
                    temp = vetorCustomer(i - 1)
                    vetorCustomer(i - 1) = vetorCustomer(i)
                    vetorCustomer(i) = temp
                    swapped = True
                End If
            Next
        Loop Until Not swapped

        'Use a For Loop to display all the customers'
        Console.WriteLine()
        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine(vbTab & vbTab & " * Customer Details * " & vbCrLf)
        Console.ForegroundColor = ConsoleColor.Gray
        Console.WriteLine("ID" & vbTab & "Name" & vbTab & vbTab & "Date of Birth" & vbTab & vbTab & "Phone Number")
        Console.WriteLine("===========================================================")

        For i = 0 To UBound(vetorCustomer)
            Console.WriteLine(vetorCustomer(i).id & vbTab &
                              vetorCustomer(i).firstName & " " & vetorCustomer(i).surname & vbTab &
                              vetorCustomer(i).DoB & vbTab & vbTab &
                              vetorCustomer(i).phoneNumber)
        Next

        Console.WriteLine(vbCrLf & "Press any key to continue... ")
        Console.ReadKey()
    End Sub

    Sub ComplexSearch()
        Dim begchar, endchar As Char
        Dim i, age, searchage As Integer

        'Search based on two variables (surname and date of birth)
        'ToUpper for the if compare

        Console.WriteLine()
        Console.WriteLine("***** Search for Customers by Surname ******" & vbCrLf)

        Console.Write("Enter beginning letter: ")
        begchar = Console.ReadLine.ToUpper

        Console.Write("Enter end letter: ")
        endchar = Console.ReadLine.ToUpper

        Console.Write("Enter age limit: ")
        searchage = Console.ReadLine.ToUpper

        For i = 0 To UBound(vetorCustomer)
            age = Now.Year - vetorCustomer(i).DoB.Year
            If Left(vetorCustomer(i).surname, 1) >= begchar And Left(vetorCustomer(i).surname, 1) <= endchar And age <= searchage Then
                Console.WriteLine("Customer: " & vetorCustomer(i).id & ", " & vetorCustomer(i).firstName & " " & vetorCustomer(i).surname)
            End If
        Next


        Console.WriteLine(vbCrLf & "Press any key to continue...")
        Console.ReadKey()
    End Sub

    Sub SearchCustomer()
        ' 'Sub Procedure to find a Student and display Grades
        Dim tempid, i As Integer
        Dim found As Boolean = False
        Dim month As Integer
        Dim trueval As Boolean = False

        'Validate input of ID (Integer)
        Do
            Try
                Console.Write("Type in customer ID: ")
                tempid = Console.ReadLine
                trueval = True
            Catch ex As Exception
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("Error! This is not a Number ...")
                trueval = False
                Console.ForegroundColor = ConsoleColor.Gray
            End Try
        Loop Until trueval = True

        'Use For Loop to search array for customer ID using Simple Linear Search
        For i = 0 To vetorCustomer.Length - 1
            If tempid = vetorCustomer(i).id Then
                found = True
                Exit For                             ' If customer is found then Exit For Loop
            End If
        Next

        'Display Customer Details and 
        If found = True Then
            Console.WriteLine()
            Console.WriteLine()
            'DISPLAY section if the customer has been found
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(vbTab & vbTab & " * Customer Found * " & vbCrLf)
            Console.ForegroundColor = ConsoleColor.Gray

            Console.WriteLine("ID" & vbTab & "Name" & vbTab & vbTab & "Date of Birth" & vbTab & vbTab & "Phone Number")
            Console.WriteLine("===========================================================")

            Console.WriteLine(vetorCustomer(i).id & vbTab &
                                  vetorCustomer(i).firstName & " " & vetorCustomer(i).surname & vbTab &
                                  vetorCustomer(i).DoB & vbTab & vbTab &
                                  vetorCustomer(i).phoneNumber)
            Console.WriteLine()
            Console.ForegroundColor = ConsoleColor.Blue
            Console.Write(vbTab & vbTab & " * Statement Year 2020 * " & vbCrLf)
            Console.ForegroundColor = ConsoleColor.Gray
            Console.WriteLine("_____________________________________________________________")
            Console.WriteLine("Month" & vbTab & "Plan Type" & vbTab & "Minutes" & vbTab & vbTab & "Text" & vbTab & vbTab & "Data (Mb)")
            Console.WriteLine("_____________________________________________________________")
            For j = 0 To 11
                Month = j + 1
                Console.WriteLine(month & vbTab &
                                          vetorCustomer(i).statement(j).planType & vbTab & vbTab &
                                          vetorCustomer(i).statement(j).minutes & vbTab & vbTab &
                                          vetorCustomer(i).statement(j).text & vbTab & vbTab &
                                          vetorCustomer(i).statement(j).data)
            Next
            Console.ForegroundColor = ConsoleColor.Gray
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("No customer found with ID " & tempid)
            Console.ForegroundColor = ConsoleColor.Gray
        End If

        Console.Write(vbCrLf & "Press any key to continue.....")
        Console.ReadKey()
    End Sub

    Sub EnterMobileUsage()
        ' Sub Procedure to enter PlanUsage for a Customer 
        Dim tempid, i, j, num1, index As Integer
        Dim found As Boolean = False
        Dim trueval As Boolean = False
        Dim num As Integer


        'Validate customer ID 
        Do
            Try
                Console.Write("Type in customer ID: ")
                tempid = Console.ReadLine
                trueval = True
            Catch ex As Exception
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Error! This is not a Number ...")
                trueval = False
                Console.ForegroundColor = ConsoleColor.Gray
            End Try
        Loop Until trueval = True

        'Use For Loop to search array for customer ID using Simple Linear Search

        found = False

        For i = 0 To UBound(vetorCustomer)
            If tempid = vetorCustomer(i).id Then
                found = True
                index = i
                Exit For                ' If customer is found then Exit For Loop
            End If
        Next

        If found = True Then
            Console.WriteLine(vbCrLf & "** Customer found **")
            Console.WriteLine("ID: " & vetorCustomer(index).id)
            Console.WriteLine("Name: " & vetorCustomer(index).firstName & " " & vetorCustomer(index).surname)
            Console.WriteLine()
            Do
                Try
                    Console.WriteLine()
                    Console.Write("Which Month [1-12]: ")
                    num = Console.ReadLine()
                    trueval = True

                    If ((num > 0) And (num <= 12)) Then
                        Console.WriteLine()
                        Console.WriteLine("** Valid Month **")
                        Console.WriteLine()
                        trueval = True
                    Else
                        trueval = False
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine(" ** Invalid Month **")
                        Console.ForegroundColor = ConsoleColor.Gray
                    End If

                Catch ex As Exception
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Error! This is not a Number ...")
                    trueval = False
                    Console.ForegroundColor = ConsoleColor.Gray
                End Try
            Loop Until trueval = True

            trueval = False
            num1 = num - 1

            'Input and validate Customer Plan Type empty or not (Structure to validate the string)
            Do
                Console.Write("Plan Type [3G - 4G - 5G]: ")
                vetorCustomer(index).statement(num1).planType = StrConv(Console.ReadLine, VbStrConv.ProperCase)

                If String.IsNullOrEmpty(vetorCustomer(index).statement(num1).planType) Then
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.WriteLine("Plan Type cannot be blank...")
                    Console.ForegroundColor = ConsoleColor.Gray
                End If

            Loop Until Not (String.IsNullOrEmpty(vetorCustomer(index).statement(num1).planType))

            'Validate Minutes'
            Do
                Try
                    Console.Write("Minutes: ")
                    vetorCustomer(index).statement(num1).minutes = Console.ReadLine()
                    trueval = True
                Catch ex As Exception
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Error! This is not a Number ...")
                    trueval = False
                    Console.ForegroundColor = ConsoleColor.Gray
                End Try
            Loop Until trueval = True

            trueval = False

            'Validate Text'
            Do
                Try
                    Console.Write("Text: ")
                    vetorCustomer(index).statement(num1).text = Console.ReadLine()
                    trueval = True
                Catch ex As Exception
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Error! This is not a Number ...")
                    trueval = False
                    Console.ForegroundColor = ConsoleColor.Gray
                End Try
            Loop Until trueval = True

            trueval = False

            'Validate Data'
            Do
                Try
                    Console.Write("Data (MB): ")
                    vetorCustomer(index).statement(num1).data = Console.ReadLine()
                    trueval = True
                Catch ex As Exception
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Error! This is not a Number ...")
                    trueval = False
                    Console.ForegroundColor = ConsoleColor.Gray
                End Try
            Loop Until trueval = True



            'Variables for the display
            Dim plancost As Decimal
            Dim mincost, textcost, datacost, subTotal, vat, total As Decimal
            plancost = CalcPlanCost(vetorCustomer(index).statement(num1).planType)
            mincost = CalcMinCost(vetorCustomer(index).statement(num1).minutes)
            textcost = CalcTextCost(vetorCustomer(index).statement(num1).text)
            datacost = CalcDataCost(vetorCustomer(index).statement(num1).data)

            subTotal = SubtotalOfCustomerBill(datacost, textcost, mincost, plancost)
            vat = ((subTotal * 20) / 100)
            total = (subTotal + vat)

            ' ====== DISPLAY SECTION ======'
            Console.WriteLine()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("********** Monthly Statement **************" & vbCrLf)
            Console.ForegroundColor = ConsoleColor.Gray

            Console.WriteLine(vetorCustomer(index).address & vbTab & "Customer ID: " & vetorCustomer(index).id)
            Console.WriteLine()
            Console.WriteLine("Mobile no. " & vbTab & vetorCustomer(index).phoneNumber & vbTab & "Statement Date Jun 2020")
            Console.WriteLine()
            Console.WriteLine("Plan Type: " & vbTab & vetorCustomer(index).statement(num1).planType & vbTab & vbTab & "£" & plancost)
            Console.WriteLine("Mins:      " & vbTab & vetorCustomer(index).statement(num1).minutes & vbTab & vbTab & "£" & mincost)
            Console.WriteLine("Texts:     " & vbTab & vetorCustomer(index).statement(num1).text & vbTab & vbTab & "£" & textcost)
            Console.WriteLine("Data (MBs):" & vbTab & vetorCustomer(index).statement(num1).data & vbTab & vbTab & "£" & datacost)
            Console.WriteLine("=======================================")
            Console.WriteLine("Subtotal" & vbTab & vbTab & " £" & subTotal)
            Console.WriteLine("VAT     " & vbTab & vbTab & " £" & vat)
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("Total   " & vbTab & vbTab & " £" & total)
            Console.WriteLine()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("********** END OF Statement **************" & vbCrLf)
            Console.WriteLine()
            Console.ForegroundColor = ConsoleColor.Gray
        Else

            ' Display message if customer not found
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine()
            Console.WriteLine("* No Customer found with ID " & tempid & " *")
            Console.ForegroundColor = ConsoleColor.Gray
        End If

        Console.Write(vbCrLf & "Press any key to continue.....")
        Console.ReadKey()
    End Sub

    Sub Savedata()
        ' Sub Procedure to Save Data in CVS file
        Dim myfile As System.IO.StreamWriter            'Declare object of type StreamWriter
        Dim i, j As Integer
        Dim temp As String              'Used to build up a string of all the grades

        'Assign a file to StreamWriter Object. Will Overwrite file when program terminates 
        ' File is located in teh Bin Folder of the VB project folder 

        myfile = My.Computer.FileSystem.OpenTextFileWriter("data.csv", False)
        'Use a For Loop to traverse array and write each element of the array to the text file 
        For i = 0 To vetorCustomer.Length - 1
            temp = ""
            ' A for Loop to used to build up a string storing all the 
            For j = 0 To 11
                temp = temp & "," & vetorCustomer(i).statement(j).planType & "," & vetorCustomer(i).statement(j).minutes & "," & vetorCustomer(i).statement(j).text & "," & vetorCustomer(i).statement(j).data
            Next
            'Write  Student Details to File including grades. This is a CSV file using a Comma as seperator 
            myfile.WriteLine(vetorCustomer(i).id & "," & vetorCustomer(i).firstName & "," & vetorCustomer(i).surname & "," & vetorCustomer(i).DoB & "," & vetorCustomer(i).address & "," & vetorCustomer(i).postcode & "," & vetorCustomer(i).phoneNumber & temp)
        Next
        myfile.Close()
        'For the user to save data in the CVS file you must put all the details required and also at least one month of Mobile Plan, otherwise it will not save the details into the cvs file.
    End Sub

    Sub Loaddata()
        Dim i, j As Integer
        Dim myfile As FileIO.TextFieldParser
        Dim record() As String

        myfile = My.Computer.FileSystem.OpenTextFieldParser("data.csv") 'Assign file
        myfile.TextFieldType = FileIO.FieldType.Delimited
        myfile.SetDelimiters(",")

        While Not myfile.EndOfData 'do loop to read each line of text until the end of the file
            record = myfile.ReadFields 'read each line of the file into an array. The comma will act as separator so that each field is read into the array

            'Load data into de array
            position = UBound(vetorCustomer) + 1
            ReDim Preserve vetorCustomer(position) 'Resize the array and preserve the data inside
            ReDim Preserve vetorCustomer(position).statement(11) 'size the array'

            'Assign the values read from file
            vetorCustomer(position).id = record(0)
            vetorCustomer(position).firstName = record(1)
            vetorCustomer(position).surname = record(2)
            vetorCustomer(position).DoB = record(3)
            vetorCustomer(position).address = record(4)
            vetorCustomer(position).postcode = record(5)
            vetorCustomer(position).phoneNumber = record(6)

            'Loop for the array statement (plan mobile usage) read all the months (j)
            For j = 0 To 11
                vetorCustomer(position).statement(j).planType = record(7)
                vetorCustomer(position).statement(j).minutes = record(8)
                vetorCustomer(position).statement(j).text = record(9)
                vetorCustomer(position).statement(j).data = record(10)
            Next


        End While
        myfile.Close()
    End Sub

    Sub DisplayBill()
        ' Sub Procedure to display the Bill
        Dim tempid, i, j, num1, index As Integer
        Dim found As Boolean = False
        Dim trueval As Boolean = False
        Dim num As Integer


        'Validate customer ID 
        Do
            Try
                Console.Write("Type in customer ID: ")
                tempid = Console.ReadLine
                trueval = True
            Catch ex As Exception
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Error! This is not a Number ...")
                trueval = False
                Console.ForegroundColor = ConsoleColor.Gray
            End Try
        Loop Until trueval = True

        'Use For Loop to search array for customer ID using Simple Linear Search

        found = False

        For i = 0 To UBound(vetorCustomer)
            If tempid = vetorCustomer(i).id Then
                found = True
                index = i
                Exit For                ' If customer is found then Exit For Loop
            End If
        Next

        If found = True Then
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(vbCrLf & "** Customer found **")
            Console.ForegroundColor = ConsoleColor.Gray
            Console.WriteLine("ID: " & vetorCustomer(index).id)
            Console.WriteLine("Name: " & vetorCustomer(index).firstName & " " & vetorCustomer(index).surname)
            Console.WriteLine()
            Do
                Try
                    Console.WriteLine()
                    Console.Write("Which Month [1-12]: ")
                    num = Console.ReadLine()
                    trueval = True

                    If ((num > 0) And (num <= 12)) Then
                        Console.WriteLine()
                        Console.WriteLine("** Valid Month **")
                        Console.WriteLine()
                        trueval = True
                    Else
                        trueval = False
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine(" ** Invalid Month **")
                        Console.ForegroundColor = ConsoleColor.Gray
                    End If

                Catch ex As Exception
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Error! This is not a Number ...")
                    trueval = False
                    Console.ForegroundColor = ConsoleColor.Gray
                End Try
            Loop Until trueval = True

            trueval = False
            num1 = num - 1

            'Variables for the display
            Dim plancost As Decimal
            Dim mincost, textcost, datacost, subTotal, vat, total As Decimal
            plancost = CalcPlanCost(vetorCustomer(index).statement(num1).planType)
            mincost = CalcMinCost(vetorCustomer(index).statement(num1).minutes)
            textcost = CalcTextCost(vetorCustomer(index).statement(num1).text)
            datacost = CalcDataCost(vetorCustomer(index).statement(num1).data)

            subTotal = SubtotalOfCustomerBill(datacost, textcost, mincost, plancost)
            vat = ((subTotal * 20) / 100)
            total = (subTotal + vat)

            ' ====== DISPLAY SECTION ======'
            Console.WriteLine()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("********** Monthly Statement **************" & vbCrLf)
            Console.ForegroundColor = ConsoleColor.Gray

            Console.WriteLine(vetorCustomer(index).address & vbTab & "Customer ID: " & vetorCustomer(index).id)
            Console.WriteLine()
            Console.WriteLine("Mobile no. " & vbTab & vetorCustomer(index).phoneNumber & vbTab & "Statement Date Jun 2020")
            Console.WriteLine()
            Console.WriteLine("Plan Type: " & vbTab & vetorCustomer(index).statement(num1).planType & vbTab & vbTab & "£" & plancost)
            Console.WriteLine("Mins:      " & vbTab & vetorCustomer(index).statement(num1).minutes & vbTab & vbTab & "£" & mincost)
            Console.WriteLine("Texts:     " & vbTab & vetorCustomer(index).statement(num1).text & vbTab & vbTab & "£" & textcost)
            Console.WriteLine("Data (MBs):" & vbTab & vetorCustomer(index).statement(num1).data & vbTab & vbTab & "£" & datacost)
            Console.WriteLine("=======================================")
            Console.WriteLine("Subtotal" & vbTab & vbTab & " £" & subTotal)
            Console.WriteLine("VAT     " & vbTab & vbTab & " £" & vat)
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("Total   " & vbTab & vbTab & " £" & total)
            Console.WriteLine()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("********** END OF Statement **************" & vbCrLf)
            Console.WriteLine()
            Console.ForegroundColor = ConsoleColor.Gray
        Else

            ' Display message if customer not found
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine()
            Console.WriteLine("* No Customer found with ID " & tempid & " *")
            Console.ForegroundColor = ConsoleColor.Gray
        End If

        Console.Write(vbCrLf & "Press any key to continue.....")
        Console.ReadKey()
    End Sub

End Module