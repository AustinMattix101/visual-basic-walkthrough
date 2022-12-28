Imports System

Module Program
    Sub Main(args As String())

        Console.WriteLine("Pick a number between 1 and 100:")

        Dim userValue As String = Console.ReadLine()

        ' Note : This is dangerous ---- what if the user does't
        'Type in a number correctly?

        Dim compareValue As Integer = CInt(userValue)

        If compareValue < 1 Or compareValue > 100 Then
            Console.WriteLine("The number you choose was out of bounds")
        ElseIf compareValue = 42 Or compareValue = 23 Or compareValue > 90 Then
            Console.WriteLine("You're found one of special numbers")
        Else
            Console.WriteLine("You didn't find one of special numbers")
        End If
        Console.ReadLine()
    End Sub
End Module
