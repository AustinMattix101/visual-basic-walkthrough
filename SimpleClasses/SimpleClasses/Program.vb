Imports System

Module Program
    Sub Main()

        'Dim car1Make As String
        'Dim car1Model As String
        'Dim car1Year As Integer
        'Dim car1Color As String

        Dim myCar As Car
        myCar = New Car()
        myCar.Make = "Toyota"
        myCar.Model = "4Runner"
        myCar.Year = 2010
        myCar.Color = "White"

        Dim myOtherCar As New Car()

        myOtherCar.Make = "Honda"
        myOtherCar.Model = "Accord"
        myOtherCar.Year = 2012
        myOtherCar.Color = "Black"

        'Console.WriteLine("{0} {1}", myCar.Make, determineMarketValue(myCar))
        'Console.WriteLine("{0} {1}", myOtherCar.Make, myOtherCar.Year)

        Console.WriteLine("{0} {1:C}", myCar.Make, myCar.MarketValue())

        Console.ReadLine()


    End Sub

    Function determineMarketValue(ByVal myCar As Car) As Decimal
        'Super secret formula
        'Search online to find the value of the car 
        Return 100.0
    End Function

End Module
