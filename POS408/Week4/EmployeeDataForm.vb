Imports System.IO

Public Class frmEmployeeData

    Private Sub frmEmployeeData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ActiveControl = Me.btnExit
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        SetControls()
    End Sub

    Private Sub SetControls()
        Dim ctl As Control, cbx As ComboBox
        'Loop through text control in group box
        For Each ctl In Me.gbxEmployeeData.Controls
            If (TypeOf ctl Is TextBox) Then
                ctl.Text = String.Empty
            End If
            If (TypeOf ctl Is ComboBox) Then ' If the Control in the GroupBox is a ComboBox then Set the Text to ""
                cbx = CType(ctl, ComboBox)
                'cbx.Text = String.Empty 'For dropdown
                cbx.SelectedIndex = -1    'For dropdownlist
            End If
        Next
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim strToken As String = ","
            Dim strSep As String = ":"
            Dim EmpID As Integer = GetRecID()
            Dim strEmpID As String = "EmpID" & strSep & EmpID & strToken
            Dim ctlName As String
            ' Declare an object variable 'File.AppendText("EmployeeData.txt")
            Dim objWriter As StreamWriter = New StreamWriter("EmployeeData.txt", True)

            objWriter.Write(strEmpID)

            For Each ctl In Me.gbxEmployeeData.Controls
                If (TypeOf ctl Is TextBox) Then
                    ctlName = SubString(ctl.Name)
                    ctlName = ctlName & strSep & ctl.Text & strToken
                    objWriter.Write(ctlName)
                End If
                If (TypeOf ctl Is ComboBox) Then ' If the Control in the GroupBox is a ComboBox then Set the Text to ""
                    Dim cbx As ComboBox = CType(ctl, ComboBox)
                    ctlName = SubString(cbx.Name)
                    ctlName = ctlName & strSep & cbx.SelectedItem & strToken
                    objWriter.Write(ctlName)
                End If
            Next

            objWriter.WriteLine()
            objWriter.Close()
            SetRecID(EmpID)
            MessageBox.Show("Successfully saved the record !!!")

        Catch ex As Exception
            MessageBox.Show("Failed to Save the record")
        End Try
    End Sub

  
    'Private Function SetRecID(ByVal ID As Integer)
    'Write the ID to the file
    Private Sub SetRecID(ByVal ID As Integer)
        Dim objWriterRecID As StreamWriter = New StreamWriter("RecID.txt", False)
        objWriterRecID.WriteLine(ID)
        objWriterRecID.Close()
        'Return Nothing
        'End Function
    End Sub

    Private Function GetRecID() As Integer
        Dim RecID As Integer
        Dim objReader As StreamReader = Nothing
        Try
            objReader = New StreamReader("RecID.txt") 'File.OpenText("RecID.txt")
            Dim strContent As String = objReader.ReadLine()
            If Not strContent Is Nothing Then
                RecID = CInt(strContent)
            Else
                RecID = 0
            End If
        Catch ex As IOException
            RecID = 0
        Finally
            If Not (objReader Is Nothing) Then
                objReader.Close()
            End If
        End Try

        Return RecID + 1
    End Function

    Public Function SubString(strName As String) As String
        If Not (strName Is Nothing) And strName.Length > 0 Then
            Return strName.Substring(3)
        End If
        Return String.Empty
    End Function
End Class