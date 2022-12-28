Imports System

Module Program
    Sub Main(args As String())

        Console.WriteLine("Type in a super hero's name to see his nickname:")

        Dim userValue As String = Console.ReadLine()

        Select Case userValue.ToUpper()
            Case "BATMAN"
                Console.WriteLine("Caped crusader")
            Case "SUPERMAN"
                Console.WriteLine("Man of steel")
            Case "GREEN LANTERN"
                Console.WriteLine("Emerald Knight")
            Case Else
                Console.WriteLine("Not found")
        End Select

        Console.ReadLine()

    End Sub
End Module
