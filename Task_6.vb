Module Module1

    Sub Main()
        Dim donutCounter As Integer

        donutCounter = 0

        Console.WriteLine("Enter the number of Donuts you have: ")
        donutCounter = Console.ReadLine


        If donutCounter > 10 Then
            Console.WriteLine("Number of Donuts: many")
        Else
            Console.WriteLine("Number of Donuts: " & donutCounter)
        End If

        Console.ReadKey()

    End Sub

End Module
