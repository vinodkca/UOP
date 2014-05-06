Namespace Model ' 3
    Public Class Book
        'Public Access 1
        Public Title As String

        'Private StrTitle As String 2
        Private strTitle As String
        Public Property BookName() As String
            Get
                Return strTitle
            End Get
            Set(ByVal value As String)
                strTitle = value
            End Set
        End Property

        'Protected 4
        'Protected ISDN As Integer

        'Friend 4
        Friend ISBN As Integer


    End Class

End Namespace
