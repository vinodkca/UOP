Public Class ListForm
    Private Sub ListForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Movies Form"
    End Sub
    Private Sub btnFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFill.Click
        'Change the title bar
        lstMovie.Items.Add("Gravity")
        lstMovie.Items.Add("Captain Phillips")
        lstMovie.Items.Add("The Wolf of Wall Street")
        lstMovie.Items.Add("12 Years a Slave")
        lstMovie.Items.Add("Short Term 12")
    End Sub

    Private Sub btnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        lstMovie.Sorted = True
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstMovie.Items.Clear()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        lstMovie.Items.Remove(lstMovie.SelectedItem)
    End Sub

    'Important 5
    Private Sub btnCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCount.Click
        lblCount.Text = lstMovie.Items.Count
    End Sub

    'Important 6
    Private Sub lstMovie_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstMovie.SelectedIndexChanged
        If Not lstMovie.SelectedItem Is Nothing Then
            lblSelection.Text = lstMovie.SelectedItem.ToString()
        End If
    End Sub
End Class