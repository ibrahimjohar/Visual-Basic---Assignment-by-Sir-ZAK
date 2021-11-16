Module Module1

    Sub Main()

        Dim Str1, alpha As String
        Dim n As Integer
        Dim isPangram As Boolean
        Dim thisAlpha As Char

        Str1 = ""
        n = 0
        isPangram = True
        thisAlpha = ""
        alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"


        Console.Write("Enter string: ")
        Str1 = Console.ReadLine()
        Str1 = UCase(Str1)

        For i = 1 To 26
            thisAlpha = Mid(alpha, i, 1)
            n = InStr(Str1, thisAlpha)
            If n = 0 Then isPangram = False
        Next


        If isPangram = False Then
            Console.Write("incorrect input!")
        Else : Console.Write("correct")
        End If

        Console.ReadKey()

    End Sub

End Module
