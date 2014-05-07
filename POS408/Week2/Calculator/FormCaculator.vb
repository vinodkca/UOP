Public Class frmCalculator
    Dim FirstNumber As Single
    Dim SecondNumber As Single
    Dim AnswerNumber As Single
    Dim ArithmeticProcess As String

    Private Sub ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click
        txtResult.Text = txtResult.Text & sender.text
    End Sub

    Private Sub btnDot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDot.Click
        txtResult.Text = txtResult.Text & "."
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        FirstNumber = Val(txtResult.Text)
        txtResult.Text = ""
        ArithmeticProcess = "+"
    End Sub

    Private Sub btnSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSub.Click
        FirstNumber = Val(txtResult.Text)
        txtResult.Text = ""
        ArithmeticProcess = "-"
    End Sub

    Private Sub btnMulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMulti.Click
        FirstNumber = Val(txtResult.Text)
        txtResult.Text = ""
        ArithmeticProcess = "X"
    End Sub

    Private Sub btnDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiv.Click
        FirstNumber = Val(txtResult.Text)
        txtResult.Text = ""
        ArithmeticProcess = "/"
    End Sub


    Private Sub btnEqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEqual.Click
        SecondNumber = Val(txtResult.Text)
        If ArithmeticProcess = "+" Then
            AnswerNumber = FirstNumber + SecondNumber
        End If
        If ArithmeticProcess = "-" Then
            AnswerNumber = FirstNumber - SecondNumber
        End If
        If ArithmeticProcess = "X" Then
            AnswerNumber = FirstNumber * SecondNumber
        End If
        If ArithmeticProcess = "/" Then
            AnswerNumber = FirstNumber / SecondNumber
        End If
        txtResult.Text = AnswerNumber
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtResult.Text = ""
    End Sub
End Class
