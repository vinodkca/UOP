Public Class WebBrowser

    Private Sub btnGo_Click(sender As System.Object, e As System.EventArgs) Handles btnGo.Click
        webDisplay.Navigate(txtURL.Text)
    End Sub
End Class