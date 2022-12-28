Imports System

Module Program

    Private K As String = ""



    Sub Main()

        'Dim j As String = ""

        'For i = 1 To 10
        '    Console.WriteLine("i: " & i)
        '    j = i.ToString()
        '    K = i.ToString()

        '    If (i = 10) Then
        '        Dim l As String = i.ToString()
        '        Console.WriteLine("l: " & l)
        '    End If
        'Next
        ''Console.WriteLine(i)
        'Console.WriteLine("j: " & j)
        'Console.WriteLine("K: " & K)
        'helperMethod()

        Dim myCar As New Car()
        myCar.DoSomethingImportant()


        Console.ReadLine()

    End Sub

    Private Sub helperMethod()
        Console.WriteLine("k (from helperMethod) :" & K)
    End Sub
End Module
