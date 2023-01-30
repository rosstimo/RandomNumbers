Imports System

Module RandomNumbers
    Sub Main(args As String())
        RandomNumber()
    End Sub

    Function RandomNumber() As Integer
        Dim _randomNumber As Integer
        Dim temp As Single
        'Rnd() returns random Single Type from 0 to 1
        'Console.WriteLine(Rnd())

        'a percentage of 6
        'Console.WriteLine(Rnd() * 6)
        'Console.WriteLine(Int(Rnd() * 6))

        Randomize() 'generates a new randomization seed

        temp = Rnd()
        temp *= 6
        _randomNumber = Int(temp)

        Console.WriteLine(temp)
        Console.WriteLine(_randomNumber)




        Return 0
    End Function
End Module
