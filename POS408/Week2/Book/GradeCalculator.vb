Public Class GradeCalculator

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        '1
        txtGrade.Text = PrintGradeFunc()
        '2
        'PrintGrade()

    End Sub
    Private Function PrintGradeFunc()
        Dim Grade As String
        'Examination Marks
        Dim score As Integer
        score = Convert.ToInt32(txtScore.Text)

        If score >= 80 Then
            Grade = "A"
        ElseIf score >= 60 And score < 80 Then
            Grade = "B"

        ElseIf score >= 40 And score < 60 Then
            Grade = "C"
        Else
            Grade = "D"
            Return Grade
        End If
    End Function

    Private Sub PrintGradeSelect()

        'Examination Marks
        Dim score As Integer
        score = Convert.ToInt32(txtScore.Text)

        Select Case score
            Case 0 To 49
                txtGrade.Text = "E"
            Case 50 To 59
                txtGrade.Text = "D"
            Case 60 To 69
                txtGrade.Text = "C"
            Case 70 To 79
                txtGrade.Text = "B"
            Case 80 To 100
                txtGrade.Text = "A"
            Case Else
                txtGrade.Text = "Error, please reenter the mark"

        End Select
    End Sub



End Class