Public Class frmLottery
    Private Sub frmLottery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'btnExit.Focus() ' For textbox and below is for button
        Me.ActiveControl = btnExit
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub


    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim intNumbers() As Integer
        'Option 2
        'ReDim intNumbers(5) ' U have to sepecify count 5 for passing in Procedure rather than returning by Function or use Array list
        Dim objLottery As New Lottery

        'Option 1
        intNumbers = objLottery.GetRandomNumbers()
        'Option 2
        'objLottery.GetRandomNumbersByProc(intNumbers)
        For iIndex = 0 To intNumbers.Length
            Select Case iIndex
                Case 0
                    txtOne.Text = intNumbers(iIndex).ToString()
                Case 1
                    txtTwo.Text = intNumbers(iIndex).ToString()
                Case 2
                    txtThree.Text = intNumbers(iIndex).ToString()
                Case 3
                    txtFour.Text = intNumbers(iIndex).ToString()
                Case 4
                    txtFive.Text = intNumbers(iIndex).ToString()
                Case 5
                    txtSix.Text = intNumbers(iIndex).ToString()
            End Select
        Next
    End Sub
End Class
