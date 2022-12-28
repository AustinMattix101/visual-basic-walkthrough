Public Class Car

    Public Property Make As String
    Public Property Model As String
    Public Property Year As Integer
    Public Property Color As String

    'Private newPropertyValue As String
    'Public Property NewProperty() As String
    '    Get
    '        Return newPropertyValue
    '    End Get
    '    Set(ByVal value As String)

    '        newPropertyValue = value
    '    End Set
    'End Property

    Public Function MarketValue() As Decimal

        ' Super secret formula
        ' Look online for the value

        Dim carValue As Decimal
        If Year > 1990 Then
            carValue = 10000.0
        Else
            carValue = 2000.0
        End If


        Return carValue

    End Function

End Class
