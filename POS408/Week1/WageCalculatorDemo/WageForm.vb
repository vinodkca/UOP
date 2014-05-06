Public Class WageForm

    Private Sub btnGrossPay_Click(sender As System.Object, e As System.EventArgs) Handles btnGrossPay.Click
        ' Declare variables we will use in the calculations.
        Dim dblHoursWorked As Double
        Dim dblPayRate As Double
        Dim dblGrossPay As Double

        ' Get the hours worked from the TextBox control.
        dblHoursWorked = CDbl(txtHoursWorked.Text)

        ' Get the hourly pay rate from the TextBox control.
        dblPayRate = CDbl(txtPayrate.Text)

        ' Calculate the employee's gross pay.
        dblGrossPay = dblHoursWorked * dblPayRate

        ' Assign the gross pay to a Label control,
        ' with currency formatting.
        lblGrossPay.Text = dblGrossPay.ToString("c")
    End Sub

    Private Sub btmClose_Click(sender As System.Object, e As System.EventArgs) Handles btmClose.Click
        Me.Close()
    End Sub

    Private Sub WageForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'e.Cancel = True
        If MessageBox.Show("Do you want to save changes to your text?", "My Application", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ' Cancel the Closing event from closing the form.
            e.Cancel = True
        End If ' Call method to save file...


    End Sub

    Private Sub WageForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        'Me.WindowState = FormWindowState.Minimized
        'Me.Hide()
        ''FormBorderStyle to FixedToolWindows or SizableToolWindow. 'In properties windoe

    End Sub

    Private Sub WageForm_MaximumSizeChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.MaximumSizeChanged
        MessageBox.Show("You are in the WageForm_MaximumSizeChanged event.")

    End Sub

    Private Sub WageForm_MinimumSizeChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.MinimumSizeChanged
        MessageBox.Show("You are in the Form.MinimumSizeChanged event.")


    End Sub
End Class
