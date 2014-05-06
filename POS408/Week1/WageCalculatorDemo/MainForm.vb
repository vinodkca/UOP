Public Class MainForm

    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        'MessageBox.Show("Open the Controls Form")
        Dim result1 As DialogResult = MessageBox.Show("Is Dot Net Perls awesome?", _
            "Important Question", _
            MessageBoxButtons.YesNo)

        '   If result1 = DialogResult.Yes And _
        'result2 = DialogResult.Yes And _
        'result3 = DialogResult.No Then
        If result1 = DialogResult.Yes Then
            'MessageBox.Show("You answered yes") ' Another dialog.
            Dim f As New ControlsDemo()
            'f.btnClose.BackColor = Color.Aqua

            f.Show(Me) 'Modelless
            'f.ShowDialog(Me) 'model

            Dim strUserName As String = InputBox("Enter your name")
            MySub(strUserName)
            MessageBox.Show(strUserName)

        End If

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Sub MySub(ByRef strName As String)
        strName += "ME"
    End Sub
End Class