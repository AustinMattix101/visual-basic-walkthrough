Imports System


Module Program
    Sub Main(args As String())

        Dim car1 As Car = New Car()
        car1.Make = "Oldsmobile"
        car1.Model = "Culas Supreme"

        Dim car2 As Car = New Car()
        car2.Make = "Geo"
        car2.Model = "Primsm"

        Dim b1 As Book = New Book()
        b1.Author = "Robert Tabor"
        b1.Title = "Microsoft .NET XML Web Services"
        b1.ISBN = "0-000-00000-0"

        'Dim myArrayList As New ArrayList()
        'myArrayList.Add(car1)
        'myArrayList.Add(car2)
        'myArrayList.Add(b1)
        'myArrayList.Remove(b1)

        'For Each item As Car In myArrayList
        '    Console.WriteLine(item.Make)

        'Next

        'Dim myList As List(Of Car) = New List(Of Car)

        'myList.Add(car1)
        'myList.Add(car2)
        ''myList.Add(b1)


        'For Each item As Car In myList
        '    Console.WriteLine(item.Make)
        'Next

        'Dim myDictionary As New Dictionary(Of String, Car)

        'myDictionary.Add(car1.Make, car1)
        'myDictionary.Add(car2.Make, car2)
        ''myDictionary.Add(b1.Author, b1)
        'Console.WriteLine(myDictionary("Geo").Model)


        'Dim names() As String = {"Eddie", "Alex", "David Lee", "Michael"}

        'Dim myCar As New Car With {.Make = "BMW", .Model = "745li"}
        Dim myListOfCars As New List(Of Car) From {
         New Car With {.Make = "Aston Martin", .Model = "DB9"},
         New Car With {.Make = "Audi", .Model = "A8"},
         New Car With {.Make = "Dodge", .Model = "Dart"}}

        For Each item As Car In myListOfCars
            Console.WriteLine(item.Model)
        Next
        Console.ReadLine()

        '"Generic"

    End Sub
End Module
