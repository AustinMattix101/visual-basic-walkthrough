Imports System

Module Program
    Sub Main(args As String())

        Dim myValue As Date = Now()

        'Console.WriteLine(myValue)

        'Console.WriteLine(myValue.ToLongDateString())
        'Console.WriteLine(myValue.ToShortDateString)
        'Console.WriteLine(myValue.ToLongTimeString)
        'Console.WriteLine(myValue.ToShortTimeString)


        'Console.WriteLine(myValue.Month & "--" & myValue.Year & " " & myValue.DayOfWeek)

        'Console.WriteLine(myValue.ToString("MMMM") & myValue.ToString("h"))

        'Console.WriteLine(myValue.AddDays(14).ToLongDateString)

        'Console.WriteLine(myValue.AddHours(5).ToShortTimeString())

        'Dim myBirthdate As New Date(2003, 3, 2, 7, 30, 1)
        'Dim myBirthdate As New Date
        'myBirthdate = Date.Parse("03/2/2003")

        'Dim myBirthdate As New Date = #03/02/2003#

        'Console.WriteLine(myBirthdate.ToLongDateString())



        Dim myBirthdate As New Date(2003, 3, 2)
        Dim myAge As TimeSpan = Date.Now.Subtract(myBirthdate)

        myAge = myAge.Add(New TimeSpan(100, 0, 0, 0))
        Dim unit As String = " Days"

        Console.WriteLine("{0}", "I've been alive about " & myAge.TotalDays & unit)


        Console.ReadLine()

    End Sub
End Module
