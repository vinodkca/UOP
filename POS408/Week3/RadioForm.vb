Public Class RadioForm
    Dim rbControl() As RadioButton
    Dim rbControl2() As RadioButton
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
        'obj.SortArray()
        'Me.Close()
        'Return
        'Option1
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

        'Option2
        'ReDim rbControl(Array_Size)
        'For i = 0 To Array_Size
        '    rbControl(i) = New RadioButton

        '    With rbControl(i)
        '        .Name = String.Format("rbt_'{0}'", i.ToString)
        '        .Text = String.Format("Radio Button - '{0}'", i.ToString)
        '        .Top = 20 * i
        '        .AutoSize = True
        '    End With

        '    AddHandler rbControl(i).Click, AddressOf MyRadioButton_CheckedChanged
        '    Me.pnlRadioButton.Controls.Add(rbControl(i))
        'Next

    End Sub

    Private Sub rbControl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        rbControl = sender
    End Sub

    'Option2
    Protected Sub MyRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        '   Convert the Sender object into a radio button 
        Dim ClickedRadioButton As RadioButton = DirectCast(sender, RadioButton)

        '   Display the radio button name
        MsgBox(String.Format("Radio Button {0} has been Updated!", ClickedRadioButton.Name), Nothing, "Panel RadioButton")

    End Sub
End Class

'' Add the following line to Sub Form1_Load(). 
'AddHandler Button1.Click, AddressOf Button1_Click

'Public Sub CountSheep()
'    Dim i As Integer = 1 ' Sheep do not count from 0.
'    Do While (True) ' Endless loop.
'        Console.WriteLine("Sheep " & i & " Baah")
'        i = i + 1
'        System.Threading.Thread.Sleep(1000) 'Wait 1 second.
'    Loop
'End Sub

'Sub UseThread()
'    Dim t As New System.Threading.Thread(AddressOf CountSheep)
'    t.Start()
'End Sub
