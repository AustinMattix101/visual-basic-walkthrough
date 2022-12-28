Imports System

Module Program
    Sub Main(args As String())
        'Dim X As Integer
        'Dim Y As Integer
        'X = 3
        'Y = X + 7
        'Console.WriteLine(Y)
        'Console.ReadLine()

        Console.WriteLine("Hey! What's your former name?")
        Console.Write("Write out your first name: ")
        'Dim strFirstName As String
        'strFirstName = Console.ReadLine()
        Dim strFirstName As String = Console.ReadLine()

        Console.Write("Write out your last name: ")
        'Dim strLastName As String = "Matt"
        Dim strLastName As String
        strLastName = Console.ReadLine()

        Console.WriteLine("Hey, " & " " & strFirstName & " " & strLastName)
        Console.ReadLine()
    End Sub
End Module
