Module Module1

    Sub Main()

        'courtesy stackoverflow

        Console.Write("Enter String: ")
        Dim Str1 As String = Console.ReadLine()

        Dim Char1 As Char
        Dim highChar As Char
        Dim maxCount As Integer
        Dim highCount(Len(Str1)) As Integer

        For n = 1 To Len(Str1)
            Char1 = Mid(Str1, n, 1)
            highCount(n) = Str1.Count(Function(x) LCase(x) = Char1)
            If highCount(n) > maxCount Then
                maxCount = highCount(n)
                highChar = Mid(Str1, n, 1)
            End If
        Next

        Console.WriteLine("The character that appears the most is: " & highChar)
        Console.WriteLine("It appears: " & maxCount)

        Console.ReadLine()
    End Sub

End Module
