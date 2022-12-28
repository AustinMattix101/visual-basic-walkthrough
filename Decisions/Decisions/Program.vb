Imports System

Module Program
    Sub Main(args As String())


        'Console.WriteLine("A Big CAMUNITED Give away!")
        'Console.Write("Gives your in mind number of our team services provided. 1,2,3 or anything else! Put it here: ")


        'Dim userValue As String = Console.ReadLine
        'Dim message As String = ""

        'If userValue = "1" Then
        '    message = "You won a new iPhone 12 Pro Max!"

        'ElseIf userValue = "2" Then
        '    message = "You won a new iPad! "
        'ElseIf userValue = "3" Then
        '    message = "You won a new iPod! "
        'Else message = "Sorry! Makes more chances."

        'End If

        'Console.WriteLine("You won {0}!", message)
        'Console.ReadLine()

        Console.WriteLine("A Big CAMUNITED Give away!")
        Console.Write("Gives your in mind number of our team services provided. 1,2,3 or anything else! Put it here: ")

        Dim userValue As String = Console.ReadLine
        Dim message As String = ""
        message = IIf(userValue = "1", "an iPhone 12 Pro Max", "a MacBook Pro 16Inch")

        Console.WriteLine("You won {0}!", message)
        Console.ReadLine()
    End Sub
End Module
