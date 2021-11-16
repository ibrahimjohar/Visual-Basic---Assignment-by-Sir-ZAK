Module Module1

    Sub Main()
        Dim Str1 As String
        Dim n As Integer
        Dim Char1 As Char
        Dim alphabetCounter As Integer
        Dim numberCounter As Integer
        Dim specialCounter As Integer

        Str1 = ""
        n = 0
        Char1 = ""
        alphabetCounter = 0
        numberCounter = 0
        specialCounter = 0

        Console.Write("Enter your desired string: ")
        Str1 = Console.ReadLine

        For n = 1 To Len(Str1)
            Char1 = Mid(Str1, n, 1)
            Char1 = UCase(Char1)
            If Char1 >= "A" And Char1 <= "Z" Then
                alphabetCounter = alphabetCounter + 1
            ElseIf Char1 >= "0" And Char1 <= "9" Then
                numberCounter = numberCounter + 1
            ElseIf Char1 >= "!" And Char1 <= "/" Then
                specialCounter = specialCounter + 1
            End If
        Next

        Console.WriteLine("Total Characters are: " & Len(Str1))
        Console.WriteLine("Number of Alphabets are: " & alphabetCounter)
        Console.WriteLine("Number of Digits/Numerics are: " & numberCounter)
        Console.WriteLine("Special Charaters are: " & specialCounter)



        Console.ReadKey()


    End Sub

End Module
