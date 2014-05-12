Public Class ArraySample
    'http://www.tutorialspoint.com/vb.net/vb.net_arrays.htm
    'Creating Arrays in VB.Net
    Dim intData(30)   ' an array of 31 elements
    Dim strData(20) As String   ' an array of 21 strings

    'initialize the array elements while declaring the array
    Dim intData1() As Integer = {12, 16, 20, 24, 28, 32}
    Dim names() As String = {"Emp1", "Emp2", _
    "Emp3", "Emp4", "Emp5"}
    Dim miscData() As Object = {"Hello World", 12, 16.0, "A"c}

    Function Datalength() As Integer
        Return strData.Length
    End Function

    Sub OutputArray()
        Dim strArr As String = String.Empty
        For j = 0 To names.Length - 1
            strArr += String.Format("Element({0}) = {1}", j, names(j)) & Environment.NewLine '& vbTab &
        Next j
        MessageBox.Show(strArr)
    End Sub


    'Dynamic Arrays

    'Dynamic arrays are arrays that can be dimensioned and re-dimensioned as par the need of the program. You can declare a dynamic array using the ReDim statement. 

    'Syntax for ReDim statement:
    'ReDim [Preserve] arrayname(subscripts)

    Sub DynamicArray()
        ReDim Preserve names(2) ' 0,1,2
        'ReDim names(2) ' 0,1,2

        OutputArray()
    End Sub

    'Original Array: 34 72 13 44 25 30 10
    'Reversed Array: 10 30 25 44 13 72 34
    'Sorted Array: 10 13 25 30 34 44 72
    Sub ReverseArray()
        Array.Reverse(names)
        OutputArray()
    End Sub

    Sub SortArray()
        Array.Sort(names)
        OutputArray()
    End Sub


End Class
