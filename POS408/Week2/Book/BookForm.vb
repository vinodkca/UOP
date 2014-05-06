Public Class BookForm

    Private Sub BookForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Dim bk As New Model.Book
        'Dim bkSub As New Model.SubBook
        'bkSub.AssignISDN()
        'bk = bkSub

        'bk.Title = "Title of Book1"
        'bk.BookName = "Good Book"

        'txtBookName.Text = bk.BookName  ' bk.Title
        ''txtISDN.Text = bk.ISDN 'Not OK for protected
        'txtISDN.Text = bk.ISDN

        InitializeValues()
    End Sub

    Private Sub InitializeValues()
        Dim bk As New Model.Book
        Dim bkSub As New Model.SubBook
        bkSub.AssignISDN()
        bk = bkSub

        bk.Title = "Title of Book1"
        bk.BookName = "Good Book"

        txtBookName.Text = bk.BookName  ' bk.Title
        'txtISDN.Text = bk.ISDN 'Not OK for protected
        txtISDN.Text = bk.ISBN
        Try
            ' Throw New ApplicationException("A custom exception " &
            '    "is being thrown here...")

            txtISDN.Text = CalculateISDN(Convert.ToInt32("name"))
        Catch ex As FormatException
            MessageBox.Show("Format:  " + ex.Message)
        Catch exall As Exception
            MessageBox.Show(exall.Message)
        Finally
            ' This line executes whether or not the exception occurs.
            MessageBox.Show("in Finally block")
        End Try

    End Sub

    Function CalculateISDN(ByVal j As Integer) As Double
        Return 3.87 * j
    End Function

End Class
