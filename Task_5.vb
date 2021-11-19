Module Module1

    Sub Main()
        Dim Str1 As String
        Dim myCounter, aCounter, eCounter, iCounter, oCounter, uCounter As Integer
        Dim Char1, A, E, I, O, U As Char

        Str1 = ""
        myCounter = 0
        aCounter = 0
        eCounter = 0
        iCounter = 0
        oCounter = 0
        uCounter = 0
        A = ""
        E = ""
        I = ""
        O = ""
        U = ""
        Char1 = ""

        Console.WriteLine("Enter your string: ")
        Str1 = Console.ReadLine
        Str1 = UCase(Str1)

        For myCounter = 1 To Len(Str1)
            Char1 = Mid(Str1, myCounter, 1)
            If InStr("A", Char1) Then
                aCounter = aCounter + 1
            End If
        Next

        For myCounter = 1 To Len(Str1)
            Char1 = Mid(Str1, myCounter, 1)
            If InStr("E", Char1) Then
                eCounter = eCounter + 1
            End If
        Next

        For myCounter = 1 To Len(Str1)
            Char1 = Mid(Str1, myCounter, 1)
            If InStr("I", Char1) Then
                iCounter = iCounter + 1
            End If
        Next

        For myCounter = 1 To Len(Str1)
            Char1 = Mid(Str1, myCounter, 1)
            If InStr("O", Char1) Then
                oCounter = oCounter + 1
            End If
        Next


        For myCounter = 1 To Len(Str1)
            Char1 = Mid(Str1, myCounter, 1)
            If InStr("U", Char1) Then
                uCounter = uCounter + 1
            End If
        Next



        Console.WriteLine("No. of As: " & aCounter)
        Console.WriteLine("No. of Es: " & eCounter)
        Console.WriteLine("No. of Is: " & iCounter)
        Console.WriteLine("No. of Os: " & oCounter)
        Console.WriteLine("No. of Us: " & uCounter)


        Console.ReadKey()


    End Sub

End Module
