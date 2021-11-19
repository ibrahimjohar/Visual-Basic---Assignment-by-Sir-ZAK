Module Module1

    Sub Main()
        Dim s, first2, last2 As String
        Dim char1 As Char
        Dim counter1 As Integer

        s = ""
        char1 = ""
        counter1 = 0
        first2 = ""
        last2 = ""


        Console.WriteLine("Enter your string (s): ")
        s = Console.ReadLine

        If Len(s) < 4 Then
            Console.WriteLine("bothends output: s")
        Else
            first2 = (Left(s, 2))
            last2 = (Right(s, 2))

            Console.WriteLine(first2 & last2)

            counter1 = Len(first2 & last2)
            Console.WriteLine("total characters: " & counter1)
        End If


        Console.ReadKey()


    End Sub

End Module
