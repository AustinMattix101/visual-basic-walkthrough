Imports System
Imports System.IO

Module Program
    Sub Main(args As String())


        Dim content As String
        Try

            content = File.ReadAllText("C:\Test\Test4.txt")

        Catch ex As FileNotFoundException
            Console.WriteLine("Could't locate the file 'text4.txt' in the directory C:\Test please make sure the file exists.")

        Catch ex As DirectoryNotFoundException
            Console.WriteLine("Could not locate the C:\tes directory. Please ensure that it exists. ")
        Catch ex As Exception



            'Console.WriteLine("There was a problem!")
            Console.WriteLine("There was a problem: {0}.", ex.Message)

        Finally
            ' Code should execute no matter what.
            ' Close database connection.
            ' Close file connection.
            ' Clean up work.

            Dim content1 As String = content
            Console.Write(IIf(content1.Length = 0, "No data found!", ""))

        End Try


        Console.WriteLine(content)
        Console.ReadLine()



    End Sub
End Module
