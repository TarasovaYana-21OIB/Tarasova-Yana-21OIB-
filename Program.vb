Imports System

Module Program
    Private brush As Char = "0"c
    Sub Main(args As String())
        Dim A As Char

        Console.WriteLine("1-горизонтальная линия, 2-вертикальная линия, 3-линейка, 4-незакрашенный квадрат, 5-квадратное поле, 6-цветное квадратное поле, 7-закрашенный квадрат")
        A = Console.ReadLine()
        Select Case A
            Case "1"c : hline(10, 5, 70)
            Case "2"c : vline(10, 5, 40)
            Case "3"c
                For j As Byte = 1 To 8
                    hline(10, 5 + j, 70)
                Next
            Case "4"c : Rect(10, 5, 20, 40)
            Case "5"c
                For j As Byte = 1 To 9
                    hline(10, 5 + j, 71)
                Next
                For j As Byte = 1 To 5
                    vline(10 + j, 5, 40)
                Next
            Case "6"c
                Console.ForegroundColor = ConsoleColor.Black
                Console.BackgroundColor = ConsoleColor.Yellow
                For j As Byte = 1 To 9
                    hline(10, 5 + j, 71)
                Next
                For j As Byte = 1 To 5
                    vline(10 + j, 5, 40)
                Next
            Case "7"c : filRect(10, 5, 20, 40)
            Case "8"c
        End Select
    End Sub
    Sub hline(leftx As Byte, topy As Byte, length As Byte)
        Console.SetCursorPosition(leftx, topy)
        For j = 1 To length
            Console.Write("F")
        Next
    End Sub
    Sub vline(leftx As Byte, topy As Byte, length As Byte)
        For i = 1 To length - 1
            Console.SetCursorPosition(leftx, topy + i)
            Console.Write("F")
        Next
    End Sub
    Sub filRect(leftx As Byte, topy As Byte, width As Byte, height As Byte)
        For i = 0 To height - 1
            hline(leftx, topy + i, width)
        Next
    End Sub
    Sub Rect(leftx As Byte, topy As Byte, width As Byte, height As Byte)
        hline(leftx, topy, width)
        vline(leftx, topy + height, width)
        hline(leftx, topy, height)
        vline(leftx, width, height)
    End Sub
End Module