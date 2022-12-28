'Imports System

Imports System.Net

Module Program
    Sub Main()

        'Dim myStringBuilder As New System.Text.StringBuilder()
        Dim client As WebClient = New WebClient()
        Dim reply As String = client.DownloadString("https://www.google.com")
        Console.WriteLine(reply)
        Console.ReadLine()

    End Sub
End Module
