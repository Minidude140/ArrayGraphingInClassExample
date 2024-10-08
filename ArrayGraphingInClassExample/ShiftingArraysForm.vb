Public Class ShiftingArraysForm



    ''' <summary>
    ''' Given a minimum and maximum, returns a random number within range.  
    ''' <br/>
    ''' Defaults:
    ''' <br/>
    ''' Min = 0     Max = 10
    ''' </summary>
    ''' <param name="min"></param>
    ''' <param name="max"></param>
    ''' <returns></returns>
    Function RandomNumberFrom(Optional min As Integer = 0, Optional max As Integer = 10) As Integer
        Dim _random As Integer
        'max = max + 1 to still get the max number (floor always rounds down)
        max += 1
        'randomize with current millisecond as seed
        Randomize(DateTime.Now.Millisecond)
        'set random number as random within bounds
        _random = CInt(Math.Floor(Rnd() * (max - min))) + min
        Return _random
    End Function

    ''' <summary>
    ''' Tests the Random Number Generator By Producing 1000 Numbers and Outputting the Results to Console
    ''' </summary>
    Sub TestRandomNumbers()
        'create and array to track the random numbers
        Dim Randomness(10) As Integer
        For i = 1 To 1000
            'creates 1000 random numbers and stores the number of times the number is pulled
            Dim testNumber As Integer = RandomNumberFrom()
            Randomness(testNumber) += 1
        Next
        'write to the console the results of the test
        For i = LBound(Randomness) To UBound(Randomness)
            Console.WriteLine(CStr(Randomness(i)).PadLeft(4))
        Next
    End Sub
    Private Sub ShiftingArraysForm_load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
