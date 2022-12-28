Imports System

Module Program
    Sub Main(args As String())

        'Dim myTODO As New TODO() With {
        '    .ID = 1,
        '    .Title = "First TODO",
        '    .Description = "This is my first TODO item.",
        '    .DueDate = #12/7/2017#,
        '    .Status = "Not Started"}

        'Console.ForegroundColor = ConsoleColor.DarkRed
        'Console.WriteLine("Hello World")
        'Console.ReadLine()

        Console.WriteLine("Type in a superhero's name to see his nickname:")
        Dim userValue As String = Console.ReadLine()

        'If userValue = "Batman" Then
        '    Console.WriteLine("Caped Crusader")


        'End If

        Dim result As String = ""

        Dim myValue As Superhero
        If Superhero.TryParse(userValue, True, myValue) Then

            Select Case myValue
                Case Superhero.Batman
                    result = "Caped crusader"
                Case Superhero.Spiderman
                    result = "Man of steel"
                Case Superhero.Greenlantern
                    result = "Green Lantern"
                Case Else

            End Select

            'If myValue = Superhero.Batman Then
            '    Console.WriteLine("Caped Crusader")

            'ElseIf myValue = Superhero.Spiderman Then
            '    Console.WriteLine("Man of steel")
            'ElseIf myValue = Superhero.Greenlantern Then
            '    Console.WriteLine("Emerald Knight")

            'End If
        End If
        Console.WriteLine(result)
        Console.ReadLine()

    End Sub
End Module
