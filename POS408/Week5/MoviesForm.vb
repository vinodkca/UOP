Public Class MoviesForm

    Private Sub MoviesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgrMovies.AllowUserToAddRows = False
    End Sub

    Private Sub btnFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFill.Click
        SampleFill()
    End Sub

    Private Sub btnStartsA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartsA.Click
        SampleStartWithA()
    End Sub

    Private Sub btnSorted_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSorted.Click
        SamplSorted()
    End Sub

    Private Sub SampleFill()
        Dim dc As New LINQMoviesDataContext()
        Dim q = _
            From a In dc.GetTable(Of Movie)() _
            Select a
        dgrMovies.DataSource = q
    End Sub

    Private Sub SampleStartWithA()
        Dim dc As New LINQMoviesDataContext()
        Dim q = _
            From a In dc.GetTable(Of Movie)() _
            Where a.MovieName.StartsWith("A") _
            Select a
        dgrMovies.DataSource = q
    End Sub

    Private Sub SamplSorted()
        Dim dc As New LINQMoviesDataContext()
        Dim q = _
            From a In dc.GetTable(Of Movie)()
            Order By a.YearPublished Ascending
            Select a
        dgrMovies.DataSource = q
    End Sub

    Private Sub dgrMovies_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrMovies.CellClick
        For Each dc As DataGridViewColumn In dgrMovies.Columns
            dc.ReadOnly = True
        Next
    End Sub
End Class