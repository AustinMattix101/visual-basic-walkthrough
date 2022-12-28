Public Class Car
    Public Property Make As String
    Public Property Model As String
    Public Property Year As Integer
    Public Property Color As String


    Public Sub DoSomethingImportant()
        Console.WriteLine(helperMethod())
    End Sub

    Private Function helperMethod() As String
        Return "Howdy Partner"
    End Function

End Class
