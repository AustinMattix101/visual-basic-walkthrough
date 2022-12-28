Imports System

Module Program
    Sub Main()

        Dim myCar As New Car()

        'Console.WriteLine(myCar.Make)

        'myCar.Make = "Toyota"
        'myCar.Model = "4Runner"
        'myCar.Year = 2010
        'myCar.Color = "White"


        Dim myCar As New Car("Toyota", "4Runner", 2010, "White")

        Dim myOtherCar As Car = myCar


        Console.WriteLine(myOtherCar.Make)
        myOtherCar.Color = "Black"


        CarLot.AddToInventory(myCar)

        myOtherCar = Nothing
        myCar = Nothing

        'Console.WriteLine(myCar.Color)
        'Console.WriteLine(myOtherCar.Color)
        Console.ReadLine()
    End Sub
End Module
