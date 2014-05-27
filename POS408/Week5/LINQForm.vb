Public Class LINQForm

    Dim lnqExample As LINQExample = New LINQExample()

    Private Sub btnReadObjects_Click(sender As System.Object, e As System.EventArgs) Handles btnReadObjects.Click
        '3.Query execution. 
        Dim arrSample As Integer() = lnqExample.ReadObjects()

        For Each number In arrSample
            lstSample.Items.Add(number)
        Next
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        lstSample.Items.Clear()

    End Sub

    Private Sub btnReadXML_Click(sender As System.Object, e As System.EventArgs) Handles btnReadXML.Click
        'How Do I Access Multiple Elements using LINQ to XML 
        For Each employee In lnqExample.ReadXML()
            'lstSample.Items.Add(employee.Element("Name").Value)
            Dim strElement As String = String.Format("{0} has Employee ID {1}", employee.Element("Name").Value, employee.Element("EmpId").Value)
            lstSample.Items.Add(strElement)
            Dim lstAddress As IEnumerable(Of XElement) = employee.Descendants("Address")
            ''How Do I Find an Element within another Element using LINQ to XML
            'For Each addr As XElement In lstAddress

            '    strElement = String.Format("{0}, {1}, {2}, {3}", addr.Element("Street").Value, _
            '                                addr.Element("City").Value, _
            '                                addr.Element("State").Value, _
            '                                addr.Element("Zip").Value)
            '    lstSample.Items.Add(strElement)
            'Next
        Next employee



    End Sub
End Class
