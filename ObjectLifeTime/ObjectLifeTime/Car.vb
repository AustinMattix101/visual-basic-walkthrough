Public Class Car
    Public Property Make As String
    Public Property Model As String
    Public Property Year As Integer
    Public Property Color As String

    'Public Sub New()
    '    ' Load this from a configuration file
    '    ' a database, grab it from online,
    '    ' In thisa case, hard code the
    '    ' Make property so that new instances
    '    ' of the Car class will automatically
    '    ' have its Make property populated.
    '    Make = "Nissan"
    'End Sub


    Public Sub New(ByVal makeValuee As String,
                   ByVal modelValue As String,
                   ByVal yearValue As Integer,
                   ByVal colorValue As String)
        Make = makeValuee
        Model = modelValue
        Year = yearValue
        Color = colorValue


    End Sub
End Class

Public Class CarLot

        Public Shared Sub AddToInventory(ByVal newCar As Car)
            ' body of method goes here
            ' I might save this instance of Car
            ' in an array OR better yet, in a collection.


        End Sub

    End Class
