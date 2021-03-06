﻿'Sean Gingerich
'RCET0265
'Fall 2020
'Say My Name Again
'https://github.com/gingsean5/MultiplicationTable

Option Strict On
Option Explicit On

Module MultiplicationTable
    Dim userInput As String
    Dim tableSize As Integer
    Dim problem As Boolean
    Dim temp As Integer
    Sub Main()

        Console.WriteLine("Please enter one number for a multiplication table up to that number's multiples.")
        problem = True
        While problem = True And userInput <> "Q" And userInput <> "q"
            Console.Write("Choose a Number: ")
            Try
                userInput = Console.ReadLine()
                tableSize = CInt(userInput)
                problem = False
            Catch e As Exception
                Console.WriteLine($"You entered {userInput}, please enter a whole number.")
                problem = True
            End Try
            If problem = False Then
                Console.WriteLine($"Enjoy your {userInput} x {userInput} multiplication table")
            End If
        End While
        Dim banana As Integer
        Dim apple As Integer

        For j = 1 To tableSize
            For i = 1 To tableSize
                banana = CInt(i)
                apple = CInt(j)

                temp = banana * apple
                Console.Write(CStr(temp).PadLeft(5))
            Next
            Console.WriteLine()
        Next
        Console.Read()

    End Sub

End Module
