Imports System

Module Program
    Sub Main()

        'Dim numbers(0 To 4) As Integer
        'Dim numbers(4) As Integer

        'numbers(0) = 4
        'numbers(1) = 8
        'numbers(2) = 15
        'numbers(3) = 16
        'numbers(4) = 23
        'numbers(5) = 42

        'Console.WriteLine("The third element of array contain: {0}", numbers(2))
        'Console.WriteLine(numbers.Length)

        'Dim numbers() As Integer = {4, 8, 15, 16, 23, 42}


        'For index = 0 To numbers.Length - 1
        '    Console.WriteLine(numbers(index))
        'Next

        'Dim names() As String = {"Connor ", "Eddie ", "Michael ", "Alex."}
        'For Each name As String In names
        '    Console.Write(name)
        'Next


        Dim myText As String = "You can get what you want out of life " &
            "If you help enough other people get what they want."
        Dim charArray() As Char = myText.ToCharArray()

        Array.Reverse(charArray)
        For Each item As String In charArray
            Console.Write(item)
        Next

        Console.ReadLine()


    End Sub
End Module
