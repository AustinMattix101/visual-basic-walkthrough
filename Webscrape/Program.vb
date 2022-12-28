Imports System
Imports ClassLibrary2

Module Program
    Sub Main(args As String())
        Dim myScrape = New Scrape()
        Dim result As String = myScrape.ScrapeWebpage("http://www.google.com", "C:\Example")
        Console.WriteLine(result)
        Console.ReadLine()

    End Sub
End Module
