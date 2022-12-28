Imports System

Module Program
    Sub Main()

        'Dim counter As Integer = 0
        'Dim userResponse As Boolean = True
        'While (userResponse = True)
        '    counter = counter + 1
        '    Console.WriteLine("Codeblock has executed {0} times.", counter)
        '    Console.Write("Continue? (Y or N?)")
        '    userResponse = IIf(Console.ReadLine() = "Y", True, False)
        'End While

        'Console.WriteLine("Finish. Press Enter to Exit.")
        'Console.ReadLine()

        Dim displayMenu As Boolean = True
        While (displayMenu)
            displayMenu = MainMenu
        End While

    End Sub

    Function MainMenu() As Boolean
        Console.Clear()
        Console.WriteLine("Choose an option: ")
        Console.WriteLine("1 - Print Numers")
        Console.WriteLine("2 - Guessing Game")
        Console.WriteLine("3 - Exit")

        Dim result As String = Console.ReadLine()

        If result = "1" Then
            Return PrintNumbers()
        ElseIf result = "2" Then
            Return GuessingGame()
        ElseIf result = "3" Then
            Return False
        Else Return True
        End If

    End Function

    Function PrintNumbers() As Boolean

        Console.Clear()
        Console.WriteLine("Type a number: ")

        Dim result As Integer = CInt(Console.ReadLine())
        Dim counter As Integer = 1
        While counter < result + 1
            Console.Write(counter)
            Console.Write("-")
            counter += 1
        End While
        Console.ReadLine()
        Return True
    End Function
    Function GuessingGame() As Boolean
        Console.Clear()
        Console.WriteLine("Type a number: ")
        Dim random As New Random()
        Dim randomNumber As Integer = random.Next(1, 11)
        Dim guesses As Integer = 0
        Dim incorrect As Boolean = True

        Do While incorrect = True
            Console.Write("Guess a number between 1 and 10:")
            Dim result As String = Console.ReadLine()
            guesses += 1 'guesses = guesses + 1
            If result = randomNumber.ToString() Then 'Cstr(randomNumber)
                incorrect = False
            Else
                Console.WriteLine("Wrong!")
            End If
        Loop
        Console.WriteLine("Correct! It took you {0} guesses", guesses)
        Console.ReadLine()
        Return True
    End Function

End Module
