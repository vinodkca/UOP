Public Class FileForm
    Private objFileInfo As New FileInfo
    Private Sub btnCreateFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateFile.Click
        Dim strError As String = String.Empty
        Dim bNoError As Boolean = False

        bNoError = objFileInfo.SaveTextToFile(txtFile.Text, "test.txt", strError)
        If bNoError Then
            MessageBox.Show("File saved successfully !!!")
        Else
            MessageBox.Show("Error Saving File: " & strError)
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReadFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadFile.Click
        Dim strError As String = String.Empty
        Dim strContents = objFileInfo.GetFileContents("test.txt", strError)
        If strError.Length > 0 Then
            MessageBox.Show("Error Reading File")
        Else
            txtFile.Text = strContents
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtFile.Text = ""
    End Sub

    'Not required just to show vertical scrollbar is done by code and coonot be done on design time
    Private Sub FileForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the Multiline property to true.
        txtFile.Multiline = True
        ' Add vertical scroll bars to the TextBox control.
        txtFile.ScrollBars = ScrollBars.Vertical
        ' Allow the RETURN key in the TextBox control.
        txtFile.AcceptsReturn = True
        ' Allow the TAB key to be entered in the TextBox control.
        txtFile.AcceptsTab = True
        ' Set WordWrap to true to allow text to wrap to the next line.
        txtFile.WordWrap = True
    End Sub
End Class