Imports System

Module Program
    Sub Main(args As String())

        Dim timer As New Timers.Timer(1000)

        AddHandler timer.Elapsed, AddressOf Program.HandleTimer1
        AddHandler timer.Elapsed, AddressOf Program.HandleTimer2


        timer.Start()
        Console.WriteLine("Press Enter to stop handling the event twice.")
        Console.ReadLine()
        timer.Stop()

        RemoveHandler timer.Elapsed, AddressOf Program.HandleTimer2

        timer.Start()
        Console.ReadLine()
        timer.Stop()

    End Sub

    Private Sub HandleTimer2(sender As Object, e As Timers.ElapsedEventArgs)
        Console.WriteLine("HandleTheTimer2 Event {0:HH:MM:ss:fff}", e.SignalTime)
    End Sub

    Private Sub HandleTimer1(sender As Object, e As Timers.ElapsedEventArgs)
        Console.WriteLine("HandleTheTimer1 Event {0:HH:MM:ss:fff}", e.SignalTime)



    End Sub
End Module
