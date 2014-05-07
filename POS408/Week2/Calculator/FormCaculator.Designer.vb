<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
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
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btnDot = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(27, 13)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(216, 44)
        Me.txtResult.TabIndex = 0
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(27, 73)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(45, 23)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(82, 73)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(45, 23)
        Me.btn2.TabIndex = 2
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(141, 73)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(45, 23)
        Me.btn3.TabIndex = 3
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(199, 73)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(45, 23)
        Me.btn4.TabIndex = 4
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(199, 120)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(45, 23)
        Me.btn8.TabIndex = 8
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(141, 122)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(45, 23)
        Me.btn7.TabIndex = 7
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(82, 122)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(45, 23)
        Me.btn6.TabIndex = 6
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(27, 122)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(45, 23)
        Me.btn5.TabIndex = 5
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btnDot
        '
        Me.btnDot.Location = New System.Drawing.Point(141, 171)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(45, 23)
        Me.btnDot.TabIndex = 11
        Me.btnDot.Text = "."
        Me.btnDot.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(82, 171)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(45, 23)
        Me.btn0.TabIndex = 10
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(27, 171)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(45, 23)
        Me.btn9.TabIndex = 9
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(199, 220)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(45, 23)
        Me.btnDiv.TabIndex = 15
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnMulti
        '
        Me.btnMulti.Location = New System.Drawing.Point(141, 220)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(45, 23)
        Me.btnMulti.TabIndex = 14
        Me.btnMulti.Text = "x"
        Me.btnMulti.UseVisualStyleBackColor = True
        '
        'btnSub
        '
        Me.btnSub.Location = New System.Drawing.Point(82, 220)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(45, 23)
        Me.btnSub.TabIndex = 13
        Me.btnSub.Text = "-"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(27, 220)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(45, 23)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEqual
        '
        Me.btnEqual.Location = New System.Drawing.Point(27, 263)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(216, 43)
        Me.btnEqual.TabIndex = 16
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(199, 171)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(45, 23)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "CLR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 318)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEqual)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDot)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.txtResult)
        Me.MaximizeBox = False
        Me.Name = "frmCalculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btnDot As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btnDiv As System.Windows.Forms.Button
    Friend WithEvents btnMulti As System.Windows.Forms.Button
    Friend WithEvents btnSub As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEqual As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
