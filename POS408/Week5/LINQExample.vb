Public Class LINQExample
    Function ReadObjects() As Integer()
        '1.Data source. 
        Dim numbers() As Integer = {0, 1, 2, 3, 4, 5, 6}

        '2.Query creation. 
        Dim evensQuery = From num In numbers
                         Where num < 5
                         Select num
        '  Where num Mod 2 = 0
        Return evensQuery.ToArray()
        ''3.Query execution. 
        'For Each number In evensQuery
        '    Console.Write(number & " ")
        'Next
    End Function

    Function ReadXML() As XElement()
        Dim xelement As XElement = xelement.Load("Employees.xml")

        Dim employees As IEnumerable(Of XElement) = xelement.Elements()

        Return employees.ToArray()

        ' Read the entire XML
        'For Each employee In employees
        '    Console.WriteLine(employee)
        'Next employee
    End Function
End Class
