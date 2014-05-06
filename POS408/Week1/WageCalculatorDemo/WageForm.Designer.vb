<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WageForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNumHours = New System.Windows.Forms.Label()
        Me.txtHoursWorked = New System.Windows.Forms.TextBox()
        Me.lblGrossPay = New System.Windows.Forms.TextBox()
        Me.lblGrossPayEarned = New System.Windows.Forms.Label()
        Me.txtPayrate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGrossPay = New System.Windows.Forms.Button()
        Me.btmClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumHours
        '
        Me.lblNumHours.AutoSize = True
        Me.lblNumHours.Location = New System.Drawing.Point(19, 37)
        Me.lblNumHours.Name = "lblNumHours"
        Me.lblNumHours.Size = New System.Drawing.Size(128, 13)
        Me.lblNumHours.TabIndex = 0
        Me.lblNumHours.Text = "Number of Hours Worked"
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.Location = New System.Drawing.Point(172, 34)
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(100, 20)
        Me.txtHoursWorked.TabIndex = 1
        '
        'lblGrossPay
        '
        Me.lblGrossPay.Location = New System.Drawing.Point(172, 117)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(100, 20)
        Me.lblGrossPay.TabIndex = 3
        '
        'lblGrossPayEarned
        '
        Me.lblGrossPayEarned.AutoSize = True
        Me.lblGrossPayEarned.Location = New System.Drawing.Point(19, 124)
        Me.lblGrossPayEarned.Name = "lblGrossPayEarned"
        Me.lblGrossPayEarned.Size = New System.Drawing.Size(128, 13)
        Me.lblGrossPayEarned.TabIndex = 2
        Me.lblGrossPayEarned.Text = "Number of Hours Worked"
        '
        'txtPayrate
        '
        Me.txtPayrate.Location = New System.Drawing.Point(172, 74)
        Me.txtPayrate.Name = "txtPayrate"
        Me.txtPayrate.Size = New System.Drawing.Size(100, 20)
        Me.txtPayrate.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hours Pay Rate"
        '
        'btnGrossPay
        '
        Me.btnGrossPay.Location = New System.Drawing.Point(22, 176)
        Me.btnGrossPay.Name = "btnGrossPay"
        Me.btnGrossPay.Size = New System.Drawing.Size(75, 51)
        Me.btnGrossPay.TabIndex = 6
        Me.btnGrossPay.Text = "Caulate Gross Pay"
        Me.btnGrossPay.UseVisualStyleBackColor = True
        '
        'btmClose
        '
        Me.btmClose.Location = New System.Drawing.Point(166, 176)
        Me.btmClose.Name = "btmClose"
        Me.btmClose.Size = New System.Drawing.Size(75, 51)
        Me.btmClose.TabIndex = 7
        Me.btmClose.Text = "Close"
        Me.btmClose.UseVisualStyleBackColor = True
        '
        'WageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btmClose)
        Me.Controls.Add(Me.btnGrossPay)
        Me.Controls.Add(Me.txtPayrate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.lblGrossPayEarned)
        Me.Controls.Add(Me.txtHoursWorked)
        Me.Controls.Add(Me.lblNumHours)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "WageForm"
        Me.Text = "Wage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumHours As System.Windows.Forms.Label
    Friend WithEvents txtHoursWorked As System.Windows.Forms.TextBox
    Friend WithEvents lblGrossPay As System.Windows.Forms.TextBox
    Friend WithEvents lblGrossPayEarned As System.Windows.Forms.Label
    Friend WithEvents txtPayrate As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGrossPay As System.Windows.Forms.Button
    Friend WithEvents btmClose As System.Windows.Forms.Button

End Class
