Module Module1

    Sub Main()
        Dim Str1 As String
        Dim Str2 As String
        Dim searchChar As Char
        Dim processChar As Char
        Dim replaceChar As Char
        Dim i As Integer
        Dim n As Integer

        Str1 = ""
        Str2 = ""
        i = 0
        searchChar = ""
        processChar = ""
        replaceChar = ""
        n = 0

        Console.Write("Enter your string: ")
        Str1 = Console.ReadLine

        Console.Write("Enter character to select from your string: ")
        searchChar = Console.ReadLine


        Console.Write("Enter desired character to replace in your string: ")
        replaceChar = Console.ReadLine

        For i = 1 To Len(Str1)
            processChar = Mid(Str1, i, 1)
            If searchChar <> processChar Then
                Str2 = Str2 & processChar
            Else
                Str2 = Str2 & replaceChar
            End If
        Next


        Console.WriteLine("Your string after replacement is: " & Str2)

        Console.ReadKey()

    End Sub

End Module
