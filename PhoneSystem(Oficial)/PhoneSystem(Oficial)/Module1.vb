Imports System
Imports System.IO
Imports System.Console
Imports Microsoft.VisualBasic
Imports System.Math


Module Module1
    '|=============================================================================|
    '| Mobile System  Application      V1.0 Dec 2020                               |
    '| Author: Rui Vergani Neto                                                    |
    '| Date: December 2020                                                         |
    '|=============================================================================|

    ' Define Structure for a Customer and another structure for the tarrif
    Structure customer
        Dim id As Integer
        Dim firstName As String
        Dim surname As String
        Dim address As String
        Dim postcode As String
        Dim phoneNumber As String
        Dim DoB As Date

        Structure tarrif
            Dim planType As String
            Dim minutes As UShort
            Dim text As UShort
            Dim data As UShort
            Dim month As Byte
        End Structure

        Dim statement() As tarrif
    End Structure


    ' Declare Public Variables as these will be used througout the project

    Public vetorCustomer(-1) As customer ' Array based on customer Data type. This is a Dynamic Array  as size will change when a new customer is added 
    ' reason for the -1 in brackets is that if you leave it blank or put a 0 this will  .
    Public position As Integer ' Variable used to track the size of the Array



    Sub Main()

        Dim choice As Integer
        Dim trueval As Boolean = False


        Loaddata() ' Load Customer Data

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine()
            WriteLine(vbCrLf & vbTab & vbTab & "** Mobile Phone System **" & vbCrLf)
            Console.WriteLine()
            Console.ForegroundColor = ConsoleColor.Gray


            ' Display Main Menu
            Console.WriteLine("1. Enter Customer Details")
            Console.WriteLine("2. Enter Mobile Phone usage and display Bill")
            Console.WriteLine("3. Display All Customers")
            Console.WriteLine("4. Display Bill")
            Console.WriteLine("5. Search for a Customer")
            Console.WriteLine("6. Complex Search")
            Console.WriteLine("7. Exit")


            ' Validate user Selection 
            Do
                Try
                    Console.Write(vbCrLf & "Please make a selection [1-7]: ")
                    choice = Console.ReadLine
                    trueval = True
                Catch ex As Exception
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine()
                    Console.WriteLine("Error. You have not typed in a number. Press any key to continue... ")
                    Console.ForegroundColor = ConsoleColor.Gray
                End Try
            Loop Until trueval = True

            trueval = False

            ' Use Select Case to choose options from main menu
            Select Case choice
                Case 1
                    addCustomer()
                Case 2
                    EnterMobileUsage()
                Case 3
                    Displayall()
                Case 4
                    DisplayBill()
                Case 5
                    SearchCustomer()
                Case 6
                    ComplexSearch()
                Case 7
                    Console.WriteLine(vbCrLf & "You have chosen to exit. Press any key to exit...")
                Case Else
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine()
                    Console.WriteLine("Invalid selection. press any key to continue ...")
                    Console.ForegroundColor = ConsoleColor.Gray
                    Console.ReadKey()
            End Select
        Loop Until choice = 7   ' Loop until user selects menu option 7

        Savedata() ' Save Data before program terminates

        Console.ReadKey()
    End Sub

End Module