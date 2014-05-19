<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLottery
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
        Me.txtOne = New System.Windows.Forms.TextBox()
        Me.txtTwo = New System.Windows.Forms.TextBox()
        Me.txtThree = New System.Windows.Forms.TextBox()
        Me.txtFour = New System.Windows.Forms.TextBox()
        Me.txtFive = New System.Windows.Forms.TextBox()
        Me.txtSix = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOne
        '
        Me.txtOne.Location = New System.Drawing.Point(13, 26)
        Me.txtOne.Name = "txtOne"
        Me.txtOne.ReadOnly = True
        Me.txtOne.Size = New System.Drawing.Size(31, 20)
        Me.txtOne.TabIndex = 0
        '
        'txtTwo
        '
        Me.txtTwo.Location = New System.Drawing.Point(54, 26)
        Me.txtTwo.Name = "txtTwo"
        Me.txtTwo.ReadOnly = True
        Me.txtTwo.Size = New System.Drawing.Size(31, 20)
        Me.txtTwo.TabIndex = 1
        '
        'txtThree
        '
        Me.txtThree.Location = New System.Drawing.Point(95, 26)
        Me.txtThree.Name = "txtThree"
        Me.txtThree.ReadOnly = True
        Me.txtThree.Size = New System.Drawing.Size(31, 20)
        Me.txtThree.TabIndex = 2
        '
        'txtFour
        '
        Me.txtFour.Location = New System.Drawing.Point(136, 26)
        Me.txtFour.Name = "txtFour"
        Me.txtFour.ReadOnly = True
        Me.txtFour.Size = New System.Drawing.Size(31, 20)
        Me.txtFour.TabIndex = 3
        '
        'txtFive
        '
        Me.txtFive.Location = New System.Drawing.Point(177, 26)
        Me.txtFive.Name = "txtFive"
        Me.txtFive.ReadOnly = True
        Me.txtFive.Size = New System.Drawing.Size(31, 20)
        Me.txtFive.TabIndex = 4
        '
        'txtSix
        '
        Me.txtSix.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtSix.Location = New System.Drawing.Point(218, 26)
        Me.txtSix.Name = "txtSix"
        Me.txtSix.ReadOnly = True
        Me.txtSix.Size = New System.Drawing.Size(31, 20)
        Me.txtSix.TabIndex = 5
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(13, 69)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 43)
        Me.btnGenerate.TabIndex = 6
        Me.btnGenerate.Text = "Generate Numbers"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(174, 69)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 43)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmLottery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 124)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.txtSix)
        Me.Controls.Add(Me.txtFive)
        Me.Controls.Add(Me.txtFour)
        Me.Controls.Add(Me.txtThree)
        Me.Controls.Add(Me.txtTwo)
        Me.Controls.Add(Me.txtOne)
        Me.Name = "frmLottery"
        Me.Text = "Lottery Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOne As System.Windows.Forms.TextBox
    Friend WithEvents txtTwo As System.Windows.Forms.TextBox
    Friend WithEvents txtThree As System.Windows.Forms.TextBox
    Friend WithEvents txtFour As System.Windows.Forms.TextBox
    Friend WithEvents txtFive As System.Windows.Forms.TextBox
    Friend WithEvents txtSix As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
