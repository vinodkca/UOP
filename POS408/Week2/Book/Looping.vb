Public Class Looping
    'vbCrLf = "\r\n"
    'vbCr = "\r"
    'vbLf = "\n"
    'vbNewLine
    'Environment.NewLine.

    Private Sub btnWhile_Click(sender As System.Object, e As System.EventArgs) Handles btnWhile.Click
        Dim sum, n As Integer
        lstLoop.Items.Add("n" & vbTab & "sum")
        lstLoop.Items.Add("----------------------")
        While n <> 10
            n += 1
            sum = sum + n
            lstLoop.Items.Add(n & vbTab & sum)
        End While
        lstLoop.Items.Add(vbNewLine)
    End Sub

    Private Sub btnDoWhile_Click(sender As System.Object, e As System.EventArgs) Handles btnDoWhile.Click

        Dim sum, n As Integer
        lstLoop.Items.Add(vbNewLine)
        lstLoop.Items.Add("n" & vbTab & "sum")
        lstLoop.Items.Add("----------------------")

        Do
            n += 1
            sum += n
            lstLoop.Items.Add(n & vbTab & sum)

            If n = 10 Then
                Exit Do
            End If
        Loop
        lstLoop.Items.Add(vbNewLine)
    End Sub

    Private Sub btnFor_Click(sender As System.Object, e As System.EventArgs) Handles btnFor.Click
        Dim sum, n As Integer
        lstLoop.Items.Add("n" & vbTab & "sum")
        lstLoop.Items.Add("----------------------")
        For n = 1 To 10
            If n > 6 Then
                Exit For
            End If
            sum += n
            lstLoop.Items.Add(n & vbTab & sum)
        Next
        lstLoop.Items.Add(vbNewLine)
    End Sub
End Class