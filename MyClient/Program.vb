Imports System
Imports ClassLibrary1

Module Program
    Sub Main(args As String())

        Dim myScrape As New Scrape()
        Dim result As String = myScrape.ScrapeWebpage("http://www.google.com", "c:\Example\devu.txt")
        Console.WriteLine(result)
        Console.ReadLine()






    End Sub
End Module
