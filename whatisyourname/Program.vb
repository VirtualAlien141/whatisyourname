Imports System

Module Program
    Sub Main(args As String())
        Console.Write("Please enter your name: ")
        Dim Name = Console.ReadLine()
        Dim currentDate = DateTime.Now
        Console.WriteLine($"Hello, {Name}, on {currentDate:d} at {currentDate:t}")
        Console.Write("Press any key to continue...")
        Console.ReadKey(True)
    End Sub
End Module
