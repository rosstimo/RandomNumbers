Option Strict On
Option Explicit On

Imports System

Module RandomNumbers
    Sub Main(args As String())
        TestRandomness()

    End Sub

    Function RandomNumberExample() As Integer
        Dim _randomNumber As Integer
        Dim temp As Single
        'Rnd() returns random Single Type from 0 to 1
        'Console.WriteLine(Rnd())

        'a percentage of 6
        'Console.WriteLine(Rnd() * 6)
        'Console.WriteLine(Int(Rnd() * 6))

        Randomize(Date.Now.Millisecond * Date.Now.Second) 'generates a new randomization seed

        temp = Rnd()
        Console.WriteLine(temp)
        temp *= 6
        ' _randomNumber = Int(temp)

        Console.WriteLine(temp)
        Console.WriteLine(_randomNumber)

        Return 0
    End Function

    ''' <summary>
    ''' Returns a random integer from 0 to the max value argument
    ''' </summary>
    ''' <param name="max"></param>
    ''' <returns>a random integer</returns>
    Function RandomNumber(max As Integer) As Integer
        Dim _randomNumber As Integer
        ' Dim max As Integer = 10
        Randomize()
        _randomNumber = CInt(Math.Round(Rnd() * max))
        Return _randomNumber
    End Function

    Sub TestRandomness()
        Dim temp As Integer
        Dim numbers(6) As Integer
        Dim row As String
        Dim formattedColumn As String
        Dim columnWidth As Integer = 8

        For i = 0 To 100000
            temp = RandomNumber(5)
            numbers(temp) += 1
        Next

        'add header row
        For i = LBound(numbers) To UBound(numbers)
            formattedColumn = i & " |"
            row &= formattedColumn.PadLeft(columnWidth)
        Next
        Console.WriteLine(row)

        'add separator row
        Console.WriteLine(StrDup(columnWidth * (UBound(numbers) + 1), "-"))

        'add data row
        row = ""
        For i = LBound(numbers) To UBound(numbers)
            formattedColumn = numbers(i) & " |"
            row &= formattedColumn.PadLeft(columnWidth)
        Next

        Console.WriteLine(row)

    End Sub
End Module
