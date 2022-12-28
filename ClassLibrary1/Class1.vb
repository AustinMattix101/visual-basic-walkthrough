Imports System.IO
Imports System.Net

Public Class Scrape

    Public Function ScrapeWebpage(ByVal url As String, ByVal path As String) As String

        Dim client As New WebClient()
        Dim reply As String = client.DownloadString(url)


        File.WriteAllText(path, reply)







        Return reply

    End Function

End Class
