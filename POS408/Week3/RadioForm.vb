Public Class RadioForm
    Dim rbControl() As RadioButton
    Dim Array_Size As Integer = 5

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnClick.Click
        For i = 0 To Array_Size
            If rbControl(i).Checked Then
                MsgBox(rbControl(i).Text)
                'Exit For
                'Return
                GoTo endFor

            End If
        Next
endFor:
        'MessageBox.Show("exited for")
        Return
Line1:
        Dim a As Integer = 10
        Do
            If (a = 15) Then
                ' skip the iteration '
                a = a + 1
                GoTo Line1
            End If
            Console.WriteLine("value of a: {0}", a)
            a = a + 1
        Loop While (a < 20)
        Console.ReadLine()
    End Sub



    Private Sub RadioForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim obj As New ArraySample
        'MessageBox.Show(obj.Datalength())
        'obj.OutputArray()
        'obj.DynamicArray()
        'obj.ReverseArray()
        obj.SortArray()
        Me.Close()
        Return
        ReDim rbControl(Array_Size)
        For i = 0 To Array_Size
            rbControl(i) = New RadioButton
            rbControl(i).Text = "Radio Button " + i.ToString
            If i = 0 Then
                rbControl(i).Top = 20
            Else
                rbControl(i).Top = 20 * i
            End If

            rbControl(i).Left = 20
            Me.Controls.Add(rbControl(i))
        Next

    End Sub
End Class
