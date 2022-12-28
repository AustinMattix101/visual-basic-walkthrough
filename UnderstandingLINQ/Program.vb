Imports System

Module Program
    Sub Main(args As String())

        Dim myCars As New List(Of Car) From {
            New Car With {.Make = "BMW", .Model = "550i", .StickerPrice = 55000, .Year = 2009},
            New Car With {.Make = "Toyota", .Model = "4Runner", .StickerPrice = 35000, .Year = 2010},
            New Car With {.Make = "BMW", .Model = "745li", .StickerPrice = 75000, .Year = 2008},
            New Car With {.Make = "Ford", .Model = "Escape", .StickerPrice = 28000, .Year = 2008},
            New Car With {.Make = "BMW", .Model = "550i", .StickerPrice = 57000, .Year = 2010}}


        'Dim bmws = From car In myCars
        '           Where car.Make = "BMW"
        '           Select car

        'Dim bmws = From car In myCars
        '           Where car.Make = "BMW" And car.Year = 2010
        '           Select car

        'Dim newCars = From car In myCars
        '              Where car.Year > 2009
        '              Select New With {car.Make, car.Model}


        'Dim orderedCars = From car In myCars
        '                  Order By car.Year Descending
        '                  Select car

        'Dim bmws = myCars.Where(Function(car) car.Make = "BMW")

        'Dim bmws = myCars.Where(Function(car) car.Make = "BMW").Where(Function(car) car.Year = 2010)

        'Dim orderedCars = myCars.OrderByDescending(Function(car) car.Year)



        'For Each item As Car In orderedCars
        '    Console.WriteLine("{0} {1} {2}", item.Make, item.Model, item.Year)
        'Next


        'Dim sum = myCars.Sum(Function(car) car.StickerPrice)

        'Console.WriteLine("Total Value: {0:C}", sum)

        'myCars.ForEach(Sub(car) car.StickerPrice += 10000)
        'Dim sum = myCars.Sum(Function(car) car.StickerPrice)

        Console.WriteLine("Total Value: {0:C}", myCars.Sum(
                          Function(car)
                              Return car.StickerPrice + 10000
                          End Function))


        Console.ReadLine()

    End Sub
End Module
