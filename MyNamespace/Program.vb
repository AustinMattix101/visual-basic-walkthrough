Imports System.Net
Imports MyNamespace
Imports System.Net.NetworkInformation


Module Program

    '    Namespace n1
    '    Namespace n2
    '        Class a

    '        End Class
    '    End Namespace
    'End Namespace


    'Namespace My
    '    <HideModuleName()>
    '    Module MyCustomExtensions
    '        Private _extension As New ThreadSafeObjectProvider(Of SampleExtension)
    '        Friend ReadOnly Property SampleExtension() As SampleExtension
    '            Get
    '                Return _extension.GetInstance()
    '            End Get
    '        End Property
    '    End Module
    'End Namespace

    'Sub Main(args As String())

    '    'Console.WriteLine(My.Computer.Name)
    '    'Console.WriteLine(String.Format("{0:N}", My.Computer.Info.AvailablePhysicalMemory))

    '    'Dim files = My.Computer.FileSystem.GetDirectories("C:\users\bob\Documents")

    '    'For Each item As String In files
    '    '    Console.WriteLine(item)
    '    'Next


    '    'Dim files = My.Computer.FileSystem.FindInFiles("C:\users\bob\Documents\test1.txt", "time",True,FileIO.SearchOption.SearchTopLevelOnly)

    '    'For Each item As String In files
    '    '    Console.WriteLine(item)
    '    'Next

    '    'My.Computer.FileSystem.CopyDirectory("c:\user\", "c:\test2", True)
    '    'Console.WriteLine("Finished")

    '    'Dim arguments = My.Application.CommandLineArgs
    '    'For Each item As String In arguments
    '    '    Console.WriteLine(item)
    '    'Next

    '    Console.ReadLine()

    '    End Sub

    Sub Main(ByVal agrs As String)


        Dim result As Boolean = True

        result = result.namespace = 1

        Console.WriteLine(result)
        Console.ReadLine()

    End Sub
End Module
