Public Class WorkshopSelectorForm

    'initialize the array elements while declaring the array
    Dim intDays() As String = {3, 3, 3, 5, 1}
    Dim dblRegistraion() As Double = {595, 695, 995, 1295, 395}
    
    Private Sub WorkshopSelectorForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        lstWorkshop.Items.Add("Handling Stress")
        lstWorkshop.Items.Add("Time Management")
        lstWorkshop.Items.Add("Supervision Skills")
        lstWorkshop.Items.Add("Negotiation")
        lstWorkshop.Items.Add("How to Interview")

    End Sub


    Private Sub btnTotal_Click(sender As System.Object, e As System.EventArgs) Handles btnTotal.Click
        Dim totalCost As Double
        For iIndex As Integer = 0 To lstCost.Items.Count - 1
            Dim dblCost As Double = CDbl(lstCost.Items(iIndex))
            totalCost = totalCost + dblCost
        Next
        txtTotalCost.Text = (totalCost).ToString("c")
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim locCost, lodgingCost, regCost As Double
        Dim iIndex As Integer
        If lstWorkshop.SelectedIndex > -1 Then
            iIndex = lstWorkshop.SelectedIndex

            Select Case lstLocation.SelectedIndex
                Case 0
                    locCost = My.Settings.Loc0
                Case 1
                    locCost = My.Settings.Loc1
                Case 2
                    locCost = My.Settings.Loc2
                Case 3
                    locCost = My.Settings.Loc3
                Case 4
                    locCost = My.Settings.Loc4
                Case 5
                    locCost = My.Settings.Loc5
                Case Else
                    locCost = 0
            End Select
            regCost = dblRegistraion(iIndex)
            lodgingCost = intDays(iIndex) * locCost

            lstCost.Items.Add(regCost + lodgingCost)

            lstWorkshop.SelectedIndex = -1
            lstLocation.SelectedIndex = -1

        End If

    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click

        lstWorkshop.SelectedIndex = -1
        lstLocation.SelectedIndex = -1
        lstCost.Items.Clear()
        txtTotalCost.Text = String.Empty
    End Sub
End Class