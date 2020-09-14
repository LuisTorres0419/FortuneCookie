'Luis Torres
'RCET0265
'spring 2020
'Fortune Cookie
'https://github.com/LuisTorres0419/FortuneCookie.git

Option Strict On
Option Explicit On
Option Compare Text

Module FortuneCookie

    Sub Main()
        Dim randomNumber As Integer
        Randomize()
        Dim quit As String

        Do
            Console.WriteLine("you feeling lucky are you press enter for a fortune!")
            quit = Console.ReadLine()

            If quit = "q" Then
                Exit Sub
            End If

            randomNumber = GetRandomNumber(1, 2)

            Select Case randomNumber
                Case 1
                    Console.WriteLine("you will have a great day")
                Case 2
                    Console.WriteLine("You will be handsome soon")
                Case 3
                    Console.WriteLine("You will over through that king")
            End Select

            quit = Console.ReadLine()

            If quit = "q" Then
                Exit Sub
            End If

            Console.Clear()
        Loop
    End Sub

    Function GetRandomNumber(ByVal Minimum As Integer, ByVal Maximum As Integer) As Integer

        Dim value As Single
        value = ((Maximum - Minimum + 1) * Rnd()) + Minimum
        Return CInt(value)

    End Function

End Module
