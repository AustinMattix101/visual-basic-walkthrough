Imports System

Module Program
    Sub Main(args As String())


        'Dim FirstName As String
        'FirstName = GetReversString(Console.ReadLine())
        'Console.Write("What your last name?")
        'Dim LastName As String
        'LastName = GetReversString(Console.ReadLine())
        'Console.WriteLine("In what city you born?")
        'Dim BornCity As String = GetReversString(Console.ReadLine())
        'Console.WriteLine(myFirstName & " " & myLastName & ".")

        'Dim FirstNameArray As Char() = FirstName.ToCharArray()
        'Array.Reverse(FirstNameArray)
        'Console.WriteLine(FirstNameArray)

        'Dim LastNameArray As Char() = LastName.ToCharArray()
        'Array.Reverse(LastNameArray)
        'Console.WriteLine(LastNameArray)

        'Dim BornCityArray As Char() = BornCity.ToCharArray()
        'Array.Reverse(BornCityArray)
        'Console.WriteLine(BornCityArray)

        'Dim result As String = ""

        'For Each item As String In FirstNameArray
        '    result &= item
        'Next

        'result &= " "

        'For Each item As String In LastNameArray
        '    result &= item
        'Next

        'result += " "

        'For Each item As String In BornCityArray
        '    result &= item
        'Next

        'Console.WriteLine("Welcome! " & FirstNameArray & " " & LastNameArray & " " & BornCityArray)
        'Console.WriteLine("Welcome! " + result)

        Console.WriteLine("The Name Game")
        Console.Write("What your first name?")

        Dim FirstName As String
        FirstName = Console.ReadLine()

        Console.Write("What your last name?")
        Dim LastName As String
        LastName = Console.ReadLine()

        Console.WriteLine("In what city you born?")
        Dim BornCity As String
        BornCity = Console.ReadLine()

        ReversString(FirstName)
        ReversString(LastName)
        ReversString(BornCity)

        DisplayResult(FirstName, LastName, BornCity)

        Console.ReadLine()



    End Sub
    Sub DisplayResult(message As String)

        Console.Write("Results: ")
        Console.Write(message)

    End Sub

    Sub DisplayResult(reversedFirstName As String,
                      reversedLastName As String,
                      reversedBornCity As String)
        Console.Write("Results: ")
        Console.Write("{0} {1} {2}",
                      reversedFirstName,
                      reversedLastName,
                      reversedBornCity)


    End Sub

    Function GetReversString(ByVal message As String) As String

        Dim messageArray As Char() = message.ToCharArray
        Array.Reverse(messageArray)
        Return String.Concat(messageArray)
    End Function

    Sub ReversString(ByRef message As String)
        Dim messageArray As Char() = message.ToCharArray()
        Array.Reverse(messageArray)
        message = String.Concat(messageArray)
    End Sub

End Module
