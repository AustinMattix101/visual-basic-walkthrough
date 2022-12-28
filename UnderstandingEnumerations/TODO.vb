Public Class TODO
    Public Property ID As Integer
    Public Property Title As String
    Public Property Description As String
    Public Property DueDate As Date
    Public Property Status As TodoStatus

End Class

Public Enum TodoStatus
    NotStarted
    InProgress
    OnHold
    Completed
    Deleted
End Enum
