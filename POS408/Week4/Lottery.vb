Public Class Lottery

    Const intMAX_SUBSCRIPT As Integer = 5
    ' Array declaration
    Dim intNumbers(intMAX_SUBSCRIPT) As Integer

    Function GetRandomNumbers() As Integer()
        ' Create a Random object.
        Dim rand As New Random
        ' Loop counter
        Dim intCount As Integer
        ' Fill the array with random numbers.
        ' Each number will be in the range 0-99.
        For intCount = 0 To intMAX_SUBSCRIPT
            intNumbers(intCount) = rand.Next(100)
        Next
        Return intNumbers
    End Function

    Sub GetRandomNumbersByProc(ByVal intNumbers() As Integer)
        ' Create a Random object.
        Dim rand As New Random
        ' Loop counter
        Dim intCount As Integer
        For intCount = 0 To intMAX_SUBSCRIPT
            intNumbers(intCount) = rand.Next(100)
        Next
    End Sub

End Class
